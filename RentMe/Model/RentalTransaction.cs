using System;

namespace RentMe.Model
{
    /// <summary>
    /// Defines a model class for a Rental Transaction
    /// </summary>
    public class RentalTransaction
    {
        public int TransactionID { get; set; }
        public int MemberID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime DueDate { get; set; }
    }
}
