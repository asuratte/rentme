namespace RentMe.Model
{
    /// <summary>
    /// This class models a furniture item
    /// </summary>
    public class Furniture
    {
        public string FurnitureID { get; set; }

        public string Name { get; set; }

        public string Style { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public decimal RentalRate { get; set; }

        public int TotalQuantity { get; set; }
    }
}
