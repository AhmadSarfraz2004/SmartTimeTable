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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtUserName.Clear();
            txtEmail.Clear();
            txtDepartment.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            cmbRole.SelectedIndex = -1;
            dtpDOB.Value = DateTime.Now;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
    string.IsNullOrWhiteSpace(txtLastName.Text) ||
    string.IsNullOrWhiteSpace(txtUserName.Text) ||
    string.IsNullOrWhiteSpace(txtEmail.Text) ||
    string.IsNullOrWhiteSpace(txtDepartment.Text) ||
    string.IsNullOrWhiteSpace(txtPassword.Text) ||
    string.IsNullOrWhiteSpace(txtConfirmPassword.Text) ||
    cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields before signing up!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            User user = new User
            {
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                UserName = txtUserName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Department = txtDepartment.Text.Trim(),
                Role = cmbRole.SelectedItem?.ToString() ?? "Student",
                Password = txtPassword.Text.Trim(),
                DateOfBirth = dtpDOB.Value
            };

            Connection.RegisterUser(user);
            MessageBox.Show("User Registered Successfully!");

            this.Hide();
            new Login().Show();
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void lblcross_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

