using RentMe.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RentMe.DAL
{
    /// <summary>
    /// Data Access Layer for Rental Transaction
    /// </summary>
    public class RentalTransactionDAL
    {
        /// <summary>
        /// Adds the rental transaction and items to the database.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        /// <param name="employeeID">The employee identifier.</param>
        /// <param name="rentalItemsList">The rental items list.</param>
        /// <param name="dueDate">The due date.</param>
        /// <returns>The rental transaction ID.</returns>
        public int AddRentalTransactionAndItems(int memberID, int employeeID, List<RentalItem> rentalItemsList, DateTime dueDate)
        {
            string insertRentalTransactionStatement =
                @"INSERT INTO rental_transaction (memberID, employeeID, rentalDate, dueDate) 
                VALUES (@MemberID, @EmployeeID, @RentalDate, @DueDate)";

            string selectTransactionIDStatement = "SELECT @@Identity";

            string insertRentalItemStatement =
                @"INSERT INTO rental_item (transactionID, furnitureID, quantity) 
                VALUES (@TransactionID, @FurnitureID, @Quantity)";

            string updateFurnitureInventoryStatement =
                @"UPDATE furniture SET
                   totalQuantity = totalQuantity - @QuantityRented
                WHERE furnitureID = @FurnitureID";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                int transactionID = 0;
                try
                {
                    using (SqlCommand insertCommand = new SqlCommand(insertRentalTransactionStatement, connection))
                    {
                        insertCommand.Transaction = transaction;
                        insertCommand.Parameters.Add("@MemberID", System.Data.SqlDbType.Int);
                        insertCommand.Parameters["@MemberID"].Value = memberID;
                        insertCommand.Parameters.Add("@EmployeeID", System.Data.SqlDbType.Int);
                        insertCommand.Parameters["@EmployeeID"].Value = employeeID;
                        insertCommand.Parameters.Add("@RentalDate", System.Data.SqlDbType.DateTime);
                        insertCommand.Parameters["@RentalDate"].Value = DateTime.Now;
                        insertCommand.Parameters.Add("@DueDate", System.Data.SqlDbType.DateTime);
                        insertCommand.Parameters["@DueDate"].Value = dueDate;
                        insertCommand.ExecuteNonQuery();
                    }
                    using (SqlCommand selectCommand = new SqlCommand(selectTransactionIDStatement, connection))
                    {
                        selectCommand.Transaction = transaction;
                        transactionID = Convert.ToInt32(selectCommand.ExecuteScalar());
                    }
                    using (SqlCommand insertCommand = new SqlCommand(insertRentalItemStatement, connection))
                    {
                        insertCommand.Transaction = transaction;
                        foreach (RentalItem theRentalItem in rentalItemsList)
                        {
                            insertCommand.Parameters.Add("@TransactionID", System.Data.SqlDbType.Int);
                            insertCommand.Parameters["@TransactionID"].Value = transactionID;
                            insertCommand.Parameters.Add("@FurnitureID", System.Data.SqlDbType.VarChar);
                            insertCommand.Parameters["@FurnitureID"].Value = theRentalItem.FurnitureID;
                            insertCommand.Parameters.Add("@Quantity", System.Data.SqlDbType.Int);
                            insertCommand.Parameters["@Quantity"].Value = theRentalItem.Quantity;
                            insertCommand.ExecuteNonQuery();
                            insertCommand.Parameters.Clear();
                        }
                    }
                    using (SqlCommand updateCommand = new SqlCommand(updateFurnitureInventoryStatement, connection))
                    {
                        updateCommand.Transaction = transaction;
                        foreach (RentalItem theRentalItem in rentalItemsList)
                        {
                            updateCommand.Parameters.Add("@FurnitureID", System.Data.SqlDbType.VarChar);
                            updateCommand.Parameters["@FurnitureID"].Value = theRentalItem.FurnitureID;
                            updateCommand.Parameters.Add("@QuantityRented", System.Data.SqlDbType.Int);
                            updateCommand.Parameters["@QuantityRented"].Value = theRentalItem.Quantity;
                            updateCommand.ExecuteNonQuery();
                            updateCommand.Parameters.Clear();
                        }
                    }
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
                return transactionID;
            }
        }

        /// <summary>
        /// Gets all rental transactions by member identifier.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        /// <returns>The list of rental transactions for the specified member ID.</returns>
        public List<RentalTransaction> GetAllRentalTransactionsByMemberID(int memberID)
        {
            List<RentalTransaction> rentalTransactionList = new List<RentalTransaction>();

            string selectStatement =
                @"SELECT transactionID, memberID, employeeID, rentalDate, dueDate
                FROM rental_transaction
                WHERE memberID = @MemberID";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@MemberID", System.Data.SqlDbType.Int);
                    selectCommand.Parameters["@MemberID"].Value = memberID;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            RentalTransaction theRentalTransaction = new RentalTransaction
                            {
                                TransactionID = (int)reader["transactionID"],
                                MemberID = memberID,
                                EmployeeID = (int)reader["employeeID"],
                                RentalDate = (DateTime)reader["rentalDate"],
                                DueDate = (DateTime)reader["dueDate"]
                            };
                            rentalTransactionList.Add(theRentalTransaction);
                        }
                    }
                }
            }
            return rentalTransactionList;
        }
    }
}
