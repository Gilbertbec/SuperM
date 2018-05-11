namespace SuperM.UI.WinForm.CheckOut
{
    using SuperM.Business.Services;
    using SuperM.Data.Entities;
    using System;
    using System.Windows.Forms;

    public partial class CheckOutEditor : Form
    {
        InventoryService InventoryService = new InventoryService();

        ServiceFacade ServiceFacade = new Business.Services.ServiceFacade();

        ChackOutService CheckOutService = new ChackOutService();

        ProductService ProductService = new ProductService();

        int EditId = -1;

        int OrderId = -1;

        public CheckOutEditor()
        {
            InitializeComponent();
        }

        private void CheckOutEditor_Load(object sender, EventArgs e)
        {
            BindData();
            BindOrder();
            BindOrderDetails();
        }

        private void BindOrderDetails()
        {
            ServiceFacade.FillOrderDetailsDataGridView(this.dgvOrderDetails, OrderId);
        }

        private void BindOrder()
        {
            ServiceFacade.FillOrderDataGridView(this.dgvOrder, OrderId);
        }

        private void BindData()
        {
            ServiceFacade.FillInventoryDataGridView(this.dgvInventory);
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
        }

        private void btnOpenNewOrder(object sender, EventArgs e)
        {
            Order order = new Order()
            {
                UserId = UserLogined.UserId,
                OrderTime = DateTime.Now,
            };
            OrderId = CheckOutService.GetNewOrderId(order);
            txtOrderId.Text = OrderId.ToString();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            int orderId = OrderId;
            int productId = Convert.ToInt32(txtProductId.Text.Trim());
            Product product = ProductService.GetProductById(productId);
            int quantity = Convert.ToInt32(txtQuantity.Text.Trim());
            CheckOutService.AddProduct(product, orderId, quantity);
            BindOrder();
            BindOrderDetails();
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            int orderId = OrderId;
            int productId = Convert.ToInt32(txtProductId.Text.Trim());
            Product product = ProductService.GetProductById(productId);
            int quantity = Convert.ToInt32(txtQuantity.Text.Trim());
            CheckOutService.RomoveProduct(product, orderId, quantity);
            BindOrder();
            BindOrderDetails();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            int orderId = OrderId;
            OrderAndOrderDetailForCheckOut checkOut = CheckOutService.CheckOut(orderId);
            Receipt receipt = new Receipt(checkOut);
            receipt.Show();
        }

        /// <summary>
		/// Display
		/// </summary>
		/// <param name="inventory"></param>
        void DisplayInformation(Inventory inventory)
        {
            txtProductId.Text = inventory.ProductId.ToString();
            txtProductName.Text = inventory.Product.Name;
            txtPrice.Text = inventory.Price.ToString();
        }
    }
}
