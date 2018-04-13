namespace SuperM.UI.WinForm
{
	using SuperM.Business.Services;
	using SuperM.Data.Entities;
	using System;
	using System.Drawing;
	using System.Windows.Forms;

	public partial class ProductTypesEditor : Form
	{
		/// <summary>
		/// Declaration
		/// </summary>
		ProductTypeService productTypeService = new ProductTypeService();

		int _editId;

		/// <summary>
		/// Load
		/// </summary>
		public ProductTypesEditor()
		{
			InitializeComponent();
		}

		private void ProductTypesEditor_Load(object sender, EventArgs e)
		{
			VerificationHelper.VirifyPermission(this);
			BindData();
		}

		private void BindData()
		{
			var productTypeList = productTypeService.GetAllProductType();
			dgvProductTypes.DataSource = productTypeList;
			dgvProductTypes.ReadOnly = true;
			dgvProductTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvProductTypes.DefaultCellStyle.SelectionBackColor = Color.Gray;
			dgvProductTypes.Columns["ProductTypeId"].Visible = false;
		}

		/// <summary>
		/// Add
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (VerificationHelper.IsInputBoxEmpty(txtProductTypeName))
			{
				return;
			}

			if (productTypeService.IsProductTypeNameExisted(txtProductTypeName.Text.Trim()))
			{
				MessageBox.Show("This " + txtProductTypeName.Text.Trim() + " already exists.");
			}
			else
			{
				var productType = new ProductType()
				{
					ProductTypeName = txtProductTypeName.Text
				};

				productTypeService.Add(productType);
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
			int productTypeId = Convert.ToInt32(dgvProductTypes.CurrentRow.Cells["ProductTypeId"].Value);
			string productTypeName = dgvProductTypes.CurrentRow.Cells["ProductTypeName"].Value.ToString();
			DialogResult dialogResult = MessageBox.Show(btnDelete, "Are you really want to Delete productTypeName:" + productTypeName, "Confirmation", MessageBoxButtons.OKCancel);
			if (dialogResult == DialogResult.OK)
			{
				var productType = new ProductType() { ProductTypeId = productTypeId };
				productTypeService.Delete(productType);
				BindData();
				ResetUIInputtdData();
			}
		}

		/// <summary>
		/// Update
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dgvProductTypes_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtProductTypeName.Text = dgvProductTypes.CurrentRow.Cells["ProductTypeName"].Value.ToString();
			_editId = Convert.ToInt32(dgvProductTypes.CurrentRow.Cells["ProductTypeId"].Value);
			btnAdd.Enabled = false;
			btnUpdate.Enabled = true;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (VerificationHelper.IsInputBoxEmpty(txtProductTypeName))
			{
				return;
			}

			int productTypeId = _editId;
			string productTypeName = txtProductTypeName.Text.Trim();
			ProductType productType = new ProductType()
			{
				ProductTypeId = productTypeId,
				ProductTypeName = productTypeName
			};

			productTypeService.Update(productType);
			ResetUIInputtdData();
		}

		/// <summary>
		/// Search
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtProductTypeName_TextChanged(object sender, EventArgs e)
		{
			if (txtProductTypeName.Text.Trim().Length == 0)
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
			var productTypesBySearched = productTypeService.GetProductTypeByName(txtProductTypeName.Text.Trim());
			dgvProductTypes.DataSource = productTypesBySearched;
		}

		/// <summary>
		/// Reload
		/// </summary>
		private void btnClear_Click(object sender, EventArgs e)
		{
			ResetUIInputtdData();
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
			_editId = -1;
		}
	}
}
