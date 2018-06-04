using DATALAYER.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIC.ApplicationLogic
{
    public class ClientProcessesApp
    {
        public async Task<People> ClientSearch(string username)
        {
            return await BusinessLogic.ClientProcesses.ClientSearch(username);
        }
        public async Task<Client> ClientLoad(string username)
        {
            return await BusinessLogic.ClientProcesses.ClientLoad(username);
        }
        public async Task<People> ClientPSys(string fname)
        {
            return await BusinessLogic.ClientProcesses.ClientProductLoad(fname);
        }

        public async Task<Client> GetClientID()
        {
            return await BusinessLogic.ClientProcesses.GetClientID();
        }
        

        public async Task<ProductSystem> ProductLoad()
        {
            try
            {
                return await BusinessLogic.ClientProcesses.ClientProductLoad();
            }
            catch (NullReferenceException e)
            {
                MessageBox.Show("Error");
                throw;
            }
            
        }

        public static List<string> ClientFNLoadApp()
        {
            return BusinessLogic.ClientProcesses.ClientFNLoad();
        }
    }
}
