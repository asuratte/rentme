using RentMe.DAL;
using System;
using System.Collections.Generic;

namespace RentMe.Controller
{
    /// <summary>
    /// Defines a controller class that mediates between the CategoryDAL and the view.
    /// </summary>
    public class CategoryController
    {
        private readonly CategoryDAL categoryDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryController"/> class.
        /// </summary>
        public CategoryController()
        {
            this.categoryDAL = new CategoryDAL();
        }

        /// <summary>
        /// Retrieve list of all categories from the furniture category table in the database
        /// </summary>
        /// <returns>List of all furniture categories in the database</returns>
        public List<String> GetAllCategories()
        {
            return this.categoryDAL.GetAllCategories();
        }
    }
}
