
namespace RentMe.View
{
    partial class ConfirmOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmOrderForm));
            this.confirmOrderDetailsLabel = new System.Windows.Forms.Label();
            this.submitOrderButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalValueLabel = new System.Windows.Forms.Label();
            this.rentalItemDataGridView = new System.Windows.Forms.DataGridView();
            this.dueDateLabel = new System.Windows.Forms.Label();
            this.dueDateValueLabel = new System.Windows.Forms.Label();
            this.rentalItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionIDTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.furnitureIDTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.furnitureNameTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalRateTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubtotalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberIDTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalDateTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rentalItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // confirmOrderDetailsLabel
            // 
            this.confirmOrderDetailsLabel.AutoSize = true;
            this.confirmOrderDetailsLabel.Location = new System.Drawing.Point(8, 9);
            this.confirmOrderDetailsLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.confirmOrderDetailsLabel.Name = "confirmOrderDetailsLabel";
            this.confirmOrderDetailsLabel.Size = new System.Drawing.Size(293, 19);
            this.confirmOrderDetailsLabel.TabIndex = 0;
            this.confirmOrderDetailsLabel.Text = "Please confirm order details before submitting.";
            // 
            // submitOrderButton
            // 
            this.submitOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.submitOrderButton.FlatAppearance.BorderSize = 0;
            this.submitOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitOrderButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitOrderButton.ForeColor = System.Drawing.Color.White;
            this.submitOrderButton.Location = new System.Drawing.Point(340, 334);
            this.submitOrderButton.Name = "submitOrderButton";
            this.submitOrderButton.Size = new System.Drawing.Size(168, 27);
            this.submitOrderButton.TabIndex = 3;
            this.submitOrderButton.Text = "Confirm && Submit";
            this.submitOrderButton.UseVisualStyleBackColor = false;
            this.submitOrderButton.Click += new System.EventHandler(this.SubmitButtonClick);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.DimGray;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(527, 334);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(110, 27);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(12, 339);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(41, 19);
            this.totalLabel.TabIndex = 0;
            this.totalLabel.Text = "Total:";
            // 
            // totalValueLabel
            // 
            this.totalValueLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalValueLabel.Location = new System.Drawing.Point(82, 339);
            this.totalValueLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.totalValueLabel.Name = "totalValueLabel";
            this.totalValueLabel.Size = new System.Drawing.Size(98, 19);
            this.totalValueLabel.TabIndex = 0;
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
            this.rentalRateTextBoxColumn,
            this.quantityTextBoxColumn,
            this.SubtotalColumn,
            this.memberIDTextBoxColumn,
            this.rentalDateTextBoxColumn,
            this.dueDateTextBoxColumn});
            this.rentalItemDataGridView.DataSource = this.rentalItemBindingSource;
            this.rentalItemDataGridView.Location = new System.Drawing.Point(12, 48);
            this.rentalItemDataGridView.Name = "rentalItemDataGridView";
            this.rentalItemDataGridView.ReadOnly = true;
            this.rentalItemDataGridView.Size = new System.Drawing.Size(625, 247);
            this.rentalItemDataGridView.TabIndex = 1;
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.Location = new System.Drawing.Point(12, 311);
            this.dueDateLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(70, 19);
            this.dueDateLabel.TabIndex = 0;
            this.dueDateLabel.Text = "Due Date:";
            // 
            // dueDateValueLabel
            // 
            this.dueDateValueLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDateValueLabel.Location = new System.Drawing.Point(82, 311);
            this.dueDateValueLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.dueDateValueLabel.Name = "dueDateValueLabel";
            this.dueDateValueLabel.Size = new System.Drawing.Size(150, 19);
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
            this.furnitureIDTextBoxColumn.FillWeight = 221.3198F;
            this.furnitureIDTextBoxColumn.HeaderText = "Furniture ID";
            this.furnitureIDTextBoxColumn.Name = "furnitureIDTextBoxColumn";
            this.furnitureIDTextBoxColumn.ReadOnly = true;
            this.furnitureIDTextBoxColumn.Width = 110;
            // 
            // furnitureNameTextBoxColumn
            // 
            this.furnitureNameTextBoxColumn.DataPropertyName = "FurnitureName";
            this.furnitureNameTextBoxColumn.FillWeight = 59.56007F;
            this.furnitureNameTextBoxColumn.HeaderText = "Furniture Name";
            this.furnitureNameTextBoxColumn.Name = "furnitureNameTextBoxColumn";
            this.furnitureNameTextBoxColumn.ReadOnly = true;
            this.furnitureNameTextBoxColumn.Width = 175;
            // 
            // rentalRateTextBoxColumn
            // 
            this.rentalRateTextBoxColumn.DataPropertyName = "RentalRate";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.rentalRateTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.rentalRateTextBoxColumn.FillWeight = 59.56007F;
            this.rentalRateTextBoxColumn.HeaderText = "Rental Rate";
            this.rentalRateTextBoxColumn.Name = "rentalRateTextBoxColumn";
            this.rentalRateTextBoxColumn.ReadOnly = true;
            this.rentalRateTextBoxColumn.Width = 106;
            // 
            // quantityTextBoxColumn
            // 
            this.quantityTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityTextBoxColumn.FillWeight = 59.56007F;
            this.quantityTextBoxColumn.HeaderText = "Quantity";
            this.quantityTextBoxColumn.Name = "quantityTextBoxColumn";
            this.quantityTextBoxColumn.ReadOnly = true;
            this.quantityTextBoxColumn.Width = 85;
            // 
            // SubtotalColumn
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.SubtotalColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.SubtotalColumn.HeaderText = "Subtotal";
            this.SubtotalColumn.Name = "SubtotalColumn";
            this.SubtotalColumn.ReadOnly = true;
            this.SubtotalColumn.Width = 85;
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
            this.rentalDateTextBoxColumn.Width = 90;
            // 
            // dueDateTextBoxColumn
            // 
            this.dueDateTextBoxColumn.DataPropertyName = "DueDate";
            this.dueDateTextBoxColumn.HeaderText = "DueDate";
            this.dueDateTextBoxColumn.Name = "dueDateTextBoxColumn";
            this.dueDateTextBoxColumn.ReadOnly = true;
            this.dueDateTextBoxColumn.Visible = false;
            // 
            // ConfirmOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 372);
            this.Controls.Add(this.dueDateValueLabel);
            this.Controls.Add(this.dueDateLabel);
            this.Controls.Add(this.rentalItemDataGridView);
            this.Controls.Add(this.totalValueLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitOrderButton);
            this.Controls.Add(this.confirmOrderDetailsLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ConfirmOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirm Order";
            this.Load += new System.EventHandler(this.OnConfirmOrderFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.rentalItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label confirmOrderDetailsLabel;
        private System.Windows.Forms.Button submitOrderButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalValueLabel;
        private System.Windows.Forms.BindingSource rentalItemBindingSource;
        private System.Windows.Forms.DataGridView rentalItemDataGridView;
        private System.Windows.Forms.Label dueDateLabel;
        private System.Windows.Forms.Label dueDateValueLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionIDTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn furnitureIDTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn furnitureNameTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalRateTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubtotalColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalDateTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateTextBoxColumn;
    }
}