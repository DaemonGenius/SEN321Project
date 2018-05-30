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
                    Gender = person.Gender,
                    
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
        public static async Task<SysConProduct> asClientProductLoad()
        {
            using (var dbe = new SHSdb())
            {
                Client client = dbe.Clients.FirstOrDefault((x => x.Person_ID == ID));
                Transaction transaction = dbe.transactions.FirstOrDefault((x => x.Cart_ID == client.ID));
                ProductSystem productSystems = dbe.productSystems.FirstOrDefault((x => x.Cart_ID == transaction.Cart_ID));
                SysConProduct sysConProduct = dbe.sysConProducts.FirstOrDefault(x => x.ProductSystem.ID == x.ConvienceProduct.ID);

                return new SysConProduct() {                    
                    ConvienceProduct = new ConvienceProduct() {                        
                        Name = sysConProduct.ConvienceProduct.Name,
                        Discription = sysConProduct.ConvienceProduct.Discription,
                        Price = sysConProduct.ConvienceProduct.Price,                        
                    }

                };
            }
        }

        public static async Task<ProductSystem> ClientProductLoad()
        {
            using (var dbe = new SHSdb())
            {
                Client client = dbe.Clients.FirstOrDefault((x => x.Person_ID == ID));
                Transaction transaction = dbe.transactions.FirstOrDefault((x => x.Cart_ID == client.ID));
                ProductSystem productSystems = dbe.productSystems.FirstOrDefault((x => x.Cart_ID == transaction.Cart_ID));
                SysConProduct sysConProduct = dbe.sysConProducts.FirstOrDefault(x => x.ProductSystem.ID == x.ConvienceProduct.ID);

                return new ProductSystem()
                {
                    Name = productSystems.Name,
                    Price = productSystems.Price,
                    SysConProducts = (from con in productSystems.SysConProducts
                                      select new SysConProduct
                                      {
                                          ConvienceProduct = new ConvienceProduct() {
                                              Name = con.ConvienceProduct.Name,
                                              Discription = con.ConvienceProduct.Discription,
                                              Price = con.ConvienceProduct.Price                                              
                                          }                                          
                                      }).ToEntitySet(),
                    SysEneProducts = (from Ene in productSystems.SysEneProducts
                                      select new SysEneProduct
                                      {
                                          EnergyProduct = new EnergyProduct()
                                          {
                                              Name = Ene.EnergyProduct.Name,
                                              Discription = Ene.EnergyProduct.Discription,
                                              Price = Ene.EnergyProduct.Price
                                          }
                                      }).ToEntitySet(),

                    SysSafProducts = (from Saf in productSystems.SysSafProducts
                                      select new SysSafProduct
                                      {
                                          SafetyProduct = new SafetyProduct()
                                          {
                                              Name = Saf.SafetyProduct.Name,
                                              Discription = Saf.SafetyProduct.Discription,
                                              Price = Saf.SafetyProduct.Price
                                          }
                                      }).ToEntitySet()
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
    

