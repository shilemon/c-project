using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Hostel_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Documents\\SignInDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (first_name.Text != "" && last_name.Text != "" && birth_date.Text != "" && gender.Text != "" && address.Text != "" && email.Text != "" && password.Text != "" && con_password.Text != "")
                {
                    if (password.Text == con_password.Text)
                    {
                        int v = check(email.Text);
                        if (v != 1)
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand("insert into SignUpTbl values(@f_name,@l_name,@b_date,@gender,@address,@email,@password)", connection);
                            command.Parameters.AddWithValue("@f_name", first_name.Text);
                            command.Parameters.AddWithValue("@l_name", last_name.Text);
                            command.Parameters.AddWithValue("@b_date", Convert.ToDateTime(birth_date.Text));
                            command.Parameters.AddWithValue("@gender", gender.Text);
                            command.Parameters.AddWithValue("@address", address.Text);
                            command.Parameters.AddWithValue("@email", email.Text);
                            command.Parameters.AddWithValue("@password", password.Text);
                            command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Register Successfully !");
                            first_name.Text = "";
                            last_name.Text = "";
                            gender.Text = "";
                            address.Text = "";
                            email.Text = "";
                            password.Text = "";
                            con_password.Text = "";



                        }
                        else
                        {
                            MessageBox.Show("You are already registered");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password does not match. ");
                    }
                }
                else
                {
                    MessageBox.Show("Fill in the blanks!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (first_name.Text != "" && last_name.Text != "" && birth_date.Text != "" && gender.Text != "" && address.Text != "" && email.Text != "" && password.Text != "" && con_password.Text != "")
                {
                    if (password.Text == con_password.Text)
                    {
                        int v = check(email.Text);
                        if (v != 1)
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand("insert into SignUpTbl values(@f_name,@l_name,@b_date,@gender,@address,@email,@password)", connection);
                            command.Parameters.AddWithValue("@f_name", first_name.Text);
                            command.Parameters.AddWithValue("@l_name", last_name.Text);
                            command.Parameters.AddWithValue("@b_date", Convert.ToDateTime(birth_date.Text));
                            command.Parameters.AddWithValue("@gender", gender.Text);
                            command.Parameters.AddWithValue("@address", address.Text);
                            command.Parameters.AddWithValue("@email", email.Text);
                            command.Parameters.AddWithValue("@password", password.Text);
                            command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Register Successfully !");
                            first_name.Text = "";
                            last_name.Text = "";
                            gender.Text = "";
                            address.Text = "";
                            email.Text = "";
                            password.Text = "";
                            con_password.Text = "";



                        }
                        else
                        {
                            MessageBox.Show("You are already registered");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password does not match. ");
                    }
                }
                else
                {
                    MessageBox.Show("Fill in the blanks!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int check(string email)
            {
            connection.Open();
            string query = "select count(*) from SignUpTbl where email='" + email + "'";
            SqlCommand command = new SqlCommand(query, connection);
            int v = (int)command.ExecuteScalar();
            connection.Close();
            return v;

            }


        private void check_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (check_pass.Checked)
            {
                password.UseSystemPasswordChar = false;
                con_password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
                con_password.UseSystemPasswordChar = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Log_In login = new Log_In();
            login.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            User_Login user_login = new User_Login();
            user_login.Show();
        }

        
    }
}
