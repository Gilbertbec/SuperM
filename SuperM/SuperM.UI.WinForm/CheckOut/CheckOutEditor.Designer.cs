namespace SuperM.UI.WinForm.CheckOut
{
	partial class CheckOutEditor
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtProductId = new System.Windows.Forms.TextBox();
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.txtQuantity = new System.Windows.Forms.TextBox();
			this.lblQuantity = new System.Windows.Forms.Label();
			this.OpenNewOrder = new System.Windows.Forms.Button();
			this.lblOrderId = new System.Windows.Forms.Label();
			this.btnAddProduct = new System.Windows.Forms.Button();
			this.btnRemoveProduct = new System.Windows.Forms.Button();
			this.btnCheckOut = new System.Windows.Forms.Button();
			this.txtOrderId = new System.Windows.Forms.TextBox();
			this.dgvOrder = new System.Windows.Forms.DataGridView();
			this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvInventory
			// 
			this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvInventory.Location = new System.Drawing.Point(-49, 12);
			this.dgvInventory.Name = "dgvInventory";
			this.dgvInventory.RowTemplate.Height = 33;
			this.dgvInventory.Size = new System.Drawing.Size(2000, 513);
			this.dgvInventory.TabIndex = 1;
			this.dgvInventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(76, 690);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "ProductId";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(76, 742);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(142, 25);
			this.label2.TabIndex = 3;
			this.label2.Text = "ProductName";
			// 
			// txtProductId
			// 
			this.txtProductId.Location = new System.Drawing.Point(221, 687);
			this.txtProductId.Name = "txtProductId";
			this.txtProductId.Size = new System.Drawing.Size(100, 31);
			this.txtProductId.TabIndex = 4;
			// 
			// txtProductName
			// 
			this.txtProductName.Location = new System.Drawing.Point(221, 736);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(100, 31);
			this.txtProductName.TabIndex = 5;
			// 
			// txtQuantity
			// 
			this.txtQuantity.Location = new System.Drawing.Point(221, 829);
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.Size = new System.Drawing.Size(100, 31);
			this.txtQuantity.TabIndex = 6;
			// 
			// lblQuantity
			// 
			this.lblQuantity.AutoSize = true;
			this.lblQuantity.Location = new System.Drawing.Point(76, 829);
			this.lblQuantity.Name = "lblQuantity";
			this.lblQuantity.Size = new System.Drawing.Size(92, 25);
			this.lblQuantity.TabIndex = 7;
			this.lblQuantity.Text = "Quantity";
			// 
			// OpenNewOrder
			// 
			this.OpenNewOrder.Location = new System.Drawing.Point(102, 531);
			this.OpenNewOrder.Name = "OpenNewOrder";
			this.OpenNewOrder.Size = new System.Drawing.Size(219, 65);
			this.OpenNewOrder.TabIndex = 8;
			this.OpenNewOrder.Text = "OpenNewOrder";
			this.OpenNewOrder.UseVisualStyleBackColor = true;
			this.OpenNewOrder.Click += new System.EventHandler(this.btnOpenNewOrder);
			// 
			// lblOrderId
			// 
			this.lblOrderId.AutoSize = true;
			this.lblOrderId.Location = new System.Drawing.Point(81, 638);
			this.lblOrderId.Name = "lblOrderId";
			this.lblOrderId.Size = new System.Drawing.Size(111, 25);
			this.lblOrderId.TabIndex = 9;
			this.lblOrderId.Text = "lblOrderId:";
			// 
			// btnAddProduct
			// 
			this.btnAddProduct.Location = new System.Drawing.Point(118, 910);
			this.btnAddProduct.Name = "btnAddProduct";
			this.btnAddProduct.Size = new System.Drawing.Size(203, 63);
			this.btnAddProduct.TabIndex = 10;
			this.btnAddProduct.Text = "Add Product";
			this.btnAddProduct.UseVisualStyleBackColor = true;
			this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
			// 
			// btnRemoveProduct
			// 
			this.btnRemoveProduct.Location = new System.Drawing.Point(118, 993);
			this.btnRemoveProduct.Name = "btnRemoveProduct";
			this.btnRemoveProduct.Size = new System.Drawing.Size(203, 63);
			this.btnRemoveProduct.TabIndex = 11;
			this.btnRemoveProduct.Text = "Remove Product";
			this.btnRemoveProduct.UseVisualStyleBackColor = true;
			this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
			// 
			// btnCheckOut
			// 
			this.btnCheckOut.Location = new System.Drawing.Point(118, 1083);
			this.btnCheckOut.Name = "btnCheckOut";
			this.btnCheckOut.Size = new System.Drawing.Size(203, 63);
			this.btnCheckOut.TabIndex = 12;
			this.btnCheckOut.Text = "Check Out";
			this.btnCheckOut.UseVisualStyleBackColor = true;
			this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
			// 
			// txtOrderId
			// 
			this.txtOrderId.Location = new System.Drawing.Point(221, 638);
			this.txtOrderId.Name = "txtOrderId";
			this.txtOrderId.Size = new System.Drawing.Size(100, 31);
			this.txtOrderId.TabIndex = 13;
			// 
			// dgvOrder
			// 
			this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOrder.Location = new System.Drawing.Point(338, 541);
			this.dgvOrder.Name = "dgvOrder";
			this.dgvOrder.RowTemplate.Height = 33;
			this.dgvOrder.Size = new System.Drawing.Size(1613, 208);
			this.dgvOrder.TabIndex = 14;
			// 
			// dgvOrderDetails
			// 
			this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOrderDetails.Location = new System.Drawing.Point(338, 755);
			this.dgvOrderDetails.Name = "dgvOrderDetails";
			this.dgvOrderDetails.RowTemplate.Height = 33;
			this.dgvOrderDetails.Size = new System.Drawing.Size(1613, 428);
			this.dgvOrderDetails.TabIndex = 15;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(76, 790);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 25);
			this.label3.TabIndex = 16;
			this.label3.Text = "Price";
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(221, 787);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(100, 31);
			this.txtPrice.TabIndex = 17;
			// 
			// CheckOutEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(2087, 1195);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dgvOrderDetails);
			this.Controls.Add(this.dgvOrder);
			this.Controls.Add(this.txtOrderId);
			this.Controls.Add(this.btnCheckOut);
			this.Controls.Add(this.btnRemoveProduct);
			this.Controls.Add(this.btnAddProduct);
			this.Controls.Add(this.lblOrderId);
			this.Controls.Add(this.OpenNewOrder);
			this.Controls.Add(this.lblQuantity);
			this.Controls.Add(this.txtQuantity);
			this.Controls.Add(this.txtProductName);
			this.Controls.Add(this.txtProductId);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvInventory);
			this.Name = "CheckOutEditor";
			this.Text = "CheckOut";
			this.Load += new System.EventHandler(this.CheckOutEditor_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvInventory;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtProductId;
		private System.Windows.Forms.TextBox txtProductName;
		private System.Windows.Forms.TextBox txtQuantity;
		private System.Windows.Forms.Label lblQuantity;
		private System.Windows.Forms.Button OpenNewOrder;
		private System.Windows.Forms.Label lblOrderId;
		private System.Windows.Forms.Button btnAddProduct;
		private System.Windows.Forms.Button btnRemoveProduct;
		private System.Windows.Forms.Button btnCheckOut;
		private System.Windows.Forms.TextBox txtOrderId;
		private System.Windows.Forms.DataGridView dgvOrder;
		private System.Windows.Forms.DataGridView dgvOrderDetails;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPrice;
	}
}