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
        public async Task<Schedule> Schedule(string name)
        {
            return await BusinessLogic.TechnicianProcesses.GetTechSche(name);
        }
    }
}
