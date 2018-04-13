namespace SuperM.UI.WinForm
{
	using SuperM.Business.Services;
	using SuperM.Data.Entities;
	using System.Text.RegularExpressions;
	using System.Windows.Forms;

	public static class VerificationHelper
	{
		public static bool IsInputBoxEmpty(TextBox textBox)
		{
			bool isInputBoxEmpty = false;
			if (textBox.Text.Trim().Length == 0)
			{
				MessageBox.Show(textBox.Name.Substring(3) + "can not be null.");
				isInputBoxEmpty = true;
			}

			return isInputBoxEmpty;
		}

		public static void EmailFormatValidation(TextBox txtEmail, ErrorProvider errProider)
		{
			Regex reg = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
			if (!reg.IsMatch(txtEmail.Text))
			{
				errProider.SetError(txtEmail, "Email not valid");
			}
			else
			{
				errProider.Dispose();
			}
		}

		public static void VirifyPermission(Form form)
		{
			string thisName = form.Name;
			int groupId = UserLogined.GroupId;
			PermissionService permissionService = new PermissionService();
			var permissions = permissionService.GetPermissionByGroupId_Model(groupId, thisName);
			if (permissions != null)
			{
				foreach (Permission item in permissions)
				{
					var control = form.Controls.Find(item.ControlName, false);
					((Control)control[0]).Enabled = false;
				}
			}
		}
	}
}
