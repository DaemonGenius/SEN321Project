using DATALAYER.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.ApplicationLogic
{
    public class ProductManagementUpdateApp
    {
        public async Task<ConvienceProduct> UpdateConvienceProduct(ConvienceProduct convienceProduct)
        {
            return await BusinessLogic.ProductManagementUpdates.UpdateConvienceProduct(convienceProduct);
        }
        public async Task<SafetyProduct> UpdateSafetyProduct(SafetyProduct safetyProduct)
        {
            return await BusinessLogic.ProductManagementUpdates.UpdateSafetyProduct(safetyProduct);
        }
        public async Task<EnergyProduct> UpdateEnergyProduct(EnergyProduct energyProduct)
        {
            return await BusinessLogic.ProductManagementUpdates.UpdateEnergyProduct(energyProduct);
        }
    }
}
