using RentMe.Controller;
using RentMe.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace RentMe.UserControls
{
    /// <summary>
    /// Represents the member information user interface
    /// </summary>
    public partial class MemberInformationUserControl : UserControl
    {
        private readonly SortedDictionary<string, string> sexList;
        private readonly MemberController theMemberController;

        /// <summary>
        /// Initialize the member information user interface
        /// </summary>
        public MemberInformationUserControl()
        {
            InitializeComponent();
            this.sexList = new SortedDictionary<string, string> {
                { "Male", "M"},
                { "Female", "F"},
                { "Other", "O"},
                { "Prefer not to say", "P"}
            };
            this.theMemberController = new MemberController();
        }

        /// <summary>
        /// Resets the form.
        /// </summary>
        public void ResetForm()
        {
            this.LoadComboBoxes();
            this.errorMessageLabel.Text = "";
        }

        private void LoadComboBoxes()
        {
            this.sexFormComboBox.DataSource = new BindingSource(sexList, null);
            this.sexFormComboBox.DisplayMember = "Key";
            this.sexFormComboBox.ValueMember = "Value";
        }

        private void AddNewMemberButtonClick(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(this.firstNameFormTextBox.Text))
            {
                this.errorMessageLabel.Text = "First Name must not be blank.";
                this.errorMessageLabel.ForeColor = Color.Red;
            }
            else if (string.IsNullOrEmpty(this.lastNameFormTextBox.Text))
            {
                this.errorMessageLabel.Text = "Last Name must not be blank.";
                this.errorMessageLabel.ForeColor = Color.Red;
            }
            else if (string.IsNullOrEmpty(this.dateOfBirthFormTextBox.Text))
            {
                this.errorMessageLabel.Text = "Date of Birth must not be blank.";
                this.errorMessageLabel.ForeColor = Color.Red;
            }
            else if (!DateTime.TryParseExact(this.dateOfBirthFormTextBox.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateOfBirth))
            {
                this.errorMessageLabel.Text = "Date of Birth must be in MM/DD/YYYY format.";
                this.errorMessageLabel.ForeColor = Color.Red;
            }
            else if (string.IsNullOrEmpty(this.phoneFormTextBox.Text))
            {
                this.errorMessageLabel.Text = "Phone must not be blank.";
                this.errorMessageLabel.ForeColor = Color.Red;
            }
            else if (string.IsNullOrEmpty(this.address1FormTextBox.Text))
            {
                this.errorMessageLabel.Text = "Address 1 must not be blank.";
                this.errorMessageLabel.ForeColor = Color.Red;
            }
            else if (string.IsNullOrEmpty(this.cityFormTextBox.Text))
            {
                this.errorMessageLabel.Text = "City must not be blank.";
                this.errorMessageLabel.ForeColor = Color.Red;
            }
            else if (string.IsNullOrEmpty(this.zipCodeFormTextBox.Text) || this.zipCodeFormTextBox.Text.Length != 5)
            {
                this.errorMessageLabel.Text = "Zip Code must be a 5 digit number.";
                this.errorMessageLabel.ForeColor = Color.Red;
            }
            else
            {
                try
                {
                    Member newMember = this.CreateNewMember();
                    this.theMemberController.AddMember(newMember);
                    this.errorMessageLabel.Text = "Member successfully added. ";
                    this.errorMessageLabel.ForeColor = Color.Green;
                }
                catch (Exception ex)
                {
                    this.errorMessageLabel.Text = "Invalid input, please try again. " + ex.Message;
                    this.errorMessageLabel.ForeColor = Color.Red;
                }
            }
        }

        private Member CreateNewMember()
        {
            Member newMember = new Member();
            newMember.FirstName = this.firstNameFormTextBox.Text;
            newMember.LastName = this.lastNameFormTextBox.Text;
            newMember.Sex = this.sexFormComboBox.SelectedValue.ToString();
            newMember.DateOfBirth = Convert.ToDateTime(this.dateOfBirthFormTextBox.Text);
            newMember.Phone = this.phoneFormTextBox.Text;
            newMember.Address1 = this.address1FormTextBox.Text;
            newMember.Address2 = this.address2FormTextBox.Text;
            newMember.City = this.cityFormTextBox.Text;
            newMember.State = this.stateFormTextBox.Text;
            newMember.ZipCode = this.zipCodeFormTextBox.Text;
            return newMember;
        }
    }
}
