namespace RentMe.Model
{
    /// <summary>
    /// Defines a model class for a Return Item.
    /// </summary>
    public class ReturnItem
    {
        public int RentalTransactionID { get; set; }
        public string FurnitureID { get; set; }
        public string FurnitureName { get; set; }
        public int Quantity { get; set; }
        public decimal ItemTotal { get; set; }
        public string ItemTotalDisplay { get; set; }
    }
}
