using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATALAYER.DataHandler
{
    [Table(Name = "Addresses")]
    public class Address
    {
        public Address()
        {

        }
        
        public int ID { get; set; }
        public string Street { get; set; }
        public int StreetNum { get; set; }
        public string Zipcode { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }

    }
}
