using Bunifu.UI.WinForms.BunifuTextbox;
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
    public partial class slaryIsuu : UserControl
    {
        public slaryIsuu()
        {
            InitializeComponent();
            Postion_Read();
            GetId();
            GetBonus();
            Showdate();

        }

        private void slaryIsuu_Load(object sender, EventArgs e)
        {

        }


        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OG2GV0R;Integrated Security=SSPI;Initial Catalog=pyroll");
        //add
        private void login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int git = int.Parse(comboBox_b2.Text);
                int bl = int.Parse(blance_txt.Text);
                int at = int.Parse(abse_txt.Text);
                if (at > 10)
                    bl = bl / 2;

                    conn.Open();
                SqlCommand cmd = new SqlCommand("insert into salary values(@id , @F_Name,@Slary,@Bonus,@Attendece ,@Absents,@present,@Excused,@Blance,@Period_S  )", conn);
                cmd.Parameters.AddWithValue("@id ", comboBox1.Text);
                cmd.Parameters.AddWithValue("@F_Name", fn_txt.Text);
                cmd.Parameters.AddWithValue("@Slary", slar_txt.Text);
                cmd.Parameters.AddWithValue("@Bonus", comboBox_bonus.Text +" "+ comboBox_b2.Text);
                cmd.Parameters.AddWithValue("@Attendece", atende_com.Text); 
                cmd.Parameters.AddWithValue("@Absents", abse_txt.Text);
                cmd.Parameters.AddWithValue("@present", pre_txt.Text);
                cmd.Parameters.AddWithValue("@Excused", Ex_txt.Text);
                cmd.Parameters.AddWithValue("@Blance", bl+git);
                cmd.Parameters.AddWithValue("@Period_S", dateTimePicker1.Text);



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
//get saly,name
        private void Postion_Read()
        {
            if (comboBox1.TabIndex > 0)
            {



                SqlCommand cmd = new SqlCommand("select Full_Name,salary from emplyoyee where id='"+comboBox1.Text+"' ", conn);

                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                DataTable dd = new DataTable();
                dt.Fill(dd);

                foreach (DataRow dr in dd.Rows)
                {
//comboBox1.Items.Add(dr["id"].ToString());
                    fn_txt.Text = (dr["Full_Name"].ToString());
                    slar_txt.Text = (dr["salary"].ToString());

                    //pictureBox_student.Image= dr["Picture"];
                }
            }
        }


        //get ids 
        private void GetId()
        {


            SqlCommand cmd = new SqlCommand("select id from emplyoyee", conn);

            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            DataTable dd = new DataTable();
            dt.Fill(dd);

            foreach (DataRow dr in dd.Rows)
            {
                comboBox1.Items.Add(dr["id"].ToString());
             
                //pictureBox_student.Image= dr["Picture"];
            }
        }

        //date read
        private void Showdate()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from salary", conn);
            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            DataTable d = new DataTable();
            dt.Fill(d);
            guna2DataGridView1.DataSource = d;
            conn.Close();

        }

        private void Earse()
        {
            fn_txt.Text = "";
            comboBox1.Text = "";
            abse_txt.Text = "";
            Ex_txt.Text = "";
            pre_txt.Text = "";
            comboBox_bonus.Text = "";
            comboBox_b2.Text = "";
            blance_txt.Text = "";


        }

        //edit 
        private void edit_btn_Click(object sender, EventArgs e)
        { 
            try
            {
                int git = int.Parse(comboBox_b2.Text);
                int bl = int.Parse(blance_txt.Text);
                int at = int.Parse(abse_txt.Text);
                if (at > 10)
                    bl = bl / 2;

                conn.Open();
                SqlCommand cmd = new SqlCommand("update  salary set  F_Name=@F_Name,Slary=@Slary,Bonus=@Bonus,Attendece=@Attendece ,Absents=@Absents,present=@present,Excused=@Excused,Blance=@Blance,Period_S=@Period_S  where id='"+comboBox1.Text+"'", conn);
              //  cmd.Parameters.AddWithValue("@id ", comboBox1.Text);
                cmd.Parameters.AddWithValue("@F_Name", fn_txt.Text);
                cmd.Parameters.AddWithValue("@Slary", slar_txt.Text);
                cmd.Parameters.AddWithValue("@Bonus", comboBox_bonus.Text + " " + comboBox_b2.Text);
                cmd.Parameters.AddWithValue("@Attendece", atende_com.Text);
                cmd.Parameters.AddWithValue("@Absents", abse_txt.Text);
                cmd.Parameters.AddWithValue("@present", pre_txt.Text);
                cmd.Parameters.AddWithValue("@Excused", Ex_txt.Text);
                cmd.Parameters.AddWithValue("@Blance", bl + git);
                cmd.Parameters.AddWithValue("@Period_S", dateTimePicker1.Text);



                int a = cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(a.ToString() + " Updated");
                Earse(); Showdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        


    }
        //deleted
    private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            try
            {
           
              
                if (MessageBox.Show("Delete ", "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete  salary  where id='" + comboBox1.Text + "'", conn);
                    //  cmd.Parameters.AddWithValue("@id ", comboBox1.Text);



                    int a = cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show(a.ToString() + " Deleted");
                    Earse(); Showdate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }




            }

        

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        //get ponus 
        private void GetBonus()
        {
        


                SqlCommand cmd = new SqlCommand("select BName,BAmount from bonus", conn);

                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                DataTable dd = new DataTable();
                dt.Fill(dd);

                foreach (DataRow dr in dd.Rows)
                {
                   comboBox_bonus.Items.Add(dr["BName"].ToString());
                    comboBox_b2.Items.Add(dr["BAmount"].ToString());

                    //pictureBox_student.Image= dr["Picture"];
                }

        }

        //get all about attendec
        private void Attendece()
        {
            if (comboBox1.TabIndex > 0)
            {



                SqlCommand cmd = new SqlCommand("select sum(Present) from attendence where id ='"+comboBox1.Text+"'", conn);
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                DataTable d = new DataTable();
                dt.Fill(d);
                pre_txt.Text = d.Rows[0][0].ToString();
                conn.Close();

            }

            if (comboBox1.Text != "")
            {

                SqlCommand cmd = new SqlCommand("select sum(Absents) from attendence where id ='" + comboBox1.Text + "'", conn);
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                DataTable d = new DataTable();
                dt.Fill(d);
                abse_txt.Text = d.Rows[0][0].ToString();
                conn.Close();
            }

            if(comboBox1.Text!="" )
            {
                SqlCommand cmd = new SqlCommand("select sum(Excused) from attendence where id ='" + comboBox1.Text + "'", conn);
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                DataTable d = new DataTable();
                dt.Fill(d);
                Ex_txt.Text = d.Rows[0][0].ToString();
                conn.Close();

            }
            if(comboBox1 != null)
            {
                SqlCommand cmd = new SqlCommand("select sum(Present+Absents) from attendence where id ='"+comboBox1.Text+"'",conn);
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                DataTable d = new DataTable();
                dt.Fill(d);
                atende_com.Text = d.Rows[0][0].ToString();
                conn.Close();
            }

        }

        //get_id
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Attendece();
            Postion_Read();
        }

        private void pre_txt_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Ex_txt_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void atende_com_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //click datagriedview
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox1.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            fn_txt.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            slar_txt.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBox_bonus.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            atende_com.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            abse_txt.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            blance_txt.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
     dateTimePicker1.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            comboBox_b2.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            pre_txt.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            Ex_txt.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }
    }
}
