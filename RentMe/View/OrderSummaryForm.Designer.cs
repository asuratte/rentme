
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderSummaryForm));
            this.memberNameValueLabel = new System.Windows.Forms.Label();
            this.dateValueLabel = new System.Windows.Forms.Label();
            this.employeeNameValueLabel = new System.Windows.Forms.Label();
            this.transactionNumberLabel = new System.Windows.Forms.Label();
            this.totalValueLabel = new System.Windows.Forms.Label();
            this.rentalItemDataGridView = new System.Windows.Forms.DataGridView();
            this.dueDateValueLabel = new System.Windows.Forms.Label();
            this.rentalItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionIDTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.furnitureIDTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.furnitureNameTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberIDTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalDateTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubtotalTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rentalItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // memberNameValueLabel
            // 
            this.memberNameValueLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberNameValueLabel.Location = new System.Drawing.Point(12, 43);
            this.memberNameValueLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.memberNameValueLabel.Name = "memberNameValueLabel";
            this.memberNameValueLabel.Size = new System.Drawing.Size(288, 19);
            this.memberNameValueLabel.TabIndex = 0;
            // 
            // dateValueLabel
            // 
            this.dateValueLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateValueLabel.Location = new System.Drawing.Point(381, 9);
            this.dateValueLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.dateValueLabel.Name = "dateValueLabel";
            this.dateValueLabel.Size = new System.Drawing.Size(288, 19);
            this.dateValueLabel.TabIndex = 0;
            this.dateValueLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // employeeNameValueLabel
            // 
            this.employeeNameValueLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNameValueLabel.Location = new System.Drawing.Point(381, 43);
            this.employeeNameValueLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.employeeNameValueLabel.Name = "employeeNameValueLabel";
            this.employeeNameValueLabel.Size = new System.Drawing.Size(288, 19);
            this.employeeNameValueLabel.TabIndex = 0;
            this.employeeNameValueLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // transactionNumberLabel
            // 
            this.transactionNumberLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionNumberLabel.Location = new System.Drawing.Point(12, 9);
            this.transactionNumberLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.transactionNumberLabel.Name = "transactionNumberLabel";
            this.transactionNumberLabel.Size = new System.Drawing.Size(292, 19);
            this.transactionNumberLabel.TabIndex = 0;
            // 
            // totalValueLabel
            // 
            this.totalValueLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalValueLabel.Location = new System.Drawing.Point(438, 334);
            this.totalValueLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.totalValueLabel.Name = "totalValueLabel";
            this.totalValueLabel.Size = new System.Drawing.Size(231, 19);
            this.totalValueLabel.TabIndex = 0;
            this.totalValueLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rentalItemDataGridView
            // 
            this.rentalItemDataGridView.AllowUserToAddRows = false;
            this.rentalItemDataGridView.AllowUserToDeleteRows = false;
            this.rentalItemDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rentalItemDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.rentalItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentalItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionIDTextBoxColumn,
            this.furnitureIDTextBoxColumn,
            this.furnitureNameTextBoxColumn,
            this.quantityTextBoxColumn,
            this.RentalRate,
            this.memberIDTextBoxColumn,
            this.rentalDateTextBoxColumn,
            this.dueDateTextBoxColumn,
            this.SubtotalTextBoxColumn});
            this.rentalItemDataGridView.DataSource = this.rentalItemBindingSource;
            this.rentalItemDataGridView.Location = new System.Drawing.Point(16, 82);
            this.rentalItemDataGridView.Name = "rentalItemDataGridView";
            this.rentalItemDataGridView.ReadOnly = true;
            this.rentalItemDataGridView.Size = new System.Drawing.Size(653, 234);
            this.rentalItemDataGridView.TabIndex = 1;
            // 
            // dueDateValueLabel
            // 
            this.dueDateValueLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDateValueLabel.Location = new System.Drawing.Point(12, 334);
            this.dueDateValueLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.dueDateValueLabel.Name = "dueDateValueLabel";
            this.dueDateValueLabel.Size = new System.Drawing.Size(231, 19);
            this.dueDateValueLabel.TabIndex = 0;
            // 
            // rentalItemBindingSource
            // 
            this.rentalItemBindingSource.DataSource = typeof(RentMe.Model.RentalItem);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.furnitureIDTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.furnitureIDTextBoxColumn.HeaderText = "Furniture ID";
            this.furnitureIDTextBoxColumn.Name = "furnitureIDTextBoxColumn";
            this.furnitureIDTextBoxColumn.ReadOnly = true;
            this.furnitureIDTextBoxColumn.Width = 108;
            // 
            // furnitureNameTextBoxColumn
            // 
            this.furnitureNameTextBoxColumn.DataPropertyName = "FurnitureName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.furnitureNameTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.furnitureNameTextBoxColumn.HeaderText = "Furniture Name";
            this.furnitureNameTextBoxColumn.Name = "furnitureNameTextBoxColumn";
            this.furnitureNameTextBoxColumn.ReadOnly = true;
            this.furnitureNameTextBoxColumn.Width = 183;
            // 
            // quantityTextBoxColumn
            // 
            this.quantityTextBoxColumn.DataPropertyName = "Quantity";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.quantityTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.quantityTextBoxColumn.HeaderText = "Quantity";
            this.quantityTextBoxColumn.Name = "quantityTextBoxColumn";
            this.quantityTextBoxColumn.ReadOnly = true;
            this.quantityTextBoxColumn.Width = 81;
            // 
            // RentalRate
            // 
            this.RentalRate.DataPropertyName = "RentalRate";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.RentalRate.DefaultCellStyle = dataGridViewCellStyle5;
            this.RentalRate.HeaderText = "Rental Rate";
            this.RentalRate.Name = "RentalRate";
            this.RentalRate.ReadOnly = true;
            this.RentalRate.Width = 109;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.dueDateTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.dueDateTextBoxColumn.HeaderText = "Due Date";
            this.dueDateTextBoxColumn.Name = "dueDateTextBoxColumn";
            this.dueDateTextBoxColumn.ReadOnly = true;
            this.dueDateTextBoxColumn.Visible = false;
            this.dueDateTextBoxColumn.Width = 113;
            // 
            // SubtotalTextBoxColumn
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.SubtotalTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.SubtotalTextBoxColumn.HeaderText = "Subtotal";
            this.SubtotalTextBoxColumn.Name = "SubtotalTextBoxColumn";
            this.SubtotalTextBoxColumn.ReadOnly = true;
            this.SubtotalTextBoxColumn.Width = 111;
            // 
            // OrderSummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 378);
            this.Controls.Add(this.dueDateValueLabel);
            this.Controls.Add(this.rentalItemDataGridView);
            this.Controls.Add(this.totalValueLabel);
            this.Controls.Add(this.transactionNumberLabel);
            this.Controls.Add(this.employeeNameValueLabel);
            this.Controls.Add(this.dateValueLabel);
            this.Controls.Add(this.memberNameValueLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OrderSummaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Summary";
            this.Load += new System.EventHandler(this.OnOrderSummaryFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.rentalItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label memberNameValueLabel;
        private System.Windows.Forms.Label dateValueLabel;
        private System.Windows.Forms.Label employeeNameValueLabel;
        private System.Windows.Forms.Label transactionNumberLabel;
        private System.Windows.Forms.BindingSource rentalItemBindingSource;
        private System.Windows.Forms.Label totalValueLabel;
        private System.Windows.Forms.DataGridView rentalItemDataGridView;
        private System.Windows.Forms.Label dueDateValueLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionIDTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn furnitureIDTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn furnitureNameTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalDateTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubtotalTextBoxColumn;
    }
}