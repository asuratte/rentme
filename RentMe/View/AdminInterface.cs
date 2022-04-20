using RentMe.Model;
using System.Windows.Forms;

namespace RentMe.View
{
    /// <summary>
    /// Represents the main admin interface of the RentMe Application
    /// </summary>
    public partial class AdminInterface : Form
    {
        private Employee theEmployee;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminInterface"/> class.
        /// </summary>
        public AdminInterface()
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

        private void AdminInterfaceOnLoad(object sender, System.EventArgs e)
        {
            this.popularFurnitureReportUserControl.TheEmployee = this.theEmployee;
        }
    }
}
