using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartTimeTable.Business;
using SmartTimeTable.Data;

namespace SmartTimeTable.Presentation
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void Role_Click(object sender, EventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtFirstName.Clear();
            TxtLastName.Clear();
            TxtUserName.Clear();
            TxtEmail.Clear();
            TxtDepartment.Clear();
            TxtPassword.Clear();
            TxtConfirmPassword.Clear();
            CmbRole.SelectedIndex = -1;
            DtpDOB.Value = DateTime.Now;
        }

        private void BtnADD_Click(object sender, EventArgs e)
        {
            // 1) Validate inputs
            if (string.IsNullOrWhiteSpace(TxtFirstName.Text) ||
                string.IsNullOrWhiteSpace(TxtLastName.Text) ||
                string.IsNullOrWhiteSpace(TxtUserName.Text) ||
                string.IsNullOrWhiteSpace(TxtEmail.Text) ||
                string.IsNullOrWhiteSpace(TxtDepartment.Text) ||
                CmbRole.SelectedIndex < 0 ||
                string.IsNullOrWhiteSpace(TxtPassword.Text) ||
                string.IsNullOrWhiteSpace(TxtConfirmPassword.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (TxtPassword.Text != TxtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2) Build your User object
            var user = new User
            {
                FirstName = TxtFirstName.Text.Trim(),
                LastName = TxtLastName.Text.Trim(),
                UserName = TxtUserName.Text.Trim(),
                Email = TxtEmail.Text.Trim(),
                Department = TxtDepartment.Text.Trim(),
                Role = CmbRole.SelectedItem.ToString(),   // "Teacher" or "Student"
                Password = TxtPassword.Text,                  // plain-text for now
                DateOfBirth = DtpDOB.Value
            };

            // 3) Save to Users + (Teacher|Student) in one go
            Connection.SaveUser(user);

            // 4) Feedback & clear
            MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BtnClear_Click(sender, e);
        }

        private void LblCross_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnset_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Timetable().Show();
        }
    }
}