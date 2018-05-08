namespace SuperM.UI.WinForm
{
    using System;
    using System.Windows.Forms;

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
