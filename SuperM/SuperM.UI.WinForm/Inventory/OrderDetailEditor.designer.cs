
namespace SuperM.UI.WinForm
{
	partial class OrderDetailEditor
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnUpdate;

			private System.Windows.Forms.Label lblOrderDetailId;
			private System.Windows.Forms.TextBox txtOrderDetailId;
			private System.Windows.Forms.Label lblOrderId;
			private System.Windows.Forms.TextBox txtOrderId;
			private System.Windows.Forms.Label lblOrder;
			private System.Windows.Forms.TextBox txtOrder;
			private System.Windows.Forms.Label lblProductId;
			private System.Windows.Forms.TextBox txtProductId;
			private System.Windows.Forms.Label lblProduct;
			private System.Windows.Forms.TextBox txtProduct;
			private System.Windows.Forms.Label lblDiscount;
			private System.Windows.Forms.TextBox txtDiscount;
			private System.Windows.Forms.Label lblPrice;
			private System.Windows.Forms.TextBox txtPrice;
			private System.Windows.Forms.Label lblQuantity;
			private System.Windows.Forms.TextBox txtQuantity;
			private System.Windows.Forms.Label lblNationTax;
			private System.Windows.Forms.TextBox txtNationTax;
			private System.Windows.Forms.Label lblProvinceTax;
			private System.Windows.Forms.TextBox txtProvinceTax;
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
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.lblOrderDetailId = new System.Windows.Forms.Label();
			this.txtOrderDetailId = new System.Windows.Forms.TextBox();
			this.lblOrderId = new System.Windows.Forms.Label();
			this.txtOrderId = new System.Windows.Forms.TextBox();
			this.lblOrder = new System.Windows.Forms.Label();
			this.txtOrder = new System.Windows.Forms.TextBox();
			this.lblProductId = new System.Windows.Forms.Label();
			this.txtProductId = new System.Windows.Forms.TextBox();
			this.lblProduct = new System.Windows.Forms.Label();
			this.txtProduct = new System.Windows.Forms.TextBox();
			this.lblDiscount = new System.Windows.Forms.Label();
			this.txtDiscount = new System.Windows.Forms.TextBox();
			this.lblPrice = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.lblQuantity = new System.Windows.Forms.Label();
			this.txtQuantity = new System.Windows.Forms.TextBox();
			this.lblNationTax = new System.Windows.Forms.Label();
			this.txtNationTax = new System.Windows.Forms.TextBox();
			this.lblProvinceTax = new System.Windows.Forms.Label();
			this.txtProvinceTax = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(1552, 951);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(120, 50);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(1880, 952);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(120, 50);
			this.btnDelete.TabIndex = 5;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(1404, 951);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(120, 50);
			this.btnClear.TabIndex = 6;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
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
			// lblOrderDetailId
			// 
			this.lblOrderDetailId.AutoSize = true;
			this.lblOrderDetailId.Location = new System.Drawing.Point(256, 378);
			this.lblOrderDetailId.Name = "lblOrderDetailId";
			this.lblOrderDetailId.Size = new System.Drawing.Size(144, 25);
			this.lblOrderDetailId.TabIndex = 1;
			this.lblOrderDetailId.Text = "OrderDetailId:";
			// 
			// txtOrderDetailId
			// 
			this.txtOrderDetailId.Location = new System.Drawing.Point(392, 378);
			this.txtOrderDetailId.Name = "txtOrderDetailId";
			this.txtOrderDetailId.Size = new System.Drawing.Size(454, 31);
			this.txtOrderDetailId.TabIndex = 2;
			// 
			// lblOrderId
			// 
			this.lblOrderId.AutoSize = true;
			this.lblOrderId.Location = new System.Drawing.Point(256, 428);
			this.lblOrderId.Name = "lblOrderId";
			this.lblOrderId.Size = new System.Drawing.Size(89, 25);
			this.lblOrderId.TabIndex = 1;
			this.lblOrderId.Text = "OrderId:";
			// 
			// txtOrderId
			// 
			this.txtOrderId.Location = new System.Drawing.Point(392, 428);
			this.txtOrderId.Name = "txtOrderId";
			this.txtOrderId.Size = new System.Drawing.Size(454, 31);
			this.txtOrderId.TabIndex = 2;
			// 
			// lblOrder
			// 
			this.lblOrder.AutoSize = true;
			this.lblOrder.Location = new System.Drawing.Point(256, 478);
			this.lblOrder.Name = "lblOrder";
			this.lblOrder.Size = new System.Drawing.Size(72, 25);
			this.lblOrder.TabIndex = 1;
			this.lblOrder.Text = "Order:";
			// 
			// txtOrder
			// 
			this.txtOrder.Location = new System.Drawing.Point(392, 478);
			this.txtOrder.Name = "txtOrder";
			this.txtOrder.Size = new System.Drawing.Size(454, 31);
			this.txtOrder.TabIndex = 2;
			// 
			// lblProductId
			// 
			this.lblProductId.AutoSize = true;
			this.lblProductId.Location = new System.Drawing.Point(256, 528);
			this.lblProductId.Name = "lblProductId";
			this.lblProductId.Size = new System.Drawing.Size(109, 25);
			this.lblProductId.TabIndex = 1;
			this.lblProductId.Text = "ProductId:";
			// 
			// txtProductId
			// 
			this.txtProductId.Location = new System.Drawing.Point(392, 528);
			this.txtProductId.Name = "txtProductId";
			this.txtProductId.Size = new System.Drawing.Size(454, 31);
			this.txtProductId.TabIndex = 2;
			// 
			// lblProduct
			// 
			this.lblProduct.AutoSize = true;
			this.lblProduct.Location = new System.Drawing.Point(256, 578);
			this.lblProduct.Name = "lblProduct";
			this.lblProduct.Size = new System.Drawing.Size(92, 25);
			this.lblProduct.TabIndex = 1;
			this.lblProduct.Text = "Product:";
			// 
			// txtProduct
			// 
			this.txtProduct.Location = new System.Drawing.Point(392, 578);
			this.txtProduct.Name = "txtProduct";
			this.txtProduct.Size = new System.Drawing.Size(454, 31);
			this.txtProduct.TabIndex = 2;
			// 
			// lblDiscount
			// 
			this.lblDiscount.AutoSize = true;
			this.lblDiscount.Location = new System.Drawing.Point(256, 628);
			this.lblDiscount.Name = "lblDiscount";
			this.lblDiscount.Size = new System.Drawing.Size(102, 25);
			this.lblDiscount.TabIndex = 1;
			this.lblDiscount.Text = "Discount:";
			// 
			// txtDiscount
			// 
			this.txtDiscount.Location = new System.Drawing.Point(392, 628);
			this.txtDiscount.Name = "txtDiscount";
			this.txtDiscount.Size = new System.Drawing.Size(454, 31);
			this.txtDiscount.TabIndex = 2;
			// 
			// lblPrice
			// 
			this.lblPrice.AutoSize = true;
			this.lblPrice.Location = new System.Drawing.Point(256, 678);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new System.Drawing.Size(67, 25);
			this.lblPrice.TabIndex = 1;
			this.lblPrice.Text = "Price:";
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(392, 678);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(454, 31);
			this.txtPrice.TabIndex = 2;
			// 
			// lblQuantity
			// 
			this.lblQuantity.AutoSize = true;
			this.lblQuantity.Location = new System.Drawing.Point(256, 728);
			this.lblQuantity.Name = "lblQuantity";
			this.lblQuantity.Size = new System.Drawing.Size(98, 25);
			this.lblQuantity.TabIndex = 1;
			this.lblQuantity.Text = "Quantity:";
			// 
			// txtQuantity
			// 
			this.txtQuantity.Location = new System.Drawing.Point(392, 728);
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.Size = new System.Drawing.Size(454, 31);
			this.txtQuantity.TabIndex = 2;
			// 
			// lblNationTax
			// 
			this.lblNationTax.AutoSize = true;
			this.lblNationTax.Location = new System.Drawing.Point(256, 778);
			this.lblNationTax.Name = "lblNationTax";
			this.lblNationTax.Size = new System.Drawing.Size(116, 25);
			this.lblNationTax.TabIndex = 1;
			this.lblNationTax.Text = "NationTax:";
			// 
			// txtNationTax
			// 
			this.txtNationTax.Location = new System.Drawing.Point(392, 778);
			this.txtNationTax.Name = "txtNationTax";
			this.txtNationTax.Size = new System.Drawing.Size(454, 31);
			this.txtNationTax.TabIndex = 2;
			// 
			// lblProvinceTax
			// 
			this.lblProvinceTax.AutoSize = true;
			this.lblProvinceTax.Location = new System.Drawing.Point(256, 828);
			this.lblProvinceTax.Name = "lblProvinceTax";
			this.lblProvinceTax.Size = new System.Drawing.Size(138, 25);
			this.lblProvinceTax.TabIndex = 1;
			this.lblProvinceTax.Text = "ProvinceTax:";
			// 
			// txtProvinceTax
			// 
			this.txtProvinceTax.Location = new System.Drawing.Point(392, 828);
			this.txtProvinceTax.Name = "txtProvinceTax";
			this.txtProvinceTax.Size = new System.Drawing.Size(454, 31);
			this.txtProvinceTax.TabIndex = 2;
			// 
			// OrderDetailEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(2074, 1329);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtOrderDetailId);
			this.Controls.Add(this.lblOrderDetailId);
			this.Controls.Add(this.txtOrderId);
			this.Controls.Add(this.lblOrderId);
			this.Controls.Add(this.txtOrder);
			this.Controls.Add(this.lblOrder);
			this.Controls.Add(this.txtProductId);
			this.Controls.Add(this.lblProductId);
			this.Controls.Add(this.txtProduct);
			this.Controls.Add(this.lblProduct);
			this.Controls.Add(this.txtDiscount);
			this.Controls.Add(this.lblDiscount);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.lblPrice);
			this.Controls.Add(this.txtQuantity);
			this.Controls.Add(this.lblQuantity);
			this.Controls.Add(this.txtNationTax);
			this.Controls.Add(this.lblNationTax);
			this.Controls.Add(this.txtProvinceTax);
			this.Controls.Add(this.lblProvinceTax);
			this.Name = "OrderDetailEditor";
			this.Text = "OrderDetailEditor";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}

