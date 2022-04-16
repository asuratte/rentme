using RentMe.DAL;
using RentMe.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RentMe.Controller
{
    /// <summary>
    /// Defines a controller class that mediates between the ReturnTransaction DAL and the view.
    /// </summary>
    class ReturnTransactionController
    {
        private readonly ReturnTransactionDAL returnTransactionDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnTransactionController"/> class.
        /// </summary>
        public ReturnTransactionController()
        {
            this.returnTransactionDAL = new ReturnTransactionDAL();
        }

        /// <summary>
        /// Adds the return transaction and items to the database.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        /// <param name="employeeID">The employee identifier.</param>
        /// <param name="returnedItemsListView">The returned items ListView.</param>
        /// <returns>The return transaction ID</returns>
        public int AddReturnTransactionAndItems(int memberID, int employeeID, ListView returnedItemsListView)
        {
            if (memberID <= 0)
            {
                throw new ArgumentException("Member ID must be a positive whole number.");
            }
            if (employeeID <= 0)
            {
                throw new ArgumentException("Employee ID must be a positive whole number.");
            }
            if (returnedItemsListView.Items.Count < 1 || returnedItemsListView == null)
            {
                throw new ArgumentException("There must be at least one furniture item in the list.");
            }
            return this.returnTransactionDAL.AddReturnTransactionAndItems(memberID, employeeID, returnedItemsListView);
        }

        /// <summary>
        /// Gets all return transactions by member identifier.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        /// <returns>The list of return transactions for the specified member ID.</returns>
        /// <exception cref="System.ArgumentException">Member ID must be a positive whole number.</exception>
        public List<ReturnTransaction> GetAllReturnTransactionsByMemberID(int memberID)
        {
            if (memberID <= 0)
            {
                throw new ArgumentException("Member ID must be a positive whole number.");
            }
            return this.returnTransactionDAL.GetAllReturnTransactionsByMemberID(memberID);
        }
    }
}
