using DATALAYER.Controllers;
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
        public App_ManagementProtalView()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void btnSearchCli_Click(object sender, EventArgs e)
        {
            LOGIC.ApplicationLogic.ClientProcessesApp cpa = new LOGIC.ApplicationLogic.ClientProcessesApp();
            People people = await cpa.ClientSearch(txtbxSCUSername.Text);
            
            if (people.Gender == "Male")
            {
                radbtnMale.Checked = true;
            }
            else if (people.Gender == "Female")
            {
                radbtnFemale.Checked = true;
            }
            else if (people.Gender == "Other")
            {
                radbtnOther.Checked = true;
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
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            View.SharedViews.App_RegisterUser registerUser = new SharedViews.App_RegisterUser();
            registerUser.Show();
        }

        private void btnClientProducts_Click(object sender, EventArgs e)
        {
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

        private void btnProductManage_Click(object sender, EventArgs e)
        {
            tbpProductManagement.Show();
            tbpClients.Hide();
            tbpProducts.Hide();
            tbpScheduleMain.Hide();
            tbpCallCentre.Hide();
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
    }
}
