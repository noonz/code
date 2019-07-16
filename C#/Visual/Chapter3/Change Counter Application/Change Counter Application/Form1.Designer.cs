namespace Change_Counter_Application
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
            this.fiveCentsButton = new System.Windows.Forms.Button();
            this.tenCentsButton = new System.Windows.Forms.Button();
            this.twoFiveCentsButton = new System.Windows.Forms.Button();
            this.fiftyCentButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fiveCentsButton
            // 
            this.fiveCentsButton.Location = new System.Drawing.Point(71, 76);
            this.fiveCentsButton.Name = "fiveCentsButton";
            this.fiveCentsButton.Size = new System.Drawing.Size(75, 23);
            this.fiveCentsButton.TabIndex = 0;
            this.fiveCentsButton.Text = "5 Cents";
            this.fiveCentsButton.UseVisualStyleBackColor = true;
            this.fiveCentsButton.Click += new System.EventHandler(this.fiveCentsButton_Click);
            // 
            // tenCentsButton
            // 
            this.tenCentsButton.Location = new System.Drawing.Point(172, 76);
            this.tenCentsButton.Name = "tenCentsButton";
            this.tenCentsButton.Size = new System.Drawing.Size(75, 23);
            this.tenCentsButton.TabIndex = 1;
            this.tenCentsButton.Text = "10 Cents";
            this.tenCentsButton.UseVisualStyleBackColor = true;
            this.tenCentsButton.Click += new System.EventHandler(this.tenCentsButton_Click);
            // 
            // twoFiveCentsButton
            // 
            this.twoFiveCentsButton.Location = new System.Drawing.Point(71, 105);
            this.twoFiveCentsButton.Name = "twoFiveCentsButton";
            this.twoFiveCentsButton.Size = new System.Drawing.Size(75, 23);
            this.twoFiveCentsButton.TabIndex = 2;
            this.twoFiveCentsButton.Text = "25 Cents";
            this.twoFiveCentsButton.UseVisualStyleBackColor = true;
            this.twoFiveCentsButton.Click += new System.EventHandler(this.twoFiveCentsButton_Click);
            // 
            // fiftyCentButton
            // 
            this.fiftyCentButton.Location = new System.Drawing.Point(172, 105);
            this.fiftyCentButton.Name = "fiftyCentButton";
            this.fiftyCentButton.Size = new System.Drawing.Size(75, 23);
            this.fiftyCentButton.TabIndex = 3;
            this.fiftyCentButton.Text = "50 Cents";
            this.fiftyCentButton.UseVisualStyleBackColor = true;
            this.fiftyCentButton.Click += new System.EventHandler(this.fiftyCentButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(172, 144);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Click an amount";
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(295, 81);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(31, 13);
            this.outputDescriptionLabel.TabIndex = 6;
            this.outputDescriptionLabel.Text = "Total";
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Location = new System.Drawing.Point(263, 105);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(100, 23);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(71, 144);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 193);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.fiftyCentButton);
            this.Controls.Add(this.twoFiveCentsButton);
            this.Controls.Add(this.tenCentsButton);
            this.Controls.Add(this.fiveCentsButton);
            this.Name = "Form1";
            this.Text = "Change Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fiveCentsButton;
        private System.Windows.Forms.Button tenCentsButton;
        private System.Windows.Forms.Button twoFiveCentsButton;
        private System.Windows.Forms.Button fiftyCentButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button clearButton;
    }
}

