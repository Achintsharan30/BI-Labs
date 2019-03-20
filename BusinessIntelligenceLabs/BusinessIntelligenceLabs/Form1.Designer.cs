namespace BusinessIntelligenceLabs
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonGetDate = new System.Windows.Forms.Button();
            this.listBoxDates = new System.Windows.Forms.ListBox();
            this.btnGetDateSource = new System.Windows.Forms.Button();
            this.listBoxDate = new System.Windows.Forms.ListBox();
            this.btnGetDateDimension = new System.Windows.Forms.Button();
            this.listBoxDatesDimension = new System.Windows.Forms.ListBox();
            this.btnBuildFactTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(644, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(644, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(644, 165);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // buttonGetDate
            // 
            this.buttonGetDate.Location = new System.Drawing.Point(644, 205);
            this.buttonGetDate.Name = "buttonGetDate";
            this.buttonGetDate.Size = new System.Drawing.Size(75, 23);
            this.buttonGetDate.TabIndex = 3;
            this.buttonGetDate.Text = "Gets Dates";
            this.buttonGetDate.UseVisualStyleBackColor = true;
            this.buttonGetDate.Click += new System.EventHandler(this.buttonGetDate_Click);
            // 
            // listBoxDates
            // 
            this.listBoxDates.FormattingEnabled = true;
            this.listBoxDates.Location = new System.Drawing.Point(644, 271);
            this.listBoxDates.Name = "listBoxDates";
            this.listBoxDates.Size = new System.Drawing.Size(120, 95);
            this.listBoxDates.TabIndex = 4;
            // 
            // btnGetDateSource
            // 
            this.btnGetDateSource.Location = new System.Drawing.Point(36, 165);
            this.btnGetDateSource.Name = "btnGetDateSource";
            this.btnGetDateSource.Size = new System.Drawing.Size(138, 39);
            this.btnGetDateSource.TabIndex = 5;
            this.btnGetDateSource.Text = "Get Dates from Source";
            this.btnGetDateSource.UseVisualStyleBackColor = true;
            // 
            // listBoxDate
            // 
            this.listBoxDate.FormattingEnabled = true;
            this.listBoxDate.Location = new System.Drawing.Point(36, 222);
            this.listBoxDate.Name = "listBoxDate";
            this.listBoxDate.Size = new System.Drawing.Size(138, 95);
            this.listBoxDate.TabIndex = 6;
            // 
            // btnGetDateDimension
            // 
            this.btnGetDateDimension.Location = new System.Drawing.Point(213, 163);
            this.btnGetDateDimension.Name = "btnGetDateDimension";
            this.btnGetDateDimension.Size = new System.Drawing.Size(149, 41);
            this.btnGetDateDimension.TabIndex = 8;
            this.btnGetDateDimension.Text = "Get Dates from Dimension";
            this.btnGetDateDimension.UseVisualStyleBackColor = true;
            this.btnGetDateDimension.Click += new System.EventHandler(this.btnGetDateDimension_Click);
            // 
            // listBoxDatesDimension
            // 
            this.listBoxDatesDimension.FormattingEnabled = true;
            this.listBoxDatesDimension.HorizontalScrollbar = true;
            this.listBoxDatesDimension.Location = new System.Drawing.Point(213, 222);
            this.listBoxDatesDimension.Name = "listBoxDatesDimension";
            this.listBoxDatesDimension.Size = new System.Drawing.Size(149, 95);
            this.listBoxDatesDimension.TabIndex = 9;
            
            // 
            // btnBuildFactTable
            // 
            this.btnBuildFactTable.Location = new System.Drawing.Point(392, 165);
            this.btnBuildFactTable.Name = "btnBuildFactTable";
            this.btnBuildFactTable.Size = new System.Drawing.Size(106, 39);
            this.btnBuildFactTable.TabIndex = 10;
            this.btnBuildFactTable.Text = "Build Fact Table";
            this.btnBuildFactTable.UseVisualStyleBackColor = true;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuildFactTable);
            this.Controls.Add(this.listBoxDatesDimension);
            this.Controls.Add(this.btnGetDateDimension);
            this.Controls.Add(this.listBoxDate);
            this.Controls.Add(this.btnGetDateSource);
            this.Controls.Add(this.listBoxDates);
            this.Controls.Add(this.buttonGetDate);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonGetDate;
        private System.Windows.Forms.ListBox listBoxDates;
        private System.Windows.Forms.Button btnGetDateSource;
        private System.Windows.Forms.ListBox listBoxDate;
        private System.Windows.Forms.Button btnGetDateDimension;
        private System.Windows.Forms.ListBox listBoxDatesDimension;
        private System.Windows.Forms.Button btnBuildFactTable;
    }
}

