using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATALAYER.DataHandler
{
    [Table(Name = "Departments")]
    public class Department
    {
        //private EntitySet<Person> _Person;
        //public Department()
        //{
        //    this._Person = new EntitySet<Person>();
        //}
        private int _DepartmentID;
        [Column(IsPrimaryKey = true, Storage = "_DepartmentID")]
        public int dept_ID
        {
            get { return this._DepartmentID; }
            set { this._DepartmentID = value; }
            
        }
        private string _deptType;
        [Column(Storage = "_deptType")]
        public string dept_Type
        {
            get { return this._deptType; }
            set { this._deptType = value; }
        }
        //[Association(Storage = "_Person", OtherKey = "ID")]
        //public EntitySet<Person> Persons
        //{
        //    get { return this._Person; }
        //    set { this._Person.Assign(value); }
        //}

    }
}
