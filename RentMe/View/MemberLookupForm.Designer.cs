namespace RentMe.View
{
    partial class MemberLookupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberLookupForm));
            this.memberDataGridView = new System.Windows.Forms.DataGridView();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cancelButton = new System.Windows.Forms.Button();
            this.dataGridViewMemberIDTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewFirstNameTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLastNameTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewPhoneTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewDateOfBirthTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewSexTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewAddress1TextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewAddress2TextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCityTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewStateTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewZipCodeTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectMember = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // memberDataGridView
            // 
            this.memberDataGridView.AllowUserToAddRows = false;
            this.memberDataGridView.AllowUserToDeleteRows = false;
            this.memberDataGridView.AllowUserToOrderColumns = true;
            this.memberDataGridView.AutoGenerateColumns = false;
            this.memberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewMemberIDTextBox,
            this.dataGridViewFirstNameTextBox,
            this.dataGridViewLastNameTextBox,
            this.dataGridViewPhoneTextBox,
            this.dataGridViewDateOfBirthTextBox,
            this.dataGridViewSexTextBox,
            this.dataGridViewAddress1TextBox,
            this.dataGridViewAddress2TextBox,
            this.dataGridViewCityTextBox,
            this.dataGridViewStateTextBox,
            this.dataGridViewZipCodeTextBox,
            this.SelectMember});
            this.memberDataGridView.DataSource = this.memberBindingSource;
            this.memberDataGridView.Location = new System.Drawing.Point(12, 12);
            this.memberDataGridView.Name = "memberDataGridView";
            this.memberDataGridView.ReadOnly = true;
            this.memberDataGridView.Size = new System.Drawing.Size(659, 244);
            this.memberDataGridView.TabIndex = 2;
            this.memberDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MemberDataGridViewCellContentClick);
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataSource = typeof(RentMe.Model.Member);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.DimGray;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(587, 281);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(83, 27);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonOnClick);
            // 
            // dataGridViewMemberIDTextBox
            // 
            this.dataGridViewMemberIDTextBox.DataPropertyName = "MemberID";
            this.dataGridViewMemberIDTextBox.HeaderText = "Member ID";
            this.dataGridViewMemberIDTextBox.Name = "dataGridViewMemberIDTextBox";
            this.dataGridViewMemberIDTextBox.ReadOnly = true;
            this.dataGridViewMemberIDTextBox.Width = 95;
            // 
            // dataGridViewFirstNameTextBox
            // 
            this.dataGridViewFirstNameTextBox.DataPropertyName = "FirstName";
            this.dataGridViewFirstNameTextBox.HeaderText = "First Name";
            this.dataGridViewFirstNameTextBox.Name = "dataGridViewFirstNameTextBox";
            this.dataGridViewFirstNameTextBox.ReadOnly = true;
            this.dataGridViewFirstNameTextBox.Width = 95;
            // 
            // dataGridViewLastNameTextBox
            // 
            this.dataGridViewLastNameTextBox.DataPropertyName = "LastName";
            this.dataGridViewLastNameTextBox.HeaderText = "Last Name";
            this.dataGridViewLastNameTextBox.Name = "dataGridViewLastNameTextBox";
            this.dataGridViewLastNameTextBox.ReadOnly = true;
            this.dataGridViewLastNameTextBox.Width = 95;
            // 
            // dataGridViewPhoneTextBox
            // 
            this.dataGridViewPhoneTextBox.DataPropertyName = "Phone";
            this.dataGridViewPhoneTextBox.HeaderText = "Phone";
            this.dataGridViewPhoneTextBox.Name = "dataGridViewPhoneTextBox";
            this.dataGridViewPhoneTextBox.ReadOnly = true;
            this.dataGridViewPhoneTextBox.Width = 95;
            // 
            // dataGridViewDateOfBirthTextBox
            // 
            this.dataGridViewDateOfBirthTextBox.DataPropertyName = "DateOfBirth";
            this.dataGridViewDateOfBirthTextBox.HeaderText = "Date Of Birth";
            this.dataGridViewDateOfBirthTextBox.Name = "dataGridViewDateOfBirthTextBox";
            this.dataGridViewDateOfBirthTextBox.ReadOnly = true;
            // 
            // dataGridViewSexTextBox
            // 
            this.dataGridViewSexTextBox.DataPropertyName = "Sex";
            this.dataGridViewSexTextBox.HeaderText = "Sex";
            this.dataGridViewSexTextBox.Name = "dataGridViewSexTextBox";
            this.dataGridViewSexTextBox.ReadOnly = true;
            this.dataGridViewSexTextBox.Width = 35;
            // 
            // dataGridViewAddress1TextBox
            // 
            this.dataGridViewAddress1TextBox.DataPropertyName = "Address1";
            this.dataGridViewAddress1TextBox.HeaderText = "Address 1";
            this.dataGridViewAddress1TextBox.Name = "dataGridViewAddress1TextBox";
            this.dataGridViewAddress1TextBox.ReadOnly = true;
            this.dataGridViewAddress1TextBox.Visible = false;
            this.dataGridViewAddress1TextBox.Width = 95;
            // 
            // dataGridViewAddress2TextBox
            // 
            this.dataGridViewAddress2TextBox.DataPropertyName = "Address2";
            this.dataGridViewAddress2TextBox.HeaderText = "Address 2";
            this.dataGridViewAddress2TextBox.Name = "dataGridViewAddress2TextBox";
            this.dataGridViewAddress2TextBox.ReadOnly = true;
            this.dataGridViewAddress2TextBox.Visible = false;
            this.dataGridViewAddress2TextBox.Width = 65;
            // 
            // dataGridViewCityTextBox
            // 
            this.dataGridViewCityTextBox.DataPropertyName = "City";
            this.dataGridViewCityTextBox.HeaderText = "City";
            this.dataGridViewCityTextBox.Name = "dataGridViewCityTextBox";
            this.dataGridViewCityTextBox.ReadOnly = true;
            this.dataGridViewCityTextBox.Visible = false;
            this.dataGridViewCityTextBox.Width = 65;
            // 
            // dataGridViewStateTextBox
            // 
            this.dataGridViewStateTextBox.DataPropertyName = "State";
            this.dataGridViewStateTextBox.HeaderText = "State";
            this.dataGridViewStateTextBox.Name = "dataGridViewStateTextBox";
            this.dataGridViewStateTextBox.ReadOnly = true;
            this.dataGridViewStateTextBox.Visible = false;
            this.dataGridViewStateTextBox.Width = 45;
            // 
            // dataGridViewZipCodeTextBox
            // 
            this.dataGridViewZipCodeTextBox.DataPropertyName = "ZipCode";
            this.dataGridViewZipCodeTextBox.HeaderText = "Zip Code";
            this.dataGridViewZipCodeTextBox.Name = "dataGridViewZipCodeTextBox";
            this.dataGridViewZipCodeTextBox.ReadOnly = true;
            this.dataGridViewZipCodeTextBox.Visible = false;
            this.dataGridViewZipCodeTextBox.Width = 85;
            // 
            // SelectMember
            // 
            this.SelectMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectMember.HeaderText = "";
            this.SelectMember.Name = "SelectMember";
            this.SelectMember.ReadOnly = true;
            this.SelectMember.Text = "Select";
            this.SelectMember.UseColumnTextForButtonValue = true;
            // 
            // MemberLookupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 320);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.memberDataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MemberLookupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Lookup";
            this.Load += new System.EventHandler(this.OnMemberLookupFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource memberBindingSource;
        private System.Windows.Forms.DataGridView memberDataGridView;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewMemberIDTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewFirstNameTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewLastNameTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewPhoneTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewDateOfBirthTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewSexTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewAddress1TextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewAddress2TextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewCityTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewStateTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewZipCodeTextBox;
        private System.Windows.Forms.DataGridViewButtonColumn SelectMember;
    }
}