using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace sqDogBytes
{
    public partial class Form3: Form
    {
        public Form3(string inString)
        {
            InitializeComponent();
            conString = inString;
        }
        string conString;

        //declare a connection and datareader object
        SQLiteConnection dbcon;
        SQLiteDataReader dbreader;

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                dbcon = new SQLiteConnection(conString);
                dbcon.Open();

                SQLiteCommand dbcmd = dbcon.CreateCommand();
                dbcmd.CommandText = @"Select * From Item";

                dbreader = dbcmd.ExecuteReader();

                if (dbreader.Read())
                {
                    lblDesc.Text = dbreader["Details"].ToString();
                    lblCost.Text = "Cost per unit : £" + dbreader["Price"].ToString();
                    lblStock.Text = "Stock level : " + dbreader[3].ToString();
                    pictureBox1.Image = Image.FromFile(dbreader["Display"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (dbreader.Read())
            {
                lblDesc.Text = dbreader["Details"].ToString();
                lblCost.Text = "Cost per unit : £" + dbreader["Price"].ToString();
                lblStock.Text = "Stock level : " + dbreader["Stock"].ToString();
                pictureBox1.Image = Image.FromFile(dbreader["Display"].ToString());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            dbcon.Close();
            this.Close();
        }
    }
}
