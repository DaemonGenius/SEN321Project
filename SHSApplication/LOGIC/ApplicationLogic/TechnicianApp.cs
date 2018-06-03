using DATALAYER.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.ApplicationLogic
{
    public class TechnicianApp
    {
        public async Task<Maintenance> Maintenance(string name)
        {
            return await BusinessLogic.TechnicianProcesses.LoadTechSche(name);
        }

        public async Task<TechnicianEmp> Maintenances(string name)
        {
            return await BusinessLogic.TechnicianProcesses.GetTechMain(name);
        }

        public static List<string> TechNLoadApp()
        {
            return BusinessLogic.TechnicianProcesses.TechNameLoad();
        }
    }
}
