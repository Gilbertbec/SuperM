namespace SuperM.UI.WinForm
{
	partial class UserSelector
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dgvUsers;
		private System.Windows.Forms.Label lblUserId;
		private System.Windows.Forms.TextBox txtUserId;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox txtName;

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
			this.dgvUsers = new System.Windows.Forms.DataGridView();
			this.lblUserId = new System.Windows.Forms.Label();
			this.txtUserId = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.btnConfirm = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvUsers
			// 
			this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUsers.Location = new System.Drawing.Point(0, 1);
			this.dgvUsers.Name = "dgvUsers";
			this.dgvUsers.RowTemplate.Height = 33;
			this.dgvUsers.Size = new System.Drawing.Size(1700, 500);
			this.dgvUsers.TabIndex = 0;
			this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
			// 
			// lblUserId
			// 
			this.lblUserId.Location = new System.Drawing.Point(0, 0);
			this.lblUserId.Name = "lblUserId";
			this.lblUserId.Size = new System.Drawing.Size(100, 23);
			this.lblUserId.TabIndex = 9;
			// 
			// txtUserId
			// 
			this.txtUserId.Location = new System.Drawing.Point(0, 0);
			this.txtUserId.Name = "txtUserId";
			this.txtUserId.Size = new System.Drawing.Size(100, 31);
			this.txtUserId.TabIndex = 8;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(19, 532);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(74, 25);
			this.lblName.TabIndex = 1;
			this.lblName.Text = "Name:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(155, 532);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(454, 31);
			this.txtName.TabIndex = 2;
			this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
			// 
			// btnConfirm
			// 
			this.btnConfirm.Location = new System.Drawing.Point(911, 532);
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Size = new System.Drawing.Size(120, 50);
			this.btnConfirm.TabIndex = 10;
			this.btnConfirm.Text = "Confirm";
			this.btnConfirm.UseVisualStyleBackColor = true;
			this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(718, 532);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(120, 50);
			this.btnClear.TabIndex = 11;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// UserSelector
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1674, 629);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnConfirm);
			this.Controls.Add(this.dgvUsers);
			this.Controls.Add(this.txtUserId);
			this.Controls.Add(this.lblUserId);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblName);
			this.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.Name = "UserSelector";
			this.Text = "UsersEditor";
			this.Load += new System.EventHandler(this.UsersEditor_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private System.Windows.Forms.Button btnConfirm;
		private System.Windows.Forms.Button btnClear;
	}
}
