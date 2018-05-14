using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATALAYER.Controllers
{
    [Table(Name = "People")]
    public class People
    {      
      
            public People() { }
            private int _ID;
            private string _p_FirstName;
            private string _LastName;
            private string _EmailAddress;
            private string _Password;
            private string _SSID;
            private string _DOB;
            private string _CellNumber;

       
        [Column(IsPrimaryKey = true, Storage = "_ID", CanBeNull = false)]
        public int ID
        {
            get { return this._ID; }
            set { this._ID = value; }
        }
       
        [Column(Storage = "_p_FirstName")]
        public string p_FirstName
        {
            get { return this._p_FirstName; }
            set { this._p_FirstName = value; }
        }
      
        [Column(Storage = "_LastName")]
        public string p_LastName
        {
            get { return this._LastName; }
            set { this._LastName = value; }
        }
       
        [Column(Storage = "_EmailAddress")]
        public string p_EmailAddress
        {
            get { return this._EmailAddress; }
            set { this._EmailAddress = value; }
        }
  
        [Column(Storage = "_Password")]
        public string p_Password
        {
            get { return this._Password; }
            set { this._Password = value; }
        }
    
        [Column(Storage = "_SSID")]
        public string p_SSID
        {
            get { return this._SSID; }
            set { this._SSID = value; }
        }
 
        [Column(Storage = "_DOB")]
        public string p_DOB
        {
            get { return this._DOB; }
            set { this._DOB = value; }
        }
        
        [Column(Storage = "_CellNumber")]
        public string p_CellNumber
        {
            get { return this._CellNumber; }
            set { this._CellNumber = value; }
        }



    }
}

