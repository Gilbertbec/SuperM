using SuperM.Business.Services;
using SuperM.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperM.UI.WinForm.CheckOut
{
	public partial class CheckOutEditor : Form
	{
		InventoryService _inventoryService = new InventoryService();
		ServiceFacade _serviceFacade = new Business.Services.ServiceFacade();
		ChackOutService _checkOutService = new ChackOutService();
		ProductService _productService = new ProductService();
		int _editId = -1;
		int _orderId = -1;

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
			_serviceFacade.FillOrderDetailsDataGridView(this.dgvOrderDetails, _orderId);
		}

		private void BindOrder()
		{
			_serviceFacade.FillOrderDataGridView(this.dgvOrder, _orderId);
		}

		private void BindData()
		{
			_serviceFacade.FillInventoryDataGridView(this.dgvInventory);
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

			_editId = (int)dgvInventory.CurrentRow.Cells["InventoryId"].Value;
			Inventory inventory = _inventoryService.GetInventoryById(_editId);
			DisplayInformation(inventory);
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

		private void btnOpenNewOrder(object sender, EventArgs e)
		{
			Order order = new Order()
			{
				UserId = UserLogined.UserId,
				OrderTime = DateTime.Now,
			};

			_orderId = _checkOutService.GetNewOrderId(order);
			txtOrderId.Text = _orderId.ToString();

		}


		private void btnAddProduct_Click(object sender, EventArgs e)
		{
			int orderId = _orderId;
			int productId = Convert.ToInt32(txtProductId.Text.Trim());
			Product product = _productService.GetProductById(productId);
			int quantity = Convert.ToInt32(txtQuantity.Text.Trim());

			_checkOutService.AddProduct(product, orderId, quantity);
		
			BindOrder();
			BindOrderDetails();
		}

		private void btnRemoveProduct_Click(object sender, EventArgs e)
		{
			int orderId = _orderId;
			int productId = Convert.ToInt32(txtProductId.Text.Trim());
			Product product = _productService.GetProductById(productId);
			int quantity = Convert.ToInt32(txtQuantity.Text.Trim());

			_checkOutService.RomoveProduct(product, orderId, quantity);
			BindOrder();
			BindOrderDetails();
		}

		private void btnCheckOut_Click(object sender, EventArgs e)
		{
			int orderId = _orderId;
			OrderAndOrderDetailForCheckOut checkOut = _checkOutService.CheckOut(orderId);
			Receipt receipt = new Receipt(checkOut);
			receipt.Show();

		}
	}
}
