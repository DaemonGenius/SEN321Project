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

        public void RegisterUser(string fname, string lname, string email, string cell, string pass, string DOB, string ssid, 
                                  int StreetNum, string StreetName, string Zipcode, string City, string Province, string Country,
                                  string cardNum, string cardName, string cardCVC, string cardType, string cardExpiryDate)
        {

            People people = new People();

            people = new People
            {
                FirstName = fname,
                LastName = lname,
                EmailAddress = email,
                CellNumber = cell,
                Password = pass,
                DOB = DOB,
                SSID = ssid,
                Address = new Address()
                {
                    StreetNum = StreetNum,
                    Street = StreetName,
                    City = City,
                    Country = Country,
                    Province = Province,
                    Zipcode = Zipcode,
                },
                Billinginfoes = (from Bilinfo in people.Billinginfoes
                                 select new Billinginfoe
                                 {
                                     CardName = cardName,
                                     CardNum = cardNum,
                                     CardCVV = cardCVC,
                                     CardExpireDate = cardExpiryDate,
                                     CardType = cardType,
                                 }).ToEntitySet()

            };
                People.InsertOnSubmit(people);
                db.SubmitChanges();            
            
        }

       



        #endregion

    }
}
