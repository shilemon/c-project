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
    public partial class AllStudentLiving : Form
    {
        function fn = new function();
        String query;
        public AllStudentLiving()
        {
            InitializeComponent();
        }

        private void AllStudentLiving_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 170);
            query = "select * from NewStudents where living='Yes'";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
