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
        GroupService GroupService = new GroupService();

        int EditId = -1;

        IGroupHolder GroupHolder;

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
            GroupHolder = iGroupHolder;
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
            if (EditId != -1)
            {
                GroupHolder.GroupId = EditId;
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
            EditId = (int)dgvGroup.CurrentRow.Cells["GroupId"].Value;
            Group group = GroupService.GetGroupById(EditId);
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
            var GroupsBySearched = GroupService.GetGroupListByName(txtName.Text.Trim());
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
            EditId = -1;
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
