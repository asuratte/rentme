using RentMe.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RentMe.DAL
{
    /// <summary>
    /// Data Access Layer for States
    /// </summary>
    public class StateDAL
    {
        /// <summary>
        /// Retrieve list of all states from the state table in the database
        /// </summary>
        /// <returns>List of all states in the database</returns>
        public List<State> GetAllStates()
        {
            List<State> stateList = new List<State>();

            string selectStatement = "SELECT code, name FROM State";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            State theState = new State();
                            theState.Code = reader["code"].ToString();
                            theState.Name = reader["name"].ToString();
                            stateList.Add(theState);
                        }
                    }
                }
            }
            return stateList;
        }
    }
}
