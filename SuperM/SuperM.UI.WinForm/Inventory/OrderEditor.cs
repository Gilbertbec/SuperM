
namespace SuperM.UI.WinForm
{
	using SuperM.Business.Services;
	using SuperM.Data.Entities;
	using System;
	using System.Windows.Forms;

	public partial class OrderEditor : Form
	{
//		/// <summary>
//		/// Declaration
//		/// </summary>


//		ServiceFacade _serviceFacade = new Business.Services.ServiceFacade();

//		int _editId = -1;

//		/// <summary>
//		/// Load
//		/// </summary>
//		public OrderEditor()
//		{
//			InitializeComponent();
//		}

//		private void OrderEditor_Load(object sender, EventArgs e)
//		{
//			BindData();
//		}
		
//		public void FillOrderDataGridView(DataGridView dgv)//To be moved to ServiceFacade
//		{
//			OrderService employeeService = new OrderService();
//			var OrderList = employeeService.GetOrderList();
//			dgv.DataSource = OrderList;
//			dgv.ReadOnly = true;
//			dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
//			dgv.DefaultCellStyle.SelectionBackColor = Color.Gray;
//		}

//		private void BindData()
//		{
//			_serviceFacade.FillOrderDataGridView(this.dgvOrder);
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

//				var Order = new Order();
//				if (_orderService.IsNameExisted(txtName.Text.Trim()))
//				{
//					MessageBox.Show("This " + txtName.Text.Trim() + " has already existed.");
//				}
//				else
//				{
//					Order.Name = txtName.Text;
//					//Order.CompanyId = (int)cboCompany.SelectedValue;
//					_orderService.Add(Order);
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
//				int OrderId = Convert.ToInt32(dgvOrder.CurrentRow.Cells["OrderId"].Value);
//				string Name = dgvOrder.CurrentRow.Cells["Name"].Value.ToString();
//				DialogResult dialogResult = MessageBox.Show(btnDelete, "Are you really want to Delete Name:" + Name, "Confirmation", MessageBoxButtons.OKCancel);
//				if (dialogResult == DialogResult.OK)
//				{
//					_orderService.DeleteOrderById(OrderId);
//					BindData();
//					ReloadForm();
//				}
//			}

//			/// <summary>
//			/// Update
//			/// </summary>
//			/// <param name="sender"></param>
//			/// <param name="e"></param>
//			private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
//			{
//				if (dgvOrder.CurrentRow == null)
//				{
//					return;
//				}

//				_editId = (int)dgvOrder.CurrentRow.Cells["OrderId"].Value;
//				Order order = _orderService.GetOrderById(_editId);
//				DisplayInformation(order);

//				btnAdd.Enabled = false;
//				btnUpdate.Enabled = true;
//			}

//			private void btnUpdate_Click(object sender, EventArgs e)
//			{
//				if (IsInputeNull())
//				{
//					return;
//				}

//				int orderId = _editId;

//				string userId = txtUserId.Text.Trim();
				
//				string orderTime = txtOrderTime.Text.Trim();
				
//				string grossTotal = txtGrossTotal.Text.Trim();
				
//				string nationTax = txtNationTax.Text.Trim();
				
//				string provinceTax = txtProvinceTax.Text.Trim();
				
//				string total = txtTotal.Text.Trim();
				
//				string orderDetails = txtOrderDetails.Text.Trim();
//				Order order = new Order() { 
// OrderId = orderId, UserId = userId, OrderTime = orderTime, GrossTotal = grossTotal, NationTax = nationTax, ProvinceTax = provinceTax, Total = total, OrderDetails = orderDetails};
//_orderService.UpdateOrderByOrder(order);
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
//				var OrdersBySearched = _orderService.GetOrderListByName(txtName.Text.Trim());
//				dgvOrder.DataSource = OrdersBySearched;
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
//			/// <param name="order"></param>
//			void DisplayInformation(Order order)
//			{

//			txtOrderId.Text = order.OrderId;

//			txtUserId.Text = order.UserId;

//			txtOrderTime.Text = order.OrderTime;

//			txtGrossTotal.Text = order.GrossTotal;

//			txtNationTax.Text = order.NationTax;

//			txtProvinceTax.Text = order.ProvinceTax;

//			txtTotal.Text = order.Total;

//			txtOrderDetails.Text = order.OrderDetails;
//}
		}
	}

