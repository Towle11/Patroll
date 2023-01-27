using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Payroll_Management
{
    internal class MainClass
    {
        //ado.net variables
        public static SqlConnection con = new SqlConnection(@"Source=DESKTOP-OG2GV0R;Integrated Security=SSPI;Initial Catalog=pyroll");
 public static SqlCommand cmd;
        public static SqlDataAdapter da;
        //other variables
        public static string query;
        public static string insertAlert = "Data has been saved.";
        public static string updateAlert = "Data has been updated.";
        public static string deleteAlert = "Data has been deleted.";
        public static string appTitle = "Student Registration App";
        //open connection method
        public void Connect()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }
        //close connection
        public void Disconnect()
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
        }

        //method for insert, update and delete
        public void ProcessData(string sqlSt, string alert)
        {
            using (cmd = new SqlCommand(sqlSt, con))
            {
                Connect();//open connection
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show(alert, appTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Something went wrong. Please trty again.", appTitle, MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                Disconnect();//close connection
            }
        }
        //display method
        public void Display(DataGridView dgv, string sqlSt)
        {
            using (da = new SqlDataAdapter(sqlSt, con))
            {
                DataSet ds = new DataSet();
                da.Fill(ds, "table");
                dgv.DataSource = ds.Tables["table"];
            }
        }

    }
}
