using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System
{
    public partial class StudentFees : Form
    {
        function fn = new function();
        String query;
        public StudentFees()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentFees_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 170);
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "MMMM yyyy";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtMobile.Text != "")
            {
                query = "select name ,email,roomNo from NewStudents where mobile = "+txtMobile.Text+"";
                DataSet ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtEmailid.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtRoomNo.Text = ds.Tables[0].Rows[0][2].ToString();
                    setDataGrid(Int64.Parse(txtMobile.Text));


                }
                else
                {
                    MessageBox.Show("No Record Exist", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        public void setDataGrid (Int64 mobile)
        {
            query = "select * from Fees where mobile =" +mobile + "";
            DataSet ds2 = fn.getData(query);
            dataGridView1.DataSource = ds2.Tables[0];
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

        }
    }
}
