
namespace RentMe.View
{
    partial class OrderSummaryForm
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
            this.memberLabel = new System.Windows.Forms.Label();
            this.memberNameValueLabel = new System.Windows.Forms.Label();
            this.dateValueLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.employeeNameValueLabel = new System.Windows.Forms.Label();
            this.helpedByLabel = new System.Windows.Forms.Label();
            this.transactionNumberLabel = new System.Windows.Forms.Label();
            this.rentalItemDataGridView = new System.Windows.Forms.DataGridView();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalValueLabel = new System.Windows.Forms.Label();
            this.transactionIDTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.furnitureIDTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.furnitureNameTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberIDTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalDateTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rentalItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // memberLabel
            // 
            this.memberLabel.AutoSize = true;
            this.memberLabel.Location = new System.Drawing.Point(12, 43);
            this.memberLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.memberLabel.Name = "memberLabel";
            this.memberLabel.Size = new System.Drawing.Size(64, 19);
            this.memberLabel.TabIndex = 23;
            this.memberLabel.Text = "Member:";
            // 
            // memberNameValueLabel
            // 
            this.memberNameValueLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberNameValueLabel.Location = new System.Drawing.Point(76, 43);
            this.memberNameValueLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.memberNameValueLabel.Name = "memberNameValueLabel";
            this.memberNameValueLabel.Size = new System.Drawing.Size(228, 19);
            this.memberNameValueLabel.TabIndex = 26;
            // 
            // dateValueLabel
            // 
            this.dateValueLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateValueLabel.Location = new System.Drawing.Point(482, 9);
            this.dateValueLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.dateValueLabel.Name = "dateValueLabel";
            this.dateValueLabel.Size = new System.Drawing.Size(151, 19);
            this.dateValueLabel.TabIndex = 28;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(437, 9);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(41, 19);
            this.dateLabel.TabIndex = 27;
            this.dateLabel.Text = "Date:";
            // 
            // employeeNameValueLabel
            // 
            this.employeeNameValueLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNameValueLabel.Location = new System.Drawing.Point(478, 43);
            this.employeeNameValueLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.employeeNameValueLabel.Name = "employeeNameValueLabel";
            this.employeeNameValueLabel.Size = new System.Drawing.Size(155, 19);
            this.employeeNameValueLabel.TabIndex = 30;
            // 
            // helpedByLabel
            // 
            this.helpedByLabel.AutoSize = true;
            this.helpedByLabel.Location = new System.Drawing.Point(404, 43);
            this.helpedByLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.helpedByLabel.Name = "helpedByLabel";
            this.helpedByLabel.Size = new System.Drawing.Size(74, 19);
            this.helpedByLabel.TabIndex = 29;
            this.helpedByLabel.Text = "Helped By:";
            // 
            // transactionNumberLabel
            // 
            this.transactionNumberLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionNumberLabel.Location = new System.Drawing.Point(12, 9);
            this.transactionNumberLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.transactionNumberLabel.Name = "transactionNumberLabel";
            this.transactionNumberLabel.Size = new System.Drawing.Size(292, 19);
            this.transactionNumberLabel.TabIndex = 31;
            // 
            // rentalItemDataGridView
            // 
            this.rentalItemDataGridView.AllowUserToAddRows = false;
            this.rentalItemDataGridView.AllowUserToDeleteRows = false;
            this.rentalItemDataGridView.AutoGenerateColumns = false;
            this.rentalItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentalItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionIDTextBoxColumn,
            this.furnitureIDTextBoxColumn,
            this.furnitureNameTextBoxColumn,
            this.quantityTextBoxColumn,
            this.memberIDTextBoxColumn,
            this.rentalDateTextBoxColumn,
            this.dueDateTextBoxColumn});
            this.rentalItemDataGridView.DataSource = this.rentalItemBindingSource;
            this.rentalItemDataGridView.Location = new System.Drawing.Point(16, 89);
            this.rentalItemDataGridView.Name = "rentalItemDataGridView";
            this.rentalItemDataGridView.ReadOnly = true;
            this.rentalItemDataGridView.Size = new System.Drawing.Size(617, 220);
            this.rentalItemDataGridView.TabIndex = 32;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(437, 334);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(41, 19);
            this.totalLabel.TabIndex = 33;
            this.totalLabel.Text = "Total:";
            // 
            // totalValueLabel
            // 
            this.totalValueLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalValueLabel.Location = new System.Drawing.Point(486, 334);
            this.totalValueLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.totalValueLabel.Name = "totalValueLabel";
            this.totalValueLabel.Size = new System.Drawing.Size(147, 19);
            this.totalValueLabel.TabIndex = 34;
            // 
            // transactionIDTextBoxColumn
            // 
            this.transactionIDTextBoxColumn.DataPropertyName = "TransactionID";
            this.transactionIDTextBoxColumn.HeaderText = "TransactionID";
            this.transactionIDTextBoxColumn.Name = "transactionIDTextBoxColumn";
            this.transactionIDTextBoxColumn.ReadOnly = true;
            this.transactionIDTextBoxColumn.Visible = false;
            // 
            // furnitureIDTextBoxColumn
            // 
            this.furnitureIDTextBoxColumn.DataPropertyName = "FurnitureID";
            this.furnitureIDTextBoxColumn.HeaderText = "Furniture ID";
            this.furnitureIDTextBoxColumn.Name = "furnitureIDTextBoxColumn";
            this.furnitureIDTextBoxColumn.ReadOnly = true;
            this.furnitureIDTextBoxColumn.Width = 108;
            // 
            // furnitureNameTextBoxColumn
            // 
            this.furnitureNameTextBoxColumn.DataPropertyName = "FurnitureName";
            this.furnitureNameTextBoxColumn.HeaderText = "Furniture Name";
            this.furnitureNameTextBoxColumn.Name = "furnitureNameTextBoxColumn";
            this.furnitureNameTextBoxColumn.ReadOnly = true;
            this.furnitureNameTextBoxColumn.Width = 180;
            // 
            // quantityTextBoxColumn
            // 
            this.quantityTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityTextBoxColumn.HeaderText = "Quantity";
            this.quantityTextBoxColumn.Name = "quantityTextBoxColumn";
            this.quantityTextBoxColumn.ReadOnly = true;
            this.quantityTextBoxColumn.Width = 80;
            // 
            // memberIDTextBoxColumn
            // 
            this.memberIDTextBoxColumn.DataPropertyName = "MemberID";
            this.memberIDTextBoxColumn.HeaderText = "MemberID";
            this.memberIDTextBoxColumn.Name = "memberIDTextBoxColumn";
            this.memberIDTextBoxColumn.ReadOnly = true;
            this.memberIDTextBoxColumn.Visible = false;
            // 
            // rentalDateTextBoxColumn
            // 
            this.rentalDateTextBoxColumn.DataPropertyName = "RentalDate";
            this.rentalDateTextBoxColumn.HeaderText = "RentalDate";
            this.rentalDateTextBoxColumn.Name = "rentalDateTextBoxColumn";
            this.rentalDateTextBoxColumn.ReadOnly = true;
            this.rentalDateTextBoxColumn.Visible = false;
            // 
            // dueDateTextBoxColumn
            // 
            this.dueDateTextBoxColumn.DataPropertyName = "DueDate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dueDateTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dueDateTextBoxColumn.HeaderText = "Due Date";
            this.dueDateTextBoxColumn.Name = "dueDateTextBoxColumn";
            this.dueDateTextBoxColumn.ReadOnly = true;
            // 
            // rentalItemBindingSource
            // 
            this.rentalItemBindingSource.DataSource = typeof(RentMe.Model.RentalItem);
            // 
            // OrderSummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 370);
            this.Controls.Add(this.totalValueLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.rentalItemDataGridView);
            this.Controls.Add(this.transactionNumberLabel);
            this.Controls.Add(this.employeeNameValueLabel);
            this.Controls.Add(this.helpedByLabel);
            this.Controls.Add(this.dateValueLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.memberNameValueLabel);
            this.Controls.Add(this.memberLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OrderSummaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Summary";
            this.Load += new System.EventHandler(this.OnOrderSummaryFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.rentalItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label memberLabel;
        private System.Windows.Forms.Label memberNameValueLabel;
        private System.Windows.Forms.Label dateValueLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label employeeNameValueLabel;
        private System.Windows.Forms.Label helpedByLabel;
        private System.Windows.Forms.Label transactionNumberLabel;
        private System.Windows.Forms.BindingSource rentalItemBindingSource;
        private System.Windows.Forms.DataGridView rentalItemDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionIDTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn furnitureIDTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn furnitureNameTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalRateTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalDateTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateTextBoxColumn;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalValueLabel;
    }
}