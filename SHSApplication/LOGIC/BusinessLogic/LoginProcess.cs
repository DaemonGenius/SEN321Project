using DATALAYER.Controllers;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.BusinessLogic
{
    public class LoginProcess
    {
        public string Email;
        public string Pass;
       // DataContext db = new DataContext("Data Source=.;Initial Catalog=SHSdb4;Integrated Security=True;");
       // Table<People> People = db.GetTable<People>();
        #region Login
        public bool Login(string Username, string Password)
        {
            using (var dbe = new DataContext("Data Source=.;Initial Catalog=SHSdb4;Integrated Security=True;"))
            {
                bool value = false;
                foreach (People item in dbe.GetTable<People>())
                {
                    // Person person = db.Person.FirstOrDefault(x => x.p_EmailAddress == Username && x.p_Password == Password);
                    if (item == null)
                    {
                        return value;
                    }
                    else
                    if (item.EmailAddress == Username && item.Password == Password)
                    {
                        Email = item.EmailAddress;
                        Pass = item.Password;
                        return value = true;
                    }
                }
                
                return value;
            }
        }
        #endregion

        #region PortalType
        public string PortalType()
        {
            using (var dbe = new DataContext("Data Source=.;Initial Catalog=SHSdb4;Integrated Security=True;"))
            {
                
                string value = null;
                foreach (People item in dbe.GetTable<People>())
                {
                    // Person person = db.Person.FirstOrDefault(x => x.p_EmailAddress == Username && x.p_Password == Password);
                    if (Email == item.EmailAddress && Pass == item.Password )
                    {
                        value = item.Department;
                        return value;
                    }
                   
                }
                return value;
            }

        }
        #endregion

    }
}
