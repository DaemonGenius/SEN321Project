using DATALAYER.Controllers;
using DATALAYER.DatabaseConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.BusinessLogic
{
    class MaintenanceInsertProcess
    {

        #region ClientMaintenancesInsert
        public Maintenance InsertMaintenance(Maintenance maintenance)
        {
            using (var dbe = new SHSdb())
            {
                dbe.maintenances.InsertOnSubmit(maintenance);
                dbe.SubmitChanges();
                return maintenance;
            }
        }

        #endregion

        #region MaintenanceUpdate
        public static async Task<Maintenance> UpdateMainten(Maintenance maintenance)
        {
            using (var db = new SHSdb())
            {
                Maintenance existing = db.maintenances.FirstOrDefault(x => x.ID == maintenance.ID);
                if (existing == null) { throw new KeyNotFoundException(); }                
                existing.Contract_ID = maintenance.Contract_ID;
                existing.DateStart = maintenance.DateStart;
                existing.DateEnd = maintenance.DateEnd;
                existing.Name = maintenance.Name;
                db.SubmitChanges();
                return existing;
            }
        }
        #endregion
    }
}
