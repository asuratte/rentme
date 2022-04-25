using RentMe.Controller;
using RentMe.Model;
using RentMe.View;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        private MemberRegistrationConfirmationForm theMemberRegistrationConfirmationForm;
        private MemberLookupForm theMemberLookupForm;
        private static Member memberFromLookup = null;

        public static Member MemberFromLookup
        {
            get { return memberFromLookup; }
        }

        /// <summary>
        /// Initialize the member information user interface
        /// </summary>
        public MemberInformationUserControl()
        {
            InitializeComponent();
            this.sexList = new SortedDictionary<string, string> {
                { "", "0"},
                { "Male", "M"},
                { "Female", "F"},
                { "Other", "O"},
                { "Prefer not to say", "P"}
            };
            this.theMemberController = new MemberController();
            this.theStateController = new StateController();
            this.theMemberRegistrationConfirmationForm = new MemberRegistrationConfirmationForm();
            this.theMemberLookupForm = new MemberLookupForm();
        }

        /// <summary>
        /// Resets the form.
        /// </summary>
        public void ResetForm()
        {
            this.memberBindingSource.Clear();
            this.LoadComboBoxes();
            this.errorMessageLabel.Text = "";
            this.ClearMemberFormInputs();
            this.ClearSearchFormInputs();
            this.updateMemberInformationButton.Enabled = false;
            this.viewRentalHistoryButton.Enabled = false;
            memberFromLookup = null;
        }

        private void ClearMemberFormInputs()
        {
            this.lastNameFormTextBox.Text = "";
            this.firstNameFormTextBox.Text = "";
            this.phoneFormTextBox.Text = "";
            this.address1FormTextBox.Text = "";
            this.address2FormTextBox.Text = "";
            this.cityFormTextBox.Text = "";
            this.zipCodeFormTextBox.Text = "";
            this.stateFormComboBox.SelectedIndex = 0;
            this.sexFormComboBox.SelectedIndex = 0;
            this.memberIDFormValue.Text = "";
            this.dateOfBirthDateTimePicker.Value = DateTime.Now;
        }

        private void ClearSearchFormInputs()
        {
            this.memberIDSearchTextBox.Text = "";
            this.firstNameSearchTextBox.Text = "";
            this.lastNameSearchTextBox.Text = "";
            this.phoneSearchTextBox.Text = "";
        }

        private void LoadComboBoxes()
        {
            this.sexFormComboBox.DataSource = new BindingSource(sexList, null);
            this.sexFormComboBox.DisplayMember = "Key";
            this.sexFormComboBox.ValueMember = "Value";
            try
            {
                List<State> theStateList = this.theStateController.GetAllStates();
                theStateList.Insert(0, new State()
                {
                    Name = ""
                });
                this.stateFormComboBox.DataSource = theStateList;
                this.stateFormComboBox.DisplayMember = "Name";
                this.stateFormComboBox.ValueMember = "Code";
            }
            catch (Exception)
            {
                this.ShowErrorMessage("There was a problem getting the list of states.");
            }

        }

        private void AddNewMemberButtonClick(object sender, System.EventArgs e)
        {
            this.errorMessageLabel.Text = "";
            if (this.IsValidEntry())
            {
                try
                {
                    if (this.theMemberController.CheckMemberExists(this.firstNameFormTextBox.Text, this.lastNameFormTextBox.Text, this.UnformatPhoneNumber(this.phoneFormTextBox.Text)))
                    {
                        this.ShowErrorMessage("A member with this information already exists in the database. Try searching by First and Last Name or Phone.");
                    }
                    else
                    {
                        this.theMemberRegistrationConfirmationForm.MemberName = this.firstNameFormTextBox.Text + " " + this.lastNameFormTextBox.Text;
                        this.theMemberRegistrationConfirmationForm.MemberPhone = this.FormatPhoneNumber(this.phoneFormTextBox.Text);
                        this.theMemberRegistrationConfirmationForm.MemberDateOfBirth = this.dateOfBirthDateTimePicker.Text;
                        this.theMemberRegistrationConfirmationForm.MemberAddress = this.FormatAddressString(this.address1FormTextBox.Text, this.address2FormTextBox.Text, this.cityFormTextBox.Text, this.stateFormComboBox.SelectedValue.ToString(), this.zipCodeFormTextBox.Text);
                        this.theMemberRegistrationConfirmationForm.ShowDialog();
                        if (this.theMemberRegistrationConfirmationForm.DialogResult == DialogResult.OK)
                        {
                            Member newMember = this.CreateNewMember();
                            this.memberIDFormValue.Text = this.theMemberController.AddMember(newMember).ToString();
                            this.errorMessageLabel.Text = "Member successfully added.";
                            this.errorMessageLabel.ForeColor = Color.Green;
                            newMember.MemberID = Convert.ToInt32(memberIDFormValue.Text);
                            memberFromLookup = newMember;
                            this.updateMemberInformationButton.Enabled = true;
                        }
                    }
                }
                catch (Exception)
                {
                    this.ShowErrorMessage("There was a problem saving your input, please try again.");
                }
            }
        }

        private Member CreateNewMember()
        {
            Member newMember = new Member();
            newMember.FirstName = this.firstNameFormTextBox.Text;
            newMember.LastName = this.lastNameFormTextBox.Text;
            newMember.Sex = this.sexFormComboBox.SelectedValue.ToString();
            newMember.DateOfBirth = this.dateOfBirthDateTimePicker.Value;
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

        private string FormatPhoneNumber(string phoneNumber)
        {
            string formattedPhoneNumber = "";
            phoneNumber = this.UnformatPhoneNumber(phoneNumber);
            if (phoneNumber.Length == 10)
            {
                formattedPhoneNumber = phoneNumber.Substring(0, 3) +
                    "-" + phoneNumber.Substring(3, 3) +
                    "-" + phoneNumber.Substring(6, 4);
                return formattedPhoneNumber;
            }
            return null;
        }

        private bool IsValidEntry()
        {
            if (!Validator.IsFieldFilled(this.firstNameFormTextBox)
                || !Validator.IsFieldFilled(this.lastNameFormTextBox)
                || !Validator.IsFieldFilled(this.address1FormTextBox)
                || !Validator.IsFieldFilled(this.cityFormTextBox))
            {
                this.ShowErrorMessage("This is a required field.");
                return false;
            }
            else if (this.sexFormComboBox.SelectedIndex == 0)
            {
                this.ShowErrorMessage("Please select a Sex.");
                return false;
            }
            else if (this.stateFormComboBox.SelectedIndex == 0)
            {
                this.ShowErrorMessage("Please select a State.");
                return false;
            }
            else if (!Validator.IsPhoneNumber(this.phoneFormTextBox))
            {
                this.ShowErrorMessage("Please enter a valid phone number in the format 999-999-9999");
                return false;
            }
            else if (!Validator.IsZipCode(this.zipCodeFormTextBox))
            {
                this.ShowErrorMessage("Please enter a valid 5 digit zip code.");
                return false;
            }
            else if (this.dateOfBirthDateTimePicker.Text == DateTime.Now.ToShortDateString())
            {
                this.ShowErrorMessage("Please choose a valid date of birth.");
                return false;
            }
            return true;
        }

        private string FormatAddressString(string address1, string address2, string city, string state, string zipCode)
        {
            string formattedAddress = address1 + Environment.NewLine;
            if (address2 != null && address2 != "")
            {
                formattedAddress += (address2 + Environment.NewLine);
            }
            formattedAddress += (city + ", " + state + " " + zipCode);
            return formattedAddress;
        }

        private void MemberSearchButtonClick(object sender, EventArgs e)
        {
            this.ClearMemberFormInputs();
            this.errorMessageLabel.Text = "";
            this.viewRentalHistoryButton.Enabled = false;
            this.updateMemberInformationButton.Enabled = false;
            if (this.memberIDSearchTextBox.Text != null && this.memberIDSearchTextBox.Text != "")
            {
                try
                {
                    int memberID = Convert.ToInt32(this.memberIDSearchTextBox.Text);
                    Member theMember = this.theMemberController.GetMemberByID(memberID);
                    if (theMember != null)
                    {
                        theMember.Phone = this.FormatPhoneNumber(theMember.Phone);
                        this.memberBindingSource.Clear();
                        this.memberBindingSource.Add(theMember);
                        this.memberIDFormValue.Text = Convert.ToString(theMember.MemberID);
                        this.ClearSearchFormInputs();
                        this.updateMemberInformationButton.Enabled = true;
                        this.viewRentalHistoryButton.Enabled = true;
                        memberFromLookup = theMember;
                    }
                    else
                    {
                        this.ShowErrorMessage("Cannot find member with specified ID.");
                    }
                }
                catch (Exception)
                {
                    this.ShowErrorMessage("There was an issue retrieving member information by ID.");
                }
            }
            else if (this.phoneSearchTextBox.Text != null && this.phoneSearchTextBox.Text != "")
            {
                try
                {
                    string memberPhone = this.UnformatPhoneNumber(this.phoneSearchTextBox.Text);
                    List<Member> theMemberList = this.theMemberController.GetMembersByPhoneNumber(memberPhone);
                    if (theMemberList.Count > 0)
                    {
                        this.ShowMemberLookupForm(theMemberList);
                        if (this.theMemberLookupForm.DialogResult == DialogResult.OK)
                        {
                            this.DisplayMemberFromLookup();
                        }
                    }
                    else
                    {
                        this.ShowErrorMessage("Cannot find member with specified phone number.");
                    }
                }
                catch (Exception)
                {
                    this.ShowErrorMessage("There was an issue retrieving member information by phone.");
                }
            }
            else if (this.firstNameSearchTextBox.Text != null && this.firstNameSearchTextBox.Text != "" && this.lastNameSearchTextBox.Text != null && this.lastNameSearchTextBox.Text != "")
            {
                try
                {
                    string firstName = this.firstNameSearchTextBox.Text;
                    string lastName = this.lastNameSearchTextBox.Text;
                    List<Member> theMemberList = this.theMemberController.GetMembersByFirstAndLastName(firstName, lastName);
                    if (theMemberList.Count > 0)
                    {
                        this.ShowMemberLookupForm(theMemberList);
                        if (this.theMemberLookupForm.DialogResult == DialogResult.OK)
                        {
                            this.DisplayMemberFromLookup();
                        }
                    }
                    else
                    {
                        this.ShowErrorMessage("Cannot find member with specified first and last name.");
                    }
                }
                catch (Exception)
                {
                    this.ShowErrorMessage("There was an issue retrieving member information by first and last name.");
                }
            }
            else
            {
                this.ShowErrorMessage("Please enter either a Member ID, a Phone Number, or both a First and Last Name before clicking Search.");
            }
        }

        private void UpdateMemberButtonClick(object sender, EventArgs e)
        {
            this.errorMessageLabel.Text = "";
            if (this.IsValidEntry())
            {
                try
                {
                    Member oldMember = this.theMemberController.GetMemberByID(Convert.ToInt32(this.memberIDFormValue.Text));
                    Member newMember = this.CreateNewMember();
                    if (this.CheckIfEditsMade(oldMember, newMember))
                    {
                        bool updateSuccessful = this.theMemberController.UpdateMember(oldMember, newMember);
                        if (updateSuccessful)
                        {
                            this.errorMessageLabel.Text = "Member successfully updated.";
                            this.errorMessageLabel.ForeColor = Color.Green;
                        }
                        else
                        {
                            this.ShowErrorMessage("Member update failed. The member's data has  changed since it was last loaded. Please search for the member again to get up-to-date data.");
                        }
                    }
                    else
                    {
                        this.ShowErrorMessage("Please make an edit to the member information before clicking update.");
                    }
                }
                catch (Exception)
                {
                    this.ShowErrorMessage("There was a problem saving your input, please try again.");
                }
            }
        }

        private bool CheckIfEditsMade(Member oldMember, Member newMember)
        {
            bool editsMade;
            if (oldMember.FirstName == newMember.FirstName
                && oldMember.LastName == newMember.LastName
                && oldMember.DateOfBirth == newMember.DateOfBirth
                && oldMember.Phone == newMember.Phone
                && oldMember.Sex == newMember.Sex
                && oldMember.Address1 == newMember.Address1
                && (oldMember.Address2 == null && newMember.Address2 == "" || oldMember.Address2 == newMember.Address2)
                && oldMember.City == newMember.City
                && oldMember.State == newMember.State
                && oldMember.ZipCode == newMember.ZipCode)
            {
                editsMade = false;
            }
            else
            {
                editsMade = true;
            }
            return editsMade;
        }

        private void OnTextEntered(object sender, EventArgs e)
        {
            this.errorMessageLabel.Text = "";
            this.errorMessageLabel.ForeColor = default(Color);
        }

        private void ClearFormClick(object sender, EventArgs e)
        {
            this.ResetForm();
        }

        private void DisplayMemberFromLookup()
        {
            Member theMember = this.theMemberLookupForm.TheSelectedMember;
            this.memberBindingSource.Clear();
            this.memberBindingSource.Add(theMember);
            this.memberIDFormValue.Text = Convert.ToString(theMember.MemberID);
            this.ClearSearchFormInputs();
            this.updateMemberInformationButton.Enabled = true;
            memberFromLookup = theMember;
            this.viewRentalHistoryButton.Enabled = true;
        }

        private void ShowMemberLookupForm(List<Member> theMemberList)
        {
            foreach (Member theMember in theMemberList)
            {
                theMember.Phone = this.FormatPhoneNumber(theMember.Phone);
            }
            this.theMemberLookupForm.TheMemberList = theMemberList;
            this.theMemberLookupForm.ShowDialog();
        }

        private void ShowErrorMessage(string message)
        {
            this.errorMessageLabel.Text = message;
            this.errorMessageLabel.ForeColor = Color.Red;
        }

        private void OnComboBoxSelectionChange(object sender, EventArgs e)
        {
            this.errorMessageLabel.Text = "";
            this.errorMessageLabel.ForeColor = default(Color);
        }

        private void ViewRentalHistoryButtonClick(object sender, EventArgs e)
        {
            try
            {
                int memberID = Convert.ToInt32(this.memberIDFormValue.Text);
                using (ViewRentalHistoryForm theViewRentalHistoryForm = new ViewRentalHistoryForm())
                {
                    theViewRentalHistoryForm.MemberID = memberID;
                    theViewRentalHistoryForm.ShowDialog();
                }
            }
            catch (Exception)
            {
                this.errorMessageLabel.Text = "There was an issue retrieving the transaction history.";
                this.errorMessageLabel.ForeColor = Color.Red;
            }
        }
    }
}
