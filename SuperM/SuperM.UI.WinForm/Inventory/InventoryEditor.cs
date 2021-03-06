namespace SuperM.UI.WinForm
{
    using SuperM.Business.Services;
    using SuperM.Data.Entities;
    using System;
    using System.Windows.Forms;

    public partial class InventoryEditor : Form
    {
        /// <summary>
		/// Declaration
		/// </summary>
        InventoryService InventoryService = new InventoryService();

        ServiceFacade ServiceFacade = new Business.Services.ServiceFacade();

        ChackOutService OrderService = new ChackOutService();

        int EditId = -1;

        int OrderId;

        /// <summary>
		/// Load
		/// </summary>
        public InventoryEditor()
        {
            InitializeComponent();
        }

        private void InventoryEditor_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            ServiceFacade.FillInventoryDataGridView(this.dgvInventory);
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

            var Inventory = new Inventory();
            if (InventoryService.IsNameExisted(txtBatch.Text.Trim()))
            {
                MessageBox.Show("This " + txtBatch.Text.Trim() + " has already existed.");
            }
            else
            {
                Inventory.Batch = txtBatch.Text;
                //Inventory.CompanyId = (int)cboCompany.SelectedValue;
                InventoryService.Add(Inventory);
            }

            BindData();
            ReloadForm();
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int InventoryId = Convert.ToInt32(dgvInventory.CurrentRow.Cells["InventoryId"].Value);
            string Batch = dgvInventory.CurrentRow.Cells["Batch"].Value.ToString();
            DialogResult dialogResult = MessageBox.Show(btnDelete, "Are you really want to Delete Batch:" + Batch, "Confirmation", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                InventoryService.DeleteInventoryById(InventoryId);
                BindData();
                ReloadForm();
            }
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvInventory.CurrentRow == null)
            {
                return;
            }

            EditId = (int)dgvInventory.CurrentRow.Cells["InventoryId"].Value;
            Inventory inventory = InventoryService.GetInventoryById(EditId);
            DisplayInformation(inventory);

            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsInputeNull())
            {
                return;
            }

            int inventoryId = EditId;

            string batch = txtBatch.Text.Trim();

            string count = txtCount.Text.Trim();

            string price = txtPrice.Text.Trim();

            string productId = txtProductId.Text.Trim();

            string product = txtProduct.Text.Trim();

            string supplierId = txtSupplierId.Text.Trim();

            string supplier = txtSupplier.Text.Trim();

            string stockInId = txtStockInId.Text.Trim();

            string stockIn = txtStockIn.Text.Trim();

            string inStockTime = txtInStockTime.Text.Trim();
            Inventory inventory = new Inventory()
            {
                //InventoryId = inventoryId, Batch = batch, Count = count, Price = price, ProductId = productId, Product = product, SupplierId = supplierId, Supplier = supplier, StockInId = stockInId, StockIn = stockIn, InStockTime = inStockTime
            };
            InventoryService.UpdateInventoryByInventory(inventory);
            ReloadForm();
        }

        /// <summary>
        /// Search
        /// </summary>
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

        private void BindDataByName()
        {
            var InventorysBySearched = InventoryService.GetInventoryListByName(txtBatch.Text.Trim());
            dgvInventory.DataSource = InventorysBySearched;
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
            isInputeNull = IsInputtingNameNull(txtBatch);

            return isInputeNull;
        }

        private void btnOpenNewOrder_Click(object sender, EventArgs e)
        {
            ChackOutService orderFacadeService = new ChackOutService();
            Order order = new Order
            {
                UserId = UserLogined.UserId,
                OrderTime = DateTime.Now
            };
            OrderId = orderFacadeService.GetNewOrderId(order);
        }

        /// <summary>
        /// Display
        /// </summary>
        /// <param name="inventory"></param>
        void DisplayInformation(Inventory inventory)
        {
        }
    }
}
