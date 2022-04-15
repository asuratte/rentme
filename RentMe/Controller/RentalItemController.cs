using RentMe.DAL;
using RentMe.Model;
using System;
using System.Collections.Generic;

namespace RentMe.Controller
{
    /// <summary>
    /// Defines a controller class that mediates between the RentalItem DAL and the view.
    /// </summary>
    public class RentalItemController
    {
        private readonly RentalItemDAL rentalItemDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="RentalItemController"/> class.
        /// </summary>
        public RentalItemController()
        {
            this.rentalItemDAL = new RentalItemDAL();
        }

        /// <summary>
        /// Get list of active (non-returned) rental items by member ID
        /// </summary>
        /// <param name="memberID">The memberID.</param>
        /// <returns>List of active rental items associated with the given member ID</returns>
        /// <exception cref="ArgumentException">Member ID must be a positive whole number.</exception>
        public List<RentalItem> GetActiveRentalItemsByMemberID(int memberID)
        {
            if (memberID <= 0)
            {
                throw new ArgumentException("Member ID must be a positive whole number.");
            }
            return this.rentalItemDAL.GetActiveRentalItemsByMemberID(memberID);
        }
    }
}
