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
    public partial class LeavedStudents : Form
    {
        function fn = new function();
        String query;
        public LeavedStudents()
        {
            InitializeComponent();
        }

        private void LeavedStudents_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 170);
            query = "Select * from newStudent where living = 'No'";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
