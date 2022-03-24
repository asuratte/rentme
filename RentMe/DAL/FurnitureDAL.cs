﻿using RentMe.Model;
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



    }
}
