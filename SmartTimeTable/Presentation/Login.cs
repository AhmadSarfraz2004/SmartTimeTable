using SmartTimeTable.Business;
using SmartTimeTable.Data;
using SmartTimeTable.Presentation;

namespace SmartTimeTable
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            var userInput = txtUserName.Text.Trim();
            var password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(userInput) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both Username/Email and Password!");
                return;
            }

            // Optional hard-coded Admin:
            if (userInput.Equals("Admin", StringComparison.OrdinalIgnoreCase)
                && password == "Password")
            {
                Session.CurrentUser = new User
                {
                    FirstName = "Admin",
                    Role = "Admin"
                };

                Hide();
                new AddUser().Show();
                return;
            }

            // DB login:
            var user = Connection.LoginUser(userInput, password);
            if (user == null)
            {
                MessageBox.Show("Invalid Username/Email or Password!");
                return;
            }

            // Save into session
            Session.CurrentUser = user;
            MessageBox.Show($"Welcome {user.FirstName}! Logged in as {user.Role}");

            Hide();
            if (user.Role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                new AddUser().Show();
            else
                new Gridlayout().Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Register().Show();
        }

        private void lblCross_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
