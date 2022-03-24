using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RentMe.DAL
{
    /// <summary>
    /// Data Access Layer for Furniture Categories
    /// </summary>
    public class CategoryDAL
    {
        /// <summary>
        /// Retrieve list of all category names from the furniture category table in the database
        /// </summary>
        /// <returns>List of all furniture category names in the database</returns>
        public List<String> GetAllCategories()
        {
            List<String> categoryList = new List<String>();

            string selectStatement = "SELECT categoryName FROM Furniture_Category";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            String categoryName = "";
                            categoryName = reader["categoryName"].ToString();
                            categoryList.Add(categoryName);
                        }
                    }
                }
            }
            return categoryList;
        }
    }
}
