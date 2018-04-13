
namespace SuperM.UI.WinForm
{
	partial class OrderEditor
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnUpdate;

			private System.Windows.Forms.Label lblOrderId;
			private System.Windows.Forms.TextBox txtOrderId;
			private System.Windows.Forms.Label lblUserId;
			private System.Windows.Forms.TextBox txtUserId;
			private System.Windows.Forms.Label lblOrderTime;
			private System.Windows.Forms.TextBox txtOrderTime;
			private System.Windows.Forms.Label lblGrossTotal;
			private System.Windows.Forms.TextBox txtGrossTotal;
			private System.Windows.Forms.Label lblNationTax;
			private System.Windows.Forms.TextBox txtNationTax;
			private System.Windows.Forms.Label lblProvinceTax;
			private System.Windows.Forms.TextBox txtProvinceTax;
			private System.Windows.Forms.Label lblTotal;
			private System.Windows.Forms.TextBox txtTotal;
			private System.Windows.Forms.Label lblOrderDetails;
			private System.Windows.Forms.TextBox txtOrderDetails;
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
			this.lblOrderId = new System.Windows.Forms.Label();
			this.txtOrderId = new System.Windows.Forms.TextBox();
			this.lblUserId = new System.Windows.Forms.Label();
			this.txtUserId = new System.Windows.Forms.TextBox();
			this.lblOrderTime = new System.Windows.Forms.Label();
			this.txtOrderTime = new System.Windows.Forms.TextBox();
			this.lblGrossTotal = new System.Windows.Forms.Label();
			this.txtGrossTotal = new System.Windows.Forms.TextBox();
			this.lblNationTax = new System.Windows.Forms.Label();
			this.txtNationTax = new System.Windows.Forms.TextBox();
			this.lblProvinceTax = new System.Windows.Forms.Label();
			this.txtProvinceTax = new System.Windows.Forms.TextBox();
			this.lblTotal = new System.Windows.Forms.Label();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.lblOrderDetails = new System.Windows.Forms.Label();
			this.txtOrderDetails = new System.Windows.Forms.TextBox();
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
			// lblOrderId
			// 
			this.lblOrderId.AutoSize = true;
			this.lblOrderId.Location = new System.Drawing.Point(80, 136);
			this.lblOrderId.Name = "lblOrderId";
			this.lblOrderId.Size = new System.Drawing.Size(89, 25);
			this.lblOrderId.TabIndex = 1;
			this.lblOrderId.Text = "OrderId:";
			// 
			// txtOrderId
			// 
			this.txtOrderId.Location = new System.Drawing.Point(216, 136);
			this.txtOrderId.Name = "txtOrderId";
			this.txtOrderId.Size = new System.Drawing.Size(454, 31);
			this.txtOrderId.TabIndex = 2;
			// 
			// lblUserId
			// 
			this.lblUserId.AutoSize = true;
			this.lblUserId.Location = new System.Drawing.Point(80, 186);
			this.lblUserId.Name = "lblUserId";
			this.lblUserId.Size = new System.Drawing.Size(80, 25);
			this.lblUserId.TabIndex = 1;
			this.lblUserId.Text = "UserId:";
			// 
			// txtUserId
			// 
			this.txtUserId.Location = new System.Drawing.Point(216, 186);
			this.txtUserId.Name = "txtUserId";
			this.txtUserId.Size = new System.Drawing.Size(454, 31);
			this.txtUserId.TabIndex = 2;
			// 
			// lblOrderTime
			// 
			this.lblOrderTime.AutoSize = true;
			this.lblOrderTime.Location = new System.Drawing.Point(80, 236);
			this.lblOrderTime.Name = "lblOrderTime";
			this.lblOrderTime.Size = new System.Drawing.Size(119, 25);
			this.lblOrderTime.TabIndex = 1;
			this.lblOrderTime.Text = "OrderTime:";
			// 
			// txtOrderTime
			// 
			this.txtOrderTime.Location = new System.Drawing.Point(216, 236);
			this.txtOrderTime.Name = "txtOrderTime";
			this.txtOrderTime.Size = new System.Drawing.Size(454, 31);
			this.txtOrderTime.TabIndex = 2;
			// 
			// lblGrossTotal
			// 
			this.lblGrossTotal.AutoSize = true;
			this.lblGrossTotal.Location = new System.Drawing.Point(80, 286);
			this.lblGrossTotal.Name = "lblGrossTotal";
			this.lblGrossTotal.Size = new System.Drawing.Size(123, 25);
			this.lblGrossTotal.TabIndex = 1;
			this.lblGrossTotal.Text = "GrossTotal:";
			// 
			// txtGrossTotal
			// 
			this.txtGrossTotal.Location = new System.Drawing.Point(216, 286);
			this.txtGrossTotal.Name = "txtGrossTotal";
			this.txtGrossTotal.Size = new System.Drawing.Size(454, 31);
			this.txtGrossTotal.TabIndex = 2;
			// 
			// lblNationTax
			// 
			this.lblNationTax.AutoSize = true;
			this.lblNationTax.Location = new System.Drawing.Point(80, 336);
			this.lblNationTax.Name = "lblNationTax";
			this.lblNationTax.Size = new System.Drawing.Size(116, 25);
			this.lblNationTax.TabIndex = 1;
			this.lblNationTax.Text = "NationTax:";
			// 
			// txtNationTax
			// 
			this.txtNationTax.Location = new System.Drawing.Point(216, 336);
			this.txtNationTax.Name = "txtNationTax";
			this.txtNationTax.Size = new System.Drawing.Size(454, 31);
			this.txtNationTax.TabIndex = 2;
			// 
			// lblProvinceTax
			// 
			this.lblProvinceTax.AutoSize = true;
			this.lblProvinceTax.Location = new System.Drawing.Point(80, 386);
			this.lblProvinceTax.Name = "lblProvinceTax";
			this.lblProvinceTax.Size = new System.Drawing.Size(138, 25);
			this.lblProvinceTax.TabIndex = 1;
			this.lblProvinceTax.Text = "ProvinceTax:";
			// 
			// txtProvinceTax
			// 
			this.txtProvinceTax.Location = new System.Drawing.Point(216, 386);
			this.txtProvinceTax.Name = "txtProvinceTax";
			this.txtProvinceTax.Size = new System.Drawing.Size(454, 31);
			this.txtProvinceTax.TabIndex = 2;
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Location = new System.Drawing.Point(80, 436);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(66, 25);
			this.lblTotal.TabIndex = 1;
			this.lblTotal.Text = "Total:";
			// 
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(216, 436);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(454, 31);
			this.txtTotal.TabIndex = 2;
			// 
			// lblOrderDetails
			// 
			this.lblOrderDetails.AutoSize = true;
			this.lblOrderDetails.Location = new System.Drawing.Point(80, 486);
			this.lblOrderDetails.Name = "lblOrderDetails";
			this.lblOrderDetails.Size = new System.Drawing.Size(138, 25);
			this.lblOrderDetails.TabIndex = 1;
			this.lblOrderDetails.Text = "OrderDetails:";
			// 
			// txtOrderDetails
			// 
			this.txtOrderDetails.Location = new System.Drawing.Point(216, 486);
			this.txtOrderDetails.Name = "txtOrderDetails";
			this.txtOrderDetails.Size = new System.Drawing.Size(454, 31);
			this.txtOrderDetails.TabIndex = 2;
			// 
			// OrderEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(2074, 1329);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
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
			this.Name = "OrderEditor";
			this.Text = "OrderEditor";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}

