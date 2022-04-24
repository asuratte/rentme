
namespace RentMe.UserControls
{
    partial class ReturnFurnitureUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.memberIDLabel = new System.Windows.Forms.Label();
            this.memberIDTextBox = new System.Windows.Forms.TextBox();
            this.memberIDSearchButton = new System.Windows.Forms.Button();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.completeReturnTransactionButton = new System.Windows.Forms.Button();
            this.transactionTotalAmountTextBox = new System.Windows.Forms.TextBox();
            this.transactionTotalAmountLabel = new System.Windows.Forms.Label();
            this.returnedItemsListView = new System.Windows.Forms.ListView();
            this.returnedItemsListViewColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rentalItemDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewMemberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewFurnitureID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewRentalTransactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewRentalDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewDueDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnItemButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rentalItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataGridViewHeaderLabel = new System.Windows.Forms.Label();
            this.clearFormButton = new System.Windows.Forms.Button();
            this.loadMemberFromLookupButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rentalItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // memberIDLabel
            // 
            this.memberIDLabel.AutoSize = true;
            this.memberIDLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.memberIDLabel.Location = new System.Drawing.Point(11, 23);
            this.memberIDLabel.Name = "memberIDLabel";
            this.memberIDLabel.Size = new System.Drawing.Size(82, 19);
            this.memberIDLabel.TabIndex = 0;
            this.memberIDLabel.Text = "Member ID:";
            // 
            // memberIDTextBox
            // 
            this.memberIDTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberIDTextBox.Location = new System.Drawing.Point(99, 20);
            this.memberIDTextBox.Name = "memberIDTextBox";
            this.memberIDTextBox.Size = new System.Drawing.Size(135, 25);
            this.memberIDTextBox.TabIndex = 1;
            this.memberIDTextBox.TextChanged += new System.EventHandler(this.OnTextEntered);
            // 
            // memberIDSearchButton
            // 
            this.memberIDSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.memberIDSearchButton.FlatAppearance.BorderSize = 0;
            this.memberIDSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memberIDSearchButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberIDSearchButton.ForeColor = System.Drawing.Color.White;
            this.memberIDSearchButton.Location = new System.Drawing.Point(244, 19);
            this.memberIDSearchButton.Name = "memberIDSearchButton";
            this.memberIDSearchButton.Size = new System.Drawing.Size(79, 27);
            this.memberIDSearchButton.TabIndex = 2;
            this.memberIDSearchButton.Text = "Search";
            this.memberIDSearchButton.UseVisualStyleBackColor = false;
            this.memberIDSearchButton.Click += new System.EventHandler(this.MemberSearchButtonClick);
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageLabel.Location = new System.Drawing.Point(523, 19);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(245, 56);
            this.errorMessageLabel.TabIndex = 0;
            // 
            // completeReturnTransactionButton
            // 
            this.completeReturnTransactionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.completeReturnTransactionButton.FlatAppearance.BorderSize = 0;
            this.completeReturnTransactionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.completeReturnTransactionButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeReturnTransactionButton.ForeColor = System.Drawing.Color.White;
            this.completeReturnTransactionButton.Location = new System.Drawing.Point(409, 390);
            this.completeReturnTransactionButton.Name = "completeReturnTransactionButton";
            this.completeReturnTransactionButton.Size = new System.Drawing.Size(229, 27);
            this.completeReturnTransactionButton.TabIndex = 5;
            this.completeReturnTransactionButton.Text = "Complete Return Transaction";
            this.completeReturnTransactionButton.UseVisualStyleBackColor = false;
            this.completeReturnTransactionButton.Click += new System.EventHandler(this.OnCompleteReturnTransactionClick);
            // 
            // transactionTotalAmountTextBox
            // 
            this.transactionTotalAmountTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionTotalAmountTextBox.Location = new System.Drawing.Point(250, 391);
            this.transactionTotalAmountTextBox.Name = "transactionTotalAmountTextBox";
            this.transactionTotalAmountTextBox.ReadOnly = true;
            this.transactionTotalAmountTextBox.Size = new System.Drawing.Size(135, 25);
            this.transactionTotalAmountTextBox.TabIndex = 0;
            this.transactionTotalAmountTextBox.TabStop = false;
            // 
            // transactionTotalAmountLabel
            // 
            this.transactionTotalAmountLabel.AutoSize = true;
            this.transactionTotalAmountLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.transactionTotalAmountLabel.Location = new System.Drawing.Point(151, 394);
            this.transactionTotalAmountLabel.Name = "transactionTotalAmountLabel";
            this.transactionTotalAmountLabel.Size = new System.Drawing.Size(95, 19);
            this.transactionTotalAmountLabel.TabIndex = 0;
            this.transactionTotalAmountLabel.Text = "Total Amount:";
            // 
            // returnedItemsListView
            // 
            this.returnedItemsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.returnedItemsListViewColumn});
            this.returnedItemsListView.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnedItemsListView.HideSelection = false;
            this.returnedItemsListView.Location = new System.Drawing.Point(638, 118);
            this.returnedItemsListView.Name = "returnedItemsListView";
            this.returnedItemsListView.Size = new System.Drawing.Size(126, 209);
            this.returnedItemsListView.TabIndex = 4;
            this.returnedItemsListView.UseCompatibleStateImageBehavior = false;
            this.returnedItemsListView.View = System.Windows.Forms.View.Details;
            // 
            // returnedItemsListViewColumn
            // 
            this.returnedItemsListViewColumn.Text = "Returned Items";
            this.returnedItemsListViewColumn.Width = 120;
            // 
            // rentalItemDataGridView
            // 
            this.rentalItemDataGridView.AllowUserToAddRows = false;
            this.rentalItemDataGridView.AllowUserToDeleteRows = false;
            this.rentalItemDataGridView.AutoGenerateColumns = false;
            this.rentalItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentalItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewMemberID,
            this.dataGridViewFurnitureID,
            this.dataGridViewRentalTransactionID,
            this.dataGridViewQuantityColumn,
            this.dataGridViewRentalDateColumn,
            this.dataGridViewDueDateColumn,
            this.ReturnItemButton});
            this.rentalItemDataGridView.DataSource = this.rentalItemBindingSource;
            this.rentalItemDataGridView.Location = new System.Drawing.Point(15, 85);
            this.rentalItemDataGridView.Name = "rentalItemDataGridView";
            this.rentalItemDataGridView.ReadOnly = true;
            this.rentalItemDataGridView.Size = new System.Drawing.Size(604, 274);
            this.rentalItemDataGridView.TabIndex = 3;
            this.rentalItemDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReturnsDataGridViewCellContentClick);
            // 
            // dataGridViewMemberID
            // 
            this.dataGridViewMemberID.DataPropertyName = "MemberID";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewMemberID.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewMemberID.HeaderText = "Member ID";
            this.dataGridViewMemberID.Name = "dataGridViewMemberID";
            this.dataGridViewMemberID.ReadOnly = true;
            this.dataGridViewMemberID.Width = 75;
            // 
            // dataGridViewFurnitureID
            // 
            this.dataGridViewFurnitureID.DataPropertyName = "FurnitureID";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewFurnitureID.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewFurnitureID.HeaderText = "Furniture ID";
            this.dataGridViewFurnitureID.Name = "dataGridViewFurnitureID";
            this.dataGridViewFurnitureID.ReadOnly = true;
            this.dataGridViewFurnitureID.Width = 78;
            // 
            // dataGridViewRentalTransactionID
            // 
            this.dataGridViewRentalTransactionID.DataPropertyName = "TransactionID";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewRentalTransactionID.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewRentalTransactionID.HeaderText = "Rental Transaction ID";
            this.dataGridViewRentalTransactionID.Name = "dataGridViewRentalTransactionID";
            this.dataGridViewRentalTransactionID.ReadOnly = true;
            this.dataGridViewRentalTransactionID.Width = 80;
            // 
            // dataGridViewQuantityColumn
            // 
            this.dataGridViewQuantityColumn.DataPropertyName = "Quantity";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewQuantityColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewQuantityColumn.HeaderText = "Quantity";
            this.dataGridViewQuantityColumn.Name = "dataGridViewQuantityColumn";
            this.dataGridViewQuantityColumn.ReadOnly = true;
            this.dataGridViewQuantityColumn.Width = 60;
            // 
            // dataGridViewRentalDateColumn
            // 
            this.dataGridViewRentalDateColumn.DataPropertyName = "RentalDate";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.Format = "d";
            dataGridViewCellStyle11.NullValue = null;
            this.dataGridViewRentalDateColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewRentalDateColumn.HeaderText = "Rental Date";
            this.dataGridViewRentalDateColumn.Name = "dataGridViewRentalDateColumn";
            this.dataGridViewRentalDateColumn.ReadOnly = true;
            this.dataGridViewRentalDateColumn.Width = 90;
            // 
            // dataGridViewDueDateColumn
            // 
            this.dataGridViewDueDateColumn.DataPropertyName = "DueDate";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.Format = "d";
            dataGridViewCellStyle12.NullValue = null;
            this.dataGridViewDueDateColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewDueDateColumn.HeaderText = "Due Date";
            this.dataGridViewDueDateColumn.Name = "dataGridViewDueDateColumn";
            this.dataGridViewDueDateColumn.ReadOnly = true;
            this.dataGridViewDueDateColumn.Width = 82;
            // 
            // ReturnItemButton
            // 
            this.ReturnItemButton.HeaderText = "";
            this.ReturnItemButton.Name = "ReturnItemButton";
            this.ReturnItemButton.ReadOnly = true;
            this.ReturnItemButton.Text = "Return Item";
            this.ReturnItemButton.UseColumnTextForButtonValue = true;
            this.ReturnItemButton.Width = 80;
            // 
            // rentalItemBindingSource
            // 
            this.rentalItemBindingSource.DataSource = typeof(RentMe.Model.RentalItem);
            // 
            // DataGridViewHeaderLabel
            // 
            this.DataGridViewHeaderLabel.AutoSize = true;
            this.DataGridViewHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewHeaderLabel.Location = new System.Drawing.Point(13, 60);
            this.DataGridViewHeaderLabel.Name = "DataGridViewHeaderLabel";
            this.DataGridViewHeaderLabel.Size = new System.Drawing.Size(0, 15);
            this.DataGridViewHeaderLabel.TabIndex = 21;
            // 
            // clearFormButton
            // 
            this.clearFormButton.BackColor = System.Drawing.Color.DimGray;
            this.clearFormButton.FlatAppearance.BorderSize = 0;
            this.clearFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearFormButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearFormButton.ForeColor = System.Drawing.Color.White;
            this.clearFormButton.Location = new System.Drawing.Point(659, 390);
            this.clearFormButton.Name = "clearFormButton";
            this.clearFormButton.Size = new System.Drawing.Size(105, 27);
            this.clearFormButton.TabIndex = 22;
            this.clearFormButton.Text = "Clear Form";
            this.clearFormButton.UseVisualStyleBackColor = false;
            this.clearFormButton.Click += new System.EventHandler(this.OnClearFormButtonClick);
            // 
            // loadMemberFromLookupButton
            // 
            this.loadMemberFromLookupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.loadMemberFromLookupButton.FlatAppearance.BorderSize = 0;
            this.loadMemberFromLookupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadMemberFromLookupButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadMemberFromLookupButton.ForeColor = System.Drawing.Color.White;
            this.loadMemberFromLookupButton.Location = new System.Drawing.Point(329, 19);
            this.loadMemberFromLookupButton.Name = "loadMemberFromLookupButton";
            this.loadMemberFromLookupButton.Size = new System.Drawing.Size(176, 28);
            this.loadMemberFromLookupButton.TabIndex = 24;
            this.loadMemberFromLookupButton.Text = "Load Member From Lookup";
            this.loadMemberFromLookupButton.UseVisualStyleBackColor = false;
            this.loadMemberFromLookupButton.Click += new System.EventHandler(this.LoadMemberFromLookupButtonClick);
            // 
            // ReturnFurnitureUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.loadMemberFromLookupButton);
            this.Controls.Add(this.clearFormButton);
            this.Controls.Add(this.DataGridViewHeaderLabel);
            this.Controls.Add(this.rentalItemDataGridView);
            this.Controls.Add(this.returnedItemsListView);
            this.Controls.Add(this.transactionTotalAmountTextBox);
            this.Controls.Add(this.transactionTotalAmountLabel);
            this.Controls.Add(this.completeReturnTransactionButton);
            this.Controls.Add(this.errorMessageLabel);
            this.Controls.Add(this.memberIDSearchButton);
            this.Controls.Add(this.memberIDTextBox);
            this.Controls.Add(this.memberIDLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ReturnFurnitureUserControl";
            this.Size = new System.Drawing.Size(788, 437);
            ((System.ComponentModel.ISupportInitialize)(this.rentalItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label memberIDLabel;
        private System.Windows.Forms.TextBox memberIDTextBox;
        private System.Windows.Forms.Button memberIDSearchButton;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.Button completeReturnTransactionButton;
        private System.Windows.Forms.TextBox transactionTotalAmountTextBox;
        private System.Windows.Forms.Label transactionTotalAmountLabel;
        private System.Windows.Forms.ListView returnedItemsListView;
        private System.Windows.Forms.ColumnHeader returnedItemsListViewColumn;
        private System.Windows.Forms.BindingSource rentalItemBindingSource;
        private System.Windows.Forms.DataGridView rentalItemDataGridView;
        private System.Windows.Forms.Label DataGridViewHeaderLabel;
        private System.Windows.Forms.Button clearFormButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewMemberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewFurnitureID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewRentalTransactionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewQuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewRentalDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewDueDateColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ReturnItemButton;
        private System.Windows.Forms.Button loadMemberFromLookupButton;
    }
}
