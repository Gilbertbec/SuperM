namespace SuperM.UI.WinForm
{
	using SuperM.Business.Services;
	using SuperM.Data.Entities;
	using System;
	using System.Drawing;
	using System.Windows.Forms;

	public partial class SupplierEditor : Form
	{
		SupplierService SupplierService = new SupplierService();

		int EditId;

		public SupplierEditor()
		{
			InitializeComponent();
		}

		private void SuppliersEditor_Load(object sender, EventArgs e)
		{
			BindData();
		}

		private void BindData()
		{
			var SupplierList = SupplierService.GetSupplierList();
			dgvSuppliers.DataSource = SupplierList;
			dgvSuppliers.ReadOnly = true;
			dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvSuppliers.DefaultCellStyle.SelectionBackColor = Color.Gray;
		}

		private bool IsInputBoxEmpty()
		{
			if (txtName.Text.Trim().Length == 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (IsInputBoxEmpty())
			{
				MessageBox.Show("ProdutTypeName can not be null.");
				return;
			}

			var Supplier = new Supplier();
			if (SupplierService.IsNameExisted(txtName.Text.Trim()))
			{
				MessageBox.Show("This " + txtName.Text.Trim() + " already exists.");
			}
			else
			{
				Supplier.Name = txtName.Text;
				SupplierService.Add(Supplier);
			}

			BindData();
			ResetUIInputtdData();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int SupplierId = Convert.ToInt32(dgvSuppliers.CurrentRow.Cells["SupplierId"].Value);
			string Name = dgvSuppliers.CurrentRow.Cells["Name"].Value.ToString();
			DialogResult dialogResult = MessageBox.Show(btnDelete, "Are you really want to Delete Name:" + Name, "Confirmation", MessageBoxButtons.OKCancel);
			if (dialogResult == DialogResult.OK)
			{
				SupplierService.DeleteSupplierById(SupplierId);
				BindData();
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

			btnAdd.Enabled = true;
			btnUpdate.Enabled = false;
			EditId = -1;
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			BindDataByName();
		}

		private void BindDataByName()
		{
			var SuppliersBySearched = SupplierService.GetSupplierListByName(txtName.Text.Trim());
			dgvSuppliers.DataSource = SuppliersBySearched;
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

		private void btnClear_Click(object sender, EventArgs e)
		{
			ResetUIInputtdData();
		}

		private void dgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtName.Text = dgvSuppliers.CurrentRow.Cells["Name"].Value.ToString();
			EditId = Convert.ToInt32(dgvSuppliers.CurrentRow.Cells["SupplierId"].Value);
			btnAdd.Enabled = false;
			btnUpdate.Enabled = true;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (IsInputBoxEmpty())
			{
				MessageBox.Show("ProdutTypeName can not be null.");
				return;
			}

			int SupplierId = EditId;
			string Name = txtName.Text.Trim();
			Supplier Supplier = new Supplier() { SupplierId = SupplierId, Name = Name };

			SupplierService.UpdateSupplierBySupplier(Supplier);
			BindData();
			ResetUIInputtdData();
		}
	}
}
