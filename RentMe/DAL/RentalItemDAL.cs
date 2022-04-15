using RentMe.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RentMe.DAL
{
    /// <summary>
    /// Data Access Layer for Rental Items
    /// </summary>
    public class RentalItemDAL
    {
        /// <summary>
        /// Get list of active (non-returned) rental items by member ID
        /// </summary>
        /// <param name="memberID">The memberID.</param>
        /// <returns>List of active rental items associated with the given member ID</returns>
        public List<RentalItem> GetActiveRentalItemsByMemberID(int memberID)
        {
            string selectStatement =
            @"SELECT rt.memberID,
	            rt.transactionID as 'Rental Transaction ID',
	            rt.rentalDate as 'Rental Date',
	            rt.dueDate as 'Due Date',
	            rli.furnitureID as 'Rental Item Furniture ID',
	            rli.quantity - ISNULL(SUM(rni.quantity), 0) as 'Quantity Outstanding'
            FROM rental_transaction rt
	            JOIN rental_item rli ON rt.transactionID = rli.transactionID
	            LEFT JOIN return_item rni ON rni.rentalTransactionID = rt.transactionID AND rni.furnitureID = rli.furnitureID
            WHERE rt.memberID = @MemberID
            GROUP BY rt.memberID, rt.transactionID, rt.rentalDate, rt.dueDate, rli.furnitureID, rli.quantity
            HAVING SUM(rni.quantity) IS NULL OR SUM(rni.quantity) < rli.quantity";

            List<RentalItem> theRentalItemList = new List<RentalItem>();

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
                            RentalItem theRentalItem = new RentalItem();
                            theRentalItem.MemberID = memberID;
                            theRentalItem.TransactionID = Convert.ToInt32(reader["Rental Transaction ID"]);
                            theRentalItem.FurnitureID = reader["Rental Item Furniture ID"].ToString();
                            theRentalItem.Quantity = Convert.ToInt32(reader["Quantity Outstanding"]);
                            theRentalItem.RentalDate = (DateTime)reader["Rental Date"];
                            theRentalItem.DueDate = (DateTime)reader["Due Date"];

                            theRentalItemList.Add(theRentalItem);
                        }
                    }
                }
            }
            return theRentalItemList;
        }
    }
}