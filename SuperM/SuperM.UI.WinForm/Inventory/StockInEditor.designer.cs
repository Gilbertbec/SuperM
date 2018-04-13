
namespace SuperM.UI.WinForm
{
	partial class StockInEditor
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
			this.txtProductId = new System.Windows.Forms.TextBox();
			this.dgvProduct = new System.Windows.Forms.DataGridView();
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSpecification = new System.Windows.Forms.TextBox();
			this.lblSpecification = new System.Windows.Forms.Label();
			this.txtCategoryId = new System.Windows.Forms.TextBox();
			this.lblCategoryId = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.lblDescription = new System.Windows.Forms.Label();
			this.txtPurchasedPrice = new System.Windows.Forms.TextBox();
			this.lblPurchasedPrice = new System.Windows.Forms.Label();
			this.txtSellingPrice = new System.Windows.Forms.TextBox();
			this.lblSellingPrice = new System.Windows.Forms.Label();
			this.txtSupplierId = new System.Windows.Forms.TextBox();
			this.lblSupplierId = new System.Windows.Forms.Label();
			this.txtExpirationDate = new System.Windows.Forms.TextBox();
			this.lblExpirationDate = new System.Windows.Forms.Label();
			this.txtPurchasedDate = new System.Windows.Forms.TextBox();
			this.lblPurchasedDate = new System.Windows.Forms.Label();
			this.txtSubtotal = new System.Windows.Forms.TextBox();
			this.lblSubtotal = new System.Windows.Forms.Label();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.lblUser = new System.Windows.Forms.Label();
			this.lblInStockTime = new System.Windows.Forms.Label();
			this.dtpInStockTime = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvInventory
			// 
			this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvInventory.Location = new System.Drawing.Point(1307, 1);
			this.dgvInventory.Name = "dgvInventory";
			this.dgvInventory.RowTemplate.Height = 33;
			this.dgvInventory.Size = new System.Drawing.Size(1203, 917);
			this.dgvInventory.TabIndex = 0;
			this.dgvInventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellClick);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(1993, 1205);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(119, 51);
			this.btnAdd.TabIndex = 12;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(2391, 1205);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(119, 51);
			this.btnDelete.TabIndex = 14;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(1793, 1205);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(119, 52);
			this.btnClear.TabIndex = 11;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Enabled = false;
			this.btnUpdate.Location = new System.Drawing.Point(2187, 1205);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(119, 51);
			this.btnUpdate.TabIndex = 13;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// lblBatch
			// 
			this.lblBatch.AutoSize = true;
			this.lblBatch.Location = new System.Drawing.Point(1354, 994);
			this.lblBatch.Name = "lblBatch";
			this.lblBatch.Size = new System.Drawing.Size(73, 25);
			this.lblBatch.TabIndex = 1;
			this.lblBatch.Text = "Batch:";
			// 
			// txtBatch
			// 
			this.txtBatch.Location = new System.Drawing.Point(1460, 994);
			this.txtBatch.Name = "txtBatch";
			this.txtBatch.Size = new System.Drawing.Size(454, 31);
			this.txtBatch.TabIndex = 10;
			this.txtBatch.TextChanged += new System.EventHandler(this.txtName_TextChanged);
			// 
			// lblCount
			// 
			this.lblCount.AutoSize = true;
			this.lblCount.Location = new System.Drawing.Point(1354, 1044);
			this.lblCount.Name = "lblCount";
			this.lblCount.Size = new System.Drawing.Size(75, 25);
			this.lblCount.TabIndex = 1;
			this.lblCount.Text = "Count:";
			// 
			// txtCount
			// 
			this.txtCount.Location = new System.Drawing.Point(1460, 1044);
			this.txtCount.Name = "txtCount";
			this.txtCount.Size = new System.Drawing.Size(454, 31);
			this.txtCount.TabIndex = 11;
			this.txtCount.TextChanged += new System.EventHandler(this.txtCount_TextChanged);
			// 
			// lblProductId
			// 
			this.lblProductId.AutoSize = true;
			this.lblProductId.Location = new System.Drawing.Point(1348, 944);
			this.lblProductId.Name = "lblProductId";
			this.lblProductId.Size = new System.Drawing.Size(109, 25);
			this.lblProductId.TabIndex = 1;
			this.lblProductId.Text = "ProductId:";
			// 
			// txtProductId
			// 
			this.txtProductId.Location = new System.Drawing.Point(1460, 938);
			this.txtProductId.Name = "txtProductId";
			this.txtProductId.Size = new System.Drawing.Size(454, 31);
			this.txtProductId.TabIndex = 9;
			this.txtProductId.TextChanged += new System.EventHandler(this.txtProductId_TextChanged);
			// 
			// dgvProduct
			// 
			this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProduct.Location = new System.Drawing.Point(-9, 1);
			this.dgvProduct.Name = "dgvProduct";
			this.dgvProduct.RowTemplate.Height = 33;
			this.dgvProduct.Size = new System.Drawing.Size(1310, 917);
			this.dgvProduct.TabIndex = 8;
			this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
			// 
			// txtProductName
			// 
			this.txtProductName.Location = new System.Drawing.Point(188, 941);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(454, 31);
			this.txtProductName.TabIndex = 0;
			this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 944);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(148, 25);
			this.label2.TabIndex = 13;
			this.label2.Text = "ProductName:";
			// 
			// txtSpecification
			// 
			this.txtSpecification.Location = new System.Drawing.Point(188, 991);
			this.txtSpecification.Name = "txtSpecification";
			this.txtSpecification.Size = new System.Drawing.Size(454, 31);
			this.txtSpecification.TabIndex = 2;
			// 
			// lblSpecification
			// 
			this.lblSpecification.AutoSize = true;
			this.lblSpecification.Location = new System.Drawing.Point(12, 994);
			this.lblSpecification.Name = "lblSpecification";
			this.lblSpecification.Size = new System.Drawing.Size(141, 25);
			this.lblSpecification.TabIndex = 14;
			this.lblSpecification.Text = "Specification:";
			// 
			// txtCategoryId
			// 
			this.txtCategoryId.Location = new System.Drawing.Point(188, 1041);
			this.txtCategoryId.Name = "txtCategoryId";
			this.txtCategoryId.Size = new System.Drawing.Size(454, 31);
			this.txtCategoryId.TabIndex = 4;
			// 
			// lblCategoryId
			// 
			this.lblCategoryId.AutoSize = true;
			this.lblCategoryId.Location = new System.Drawing.Point(12, 1044);
			this.lblCategoryId.Name = "lblCategoryId";
			this.lblCategoryId.Size = new System.Drawing.Size(122, 25);
			this.lblCategoryId.TabIndex = 15;
			this.lblCategoryId.Text = "CategoryId:";
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(188, 1091);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(454, 31);
			this.txtDescription.TabIndex = 6;
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Location = new System.Drawing.Point(12, 1094);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(126, 25);
			this.lblDescription.TabIndex = 16;
			this.lblDescription.Text = "Description:";
			// 
			// txtPurchasedPrice
			// 
			this.txtPurchasedPrice.Location = new System.Drawing.Point(188, 1141);
			this.txtPurchasedPrice.Name = "txtPurchasedPrice";
			this.txtPurchasedPrice.Size = new System.Drawing.Size(454, 31);
			this.txtPurchasedPrice.TabIndex = 8;
			// 
			// lblPurchasedPrice
			// 
			this.lblPurchasedPrice.AutoSize = true;
			this.lblPurchasedPrice.Location = new System.Drawing.Point(12, 1144);
			this.lblPurchasedPrice.Name = "lblPurchasedPrice";
			this.lblPurchasedPrice.Size = new System.Drawing.Size(170, 25);
			this.lblPurchasedPrice.TabIndex = 17;
			this.lblPurchasedPrice.Text = "PurchasedPrice:";
			// 
			// txtSellingPrice
			// 
			this.txtSellingPrice.Location = new System.Drawing.Point(847, 941);
			this.txtSellingPrice.Name = "txtSellingPrice";
			this.txtSellingPrice.Size = new System.Drawing.Size(454, 31);
			this.txtSellingPrice.TabIndex = 1;
			// 
			// lblSellingPrice
			// 
			this.lblSellingPrice.AutoSize = true;
			this.lblSellingPrice.Location = new System.Drawing.Point(675, 944);
			this.lblSellingPrice.Name = "lblSellingPrice";
			this.lblSellingPrice.Size = new System.Drawing.Size(132, 25);
			this.lblSellingPrice.TabIndex = 24;
			this.lblSellingPrice.Text = "SellingPrice:";
			// 
			// txtSupplierId
			// 
			this.txtSupplierId.Location = new System.Drawing.Point(847, 991);
			this.txtSupplierId.Name = "txtSupplierId";
			this.txtSupplierId.Size = new System.Drawing.Size(454, 31);
			this.txtSupplierId.TabIndex = 3;
			// 
			// lblSupplierId
			// 
			this.lblSupplierId.AutoSize = true;
			this.lblSupplierId.Location = new System.Drawing.Point(675, 994);
			this.lblSupplierId.Name = "lblSupplierId";
			this.lblSupplierId.Size = new System.Drawing.Size(114, 25);
			this.lblSupplierId.TabIndex = 25;
			this.lblSupplierId.Text = "SupplierId:";
			// 
			// txtExpirationDate
			// 
			this.txtExpirationDate.Location = new System.Drawing.Point(847, 1041);
			this.txtExpirationDate.Name = "txtExpirationDate";
			this.txtExpirationDate.Size = new System.Drawing.Size(454, 31);
			this.txtExpirationDate.TabIndex = 5;
			// 
			// lblExpirationDate
			// 
			this.lblExpirationDate.AutoSize = true;
			this.lblExpirationDate.Location = new System.Drawing.Point(675, 1044);
			this.lblExpirationDate.Name = "lblExpirationDate";
			this.lblExpirationDate.Size = new System.Drawing.Size(159, 25);
			this.lblExpirationDate.TabIndex = 26;
			this.lblExpirationDate.Text = "ExpirationDate:";
			// 
			// txtPurchasedDate
			// 
			this.txtPurchasedDate.Location = new System.Drawing.Point(847, 1091);
			this.txtPurchasedDate.Name = "txtPurchasedDate";
			this.txtPurchasedDate.Size = new System.Drawing.Size(454, 31);
			this.txtPurchasedDate.TabIndex = 7;
			// 
			// lblPurchasedDate
			// 
			this.lblPurchasedDate.AutoSize = true;
			this.lblPurchasedDate.Location = new System.Drawing.Point(675, 1094);
			this.lblPurchasedDate.Name = "lblPurchasedDate";
			this.lblPurchasedDate.Size = new System.Drawing.Size(166, 25);
			this.lblPurchasedDate.TabIndex = 27;
			this.lblPurchasedDate.Text = "PurchasedDate:";
			// 
			// txtSubtotal
			// 
			this.txtSubtotal.Location = new System.Drawing.Point(2056, 941);
			this.txtSubtotal.Name = "txtSubtotal";
			this.txtSubtotal.Size = new System.Drawing.Size(454, 31);
			this.txtSubtotal.TabIndex = 32;
			// 
			// lblSubtotal
			// 
			this.lblSubtotal.AutoSize = true;
			this.lblSubtotal.Location = new System.Drawing.Point(1920, 941);
			this.lblSubtotal.Name = "lblSubtotal";
			this.lblSubtotal.Size = new System.Drawing.Size(97, 25);
			this.lblSubtotal.TabIndex = 28;
			this.lblSubtotal.Text = "Subtotal:";
			// 
			// txtUser
			// 
			this.txtUser.Location = new System.Drawing.Point(2056, 994);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(454, 31);
			this.txtUser.TabIndex = 34;
			// 
			// lblUser
			// 
			this.lblUser.AutoSize = true;
			this.lblUser.Location = new System.Drawing.Point(1920, 994);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(63, 25);
			this.lblUser.TabIndex = 30;
			this.lblUser.Text = "User:";
			// 
			// lblInStockTime
			// 
			this.lblInStockTime.AutoSize = true;
			this.lblInStockTime.Location = new System.Drawing.Point(1920, 1044);
			this.lblInStockTime.Name = "lblInStockTime";
			this.lblInStockTime.Size = new System.Drawing.Size(136, 25);
			this.lblInStockTime.TabIndex = 31;
			this.lblInStockTime.Text = "InStockTime:";
			// 
			// dtpInStockTime
			// 
			this.dtpInStockTime.Location = new System.Drawing.Point(2056, 1044);
			this.dtpInStockTime.Name = "dtpInStockTime";
			this.dtpInStockTime.Size = new System.Drawing.Size(454, 31);
			this.dtpInStockTime.TabIndex = 35;
			// 
			// StockInEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(2522, 1268);
			this.Controls.Add(this.dtpInStockTime);
			this.Controls.Add(this.txtSubtotal);
			this.Controls.Add(this.lblSubtotal);
			this.Controls.Add(this.txtUser);
			this.Controls.Add(this.lblUser);
			this.Controls.Add(this.lblInStockTime);
			this.Controls.Add(this.txtSellingPrice);
			this.Controls.Add(this.lblSellingPrice);
			this.Controls.Add(this.txtSupplierId);
			this.Controls.Add(this.lblSupplierId);
			this.Controls.Add(this.txtExpirationDate);
			this.Controls.Add(this.lblExpirationDate);
			this.Controls.Add(this.txtPurchasedDate);
			this.Controls.Add(this.lblPurchasedDate);
			this.Controls.Add(this.txtProductName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtSpecification);
			this.Controls.Add(this.lblSpecification);
			this.Controls.Add(this.txtCategoryId);
			this.Controls.Add(this.lblCategoryId);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.lblDescription);
			this.Controls.Add(this.txtPurchasedPrice);
			this.Controls.Add(this.lblPurchasedPrice);
			this.Controls.Add(this.dgvProduct);
			this.Controls.Add(this.dgvInventory);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtBatch);
			this.Controls.Add(this.lblBatch);
			this.Controls.Add(this.txtCount);
			this.Controls.Add(this.lblCount);
			this.Controls.Add(this.txtProductId);
			this.Controls.Add(this.lblProductId);
			this.Name = "StockInEditor";
			this.Text = "StockInEditor";
			this.Load += new System.EventHandler(this.InventoryEditor_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

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
		private System.Windows.Forms.TextBox txtProductId;
		private System.Windows.Forms.DataGridView dgvProduct;
		private System.Windows.Forms.TextBox txtProductName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSpecification;
		private System.Windows.Forms.Label lblSpecification;
		private System.Windows.Forms.TextBox txtCategoryId;
		private System.Windows.Forms.Label lblCategoryId;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.TextBox txtPurchasedPrice;
		private System.Windows.Forms.Label lblPurchasedPrice;
		private System.Windows.Forms.TextBox txtSellingPrice;
		private System.Windows.Forms.Label lblSellingPrice;
		private System.Windows.Forms.TextBox txtSupplierId;
		private System.Windows.Forms.Label lblSupplierId;
		private System.Windows.Forms.TextBox txtExpirationDate;
		private System.Windows.Forms.Label lblExpirationDate;
		private System.Windows.Forms.TextBox txtPurchasedDate;
		private System.Windows.Forms.Label lblPurchasedDate;
		private System.Windows.Forms.TextBox txtSubtotal;
		private System.Windows.Forms.Label lblSubtotal;
		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.Label lblUser;
		private System.Windows.Forms.Label lblInStockTime;
		private System.Windows.Forms.DateTimePicker dtpInStockTime;
	}
}
