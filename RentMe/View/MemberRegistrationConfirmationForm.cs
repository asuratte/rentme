using System;
using System.Windows.Forms;

namespace RentMe.View
{
    /// <summary>
    /// Represents the Member Registration Confirmation Form
    /// </summary>
    public partial class MemberRegistrationConfirmationForm : Form
    {
        private string memberName;
        private string memberPhone;
        private string memberDateOfBirth;
        private string memberAddress;

        public string MemberName
        {
            get { return this.memberName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name not provided");
                }
                this.memberName = value;
                this.memberNameValue.Text = this.memberName;
            }
        }

        public string MemberPhone
        {
            get { return this.memberPhone; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Phone number not provided");
                }
                this.memberPhone = value;
                this.memberPhoneValue.Text = this.memberPhone;
            }
        }

        public string MemberDateOfBirth
        {
            get { return this.memberDateOfBirth; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Date of birth not provided");
                }
                this.memberDateOfBirth = value;
                this.memberDateOfBirthValue.Text = this.memberDateOfBirth;
            }
        }

        public string MemberAddress
        {
            get { return this.memberAddress; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Address not provided");
                }
                this.memberAddress = value;
                this.memberAddressValue.Text = this.memberAddress;
            }
        }

        /// <summary>
        /// Initialize the Member Registration Confirmation Form
        /// </summary>
        public MemberRegistrationConfirmationForm()
        {
            InitializeComponent();
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ConfirmAddButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
