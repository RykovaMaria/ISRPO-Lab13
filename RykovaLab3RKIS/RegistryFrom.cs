using RykovaLab3RKIS.ModelEF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RykovaLab3RKIS
{
	public partial class RegistryFrom : Form
	{
		public RegistryFrom()
		{
			InitializeComponent();
		}

		private void exitBtn_Click(object sender, EventArgs e)
		{
			this.Close();
			MainForm.FORMA.Show();
		}

		Model1 db = new Model1();

		private void registerBtn_Click(object sender, EventArgs e)
		{
			if (loginTxt.Text == "" || pswTxt.Text == "" || pswTxt.Text == "" || fioTxt.Text == "")
			{
				MessageBox.Show("Нужно задать все данные!");
				return;
			}

			if (pswTxt.Text != pswTxt2.Text)
			{
				MessageBox.Show("Значения паролей не совпадают!");
				return;
			}

			User usr = db.Users.Find(loginTxt.Text);
			if (usr != null)
			{
				MessageBox.Show("Пользователь с таким логином уже есть!");
				return;
			}

			usr = new User();
			usr.login = loginTxt.Text;
			usr.password = pswTxt.Text;
			usr.roleId = 1;
			usr.FIO = fioTxt.Text;
			db.Users.Add(usr);
			try
			{
				db.SaveChanges();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			MessageBox.Show("Пользователь " + usr.login + "зарегистрирован!");
			MainForm.FORMA.Show();
			this.Close();
			return;
		}

	}
}
