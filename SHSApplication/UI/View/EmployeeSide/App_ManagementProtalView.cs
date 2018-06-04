using DATALAYER.Controllers;
using LOGIC.ApplicationLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.View.EmployeeSide
{
    public partial class App_ManagementProtalView : Form
    {
        
        
        public string LoggedUser, ProductIdent;
        public int Client;
        public int Contract, WarrentyID;
        public int TechnicianName, ProductID;
        public int SysName, MainID, TechID;
        public int ScheduleState;
        public App_ManagementProtalView()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void btnSearchCli_Click(object sender, EventArgs e)
        {
            #region Search Client
            LOGIC.ApplicationLogic.ClientProcessesApp cpa = new LOGIC.ApplicationLogic.ClientProcessesApp();
            People people = await cpa.ClientSearch(txtbxSCUSername.Text);

            if (people.Gender == "Male")
            {
                radbtnMale.Checked =! false;
            }
            else if (people.Gender == "Female")
            {
                radbtnFemale.Checked = !false;
            }
            else if (people.Gender == "Other")
            {
                radbtnOther.Checked = !false;
            }
            
            txtbxCFName.Text = people.FirstName;
            txtbxCLName.Text = people.LastName;
            txtbxcEmail.Text = people.EmailAddress;
            txtbxCPassword.Text = people.Password;
            txtbxCDOB.Text = people.DOB;
            txtbxCSSID.Text = people.SSID;
            txtbxCcellNumber.Text = people.CellNumber;
            txtbxEStreetNum.Text = people.Address.StreetNum.ToString();
            txtbxEStreetName.Text = people.Address.Street;
            txtbxEZipCode.Text = people.Address.Zipcode;
            txtbxEProvince.Text = people.Address.Province;
            txtbxECity.Text = people.Address.City;
            txtbxECountry.Text = people.Address.Country;
            foreach (var item in people.Billinginfoes)
            {
                if (people.FirstName == item.People.FirstName)
                {
                    txtbxECardName.Text = item.CardName;
                    txtbxECardNum.Text = item.CardNum;
                    txtbxECardType.Text = item.CardType;
                    txtbxECVC.Text = item.CardCVV;
                    txtbxEExpDate.Text = item.CardExpireDate;
                }
            }
            #endregion

            

        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            View.SharedViews.App_RegisterUser registerUser = new SharedViews.App_RegisterUser();
            registerUser.Show();
        }

        private async void btnClientProducts_Click(object sender, EventArgs e)
        {
            #region ProductLoad
            LOGIC.ApplicationLogic.ProductInfoApp productInfoApp = new LOGIC.ApplicationLogic.ProductInfoApp();
            LOGIC.ApplicationLogic.ClientProcessesApp clientProcessesApp = new LOGIC.ApplicationLogic.ClientProcessesApp();
            try
            {
                ProductSystem productSystem = await clientProcessesApp.ProductLoad();
                txtbxSystem.Text = productSystem.Name;
                foreach (var item in productSystem.SysConProducts)
                {
                    lstbxConvPro.Items.Add(item.ConvienceProduct.Name);
                }
                foreach (var item1 in productSystem.SysEneProducts)
                {
                    lstbxEnergPro.Items.Add(item1.EnergyProduct.Name);
                }
                foreach (var item2 in productSystem.SysSafProducts)
                {
                    lstbxSaftPro.Items.Add(item2.SafetyProduct.Name);
                }
            }
            catch (NullReferenceException )
            {
                MessageBox.Show("Error");
                
            }
            

           

            TechnicianEmp technicianEmp = await productInfoApp.techProductLoad();
            txtbxTechnicianN.Text = technicianEmp.People.FirstName + " " + technicianEmp.People.LastName;

            Contract contract = await productInfoApp.ContractLoad();
            txtbxContract.Text = contract.ContractName;

            foreach (var item in contract.Maintenances)
            {
                string Date = "Start: " + item.DateStart + " End : " + item.DateEnd;

                rtxtbxMainSche.AppendText(Date);
            }


            #endregion
            tbpClients.Hide();
            tbpScheduleMain.Hide();
            tbpProductManagement.Hide();
            tbpCallCentre.Hide();
            tbpProducts.Show();
        }

        private void btnViewClient_Click(object sender, EventArgs e)
        {
            tbpProducts.Hide();
            tbpScheduleMain.Hide();
            tbpProductManagement.Hide();
            tbpCallCentre.Hide();
            tbpClients.Show();
        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void btnViewLogs_Click(object sender, EventArgs e)
        {
            tblCCClient.Hide();
            tbpCCAdmin.Hide();
            tblCCLogs.Show();
        }

        private void btnMsgA_Click(object sender, EventArgs e)
        {
            tbpCCAdmin.Show();
            tblCCClient.Hide();
            tblCCLogs.Hide();
        }

        private void btnMsgClient_Click(object sender, EventArgs e)
        {
            tblCCClient.Show();
            tbpCCAdmin.Hide();
            tblCCLogs.Hide();
        }

        private async void btnProductManage_Click(object sender, EventArgs e)
        {
            lstbxEneProducts.Items.Clear();
            lstbxsafProducts.Items.Clear();
            lstbxConProducts.Items.Clear();
            LOGIC.ApplicationLogic.ProductInfoApp productInfoApp = new LOGIC.ApplicationLogic.ProductInfoApp();
            LOGIC.ApplicationLogic.WarrentyLoadApp warrentyLoadApp = new WarrentyLoadApp();
            List<string> ListWar = LOGIC.ApplicationLogic.WarrentyLoadApp.WarrentyLoad();
            foreach (var item in ListWar)
            {
                cbxProductWarr.Items.Add(item.ToString());
            }
            tbpProductManagement.Show();
            tbpClients.Hide();
            tbpProducts.Hide();
            tbpScheduleMain.Hide();
            tbpCallCentre.Hide();

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

        }

        private void btnScheManagement_Click(object sender, EventArgs e)
        {
            tbpScheduleMain.Show();
            tbpClients.Hide();
            tbpProducts.Hide();
            tbpProductManagement.Hide();
            tbpCallCentre.Hide();

        }

        private void btnCallCentre_Click(object sender, EventArgs e)
        {
            tbpScheduleMain.Hide();
            tbpClients.Hide();
            tbpProducts.Hide();
            tbpProductManagement.Hide();
            tbpCallCentre.Show();
        }
        #region ClientSystem
        private async void lstbxSaftPro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = lstbxSaftPro.SelectedItem.ToString();
            LOGIC.ApplicationLogic.ProductInfoApp productInfoApp = new LOGIC.ApplicationLogic.ProductInfoApp();

            SafetyProduct safetyProduct = await productInfoApp.SafProductLoad(name);

            txtbxProductName.Text = safetyProduct.Name;
            rtxtbxDisc.Text = safetyProduct.Discription;
            txtbxPrice.Text = safetyProduct.Price.ToString();
            txtbxWarr.Text = safetyProduct.Warrenty.Duration;



        }

        private async void lstbxConvPro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = lstbxConvPro.SelectedItem.ToString();
            LOGIC.ApplicationLogic.ProductInfoApp productInfoApp = new LOGIC.ApplicationLogic.ProductInfoApp();

            ConvienceProduct convienceProduct = await productInfoApp.ConProductLoad(name);

            txtbxProductName.Text = convienceProduct.Name;
            rtxtbxDisc.Text = convienceProduct.Discription;
            txtbxPrice.Text = convienceProduct.Price.ToString();
            txtbxWarr.Text = convienceProduct.Warrenty.Duration;
        }

        private async void lstbxEnergPro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = lstbxEnergPro.SelectedItem.ToString();
            LOGIC.ApplicationLogic.ProductInfoApp productInfoApp = new LOGIC.ApplicationLogic.ProductInfoApp();

            EnergyProduct energyProduct = await productInfoApp.ENProductLoad(name);

            txtbxProductName.Text = energyProduct.Name;
            rtxtbxDisc.Text = energyProduct.Discription;
            txtbxPrice.Text = energyProduct.Price.ToString();
            txtbxWarr.Text = energyProduct.Warrenty.Duration;
        }
        #endregion


        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
           // txtbxProductSeacch.Text;

        }

        private async void lstbxsafProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = lstbxsafProducts.SelectedItem.ToString();
            LOGIC.ApplicationLogic.ProductInfoApp productInfoApp = new LOGIC.ApplicationLogic.ProductInfoApp();

            SafetyProduct safProduct = await productInfoApp.SafProductLoad(name);

            txtbxProdctName.Text = safProduct.Name;
            rtxtbxProductDiscr.Text = safProduct.Discription;
            txtProductPrice.Text = safProduct.Price.ToString();
            cbxProductWarr.Text = safProduct.Warrenty.Duration;
            ProductID = safProduct.ID;
            ProductIdent = "SaftyProduct";
        }

        private async void lstbxEneProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = lstbxEneProducts.SelectedItem.ToString();
            LOGIC.ApplicationLogic.ProductInfoApp productInfoApp = new LOGIC.ApplicationLogic.ProductInfoApp();

            EnergyProduct energyProduct = await productInfoApp.ENProductLoad(name);

            txtbxProdctName.Text = energyProduct.Name;
            rtxtbxProductDiscr.Text = energyProduct.Discription;
            txtProductPrice.Text = energyProduct.Price.ToString();
            cbxProductWarr.Text = energyProduct.Warrenty.Duration;
            ProductID = energyProduct.ID;
           
            ProductIdent = "EnergyProduct";
        }

        private async void lstbxConProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = lstbxConProducts.SelectedItem.ToString();
            LOGIC.ApplicationLogic.ProductInfoApp productInfoApp = new LOGIC.ApplicationLogic.ProductInfoApp();

            ConvienceProduct convienceProduct = await productInfoApp.ConProductLoad(name);

            txtbxProdctName.Text = convienceProduct.Name;
            rtxtbxProductDiscr.Text = convienceProduct.Discription;
            txtProductPrice.Text = convienceProduct.Price.ToString();
            cbxProductWarr.Text = convienceProduct.Warrenty.Duration;
            ProductID = convienceProduct.ID;
            ProductIdent = "ConvienceProduct";
        }

        private async void btnSchSearch_Click(object sender, EventArgs e)
        {
            
            string name = txtbxScheTechName.Text;
            LOGIC.ApplicationLogic.TechnicianApp technicianApp = new LOGIC.ApplicationLogic.TechnicianApp();
            TechnicianEmp technician = await technicianApp.Maintenances(name);

            foreach (var item in technician.Maintenances)
            {
                lstbxMaintenanceDue.Items.Add(item.Name);
            }
            
        }

        private void groupBox15_Enter(object sender, EventArgs e)
        {

        }

        private async void lstbxMaintenanceDue_SelectedIndexChanged(object sender, EventArgs e)
        {
            LOGIC.ApplicationLogic.TechnicianApp technicianApp = new LOGIC.ApplicationLogic.TechnicianApp();
            string name = lstbxMaintenanceDue.SelectedItem.ToString();

            Maintenance maintenance = await technicianApp.Maintenance(name);

            cbxClientName.Text = maintenance.Client.People.FirstName + " " + maintenance.Client.People.LastName;
            txtbxScheTechName.Text = maintenance.TechnicianEmp.People.FirstName + " " + maintenance.TechnicianEmp.People.LastName;
            txtbxScheTimeS.Text = maintenance.DateStart.ToShortDateString();
            txtbxScheTimeE.Text = maintenance.DateEnd.ToShortDateString();
            cbxClientSys.Text = maintenance.ProductSystem.Name;
            MainID = maintenance.ID;
            



        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void App_ManagementProtalView_Load(object sender, EventArgs e)
        {
            LOGIC.ApplicationLogic.EmployeeApp employeeApp = new LOGIC.ApplicationLogic.EmployeeApp();
           
            List<string> Technicians =  employeeApp.LoadEmp();
            List<string> Sales = employeeApp.LoadSaleEmp();
            List<string> Admins = employeeApp.LoadAdminEmp();

            foreach (var item in Technicians)
            {
                if (item != LoggedUser )
                {
                    cbxEmployee.Items.Add(item);
                }
                else
                {
                    cbxEmployee.Items.Remove(LoggedUser);
                    
                }
               
            }

            foreach (var item in Sales)
            {
                if (item == LoggedUser)
                {
                    cbxEmployee.Items.Remove(LoggedUser);
                }
                else
                {
                    cbxEmployee.Items.Add(item);
                }
            }

            foreach (var item in Admins)
            {
                if (item == LoggedUser)
                {
                    cbxEmployee.Items.Remove(LoggedUser);
                }
                else
                {
                    cbxEmployee.Items.Add(item);
                }
            }

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            View.EmployeeSide.App_PurchaseOrder app_PurchaseOrder = new App_PurchaseOrder();
            app_PurchaseOrder.Show();
            this.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLoginOut_Click(object sender, EventArgs e)
        {
            View.SharedViews.App_Start app_Start = new SharedViews.App_Start();
            app_Start.Show();
            this.Visible = false;
        }

        private void btnNewSchedule_Click(object sender, EventArgs e)
        {
            cbxClientName.Items.Clear();
            txtbxScheTechName.Clear();
            txtbxScheTimeS.Clear();
            txtbxScheTimeE.Clear();
            cbxClientSys.Items.Clear();
            ScheduleState = 0;
            tbpMainSche.Hide();
            tbpNewSche.Show();            
            List<string> ClientLoad = LOGIC.ApplicationLogic.ClientProcessesApp.ClientFNLoadApp();
            foreach (var item in ClientLoad)
            {
                cbxScheClintName.Items.Add(item);
            }
            List<string> TechNLoad = LOGIC.ApplicationLogic.TechnicianApp.TechNLoadApp();
            foreach (var item in TechNLoad)
            {
                cbcScheTechname.Items.Add(item);
            }
            

        }

        private void btnSearchSche_Click(object sender, EventArgs e)
        {
            cbxClientName.Items.Clear();
            txtbxScheTechName.Clear();
            txtbxScheTimeS.Clear();
            txtbxScheTimeE.Clear();
            cbxClientSys.Items.Clear();
            tbpMainSche.Show();
            tbpNewSche.Hide();
        }

        private async void cbxScheClintName_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region ProductLoad
            LOGIC.ApplicationLogic.ClientProcessesApp cpa = new LOGIC.ApplicationLogic.ClientProcessesApp();
            
            People people = await cpa.ClientPSys(cbxScheClintName.Text);
            LOGIC.ApplicationLogic.ProductInfoApp productInfoApp = new LOGIC.ApplicationLogic.ProductInfoApp();
            LOGIC.ApplicationLogic.ClientProcessesApp clientProcessesApp = new LOGIC.ApplicationLogic.ClientProcessesApp();
            ProductSystem productSystem = await clientProcessesApp.ProductLoad();
            cbxScheSysName.Text = productSystem.Name;
            
            SysName = productSystem.ID;
            Client client = await cpa.GetClientID();
            Client = (int)client.ID;
            #endregion
        }

        private async void btnInsert_Click(object sender, EventArgs e)
        {
            
            if (ScheduleState == 1)
            {
                Maintenance maintenance = new Maintenance();
                maintenance.DateStart = DateTime.Parse(txtbxST.Text);
                maintenance.DateEnd = DateTime.Parse(txtbxET.Text);
                maintenance.Name = txtbxMainName.Text;
                maintenance.Contract_ID = 1;
                maintenance.TechnicianEmp_ID = TechID;
                maintenance.ID = MainID;
                LOGIC.ApplicationLogic.MaintenanceInsertApp maintenanceInsertApp = new MaintenanceInsertApp();
                await maintenanceInsertApp.UpdateMaintenance(maintenance);
               
                
            }
            else if(ScheduleState == 0)
            {
                DateTime StartT = DateTime.Parse(txtbxST.Text);
                DateTime EndT = DateTime.Parse(txtbxET.Text);
                string MainName = txtbxMainName.Text;
                Contract = 1;
                LOGIC.ApplicationLogic.MaintenanceInsertApp maintenanceInsert = new MaintenanceInsertApp();
                maintenanceInsert.InsertNewMain(Client, Contract, TechnicianName, SysName, StartT, EndT, MainName);
            }           


        }

        private async void cbcScheTechname_SelectedIndexChanged(object sender, EventArgs e)
        {
            LOGIC.ApplicationLogic.TechnicianApp technicianApp = new LOGIC.ApplicationLogic.TechnicianApp();
            TechnicianEmp technician = await technicianApp.TechnicianEmp(cbcScheTechname.Text);
            TechnicianName = (int)technician.ID;
            TechID = technician.ID;
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtbxST.Clear();
            txtbxET.Clear();
            txtbxMainName.Clear();

        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            label64.Visible = true;
            btnInsertProduct.Visible = true;
            cbxGroupType.Visible = true;
            txtProductPrice.Clear();
            cbxProductWarr.Text = "";
            rtxtbxProductDiscr.Clear();
            txtbxProdctName.Clear();
        }

        private void btnInsertProduct_Click(object sender, EventArgs e)
        {
            LOGIC.ApplicationLogic.ProductInsertApp productInsertApp = new ProductInsertApp();
            string PName = txtbxProdctName.Text;
            string Disctip = rtxtbxProductDiscr.Text;
            double Price = Convert.ToDouble(txtProductPrice.Text);

            if (cbxGroupType.Text == "Safety Product")
            {
                productInsertApp.SafetyProductInsert(PName, Disctip, Price, WarrentyID);
            }
            else if (cbxGroupType.Text == "Energy Product")
            {
                productInsertApp.EnergyProductInsert(PName, Disctip, Price, WarrentyID);
            }
            else if(cbxGroupType.Text == "Home Product")
            {
                productInsertApp.ConvProductInsert(PName, Disctip, Price, WarrentyID);
            }
        }

        private async void cbxProductWarr_SelectedIndexChanged(object sender, EventArgs e)
        {
            LOGIC.ApplicationLogic.WarrentyLoadApp warrentyLoadApp = new WarrentyLoadApp();
            Warrenty warrenty = await warrentyLoadApp.GetWarrentyDetail(cbxProductWarr.Text);
            WarrentyID = warrenty.ID;
        }

        private async void btnProductUpdate_Click(object sender, EventArgs e)
        {
            if (ProductIdent == "EnergyProduct")
            {
                LOGIC.ApplicationLogic.ProductManagementUpdateApp productManagementUpdateApp = new ProductManagementUpdateApp();
                EnergyProduct energyProduct = new EnergyProduct();
                energyProduct.ID = ProductID;
                energyProduct.Name = txtbxProdctName.Text;
                energyProduct.Discription = rtxtbxProductDiscr.Text;
                energyProduct.Price = Convert.ToDouble(txtProductPrice.Text);
                energyProduct.Warrenty_ID = WarrentyID;
                await productManagementUpdateApp.UpdateEnergyProduct(energyProduct);

            }
            else if(ProductIdent == "SaftyProduct")
            {
                LOGIC.ApplicationLogic.ProductManagementUpdateApp productManagementUpdateApp = new ProductManagementUpdateApp();
                SafetyProduct safetyProduct = new SafetyProduct();
                safetyProduct.ID = ProductID;
                safetyProduct.Name = txtbxProdctName.Text;
                safetyProduct.Discription = rtxtbxProductDiscr.Text;
                safetyProduct.Price = Convert.ToDouble(txtProductPrice.Text);
                safetyProduct.Warrenty_ID = WarrentyID;
                await productManagementUpdateApp.UpdateSafetyProduct(safetyProduct);

            }
            else if(ProductIdent == "ConvienceProduct")
            {
                LOGIC.ApplicationLogic.ProductManagementUpdateApp productManagementUpdateApp = new ProductManagementUpdateApp();
                ConvienceProduct convienceProduct = new ConvienceProduct();
                convienceProduct.ID = ProductID;
                convienceProduct.Name = txtbxProdctName.Text;
                convienceProduct.Discription = rtxtbxProductDiscr.Text;
                convienceProduct.Price = Convert.ToDouble(txtProductPrice.Text);
                convienceProduct.Warrenty_ID = WarrentyID;
                try
                {
                    await productManagementUpdateApp.UpdateConvienceProduct(convienceProduct);
                }
                catch (Exception)
                {

                    throw;
                }
                
            }
        }

        private void txtbxProductGroup_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateSchedule_Click(object sender, EventArgs e)
        {
           
            
            ScheduleState = 1;
            tbpMainSche.Hide();
            tbpNewSche.Show();
            txtbxMainName.Text = lstbxMaintenanceDue.Text;
            txtbxST.Text = txtbxScheTimeS.Text;
            txtbxET.Text = txtbxScheTimeE.Text;
            cbxScheClintName.Enabled = false;
            cbxScheSysName.Enabled = false;
            cbxScheClintName.Text = cbxClientName.Text;
            cbxScheSysName.Text = cbxClientSys.Text;
            List<string> TechNLoad = LOGIC.ApplicationLogic.TechnicianApp.TechNLoadApp();
            foreach (var item in TechNLoad)
            {
                cbcScheTechname.Items.Add(item);
            }
            cbxClientName.Items.Clear();
            txtbxScheTechName.Clear();
            lstbxMaintenanceDue.Items.Clear();
            cbxClientSys.Items.Clear();
            cbxClientName.Items.Clear();
            cbxClientSys.Items.Clear();
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {

        }
    }
}
