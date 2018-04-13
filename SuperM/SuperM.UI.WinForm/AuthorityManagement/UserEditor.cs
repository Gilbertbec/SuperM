namespace SuperM.UI.WinForm
{
	using SuperM.Business.Services;
	using SuperM.Data.Entities;
	using System;
	using System.Windows.Forms;

	public partial class UserEditor : Form
	{
		/// <summary>
		/// Declaration
		/// </summary>
		UserService _userService = new UserService();

		int _editId;

		/// <summary>
		/// Load
		/// </summary>
		public UserEditor()
		{
			InitializeComponent();
		}

		private void UsersEditor_Load(object sender, EventArgs e)
		{
			VerificationHelper.VirifyPermission(this);
			BindData();
		}

		private void BindData()
		{
			ServiceFacade _serviceFacade = new ServiceFacade();
			_serviceFacade.FillUserDataGridView(this.dgvUsers);
		}

		/// <summary>
		/// Add
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (IsNameEmpty())
			{
				return;
			}

			var user = new User();
			if (_userService.IsNameExisted(txtName.Text.Trim()))
			{
				MessageBox.Show("This " + txtName.Text.Trim() + " already exists.");
			}
			else
			{
				user.Name = txtName.Text;
				user.Password = txtPassword.Text;
				_userService.Add(user);
			}

			BindData();
			ResetUIInputtdData();
		}

		/// <summary>
		/// Delete
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnDelete_Click(object sender, EventArgs e)
		{
			int UserId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserId"].Value);
			string Name = dgvUsers.CurrentRow.Cells["Name"].Value.ToString();

			DialogResult dialogResult = MessageBox.Show(btnDelete, "Are you really want to Delete Name:" + Name, "Confirmation", MessageBoxButtons.OKCancel);

			if (dialogResult == DialogResult.OK)
			{
				_userService.DeleteUserById(UserId);
				BindData();
				ResetUIInputtdData();
			}
		}

		/// <summary>
		/// Edit
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvUsers.CurrentRow == null)
			{
				return;
			}

			_editId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserId"].Value);
			User user = _userService.GetUserById(_editId);
			txtName.Text = user.Name;
			txtPassword.Text = user.Password;

			btnAdd.Enabled = false;
			btnUpdate.Enabled = true;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (IsNameEmpty())
			{
				return;
			}

			int userId = _editId;
			string name = txtName.Text.Trim();
			string password = txtPassword.Text.Trim();
			User user = new User()
			{
				UserId = userId,
				Name = name,
				Password = password
			};

			_userService.UpdateUserByUser(user);
			BindData();
			ResetUIInputtdData();
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

		/// <summary>
		/// Search
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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
			string name = txtName.Text.Trim();
			if (!_userService.IsNameExisted(name))
			{
				return;
			}

			var UsersBySearched = _userService.GetUserByName(name);
			dgvUsers.DataSource = UsersBySearched;
		}

		/// <summary>
		/// Validation
		/// </summary>
		/// <param name="textBox"></param>
		/// <returns></returns>
		private bool IsNameEmpty()
		{
			bool isNameEmpty = false;
			isNameEmpty = VerificationHelper.IsInputBoxEmpty(txtName);

			return isNameEmpty;
		}
	}
}
