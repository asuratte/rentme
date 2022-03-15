namespace RentMe.UserControls
{
    partial class MemberInformationUserControl
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
            this.memberSearchDescriptionLabel = new System.Windows.Forms.Label();
            this.memberIDSearchLabel = new System.Windows.Forms.Label();
            this.phoneSearchLabel = new System.Windows.Forms.Label();
            this.nameSearchLabel = new System.Windows.Forms.Label();
            this.memberIDSearchTextBox = new System.Windows.Forms.TextBox();
            this.phoneSearchTextBox = new System.Windows.Forms.TextBox();
            this.nameSearchTextBox = new System.Windows.Forms.TextBox();
            this.memberSearchButton = new System.Windows.Forms.Button();
            this.horizontalDividerLineLabel = new System.Windows.Forms.Label();
            this.memberIDFormLabel = new System.Windows.Forms.Label();
            this.memberIDFormValue = new System.Windows.Forms.Label();
            this.firstNameFormLabel = new System.Windows.Forms.Label();
            this.lastNameFormTextBox = new System.Windows.Forms.TextBox();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lastNameFormLabel = new System.Windows.Forms.Label();
            this.dateOfBirthFormTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthFormLabel = new System.Windows.Forms.Label();
            this.sexFormLabel = new System.Windows.Forms.Label();
            this.phoneFormTextBox = new System.Windows.Forms.TextBox();
            this.phoneFormLabel = new System.Windows.Forms.Label();
            this.address1FormTextBox = new System.Windows.Forms.TextBox();
            this.address1FormLabel = new System.Windows.Forms.Label();
            this.address2FormTextBox = new System.Windows.Forms.TextBox();
            this.address2FormLabel = new System.Windows.Forms.Label();
            this.cityFormTextBox = new System.Windows.Forms.TextBox();
            this.cityFormLabel = new System.Windows.Forms.Label();
            this.stateFormLabel = new System.Windows.Forms.Label();
            this.zipCodeFormTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeFormLabel = new System.Windows.Forms.Label();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.addNewMemberButton = new System.Windows.Forms.Button();
            this.updateMemberInformationButton = new System.Windows.Forms.Button();
            this.firstNameFormTextBox = new System.Windows.Forms.TextBox();
            this.sexFormComboBox = new System.Windows.Forms.ComboBox();
            this.stateFormComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // memberSearchDescriptionLabel
            // 
            this.memberSearchDescriptionLabel.AutoSize = true;
            this.memberSearchDescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberSearchDescriptionLabel.Location = new System.Drawing.Point(3, 12);
            this.memberSearchDescriptionLabel.Name = "memberSearchDescriptionLabel";
            this.memberSearchDescriptionLabel.Size = new System.Drawing.Size(348, 19);
            this.memberSearchDescriptionLabel.TabIndex = 0;
            this.memberSearchDescriptionLabel.Text = "Search for member by ID, phone, or first and last name:";
            // 
            // memberIDSearchLabel
            // 
            this.memberIDSearchLabel.AutoSize = true;
            this.memberIDSearchLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberIDSearchLabel.Location = new System.Drawing.Point(3, 41);
            this.memberIDSearchLabel.Name = "memberIDSearchLabel";
            this.memberIDSearchLabel.Size = new System.Drawing.Size(79, 19);
            this.memberIDSearchLabel.TabIndex = 0;
            this.memberIDSearchLabel.Text = "Member ID";
            // 
            // phoneSearchLabel
            // 
            this.phoneSearchLabel.AutoSize = true;
            this.phoneSearchLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneSearchLabel.Location = new System.Drawing.Point(194, 41);
            this.phoneSearchLabel.Name = "phoneSearchLabel";
            this.phoneSearchLabel.Size = new System.Drawing.Size(48, 19);
            this.phoneSearchLabel.TabIndex = 0;
            this.phoneSearchLabel.Text = "Phone";
            // 
            // nameSearchLabel
            // 
            this.nameSearchLabel.AutoSize = true;
            this.nameSearchLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameSearchLabel.Location = new System.Drawing.Point(377, 41);
            this.nameSearchLabel.Name = "nameSearchLabel";
            this.nameSearchLabel.Size = new System.Drawing.Size(45, 19);
            this.nameSearchLabel.TabIndex = 0;
            this.nameSearchLabel.Text = "Name";
            // 
            // memberIDSearchTextBox
            // 
            this.memberIDSearchTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberIDSearchTextBox.Location = new System.Drawing.Point(7, 63);
            this.memberIDSearchTextBox.Name = "memberIDSearchTextBox";
            this.memberIDSearchTextBox.Size = new System.Drawing.Size(172, 25);
            this.memberIDSearchTextBox.TabIndex = 1;
            // 
            // phoneSearchTextBox
            // 
            this.phoneSearchTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneSearchTextBox.Location = new System.Drawing.Point(198, 63);
            this.phoneSearchTextBox.Name = "phoneSearchTextBox";
            this.phoneSearchTextBox.Size = new System.Drawing.Size(165, 25);
            this.phoneSearchTextBox.TabIndex = 2;
            // 
            // nameSearchTextBox
            // 
            this.nameSearchTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameSearchTextBox.Location = new System.Drawing.Point(381, 63);
            this.nameSearchTextBox.Name = "nameSearchTextBox";
            this.nameSearchTextBox.Size = new System.Drawing.Size(286, 25);
            this.nameSearchTextBox.TabIndex = 3;
            // 
            // memberSearchButton
            // 
            this.memberSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.memberSearchButton.FlatAppearance.BorderSize = 0;
            this.memberSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memberSearchButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberSearchButton.ForeColor = System.Drawing.Color.White;
            this.memberSearchButton.Location = new System.Drawing.Point(684, 62);
            this.memberSearchButton.Name = "memberSearchButton";
            this.memberSearchButton.Size = new System.Drawing.Size(79, 27);
            this.memberSearchButton.TabIndex = 4;
            this.memberSearchButton.Text = "Search";
            this.memberSearchButton.UseVisualStyleBackColor = false;
            // 
            // horizontalDividerLineLabel
            // 
            this.horizontalDividerLineLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.horizontalDividerLineLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.horizontalDividerLineLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.horizontalDividerLineLabel.Location = new System.Drawing.Point(7, 109);
            this.horizontalDividerLineLabel.Name = "horizontalDividerLineLabel";
            this.horizontalDividerLineLabel.Size = new System.Drawing.Size(757, 1);
            this.horizontalDividerLineLabel.TabIndex = 9;
            // 
            // memberIDFormLabel
            // 
            this.memberIDFormLabel.AutoSize = true;
            this.memberIDFormLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberIDFormLabel.Location = new System.Drawing.Point(3, 128);
            this.memberIDFormLabel.Name = "memberIDFormLabel";
            this.memberIDFormLabel.Size = new System.Drawing.Size(79, 19);
            this.memberIDFormLabel.TabIndex = 0;
            this.memberIDFormLabel.Text = "Member ID";
            // 
            // memberIDFormValue
            // 
            this.memberIDFormValue.AutoSize = true;
            this.memberIDFormValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberIDFormValue.Location = new System.Drawing.Point(91, 128);
            this.memberIDFormValue.Name = "memberIDFormValue";
            this.memberIDFormValue.Size = new System.Drawing.Size(33, 19);
            this.memberIDFormValue.TabIndex = 0;
            this.memberIDFormValue.Text = "###";
            // 
            // firstNameFormLabel
            // 
            this.firstNameFormLabel.AutoSize = true;
            this.firstNameFormLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameFormLabel.Location = new System.Drawing.Point(3, 160);
            this.firstNameFormLabel.Name = "firstNameFormLabel";
            this.firstNameFormLabel.Size = new System.Drawing.Size(75, 19);
            this.firstNameFormLabel.TabIndex = 0;
            this.firstNameFormLabel.Text = "First Name";
            // 
            // lastNameFormTextBox
            // 
            this.lastNameFormTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "LastName", true));
            this.lastNameFormTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameFormTextBox.Location = new System.Drawing.Point(483, 157);
            this.lastNameFormTextBox.Name = "lastNameFormTextBox";
            this.lastNameFormTextBox.Size = new System.Drawing.Size(280, 25);
            this.lastNameFormTextBox.TabIndex = 6;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataSource = typeof(RentMe.Model.Member);
            // 
            // lastNameFormLabel
            // 
            this.lastNameFormLabel.AutoSize = true;
            this.lastNameFormLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameFormLabel.Location = new System.Drawing.Point(403, 160);
            this.lastNameFormLabel.Name = "lastNameFormLabel";
            this.lastNameFormLabel.Size = new System.Drawing.Size(74, 19);
            this.lastNameFormLabel.TabIndex = 0;
            this.lastNameFormLabel.Text = "Last Name";
            // 
            // dateOfBirthFormTextBox
            // 
            this.dateOfBirthFormTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "DateOfBirth", true));
            this.dateOfBirthFormTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthFormTextBox.Location = new System.Drawing.Point(95, 193);
            this.dateOfBirthFormTextBox.Name = "dateOfBirthFormTextBox";
            this.dateOfBirthFormTextBox.Size = new System.Drawing.Size(183, 25);
            this.dateOfBirthFormTextBox.TabIndex = 7;
            // 
            // dateOfBirthFormLabel
            // 
            this.dateOfBirthFormLabel.AutoSize = true;
            this.dateOfBirthFormLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthFormLabel.Location = new System.Drawing.Point(3, 196);
            this.dateOfBirthFormLabel.Name = "dateOfBirthFormLabel";
            this.dateOfBirthFormLabel.Size = new System.Drawing.Size(87, 19);
            this.dateOfBirthFormLabel.TabIndex = 0;
            this.dateOfBirthFormLabel.Text = "Date of Birth";
            // 
            // sexFormLabel
            // 
            this.sexFormLabel.AutoSize = true;
            this.sexFormLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexFormLabel.Location = new System.Drawing.Point(298, 196);
            this.sexFormLabel.Name = "sexFormLabel";
            this.sexFormLabel.Size = new System.Drawing.Size(29, 19);
            this.sexFormLabel.TabIndex = 0;
            this.sexFormLabel.Text = "Sex";
            // 
            // phoneFormTextBox
            // 
            this.phoneFormTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "Phone", true));
            this.phoneFormTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneFormTextBox.Location = new System.Drawing.Point(595, 193);
            this.phoneFormTextBox.Name = "phoneFormTextBox";
            this.phoneFormTextBox.Size = new System.Drawing.Size(168, 25);
            this.phoneFormTextBox.TabIndex = 9;
            // 
            // phoneFormLabel
            // 
            this.phoneFormLabel.AutoSize = true;
            this.phoneFormLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneFormLabel.Location = new System.Drawing.Point(537, 196);
            this.phoneFormLabel.Name = "phoneFormLabel";
            this.phoneFormLabel.Size = new System.Drawing.Size(48, 19);
            this.phoneFormLabel.TabIndex = 0;
            this.phoneFormLabel.Text = "Phone";
            // 
            // address1FormTextBox
            // 
            this.address1FormTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "Address1", true));
            this.address1FormTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address1FormTextBox.Location = new System.Drawing.Point(95, 229);
            this.address1FormTextBox.Name = "address1FormTextBox";
            this.address1FormTextBox.Size = new System.Drawing.Size(668, 25);
            this.address1FormTextBox.TabIndex = 10;
            // 
            // address1FormLabel
            // 
            this.address1FormLabel.AutoSize = true;
            this.address1FormLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address1FormLabel.Location = new System.Drawing.Point(3, 232);
            this.address1FormLabel.Name = "address1FormLabel";
            this.address1FormLabel.Size = new System.Drawing.Size(70, 19);
            this.address1FormLabel.TabIndex = 0;
            this.address1FormLabel.Text = "Address 1";
            // 
            // address2FormTextBox
            // 
            this.address2FormTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "Address2", true));
            this.address2FormTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address2FormTextBox.Location = new System.Drawing.Point(95, 264);
            this.address2FormTextBox.Name = "address2FormTextBox";
            this.address2FormTextBox.Size = new System.Drawing.Size(668, 25);
            this.address2FormTextBox.TabIndex = 11;
            // 
            // address2FormLabel
            // 
            this.address2FormLabel.AutoSize = true;
            this.address2FormLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address2FormLabel.Location = new System.Drawing.Point(3, 267);
            this.address2FormLabel.Name = "address2FormLabel";
            this.address2FormLabel.Size = new System.Drawing.Size(70, 19);
            this.address2FormLabel.TabIndex = 0;
            this.address2FormLabel.Text = "Address 2";
            // 
            // cityFormTextBox
            // 
            this.cityFormTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "City", true));
            this.cityFormTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityFormTextBox.Location = new System.Drawing.Point(95, 299);
            this.cityFormTextBox.Name = "cityFormTextBox";
            this.cityFormTextBox.Size = new System.Drawing.Size(195, 25);
            this.cityFormTextBox.TabIndex = 12;
            // 
            // cityFormLabel
            // 
            this.cityFormLabel.AutoSize = true;
            this.cityFormLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityFormLabel.Location = new System.Drawing.Point(3, 302);
            this.cityFormLabel.Name = "cityFormLabel";
            this.cityFormLabel.Size = new System.Drawing.Size(33, 19);
            this.cityFormLabel.TabIndex = 0;
            this.cityFormLabel.Text = "City";
            // 
            // stateFormLabel
            // 
            this.stateFormLabel.AutoSize = true;
            this.stateFormLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateFormLabel.Location = new System.Drawing.Point(310, 302);
            this.stateFormLabel.Name = "stateFormLabel";
            this.stateFormLabel.Size = new System.Drawing.Size(40, 19);
            this.stateFormLabel.TabIndex = 0;
            this.stateFormLabel.Text = "State";
            // 
            // zipCodeFormTextBox
            // 
            this.zipCodeFormTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "ZipCode", true));
            this.zipCodeFormTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipCodeFormTextBox.Location = new System.Drawing.Point(630, 299);
            this.zipCodeFormTextBox.Name = "zipCodeFormTextBox";
            this.zipCodeFormTextBox.Size = new System.Drawing.Size(133, 25);
            this.zipCodeFormTextBox.TabIndex = 14;
            // 
            // zipCodeFormLabel
            // 
            this.zipCodeFormLabel.AutoSize = true;
            this.zipCodeFormLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipCodeFormLabel.Location = new System.Drawing.Point(559, 302);
            this.zipCodeFormLabel.Name = "zipCodeFormLabel";
            this.zipCodeFormLabel.Size = new System.Drawing.Size(64, 19);
            this.zipCodeFormLabel.TabIndex = 0;
            this.zipCodeFormLabel.Text = "Zip Code";
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageLabel.Location = new System.Drawing.Point(7, 342);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(756, 45);
            this.errorMessageLabel.TabIndex = 0;
            // 
            // addNewMemberButton
            // 
            this.addNewMemberButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.addNewMemberButton.FlatAppearance.BorderSize = 0;
            this.addNewMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewMemberButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewMemberButton.ForeColor = System.Drawing.Color.White;
            this.addNewMemberButton.Location = new System.Drawing.Point(7, 390);
            this.addNewMemberButton.Name = "addNewMemberButton";
            this.addNewMemberButton.Size = new System.Drawing.Size(157, 27);
            this.addNewMemberButton.TabIndex = 16;
            this.addNewMemberButton.Text = "Add New Member";
            this.addNewMemberButton.UseVisualStyleBackColor = false;
            this.addNewMemberButton.Click += new System.EventHandler(this.AddNewMemberButtonClick);
            // 
            // updateMemberInformationButton
            // 
            this.updateMemberInformationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(136)))));
            this.updateMemberInformationButton.FlatAppearance.BorderSize = 0;
            this.updateMemberInformationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateMemberInformationButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateMemberInformationButton.ForeColor = System.Drawing.Color.White;
            this.updateMemberInformationButton.Location = new System.Drawing.Point(285, 390);
            this.updateMemberInformationButton.Name = "updateMemberInformationButton";
            this.updateMemberInformationButton.Size = new System.Drawing.Size(235, 27);
            this.updateMemberInformationButton.TabIndex = 17;
            this.updateMemberInformationButton.Text = "Update Member Information";
            this.updateMemberInformationButton.UseVisualStyleBackColor = false;
            // 
            // firstNameFormTextBox
            // 
            this.firstNameFormTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "FirstName", true));
            this.firstNameFormTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameFormTextBox.Location = new System.Drawing.Point(95, 157);
            this.firstNameFormTextBox.Name = "firstNameFormTextBox";
            this.firstNameFormTextBox.Size = new System.Drawing.Size(302, 25);
            this.firstNameFormTextBox.TabIndex = 5;
            // 
            // sexFormComboBox
            // 
            this.sexFormComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.memberBindingSource, "Sex", true));
            this.sexFormComboBox.DataSource = this.memberBindingSource;
            this.sexFormComboBox.DisplayMember = "Sex";
            this.sexFormComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexFormComboBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexFormComboBox.FormattingEnabled = true;
            this.sexFormComboBox.Location = new System.Drawing.Point(333, 193);
            this.sexFormComboBox.Name = "sexFormComboBox";
            this.sexFormComboBox.Size = new System.Drawing.Size(187, 25);
            this.sexFormComboBox.TabIndex = 8;
            this.sexFormComboBox.ValueMember = "Sex";
            // 
            // stateFormComboBox
            // 
            this.stateFormComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.memberBindingSource, "State", true));
            this.stateFormComboBox.DataSource = this.memberBindingSource;
            this.stateFormComboBox.DisplayMember = "State";
            this.stateFormComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateFormComboBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateFormComboBox.FormattingEnabled = true;
            this.stateFormComboBox.Location = new System.Drawing.Point(356, 299);
            this.stateFormComboBox.Name = "stateFormComboBox";
            this.stateFormComboBox.Size = new System.Drawing.Size(185, 25);
            this.stateFormComboBox.TabIndex = 18;
            this.stateFormComboBox.ValueMember = "State";
            // 
            // MemberInformationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.stateFormComboBox);
            this.Controls.Add(this.sexFormComboBox);
            this.Controls.Add(this.firstNameFormTextBox);
            this.Controls.Add(this.updateMemberInformationButton);
            this.Controls.Add(this.addNewMemberButton);
            this.Controls.Add(this.errorMessageLabel);
            this.Controls.Add(this.zipCodeFormTextBox);
            this.Controls.Add(this.zipCodeFormLabel);
            this.Controls.Add(this.stateFormLabel);
            this.Controls.Add(this.cityFormTextBox);
            this.Controls.Add(this.cityFormLabel);
            this.Controls.Add(this.address2FormTextBox);
            this.Controls.Add(this.address2FormLabel);
            this.Controls.Add(this.address1FormTextBox);
            this.Controls.Add(this.address1FormLabel);
            this.Controls.Add(this.phoneFormTextBox);
            this.Controls.Add(this.phoneFormLabel);
            this.Controls.Add(this.sexFormLabel);
            this.Controls.Add(this.dateOfBirthFormTextBox);
            this.Controls.Add(this.dateOfBirthFormLabel);
            this.Controls.Add(this.lastNameFormTextBox);
            this.Controls.Add(this.lastNameFormLabel);
            this.Controls.Add(this.firstNameFormLabel);
            this.Controls.Add(this.memberIDFormValue);
            this.Controls.Add(this.memberIDFormLabel);
            this.Controls.Add(this.horizontalDividerLineLabel);
            this.Controls.Add(this.memberSearchButton);
            this.Controls.Add(this.nameSearchTextBox);
            this.Controls.Add(this.phoneSearchTextBox);
            this.Controls.Add(this.memberIDSearchTextBox);
            this.Controls.Add(this.nameSearchLabel);
            this.Controls.Add(this.phoneSearchLabel);
            this.Controls.Add(this.memberIDSearchLabel);
            this.Controls.Add(this.memberSearchDescriptionLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MemberInformationUserControl";
            this.Size = new System.Drawing.Size(784, 437);
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label memberSearchDescriptionLabel;
        private System.Windows.Forms.Label memberIDSearchLabel;
        private System.Windows.Forms.Label phoneSearchLabel;
        private System.Windows.Forms.Label nameSearchLabel;
        private System.Windows.Forms.TextBox memberIDSearchTextBox;
        private System.Windows.Forms.TextBox phoneSearchTextBox;
        private System.Windows.Forms.TextBox nameSearchTextBox;
        private System.Windows.Forms.Button memberSearchButton;
        private System.Windows.Forms.Label horizontalDividerLineLabel;
        private System.Windows.Forms.Label memberIDFormLabel;
        private System.Windows.Forms.Label memberIDFormValue;
        private System.Windows.Forms.Label firstNameFormLabel;
        private System.Windows.Forms.TextBox lastNameFormTextBox;
        private System.Windows.Forms.Label lastNameFormLabel;
        private System.Windows.Forms.TextBox dateOfBirthFormTextBox;
        private System.Windows.Forms.Label dateOfBirthFormLabel;
        private System.Windows.Forms.Label sexFormLabel;
        private System.Windows.Forms.TextBox phoneFormTextBox;
        private System.Windows.Forms.Label phoneFormLabel;
        private System.Windows.Forms.TextBox address1FormTextBox;
        private System.Windows.Forms.Label address1FormLabel;
        private System.Windows.Forms.TextBox address2FormTextBox;
        private System.Windows.Forms.Label address2FormLabel;
        private System.Windows.Forms.TextBox cityFormTextBox;
        private System.Windows.Forms.Label cityFormLabel;
        private System.Windows.Forms.Label stateFormLabel;
        private System.Windows.Forms.TextBox zipCodeFormTextBox;
        private System.Windows.Forms.Label zipCodeFormLabel;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.Button addNewMemberButton;
        private System.Windows.Forms.Button updateMemberInformationButton;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private System.Windows.Forms.TextBox firstNameFormTextBox;
        private System.Windows.Forms.ComboBox sexFormComboBox;
        private System.Windows.Forms.ComboBox stateFormComboBox;
    }
}
