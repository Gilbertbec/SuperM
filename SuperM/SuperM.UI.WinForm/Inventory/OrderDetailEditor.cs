
namespace SuperM.UI.WinForm
{
	using SuperM.Business.Services;
	using SuperM.Data.Entities;
	using System;
	using System.Windows.Forms;

	public partial class OrderDetailEditor : Form
	{
		/// <summary>
		/// Declaration
		/// </summary>

//		ServiceFacade _serviceFacade = new Business.Services.ServiceFacade();

//		int _editId = -1;

//		/// <summary>
//		/// Load
//		/// </summary>
//		public OrderDetailEditor()
//		{
//			InitializeComponent();
//		}

//		private void OrderDetailEditor_Load(object sender, EventArgs e)
//		{
//			BindData();
//		}
		
//		public void FillOrderDetailDataGridView(DataGridView dgv)//To be moved to ServiceFacade
//		{
//			OrderDetailService employeeService = new OrderDetailService();
//			var OrderDetailList = employeeService.GetOrderDetailList();
//			dgv.DataSource = OrderDetailList;
//			dgv.ReadOnly = true;
//			dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
//			dgv.DefaultCellStyle.SelectionBackColor = Color.Gray;
//		}

//		private void BindData()
//		{
//			_serviceFacade.FillOrderDetailDataGridView(this.dgvOrderDetail);
//			//_serviceFacade.FillCompanyComboBox(this.cboCompany);
//		}

//		/// <summary>
//		/// Add
//		/// </summary>
//		/// <param name="sender"></param>
//		/// <param name="e"></param>
//			private void btnAdd_Click(object sender, EventArgs e)
//			{
//				if (IsInputeNull())
//				{
//					return;
//				}

//				var OrderDetail = new OrderDetail();
//				if (_orderDetailService.IsNameExisted(txtName.Text.Trim()))
//				{
//					MessageBox.Show("This " + txtName.Text.Trim() + " has already existed.");
//				}
//				else
//				{
//					OrderDetail.Name = txtName.Text;
//					//OrderDetail.CompanyId = (int)cboCompany.SelectedValue;
//					_orderDetailService.Add(OrderDetail);
//				}

//				BindData();
//				ReloadForm();
//			}

//			/// <summary>
//			/// Delete
//			/// </summary>
//			/// <param name="sender"></param>
//			/// <param name="e"></param>
//			private void btnDelete_Click(object sender, EventArgs e)
//			{
//				int OrderDetailId = Convert.ToInt32(dgvOrderDetail.CurrentRow.Cells["OrderDetailId"].Value);
//				string Name = dgvOrderDetail.CurrentRow.Cells["Name"].Value.ToString();
//				DialogResult dialogResult = MessageBox.Show(btnDelete, "Are you really want to Delete Name:" + Name, "Confirmation", MessageBoxButtons.OKCancel);
//				if (dialogResult == DialogResult.OK)
//				{
//					_orderDetailService.DeleteOrderDetailById(OrderDetailId);
//					BindData();
//					ReloadForm();
//				}
//			}

//			/// <summary>
//			/// Update
//			/// </summary>
//			/// <param name="sender"></param>
//			/// <param name="e"></param>
//			private void dgvOrderDetail_CellClick(object sender, DataGridViewCellEventArgs e)
//			{
//				if (dgvOrderDetail.CurrentRow == null)
//				{
//					return;
//				}

//				_editId = (int)dgvOrderDetail.CurrentRow.Cells["OrderDetailId"].Value;
//				OrderDetail orderDetail = _orderDetailService.GetOrderDetailById(_editId);
//				DisplayInformation(orderDetail);

//				btnAdd.Enabled = false;
//				btnUpdate.Enabled = true;
//			}

//			private void btnUpdate_Click(object sender, EventArgs e)
//			{
//				if (IsInputeNull())
//				{
//					return;
//				}

//				int orderDetailId = _editId;

//				string orderId = txtOrderId.Text.Trim();
				
//				string order = txtOrder.Text.Trim();
				
//				string productId = txtProductId.Text.Trim();
				
//				string product = txtProduct.Text.Trim();
				
//				string discount = txtDiscount.Text.Trim();
				
//				string price = txtPrice.Text.Trim();
				
//				string quantity = txtQuantity.Text.Trim();
				
//				string nationTax = txtNationTax.Text.Trim();
				
//				string provinceTax = txtProvinceTax.Text.Trim();
//				OrderDetail orderDetail = new OrderDetail() { 
// OrderDetailId = orderDetailId, OrderId = orderId, Order = order, ProductId = productId, Product = product, Discount = discount, Price = price, Quantity = quantity, NationTax = nationTax, ProvinceTax = provinceTax};
//_orderDetailService.UpdateOrderDetailByOrderDetail(orderDetail);
//				ReloadForm();
//			}

//			/// <summary>
//			/// Search
//			/// </summary>
//			private void txtName_TextChanged(object sender, EventArgs e)
//			{
//				if (txtName.Text.Trim().Length == 0)
//				{
//					BindData();
//				}
//				else
//				{
//					BindDataByName();
//				}
//			}

//			private void BindDataByName()
//			{
//				var OrderDetailsBySearched = _orderDetailService.GetOrderDetailListByName(txtName.Text.Trim());
//				dgvOrderDetail.DataSource = OrderDetailsBySearched;
//			}

//			/// <summary>
//			/// Reload
//			/// </summary>
//			private void ReloadForm()
//			{
//				foreach (var item in this.Controls)
//				{
//					if (item is TextBox)
//					{
//						((TextBox)item).Clear();
//					}
//				}

//				BindData();
//				btnAdd.Enabled = true;
//				btnUpdate.Enabled = false;
//				_editId = -1;
//			}

//			private void btnClear_Click(object sender, EventArgs e)
//			{
//				ReloadForm();
//			}

//			/// <summary>
//			/// Validation
//			/// </summary>
//			/// <param name="textBox"></param>
//			/// <returns></returns>
//			private bool IsInputtingNameNull(TextBox textBox)
//			{
//				if (textBox.Text.Trim().Length == 0)
//				{
//					MessageBox.Show(textBox.Name.Substring(3) + "can not be null.");
//					return true;
//				}
//				else
//				{
//					return false;
//				}
//			}

//			private bool IsInputeNull()
//			{
//				bool isInputeNull = false;
//				isInputeNull = IsInputtingNameNull(txtName);

//				return isInputeNull;
//			}

//			/// <summary>
//			/// Display
//			/// </summary>
//			/// <param name="orderDetail"></param>
//			void DisplayInformation(OrderDetail orderDetail)
//			{

//			txtOrderDetailId.Text = orderDetail.OrderDetailId;

//			txtOrderId.Text = orderDetail.OrderId;

//			txtOrder.Text = orderDetail.Order;

//			txtProductId.Text = orderDetail.ProductId;

//			txtProduct.Text = orderDetail.Product;

//			txtDiscount.Text = orderDetail.Discount;

//			txtPrice.Text = orderDetail.Price;

//			txtQuantity.Text = orderDetail.Quantity;

//			txtNationTax.Text = orderDetail.NationTax;

//			txtProvinceTax.Text = orderDetail.ProvinceTax;
//}
		}
	}

