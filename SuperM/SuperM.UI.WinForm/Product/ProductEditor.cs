namespace SuperM.UI.WinForm
{
    using SuperM.Business.Services;
    using SuperM.Data.Entities;
    using System;
    using System.Windows.Forms;

    public partial class ProductEditor : Form, ISupplierHolder
    {
        /// <summary>
		/// Declaration
		/// </summary>
        ProductService _productService = new ProductService();

        SupplierService _supplierService = new SupplierService();

        int _editId;

        int _supplierId;

        /// <summary>
		/// Load
		/// </summary>
        public ProductEditor()
        {
            InitializeComponent();
        }

        /// <summary>
		/// Property
		/// </summary>
        public int SupplierId
        {
            get
            {
                return _supplierId;
            }
            set
            {
                _supplierId = value;
                Supplier supplier = _supplierService.GetSupplierById(_supplierId);
                if (supplier != null)
                {
                    txtSupplier.Text = supplier.Name;
                }
            }
        }

        private void ProductEditor_Load(object sender, EventArgs e)
        {
            VerificationHelper.VirifyPermission(this);
            BindData();
        }

        private void BindData()
        {
            ServiceFacade serviceFacade = new ServiceFacade();
            serviceFacade.FillProductDataGridView(this.dgvProduct);
            serviceFacade.FillCategoryComboBox(this.cboCategory);
        }

        /// <summary>
		/// Add
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (VerificationHelper.IsInputBoxEmpty(txtName))
            { return; }


            if (_productService.IsNameExisted(txtName.Text.Trim()))
            {
                MessageBox.Show("This " + txtName.Text.Trim() + " already exists.");
            }
            else
            {
                string name = txtName.Text.Trim();
                string specification = txtSpecification.Text.Trim();
                int categoryId = (int)cboCategory.SelectedValue;
                int supplierId = _supplierId;
                decimal.TryParse(txtPurchasedPrice.Text.Trim(), out Decimal purchasedPrice);
                decimal.TryParse(txtSellingPrice.Text.Trim(), out Decimal sellingPrice);
                DateTime purchasedDate = dtpPurchasedDate.Value;
                DateTime expirationDate = dtpExpirationDate.Value;
                string description = txtDescription.Text.Trim();

                Product product = new Product()
                {
                    Name = name,
                    Specification = specification,
                    CategoryId = categoryId,
                    SupplierId = supplierId,
                    PurchasedPrice = purchasedPrice,
                    SellingPrice = sellingPrice,
                    PurchasedDate = purchasedDate,
                    ExpirationDate = expirationDate,
                    Description = description
                };

                _productService.Add(product);
            }

            ResetUIInputtdData();
        }

        /// <summary>
		/// Delete
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ProductId = Convert.ToInt32(dgvProduct.CurrentRow.Cells["ProductId"].Value);
            string Name = dgvProduct.CurrentRow.Cells["Name"].Value.ToString();
            DialogResult dialogResult = MessageBox.Show(btnDelete, "Are you really want to Delete Name:" + Name, "Confirmation", MessageBoxButtons.OKCancel);

            if (dialogResult == DialogResult.OK)
            {
                _productService.DeleteProductById(ProductId);
                ResetUIInputtdData();
            }
        }

        /// <summary>
		/// Update
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProduct.CurrentRow == null)
            { return; }

            _editId = Convert.ToInt32(dgvProduct.CurrentRow.Cells["ProductId"].Value);
            Product product = _productService.GetProductById(_editId);

            txtName.Text = product.Name;
            txtSpecification.Text = product.Specification;
            cboCategory.SelectedValue = product.CategoryId;
            txtDescription.Text = product.Description;
            txtPurchasedPrice.Text = product.PurchasedPrice.ToString();
            txtSellingPrice.Text = product.SellingPrice.ToString();
            _supplierId = (int)product.SupplierId;
            txtSupplier.Text = _supplierService.GetSupplierById(_supplierId).Name;
            dtpExpirationDate.Value = product.ExpirationDate;
            dtpPurchasedDate.Value = product.PurchasedDate;

            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsNameEmpty())
            { return; }

            int productId = _editId;
            string name = txtName.Text.Trim();
            string specification = txtSpecification.Text.Trim();
            int categoryId = (int)cboCategory.SelectedValue;
            string description = txtDescription.Text.Trim();
            decimal purchasedPrice = Convert.ToDecimal(txtPurchasedPrice.Text.Trim());
            decimal sellingPrice = Convert.ToDecimal(txtSellingPrice.Text.Trim());
            int supplierId = _supplierId;
            DateTime expirationDate = dtpExpirationDate.Value;
            DateTime purchasedDate = dtpPurchasedDate.Value;

            Product product = new Product()
            {
                ProductId = productId,
                Name = name,
                Specification = specification,
                CategoryId = categoryId,
                Description = description,
                PurchasedPrice = purchasedPrice,
                SellingPrice = sellingPrice,
                SupplierId = supplierId,
                ExpirationDate = expirationDate,
                PurchasedDate = purchasedDate
            };

            _productService.UpdateProductByProduct(product);
            ResetUIInputtdData();
        }

        /// <summary>
		/// Search
		/// </summary>
        private void BindDataByName()
        {
            var ProductsBySearched = _productService.GetProductListByName(txtName.Text.Trim());
            dgvProduct.DataSource = ProductsBySearched;
        }

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

        private void txtSupplierId_Click(object sender, EventArgs e)
        {
            SupplierSelector supplierSelector = new SupplierSelector(this);
            supplierSelector.Show();
        }

        /// <summary>
		/// Reload
		/// </summary>
		/// <returns></returns>
        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetUIInputtdData();
        }

        private bool IsNameEmpty()
        {
            bool isNameEmpty = false;
            isNameEmpty = VerificationHelper.IsInputBoxEmpty(txtName);

            return isNameEmpty;
        }

        private void ResetUIInputtdData()
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
            }

            dtpPurchasedDate.Value = DateTime.Now;
            dtpExpirationDate.Value = DateTime.Now;
            BindData();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            _editId = -1;
        }
    }
}
