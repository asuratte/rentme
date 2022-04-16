
namespace RentMe.View
{
    partial class ViewTransactionDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTransactionDetailsForm));
            this.totalLabel = new System.Windows.Forms.Label();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.transactionNumberLabel = new System.Windows.Forms.Label();
            this.transactionNumberValue = new System.Windows.Forms.Label();
            this.employeeNameValue = new System.Windows.Forms.Label();
            this.totalValue = new System.Windows.Forms.Label();
            this.dateValue = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(10, 65);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(41, 19);
            this.totalLabel.TabIndex = 11;
            this.totalLabel.Text = "Total:";
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Location = new System.Drawing.Point(10, 39);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(74, 19);
            this.employeeNameLabel.TabIndex = 10;
            this.employeeNameLabel.Text = "Helped By:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(10, 89);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(41, 19);
            this.dateLabel.TabIndex = 9;
            this.dateLabel.Text = "Date:";
            // 
            // transactionNumberLabel
            // 
            this.transactionNumberLabel.AutoSize = true;
            this.transactionNumberLabel.Location = new System.Drawing.Point(10, 15);
            this.transactionNumberLabel.Name = "transactionNumberLabel";
            this.transactionNumberLabel.Size = new System.Drawing.Size(90, 19);
            this.transactionNumberLabel.TabIndex = 12;
            this.transactionNumberLabel.Text = "Transaction #";
            // 
            // transactionNumberValue
            // 
            this.transactionNumberValue.AutoSize = true;
            this.transactionNumberValue.Location = new System.Drawing.Point(97, 15);
            this.transactionNumberValue.Name = "transactionNumberValue";
            this.transactionNumberValue.Size = new System.Drawing.Size(0, 19);
            this.transactionNumberValue.TabIndex = 13;
            // 
            // employeeNameValue
            // 
            this.employeeNameValue.AutoSize = true;
            this.employeeNameValue.Location = new System.Drawing.Point(90, 39);
            this.employeeNameValue.Name = "employeeNameValue";
            this.employeeNameValue.Size = new System.Drawing.Size(0, 19);
            this.employeeNameValue.TabIndex = 14;
            // 
            // totalValue
            // 
            this.totalValue.AutoSize = true;
            this.totalValue.Location = new System.Drawing.Point(57, 65);
            this.totalValue.Name = "totalValue";
            this.totalValue.Size = new System.Drawing.Size(0, 19);
            this.totalValue.TabIndex = 15;
            // 
            // dateValue
            // 
            this.dateValue.AutoSize = true;
            this.dateValue.Location = new System.Drawing.Point(57, 89);
            this.dateValue.Name = "dateValue";
            this.dateValue.Size = new System.Drawing.Size(0, 19);
            this.dateValue.TabIndex = 16;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.DimGray;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(461, 397);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(83, 27);
            this.closeButton.TabIndex = 17;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButtonOnClick);
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageLabel.Location = new System.Drawing.Point(12, 382);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(429, 45);
            this.errorMessageLabel.TabIndex = 18;
            // 
            // ViewTransactionDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 436);
            this.Controls.Add(this.errorMessageLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.dateValue);
            this.Controls.Add(this.totalValue);
            this.Controls.Add(this.employeeNameValue);
            this.Controls.Add(this.transactionNumberValue);
            this.Controls.Add(this.transactionNumberLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.employeeNameLabel);
            this.Controls.Add(this.dateLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewTransactionDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Transaction Details";
            this.Load += new System.EventHandler(this.ViewTransactionDetailsFormOnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label transactionNumberLabel;
        private System.Windows.Forms.Label transactionNumberValue;
        private System.Windows.Forms.Label employeeNameValue;
        private System.Windows.Forms.Label totalValue;
        private System.Windows.Forms.Label dateValue;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label errorMessageLabel;
    }
}