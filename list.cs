using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_Management
{
    public partial class list : Form
    {
        public list()
        {
            InitializeComponent();
            Showdate();
        }

        private void list_Load(object sender, EventArgs e)
        {
            Showdate();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OG2GV0R;Integrated Security=SSPI;Initial Catalog=pyroll");
        private void Showdate()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select id,Full_Name,phone,Addres,gender,age,join_time,salary,position,certif from emplyoyee", conn);
            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            DataTable d = new DataTable();
            dt.Fill(d);
            guna2DataGridView1.DataSource = d;
            conn.Close();

        }
        private void GetImageFromDB()
        {
            try
            {
                SqlConnection cc = new SqlConnection(@"Data Source=DESKTOP-OG2GV0R;Integrated Security=SSPI;Initial Catalog=pyroll");
                cc.Open();
                SqlCommand cmd = new SqlCommand("select picture from emplyoyee where id ='" + bunifuTextBox1.Text + "'", cc);


                SqlDataReader d = cmd.ExecuteReader();
                d.Read();

                if (d.HasRows)
                {
                    byte[] img = ((byte[])d[0]).ToArray();

                    if (img == null)
                    {
                        pictureBox1.Image = null;

                    }
                    else
                    {
                        MemoryStream mys = new MemoryStream(img);
                        pictureBox1.Image = Image.FromStream(mys);
                    }
                }
                else
                {
                    MessageBox.Show("Not Avaliable ");
                }

                cc.Close();
            }
            catch { }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bunifuTextBox1.Text= guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            GetImageFromDB();
        }


      
    }
}

