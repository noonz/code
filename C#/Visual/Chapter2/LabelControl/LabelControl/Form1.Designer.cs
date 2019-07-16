namespace LabelControl
{
    partial class grossPay
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
            this.hoursWorked = new System.Windows.Forms.Label();
            this.hourlyPay = new System.Windows.Forms.Label();
            this.calculatePay = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hoursWorked
            // 
            this.hoursWorked.AutoSize = true;
            this.hoursWorked.Location = new System.Drawing.Point(12, 24);
            this.hoursWorked.Name = "hoursWorked";
            this.hoursWorked.Size = new System.Drawing.Size(128, 13);
            this.hoursWorked.TabIndex = 0;
            this.hoursWorked.Text = "Number of Hours Worked";
            // 
            // hourlyPay
            // 
            this.hourlyPay.AutoSize = true;
            this.hourlyPay.Location = new System.Drawing.Point(56, 55);
            this.hourlyPay.Name = "hourlyPay";
            this.hourlyPay.Size = new System.Drawing.Size(84, 13);
            this.hourlyPay.TabIndex = 1;
            this.hourlyPay.Text = "Hourly Pay Rate";
            // 
            // calculatePay
            // 
            this.calculatePay.Location = new System.Drawing.Point(59, 104);
            this.calculatePay.Name = "calculatePay";
            this.calculatePay.Size = new System.Drawing.Size(75, 34);
            this.calculatePay.TabIndex = 2;
            this.calculatePay.Text = "Calculate Pay";
            this.calculatePay.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(169, 104);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 34);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // grossPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.calculatePay);
            this.Controls.Add(this.hourlyPay);
            this.Controls.Add(this.hoursWorked);
            this.Name = "grossPay";
            this.Text = "Gross Pay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hoursWorked;
        private System.Windows.Forms.Label hourlyPay;
        private System.Windows.Forms.Button calculatePay;
        private System.Windows.Forms.Button exit;
    }
}

