using DATALAYER.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.View.EmployeeSide
{
    public partial class App_PurchaseOrder : Form
    {
        public string LoggedUser, ProductIdent;
        public int Client;
        public int Contract, WarrentyID;
        public int TechnicianName, ProductID;
        public int SysName, MainID;
        public int ScheduleState;

        public double totalPrice, productSysPrice;
        public int clientID, TechID, SaleID, ContID;
        public App_PurchaseOrder()
        {
            InitializeComponent();
            LOGIC.ApplicationLogic.ProductInfoApp productInfoApp = new LOGIC.ApplicationLogic.ProductInfoApp();
            List<string> ListEn = LOGIC.ApplicationLogic.ProductInfoApp.EnProduct();
            foreach (var item in ListEn)
            {
                lstbxEneProducts.Items.Add(item.ToString());
            }
            List<string> ListSaf = LOGIC.ApplicationLogic.ProductInfoApp.SafProduct();
            foreach (var item in ListSaf)
            {
                lstbxsafProducts.Items.Add(item.ToString());
            }
            List<string> ListCon = LOGIC.ApplicationLogic.ProductInfoApp.ConProduct();
            foreach (var item in ListCon)
            {
                lstbxConProducts.Items.Add(item.ToString());
            }
            List<string> TechNLoad = LOGIC.ApplicationLogic.TechnicianApp.TechNLoadApp();
            foreach (var item in TechNLoad)
            {
                cbxTechname.Items.Add(item);
            }
        }
        public List<double> conPricelst = new List<double>();
        public List<double> safPricelst = new List<double>();
        public List<double> enePricelst = new List<double>();
        public List<int> conIDlst = new List<int>();
        public List<int> safIDlst = new List<int>();
        public List<int> eneIDlst = new List<int>();
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (ProductIdent == "EnergyProduct")
            {
                lstbxCartEnergy.Items.Add(txtbxProductName.Text);
                enePricelst.Add(Convert.ToDouble(txtbxPrice.Text));
                eneIDlst.Add(Convert.ToInt16(ProductID));
            }
            else if (ProductIdent == "SaftyProduct")
            {
                lstbxCartSafe.Items.Add(txtbxProductName.Text);
                safPricelst.Add(Convert.ToDouble(txtbxPrice.Text));
                safIDlst.Add(Convert.ToInt16(ProductID));
            }
            else if (ProductIdent == "ConvienceProduct")
            {
                lstbxCartHome.Items.Add(txtbxProductName.Text);
                conPricelst.Add(Convert.ToDouble(txtbxPrice.Text));
                conIDlst.Add(Convert.ToInt16(ProductID));
            }
        }

        private void btnSysSpecAppro_Click(object sender, EventArgs e)
        {
            txtbxCartSysName.Text = txtbxSystem.Text;
            txtbxCartContract.Text = cbxProductWarr.Text;
            Maintenance maintenance = new Maintenance();
            maintenance.DateStart = DateTime.Parse(txtbxScheTimeS.Text);
            maintenance.DateEnd = DateTime.Parse(txtbxScheTimeE.Text);
            
            rtxtbxMainSche.Text = "Start: " + maintenance.DateStart + " End : " + maintenance.DateEnd;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            LOGIC.ApplicationLogic.TransactionInsertApp transactionInsertApp = new LOGIC.ApplicationLogic.TransactionInsertApp();
            ProductPriceCalc();
            SysPrice();            
            transactionInsertApp.InsertCart(totalPrice);
            transactionInsertApp.InsertProductSystem(txtbxCartSysName.Text, productSysPrice);
            foreach (var item in conIDlst)
            {
                transactionInsertApp.sysConProduct(item, transactionInsertApp.productID);
            }
            foreach (var item in safIDlst)
            {
                transactionInsertApp.sysSafProduct(item, transactionInsertApp.productID);
            }
            foreach (var item in eneIDlst)
            {
                transactionInsertApp.sysEneProduct(item, transactionInsertApp.productID);
            }
            //transactionInsertApp.InsertTransaction(clientID, saleEMpID, techID, ContID);
        }
        #region PriceCalculation
        public double conPrice;
        public double safPrice;
        public double EnPrice;
        public double ProductPriceCalc()
        {
            foreach (var item in conPricelst)
            {
                conPrice = +item;
            }
            foreach (var item in safPricelst)
            {
                safPrice = +item;
            }
            foreach (var item in enePricelst)
            {
                EnPrice += item;
            }
            productSysPrice = conPrice + EnPrice + safPrice;
            return productSysPrice;
        }

        public double SysPrice()
        {
            totalPrice = productSysPrice * 1.25;
            return totalPrice;
        }
        #endregion
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            View.EmployeeSide.App_ManagementProtalView app_ManagementProtalView = new App_ManagementProtalView();
            app_ManagementProtalView.Show();
            this.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void lstbxEneProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = lstbxEneProducts.SelectedItem.ToString();
            LOGIC.ApplicationLogic.ProductInfoApp productInfoApp = new LOGIC.ApplicationLogic.ProductInfoApp();

            EnergyProduct energyProduct = await productInfoApp.ENProductLoad(name);

            txtbxProductName.Text = energyProduct.Name;
            rtxtbxDisc.Text = energyProduct.Discription;
            txtbxPrice.Text = energyProduct.Price.ToString();
            cbxWarrty.Text = energyProduct.Warrenty.Duration;
            ProductID = energyProduct.ID;

            ProductIdent = "EnergyProduct";
            //cbxGroupType.Text = ProductIdent;
        }

        private async void lstbxsafProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = lstbxsafProducts.SelectedItem.ToString();
            LOGIC.ApplicationLogic.ProductInfoApp productInfoApp = new LOGIC.ApplicationLogic.ProductInfoApp();

            SafetyProduct safProduct = await productInfoApp.SafProductLoad(name);

            txtbxProductName.Text = safProduct.Name;
            rtxtbxDisc.Text = safProduct.Discription;
            txtbxPrice.Text = safProduct.Price.ToString();
            cbxWarrty.Text = safProduct.Warrenty.Duration;
            ProductID = safProduct.ID;
            ProductIdent = "SaftyProduct";
            //cbxGroupType.Text = ProductIdent;
        }

        private async void lstbxConProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = lstbxConProducts.SelectedItem.ToString();
            LOGIC.ApplicationLogic.ProductInfoApp productInfoApp = new LOGIC.ApplicationLogic.ProductInfoApp();

            ConvienceProduct convienceProduct = await productInfoApp.ConProductLoad(name);

            txtbxProductName.Text = convienceProduct.Name;
            rtxtbxDisc.Text = convienceProduct.Discription;
            txtbxPrice.Text = convienceProduct.Price.ToString();
            cbxWarrty.Text = convienceProduct.Warrenty.Duration;
            ProductID = convienceProduct.ID;
            ProductIdent = "ConvienceProduct";
            //cbxGroupType.Text = ProductIdent;
        }
    }
}
