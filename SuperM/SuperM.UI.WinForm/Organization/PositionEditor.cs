namespace SuperM.UI.WinForm
{
    using SuperM.Business.Services;
    using SuperM.Data.Entities;
    using System;
    using System.Windows.Forms;

    public partial class PositionEditor : Form
    {
        /// <summary>
		/// Declaration
		/// </summary>
        PositionService _positionService = new PositionService();

        int _editId;

        /// <summary>
		/// Load
		/// </summary>
        public PositionEditor()
        {
            InitializeComponent();
        }

        private void PositionEditor_Load(object sender, EventArgs e)
        {
            VerificationHelper.VirifyPermission(this);
            BindData();
        }

        private void BindData()
        {
            ServiceFacade _serviceFacade = new ServiceFacade();
            _serviceFacade.FillPositionDataGridView(this.dgvPosition);
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

            var Position = new Position();
            if (_positionService.IsNameExisted(txtName.Text.Trim()))
            {
                MessageBox.Show("This " + txtName.Text.Trim() + " already exists.");
            }
            else
            {
                Position.Name = txtName.Text;
                _positionService.Add(Position);
            }

            ReloadForm();
        }

        /// <summary>
		/// Delete
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int PositionId = Convert.ToInt32(dgvPosition.CurrentRow.Cells["PositionId"].Value);
            string Name = dgvPosition.CurrentRow.Cells["Name"].Value.ToString();
            DialogResult dialogResult = MessageBox.Show(btnDelete, "Are you really want to Delete Name:" + Name, "Confirmation", MessageBoxButtons.OKCancel);

            if (dialogResult == DialogResult.OK)
            {
                _positionService.DeletePositionById(PositionId);
                ReloadForm();
            }
        }

        /// <summary>
		/// Update
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void dgvPosition_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _editId = Convert.ToInt32(dgvPosition.CurrentRow.Cells["PositionId"].Value);
            Position position = _positionService.GetPositionById(_editId);
            txtName.Text = position.Name;

            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsNameEmpty())
            {
                return;
            }

            int positionId = _editId;
            string name = txtName.Text.Trim();
            Position position = new Position()
            {
                PositionId = positionId,
                Name = name
            };

            _positionService.UpdatePositionByPosition(position);
            ReloadForm();
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
            var PositionsBySearched = _positionService.GetPositionListByName(txtName.Text.Trim());
            dgvPosition.DataSource = PositionsBySearched;
        }

        /// <summary>
		/// Reload
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            ReloadForm();
        }

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
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            _editId = -1;
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
