
namespace SuperM.UI.WinForm
{
	using SuperM.Business.Services;
	using SuperM.Data.Entities;
	using System;
	using System.Drawing;
	using System.Windows.Forms;

	public partial class InventoryEditor2 : Form
	{
		/// <summary>
		/// Declaration
		/// </summary>
		InventoryService _inventoryService = new InventoryService();

		ServiceFacade _serviceFacade = new Business.Services.ServiceFacade();

		int _editId = -1;

		/// <summary>
		/// Load
		/// </summary>
		public InventoryEditor2()
		{
			InitializeComponent();
		}

		private void InventoryEditor_Load(object sender, EventArgs e)
		{
			BindData();
		}
		
		public void FillInventoryDataGridView(DataGridView dgv)//To be moved to ServiceFacade
		{
			InventoryService employeeService = new InventoryService();
			var InventoryList = employeeService.GetInventoryList();
			dgv.DataSource = InventoryList;
			dgv.ReadOnly = true;
			dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv.DefaultCellStyle.SelectionBackColor = Color.Gray;
		}

		private void BindData()
		{
			_serviceFacade.FillInventoryDataGridView(this.dgvInventory);
			//_serviceFacade.FillCompanyComboBox(this.cboCompany);
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
				if (_inventoryService.IsNameExisted(txtName.Text.Trim()))
				{
					MessageBox.Show("This " + txtName.Text.Trim() + " has already existed.");
				}
				else
				{
					Inventory.Name = txtName.Text;
					//Inventory.CompanyId = (int)cboCompany.SelectedValue;
					_inventoryService.Add(Inventory);
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
				string Name = dgvInventory.CurrentRow.Cells["Name"].Value.ToString();
				DialogResult dialogResult = MessageBox.Show(btnDelete, "Are you really want to Delete Name:" + Name, "Confirmation", MessageBoxButtons.OKCancel);
				if (dialogResult == DialogResult.OK)
				{
					_inventoryService.DeleteInventoryById(InventoryId);
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

				_editId = (int)dgvInventory.CurrentRow.Cells["InventoryId"].Value;
				Inventory inventory = _inventoryService.GetInventoryById(_editId);
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

				int inventoryId = _editId;

				string name = txtName.Text.Trim();			
				int count = Convert.ToInt32(txtCount.Text.Trim());			
				int productId = Convert.ToInt32(txtProductId.Text.Trim());			

				
				int subtotal = Convert.ToInt32(txtSubtotal.Text.Trim());
				int userId = Convert.ToInt32(txtUserId.Text.Trim());						
				DateTime inStockTime = txtInStockTime.Text.Trim();

				Inventory inventory = new Inventory() { 
					InventoryId = inventoryId,
					Name = name,
					Count = count,
					ProductId = productId,
					Subtotal = subtotal,
					UserId = userId,
					InStockTime = inStockTime
				};
				_inventoryService.UpdateInventoryByInventory(inventory);
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
				var InventorysBySearched = _inventoryService.GetInventoryListByName(txtName.Text.Trim());
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

			/// <summary>
			/// Display
			/// </summary>
			/// <param name="inventory"></param>
			void DisplayInformation(Inventory inventory)
			{

			txtInventoryId.Text = inventory.InventoryId;
			txtName.Text = inventory.Name;
			txtCount.Text = inventory.Count;
			txtProductId.Text = inventory.ProductId;
			txtProduct.Text = inventory.Product;
			txtSubtotal.Text = inventory.Subtotal;
			txtUserId.Text = inventory.UserId;
			txtUser.Text = inventory.User;
			txtInStockTime.Text = inventory.InStockTime;
}
		}
	}

