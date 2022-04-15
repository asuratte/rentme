using RentMe.DAL;
using RentMe.Model;
using System;
using System.Collections.Generic;

namespace RentMe.Controller
{
    /// <summary>
    /// Defines a controller class that mediates between the FurnitureDAL and the view.
    /// </summary>
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

        /// <summary>
        /// Gets the furniture by category and style.
        /// </summary>
        /// <param name="category">The name of the category.</param>
        /// <param name="style">The name of the style.</param>
        /// <returns>Furniture items matching specific category and style</returns>
        /// <exception cref="ArgumentNullException">
        /// Furniture category must not be null.
        /// or
        /// Furniture style must not be null.
        /// </exception>
        public List<Furniture> GetFurnitureByCategoryAndStyle(string category, string style)
        {
            if (category == null)
            {
                throw new ArgumentNullException("Furniture category must not be null.");
            }
            if (style == null)
            {
                throw new ArgumentNullException("Furniture style must not be null.");
            }
            return this.furnitureDAL.GetFurnitureByCategoryAndStyle(category, style);
        }

        /// <summary>
        /// Gets the rental rate by furnitureID
        /// </summary>
        /// <param name="furnitureID">The furnitureID</param>
        /// <returns>Rental rate as decimal</returns>
        /// <exception cref="ArgumentNullException">Furniture ID must not be null.</exception>
        public decimal GetRentalRateByFurnitureID(string furnitureID)
        {
            if (furnitureID == null || furnitureID == "")
            {
                throw new ArgumentNullException("Furniture ID must not be null.");
            }
            return this.furnitureDAL.GetRentalRateByFurnitureID(furnitureID);
        }
    }
}
