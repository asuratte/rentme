namespace RentMe.Model
{
    /// <summary>
    /// Defines a model class for a Rental Item.
    /// </summary>
    class RentalItem
    {
        public int TransactionID { get; set; }
        public string FurnitureID { get; set; }
        public int Quantity { get; set; }
    }
}
