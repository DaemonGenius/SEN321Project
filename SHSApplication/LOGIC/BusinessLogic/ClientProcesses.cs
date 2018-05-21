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
    public static class ClientProcesses
    {
        #region ClientSearch
        public static async Task<People> ClientSearch(string Username)
        {
            using (var dbe = new SHSdb())
            {
                People person = dbe.peoples.FirstOrDefault((x => x.EmailAddress == Username));
                //Billinginfoe billinginfoe = dbe.BillingInfo.FirstOrDefault(x => x.ID == person.ID);
                return new People()
                {
                    FirstName = person.FirstName,
                    LastName = person.LastName,
                    EmailAddress = person.EmailAddress,
                    Password = person.Password,
                    CellNumber = person.CellNumber,
                    SSID = person.SSID,
                    DOB = person.DOB,
                    Address = new Address()
                    {
                        ID = person.ID,
                        Street = person.Address.Street,
                        StreetNum = person.Address.StreetNum,
                        Zipcode = person.Address.Zipcode,
                        City = person.Address.City,
                        Country = person.Address.Country,
                        Province = person.Address.Province
                    },
                    Billinginfoes = (from Bilinfo in person.Billinginfoes
                                     select new Billinginfoe
                                     {
                                         CardName = Bilinfo.CardName,
                                         CardNum = Bilinfo.CardNum,
                                         CardCVV = Bilinfo.CardCVV,
                                         CardExpireDate = Bilinfo.CardExpireDate,
                                         CardType = Bilinfo.CardType,
                                     }).ToEntitySet()

            };
            }
        }

        public static EntitySet<T> ToEntitySet<T>(this IEnumerable<T> source) where T : class
        {
            var es = new EntitySet<T>();
            es.AddRange(source);
            return es;
        }
        #endregion
    }



}
    

