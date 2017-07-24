using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace sqDogBytes
{
	public partial class Form2 : Form
	{
		public Form2(string inString)
		{
			InitializeComponent();
			conString = inString;
		}

		string conString;

		//create a connection object
		SQLiteConnection dbcon = new SQLiteConnection();
		//declare a command object
		SQLiteCommand dbcmd;

		private void btnNew_Click(object sender, EventArgs e)
		{
			try
			{
				dbcon.ConnectionString = conString;
				dbcmd = dbcon.CreateCommand();
				dbcmd.CommandText =
				 @"Insert into customer(customername, address) Values (@name, @addr)";

				dbcmd.Parameters.AddWithValue("name", txtName.Text);
				dbcmd.Parameters.AddWithValue("address", txtAddress.Text);

				dbcon.Open();
				int recordsChanged = dbcmd.ExecuteNonQuery();
				MessageBox.Show(recordsChanged.ToString() + " records added");
				dbcon.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}

		private void btnModify_Click(object sender, EventArgs e)
		{
			try
			{
				dbcon.ConnectionString = conString;
				dbcmd = dbcon.CreateCommand();
				dbcmd.CommandText =
				 @"Update customer Set address =@addr Where customerid=@recd";

				dbcmd.Parameters.AddWithValue("addr", txtAddress.Text);
				dbcmd.Parameters.AddWithValue("recd", Convert.ToInt32(txtID2.Text));

				dbcon.Open();
				int recordsChanged = dbcmd.ExecuteNonQuery();
				MessageBox.Show(recordsChanged.ToString() + " records modified");
				dbcon.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				dbcon.ConnectionString = conString;
				dbcmd = dbcon.CreateCommand();
				dbcmd.CommandText =
				 @"Delete From customer Where customerid=@recd";

				dbcmd.Parameters.AddWithValue("recd", Convert.ToInt32(txtID3.Text));

				dbcon.Open();
				int recordsChanged = dbcmd.ExecuteNonQuery();
				MessageBox.Show(recordsChanged.ToString() + " records deleted");
				dbcon.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}
	}
}
