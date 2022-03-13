using RentMe.Controller;
using RentMe.Model;
using System;
using System.Windows.Forms;

namespace RentMe.View
{
    /// <summary>
    /// Represents the login form for the RentMe application
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class LoginForm : Form
    {
        private readonly EmployeeController employeeController;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginForm"/> class.
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            this.employeeController = new EmployeeController();
            this.errorMessageLabel.Visible = false;
        }

        private void ClearFields()
        {
            this.usernameTextBox.Text = "";
            this.passwordTextBox.Text = "";
            this.errorMessageLabel.Visible = false;
        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {
            this.errorMessageLabel.Visible = false;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool validCredentials = this.employeeController.CheckLoginCredentials(usernameTextBox.Text, passwordTextBox.Text);
            if (validCredentials) 
            {
                Employee employee = this.employeeController.GetEmployeeByUsername(usernameTextBox.Text);
                bool isAdmin = this.employeeController.CheckIfEmployeeIsAdmin(employee.EmployeeID);
                
                if (isAdmin)
                {
                    using (AdminInterface adminInterface = new AdminInterface())
                    {
                        this.Hide();
                        adminInterface.SetEmployee(employee);
                        DialogResult result = adminInterface.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            this.ClearFields();
                            this.Show();
                        }
                        else if (result == DialogResult.Cancel)
                        {
                            this.Close();
                        }
                        this.usernameTextBox.Focus();
                    }
                }
                else
                {
                    using (EmployeeInterface employeeInterface = new EmployeeInterface())
                    {
                        this.Hide();
                        employeeInterface.SetEmployee(employee);
                        DialogResult result = employeeInterface.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            this.ClearFields();
                            this.Show();
                        }
                        else if (result == DialogResult.Cancel)
                        {
                            this.Close();
                        }
                        this.usernameTextBox.Focus();
                    }
                }
            }
            else
            {
                this.errorMessageLabel.Visible = true;
            }
        }
    }
}
