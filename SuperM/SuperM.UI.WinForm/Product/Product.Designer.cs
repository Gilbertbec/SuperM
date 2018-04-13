namespace SuperM.UI.WinForm
{
	partial class ProductBak
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
			this.dgvProduct = new System.Windows.Forms.DataGridView();
			this.textName = new System.Windows.Forms.TextBox();
			this.txtType = new System.Windows.Forms.TextBox();
			this.txtPurchasedPrice = new System.Windows.Forms.TextBox();
			this.txtPurchasedDate = new System.Windows.Forms.TextBox();
			this.txtSellingPrice = new System.Windows.Forms.TextBox();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.txtSupplierId = new System.Windows.Forms.TextBox();
			this.txtExpirationDate = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.lblType = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblSellingPrice = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtCategoryId = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
			((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvProduct
			// 
			this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProduct.Location = new System.Drawing.Point(449, 217);
			this.dgvProduct.Name = "dgvProduct";
			this.dgvProduct.RowTemplate.Height = 33;
			this.dgvProduct.Size = new System.Drawing.Size(1896, 978);
			this.dgvProduct.TabIndex = 0;
			this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentClick);
			// 
			// textName
			// 
			this.textName.Location = new System.Drawing.Point(115, 56);
			this.textName.Name = "textName";
			this.textName.Size = new System.Drawing.Size(100, 31);
			this.textName.TabIndex = 1;
			// 
			// txtType
			// 
			this.txtType.Location = new System.Drawing.Point(328, 59);
			this.txtType.Name = "txtType";
			this.txtType.Size = new System.Drawing.Size(100, 31);
			this.txtType.TabIndex = 1;
			// 
			// txtPurchasedPrice
			// 
			this.txtPurchasedPrice.Location = new System.Drawing.Point(918, 59);
			this.txtPurchasedPrice.Name = "txtPurchasedPrice";
			this.txtPurchasedPrice.Size = new System.Drawing.Size(100, 31);
			this.txtPurchasedPrice.TabIndex = 1;
			// 
			// txtPurchasedDate
			// 
			this.txtPurchasedDate.Location = new System.Drawing.Point(1992, 53);
			this.txtPurchasedDate.Name = "txtPurchasedDate";
			this.txtPurchasedDate.Size = new System.Drawing.Size(100, 31);
			this.txtPurchasedDate.TabIndex = 1;
			// 
			// txtSellingPrice
			// 
			this.txtSellingPrice.Location = new System.Drawing.Point(1198, 56);
			this.txtSellingPrice.Name = "txtSellingPrice";
			this.txtSellingPrice.Size = new System.Drawing.Size(100, 31);
			this.txtSellingPrice.TabIndex = 1;
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(1461, 59);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(100, 31);
			this.txtDescription.TabIndex = 1;
			// 
			// txtSupplierId
			// 
			this.txtSupplierId.Location = new System.Drawing.Point(1698, 56);
			this.txtSupplierId.Name = "txtSupplierId";
			this.txtSupplierId.Size = new System.Drawing.Size(100, 31);
			this.txtSupplierId.TabIndex = 1;
			// 
			// txtExpirationDate
			// 
			this.txtExpirationDate.Location = new System.Drawing.Point(2263, 56);
			this.txtExpirationDate.Name = "txtExpirationDate";
			this.txtExpirationDate.Size = new System.Drawing.Size(100, 31);
			this.txtExpirationDate.TabIndex = 1;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(35, 56);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(74, 25);
			this.lblName.TabIndex = 2;
			this.lblName.Text = "Name:";
			// 
			// lblType
			// 
			this.lblType.AutoSize = true;
			this.lblType.Location = new System.Drawing.Point(243, 59);
			this.lblType.Name = "lblType";
			this.lblType.Size = new System.Drawing.Size(66, 25);
			this.lblType.TabIndex = 2;
			this.lblType.Text = "Type:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(731, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(170, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "PurchasedPrice:";
			// 
			// lblSellingPrice
			// 
			this.lblSellingPrice.AutoSize = true;
			this.lblSellingPrice.Location = new System.Drawing.Point(1051, 62);
			this.lblSellingPrice.Name = "lblSellingPrice";
			this.lblSellingPrice.Size = new System.Drawing.Size(132, 25);
			this.lblSellingPrice.TabIndex = 2;
			this.lblSellingPrice.Text = "SellingPrice:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(1320, 62);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(126, 25);
			this.label3.TabIndex = 2;
			this.label3.Text = "Description:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(1578, 65);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(114, 25);
			this.label4.TabIndex = 2;
			this.label4.Text = "SupplierId:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(2098, 62);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(159, 25);
			this.label5.TabIndex = 2;
			this.label5.Text = "ExpirationDate:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(1820, 56);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(166, 25);
			this.label6.TabIndex = 2;
			this.label6.Text = "PurchasedDate:";
			// 
			// txtCategoryId
			// 
			this.txtCategoryId.Location = new System.Drawing.Point(602, 59);
			this.txtCategoryId.Name = "txtCategoryId";
			this.txtCategoryId.Size = new System.Drawing.Size(100, 31);
			this.txtCategoryId.TabIndex = 1;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(458, 62);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(122, 25);
			this.label7.TabIndex = 2;
			this.label7.Text = "CategoryId:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(115, 143);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(156, 49);
			this.button1.TabIndex = 3;
			this.button1.Text = "AddProduct";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(328, 143);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(175, 49);
			this.button2.TabIndex = 3;
			this.button2.Text = "UpdateProduct";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(661, 143);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(156, 49);
			this.button3.TabIndex = 3;
			this.button3.Text = "DeleteProduct";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.Location = new System.Drawing.Point(40, 263);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.Size = new System.Drawing.Size(340, 535);
			this.propertyGrid1.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(2417, 1247);
			this.Controls.Add(this.propertyGrid1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblSellingPrice);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblType);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.txtCategoryId);
			this.Controls.Add(this.txtExpirationDate);
			this.Controls.Add(this.txtSupplierId);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.txtSellingPrice);
			this.Controls.Add(this.txtPurchasedDate);
			this.Controls.Add(this.txtPurchasedPrice);
			this.Controls.Add(this.txtType);
			this.Controls.Add(this.textName);
			this.Controls.Add(this.dgvProduct);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvProduct;
		private System.Windows.Forms.TextBox textName;
		private System.Windows.Forms.TextBox txtType;
		private System.Windows.Forms.TextBox txtPurchasedPrice;
		private System.Windows.Forms.TextBox txtPurchasedDate;
		private System.Windows.Forms.TextBox txtSellingPrice;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.TextBox txtSupplierId;
		private System.Windows.Forms.TextBox txtExpirationDate;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblType;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblSellingPrice;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtCategoryId;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.PropertyGrid propertyGrid1;
	}
}

