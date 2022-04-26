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
        /// <param name="theMember"></param>
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
        /// Gets member matching specific ID 
        /// </summary>
        /// <returns>Member matching specific ID</returns>
        /// <exception cref="System.ArgumentException">Member ID must be a positive whole number.</exception>
        public Member GetMemberByID(int memberID)
        {
            if (memberID <= 0)
            {
                throw new ArgumentException("Member ID must be a positive whole number.");
            }
            return this.memberDAL.GetMemberByID(memberID);
        }

        /// <summary>
        /// Gets members matching specific phone number
        /// </summary>
        /// <returns>Members matching specific phone number</returns>
        /// <exception cref="System.ArgumentException">Phone number must not be null.</exception>
        public List<Member> GetMembersByPhoneNumber(string phoneNumber)
        {
            if (phoneNumber == null)
            {
                throw new ArgumentNullException("Phone number must not be null.");
            }
            return this.memberDAL.GetMembersByPhoneNumber(phoneNumber);
        }

        /// <summary>
        /// Gets members matching specific first and last name
        /// </summary>
        /// <returns>Members matching specific first and last name</returns>
        /// <exception cref="System.ArgumentException">First Name must not be null.
        /// OR Last Name must not be null.
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
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phoneNumber"></param>
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
        /// <param name="oldMember"></param>
        /// <param name="newMember"></param>
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
