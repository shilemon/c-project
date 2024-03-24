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
    public partial class EmployeePayment : Form
    {
        function fn = new function();
        String query;
        public EmployeePayment()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 170);
            monthDateTime.Format = DateTimePickerFormat.Custom;
            monthDateTime.CustomFormat = "MMMM yyyy";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtMobile.Text != "")
            {
                query = "select ename,eemail,edesignation from NewEmployee where emobile=" + txtMobile.Text + "";
                DataSet ds = fn.getData(query);


                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtEmailId.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtDesignation.Text = ds.Tables[0].Rows[0][2].ToString();

                    setDataGrid(Int64.Parse(txtMobile.Text));
                }
                else
                {
                    MessageBox.Show("No Record Exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else
            {
                MessageBox.Show("Enter some data.", "Information ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        public void setDataGrid(Int64 mobile)
        {
            query = "select * from EmployeeSalary where mobileNo=" + mobile + " ";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnPaySalary_Click(object sender, EventArgs e)
        {
            if (txtMobile.Text != "" && txtPaymentAmount.Text != "")
            {
                query = "select * from EmployeeSalary where mobilrNo=" + txtMobile.Text + "and fmonth='" + monthDateTime.Text + "'";
                DataSet ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    Int64 mobile = Int64.Parse(txtMobile.Text);
                    String month = monthDateTime.Text;
                    Int64 amount = Int64.Parse(txtPaymentAmount.Text);

                    query = "insert into EmployeeSalary values (" + mobile + ",'" + month + "'," + amount + ") ";
                    fn.setData(query, "Salary for month " + monthDateTime.Text + " Paid ");
                    setDataGrid(mobile);
                }
                else
                {
                    MessageBox.Show("Payment of " + monthDateTime.Text + "Done.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        public void ClearAll()
        {
            txtMobile.Clear();
            txtName.Clear();
            txtPaymentAmount.Clear();
            txtDesignation.Clear();
            txtEmailId.Clear();
            dataGridView1.DataSource = 0;
            monthDateTime.ResetText();
        }
    }
}
