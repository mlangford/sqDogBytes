using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace sqDogBytes
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			//makes the application appear centre screen
			this.StartPosition = FormStartPosition.CenterScreen;
		}

		//create a connection object
		SQLiteConnection dbcon = new SQLiteConnection();

		//set up a string variable for the connection details
		public string conString;

		private void tbSet_Click(object sender, EventArgs e)
		{
			mnuSet_Click(sender, e);
		}

		private void mnuSet_Click(object sender, EventArgs e)
		{
			openFileDialog1.Title = "Select SQLite database file";
			openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			openFileDialog1.Filter = "Database files (*.db)|*.db";
			openFileDialog1.FilterIndex = 1;
			openFileDialog1.FileName = "";
			if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
			{
				conString = @"Data Source =" + openFileDialog1.FileName;
				mnuTest.Enabled = true;
				tbTest.Enabled = true;
				ssDB.Image = Properties.Resources.db_picked;
			}
			else
			{
				mnuTest.Enabled = false;
				tbTest.Enabled = false;
				conString = "Data Source =";
				ssDB.Image = Properties.Resources.db_unpicked;
			}
		}

		private void tbTest_Click(object sender, EventArgs e)
		{
			mnuTest_Click(sender, e);
		}

		private void mnuTest_Click(object sender, EventArgs e)
		{
			try
			{
				dbcon.ConnectionString = conString;
				dbcon.Open();
				if (dbcon.State == System.Data.ConnectionState.Open)
				{
					ssCon.Image = Properties.Resources.on_icon;
					ssCon.Text = "On";

					tbTest.Enabled = false;
					mnuTest.Enabled = false;

					timer1.Interval = 2000;
					timer1.Start();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			timer1.Stop();
			dbcon.Close();
			if (dbcon.State == System.Data.ConnectionState.Closed)
			{
				ssCon.Image = Properties.Resources.off_icon;
				ssCon.Text = "Off";
			}
			tbTest.Enabled = true;
			mnuTest.Enabled = true;
		}

		private void tbClose_Click(object sender, EventArgs e)
		{
			mnuClose_Click(sender, e);
		}

		private void mnuClose_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Really quit ?", "Exit",
						   MessageBoxButtons.OKCancel,
						   MessageBoxIcon.Question) == DialogResult.OK)
			{
				Application.Exit();
			}
		}


		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				using (StreamWriter sw = new StreamWriter("dogbytes.cnfg"))
				{
					sw.Write(conString);
				}
			}
			catch { }
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			try
			{
				using (StreamReader sr = new StreamReader("dogbytes.cnfg"))
				{
					conString = sr.ReadLine();
					if (conString != "Data Source =")
					{
						mnuTest.Enabled = true;
						tbTest.Enabled = true;
						ssDB.Image = Properties.Resources.db_picked;
					}
				}
			}
			catch
			{
				mnuTest.Enabled = false;
				tbTest.Enabled = false;
				ssDB.Image = Properties.Resources.db_unpicked;
			}
		}

		private void mnuAbout_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Another brilliant program\n\rwritten by Mitch Langford");
		}

		private void mnuCustomer_Click(object sender, EventArgs e)
		{
			Form2 frmCustomer = new Form2(conString);
			frmCustomer.ShowDialog();
		}
	}
}
