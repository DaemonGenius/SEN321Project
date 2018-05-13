using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace DATALAYER.DataHandler
{

    [Table(Name = "People")]

        public class Person 
        {
      
       
        private int _DepartmentID;
        public EntityRef<Department> _Department;
        public Person() { this._Department = new EntityRef<Department>(); }
        private int _ID;
            [Column(IsPrimaryKey =true, Storage ="_ID", CanBeNull =false)]
            public int ID
            {
                get { return this._ID; }
                set { this._ID = value; }
            }
            private string _p_FirstName;
            [Column(Storage = "_p_FirstName")]
            public string p_FirstName
            {
                get { return this._p_FirstName; }
                set { this._p_FirstName = value; }
            }
            private string _LastName;
            [Column(Storage = "_LastName")]
            public string p_LastName
            {
                get { return this._LastName; }
                set { this._LastName = value; }
            }
            private string _EmailAddress;
            [Column(Storage = "_EmailAddress")]
            public string p_EmailAddress
            {
                get { return this._EmailAddress; }
                set { this._EmailAddress = value; }
            }
            private string _Password;
            [Column(Storage = "_Password")]
            public string p_Password
            {
                get { return this._Password; }
                set { this._Password = value; }
            }
            private string _SSID;
            [Column(Storage = "_SSID")]
            public string p_SSID
            {
                get { return this._SSID; }
                set { this._SSID = value; }
            }
            private string _DOB;
            [Column(Storage = "_DOB")]
            public string p_DOB
            {
                get { return this._DOB; }
                set { this._DOB = value; }
            }
            private string _CellNumber;
            [Column(Storage = "_CellNumber")]
            public string p_CellNumber
            {
                get { return this._CellNumber; }
                set { this._CellNumber = value; }
            }

        [Column(Storage = "_DepartmentID", DbType = "Int")]
        public int p_Department_dept_ID
        {
            get { return this._DepartmentID; }
            set { this._DepartmentID = value; }
        }

        //[Association(Storage = "_DepartmentID", ThisKey = "p_Department_dept_ID", IsForeignKey = true)]
        //public Department Department
        //{
        //    get { return this._Department.Entity; }
        //    set { this._Department.Entity = value; }
        //}
    }
    
}

