namespace SuperM.UI.WinForm
{
	partial class EmployeeEditor
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		private System.Windows.Forms.DataGridView dgvEmployee;

		private System.Windows.Forms.Button btnAdd;

		private System.Windows.Forms.Button btnDelete;

		private System.Windows.Forms.Button btnClear;

		private System.Windows.Forms.Button btnUpdate;

		private System.Windows.Forms.Label lblName;

		private System.Windows.Forms.TextBox txtName;

		private System.Windows.Forms.Label lblPosition;

		private System.Windows.Forms.Label lblDepartment;

		private System.Windows.Forms.Label lblFirstName;

		private System.Windows.Forms.TextBox txtFirstName;

		private System.Windows.Forms.Label lblMiddleName;

		private System.Windows.Forms.TextBox txtMiddleName;

		private System.Windows.Forms.Label lblLastName;

		private System.Windows.Forms.TextBox txtLastName;

		private System.Windows.Forms.Label lblGender;

		private System.Windows.Forms.TextBox txtGender;

		private System.Windows.Forms.Label lblBirthDay;

		private System.Windows.Forms.Label lblEntryTime;

		private System.Windows.Forms.Label lblEducation;

		private System.Windows.Forms.TextBox txtEducation;

		private System.Windows.Forms.Label lblProfession;

		private System.Windows.Forms.TextBox txtProfession;

		private System.Windows.Forms.Label lblLanguage;

		private System.Windows.Forms.TextBox txtLanguage;

		private System.Windows.Forms.Label lblSpecialty;

		private System.Windows.Forms.TextBox txtSpecialty;

		private System.Windows.Forms.Label lblFamilyAddress;

		private System.Windows.Forms.TextBox txtFamilyAddress;

		private System.Windows.Forms.Label lblEmergencyContact;

		private System.Windows.Forms.Label lblPhoto;

		private System.Windows.Forms.TextBox txtPhoto;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dgvEmployee = new System.Windows.Forms.DataGridView();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.lblName = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblPosition = new System.Windows.Forms.Label();
			this.lblDepartment = new System.Windows.Forms.Label();
			this.lblFirstName = new System.Windows.Forms.Label();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.lblMiddleName = new System.Windows.Forms.Label();
			this.txtMiddleName = new System.Windows.Forms.TextBox();
			this.lblLastName = new System.Windows.Forms.Label();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.lblGender = new System.Windows.Forms.Label();
			this.txtGender = new System.Windows.Forms.TextBox();
			this.lblBirthDay = new System.Windows.Forms.Label();
			this.lblEntryTime = new System.Windows.Forms.Label();
			this.lblEducation = new System.Windows.Forms.Label();
			this.txtEducation = new System.Windows.Forms.TextBox();
			this.lblProfession = new System.Windows.Forms.Label();
			this.txtProfession = new System.Windows.Forms.TextBox();
			this.lblLanguage = new System.Windows.Forms.Label();
			this.txtLanguage = new System.Windows.Forms.TextBox();
			this.lblSpecialty = new System.Windows.Forms.Label();
			this.txtSpecialty = new System.Windows.Forms.TextBox();
			this.lblFamilyAddress = new System.Windows.Forms.Label();
			this.txtFamilyAddress = new System.Windows.Forms.TextBox();
			this.lblEmergencyContact = new System.Windows.Forms.Label();
			this.lblPhoto = new System.Windows.Forms.Label();
			this.txtPhoto = new System.Windows.Forms.TextBox();
			this.cboDepartment = new System.Windows.Forms.ComboBox();
			this.cboPosition = new System.Windows.Forms.ComboBox();
			this.txtEmergencyContact = new System.Windows.Forms.MaskedTextBox();
			this.dtpBirthDay = new System.Windows.Forms.DateTimePicker();
			this.dtpEntryTime = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvEmployee
			// 
			this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEmployee.Location = new System.Drawing.Point(0, 1);
			this.dgvEmployee.Name = "dgvEmployee";
			this.dgvEmployee.RowTemplate.Height = 33;
			this.dgvEmployee.Size = new System.Drawing.Size(2000, 900);
			this.dgvEmployee.TabIndex = 0;
			this.dgvEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellClick);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(1552, 951);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(120, 50);
			this.btnAdd.TabIndex = 17;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(1880, 952);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(120, 50);
			this.btnDelete.TabIndex = 19;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(1404, 951);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(120, 50);
			this.btnClear.TabIndex = 16;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Enabled = false;
			this.btnUpdate.Location = new System.Drawing.Point(1717, 951);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(120, 50);
			this.btnUpdate.TabIndex = 18;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(4, 923);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(74, 25);
			this.lblName.TabIndex = 1;
			this.lblName.Text = "Name:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(140, 923);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(454, 31);
			this.txtName.TabIndex = 0;
			this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
			// 
			// lblPosition
			// 
			this.lblPosition.AutoSize = true;
			this.lblPosition.Location = new System.Drawing.Point(662, 968);
			this.lblPosition.Name = "lblPosition";
			this.lblPosition.Size = new System.Drawing.Size(95, 25);
			this.lblPosition.TabIndex = 1;
			this.lblPosition.Text = "Position:";
			// 
			// lblDepartment
			// 
			this.lblDepartment.AutoSize = true;
			this.lblDepartment.Location = new System.Drawing.Point(4, 977);
			this.lblDepartment.Name = "lblDepartment";
			this.lblDepartment.Size = new System.Drawing.Size(129, 25);
			this.lblDepartment.TabIndex = 1;
			this.lblDepartment.Text = "Department:";
			// 
			// lblFirstName
			// 
			this.lblFirstName.AutoSize = true;
			this.lblFirstName.Location = new System.Drawing.Point(4, 1027);
			this.lblFirstName.Name = "lblFirstName";
			this.lblFirstName.Size = new System.Drawing.Size(116, 25);
			this.lblFirstName.TabIndex = 1;
			this.lblFirstName.Text = "FirstName:";
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(140, 1027);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(454, 31);
			this.txtFirstName.TabIndex = 4;
			// 
			// lblMiddleName
			// 
			this.lblMiddleName.AutoSize = true;
			this.lblMiddleName.Location = new System.Drawing.Point(4, 1077);
			this.lblMiddleName.Name = "lblMiddleName";
			this.lblMiddleName.Size = new System.Drawing.Size(138, 25);
			this.lblMiddleName.TabIndex = 1;
			this.lblMiddleName.Text = "MiddleName:";
			// 
			// txtMiddleName
			// 
			this.txtMiddleName.Location = new System.Drawing.Point(140, 1077);
			this.txtMiddleName.Name = "txtMiddleName";
			this.txtMiddleName.Size = new System.Drawing.Size(454, 31);
			this.txtMiddleName.TabIndex = 6;
			// 
			// lblLastName
			// 
			this.lblLastName.AutoSize = true;
			this.lblLastName.Location = new System.Drawing.Point(4, 1127);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.Size = new System.Drawing.Size(115, 25);
			this.lblLastName.TabIndex = 1;
			this.lblLastName.Text = "LastName:";
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(140, 1127);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(454, 31);
			this.txtLastName.TabIndex = 8;
			// 
			// lblGender
			// 
			this.lblGender.AutoSize = true;
			this.lblGender.Location = new System.Drawing.Point(662, 920);
			this.lblGender.Name = "lblGender";
			this.lblGender.Size = new System.Drawing.Size(89, 25);
			this.lblGender.TabIndex = 1;
			this.lblGender.Text = "Gender:";
			// 
			// txtGender
			// 
			this.txtGender.Location = new System.Drawing.Point(868, 923);
			this.txtGender.Name = "txtGender";
			this.txtGender.Size = new System.Drawing.Size(454, 31);
			this.txtGender.TabIndex = 1;
			// 
			// lblBirthDay
			// 
			this.lblBirthDay.AutoSize = true;
			this.lblBirthDay.Location = new System.Drawing.Point(4, 1176);
			this.lblBirthDay.Name = "lblBirthDay";
			this.lblBirthDay.Size = new System.Drawing.Size(100, 25);
			this.lblBirthDay.TabIndex = 1;
			this.lblBirthDay.Text = "BirthDay:";
			// 
			// lblEntryTime
			// 
			this.lblEntryTime.AutoSize = true;
			this.lblEntryTime.Location = new System.Drawing.Point(4, 1227);
			this.lblEntryTime.Name = "lblEntryTime";
			this.lblEntryTime.Size = new System.Drawing.Size(115, 25);
			this.lblEntryTime.TabIndex = 1;
			this.lblEntryTime.Text = "EntryTime:";
			// 
			// lblEducation
			// 
			this.lblEducation.AutoSize = true;
			this.lblEducation.Location = new System.Drawing.Point(662, 1068);
			this.lblEducation.Name = "lblEducation";
			this.lblEducation.Size = new System.Drawing.Size(114, 25);
			this.lblEducation.TabIndex = 1;
			this.lblEducation.Text = "Education:";
			// 
			// txtEducation
			// 
			this.txtEducation.Location = new System.Drawing.Point(868, 1071);
			this.txtEducation.Name = "txtEducation";
			this.txtEducation.Size = new System.Drawing.Size(454, 31);
			this.txtEducation.TabIndex = 7;
			// 
			// lblProfession
			// 
			this.lblProfession.AutoSize = true;
			this.lblProfession.Location = new System.Drawing.Point(662, 1124);
			this.lblProfession.Name = "lblProfession";
			this.lblProfession.Size = new System.Drawing.Size(120, 25);
			this.lblProfession.TabIndex = 1;
			this.lblProfession.Text = "Profession:";
			// 
			// txtProfession
			// 
			this.txtProfession.Location = new System.Drawing.Point(868, 1127);
			this.txtProfession.Name = "txtProfession";
			this.txtProfession.Size = new System.Drawing.Size(454, 31);
			this.txtProfession.TabIndex = 9;
			// 
			// lblLanguage
			// 
			this.lblLanguage.AutoSize = true;
			this.lblLanguage.Location = new System.Drawing.Point(662, 1018);
			this.lblLanguage.Name = "lblLanguage";
			this.lblLanguage.Size = new System.Drawing.Size(114, 25);
			this.lblLanguage.TabIndex = 1;
			this.lblLanguage.Text = "Language:";
			// 
			// txtLanguage
			// 
			this.txtLanguage.Location = new System.Drawing.Point(868, 1021);
			this.txtLanguage.Name = "txtLanguage";
			this.txtLanguage.Size = new System.Drawing.Size(454, 31);
			this.txtLanguage.TabIndex = 5;
			// 
			// lblSpecialty
			// 
			this.lblSpecialty.AutoSize = true;
			this.lblSpecialty.Location = new System.Drawing.Point(662, 1179);
			this.lblSpecialty.Name = "lblSpecialty";
			this.lblSpecialty.Size = new System.Drawing.Size(106, 25);
			this.lblSpecialty.TabIndex = 1;
			this.lblSpecialty.Text = "Specialty:";
			// 
			// txtSpecialty
			// 
			this.txtSpecialty.Location = new System.Drawing.Point(868, 1182);
			this.txtSpecialty.Name = "txtSpecialty";
			this.txtSpecialty.Size = new System.Drawing.Size(454, 31);
			this.txtSpecialty.TabIndex = 11;
			// 
			// lblFamilyAddress
			// 
			this.lblFamilyAddress.AutoSize = true;
			this.lblFamilyAddress.Location = new System.Drawing.Point(662, 1224);
			this.lblFamilyAddress.Name = "lblFamilyAddress";
			this.lblFamilyAddress.Size = new System.Drawing.Size(160, 25);
			this.lblFamilyAddress.TabIndex = 1;
			this.lblFamilyAddress.Text = "FamilyAddress:";
			// 
			// txtFamilyAddress
			// 
			this.txtFamilyAddress.Location = new System.Drawing.Point(868, 1227);
			this.txtFamilyAddress.Name = "txtFamilyAddress";
			this.txtFamilyAddress.Size = new System.Drawing.Size(454, 31);
			this.txtFamilyAddress.TabIndex = 13;
			// 
			// lblEmergencyContact
			// 
			this.lblEmergencyContact.AutoSize = true;
			this.lblEmergencyContact.Location = new System.Drawing.Point(662, 1280);
			this.lblEmergencyContact.Name = "lblEmergencyContact";
			this.lblEmergencyContact.Size = new System.Drawing.Size(200, 25);
			this.lblEmergencyContact.TabIndex = 1;
			this.lblEmergencyContact.Text = "EmergencyContact:";
			// 
			// lblPhoto
			// 
			this.lblPhoto.AutoSize = true;
			this.lblPhoto.Location = new System.Drawing.Point(4, 1283);
			this.lblPhoto.Name = "lblPhoto";
			this.lblPhoto.Size = new System.Drawing.Size(74, 25);
			this.lblPhoto.TabIndex = 1;
			this.lblPhoto.Text = "Photo:";
			// 
			// txtPhoto
			// 
			this.txtPhoto.Location = new System.Drawing.Point(140, 1277);
			this.txtPhoto.Name = "txtPhoto";
			this.txtPhoto.Size = new System.Drawing.Size(454, 31);
			this.txtPhoto.TabIndex = 14;
			// 
			// cboDepartment
			// 
			this.cboDepartment.FormattingEnabled = true;
			this.cboDepartment.Location = new System.Drawing.Point(140, 977);
			this.cboDepartment.Name = "cboDepartment";
			this.cboDepartment.Size = new System.Drawing.Size(454, 33);
			this.cboDepartment.TabIndex = 2;
			// 
			// cboPosition
			// 
			this.cboPosition.FormattingEnabled = true;
			this.cboPosition.Location = new System.Drawing.Point(868, 971);
			this.cboPosition.Name = "cboPosition";
			this.cboPosition.Size = new System.Drawing.Size(454, 33);
			this.cboPosition.TabIndex = 3;
			// 
			// txtEmergencyContact
			// 
			this.txtEmergencyContact.Location = new System.Drawing.Point(868, 1277);
			this.txtEmergencyContact.Mask = "(999) 000-0000";
			this.txtEmergencyContact.Name = "txtEmergencyContact";
			this.txtEmergencyContact.Size = new System.Drawing.Size(454, 31);
			this.txtEmergencyContact.TabIndex = 15;
			// 
			// dtpBirthDay
			// 
			this.dtpBirthDay.Location = new System.Drawing.Point(140, 1179);
			this.dtpBirthDay.Name = "dtpBirthDay";
			this.dtpBirthDay.Size = new System.Drawing.Size(454, 31);
			this.dtpBirthDay.TabIndex = 10;
			// 
			// dtpEntryTime
			// 
			this.dtpEntryTime.Location = new System.Drawing.Point(140, 1240);
			this.dtpEntryTime.Name = "dtpEntryTime";
			this.dtpEntryTime.Size = new System.Drawing.Size(454, 31);
			this.dtpEntryTime.TabIndex = 12;
			// 
			// EmployeeEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(2074, 1329);
			this.Controls.Add(this.dtpEntryTime);
			this.Controls.Add(this.dtpBirthDay);
			this.Controls.Add(this.txtEmergencyContact);
			this.Controls.Add(this.cboPosition);
			this.Controls.Add(this.cboDepartment);
			this.Controls.Add(this.dgvEmployee);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.lblPosition);
			this.Controls.Add(this.lblDepartment);
			this.Controls.Add(this.txtFirstName);
			this.Controls.Add(this.lblFirstName);
			this.Controls.Add(this.txtMiddleName);
			this.Controls.Add(this.lblMiddleName);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.lblLastName);
			this.Controls.Add(this.txtGender);
			this.Controls.Add(this.lblGender);
			this.Controls.Add(this.lblBirthDay);
			this.Controls.Add(this.lblEntryTime);
			this.Controls.Add(this.txtEducation);
			this.Controls.Add(this.lblEducation);
			this.Controls.Add(this.txtProfession);
			this.Controls.Add(this.lblProfession);
			this.Controls.Add(this.txtLanguage);
			this.Controls.Add(this.lblLanguage);
			this.Controls.Add(this.txtSpecialty);
			this.Controls.Add(this.lblSpecialty);
			this.Controls.Add(this.txtFamilyAddress);
			this.Controls.Add(this.lblFamilyAddress);
			this.Controls.Add(this.lblEmergencyContact);
			this.Controls.Add(this.txtPhoto);
			this.Controls.Add(this.lblPhoto);
			this.Name = "EmployeeEditor";
			this.Text = "EmployeeEditor";
			this.Load += new System.EventHandler(this.EmployeeEditor_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private System.Windows.Forms.ComboBox cboDepartment;
		private System.Windows.Forms.ComboBox cboPosition;
		private System.Windows.Forms.MaskedTextBox txtEmergencyContact;
		private System.Windows.Forms.DateTimePicker dtpBirthDay;
		private System.Windows.Forms.DateTimePicker dtpEntryTime;
	}
}
