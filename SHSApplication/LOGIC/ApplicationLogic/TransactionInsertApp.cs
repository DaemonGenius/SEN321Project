using DATALAYER.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.ApplicationLogic
{
    public class TransactionInsertApp
    {
        public int cartID, productID;
        public bool InsertCart(double totalPrice)
        {
            Cart cart = new Cart()
            {               
                TotalPrice = totalPrice,
            };
            
            BusinessLogic.TransactionInsert transactionInsert = new BusinessLogic.TransactionInsert();
            transactionInsert.InsertCart(cart);
            cartID = cart.ID;
            return true;
        }
        public bool InsertProductSystem( string SystemName, double ProductSysPrice)
        {                     
            
            ProductSystem productSystem = new ProductSystem()
            {
                Cart_ID = cartID,
                Name = SystemName,
                Price = ProductSysPrice,                
            };
            
            
            BusinessLogic.TransactionInsert transactionInsert = new BusinessLogic.TransactionInsert();
            transactionInsert.InsertProductSys(productSystem);
            productID = productSystem.ID;

            return true;
        }
        public bool InsertTransaction(int clientID, int saleEMpID, int techID, int ContID)
        {
            Transaction transaction = new Transaction()
            {
                Cart_ID = cartID,
                Client_ID = clientID,
                SaleEmp_ID = saleEMpID,
                TechnicianEmp_ID = techID,
                Contract_ID = ContID
            };
            BusinessLogic.TransactionInsert transactionInsert = new BusinessLogic.TransactionInsert();
            transactionInsert.InsertTransaction(transaction);
            return true;
        }
        public bool sysConProduct(int ConID, int prodSysID)
        {
            SysConProduct sysConProduct = new SysConProduct()
            {
                ProductSystems_ID = prodSysID,
                ConvienceProducts_ID = ConID,
            };
            BusinessLogic.TransactionInsert transactionInsert = new BusinessLogic.TransactionInsert();
            transactionInsert.InsertSysConProduct(sysConProduct);
            return true;
        }

        public bool sysEneProduct(int EneID, int prodSysID)
        {
            SysEneProduct sysEneProduct = new SysEneProduct()
            {
                ProductSystems_ID = prodSysID,
                EnergyProducts_ID = EneID,
            };
            BusinessLogic.TransactionInsert transactionInsert = new BusinessLogic.TransactionInsert();
            transactionInsert.InsertSysEneProduct(sysEneProduct);
            return true;
        }

        public bool sysSafProduct(int SafID, int prodSysID)
        {
            SysSafProduct sysSafProduct = new SysSafProduct()
            {
                ProductSystems_ID = prodSysID,
                SafetyProducts_ID = SafID,
            };
            BusinessLogic.TransactionInsert transactionInsert = new BusinessLogic.TransactionInsert();
            transactionInsert.InsertSysSafProduct(sysSafProduct);
            return true;
        }
    }
}
