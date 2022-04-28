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
        /// <param name="theMember">The member to add.</param>
        /// <returns>Member ID of newly inserted member</returns>
        public int AddMember(Member theMember)
        {
            string insertStatement =
                @"INSERT INTO member (sex, dateOfBirth, firstName, lastName, phone, address1, address2, city, state, zipCode) 
                VALUES (@Sex, @DateOfBirth, @FirstName, @LastName, @Phone, @Address1, @Address2, @City, @State, @ZipCode)";
            string selectStatement = "SELECT @@Identity";
            int memberID = 0;
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
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    memberID = Convert.ToInt32(selectCommand.ExecuteScalar());
                }
            }
            return memberID;
        }

        /// <summary>
        /// Gets member matching specific ID 
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
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
        /// <param name="phoneNumber">The phone number.</param>
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
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
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
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="phoneNumber">The phone number.</param>
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

        /// <summary>
        /// Update existing member in the database
        /// </summary>
        /// <param name="oldMember">The old member.</param>
        /// <param name="newMember">The new member.</param>
        /// <returns>True if successful, false if not</returns>
        public bool UpdateMember(Member oldMember, Member newMember)
        {
            string updateStatement =
                @"UPDATE member SET
                firstName = @NewFirstName,
                lastName = @NewLastName,
                dateOfBirth = @NewDateOfBirth,
                sex = @NewSex,
                phone = @NewPhone,
                address1 = @NewAddress1,
                address2 = @NewAddress2,
                city = @NewCity,
                state = @NewState,
                zipCode = @NewZipCode
                WHERE memberID = @MemberID
                AND firstName = @OldFirstName
                AND lastName = @OldLastName
                AND dateOfBirth = @OldDateOfBirth
                AND sex = @OldSex
                AND phone = @OldPhone
                AND address1 = @OldAddress1
                AND (address2 = @OldAddress2 OR
                address2 IS NULL AND @OldAddress2 IS NULL)
                AND city = @OldCity
                AND state = @OldState
                AND zipCode = @OldZipCode";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {
                    updateCommand.Parameters.Add("@MemberID", System.Data.SqlDbType.Int);
                    updateCommand.Parameters["@MemberID"].Value = oldMember.MemberID;

                    updateCommand.Parameters.Add("@NewFirstName", System.Data.SqlDbType.VarChar);
                    updateCommand.Parameters["@NewFirstName"].Value = newMember.FirstName;
                    updateCommand.Parameters.Add("@OldFirstName", System.Data.SqlDbType.VarChar);
                    updateCommand.Parameters["@OldFirstName"].Value = oldMember.FirstName;

                    updateCommand.Parameters.Add("@NewLastName", System.Data.SqlDbType.VarChar);
                    updateCommand.Parameters["@NewLastName"].Value = newMember.LastName;
                    updateCommand.Parameters.Add("@OldLastName", System.Data.SqlDbType.VarChar);
                    updateCommand.Parameters["@OldLastName"].Value = oldMember.LastName;

                    updateCommand.Parameters.Add("@NewDateOfBirth", System.Data.SqlDbType.Date);
                    updateCommand.Parameters["@NewDateOfBirth"].Value = newMember.DateOfBirth;
                    updateCommand.Parameters.Add("@OldDateOfBirth", System.Data.SqlDbType.Date);
                    updateCommand.Parameters["@OldDateOfBirth"].Value = oldMember.DateOfBirth;

                    updateCommand.Parameters.Add("@NewSex", System.Data.SqlDbType.Char, 1);
                    updateCommand.Parameters["@NewSex"].Value = newMember.Sex;
                    updateCommand.Parameters.Add("@OldSex", System.Data.SqlDbType.Char, 1);
                    updateCommand.Parameters["@OldSex"].Value = oldMember.Sex;

                    updateCommand.Parameters.Add("@NewPhone", System.Data.SqlDbType.Char, 10);
                    updateCommand.Parameters["@NewPhone"].Value = newMember.Phone;
                    updateCommand.Parameters.Add("@OldPhone", System.Data.SqlDbType.Char, 10);
                    updateCommand.Parameters["@OldPhone"].Value = oldMember.Phone;

                    updateCommand.Parameters.Add("@NewAddress1", System.Data.SqlDbType.VarChar);
                    updateCommand.Parameters["@NewAddress1"].Value = newMember.Address1;
                    updateCommand.Parameters.Add("@OldAddress1", System.Data.SqlDbType.VarChar);
                    updateCommand.Parameters["@OldAddress1"].Value = oldMember.Address1;

                    if (newMember.Address2 == null || newMember.Address2 == "")
                    {
                        updateCommand.Parameters.Add("@NewAddress2", System.Data.SqlDbType.VarChar);
                        updateCommand.Parameters["@NewAddress2"].Value = DBNull.Value;
                    }
                    else 
                    {
                        updateCommand.Parameters.Add("@NewAddress2", System.Data.SqlDbType.VarChar);
                        updateCommand.Parameters["@NewAddress2"].Value = newMember.Address2;
                    }
                    if (oldMember.Address2 == null || oldMember.Address2 == "")
                    {
                        updateCommand.Parameters.Add("@OldAddress2", System.Data.SqlDbType.VarChar);
                        updateCommand.Parameters["@OldAddress2"].Value = DBNull.Value;
                    }
                    else
                    {
                        updateCommand.Parameters.Add("@OldAddress2", System.Data.SqlDbType.VarChar);
                        updateCommand.Parameters["@OldAddress2"].Value = oldMember.Address2;
                    }

                    updateCommand.Parameters.Add("@NewCity", System.Data.SqlDbType.VarChar);
                    updateCommand.Parameters["@NewCity"].Value = newMember.City;
                    updateCommand.Parameters.Add("@OldCity", System.Data.SqlDbType.VarChar);
                    updateCommand.Parameters["@OldCity"].Value = oldMember.City;

                    updateCommand.Parameters.Add("@NewState", System.Data.SqlDbType.Char, 2);
                    updateCommand.Parameters["@NewState"].Value = newMember.State;
                    updateCommand.Parameters.Add("@OldState", System.Data.SqlDbType.Char, 2);
                    updateCommand.Parameters["@OldState"].Value = oldMember.State;

                    updateCommand.Parameters.Add("@NewZipCode", System.Data.SqlDbType.Char, 5);
                    updateCommand.Parameters["@NewZipCode"].Value = newMember.ZipCode;
                    updateCommand.Parameters.Add("@OldZipCode", System.Data.SqlDbType.Char, 5);
                    updateCommand.Parameters["@OldZipCode"].Value = oldMember.ZipCode;

                    int count = updateCommand.ExecuteNonQuery();
                    if (count > 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
        }

    }
}
