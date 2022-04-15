using RentMe.DAL;
using System;
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
    }
}
