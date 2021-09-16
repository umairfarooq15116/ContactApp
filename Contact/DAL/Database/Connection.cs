using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.DAL.Database
{
    class Connection
    {
        public static string GetConnectionString
        {
            get
            {
                // get connection string from  App.config
                return ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            }
        }
    }
}
