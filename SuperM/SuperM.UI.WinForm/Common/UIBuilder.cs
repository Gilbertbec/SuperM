using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperM.UI.WinForm
{
	public partial class UIBuilder : Form
	{
		public UIBuilder()
		{
			InitializeComponent();
		}

		private void UIBuilder_Load(object sender, EventArgs e)
		{
			VerificationHelper.VirifyPermission(this);
		}
	}
}
