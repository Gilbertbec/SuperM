namespace SuperM.UI.WinForm
{
	partial class SupplierSelector
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		private System.Windows.Forms.DataGridView dgvSupplier;

		private System.Windows.Forms.Button btnClear;

		private System.Windows.Forms.Label lblName;

		private System.Windows.Forms.TextBox txtName;

		private System.Windows.Forms.Label lblAddress;

		private System.Windows.Forms.TextBox txtAddress;

		private System.Windows.Forms.Label lblTelephoneNumber;

		private System.Windows.Forms.Label lblFax;

		private System.Windows.Forms.Label lblEmail;

		private System.Windows.Forms.TextBox txtEmail;

		private System.Windows.Forms.Label lblWebsite;

		private System.Windows.Forms.TextBox txtWebsite;

		private System.Windows.Forms.Label lblRank;

		private System.Windows.Forms.TextBox txtRank;

		private System.Windows.Forms.MaskedTextBox txtTelephoneNumber;

		private System.Windows.Forms.MaskedTextBox txtFax;

		private System.Windows.Forms.ErrorProvider errProvider;

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
			this.components = new System.ComponentModel.Container();
			this.dgvSupplier = new System.Windows.Forms.DataGridView();
			this.btnClear = new System.Windows.Forms.Button();
			this.lblName = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblAddress = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.lblTelephoneNumber = new System.Windows.Forms.Label();
			this.lblFax = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.lblWebsite = new System.Windows.Forms.Label();
			this.txtWebsite = new System.Windows.Forms.TextBox();
			this.lblRank = new System.Windows.Forms.Label();
			this.txtRank = new System.Windows.Forms.TextBox();
			this.txtTelephoneNumber = new System.Windows.Forms.MaskedTextBox();
			this.txtFax = new System.Windows.Forms.MaskedTextBox();
			this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.btnConfirm = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvSupplier
			// 
			this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSupplier.Location = new System.Drawing.Point(0, 1);
			this.dgvSupplier.Name = "dgvSupplier";
			this.dgvSupplier.RowTemplate.Height = 33;
			this.dgvSupplier.Size = new System.Drawing.Size(1700, 500);
			this.dgvSupplier.TabIndex = 0;
			this.dgvSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplier_CellClick);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(1347, 560);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(120, 50);
			this.btnClear.TabIndex = 7;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(5, 554);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(74, 25);
			this.lblName.TabIndex = 1;
			this.lblName.Text = "Name:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(197, 554);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(454, 31);
			this.txtName.TabIndex = 0;
			this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Location = new System.Drawing.Point(5, 604);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(97, 25);
			this.lblAddress.TabIndex = 1;
			this.lblAddress.Text = "Address:";
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(197, 604);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(454, 31);
			this.txtAddress.TabIndex = 2;
			// 
			// lblTelephoneNumber
			// 
			this.lblTelephoneNumber.AutoSize = true;
			this.lblTelephoneNumber.Location = new System.Drawing.Point(5, 654);
			this.lblTelephoneNumber.Name = "lblTelephoneNumber";
			this.lblTelephoneNumber.Size = new System.Drawing.Size(195, 25);
			this.lblTelephoneNumber.TabIndex = 1;
			this.lblTelephoneNumber.Text = "TelephoneNumber:";
			// 
			// lblFax
			// 
			this.lblFax.AutoSize = true;
			this.lblFax.Location = new System.Drawing.Point(5, 704);
			this.lblFax.Name = "lblFax";
			this.lblFax.Size = new System.Drawing.Size(54, 25);
			this.lblFax.TabIndex = 1;
			this.lblFax.Text = "Fax:";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Location = new System.Drawing.Point(714, 560);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(71, 25);
			this.lblEmail.TabIndex = 1;
			this.lblEmail.Text = "Email:";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(813, 560);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(454, 31);
			this.txtEmail.TabIndex = 1;
			this.txtEmail.MouseLeave += new System.EventHandler(this.txtEmail_MouseLeave);
			// 
			// lblWebsite
			// 
			this.lblWebsite.AutoSize = true;
			this.lblWebsite.Location = new System.Drawing.Point(714, 610);
			this.lblWebsite.Name = "lblWebsite";
			this.lblWebsite.Size = new System.Drawing.Size(96, 25);
			this.lblWebsite.TabIndex = 1;
			this.lblWebsite.Text = "Website:";
			// 
			// txtWebsite
			// 
			this.txtWebsite.Location = new System.Drawing.Point(813, 610);
			this.txtWebsite.Name = "txtWebsite";
			this.txtWebsite.Size = new System.Drawing.Size(454, 31);
			this.txtWebsite.TabIndex = 3;
			// 
			// lblRank
			// 
			this.lblRank.AutoSize = true;
			this.lblRank.Location = new System.Drawing.Point(714, 660);
			this.lblRank.Name = "lblRank";
			this.lblRank.Size = new System.Drawing.Size(68, 25);
			this.lblRank.TabIndex = 1;
			this.lblRank.Text = "Rank:";
			// 
			// txtRank
			// 
			this.txtRank.Location = new System.Drawing.Point(813, 660);
			this.txtRank.Name = "txtRank";
			this.txtRank.Size = new System.Drawing.Size(454, 31);
			this.txtRank.TabIndex = 5;
			this.txtRank.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRank_KeyPress);
			// 
			// txtTelephoneNumber
			// 
			this.txtTelephoneNumber.Location = new System.Drawing.Point(197, 654);
			this.txtTelephoneNumber.Mask = "(999) 000-0000";
			this.txtTelephoneNumber.Name = "txtTelephoneNumber";
			this.txtTelephoneNumber.Size = new System.Drawing.Size(454, 31);
			this.txtTelephoneNumber.TabIndex = 4;
			// 
			// txtFax
			// 
			this.txtFax.Location = new System.Drawing.Point(197, 704);
			this.txtFax.Mask = "(999) 000-0000";
			this.txtFax.Name = "txtFax";
			this.txtFax.Size = new System.Drawing.Size(454, 31);
			this.txtFax.TabIndex = 6;
			// 
			// errProvider
			// 
			this.errProvider.ContainerControl = this;
			// 
			// btnConfirm
			// 
			this.btnConfirm.Location = new System.Drawing.Point(1532, 560);
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Size = new System.Drawing.Size(120, 50);
			this.btnConfirm.TabIndex = 8;
			this.btnConfirm.Text = "Confirm";
			this.btnConfirm.UseVisualStyleBackColor = true;
			this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
			// 
			// SupplierSelector
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1674, 775);
			this.Controls.Add(this.btnConfirm);
			this.Controls.Add(this.txtFax);
			this.Controls.Add(this.txtTelephoneNumber);
			this.Controls.Add(this.dgvSupplier);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.lblAddress);
			this.Controls.Add(this.lblTelephoneNumber);
			this.Controls.Add(this.lblFax);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.txtWebsite);
			this.Controls.Add(this.lblWebsite);
			this.Controls.Add(this.txtRank);
			this.Controls.Add(this.lblRank);
			this.Name = "SupplierSelector";
			this.Text = "SupplierEditor";
			this.Load += new System.EventHandler(this.SupplierEditor_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private System.Windows.Forms.Button btnConfirm;
	}
}
