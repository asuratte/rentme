﻿using System;

namespace RentMe.Model
{
    /// <summary>
    /// This class models a Member
    /// </summary>
    public class Member
    {
        public int MemberID { get; set; }
        public string Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }
}
