using DATALAYER.Controllers;
using DATALAYER.DatabaseConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.BusinessLogic
{
    public class TransactionInsert
    {
        public Transaction InsertTransaction(Transaction transaction)
        {
            using (var dbe = new SHSdb())
            {
                dbe.transactions.InsertOnSubmit(transaction);
                dbe.SubmitChanges();
                return transaction;
            }
        }

        public ProductSystem InsertProductSys(ProductSystem productSystem)
        {
            using (var dbe = new SHSdb())
            {
                dbe.productSystems.InsertOnSubmit(productSystem);
                dbe.SubmitChanges();
                return productSystem;
            }
        }

        public Cart InsertCart(Cart cart)
        {
            using (var dbe = new SHSdb())
            {
                dbe.carts.InsertOnSubmit(cart);
                dbe.SubmitChanges();
                return cart;
            }
        }
        public SysConProduct InsertSysConProduct(SysConProduct sysConProduct)
        {
            using (var dbe = new SHSdb())
            {
                dbe.sysConProducts.InsertOnSubmit(sysConProduct);
                dbe.SubmitChanges();
                return sysConProduct;
            }
        }
        public SysEneProduct InsertSysEneProduct(SysEneProduct sysEneProduct)
        {
            using (var dbe = new SHSdb())
            {
                dbe.sysEneProducts.InsertOnSubmit(sysEneProduct);
                dbe.SubmitChanges();
                return sysEneProduct;
            }
        }
        public SysSafProduct InsertSysSafProduct(SysSafProduct sysSafProduct)
        {
            using (var dbe = new SHSdb())
            {
                dbe.sysSafProducts.InsertOnSubmit(sysSafProduct);
                dbe.SubmitChanges();
                return sysSafProduct;
            }
        }
    }
}
