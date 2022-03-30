using RentMe.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RentMe.DAL
{
    /// <summary>
    /// Data Access Layer for Furniture Categories
    /// </summary>
    public class FurnitureCategoryDAL
    {
        /// <summary>
        /// Retrieve list of all category names from the furniture category table in the database
        /// </summary>
        /// <returns>List of all furniture category names in the database</returns>
        public List<FurnitureCategory> GetAllFurnitureCategories()
        {
            List<FurnitureCategory> categoryList = new List<FurnitureCategory>();

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
                            FurnitureCategory furnitureCategory = new FurnitureCategory();
                            furnitureCategory.CategoryName = reader["categoryName"].ToString();
                            categoryList.Add(furnitureCategory);
                        }
                    }
                }
            }
            return categoryList;
        }
    }
}
