using System;

namespace RentMe.Model
{
    /// <summary>
    /// This class models a rental item
    /// </summary>
    public class RentalItem
    {
        public int TransactionID { get; set; }
        public string FurnitureID { get; set; }
        public string FurnitureName { get; set; }
        public int Quantity { get; set; }
        public int MemberID { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime DueDate { get; set; }
        public decimal RentalRate { get; set; }
    }
}
