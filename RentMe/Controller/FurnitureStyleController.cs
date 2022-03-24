using RentMe.DAL;
using System;
using System.Collections.Generic;

namespace RentMe.Controller
{
    /// <summary>
    /// Defines a controller class that mediates between the FurnitureStyleDAL and the view.
    /// </summary>
    public class FurnitureStyleController
    {
        private readonly FurnitureStyleDAL furnitureStyleDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="FurnitureStyleController"/> class.
        /// </summary>
        public FurnitureStyleController()
        {
            this.furnitureStyleDAL = new FurnitureStyleDAL();
        }

        /// <summary>
        /// Retrieve list of all styles from the furniture style table in the database
        /// </summary>
        /// <returns>List of all furniture styles in the database</returns>
        public List<String> GetAllFurnitureStyles()
        {
            return this.furnitureStyleDAL.GetAllFurnitureStyles();
        }
    }
}
