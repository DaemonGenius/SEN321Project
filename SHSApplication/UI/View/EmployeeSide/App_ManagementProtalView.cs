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

            //ComponentDTO Component = await SoftwareEngineeringProject.EntityFramework.SelectController.GetCertainComponent(TxtboxComName.Text);
            //int currentIndex = datagrdProductViewer.SelectedRows[0].Index;
            //ComponentDepartmentDTO ComponentDepartment = await SoftwareEngineeringProject.EntityFramework.SelectController.GetAllcompDepAsync(Component.ID);
            //Product item = (Product)dtaGridViewProductVIEW.SelectedRows[0].DataBoundItem;

            //LOGIC.BusinessLogic.ClientProcesses.ClientSearch(txtbxSCUSername);
            LOGIC.ApplicationLogic.ClientProcessesApp cpa = new LOGIC.ApplicationLogic.ClientProcessesApp();
            await cpa.ClientSearch(txtbxSCUSername.Text);
            



                //txtbxProductNameAdd.Text = item.ProductName;
                //txtbxProductNumAdd.Text = item.ProductNumber;
                //rtxtbxDiscriptionAdd.Text = item.Discription;
                //txtbxCompWarrenty.Text = item.Warrenty;
                //txtbxProcVersion.Text = item.Version;
                ////datePicAddClient.Text = item.;
                //numMericPrize.Value = (decimal)item.Price;


            
        }
    }
}
