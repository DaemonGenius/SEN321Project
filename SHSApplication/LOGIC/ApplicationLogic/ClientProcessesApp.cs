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
    }
}
