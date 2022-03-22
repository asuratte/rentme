using RentMe.DAL;
using RentMe.Model;
using System.Collections.Generic;

namespace RentMe.Controller
{
    /// <summary>
    /// Defines a controller class that mediates between the StateDAL and the view.
    /// </summary>
    public class StateController
    {
        private readonly StateDAL stateDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="StateController"/> class.
        /// </summary>
        public StateController()
        {
            this.stateDAL = new StateDAL();
        }

        /// <summary>
        /// Retrieve list of all states from the state table in the database
        /// </summary>
        /// <returns>List of all states in the database</returns>
        public List<State> GetAllStates()
        {
            return this.stateDAL.GetAllStates();
        }
    }
}
