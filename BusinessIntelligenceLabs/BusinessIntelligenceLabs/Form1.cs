using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessIntelligenceLabs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int GetDatesId(string date)
        {
            //Split the date down and assign it to variable for later use
            string[] arrayDate = date.Split('/');

            Int32 Year = Convert.ToInt32(arrayDate[2]);
            Int32 Month = Convert.ToInt32(arrayDate[1]);
            Int32 Day = Convert.ToInt32(arrayDate[0]);

            DateTime myDate = new DateTime(Year, Month, Day);
            string dDate = myDate.ToString("M/dd/yyyy");
            //create a connection to MDF file
            String connectionStringDestination = Properties.Settings.Default.DestinationDatabase_1_ConnectionString;
            using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
            {
                //open SQL connection 
                myConnection.Open();

                //check if the data is already exists in the database - we dont need to duplicates 
                SqlCommand command = new SqlCommand("SELECT id FROM Time Where date = @date", myConnection);
                command.Parameters.Add(new SqlParameter("date", date));


                //create a variable and assign it false 
                Boolean exists = false;

                // run the command and read the results 
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //if there are rows it means the data exists, so updtaes the var!
                    if (reader.HasRows)
                    {
                        exists = true;
                        return Convert.ToInt32(reader["id"]);
                    }
                }
               
          
            }
                    return 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitDates(string rawDate)
        {
            //Split the date down and assign it to variable for later use
            string[] arrayDate = rawDate.Split('/');

            Int32 Year = Convert.ToInt32(arrayDate[2]);
            Int32 Month = Convert.ToInt32(arrayDate[1]);
            Int32 Day = Convert.ToInt32(arrayDate[0]);

            DateTime myDate = new DateTime(Year, Month, Day);
            Console.WriteLine("Day of week:" + myDate.DayOfWeek);

            String dayOfweek = myDate.DayOfWeek.ToString();
            Int32 dayOfYear = myDate.DayOfYear;
            String monthName = myDate.ToString("MMMM");
            Int32 weekNumber = dayOfYear / 7;
            Boolean weekend = false;
            if (dayOfweek == "Saturday" || dayOfweek == "Sunday") weekend = true;

        }
  
        // convert this database friendly format 
        string dbDate = myDate.ToString("M/dd/yyyy");

        private void insertTimeDimension(string date, string dayName, Int32 dayNumber, string monthName, Int32 monthNumber, Int32 weekNumber, Int32 year, Boolean weekend, Int32 dayOfYear)
        {
            //create a connection to MDF file
            String connectionStringDestination = Properties.Settings.Default.DestinationDatabase_1_ConnectionString;
            using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
            {
                //open SQL connection 
                myConnection.Open();

                //check if the data is already exists in the database - we dont need to duplicates 
                SqlCommand command = new SqlCommand("SELECT id FROM Time Where date = @date", myConnection);
                command.Parameters.Add(new SqlParameter("date", date));
          

                //create a variable and assign it false 
                Boolean exists = false; 

                // run the command and read the results 
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //if there are rows it means the data exists, so updtaes the var!
                    if (reader.HasRows) exists = true;
                   
                }
                if (exists == false)
                {
                    SqlCommand insertCommand = new SqlCommand(
                        "INSERT INTO TIME (dayName, dayNumber, monthName, monthNumber, weekNumber, year, weekend, date, dayOfYear)" + "VALUES (@dayName, @dayNumber, @monthName, @monthNumber, @year, @weekend, @date, @dateOfYear)", myConnection);
                    insertCommand.Parameters.Add(new SqlParameter("dayName", dayName));
                    insertCommand.Parameters.Add(new SqlParameter("dayNumber", dayNumber));
                    insertCommand.Parameters.Add(new SqlParameter("monthName", monthNumber));
                    insertCommand.Parameters.Add(new SqlParameter("monthNumber",monthNumber));
                    insertCommand.Parameters.Add(new SqlParameter("weekNumber", weekNumber));
                    insertCommand.Parameters.Add(new SqlParameter("year", year));
                    insertCommand.Parameters.Add(new SqlParameter("weekend", weekend));
                    insertCommand.Parameters.Add(new SqlParameter("date", date));
                    insertCommand.Parameters.Add(new SqlParameter("dayOfYear", dayOfYear));
                    // insert the line 
                    int recordsAffected = insertCommand.ExecuteNonQuery();
                    Console.WriteLine("Records affected: + records affected");
                }
        

            }
        }




        private void buttonGetDate_Click(object sender, EventArgs e)
        {
            //create a list to store my  data in 
            List<string> Dates = new List<string>();
            //clear the list box to ensure no old data is in there.
            listBoxDates.Items.Clear();

            //create a database string
            string connectionString = Properties.Settings.Default.Data_set_1_1_ConnectionString;
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand getDates = new OleDbCommand("SELECT [Order Date], [Ship Date], [Ship Date] from Sheet1", connection);

                reader = getDates.ExecuteReader();
                while (reader.Read())
                {
                    Dates.Add(reader[0].ToString());
                    Dates.Add(reader[1].ToString());
                }
            }
            List<string> DatesFormatted = new List<string>();
            foreach(string date in Dates)
            {
                var dates =  date.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                DatesFormatted.Add(dates[0]);
            }

            //Bind the listbox to the list.
            listBoxDates.DataSource = DatesFormatted;

            //split the date and insert every dates in the list 
            foreach(string date in DatesFormatted)
            {
                splitDates(date);
            }
            splitDates(DatesFormatted[0]);

         


            string fullDate = DatesFormatted[0].ToString();
            string[] arrayDate1 = fullDate.Split('/');
            Console.WriteLine("Day:" + arrayDate1[0] + "Month:" + arrayDate1[1] + "Year:" + arrayDate1[2]);
        }
}
    }
