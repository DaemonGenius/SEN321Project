using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.View.SharedViews
{
    public partial class App_RegisterUser : Form
    {
        #region Public Regex
        public Regex rEmail = new Regex(@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
             @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");
        public Regex rFLname = new Regex(@"^[a-zA-Z]+(([\'\,\.\- ][a-zA-Z ])?[a-zA-Z]*)*$");
        public Regex rDOB = new Regex(@"^\d{1,2}\/\d{1,2}\/\d{4}$");
        public Regex rID = new Regex(@"^\d{ 13 }$");
        public Regex rCell = new Regex(@"0((60[3-9]|64[0-5])\d{6}|(7[1-4689]|6[1-3]|8[1-4])\d{7})");
        public Regex rZip = new Regex(@"\d{4}");
        public Regex rStreetNu = new Regex(@"\d{4}");
        public Regex rCardName = new Regex(@"^[a-zA-Z]+(([\'\,\.\- ][a-zA-Z ])?[a-zA-Z]*)*$");
        public Regex rCardNum = new Regex(@"\d{4}-?\d{4}-?\d{4}-?\d{4}");
        #endregion
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
            LOGIC.ApplicationLogic.RegisterValidation registerValidation = new LOGIC.ApplicationLogic.RegisterValidation();
            registerValidation.RegisterUser(fname,lname,email,cell,pass,DOB,ssid,StreetName,Zipcode,City,Province,Country,cardNum,cardName,cardCVC,cardType,cardExpiryDate,Convert.ToInt32(StreetNum),department);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View.SharedViews.App_Start startForm = new App_Start();
            startForm.Show();
        }
        #region Text ChangeValidation
        private void txtbxFName_TextChanged(object sender, EventArgs e)
        {
            if (rFLname.IsMatch(txtbxFName.Text))
            {
                lblErrorName.Visible = true;
                lblErrorName.Text = "Passed";
                lblErrorName.ForeColor = System.Drawing.Color.Green;

            }
            else
            {
                lblErrorName.Visible = true;
                lblErrorName.Text = "Error with name";
                lblErrorName.ForeColor = System.Drawing.Color.Red;
            }

        }

        private void txtbxLname_TextChanged(object sender, EventArgs e)
        {
            if (rFLname.IsMatch(txtbxLname.Text))
            {
                lblLName.Visible = true;
                lblLName.Text = "Passed";
                lblLName.ForeColor = System.Drawing.Color.Green;

            }
            else
            {
                lblLName.Visible = true;
                lblLName.Text = "Error with Last Name";
                lblLName.ForeColor = System.Drawing.Color.Red;
            }
        }
        private void txtbxEmail_TextChanged(object sender, EventArgs e)
        {
            if (rEmail.IsMatch(txtbxEmail.Text))
            {
                lblEmail.Visible = true;
                lblEmail.Text = "Passed";
                lblEmail.ForeColor = System.Drawing.Color.Green;

            }
            else
            {
                lblEmail.Visible = true;
                lblEmail.Text = "Error with Email";
                lblEmail.ForeColor = System.Drawing.Color.Red;
            }
        }
        private void txtbxPass_TextChanged(object sender, EventArgs e)
        {
            if (rEmail.IsMatch(txtbxPass.Text))
            {
                lblPass.Visible = true;
                lblPass.Text = "Passed";
                lblPass.ForeColor = System.Drawing.Color.Green;

            }
            else
            {
                lblPass.Visible = true;
                lblPass.Text = "Error with password";
                lblPass.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void txtbxDateofB_TextChanged(object sender, EventArgs e)
        {
            if (rDOB.IsMatch(txtbxDateofB.Text))
            {
                lblDOB.Visible = true;
                lblDOB.Text = "Passed";
                lblDOB.ForeColor = System.Drawing.Color.Green;

            }
            else
            {
                lblDOB.Visible = true;
                lblDOB.Text = "Error with Data of Birth";
                lblDOB.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void txtbxSSID_TextChanged(object sender, EventArgs e)
        {
            if (rID.IsMatch(txtbxSSID.Text))
            {
                lblSSID.Visible = true;
                lblSSID.Text = "Passed";
                lblSSID.ForeColor = System.Drawing.Color.Green;

            }
            else
            {
                lblSSID.Visible = true;
                lblSSID.Text = "Error with SSID";
                lblSSID.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void txtbxCell_TextChanged(object sender, EventArgs e)
        {
            if (rCell.IsMatch(txtbxCell.Text))
            {
                lblCell.Visible = true;
                lblCell.Text = "Passed";
                lblCell.ForeColor = System.Drawing.Color.Green;

            }
            else
            {
                lblCell.Visible = true;
                lblCell.Text = "Error with Cell";
                lblCell.ForeColor = System.Drawing.Color.Red;
            }
        }

        #endregion

        private void txtbxECardName_TextChanged(object sender, EventArgs e)
        {
            if (rCardName.IsMatch(txtbxECardName.Text))
            {
                lblCardName.Visible = true;
                lblCardName.Text = "Passed";
                lblCardName.ForeColor = System.Drawing.Color.Green;

            }
            else
            {
                lblCardName.Visible = true;
                lblCardName.Text = "Error with Last Name";
                lblCardName.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
