using DATALAYER.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.ApplicationLogic
{
    public class ProductInfoApp
    {
        public async Task<SafetyProduct> SafProductLoad(string name)
        {
            return await BusinessLogic.ProductInfoProcess.SafProductInfo(name);
        }
        public async Task<ConvienceProduct> ConProductLoad(string name)
        {
            return await BusinessLogic.ProductInfoProcess.ConProductInfo(name);
        }
        public async Task<EnergyProduct> ENProductLoad(string name)
        {
            return await BusinessLogic.ProductInfoProcess.EnProductInfo(name);
        }
        public async Task<TechnicianEmp> techProductLoad()
        {
            return await BusinessLogic.ProductInfoProcess.GetTransactionTech();
        }
        public async Task<TechnicianEmp> techScheduleLoad()
        {
            return await BusinessLogic.ProductInfoProcess.GetSchedule();
        }
        public async Task<Contract> ContractLoad()
        {
            return await BusinessLogic.ProductInfoProcess.GetContract();
        }

        public static List<string> ConProduct()
        {
            return  BusinessLogic.ProductInfoProcess.ConProductSearch();
        }
        public static List<string> EnProduct()
        {
            return BusinessLogic.ProductInfoProcess.EnProductSearch();
        }
        public static List<string> SafProduct()
        {
            return BusinessLogic.ProductInfoProcess.SafProductSearch();
        }


    }
}
