
namespace passwordManagerbeta
{
	partial class PasswordManager
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
			this.Password = new System.Windows.Forms.Label();
			this.PasswordLengthLabel = new System.Windows.Forms.Label();
			this.PasswordLength = new System.Windows.Forms.TrackBar();
			this.CopyPassword = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.PasswordLength)).BeginInit();
			this.SuspendLayout();
			// 
			// Password
			// 
			this.Password.Font = new System.Drawing.Font("Leelawadee", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Password.Location = new System.Drawing.Point(209, 56);
			this.Password.Name = "Password";
			this.Password.Size = new System.Drawing.Size(366, 65);
			this.Password.TabIndex = 0;
			this.Password.Text = "PasswordLabel";
			this.Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// PasswordLengthLabel
			// 
			this.PasswordLengthLabel.Font = new System.Drawing.Font("Leelawadee", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PasswordLengthLabel.Location = new System.Drawing.Point(209, 140);
			this.PasswordLengthLabel.Name = "PasswordLengthLabel";
			this.PasswordLengthLabel.Size = new System.Drawing.Size(366, 65);
			this.PasswordLengthLabel.TabIndex = 1;
			this.PasswordLengthLabel.Text = "Password Length: 5";
			this.PasswordLengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// PasswordLength
			// 
			this.PasswordLength.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.PasswordLength.Location = new System.Drawing.Point(216, 237);
			this.PasswordLength.Name = "PasswordLength";
			this.PasswordLength.Size = new System.Drawing.Size(359, 45);
			this.PasswordLength.TabIndex = 2;
			this.PasswordLength.Scroll += new System.EventHandler(this.PasswordLength_Scroll);
			// 
			// CopyPassword
			// 
			this.CopyPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CopyPassword.Location = new System.Drawing.Point(216, 315);
			this.CopyPassword.Name = "CopyPassword";
			this.CopyPassword.Size = new System.Drawing.Size(359, 44);
			this.CopyPassword.TabIndex = 3;
			this.CopyPassword.Text = "Copy Password";
			this.CopyPassword.UseVisualStyleBackColor = true;
			this.CopyPassword.Click += new System.EventHandler(this.CopyPassword_Click);
			// 
			// PasswordManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.CopyPassword);
			this.Controls.Add(this.PasswordLength);
			this.Controls.Add(this.PasswordLengthLabel);
			this.Controls.Add(this.Password);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "PasswordManager";
			this.Text = "Password Manager";
			((System.ComponentModel.ISupportInitialize)(this.PasswordLength)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Password;
		private System.Windows.Forms.Label PasswordLengthLabel;
		private System.Windows.Forms.TrackBar PasswordLength;
		private System.Windows.Forms.Button CopyPassword;
	}
}

