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
    public static class ProductInfoProcess
    {

        #region ConProduct
        public static async Task<ConvienceProduct> ConProductInfo(string name)
        {
            using (var dbe = new SHSdb())
            {
                ConvienceProduct convienceProduct = dbe.convienceProducts.FirstOrDefault((x => x.Name == name));
                return new ConvienceProduct()
                {
                    Name = convienceProduct.Name,
                    Discription = convienceProduct.Discription,
                    Price = convienceProduct.Price,
                    Warrenty = new Warrenty()
                    {
                        Discription = convienceProduct.Warrenty.Discription,
                        Type = convienceProduct.Warrenty.Type,
                        Duration = convienceProduct.Warrenty.Duration,                        
                    }


                };
            }
        }
        #endregion
        #region SafeProduct
        public static async Task<SafetyProduct> SafProductInfo(string name)
        {
            using (var dbe = new SHSdb())
            {
                SafetyProduct safetyProducts = dbe.safetyProducts.FirstOrDefault((x => x.Name == name));
                return new SafetyProduct()
                {
                    Name = safetyProducts.Name,
                    Discription = safetyProducts.Discription,
                    Price = safetyProducts.Price,
                    Warrenty = new Warrenty()
                    {
                        Discription = safetyProducts.Warrenty.Discription,
                        Type = safetyProducts.Warrenty.Type,
                        Duration = safetyProducts.Warrenty.Duration,
                    }


                };
            }
        }
        #endregion
        #region EnergyProduct
        public static async Task<EnergyProduct> EnProductInfo(string name)
        {
            using (var dbe = new SHSdb())
            {
                EnergyProduct energyProducts = dbe.energyProducts.FirstOrDefault((x => x.Name == name));
                return new EnergyProduct()
                {
                    Name = energyProducts.Name,
                    Discription = energyProducts.Discription,
                    Price = energyProducts.Price,
                    Warrenty = new Warrenty()
                    {
                        Discription = energyProducts.Warrenty.Discription,
                        Type = energyProducts.Warrenty.Type,
                        Duration = energyProducts.Warrenty.Duration,
                    }


                };
            }
        }
        #endregion
        #region LoadTechnician
        public static async Task<TechnicianEmp> GetTransactionTech()
        {
            using (var dbe = new SHSdb())
            {
                People person = dbe.peoples.FirstOrDefault((x => x.ID == ClientProcesses.ID));
                Transaction transaction = dbe.transactions.FirstOrDefault((x => x.Cart_ID == x.ID ));              

                return new TechnicianEmp()
                {
                    People = new People()
                    {
                        FirstName = transaction.TechnicianEmp.People.FirstName,
                        LastName = transaction.TechnicianEmp.People.LastName                        
                    }
                };
            }
        }
        #endregion
        #region LoadContract
        public static async Task<Contract> GetContract()
        {
            using (var dbe = new SHSdb())
            {
                People person = dbe.peoples.FirstOrDefault((x => x.ID == ClientProcesses.ID));
                Transaction transaction = dbe.transactions.FirstOrDefault((x => x.Cart_ID == x.ID));

                return new Contract()
                {
                   ContractName = transaction.Contract.ContractName,
                   Maintenances = (from Maindate in transaction.Contract.Maintenances
                                   select new Maintenance
                                   {
                                       DateStart = Maindate.DateStart,
                                       DateEnd = Maindate.DateEnd
                                   }).ToEntitySet(),

                };
            }
        }
        #endregion
        #region LoadSchedules
        public static async Task<TechnicianEmp> GetSchedule()
        {
            using (var dbe = new SHSdb())
            {
                People person = dbe.peoples.FirstOrDefault((x => x.ID == ClientProcesses.ID));
                TechnicianEmp technicianEmp = dbe.technicianEmps.FirstOrDefault(x => x.ID == person.ID);
                Transaction transaction = dbe.transactions.FirstOrDefault((x => x.TechnicianEmp_ID == technicianEmp.ID));

                return new TechnicianEmp()
                {
                    Schedules = (from Schedate in technicianEmp.Schedules
                                 select new Schedule
                                 {
                                     InsDateStart = Schedate.InsDateStart,
                                     MainDateStart = Schedate.MainDateStart
                                 }).ToEntitySet(),

                };
            }
        }
        #endregion
        #region ProductSearch
        //public static async Task<ConvienceProduct> ConProductSearch()
        //{

        //    using (var dbe = new SHSdb())
        //    {
        //        ConvienceProduct convienceProduct;


        //        return dbe.convienceProducts.Select(x => new ConvienceProduct()
        //        {
        //            Name = x.Name,

        //        }).ToEntitySet();

        //    }
        //}

        public static EnergyProduct[] EnProductSearch()
        {
            using (var dbe = new SHSdb())
            {
                return dbe.energyProducts.Select(x => new EnergyProduct()
                {
                    Name = x.Name,                   

                }).ToArray();
            }
        }
        public static SafetyProduct[] SafProductSearch()
        {
            using (var dbe = new SHSdb())
            {
                return dbe.safetyProducts.Select(x => new SafetyProduct()
                {
                    Name = x.Name,                  

                }).ToArray();
            }
        }
        #endregion
        public static EntitySet<T> ToEntitySet<T>(this IEnumerable<T> source) where T : class
        {
            var es = new EntitySet<T>();
            es.AddRange(source);
            return es;
        }

    }
}
