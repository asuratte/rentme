using System;

namespace RentMe.Model
{
    /// <summary>
    /// Defines a model class for a Return Transaction.
    /// </summary>
    public class ReturnTransaction
    {
        public int TransactionID { get; set; }
        public int MemberID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime ReturnDate { get; set; }

        public decimal TotalAmount { get; set; }
    }
}
