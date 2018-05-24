using DATALAYER.Controllers;
using DATALAYER.DatabaseConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.BusinessLogic
{
    public class ProductInfoProcess
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
                
                Transaction transaction = dbe.transactions.FirstOrDefault((x => x.Cart_ID == person.ID));
                TechnicianEmp technicianEmp = dbe.technicianEmps.FirstOrDefault(x => x.ID == transaction.TechnicianEmp_ID);

                return new TechnicianEmp()
                {
                    Person_ID = technicianEmp.Person_ID,
                    People = new People()
                    {
                        FirstName = person.FirstName
                    }
                };
            }
        }
        #endregion

        #region LoadContract

        #endregion

        #region LoadSchedules

        #endregion



    }
}
