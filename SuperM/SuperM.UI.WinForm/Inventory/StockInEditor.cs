namespace SuperM.UI.WinForm
{
    using SuperM.Business.Services;
    using SuperM.Data.Entities;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class StockInEditor : Form
    {
        ProductService ProductService = new ProductService();

        StockInService StockInService = new StockInService();

        CategoryService CategoryService = new CategoryService();

        ServiceFacade ServiceFacade = new ServiceFacade();

        InventoryService InventoryService = new InventoryService();

        int EditProductId;

        int EditStockInId;

        public StockInEditor()
        {
            InitializeComponent();
        }

        public void BindDataByProductId(int productId)
        {
            List<Product> products = ProductService.GetProductListById(productId);
            dgvProduct.DataSource = products;
            Product product = ProductService.GetProductById(productId);
            DisplayProduct(product);
            List<StockIn> inventorys = StockInService.GetInventoryListByProductId(productId);
            dgvInventory.DataSource = inventorys;
        }

        private void InventoryEditor_Load(object sender, EventArgs e)
        {
            VerificationHelper.VirifyPermission(this);
            BindData();
        }

        private void BindData()
        {
            ServiceFacade.FillProductDataGridView(this.dgvProduct);
            ServiceFacade.FillStockInDataGridView(this.dgvInventory);
            txtUser.Text = UserLogined.UserName;
            dtpInStockTime.Value = DateTime.Now;
        }

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
            isNameEmpty = (IsInputBoxEmpty(txtBatch) && IsInputBoxEmpty(txtCount) && IsInputBoxEmpty(txtProductId));

            return isNameEmpty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsNameEmpty())
            { return; }

            if (StockInService.IsNameExisted(txtBatch.Text.Trim()))
            {
                MessageBox.Show("This " + txtBatch.Text.Trim() + " already exists.");
            }
            else
            {
                int productId = Convert.ToInt32(txtProductId.Text.Trim());
                Product product = ProductService.GetProductById(productId);
                string batch = txtBatch.Text;
                int count = Convert.ToInt32(txtCount.Text.Trim());
                decimal subTotal = Convert.ToDecimal(txtSubtotal.Text.Trim());
                int userId = UserLogined.UserId;
                DateTime inStockTime = dtpInStockTime.Value;

                StockIn stockIn = new StockIn()
                {
                    ProductId = productId,
                    Batch = batch,
                    Count = count,
                    Subtotal = subTotal,
                    UserId = userId,
                    InStockTime = inStockTime
                };

                int stockInId = StockInService.Add(stockIn);


                int supplierId = Convert.ToInt32(txtSupplierId.Text);
                Inventory inventory = new Inventory()
                {
                    ProductId = productId,
                    SupplierId = supplierId,
                    Batch = batch,
                    Count = count,
                    Price = product.SellingPrice,
                    InStockTime = DateTime.Now,
                    StockInId = stockInId
                };

                InventoryService.Add(inventory);
            }

            ResetUIInputtdData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int InventoryId = Convert.ToInt32(dgvInventory.CurrentRow.Cells["StockInId"].Value);
            string Batch = dgvInventory.CurrentRow.Cells["Batch"].Value.ToString();
            DialogResult dialogResult = MessageBox.Show(btnDelete, "Are you really want to Delete Batch:" + Batch, "Confirmation", MessageBoxButtons.OKCancel);

            if (dialogResult == DialogResult.OK)
            {
                StockInService.DeleteInventoryById(InventoryId);
                ResetUIInputtdData();
            }
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
            BindData();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            EditProductId = -1;
        }

        private void BindDataByName()
        {
            var InventorysBySearched = StockInService.GetInventoryListByName(txtBatch.Text.Trim());
            dgvInventory.DataSource = InventorysBySearched;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtBatch.Text.Trim().Length == 0)
            {
                BindData();
            }
            else
            {
                BindDataByName();
            }
        }

        private void txtCount_TextChanged(object sender, EventArgs e)
        {
            if (txtCount.Text.Trim().Length != 0 && txtPurchasedPrice.Text.Trim().Length != 0)
            {
                decimal purchasedPrice = Convert.ToDecimal(txtPurchasedPrice.Text.Trim());
                decimal count = Convert.ToDecimal(txtCount.Text.Trim());
                txtSubtotal.Text = (purchasedPrice * count).ToString();
            }
        }

        private void txtProduct_TextChanged(object sender, EventArgs e)
        {
            if (txtBatch.Text.Trim().Length == 0)
            {
                BindData();
            }
            else
            {
                BindDataByName();
            }
        }

        private void txtProductId_TextChanged(object sender, EventArgs e)
        {
            if (txtProductId.Text.Trim().Length != 0)
            {
                BindDataByProductId(Convert.ToInt32(txtProductId.Text.Trim()));
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetUIInputtdData();
        }

        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EditStockInId = Convert.ToInt32(dgvInventory.CurrentRow.Cells["StockInId"].Value);
            StockIn inventory = StockInService.GetInventoryById(EditStockInId);

            EditProductId = (int)inventory.ProductId;
            txtProductId.Text = inventory.ProductId.ToString();
            txtBatch.Text = inventory.Batch;
            txtCount.Text = inventory.Count.ToString();
            txtSubtotal.Text = inventory.Subtotal.ToString();
            UserService userService = new UserService();
            txtUser.Text = userService.GetUserById((int)inventory.UserId).Name;
            dtpInStockTime.Value = inventory.InStockTime;

            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsNameEmpty())
            { return; }

            int stockInId = EditStockInId;
            string name = txtBatch.Text.Trim();
            int count = Convert.ToInt32(txtCount.Text.Trim());
            int productId = Convert.ToInt32(txtProductId.Text.Trim());
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text.Trim());
            int userId = UserLogined.UserId;
            DateTime inStockTime = dtpInStockTime.Value;

            StockIn stockIn = new StockIn()
            {
                StockInId = stockInId,
                Batch = name,
                Count = count,
                ProductId = productId,
                Subtotal = subtotal,
                UserId = userId,
                InStockTime = inStockTime,
            };

            StockInService.UpdateInventoryByInventory(stockIn);
            BindData();
            ResetUIInputtdData();
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvProduct.CurrentRow == null)
            { return; }

            txtProductId.Text = dgvProduct.CurrentRow.Cells["ProductId"].Value.ToString();
            Product product = ProductService.GetProductById(Convert.ToInt32(txtProductId.Text));

            if (product != null)
            {
                DisplayProduct(product);
            }
        }

        private void DisplayProduct(Product product)
        {
            EditProductId = product.ProductId;
            txtProductName.Text = product.Name;
            txtSpecification.Text = product.Specification;
            txtCategoryId.Text = CategoryService.GetCategoryById((int)product.CategoryId).Name;
            txtDescription.Text = product.Description;
            txtPurchasedPrice.Text = product.PurchasedPrice.ToString();
            txtSellingPrice.Text = product.SellingPrice.ToString();
            txtSupplierId.Text = product.SupplierId.ToString();
            txtExpirationDate.Text = product.ExpirationDate.ToString();
            txtPurchasedDate.Text = product.PurchasedDate.ToString();
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            List<Product> products = ProductService.GetProductListByName(txtProductName.Text.Trim());
            dgvProduct.DataSource = products;
        }
    }
}
