using Contact.DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact.Models;
using System.Data.SqlClient;
using System.Data;

namespace Contact.DAL.User
{
    public class UserDAL
    {
        #region Private Members
        private static string ConnectionString = Connection.GetConnectionString;
        #endregion

        #region Public Methods
        //To Add new User record
        public static void RegisterUser(Users user)
        {
            try
            {
                // Creating Connection 
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand()
                    {
                        Connection = con,
                        CommandText = "spInsertUser",
                        CommandType = CommandType.StoredProcedure
                    };
                    //Set SqlParameters
                    cmd.Parameters.AddWithValue("@Name", user.Name);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@Password", user.Password);
                    cmd.Parameters.AddWithValue("@CreationDte", DateTime.Now);
                    cmd.Parameters.AddWithValue("@UpdatedDte", DateTime.Now);
                    // Opening Connection  
                    con.Open();
                    // Executing the SQL query or SP
                    int a = cmd.ExecuteNonQuery();
                    // Displaying a message 
                    if (a > 0)
                    {
                        Console.WriteLine("Data Inserted Successfully {0}", a);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("OOPs, something went wrong." + ex);
            }
        }
        #endregion
    }
}
