using RentMe.DAL;
using RentMe.Model;

namespace RentMe.Controller
{
    /// <summary>
    /// Defines a controller class that mediates between the EmployeeDAL and the view.
    /// </summary>
    public class EmployeeController
    {
        private readonly EmployeeDAL employeeDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeController"/> class.
        /// </summary>
        public EmployeeController()
        {
            this.employeeDAL = new EmployeeDAL();
        }

        /// <summary>
        /// Checks the login credentials of the employee.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns>True if credentials are valid.</returns>
        public bool CheckLoginCredentials(string username, string password)
        {
            return this.employeeDAL.CheckLoginCredentials(username, password);
        }

        /// <summary>
        /// Gets the employee by username.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns>Employee with the specified username.</returns>
        public Employee GetEmployeeByUsername(string username)
        {
            return this.employeeDAL.GetEmployeeByUsername(username);
        }

        /// <summary>
        /// Checks if employee is admin by ID.
        /// </summary>
        /// <param name="employeeID">The employee identifier.</param>
        /// <returns>True if employee is admin.</returns>
        public bool CheckIfEmployeeIsAdmin(int employeeID)
        {
            return this.employeeDAL.CheckIfEmployeeIsAdmin(employeeID);
        }
    }
}
