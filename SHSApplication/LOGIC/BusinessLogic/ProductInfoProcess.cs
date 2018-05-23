using DATALAYER.Controllers;
using DATALAYER.DatabaseConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.BusinessLogic
{
    public class ProductInfoProcess
    {

        #region ConProduct
        public static async Task<ConvienceProduct> ConProductInfo(string name)
        {
            using (var dbe = new SHSdb())
            {
                ConvienceProduct convienceProduct = dbe.convienceProducts.FirstOrDefault((x => x.Name == name));
                return new ConvienceProduct()
                {
                    Name = convienceProduct.Name,
                    Discription = convienceProduct.Discription,
                    Price = convienceProduct.Price,
                    Warrenty = new Warrenty()
                    {
                        Discription = convienceProduct.Warrenty.Discription,
                        Type = convienceProduct.Warrenty.Type,
                        Duration = convienceProduct.Warrenty.Duration,                        
                    }


                };
            }
        }
        #endregion




            #region SafeProduct

            #endregion
            #region EnergyProduct

            #endregion

    }
}
