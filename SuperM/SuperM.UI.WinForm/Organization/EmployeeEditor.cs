namespace SuperM.UI.WinForm
{
	using SuperM.Business.Services;
	using SuperM.Data.Entities;
	using System;
	using System.Windows.Forms;

	public partial class EmployeeEditor : Form
	{
		/// <summary>
		/// Declaration
		/// </summary>
		EmployeeService _employeeService = new EmployeeService();

		int _editId = -1;

		/// <summary>
		/// Load
		/// </summary>
		public EmployeeEditor()
		{
			InitializeComponent();
		}

		private void EmployeeEditor_Load(object sender, EventArgs e)
		{
			VerificationHelper.VirifyPermission(this);
			BindData();
		}

		private void BindData()
		{
			ServiceFacade _serviceFacade = new Business.Services.ServiceFacade();
			_serviceFacade.FillEmployeeDataGridView(this.dgvEmployee);
			_serviceFacade.FillDepartmentComboBox(this.cboDepartment);
			_serviceFacade.FillPositionComboBox(this.cboPosition);
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

			if (_employeeService.IsNameExisted(txtName.Text.Trim()))
			{
				MessageBox.Show("This " + txtName.Text.Trim() + " already exists.");
			}
			else
			{
				Employee employee = GetEmployeeFromUI();
				_employeeService.Add(employee);
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
			int EmployeeId = Convert.ToInt32(dgvEmployee.CurrentRow.Cells["EmployeeId"].Value);
			string Name = dgvEmployee.CurrentRow.Cells["Name"].Value.ToString();
			DialogResult dialogResult = MessageBox.Show(btnDelete, "Are you really want to Delete Name:" + Name, "Confirmation", MessageBoxButtons.OKCancel);

			if (dialogResult == DialogResult.OK)
			{
				_employeeService.DeleteEmployeeById(EmployeeId);
				ReloadForm();
			}
		}

		/// <summary>
		/// Update
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvEmployee.CurrentRow == null)
			{
				return;
			}

			_editId = (int)dgvEmployee.CurrentRow.Cells["EmployeeId"].Value;
			Employee employee = _employeeService.GetEmployeeById(_editId);
			DisplayInformation(employee);

			btnAdd.Enabled = false;
			btnUpdate.Enabled = true;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (IsNameEmpty())
			{
				return;
			}
			Employee employee = GetEmployeeFromUI();
			_employeeService.UpdateEmployeeByEmployee(employee);
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
			var EmployeesBySearched = _employeeService.GetEmployeeListByName(txtName.Text.Trim());
			dgvEmployee.DataSource = EmployeesBySearched;
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
			txtEmergencyContact.Clear();
			dtpBirthDay.Value = DateTime.Now;
			dtpEntryTime.Value = DateTime.Now;

			BindData();
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
		/// GetInformationFromUI
		/// </summary>
		/// <returns></returns>
		Employee GetEmployeeFromUI()
		{
			int employeeId = _editId;
			string name = txtName.Text.Trim();
			int positionId = (int)cboPosition.SelectedValue;
			int departmentId = (int)cboDepartment.SelectedValue;
			string firstName = txtFirstName.Text.Trim();
			string middleName = txtMiddleName.Text.Trim();
			string lastName = txtLastName.Text.Trim();
			string gender = txtGender.Text.Trim();
			DateTime birthDay = dtpBirthDay.Value;
			DateTime entryTime = dtpEntryTime.Value;
			string education = txtEducation.Text.Trim();
			string profession = txtProfession.Text.Trim();
			string language = txtLanguage.Text.Trim();
			string specialty = txtSpecialty.Text.Trim();
			string familyAddress = txtFamilyAddress.Text.Trim();
			string emergencyContact = txtEmergencyContact.Text.Trim();
			string photo = txtPhoto.Text.Trim();

			Employee employee = new Employee()
			{
				EmployeeId = employeeId,
				Name = name,
				PositionId = positionId,
				DepartmentId = departmentId,
				FirstName = firstName,
				MiddleName = middleName,
				LastName = lastName,
				Gender = gender,
				BirthDay = birthDay,
				EntryTime = entryTime,
				Education = education,
				Profession = profession,
				Language = language,
				Specialty = specialty,
				FamilyAddress = familyAddress,
				EmergencyContact = emergencyContact,
				Photo = photo
			};

			return employee;
		}

		/// <summary>
		/// Display
		/// </summary>
		/// <param name="employee"></param>
		void DisplayInformation(Employee employee)
		{
			txtName.Text = employee.Name;
			cboPosition.SelectedValue = employee.PositionId;
			cboDepartment.SelectedValue = employee.DepartmentId;
			txtFirstName.Text = employee.FirstName;
			txtMiddleName.Text = employee.MiddleName;
			txtLastName.Text = employee.LastName;
			txtGender.Text = employee.Gender;
			dtpBirthDay.Text = employee.BirthDay.ToString();
			dtpEntryTime.Text = employee.EntryTime.ToString();
			txtEducation.Text = employee.Education;
			txtProfession.Text = employee.Profession;
			txtLanguage.Text = employee.Language;
			txtSpecialty.Text = employee.Specialty;
			txtFamilyAddress.Text = employee.FamilyAddress;
			txtEmergencyContact.Text = employee.EmergencyContact;
			txtPhoto.Text = employee.Photo;
		}
	}
}
