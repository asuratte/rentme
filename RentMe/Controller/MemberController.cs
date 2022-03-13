using RentMe.DAL;
using RentMe.Model;
using System;

namespace RentMe.Controller
{
    /// <summary>
    /// Defines a controller class that mediates between the MemberDAL and the view.
    /// </summary>
    public class MemberController
    {
        private readonly MemberDAL memberDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="MemberController"/> class.
        /// </summary>
        public MemberController()
        {
            this.memberDAL = new MemberDAL();
        }

        /// <summary>
        /// Add member to the database
        /// </summary>
        /// <param name="theMember"></param>
        public void AddMember(Member theMember)
        {
            if (theMember == null) 
            {
                throw new ArgumentNullException("Member must not be null.");
            }
            this.memberDAL.AddMember(theMember);
        }
    }
}
