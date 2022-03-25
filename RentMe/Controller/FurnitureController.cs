using RentMe.DAL;
using RentMe.Model;
using System;
using System.Collections.Generic;

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

        /// <summary>
        /// Gets the furniture items matching specific category
        /// </summary>
        /// <param name="categoryName">Name of the category.</param>
        /// <returns>Furniture items matching specific category</returns>
        /// <exception cref="ArgumentNullException">Category name must not be null.</exception>
        public List<Furniture> GetFurnitureByCategory(string category)
        {
            if (category == null)
            {
                throw new ArgumentNullException("Furniture category must not be null.");
            }
            return this.furnitureDAL.GetFurnitureByCategory(category);
        }
    }
}
