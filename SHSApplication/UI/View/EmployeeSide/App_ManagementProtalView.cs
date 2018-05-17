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
                        
            
            using (var dbe = new DataContext("Data Source=.;Initial Catalog=SHSdb4;Integrated Security=True;"))
            {
                LOGIC.ApplicationLogic.ClientProcessesApp cpa = new LOGIC.ApplicationLogic.ClientProcessesApp();
                People people = await cpa.ClientSearch(txtbxSCUSername.Text);
                txtbxCFName.Text = people.FirstName;
                txtbxCLName.Text = people.LastName;
                txtbxcEmail.Text = people.EmailAddress;
                txtbxCPassword.Text = people.Password;
                txtbxCDOB.Text = people.DOB;
                txtbxCSSID.Text = people.SSID;
                txtbxCcellNumber.Text = people.CellNumber;
               // txtbxEStreetName.Text = people
            }
            
            
        }
    }
}
