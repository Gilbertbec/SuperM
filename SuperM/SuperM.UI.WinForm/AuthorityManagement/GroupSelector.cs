namespace SuperM.UI.WinForm
{
	using SuperM.Business.Services;
	using SuperM.Data.Entities;
	using System;
	using System.Windows.Forms;

	public partial class GroupSelector : Form
	{
		/// <summary>
		/// Declaration
		/// </summary>
		GroupService _groupService = new GroupService();

		int _editId = -1;

		IGroupHolder _iGroupHolder;

		/// <summary>
		/// Load
		/// </summary>
		public GroupSelector()
		{
			InitializeComponent();
		}

		public GroupSelector(IGroupHolder iGroupHolder)
		{
			InitializeComponent();
			_iGroupHolder = iGroupHolder;
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
		/// Select
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnConfirm_Click(object sender, EventArgs e)
		{
			if (_editId != -1)
			{
				_iGroupHolder.GroupId = _editId;
				this.Close();
				this.Dispose();
			}
		}

		private void dgvGroup_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvGroup.CurrentRow == null)
			{
				return;
			}
			_editId = (int)dgvGroup.CurrentRow.Cells["GroupId"].Value;
			Group group = _groupService.GetGroupById(_editId);
			DisplayInformation(group);
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
		private bool IsInputBoxEmpty(TextBox textBox)
		{
			if (textBox.Text.Trim().Length == 0)
			{
				MessageBox.Show(textBox.Name.Substring(3) + " can not be null.");
				return true;
			}
			else
			{
				return false;
			}
		}

		private bool IsNameEmpty()
		{
			bool isNameEmpty = false;
			isNameEmpty = IsInputBoxEmpty(txtName);

			return isNameEmpty;
		}

		/// <summary>
		/// Display
		/// </summary>
		/// <param name="group"></param>
		void DisplayInformation(Group group)
		{
			txtName.Text = group.Name;
		}
	}
}
