namespace SuperM.UI.WinForm.CheckOut
{
	partial class Receipt
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
			this.txtOrderId = new System.Windows.Forms.TextBox();
			this.lblOrderId = new System.Windows.Forms.Label();
			this.txtUserId = new System.Windows.Forms.TextBox();
			this.lblUserId = new System.Windows.Forms.Label();
			this.txtOrderTime = new System.Windows.Forms.TextBox();
			this.lblOrderTime = new System.Windows.Forms.Label();
			this.txtGrossTotal = new System.Windows.Forms.TextBox();
			this.lblGrossTotal = new System.Windows.Forms.Label();
			this.txtNationTax = new System.Windows.Forms.TextBox();
			this.lblNationTax = new System.Windows.Forms.Label();
			this.txtProvinceTax = new System.Windows.Forms.TextBox();
			this.lblProvinceTax = new System.Windows.Forms.Label();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.lblTotal = new System.Windows.Forms.Label();
			this.txtOrderDetails = new System.Windows.Forms.TextBox();
			this.lblOrderDetails = new System.Windows.Forms.Label();
			this.txtOrderDetailId = new System.Windows.Forms.TextBox();
			this.lblOrderDetailId = new System.Windows.Forms.Label();
			this.txtProductId = new System.Windows.Forms.TextBox();
			this.lblProductId = new System.Windows.Forms.Label();
			this.txtProduct = new System.Windows.Forms.TextBox();
			this.lblProduct = new System.Windows.Forms.Label();
			this.txtDiscount = new System.Windows.Forms.TextBox();
			this.lblDiscount = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.lblPrice = new System.Windows.Forms.Label();
			this.txtQuantity = new System.Windows.Forms.TextBox();
			this.lblQuantity = new System.Windows.Forms.Label();
			this.txtNationTaxDetail = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtProvinceTaxDetail = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dgvOrder = new System.Windows.Forms.DataGridView();
			this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
			this.SuspendLayout();
			// 
			// txtOrderId
			// 
			this.txtOrderId.Location = new System.Drawing.Point(264, 739);
			this.txtOrderId.Name = "txtOrderId";
			this.txtOrderId.Size = new System.Drawing.Size(454, 31);
			this.txtOrderId.TabIndex = 11;
			// 
			// lblOrderId
			// 
			this.lblOrderId.AutoSize = true;
			this.lblOrderId.Location = new System.Drawing.Point(128, 739);
			this.lblOrderId.Name = "lblOrderId";
			this.lblOrderId.Size = new System.Drawing.Size(89, 25);
			this.lblOrderId.TabIndex = 3;
			this.lblOrderId.Text = "OrderId:";
			// 
			// txtUserId
			// 
			this.txtUserId.Location = new System.Drawing.Point(264, 789);
			this.txtUserId.Name = "txtUserId";
			this.txtUserId.Size = new System.Drawing.Size(454, 31);
			this.txtUserId.TabIndex = 12;
			// 
			// lblUserId
			// 
			this.lblUserId.AutoSize = true;
			this.lblUserId.Location = new System.Drawing.Point(128, 789);
			this.lblUserId.Name = "lblUserId";
			this.lblUserId.Size = new System.Drawing.Size(80, 25);
			this.lblUserId.TabIndex = 4;
			this.lblUserId.Text = "UserId:";
			// 
			// txtOrderTime
			// 
			this.txtOrderTime.Location = new System.Drawing.Point(264, 839);
			this.txtOrderTime.Name = "txtOrderTime";
			this.txtOrderTime.Size = new System.Drawing.Size(454, 31);
			this.txtOrderTime.TabIndex = 13;
			// 
			// lblOrderTime
			// 
			this.lblOrderTime.AutoSize = true;
			this.lblOrderTime.Location = new System.Drawing.Point(128, 839);
			this.lblOrderTime.Name = "lblOrderTime";
			this.lblOrderTime.Size = new System.Drawing.Size(119, 25);
			this.lblOrderTime.TabIndex = 5;
			this.lblOrderTime.Text = "OrderTime:";
			// 
			// txtGrossTotal
			// 
			this.txtGrossTotal.Location = new System.Drawing.Point(264, 889);
			this.txtGrossTotal.Name = "txtGrossTotal";
			this.txtGrossTotal.Size = new System.Drawing.Size(454, 31);
			this.txtGrossTotal.TabIndex = 14;
			// 
			// lblGrossTotal
			// 
			this.lblGrossTotal.AutoSize = true;
			this.lblGrossTotal.Location = new System.Drawing.Point(128, 889);
			this.lblGrossTotal.Name = "lblGrossTotal";
			this.lblGrossTotal.Size = new System.Drawing.Size(123, 25);
			this.lblGrossTotal.TabIndex = 6;
			this.lblGrossTotal.Text = "GrossTotal:";
			// 
			// txtNationTax
			// 
			this.txtNationTax.Location = new System.Drawing.Point(264, 939);
			this.txtNationTax.Name = "txtNationTax";
			this.txtNationTax.Size = new System.Drawing.Size(454, 31);
			this.txtNationTax.TabIndex = 15;
			// 
			// lblNationTax
			// 
			this.lblNationTax.AutoSize = true;
			this.lblNationTax.Location = new System.Drawing.Point(128, 939);
			this.lblNationTax.Name = "lblNationTax";
			this.lblNationTax.Size = new System.Drawing.Size(116, 25);
			this.lblNationTax.TabIndex = 7;
			this.lblNationTax.Text = "NationTax:";
			// 
			// txtProvinceTax
			// 
			this.txtProvinceTax.Location = new System.Drawing.Point(264, 989);
			this.txtProvinceTax.Name = "txtProvinceTax";
			this.txtProvinceTax.Size = new System.Drawing.Size(454, 31);
			this.txtProvinceTax.TabIndex = 16;
			// 
			// lblProvinceTax
			// 
			this.lblProvinceTax.AutoSize = true;
			this.lblProvinceTax.Location = new System.Drawing.Point(128, 989);
			this.lblProvinceTax.Name = "lblProvinceTax";
			this.lblProvinceTax.Size = new System.Drawing.Size(138, 25);
			this.lblProvinceTax.TabIndex = 8;
			this.lblProvinceTax.Text = "ProvinceTax:";
			// 
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(264, 1039);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(454, 31);
			this.txtTotal.TabIndex = 17;
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Location = new System.Drawing.Point(128, 1039);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(66, 25);
			this.lblTotal.TabIndex = 9;
			this.lblTotal.Text = "Total:";
			// 
			// txtOrderDetails
			// 
			this.txtOrderDetails.Location = new System.Drawing.Point(264, 1089);
			this.txtOrderDetails.Name = "txtOrderDetails";
			this.txtOrderDetails.Size = new System.Drawing.Size(454, 31);
			this.txtOrderDetails.TabIndex = 18;
			// 
			// lblOrderDetails
			// 
			this.lblOrderDetails.AutoSize = true;
			this.lblOrderDetails.Location = new System.Drawing.Point(128, 1089);
			this.lblOrderDetails.Name = "lblOrderDetails";
			this.lblOrderDetails.Size = new System.Drawing.Size(138, 25);
			this.lblOrderDetails.TabIndex = 10;
			this.lblOrderDetails.Text = "OrderDetails:";
			// 
			// txtOrderDetailId
			// 
			this.txtOrderDetailId.Location = new System.Drawing.Point(1117, 733);
			this.txtOrderDetailId.Name = "txtOrderDetailId";
			this.txtOrderDetailId.Size = new System.Drawing.Size(454, 31);
			this.txtOrderDetailId.TabIndex = 38;
			// 
			// lblOrderDetailId
			// 
			this.lblOrderDetailId.AutoSize = true;
			this.lblOrderDetailId.Location = new System.Drawing.Point(981, 733);
			this.lblOrderDetailId.Name = "lblOrderDetailId";
			this.lblOrderDetailId.Size = new System.Drawing.Size(144, 25);
			this.lblOrderDetailId.TabIndex = 28;
			this.lblOrderDetailId.Text = "OrderDetailId:";
			// 
			// txtProductId
			// 
			this.txtProductId.Location = new System.Drawing.Point(1117, 783);
			this.txtProductId.Name = "txtProductId";
			this.txtProductId.Size = new System.Drawing.Size(454, 31);
			this.txtProductId.TabIndex = 37;
			// 
			// lblProductId
			// 
			this.lblProductId.AutoSize = true;
			this.lblProductId.Location = new System.Drawing.Point(981, 783);
			this.lblProductId.Name = "lblProductId";
			this.lblProductId.Size = new System.Drawing.Size(109, 25);
			this.lblProductId.TabIndex = 24;
			this.lblProductId.Text = "ProductId:";
			// 
			// txtProduct
			// 
			this.txtProduct.Location = new System.Drawing.Point(1117, 833);
			this.txtProduct.Name = "txtProduct";
			this.txtProduct.Size = new System.Drawing.Size(454, 31);
			this.txtProduct.TabIndex = 29;
			// 
			// lblProduct
			// 
			this.lblProduct.AutoSize = true;
			this.lblProduct.Location = new System.Drawing.Point(981, 833);
			this.lblProduct.Name = "lblProduct";
			this.lblProduct.Size = new System.Drawing.Size(92, 25);
			this.lblProduct.TabIndex = 19;
			this.lblProduct.Text = "Product:";
			// 
			// txtDiscount
			// 
			this.txtDiscount.Location = new System.Drawing.Point(1117, 883);
			this.txtDiscount.Name = "txtDiscount";
			this.txtDiscount.Size = new System.Drawing.Size(454, 31);
			this.txtDiscount.TabIndex = 31;
			// 
			// lblDiscount
			// 
			this.lblDiscount.AutoSize = true;
			this.lblDiscount.Location = new System.Drawing.Point(981, 883);
			this.lblDiscount.Name = "lblDiscount";
			this.lblDiscount.Size = new System.Drawing.Size(102, 25);
			this.lblDiscount.TabIndex = 23;
			this.lblDiscount.Text = "Discount:";
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(1117, 933);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(454, 31);
			this.txtPrice.TabIndex = 33;
			// 
			// lblPrice
			// 
			this.lblPrice.AutoSize = true;
			this.lblPrice.Location = new System.Drawing.Point(981, 933);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new System.Drawing.Size(67, 25);
			this.lblPrice.TabIndex = 22;
			this.lblPrice.Text = "Price:";
			// 
			// txtQuantity
			// 
			this.txtQuantity.Location = new System.Drawing.Point(1117, 983);
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.Size = new System.Drawing.Size(454, 31);
			this.txtQuantity.TabIndex = 34;
			// 
			// lblQuantity
			// 
			this.lblQuantity.AutoSize = true;
			this.lblQuantity.Location = new System.Drawing.Point(981, 983);
			this.lblQuantity.Name = "lblQuantity";
			this.lblQuantity.Size = new System.Drawing.Size(98, 25);
			this.lblQuantity.TabIndex = 21;
			this.lblQuantity.Text = "Quantity:";
			// 
			// txtNationTaxDetail
			// 
			this.txtNationTaxDetail.Location = new System.Drawing.Point(1117, 1033);
			this.txtNationTaxDetail.Name = "txtNationTaxDetail";
			this.txtNationTaxDetail.Size = new System.Drawing.Size(454, 31);
			this.txtNationTaxDetail.TabIndex = 36;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(981, 1033);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(116, 25);
			this.label2.TabIndex = 20;
			this.label2.Text = "NationTax:";
			// 
			// txtProvinceTaxDetail
			// 
			this.txtProvinceTaxDetail.Location = new System.Drawing.Point(1117, 1083);
			this.txtProvinceTaxDetail.Name = "txtProvinceTaxDetail";
			this.txtProvinceTaxDetail.Size = new System.Drawing.Size(454, 31);
			this.txtProvinceTaxDetail.TabIndex = 30;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(981, 1083);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(138, 25);
			this.label3.TabIndex = 25;
			this.label3.Text = "ProvinceTax:";
			// 
			// dgvOrder
			// 
			this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOrder.Location = new System.Drawing.Point(17, 67);
			this.dgvOrder.Name = "dgvOrder";
			this.dgvOrder.RowTemplate.Height = 33;
			this.dgvOrder.Size = new System.Drawing.Size(1612, 220);
			this.dgvOrder.TabIndex = 39;
			// 
			// dgvOrderDetails
			// 
			this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOrderDetails.Location = new System.Drawing.Point(17, 308);
			this.dgvOrderDetails.Name = "dgvOrderDetails";
			this.dgvOrderDetails.RowTemplate.Height = 33;
			this.dgvOrderDetails.Size = new System.Drawing.Size(1612, 403);
			this.dgvOrderDetails.TabIndex = 40;
			// 
			// Receipt
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1641, 1220);
			this.Controls.Add(this.dgvOrderDetails);
			this.Controls.Add(this.dgvOrder);
			this.Controls.Add(this.txtOrderDetailId);
			this.Controls.Add(this.lblOrderDetailId);
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
			this.Controls.Add(this.txtNationTaxDetail);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtProvinceTaxDetail);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtOrderId);
			this.Controls.Add(this.lblOrderId);
			this.Controls.Add(this.txtUserId);
			this.Controls.Add(this.lblUserId);
			this.Controls.Add(this.txtOrderTime);
			this.Controls.Add(this.lblOrderTime);
			this.Controls.Add(this.txtGrossTotal);
			this.Controls.Add(this.lblGrossTotal);
			this.Controls.Add(this.txtNationTax);
			this.Controls.Add(this.lblNationTax);
			this.Controls.Add(this.txtProvinceTax);
			this.Controls.Add(this.lblProvinceTax);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.txtOrderDetails);
			this.Controls.Add(this.lblOrderDetails);
			this.Name = "Receipt";
			this.Text = "Receipt";
			((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtOrderId;
		private System.Windows.Forms.Label lblOrderId;
		private System.Windows.Forms.TextBox txtUserId;
		private System.Windows.Forms.Label lblUserId;
		private System.Windows.Forms.TextBox txtOrderTime;
		private System.Windows.Forms.Label lblOrderTime;
		private System.Windows.Forms.TextBox txtGrossTotal;
		private System.Windows.Forms.Label lblGrossTotal;
		private System.Windows.Forms.TextBox txtNationTax;
		private System.Windows.Forms.Label lblNationTax;
		private System.Windows.Forms.TextBox txtProvinceTax;
		private System.Windows.Forms.Label lblProvinceTax;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.TextBox txtOrderDetails;
		private System.Windows.Forms.Label lblOrderDetails;
		private System.Windows.Forms.TextBox txtOrderDetailId;
		private System.Windows.Forms.Label lblOrderDetailId;
		private System.Windows.Forms.TextBox txtProductId;
		private System.Windows.Forms.Label lblProductId;
		private System.Windows.Forms.TextBox txtProduct;
		private System.Windows.Forms.Label lblProduct;
		private System.Windows.Forms.TextBox txtDiscount;
		private System.Windows.Forms.Label lblDiscount;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Label lblPrice;
		private System.Windows.Forms.TextBox txtQuantity;
		private System.Windows.Forms.Label lblQuantity;
		private System.Windows.Forms.TextBox txtNationTaxDetail;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtProvinceTaxDetail;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dgvOrder;
		private System.Windows.Forms.DataGridView dgvOrderDetails;
	}
}