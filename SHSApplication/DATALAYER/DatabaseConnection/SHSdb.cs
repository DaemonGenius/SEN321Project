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
        public Table<BillingInfo> BillingInfo;
        public Table<Client> Client;
        public SHSdb(string connection) : base(connection) { }

        public SHSdb() : base("EF")
        {

        }
    }
}
