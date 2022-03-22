using RentMe.Model;
using System.Windows.Forms;

namespace RentMe.View
{
    /// <summary>
    /// Represents the main employee interface of the RentMe Application
    /// </summary>
    public partial class EmployeeInterface : Form
    {
        /// <summary>
        /// Initialize the employee interface
        /// </summary>
        public EmployeeInterface()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the employee information on the interface.
        /// </summary>
        /// <param name="employee">The employee.</param>
        public void SetEmployee(Employee employee)
        {
            this.employeeNameLabel.Text = employee.FirstName + " " + employee.LastName;
            this.employeeUsernameLabel.Text = employee.Username;
        }

        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void EmployeeInterfaceOnTabSelected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 0)
            {
                this.memberInformationUserControl.ResetForm();
            }
        }

        private void EmployeeInterfaceOnLoad(object sender, System.EventArgs e)
        {
            this.memberInformationUserControl.ResetForm();
        }
    }
}
