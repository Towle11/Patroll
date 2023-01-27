using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_Management
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public static String Usernmae;
        public static String pass;

        //login
        private void login_btn_Click(object sender, EventArgs e)
        {
            if (user_txt.Text == " " || pass_txt.Text == "")
            {
                lp_ans.Text = "Enter Both Values";
                lp_ans.ForeColor = Color.Red;
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OG2GV0R;Integrated Security=SSPI;Initial Catalog=pyroll");
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from LoginT where User_Names='" + user_txt.Text + "' and Passwords ='" + pass_txt.Text + "' ", conn);
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                DataTable d = new DataTable();
                dt.Fill(d);
                if (d.Rows.Count > 0)
                {
                    Usernmae = user_txt.Text;
                    pass = pass_txt.Text;

                    Form1 f1 = new Form1();
                    f1.Show();
                    this.Hide();

                }
                else
                {
                    lp_ans.Text = "Wrong Username Or Password";
                    lp_ans.ForeColor = Color.Red;
                }
                conn.Close();
            }

          
        }

      
        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }


        //hint get infor
        private void bunifuCustomLabel2_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OG2GV0R;Integrated Security=SSPI;Initial Catalog=pyroll");
                conn.Open();
                SqlCommand cmd = new SqlCommand("select  User_Names,Passwords from LoginT  ", conn);
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                DataTable d = new DataTable();
                dt.Fill(d);
                user_txt.Text = d.Rows[0][0].ToString();
                pass_txt.Text = d.Rows[0][1].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        //forget password
        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {
            ForgetPassword fg = new ForgetPassword();
            fg.Show();
        }
    }
}
