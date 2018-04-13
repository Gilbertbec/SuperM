namespace SuperM.UI.WinForm
{
	using SuperM.Business.Services;
	using SuperM.Data.Entities;
	using System;
	using System.Windows.Forms;

	public partial class GroupEditor : Form
	{
		/// <summary>
		/// Declaration
		/// </summary>
		GroupService _groupService = new GroupService();

		int _editId = -1;

		/// <summary>
		/// Load
		/// </summary>
		public GroupEditor()
		{
			InitializeComponent();
		}

		private void GroupEditor_Load(object sender, EventArgs e)
		{
			VerificationHelper.VirifyPermission(this);
			BindData();
		}

		private void BindData()
		{
			ServiceFacade _serviceFacade = new Business.Services.ServiceFacade();
			_serviceFacade.FillGroupDataGridView(this.dgvGroup);
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

			var Group = new Group();
			if (_groupService.IsNameExisted(txtName.Text.Trim()))
			{
				MessageBox.Show("This " + txtName.Text.Trim() + " already exists.");
			}
			else
			{
				Group.Name = txtName.Text;
				_groupService.Add(Group);
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
			int GroupId = Convert.ToInt32(dgvGroup.CurrentRow.Cells["GroupId"].Value);
			string Name = dgvGroup.CurrentRow.Cells["Name"].Value.ToString();
			DialogResult dialogResult = MessageBox.Show(btnDelete, "Are you really want to Delete Name:" + Name, "Confirmation", MessageBoxButtons.OKCancel);

			if (dialogResult == DialogResult.OK)
			{
				_groupService.DeleteGroupById(GroupId);
				BindData();
				ReloadForm();
			}
		}

		/// <summary>
		/// Update
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dgvGroup_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvGroup.CurrentRow == null)
			{
				return;
			}

			_editId = (int)dgvGroup.CurrentRow.Cells["GroupId"].Value;
			Group group = _groupService.GetGroupById(_editId);
			txtName.Text = group.Name;

			btnAdd.Enabled = false;
			btnUpdate.Enabled = true;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (IsNameEmpty())
			{
				return;
			}

			int groupId = _editId;
			string name = txtName.Text.Trim();
			Group group = new Group()
			{
				GroupId = groupId,
				Name = name
			};
			_groupService.UpdateGroupByGroup(group);
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
			var GroupsBySearched = _groupService.GetGroupListByName(txtName.Text.Trim());
			dgvGroup.DataSource = GroupsBySearched;
		}

		/// <summary>
		/// Reload
		/// </summary>
		private void btnClear_Click(object sender, EventArgs e)
		{
			ReloadForm();
		}

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
