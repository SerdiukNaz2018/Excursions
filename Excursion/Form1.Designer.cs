namespace Excursion
{
	partial class Form1
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
			this.deleteErrorMessage = new System.Windows.Forms.Label();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.newBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteSecektedBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.excursionGridView = new System.Windows.Forms.DataGridView();
			this.currentFileLabel = new System.Windows.Forms.Label();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.Update = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.newDuration = new System.Windows.Forms.TextBox();
			this.newPrice = new System.Windows.Forms.TextBox();
			this.newGuide = new System.Windows.Forms.TextBox();
			this.newCountry = new System.Windows.Forms.TextBox();
			this.Reverse = new System.Windows.Forms.Button();
			this.refresh = new System.Windows.Forms.CheckBox();
			this.Read = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.excursionGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// deleteErrorMessage
			// 
			this.deleteErrorMessage.AutoSize = true;
			this.deleteErrorMessage.ForeColor = System.Drawing.Color.Red;
			this.deleteErrorMessage.Location = new System.Drawing.Point(702, 457);
			this.deleteErrorMessage.Name = "deleteErrorMessage";
			this.deleteErrorMessage.Size = new System.Drawing.Size(0, 17);
			this.deleteErrorMessage.TabIndex = 27;
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBookToolStripMenuItem,
            this.deleteSecektedBookToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(53, 24);
			this.toolStripMenuItem1.Text = "Item";
			// 
			// newBookToolStripMenuItem
			// 
			this.newBookToolStripMenuItem.Name = "newBookToolStripMenuItem";
			this.newBookToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
			this.newBookToolStripMenuItem.Text = "Add New";
			this.newBookToolStripMenuItem.Click += new System.EventHandler(this.newBookToolStripMenuItem_Click);
			// 
			// deleteSecektedBookToolStripMenuItem
			// 
			this.deleteSecektedBookToolStripMenuItem.Name = "deleteSecektedBookToolStripMenuItem";
			this.deleteSecektedBookToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
			this.deleteSecektedBookToolStripMenuItem.Text = "Delete";
			this.deleteSecektedBookToolStripMenuItem.Click += new System.EventHandler(this.deleteSecektedBookToolStripMenuItem_Click);
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem2,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 26);
			this.toolStripMenuItem3.Text = "Open";
			this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 26);
			this.toolStripMenuItem2.Text = "Save";
			this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
			this.saveAsToolStripMenuItem.Text = "Save As...";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.aboutAuthorToolStripMenuItem});
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
			this.aboutToolStripMenuItem.Text = "Help";
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
			this.viewToolStripMenuItem.Text = "About App";
			this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
			// 
			// aboutAuthorToolStripMenuItem
			// 
			this.aboutAuthorToolStripMenuItem.Name = "aboutAuthorToolStripMenuItem";
			this.aboutAuthorToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
			this.aboutAuthorToolStripMenuItem.Text = "About Author";
			this.aboutAuthorToolStripMenuItem.Click += new System.EventHandler(this.aboutAuthorToolStripMenuItem_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.aboutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(940, 28);
			this.menuStrip1.TabIndex = 28;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// excursionGridView
			// 
			this.excursionGridView.AllowUserToAddRows = false;
			this.excursionGridView.AllowUserToDeleteRows = false;
			this.excursionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.excursionGridView.Location = new System.Drawing.Point(316, 45);
			this.excursionGridView.Name = "excursionGridView";
			this.excursionGridView.ReadOnly = true;
			this.excursionGridView.RowHeadersWidth = 51;
			this.excursionGridView.RowTemplate.Height = 24;
			this.excursionGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.excursionGridView.Size = new System.Drawing.Size(602, 387);
			this.excursionGridView.TabIndex = 0;
			// 
			// currentFileLabel
			// 
			this.currentFileLabel.AutoSize = true;
			this.currentFileLabel.Location = new System.Drawing.Point(313, 25);
			this.currentFileLabel.Name = "currentFileLabel";
			this.currentFileLabel.Size = new System.Drawing.Size(0, 17);
			this.currentFileLabel.TabIndex = 29;
			// 
			// splitter1
			// 
			this.splitter1.BackColor = System.Drawing.Color.LightGray;
			this.splitter1.Location = new System.Drawing.Point(0, 28);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(294, 431);
			this.splitter1.TabIndex = 30;
			this.splitter1.TabStop = false;
			// 
			// Update
			// 
			this.Update.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.Update.Location = new System.Drawing.Point(22, 381);
			this.Update.Name = "Update";
			this.Update.Size = new System.Drawing.Size(242, 51);
			this.Update.TabIndex = 60;
			this.Update.Text = "Update";
			this.Update.UseVisualStyleBackColor = false;
			this.Update.Click += new System.EventHandler(this.Update_Click_1);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.LightGray;
			this.label2.Location = new System.Drawing.Point(19, 343);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 17);
			this.label2.TabIndex = 59;
			this.label2.Text = "New Duration";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.LightGray;
			this.label3.Location = new System.Drawing.Point(19, 315);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 17);
			this.label3.TabIndex = 58;
			this.label3.Text = "New Price";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.LightGray;
			this.label5.Location = new System.Drawing.Point(19, 287);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(77, 17);
			this.label5.TabIndex = 57;
			this.label5.Text = "New Guide";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.LightGray;
			this.label6.Location = new System.Drawing.Point(19, 259);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 17);
			this.label6.TabIndex = 56;
			this.label6.Text = "New Country";
			// 
			// newDuration
			// 
			this.newDuration.Location = new System.Drawing.Point(122, 338);
			this.newDuration.Name = "newDuration";
			this.newDuration.Size = new System.Drawing.Size(142, 22);
			this.newDuration.TabIndex = 55;
			// 
			// newPrice
			// 
			this.newPrice.Location = new System.Drawing.Point(122, 310);
			this.newPrice.Name = "newPrice";
			this.newPrice.Size = new System.Drawing.Size(142, 22);
			this.newPrice.TabIndex = 54;
			// 
			// newGuide
			// 
			this.newGuide.Location = new System.Drawing.Point(122, 282);
			this.newGuide.Name = "newGuide";
			this.newGuide.Size = new System.Drawing.Size(142, 22);
			this.newGuide.TabIndex = 53;
			// 
			// newCountry
			// 
			this.newCountry.Location = new System.Drawing.Point(122, 254);
			this.newCountry.Name = "newCountry";
			this.newCountry.Size = new System.Drawing.Size(142, 22);
			this.newCountry.TabIndex = 52;
			// 
			// Reverse
			// 
			this.Reverse.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.Reverse.Location = new System.Drawing.Point(22, 187);
			this.Reverse.Name = "Reverse";
			this.Reverse.Size = new System.Drawing.Size(242, 47);
			this.Reverse.TabIndex = 51;
			this.Reverse.Text = "Reverse";
			this.Reverse.UseVisualStyleBackColor = false;
			this.Reverse.Click += new System.EventHandler(this.Reverse_Click_1);
			// 
			// refresh
			// 
			this.refresh.AutoSize = true;
			this.refresh.BackColor = System.Drawing.Color.LightGray;
			this.refresh.Location = new System.Drawing.Point(22, 99);
			this.refresh.Name = "refresh";
			this.refresh.Size = new System.Drawing.Size(152, 21);
			this.refresh.TabIndex = 50;
			this.refresh.Text = "Replace current list";
			this.refresh.UseVisualStyleBackColor = false;
			// 
			// Read
			// 
			this.Read.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.Read.Location = new System.Drawing.Point(22, 42);
			this.Read.Name = "Read";
			this.Read.Size = new System.Drawing.Size(242, 51);
			this.Read.TabIndex = 49;
			this.Read.Text = "Read from current file";
			this.Read.UseVisualStyleBackColor = false;
			this.Read.Click += new System.EventHandler(this.Read_Click_1);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(22, 143);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(242, 24);
			this.comboBox1.TabIndex = 48;
			this.comboBox1.Text = "Sort by: ";
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(940, 459);
			this.Controls.Add(this.Update);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.newDuration);
			this.Controls.Add(this.newPrice);
			this.Controls.Add(this.newGuide);
			this.Controls.Add(this.newCountry);
			this.Controls.Add(this.Reverse);
			this.Controls.Add(this.refresh);
			this.Controls.Add(this.Read);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.currentFileLabel);
			this.Controls.Add(this.deleteErrorMessage);
			this.Controls.Add(this.excursionGridView);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Excursions";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.excursionGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label deleteErrorMessage;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newBookToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteSecektedBookToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutAuthorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.DataGridView excursionGridView;
		private System.Windows.Forms.Label currentFileLabel;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Button Update;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox newDuration;
		private System.Windows.Forms.TextBox newPrice;
		private System.Windows.Forms.TextBox newGuide;
		private System.Windows.Forms.TextBox newCountry;
		private System.Windows.Forms.Button Reverse;
		private System.Windows.Forms.CheckBox refresh;
		private System.Windows.Forms.Button Read;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}

