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
    }
}
