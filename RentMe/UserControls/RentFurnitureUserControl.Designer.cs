
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
            this.furnitureIDTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.styleTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalRateTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityInStockTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addToCartButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.furnitureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberIDSearchTextBox = new System.Windows.Forms.TextBox();
            this.memberIDSearchLabel = new System.Windows.Forms.Label();
            this.memberSearchButton = new System.Windows.Forms.Button();
            this.viewCartButton = new System.Windows.Forms.Button();
            this.resetCartButton = new System.Windows.Forms.Button();
            this.cartForMemberLabel = new System.Windows.Forms.Label();
            this.horizontalDividerLineLabel = new System.Windows.Forms.Label();
            this.memberNameValueLabel = new System.Windows.Forms.Label();
            this.memberSearchDescriptionLabel = new System.Windows.Forms.Label();
            this.loadMemberFromLookupButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // categorySearchLabel
            // 
            this.categorySearchLabel.AutoSize = true;
            this.categorySearchLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorySearchLabel.Location = new System.Drawing.Point(44, 93);
            this.categorySearchLabel.Name = "categorySearchLabel";
            this.categorySearchLabel.Size = new System.Drawing.Size(65, 19);
            this.categorySearchLabel.TabIndex = 0;
            this.categorySearchLabel.Text = "Category";
            // 
            // styleSearchLabel
            // 
            this.styleSearchLabel.AutoSize = true;
            this.styleSearchLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styleSearchLabel.Location = new System.Drawing.Point(236, 93);
            this.styleSearchLabel.Name = "styleSearchLabel";
            this.styleSearchLabel.Size = new System.Drawing.Size(38, 19);
            this.styleSearchLabel.TabIndex = 0;
            this.styleSearchLabel.Text = "Style";
            // 
            // furnitureIDSearchTextBox
            // 
            this.furnitureIDSearchTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furnitureIDSearchTextBox.Location = new System.Drawing.Point(436, 115);
            this.furnitureIDSearchTextBox.Name = "furnitureIDSearchTextBox";
            this.furnitureIDSearchTextBox.Size = new System.Drawing.Size(131, 25);
            this.furnitureIDSearchTextBox.TabIndex = 7;
            this.furnitureIDSearchTextBox.TextChanged += new System.EventHandler(this.OnSearchValueChanged);
            // 
            // furnitureIDSearchLabel
            // 
            this.furnitureIDSearchLabel.AutoSize = true;
            this.furnitureIDSearchLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furnitureIDSearchLabel.Location = new System.Drawing.Point(432, 93);
            this.furnitureIDSearchLabel.Name = "furnitureIDSearchLabel";
            this.furnitureIDSearchLabel.Size = new System.Drawing.Size(83, 19);
            this.furnitureIDSearchLabel.TabIndex = 0;
            this.furnitureIDSearchLabel.Text = "Furniture ID";
            // 
            // furnitureSearchButton
            // 
            this.furnitureSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.furnitureSearchButton.FlatAppearance.BorderSize = 0;
            this.furnitureSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.furnitureSearchButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furnitureSearchButton.ForeColor = System.Drawing.Color.White;
            this.furnitureSearchButton.Location = new System.Drawing.Point(632, 114);
            this.furnitureSearchButton.Name = "furnitureSearchButton";
            this.furnitureSearchButton.Size = new System.Drawing.Size(79, 27);
            this.furnitureSearchButton.TabIndex = 8;
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
            this.errorMessageLabel.TabIndex = 0;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(48, 115);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(170, 25);
            this.categoryComboBox.TabIndex = 5;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.OnSearchValueChanged);
            // 
            // styleComboBox
            // 
            this.styleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.styleComboBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styleComboBox.FormattingEnabled = true;
            this.styleComboBox.Location = new System.Drawing.Point(240, 115);
            this.styleComboBox.Name = "styleComboBox";
            this.styleComboBox.Size = new System.Drawing.Size(170, 25);
            this.styleComboBox.TabIndex = 6;
            this.styleComboBox.SelectedIndexChanged += new System.EventHandler(this.OnSearchValueChanged);
            // 
            // furnitureDataGridView
            // 
            this.furnitureDataGridView.AllowUserToAddRows = false;
            this.furnitureDataGridView.AllowUserToDeleteRows = false;
            this.furnitureDataGridView.AllowUserToOrderColumns = true;
            this.furnitureDataGridView.AutoGenerateColumns = false;
            this.furnitureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.furnitureDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.furnitureIDTextBoxColumn,
            this.nameTextBoxColumn,
            this.descriptionTextBoxColumn,
            this.categoryTextBoxColumn,
            this.styleTextBoxColumn,
            this.rentalRateTextBoxColumn,
            this.quantityInStockTextBoxColumn,
            this.addToCartButtonColumn});
            this.furnitureDataGridView.DataSource = this.furnitureBindingSource;
            this.furnitureDataGridView.Location = new System.Drawing.Point(7, 165);
            this.furnitureDataGridView.Name = "furnitureDataGridView";
            this.furnitureDataGridView.ReadOnly = true;
            this.furnitureDataGridView.Size = new System.Drawing.Size(756, 210);
            this.furnitureDataGridView.TabIndex = 9;
            this.furnitureDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FurnitureDataGridViewCellContentClick);
            // 
            // furnitureIDTextBoxColumn
            // 
            this.furnitureIDTextBoxColumn.DataPropertyName = "FurnitureID";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.furnitureIDTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.furnitureIDTextBoxColumn.HeaderText = "Furniture ID";
            this.furnitureIDTextBoxColumn.Name = "furnitureIDTextBoxColumn";
            this.furnitureIDTextBoxColumn.ReadOnly = true;
            this.furnitureIDTextBoxColumn.Width = 92;
            // 
            // nameTextBoxColumn
            // 
            this.nameTextBoxColumn.DataPropertyName = "Name";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nameTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.nameTextBoxColumn.HeaderText = "Name";
            this.nameTextBoxColumn.Name = "nameTextBoxColumn";
            this.nameTextBoxColumn.ReadOnly = true;
            this.nameTextBoxColumn.Width = 105;
            // 
            // descriptionTextBoxColumn
            // 
            this.descriptionTextBoxColumn.DataPropertyName = "Description";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.descriptionTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.descriptionTextBoxColumn.HeaderText = "Description";
            this.descriptionTextBoxColumn.Name = "descriptionTextBoxColumn";
            this.descriptionTextBoxColumn.ReadOnly = true;
            this.descriptionTextBoxColumn.Visible = false;
            this.descriptionTextBoxColumn.Width = 110;
            // 
            // categoryTextBoxColumn
            // 
            this.categoryTextBoxColumn.DataPropertyName = "Category";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.categoryTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.categoryTextBoxColumn.HeaderText = "Category";
            this.categoryTextBoxColumn.Name = "categoryTextBoxColumn";
            this.categoryTextBoxColumn.ReadOnly = true;
            // 
            // styleTextBoxColumn
            // 
            this.styleTextBoxColumn.DataPropertyName = "Style";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.styleTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.styleTextBoxColumn.HeaderText = "Style";
            this.styleTextBoxColumn.Name = "styleTextBoxColumn";
            this.styleTextBoxColumn.ReadOnly = true;
            // 
            // rentalRateTextBoxColumn
            // 
            this.rentalRateTextBoxColumn.DataPropertyName = "RentalRate";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.rentalRateTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.rentalRateTextBoxColumn.HeaderText = "Rental Rate";
            this.rentalRateTextBoxColumn.Name = "rentalRateTextBoxColumn";
            this.rentalRateTextBoxColumn.ReadOnly = true;
            this.rentalRateTextBoxColumn.Width = 95;
            // 
            // quantityInStockTextBoxColumn
            // 
            this.quantityInStockTextBoxColumn.DataPropertyName = "TotalQuantity";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.quantityInStockTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.quantityInStockTextBoxColumn.HeaderText = "Quantity In Stock";
            this.quantityInStockTextBoxColumn.Name = "quantityInStockTextBoxColumn";
            this.quantityInStockTextBoxColumn.ReadOnly = true;
            this.quantityInStockTextBoxColumn.Width = 120;
            // 
            // addToCartButtonColumn
            // 
            this.addToCartButtonColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToCartButtonColumn.HeaderText = "";
            this.addToCartButtonColumn.Name = "addToCartButtonColumn";
            this.addToCartButtonColumn.ReadOnly = true;
            this.addToCartButtonColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.addToCartButtonColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.addToCartButtonColumn.Text = "Add to Cart";
            this.addToCartButtonColumn.UseColumnTextForButtonValue = true;
            // 
            // furnitureBindingSource
            // 
            this.furnitureBindingSource.DataSource = typeof(RentMe.Model.Furniture);
            // 
            // memberIDSearchTextBox
            // 
            this.memberIDSearchTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberIDSearchTextBox.Location = new System.Drawing.Point(85, 40);
            this.memberIDSearchTextBox.Name = "memberIDSearchTextBox";
            this.memberIDSearchTextBox.Size = new System.Drawing.Size(131, 25);
            this.memberIDSearchTextBox.TabIndex = 1;
            this.memberIDSearchTextBox.TextChanged += new System.EventHandler(this.OnSearchValueChanged);
            // 
            // memberIDSearchLabel
            // 
            this.memberIDSearchLabel.AutoSize = true;
            this.memberIDSearchLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberIDSearchLabel.Location = new System.Drawing.Point(3, 43);
            this.memberIDSearchLabel.Name = "memberIDSearchLabel";
            this.memberIDSearchLabel.Size = new System.Drawing.Size(79, 19);
            this.memberIDSearchLabel.TabIndex = 0;
            this.memberIDSearchLabel.Text = "Member ID";
            // 
            // memberSearchButton
            // 
            this.memberSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.memberSearchButton.FlatAppearance.BorderSize = 0;
            this.memberSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memberSearchButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberSearchButton.ForeColor = System.Drawing.Color.White;
            this.memberSearchButton.Location = new System.Drawing.Point(222, 39);
            this.memberSearchButton.Name = "memberSearchButton";
            this.memberSearchButton.Size = new System.Drawing.Size(79, 27);
            this.memberSearchButton.TabIndex = 2;
            this.memberSearchButton.Text = "Search";
            this.memberSearchButton.UseVisualStyleBackColor = false;
            this.memberSearchButton.Click += new System.EventHandler(this.MemberSearchButtonClick);
            // 
            // viewCartButton
            // 
            this.viewCartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.viewCartButton.FlatAppearance.BorderSize = 0;
            this.viewCartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewCartButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCartButton.ForeColor = System.Drawing.Color.White;
            this.viewCartButton.Location = new System.Drawing.Point(519, 39);
            this.viewCartButton.Name = "viewCartButton";
            this.viewCartButton.Size = new System.Drawing.Size(110, 27);
            this.viewCartButton.TabIndex = 3;
            this.viewCartButton.Text = "View Cart";
            this.viewCartButton.UseVisualStyleBackColor = false;
            this.viewCartButton.Click += new System.EventHandler(this.ViewCartButtonClick);
            // 
            // resetCartButton
            // 
            this.resetCartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.resetCartButton.FlatAppearance.BorderSize = 0;
            this.resetCartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetCartButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetCartButton.ForeColor = System.Drawing.Color.White;
            this.resetCartButton.Location = new System.Drawing.Point(653, 39);
            this.resetCartButton.Name = "resetCartButton";
            this.resetCartButton.Size = new System.Drawing.Size(110, 27);
            this.resetCartButton.TabIndex = 4;
            this.resetCartButton.Text = "Reset Cart";
            this.resetCartButton.UseVisualStyleBackColor = false;
            this.resetCartButton.Click += new System.EventHandler(this.ResetCartButtonClick);
            // 
            // cartForMemberLabel
            // 
            this.cartForMemberLabel.AutoSize = true;
            this.cartForMemberLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartForMemberLabel.Location = new System.Drawing.Point(515, 12);
            this.cartForMemberLabel.Name = "cartForMemberLabel";
            this.cartForMemberLabel.Size = new System.Drawing.Size(62, 19);
            this.cartForMemberLabel.TabIndex = 0;
            this.cartForMemberLabel.Text = "Cart For:";
            // 
            // horizontalDividerLineLabel
            // 
            this.horizontalDividerLineLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.horizontalDividerLineLabel.Location = new System.Drawing.Point(11, 80);
            this.horizontalDividerLineLabel.Name = "horizontalDividerLineLabel";
            this.horizontalDividerLineLabel.Size = new System.Drawing.Size(756, 2);
            this.horizontalDividerLineLabel.TabIndex = 22;
            // 
            // memberNameValueLabel
            // 
            this.memberNameValueLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberNameValueLabel.Location = new System.Drawing.Point(583, 12);
            this.memberNameValueLabel.Name = "memberNameValueLabel";
            this.memberNameValueLabel.Size = new System.Drawing.Size(180, 19);
            this.memberNameValueLabel.TabIndex = 0;
            // 
            // memberSearchDescriptionLabel
            // 
            this.memberSearchDescriptionLabel.AutoSize = true;
            this.memberSearchDescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberSearchDescriptionLabel.Location = new System.Drawing.Point(3, 12);
            this.memberSearchDescriptionLabel.Name = "memberSearchDescriptionLabel";
            this.memberSearchDescriptionLabel.Size = new System.Drawing.Size(261, 19);
            this.memberSearchDescriptionLabel.TabIndex = 0;
            this.memberSearchDescriptionLabel.Text = "Search for member by ID to create a cart:";
            // 
            // loadMemberFromLookupButton
            // 
            this.loadMemberFromLookupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.loadMemberFromLookupButton.FlatAppearance.BorderSize = 0;
            this.loadMemberFromLookupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadMemberFromLookupButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadMemberFromLookupButton.ForeColor = System.Drawing.Color.White;
            this.loadMemberFromLookupButton.Location = new System.Drawing.Point(309, 39);
            this.loadMemberFromLookupButton.Name = "loadMemberFromLookupButton";
            this.loadMemberFromLookupButton.Size = new System.Drawing.Size(176, 28);
            this.loadMemberFromLookupButton.TabIndex = 23;
            this.loadMemberFromLookupButton.Text = "Load Member From Lookup";
            this.loadMemberFromLookupButton.UseVisualStyleBackColor = false;
            this.loadMemberFromLookupButton.Click += new System.EventHandler(this.LoadMemberFromLookupButtonClick);
            // 
            // RentFurnitureUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.loadMemberFromLookupButton);
            this.Controls.Add(this.memberSearchDescriptionLabel);
            this.Controls.Add(this.memberNameValueLabel);
            this.Controls.Add(this.horizontalDividerLineLabel);
            this.Controls.Add(this.cartForMemberLabel);
            this.Controls.Add(this.resetCartButton);
            this.Controls.Add(this.viewCartButton);
            this.Controls.Add(this.memberSearchButton);
            this.Controls.Add(this.memberIDSearchLabel);
            this.Controls.Add(this.memberIDSearchTextBox);
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
        private System.Windows.Forms.TextBox memberIDSearchTextBox;
        private System.Windows.Forms.Label memberIDSearchLabel;
        private System.Windows.Forms.Button memberSearchButton;
        private System.Windows.Forms.Button viewCartButton;
        private System.Windows.Forms.Button resetCartButton;
        private System.Windows.Forms.Label cartForMemberLabel;
        private System.Windows.Forms.Label horizontalDividerLineLabel;
        private System.Windows.Forms.Label memberNameValueLabel;
        private System.Windows.Forms.Label memberSearchDescriptionLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn furnitureIDTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn styleTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalRateTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityInStockTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn addToCartButtonColumn;
        private System.Windows.Forms.Button loadMemberFromLookupButton;
    }
}
