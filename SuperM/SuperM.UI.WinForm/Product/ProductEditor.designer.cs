
namespace SuperM.UI.WinForm
{
	partial class ProductEditor
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
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.lblName = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblSpecification = new System.Windows.Forms.Label();
			this.txtSpecification = new System.Windows.Forms.TextBox();
			this.lblCategory = new System.Windows.Forms.Label();
			this.lblDescription = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.lblPurchasedPrice = new System.Windows.Forms.Label();
			this.txtPurchasedPrice = new System.Windows.Forms.TextBox();
			this.lblSellingPrice = new System.Windows.Forms.Label();
			this.txtSellingPrice = new System.Windows.Forms.TextBox();
			this.lblSupplier = new System.Windows.Forms.Label();
			this.txtSupplier = new System.Windows.Forms.TextBox();
			this.lblExpirationDate = new System.Windows.Forms.Label();
			this.lblPurchasedDate = new System.Windows.Forms.Label();
			this.cboCategory = new System.Windows.Forms.ComboBox();
			this.dtpPurchasedDate = new System.Windows.Forms.DateTimePicker();
			this.dtpExpirationDate = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvProduct
			// 
			this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProduct.Location = new System.Drawing.Point(0, 1);
			this.dgvProduct.Name = "dgvProduct";
			this.dgvProduct.RowTemplate.Height = 33;
			this.dgvProduct.Size = new System.Drawing.Size(2000, 900);
			this.dgvProduct.TabIndex = 0;
			this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(1541, 957);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(119, 51);
			this.btnAdd.TabIndex = 10;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(1881, 956);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(119, 51);
			this.btnDelete.TabIndex = 12;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(1368, 957);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(119, 52);
			this.btnClear.TabIndex = 9;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Enabled = false;
			this.btnUpdate.Location = new System.Drawing.Point(1714, 957);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(119, 51);
			this.btnUpdate.TabIndex = 11;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(12, 925);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(74, 25);
			this.lblName.TabIndex = 1;
			this.lblName.Text = "Name:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(184, 930);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(454, 31);
			this.txtName.TabIndex = 0;
			this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
			// 
			// lblSpecification
			// 
			this.lblSpecification.AutoSize = true;
			this.lblSpecification.Location = new System.Drawing.Point(645, 930);
			this.lblSpecification.Name = "lblSpecification";
			this.lblSpecification.Size = new System.Drawing.Size(141, 25);
			this.lblSpecification.TabIndex = 1;
			this.lblSpecification.Text = "Specification:";
			// 
			// txtSpecification
			// 
			this.txtSpecification.Location = new System.Drawing.Point(817, 935);
			this.txtSpecification.Name = "txtSpecification";
			this.txtSpecification.Size = new System.Drawing.Size(454, 31);
			this.txtSpecification.TabIndex = 1;
			// 
			// lblCategory
			// 
			this.lblCategory.AutoSize = true;
			this.lblCategory.Location = new System.Drawing.Point(12, 981);
			this.lblCategory.Name = "lblCategory";
			this.lblCategory.Size = new System.Drawing.Size(105, 25);
			this.lblCategory.TabIndex = 1;
			this.lblCategory.Text = "Category:";
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Location = new System.Drawing.Point(12, 1165);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(126, 25);
			this.lblDescription.TabIndex = 1;
			this.lblDescription.Text = "Description:";
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(184, 1162);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(454, 126);
			this.txtDescription.TabIndex = 8;
			// 
			// lblPurchasedPrice
			// 
			this.lblPurchasedPrice.AutoSize = true;
			this.lblPurchasedPrice.Location = new System.Drawing.Point(12, 1047);
			this.lblPurchasedPrice.Name = "lblPurchasedPrice";
			this.lblPurchasedPrice.Size = new System.Drawing.Size(170, 25);
			this.lblPurchasedPrice.TabIndex = 1;
			this.lblPurchasedPrice.Text = "PurchasedPrice:";
			// 
			// txtPurchasedPrice
			// 
			this.txtPurchasedPrice.Location = new System.Drawing.Point(185, 1049);
			this.txtPurchasedPrice.Name = "txtPurchasedPrice";
			this.txtPurchasedPrice.Size = new System.Drawing.Size(454, 31);
			this.txtPurchasedPrice.TabIndex = 4;
			// 
			// lblSellingPrice
			// 
			this.lblSellingPrice.AutoSize = true;
			this.lblSellingPrice.Location = new System.Drawing.Point(645, 1049);
			this.lblSellingPrice.Name = "lblSellingPrice";
			this.lblSellingPrice.Size = new System.Drawing.Size(132, 25);
			this.lblSellingPrice.TabIndex = 1;
			this.lblSellingPrice.Text = "SellingPrice:";
			// 
			// txtSellingPrice
			// 
			this.txtSellingPrice.Location = new System.Drawing.Point(817, 1046);
			this.txtSellingPrice.Name = "txtSellingPrice";
			this.txtSellingPrice.Size = new System.Drawing.Size(454, 31);
			this.txtSellingPrice.TabIndex = 5;
			// 
			// lblSupplier
			// 
			this.lblSupplier.AutoSize = true;
			this.lblSupplier.Location = new System.Drawing.Point(645, 986);
			this.lblSupplier.Name = "lblSupplier";
			this.lblSupplier.Size = new System.Drawing.Size(97, 25);
			this.lblSupplier.TabIndex = 1;
			this.lblSupplier.Text = "Supplier:";
			// 
			// txtSupplier
			// 
			this.txtSupplier.Location = new System.Drawing.Point(817, 991);
			this.txtSupplier.Name = "txtSupplier";
			this.txtSupplier.Size = new System.Drawing.Size(454, 31);
			this.txtSupplier.TabIndex = 3;
			this.txtSupplier.Click += new System.EventHandler(this.txtSupplierId_Click);
			// 
			// lblExpirationDate
			// 
			this.lblExpirationDate.AutoSize = true;
			this.lblExpirationDate.Location = new System.Drawing.Point(645, 1100);
			this.lblExpirationDate.Name = "lblExpirationDate";
			this.lblExpirationDate.Size = new System.Drawing.Size(159, 25);
			this.lblExpirationDate.TabIndex = 1;
			this.lblExpirationDate.Text = "ExpirationDate:";
			// 
			// lblPurchasedDate
			// 
			this.lblPurchasedDate.AutoSize = true;
			this.lblPurchasedDate.Location = new System.Drawing.Point(12, 1106);
			this.lblPurchasedDate.Name = "lblPurchasedDate";
			this.lblPurchasedDate.Size = new System.Drawing.Size(166, 25);
			this.lblPurchasedDate.TabIndex = 1;
			this.lblPurchasedDate.Text = "PurchasedDate:";
			// 
			// cboCategory
			// 
			this.cboCategory.FormattingEnabled = true;
			this.cboCategory.Location = new System.Drawing.Point(184, 986);
			this.cboCategory.Name = "cboCategory";
			this.cboCategory.Size = new System.Drawing.Size(454, 33);
			this.cboCategory.TabIndex = 2;
			// 
			// dtpPurchasedDate
			// 
			this.dtpPurchasedDate.Location = new System.Drawing.Point(185, 1105);
			this.dtpPurchasedDate.Name = "dtpPurchasedDate";
			this.dtpPurchasedDate.Size = new System.Drawing.Size(454, 31);
			this.dtpPurchasedDate.TabIndex = 6;
			// 
			// dtpExpirationDate
			// 
			this.dtpExpirationDate.Location = new System.Drawing.Point(817, 1100);
			this.dtpExpirationDate.Name = "dtpExpirationDate";
			this.dtpExpirationDate.Size = new System.Drawing.Size(454, 31);
			this.dtpExpirationDate.TabIndex = 7;
			// 
			// ProductEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(2074, 1329);
			this.Controls.Add(this.dtpExpirationDate);
			this.Controls.Add(this.dtpPurchasedDate);
			this.Controls.Add(this.cboCategory);
			this.Controls.Add(this.dgvProduct);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.txtSpecification);
			this.Controls.Add(this.lblSpecification);
			this.Controls.Add(this.lblCategory);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.lblDescription);
			this.Controls.Add(this.txtPurchasedPrice);
			this.Controls.Add(this.lblPurchasedPrice);
			this.Controls.Add(this.txtSellingPrice);
			this.Controls.Add(this.lblSellingPrice);
			this.Controls.Add(this.txtSupplier);
			this.Controls.Add(this.lblSupplier);
			this.Controls.Add(this.lblExpirationDate);
			this.Controls.Add(this.lblPurchasedDate);
			this.Name = "ProductEditor";
			this.Text = "ProductEditor";
			this.Load += new System.EventHandler(this.ProductEditor_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvProduct;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lblSpecification;
		private System.Windows.Forms.TextBox txtSpecification;
		private System.Windows.Forms.Label lblCategory;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Label lblPurchasedPrice;
		private System.Windows.Forms.TextBox txtPurchasedPrice;
		private System.Windows.Forms.Label lblSellingPrice;
		private System.Windows.Forms.TextBox txtSellingPrice;
		private System.Windows.Forms.Label lblSupplier;
		private System.Windows.Forms.TextBox txtSupplier;
		private System.Windows.Forms.Label lblExpirationDate;
		private System.Windows.Forms.Label lblPurchasedDate;
		private System.Windows.Forms.ComboBox cboCategory;
		private System.Windows.Forms.DateTimePicker dtpPurchasedDate;
		private System.Windows.Forms.DateTimePicker dtpExpirationDate;
	}
}
