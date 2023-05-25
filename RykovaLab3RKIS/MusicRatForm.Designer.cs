namespace RykovaLab3RKIS
{
	partial class MusicRatForm
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
			this.exitBtn = new System.Windows.Forms.Button();
			this.report2Btn = new System.Windows.Forms.Button();
			this.report1Btn = new System.Windows.Forms.Button();
			this.helloLbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// exitBtn
			// 
			this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.exitBtn.Location = new System.Drawing.Point(216, 351);
			this.exitBtn.Name = "exitBtn";
			this.exitBtn.Size = new System.Drawing.Size(110, 34);
			this.exitBtn.TabIndex = 7;
			this.exitBtn.Text = "Выйти";
			this.exitBtn.UseVisualStyleBackColor = true;
			this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
			// 
			// report2Btn
			// 
			this.report2Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.report2Btn.Location = new System.Drawing.Point(311, 241);
			this.report2Btn.Name = "report2Btn";
			this.report2Btn.Size = new System.Drawing.Size(92, 38);
			this.report2Btn.TabIndex = 6;
			this.report2Btn.Text = "Отчет 4";
			this.report2Btn.UseVisualStyleBackColor = true;
			// 
			// report1Btn
			// 
			this.report1Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.report1Btn.Location = new System.Drawing.Point(137, 241);
			this.report1Btn.Name = "report1Btn";
			this.report1Btn.Size = new System.Drawing.Size(92, 38);
			this.report1Btn.TabIndex = 5;
			this.report1Btn.Text = "Отчет 3";
			this.report1Btn.UseVisualStyleBackColor = true;
			// 
			// helloLbl
			// 
			this.helloLbl.AutoSize = true;
			this.helloLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.helloLbl.Location = new System.Drawing.Point(170, 68);
			this.helloLbl.Name = "helloLbl";
			this.helloLbl.Size = new System.Drawing.Size(114, 20);
			this.helloLbl.TabIndex = 4;
			this.helloLbl.Text = "Добрый день!";
			// 
			// MusicRatForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(540, 465);
			this.Controls.Add(this.exitBtn);
			this.Controls.Add(this.report2Btn);
			this.Controls.Add(this.report1Btn);
			this.Controls.Add(this.helloLbl);
			this.Name = "MusicRatForm";
			this.Text = "Форма музыкальной крысы";
			this.Load += new System.EventHandler(this.MusicRatForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button exitBtn;
		private System.Windows.Forms.Button report2Btn;
		private System.Windows.Forms.Button report1Btn;
		private System.Windows.Forms.Label helloLbl;
	}
}