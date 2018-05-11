namespace SuperM.UI.WinForm
{
    using SuperM.Business.Services;
    using SuperM.Data.Entities;
    using System;
    using System.Windows.Forms;

    public partial class CompanyEditor : Form
    {
        /// <summary>
		/// Declaration
		/// </summary>
        CompanyService CompanyService = new CompanyService();

        int EditId = -1;

        /// <summary>
		/// Load
		/// </summary>
        public CompanyEditor()
        {
            InitializeComponent();
        }

        private void CompanyEditor_Load(object sender, EventArgs e)
        {
            VerificationHelper.VirifyPermission(this);
            BindData();
        }

        private void BindData()
        {
            ServiceFacade _serviceFacade = new ServiceFacade();
            _serviceFacade.FillCompanyDataGridView(this.dgvCompany);
            _serviceFacade.FillCompanyComboBox(this.cboFatherCompany);
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


            if (CompanyService.IsNameExisted(txtName.Text.Trim()))
            {
                MessageBox.Show("This " + txtName.Text.Trim() + " already exists.");
            }
            else
            {
                var Company = new Company()
                {
                    Name = txtName.Text,
                    Address = txtAddress.Text,
                    TelephoneNumber = txtTelephoneNumber.Text,
                    Fax = txtFax.Text,
                    Email = txtEmail.Text,
                    Website = txtWebsite.Text,
                    FatherCompanyId = (int)cboFatherCompany.SelectedValue
                };

                CompanyService.Add(Company);
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
            int CompanyId = Convert.ToInt32(dgvCompany.CurrentRow.Cells["CompanyId"].Value);
            string Name = dgvCompany.CurrentRow.Cells["Name"].Value.ToString();
            DialogResult dialogResult = MessageBox.Show(btnDelete, "Are you really want to Delete Name:" + Name, "Confirmation", MessageBoxButtons.OKCancel);

            if (dialogResult == DialogResult.OK)
            {
                CompanyService.DeleteCompanyById(CompanyId);
                ReloadForm();
            }
        }

        /// <summary>
		/// Update
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void dgvCompany_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCompany.CurrentRow == null)
            {
                return;
            }

            EditId = Convert.ToInt32(dgvCompany.CurrentRow.Cells["CompanyId"].Value);
            Company company = CompanyService.GetCompanyById(EditId);
            DisplayInformation(company);

            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsNameEmpty())
            {
                return;
            }

            int companyId = EditId;
            string name = txtName.Text.Trim();
            string address = txtAddress.Text.Trim();
            string telephoneNumber = txtTelephoneNumber.Text.Trim();
            string fax = txtFax.Text.Trim();
            string email = txtEmail.Text.Trim();
            string website = txtWebsite.Text.Trim();
            int fatherCompanyId = (int)cboFatherCompany.SelectedValue;

            Company company = new Company()
            {
                CompanyId = companyId,
                Name = name,
                Address = address,
                TelephoneNumber = telephoneNumber,
                Fax = fax,
                Email = email,
                Website = website,
                FatherCompanyId = fatherCompanyId
            };

            CompanyService.UpdateCompanyByCompany(company);
            ReloadForm();
        }

        /// <summary>
		/// Search
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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
            var CompanysBySearched = CompanyService.GetCompanyListByName(txtName.Text.Trim());
            dgvCompany.DataSource = CompanysBySearched;
        }

        /// <summary>
		/// Reload
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            ReloadForm();
        }

        private void ReloadForm()
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                else if (item is MaskedTextBox)
                {
                    ((MaskedTextBox)item).Clear();
                }
            }
            BindData();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            EditId = -1;
        }

        /// <summary>
		/// Validation
		/// </summary>
		/// <param name="textBox"></param>
		/// <returns></returns>
        private bool IsNameEmpty()
        {
            bool isNameEmpty = false;
            isNameEmpty = VerificationHelper.IsInputBoxEmpty(txtName);
            return isNameEmpty;
        }

        private void txtEmail_MouseLeave(object sender, EventArgs e)
        {
            VerificationHelper.EmailFormatValidation(txtEmail, errProvider);
        }

        /// <summary>
		/// Display
		/// </summary>
		/// <param name="company"></param>
        void DisplayInformation(Company company)
        {
            txtName.Text = company.Name;
            txtAddress.Text = company.Address;
            txtTelephoneNumber.Text = company.TelephoneNumber;
            txtFax.Text = company.Fax;
            txtEmail.Text = company.Email;
            txtWebsite.Text = company.Website;
            cboFatherCompany.SelectedValue = company.FatherCompanyId;
        }
    }
}
