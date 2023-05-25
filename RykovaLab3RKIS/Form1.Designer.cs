namespace RykovaLab3RKIS
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelHeader = new System.Windows.Forms.Label();
			this.labelLogin = new System.Windows.Forms.Label();
			this.labelPassword = new System.Windows.Forms.Label();
			this.loginTxt = new System.Windows.Forms.TextBox();
			this.pswTxt = new System.Windows.Forms.TextBox();
			this.enterBtn = new System.Windows.Forms.Button();
			this.exitBtn = new System.Windows.Forms.Button();
			this.regBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelHeader
			// 
			this.labelHeader.AutoSize = true;
			this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelHeader.Location = new System.Drawing.Point(304, 69);
			this.labelHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelHeader.Name = "labelHeader";
			this.labelHeader.Size = new System.Drawing.Size(106, 16);
			this.labelHeader.TabIndex = 0;
			this.labelHeader.Text = "Вход в систему";
			// 
			// labelLogin
			// 
			this.labelLogin.AutoSize = true;
			this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelLogin.Location = new System.Drawing.Point(260, 162);
			this.labelLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelLogin.Name = "labelLogin";
			this.labelLogin.Size = new System.Drawing.Size(46, 16);
			this.labelLogin.TabIndex = 1;
			this.labelLogin.Text = "Логин";
			// 
			// labelPassword
			// 
			this.labelPassword.AutoSize = true;
			this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelPassword.Location = new System.Drawing.Point(250, 229);
			this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(56, 16);
			this.labelPassword.TabIndex = 2;
			this.labelPassword.Text = "Пароль";
			// 
			// loginTxt
			// 
			this.loginTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.loginTxt.Location = new System.Drawing.Point(341, 162);
			this.loginTxt.Margin = new System.Windows.Forms.Padding(4);
			this.loginTxt.Name = "loginTxt";
			this.loginTxt.Size = new System.Drawing.Size(140, 22);
			this.loginTxt.TabIndex = 3;
			// 
			// pswTxt
			// 
			this.pswTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.pswTxt.Location = new System.Drawing.Point(341, 229);
			this.pswTxt.Margin = new System.Windows.Forms.Padding(4);
			this.pswTxt.Name = "pswTxt";
			this.pswTxt.Size = new System.Drawing.Size(140, 22);
			this.pswTxt.TabIndex = 4;
			// 
			// enterBtn
			// 
			this.enterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.enterBtn.Location = new System.Drawing.Point(254, 325);
			this.enterBtn.Margin = new System.Windows.Forms.Padding(4);
			this.enterBtn.Name = "enterBtn";
			this.enterBtn.Size = new System.Drawing.Size(108, 47);
			this.enterBtn.TabIndex = 5;
			this.enterBtn.Text = "Войти";
			this.enterBtn.UseVisualStyleBackColor = true;
			this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
			// 
			// exitBtn
			// 
			this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.exitBtn.Location = new System.Drawing.Point(374, 325);
			this.exitBtn.Margin = new System.Windows.Forms.Padding(4);
			this.exitBtn.Name = "exitBtn";
			this.exitBtn.Size = new System.Drawing.Size(108, 47);
			this.exitBtn.TabIndex = 6;
			this.exitBtn.Text = "Закончить работу";
			this.exitBtn.UseVisualStyleBackColor = true;
			this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
			// 
			// regBtn
			// 
			this.regBtn.Location = new System.Drawing.Point(545, 325);
			this.regBtn.Name = "regBtn";
			this.regBtn.Size = new System.Drawing.Size(140, 58);
			this.regBtn.TabIndex = 7;
			this.regBtn.Text = "Регистрация";
			this.regBtn.UseVisualStyleBackColor = true;
			this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(722, 554);
			this.Controls.Add(this.regBtn);
			this.Controls.Add(this.exitBtn);
			this.Controls.Add(this.enterBtn);
			this.Controls.Add(this.pswTxt);
			this.Controls.Add(this.loginTxt);
			this.Controls.Add(this.labelPassword);
			this.Controls.Add(this.labelLogin);
			this.Controls.Add(this.labelHeader);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Text = "Вход в информационную систему";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelHeader;
		private System.Windows.Forms.Label labelLogin;
		private System.Windows.Forms.Label labelPassword;
		private System.Windows.Forms.TextBox loginTxt;
		private System.Windows.Forms.TextBox pswTxt;
		private System.Windows.Forms.Button enterBtn;
		private System.Windows.Forms.Button exitBtn;
		private System.Windows.Forms.Button regBtn;
	}
}

