using DATALAYER.Controllers;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATALAYER.DatabaseConnection
{
    public partial class SHSdb : DataContext
    {
        public Table<People> peoples;
        public Table<Address> Address;
        public Table<Billinginfoe> BillingInfo;
        public Table<Client> Clients;
        public Table<Admin> admins;
        public Table<TechnicianEmp> technicianEmps;
        public Table<Sale_Emp> sale_Emps;
        public Table<Messaging> messagings;
        public Table<Transaction> transactions;
        public Table<Contract> contracts;
        public Table<Maintenance> maintenances;
        public Table<Schedule> schedules;
        public Table<Cart> carts;
        public Table<ProductSystem> productSystems;
        public Table<EnergyProduct> energyProducts;
        public Table<ConvienceProduct> convienceProducts;
        public Table<SafetyProduct> safetyProducts;
        public Table<Warrenty> warrenties;
        public Table<SysSafProduct> sysSafProducts;
        public Table<SysEneProduct> sysEneProducts;
        public Table<SysConProduct> sysConProducts;



        public SHSdb(string connection) : base(connection) { }

        public SHSdb() : base("Data Source=.;Initial Catalog=SHSdb6;Integrated Security=True;")
        {
            
        }
    }
}
