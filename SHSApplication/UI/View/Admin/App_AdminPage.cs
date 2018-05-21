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

namespace UI.View.Admin
{
    public partial class App_AdminPage : Form
    {
        public LOGIC.ApplicationLogic.AdminProcessing adminProcessing = new LOGIC.ApplicationLogic.AdminProcessing();
        public int ID;
        public App_AdminPage()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View.ClientSide.ClientPortalView clientPortal = new ClientSide.ClientPortalView();
            clientPortal.Show();
        }

        private void btnUEmpPortal_Click(object sender, EventArgs e)
        {
            View.EmployeeSide.App_ManagementProtalView managementProtalView = new EmployeeSide.App_ManagementProtalView();
            managementProtalView.Show();
        }

        private void App_AdminPage_Load(object sender, EventArgs e)
        {
            
            
            rtxtbxEmp.AppendText(adminProcessing.GetAllEmp().ToString());
            

        }

        private async void btnUsearch_Click(object sender, EventArgs e)
        {
            LOGIC.ApplicationLogic.ClientProcessesApp cpa = new LOGIC.ApplicationLogic.ClientProcessesApp();
            People people = await cpa.ClientSearch(txtbxUusersearch.Text);
            ID = people.ID;
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
            txtbxUFName.Text = people.FirstName;
            txtbxULName.Text = people.LastName;
            txtbxcUEmail.Text = people.EmailAddress;
            txtbxUPassword.Text = people.Password;
            txtbxUDOB.Text = people.DOB;
            txtbxUSSID.Text = people.SSID;
            txtbxUcellNumber.Text = people.CellNumber;
            txtbxUStreetNum.Text = people.Address.StreetNum.ToString();
            txtbxUStreetName.Text = people.Address.Street;
            txtbxUZipCode.Text = people.Address.Zipcode;
            txtbxUProvince.Text = people.Address.Province;
            txtbxUCity.Text = people.Address.City;
            txtbxUCountry.Text = people.Address.Country;
            foreach (var item in people.Billinginfoes)
            {
                if (people.FirstName == item.People.FirstName)
                {
                    txtbxUCardName.Text = item.CardName;
                    txtbxUCardNum.Text = item.CardNum;
                    txtbxUCardType.Text = item.CardType;
                    txtbxUCVC.Text = item.CardCVV;
                    txtbxUExpDate.Text = item.CardExpireDate;
                }
            }
        }

        private async void btnUUpdateUser_Click(object sender, EventArgs e)
        {
            People person = new People();
            person.ID = 1;
            person.FirstName = txtbxUFName.Text;
            person.LastName = txtbxULName.Text;
            person.EmailAddress = txtbxcUEmail.Text;
            person.Password = txtbxUPassword.Text;
            person.CellNumber = txtbxUcellNumber.Text;
            person.SSID = txtbxUSSID.Text;
            person.Department = txtbxUDepartment.Text;
            person.DOB = txtbxUDOB.Text;
            await adminProcessing.UpdatePerson(person);
        }
    }
}
