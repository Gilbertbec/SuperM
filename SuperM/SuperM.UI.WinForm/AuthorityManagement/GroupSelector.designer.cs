
namespace SuperM.UI.WinForm
{
	partial class GroupSelector
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dgvGroup;
		private System.Windows.Forms.Button btnClear;
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
			this.dgvGroup = new System.Windows.Forms.DataGridView();
			this.btnClear = new System.Windows.Forms.Button();
			this.lblName = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.btnConfirm = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvGroup
			// 
			this.dgvGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvGroup.Location = new System.Drawing.Point(0, 1);
			this.dgvGroup.Name = "dgvGroup";
			this.dgvGroup.RowTemplate.Height = 33;
			this.dgvGroup.Size = new System.Drawing.Size(1700, 500);
			this.dgvGroup.TabIndex = 0;
			this.dgvGroup.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroup_CellClick);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(849, 530);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(120, 50);
			this.btnClear.TabIndex = 6;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(19, 555);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(74, 25);
			this.lblName.TabIndex = 1;
			this.lblName.Text = "Name:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(155, 555);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(454, 31);
			this.txtName.TabIndex = 2;
			this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
			// 
			// btnConfirm
			// 
			this.btnConfirm.Location = new System.Drawing.Point(1175, 530);
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Size = new System.Drawing.Size(120, 50);
			this.btnConfirm.TabIndex = 7;
			this.btnConfirm.Text = "Confirm";
			this.btnConfirm.UseVisualStyleBackColor = true;
			this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
			// 
			// GroupSelector
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1674, 629);
			this.Controls.Add(this.btnConfirm);
			this.Controls.Add(this.dgvGroup);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblName);
			this.Name = "GroupSelector";
			this.Text = "GroupSelector";
			this.Load += new System.EventHandler(this.GroupEditor_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private System.Windows.Forms.Button btnConfirm;
	}
}

