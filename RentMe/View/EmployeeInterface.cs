using RentMe.Model;
using System.Windows.Forms;

namespace RentMe.View
{
    /// <summary>
    /// Represents the main employee interface of the RentMe Application
    /// </summary>
    public partial class EmployeeInterface : Form
    {
        private Employee theEmployee;

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
            this.theEmployee = employee;
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
            else if (e.TabPageIndex == 1)
            {
                this.rentFurnitureUserControl.ResetForm();
            }
            else if (e.TabPageIndex == 2)
            {
                this.returnFurnitureUserControl.ResetForm();
                this.returnFurnitureUserControl.TheEmployee = this.theEmployee;
            }
        }

        private void EmployeeInterfaceOnLoad(object sender, System.EventArgs e)
        {
            this.memberInformationUserControl.ResetForm();
        }
    }
}
