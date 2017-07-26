using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace sqDogBytes
{
    public partial class Form4: Form
    {
        public Form4(string inString)
        {
            InitializeComponent();
            conString = inString;
        }
        string conString;
        SQLiteConnection dbcon;

        SQLiteDataAdapter daitems;
        DataTable dtitems = new DataTable();
        int rowAt;

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                dbcon = new SQLiteConnection(conString);
                string sqlcommand = @"Select * From item";

                daitems = new SQLiteDataAdapter(sqlcommand, dbcon);
                daitems.Fill(dtitems);

                rowAt = 0;
                showrecord();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void showrecord()
        {
            //get the specified row in the datatable
            DataRow row = dtitems.Rows[rowAt];

            // equivalent to code below, but using numeric column indices
            //lblDesc.Text = row[1].ToString();
            //lblCost.Text = "Cost per unit : £" + row[2].ToString();
            //lblStock.Text = "Stock level : " + row[3].ToString();
            //pictureBox1.Image = Image.FromFile(row[4].ToString());

            lblDesc.Text = row["Details"].ToString();
            lblCost.Text = "Cost per unit : £" + row["Price"].ToString();
            lblStock.Text = "Stock level : " + row["Stock"].ToString();
            pictureBox1.Image = Image.FromFile(row["Display"].ToString());
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (rowAt < dtitems.Rows.Count - 1)
            {
                rowAt++;
            }
            else
            {
                rowAt = 0;
            }
            showrecord();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (rowAt > 0)
            {
                rowAt--;
            }
            else
            {
                rowAt = dtitems.Rows.Count - 1;
            }
            showrecord();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            SQLiteCommandBuilder cbitems = new SQLiteCommandBuilder(daitems);
            daitems.Update(dtitems);
            this.Close();
        }

        private void btnNewPrice_Click(object sender, EventArgs e)
        {
            btnNewPrice.Enabled = false;
            btnSubmit.Enabled = true;
            btnCancel.Enabled = true;
            txtNewPrice.Enabled = true;
            btnNext.Enabled = false;
            btnPrev.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnNewPrice.Enabled = true;
            btnSubmit.Enabled = false;
            btnCancel.Enabled = false;
            txtNewPrice.Enabled = false;
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DataRow row = dtitems.Rows[rowAt];
            row["Price"] = txtNewPrice.Text;

            btnCancel_Click(sender, e);
            txtNewPrice.Clear();
            showrecord();
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
        }

    }
}
