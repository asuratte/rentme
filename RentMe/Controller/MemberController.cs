using RentMe.DAL;
using RentMe.Model;
using System;
using System.Collections.Generic;

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
        /// <param name="theMember">The member to add.</param>
        /// <returns>Member ID of newly inserted member</returns>
        /// <exception cref="System.ArgumentException">Member must not be null.</exception>
        public int AddMember(Member theMember)
        {
            if (theMember == null) 
            {
                throw new ArgumentNullException("Member must not be null.");
            }
            return this.memberDAL.AddMember(theMember);
        }

        /// <summary>
        /// Gets the member by identifier.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        /// <returns>The member matching the specific identifier.</returns>
        /// <exception cref="ArgumentException">Member ID must be a positive whole number.</exception>
        public Member GetMemberByID(int memberID)
        {
            if (memberID <= 0)
            {
                throw new ArgumentException("Member ID must be a positive whole number.");
            }
            return this.memberDAL.GetMemberByID(memberID);
        }


        /// <summary>
        /// Gets the members by phone number.
        /// </summary>
        /// <param name="phoneNumber">The phone number.</param>
        /// <returns>Members matching specific phone number.</returns>
        /// <exception cref="ArgumentNullException">Phone number must not be null.</exception>
        public List<Member> GetMembersByPhoneNumber(string phoneNumber)
        {
            if (phoneNumber == null)
            {
                throw new ArgumentNullException("Phone number must not be null.");
            }
            return this.memberDAL.GetMembersByPhoneNumber(phoneNumber);
        }

        /// <summary>
        /// Gets members matching specific first and last name.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <returns>Members matching specific first and last name.</returns>
        /// <exception cref="ArgumentNullException">
        /// First Name must not be null.
        /// or
        /// Last Name must not be null.
        /// </exception>
        public List<Member> GetMembersByFirstAndLastName(string firstName, string lastName)
        {
            if (firstName == null)
            {
                throw new ArgumentNullException("First Name must not be null.");
            }
            if (lastName == null)
            {
                throw new ArgumentNullException("Last Name must not be null.");
            }
            return this.memberDAL.GetMembersByFirstAndLastName(firstName, lastName);
        }

        /// <summary>
        /// Check if a member exists using a combination of first name, last name, and phone
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="phoneNumber">The phone number.</param>
        /// <returns>True if exists, false if not</returns>
        /// <exception cref="System.ArgumentException">First Name must not be null.
        /// OR Last Name must not be null.
        /// OR Phone Number must not be null.
        /// </exception>
        public bool CheckMemberExists(string firstName, string lastName, string phoneNumber)
        {
            if (firstName == null)
            {
                throw new ArgumentNullException("First Name must not be null.");
            }
            if (lastName == null)
            {
                throw new ArgumentNullException("Last Name must not be null.");
            }
            if (phoneNumber == null)
            {
                throw new ArgumentNullException("Phone Number must not be null.");
            }
            return this.memberDAL.CheckMemberExists(firstName, lastName, phoneNumber);  
        }

        /// <summary>
        /// Update existing member in the database
        /// </summary>
        /// <param name="oldMember">The old member.</param>
        /// <param name="newMember">The new member.</param>
        /// <returns>True if successful, false if not</returns>
        /// <exception cref="System.ArgumentException">Old Member must not be null.
        /// OR New Member must not be null.
        /// </exception>
        public bool UpdateMember(Member oldMember, Member newMember)
        {
            if (oldMember == null)
            {
                throw new ArgumentNullException("Old member must not be null.");
            }
            if (newMember == null)
            {
                throw new ArgumentNullException("New member must not be null.");
            }
            return this.memberDAL.UpdateMember(oldMember, newMember);
        }
    }
}
