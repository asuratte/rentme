using RentMe.Model;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RentMe.DAL
{
    /// <summary>
    /// Data Access Layer for Return Transaction
    /// </summary>
    public class ReturnTransactionDAL
    {
        /// <summary>
        /// Adds the return transaction and items to the database.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        /// <param name="employeeID">The employee identifier.</param>
        /// <param name="returnedItemsListView">The returned items ListView.</param>
        /// <returns>The return transaction ID</returns>
        public int AddReturnTransactionAndItems(int memberID, int employeeID, ListView returnedItemsListView)
        {
            string insertReturnTransactionStatement =
                @"INSERT INTO return_transaction (memberID, employeeID, returnDate) 
                VALUES (@MemberID, @EmployeeID, @ReturnDate)";

            string selectTransactionID = "SELECT @@Identity";

            string insertReturnItemStatement =
                @"INSERT INTO return_item (transactionID, rentalTransactionID, furnitureID, quantity) 
                VALUES (@TransactionID, @RentalTransactionID, @FurnitureID, @Quantity)";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                int transactionID = 0;
                try
                {
                    using (SqlCommand insertCommand = new SqlCommand(insertReturnTransactionStatement, connection))
                    {
                        insertCommand.Transaction = transaction;
                        insertCommand.Parameters.Add("@MemberID", System.Data.SqlDbType.Int);
                        insertCommand.Parameters["@MemberID"].Value = memberID;
                        insertCommand.Parameters.Add("@EmployeeID", System.Data.SqlDbType.Int);
                        insertCommand.Parameters["@EmployeeID"].Value = employeeID;
                        insertCommand.Parameters.Add("@ReturnDate", System.Data.SqlDbType.DateTime);
                        insertCommand.Parameters["@ReturnDate"].Value = DateTime.Now;
                        insertCommand.ExecuteNonQuery();
                    }
                    using (SqlCommand selectCommand = new SqlCommand(selectTransactionID, connection))
                    {
                        selectCommand.Transaction = transaction;
                        transactionID = Convert.ToInt32(selectCommand.ExecuteScalar());
                    }
                    using (SqlCommand insertCommand = new SqlCommand(insertReturnItemStatement, connection))
                    {
                        insertCommand.Transaction = transaction;
                        for (int i = 0; i < returnedItemsListView.Items.Count; i++)
                        {
                            ReturnItem theReturnedItem = (ReturnItem)returnedItemsListView.Items[i].Tag;
                            insertCommand.Parameters.Add("@TransactionID", System.Data.SqlDbType.Int);
                            insertCommand.Parameters["@TransactionID"].Value = transactionID;
                            insertCommand.Parameters.Add("@RentalTransactionID", System.Data.SqlDbType.Int);
                            insertCommand.Parameters["@RentalTransactionID"].Value = theReturnedItem.RentalTransactionID;
                            insertCommand.Parameters.Add("@FurnitureID", System.Data.SqlDbType.VarChar);
                            insertCommand.Parameters["@FurnitureID"].Value = theReturnedItem.FurnitureID;
                            insertCommand.Parameters.Add("@Quantity", System.Data.SqlDbType.Int);
                            insertCommand.Parameters["@Quantity"].Value = theReturnedItem.Quantity;
                            insertCommand.ExecuteNonQuery();
                            insertCommand.Parameters.Clear();
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
    }
}
