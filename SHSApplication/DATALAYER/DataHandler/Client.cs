using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATALAYER.DataHandler
{
    [Table(Name = "Client")]
    public class Client
    {
        private int _ID;
        private DateTime _dateJoined;
        private Person _PersonID;

        public EntityRef<Person> _Person;
        public Client() { this._Person = new EntityRef<Person>(); }

        [Column(IsPrimaryKey = true, Storage = "_ID")]
        public int ID
        {
            get { return this._ID; }
            set { this._ID = value; }

        }
        [Column(Storage = "_dateJoined")]
        public DateTime dateJoined
        {
            get { return this._dateJoined; }
            set { this._dateJoined = value; }

        }
        [Column(Storage = "_Person_ID", DbType = "Int")]
        public Person Person_ID
        {
            get { return this._PersonID; }
            set { this._PersonID = value; }
        }

        [Association(Storage = "_Person_ID", ThisKey = "Person_ID")]
        public Person Person
        {
            get { return this.Person; }
            set { this.Person = value; }
        }
    }
}
