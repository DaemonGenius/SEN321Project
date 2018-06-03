using DATALAYER.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.ApplicationLogic
{
    public class MaintenanceInsertApp
    {
        public int Client;
        public int Contract;
        public int TechnicianName;
        public int SysName;
        public string StartT;
        public string EndT;
        public string MainName;

        public bool InsertNewMain(int Client, int Contract, int TechnicianName, int SysName, DateTime StartT, DateTime EndT, string MainName)
        {
            Maintenance maintenance = new Maintenance
            {
                Client_ID = Client,
                Contract_ID = Contract,
                TechnicianEmp_ID = TechnicianName,
                ProductSystems_ID = SysName,
                DateStart = StartT,
                DateEnd = EndT,
                Name = MainName,
               
            };
            BusinessLogic.MaintenanceInsertProcess maintenanceInsertProcess = new BusinessLogic.MaintenanceInsertProcess();
            maintenanceInsertProcess.InsertMaintenance(maintenance);
            return true;
        }

        public async Task<Maintenance> UpdateMaintenance(Maintenance maintenance)
        {
            return await BusinessLogic.MaintenanceInsertProcess.UpdateMainten(maintenance);
        }
    }
}
