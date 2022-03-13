using RentMe.Model;
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
                    insertCommand.Parameters.Add("@DateOfBirth", System.Data.SqlDbType.DateTime);
                    insertCommand.Parameters["@DateOfBirth"].Value = theMember.DateOfBirth;
                    insertCommand.Parameters.Add("@FirstName", System.Data.SqlDbType.VarChar);
                    insertCommand.Parameters["@FirstName"].Value = theMember.FirstName;
                    insertCommand.Parameters.Add("@LastName", System.Data.SqlDbType.VarChar);
                    insertCommand.Parameters["@LastName"].Value = theMember.LastName;
                    insertCommand.Parameters.Add("@Phone", System.Data.SqlDbType.Char, 10);
                    insertCommand.Parameters["@Phone"].Value = theMember.Phone;
                    insertCommand.Parameters.Add("@Address1", System.Data.SqlDbType.VarChar);
                    insertCommand.Parameters["@Address1"].Value = theMember.Address1;
                    insertCommand.Parameters.Add("@Address2", System.Data.SqlDbType.VarChar);
                    insertCommand.Parameters["@Address2"].Value = theMember.Address2;
                    insertCommand.Parameters.Add("@City", System.Data.SqlDbType.VarChar);
                    insertCommand.Parameters["@City"].Value = theMember.City;
                    insertCommand.Parameters.Add("@ZipCode", System.Data.SqlDbType.Char, 5);
                    insertCommand.Parameters["@ZipCode"].Value = theMember.ZipCode;
                    insertCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
