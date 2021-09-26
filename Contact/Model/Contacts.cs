using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Model
{
    #region Contact Model
    public class Contacts
    {
        public int ContId;
        public int ContNo;
        public string Name;
        public string Email;
        public int UserId;
        public DateTime CreationDte;
        public DateTime UpdatedDate;
        public bool IsActive;
        public List<PhoneNo> phones;
    }
    #endregion
}
