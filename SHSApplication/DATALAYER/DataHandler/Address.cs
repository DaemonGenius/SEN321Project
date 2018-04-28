using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATALAYER.DataHandler
{
   [Table(Name = "Addresses")]
    public class Address
    {
        private int adr_ID;
        private string adr_Street;
        private string adr_StreetNum;
        private string adr_Zipcode;
        private string adr_City;
        private string adr_Province;
        private string adr_Country;
        private int Person_ID;

        public EntityRef<Person> _Person;
        public Address() { this._Person = new EntityRef<Person>(); }

        [Column(Storage ="_adr_ID", IsPrimaryKey =true)]
        public int _AddressID
        {
            get { return this._AddressID; }
            set { this._AddressID = value; }
        }
        [Column(Name ="adr_Street",Storage ="_adr_Street")]
        public string _adr_Street
        {
            get { return this._adr_Street; }
            set { this._adr_Street = value; }
        }
        [Column(Name = "adr_StreetNum", Storage = "_adr_StreetNum")]
        public string _adr_StreetNum
        {
            get { return this._adr_StreetNum; }
            set { this._adr_StreetNum = value; }
        }
        [Column(Name = "adr_Zipcode", Storage = "_adr_Zipcode")]
        public string _adr_Zipcode
        {
            get { return this._adr_Zipcode; }
            set { this._adr_Zipcode = value; }
        }
        [Column(Name = "adr_City", Storage = "_adr_City")]
        public string _adr_City
        {
            get { return this._adr_City; }
            set { this._adr_City = value; }
        }
        [Column(Name = "adr_Province", Storage = "_adr_Province")]
        public string _adr_Province
        {
            get { return this._adr_Province; }
            set { this._adr_Province = value; }
        }
        [Column(Name = "adr_County", Storage = "_adr_County")]
        public string _adr_County
        {
            get { return this._adr_County; }
            set { this._adr_County = value; }
        }
        [Column(Storage = "_PersonID", DbType = "Int")]
        public int _PersonID
        {
            get { return this._PersonID; }
            set { this._PersonID = value; }
        }

        [Association(Storage = "_PersonID", ThisKey = "Person_ID")]
        public Person Person
        {
            get { return this._Person.Entity; }
            set { this._Person.Entity = value; }
        }


    }
}
