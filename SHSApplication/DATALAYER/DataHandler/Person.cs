using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;

namespace DATALAYER.DataHandler
{
    public class People
    {
        public People()
        {

        }

       
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string SSID { get; set; }
        public string DOB { get; set; }
        public string CellNumber { get; set; }
        public virtual Address Address { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }
        public virtual ICollection<Billinginfo> Billinginfo { get; set; }
    }
}
