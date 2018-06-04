using DATALAYER.Controllers;
using DATALAYER.DatabaseConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.BusinessLogic
{
    public class EmployeeProcess
    {
        public static List<string> Loadtech()
        {
            using (var dbe = new SHSdb())
            {
                return dbe.technicianEmps.Select(x => x.People.FirstName).ToList();
            }
        }

        public static List<string> LoadSale()
        {
            using (var dbe = new SHSdb())
            {
                return dbe.sale_Emps.Select(x => x.People.FirstName).ToList();
            }
        }

        public static List<string> LoadAdmin()
        {
            using (var dbe = new SHSdb())
            {
                return dbe.admins.Select(x => x.People.FirstName).ToList();
            }
        }

        public static async Task<Sale_Emp> Sale_EmpAsync(string fName)
        {
            using (var dbe = new SHSdb())
            {
                Sale_Emp sale_Emp = dbe.sale_Emps.FirstOrDefault(x => x.People.FirstName == fName);

                return new Sale_Emp()
                {
                    ID = sale_Emp.ID,
                    People = new People() {
                        FirstName = sale_Emp.People.FirstName
                    }
                   
                };
            }
        }


    }
}
