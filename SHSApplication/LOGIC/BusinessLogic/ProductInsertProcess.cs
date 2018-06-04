using DATALAYER.Controllers;
using DATALAYER.DatabaseConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.BusinessLogic
{
    public class ProductInsertProcess
    {
        public ProductInsertProcess() { }
        public ConvienceProduct InsertConvienceProduct(ConvienceProduct convienceProduct)
        {
            using (var dbe = new SHSdb())
            {
                dbe.convienceProducts.InsertOnSubmit(convienceProduct);
                dbe.SubmitChanges();
                return convienceProduct;
            }
        }
        public EnergyProduct InsertEnergyProduct(EnergyProduct energyProduct)
        {
            using (var dbe = new SHSdb())
            {
                dbe.energyProducts.InsertOnSubmit(energyProduct);
                dbe.SubmitChanges();
                return energyProduct;
            }
        }
        public SafetyProduct InsertSafetyProduct(SafetyProduct safetyProduct)
        {
            using (var dbe = new SHSdb())
            {
                dbe.safetyProducts.InsertOnSubmit(safetyProduct);
                dbe.SubmitChanges();
                return safetyProduct;
            }
        }
    }
}
