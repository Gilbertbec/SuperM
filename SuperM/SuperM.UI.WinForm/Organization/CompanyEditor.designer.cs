
namespace SuperM.UI.WinForm
{
	partial class CompanyEditor
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.dgvCompany = new System.Windows.Forms.DataGridView();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.lblName = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblAddress = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.lblTelephoneNumber = new System.Windows.Forms.Label();
			this.lblFax = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblWebsite = new System.Windows.Forms.Label();
			this.txtWebsite = new System.Windows.Forms.TextBox();
			this.lblFatherCompany = new System.Windows.Forms.Label();
			this.cboFatherCompany = new System.Windows.Forms.ComboBox();
			this.txtTelephoneNumber = new System.Windows.Forms.MaskedTextBox();
			this.txtFax = new System.Windows.Forms.MaskedTextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dgvCompany)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvCompany
			// 
			this.dgvCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCompany.Location = new System.Drawing.Point(0, 1);
			this.dgvCompany.Name = "dgvCompany";
			this.dgvCompany.RowTemplate.Height = 33;
			this.dgvCompany.Size = new System.Drawing.Size(2000, 900);
			this.dgvCompany.TabIndex = 0;
			this.dgvCompany.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompany_CellClick);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(1582, 945);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(120, 50);
			this.btnAdd.TabIndex = 7;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(1880, 946);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(120, 50);
			this.btnDelete.TabIndex = 9;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(1434, 945);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(120, 50);
			this.btnClear.TabIndex = 7;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Enabled = false;
			this.btnUpdate.Location = new System.Drawing.Point(1731, 945);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(120, 50);
			this.btnUpdate.TabIndex = 8;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(17, 946);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(74, 25);
			this.lblName.TabIndex = 1;
			this.lblName.Text = "Name:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(228, 946);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(454, 31);
			this.txtName.TabIndex = 0;
			this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Location = new System.Drawing.Point(17, 996);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(97, 25);
			this.lblAddress.TabIndex = 1;
			this.lblAddress.Text = "Address:";
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(228, 996);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(454, 31);
			this.txtAddress.TabIndex = 2;
			// 
			// lblTelephoneNumber
			// 
			this.lblTelephoneNumber.AutoSize = true;
			this.lblTelephoneNumber.Location = new System.Drawing.Point(17, 1046);
			this.lblTelephoneNumber.Name = "lblTelephoneNumber";
			this.lblTelephoneNumber.Size = new System.Drawing.Size(195, 25);
			this.lblTelephoneNumber.TabIndex = 1;
			this.lblTelephoneNumber.Text = "TelephoneNumber:";
			// 
			// lblFax
			// 
			this.lblFax.AutoSize = true;
			this.lblFax.Location = new System.Drawing.Point(718, 993);
			this.lblFax.Name = "lblFax";
			this.lblFax.Size = new System.Drawing.Size(54, 25);
			this.lblFax.TabIndex = 1;
			this.lblFax.Text = "Fax:";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Location = new System.Drawing.Point(718, 1046);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(71, 25);
			this.lblEmail.TabIndex = 1;
			this.lblEmail.Text = "Email:";
			// 
			// lblWebsite
			// 
			this.lblWebsite.AutoSize = true;
			this.lblWebsite.Location = new System.Drawing.Point(17, 1099);
			this.lblWebsite.Name = "lblWebsite";
			this.lblWebsite.Size = new System.Drawing.Size(96, 25);
			this.lblWebsite.TabIndex = 1;
			this.lblWebsite.Text = "Website:";
			// 
			// txtWebsite
			// 
			this.txtWebsite.Location = new System.Drawing.Point(228, 1099);
			this.txtWebsite.Name = "txtWebsite";
			this.txtWebsite.Size = new System.Drawing.Size(454, 31);
			this.txtWebsite.TabIndex = 6;
			// 
			// lblFatherCompany
			// 
			this.lblFatherCompany.AutoSize = true;
			this.lblFatherCompany.Location = new System.Drawing.Point(718, 946);
			this.lblFatherCompany.Name = "lblFatherCompany";
			this.lblFatherCompany.Size = new System.Drawing.Size(171, 25);
			this.lblFatherCompany.TabIndex = 1;
			this.lblFatherCompany.Text = "FatherCompany:";
			// 
			// cboFatherCompany
			// 
			this.cboFatherCompany.FormattingEnabled = true;
			this.cboFatherCompany.Location = new System.Drawing.Point(927, 943);
			this.cboFatherCompany.Name = "cboFatherCompany";
			this.cboFatherCompany.Size = new System.Drawing.Size(454, 33);
			this.cboFatherCompany.TabIndex = 1;
			// 
			// txtTelephoneNumber
			// 
			this.txtTelephoneNumber.Location = new System.Drawing.Point(228, 1046);
			this.txtTelephoneNumber.Mask = "(999) 000-0000";
			this.txtTelephoneNumber.Name = "txtTelephoneNumber";
			this.txtTelephoneNumber.Size = new System.Drawing.Size(454, 31);
			this.txtTelephoneNumber.TabIndex = 4;
			// 
			// txtFax
			// 
			this.txtFax.Location = new System.Drawing.Point(927, 993);
			this.txtFax.Mask = "(999) 000-0000";
			this.txtFax.Name = "txtFax";
			this.txtFax.Size = new System.Drawing.Size(454, 31);
			this.txtFax.TabIndex = 3;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(927, 1040);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(454, 31);
			this.txtEmail.TabIndex = 5;
			this.txtEmail.MouseLeave += new System.EventHandler(this.txtEmail_MouseLeave);
			// 
			// errProvider
			// 
			this.errProvider.ContainerControl = this;
			// 
			// CompanyEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(2074, 1329);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtFax);
			this.Controls.Add(this.txtTelephoneNumber);
			this.Controls.Add(this.cboFatherCompany);
			this.Controls.Add(this.dgvCompany);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.lblAddress);
			this.Controls.Add(this.lblTelephoneNumber);
			this.Controls.Add(this.lblFax);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.txtWebsite);
			this.Controls.Add(this.lblWebsite);
			this.Controls.Add(this.lblFatherCompany);
			this.Name = "CompanyEditor";
			this.Text = "CompanyEditor";
			this.Load += new System.EventHandler(this.CompanyEditor_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvCompany)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvCompany;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Label lblTelephoneNumber;
		private System.Windows.Forms.Label lblFax;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblWebsite;
		private System.Windows.Forms.TextBox txtWebsite;
		private System.Windows.Forms.Label lblFatherCompany;
		private System.Windows.Forms.ComboBox cboFatherCompany;
		private System.Windows.Forms.MaskedTextBox txtTelephoneNumber;
		private System.Windows.Forms.MaskedTextBox txtFax;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.ErrorProvider errProvider;
	}
}
