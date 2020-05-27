using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excursion
{
	public partial class Form2 : Form
	{
		List<Excursion> Books;
		DataGridView excursionGridView;

		public Form2(List<Excursion> Books, DataGridView bookGridView)
		{
			InitializeComponent();
			this.Books = Books;
			this.excursionGridView = bookGridView;
		}

		public void AddExcursion()
		{
			if (countryTB.Text == "" || guideTB.Text == "" || PriceTB.Text == "" || durationTB.Text == "")
			{
				errorMessageLabel.Text = "Please, input all the values";
			}
			else
			{
				errorMessageLabel.Text = "";
				string a = $"{countryTB.Text} {guideTB.Text} {PriceTB.Text} {durationTB.Text}";
				this.excursionGridView.DataSource = null;
				this.Books.Add(Excursion.Parse(a));
				excursionGridView.DataSource = this.Books;
				this.Hide();
			}
		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}

		private void Add_Click(object sender, EventArgs e)
		{
			AddExcursion();
		}
	}
}
