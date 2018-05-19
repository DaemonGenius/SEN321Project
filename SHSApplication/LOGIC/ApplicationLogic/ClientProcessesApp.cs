using DATALAYER.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.ApplicationLogic
{
    public class ClientProcessesApp
    {
        public async Task<People> ClientSearch(string username)
        {
            return await BusinessLogic.ClientProcesses.ClientSearch(username);
        }
    }
}
