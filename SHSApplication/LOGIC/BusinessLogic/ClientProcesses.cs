using DATALAYER.Controllers;
using DATALAYER.DatabaseConnection;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.BusinessLogic
{
    public class ClientProcesses
    {
        #region ClientSearch
        public static async Task<People> ClientSearch(string Username)
        {
            using (var dbe = new SHSdb())
            {
                Address address = new Address();
                People person =  dbe.peoples.FirstOrDefault((x => x.EmailAddress == Username));
                address = dbe.Address.FirstOrDefault((x => x.adr_ID == person.ID));
                address = new Address()
                {
                    adr_ID = person.ID,
                    adr_Street = address.adr_Street,
                    adr_StreetNum = address.adr_StreetNum,
                    adr_Zipcode = address.adr_Zipcode,
                    adr_City = address.adr_City,
                    adr_Country = address.adr_Country,
                    adr_Province = address.adr_Province
                };

                return new People()
                {
                    FirstName = person.FirstName,
                    LastName = person.LastName,
                    EmailAddress = person.EmailAddress,
                    Password = person.Password,
                    CellNumber = person.CellNumber,
                    SSID = person.SSID,
                    DOB = person.DOB,                   
                    

                };
            }

        }
        #endregion
    }
}
