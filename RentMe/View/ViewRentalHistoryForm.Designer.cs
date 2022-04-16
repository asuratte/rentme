
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewRentalHistoryForm));
            this.rentalTransactionsLabel = new System.Windows.Forms.Label();
            this.rentalTransactionDataGridView = new System.Windows.Forms.DataGridView();
            this.rentalTransactionIDTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalMemberIDTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalEmployeeIDTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalDateTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalDueDateTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalTotalValueTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalViewDetailsButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rentalTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.returnTransactionsLabel = new System.Windows.Forms.Label();
            this.returnTransactionDataGridView = new System.Windows.Forms.DataGridView();
            this.returnTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.returnTransactionIDTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnMemberIDTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnEmployeeIDTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDateTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnTotalAmountTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnViewDetailsButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rentalTransactionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalTransactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnTransactionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnTransactionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rentalTransactionsLabel
            // 
            this.rentalTransactionsLabel.AutoSize = true;
            this.rentalTransactionsLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalTransactionsLabel.Location = new System.Drawing.Point(12, 15);
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
            this.rentalTransactionIDTextBoxColumn,
            this.rentalMemberIDTextBoxColumn,
            this.rentalEmployeeIDTextBoxColumn,
            this.rentalDateTextBoxColumn,
            this.rentalDueDateTextBoxColumn,
            this.rentalTotalValueTextBoxColumn,
            this.rentalViewDetailsButton});
            this.rentalTransactionDataGridView.DataSource = this.rentalTransactionBindingSource;
            this.rentalTransactionDataGridView.Location = new System.Drawing.Point(16, 40);
            this.rentalTransactionDataGridView.Name = "rentalTransactionDataGridView";
            this.rentalTransactionDataGridView.ReadOnly = true;
            this.rentalTransactionDataGridView.Size = new System.Drawing.Size(453, 220);
            this.rentalTransactionDataGridView.TabIndex = 2;
            // 
            // rentalTransactionIDTextBoxColumn
            // 
            this.rentalTransactionIDTextBoxColumn.DataPropertyName = "TransactionID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.rentalTransactionIDTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.rentalTransactionIDTextBoxColumn.HeaderText = "TransactionID";
            this.rentalTransactionIDTextBoxColumn.Name = "rentalTransactionIDTextBoxColumn";
            this.rentalTransactionIDTextBoxColumn.ReadOnly = true;
            // 
            // rentalMemberIDTextBoxColumn
            // 
            this.rentalMemberIDTextBoxColumn.DataPropertyName = "MemberID";
            this.rentalMemberIDTextBoxColumn.HeaderText = "MemberID";
            this.rentalMemberIDTextBoxColumn.Name = "rentalMemberIDTextBoxColumn";
            this.rentalMemberIDTextBoxColumn.ReadOnly = true;
            this.rentalMemberIDTextBoxColumn.Visible = false;
            // 
            // rentalEmployeeIDTextBoxColumn
            // 
            this.rentalEmployeeIDTextBoxColumn.DataPropertyName = "EmployeeID";
            this.rentalEmployeeIDTextBoxColumn.HeaderText = "EmployeeID";
            this.rentalEmployeeIDTextBoxColumn.Name = "rentalEmployeeIDTextBoxColumn";
            this.rentalEmployeeIDTextBoxColumn.ReadOnly = true;
            this.rentalEmployeeIDTextBoxColumn.Visible = false;
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
            // rentalDueDateTextBoxColumn
            // 
            this.rentalDueDateTextBoxColumn.DataPropertyName = "DueDate";
            this.rentalDueDateTextBoxColumn.HeaderText = "DueDate";
            this.rentalDueDateTextBoxColumn.Name = "rentalDueDateTextBoxColumn";
            this.rentalDueDateTextBoxColumn.ReadOnly = true;
            this.rentalDueDateTextBoxColumn.Visible = false;
            // 
            // rentalTotalValueTextBoxColumn
            // 
            this.rentalTotalValueTextBoxColumn.DataPropertyName = "TotalValue";
            this.rentalTotalValueTextBoxColumn.HeaderText = "TotalValue";
            this.rentalTotalValueTextBoxColumn.Name = "rentalTotalValueTextBoxColumn";
            this.rentalTotalValueTextBoxColumn.ReadOnly = true;
            this.rentalTotalValueTextBoxColumn.Visible = false;
            // 
            // rentalViewDetailsButton
            // 
            this.rentalViewDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rentalViewDetailsButton.HeaderText = "";
            this.rentalViewDetailsButton.Name = "rentalViewDetailsButton";
            this.rentalViewDetailsButton.ReadOnly = true;
            this.rentalViewDetailsButton.Text = "View Details";
            this.rentalViewDetailsButton.UseColumnTextForButtonValue = true;
            this.rentalViewDetailsButton.Width = 110;
            // 
            // rentalTransactionBindingSource
            // 
            this.rentalTransactionBindingSource.DataSource = typeof(RentMe.Model.RentalTransaction);
            // 
            // returnTransactionsLabel
            // 
            this.returnTransactionsLabel.AutoSize = true;
            this.returnTransactionsLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnTransactionsLabel.Location = new System.Drawing.Point(12, 289);
            this.returnTransactionsLabel.Name = "returnTransactionsLabel";
            this.returnTransactionsLabel.Size = new System.Drawing.Size(139, 19);
            this.returnTransactionsLabel.TabIndex = 3;
            this.returnTransactionsLabel.Text = "Return Transactions";
            // 
            // returnTransactionDataGridView
            // 
            this.returnTransactionDataGridView.AllowUserToAddRows = false;
            this.returnTransactionDataGridView.AllowUserToDeleteRows = false;
            this.returnTransactionDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.returnTransactionDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.returnTransactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.returnTransactionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.returnTransactionIDTextBoxColumn,
            this.returnMemberIDTextBoxColumn,
            this.returnEmployeeIDTextBoxColumn,
            this.returnDateTextBoxColumn,
            this.returnTotalAmountTextBoxColumn,
            this.returnViewDetailsButton});
            this.returnTransactionDataGridView.DataSource = this.returnTransactionBindingSource;
            this.returnTransactionDataGridView.Location = new System.Drawing.Point(16, 314);
            this.returnTransactionDataGridView.Name = "returnTransactionDataGridView";
            this.returnTransactionDataGridView.ReadOnly = true;
            this.returnTransactionDataGridView.Size = new System.Drawing.Size(453, 220);
            this.returnTransactionDataGridView.TabIndex = 3;
            // 
            // returnTransactionBindingSource
            // 
            this.returnTransactionBindingSource.DataSource = typeof(RentMe.Model.ReturnTransaction);
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageLabel.Location = new System.Drawing.Point(12, 553);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(457, 45);
            this.errorMessageLabel.TabIndex = 4;
            // 
            // returnTransactionIDTextBoxColumn
            // 
            this.returnTransactionIDTextBoxColumn.DataPropertyName = "TransactionID";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.returnTransactionIDTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.returnTransactionIDTextBoxColumn.HeaderText = "TransactionID";
            this.returnTransactionIDTextBoxColumn.Name = "returnTransactionIDTextBoxColumn";
            this.returnTransactionIDTextBoxColumn.ReadOnly = true;
            // 
            // returnMemberIDTextBoxColumn
            // 
            this.returnMemberIDTextBoxColumn.DataPropertyName = "MemberID";
            this.returnMemberIDTextBoxColumn.HeaderText = "MemberID";
            this.returnMemberIDTextBoxColumn.Name = "returnMemberIDTextBoxColumn";
            this.returnMemberIDTextBoxColumn.ReadOnly = true;
            this.returnMemberIDTextBoxColumn.Visible = false;
            // 
            // returnEmployeeIDTextBoxColumn
            // 
            this.returnEmployeeIDTextBoxColumn.DataPropertyName = "EmployeeID";
            this.returnEmployeeIDTextBoxColumn.HeaderText = "EmployeeID";
            this.returnEmployeeIDTextBoxColumn.Name = "returnEmployeeIDTextBoxColumn";
            this.returnEmployeeIDTextBoxColumn.ReadOnly = true;
            this.returnEmployeeIDTextBoxColumn.Visible = false;
            // 
            // returnDateTextBoxColumn
            // 
            this.returnDateTextBoxColumn.DataPropertyName = "ReturnDate";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.returnDateTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.returnDateTextBoxColumn.HeaderText = "Date";
            this.returnDateTextBoxColumn.Name = "returnDateTextBoxColumn";
            this.returnDateTextBoxColumn.ReadOnly = true;
            this.returnDateTextBoxColumn.Width = 200;
            // 
            // returnTotalAmountTextBoxColumn
            // 
            this.returnTotalAmountTextBoxColumn.DataPropertyName = "TotalAmount";
            this.returnTotalAmountTextBoxColumn.HeaderText = "TotalAmount";
            this.returnTotalAmountTextBoxColumn.Name = "returnTotalAmountTextBoxColumn";
            this.returnTotalAmountTextBoxColumn.ReadOnly = true;
            this.returnTotalAmountTextBoxColumn.Visible = false;
            // 
            // returnViewDetailsButton
            // 
            this.returnViewDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnViewDetailsButton.HeaderText = "";
            this.returnViewDetailsButton.Name = "returnViewDetailsButton";
            this.returnViewDetailsButton.ReadOnly = true;
            this.returnViewDetailsButton.Text = "View Details";
            this.returnViewDetailsButton.UseColumnTextForButtonValue = true;
            this.returnViewDetailsButton.Width = 110;
            // 
            // ViewRentalHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 607);
            this.Controls.Add(this.errorMessageLabel);
            this.Controls.Add(this.returnTransactionDataGridView);
            this.Controls.Add(this.returnTransactionsLabel);
            this.Controls.Add(this.rentalTransactionDataGridView);
            this.Controls.Add(this.rentalTransactionsLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewRentalHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Rental History";
            this.Load += new System.EventHandler(this.OnViewRentalHistoryFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.rentalTransactionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalTransactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnTransactionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnTransactionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rentalTransactionsLabel;
        private System.Windows.Forms.BindingSource rentalTransactionBindingSource;
        private System.Windows.Forms.DataGridView rentalTransactionDataGridView;
        private System.Windows.Forms.Label returnTransactionsLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalTransactionIDTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalMemberIDTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalEmployeeIDTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalDateTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalDueDateTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalTotalValueTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn rentalViewDetailsButton;
        private System.Windows.Forms.BindingSource returnTransactionBindingSource;
        private System.Windows.Forms.DataGridView returnTransactionDataGridView;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnTransactionIDTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnMemberIDTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnEmployeeIDTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDateTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnTotalAmountTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn returnViewDetailsButton;
    }
}