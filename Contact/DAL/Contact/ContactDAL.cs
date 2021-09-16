using Contact.DAL.Database;
using Contact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.DAL.Contact
{
    public class ContactDAL
    {
        #region Private Members
        private readonly string ConnectionString = null;
        #endregion

        #region Constructor
        public ContactDAL()
        {
            ConnectionString = Connection.GetConnectionString;
        }
        #endregion

        #region Public Methods
        //To View all Contact details   
        public IEnumerable<Contacts> GetAllContacts()
        {
            return null;
        }
        //To Add new Contact record
        public void AddContact()
        {

        }
        //To Update the records of a particluar Contact  
        public void UpdateContact()
        {

        }
        //Get the details of a particular Contact 
        public Contacts GetContact(int? id)
        {
            return  null;
        }
        //To Delete the record of a particular Contact 
        public void DeleteContact(int? id)
        {

        }
        #endregion
    }
}
