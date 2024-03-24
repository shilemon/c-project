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
    public partial class Dashboard1 : Form
    {
        public Dashboard1()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Boolean labelVisible = true;

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (labelVisible == true)
            {
                hmsLabel.Visible = true;
                labelVisible = false;

            }
            else
            {
                hmsLabel.Visible = false;
                labelVisible = true;
            }
        }

        private void Dashboard1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void btnManageRooms_Click(object sender, EventArgs e)
        {
            AddNewRoom anr
                 = new AddNewRoom();
            anr.Show();
        }

        private void btnStudentFees_Click(object sender, EventArgs e)
        {
            StudentFees sf = new StudentFees();
            sf.Show();
        }

        private void btnAllStudentLiving_Click(object sender, EventArgs e)
        {
            AllStudentLiving asl = new AllStudentLiving(); ;
            asl.Show();
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            NewEmployee ne = new NewEmployee();
            ne.Show(); 
        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            NewStudent ns = new NewStudent();
            ns.Show();
        }

        private void btnAllEmployeeWorking_Click(object sender, EventArgs e)
        {
            AllEmployeeWorking aew = new AllEmployeeWorking();
            aew.Show();
        }

        

        private void btnUpdateDeleteEmployee_Click(object sender, EventArgs e)
        {
            UpdateDeleteEmployee ude = new UpdateDeleteEmployee();
            ude.Show();
        }

        private void btnLeavedEmployee_Click(object sender, EventArgs e)
        {
            LeavedEmployee le = new LeavedEmployee();
            le.Show();
        }

        private void btnLeavedStudents_Click(object sender, EventArgs e)
        {
            LeavedStudents ls = new LeavedStudents();
            ls.Show();  
        }

        private void btnUpdateDeleteStudent_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudent uds = new UpdateDeleteStudent();
            uds.Show();
        }

        private void btnEmployeePayment_Click(object sender, EventArgs e)
        {
            EmployeePayment ep = new EmployeePayment();
            ep.Show();  
        }
    }
}
