using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RykovaLab3RKIS
{
	public partial class AccountsForm : Form
	{
		public AccountsForm()
		{
			InitializeComponent();
		}

		private void AddBtn_Click(object sender, EventArgs e)
		{
			RegistryFrom f = new RegistryFrom();
			this.Hide();
			f.Show();
		}

		private void AccountsForm_Load(object sender, EventArgs e)
		{
			this.usersTableAdapter.Fill(this.rykova_SampleDBDataSet.Users);
		}
	}
}
