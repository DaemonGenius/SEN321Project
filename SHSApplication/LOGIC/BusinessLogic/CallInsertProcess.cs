using DATALAYER.Controllers;
using DATALAYER.DatabaseConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.BusinessLogic
{
    public class CallInsertProcess
    {
        public CallInsertProcess() { }
        public Messaging InsertMessaging(Messaging messaging)
        {
            using (var dbe = new SHSdb())
            {
                dbe.messagings.InsertOnSubmit(messaging);
                dbe.SubmitChanges();
                return messaging;
            }
        }
        public Client RegisterClient(Client client)
        {
            using (var dbe = new SHSdb())
            {
                dbe.Clients.InsertOnSubmit(client);
                dbe.SubmitChanges();
                return client;
            }
        }
        public Admin RegisterAdmin(Admin admin)
        {
            using (var dbe = new SHSdb())
            {
                dbe.admins.InsertOnSubmit(admin);
                dbe.SubmitChanges();
                return admin;
            }
        }
        public TechnicianEmp RegisterTech(TechnicianEmp technicianEmp)
        {
            using (var dbe = new SHSdb())
            {
                dbe.technicianEmps.InsertOnSubmit(technicianEmp);
                dbe.SubmitChanges();
                return technicianEmp;
            }
        }
        public Sale_Emp RegisterSales(Sale_Emp sale_Emp)
        {
            using (var dbe = new SHSdb())
            {
                dbe.sale_Emps.InsertOnSubmit(sale_Emp);
                dbe.SubmitChanges();
                return sale_Emp;
            }
        }
    }
}
