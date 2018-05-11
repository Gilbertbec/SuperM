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
        UserService UserService = new UserService();

        int EditId = -1;

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
            ServiceFacade serviceFacade = new ServiceFacade();
            serviceFacade.FillUserDataGridView(this.dgvUsers);
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
            if (UserService.IsNameExisted(txtName.Text.Trim()))
            {
                MessageBox.Show("This " + txtName.Text.Trim() + " already exists.");
            }
            else
            {
                user.Name = txtName.Text;
                user.Password = txtPassword.Text;
                UserService.Add(user);
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
                UserService.DeleteUserById(UserId);
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

            EditId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserId"].Value);
            User user = UserService.GetUserById(EditId);
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

            int userId = EditId;
            string name = txtName.Text.Trim();
            string password = txtPassword.Text.Trim();
            User user = new User()
            {
                UserId = userId,
                Name = name,
                Password = password
            };
            UserService.UpdateUserByUser(user);
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
            EditId = -1;
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
            if (!UserService.IsNameExisted(name))
            {
                return;
            }

            var UsersBySearched = UserService.GetUserByName(name);
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
