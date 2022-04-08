
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
            this.memberIDLabel = new System.Windows.Forms.Label();
            this.memberIDTextBox = new System.Windows.Forms.TextBox();
            this.memberIDSearchButton = new System.Windows.Forms.Button();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.transactionTotalAmountTextBox = new System.Windows.Forms.TextBox();
            this.transactionTotalAmountLabel = new System.Windows.Forms.Label();
            this.returnedItemsListView = new System.Windows.Forms.ListView();
            this.returnedItemsListViewColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.returnTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.returnItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.returnItemDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewMemberIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewRentalTransactionIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTransactionIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewFurnitureIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewRentalDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewDueDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnItem = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.returnTransactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnItemDataGridView)).BeginInit();
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
            this.memberIDSearchButton.TabIndex = 5;
            this.memberIDSearchButton.Text = "Search";
            this.memberIDSearchButton.UseVisualStyleBackColor = false;
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageLabel.Location = new System.Drawing.Point(344, 9);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(424, 27);
            this.errorMessageLabel.TabIndex = 16;
            this.errorMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(535, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 27);
            this.button1.TabIndex = 17;
            this.button1.Text = "Complete Return Transaction";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // transactionTotalAmountTextBox
            // 
            this.transactionTotalAmountTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionTotalAmountTextBox.Location = new System.Drawing.Point(357, 392);
            this.transactionTotalAmountTextBox.Name = "transactionTotalAmountTextBox";
            this.transactionTotalAmountTextBox.ReadOnly = true;
            this.transactionTotalAmountTextBox.Size = new System.Drawing.Size(135, 25);
            this.transactionTotalAmountTextBox.TabIndex = 19;
            // 
            // transactionTotalAmountLabel
            // 
            this.transactionTotalAmountLabel.AutoSize = true;
            this.transactionTotalAmountLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.transactionTotalAmountLabel.Location = new System.Drawing.Point(258, 395);
            this.transactionTotalAmountLabel.Name = "transactionTotalAmountLabel";
            this.transactionTotalAmountLabel.Size = new System.Drawing.Size(95, 19);
            this.transactionTotalAmountLabel.TabIndex = 18;
            this.transactionTotalAmountLabel.Text = "Total Amount:";
            // 
            // returnedItemsListView
            // 
            this.returnedItemsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.returnedItemsListViewColumn});
            this.returnedItemsListView.HideSelection = false;
            this.returnedItemsListView.Location = new System.Drawing.Point(590, 64);
            this.returnedItemsListView.Name = "returnedItemsListView";
            this.returnedItemsListView.Size = new System.Drawing.Size(174, 295);
            this.returnedItemsListView.TabIndex = 20;
            this.returnedItemsListView.UseCompatibleStateImageBehavior = false;
            this.returnedItemsListView.View = System.Windows.Forms.View.List;
            // 
            // returnedItemsListViewColumn
            // 
            this.returnedItemsListViewColumn.Text = "Returned Items";
            // 
            // returnTransactionBindingSource
            // 
            this.returnTransactionBindingSource.DataSource = typeof(RentMe.Model.ReturnTransaction);
            // 
            // returnItemBindingSource
            // 
            this.returnItemBindingSource.DataSource = typeof(RentMe.Model.ReturnItem);
            // 
            // returnItemDataGridView
            // 
            this.returnItemDataGridView.AllowUserToAddRows = false;
            this.returnItemDataGridView.AllowUserToDeleteRows = false;
            this.returnItemDataGridView.AutoGenerateColumns = false;
            this.returnItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.returnItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewMemberIDColumn,
            this.dataGridViewRentalTransactionIDColumn,
            this.dataGridViewTransactionIDColumn,
            this.dataGridViewFurnitureIDColumn,
            this.dataGridViewQuantityColumn,
            this.dataGridViewRentalDateColumn,
            this.dataGridViewDueDateColumn,
            this.ReturnItem});
            this.returnItemDataGridView.DataSource = this.returnItemBindingSource;
            this.returnItemDataGridView.Location = new System.Drawing.Point(15, 64);
            this.returnItemDataGridView.Name = "returnItemDataGridView";
            this.returnItemDataGridView.ReadOnly = true;
            this.returnItemDataGridView.Size = new System.Drawing.Size(554, 295);
            this.returnItemDataGridView.TabIndex = 20;
            // 
            // dataGridViewMemberIDColumn
            // 
            this.dataGridViewMemberIDColumn.DataPropertyName = "MemberID";
            this.dataGridViewMemberIDColumn.HeaderText = "Member ID";
            this.dataGridViewMemberIDColumn.Name = "dataGridViewMemberIDColumn";
            this.dataGridViewMemberIDColumn.ReadOnly = true;
            this.dataGridViewMemberIDColumn.Width = 70;
            // 
            // dataGridViewRentalTransactionIDColumn
            // 
            this.dataGridViewRentalTransactionIDColumn.DataPropertyName = "RentalTransactionID";
            this.dataGridViewRentalTransactionIDColumn.HeaderText = "Rental Transaction ID";
            this.dataGridViewRentalTransactionIDColumn.Name = "dataGridViewRentalTransactionIDColumn";
            this.dataGridViewRentalTransactionIDColumn.ReadOnly = true;
            this.dataGridViewRentalTransactionIDColumn.Width = 90;
            // 
            // dataGridViewTransactionIDColumn
            // 
            this.dataGridViewTransactionIDColumn.DataPropertyName = "TransactionID";
            this.dataGridViewTransactionIDColumn.HeaderText = "Transaction ID";
            this.dataGridViewTransactionIDColumn.Name = "dataGridViewTransactionIDColumn";
            this.dataGridViewTransactionIDColumn.ReadOnly = true;
            this.dataGridViewTransactionIDColumn.Visible = false;
            this.dataGridViewTransactionIDColumn.Width = 5;
            // 
            // dataGridViewFurnitureIDColumn
            // 
            this.dataGridViewFurnitureIDColumn.DataPropertyName = "FurnitureID";
            this.dataGridViewFurnitureIDColumn.HeaderText = "Furniture ID";
            this.dataGridViewFurnitureIDColumn.Name = "dataGridViewFurnitureIDColumn";
            this.dataGridViewFurnitureIDColumn.ReadOnly = true;
            this.dataGridViewFurnitureIDColumn.Width = 70;
            // 
            // dataGridViewQuantityColumn
            // 
            this.dataGridViewQuantityColumn.DataPropertyName = "Quantity";
            this.dataGridViewQuantityColumn.HeaderText = "Quantity";
            this.dataGridViewQuantityColumn.Name = "dataGridViewQuantityColumn";
            this.dataGridViewQuantityColumn.ReadOnly = true;
            this.dataGridViewQuantityColumn.Width = 70;
            // 
            // dataGridViewRentalDateColumn
            // 
            this.dataGridViewRentalDateColumn.DataPropertyName = "RentalDate";
            this.dataGridViewRentalDateColumn.HeaderText = "Rental Date";
            this.dataGridViewRentalDateColumn.Name = "dataGridViewRentalDateColumn";
            this.dataGridViewRentalDateColumn.ReadOnly = true;
            this.dataGridViewRentalDateColumn.Width = 65;
            // 
            // dataGridViewDueDateColumn
            // 
            this.dataGridViewDueDateColumn.DataPropertyName = "DueDate";
            this.dataGridViewDueDateColumn.HeaderText = "Due Date";
            this.dataGridViewDueDateColumn.Name = "dataGridViewDueDateColumn";
            this.dataGridViewDueDateColumn.ReadOnly = true;
            this.dataGridViewDueDateColumn.Width = 65;
            // 
            // ReturnItem
            // 
            this.ReturnItem.HeaderText = "";
            this.ReturnItem.Name = "ReturnItem";
            this.ReturnItem.ReadOnly = true;
            this.ReturnItem.UseColumnTextForButtonValue = true;
            this.ReturnItem.Width = 80;
            // 
            // ReturnFurnitureUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.returnItemDataGridView);
            this.Controls.Add(this.returnedItemsListView);
            this.Controls.Add(this.transactionTotalAmountTextBox);
            this.Controls.Add(this.transactionTotalAmountLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.errorMessageLabel);
            this.Controls.Add(this.memberIDSearchButton);
            this.Controls.Add(this.memberIDTextBox);
            this.Controls.Add(this.memberIDLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ReturnFurnitureUserControl";
            this.Size = new System.Drawing.Size(788, 437);
            ((System.ComponentModel.ISupportInitialize)(this.returnTransactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnItemDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label memberIDLabel;
        private System.Windows.Forms.TextBox memberIDTextBox;
        private System.Windows.Forms.Button memberIDSearchButton;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox transactionTotalAmountTextBox;
        private System.Windows.Forms.Label transactionTotalAmountLabel;
        private System.Windows.Forms.ListView returnedItemsListView;
        private System.Windows.Forms.ColumnHeader returnedItemsListViewColumn;
        private System.Windows.Forms.BindingSource returnTransactionBindingSource;
        private System.Windows.Forms.BindingSource returnItemBindingSource;
        private System.Windows.Forms.DataGridView returnItemDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewMemberIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewRentalTransactionIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTransactionIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewFurnitureIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewQuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewRentalDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewDueDateColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ReturnItem;
    }
}
