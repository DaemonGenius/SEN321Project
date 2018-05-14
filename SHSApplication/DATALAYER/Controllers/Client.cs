using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATALAYER.Controllers
{
    [Table(Name = "Client")]
    public class Client
    {
        private int _ID;
        private DateTime _dateJoined;
        public Client() { }
                      

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
       
    }
}
