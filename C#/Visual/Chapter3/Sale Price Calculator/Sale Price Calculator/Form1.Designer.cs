namespace Sale_Price_Calculator
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.originalPrice = new System.Windows.Forms.Label();
            this.discountPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.discountPercentageTextBox = new System.Windows.Forms.TextBox();
            this.originalPriceTextBox = new System.Windows.Forms.TextBox();
            this.salePriceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(109, 160);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 41);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate Sale Price";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(208, 160);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 41);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // originalPrice
            // 
            this.originalPrice.AutoSize = true;
            this.originalPrice.Location = new System.Drawing.Point(112, 28);
            this.originalPrice.Name = "originalPrice";
            this.originalPrice.Size = new System.Drawing.Size(72, 13);
            this.originalPrice.TabIndex = 2;
            this.originalPrice.Text = "Original Price:";
            // 
            // discountPrice
            // 
            this.discountPrice.AutoSize = true;
            this.discountPrice.Location = new System.Drawing.Point(74, 66);
            this.discountPrice.Name = "discountPrice";
            this.discountPrice.Size = new System.Drawing.Size(110, 13);
            this.discountPrice.TabIndex = 3;
            this.discountPrice.Text = "Discount Percentage:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sale Price:";
            // 
            // discountPercentageTextBox
            // 
            this.discountPercentageTextBox.Location = new System.Drawing.Point(208, 63);
            this.discountPercentageTextBox.Name = "discountPercentageTextBox";
            this.discountPercentageTextBox.Size = new System.Drawing.Size(100, 20);
            this.discountPercentageTextBox.TabIndex = 5;
            // 
            // originalPriceTextBox
            // 
            this.originalPriceTextBox.Location = new System.Drawing.Point(208, 25);
            this.originalPriceTextBox.Name = "originalPriceTextBox";
            this.originalPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.originalPriceTextBox.TabIndex = 6;
            // 
            // salePriceLabel
            // 
            this.salePriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salePriceLabel.Location = new System.Drawing.Point(208, 103);
            this.salePriceLabel.Name = "salePriceLabel";
            this.salePriceLabel.Size = new System.Drawing.Size(100, 20);
            this.salePriceLabel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.salePriceLabel);
            this.Controls.Add(this.originalPriceTextBox);
            this.Controls.Add(this.discountPercentageTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.discountPrice);
            this.Controls.Add(this.originalPrice);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Name = "Form1";
            this.Text = "Sale Price Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label originalPrice;
        private System.Windows.Forms.Label discountPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox discountPercentageTextBox;
        private System.Windows.Forms.TextBox originalPriceTextBox;
        private System.Windows.Forms.Label salePriceLabel;
    }
}

