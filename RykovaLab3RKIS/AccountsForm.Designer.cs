namespace RykovaLab3RKIS
{
	partial class AccountsForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.userDataGridView = new System.Windows.Forms.DataGridView();
			this.AddBtn = new System.Windows.Forms.Button();
			this.EditBtn = new System.Windows.Forms.Button();
			this.DeleteBtn = new System.Windows.Forms.Button();
			this.ExitBtn = new System.Windows.Forms.Button();
			this.rykova_SampleDBDataSet = new RykovaLab3RKIS.Rykova_SampleDBDataSet();
			this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.usersTableAdapter = new RykovaLab3RKIS.Rykova_SampleDBDataSetTableAdapters.UsersTableAdapter();
			this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.roleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rykova_SampleDBDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(112, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(190, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Зарегистрированные пользователи";
			// 
			// userDataGridView
			// 
			this.userDataGridView.AutoGenerateColumns = false;
			this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.userDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.roleIdDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn});
			this.userDataGridView.DataSource = this.usersBindingSource;
			this.userDataGridView.Location = new System.Drawing.Point(34, 78);
			this.userDataGridView.Name = "userDataGridView";
			this.userDataGridView.Size = new System.Drawing.Size(466, 150);
			this.userDataGridView.TabIndex = 1;
			// 
			// AddBtn
			// 
			this.AddBtn.Location = new System.Drawing.Point(34, 290);
			this.AddBtn.Name = "AddBtn";
			this.AddBtn.Size = new System.Drawing.Size(75, 23);
			this.AddBtn.TabIndex = 2;
			this.AddBtn.Text = "Добавить";
			this.AddBtn.UseVisualStyleBackColor = true;
			this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
			// 
			// EditBtn
			// 
			this.EditBtn.Location = new System.Drawing.Point(145, 290);
			this.EditBtn.Name = "EditBtn";
			this.EditBtn.Size = new System.Drawing.Size(75, 23);
			this.EditBtn.TabIndex = 3;
			this.EditBtn.Text = "Изменить";
			this.EditBtn.UseVisualStyleBackColor = true;
			// 
			// DeleteBtn
			// 
			this.DeleteBtn.Location = new System.Drawing.Point(257, 290);
			this.DeleteBtn.Name = "DeleteBtn";
			this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
			this.DeleteBtn.TabIndex = 4;
			this.DeleteBtn.Text = "Удалить";
			this.DeleteBtn.UseVisualStyleBackColor = true;
			// 
			// ExitBtn
			// 
			this.ExitBtn.Location = new System.Drawing.Point(425, 290);
			this.ExitBtn.Name = "ExitBtn";
			this.ExitBtn.Size = new System.Drawing.Size(75, 23);
			this.ExitBtn.TabIndex = 5;
			this.ExitBtn.Text = "Выйти";
			this.ExitBtn.UseVisualStyleBackColor = true;
			// 
			// rykova_SampleDBDataSet
			// 
			this.rykova_SampleDBDataSet.DataSetName = "Rykova_SampleDBDataSet";
			this.rykova_SampleDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// usersBindingSource
			// 
			this.usersBindingSource.DataMember = "Users";
			this.usersBindingSource.DataSource = this.rykova_SampleDBDataSet;
			// 
			// usersTableAdapter
			// 
			this.usersTableAdapter.ClearBeforeFill = true;
			// 
			// loginDataGridViewTextBoxColumn
			// 
			this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
			this.loginDataGridViewTextBoxColumn.HeaderText = "login";
			this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
			// 
			// passwordDataGridViewTextBoxColumn
			// 
			this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
			this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
			this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
			// 
			// roleIdDataGridViewTextBoxColumn
			// 
			this.roleIdDataGridViewTextBoxColumn.DataPropertyName = "roleId";
			this.roleIdDataGridViewTextBoxColumn.HeaderText = "roleId";
			this.roleIdDataGridViewTextBoxColumn.Name = "roleIdDataGridViewTextBoxColumn";
			// 
			// fIODataGridViewTextBoxColumn
			// 
			this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
			this.fIODataGridViewTextBoxColumn.HeaderText = "FIO";
			this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
			// 
			// AccountsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(596, 450);
			this.Controls.Add(this.ExitBtn);
			this.Controls.Add(this.DeleteBtn);
			this.Controls.Add(this.EditBtn);
			this.Controls.Add(this.AddBtn);
			this.Controls.Add(this.userDataGridView);
			this.Controls.Add(this.label1);
			this.Name = "AccountsForm";
			this.Text = "Работа с учетными записями пользователей";
			this.Load += new System.EventHandler(this.AccountsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rykova_SampleDBDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView userDataGridView;
		private System.Windows.Forms.Button AddBtn;
		private System.Windows.Forms.Button EditBtn;
		private System.Windows.Forms.Button DeleteBtn;
		private System.Windows.Forms.Button ExitBtn;
		private Rykova_SampleDBDataSet rykova_SampleDBDataSet;
		private System.Windows.Forms.BindingSource usersBindingSource;
		private Rykova_SampleDBDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn roleIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
	}
}