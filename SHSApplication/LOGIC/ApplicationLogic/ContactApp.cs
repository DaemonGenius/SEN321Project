using DATALAYER.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.ApplicationLogic
{
    public class ContactApp
    {
        public static List<string> ContractLoad()
        {
            return BusinessLogic.ContractProccess.ContractLoad();
        }

        public async  Task<Contract> GetContractIDAsync(string cName)
        {
            return await BusinessLogic.ContractProccess.GetContractAsync(cName);
        }
    }
}
