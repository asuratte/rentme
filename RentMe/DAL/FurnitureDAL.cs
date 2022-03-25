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
    /// Data Access Layer for Furniture items
    /// </summary>
    public class FurnitureDAL
    {
        /// <summary>
        /// Gets furniture matching specific ID 
        /// </summary>
        /// <returns>Furniture matching specific ID</returns>
        public Furniture GetFurnitureByID(string furnitureID)
        {
            string selectStatement =
                @"SELECT name, style, category, description, rentalRate, totalQuantity
                FROM furniture
                WHERE furnitureID = @FurnitureID";

            Furniture furnitureItem = new Furniture();

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@FurnitureID", System.Data.SqlDbType.VarChar);
                    selectCommand.Parameters["@FurnitureID"].Value = furnitureID;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            furnitureItem.FurnitureID = furnitureID;
                            furnitureItem.Name = reader["name"].ToString();
                            furnitureItem.Style = reader["style"].ToString();
                            furnitureItem.Category = reader["category"].ToString();
                            furnitureItem.Description = reader["description"].ToString();
                            furnitureItem.RentalRate = (decimal)reader["rentalRate"];
                            furnitureItem.TotalQuantity = (int)reader["totalQuantity"];
                        }
                        else
                        {
                            furnitureItem = null;
                        }
                    }
                }
            }
            return furnitureItem;
        }

        /// <summary>
        /// Gets furniture items matching specific category
        /// </summary>
        /// <returns>Furniture items matching specific category</returns>
        public List<Furniture> GetFurnitureByCategory(string category)
        {
            string selectStatement =
                @"SELECT furnitureID, name, style, description, rentalRate, totalQuantity
                FROM furniture
                WHERE category = @Category";

            List<Furniture> theFurnitureList = new List<Furniture>();

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@Category", System.Data.SqlDbType.VarChar);
                    selectCommand.Parameters["@Category"].Value = category;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Furniture furnitureItem = new Furniture();
                            furnitureItem.FurnitureID = reader["furnitureID"].ToString();
                            furnitureItem.Name = reader["name"].ToString();
                            furnitureItem.Style = reader["style"].ToString();
                            furnitureItem.Category = category;
                            furnitureItem.Description = reader["description"].ToString();
                            furnitureItem.RentalRate = (decimal)reader["rentalRate"];
                            furnitureItem.TotalQuantity = (int)reader["totalQuantity"];
                            theFurnitureList.Add(furnitureItem);
                        }
                    }
                }
            }
            return theFurnitureList;
        }

        /// <summary>
        /// Gets furniture items matching specific style
        /// </summary>
        /// <returns>Furniture items matching specific style</returns>
        public List<Furniture> GetFurnitureByStyle(string style)
        {
            string selectStatement =
                @"SELECT furnitureID, name, category, description, rentalRate, totalQuantity
                FROM furniture
                WHERE style = @Style";

            List<Furniture> theFurnitureList = new List<Furniture>();

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@Style", System.Data.SqlDbType.VarChar);
                    selectCommand.Parameters["@Style"].Value = style;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Furniture furnitureItem = new Furniture();
                            furnitureItem.FurnitureID = reader["furnitureID"].ToString();
                            furnitureItem.Name = reader["name"].ToString();
                            furnitureItem.Style = style;
                            furnitureItem.Category = reader["category"].ToString();
                            furnitureItem.Description = reader["description"].ToString();
                            furnitureItem.RentalRate = (decimal)reader["rentalRate"];
                            furnitureItem.TotalQuantity = (int)reader["totalQuantity"];
                            theFurnitureList.Add(furnitureItem);
                        }
                    }
                }
            }
            return theFurnitureList;
        }

        /// <summary>
        /// Gets furniture items matching specific category and style
        /// </summary>
        /// <returns>Furniture items matching specific category and style</returns>
        public List<Furniture> GetFurnitureByCategoryAndStyle(string category, string style)
        {
            string selectStatement =
                @"SELECT furnitureID, name, description, rentalRate, totalQuantity
                FROM furniture
                WHERE category = @Category AND style = @Style";

            List<Furniture> theFurnitureList = new List<Furniture>();

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@Category", System.Data.SqlDbType.VarChar);
                    selectCommand.Parameters["@Category"].Value = category;
                    selectCommand.Parameters.Add("@Style", System.Data.SqlDbType.VarChar);
                    selectCommand.Parameters["@Style"].Value = style;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Furniture furnitureItem = new Furniture();
                            furnitureItem.FurnitureID = reader["furnitureID"].ToString();
                            furnitureItem.Name = reader["name"].ToString();
                            furnitureItem.Style = style;
                            furnitureItem.Category = category;
                            furnitureItem.Description = reader["description"].ToString();
                            furnitureItem.RentalRate = (decimal)reader["rentalRate"];
                            furnitureItem.TotalQuantity = (int)reader["totalQuantity"];
                            theFurnitureList.Add(furnitureItem);
                        }
                    }
                }
            }
            return theFurnitureList;
        }

    }
}
