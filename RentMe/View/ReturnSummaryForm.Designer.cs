
namespace RentMe.View
{
    partial class ReturnSummaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnSummaryForm));
            this.transactionNumberLabel = new System.Windows.Forms.Label();
            this.memberNameLabel = new System.Windows.Forms.Label();
            this.memberNameValue = new System.Windows.Forms.Label();
            this.dateValue = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.employeeNameValue = new System.Windows.Forms.Label();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.totalValue = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // transactionNumberLabel
            // 
            this.transactionNumberLabel.AutoSize = true;
            this.transactionNumberLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionNumberLabel.Location = new System.Drawing.Point(11, 12);
            this.transactionNumberLabel.Name = "transactionNumberLabel";
            this.transactionNumberLabel.Size = new System.Drawing.Size(0, 19);
            this.transactionNumberLabel.TabIndex = 0;
            // 
            // memberNameLabel
            // 
            this.memberNameLabel.AutoSize = true;
            this.memberNameLabel.Location = new System.Drawing.Point(12, 40);
            this.memberNameLabel.Name = "memberNameLabel";
            this.memberNameLabel.Size = new System.Drawing.Size(64, 19);
            this.memberNameLabel.TabIndex = 1;
            this.memberNameLabel.Text = "Member:";
            // 
            // memberNameValue
            // 
            this.memberNameValue.AutoSize = true;
            this.memberNameValue.Location = new System.Drawing.Point(82, 40);
            this.memberNameValue.Name = "memberNameValue";
            this.memberNameValue.Size = new System.Drawing.Size(0, 19);
            this.memberNameValue.TabIndex = 2;
            // 
            // dateValue
            // 
            this.dateValue.AutoSize = true;
            this.dateValue.Location = new System.Drawing.Point(342, 12);
            this.dateValue.Name = "dateValue";
            this.dateValue.Size = new System.Drawing.Size(0, 19);
            this.dateValue.TabIndex = 4;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(297, 12);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(41, 19);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "Date:";
            // 
            // employeeNameValue
            // 
            this.employeeNameValue.AutoSize = true;
            this.employeeNameValue.Location = new System.Drawing.Point(373, 40);
            this.employeeNameValue.Name = "employeeNameValue";
            this.employeeNameValue.Size = new System.Drawing.Size(0, 19);
            this.employeeNameValue.TabIndex = 6;
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Location = new System.Drawing.Point(296, 40);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(74, 19);
            this.employeeNameLabel.TabIndex = 5;
            this.employeeNameLabel.Text = "Helped By:";
            // 
            // totalValue
            // 
            this.totalValue.AutoSize = true;
            this.totalValue.Location = new System.Drawing.Point(429, 283);
            this.totalValue.Name = "totalValue";
            this.totalValue.Size = new System.Drawing.Size(0, 19);
            this.totalValue.TabIndex = 8;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(382, 283);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(41, 19);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.Text = "Total:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(506, 187);
            this.dataGridView1.TabIndex = 9;
            // 
            // ReturnSummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 311);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.totalValue);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.employeeNameValue);
            this.Controls.Add(this.employeeNameLabel);
            this.Controls.Add(this.dateValue);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.memberNameValue);
            this.Controls.Add(this.memberNameLabel);
            this.Controls.Add(this.transactionNumberLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReturnSummaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return Summary";
            this.Load += new System.EventHandler(this.OnReturnSummaryFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label transactionNumberLabel;
        private System.Windows.Forms.Label memberNameLabel;
        private System.Windows.Forms.Label memberNameValue;
        private System.Windows.Forms.Label dateValue;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label employeeNameValue;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.Label totalValue;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}