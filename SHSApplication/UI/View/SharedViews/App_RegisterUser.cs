using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.View.SharedViews
{
    public partial class App_RegisterUser : Form
    {
        public App_RegisterUser()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fname = txtbxFName.Text;
            string lname = txtbxLname.Text;
            string email = txtbxEmail.Text;
            string pass = txtbxPass.Text;
            string DOB = txtbxDateofB.Text;
            string cell = txtbxCell.Text;
            string ssid = txtbxSSID.Text;
            string StreetName = txtbxEStreetName.Text;
            string Zipcode = txtbxEStreetNum.Text;
            string City = txtbxECity.Text;
            string Province = txtbxEProvince.Text;
            string Country = txtbxECountry.Text;
            string cardNum = txtbxECardNum.Text;
            string cardName = txtbxECardName.Text;
            string cardCVC = txtbxECVC.Text;
            string cardType = txtbxECardType.Text;
            string cardExpiryDate = txtbxDateofB.Text;
            string StreetNum = txtbxEStreetNum.Text;
            string department = "Admin";
            

            LOGIC.BusinessLogic.RegistrationProcess registerProcess = new LOGIC.BusinessLogic.RegistrationProcess();
            registerProcess.RegisterUser(fname, lname, email, pass, DOB, cell, ssid, Convert.ToInt16(StreetNum),StreetName,Zipcode,City,Province,Country,cardNum,cardName,cardCVC,cardType,cardExpiryDate,department);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View.SharedViews.App_Start startForm = new App_Start();
            startForm.Show();
        }
    }
}
