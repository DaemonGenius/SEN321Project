using System.Data.Linq.Mapping;

namespace DATALAYER.DataHandler
{
   
        [Table(Name = "People")]
        public class Person
        {
            private int _ID;
            [Column(Name = "ID" ,IsPrimaryKey =true, Storage ="_ID")]
            public int PersonID
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
            [Column(IsPrimaryKey = true, Storage = "_LastName")]
            public string p_LastName
            {
                get { return this._LastName; }
                set { this._LastName = value; }
            }
        //private string _EmailAddress;
        //[Column(IsPrimaryKey = true, Storage = "_EmailAddress")]
        //public string EmailAddress
        //{
        //    get { return this._EmailAddress; }
        //    set { this._EmailAddress = value; }
        //}
        //private string _Password;
        //[Column(IsPrimaryKey = true, Storage = "_Password")]
        //public string Password
        //{
        //    get { return this._Password; }
        //    set { this._Password = value; }
        //}
        //private string _SSID;
        //[Column(IsPrimaryKey = true, Storage = "_SSID")]
        //public string SSID
        //{
        //    get { return this._SSID; }
        //    set { this._SSID = value; }
        //}
        //private string _DOB;
        //[Column(IsPrimaryKey = true, Storage = "_DOB")]
        //public string DOB
        //{
        //    get { return this._DOB; }
        //    set { this._DOB = value; }
        //}
        //private string _CellNumber;
        //[Column(IsPrimaryKey = true, Storage = "_CellNumber")]
        //public string CellNumber
        //{
        //    get { return this._CellNumber; }
        //    set { this._CellNumber = value; }
        //}
    }
    }

