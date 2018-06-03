using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.View.EmployeeSide
{
    public partial class App_PurchaseOrder : Form
    {
        public App_PurchaseOrder()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            View.EmployeeSide.App_ManagementProtalView app_ManagementProtalView = new App_ManagementProtalView();
            app_ManagementProtalView.Show();
            this.Visible = false;
        }
    }
}
