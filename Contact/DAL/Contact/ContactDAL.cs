using Contact.DAL.Database;
using Contact.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.DAL.Contact
{
    public class ContactDAL
    {
        #region Private Members
        private static  string ConnectionString = Connection.GetConnectionString;
        #endregion

        //#region Constructor
        //public ContactDAL()
        //{
        //    ConnectionString = Connection.GetConnectionString;
        //}
        //#endregion

        #region Public Methods
        //To View all Contact details   
        //public IEnumerable<Contacts> GetAllContacts()
        //{
        //    return null;
        //}
        //To Add new Contact record
        public static void AddContact(Contacts contacts)
        {
            try
            {
                // Creating Connection 
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand()
                    {
                        Connection = con,
                        CommandText = "spInsertContact",
                        CommandType = CommandType.StoredProcedure
                    };
                    //Set SqlParameters
                    cmd.Parameters.AddWithValue("@Cont_No", contacts.ContNo);
                    cmd.Parameters.AddWithValue("@Name", contacts.Name);
                    cmd.Parameters.AddWithValue("@Email", contacts.Email);
                    cmd.Parameters.AddWithValue("@UserID", contacts.UserId);
                    cmd.Parameters.AddWithValue("@CreationDte", DateTime.Now);
                    cmd.Parameters.AddWithValue("@UpdatedDte", DateTime.Now);
                    cmd.Parameters.AddWithValue("@IsActive", contacts.IsActive);
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
        //To Update the records of a particluar Contact  
        //public void UpdateContact()
        //{

        //}
        //Get the details of a particular Contact 
        //public Contacts GetContact(int? id)
        //{
        //    return  null;
        //}
        //To Delete the record of a particular Contact 
        //public void DeleteContact(int? id)
        //{

        //}
        #endregion
    }
}
