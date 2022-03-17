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
            this.theMemberRegistrationConfirmationForm = new MemberRegistrationConfirmationForm();
            this.theMemberLookupForm = new MemberLookupForm();
        }

        /// <summary>
        /// Resets the form.
        /// </summary>
        public void ResetForm()
        {
            this.LoadComboBoxes();
            this.errorMessageLabel.Text = "";
            this.ClearMemberFormInputs();
            this.ClearSearchFormInputs();
        }

        private void ClearMemberFormInputs()
        {
            this.lastNameFormTextBox.Text = "";
            this.firstNameFormTextBox.Text = "";
            this.dateOfBirthFormTextBox.Text = "";
            this.phoneFormTextBox.Text = "";
            this.address1FormTextBox.Text = "";
            this.address2FormTextBox.Text = "";
            this.cityFormTextBox.Text = "";
            this.zipCodeFormTextBox.Text = "";
            this.stateFormComboBox.SelectedIndex = 0;
            this.sexFormComboBox.SelectedIndex = 0;
            this.memberIDFormValue.Text = "";
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
            if (this.IsValidEntry()) 
            {
                try
                {
                    this.theMemberRegistrationConfirmationForm.MemberName = this.firstNameFormTextBox.Text + " " + this.lastNameFormTextBox.Text;
                    this.theMemberRegistrationConfirmationForm.MemberPhone = this.phoneFormTextBox.Text;
                    this.theMemberRegistrationConfirmationForm.MemberDateOfBirth = this.dateOfBirthFormTextBox.Text;
                    this.theMemberRegistrationConfirmationForm.MemberAddress = this.FormatAddressString(this.address1FormTextBox.Text, this.address2FormTextBox.Text, this.cityFormTextBox.Text, this.stateFormComboBox.SelectedValue.ToString(), this.zipCodeFormTextBox.Text);
                    this.theMemberRegistrationConfirmationForm.ShowDialog();
                    if (this.theMemberRegistrationConfirmationForm.DialogResult == DialogResult.OK)
                    {
                        Member newMember = this.CreateNewMember();
                        this.theMemberController.AddMember(newMember);
                        this.ClearMemberFormInputs();
                        this.errorMessageLabel.Text = "Member successfully added.";
                        this.errorMessageLabel.ForeColor = Color.Green;
                    }
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

        private string FormatPhoneNumber(string phoneNumber)
        {
            string formattedPhoneNumber = "";
            if (phoneNumber.Length == 10)
            { 
                formattedPhoneNumber = phoneNumber.Substring(0, 3) + 
                    "-" + phoneNumber.Substring(3,3) + 
                    "-" + phoneNumber.Substring(6,4);
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
            if (this.memberIDSearchTextBox.Text != null && this.memberIDSearchTextBox.Text != "")
            {
                try
                {
                    int memberID = Convert.ToInt32(this.memberIDSearchTextBox.Text);
                    Member theMember = this.theMemberController.GetMemberByID(memberID);
                    if (theMember != null)
                    {
                        theMember.Phone = this.FormatPhoneNumber(theMember.Phone);
                        memberBindingSource.Clear();
                        memberBindingSource.Add(theMember);
                        this.memberIDFormValue.Text = Convert.ToString(theMember.MemberID);
                        this.ClearSearchFormInputs();
                    }
                    else
                    {
                        this.errorMessageLabel.Text = "Cannot find member with specified ID.";
                        this.errorMessageLabel.ForeColor = Color.Red;
                    }
                }
                catch (Exception)
                {
                    this.errorMessageLabel.Text = "There was an issue retrieving member information by ID.";
                    this.errorMessageLabel.ForeColor = Color.Red;
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
                        foreach (Member theMember in theMemberList)
                        {
                            theMember.Phone = this.FormatPhoneNumber(theMember.Phone);
                        }
                        this.theMemberLookupForm.TheMemberList = theMemberList;
                        this.theMemberLookupForm.ShowDialog();
                        if (this.theMemberLookupForm.DialogResult == DialogResult.OK)
                        {
                            Member theMember = this.theMemberLookupForm.TheSelectedMember;
                            memberBindingSource.Clear();
                            memberBindingSource.Add(theMember);
                            this.memberIDFormValue.Text = Convert.ToString(theMember.MemberID);
                            this.ClearSearchFormInputs();
                        }
                    }
                    else
                    {
                        this.errorMessageLabel.Text = "Cannot find member with specified phone number.";
                        this.errorMessageLabel.ForeColor = Color.Red;
                    }
                }
                catch (Exception)
                {
                    this.errorMessageLabel.Text = "There was an issue retrieving member information by phone.";
                    this.errorMessageLabel.ForeColor = Color.Red;
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
                        foreach (Member theMember in theMemberList)
                        {
                            theMember.Phone = this.FormatPhoneNumber(theMember.Phone);
                        }
                        this.theMemberLookupForm.TheMemberList = theMemberList;
                        this.theMemberLookupForm.ShowDialog();
                        if (this.theMemberLookupForm.DialogResult == DialogResult.OK)
                        {
                            Member theMember = this.theMemberLookupForm.TheSelectedMember;
                            memberBindingSource.Clear();
                            memberBindingSource.Add(theMember);
                            this.memberIDFormValue.Text = Convert.ToString(theMember.MemberID);
                            this.ClearSearchFormInputs();
                        }
                    }
                    else
                    {
                        this.errorMessageLabel.Text = "Cannot find member with specified first and last name.";
                        this.errorMessageLabel.ForeColor = Color.Red;
                    }
                }
                catch (Exception)
                {
                    this.errorMessageLabel.Text = "There was an issue retrieving member information by first and last name.";
                    this.errorMessageLabel.ForeColor = Color.Red;
                }
            }
            else
            {
                this.errorMessageLabel.Text = "Please enter either a Member ID, a Phone Number, or both a First and Last Name before clicking Search.";
                this.errorMessageLabel.ForeColor = Color.Red;
            }
        }

        private void OnTextEntered(object sender, EventArgs e)
        {
            this.errorMessageLabel.Text = "";
            this.errorMessageLabel.ForeColor = default(Color);
        }

        private void ClearFormClick(object sender, EventArgs e)
        {
            this.ClearMemberFormInputs();
            this.ClearSearchFormInputs();
            this.errorMessageLabel.Text = "";
            this.errorMessageLabel.ForeColor = default(Color);
        }
    }
}
