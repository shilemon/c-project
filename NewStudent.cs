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
using System.Xml.Linq;

namespace Hostel_Management_System
{
    
    public partial class NewStudent : Form
    {
        function fn = new function();
        string query;
        


        public NewStudent()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            txtMobile.Clear();
            txtname.Clear();
            txtFather.Clear();
            txtMother.Clear();
            txtPermanent.Clear();
            txtcollage.Clear();
            txtIdProof.Clear();
            comboRoomNo.Items.Clear();




        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMobile.Text != "" && txtname.Text != "" && txtFather.Text != "" && txtMother.Text != "" && txtEmail.Text != "" && txtPermanent.Text != "" && txtcollage.Text != "" && txtIdProof.Text != "" && comboRoomNo.Text != "")
            {


                Int64 mobile = Int64.Parse(txtMobile.Text);
                String name = txtname.Text;
                String fname = txtFather.Text;
                String mname = txtMother.Text;
                String email = txtEmail.Text;
                String paddress = txtPermanent.Text;
                String collage = txtcollage.Text;
                String idproof = txtIdProof.Text;
                String roomNo = comboRoomNo.Text;

                query = "insert into NewStudents(mobile,name,fname,mname,email,paddress,collage,idproof,roomNo) values (" + mobile + ",'" + name + "','" + fname + "','" + mname + "','" + email + "','" + paddress + "','" + collage + "','" + idproof + "'," + roomNo + ")";
                fn.setData(query, "Student Registration Successful.");
                clearAll();
            }
            else
            {
                MessageBox.Show("Fill all empty space.", "Information!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
