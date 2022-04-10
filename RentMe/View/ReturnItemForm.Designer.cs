
namespace RentMe.View
{
    partial class ReturnItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnItemForm));
            this.furnitureIDLabel = new System.Windows.Forms.Label();
            this.furnitureIDValue = new System.Windows.Forms.Label();
            this.rentalTransactionIDValue = new System.Windows.Forms.Label();
            this.rentalTransactionIDLabel = new System.Windows.Forms.Label();
            this.returnDateValue = new System.Windows.Forms.Label();
            this.returnDateLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.calculateCostButton = new System.Windows.Forms.Button();
            this.itemTotalTextBox = new System.Windows.Forms.TextBox();
            this.itemTotalLabel = new System.Windows.Forms.Label();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.returnItemButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // furnitureIDLabel
            // 
            this.furnitureIDLabel.AutoSize = true;
            this.furnitureIDLabel.Location = new System.Drawing.Point(12, 18);
            this.furnitureIDLabel.Name = "furnitureIDLabel";
            this.furnitureIDLabel.Size = new System.Drawing.Size(86, 19);
            this.furnitureIDLabel.TabIndex = 0;
            this.furnitureIDLabel.Text = "Furniture ID:";
            // 
            // furnitureIDValue
            // 
            this.furnitureIDValue.AutoSize = true;
            this.furnitureIDValue.Location = new System.Drawing.Point(104, 18);
            this.furnitureIDValue.Name = "furnitureIDValue";
            this.furnitureIDValue.Size = new System.Drawing.Size(0, 19);
            this.furnitureIDValue.TabIndex = 1;
            // 
            // rentalTransactionIDValue
            // 
            this.rentalTransactionIDValue.AutoSize = true;
            this.rentalTransactionIDValue.Location = new System.Drawing.Point(160, 50);
            this.rentalTransactionIDValue.Name = "rentalTransactionIDValue";
            this.rentalTransactionIDValue.Size = new System.Drawing.Size(0, 19);
            this.rentalTransactionIDValue.TabIndex = 3;
            // 
            // rentalTransactionIDLabel
            // 
            this.rentalTransactionIDLabel.AutoSize = true;
            this.rentalTransactionIDLabel.Location = new System.Drawing.Point(12, 50);
            this.rentalTransactionIDLabel.Name = "rentalTransactionIDLabel";
            this.rentalTransactionIDLabel.Size = new System.Drawing.Size(141, 19);
            this.rentalTransactionIDLabel.TabIndex = 0;
            this.rentalTransactionIDLabel.Text = "Rental Transaction ID:";
            // 
            // returnDateValue
            // 
            this.returnDateValue.AutoSize = true;
            this.returnDateValue.Location = new System.Drawing.Point(429, 18);
            this.returnDateValue.Name = "returnDateValue";
            this.returnDateValue.Size = new System.Drawing.Size(0, 19);
            this.returnDateValue.TabIndex = 5;
            // 
            // returnDateLabel
            // 
            this.returnDateLabel.AutoSize = true;
            this.returnDateLabel.Location = new System.Drawing.Point(337, 18);
            this.returnDateLabel.Name = "returnDateLabel";
            this.returnDateLabel.Size = new System.Drawing.Size(86, 19);
            this.returnDateLabel.TabIndex = 0;
            this.returnDateLabel.Text = "Return Date:";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(337, 50);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(66, 19);
            this.quantityLabel.TabIndex = 0;
            this.quantityLabel.Text = "Quantity:";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(409, 47);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 25);
            this.quantityTextBox.TabIndex = 1;
            this.quantityTextBox.TextChanged += new System.EventHandler(this.OnQuantityChanged);
            // 
            // calculateCostButton
            // 
            this.calculateCostButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.calculateCostButton.FlatAppearance.BorderSize = 0;
            this.calculateCostButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateCostButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateCostButton.ForeColor = System.Drawing.Color.White;
            this.calculateCostButton.Location = new System.Drawing.Point(16, 103);
            this.calculateCostButton.Name = "calculateCostButton";
            this.calculateCostButton.Size = new System.Drawing.Size(125, 27);
            this.calculateCostButton.TabIndex = 2;
            this.calculateCostButton.Text = "Calculate Cost";
            this.calculateCostButton.UseVisualStyleBackColor = false;
            this.calculateCostButton.Click += new System.EventHandler(this.CalculateCostButtonClick);
            // 
            // itemTotalTextBox
            // 
            this.itemTotalTextBox.Location = new System.Drawing.Point(94, 154);
            this.itemTotalTextBox.Name = "itemTotalTextBox";
            this.itemTotalTextBox.ReadOnly = true;
            this.itemTotalTextBox.Size = new System.Drawing.Size(133, 25);
            this.itemTotalTextBox.TabIndex = 0;
            this.itemTotalTextBox.TabStop = false;
            // 
            // itemTotalLabel
            // 
            this.itemTotalLabel.AutoSize = true;
            this.itemTotalLabel.Location = new System.Drawing.Point(14, 157);
            this.itemTotalLabel.Name = "itemTotalLabel";
            this.itemTotalLabel.Size = new System.Drawing.Size(73, 19);
            this.itemTotalLabel.TabIndex = 0;
            this.itemTotalLabel.Text = "Item Total:";
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageLabel.Location = new System.Drawing.Point(14, 200);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(496, 46);
            this.errorMessageLabel.TabIndex = 17;
            // 
            // returnItemButton
            // 
            this.returnItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.returnItemButton.FlatAppearance.BorderSize = 0;
            this.returnItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnItemButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnItemButton.ForeColor = System.Drawing.Color.White;
            this.returnItemButton.Location = new System.Drawing.Point(279, 253);
            this.returnItemButton.Name = "returnItemButton";
            this.returnItemButton.Size = new System.Drawing.Size(124, 27);
            this.returnItemButton.TabIndex = 4;
            this.returnItemButton.Text = "Return Item";
            this.returnItemButton.UseVisualStyleBackColor = false;
            this.returnItemButton.Click += new System.EventHandler(this.OnReturnItemButtonClick);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.DimGray;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(427, 253);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(83, 27);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonOnClick);
            // 
            // ReturnItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 292);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.returnItemButton);
            this.Controls.Add(this.errorMessageLabel);
            this.Controls.Add(this.itemTotalTextBox);
            this.Controls.Add(this.itemTotalLabel);
            this.Controls.Add(this.calculateCostButton);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.returnDateValue);
            this.Controls.Add(this.returnDateLabel);
            this.Controls.Add(this.rentalTransactionIDValue);
            this.Controls.Add(this.rentalTransactionIDLabel);
            this.Controls.Add(this.furnitureIDValue);
            this.Controls.Add(this.furnitureIDLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReturnItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return Item";
            this.Load += new System.EventHandler(this.OnReturnItemFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label furnitureIDLabel;
        private System.Windows.Forms.Label furnitureIDValue;
        private System.Windows.Forms.Label rentalTransactionIDValue;
        private System.Windows.Forms.Label rentalTransactionIDLabel;
        private System.Windows.Forms.Label returnDateValue;
        private System.Windows.Forms.Label returnDateLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Button calculateCostButton;
        private System.Windows.Forms.TextBox itemTotalTextBox;
        private System.Windows.Forms.Label itemTotalLabel;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.Button returnItemButton;
        private System.Windows.Forms.Button cancelButton;
    }
}