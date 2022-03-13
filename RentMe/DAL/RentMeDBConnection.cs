using System.Data.SqlClient;

namespace RentMe.DAL
{
    /// <summary>
    /// Defines the database connection class.
    /// </summary>
    public static class RentMeDBConnection
    {
        /// <summary>
        /// Gets the connection to the RentMe database.
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=localhost;" +
                "Initial Catalog=cs6232-g1;" +
                "Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
