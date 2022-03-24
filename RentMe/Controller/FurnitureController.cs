using RentMe.DAL;
using RentMe.Model;
using System;

namespace RentMe.Controller
{
    public class FurnitureController
    {
        private readonly FurnitureDAL furnitureDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="FurnitureController"/> class.
        /// </summary>
        public FurnitureController()
        {
            this.furnitureDAL = new FurnitureDAL();
        }

        /// <summary>
        /// Gets furniture matching specific ID 
        /// </summary>
        /// <returns>Furniture matching specific ID</returns>
        public Furniture GetFurnitureByID(string furnitureID)
        {
            if (furnitureID == null)
            {
                throw new ArgumentNullException("Furniture ID must not be null.");
            }
            return this.furnitureDAL.GetFurnitureByID(furnitureID);
        }
    }
}
