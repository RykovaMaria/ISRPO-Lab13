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
	public partial class RatForm : Form
	{
		public RatForm()
		{
			InitializeComponent();
		}
        public Form prevForm = null;

		private void RatForm_Load(object sender, EventArgs e)
		{
            helloLbl.Text = "Добрый день, " + Program.USER.FIO + "!";
        }

		private void exitBtn_Click(object sender, EventArgs e)
		{
            this.Close();

            if (prevForm != null) prevForm.Show();
        }

		private void accountBtn_Click(object sender, EventArgs e)
		{
			AccountsForm f = new AccountsForm();
			f.Show();
			this.Hide();
		}
	}
}
