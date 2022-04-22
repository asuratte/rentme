
namespace RentMe.View
{
    partial class AddToCartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddToCartForm));
            this.furnitureIDLabel = new System.Windows.Forms.Label();
            this.furnitureNameLabel = new System.Windows.Forms.Label();
            this.furnitureQuantityLabel = new System.Windows.Forms.Label();
            this.furnitureQuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.furnitureIDValueLabel = new System.Windows.Forms.Label();
            this.furnitureNameValueLabel = new System.Windows.Forms.Label();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureQuantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // furnitureIDLabel
            // 
            this.furnitureIDLabel.AutoSize = true;
            this.furnitureIDLabel.Location = new System.Drawing.Point(12, 12);
            this.furnitureIDLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.furnitureIDLabel.Name = "furnitureIDLabel";
            this.furnitureIDLabel.Size = new System.Drawing.Size(86, 19);
            this.furnitureIDLabel.TabIndex = 0;
            this.furnitureIDLabel.Text = "Furniture ID:";
            // 
            // furnitureNameLabel
            // 
            this.furnitureNameLabel.AutoSize = true;
            this.furnitureNameLabel.Location = new System.Drawing.Point(12, 52);
            this.furnitureNameLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.furnitureNameLabel.Name = "furnitureNameLabel";
            this.furnitureNameLabel.Size = new System.Drawing.Size(48, 19);
            this.furnitureNameLabel.TabIndex = 0;
            this.furnitureNameLabel.Text = "Name:";
            // 
            // furnitureQuantityLabel
            // 
            this.furnitureQuantityLabel.AutoSize = true;
            this.furnitureQuantityLabel.Location = new System.Drawing.Point(179, 12);
            this.furnitureQuantityLabel.Name = "furnitureQuantityLabel";
            this.furnitureQuantityLabel.Size = new System.Drawing.Size(66, 19);
            this.furnitureQuantityLabel.TabIndex = 0;
            this.furnitureQuantityLabel.Text = "Quantity:";
            // 
            // furnitureQuantityNumericUpDown
            // 
            this.furnitureQuantityNumericUpDown.Location = new System.Drawing.Point(251, 10);
            this.furnitureQuantityNumericUpDown.Name = "furnitureQuantityNumericUpDown";
            this.furnitureQuantityNumericUpDown.Size = new System.Drawing.Size(60, 25);
            this.furnitureQuantityNumericUpDown.TabIndex = 1;
            this.furnitureQuantityNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.furnitureQuantityNumericUpDown.Enter += new System.EventHandler(this.FurnitureQuantityNumericUpDownEnter);
            // 
            // furnitureIDValueLabel
            // 
            this.furnitureIDValueLabel.Location = new System.Drawing.Point(98, 12);
            this.furnitureIDValueLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.furnitureIDValueLabel.Name = "furnitureIDValueLabel";
            this.furnitureIDValueLabel.Size = new System.Drawing.Size(75, 19);
            this.furnitureIDValueLabel.TabIndex = 0;
            // 
            // furnitureNameValueLabel
            // 
            this.furnitureNameValueLabel.Location = new System.Drawing.Point(60, 52);
            this.furnitureNameValueLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.furnitureNameValueLabel.Name = "furnitureNameValueLabel";
            this.furnitureNameValueLabel.Size = new System.Drawing.Size(249, 19);
            this.furnitureNameValueLabel.TabIndex = 0;
            // 
            // addToCartButton
            // 
            this.addToCartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.addToCartButton.FlatAppearance.BorderSize = 0;
            this.addToCartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToCartButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToCartButton.ForeColor = System.Drawing.Color.White;
            this.addToCartButton.Location = new System.Drawing.Point(16, 130);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(110, 27);
            this.addToCartButton.TabIndex = 3;
            this.addToCartButton.Text = "Add to Cart";
            this.addToCartButton.UseVisualStyleBackColor = false;
            this.addToCartButton.Click += new System.EventHandler(this.AddToCartButtonClick);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.DimGray;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(199, 130);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(110, 27);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageLabel.Location = new System.Drawing.Point(12, 88);
            this.errorMessageLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(297, 33);
            this.errorMessageLabel.TabIndex = 4;
            // 
            // AddToCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 169);
            this.Controls.Add(this.errorMessageLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.furnitureNameValueLabel);
            this.Controls.Add(this.furnitureIDValueLabel);
            this.Controls.Add(this.furnitureQuantityNumericUpDown);
            this.Controls.Add(this.furnitureQuantityLabel);
            this.Controls.Add(this.furnitureNameLabel);
            this.Controls.Add(this.furnitureIDLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddToCartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add to Cart";
            this.Load += new System.EventHandler(this.AddToCartFormOnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.furnitureQuantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label furnitureIDLabel;
        private System.Windows.Forms.Label furnitureNameLabel;
        private System.Windows.Forms.Label furnitureQuantityLabel;
        private System.Windows.Forms.NumericUpDown furnitureQuantityNumericUpDown;
        private System.Windows.Forms.Label furnitureIDValueLabel;
        private System.Windows.Forms.Label furnitureNameValueLabel;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label errorMessageLabel;
    }
}