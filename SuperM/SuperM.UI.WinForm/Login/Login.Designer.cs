namespace SuperM.UI.WinForm
{
	partial class Login
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.picBoxLogin = new System.Windows.Forms.PictureBox();
			this.lblUserName = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.picBoxLogin)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(403, 636);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(280, 31);
			this.txtPassword.TabIndex = 1;
			this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(246, 711);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(437, 50);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(403, 573);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(280, 31);
			this.txtUserName.TabIndex = 0;
			this.txtUserName.Text = "guest";
			this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
			// 
			// picBoxLogin
			// 
			this.picBoxLogin.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogin.Image")));
			this.picBoxLogin.Location = new System.Drawing.Point(1, 0);
			this.picBoxLogin.Name = "picBoxLogin";
			this.picBoxLogin.Padding = new System.Windows.Forms.Padding(1);
			this.picBoxLogin.Size = new System.Drawing.Size(892, 490);
			this.picBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picBoxLogin.TabIndex = 2;
			this.picBoxLogin.TabStop = false;
			// 
			// lblUserName
			// 
			this.lblUserName.AutoSize = true;
			this.lblUserName.Location = new System.Drawing.Point(241, 573);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(113, 25);
			this.lblUserName.TabIndex = 3;
			this.lblUserName.Text = "UserName";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(241, 642);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(112, 25);
			this.lblPassword.TabIndex = 3;
			this.lblPassword.Text = "Password:";
			// 
			// errProvider
			// 
			this.errProvider.ContainerControl = this;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(891, 806);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblUserName);
			this.Controls.Add(this.picBoxLogin);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.txtPassword);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			((System.ComponentModel.ISupportInitialize)(this.picBoxLogin)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.PictureBox picBoxLogin;
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.ErrorProvider errProvider;
	}
}