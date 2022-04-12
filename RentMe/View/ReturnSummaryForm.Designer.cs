
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.returnItemDataGridView = new System.Windows.Forms.DataGridView();
            this.returnItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.returnItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnItemBindingSource)).BeginInit();
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
            this.totalValue.Location = new System.Drawing.Point(429, 347);
            this.totalValue.Name = "totalValue";
            this.totalValue.Size = new System.Drawing.Size(0, 19);
            this.totalValue.TabIndex = 8;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(382, 347);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(41, 19);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.Text = "Total:";
            // 
            // returnItemDataGridView
            // 
            this.returnItemDataGridView.AllowUserToAddRows = false;
            this.returnItemDataGridView.AllowUserToDeleteRows = false;
            this.returnItemDataGridView.AutoGenerateColumns = false;
            this.returnItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.returnItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.returnItemDataGridView.DataSource = this.returnItemBindingSource;
            this.returnItemDataGridView.Location = new System.Drawing.Point(16, 85);
            this.returnItemDataGridView.Name = "returnItemDataGridView";
            this.returnItemDataGridView.ReadOnly = true;
            this.returnItemDataGridView.Size = new System.Drawing.Size(571, 246);
            this.returnItemDataGridView.TabIndex = 9;
            // 
            // returnItemBindingSource
            // 
            this.returnItemBindingSource.DataSource = typeof(RentMe.Model.ReturnItem);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TransactionID";
            this.dataGridViewTextBoxColumn1.HeaderText = "TransactionID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RentalTransactionID";
            this.dataGridViewTextBoxColumn2.HeaderText = "RentalTransactionID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FurnitureID";
            this.dataGridViewTextBoxColumn3.HeaderText = "Furniture ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FurnitureName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 190;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn5.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 85;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ItemTotal";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn6.HeaderText = "Fine/Refund";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 130;
            // 
            // ReturnSummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 386);
            this.Controls.Add(this.returnItemDataGridView);
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
            ((System.ComponentModel.ISupportInitialize)(this.returnItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnItemBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource returnItemBindingSource;
        private System.Windows.Forms.DataGridView returnItemDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}