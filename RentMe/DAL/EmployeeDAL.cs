using RentMe.Model;
using System;
using System.Data.SqlClient;

namespace RentMe.DAL
{
    /// <summary>
    /// The DAL that accesses employee data in the DB.
    /// </summary>
    public class EmployeeDAL
    {
        /// <summary>
        /// Checks the login credentials of the employee.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns>True if valid credentials.</returns>
        public bool CheckLoginCredentials(string username, string password)
        {
            int count;

            string selectStatement =
                "SELECT COUNT(*) " +
                "FROM employee " +
                "WHERE username = @username AND password = @password ";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@username", System.Data.SqlDbType.NVarChar);
                    selectCommand.Parameters["@username"].Value = username;

                    selectCommand.Parameters.Add("@password", System.Data.SqlDbType.NVarChar);
                    selectCommand.Parameters["@password"].Value = password;

                    count = Convert.ToInt32(selectCommand.ExecuteScalar());
                }
            }
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Gets the employee by username.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns>Employee with specified username.</returns>
        public Employee GetEmployeeByUsername(string username)
        {
            Employee employee = null;

            string selectStatement =
                "SELECT employeeID, firstName, lastName, username " +
                "FROM employee " +
                "WHERE username = @username";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@username", System.Data.SqlDbType.NVarChar);
                    selectCommand.Parameters["@username"].Value = username;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            employee = new Employee()
                            {
                                EmployeeID = (int)reader["employeeID"],
                                FirstName = reader["firstName"].ToString(),
                                LastName = reader["lastName"].ToString(),
                                Username = reader["username"].ToString()
                            };
                        }
                    }
                }
            }
            return employee;
        }

        /// <summary>
        /// Checks if employee is admin by ID.
        /// </summary>
        /// <param name="employeeID">The employee identifier.</param>
        /// <returns>True if employee is admin, false if not.</returns>
        public bool CheckIfEmployeeIsAdmin(int employeeID)
        {
            int count;

            string selectStatement =
                "SELECT COUNT(*) " +
                "FROM employee e JOIN admin_employee ae ON e.employeeID = ae.employeeID " +
                "WHERE e.employeeID = @employeeID ";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@employeeID", System.Data.SqlDbType.Int);
                    selectCommand.Parameters["@employeeID"].Value = employeeID;

                    count = Convert.ToInt32(selectCommand.ExecuteScalar());
                }
            }
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Gets the employee first and last name by employeeID.
        /// </summary>
        /// <param name="employeeID">The employee identifier.</param>
        /// <returns>First and last name for the given employee</returns>
        public string GetEmployeeFirstAndLastNameByID(int employeeID)
        {
            string employeeName = "";

            string selectStatement =
                @"SELECT firstName, lastName
                FROM employee 
                WHERE employeeID = @EmployeeID";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@EmployeeID", System.Data.SqlDbType.NVarChar);
                    selectCommand.Parameters["@EmployeeID"].Value = employeeID;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            employeeName = reader["firstName"].ToString() + " " + reader["lastName"].ToString();
                        }
                    }
                }
            }
            return employeeName;
        }
    }
}
