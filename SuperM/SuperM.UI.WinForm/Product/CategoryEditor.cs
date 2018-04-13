namespace SuperM.UI.WinForm
{
	using SuperM.Business.Services;
	using SuperM.Data.Entities;
	using System;
	using System.Windows.Forms;

	public partial class CategoryEditor : Form
	{
		/// <summary>
		/// Declaration
		/// </summary>
		CategoryService _categoryService = new CategoryService();

		int _editId = -1;

		/// <summary>
		/// Load
		/// </summary>
		public CategoryEditor()
		{
			InitializeComponent();
		}

		private void CategoryEditor_Load(object sender, EventArgs e)
		{
			VerificationHelper.VirifyPermission(this);
			BindData();
		}

		private void BindData()
		{
			ServiceFacade _serviceFacade = new Business.Services.ServiceFacade();
			_serviceFacade.FillCategoryDataGridView(this.dgvCategory);
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

			var Category = new Category();
			if (_categoryService.IsNameExisted(txtName.Text.Trim()))
			{
				MessageBox.Show("This " + txtName.Text.Trim() + " has already existed.");
			}
			else
			{
				Category.Name = txtName.Text;
				//Category.CompanyId = (int)cboCompany.SelectedValue;
				_categoryService.Add(Category);
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
			int CategoryId = Convert.ToInt32(dgvCategory.CurrentRow.Cells["CategoryId"].Value);
			string Name = dgvCategory.CurrentRow.Cells["Name"].Value.ToString();
			DialogResult dialogResult = MessageBox.Show(btnDelete, "Are you really want to Delete Name:" + Name, "Confirmation", MessageBoxButtons.OKCancel);

			if (dialogResult == DialogResult.OK)
			{
				_categoryService.DeleteCategoryById(CategoryId);
				BindData();
				ReloadForm();
			}
		}

		/// <summary>
		/// Update
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvCategory.CurrentRow == null)
			{
				return;
			}

			_editId = (int)dgvCategory.CurrentRow.Cells["CategoryId"].Value;
			Category category = _categoryService.GetCategoryById(_editId);
			DisplayInformation(category);

			btnAdd.Enabled = false;
			btnUpdate.Enabled = true;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (IsInputeNull())
			{
				return;
			}

			int categoryId = _editId;

			string name = txtName.Text.Trim();
			Category category = new Category()
			{
				CategoryId = categoryId,
				Name = name
			};
			_categoryService.UpdateCategoryByCategory(category);
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
			var CategorysBySearched = _categoryService.GetCategoryListByName(txtName.Text.Trim());
			dgvCategory.DataSource = CategorysBySearched;
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
		/// <param name="category"></param>
		void DisplayInformation(Category category)
		{
			txtName.Text = category.Name;
		}
	}
}
