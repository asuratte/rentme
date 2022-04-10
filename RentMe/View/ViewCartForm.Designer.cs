
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.orderForLabel = new System.Windows.Forms.Label();
            this.memberNameLabel = new System.Windows.Forms.Label();
            this.returnDateLabel = new System.Windows.Forms.Label();
            this.returnDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rentalTotalLabel = new System.Windows.Forms.Label();
            this.rentalTotalTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.furnitureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.furnitureDataGridView = new System.Windows.Forms.DataGridView();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubtotalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // orderForLabel
            // 
            this.orderForLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderForLabel.Location = new System.Drawing.Point(12, 9);
            this.orderForLabel.Name = "orderForLabel";
            this.orderForLabel.Size = new System.Drawing.Size(86, 19);
            this.orderForLabel.TabIndex = 2;
            this.orderForLabel.Text = "Order For:";
            // 
            // memberNameLabel
            // 
            this.memberNameLabel.AutoSize = true;
            this.memberNameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberNameLabel.Location = new System.Drawing.Point(87, 9);
            this.memberNameLabel.Name = "memberNameLabel";
            this.memberNameLabel.Size = new System.Drawing.Size(0, 17);
            this.memberNameLabel.TabIndex = 3;
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
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.DimGray;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(587, 329);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(83, 27);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // furnitureBindingSource
            // 
            this.furnitureBindingSource.DataSource = typeof(RentMe.Model.Furniture);
            // 
            // furnitureDataGridView
            // 
            this.furnitureDataGridView.AllowUserToAddRows = false;
            this.furnitureDataGridView.AllowUserToDeleteRows = false;
            this.furnitureDataGridView.AutoGenerateColumns = false;
            this.furnitureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.furnitureDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuantityColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.SubtotalColumn,
            this.DeleteButtonColumn});
            this.furnitureDataGridView.DataSource = this.furnitureBindingSource;
            this.furnitureDataGridView.Location = new System.Drawing.Point(16, 103);
            this.furnitureDataGridView.Name = "furnitureDataGridView";
            this.furnitureDataGridView.ReadOnly = true;
            this.furnitureDataGridView.Size = new System.Drawing.Size(654, 220);
            this.furnitureDataGridView.TabIndex = 13;
            // 
            // QuantityColumn
            // 
            this.QuantityColumn.HeaderText = "Quantity";
            this.QuantityColumn.Name = "QuantityColumn";
            this.QuantityColumn.ReadOnly = true;
            this.QuantityColumn.Width = 80;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FurnitureID";
            this.dataGridViewTextBoxColumn1.HeaderText = "FurnitureID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 130;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Style";
            this.dataGridViewTextBoxColumn3.HeaderText = "Style";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn4.HeaderText = "Category";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn5.HeaderText = "Description";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "RentalRate";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn6.HeaderText = "RentalRate";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TotalQuantity";
            this.dataGridViewTextBoxColumn7.HeaderText = "TotalQuantity";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // SubtotalColumn
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.SubtotalColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.SubtotalColumn.HeaderText = "Subtotal";
            this.SubtotalColumn.Name = "SubtotalColumn";
            this.SubtotalColumn.ReadOnly = true;
            // 
            // DeleteButtonColumn
            // 
            this.DeleteButtonColumn.HeaderText = "";
            this.DeleteButtonColumn.Name = "DeleteButtonColumn";
            this.DeleteButtonColumn.ReadOnly = true;
            this.DeleteButtonColumn.Text = "Delete";
            this.DeleteButtonColumn.UseColumnTextForButtonValue = true;
            // 
            // ViewCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 426);
            this.Controls.Add(this.furnitureDataGridView);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.rentalTotalTextBox);
            this.Controls.Add(this.rentalTotalLabel);
            this.Controls.Add(this.returnDateTimePicker);
            this.Controls.Add(this.returnDateLabel);
            this.Controls.Add(this.memberNameLabel);
            this.Controls.Add(this.orderForLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ViewCartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Cart";
            this.Load += new System.EventHandler(this.OnViewCartFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label orderForLabel;
        private System.Windows.Forms.Label memberNameLabel;
        private System.Windows.Forms.Label returnDateLabel;
        private System.Windows.Forms.DateTimePicker returnDateTimePicker;
        private System.Windows.Forms.Label rentalTotalLabel;
        private System.Windows.Forms.TextBox rentalTotalTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.BindingSource furnitureBindingSource;
        private System.Windows.Forms.DataGridView furnitureDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubtotalColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteButtonColumn;
    }
}