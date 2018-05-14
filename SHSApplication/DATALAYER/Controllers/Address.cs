using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATALAYER.Controllers
{
    [Table(Name = "Addresses")]
    public class Address
    {
        private int _adr_ID;
        private string _adr_Street;
        private int _adr_StreetNum;
        private string _adr_Zipcode;
        private string _adr_City;
        private string _adr_Province;
        private string _adr_Country;
        private int _Person_ID;

        public EntityRef<People> _Person;
        public Address() { this._Person = new EntityRef<People>(); }

        [Column(Storage = "_adr_ID", IsPrimaryKey = true)]
        public int adr_ID
        {
            get { return this._adr_ID; }
            set { this._adr_ID = value; }
        }
        [Column(Storage = "_adr_Street")]
        public string adr_Street
        {
            get { return this._adr_Street; }
            set { this._adr_Street = value; }
        }
        [Column(Storage = "_adr_StreetNum")]
        public int adr_StreetNum
        {
            get { return this._adr_StreetNum; }
            set { this._adr_StreetNum = value; }
        }
        [Column(Storage = "_adr_Zipcode")]
        public string adr_Zipcode
        {
            get { return this._adr_Zipcode; }
            set { this._adr_Zipcode = value; }
        }
        [Column(Storage = "_adr_City")]
        public string adr_City
        {
            get { return this._adr_City; }
            set { this._adr_City = value; }
        }
        [Column(Storage = "_adr_Province")]
        public string adr_Province
        {
            get { return this._adr_Province; }
            set { this._adr_Province = value; }
        }
        [Column(Storage = "_adr_Country")]
        public string adr_Country
        {
            get { return this._adr_Country; }
            set { this._adr_Country = value; }
        }
        [Column(Storage = "_Person_ID", DbType = "Int")]
        public int Person_ID
        {
            get { return this._Person_ID; }
            set { this._Person_ID = value; }
        }


    }
}