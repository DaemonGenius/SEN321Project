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
    }
}
