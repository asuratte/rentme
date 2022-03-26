﻿using RentMe.DAL;
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
    }
}