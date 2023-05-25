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
	public partial class MainRatForm : Form
	{
		public MainRatForm()
		{
			InitializeComponent();
		}
		public Form prevForm = null;

		private void MainRatForm_Load(object sender, EventArgs e)
		{
            helloLbl.Text = "Добрый день, " + Program.USER.FIO + "!";
        }

		private void exitBtn_Click(object sender, EventArgs e)
		{
			this.Close();

			if (prevForm != null) prevForm.Show();
		}
	}
}
