using DATALAYER.Controllers;
using DATALAYER.DatabaseConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.BusinessLogic
{
    public static class ContractProccess
    {
        public static List<string> ContractLoad()
        {
            using (var dbe = new SHSdb())
            {

                return dbe.contracts.Select(x => x.ContractName).ToList();

            }
        }

        public static async Task<Contract> GetContractAsync(string cName)
        {
            using (var dbe = new SHSdb())
            {
                Contract contract = dbe.contracts.FirstOrDefault(x => x.ContractName == cName);
                return new Contract()
                {
                    ID = contract.ID,
                    ContractName = contract.ContractName
                };
            }
        }
    }
}
