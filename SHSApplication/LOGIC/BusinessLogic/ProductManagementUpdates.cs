using DATALAYER.Controllers;
using DATALAYER.DatabaseConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.BusinessLogic
{
    class ProductManagementUpdates
    {
        public static async Task<ConvienceProduct> UpdateConvienceProduct(ConvienceProduct convienceProduct)
        {
            using (var db = new SHSdb())
            {
                ConvienceProduct existing = db.convienceProducts.FirstOrDefault(x => x.ID == convienceProduct.ID);
                if (existing == null) { throw new KeyNotFoundException(); }
                existing.ID = convienceProduct.ID;
                existing.Name = convienceProduct.Name;
                existing.Discription = convienceProduct.Discription;
                existing.Price = convienceProduct.Price;
                existing.Warrenty_ID = convienceProduct.Warrenty_ID;
                db.SubmitChanges();
                return existing;
            }
        }

        public static async Task<SafetyProduct> UpdateSafetyProduct(SafetyProduct safetyProduct)
        {
            using (var db = new SHSdb())
            {
                SafetyProduct existing = db.safetyProducts.FirstOrDefault(x => x.ID == safetyProduct.ID);
                if (existing == null) { throw new KeyNotFoundException(); }
                existing.ID = safetyProduct.ID;
                existing.Name = safetyProduct.Name;
                existing.Discription = safetyProduct.Discription;
                existing.Price = safetyProduct.Price;
                existing.Warrenty_ID = safetyProduct.Warrenty_ID;
                db.SubmitChanges();
                return existing;
            }
        }
        public static async Task<EnergyProduct> UpdateEnergyProduct(EnergyProduct energyProduct)
        {
            using (var db = new SHSdb())
            {
                EnergyProduct existing = db.energyProducts.FirstOrDefault(x => x.ID == energyProduct.ID);
                if (existing == null) { throw new KeyNotFoundException(); }
                existing.ID = energyProduct.ID;
                existing.Name = energyProduct.Name;
                existing.Discription = energyProduct.Discription;
                existing.Price = energyProduct.Price;
                existing.Warrenty_ID = energyProduct.Warrenty_ID;
                db.SubmitChanges();
                return existing;
            }
        }
    }
}
