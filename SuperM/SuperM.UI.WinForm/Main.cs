namespace SuperM.UI.WinForm
{
    using SuperM.UI.WinForm.CheckOut;
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.newTabControlMain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.newTabControlMain.DrawItem += new DrawItemEventHandler(this.newTabControlMain_DrawItem);
            newTabControlMain.Dock = DockStyle.Fill;
            this.Text += "        Weclome " + UserLogined.UserName + "    you are in the Group: " + UserLogined.GroupName + "    loginTime: " + DateTime.Now.ToUniversalTime();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void newTabControlMain_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Font fntTab;
            Brush bshBack;
            Brush bshFore;
            if (e.Index == this.newTabControlMain.SelectedIndex)
            {
                fntTab = new Font(e.Font, FontStyle.Bold);
                //bshBack = new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, SystemColors.Control, SystemColors.Control, System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal);
                bshBack = new SolidBrush(Color.Orange);
                bshFore = Brushes.White;
            }
            else
            {
                fntTab = e.Font;
                bshBack = new SolidBrush(Color.LightSteelBlue);
                bshFore = new SolidBrush(Color.Black);
            }
            string tabName = this.newTabControlMain.TabPages[e.Index].Text;
            StringFormat sftTab = new StringFormat();
            e.Graphics.FillRectangle(bshBack, e.Bounds);
            Rectangle recTab = e.Bounds;
            recTab = new Rectangle(recTab.X, recTab.Y + 4, recTab.Width, recTab.Height - 4);
            e.Graphics.DrawString(tabName, fntTab, bshFore, recTab, sftTab);
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserEditor userEditor = new UserEditor();
            ShowSingleTab(userEditor);
        }

        private void groupManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupEditor groupEditor = new GroupEditor();
            ShowSingleTab(groupEditor);
        }

        private void companyManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyEditor companyEditor = new CompanyEditor();
            ShowSingleTab(companyEditor);
        }

        private void newTabControlMain_DoubleClick(object sender, EventArgs e)
        {
            System.Windows.Forms.Control.ControlCollection coll = newTabControlMain.SelectedTab.Controls;
            foreach (Control control in coll)
            {
                control.Dispose();
            }
            this.newTabControlMain.TabPages.Remove(newTabControlMain.SelectedTab);

            if (newTabControlMain.TabPages.Count == 0)
            {
                newTabControlMain.Visible = false;
            }
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartmentEditor departmentEditor = new DepartmentEditor();
            ShowSingleTab(departmentEditor);
        }

        private void userGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserGroupEditor userGroupEditor = new UserGroupEditor();
            ShowSingleTab(userGroupEditor);
        }

        private void positionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PositionEditor positionEditor = new PositionEditor();
            ShowSingleTab(positionEditor);
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeEditor employeeEditor = new EmployeeEditor();
            ShowSingleTab(employeeEditor);
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierEditor supplierEditor = new SupplierEditor();
            ShowSingleTab(supplierEditor);
        }

        private void productToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductEditor productEditor = new ProductEditor();
            ShowSingleTab(productEditor);
        }

        private void productTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductTypesEditor productTypesEditor = new ProductTypesEditor();
            ShowSingleTab(productTypesEditor);
        }

        private void incomingStorageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockInEditor inventoryEditor = new StockInEditor();
            ShowSingleTab(inventoryEditor);
        }

        private void permissionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PermissionEditor permissionEditor = new PermissionEditor();
            ShowSingleTab(permissionEditor);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            CategoryEditor categoryEditor = new CategoryEditor();
            ShowSingleTab(categoryEditor);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            VerificationHelper.VirifyPermission(this);
        }

        private void inventoryQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventoryEditor inventoryQueryEditor = new InventoryEditor();
            ShowSingleTab(inventoryQueryEditor);
        }

        private void checkOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CheckOutEditor checkOutEditor = new CheckOutEditor();
            ShowSingleTab(checkOutEditor);
        }

        void ShowSingleTab(dynamic dynamic)
        {
            bool hasTab = false;
            foreach (TabPage item in newTabControlMain.TabPages)
            {
                if (item.Name == dynamic.Name)
                {
                    hasTab = true;
                    newTabControlMain.SelectedTab = item;
                }
            }

            if (!hasTab)
            {
                dynamic.TopLevel = false;
                dynamic.Parent = this;
                TabPage tabPage = new TabPage();
                tabPage.Controls.Add(dynamic);
                tabPage.Text = dynamic.Text;
                tabPage.Name = dynamic.Name;
                tabPage.Width = 600;
                newTabControlMain.TabPages.Add(tabPage);
                dynamic.FormBorderStyle = FormBorderStyle.None;
                dynamic.Dock = DockStyle.Fill;
                dynamic.Show();
                newTabControlMain.SelectedTab = tabPage;
            }
            if (newTabControlMain.TabPages.Count > 0)
            {
                newTabControlMain.Visible = true;
            }
        }
    }
}
