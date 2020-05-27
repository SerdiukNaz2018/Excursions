namespace Excursion
{
	partial class Form2
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
			this.Add = new System.Windows.Forms.Button();
			this.errorMessageLabel = new System.Windows.Forms.Label();
			this.pagesAmountLabel = new System.Windows.Forms.Label();
			this.yearLabel = new System.Windows.Forms.Label();
			this.authorLabel = new System.Windows.Forms.Label();
			this.titleLabel = new System.Windows.Forms.Label();
			this.durationTB = new System.Windows.Forms.TextBox();
			this.PriceTB = new System.Windows.Forms.TextBox();
			this.guideTB = new System.Windows.Forms.TextBox();
			this.countryTB = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Add
			// 
			this.Add.Location = new System.Drawing.Point(204, 193);
			this.Add.Name = "Add";
			this.Add.Size = new System.Drawing.Size(216, 50);
			this.Add.TabIndex = 35;
			this.Add.Text = "Add";
			this.Add.UseVisualStyleBackColor = true;
			// 
			// errorMessageLabel
			// 
			this.errorMessageLabel.AutoSize = true;
			this.errorMessageLabel.ForeColor = System.Drawing.Color.Red;
			this.errorMessageLabel.Location = new System.Drawing.Point(261, 163);
			this.errorMessageLabel.Name = "errorMessageLabel";
			this.errorMessageLabel.Size = new System.Drawing.Size(0, 17);
			this.errorMessageLabel.TabIndex = 34;
			// 
			// pagesAmountLabel
			// 
			this.pagesAmountLabel.AutoSize = true;
			this.pagesAmountLabel.Location = new System.Drawing.Point(330, 122);
			this.pagesAmountLabel.Name = "pagesAmountLabel";
			this.pagesAmountLabel.Size = new System.Drawing.Size(62, 17);
			this.pagesAmountLabel.TabIndex = 33;
			this.pagesAmountLabel.Text = "Duration";
			// 
			// yearLabel
			// 
			this.yearLabel.AutoSize = true;
			this.yearLabel.Location = new System.Drawing.Point(330, 97);
			this.yearLabel.Name = "yearLabel";
			this.yearLabel.Size = new System.Drawing.Size(40, 17);
			this.yearLabel.TabIndex = 32;
			this.yearLabel.Text = "Price";
			// 
			// authorLabel
			// 
			this.authorLabel.AutoSize = true;
			this.authorLabel.Location = new System.Drawing.Point(23, 127);
			this.authorLabel.Name = "authorLabel";
			this.authorLabel.Size = new System.Drawing.Size(46, 17);
			this.authorLabel.TabIndex = 31;
			this.authorLabel.Text = "Guide";
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Location = new System.Drawing.Point(23, 99);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(57, 17);
			this.titleLabel.TabIndex = 30;
			this.titleLabel.Text = "Country";
			// 
			// durationTB
			// 
			this.durationTB.Location = new System.Drawing.Point(395, 122);
			this.durationTB.Name = "durationTB";
			this.durationTB.Size = new System.Drawing.Size(216, 22);
			this.durationTB.TabIndex = 29;
			// 
			// PriceTB
			// 
			this.PriceTB.Location = new System.Drawing.Point(396, 94);
			this.PriceTB.Name = "PriceTB";
			this.PriceTB.Size = new System.Drawing.Size(216, 22);
			this.PriceTB.TabIndex = 28;
			// 
			// guideTB
			// 
			this.guideTB.Location = new System.Drawing.Point(89, 124);
			this.guideTB.Name = "guideTB";
			this.guideTB.Size = new System.Drawing.Size(216, 22);
			this.guideTB.TabIndex = 27;
			// 
			// countryTB
			// 
			this.countryTB.Location = new System.Drawing.Point(89, 96);
			this.countryTB.Name = "countryTB";
			this.countryTB.Size = new System.Drawing.Size(216, 22);
			this.countryTB.TabIndex = 26;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(226, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(194, 29);
			this.label1.TabIndex = 36;
			this.label1.Text = "New Excursion";
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(640, 265);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Add);
			this.Controls.Add(this.errorMessageLabel);
			this.Controls.Add(this.pagesAmountLabel);
			this.Controls.Add(this.yearLabel);
			this.Controls.Add(this.authorLabel);
			this.Controls.Add(this.titleLabel);
			this.Controls.Add(this.durationTB);
			this.Controls.Add(this.PriceTB);
			this.Controls.Add(this.guideTB);
			this.Controls.Add(this.countryTB);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form2";
			this.Text = "New Book";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Add;
		private System.Windows.Forms.Label errorMessageLabel;
		private System.Windows.Forms.Label pagesAmountLabel;
		private System.Windows.Forms.Label yearLabel;
		private System.Windows.Forms.Label authorLabel;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.TextBox durationTB;
		private System.Windows.Forms.TextBox PriceTB;
		private System.Windows.Forms.TextBox guideTB;
		private System.Windows.Forms.TextBox countryTB;
		private System.Windows.Forms.Label label1;
	}
}