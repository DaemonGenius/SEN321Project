using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATALAYER.Controllers
{
    [Table(Name = "Billinginfoes")]
    public class BillingInfo
    {
        public BillingInfo() { }
        private int _ID;
        private string _bil_CardName;
        private string _bil_CardNum;
        private string _bil_CardCVV;
        private string _bil_CardExpireDate;
        private string _bil_CardType;

        [Column(IsPrimaryKey = true, Storage = "_ID", CanBeNull = false)]
        public int ID
        {
            get { return this._ID; }
            set { this._ID = value; }
        }

        [Column(Storage = "_bil_CardName")]
        public string bill_CardName
        {
            get { return this._bil_CardName; }
            set { this._bil_CardName = value; }
        }

        [Column(Storage = "_bil_CardNum")]
        public string bil_CardNum
        {
            get { return this._bil_CardNum; }
            set { this._bil_CardNum = value; }
        }

        [Column(Storage = "_bil_CardCVV")]
        public string bil_CardCVV
        {
            get { return this._bil_CardCVV; }
            set { this._bil_CardCVV = value; }
        }


        [Column(Storage = "_bil_CardExpireDate")]
        public string bil_CardExpireDate
        {
            get { return this._bil_CardExpireDate; }
            set { this._bil_CardExpireDate = value; }
        }


        [Column(Storage = "_bil_CardType")]
        public string bil_CardType
        {
            get { return this._bil_CardType; }
            set { this._bil_CardType = value; }
        }

    }
}
