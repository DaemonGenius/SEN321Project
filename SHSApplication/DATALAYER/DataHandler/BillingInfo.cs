using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATALAYER.DataHandler
{
    public class Billinginfo
    {
        public Billinginfo()
        {

        }

       
        public int ID { get; set; }
        public string CardName { get; set; }
        public string CardNum { get; set; }
        public string CardCVV { get; set; }
        public string CardExpireDate { get; set; }
        public string CardType { get; set; }
    }
}


