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
    public partial class settings : UserControl
    {
        public settings()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OG2GV0R;Integrated Security=SSPI;Initial Catalog=pyroll");


        private void settings_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select id From LoginT where User_Names ='"+Login.Usernmae+"'", conn);

            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            DataTable d = new DataTable();
            dt.Fill(d);
            label_id.Text = d.Rows[0][0].ToString();
            label9_cuser.Text = Login.Usernmae;
            label_cPass.Text = Login.pass;

        }


        //change pasword
        private void login_btn_Click(object sender, EventArgs e)
        {
            try
            {
               conn.Open();
                SqlCommand cmd = new SqlCommand("update  LoginT set  User_Names=@User_Names,Passwords=@Password   where id='" + id_txt.Text + "'", conn);
            cmd.Parameters.AddWithValue("@User_Names", use_txt.Text);
            cmd.Parameters.AddWithValue("@Password ", pass_txt.Text);

            int a = cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Changed" );

                label9_cuser.Text = use_txt.Text;
                label_cPass.Text = pass_txt.Text;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          

        }

        private void button1_MouseCaptureChanged(object sender, EventArgs e)
        {

        }
    }
    }

