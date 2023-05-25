namespace RykovaLab3RKIS
{
	partial class RatForm
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
			this.helloLbl = new System.Windows.Forms.Label();
			this.accountBtn = new System.Windows.Forms.Button();
			this.addUserBtn = new System.Windows.Forms.Button();
			this.exitBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// helloLbl
			// 
			this.helloLbl.AutoSize = true;
			this.helloLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.helloLbl.Location = new System.Drawing.Point(118, 60);
			this.helloLbl.Name = "helloLbl";
			this.helloLbl.Size = new System.Drawing.Size(114, 20);
			this.helloLbl.TabIndex = 0;
			this.helloLbl.Text = "Добрый день!";
			// 
			// accountBtn
			// 
			this.accountBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.accountBtn.Location = new System.Drawing.Point(121, 116);
			this.accountBtn.Name = "accountBtn";
			this.accountBtn.Size = new System.Drawing.Size(232, 32);
			this.accountBtn.TabIndex = 1;
			this.accountBtn.Text = "Просмотр учетных записей";
			this.accountBtn.UseVisualStyleBackColor = true;
			this.accountBtn.Click += new System.EventHandler(this.accountBtn_Click);
			// 
			// addUserBtn
			// 
			this.addUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.addUserBtn.Location = new System.Drawing.Point(121, 167);
			this.addUserBtn.Name = "addUserBtn";
			this.addUserBtn.Size = new System.Drawing.Size(232, 32);
			this.addUserBtn.TabIndex = 2;
			this.addUserBtn.Text = "Добавить пользователя";
			this.addUserBtn.UseVisualStyleBackColor = true;
			// 
			// exitBtn
			// 
			this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.exitBtn.Location = new System.Drawing.Point(163, 236);
			this.exitBtn.Name = "exitBtn";
			this.exitBtn.Size = new System.Drawing.Size(126, 32);
			this.exitBtn.TabIndex = 3;
			this.exitBtn.Text = "Выйти";
			this.exitBtn.UseVisualStyleBackColor = true;
			this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
			// 
			// RatForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(459, 450);
			this.Controls.Add(this.exitBtn);
			this.Controls.Add(this.addUserBtn);
			this.Controls.Add(this.accountBtn);
			this.Controls.Add(this.helloLbl);
			this.Name = "RatForm";
			this.Text = "Форма крысы";
			this.Load += new System.EventHandler(this.RatForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label helloLbl;
		private System.Windows.Forms.Button accountBtn;
		private System.Windows.Forms.Button addUserBtn;
		private System.Windows.Forms.Button exitBtn;
	}
}