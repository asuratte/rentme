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
        private readonly StateController theStateController;

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
            this.theStateController = new StateController();
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
            try
            {
                this.stateFormComboBox.DataSource = this.theStateController.GetAllStates();
                this.stateFormComboBox.DisplayMember = "Name";
                this.stateFormComboBox.ValueMember = "Code";
            }
            catch (Exception)
            {
                this.errorMessageLabel.Text = "There was a problem getting the list of states.";
                this.errorMessageLabel.ForeColor = Color.Red;
            }
            
        }

        private void AddNewMemberButtonClick(object sender, System.EventArgs e)
        {
            this.errorMessageLabel.Text = "";
            if (this.IsValidEntry()) { 
                try
                {
                    Member newMember = this.CreateNewMember();
                    this.theMemberController.AddMember(newMember);
                    this.errorMessageLabel.Text = "Member successfully added.";
                    this.errorMessageLabel.ForeColor = Color.Green;
                }
                catch (Exception)
                {
                    this.errorMessageLabel.Text = "There was a problem saving your input, please try again.";
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
            newMember.Phone = this.UnformatPhoneNumber(this.phoneFormTextBox.Text);
            newMember.Address1 = this.address1FormTextBox.Text;
            newMember.Address2 = this.address2FormTextBox.Text;
            newMember.City = this.cityFormTextBox.Text;
            newMember.State = this.stateFormComboBox.SelectedValue.ToString();
            newMember.ZipCode = this.zipCodeFormTextBox.Text;
            return newMember;
        }

        private string UnformatPhoneNumber(string phoneNumber)
        {
            phoneNumber = phoneNumber.Replace("-", "");
            return phoneNumber;
        }

        private bool IsValidEntry()
        {
            if (!Validator.IsFieldFilled(this.firstNameFormTextBox)
                || !Validator.IsFieldFilled(this.lastNameFormTextBox)
                || !Validator.IsFieldFilled(this.address1FormTextBox)
                || !Validator.IsFieldFilled(this.cityFormTextBox))
            {
                this.errorMessageLabel.Text = "This is a required field.";
                this.errorMessageLabel.ForeColor = Color.Red;
                return false;
            }
            else if (!Validator.IsDate(this.dateOfBirthFormTextBox))
            {
                this.errorMessageLabel.Text = "Please enter a valid date in the format mm/dd/yyyy.";
                this.errorMessageLabel.ForeColor = Color.Red;
                return false;
            }
            else if (!Validator.IsPhoneNumber(this.phoneFormTextBox))
            {
                this.errorMessageLabel.Text = "Please enter a valid phone number in the format 999-999-9999";
                this.errorMessageLabel.ForeColor = Color.Red;
                return false;
            }
            else if (!Validator.IsZipCode(this.zipCodeFormTextBox))
            {
                this.errorMessageLabel.Text = "Please enter a valid 6 digit zip code.";
                this.errorMessageLabel.ForeColor = Color.Red;
                return false;
            }
            return true;
        }
    }
}
