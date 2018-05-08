namespace SuperM.UI.WinForm
{
    using SuperM.Business.Services;
    using SuperM.Data.Entities;
    using System;
    using System.Threading;
    using System.Windows.Forms;

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void OpenMain()
        {
            Application.Run(new Main());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            errProvider.Clear();
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            UserService userService = new UserService();
            bool isUserExisted = userService.IsNameExisted(userName);
            if (isUserExisted == false)
            {
                errProvider.SetError(txtUserName, "UserName has not existed, please try it again");
                return;
            }

            User user = userService.GetUserByNameForLogin(userName);
            if (user.Password == password)
            {
                int userId = user.UserId;
                UserLogined.UserId = userId;
                UserLogined.UserName = user.Name;

                UserGroupService userGroupService = new UserGroupService();
                UserGroup group = userGroupService.GetUserGroupByUserId(userId);
                if (group != null)
                {
                    UserLogined.GroupId = group.GroupId;
                    UserLogined.GroupName = group.Group.Name;
                }

                Thread thread = new Thread(OpenMain);
                thread.Start();

                this.Close();
                this.Dispose();
            }
            else
            {
                errProvider.SetError(txtPassword, "UserName and Password are not matched, please try it again");
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressReturn(sender, e);
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressReturn(sender, e);
        }

        void PressReturn(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.btnLogin_Click(sender, e);
            }
        }
    }
}
