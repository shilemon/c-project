using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*using System.Data.SqlClient;*/
using System.Diagnostics.Eventing.Reader;

namespace Hostel_Management_System
{
    public partial class Log_In : Form
    {
        public Log_In()
        {
            InitializeComponent();
        }
        /*SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Documents\\SignInDb.mdf;Integrated Security=True;Connect Timeout=30");*/
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                password.UseSystemPasswordChar = false;
            }
            else 
            {
                password.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)

        {

            if (u_name.Text == "admin@gmail.com" && password.Text == "1234")
            {
                
              Dashboard1 ds = new Dashboard1();
                this.Hide();
                ds.Show();
                /*string query = "select count(*) from SignUpTbl where email='" + u_name.Text + "'and password='" + password.Text + "' ";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                int v = (int)command.ExecuteScalar();
                if (v != 1)
                {
                    MessageBox.Show("Error username or password", "Error!");
                }*/
            }

            else
            {
                MessageBox.Show("Error");

            }
        

        }

       
    }
}
