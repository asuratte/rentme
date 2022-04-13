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
            this.errorMessageLabel.Text = "";
        }

        private void ClearFields()
        {
            this.usernameTextBox.Text = "";
            this.passwordTextBox.Text = "";
            this.errorMessageLabel.Text = "";
        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {
            this.errorMessageLabel.Text = "";
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(usernameTextBox.Text))
            {
                this.errorMessageLabel.Text = "Please enter a username";
                return;
            }
            else if (String.IsNullOrEmpty(passwordTextBox.Text))
            {
                this.errorMessageLabel.Text = "Please enter a password";
                return;
            }
            try
            {
                bool validCredentials = this.employeeController.CheckLoginCredentials(usernameTextBox.Text, Encryptor.EncryptString(passwordTextBox.Text));
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
                    this.errorMessageLabel.Text = "Invalid username or password";
                }
            }
            catch (Exception)
            {
                this.errorMessageLabel.Text = "There was an issue logging in";
            }
            
        }
    }
}
