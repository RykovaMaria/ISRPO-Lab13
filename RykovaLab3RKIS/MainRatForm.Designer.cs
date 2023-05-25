namespace RykovaLab3RKIS
{
	partial class MainRatForm
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
			this.report1Btn = new System.Windows.Forms.Button();
			this.report2Btn = new System.Windows.Forms.Button();
			this.exitBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// helloLbl
			// 
			this.helloLbl.AutoSize = true;
			this.helloLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.helloLbl.Location = new System.Drawing.Point(115, 71);
			this.helloLbl.Name = "helloLbl";
			this.helloLbl.Size = new System.Drawing.Size(114, 20);
			this.helloLbl.TabIndex = 0;
			this.helloLbl.Text = "Добрый день!";
			// 
			// report1Btn
			// 
			this.report1Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.report1Btn.Location = new System.Drawing.Point(82, 244);
			this.report1Btn.Name = "report1Btn";
			this.report1Btn.Size = new System.Drawing.Size(106, 37);
			this.report1Btn.TabIndex = 1;
			this.report1Btn.Text = "Отчет 1";
			this.report1Btn.UseVisualStyleBackColor = true;
			// 
			// report2Btn
			// 
			this.report2Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.report2Btn.Location = new System.Drawing.Point(256, 244);
			this.report2Btn.Name = "report2Btn";
			this.report2Btn.Size = new System.Drawing.Size(106, 37);
			this.report2Btn.TabIndex = 2;
			this.report2Btn.Text = "Отчет 2";
			this.report2Btn.UseVisualStyleBackColor = true;
			// 
			// exitBtn
			// 
			this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.exitBtn.Location = new System.Drawing.Point(166, 332);
			this.exitBtn.Name = "exitBtn";
			this.exitBtn.Size = new System.Drawing.Size(106, 39);
			this.exitBtn.TabIndex = 3;
			this.exitBtn.Text = "Выйти";
			this.exitBtn.UseVisualStyleBackColor = true;
			this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
			// 
			// MainRatForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(462, 450);
			this.Controls.Add(this.exitBtn);
			this.Controls.Add(this.report2Btn);
			this.Controls.Add(this.report1Btn);
			this.Controls.Add(this.helloLbl);
			this.Name = "MainRatForm";
			this.Text = "Форма главной крысы";
			this.Load += new System.EventHandler(this.MainRatForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label helloLbl;
		private System.Windows.Forms.Button report1Btn;
		private System.Windows.Forms.Button report2Btn;
		private System.Windows.Forms.Button exitBtn;
	}
}