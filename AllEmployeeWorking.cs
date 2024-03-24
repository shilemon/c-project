using System;
using System.Collections;
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
    public partial class AllEmployeeWorking : Form
    {
        function fn = new function();
        string query;
        public AllEmployeeWorking()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AllEmployeeWorking_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 170);
            query = "select * from newEmployee where working = 'Yes'";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
