namespace Tab_Order_Demo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.classBox = new System.Windows.Forms.TextBox();
            this.raceBox = new System.Windows.Forms.TextBox();
            this.displayButton = new System.Windows.Forms.Button();
            this.outputDisplayBox = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Class:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Race:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // classBox
            // 
            this.classBox.Location = new System.Drawing.Point(122, 96);
            this.classBox.Name = "classBox";
            this.classBox.Size = new System.Drawing.Size(100, 20);
            this.classBox.TabIndex = 1;
            // 
            // raceBox
            // 
            this.raceBox.Location = new System.Drawing.Point(122, 142);
            this.raceBox.Name = "raceBox";
            this.raceBox.Size = new System.Drawing.Size(100, 20);
            this.raceBox.TabIndex = 2;
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(12, 261);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(75, 23);
            this.displayButton.TabIndex = 4;
            this.displayButton.Text = "&Display";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // outputDisplayBox
            // 
            this.outputDisplayBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputDisplayBox.Location = new System.Drawing.Point(12, 203);
            this.outputDisplayBox.Name = "outputDisplayBox";
            this.outputDisplayBox.Size = new System.Drawing.Size(210, 23);
            this.outputDisplayBox.TabIndex = 3;
            this.outputDisplayBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(147, 261);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clea&r";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(122, 48);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(234, 311);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.outputDisplayBox);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.raceBox);
            this.Controls.Add(this.classBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tab Order Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox classBox;
        private System.Windows.Forms.TextBox raceBox;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Label outputDisplayBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox nameBox;
    }
}

