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
                People person =  dbe.peoples.FirstOrDefault((x => x.EmailAddress == Username));
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
