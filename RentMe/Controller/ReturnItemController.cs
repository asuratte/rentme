using RentMe.DAL;
using RentMe.Model;
using System;
using System.Collections.Generic;

namespace RentMe.Controller
{
    /// <summary>
    /// Defines a controller class that mediates between the ReturnItem DAL and the view.
    /// </summary>
    public class ReturnItemController
    {
        private readonly ReturnItemDAL returnItemDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnItemController"/> class.
        /// </summary>
        public ReturnItemController()
        {
            this.returnItemDAL = new ReturnItemDAL();
        }

        /// <summary>
        /// Gets the rental items by transactionID.
        /// </summary>
        /// <param name="transactionID">The transaction identifier.</param>
        /// <returns>List of rental items for a given transaction ID</returns>
        /// <exception cref="ArgumentException">Transaction ID must be a positive whole number.</exception>
        public List<ReturnItem> GetReturnItemsByTransactionID(int transactionID)
        {
            if (transactionID <= 0)
            {
                throw new ArgumentException("Transaction ID must be a positive whole number.");
            }
            return this.returnItemDAL.GetReturnItemsByTransactionID(transactionID);
        }
    }
}
