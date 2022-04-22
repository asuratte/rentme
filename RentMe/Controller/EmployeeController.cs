using RentMe.DAL;
using RentMe.Model;
using System;

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
            if (username == null)
            {
                throw new ArgumentNullException("Username must not be null");
            }
            if (password == null)
            {
                throw new ArgumentNullException("Password must not be null");
            }
            return this.employeeDAL.CheckLoginCredentials(username, password);
        }

        /// <summary>
        /// Gets the employee by username.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns>Employee with the specified username.</returns>
        public Employee GetEmployeeByUsername(string username)
        {
            if (username == null)
            {
                throw new ArgumentNullException("Username must not be null");
            }
            return this.employeeDAL.GetEmployeeByUsername(username);
        }

        /// <summary>
        /// Checks if employee is admin by ID.
        /// </summary>
        /// <param name="employeeID">The employee identifier.</param>
        /// <returns>True if employee is admin.</returns>
        public bool CheckIfEmployeeIsAdmin(int employeeID)
        {
            if (employeeID < 0)
            {
                throw new ArgumentException("EmployeeID must be a positive whole number");
            }
            return this.employeeDAL.CheckIfEmployeeIsAdmin(employeeID);
        }

        /// <summary>
        /// Gets the employee first and last name by employeeID.
        /// </summary>
        /// <param name="employeeID">The employee identifier.</param>
        /// <returns>First and last name for the given employee</returns>
        public string GetEmployeeFirstAndLastNameByID(int employeeID)
        {
            if (employeeID < 0)
            {
                throw new ArgumentException("EmployeeID must be a positive whole number");
            }
            return this.employeeDAL.GetEmployeeFirstAndLastNameByID(employeeID);
        }
    }
}
