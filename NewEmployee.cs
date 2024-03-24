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
    public partial class NewEmployee : Form
    {
        function fn = new function();
        String query;
        public NewEmployee()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMobile.Text != "" && txtName.Text != "" && txtFather.Text != "" && txtMother.Text != "" && txtEmailId.Text != "" && txtPermanent.Text != "" && txtUniqueId.Text != "" && txtDesignation.SelectedIndex != -1)
            {
                Int64 mobile = Int64.Parse(txtMobile.Text);
                String name = txtName.Text;
                String fname = txtFather.Text;
                String mname = txtMother.Text;
                String email = txtEmailId.Text;
                String address = txtPermanent.Text;
                String id = txtUniqueId.Text;
                String Designation = txtDesignation.Text;

                query = "insert into newEmployee(emobile,ename,efname,emname,eemail,epaddress,eidproof,edesignation) values (" + mobile + ",'" + name + "','" + fname + "','" + mname + "','" + email + "','" + address + "','" + id + "','" + Designation + "')";
                fn.setData(query, "Employee Registration Successful.");
            }
            else
            {
                MessageBox.Show("Fill all Required Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
