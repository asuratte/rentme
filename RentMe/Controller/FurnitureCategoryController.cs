using RentMe.DAL;
using System;
using System.Collections.Generic;

namespace RentMe.Controller
{
    /// <summary>
    /// Defines a controller class that mediates between the FurnitureCategoryDAL and the view.
    /// </summary>
    public class FurnitureCategoryController
    {
        private readonly FurnitureCategoryDAL furnitureCategoryDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="FurnitureCategoryController"/> class.
        /// </summary>
        public FurnitureCategoryController()
        {
            this.furnitureCategoryDAL = new FurnitureCategoryDAL();
        }

        /// <summary>
        /// Retrieve list of all categories from the furniture category table in the database
        /// </summary>
        /// <returns>List of all furniture categories in the database</returns>
        public List<String> GetAllFurnitureCategories()
        {
            return this.furnitureCategoryDAL.GetAllFurnitureCategories();
        }
    }
}
