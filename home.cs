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
    public partial class home : UserControl
    {
        public home()
        {
            InitializeComponent();
            timer1.Start();
            GetHomeInf();
        }

        private void home_Load(object sender, EventArgs e)
        {
            timer1.Start();
            GetHomeInf();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OG2GV0R;Integrated Security=SSPI;Initial Catalog=pyroll");

        private void GetHomeInf()
        {
            if (1==1)
            {



                SqlCommand cmd = new SqlCommand("select COUNT(id) from emplyoyee where position='Maneger'", conn);
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                DataTable d = new DataTable();
                dt.Fill(d);
                lp_mn.Text = d.Rows[0][0].ToString();
                conn.Close();

            }

            if (22==22)
            {

                SqlCommand cmd = new SqlCommand("select COUNT(id) from emplyoyee where position='Employee'\r\n", conn);
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                DataTable d = new DataTable();
                dt.Fill(d);
                label1_em.Text = d.Rows[0][0].ToString();
                conn.Close();
            }

            if (33 == 33)
            {
                SqlCommand cmd = new SqlCommand("select sum(Slary) from salary ", conn);
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                DataTable d = new DataTable();
                dt.Fill(d);
                label_sly.Text = d.Rows[0][0].ToString()+" $";
                conn.Close();

            }
            if (111 ==111)
            {
                SqlCommand cmd = new SqlCommand("select sum(BAmount) from bonus", conn);
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                DataTable d = new DataTable();
                dt.Fill(d);
                label_bouns.Text = d.Rows[0][0].ToString()+" $";
                conn.Close();
            }

        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_clock.Text = DateTime.Now.Date.ToLongDateString();
            lb_sec.Text = DateTime.Now.Second.ToString();
            lb_m.Text = DateTime.Now.Minute.ToString() + ":";
            lb_ho.Text = DateTime.Now.Hour.ToString() + "";
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
