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
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OG2GV0R;Integrated Security=SSPI;Initial Catalog=pyroll");

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

                MessageBox.Show("Changed");
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }
    }
}
