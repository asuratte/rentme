using RentMe.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                "SELECT firstName, lastName, username " +
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
    }
}
