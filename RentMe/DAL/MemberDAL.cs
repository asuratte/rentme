using RentMe.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RentMe.DAL
{
    /// <summary>
    /// Data Access Layer for Members
    /// </summary>
    public class MemberDAL
    {
        /// <summary>
        /// Add member to the database
        /// </summary>
        /// <param name="theMember"></param>
        public void AddMember(Member theMember)
        {
            string insertStatement =
                @"INSERT INTO member (sex, dateOfBirth, firstName, lastName, phone, address1, address2, city, state, zipCode) 
                VALUES (@Sex, @DateOfBirth, @FirstName, @LastName, @Phone, @Address1, @Address2, @City, @State, @ZipCode)";
            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.Add("@Sex", System.Data.SqlDbType.Char, 1);
                    insertCommand.Parameters["@Sex"].Value = theMember.Sex;
                    insertCommand.Parameters.Add("@DateOfBirth", System.Data.SqlDbType.Date);
                    insertCommand.Parameters["@DateOfBirth"].Value = theMember.DateOfBirth;
                    insertCommand.Parameters.Add("@FirstName", System.Data.SqlDbType.VarChar);
                    insertCommand.Parameters["@FirstName"].Value = theMember.FirstName;
                    insertCommand.Parameters.Add("@LastName", System.Data.SqlDbType.VarChar);
                    insertCommand.Parameters["@LastName"].Value = theMember.LastName;
                    insertCommand.Parameters.Add("@Phone", System.Data.SqlDbType.Char, 10);
                    insertCommand.Parameters["@Phone"].Value = theMember.Phone;
                    insertCommand.Parameters.Add("@Address1", System.Data.SqlDbType.VarChar);
                    insertCommand.Parameters["@Address1"].Value = theMember.Address1;
                    if (theMember.Address2 != null && theMember.Address2 != "")
                    {
                        insertCommand.Parameters.Add("@Address2", System.Data.SqlDbType.VarChar);
                        insertCommand.Parameters["@Address2"].Value = theMember.Address2;
                    }
                    else 
                    {
                        insertCommand.Parameters.Add("@Address2", System.Data.SqlDbType.VarChar);
                        insertCommand.Parameters["@Address2"].Value = DBNull.Value;
                    }
                    insertCommand.Parameters.Add("@City", System.Data.SqlDbType.VarChar);
                    insertCommand.Parameters["@City"].Value = theMember.City;
                    insertCommand.Parameters.Add("@State", System.Data.SqlDbType.Char, 2);
                    insertCommand.Parameters["@State"].Value = theMember.State;
                    insertCommand.Parameters.Add("@ZipCode", System.Data.SqlDbType.Char, 5);
                    insertCommand.Parameters["@ZipCode"].Value = theMember.ZipCode;
                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Gets member matching specific ID 
        /// </summary>
        /// <returns>Member matching specific ID</returns>
        public Member GetMemberByID(int memberID)
        {
            string selectStatement =
                @"SELECT firstName, lastName, phone, dateOfBirth, sex, address1, address2, city, state, zipCode
                FROM member
                WHERE memberID = @MemberID";

            Member theMember = new Member();

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@MemberID", System.Data.SqlDbType.Int);
                    selectCommand.Parameters["@MemberID"].Value = memberID;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            theMember.MemberID = memberID;
                            theMember.DateOfBirth = (DateTime)reader["dateOfBirth"];
                            theMember.FirstName = reader["firstName"].ToString();
                            theMember.LastName = reader["lastName"].ToString();
                            theMember.Phone = reader["phone"].ToString();
                            theMember.Sex = reader["sex"].ToString();
                            theMember.Address1 = reader["address1"].ToString();
                            if (!(reader["address2"] is DBNull))
                            {
                                theMember.Address2 = reader["address2"].ToString();
                            }
                            theMember.City = reader["city"].ToString();
                            theMember.State = reader["state"].ToString();
                            theMember.ZipCode = reader["zipCode"].ToString();
                        }
                        else
                        {
                            theMember = null;
                        }
                    }
                }
            }
            return theMember;
        }

        /// <summary>
        /// Gets members matching specific phone number
        /// </summary>
        /// <returns>Members matching specific phone number</returns>
        public List<Member> GetMembersByPhoneNumber(string phoneNumber)
        {
            string selectStatement =
                @"SELECT memberID, firstName, lastName, phone, dateOfBirth, sex, address1, address2, city, state, zipCode
                FROM member
                WHERE phone = @Phone";

            List<Member> theMemberList = new List<Member>();

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@Phone", System.Data.SqlDbType.Char, 10);
                    selectCommand.Parameters["@Phone"].Value = phoneNumber;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Member theMember = new Member();
                            theMember.MemberID = Convert.ToInt32(reader["memberID"]);
                            theMember.DateOfBirth = (DateTime)reader["dateOfBirth"];
                            theMember.FirstName = reader["firstName"].ToString();
                            theMember.LastName = reader["lastName"].ToString();
                            theMember.Phone = reader["phone"].ToString();
                            theMember.Sex = reader["sex"].ToString();
                            theMember.Address1 = reader["address1"].ToString();
                            if (!(reader["address2"] is DBNull))
                            {
                                theMember.Address2 = reader["address2"].ToString();
                            }
                            theMember.City = reader["city"].ToString();
                            theMember.State = reader["state"].ToString();
                            theMember.ZipCode = reader["zipCode"].ToString();
                            theMemberList.Add(theMember);
                        }
                    }
                }
            }
            return theMemberList;
        }

        /// <summary>
        /// Gets members matching specific first and last name
        /// </summary>
        /// <returns>Members matching specific first and last name</returns>
        public List<Member> GetMembersByFirstAndLastName(string firstName, string lastName)
        {
            string selectStatement =
                @"SELECT memberID, firstName, lastName, phone, dateOfBirth, sex, address1, address2, city, state, zipCode
                FROM member
                WHERE firstName = @FirstName
                AND lastName = @LastName";

            List<Member> theMemberList = new List<Member>();

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@FirstName", System.Data.SqlDbType.VarChar);
                    selectCommand.Parameters["@FirstName"].Value = firstName;
                    selectCommand.Parameters.Add("@LastName", System.Data.SqlDbType.VarChar);
                    selectCommand.Parameters["@LastName"].Value = lastName;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Member theMember = new Member();
                            theMember.MemberID = Convert.ToInt32(reader["memberID"]);
                            theMember.DateOfBirth = (DateTime)reader["dateOfBirth"];
                            theMember.FirstName = reader["firstName"].ToString();
                            theMember.LastName = reader["lastName"].ToString();
                            theMember.Phone = reader["phone"].ToString();
                            theMember.Sex = reader["sex"].ToString();
                            theMember.Address1 = reader["address1"].ToString();
                            if (!(reader["address2"] is DBNull))
                            {
                                theMember.Address2 = reader["address2"].ToString();
                            }
                            theMember.City = reader["city"].ToString();
                            theMember.State = reader["state"].ToString();
                            theMember.ZipCode = reader["zipCode"].ToString();
                            theMemberList.Add(theMember);
                        }
                    }
                }
            }
            return theMemberList;
        }

        /// <summary>
        /// Check if a member exists using a combination of first name, last name, and phone
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phoneNumber"></param>
        /// <returns>True if exists, false if not</returns>
        public bool CheckMemberExists(string firstName, string lastName, string phoneNumber)
        {
            bool memberExists = false;

            string selectStatement =
                @"SELECT COUNT(*) 
                  FROM member
                  WHERE firstName = @FirstName
                  AND lastName = @LastName
                  AND phone = @PhoneNumber";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@FirstName", System.Data.SqlDbType.VarChar);
                    selectCommand.Parameters["@FirstName"].Value = firstName;
                    selectCommand.Parameters.Add("@LastName", System.Data.SqlDbType.VarChar);
                    selectCommand.Parameters["@LastName"].Value = lastName;
                    selectCommand.Parameters.Add("@PhoneNumber", System.Data.SqlDbType.Char, 10);
                    selectCommand.Parameters["@PhoneNumber"].Value = phoneNumber;

                    int numberOfRows = (int)selectCommand.ExecuteScalar();
                    if (numberOfRows > 0)
                    {
                        memberExists = true;
                    }
                }
            }
            return memberExists;
        }

    }
}
