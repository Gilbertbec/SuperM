namespace SuperM.UI.WinForm
{
	partial class DepartmentEditor
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dgvDepartment;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lblCompany;

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
			this.dgvDepartment = new System.Windows.Forms.DataGridView();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.lblName = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblCompany = new System.Windows.Forms.Label();
			this.cboCompany = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvDepartment
			// 
			this.dgvDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDepartment.Location = new System.Drawing.Point(0, 1);
			this.dgvDepartment.Name = "dgvDepartment";
			this.dgvDepartment.RowTemplate.Height = 33;
			this.dgvDepartment.Size = new System.Drawing.Size(2000, 900);
			this.dgvDepartment.TabIndex = 0;
			this.dgvDepartment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartment_CellClick);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(1552, 951);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(120, 50);
			this.btnAdd.TabIndex = 3;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(1880, 952);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(120, 50);
			this.btnDelete.TabIndex = 5;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(1404, 951);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(120, 50);
			this.btnClear.TabIndex = 2;
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
			this.btnUpdate.TabIndex = 4;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(17, 945);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(74, 25);
			this.lblName.TabIndex = 1;
			this.lblName.Text = "Name:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(153, 945);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(454, 31);
			this.txtName.TabIndex = 0;
			this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
			// 
			// lblCompany
			// 
			this.lblCompany.AutoSize = true;
			this.lblCompany.Location = new System.Drawing.Point(17, 1008);
			this.lblCompany.Name = "lblCompany";
			this.lblCompany.Size = new System.Drawing.Size(109, 25);
			this.lblCompany.TabIndex = 1;
			this.lblCompany.Text = "Company:";
			// 
			// cboCompany
			// 
			this.cboCompany.FormattingEnabled = true;
			this.cboCompany.Location = new System.Drawing.Point(153, 1008);
			this.cboCompany.Name = "cboCompany";
			this.cboCompany.Size = new System.Drawing.Size(454, 33);
			this.cboCompany.TabIndex = 1;
			// 
			// DepartmentEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(2074, 1329);
			this.Controls.Add(this.cboCompany);
			this.Controls.Add(this.dgvDepartment);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.lblCompany);
			this.Name = "DepartmentEditor";
			this.Text = "DepartmentEditor";
			this.Load += new System.EventHandler(this.DepartmentEditor_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private System.Windows.Forms.ComboBox cboCompany;
	}
}
