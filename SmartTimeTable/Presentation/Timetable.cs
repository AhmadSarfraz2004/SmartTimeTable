using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartTimeTable.Business;
using SmartTimeTable.Data;


namespace SmartTimeTable.Presentation
{
    public partial class Timetable : Form
    {

        public Timetable()
        {
            InitializeComponent();
        }

        private void Timetable_Load(object sender, EventArgs e)
        {
            DataTable teachers = Connection.GetTeachersTable();
            cmbTeacherName.DataSource = teachers;
            cmbTeacherName.DisplayMember = "FullName";
            cmbTeacherName.ValueMember = "Id";
        }

        private void cmbTeacherName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTeacherName.SelectedValue is int id)
            {
                txtTeacherID.Text = id.ToString();
                txtDept.Text = Connection.GetTeacherDepartment(id);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int teacherId = int.Parse(txtTeacherID.Text);
            string teacherName = cmbTeacherName.Text;     // same as the combo’s DisplayMember
            string department = txtDept.Text;

            // The rest of your fields
            int room = int.Parse(txtRoomNumber.Text);
            string day = cmbDay.Text;
            string Ccode = txtCourseCode.Text;
            string cName = txtCourseName.Text;
            DateTime date = DateTime.Parse(dtpDate.Text);
            string lecture = cmbLecture.Text;
            // === Strict HH:mm parsing for start/end ===
            const string timeFormat = "hh\\:mm";
            if (!TimeSpan.TryParseExact(txtStartTime.Text, timeFormat,
                    null, out TimeSpan start))
            {
                MessageBox.Show("Start time must be in 24-hour HH:mm format, e.g. 09:30");
                return;
            }
            if (!TimeSpan.TryParseExact(txtEndTime.Text, timeFormat,
                    null, out TimeSpan end))
            {
                MessageBox.Show("End time must be in 24-hour HH:mm format, e.g. 14:50");
                return;
            }

            // Insert everything in one go:
            Connection.InsertTimeTable(
                teacherId,
                teacherName,
                department,
                room,
                day,
                Ccode,
                cName,
                date,
                lecture: lecture,
                start,
                end
            );

            MessageBox.Show("Timetable entry saved!");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblCross_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            cmbTeacherName.SelectedIndex = -1;
            txtTeacherID.Clear();
            txtDept.Clear();
            dtpDate.Value = DateTime.Now;
            cmbDay.SelectedIndex = -1;
            txtRoomNumber.Clear();
            txtCourseName.Clear();
            txtCourseCode.Clear();
            txtStartTime.Clear();
            txtEndTime.Clear();
        }
        private readonly User _currentUser;

        private void btnchecktimetbl_Click(object sender, EventArgs e)
        {

            this.Hide();
            new Gridlayout().Show();
        }
    }
}

