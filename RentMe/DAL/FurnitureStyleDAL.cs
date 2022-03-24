using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RentMe.DAL
{
    public class FurnitureStyleDAL
    {
        /// <summary>
        /// Retrieve list of all style names from the furniture style table in the database
        /// </summary>
        /// <returns>List of all furniture style names in the database</returns>
        public List<String> GetAllFurnitureStyles()
        {
            List<String> styleList = new List<String>();

            string selectStatement = "SELECT styleName FROM Furniture_Style";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            String styleName = reader["styleName"].ToString();
                            styleList.Add(styleName);
                        }
                    }
                }
            }
            return styleList;
        }
    }
}
