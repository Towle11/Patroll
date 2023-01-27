using Bunifu.UI.WinForms.BunifuTextbox;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Payroll_Management
{
    public partial class Attendence : UserControl
    {
        public Attendence()
        {
            InitializeComponent();
            Postion_Read();
            Showdate();
            timer1.Start();
        }

        private void Attendence_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

       
string lb_clock = DateTime.Now.Date.ToLongDateString();


    
    private void Showdate()
    {
        conn.Open();
        SqlCommand cmd = new SqlCommand("select * from attendence", conn);
        SqlDataAdapter dt = new SqlDataAdapter(cmd);
        DataTable d = new DataTable();
        dt.Fill(d);
        guna2DataGridView1.DataSource = d;
        conn.Close();

    }

        //get id emplye
        private void Postion_Read()
        {

            SqlCommand cmd = new SqlCommand("select id from emplyoyee ", conn);

            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            DataTable dd = new DataTable();
            dt.Fill(dd);

            foreach (DataRow dr in dd.Rows)
            {
                comboBox1.Items.Add(dr["id"].ToString());
                //pictureBox_student.Image= dr["Picture"];
            }

        }
//get name emplye
        private void GetNames()
        {

            SqlCommand cmd = new SqlCommand("select Full_Name from emplyoyee where id ='" + comboBox1.Text + "' ", conn);

            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            DataTable dd = new DataTable();
            dt.Fill(dd);

            foreach (DataRow dr in dd.Rows)
            {
                fn_txt.Text = (dr["Full_Name"].ToString());
                //pictureBox_student.Image= dr["Picture"];
            }

        }

        private void Earse()
        {
            fn_txt.Text = "";
            comboBox1.Text = "";
            absent_txt.Text = "";
            Ex_txt.Text = "";
            pre_txt.Text = "";


        }
        //persen








        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OG2GV0R;Integrated Security=SSPI;Initial Catalog=pyroll");

      


        //datagrid
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox1.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            fn_txt.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            absent_txt.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            pre_txt.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            Ex_txt.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            up_delete.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            lb_time.Enabled = false;
          //  pre_txt.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string lb_hou = DateTime.Now.Hour.ToString()+":";
            string lb_sec = DateTime.Now.Second.ToString()+":";
            string lb_m= DateTime.Now.Minute.ToString();

            lb_time.Text = DateTime.Now.Date.ToLongDateString() +"\n "+ lb_hou+" "+ lb_sec+" "+lb_m;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        //get names
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            GetNames();
        }

        // btn add
        private void login_btn_Click_1(object sender, EventArgs e)
        {
            
                try
                {


                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into attendence values(@id , @E_Name,@Absents,@Present,@Excused ,@E_Period  )", conn);
                    cmd.Parameters.AddWithValue("@id ", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@E_Name", fn_txt.Text);
                    cmd.Parameters.AddWithValue("@Absents", absent_txt.Text);
                    cmd.Parameters.AddWithValue("@Present", pre_txt.Text);
                    cmd.Parameters.AddWithValue("@Excused", Ex_txt.Text);
                    cmd.Parameters.AddWithValue("@E_Period", lb_time.Text);


                    int a = cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show(a.ToString() + " Added");
                    Earse(); Showdate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
            }


        //edit
        private void edit_btn_Click_1(object sender, EventArgs e)
        {
        
                try
                {

                    conn.Open();



                    SqlCommand cmd = new SqlCommand("update  attendence set id=@id ,E_Name=@E_Name,Absents=@Absents,Present=@Present,Excused=@Excused  where E_Period= '" + up_delete.Text + "'", conn);
                    cmd.Parameters.AddWithValue("@id ", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@E_Name", fn_txt.Text);
                    cmd.Parameters.AddWithValue("@Absents", absent_txt.Text);
                    cmd.Parameters.AddWithValue("@Present", pre_txt.Text);
                    cmd.Parameters.AddWithValue("@Excused", Ex_txt.Text);

                    int a = cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show(a.ToString() + " Updated");
                lb_time.Enabled = true;

                Earse();
                    Showdate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


            

        }
        //delete
        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
          
                try

                {

                    if (comboBox1.Text == "")
                    {

                    }
                    else if (MessageBox.Show("Delete This ", "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SqlCommand cmd = new SqlCommand("delete attendence where E_Period='" + up_delete.Text + "'  ", conn);
                        conn.Open();
                        int a = cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show(a.ToString() + " Deleted");
                    lb_time.Enabled = true;


                    Showdate();
                        Earse();


                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }


            }

        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }
        private void bunifuCustomLabel7_Click_1(object sender, EventArgs e)

        {

        }
    }
    }
    
