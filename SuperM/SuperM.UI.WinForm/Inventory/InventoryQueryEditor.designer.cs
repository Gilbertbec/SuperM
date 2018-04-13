
namespace SuperM.UI.WinForm
{
	partial class InventoryQueryEditor
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dgvInventory;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnUpdate;
			private System.Windows.Forms.Label lblBatch;
			private System.Windows.Forms.TextBox txtBatch;
			private System.Windows.Forms.Label lblCount;
			private System.Windows.Forms.TextBox txtCount;
			private System.Windows.Forms.Label lblProductId;
			private System.Windows.Forms.Label lblProductText;
			private System.Windows.Forms.TextBox txtProduct;
			private System.Windows.Forms.Label lblSubtotal;
			private System.Windows.Forms.TextBox txtSubtotal;
			private System.Windows.Forms.Label lblUser;
			private System.Windows.Forms.TextBox txtUser;
			private System.Windows.Forms.Label lblInStockTime;
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
			this.dgvInventory = new System.Windows.Forms.DataGridView();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.lblBatch = new System.Windows.Forms.Label();
			this.txtBatch = new System.Windows.Forms.TextBox();
			this.lblCount = new System.Windows.Forms.Label();
			this.txtCount = new System.Windows.Forms.TextBox();
			this.lblProductId = new System.Windows.Forms.Label();
			this.lblProductText = new System.Windows.Forms.Label();
			this.txtProduct = new System.Windows.Forms.TextBox();
			this.lblSubtotal = new System.Windows.Forms.Label();
			this.txtSubtotal = new System.Windows.Forms.TextBox();
			this.lblUser = new System.Windows.Forms.Label();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.lblInStockTime = new System.Windows.Forms.Label();
			this.cboCategory = new System.Windows.Forms.ComboBox();
			this.lblCategory = new System.Windows.Forms.Label();
			this.txtSupplier = new System.Windows.Forms.TextBox();
			this.lblSupplier = new System.Windows.Forms.Label();
			this.cboProduct = new System.Windows.Forms.ComboBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvInventory
			// 
			this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvInventory.Location = new System.Drawing.Point(0, 1);
			this.dgvInventory.Name = "dgvInventory";
			this.dgvInventory.RowTemplate.Height = 33;
			this.dgvInventory.Size = new System.Drawing.Size(2000, 900);
			this.dgvInventory.TabIndex = 0;
			this.dgvInventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellClick);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(1552, 951);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(120, 50);
			this.btnAdd.TabIndex = 4;
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
			this.btnClear.TabIndex = 6;
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
			this.btnUpdate.TabIndex = 7;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			// 
			// lblBatch
			// 
			this.lblBatch.AutoSize = true;
			this.lblBatch.Location = new System.Drawing.Point(678, 1153);
			this.lblBatch.Name = "lblBatch";
			this.lblBatch.Size = new System.Drawing.Size(73, 25);
			this.lblBatch.TabIndex = 1;
			this.lblBatch.Text = "Batch:";
			// 
			// txtBatch
			// 
			this.txtBatch.Location = new System.Drawing.Point(814, 1153);
			this.txtBatch.Name = "txtBatch";
			this.txtBatch.Size = new System.Drawing.Size(454, 31);
			this.txtBatch.TabIndex = 2;
			this.txtBatch.TextChanged += new System.EventHandler(this.txtName_TextChanged);
			// 
			// lblCount
			// 
			this.lblCount.AutoSize = true;
			this.lblCount.Location = new System.Drawing.Point(32, 1223);
			this.lblCount.Name = "lblCount";
			this.lblCount.Size = new System.Drawing.Size(75, 25);
			this.lblCount.TabIndex = 1;
			this.lblCount.Text = "Count:";
			// 
			// txtCount
			// 
			this.txtCount.Location = new System.Drawing.Point(168, 1223);
			this.txtCount.Name = "txtCount";
			this.txtCount.Size = new System.Drawing.Size(454, 31);
			this.txtCount.TabIndex = 2;
			// 
			// lblProductId
			// 
			this.lblProductId.AutoSize = true;
			this.lblProductId.Location = new System.Drawing.Point(32, 966);
			this.lblProductId.Name = "lblProductId";
			this.lblProductId.Size = new System.Drawing.Size(92, 25);
			this.lblProductId.TabIndex = 1;
			this.lblProductId.Text = "Product:";
			// 
			// lblProductText
			// 
			this.lblProductText.AutoSize = true;
			this.lblProductText.Location = new System.Drawing.Point(678, 964);
			this.lblProductText.Name = "lblProductText";
			this.lblProductText.Size = new System.Drawing.Size(92, 25);
			this.lblProductText.TabIndex = 1;
			this.lblProductText.Text = "Product:";
			// 
			// txtProduct
			// 
			this.txtProduct.Location = new System.Drawing.Point(814, 964);
			this.txtProduct.Name = "txtProduct";
			this.txtProduct.Size = new System.Drawing.Size(454, 31);
			this.txtProduct.TabIndex = 2;
			// 
			// lblSubtotal
			// 
			this.lblSubtotal.AutoSize = true;
			this.lblSubtotal.Location = new System.Drawing.Point(678, 1217);
			this.lblSubtotal.Name = "lblSubtotal";
			this.lblSubtotal.Size = new System.Drawing.Size(97, 25);
			this.lblSubtotal.TabIndex = 1;
			this.lblSubtotal.Text = "Subtotal:";
			// 
			// txtSubtotal
			// 
			this.txtSubtotal.Location = new System.Drawing.Point(814, 1217);
			this.txtSubtotal.Name = "txtSubtotal";
			this.txtSubtotal.Size = new System.Drawing.Size(454, 31);
			this.txtSubtotal.TabIndex = 2;
			// 
			// lblUser
			// 
			this.lblUser.AutoSize = true;
			this.lblUser.Location = new System.Drawing.Point(32, 1153);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(63, 25);
			this.lblUser.TabIndex = 1;
			this.lblUser.Text = "User:";
			// 
			// txtUser
			// 
			this.txtUser.Location = new System.Drawing.Point(168, 1153);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(454, 31);
			this.txtUser.TabIndex = 2;
			// 
			// lblInStockTime
			// 
			this.lblInStockTime.AutoSize = true;
			this.lblInStockTime.Location = new System.Drawing.Point(32, 1085);
			this.lblInStockTime.Name = "lblInStockTime";
			this.lblInStockTime.Size = new System.Drawing.Size(136, 25);
			this.lblInStockTime.TabIndex = 1;
			this.lblInStockTime.Text = "InStockTime:";
			// 
			// cboCategory
			// 
			this.cboCategory.FormattingEnabled = true;
			this.cboCategory.Location = new System.Drawing.Point(168, 1023);
			this.cboCategory.Name = "cboCategory";
			this.cboCategory.Size = new System.Drawing.Size(454, 33);
			this.cboCategory.TabIndex = 10;
			// 
			// lblCategory
			// 
			this.lblCategory.AutoSize = true;
			this.lblCategory.Location = new System.Drawing.Point(27, 1018);
			this.lblCategory.Name = "lblCategory";
			this.lblCategory.Size = new System.Drawing.Size(105, 25);
			this.lblCategory.TabIndex = 8;
			this.lblCategory.Text = "Category:";
			// 
			// txtSupplier
			// 
			this.txtSupplier.Location = new System.Drawing.Point(814, 1025);
			this.txtSupplier.Name = "txtSupplier";
			this.txtSupplier.Size = new System.Drawing.Size(454, 31);
			this.txtSupplier.TabIndex = 11;
			// 
			// lblSupplier
			// 
			this.lblSupplier.AutoSize = true;
			this.lblSupplier.Location = new System.Drawing.Point(678, 1028);
			this.lblSupplier.Name = "lblSupplier";
			this.lblSupplier.Size = new System.Drawing.Size(97, 25);
			this.lblSupplier.TabIndex = 9;
			this.lblSupplier.Text = "Supplier:";
			// 
			// cboProduct
			// 
			this.cboProduct.FormattingEnabled = true;
			this.cboProduct.Location = new System.Drawing.Point(168, 962);
			this.cboProduct.Name = "cboProduct";
			this.cboProduct.Size = new System.Drawing.Size(454, 33);
			this.cboProduct.TabIndex = 12;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(168, 1085);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(454, 31);
			this.dateTimePicker1.TabIndex = 13;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(814, 1085);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(454, 31);
			this.dateTimePicker2.TabIndex = 14;
			// 
			// InventoryQueryEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(2074, 1329);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.cboProduct);
			this.Controls.Add(this.cboCategory);
			this.Controls.Add(this.lblCategory);
			this.Controls.Add(this.txtSupplier);
			this.Controls.Add(this.lblSupplier);
			this.Controls.Add(this.dgvInventory);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtBatch);
			this.Controls.Add(this.lblBatch);
			this.Controls.Add(this.txtCount);
			this.Controls.Add(this.lblCount);
			this.Controls.Add(this.lblProductId);
			this.Controls.Add(this.txtProduct);
			this.Controls.Add(this.lblProductText);
			this.Controls.Add(this.txtSubtotal);
			this.Controls.Add(this.lblSubtotal);
			this.Controls.Add(this.txtUser);
			this.Controls.Add(this.lblUser);
			this.Controls.Add(this.lblInStockTime);
			this.Name = "InventoryQueryEditor";
			this.Text = "InventoryEditor";
			this.Load += new System.EventHandler(this.InventoryEditor_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private System.Windows.Forms.ComboBox cboCategory;
		private System.Windows.Forms.Label lblCategory;
		private System.Windows.Forms.TextBox txtSupplier;
		private System.Windows.Forms.Label lblSupplier;
		private System.Windows.Forms.ComboBox cboProduct;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
	}
}

