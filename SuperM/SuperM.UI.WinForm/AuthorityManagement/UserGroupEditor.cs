namespace SuperM.UI.WinForm
{
	using SuperM.Business.Services;
	using SuperM.Data.Entities;
	using System;
	using System.Drawing;
	using System.Windows.Forms;

	public partial class UserGroupEditor : Form, IUserHolder, IGroupHolder
	{
		/// <summary>
		/// Declaration
		/// </summary>
		private int _userId = 0;

		private int _groupId = 0;

		UserGroupService _userGroupService = new UserGroupService();

		UserService _userService = new UserService();

		GroupService _groupService = new GroupService();

		int _editId;

		/// <summary>
		/// Load
		/// </summary>
		public UserGroupEditor()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Property
		/// </summary>
		public int UserId
		{
			get
			{
				return _userId;
			}
			set
			{
				_userId = value;
				User user = _userService.GetUserById(_userId);
				if (user != null)
				{
					txtUserName.Text = user.Name;
				}
			}
		}

		public int GroupId
		{
			get
			{
				return _groupId;
			}
			set
			{
				_groupId = value;
				Group group = _groupService.GetGroupById(_groupId);
				if (group != null)
				{
					txtGroupName.Text = group.Name;
				}
			}
		}

		private void UserGroupEditor_Load(object sender, EventArgs e)
		{
			VerificationHelper.VirifyPermission(this);
			BindData();
		}

		private void BindData()
		{
			var UserGroupList = _userGroupService.GetUserGroupList();
			dgvUserGroup.DataSource = UserGroupList;
			dgvUserGroup.ReadOnly = true;
			dgvUserGroup.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvUserGroup.DefaultCellStyle.SelectionBackColor = Color.Gray;
			dgvUserGroup.Columns["UserGroupId"].Visible = false;
		}

		/// <summary>
		/// Add
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnAdd_Click(object sender, EventArgs e)
		{
			if ((UserId != 0) && (GroupId != 0))
			{
				//TODO:ADD VILIDATION FOR BOTH USEERID AND GROUPID EXISTED
				var UserGroup = new UserGroup();
				UserGroup.UserId = UserId;
				UserGroup.GroupId = GroupId;
				_userGroupService.Add(UserGroup);
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
			int UserGroupId = Convert.ToInt32(dgvUserGroup.CurrentRow.Cells["UserGroupId"].Value);
			string Name = dgvUserGroup.CurrentRow.Cells["UserId"].Value.ToString();
			DialogResult dialogResult = MessageBox.Show(btnDelete, "Are you really want to Delete Name:" + Name, "Confirmation", MessageBoxButtons.OKCancel);

			if (dialogResult == DialogResult.OK)
			{
				_userGroupService.DeleteUserGroupById(UserGroupId);
				BindData();
				ResetUIInputtdData();
			}
		}

		/// <summary>
		/// Update
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dgvUserGroup_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			_editId = Convert.ToInt32(dgvUserGroup.CurrentRow.Cells["UserGroupId"].Value);

			UserGroup userGroup = _userGroupService.GetUserGroupById(_editId);
			txtUserName.Text = userGroup.User.Name;
			UserId = userGroup.UserId;
			txtGroupName.Text = userGroup.Group.Name;
			GroupId = userGroup.GroupId;

			btnAdd.Enabled = false;
			btnUpdate.Enabled = true;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int userGroupId = _editId;
			int userId = UserId;
			int groupId = GroupId;

			UserGroup userGroup = new UserGroup()
			{
				UserGroupId = userGroupId,
				UserId = userId,
				GroupId = groupId
			};

			_userGroupService.UpdateUserGroupByUserGroup(userGroup);
			BindData();
			ResetUIInputtdData();
		}

		/// <summary>
		/// Search
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtUserId_Click(object sender, EventArgs e)
		{
			UserSelector userEditor = new UserSelector(this);
			userEditor.Show();
		}

		private void txtGroupName_Click(object sender, EventArgs e)
		{
			GroupSelector groupSelector = new GroupSelector(this);
			groupSelector.Show();
		}

		/// <summary>
		/// Reload
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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
