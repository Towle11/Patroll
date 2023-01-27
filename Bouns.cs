using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_Management
{
    public partial class Bouns : Form
    {
        public Bouns()
        {
            InitializeComponent();
                Showdate();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OG2GV0R;Integrated Security=SSPI;Initial Catalog=pyroll");

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void Showdate()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from bonus", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd     );
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            bunifuDataGridView1.DataSource=dataTable;
            conn.Close();
        }

        //add bonus
        private void login_btn_Click(object sender, EventArgs e)
        {

            if (fn_txt.Text == "")
            {

            }
            else
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into bonus values('" + fn_txt.Text + "','" + bunifuMaterialTextbox1.Text + "')  ", conn);
                //   cmd.Parameters.AddWithValue("@am",int.Parse( bunifuMaterialTextbox1.Text).ToString("n1"));
                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Added Bonus"); Showdate();

            }
        }

        private void Bouns_Load(object sender, EventArgs e)
        {
            Showdate();
        }

      



        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fn_txt.Text = bunifuDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            bunifuMaterialTextbox1.Text = bunifuDataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

        }


        //update
        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (fn_txt.Text == "")
            {

            }
            else
            {


                conn.Open();
                SqlCommand cmd = new SqlCommand("update  bonus set BName='" + fn_txt.Text + "',BAmount='" + bunifuMaterialTextbox1.Text + "' where BName= '" + fn_txt.Text + "'  ", conn);
                //   cmd.Parameters.AddWithValue("@am",int.Parse( bunifuMaterialTextbox1.Text).ToString("n1"));
                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Updated Bonus");

                Showdate();
            }
        }

        //delete

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (fn_txt.Text == "")
            {

            }
            else if (MessageBox.Show("Delete Bonus ", "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                conn.Open();
                SqlCommand cmd = new SqlCommand("delete  bonus where BName='" + fn_txt.Text + "'  ", conn);
                //   cmd.Parameters.AddWithValue("@am",int.Parse( bunifuMaterialTextbox1.Text).ToString("n1"));
                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Deleted Bonus");
                Showdate();
            }        }
    }
    }
