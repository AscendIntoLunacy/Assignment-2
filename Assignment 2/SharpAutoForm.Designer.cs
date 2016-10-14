namespace Assignment_2
{
    partial class SharpAutoForm
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
            this.BasePriceLabel = new System.Windows.Forms.Label();
            this.AdditionalOptionsLabel = new System.Windows.Forms.Label();
            this.SubtotalLabel = new System.Windows.Forms.Label();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TradeInLabel = new System.Windows.Forms.Label();
            this.AmountDueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BasePriceLabel
            // 
            this.BasePriceLabel.AutoSize = true;
            this.BasePriceLabel.Location = new System.Drawing.Point(109, 309);
            this.BasePriceLabel.Name = "BasePriceLabel";
            this.BasePriceLabel.Size = new System.Drawing.Size(160, 32);
            this.BasePriceLabel.TabIndex = 0;
            this.BasePriceLabel.Text = "Base Price:";
            // 
            // AdditionalOptionsLabel
            // 
            this.AdditionalOptionsLabel.AutoSize = true;
            this.AdditionalOptionsLabel.Location = new System.Drawing.Point(12, 367);
            this.AdditionalOptionsLabel.Name = "AdditionalOptionsLabel";
            this.AdditionalOptionsLabel.Size = new System.Drawing.Size(257, 32);
            this.AdditionalOptionsLabel.TabIndex = 1;
            this.AdditionalOptionsLabel.Text = "Additional Options:";
            // 
            // SubtotalLabel
            // 
            this.SubtotalLabel.AutoSize = true;
            this.SubtotalLabel.Location = new System.Drawing.Point(140, 425);
            this.SubtotalLabel.Name = "SubtotalLabel";
            this.SubtotalLabel.Size = new System.Drawing.Size(129, 32);
            this.SubtotalLabel.TabIndex = 2;
            this.SubtotalLabel.Text = "Subtotal:";
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Location = new System.Drawing.Point(38, 480);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(231, 32);
            this.SalesTaxLabel.TabIndex = 3;
            this.SalesTaxLabel.Text = "Sales Tax (13%):";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(182, 530);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(87, 32);
            this.TotalLabel.TabIndex = 4;
            this.TotalLabel.Text = "Total:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(254, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(526, 222);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // TradeInLabel
            // 
            this.TradeInLabel.AutoSize = true;
            this.TradeInLabel.Location = new System.Drawing.Point(2, 581);
            this.TradeInLabel.Name = "TradeInLabel";
            this.TradeInLabel.Size = new System.Drawing.Size(267, 32);
            this.TradeInLabel.TabIndex = 6;
            this.TradeInLabel.Text = "Trade-in Allowance:";
            // 
            // AmountDueLabel
            // 
            this.AmountDueLabel.AutoSize = true;
            this.AmountDueLabel.Location = new System.Drawing.Point(176, 640);
            this.AmountDueLabel.Name = "AmountDueLabel";
            this.AmountDueLabel.Size = new System.Drawing.Size(93, 32);
            this.AmountDueLabel.TabIndex = 7;
            this.AmountDueLabel.Text = "label2";
            // 
            // SharpAutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 752);
            this.Controls.Add(this.AmountDueLabel);
            this.Controls.Add(this.TradeInLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.SalesTaxLabel);
            this.Controls.Add(this.SubtotalLabel);
            this.Controls.Add(this.AdditionalOptionsLabel);
            this.Controls.Add(this.BasePriceLabel);
            this.Name = "SharpAutoForm";
            this.Text = "Auto Center";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BasePriceLabel;
        private System.Windows.Forms.Label AdditionalOptionsLabel;
        private System.Windows.Forms.Label SubtotalLabel;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TradeInLabel;
        private System.Windows.Forms.Label AmountDueLabel;
    }
}

