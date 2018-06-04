using DATALAYER.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.ApplicationLogic
{
    public class EmployeeApp
    {
        public List<string> LoadEmp()
        {
            return  BusinessLogic.EmployeeProcess.Loadtech();
        }

        public List<string> LoadSaleEmp()
        {
            return BusinessLogic.EmployeeProcess.LoadSale();
        }

        public async Task<Sale_Emp> Sale_EmpAsync(string fname)
        {
            return await BusinessLogic.EmployeeProcess.Sale_EmpAsync(fname);
        }

        public List<string> LoadAdminEmp()
        {
            return BusinessLogic.EmployeeProcess.LoadAdmin();
        }


    }
}
