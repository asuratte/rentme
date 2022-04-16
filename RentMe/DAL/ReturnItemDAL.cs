using RentMe.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RentMe.DAL
{
    /// <summary>
    /// Data Access Layer for Return Items
    /// </summary>
    public class ReturnItemDAL
    {
        /// <summary>
        /// Gets the return items by transactionID.
        /// </summary>
        /// <param name="transactionID">The transaction identifier.</param>
        /// <returns>List of return items for a given transaction ID</returns>
        public List<ReturnItem> GetReturnItemsByTransactionID(int transactionID)
        {
            string selectStatement =
            @"SELECT ri.quantity, ri.furnitureID, f.name, f.rentalRate
              FROM return_item ri
              JOIN furniture f ON ri.furnitureID = f.furnitureID
              WHERE transactionID = @TransactionID";

            List<ReturnItem> theReturnItemList = new List<ReturnItem>();

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@TransactionID", System.Data.SqlDbType.Int);
                    selectCommand.Parameters["@TransactionID"].Value = transactionID;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ReturnItem theReturnItem = new ReturnItem();
                            theReturnItem.TransactionID = transactionID;
                            theReturnItem.FurnitureID = reader["furnitureID"].ToString();
                            theReturnItem.FurnitureName = reader["name"].ToString();
                            theReturnItem.Quantity = Convert.ToInt32(reader["quantity"]);
                            theReturnItem.RentalRate = Convert.ToDecimal(reader["rentalRate"]);
                            theReturnItemList.Add(theReturnItem);
                        }
                    }
                }
            }
            return theReturnItemList;
        }
    }
}
