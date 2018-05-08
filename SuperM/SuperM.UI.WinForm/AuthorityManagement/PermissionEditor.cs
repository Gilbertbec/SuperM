namespace SuperM.UI.WinForm
{
    using SuperM.Business.Services;
    using SuperM.Data.Entities;
    using System;
    using System.Reflection;
    using System.Windows.Forms;

    public partial class PermissionEditor : Form
    {
        /// <summary>
		/// Declaration
		/// </summary>
        PermissionService _permissionService = new PermissionService();

        int _editId = -1;

        int _groupId = -1;

        /// <summary>
		/// Load
		/// </summary>
        public PermissionEditor()
        {
            InitializeComponent();
        }

        public void BindMondels(string assemblyName, string typeName)
        {
            Assembly assembly = Assembly.LoadFrom(assemblyName);
            Type[] types = assembly.GetTypes();
            foreach (Type t in types)
            {
                if (t.Name.Contains("Editor"))
                {
                    lsbModels.Items.Add(t.Name);
                }
            }
        }

        private void PermissionEditor_Load(object sender, EventArgs e)
        {
            VerificationHelper.VirifyPermission(this);
            BindData();
        }

        private void BindData()
        {
            lsbModels.Items.Clear();

            ServiceFacade _serviceFacade = new Business.Services.ServiceFacade();
            _serviceFacade.FillPermissionDataGridView(this.dgvPermission);
            _serviceFacade.FillGroupListBox(this.lsbGroup);
            BindMondels("SuperM.UI.WinForm.exe", "PermissionEditor");
        }

        /// <summary>
		/// Binding events
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void lsbModels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbModels.SelectedItem == null)
            {
                return;
            }

            lsbControls.Items.Clear();
            var modelName = lsbModels.SelectedItem.ToString();
            txtModelName.Text = modelName;
            txtName.Clear();
            txtName.Text = modelName;
            object obj = Assembly.GetExecutingAssembly().CreateInstance("SuperM.UI.WinForm." + modelName, true, System.Reflection.BindingFlags.Default, null, new object[0], null, null);
            var type = obj.GetType();
            foreach (Control item in ((Form)obj).Controls)
            {
                lsbControls.Items.Add(item.Name);
            }
        }

        private void lsbControls_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbControls.SelectedItem == null)
            {
                return;
            }

            string controlName = lsbControls.SelectedItem.ToString();
            txtName.Text += "_" + controlName;
            txtControlName.Text = controlName;
        }

        private void lsbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbGroup.SelectedItem == null)
            {
                return;
            }

            txtGroup.Text = ((Group)lsbGroup.SelectedItem).Name;
            _groupId = ((Group)lsbGroup.SelectedItem).GroupId;
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

            if (_permissionService.IsNameExisted(txtName.Text.Trim()))
            {
                //TODO:to be fixed
                MessageBox.Show("This " + txtName.Text.Trim() + " already exists.");
            }
            else
            {
                var permission = new Permission()
                {
                    Name = txtName.Text,
                    GroupId = _groupId,
                    ModelName = txtModelName.Text,
                    ControlName = txtControlName.Text
                };

                _permissionService.Add(permission);
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
            int PermissionId = Convert.ToInt32(dgvPermission.CurrentRow.Cells["PermissionId"].Value);
            string Name = dgvPermission.CurrentRow.Cells["Name"].Value.ToString();
            DialogResult dialogResult = MessageBox.Show(btnDelete, "Are you really want to Delete Name:" + Name, "Confirmation", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                _permissionService.DeletePermissionById(PermissionId);
                BindData();
                ReloadForm();
            }
        }

        /// <summary>
		/// Update
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void dgvPermission_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPermission.CurrentRow == null)
            {
                return;
            }

            _editId = (int)dgvPermission.CurrentRow.Cells["PermissionId"].Value;
            Permission permission = _permissionService.GetPermissionById(_editId);
            _groupId = permission.GroupId;
            lsbGroup.SelectedValue = permission.GroupId;
            lsbModels.SelectedItem = permission.ModelName;
            lsbControls.SelectedItem = permission.ControlName;
            DisplayInformation(permission);

            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsNameEmpty())
            {
                return;
            }

            int permissionId = _editId;
            string name = txtName.Text.Trim();
            int groupId = _groupId;
            string modelName = txtModelName.Text.Trim();
            string controlName = txtControlName.Text.Trim();
            Permission permission = new Permission()
            {
                PermissionId = permissionId,
                Name = name,
                GroupId = groupId,
                ModelName = modelName,
                ControlName = controlName
            };
            _permissionService.UpdatePermissionByPermission(permission);
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
            var PermissionsBySearched = _permissionService.GetPermissionListByName(txtName.Text.Trim());
            dgvPermission.DataSource = PermissionsBySearched;
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
            lsbGroup.SelectedIndex = -1;
            lsbModels.SelectedIndex = -1;
            lsbControls.SelectedIndex = -1;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
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
        private bool IsNameEmpty()
        {
            bool isNameEmpty = false;
            isNameEmpty = VerificationHelper.IsInputBoxEmpty(txtName);

            return isNameEmpty;
        }

        /// <summary>
		/// Display
		/// </summary>
		/// <param name="permission"></param>
        void DisplayInformation(Permission permission)
        {
            txtName.Text = permission.Name;
            txtGroup.Text = permission.Group.Name.ToString();
            txtModelName.Text = permission.ModelName;
            txtControlName.Text = permission.ControlName;
        }
    }
}
