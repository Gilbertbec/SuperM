
namespace SuperM.UI.WinForm
{
	partial class PermissionEditor
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dgvPermission;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnUpdate;
			private System.Windows.Forms.Label lblName;
			private System.Windows.Forms.TextBox txtName;
			private System.Windows.Forms.TextBox txtGroup;
			private System.Windows.Forms.Label lblModelName;
			private System.Windows.Forms.TextBox txtModelName;
			private System.Windows.Forms.Label lblControlName;
			private System.Windows.Forms.TextBox txtControlName;
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
			this.dgvPermission = new System.Windows.Forms.DataGridView();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.lblName = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtGroup = new System.Windows.Forms.TextBox();
			this.lblModelName = new System.Windows.Forms.Label();
			this.txtModelName = new System.Windows.Forms.TextBox();
			this.lblControlName = new System.Windows.Forms.Label();
			this.txtControlName = new System.Windows.Forms.TextBox();
			this.lblGroup = new System.Windows.Forms.Label();
			this.lsbModels = new System.Windows.Forms.ListBox();
			this.lsbControls = new System.Windows.Forms.ListBox();
			this.lsbGroup = new System.Windows.Forms.ListBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvPermission)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvPermission
			// 
			this.dgvPermission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPermission.Location = new System.Drawing.Point(0, 1);
			this.dgvPermission.Name = "dgvPermission";
			this.dgvPermission.RowTemplate.Height = 33;
			this.dgvPermission.Size = new System.Drawing.Size(1253, 900);
			this.dgvPermission.TabIndex = 0;
			this.dgvPermission.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPermission_CellClick);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(1552, 951);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(120, 50);
			this.btnAdd.TabIndex = 5;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(1880, 952);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(120, 50);
			this.btnDelete.TabIndex = 7;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(1404, 951);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(120, 50);
			this.btnClear.TabIndex = 4;
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
			this.btnUpdate.TabIndex = 6;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(18, 974);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(74, 25);
			this.lblName.TabIndex = 1;
			this.lblName.Text = "Name:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(154, 974);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(454, 31);
			this.txtName.TabIndex = 0;
			this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
			// 
			// txtGroup
			// 
			this.txtGroup.Location = new System.Drawing.Point(154, 1032);
			this.txtGroup.Name = "txtGroup";
			this.txtGroup.Size = new System.Drawing.Size(454, 31);
			this.txtGroup.TabIndex = 2;
			// 
			// lblModelName
			// 
			this.lblModelName.AutoSize = true;
			this.lblModelName.Location = new System.Drawing.Point(638, 979);
			this.lblModelName.Name = "lblModelName";
			this.lblModelName.Size = new System.Drawing.Size(133, 25);
			this.lblModelName.TabIndex = 1;
			this.lblModelName.Text = "ModelName:";
			// 
			// txtModelName
			// 
			this.txtModelName.Location = new System.Drawing.Point(774, 979);
			this.txtModelName.Name = "txtModelName";
			this.txtModelName.Size = new System.Drawing.Size(454, 31);
			this.txtModelName.TabIndex = 1;
			// 
			// lblControlName
			// 
			this.lblControlName.AutoSize = true;
			this.lblControlName.Location = new System.Drawing.Point(638, 1029);
			this.lblControlName.Name = "lblControlName";
			this.lblControlName.Size = new System.Drawing.Size(143, 25);
			this.lblControlName.TabIndex = 1;
			this.lblControlName.Text = "ControlName:";
			// 
			// txtControlName
			// 
			this.txtControlName.Location = new System.Drawing.Point(774, 1029);
			this.txtControlName.Name = "txtControlName";
			this.txtControlName.Size = new System.Drawing.Size(454, 31);
			this.txtControlName.TabIndex = 3;
			// 
			// lblGroup
			// 
			this.lblGroup.AutoSize = true;
			this.lblGroup.Location = new System.Drawing.Point(18, 1035);
			this.lblGroup.Name = "lblGroup";
			this.lblGroup.Size = new System.Drawing.Size(77, 25);
			this.lblGroup.TabIndex = 1;
			this.lblGroup.Text = "Group:";
			// 
			// lsbModels
			// 
			this.lsbModels.FormattingEnabled = true;
			this.lsbModels.ItemHeight = 25;
			this.lsbModels.Location = new System.Drawing.Point(1692, -3);
			this.lsbModels.Name = "lsbModels";
			this.lsbModels.Size = new System.Drawing.Size(413, 904);
			this.lsbModels.TabIndex = 9;
			this.lsbModels.SelectedIndexChanged += new System.EventHandler(this.lsbModels_SelectedIndexChanged);
			// 
			// lsbControls
			// 
			this.lsbControls.FormattingEnabled = true;
			this.lsbControls.ItemHeight = 25;
			this.lsbControls.Location = new System.Drawing.Point(2111, -3);
			this.lsbControls.Name = "lsbControls";
			this.lsbControls.Size = new System.Drawing.Size(389, 904);
			this.lsbControls.TabIndex = 10;
			this.lsbControls.SelectedIndexChanged += new System.EventHandler(this.lsbControls_SelectedIndexChanged);
			// 
			// lsbGroup
			// 
			this.lsbGroup.FormattingEnabled = true;
			this.lsbGroup.ItemHeight = 25;
			this.lsbGroup.Location = new System.Drawing.Point(1259, -3);
			this.lsbGroup.Name = "lsbGroup";
			this.lsbGroup.Size = new System.Drawing.Size(427, 904);
			this.lsbGroup.TabIndex = 11;
			this.lsbGroup.SelectedIndexChanged += new System.EventHandler(this.lsbGroup_SelectedIndexChanged);
			// 
			// PermissionEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(2512, 1329);
			this.Controls.Add(this.lsbGroup);
			this.Controls.Add(this.lsbControls);
			this.Controls.Add(this.lsbModels);
			this.Controls.Add(this.dgvPermission);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.txtGroup);
			this.Controls.Add(this.lblGroup);
			this.Controls.Add(this.txtModelName);
			this.Controls.Add(this.lblModelName);
			this.Controls.Add(this.txtControlName);
			this.Controls.Add(this.lblControlName);
			this.Name = "PermissionEditor";
			this.Text = "PermissionEditor";
			this.Load += new System.EventHandler(this.PermissionEditor_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvPermission)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private System.Windows.Forms.Label lblGroup;
		private System.Windows.Forms.ListBox lsbModels;
		private System.Windows.Forms.ListBox lsbControls;
		private System.Windows.Forms.ListBox lsbGroup;
	}
}

