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
       static DataContext db = new DataContext("Data Source=.;Initial Catalog=SHSdb3;Integrated Security=True;");
        Table<People> People =  db.GetTable<People>();
        #region RegisterUser

        public void RegisterUser(string fname, string lname, string email, string cell, string pass, string DOB, string ssid)
        {
            People persons = new People
            {
                p_FirstName = fname,
                p_LastName = lname,
                p_EmailAddress = email,
                p_CellNumber = cell,
                p_Password = pass,
                p_DOB = DOB,
                p_SSID = ssid
            };
                People.InsertOnSubmit(persons);
                db.SubmitChanges();            
            
        }
        

        
        #endregion

    }
}
