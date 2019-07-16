namespace Exercise1
{
    partial class latinTranslator
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
            this.sinister = new System.Windows.Forms.Button();
            this.dexter = new System.Windows.Forms.Button();
            this.medium = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.translatorBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sinister
            // 
            this.sinister.Location = new System.Drawing.Point(23, 160);
            this.sinister.Name = "sinister";
            this.sinister.Size = new System.Drawing.Size(75, 23);
            this.sinister.TabIndex = 0;
            this.sinister.Text = "Sinister";
            this.sinister.UseVisualStyleBackColor = true;
            this.sinister.Click += new System.EventHandler(this.sinister_Click);
            // 
            // dexter
            // 
            this.dexter.Location = new System.Drawing.Point(272, 160);
            this.dexter.Name = "dexter";
            this.dexter.Size = new System.Drawing.Size(75, 23);
            this.dexter.TabIndex = 1;
            this.dexter.Text = "Dexter";
            this.dexter.UseVisualStyleBackColor = true;
            this.dexter.Click += new System.EventHandler(this.dexter_Click);
            // 
            // medium
            // 
            this.medium.Location = new System.Drawing.Point(150, 160);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(75, 23);
            this.medium.TabIndex = 2;
            this.medium.Text = "Medium";
            this.medium.UseVisualStyleBackColor = true;
            this.medium.Click += new System.EventHandler(this.medium_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Click a Latin word for English translation";
            // 
            // translatorBox
            // 
            this.translatorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.translatorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translatorBox.Location = new System.Drawing.Point(33, 82);
            this.translatorBox.Name = "translatorBox";
            this.translatorBox.Size = new System.Drawing.Size(300, 25);
            this.translatorBox.TabIndex = 4;
            this.translatorBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // latinTranslator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.translatorBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.medium);
            this.Controls.Add(this.dexter);
            this.Controls.Add(this.sinister);
            this.Name = "latinTranslator";
            this.Text = "Latin Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sinister;
        private System.Windows.Forms.Button dexter;
        private System.Windows.Forms.Button medium;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label translatorBox;
    }
}

