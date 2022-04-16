
namespace RentMe.View
{
    partial class ViewRentalHistoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rentalTransactionsLabel = new System.Windows.Forms.Label();
            this.rentalTransactionDataGridView = new System.Windows.Forms.DataGridView();
            this.rentalTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionIDTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberIDTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalDateTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalValueTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewDetailsButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rentalTransactionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalTransactionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rentalTransactionsLabel
            // 
            this.rentalTransactionsLabel.AutoSize = true;
            this.rentalTransactionsLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalTransactionsLabel.Location = new System.Drawing.Point(12, 9);
            this.rentalTransactionsLabel.Name = "rentalTransactionsLabel";
            this.rentalTransactionsLabel.Size = new System.Drawing.Size(137, 19);
            this.rentalTransactionsLabel.TabIndex = 0;
            this.rentalTransactionsLabel.Text = "Rental Transactions";
            // 
            // rentalTransactionDataGridView
            // 
            this.rentalTransactionDataGridView.AllowUserToAddRows = false;
            this.rentalTransactionDataGridView.AllowUserToDeleteRows = false;
            this.rentalTransactionDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rentalTransactionDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.rentalTransactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentalTransactionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionIDTextBoxColumn,
            this.memberIDTextBoxColumn,
            this.employeeIDTextBoxColumn,
            this.rentalDateTextBoxColumn,
            this.dueDateTextBoxColumn,
            this.totalValueTextBoxColumn,
            this.viewDetailsButton});
            this.rentalTransactionDataGridView.DataSource = this.rentalTransactionBindingSource;
            this.rentalTransactionDataGridView.Location = new System.Drawing.Point(16, 31);
            this.rentalTransactionDataGridView.Name = "rentalTransactionDataGridView";
            this.rentalTransactionDataGridView.ReadOnly = true;
            this.rentalTransactionDataGridView.Size = new System.Drawing.Size(453, 220);
            this.rentalTransactionDataGridView.TabIndex = 2;
            // 
            // rentalTransactionBindingSource
            // 
            this.rentalTransactionBindingSource.DataSource = typeof(RentMe.Model.RentalTransaction);
            // 
            // transactionIDTextBoxColumn
            // 
            this.transactionIDTextBoxColumn.DataPropertyName = "TransactionID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.transactionIDTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.transactionIDTextBoxColumn.HeaderText = "TransactionID";
            this.transactionIDTextBoxColumn.Name = "transactionIDTextBoxColumn";
            this.transactionIDTextBoxColumn.ReadOnly = true;
            // 
            // memberIDTextBoxColumn
            // 
            this.memberIDTextBoxColumn.DataPropertyName = "MemberID";
            this.memberIDTextBoxColumn.HeaderText = "MemberID";
            this.memberIDTextBoxColumn.Name = "memberIDTextBoxColumn";
            this.memberIDTextBoxColumn.ReadOnly = true;
            this.memberIDTextBoxColumn.Visible = false;
            // 
            // employeeIDTextBoxColumn
            // 
            this.employeeIDTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDTextBoxColumn.Name = "employeeIDTextBoxColumn";
            this.employeeIDTextBoxColumn.ReadOnly = true;
            this.employeeIDTextBoxColumn.Visible = false;
            // 
            // rentalDateTextBoxColumn
            // 
            this.rentalDateTextBoxColumn.DataPropertyName = "RentalDate";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.Format = "g";
            dataGridViewCellStyle3.NullValue = null;
            this.rentalDateTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.rentalDateTextBoxColumn.HeaderText = "Date";
            this.rentalDateTextBoxColumn.Name = "rentalDateTextBoxColumn";
            this.rentalDateTextBoxColumn.ReadOnly = true;
            this.rentalDateTextBoxColumn.Width = 200;
            // 
            // dueDateTextBoxColumn
            // 
            this.dueDateTextBoxColumn.DataPropertyName = "DueDate";
            this.dueDateTextBoxColumn.HeaderText = "DueDate";
            this.dueDateTextBoxColumn.Name = "dueDateTextBoxColumn";
            this.dueDateTextBoxColumn.ReadOnly = true;
            this.dueDateTextBoxColumn.Visible = false;
            // 
            // totalValueTextBoxColumn
            // 
            this.totalValueTextBoxColumn.DataPropertyName = "TotalValue";
            this.totalValueTextBoxColumn.HeaderText = "TotalValue";
            this.totalValueTextBoxColumn.Name = "totalValueTextBoxColumn";
            this.totalValueTextBoxColumn.ReadOnly = true;
            this.totalValueTextBoxColumn.Visible = false;
            // 
            // viewDetailsButton
            // 
            this.viewDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewDetailsButton.HeaderText = "";
            this.viewDetailsButton.Name = "viewDetailsButton";
            this.viewDetailsButton.ReadOnly = true;
            this.viewDetailsButton.Text = "View Details";
            this.viewDetailsButton.UseColumnTextForButtonValue = true;
            this.viewDetailsButton.Width = 110;
            // 
            // ViewRentalHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 270);
            this.Controls.Add(this.rentalTransactionDataGridView);
            this.Controls.Add(this.rentalTransactionsLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewRentalHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Rental History";
            this.Load += new System.EventHandler(this.OnViewRentalHistoryFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.rentalTransactionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalTransactionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rentalTransactionsLabel;
        private System.Windows.Forms.BindingSource rentalTransactionBindingSource;
        private System.Windows.Forms.DataGridView rentalTransactionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionIDTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalDateTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalValueTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn viewDetailsButton;
    }
}