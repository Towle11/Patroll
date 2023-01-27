using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PnalFasle();
        }

        private void PnalFasle()
        {
            panel_hoe.Visible = false;
            panelslary.Visible = false;
            panelem.Visible = false;
            panelbou.Visible = false;
           panel5.Visible = false;
            panel1iauu.Visible = false;

        }
     
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

    

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //home labale
        private void label1_Click(object sender, EventArgs e)
        {
            PnalFasle();
            panel_hoe.Visible = true;
            home hm = new home();
            ShowControl(hm);
            pcClor();
            pictureBox2.BackColor = Color.Wheat;
        }

        //attende labael

        private void label3_Click(object sender, EventArgs e)
        {
            PnalFasle();
         panel5.Visible = true;
            pcClor();
            pictureBox4.BackColor = Color.Wheat;
            Attendence at = new Attendence();
            ShowControl(at);
        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }
            //show contol method

            private void ShowControl(Control control)
            {
                control.Dock = DockStyle.Fill;
                panel_main.Controls.Clear();
                panel_main.Controls.Add(control);
                control.BringToFront();



            }


        //emplyee
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PnalFasle();
            panelem.Visible = true;
            pcClor();
            Emplyess em = new Emplyess();
            ShowControl(em);
        }


        //home
        private void pictureBox2_Click(object sender, EventArgs e)

        {
            PnalFasle();
            panel_hoe.Visible = true;
            pcClor();
            home hm = new home();
            ShowControl(hm);
            
        }
        private void pcClor()
        {
            pictureBox2.BackColor = Color.White;
            pictureBox3.BackColor = Color.White;
            pictureBox4.BackColor = Color.White;
            pictureBox5.BackColor = Color.White;
            pictureBox6.BackColor = Color.White;
            pictureBox7.BackColor = Color.White;
        }


        //emplyess label
        private void label2_Click(object sender, EventArgs e)

        {
            PnalFasle();
            panelem.Visible = true;
            Emplyess em = new Emplyess();
            ShowControl(em);
            pcClor();
            pictureBox3.BackColor = Color.Wheat;


        }

        //bonus labal
        private void label4_Click(object sender, EventArgs e)
        {
            PnalFasle();
            panelbou.Visible = true;
        
            pcClor();
            pictureBox5.BackColor = Color.Wheat;

            Bouns bn = new Bouns();
            bn.ShowDialog();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            PnalFasle();
            panel1iauu.Visible = true;
            slaryIsuu sly = new slaryIsuu();
            ShowControl(sly);
            pcClor();
            pictureBox7.BackColor = Color.Wheat;
        }


        //attendece
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PnalFasle();
            panel5.Visible = true;
            pcClor();
            Attendence at = new Attendence();
            ShowControl(at);
        }


        //bouns
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PnalFasle();
            panelbou.Visible = true;
            pcClor();
            Bouns bn = new Bouns();
            bn.ShowDialog();
        }


        //slay issu
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            PnalFasle();
            panel1iauu.Visible = true;
            pcClor();
            slaryIsuu sl = new slaryIsuu();
            ShowControl(sl);
        }

        //seeting pic
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            PnalFasle();
            panelslary.Visible = true;
            pcClor();
            settings st= new settings();
            ShowControl(st);
        }


        //laelseeting
        private void label6_Click(object sender, EventArgs e)
        {
            PnalFasle();
            panelslary.Visible = true;
            settings st = new settings();
            ShowControl(st);
            pcClor();
            pictureBox6.BackColor = Color.Wheat;
        }
    }
}
