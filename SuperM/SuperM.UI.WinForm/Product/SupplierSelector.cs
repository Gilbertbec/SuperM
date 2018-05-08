namespace SuperM.UI.WinForm
{
    using SuperM.Business.Services;
    using SuperM.Data.Entities;
    using System;
    using System.Windows.Forms;

    public partial class SupplierSelector : Form
    {
        /// <summary>
		/// Declaration
		/// </summary>
        SupplierService _supplierService = new SupplierService();

        ISupplierHolder _supplierHolder;

        int _editId = -1;

        /// <summary>
		/// Load
		/// </summary>
        public SupplierSelector()
        {
            InitializeComponent();
        }

        public SupplierSelector(ISupplierHolder supplierHolder)
        {
            InitializeComponent();
            _supplierHolder = supplierHolder;
        }

        private void SupplierEditor_Load(object sender, EventArgs e)
        {
            VerificationHelper.VirifyPermission(this);
            BindData();
        }

        private void BindData()
        {
            ServiceFacade _serviceFacade = new Business.Services.ServiceFacade();
            _serviceFacade.FillSupplierDataGridView(this.dgvSupplier);
        }

        /// <summary>
		/// Add
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsInputeNull())
            {
                return;
            }

            if (_supplierService.IsNameExisted(txtName.Text.Trim()))
            {
                MessageBox.Show("This " + txtName.Text.Trim() + " has already existed.");
            }
            else
            {
                var Supplier = new Supplier()
                {
                    Name = txtName.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    TelephoneNumber = txtTelephoneNumber.Text.Trim(),
                    Fax = txtFax.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Website = txtWebsite.Text.Trim(),
                    Rank = Convert.ToInt32(txtRank.Text.Trim())
                };

                _supplierService.Add(Supplier);
            }

            ReloadForm();
        }

        /// <summary>
		/// Select
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSupplier.CurrentRow == null)
            { return; }

            _editId = (int)dgvSupplier.CurrentRow.Cells["SupplierId"].Value;
            Supplier supplier = _supplierService.GetSupplierById(_editId);
            DisplayInformation(supplier);
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
            var SuppliersBySearched = _supplierService.GetSupplierListByName(txtName.Text.Trim());
            dgvSupplier.DataSource = SuppliersBySearched;
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
                else if (item is MaskedTextBox)
                {
                    ((MaskedTextBox)item).Clear();
                }
            }

            BindData();
            _editId = -1;
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
        private bool IsInputtingNameNull(TextBox textBox)
        {
            if (textBox.Text.Trim().Length == 0)
            {
                MessageBox.Show(textBox.Name.Substring(3) + "can not be null.");
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsInputeNull()
        {
            bool isInputeNull = false;
            isInputeNull = IsInputtingNameNull(txtName);

            return isInputeNull;
        }

        private void txtEmail_MouseLeave(object sender, EventArgs e)
        {
            VerificationHelper.EmailFormatValidation(txtEmail, errProvider);
        }

        private void txtRank_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (_editId != -1)
            {
                _supplierHolder.SupplierId = _editId;
                this.Close();
                this.Dispose();
            }
        }

        /// <summary>
		/// Display
		/// </summary>
		/// <param name="supplier"></param>
        void DisplayInformation(Supplier supplier)
        {
            txtName.Text = supplier.Name;
            txtAddress.Text = supplier.Address;
            txtTelephoneNumber.Text = supplier.TelephoneNumber;
            txtFax.Text = supplier.Fax;
            txtEmail.Text = supplier.Email;
            txtWebsite.Text = supplier.Website;
            txtRank.Text = supplier.Rank.ToString();
        }
    }
}
