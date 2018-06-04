using DATALAYER.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.ApplicationLogic
{
    public class ProductInsertApp
    {
        public bool SafetyProductInsert(string PName, string Discrip, double Price, int WarID)
        {
            SafetyProduct safetyProduct = new SafetyProduct
            {               
                Name = PName,
                Discription = Discrip,
                Price = Price,
                Warrenty_ID = WarID,             
            };
            BusinessLogic.ProductInsertProcess productInsertProcess = new BusinessLogic.ProductInsertProcess();
            productInsertProcess.InsertSafetyProduct(safetyProduct);
            return true;
        }
        public bool EnergyProductInsert(string PName, string Discrip, double Price, int WarID)
        {
            EnergyProduct energyProduct = new EnergyProduct
            {
                
                Name = PName,
                Discription = Discrip,
                Price = Price,
                Warrenty_ID = WarID,
            };
            BusinessLogic.ProductInsertProcess productInsertProcess = new BusinessLogic.ProductInsertProcess();
            productInsertProcess.InsertEnergyProduct(energyProduct);
            return true;
        }
        public bool ConvProductInsert(string PName, string Discrip, double Price, int WarID)
        {
            ConvienceProduct convienceProduct = new ConvienceProduct
            {
               
                Name = PName,
                Discription = Discrip,
                Price = Price,
                Warrenty_ID = WarID,
            };
            BusinessLogic.ProductInsertProcess productInsertProcess = new BusinessLogic.ProductInsertProcess();
            productInsertProcess.InsertConvienceProduct(convienceProduct);
            return true;
        }
    }
}
