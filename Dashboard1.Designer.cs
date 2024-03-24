namespace Hostel_Management_System
{
    partial class Dashboard1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.hmsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnLeavedEmployee = new System.Windows.Forms.Button();
            this.btnAllEmployeeWorking = new System.Windows.Forms.Button();
            this.btnUpdateDeleteEmployee = new System.Windows.Forms.Button();
            this.btnNewEmployee = new System.Windows.Forms.Button();
            this.btnLeavedStudents = new System.Windows.Forms.Button();
            this.btnAllStudentLiving = new System.Windows.Forms.Button();
            this.btnStudentFees = new System.Windows.Forms.Button();
            this.btnUpdateDeleteStudent = new System.Windows.Forms.Button();
            this.btnNewStudent = new System.Windows.Forms.Button();
            this.btnManageRooms = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEmployeePayment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hmsLabel
            // 
            this.hmsLabel.AutoSize = true;
            this.hmsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hmsLabel.Font = new System.Drawing.Font("Chiller", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hmsLabel.Location = new System.Drawing.Point(572, 17);
            this.hmsLabel.Name = "hmsLabel";
            this.hmsLabel.Size = new System.Drawing.Size(423, 71);
            this.hmsLabel.TabIndex = 6;
            this.hmsLabel.Text = "AIUB BOYS HOSTEL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Mistral", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 41);
            this.label1.TabIndex = 7;
            this.label1.Text = " NAVIGATOR BAR";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = global::Hostel_Management_System.Properties.Resources.Close;
            this.btnExit.Location = new System.Drawing.Point(1322, 28);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(37, 41);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 18;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Image = global::Hostel_Management_System.Properties.Resources.logout3;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(1156, 28);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(160, 41);
            this.btnLogOut.TabIndex = 17;
            this.btnLogOut.Text = "  Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnLeavedEmployee
            // 
            this.btnLeavedEmployee.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLeavedEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeavedEmployee.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeavedEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnLeavedEmployee.Image = global::Hostel_Management_System.Properties.Resources.pngwing_com__4_;
            this.btnLeavedEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLeavedEmployee.Location = new System.Drawing.Point(12, 656);
            this.btnLeavedEmployee.Name = "btnLeavedEmployee";
            this.btnLeavedEmployee.Size = new System.Drawing.Size(211, 40);
            this.btnLeavedEmployee.TabIndex = 8;
            this.btnLeavedEmployee.Text = "Leaved Employee";
            this.btnLeavedEmployee.UseVisualStyleBackColor = false;
            this.btnLeavedEmployee.Click += new System.EventHandler(this.btnLeavedEmployee_Click);
            // 
            // btnAllEmployeeWorking
            // 
            this.btnAllEmployeeWorking.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAllEmployeeWorking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllEmployeeWorking.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllEmployeeWorking.ForeColor = System.Drawing.Color.Black;
            this.btnAllEmployeeWorking.Image = global::Hostel_Management_System.Properties.Resources.pngwing1;
            this.btnAllEmployeeWorking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllEmployeeWorking.Location = new System.Drawing.Point(12, 538);
            this.btnAllEmployeeWorking.Name = "btnAllEmployeeWorking";
            this.btnAllEmployeeWorking.Size = new System.Drawing.Size(211, 40);
            this.btnAllEmployeeWorking.TabIndex = 9;
            this.btnAllEmployeeWorking.Text = "   All Employee working\r\n\r\n\r\n";
            this.btnAllEmployeeWorking.UseVisualStyleBackColor = false;
            this.btnAllEmployeeWorking.Click += new System.EventHandler(this.btnAllEmployeeWorking_Click);
            // 
            // btnUpdateDeleteEmployee
            // 
            this.btnUpdateDeleteEmployee.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdateDeleteEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateDeleteEmployee.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDeleteEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateDeleteEmployee.Image = global::Hostel_Management_System.Properties.Resources.pngwing2;
            this.btnUpdateDeleteEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateDeleteEmployee.Location = new System.Drawing.Point(12, 465);
            this.btnUpdateDeleteEmployee.Name = "btnUpdateDeleteEmployee";
            this.btnUpdateDeleteEmployee.Size = new System.Drawing.Size(211, 57);
            this.btnUpdateDeleteEmployee.TabIndex = 10;
            this.btnUpdateDeleteEmployee.Text = "Update & Delete Employee";
            this.btnUpdateDeleteEmployee.UseVisualStyleBackColor = false;
            this.btnUpdateDeleteEmployee.Click += new System.EventHandler(this.btnUpdateDeleteEmployee_Click);
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnNewEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewEmployee.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnNewEmployee.Image = global::Hostel_Management_System.Properties.Resources.Leaved_students;
            this.btnNewEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewEmployee.Location = new System.Drawing.Point(12, 419);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.Size = new System.Drawing.Size(211, 40);
            this.btnNewEmployee.TabIndex = 11;
            this.btnNewEmployee.Text = "New Employee";
            this.btnNewEmployee.UseVisualStyleBackColor = false;
            this.btnNewEmployee.Click += new System.EventHandler(this.btnNewEmployee_Click);
            // 
            // btnLeavedStudents
            // 
            this.btnLeavedStudents.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLeavedStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeavedStudents.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeavedStudents.ForeColor = System.Drawing.Color.Black;
            this.btnLeavedStudents.Image = global::Hostel_Management_System.Properties.Resources.Leaved_students;
            this.btnLeavedStudents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLeavedStudents.Location = new System.Drawing.Point(12, 350);
            this.btnLeavedStudents.Name = "btnLeavedStudents";
            this.btnLeavedStudents.Size = new System.Drawing.Size(211, 40);
            this.btnLeavedStudents.TabIndex = 11;
            this.btnLeavedStudents.Text = "Leaved Students";
            this.btnLeavedStudents.UseVisualStyleBackColor = false;
            this.btnLeavedStudents.Click += new System.EventHandler(this.btnLeavedStudents_Click);
            // 
            // btnAllStudentLiving
            // 
            this.btnAllStudentLiving.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAllStudentLiving.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllStudentLiving.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllStudentLiving.ForeColor = System.Drawing.Color.Black;
            this.btnAllStudentLiving.Image = global::Hostel_Management_System.Properties.Resources.pngwing_com__2_;
            this.btnAllStudentLiving.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllStudentLiving.Location = new System.Drawing.Point(12, 292);
            this.btnAllStudentLiving.Name = "btnAllStudentLiving";
            this.btnAllStudentLiving.Size = new System.Drawing.Size(211, 40);
            this.btnAllStudentLiving.TabIndex = 12;
            this.btnAllStudentLiving.Text = "All Student Living";
            this.btnAllStudentLiving.UseVisualStyleBackColor = false;
            this.btnAllStudentLiving.Click += new System.EventHandler(this.btnAllStudentLiving_Click);
            // 
            // btnStudentFees
            // 
            this.btnStudentFees.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnStudentFees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentFees.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentFees.ForeColor = System.Drawing.Color.Black;
            this.btnStudentFees.Image = global::Hostel_Management_System.Properties.Resources.Fees;
            this.btnStudentFees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentFees.Location = new System.Drawing.Point(9, 236);
            this.btnStudentFees.Name = "btnStudentFees";
            this.btnStudentFees.Size = new System.Drawing.Size(211, 40);
            this.btnStudentFees.TabIndex = 13;
            this.btnStudentFees.Text = "Student Fees";
            this.btnStudentFees.UseVisualStyleBackColor = false;
            this.btnStudentFees.Click += new System.EventHandler(this.btnStudentFees_Click);
            // 
            // btnUpdateDeleteStudent
            // 
            this.btnUpdateDeleteStudent.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdateDeleteStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateDeleteStudent.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDeleteStudent.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateDeleteStudent.Image = global::Hostel_Management_System.Properties.Resources.Update___Delete_Student;
            this.btnUpdateDeleteStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateDeleteStudent.Location = new System.Drawing.Point(12, 173);
            this.btnUpdateDeleteStudent.Name = "btnUpdateDeleteStudent";
            this.btnUpdateDeleteStudent.Size = new System.Drawing.Size(211, 46);
            this.btnUpdateDeleteStudent.TabIndex = 14;
            this.btnUpdateDeleteStudent.Text = " Update Delete Students";
            this.btnUpdateDeleteStudent.UseVisualStyleBackColor = false;
            this.btnUpdateDeleteStudent.Click += new System.EventHandler(this.btnUpdateDeleteStudent_Click);
            // 
            // btnNewStudent
            // 
            this.btnNewStudent.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnNewStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewStudent.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewStudent.ForeColor = System.Drawing.Color.Black;
            this.btnNewStudent.Image = global::Hostel_Management_System.Properties.Resources.new_student1;
            this.btnNewStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewStudent.Location = new System.Drawing.Point(12, 118);
            this.btnNewStudent.Name = "btnNewStudent";
            this.btnNewStudent.Size = new System.Drawing.Size(211, 40);
            this.btnNewStudent.TabIndex = 15;
            this.btnNewStudent.Text = "New Student";
            this.btnNewStudent.UseVisualStyleBackColor = false;
            this.btnNewStudent.Click += new System.EventHandler(this.btnNewStudent_Click);
            // 
            // btnManageRooms
            // 
            this.btnManageRooms.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnManageRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageRooms.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageRooms.ForeColor = System.Drawing.Color.Black;
            this.btnManageRooms.Image = global::Hostel_Management_System.Properties.Resources.room1;
            this.btnManageRooms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageRooms.Location = new System.Drawing.Point(12, 63);
            this.btnManageRooms.Name = "btnManageRooms";
            this.btnManageRooms.Size = new System.Drawing.Size(211, 40);
            this.btnManageRooms.TabIndex = 16;
            this.btnManageRooms.Text = "Manage Room";
            this.btnManageRooms.UseVisualStyleBackColor = false;
            this.btnManageRooms.Click += new System.EventHandler(this.btnManageRooms_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hostel_Management_System.Properties.Resources.pngtree_colored_flat_travel_booking_booking_hostel_composition_with_booking_the_hostel_png_image_7668262;
            this.pictureBox1.Location = new System.Drawing.Point(240, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1104, 618);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnEmployeePayment
            // 
            this.btnEmployeePayment.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEmployeePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeePayment.Location = new System.Drawing.Point(12, 596);
            this.btnEmployeePayment.Name = "btnEmployeePayment";
            this.btnEmployeePayment.Size = new System.Drawing.Size(208, 41);
            this.btnEmployeePayment.TabIndex = 19;
            this.btnEmployeePayment.Text = "Employee Payment";
            this.btnEmployeePayment.UseVisualStyleBackColor = false;
            this.btnEmployeePayment.Click += new System.EventHandler(this.btnEmployeePayment_Click);
            // 
            // Dashboard1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1368, 721);
            this.Controls.Add(this.btnEmployeePayment);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnLeavedEmployee);
            this.Controls.Add(this.btnAllEmployeeWorking);
            this.Controls.Add(this.btnUpdateDeleteEmployee);
            this.Controls.Add(this.btnNewEmployee);
            this.Controls.Add(this.btnLeavedStudents);
            this.Controls.Add(this.btnAllStudentLiving);
            this.Controls.Add(this.btnStudentFees);
            this.Controls.Add(this.btnUpdateDeleteStudent);
            this.Controls.Add(this.btnNewStudent);
            this.Controls.Add(this.btnManageRooms);
            this.Controls.Add(this.hmsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard1";
            this.Text = "Dashboard1";
            this.Load += new System.EventHandler(this.Dashboard1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnLeavedEmployee;
        private System.Windows.Forms.Button btnAllEmployeeWorking;
        private System.Windows.Forms.Button btnUpdateDeleteEmployee;
        private System.Windows.Forms.Button btnLeavedStudents;
        private System.Windows.Forms.Button btnAllStudentLiving;
        private System.Windows.Forms.Button btnStudentFees;
        private System.Windows.Forms.Button btnUpdateDeleteStudent;
        private System.Windows.Forms.Button btnNewStudent;
        private System.Windows.Forms.Button btnManageRooms;
        private System.Windows.Forms.Label hmsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnNewEmployee;
        private System.Windows.Forms.Button btnEmployeePayment;
    }
}