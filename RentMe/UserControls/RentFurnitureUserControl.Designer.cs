
namespace RentMe.UserControls
{
    partial class RentFurnitureUserControl
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

        #region Component Designer generated code

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
            this.categorySearchLabel = new System.Windows.Forms.Label();
            this.styleSearchLabel = new System.Windows.Forms.Label();
            this.furnitureIDSearchTextBox = new System.Windows.Forms.TextBox();
            this.furnitureIDSearchLabel = new System.Windows.Forms.Label();
            this.furnitureSearchButton = new System.Windows.Forms.Button();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.styleComboBox = new System.Windows.Forms.ComboBox();
            this.furnitureDataGridView = new System.Windows.Forms.DataGridView();
            this.furnitureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // categorySearchLabel
            // 
            this.categorySearchLabel.AutoSize = true;
            this.categorySearchLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorySearchLabel.Location = new System.Drawing.Point(44, 77);
            this.categorySearchLabel.Name = "categorySearchLabel";
            this.categorySearchLabel.Size = new System.Drawing.Size(65, 19);
            this.categorySearchLabel.TabIndex = 8;
            this.categorySearchLabel.Text = "Category";
            // 
            // styleSearchLabel
            // 
            this.styleSearchLabel.AutoSize = true;
            this.styleSearchLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styleSearchLabel.Location = new System.Drawing.Point(236, 77);
            this.styleSearchLabel.Name = "styleSearchLabel";
            this.styleSearchLabel.Size = new System.Drawing.Size(38, 19);
            this.styleSearchLabel.TabIndex = 10;
            this.styleSearchLabel.Text = "Style";
            // 
            // furnitureIDSearchTextBox
            // 
            this.furnitureIDSearchTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furnitureIDSearchTextBox.Location = new System.Drawing.Point(436, 99);
            this.furnitureIDSearchTextBox.Name = "furnitureIDSearchTextBox";
            this.furnitureIDSearchTextBox.Size = new System.Drawing.Size(131, 25);
            this.furnitureIDSearchTextBox.TabIndex = 13;
            // 
            // furnitureIDSearchLabel
            // 
            this.furnitureIDSearchLabel.AutoSize = true;
            this.furnitureIDSearchLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furnitureIDSearchLabel.Location = new System.Drawing.Point(432, 77);
            this.furnitureIDSearchLabel.Name = "furnitureIDSearchLabel";
            this.furnitureIDSearchLabel.Size = new System.Drawing.Size(83, 19);
            this.furnitureIDSearchLabel.TabIndex = 12;
            this.furnitureIDSearchLabel.Text = "Furniture ID";
            // 
            // furnitureSearchButton
            // 
            this.furnitureSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.furnitureSearchButton.FlatAppearance.BorderSize = 0;
            this.furnitureSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.furnitureSearchButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furnitureSearchButton.ForeColor = System.Drawing.Color.White;
            this.furnitureSearchButton.Location = new System.Drawing.Point(632, 98);
            this.furnitureSearchButton.Name = "furnitureSearchButton";
            this.furnitureSearchButton.Size = new System.Drawing.Size(79, 27);
            this.furnitureSearchButton.TabIndex = 14;
            this.furnitureSearchButton.Text = "Search";
            this.furnitureSearchButton.UseVisualStyleBackColor = false;
            this.furnitureSearchButton.Click += new System.EventHandler(this.FurnitureSearchButtonClick);
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageLabel.Location = new System.Drawing.Point(7, 382);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(756, 45);
            this.errorMessageLabel.TabIndex = 15;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(48, 99);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(170, 25);
            this.categoryComboBox.TabIndex = 16;
            // 
            // styleComboBox
            // 
            this.styleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.styleComboBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styleComboBox.FormattingEnabled = true;
            this.styleComboBox.Location = new System.Drawing.Point(240, 99);
            this.styleComboBox.Name = "styleComboBox";
            this.styleComboBox.Size = new System.Drawing.Size(170, 25);
            this.styleComboBox.TabIndex = 17;
            // 
            // furnitureDataGridView
            // 
            this.furnitureDataGridView.AllowUserToAddRows = false;
            this.furnitureDataGridView.AllowUserToDeleteRows = false;
            this.furnitureDataGridView.AllowUserToOrderColumns = true;
            this.furnitureDataGridView.AutoGenerateColumns = false;
            this.furnitureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.furnitureDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.furnitureDataGridView.DataSource = this.furnitureBindingSource;
            this.furnitureDataGridView.Location = new System.Drawing.Point(11, 144);
            this.furnitureDataGridView.Name = "furnitureDataGridView";
            this.furnitureDataGridView.ReadOnly = true;
            this.furnitureDataGridView.Size = new System.Drawing.Size(752, 212);
            this.furnitureDataGridView.TabIndex = 18;
            // 
            // furnitureBindingSource
            // 
            this.furnitureBindingSource.DataSource = typeof(RentMe.Model.Furniture);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FurnitureID";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.HeaderText = "Furniture ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 95;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Description";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn5.HeaderText = "Description";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 110;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Category";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn4.HeaderText = "Category";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Style";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn3.HeaderText = "Style";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "RentalRate";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn6.HeaderText = "Rental Rate";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TotalQuantity";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn7.HeaderText = "Quantity in Stock";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // RentFurnitureUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.furnitureDataGridView);
            this.Controls.Add(this.styleComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.errorMessageLabel);
            this.Controls.Add(this.furnitureSearchButton);
            this.Controls.Add(this.furnitureIDSearchTextBox);
            this.Controls.Add(this.furnitureIDSearchLabel);
            this.Controls.Add(this.styleSearchLabel);
            this.Controls.Add(this.categorySearchLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RentFurnitureUserControl";
            this.Size = new System.Drawing.Size(784, 437);
            ((System.ComponentModel.ISupportInitialize)(this.furnitureDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label categorySearchLabel;
        private System.Windows.Forms.Label styleSearchLabel;
        private System.Windows.Forms.TextBox furnitureIDSearchTextBox;
        private System.Windows.Forms.Label furnitureIDSearchLabel;
        private System.Windows.Forms.Button furnitureSearchButton;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox styleComboBox;
        private System.Windows.Forms.BindingSource furnitureBindingSource;
        private System.Windows.Forms.DataGridView furnitureDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}
