
namespace SuperM.UI.WinForm
{
	partial class InventoryEditor
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
			private System.Windows.Forms.Label lblBatch;
			private System.Windows.Forms.TextBox txtBatch;
			private System.Windows.Forms.Label lblCount;
			private System.Windows.Forms.TextBox txtCount;
			private System.Windows.Forms.Label lblPrice;
			private System.Windows.Forms.TextBox txtPrice;
			private System.Windows.Forms.Label lblProductId;
			private System.Windows.Forms.TextBox txtProductId;
			private System.Windows.Forms.Label lblProduct;
			private System.Windows.Forms.TextBox txtProduct;
			private System.Windows.Forms.Label lblSupplierId;
			private System.Windows.Forms.TextBox txtSupplierId;
			private System.Windows.Forms.Label lblSupplier;
			private System.Windows.Forms.TextBox txtSupplier;
			private System.Windows.Forms.Label lblStockInId;
			private System.Windows.Forms.TextBox txtStockInId;
			private System.Windows.Forms.Label lblStockIn;
			private System.Windows.Forms.TextBox txtStockIn;
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
			this.lblBatch = new System.Windows.Forms.Label();
			this.txtBatch = new System.Windows.Forms.TextBox();
			this.lblCount = new System.Windows.Forms.Label();
			this.txtCount = new System.Windows.Forms.TextBox();
			this.lblPrice = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.lblProductId = new System.Windows.Forms.Label();
			this.txtProductId = new System.Windows.Forms.TextBox();
			this.lblProduct = new System.Windows.Forms.Label();
			this.txtProduct = new System.Windows.Forms.TextBox();
			this.lblSupplierId = new System.Windows.Forms.Label();
			this.txtSupplierId = new System.Windows.Forms.TextBox();
			this.lblSupplier = new System.Windows.Forms.Label();
			this.txtSupplier = new System.Windows.Forms.TextBox();
			this.lblStockInId = new System.Windows.Forms.Label();
			this.txtStockInId = new System.Windows.Forms.TextBox();
			this.lblStockIn = new System.Windows.Forms.Label();
			this.txtStockIn = new System.Windows.Forms.TextBox();
			this.lblInStockTime = new System.Windows.Forms.Label();
			this.txtInStockTime = new System.Windows.Forms.TextBox();
			this.btnOpenNewOrder = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvInventory
			// 
			this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvInventory.Location = new System.Drawing.Point(0, 1);
			this.dgvInventory.Name = "dgvInventory";
			this.dgvInventory.RowTemplate.Height = 33;
			this.dgvInventory.Size = new System.Drawing.Size(2000, 513);
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
			this.lblInventoryId.Location = new System.Drawing.Point(24, 635);
			this.lblInventoryId.Name = "lblInventoryId";
			this.lblInventoryId.Size = new System.Drawing.Size(123, 25);
			this.lblInventoryId.TabIndex = 1;
			this.lblInventoryId.Text = "InventoryId:";
			// 
			// txtInventoryId
			// 
			this.txtInventoryId.Location = new System.Drawing.Point(160, 635);
			this.txtInventoryId.Name = "txtInventoryId";
			this.txtInventoryId.Size = new System.Drawing.Size(454, 31);
			this.txtInventoryId.TabIndex = 2;
			// 
			// lblBatch
			// 
			this.lblBatch.AutoSize = true;
			this.lblBatch.Location = new System.Drawing.Point(24, 685);
			this.lblBatch.Name = "lblBatch";
			this.lblBatch.Size = new System.Drawing.Size(73, 25);
			this.lblBatch.TabIndex = 1;
			this.lblBatch.Text = "Batch:";
			// 
			// txtBatch
			// 
			this.txtBatch.Location = new System.Drawing.Point(160, 685);
			this.txtBatch.Name = "txtBatch";
			this.txtBatch.Size = new System.Drawing.Size(454, 31);
			this.txtBatch.TabIndex = 2;
			// 
			// lblCount
			// 
			this.lblCount.AutoSize = true;
			this.lblCount.Location = new System.Drawing.Point(24, 735);
			this.lblCount.Name = "lblCount";
			this.lblCount.Size = new System.Drawing.Size(75, 25);
			this.lblCount.TabIndex = 1;
			this.lblCount.Text = "Count:";
			// 
			// txtCount
			// 
			this.txtCount.Location = new System.Drawing.Point(160, 735);
			this.txtCount.Name = "txtCount";
			this.txtCount.Size = new System.Drawing.Size(454, 31);
			this.txtCount.TabIndex = 2;
			// 
			// lblPrice
			// 
			this.lblPrice.AutoSize = true;
			this.lblPrice.Location = new System.Drawing.Point(24, 785);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new System.Drawing.Size(67, 25);
			this.lblPrice.TabIndex = 1;
			this.lblPrice.Text = "Price:";
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(160, 785);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(454, 31);
			this.txtPrice.TabIndex = 2;
			// 
			// lblProductId
			// 
			this.lblProductId.AutoSize = true;
			this.lblProductId.Location = new System.Drawing.Point(24, 835);
			this.lblProductId.Name = "lblProductId";
			this.lblProductId.Size = new System.Drawing.Size(109, 25);
			this.lblProductId.TabIndex = 1;
			this.lblProductId.Text = "ProductId:";
			// 
			// txtProductId
			// 
			this.txtProductId.Location = new System.Drawing.Point(160, 835);
			this.txtProductId.Name = "txtProductId";
			this.txtProductId.Size = new System.Drawing.Size(454, 31);
			this.txtProductId.TabIndex = 2;
			// 
			// lblProduct
			// 
			this.lblProduct.AutoSize = true;
			this.lblProduct.Location = new System.Drawing.Point(24, 885);
			this.lblProduct.Name = "lblProduct";
			this.lblProduct.Size = new System.Drawing.Size(92, 25);
			this.lblProduct.TabIndex = 1;
			this.lblProduct.Text = "Product:";
			// 
			// txtProduct
			// 
			this.txtProduct.Location = new System.Drawing.Point(160, 885);
			this.txtProduct.Name = "txtProduct";
			this.txtProduct.Size = new System.Drawing.Size(454, 31);
			this.txtProduct.TabIndex = 2;
			// 
			// lblSupplierId
			// 
			this.lblSupplierId.AutoSize = true;
			this.lblSupplierId.Location = new System.Drawing.Point(24, 935);
			this.lblSupplierId.Name = "lblSupplierId";
			this.lblSupplierId.Size = new System.Drawing.Size(114, 25);
			this.lblSupplierId.TabIndex = 1;
			this.lblSupplierId.Text = "SupplierId:";
			// 
			// txtSupplierId
			// 
			this.txtSupplierId.Location = new System.Drawing.Point(160, 935);
			this.txtSupplierId.Name = "txtSupplierId";
			this.txtSupplierId.Size = new System.Drawing.Size(454, 31);
			this.txtSupplierId.TabIndex = 2;
			// 
			// lblSupplier
			// 
			this.lblSupplier.AutoSize = true;
			this.lblSupplier.Location = new System.Drawing.Point(24, 985);
			this.lblSupplier.Name = "lblSupplier";
			this.lblSupplier.Size = new System.Drawing.Size(97, 25);
			this.lblSupplier.TabIndex = 1;
			this.lblSupplier.Text = "Supplier:";
			// 
			// txtSupplier
			// 
			this.txtSupplier.Location = new System.Drawing.Point(160, 985);
			this.txtSupplier.Name = "txtSupplier";
			this.txtSupplier.Size = new System.Drawing.Size(454, 31);
			this.txtSupplier.TabIndex = 2;
			// 
			// lblStockInId
			// 
			this.lblStockInId.AutoSize = true;
			this.lblStockInId.Location = new System.Drawing.Point(24, 1035);
			this.lblStockInId.Name = "lblStockInId";
			this.lblStockInId.Size = new System.Drawing.Size(106, 25);
			this.lblStockInId.TabIndex = 1;
			this.lblStockInId.Text = "StockInId:";
			// 
			// txtStockInId
			// 
			this.txtStockInId.Location = new System.Drawing.Point(160, 1035);
			this.txtStockInId.Name = "txtStockInId";
			this.txtStockInId.Size = new System.Drawing.Size(454, 31);
			this.txtStockInId.TabIndex = 2;
			// 
			// lblStockIn
			// 
			this.lblStockIn.AutoSize = true;
			this.lblStockIn.Location = new System.Drawing.Point(24, 1085);
			this.lblStockIn.Name = "lblStockIn";
			this.lblStockIn.Size = new System.Drawing.Size(89, 25);
			this.lblStockIn.TabIndex = 1;
			this.lblStockIn.Text = "StockIn:";
			// 
			// txtStockIn
			// 
			this.txtStockIn.Location = new System.Drawing.Point(160, 1085);
			this.txtStockIn.Name = "txtStockIn";
			this.txtStockIn.Size = new System.Drawing.Size(454, 31);
			this.txtStockIn.TabIndex = 2;
			// 
			// lblInStockTime
			// 
			this.lblInStockTime.AutoSize = true;
			this.lblInStockTime.Location = new System.Drawing.Point(24, 1135);
			this.lblInStockTime.Name = "lblInStockTime";
			this.lblInStockTime.Size = new System.Drawing.Size(136, 25);
			this.lblInStockTime.TabIndex = 1;
			this.lblInStockTime.Text = "InStockTime:";
			// 
			// txtInStockTime
			// 
			this.txtInStockTime.Location = new System.Drawing.Point(160, 1135);
			this.txtInStockTime.Name = "txtInStockTime";
			this.txtInStockTime.Size = new System.Drawing.Size(454, 31);
			this.txtInStockTime.TabIndex = 2;
			// 
			// btnOpenNewOrder
			// 
			this.btnOpenNewOrder.Location = new System.Drawing.Point(766, 588);
			this.btnOpenNewOrder.Name = "btnOpenNewOrder";
			this.btnOpenNewOrder.Size = new System.Drawing.Size(280, 97);
			this.btnOpenNewOrder.TabIndex = 8;
			this.btnOpenNewOrder.Text = "OpenNewOrder";
			this.btnOpenNewOrder.UseVisualStyleBackColor = true;
			this.btnOpenNewOrder.Click += new System.EventHandler(this.btnOpenNewOrder_Click);
			// 
			// InventoryEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(2074, 1329);
			this.Controls.Add(this.btnOpenNewOrder);
			this.Controls.Add(this.dgvInventory);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtInventoryId);
			this.Controls.Add(this.lblInventoryId);
			this.Controls.Add(this.txtBatch);
			this.Controls.Add(this.lblBatch);
			this.Controls.Add(this.txtCount);
			this.Controls.Add(this.lblCount);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.lblPrice);
			this.Controls.Add(this.txtProductId);
			this.Controls.Add(this.lblProductId);
			this.Controls.Add(this.txtProduct);
			this.Controls.Add(this.lblProduct);
			this.Controls.Add(this.txtSupplierId);
			this.Controls.Add(this.lblSupplierId);
			this.Controls.Add(this.txtSupplier);
			this.Controls.Add(this.lblSupplier);
			this.Controls.Add(this.txtStockInId);
			this.Controls.Add(this.lblStockInId);
			this.Controls.Add(this.txtStockIn);
			this.Controls.Add(this.lblStockIn);
			this.Controls.Add(this.txtInStockTime);
			this.Controls.Add(this.lblInStockTime);
			this.Name = "InventoryEditor";
			this.Text = "InventoryEditor";
			this.Load += new System.EventHandler(this.InventoryEditor_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private System.Windows.Forms.Button btnOpenNewOrder;
	}
}

