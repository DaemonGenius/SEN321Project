using DATALAYER.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.ApplicationLogic
{
    public class AdminProcessing
    {
        public async Task<People> GetAllEmp()
        {
            return await BusinessLogic.AdminProcesses.GetAllEmployees();
        }
        public async Task<People> UpdatePerson(People person)
        {
            return await BusinessLogic.AdminProcesses.UpdatePerson(person);
        }
    }
}
