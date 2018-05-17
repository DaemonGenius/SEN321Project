using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATALAYER.Controllers
{
    [Table(Name = "People")]
    public class People
    {      
      
           
            private int _ID;
            private string _FirstName;
            private string _LastName;
            private string _EmailAddress;
            private string _Password;
            private string _SSID;
            private string _DOB;
            private string _CellNumber;
            private string _Gender;
            private string _Department;
            private string _adr_ID;

            private EntitySet<Address> _Address;

        
        public People() { this._Address = new EntitySet<Address>(); }

        [Column(IsPrimaryKey = true, Storage = "_ID", CanBeNull = false)]
        public int ID
        {
            get { return this._ID; }
            set { this._ID = value; }
        }
       
        [Column(Storage = "_FirstName")]
        public string FirstName
        {
            get { return this._FirstName; }
            set { this._FirstName = value; }
        }
      
        [Column(Storage = "_LastName")]
        public string LastName
        {
            get { return this._LastName; }
            set { this._LastName = value; }
        }
       
        [Column(Storage = "_EmailAddress")]
        public string EmailAddress
        {
            get { return this._EmailAddress; }
            set { this._EmailAddress = value; }
        }
  
        [Column(Storage = "_Password")]
        public string Password
        {
            get { return this._Password; }
            set { this._Password = value; }
        }
    
        [Column(Storage = "_SSID")]
        public string SSID
        {
            get { return this._SSID; }
            set { this._SSID = value; }
        }
 
        [Column(Storage = "_DOB")]
        public string DOB
        {
            get { return this._DOB; }
            set { this._DOB = value; }
        }
        
        [Column(Storage = "_CellNumber")]
        public string CellNumber
        {
            get { return this._CellNumber; }
            set { this._CellNumber = value; }
        }
        //[Column(Storage = "_Gender")]
        //public string Gender
        //{
        //    get { return this._Gender; }
        //    set { this._Gender = value; }
        //}
        [Column(Storage = "_Department")]
        public string Department
        {
            get { return this._Department; }
            set { this._Department = value; }
        }
        [Column(Storage = "_adr_ID")]
        public string AddressID
        {
            get { return this._adr_ID; }
            set { this._adr_ID = value; }
        }

        [Association(Storage = "_Address", OtherKey = "_adr_ID")]
        public EntitySet<Address> Address
        {
            get { return this._Address; }
            set { this._Address.Assign(value); }
        }



    }
}

