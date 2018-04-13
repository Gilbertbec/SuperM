

namespace SuperM.UI.WinForm
{
	partial class SupplierEditor
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
			this.dgvSuppliers = new System.Windows.Forms.DataGridView();
			this.lblName = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvSuppliers
			// 
			this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSuppliers.Location = new System.Drawing.Point(68, 193);
			this.dgvSuppliers.Name = "dgvSuppliers";
			this.dgvSuppliers.RowTemplate.Height = 33;
			this.dgvSuppliers.Size = new System.Drawing.Size(797, 524);
			this.dgvSuppliers.TabIndex = 0;
			this.dgvSuppliers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuppliers_CellClick);
			// 
			// lblSupplierName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(63, 64);
			this.lblName.Name = "lblSupplierName";
			this.lblName.Size = new System.Drawing.Size(196, 25);
			this.lblName.TabIndex = 1;
			this.lblName.Text = "SupplierName:";
			// 
			// txtSupplierName
			// 
			this.txtName.Location = new System.Drawing.Point(276, 58);
			this.txtName.Name = "txtSupplierName";
			this.txtName.Size = new System.Drawing.Size(454, 31);
			this.txtName.TabIndex = 2;
			this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(611, 124);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(119, 51);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(68, 124);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(119, 51);
			this.btnDelete.TabIndex = 5;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(746, 123);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(119, 52);
			this.btnClear.TabIndex = 6;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Enabled = false;
			this.btnUpdate.Location = new System.Drawing.Point(276, 123);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(119, 51);
			this.btnUpdate.TabIndex = 7;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// SuppliersEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(945, 782);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.dgvSuppliers);
			this.Name = "SuppliersEditor";
			this.Text = "SuppliersEditor";
			this.Load += new System.EventHandler(this.SuppliersEditor_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvSuppliers;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnUpdate;
	}
}

