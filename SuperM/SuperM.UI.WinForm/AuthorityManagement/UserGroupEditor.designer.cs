
namespace SuperM.UI.WinForm
{
	partial class UserGroupEditor
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
			this.dgvUserGroup = new System.Windows.Forms.DataGridView();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.lblUserName = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.lblGroupName = new System.Windows.Forms.Label();
			this.txtGroupName = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvUserGroup)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvUserGroup
			// 
			this.dgvUserGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUserGroup.Location = new System.Drawing.Point(0, 1);
			this.dgvUserGroup.Name = "dgvUserGroup";
			this.dgvUserGroup.RowTemplate.Height = 33;
			this.dgvUserGroup.Size = new System.Drawing.Size(2000, 900);
			this.dgvUserGroup.TabIndex = 0;
			this.dgvUserGroup.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserGroup_CellClick);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(850, 971);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(120, 50);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(1153, 971);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(120, 50);
			this.btnDelete.TabIndex = 5;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(694, 971);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(120, 50);
			this.btnClear.TabIndex = 6;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Enabled = false;
			this.btnUpdate.Location = new System.Drawing.Point(1004, 972);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(120, 50);
			this.btnUpdate.TabIndex = 7;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// lblUserName
			// 
			this.lblUserName.AutoSize = true;
			this.lblUserName.Location = new System.Drawing.Point(27, 971);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(119, 25);
			this.lblUserName.TabIndex = 1;
			this.lblUserName.Text = "UserName:";
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(163, 971);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(454, 31);
			this.txtUserName.TabIndex = 0;
			this.txtUserName.Click += new System.EventHandler(this.txtUserId_Click);
			// 
			// lblGroupName
			// 
			this.lblGroupName.AutoSize = true;
			this.lblGroupName.Location = new System.Drawing.Point(27, 1021);
			this.lblGroupName.Name = "lblGroupName";
			this.lblGroupName.Size = new System.Drawing.Size(133, 25);
			this.lblGroupName.TabIndex = 1;
			this.lblGroupName.Text = "GroupName:";
			// 
			// txtGroupName
			// 
			this.txtGroupName.Location = new System.Drawing.Point(163, 1021);
			this.txtGroupName.Name = "txtGroupName";
			this.txtGroupName.Size = new System.Drawing.Size(454, 31);
			this.txtGroupName.TabIndex = 1;
			this.txtGroupName.Click += new System.EventHandler(this.txtGroupName_Click);
			// 
			// UserGroupEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(2074, 1329);
			this.Controls.Add(this.dgvUserGroup);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.lblUserName);
			this.Controls.Add(this.txtGroupName);
			this.Controls.Add(this.lblGroupName);
			this.Name = "UserGroupEditor";
			this.Text = "UsersGroupEditor";
			this.Load += new System.EventHandler(this.UserGroupEditor_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvUserGroup)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvUserGroup;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.Label lblGroupName;
		private System.Windows.Forms.TextBox txtGroupName;}
}
