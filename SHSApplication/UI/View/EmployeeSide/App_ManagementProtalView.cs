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
    }
}
