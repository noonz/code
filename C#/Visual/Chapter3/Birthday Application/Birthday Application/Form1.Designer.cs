namespace Birthday_Application
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
            this.dayOfWeek = new System.Windows.Forms.Label();
            this.nameOfMonth = new System.Windows.Forms.Label();
            this.dayOfMonth = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.dateOutputLabel = new System.Windows.Forms.Label();
            this.showDateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.nameOfMonthBox = new System.Windows.Forms.TextBox();
            this.dayOfMonthBox = new System.Windows.Forms.TextBox();
            this.dayOfWeekBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dayOfWeek
            // 
            this.dayOfWeek.AutoSize = true;
            this.dayOfWeek.Location = new System.Drawing.Point(24, 21);
            this.dayOfWeek.Name = "dayOfWeek";
            this.dayOfWeek.Size = new System.Drawing.Size(91, 13);
            this.dayOfWeek.TabIndex = 0;
            this.dayOfWeek.Text = "Day of the Week:";
            // 
            // nameOfMonth
            // 
            this.nameOfMonth.AutoSize = true;
            this.nameOfMonth.Location = new System.Drawing.Point(24, 53);
            this.nameOfMonth.Name = "nameOfMonth";
            this.nameOfMonth.Size = new System.Drawing.Size(101, 13);
            this.nameOfMonth.TabIndex = 1;
            this.nameOfMonth.Text = "Name of the Month:";
            // 
            // dayOfMonth
            // 
            this.dayOfMonth.AllowDrop = true;
            this.dayOfMonth.AutoSize = true;
            this.dayOfMonth.Location = new System.Drawing.Point(24, 87);
            this.dayOfMonth.Name = "dayOfMonth";
            this.dayOfMonth.Size = new System.Drawing.Size(74, 13);
            this.dayOfMonth.TabIndex = 2;
            this.dayOfMonth.Text = "Day of Month:";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(24, 118);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(32, 13);
            this.yearLabel.TabIndex = 3;
            this.yearLabel.Text = "Year:";
            this.yearLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // dateOutputLabel
            // 
            this.dateOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateOutputLabel.Location = new System.Drawing.Point(37, 148);
            this.dateOutputLabel.Name = "dateOutputLabel";
            this.dateOutputLabel.Size = new System.Drawing.Size(225, 23);
            this.dateOutputLabel.TabIndex = 4;
            this.dateOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showDateButton
            // 
            this.showDateButton.Location = new System.Drawing.Point(12, 183);
            this.showDateButton.Name = "showDateButton";
            this.showDateButton.Size = new System.Drawing.Size(75, 23);
            this.showDateButton.TabIndex = 5;
            this.showDateButton.Text = "Show Date";
            this.showDateButton.UseVisualStyleBackColor = true;
            this.showDateButton.Click += new System.EventHandler(this.showDateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(106, 183);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(197, 183);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // yearBox
            // 
            this.yearBox.Location = new System.Drawing.Point(140, 115);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(100, 20);
            this.yearBox.TabIndex = 8;
            // 
            // nameOfMonthBox
            // 
            this.nameOfMonthBox.Location = new System.Drawing.Point(140, 50);
            this.nameOfMonthBox.Name = "nameOfMonthBox";
            this.nameOfMonthBox.Size = new System.Drawing.Size(100, 20);
            this.nameOfMonthBox.TabIndex = 9;
            // 
            // dayOfMonthBox
            // 
            this.dayOfMonthBox.Location = new System.Drawing.Point(140, 84);
            this.dayOfMonthBox.Name = "dayOfMonthBox";
            this.dayOfMonthBox.Size = new System.Drawing.Size(100, 20);
            this.dayOfMonthBox.TabIndex = 10;
            // 
            // dayOfWeekBox
            // 
            this.dayOfWeekBox.Location = new System.Drawing.Point(140, 18);
            this.dayOfWeekBox.Name = "dayOfWeekBox";
            this.dayOfWeekBox.Size = new System.Drawing.Size(100, 20);
            this.dayOfWeekBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 228);
            this.Controls.Add(this.dayOfWeekBox);
            this.Controls.Add(this.dayOfMonthBox);
            this.Controls.Add(this.nameOfMonthBox);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.showDateButton);
            this.Controls.Add(this.dateOutputLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.dayOfMonth);
            this.Controls.Add(this.nameOfMonth);
            this.Controls.Add(this.dayOfWeek);
            this.Name = "Form1";
            this.Text = "Birthday App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dayOfWeek;
        private System.Windows.Forms.Label nameOfMonth;
        private System.Windows.Forms.Label dayOfMonth;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label dateOutputLabel;
        private System.Windows.Forms.Button showDateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.TextBox nameOfMonthBox;
        private System.Windows.Forms.TextBox dayOfMonthBox;
        private System.Windows.Forms.TextBox dayOfWeekBox;
    }
}

