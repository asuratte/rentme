﻿using RentMe.DAL;
using RentMe.Model;
using System;
using System.Collections.Generic;

namespace RentMe.Controller
{
    /// <summary>
    /// Defines a controller class that mediates between the RentalTransaction DAL and the view.
    /// </summary>
    public class RentalTransactionController
    {
        private readonly RentalTransactionDAL rentalTransactionDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="RentalTransactionController"/> class.
        /// </summary>
        public RentalTransactionController()
        {
            this.rentalTransactionDAL = new RentalTransactionDAL();
        }

        /// <summary>
        /// Adds the rental transaction and items to the database.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        /// <param name="employeeID">The employee identifier.</param>
        /// <param name="rentalItemsList">The rental items list.</param>
        /// <param name="dueDate">The due date.</param>
        /// <returns>The rental transaction ID.</returns>
        /// <exception cref="System.ArgumentException">
        /// Member ID must be a positive whole number.
        /// or
        /// Employee ID must be a positive whole number.
        /// or
        /// There must be at least one furniture item in the list.
        /// </exception>
        public int AddRentalTransactionAndItems(int memberID, int employeeID, List<RentalItem> rentalItemsList, DateTime dueDate)
        {
            if (memberID <= 0)
            {
                throw new ArgumentException("Member ID must be a positive whole number.");
            }
            if (employeeID <= 0)
            {
                throw new ArgumentException("Employee ID must be a positive whole number.");
            }
            if (rentalItemsList.Count < 1 || rentalItemsList == null)
            {
                throw new ArgumentException("There must be at least one furniture item in the list.");
            }
            return this.rentalTransactionDAL.AddRentalTransactionAndItems(memberID, employeeID, rentalItemsList, dueDate);
        }

        /// <summary>
        /// Gets all rental transactions by member identifier.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        /// <returns>The list of rental transactions for the specified member ID.</returns>
        /// <exception cref="System.ArgumentException">Member ID must be a positive whole number.</exception>
        public List<RentalTransaction> GetAllRentalTransactionsByMemberID(int memberID)
        {
            if (memberID <= 0)
            {
                throw new ArgumentException("Member ID must be a positive whole number.");
            }
            return this.rentalTransactionDAL.GetAllRentalTransactionsByMemberID(memberID);
        }
    }
}
