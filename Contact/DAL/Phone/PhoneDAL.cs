using Contact.DAL.Database;
using Contact.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.DAL.Phone
{
    public class PhoneDAL
    {
        #region Private Members
        private static string ConnectionString = Connection.GetConnectionString;
        #endregion
        //To Add new Contact record
        public static void AddPhone(List<PhoneNo> phone)
        {
            try
            {
                // Creating Connection 
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand()
                    {
                        Connection = con,
                        CommandText = "spInsertPhoneNo",
                        CommandType = CommandType.StoredProcedure
                    };
                    //Create Datatable
                    DataTable dt = new DataTable();
                    //Add columns  
                    dt.Columns.Add(new DataColumn("User_Id", typeof(int)));
                    dt.Columns.Add(new DataColumn("Cont_No", typeof(int)));
                    dt.Columns.Add(new DataColumn("Number", typeof(int)));
                    dt.Columns.Add(new DataColumn("Phone_No", typeof(string)));
                    dt.Columns.Add(new DataColumn("Network_Id", typeof(int)));
                    //Add Rows
                    foreach(PhoneNo no in phone)
                    {
                        dt.Rows.Add(no.UserId,no.ContNo,no.Number,no.Phone_No,no.NetworkId);
                    }
                    //Set SqlParameters (pass table variable)
                    cmd.Parameters.AddWithValue("@Phone_Details", dt);
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
    }
}
