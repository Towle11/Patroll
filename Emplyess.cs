using System;
using System.Collections;
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
using System.Xml.Linq;

namespace Payroll_Management
{
    public partial class Emplyess : UserControl
    {
        public Emplyess()
        {
            InitializeComponent();
            Postion_Read();
            Cer_re();
            //GetCernum();


        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OG2GV0R;Integrated Security=SSPI;Initial Catalog=pyroll");
        private void Emplyess_Load(object sender, EventArgs e)
        {
        }

        private void Earse()
        {
            fn_txt.Text = "";
            phone_text.Text = "";
            add_txt.Text = "";
            age_text.Text = "";
            Slary_txt.Text = "";
            comboBox1.Text = "";
            comboBox_cer.Text = "";
            pictureBox2.Image = null;
        }

        SqlCommand cmd;

        string img;
        private void login_btn_Click(object sender, EventArgs e)
        {
            try
            {

                byte[] imge = null;
                FileStream st = new FileStream(img, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(st);
                imge = br.ReadBytes((int)st.Length);

                conn.Open();


                SqlCommand cmd = new SqlCommand("insert into emplyoyee values(@Full_Name , @phone,@Addres,@gender,@age ,@join_time ,@salary ,@position,@certif,@picture,@cid)  ", conn);
                cmd.Parameters.AddWithValue("@Full_Name ", fn_txt.Text);
                cmd.Parameters.AddWithValue("@phone", phone_text.Text);
                cmd.Parameters.AddWithValue("@Addres", add_txt.Text);
                cmd.Parameters.AddWithValue("@gender", radioButton1.Checked ? "Male" : "Femele");
                cmd.Parameters.AddWithValue("@age", age_text.Text);
                cmd.Parameters.AddWithValue("@join_time", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@salary", Slary_txt.Text);
                cmd.Parameters.AddWithValue("@position", comboBox1.Text);
                cmd.Parameters.AddWithValue("@certif", comboBox_cer.Text);
                cmd.Parameters.AddWithValue("@picture", imge);
                cmd.Parameters.AddWithValue("@cid", comboBox2.Text);

                int a = cmd.ExecuteNonQuery();

                MessageBox.Show(a.ToString() + " Added");
                Earse();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)


        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Images(*.PNG,*.JPG,*.GIF)|*.JPG;*.GIF;*.PNG;";
            op.Title = "Image Student";
            if (op.ShowDialog() == DialogResult.OK)
            {
                img = op.FileName.ToString();
                pictureBox2.ImageLocation = img;
            }

        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list ls = new list();
            ls.Show();
        }



        private void Postion_Read()
        {

            SqlCommand cmd = new SqlCommand("select * from Position ", conn);

            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            DataTable dd = new DataTable();
            dt.Fill(dd);

            foreach (DataRow dr in dd.Rows)
            {
                comboBox1.Items.Add(dr["PName"].ToString());
                //pictureBox_student.Image= dr["Picture"];
            }

        }

        private void GetCernum()
        {
            if (comboBox_cer.Text == "Pach")
            {
                comboBox2.Text = "1";

            }
            else if (comboBox_cer.Text == "Master")
            {
                comboBox2.Text = "2";
            }
            else if (comboBox_cer.Text == "PHD")
            {
                comboBox2.Text = "3";
            }

        }

        private void Cer_re()
        {

            SqlCommand c = new SqlCommand("select * from Certifac ", conn);

            SqlDataAdapter dtt = new SqlDataAdapter(c);
            DataTable d = new DataTable();
            dtt.Fill(d);

            foreach (DataRow dr in d.Rows)
            {
                comboBox_cer.Items.Add(dr["Cname"].ToString()); ;
                //pictureBox_student.Image= dr["Picture"];
            }
        }




        private void bunifuCustomLabel10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_cer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void comboBox_cer_Click(object sender, EventArgs e)
        {
            GetCernum();
        }


        //btn_delete
        private void btn_dlte_Click(object sender, EventArgs e)


        {
            if (id_txt.Text == "")
            {

            }
            else if (MessageBox.Show("Delete This ", "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("delete emplyoyee where id='" + id_txt.Text + "'  ", conn);
                conn.Open();
                int a = cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(a.ToString() + "Deleted");


            }

            

        }


        //edit 
        private void edit_btn_Click(object sender, EventArgs e)
        {

            try
            {

                byte[] imge = null;
                FileStream st = new FileStream(img, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(st);
                imge = br.ReadBytes((int)st.Length);

                conn.Open();


                SqlCommand cmd = new SqlCommand("update  emplyoyee set Full_Name= @Full_Name ,phone= @phone,Addres=@Addres,gender=@gender,age=@age ,join_time=@join_time ,salary=@salary ,position=@position,certif=@certif,picture=@picture,cid=@cid where id='"+id_txt.Text+"'  ", conn);
                cmd.Parameters.AddWithValue("@Full_Name ", fn_txt.Text);
                cmd.Parameters.AddWithValue("@phone", phone_text.Text);
                cmd.Parameters.AddWithValue("@Addres", add_txt.Text);
                cmd.Parameters.AddWithValue("@gender", radioButton1.Checked ? "Male" : "Femele");
                cmd.Parameters.AddWithValue("@age", age_text.Text);
                cmd.Parameters.AddWithValue("@join_time", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@salary", Slary_txt.Text);
                cmd.Parameters.AddWithValue("@position", comboBox1.Text);
                cmd.Parameters.AddWithValue("@certif", comboBox_cer.Text);
                cmd.Parameters.AddWithValue("@picture", imge);
                cmd.Parameters.AddWithValue("@cid", comboBox2.Text);

                int a = cmd.ExecuteNonQuery();

                MessageBox.Show(a.ToString() + " Updated");
                Earse();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
        }
    }
}
