namespace UI.View.EmployeeSide
{
    partial class App_ManagementProtalView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpClients = new System.Windows.Forms.TabPage();
            this.tbpProducts = new System.Windows.Forms.TabPage();
            this.tbpMess = new System.Windows.Forms.TabPage();
            this.tbpContracts = new System.Windows.Forms.TabPage();
            this.tbpMaintenanceSche = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 532);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 528);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Location = new System.Drawing.Point(391, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(755, 528);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpClients);
            this.tabControl1.Controls.Add(this.tbpProducts);
            this.tabControl1.Controls.Add(this.tbpMess);
            this.tabControl1.Controls.Add(this.tbpContracts);
            this.tabControl1.Controls.Add(this.tbpMaintenanceSche);
            this.tabControl1.Location = new System.Drawing.Point(4, 18);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(750, 511);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpClients
            // 
            this.tbpClients.Location = new System.Drawing.Point(4, 25);
            this.tbpClients.Name = "tbpClients";
            this.tbpClients.Padding = new System.Windows.Forms.Padding(3);
            this.tbpClients.Size = new System.Drawing.Size(742, 482);
            this.tbpClients.TabIndex = 0;
            this.tbpClients.Text = "Clients";
            this.tbpClients.UseVisualStyleBackColor = true;
            // 
            // tbpProducts
            // 
            this.tbpProducts.Location = new System.Drawing.Point(4, 25);
            this.tbpProducts.Name = "tbpProducts";
            this.tbpProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tbpProducts.Size = new System.Drawing.Size(742, 482);
            this.tbpProducts.TabIndex = 1;
            this.tbpProducts.Text = "Products";
            this.tbpProducts.UseVisualStyleBackColor = true;
            // 
            // tbpMess
            // 
            this.tbpMess.Location = new System.Drawing.Point(4, 25);
            this.tbpMess.Name = "tbpMess";
            this.tbpMess.Size = new System.Drawing.Size(742, 482);
            this.tbpMess.TabIndex = 2;
            this.tbpMess.Text = "Messages";
            this.tbpMess.UseVisualStyleBackColor = true;
            // 
            // tbpContracts
            // 
            this.tbpContracts.Location = new System.Drawing.Point(4, 25);
            this.tbpContracts.Name = "tbpContracts";
            this.tbpContracts.Size = new System.Drawing.Size(742, 482);
            this.tbpContracts.TabIndex = 3;
            this.tbpContracts.Text = "Contracts";
            this.tbpContracts.UseVisualStyleBackColor = true;
            // 
            // tbpMaintenanceSche
            // 
            this.tbpMaintenanceSche.Location = new System.Drawing.Point(4, 25);
            this.tbpMaintenanceSche.Name = "tbpMaintenanceSche";
            this.tbpMaintenanceSche.Size = new System.Drawing.Size(742, 482);
            this.tbpMaintenanceSche.TabIndex = 4;
            this.tbpMaintenanceSche.Text = "Maintenance Schedules";
            this.tbpMaintenanceSche.UseVisualStyleBackColor = true;
            // 
            // App_ManagementPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 534);
            this.Controls.Add(this.panel1);
            this.Name = "App_ManagementPortal";
            this.Text = "App_ManagementPortal";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpClients;
        private System.Windows.Forms.TabPage tbpProducts;
        private System.Windows.Forms.TabPage tbpMess;
        private System.Windows.Forms.TabPage tbpContracts;
        private System.Windows.Forms.TabPage tbpMaintenanceSche;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}