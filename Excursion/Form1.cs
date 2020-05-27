using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Excursion
{
	public partial class Form1 : Form
	{
		public string FileName { get; private set; }
		public List<Excursion> Excursions { get; private set; }

		public Form1()
		{
			InitializeComponent();
		}

		public void initializeProps()
		{
			this.Excursions = new List<Excursion>();
			this.FileName = "";
		}

		public void ReadBooksFromCurrentFile()
		{
			var excursionText = File.ReadAllLines(this.FileName);
			foreach(string excText in excursionText)
			{
				this.Excursions.Add(Excursion.Parse(excText));
			}
			excursionGridView.DataSource = null;
			excursionGridView.DataSource = this.Excursions;
		}

		public void DeleteExcursion()
		{
			
			if (excursionGridView.SelectedRows.Count != 0)
			{
				if (MessageBox.Show("Are you sure?", "Delete a book", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					for (int i = 0; i < excursionGridView.SelectedRows.Count; ++i)
					{
						var row = excursionGridView.SelectedRows[i];
						string a = $"{row.Cells[0].Value} {row.Cells[1].Value} {row.Cells[2].Value} {row.Cells[3].Value}";
						Excursion selected = Excursion.Parse(a);
						this.Excursions = this.Excursions.Where(item => item != selected).ToList();
					}
					excursionGridView.DataSource = null;
					excursionGridView.DataSource = this.Excursions;
				}
			}
		}

		public void SwitchFile(string newFileName)
		{
			this.FileName = newFileName;
		}

		public void SaveToCurrentFile()
		{
			string excursionstxt = "";
			foreach (Excursion item in this.Excursions)
			{
				excursionstxt += item.ToString() + '\n';
			}
			File.WriteAllText(this.FileName, excursionstxt);
		}

		public void SaveToNewFile()
		{
			string allExcursionstxt = "";
			foreach (Excursion book in this.Excursions)
			{
				allExcursionstxt += book.ToString() + '\n';
			}

			SaveFileDialog sfd = new SaveFileDialog();
			if (sfd.ShowDialog() == DialogResult.OK)
			{
				using (Stream s = File.Open(sfd.FileName, FileMode.CreateNew))
				using (StreamWriter sw = new StreamWriter(s))
				{
					sw.Write(allExcursionstxt);
				}
			}
		}

		void SortExcursionBy(string crit)
		{
			switch (crit)
			{
				case "Country":
					this.Excursions = this.Excursions.OrderBy(item => item.Country).ToList();
					break;
				case "Price":
					this.Excursions = this.Excursions.OrderBy(item => item.Price).ToList();
					break;
				case "Duration":
					this.Excursions = this.Excursions.OrderBy(item => item.Duration).ToList();
					break;
				case "Guide":
					this.Excursions = this.Excursions.OrderBy(item => item.Guide).ToList();
					break;
				default:
					break;
			}
			excursionGridView.DataSource = null;
			excursionGridView.DataSource = this.Excursions;
		}

		public void UpdateExcursion()
		{
			if (this.excursionGridView.SelectedRows.Count != 0)
			{
				var row = this.excursionGridView.SelectedRows[0];
				string a = $"{row.Cells[0].Value} {row.Cells[1].Value} {row.Cells[2].Value} {row.Cells[3].Value}";
				Excursion selected = Excursion.Parse(a);

				int curInd = 0;

				for (int i = 1; i < this.Excursions.Count; ++i)
				{
					if (this.Excursions.ElementAt(i) == selected)
					{
						curInd = i;
						break;
					}
				}
				var rowInd = excursionGridView.CurrentCell.RowIndex;
				this.Excursions = this.Excursions.Where(item => item != selected).ToList();

				selected.Country = newCountry.Text != "" ? newCountry.Text : selected.Country;
				selected.Price = newPrice.Text != "" ? Int32.Parse(newPrice.Text) : selected.Price;
				selected.Duration = newDuration.Text != "" ? Int32.Parse(newDuration.Text) : selected.Duration;
				selected.Guide = newGuide.Text != "" ? newGuide.Text : selected.Guide;


				this.Excursions.Insert(curInd, selected);

				this.excursionGridView.DataSource = null;
				this.excursionGridView.DataSource = this.Excursions;
				this.excursionGridView.ClearSelection();
				this.excursionGridView.Rows[rowInd].Selected = true;
			}
		}


		private void Form1_Load(object sender, EventArgs e)
		{
			this.initializeProps();
			this.currentFileLabel.Text += this.FileName;

			comboBox1.Items.Add("Country");
			comboBox1.Items.Add("Guide");
			comboBox1.Items.Add("Price");
			comboBox1.Items.Add("Duration");
		}

		private void toolStripMenuItem3_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.ShowDialog();
			currentFileLabel.Text = $"{ofd.FileName}";
			this.SwitchFile(ofd.FileName);
		}

		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
			this.SaveToCurrentFile();
		}

		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.SaveToNewFile();
		}

		private void newBookToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form2 = new Form2(this.Excursions, excursionGridView);
			form2.ShowDialog();
		}

		private void deleteSecektedBookToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DeleteExcursion();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void viewToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form5 viewForm = new Form5();
			viewForm.ShowDialog();
		}

		private void aboutAuthorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form4 viewForm = new Form4();
			viewForm.ShowDialog();
		}

		private void Read_Click_1(object sender, EventArgs e)
		{
			if (refresh.Checked)
			{
				this.Excursions.Clear();
			}

			this.ReadBooksFromCurrentFile();
		}

		private void Reverse_Click_1(object sender, EventArgs e)
		{
			this.Excursions.Reverse();
			excursionGridView.DataSource = null;
			excursionGridView.DataSource = this.Excursions;
		}

		private void Update_Click_1(object sender, EventArgs e)
		{
			this.UpdateExcursion();
		}

		private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			this.SortExcursionBy(comboBox1.Text);
		}
	}
}
