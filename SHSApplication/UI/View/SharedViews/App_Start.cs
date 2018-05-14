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
    public partial class App_Start : Form
    {
        public App_Start()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LOGIC.ApplicationLogic.RegisterValidation registerValidation = new LOGIC.ApplicationLogic.RegisterValidation();
            if (registerValidation.EmailValidation(txtbxEmail.Text, txtbxPass.Text) == true)
            {
                View.EmployeeSide.App_ManagementProtalView managementProtalView = new EmployeeSide.App_ManagementProtalView();
                managementProtalView.Show();
                lblErrorEmail.Visible = false;
            }
            else
            {
                lblErrorEmail.Visible = true;
                txtbxEmail.Clear();
            }
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            View.SharedViews.App_RegisterUser registerForm = new App_RegisterUser();
            registerForm.Show();
        }
    }
}
