namespace SuperM.UI.WinForm
{
    using SuperM.Business.Services;
    using System;
    using System.Windows.Forms;

    public partial class UserSelector : Form
    {
        UserService UserService = new UserService();

        int EditId = -1;

        IUserHolder _userHolder;

        public UserSelector()
        {
            InitializeComponent();
        }

        public UserSelector(IUserHolder iUserHolder)
        {
            InitializeComponent();
            _userHolder = iUserHolder;
        }

        private void UsersEditor_Load(object sender, EventArgs e)
        {
            VerificationHelper.VirifyPermission(this);
            BindData();
        }

        private void BindData()
        {
            ServiceFacade serviceFacade = new ServiceFacade();
            serviceFacade.FillUserDataGridView(this.dgvUsers);
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
            EditId = -1;
        }

        private void BindDataByName()
        {
            var UsersBySearched = UserService.GetUserByName(txtName.Text.Trim());
            dgvUsers.DataSource = UsersBySearched;
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

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsers.CurrentRow == null)
            {
                return;
            }

            EditId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserId"].Value);
            txtName.Text = dgvUsers.CurrentRow.Cells["Name"].Value.ToString();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (EditId != -1)
            {
                _userHolder.UserId = EditId;
                this.Close();
                this.Dispose();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetUIInputtdData();
        }
    }
}
