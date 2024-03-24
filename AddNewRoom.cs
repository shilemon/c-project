using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hostel_Management_System
{
    public partial class AddNewRoom : Form
    {
        function fn = new function();
        String query;
        public AddNewRoom()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewRoom_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 170);
            labelRoom.Visible = false;
            labelRoomExist.Visible = false;

            query = "select * from Rooms";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            query="select * from Rooms where roomNo="+txtRoomNo1.Text+"";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count==0)
            {
                String status;
                if(this.status.Checked)
                {
                    status = "Yes";
                }
                else
                {
                    status = "No";
                }
                labelRoomExist.Visible = false;
                query = "insert into Rooms (roomNo,roomStatus) values(" + txtRoomNo1.Text + ",'" + status + "')";
                fn.setData(query,"Room Added.");
                AddNewRoom_Load(this, null);
            }
           
            else
            {
                labelRoomExist.Text = "Room All Ready Exist";
                labelRoomExist.Visible = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            query = "select * from Rooms where roomNo="+txtRoomNo2.Text+"";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count==0)
            {
                labelRoom.Text = "No Room Exist";
                labelRoom.Visible = true;
                checkBox2.Checked = false;
            }
            else
            {
                labelRoom.Text = "Room Found";
                labelRoom.Visible = true;
                if (ds.Tables[0].Rows[0][1].ToString()=="Yes")
                {
                    checkBox2.Checked = true;
                }
                else
                {
                    checkBox2.Checked = false;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String status;
            if (checkBox2.Checked)
            {
                status = "Yes";
            }
            else
            {
                status = "No";
            }
            query = "Update Rooms set roomStatus='" + status + "' where roomNo="+txtRoomNo2.Text+"";
            fn.setData(query, "Details updated.");
            AddNewRoom_Load(this, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (labelRoom.Text=="Room Found.")
            {
                query = "delete from Rooms where roomNo=" + txtRoomNo2.Text + "";
                fn.setData(query, "Room Details Deleated.");
                AddNewRoom_Load(this, null);
            }
           else
            {
                MessageBox.Show("Trying to delete which doesn't Exist.", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
