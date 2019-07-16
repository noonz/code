namespace Field_Demo
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
            this.showNameButton = new System.Windows.Forms.Button();
            this.daveButton = new System.Windows.Forms.Button();
            this.noonzButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showNameButton
            // 
            this.showNameButton.Location = new System.Drawing.Point(100, 26);
            this.showNameButton.Name = "showNameButton";
            this.showNameButton.Size = new System.Drawing.Size(75, 54);
            this.showNameButton.TabIndex = 0;
            this.showNameButton.Text = "Show Name";
            this.showNameButton.UseVisualStyleBackColor = true;
            this.showNameButton.Click += new System.EventHandler(this.showNameButton_Click);
            // 
            // daveButton
            // 
            this.daveButton.Location = new System.Drawing.Point(37, 98);
            this.daveButton.Name = "daveButton";
            this.daveButton.Size = new System.Drawing.Size(75, 51);
            this.daveButton.TabIndex = 1;
            this.daveButton.Text = "Change name to Dave";
            this.daveButton.UseVisualStyleBackColor = true;
            this.daveButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // noonzButton
            // 
            this.noonzButton.Location = new System.Drawing.Point(165, 98);
            this.noonzButton.Name = "noonzButton";
            this.noonzButton.Size = new System.Drawing.Size(75, 51);
            this.noonzButton.TabIndex = 2;
            this.noonzButton.Text = "Change name to Noonz";
            this.noonzButton.UseVisualStyleBackColor = true;
            this.noonzButton.Click += new System.EventHandler(this.noonzButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.noonzButton);
            this.Controls.Add(this.daveButton);
            this.Controls.Add(this.showNameButton);
            this.Name = "Form1";
            this.Text = "Field Form Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showNameButton;
        private System.Windows.Forms.Button daveButton;
        private System.Windows.Forms.Button noonzButton;
    }
}

