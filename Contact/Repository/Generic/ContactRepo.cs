using System;
using System.Collections.Generic;
using Contact.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Repository.Generic
{
    class ContactRepo : IGenericRepository<Contacts>
    {
        public ContactRepo()
        {
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Contacts> GetAll()
        {
            throw new NotImplementedException();
        }

        public Contacts GetByID(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Contacts obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Contacts obj)
        {
            throw new NotImplementedException();
        }
    }
}
