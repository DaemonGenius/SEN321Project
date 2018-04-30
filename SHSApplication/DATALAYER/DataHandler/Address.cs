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
        private string _adr_Street;
        private string _adr_StreetNum;
        private string _adr_Zipcode;
        private string _adr_City;
        private string _adr_Province;
        private string _adr_Country;
        private int _Person_ID;

        public EntityRef<Person> _Person;
        public Address() { this._Person = new EntityRef<Person>(); }

        [Column(Storage ="adr_ID", IsPrimaryKey =true)]
        public int AddressID
        {
            get { return this.AddressID; }
            set { this.AddressID = value; }
        }
        [Column(Storage = "_adr_Street")]
        public string adr_Street
        {
            get { return this.adr_Street; }
            set { this.adr_Street = value; }
        }
        [Column(Storage = "_adr_StreetNum")]
        public string adr_StreetNum
        {
            get { return this.adr_StreetNum; }
            set { this.adr_StreetNum = value; }
        }
        [Column(Storage = "_adr_Zipcode")]
        public string adr_Zipcode
        {
            get { return this.adr_Zipcode; }
            set { this.adr_Zipcode = value; }
        }
        [Column(Storage = "_adr_City")]
        public string adr_City
        {
            get { return this.adr_City; }
            set { this.adr_City = value; }
        }
        [Column(Storage = "_adr_Province")]
        public string adr_Province
        {
            get { return this.adr_Province; }
            set { this.adr_Province = value; }
        }
        [Column(Storage = "_adr_Country")]
        public string adr_Country
        {
            get { return this.adr_Country; }
            set { this.adr_Country = value; }
        }
        [Column(Storage = "PersonID", DbType = "Int")]
        public int Person_ID
        {
            get { return this.Person_ID; }
            set { this.Person_ID = value; }
        }

        [Association(Storage = "PersonID", ThisKey = "Person_ID")]
        public Person Person
        {
            get { return this._Person.Entity; }
            set { this._Person.Entity = value; }
        }


    }
}
