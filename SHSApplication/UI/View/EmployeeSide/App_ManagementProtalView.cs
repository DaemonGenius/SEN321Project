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
        
        
        public string LoggedUser;
        public int Client;
        public int Contract;
        public int TechnicianName;
        public int SysName;
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
            LOGIC.ApplicationLogic.ProductInfoApp productInfoApp = new LOGIC.ApplicationLogic.ProductInfoApp();
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
           
            DateTime StartT = DateTime.Parse(txtbxST.Text);
            DateTime EndT = DateTime.Parse(txtbxET.Text);
            string MainName = txtbxMainName.Text;
            Contract = 1;
            LOGIC.ApplicationLogic.MaintenanceInsertApp maintenanceInsert = new MaintenanceInsertApp();
            maintenanceInsert.InsertNewMain(Client, Contract, TechnicianName, SysName, StartT, EndT, MainName);


        }

        private async void cbcScheTechname_SelectedIndexChanged(object sender, EventArgs e)
        {
            LOGIC.ApplicationLogic.TechnicianApp technicianApp = new LOGIC.ApplicationLogic.TechnicianApp();
            TechnicianEmp technician = await technicianApp.TechnicianEmp(cbcScheTechname.Text);
            TechnicianName = (int)technician.ID;
        }
    }
}
