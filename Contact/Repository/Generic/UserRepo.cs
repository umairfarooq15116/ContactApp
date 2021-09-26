using Contact.DAL.User;
using Contact.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Repository.Generic
{
    public class UserRepo
    {
        public UserRepo() { }
        public void RegisterUser(Users users)
        {
            UserDAL.SaveUser(users);
        }

        public bool VerifyUserNamePassword(Users users)
        {
            if (UserDAL.VerifyUser(users.Name, users.Password))
            {
                return true;
            }
            return false;
        }
    }
}
