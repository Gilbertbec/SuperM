namespace SuperM.UI.WinForm
{
	partial class ProductTypesEditor
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
			this.dgvProductTypes = new System.Windows.Forms.DataGridView();
			this.lblProductTypeName = new System.Windows.Forms.Label();
			this.txtProductTypeName = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductTypes)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvProductTypes
			// 
			this.dgvProductTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProductTypes.Location = new System.Drawing.Point(1, -1);
			this.dgvProductTypes.Name = "dgvProductTypes";
			this.dgvProductTypes.RowTemplate.Height = 33;
			this.dgvProductTypes.Size = new System.Drawing.Size(2000, 900);
			this.dgvProductTypes.TabIndex = 0;
			this.dgvProductTypes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductTypes_CellClick);
			// 
			// lblProductTypeName
			// 
			this.lblProductTypeName.AutoSize = true;
			this.lblProductTypeName.Location = new System.Drawing.Point(14, 975);
			this.lblProductTypeName.Name = "lblProductTypeName";
			this.lblProductTypeName.Size = new System.Drawing.Size(202, 25);
			this.lblProductTypeName.TabIndex = 1;
			this.lblProductTypeName.Text = "ProductType Name:";
			// 
			// txtProductTypeName
			// 
			this.txtProductTypeName.Location = new System.Drawing.Point(227, 969);
			this.txtProductTypeName.Name = "txtProductTypeName";
			this.txtProductTypeName.Size = new System.Drawing.Size(454, 31);
			this.txtProductTypeName.TabIndex = 2;
			this.txtProductTypeName.TextChanged += new System.EventHandler(this.txtProductTypeName_TextChanged);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(1546, 969);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(120, 50);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(1881, 969);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(120, 50);
			this.btnDelete.TabIndex = 5;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(1371, 969);
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
			this.btnUpdate.Location = new System.Drawing.Point(1716, 969);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(120, 50);
			this.btnUpdate.TabIndex = 7;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// ProductTypesEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(2074, 1329);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtProductTypeName);
			this.Controls.Add(this.lblProductTypeName);
			this.Controls.Add(this.dgvProductTypes);
			this.Name = "ProductTypesEditor";
			this.Text = "ProductTypesEditor";
			this.Load += new System.EventHandler(this.ProductTypesEditor_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvProductTypes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvProductTypes;
		private System.Windows.Forms.Label lblProductTypeName;
		private System.Windows.Forms.TextBox txtProductTypeName;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnUpdate;
	}
}