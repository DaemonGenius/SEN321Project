using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATALAYER.DataHandler
{
    public class SHSdb2 : DataContext
    {
        public Table<Person> People;
        public Table<Department> Department;
        //public Table<Address> Address;
        public SHSdb2(string connection) : base(connection) { }
    }
}
