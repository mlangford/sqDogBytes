using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace sqDogBytes
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
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
	}
}
