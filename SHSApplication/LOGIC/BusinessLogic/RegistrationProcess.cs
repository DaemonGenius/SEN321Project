using DATALAYER.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace LOGIC.BusinessLogic
{
    public class RegistrationProcess
    {
        public RegistrationProcess() { }
        //DATALAYER.DatabaseConnection.SHSdb db1 = new DATALAYER.DatabaseConnection.SHSdb();
        static DataContext db = new DataContext("Data Source=.;Initial Catalog=SHSdb4;Integrated Security=True;");
        Table<People> People =  db.GetTable<People>();
        #region RegisterUser

        public void RegisterUser(string fname, string lname, string email, string cell, string pass, string DOB, string ssid)
        {
            People persons = new People
            {
                FirstName = fname,
                LastName = lname,
                EmailAddress = email,
                CellNumber = cell,
                Password = pass,
                DOB = DOB,
                SSID = ssid
            };
                People.InsertOnSubmit(persons);
                db.SubmitChanges();            
            
        }
        

        
        #endregion

    }
}
