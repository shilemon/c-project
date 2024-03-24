﻿using System;
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
    public partial class UpdateDeleteStudent : Form
    {
        function fn = new function();
        String query;
        public UpdateDeleteStudent()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateDeleteStudent_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 150);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void clearAll()
        {
            txtMobile.Clear();
            txtName.Clear();
            txtFather.Clear();
            txtMother.Clear();
            txtEmail.Clear();
            txtPermanent.Clear();
            txtUniversity.Clear();
            txtIdProof.Clear();
            txtRoomNo.Clear();
            comboBoxLiving.SelectedIndex = -1;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            query = "select * from NewStudents where mobile=" + txtMobile.Text + "";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count != 0)
            {
                txtName.Text = ds.Tables[0].Rows[0][2].ToString();
                txtFather.Text = ds.Tables[0].Rows[0][3].ToString();
                txtMother.Text = ds.Tables[0].Rows[0][4].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0][5].ToString();
                txtPermanent.Text = ds.Tables[0].Rows[0][6].ToString();
                txtUniversity.Text = ds.Tables[0].Rows[0][8].ToString();
                txtIdProof.Text = ds.Tables[0].Rows[0][9].ToString();
                comboBoxLiving.Text = ds.Tables[0].Rows[0][10].ToString();
            }
            else
            {
                clearAll();
                MessageBox.Show("No Record with this Mobile No Exists.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Int64 mobile = Int64.Parse(txtMobile.Text);
            String name = txtName.Text;
            String fname = txtFather.Text;
            String mname = txtMother.Text;
            String email = txtEmail.Text;
            String paddress = txtPermanent.Text;
            String university = txtUniversity.Text;
            String idProof = txtIdProof.Text;
            Int64 roomNo = Int64.Parse(txtRoomNo.Text);
            String livingStatus = comboBoxLiving.Text;

            query = "update Newstudents set name = '" + name + "',fname='" + fname + "',maname='" + mname + "',email='" + email + "',paddress='" + paddress + "',university='" + university + "',idproof='" + idProof + "',roomno=" + roomNo + ",living='" + livingStatus + " where mobile = " + mobile + " update Rooms set Boked ='" + livingStatus + "' where roomno=" + roomNo + "";
            fn.setData(query, "Data Updation Successful");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "delete from NewStudents where mobile =" + txtMobile.Text + "";
                fn.setData(query, "Student Record Dashboard.");
                clearAll();
            }
        }
    }
}
