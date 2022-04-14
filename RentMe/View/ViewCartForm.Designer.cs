
namespace RentMe.View
{
    partial class ViewCartForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.orderForLabel = new System.Windows.Forms.Label();
            this.memberNameValueLabel = new System.Windows.Forms.Label();
            this.returnDateLabel = new System.Windows.Forms.Label();
            this.returnDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rentalTotalLabel = new System.Windows.Forms.Label();
            this.rentalTotalTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.rentalItemDataGridView = new System.Windows.Forms.DataGridView();
            this.SubtotalTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.submitOrderButton = new System.Windows.Forms.Button();
            this.transactionIDTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.furnitureIDTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.furnitureNameTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalRateTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberIDTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalDateTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rentalItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // orderForLabel
            // 
            this.orderForLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderForLabel.Location = new System.Drawing.Point(12, 9);
            this.orderForLabel.Name = "orderForLabel";
            this.orderForLabel.Size = new System.Drawing.Size(75, 19);
            this.orderForLabel.TabIndex = 2;
            this.orderForLabel.Text = "Order For:";
            // 
            // memberNameValueLabel
            // 
            this.memberNameValueLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberNameValueLabel.Location = new System.Drawing.Point(104, 9);
            this.memberNameValueLabel.Name = "memberNameValueLabel";
            this.memberNameValueLabel.Size = new System.Drawing.Size(371, 19);
            this.memberNameValueLabel.TabIndex = 3;
            // 
            // returnDateLabel
            // 
            this.returnDateLabel.AutoSize = true;
            this.returnDateLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDateLabel.Location = new System.Drawing.Point(12, 51);
            this.returnDateLabel.Name = "returnDateLabel";
            this.returnDateLabel.Size = new System.Drawing.Size(86, 19);
            this.returnDateLabel.TabIndex = 4;
            this.returnDateLabel.Text = "Return Date:";
            // 
            // returnDateTimePicker
            // 
            this.returnDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDateTimePicker.Location = new System.Drawing.Point(104, 48);
            this.returnDateTimePicker.Name = "returnDateTimePicker";
            this.returnDateTimePicker.Size = new System.Drawing.Size(217, 25);
            this.returnDateTimePicker.TabIndex = 5;
            this.returnDateTimePicker.ValueChanged += new System.EventHandler(this.OnReturnDateTimePickerValueChanged);
            // 
            // rentalTotalLabel
            // 
            this.rentalTotalLabel.AutoSize = true;
            this.rentalTotalLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalTotalLabel.Location = new System.Drawing.Point(472, 51);
            this.rentalTotalLabel.Name = "rentalTotalLabel";
            this.rentalTotalLabel.Size = new System.Drawing.Size(83, 19);
            this.rentalTotalLabel.TabIndex = 6;
            this.rentalTotalLabel.Text = "Rental Total:";
            // 
            // rentalTotalTextBox
            // 
            this.rentalTotalTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalTotalTextBox.Location = new System.Drawing.Point(561, 48);
            this.rentalTotalTextBox.Name = "rentalTotalTextBox";
            this.rentalTotalTextBox.ReadOnly = true;
            this.rentalTotalTextBox.Size = new System.Drawing.Size(109, 25);
            this.rentalTotalTextBox.TabIndex = 7;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.DimGray;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(587, 352);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(83, 27);
            this.closeButton.TabIndex = 12;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageLabel.Location = new System.Drawing.Point(12, 334);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(432, 45);
            this.errorMessageLabel.TabIndex = 16;
            // 
            // rentalItemDataGridView
            // 
            this.rentalItemDataGridView.AllowUserToAddRows = false;
            this.rentalItemDataGridView.AllowUserToDeleteRows = false;
            this.rentalItemDataGridView.AutoGenerateColumns = false;
            this.rentalItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentalItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionIDTextBoxColumn,
            this.quantityTextBoxColumn,
            this.furnitureIDTextBoxColumn,
            this.furnitureNameTextBoxColumn,
            this.rentalRateTextBoxColumn,
            this.memberIDTextBoxColumn,
            this.rentalDateTextBoxColumn,
            this.dueDateTextBoxColumn,
            this.SubtotalTextBoxColumn,
            this.EditButtonColumn});
            this.rentalItemDataGridView.DataSource = this.rentalItemBindingSource;
            this.rentalItemDataGridView.Location = new System.Drawing.Point(16, 111);
            this.rentalItemDataGridView.Name = "rentalItemDataGridView";
            this.rentalItemDataGridView.ReadOnly = true;
            this.rentalItemDataGridView.Size = new System.Drawing.Size(654, 220);
            this.rentalItemDataGridView.TabIndex = 16;
            this.rentalItemDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RentalItemDataGridViewCellContentClick);
            // 
            // SubtotalTextBoxColumn
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.SubtotalTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.SubtotalTextBoxColumn.HeaderText = "Subtotal";
            this.SubtotalTextBoxColumn.Name = "SubtotalTextBoxColumn";
            this.SubtotalTextBoxColumn.ReadOnly = true;
            this.SubtotalTextBoxColumn.Width = 90;
            // 
            // EditButtonColumn
            // 
            this.EditButtonColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButtonColumn.HeaderText = "";
            this.EditButtonColumn.Name = "EditButtonColumn";
            this.EditButtonColumn.ReadOnly = true;
            this.EditButtonColumn.Text = "Edit";
            this.EditButtonColumn.UseColumnTextForButtonValue = true;
            // 
            // submitOrderButton
            // 
            this.submitOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.submitOrderButton.FlatAppearance.BorderSize = 0;
            this.submitOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitOrderButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitOrderButton.ForeColor = System.Drawing.Color.White;
            this.submitOrderButton.Location = new System.Drawing.Point(450, 352);
            this.submitOrderButton.Name = "submitOrderButton";
            this.submitOrderButton.Size = new System.Drawing.Size(122, 27);
            this.submitOrderButton.TabIndex = 20;
            this.submitOrderButton.Text = "Submit Order";
            this.submitOrderButton.UseVisualStyleBackColor = false;
            this.submitOrderButton.Click += new System.EventHandler(this.SubmitOrderButtonClick);
            // 
            // transactionIDTextBoxColumn
            // 
            this.transactionIDTextBoxColumn.DataPropertyName = "TransactionID";
            this.transactionIDTextBoxColumn.HeaderText = "TransactionID";
            this.transactionIDTextBoxColumn.Name = "transactionIDTextBoxColumn";
            this.transactionIDTextBoxColumn.ReadOnly = true;
            this.transactionIDTextBoxColumn.Visible = false;
            // 
            // quantityTextBoxColumn
            // 
            this.quantityTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityTextBoxColumn.HeaderText = "Quantity";
            this.quantityTextBoxColumn.Name = "quantityTextBoxColumn";
            this.quantityTextBoxColumn.ReadOnly = true;
            this.quantityTextBoxColumn.Width = 80;
            // 
            // furnitureIDTextBoxColumn
            // 
            this.furnitureIDTextBoxColumn.DataPropertyName = "FurnitureID";
            this.furnitureIDTextBoxColumn.HeaderText = "Furniture ID";
            this.furnitureIDTextBoxColumn.Name = "furnitureIDTextBoxColumn";
            this.furnitureIDTextBoxColumn.ReadOnly = true;
            this.furnitureIDTextBoxColumn.Width = 95;
            // 
            // furnitureNameTextBoxColumn
            // 
            this.furnitureNameTextBoxColumn.DataPropertyName = "FurnitureName";
            this.furnitureNameTextBoxColumn.HeaderText = "Furniture Name";
            this.furnitureNameTextBoxColumn.Name = "furnitureNameTextBoxColumn";
            this.furnitureNameTextBoxColumn.ReadOnly = true;
            this.furnitureNameTextBoxColumn.Width = 150;
            // 
            // rentalRateTextBoxColumn
            // 
            this.rentalRateTextBoxColumn.DataPropertyName = "RentalRate";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.rentalRateTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.rentalRateTextBoxColumn.HeaderText = "RentalRate";
            this.rentalRateTextBoxColumn.Name = "rentalRateTextBoxColumn";
            this.rentalRateTextBoxColumn.ReadOnly = true;
            this.rentalRateTextBoxColumn.Width = 90;
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
            this.dueDateTextBoxColumn.HeaderText = "DueDate";
            this.dueDateTextBoxColumn.Name = "dueDateTextBoxColumn";
            this.dueDateTextBoxColumn.ReadOnly = true;
            this.dueDateTextBoxColumn.Visible = false;
            // 
            // rentalItemBindingSource
            // 
            this.rentalItemBindingSource.DataSource = typeof(RentMe.Model.RentalItem);
            // 
            // ViewCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 408);
            this.Controls.Add(this.submitOrderButton);
            this.Controls.Add(this.rentalItemDataGridView);
            this.Controls.Add(this.errorMessageLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.rentalTotalTextBox);
            this.Controls.Add(this.rentalTotalLabel);
            this.Controls.Add(this.returnDateTimePicker);
            this.Controls.Add(this.returnDateLabel);
            this.Controls.Add(this.memberNameValueLabel);
            this.Controls.Add(this.orderForLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ViewCartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Cart";
            this.Shown += new System.EventHandler(this.OnViewCartFormShown);
            ((System.ComponentModel.ISupportInitialize)(this.rentalItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label orderForLabel;
        private System.Windows.Forms.Label memberNameValueLabel;
        private System.Windows.Forms.Label returnDateLabel;
        private System.Windows.Forms.DateTimePicker returnDateTimePicker;
        private System.Windows.Forms.Label rentalTotalLabel;
        private System.Windows.Forms.TextBox rentalTotalTextBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.BindingSource rentalItemBindingSource;
        private System.Windows.Forms.DataGridView rentalItemDataGridView;
        private System.Windows.Forms.Button submitOrderButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionIDTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn furnitureIDTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn furnitureNameTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalRateTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalDateTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubtotalTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditButtonColumn;
    }
}