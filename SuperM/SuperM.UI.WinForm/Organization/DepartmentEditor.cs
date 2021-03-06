namespace SuperM.UI.WinForm
{
    using SuperM.Business.Services;
    using SuperM.Data.Entities;
    using System;
    using System.Windows.Forms;

    public partial class DepartmentEditor : Form
    {
        /// <summary>
		/// Declaration
		/// </summary>
        DepartmentService DepartmentService = new DepartmentService();

        int EditId = -1;

        /// <summary>
		/// Load
		/// </summary>
        public DepartmentEditor()
        {
            InitializeComponent();
        }

        private void DepartmentEditor_Load(object sender, EventArgs e)
        {
            VerificationHelper.VirifyPermission(this);
            BindData();
        }

        private void BindData()
        {
            ServiceFacade serviceFacade = new Business.Services.ServiceFacade();
            serviceFacade.FillDepartmentDataGridView(this.dgvDepartment);
            serviceFacade.FillCompanyComboBox(this.cboCompany);
        }

        /// <summary>
		/// Add
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsNameEmpty())
            {
                return;
            }

            var Department = new Department();
            if (DepartmentService.IsNameExisted(txtName.Text.Trim()))
            {
                MessageBox.Show("This " + txtName.Text.Trim() + " already exists.");
            }
            else
            {
                Department.Name = txtName.Text;
                Department.CompanyId = (int)cboCompany.SelectedValue;
                DepartmentService.Add(Department);
            }

            ReloadForm();
        }

        /// <summary>
		/// Delete
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int DepartmentId = Convert.ToInt32(dgvDepartment.CurrentRow.Cells["DepartmentId"].Value);
            string Name = dgvDepartment.CurrentRow.Cells["Name"].Value.ToString();
            DialogResult dialogResult = MessageBox.Show(btnDelete, "Are you really want to Delete Name:" + Name, "Confirmation", MessageBoxButtons.OKCancel);

            if (dialogResult == DialogResult.OK)
            {
                DepartmentService.DeleteDepartmentById(DepartmentId);
                ReloadForm();
            }
        }

        /// <summary>
		/// Update
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void dgvDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDepartment.CurrentRow == null)
            {
                return;
            }

            EditId = (int)dgvDepartment.CurrentRow.Cells["DepartmentId"].Value;
            Department department = DepartmentService.GetDepartmentById(EditId);
            DisplayInformation(department);

            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsNameEmpty())
            {
                return;
            }

            int departmentId = EditId;
            string name = txtName.Text.Trim();
            int companyId = (int)cboCompany.SelectedValue;
            Department department = new Department()
            {
                DepartmentId = departmentId,
                Name = name,
                CompanyId = companyId
            };

            DepartmentService.UpdateDepartmentByDepartment(department);
            ReloadForm();
        }

        /// <summary>
		/// Search
		/// </summary>
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length == 0)
            {
                BindData();
            }
            else
            {
                BindDataByName();
            }
        }

        private void BindDataByName()
        {
            var DepartmentsBySearched = DepartmentService.GetDepartmentListByName(txtName.Text.Trim());
            dgvDepartment.DataSource = DepartmentsBySearched;
        }

        /// <summary>
		/// Reload
		/// </summary>
        private void ReloadForm()
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
            }
            BindData();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            EditId = -1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ReloadForm();
        }

        /// <summary>
		/// Validation
		/// </summary>
		/// <param name="textBox"></param>
		/// <returns></returns>
        private bool IsInputBoxEmpty(TextBox textBox)
        {
            if (textBox.Text.Trim().Length == 0)
            {
                MessageBox.Show(textBox.Name.Substring(3) + " can not be null.");
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsNameEmpty()
        {
            bool isNameEmpty = false;
            isNameEmpty = IsInputBoxEmpty(txtName);

            return isNameEmpty;
        }

        /// <summary>
		/// Display
		/// </summary>
		/// <param name="department"></param>
        void DisplayInformation(Department department)
        {
            txtName.Text = department.Name;
            cboCompany.SelectedValue = department.CompanyId;
            MessageBox.Show("Company Name:" + department.Company.Name);
        }
    }
}
