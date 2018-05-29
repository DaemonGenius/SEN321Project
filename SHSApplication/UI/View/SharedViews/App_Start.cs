using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.View.SharedViews
{
    public partial class App_Start : Form
    {
        
        public App_Start()
        {
            Thread thread = new Thread(new ThreadStart(StartForm));
            thread.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            thread.Abort();
        }
        public void StartForm()
        {
            Application.Run(new View.AppliocationStart.App_Launch());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
             string LoggedUser;
            EmployeeSide.App_ManagementProtalView app_ManagementProtalView = new EmployeeSide.App_ManagementProtalView();
            LOGIC.ApplicationLogic.RegisterValidation registerValidation = new LOGIC.ApplicationLogic.RegisterValidation();
            if (registerValidation.EmailValidation(txtbxEmail.Text, txtbxPass.Text) == true)
            {

                
                if (registerValidation.DepartmentType() == "Client")
                {
                    View.ClientSide.ClientPortalView clientPortal = new ClientSide.ClientPortalView();
                    clientPortal.Show();
                    lblErrorEmail.Visible = false;
                }
                else if (registerValidation.DepartmentType() == "Admin")
                {
                    
                    View.Admin.App_AdminPage adminPage = new Admin.App_AdminPage();
                    adminPage.Show();
                }
                else if (registerValidation.DepartmentType() == "Employee")
                {
                    LoggedUser = registerValidation.Loggedin;
                    View.EmployeeSide.App_ManagementProtalView managementProtalView = new EmployeeSide.App_ManagementProtalView();
                    managementProtalView.Show();                    
                    lblErrorEmail.Visible = false;
                }

            }
            else
            {
                lblErrorEmail.Visible = true;
                txtbxEmail.Clear();
                lblErrorpass.Visible = true;
                txtbxPass.Clear();
            }
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            View.SharedViews.App_RegisterUser registerForm = new App_RegisterUser();
            registerForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
