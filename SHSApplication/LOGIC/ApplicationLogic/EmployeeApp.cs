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
        public List<string> LoadAdminEmp()
        {
            return BusinessLogic.EmployeeProcess.LoadAdmin();
        }


    }
}
