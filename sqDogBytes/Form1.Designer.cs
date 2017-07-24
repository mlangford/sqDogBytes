namespace sqDogBytes
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.mnuConnect = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuSet = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuTest = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbExit = new System.Windows.Forms.ToolStripButton();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.ssCon = new System.Windows.Forms.ToolStripStatusLabel();
			this.ssDB = new System.Windows.Forms.ToolStripStatusLabel();
			this.tbSet = new System.Windows.Forms.ToolStripButton();
			this.tbTest = new System.Windows.Forms.ToolStripButton();
			this.tbClose = new System.Windows.Forms.ToolStripButton();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuConnect,
            this.mnuHelp,
            this.mnuExit});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.menuStrip1.Size = new System.Drawing.Size(602, 36);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// mnuConnect
			// 
			this.mnuConnect.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSet,
            this.mnuTest,
            this.toolStripMenuItem1});
			this.mnuConnect.Name = "mnuConnect";
			this.mnuConnect.Size = new System.Drawing.Size(96, 32);
			this.mnuConnect.Text = "Connect";
			// 
			// mnuSet
			// 
			this.mnuSet.Name = "mnuSet";
			this.mnuSet.Size = new System.Drawing.Size(228, 32);
			this.mnuSet.Text = "&Select Database";
			this.mnuSet.Click += new System.EventHandler(this.mnuSet_Click);
			// 
			// mnuTest
			// 
			this.mnuTest.Enabled = false;
			this.mnuTest.Name = "mnuTest";
			this.mnuTest.Size = new System.Drawing.Size(228, 32);
			this.mnuTest.Text = "&Test";
			this.mnuTest.Click += new System.EventHandler(this.mnuTest_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(225, 6);
			// 
			// mnuHelp
			// 
			this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
			this.mnuHelp.Name = "mnuHelp";
			this.mnuHelp.Size = new System.Drawing.Size(65, 32);
			this.mnuHelp.Text = "Help";
			// 
			// mnuAbout
			// 
			this.mnuAbout.Name = "mnuAbout";
			this.mnuAbout.Size = new System.Drawing.Size(145, 32);
			this.mnuAbout.Text = "About";
			// 
			// mnuExit
			// 
			this.mnuExit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuClose});
			this.mnuExit.Name = "mnuExit";
			this.mnuExit.Size = new System.Drawing.Size(55, 32);
			this.mnuExit.Text = "Exit";
			// 
			// mnuClose
			// 
			this.mnuClose.Name = "mnuClose";
			this.mnuClose.Size = new System.Drawing.Size(218, 32);
			this.mnuClose.Text = "Close Program";
			this.mnuClose.Click += new System.EventHandler(this.mnuClose_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.AutoSize = false;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbSet,
            this.toolStripSeparator1,
            this.tbTest,
            this.tbClose,
            this.toolStripSeparator2,
            this.tsbExit});
			this.toolStrip1.Location = new System.Drawing.Point(0, 36);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(602, 68);
			this.toolStrip1.TabIndex = 3;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.AutoSize = false;
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(16, 68);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.AutoSize = false;
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(16, 68);
			// 
			// tsbExit
			// 
			this.tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbExit.Name = "tsbExit";
			this.tsbExit.Size = new System.Drawing.Size(23, 65);
			this.tsbExit.Text = "Quit";
			// 
			// statusStrip1
			// 
			this.statusStrip1.AutoSize = false;
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssDB,
            this.ssCon});
			this.statusStrip1.Location = new System.Drawing.Point(0, 418);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(602, 45);
			this.statusStrip1.TabIndex = 4;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// ssCon
			// 
			this.ssCon.Image = global::sqDogBytes.Properties.Resources.off_icon;
			this.ssCon.Name = "ssCon";
			this.ssCon.Size = new System.Drawing.Size(54, 40);
			this.ssCon.Text = " Off";
			this.ssCon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ssDB
			// 
			this.ssDB.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ssDB.Image = global::sqDogBytes.Properties.Resources.db_unpicked;
			this.ssDB.Name = "ssDB";
			this.ssDB.Size = new System.Drawing.Size(45, 40);
			this.ssDB.Text = "    ";
			// 
			// tbSet
			// 
			this.tbSet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbSet.Image = global::sqDogBytes.Properties.Resources.sqlite_logo;
			this.tbSet.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbSet.Name = "tbSet";
			this.tbSet.Size = new System.Drawing.Size(52, 65);
			this.tbSet.Text = "Select";
			this.tbSet.Click += new System.EventHandler(this.tbSet_Click);
			// 
			// tbTest
			// 
			this.tbTest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbTest.Enabled = false;
			this.tbTest.Image = ((System.Drawing.Image)(resources.GetObject("tbTest.Image")));
			this.tbTest.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbTest.Name = "tbTest";
			this.tbTest.Size = new System.Drawing.Size(52, 65);
			this.tbTest.Text = "Test";
			this.tbTest.Click += new System.EventHandler(this.tbTest_Click);
			// 
			// tbClose
			// 
			this.tbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbClose.Image = ((System.Drawing.Image)(resources.GetObject("tbClose.Image")));
			this.tbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbClose.Name = "tbClose";
			this.tbClose.Size = new System.Drawing.Size(52, 65);
			this.tbClose.Text = "Exit";
			this.tbClose.Click += new System.EventHandler(this.tbClose_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(1, 167);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(216, 180);
			this.label1.TabIndex = 6;
			this.label1.Text = "Welcome\r\nTo\r\nDogBytes";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(264, 104);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(338, 314);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(602, 463);
			this.ControlBox = false;
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "Form1";
			this.Text = "DogBytes Ordering System";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem mnuConnect;
		private System.Windows.Forms.ToolStripMenuItem mnuSet;
		private System.Windows.Forms.ToolStripMenuItem mnuTest;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem mnuHelp;
		private System.Windows.Forms.ToolStripMenuItem mnuAbout;
		private System.Windows.Forms.ToolStripMenuItem mnuExit;
		private System.Windows.Forms.ToolStripMenuItem mnuClose;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tbSet;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton tbTest;
		private System.Windows.Forms.ToolStripButton tbClose;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton tsbExit;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel ssDB;
		private System.Windows.Forms.ToolStripStatusLabel ssCon;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}

