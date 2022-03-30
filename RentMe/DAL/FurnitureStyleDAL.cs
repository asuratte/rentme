using RentMe.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RentMe.DAL
{
    /// <summary>
    /// Data Access Layer for Furniture Styles
    /// </summary>
    public class FurnitureStyleDAL
    {
        /// <summary>
        /// Retrieve list of all style names from the furniture style table in the database
        /// </summary>
        /// <returns>List of all furniture style names in the database</returns>
        public List<FurnitureStyle> GetAllFurnitureStyles()
        {
            List<FurnitureStyle> styleList = new List<FurnitureStyle>();

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
                            FurnitureStyle furnitureStyle = new FurnitureStyle();
                            furnitureStyle.StyleName = reader["styleName"].ToString();
                            styleList.Add(furnitureStyle);
                        }
                    }
                }
            }
            return styleList;
        }
    }
}
