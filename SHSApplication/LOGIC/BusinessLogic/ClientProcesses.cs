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
        #region Public Variables
        public static int ID;
        public static int cartID;
        public static int clientID;
        #endregion
        #region ClientSearch
        public static async Task<People> ClientSearch(string Username)
        {
            using (var dbe = new SHSdb())
            {
                People person = dbe.peoples.FirstOrDefault((x => x.EmailAddress == Username));
                ID = person.ID;
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

        
        #endregion
        #region ClientProductSearch
        public static async Task<ProductSystem> ClientProductLoad()
        {
            using (var dbe = new SHSdb())
            {
                Client client = dbe.Clients.FirstOrDefault((x => x.Person_ID == ID));
                Transaction transaction = dbe.transactions.FirstOrDefault((x => x.Cart_ID == client.ID));
                ProductSystem productSystems = dbe.productSystems.FirstOrDefault((x => x.Cart_ID == transaction.Cart_ID));
                ConvienceProduct convienceProduct = dbe.convienceProducts.FirstOrDefault((x => x.ProductSystems_ID == productSystems.ID));

                return new ProductSystem()
                {
                    Name = productSystems.Name,                   
                    ConvienceProducts = (from ConvPro in productSystems.ConvienceProducts
                                         select new ConvienceProduct
                                         {
                                             Name = ConvPro.Name,
                                             Discription = ConvPro.Discription,
                                             Price = ConvPro.Price,
                                         }).ToEntitySet(),
                    EnergyProducts = (from EnerPro in productSystems.EnergyProducts
                                      select new EnergyProduct
                                      {
                                          Name = EnerPro.Name,
                                          Discription = EnerPro.Discription,
                                          Price = EnerPro.Price,
                                      }).ToEntitySet(),
                    SafetyProducts = (from SafPro in productSystems.SafetyProducts
                                      select new SafetyProduct
                                      {
                                          Name = SafPro.Name,
                                          Discription = SafPro.Discription,
                                          Price = SafPro.Price,
                                      }).ToEntitySet(),
                    
                };
            }
        }
        #endregion
        

        //public static EntitySet<T> ToEntitySet<T>(this IEnumerable<T> source) where T : class
        //{
        //    var es = new EntitySet<T>();
        //    es.AddRange(source);
        //    return es;
        //}
    }



}
    

