using RykovaLab3RKIS.ModelEF;
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
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		public static MainForm FORMA { get; set; }

		private void exitBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		static public Form prevForm = null;

		private void enterBtn_Click(object sender, EventArgs e)
		{
			if (loginTxt.Text == "" || pswTxt.Text == "")
			{
				MessageBox.Show("Нужно задать логин и пароль!");
			}

			User usr = Program.db.Users.Find(loginTxt.Text);

			if ((usr != null) && (usr.password == pswTxt.Text))
			{
				Program.USER = usr;

				if (usr.roleId == 1)
				{
					MainRatForm frm = new MainRatForm();
					frm.prevForm = this;
					frm.Show();
					this.Hide();
				}
				else if (usr.roleId == 2)
				{
					MusicRatForm frm = new MusicRatForm();
					frm.prevForm = this;
					frm.Show();
					this.Hide();
				}
				else if (usr.roleId == 3)
				{
                    RatForm frm = new RatForm();
                    frm.prevForm = this;
                    frm.Show();
                    this.Hide();
                }
			
			}
        }

		private void MainForm_Load(object sender, EventArgs e)
		{

		}

		private void regBtn_Click(object sender, EventArgs e)
		{
			RegistryFrom f = new RegistryFrom();
			this.Hide();
			f.Show();
		}
	}
}
