namespace TipTaxTotal
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
            this.exitButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.foodLabel = new System.Windows.Forms.Label();
            this.tipLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.tipBox = new System.Windows.Forms.Label();
            this.taxBox = new System.Windows.Forms.Label();
            this.totalBox = new System.Windows.Forms.Label();
            this.foodTotalBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(243, 271);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(160, 216);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(324, 216);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // foodLabel
            // 
            this.foodLabel.AutoSize = true;
            this.foodLabel.Location = new System.Drawing.Point(174, 32);
            this.foodLabel.Name = "foodLabel";
            this.foodLabel.Size = new System.Drawing.Size(61, 13);
            this.foodLabel.TabIndex = 3;
            this.foodLabel.Text = "Food Total:";
            // 
            // tipLabel
            // 
            this.tipLabel.AutoSize = true;
            this.tipLabel.Location = new System.Drawing.Point(181, 74);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.Size = new System.Drawing.Size(54, 13);
            this.tipLabel.TabIndex = 4;
            this.tipLabel.Text = "Tip (15%):";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(184, 115);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(51, 13);
            this.taxLabel.TabIndex = 5;
            this.taxLabel.Text = "Tax (7%):";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(201, 164);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(34, 13);
            this.totalLabel.TabIndex = 6;
            this.totalLabel.Text = "Total:";
            // 
            // tipBox
            // 
            this.tipBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tipBox.Location = new System.Drawing.Point(324, 74);
            this.tipBox.Name = "tipBox";
            this.tipBox.Size = new System.Drawing.Size(100, 23);
            this.tipBox.TabIndex = 7;
            this.tipBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxBox
            // 
            this.taxBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxBox.Location = new System.Drawing.Point(324, 115);
            this.taxBox.Name = "taxBox";
            this.taxBox.Size = new System.Drawing.Size(100, 23);
            this.taxBox.TabIndex = 8;
            this.taxBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalBox
            // 
            this.totalBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalBox.Location = new System.Drawing.Point(324, 164);
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(100, 23);
            this.totalBox.TabIndex = 9;
            this.totalBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // foodTotalBox
            // 
            this.foodTotalBox.Location = new System.Drawing.Point(324, 29);
            this.foodTotalBox.Name = "foodTotalBox";
            this.foodTotalBox.Size = new System.Drawing.Size(100, 20);
            this.foodTotalBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 319);
            this.Controls.Add(this.foodTotalBox);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.taxBox);
            this.Controls.Add(this.tipBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.tipLabel);
            this.Controls.Add(this.foodLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.exitButton);
            this.Name = "Form1";
            this.Text = "TipTaxTotal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label foodLabel;
        private System.Windows.Forms.Label tipLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label tipBox;
        private System.Windows.Forms.Label taxBox;
        private System.Windows.Forms.Label totalBox;
        private System.Windows.Forms.TextBox foodTotalBox;
    }
}

