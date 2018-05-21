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

        
        
        public SHSdb(string connection) : base(connection) { }

        public SHSdb() : base("Data Source=.;Initial Catalog=SHSdb4;Integrated Security=True;")
        {
            
        }
    }
}
