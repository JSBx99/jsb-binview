namespace jsb_binview
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			menuStrip1 = new MenuStrip();
			fileToolStripMenuItem = new ToolStripMenuItem();
			dgvMain = new DataGridView();
			btnOpen = new Button();
			tableLayoutPanel1 = new TableLayoutPanel();
			label1 = new Label();
			splitContainer1 = new SplitContainer();
			txtBinaryVersion = new TextBox();
			lblBinaryVersion = new Label();
			txtDataChunkCount = new TextBox();
			menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
			tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(800, 24);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			fileToolStripMenuItem.Size = new Size(37, 20);
			fileToolStripMenuItem.Text = "File";
			// 
			// dgvMain
			// 
			dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvMain.Dock = DockStyle.Fill;
			dgvMain.Location = new Point(0, 0);
			dgvMain.Name = "dgvMain";
			dgvMain.Size = new Size(595, 391);
			dgvMain.TabIndex = 1;
			// 
			// btnOpen
			// 
			btnOpen.Dock = DockStyle.Bottom;
			btnOpen.Location = new Point(0, 334);
			btnOpen.Name = "btnOpen";
			btnOpen.Size = new Size(187, 57);
			btnOpen.TabIndex = 2;
			btnOpen.Text = "Open Binary";
			btnOpen.UseVisualStyleBackColor = true;
			btnOpen.Click += btnOpen_Click;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 6;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 115F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			tableLayoutPanel1.Controls.Add(label1, 2, 0);
			tableLayoutPanel1.Controls.Add(splitContainer1, 0, 1);
			tableLayoutPanel1.Controls.Add(txtBinaryVersion, 1, 0);
			tableLayoutPanel1.Controls.Add(lblBinaryVersion, 0, 0);
			tableLayoutPanel1.Controls.Add(txtDataChunkCount, 3, 0);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 24);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 2;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Size = new Size(800, 426);
			tableLayoutPanel1.TabIndex = 3;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Dock = DockStyle.Left;
			label1.Location = new Point(193, 0);
			label1.Name = "label1";
			label1.Size = new Size(108, 25);
			label1.TabIndex = 7;
			label1.Text = "Data Chunk Count:";
			label1.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// splitContainer1
			// 
			splitContainer1.BorderStyle = BorderStyle.Fixed3D;
			tableLayoutPanel1.SetColumnSpan(splitContainer1, 6);
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.Location = new Point(3, 28);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(dgvMain);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(btnOpen);
			splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
			splitContainer1.Size = new Size(794, 395);
			splitContainer1.SplitterDistance = 599;
			splitContainer1.TabIndex = 4;
			// 
			// txtBinaryVersion
			// 
			txtBinaryVersion.Location = new Point(93, 3);
			txtBinaryVersion.Name = "txtBinaryVersion";
			txtBinaryVersion.ReadOnly = true;
			txtBinaryVersion.Size = new Size(94, 23);
			txtBinaryVersion.TabIndex = 5;
			// 
			// lblBinaryVersion
			// 
			lblBinaryVersion.AutoSize = true;
			lblBinaryVersion.Dock = DockStyle.Left;
			lblBinaryVersion.Location = new Point(3, 0);
			lblBinaryVersion.Name = "lblBinaryVersion";
			lblBinaryVersion.Size = new Size(84, 25);
			lblBinaryVersion.TabIndex = 6;
			lblBinaryVersion.Text = "Binary Version:";
			lblBinaryVersion.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// txtDataChunkCount
			// 
			txtDataChunkCount.Location = new Point(308, 3);
			txtDataChunkCount.Name = "txtDataChunkCount";
			txtDataChunkCount.ReadOnly = true;
			txtDataChunkCount.Size = new Size(94, 23);
			txtDataChunkCount.TabIndex = 8;
			// 
			// frmMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(tableLayoutPanel1);
			Controls.Add(menuStrip1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MainMenuStrip = menuStrip1;
			Name = "frmMain";
			Text = "BinView";
			Load += frmMain_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem fileToolStripMenuItem;
		private DataGridView dgvMain;
		private Button btnOpen;
		private TableLayoutPanel tableLayoutPanel1;
		private SplitContainer splitContainer1;
		private TextBox txtBinaryVersion;
		private Label lblBinaryVersion;
		private Label label1;
		private TextBox txtDataChunkCount;
	}
}
