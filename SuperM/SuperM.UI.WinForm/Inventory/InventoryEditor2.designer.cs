
namespace SuperM.UI.WinForm
{
	partial class InventoryEditor2
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

			private System.Windows.Forms.Label lblInventoryId;
			private System.Windows.Forms.TextBox txtInventoryId;
			private System.Windows.Forms.Label lblName;
			private System.Windows.Forms.TextBox txtName;
			private System.Windows.Forms.Label lblCount;
			private System.Windows.Forms.TextBox txtCount;
			private System.Windows.Forms.Label lblProductId;
			private System.Windows.Forms.TextBox txtProductId;
			private System.Windows.Forms.Label lblProduct;
			private System.Windows.Forms.TextBox txtProduct;
			private System.Windows.Forms.Label lblSubtotal;
			private System.Windows.Forms.TextBox txtSubtotal;
			private System.Windows.Forms.Label lblUserId;
			private System.Windows.Forms.TextBox txtUserId;
			private System.Windows.Forms.Label lblUser;
			private System.Windows.Forms.TextBox txtUser;
			private System.Windows.Forms.Label lblInStockTime;
			private System.Windows.Forms.TextBox txtInStockTime;
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
			this.lblInventoryId = new System.Windows.Forms.Label();
			this.txtInventoryId = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblCount = new System.Windows.Forms.Label();
			this.txtCount = new System.Windows.Forms.TextBox();
			this.lblProductId = new System.Windows.Forms.Label();
			this.txtProductId = new System.Windows.Forms.TextBox();
			this.lblProduct = new System.Windows.Forms.Label();
			this.txtProduct = new System.Windows.Forms.TextBox();
			this.lblSubtotal = new System.Windows.Forms.Label();
			this.txtSubtotal = new System.Windows.Forms.TextBox();
			this.lblUserId = new System.Windows.Forms.Label();
			this.txtUserId = new System.Windows.Forms.TextBox();
			this.lblUser = new System.Windows.Forms.Label();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.lblInStockTime = new System.Windows.Forms.Label();
			this.txtInStockTime = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvInventory
			// 
			this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvInventory.Location = new System.Drawing.Point(0, 1);
			this.dgvInventory.Name = "dgvInventory";
			this.dgvInventory.RowTemplate.Height = 33;
			this.dgvInventory.Size = new System.Drawing.Size(2000, 407);
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
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// lblInventoryId
			// 
			this.lblInventoryId.AutoSize = true;
			this.lblInventoryId.Location = new System.Drawing.Point(236, 576);
			this.lblInventoryId.Name = "lblInventoryId";
			this.lblInventoryId.Size = new System.Drawing.Size(123, 25);
			this.lblInventoryId.TabIndex = 1;
			this.lblInventoryId.Text = "InventoryId:";
			// 
			// txtInventoryId
			// 
			this.txtInventoryId.Location = new System.Drawing.Point(372, 576);
			this.txtInventoryId.Name = "txtInventoryId";
			this.txtInventoryId.Size = new System.Drawing.Size(454, 31);
			this.txtInventoryId.TabIndex = 2;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(236, 626);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(74, 25);
			this.lblName.TabIndex = 1;
			this.lblName.Text = "Name:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(372, 626);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(454, 31);
			this.txtName.TabIndex = 2;
			this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
			// 
			// lblCount
			// 
			this.lblCount.AutoSize = true;
			this.lblCount.Location = new System.Drawing.Point(236, 676);
			this.lblCount.Name = "lblCount";
			this.lblCount.Size = new System.Drawing.Size(75, 25);
			this.lblCount.TabIndex = 1;
			this.lblCount.Text = "Count:";
			// 
			// txtCount
			// 
			this.txtCount.Location = new System.Drawing.Point(372, 676);
			this.txtCount.Name = "txtCount";
			this.txtCount.Size = new System.Drawing.Size(454, 31);
			this.txtCount.TabIndex = 2;
			// 
			// lblProductId
			// 
			this.lblProductId.AutoSize = true;
			this.lblProductId.Location = new System.Drawing.Point(236, 726);
			this.lblProductId.Name = "lblProductId";
			this.lblProductId.Size = new System.Drawing.Size(109, 25);
			this.lblProductId.TabIndex = 1;
			this.lblProductId.Text = "ProductId:";
			// 
			// txtProductId
			// 
			this.txtProductId.Location = new System.Drawing.Point(372, 726);
			this.txtProductId.Name = "txtProductId";
			this.txtProductId.Size = new System.Drawing.Size(454, 31);
			this.txtProductId.TabIndex = 2;
			// 
			// lblProduct
			// 
			this.lblProduct.AutoSize = true;
			this.lblProduct.Location = new System.Drawing.Point(236, 776);
			this.lblProduct.Name = "lblProduct";
			this.lblProduct.Size = new System.Drawing.Size(92, 25);
			this.lblProduct.TabIndex = 1;
			this.lblProduct.Text = "Product:";
			// 
			// txtProduct
			// 
			this.txtProduct.Location = new System.Drawing.Point(372, 776);
			this.txtProduct.Name = "txtProduct";
			this.txtProduct.Size = new System.Drawing.Size(454, 31);
			this.txtProduct.TabIndex = 2;
			// 
			// lblSubtotal
			// 
			this.lblSubtotal.AutoSize = true;
			this.lblSubtotal.Location = new System.Drawing.Point(236, 826);
			this.lblSubtotal.Name = "lblSubtotal";
			this.lblSubtotal.Size = new System.Drawing.Size(97, 25);
			this.lblSubtotal.TabIndex = 1;
			this.lblSubtotal.Text = "Subtotal:";
			// 
			// txtSubtotal
			// 
			this.txtSubtotal.Location = new System.Drawing.Point(372, 826);
			this.txtSubtotal.Name = "txtSubtotal";
			this.txtSubtotal.Size = new System.Drawing.Size(454, 31);
			this.txtSubtotal.TabIndex = 2;
			// 
			// lblUserId
			// 
			this.lblUserId.AutoSize = true;
			this.lblUserId.Location = new System.Drawing.Point(236, 876);
			this.lblUserId.Name = "lblUserId";
			this.lblUserId.Size = new System.Drawing.Size(80, 25);
			this.lblUserId.TabIndex = 1;
			this.lblUserId.Text = "UserId:";
			// 
			// txtUserId
			// 
			this.txtUserId.Location = new System.Drawing.Point(372, 876);
			this.txtUserId.Name = "txtUserId";
			this.txtUserId.Size = new System.Drawing.Size(454, 31);
			this.txtUserId.TabIndex = 2;
			// 
			// lblUser
			// 
			this.lblUser.AutoSize = true;
			this.lblUser.Location = new System.Drawing.Point(236, 926);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(63, 25);
			this.lblUser.TabIndex = 1;
			this.lblUser.Text = "User:";
			// 
			// txtUser
			// 
			this.txtUser.Location = new System.Drawing.Point(372, 926);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(454, 31);
			this.txtUser.TabIndex = 2;
			// 
			// lblInStockTime
			// 
			this.lblInStockTime.AutoSize = true;
			this.lblInStockTime.Location = new System.Drawing.Point(236, 976);
			this.lblInStockTime.Name = "lblInStockTime";
			this.lblInStockTime.Size = new System.Drawing.Size(136, 25);
			this.lblInStockTime.TabIndex = 1;
			this.lblInStockTime.Text = "InStockTime:";
			// 
			// txtInStockTime
			// 
			this.txtInStockTime.Location = new System.Drawing.Point(372, 976);
			this.txtInStockTime.Name = "txtInStockTime";
			this.txtInStockTime.Size = new System.Drawing.Size(454, 31);
			this.txtInStockTime.TabIndex = 2;
			// 
			// InventoryEditor2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(2074, 1329);
			this.Controls.Add(this.dgvInventory);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtInventoryId);
			this.Controls.Add(this.lblInventoryId);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.txtCount);
			this.Controls.Add(this.lblCount);
			this.Controls.Add(this.txtProductId);
			this.Controls.Add(this.lblProductId);
			this.Controls.Add(this.txtProduct);
			this.Controls.Add(this.lblProduct);
			this.Controls.Add(this.txtSubtotal);
			this.Controls.Add(this.lblSubtotal);
			this.Controls.Add(this.txtUserId);
			this.Controls.Add(this.lblUserId);
			this.Controls.Add(this.txtUser);
			this.Controls.Add(this.lblUser);
			this.Controls.Add(this.txtInStockTime);
			this.Controls.Add(this.lblInStockTime);
			this.Name = "InventoryEditor2";
			this.Text = "InventoryEditor";
			this.Load += new System.EventHandler(this.InventoryEditor_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}

