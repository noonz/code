namespace LanguageTranslator
{
    partial class languageTranslator
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
            this.italian = new System.Windows.Forms.Button();
            this.spanish = new System.Windows.Forms.Button();
            this.german = new System.Windows.Forms.Button();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.translationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // italian
            // 
            this.italian.Location = new System.Drawing.Point(25, 188);
            this.italian.Name = "italian";
            this.italian.Size = new System.Drawing.Size(75, 23);
            this.italian.TabIndex = 0;
            this.italian.Text = "Italian";
            this.italian.UseVisualStyleBackColor = true;
            this.italian.Click += new System.EventHandler(this.italian_Click);
            // 
            // spanish
            // 
            this.spanish.Location = new System.Drawing.Point(145, 188);
            this.spanish.Name = "spanish";
            this.spanish.Size = new System.Drawing.Size(75, 23);
            this.spanish.TabIndex = 1;
            this.spanish.Text = "Spanish";
            this.spanish.UseVisualStyleBackColor = true;
            this.spanish.Click += new System.EventHandler(this.spanish_Click);
            // 
            // german
            // 
            this.german.Location = new System.Drawing.Point(266, 188);
            this.german.Name = "german";
            this.german.Size = new System.Drawing.Size(75, 23);
            this.german.TabIndex = 2;
            this.german.Text = "German";
            this.german.UseVisualStyleBackColor = true;
            this.german.Click += new System.EventHandler(this.german_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(70, 25);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(229, 13);
            this.instructionLabel.TabIndex = 3;
            this.instructionLabel.Text = "Select a language and I will say Good Morning.";
            // 
            // translationLabel
            // 
            this.translationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.translationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translationLabel.Location = new System.Drawing.Point(58, 94);
            this.translationLabel.Name = "translationLabel";
            this.translationLabel.Size = new System.Drawing.Size(250, 25);
            this.translationLabel.TabIndex = 4;
            this.translationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // languageTranslator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 261);
            this.Controls.Add(this.translationLabel);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.german);
            this.Controls.Add(this.spanish);
            this.Controls.Add(this.italian);
            this.Name = "languageTranslator";
            this.Text = "Language Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button italian;
        private System.Windows.Forms.Button spanish;
        private System.Windows.Forms.Button german;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label translationLabel;
    }
}

