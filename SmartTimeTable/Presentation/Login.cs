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
            string userInput = txtUserName.Text.Trim();   // This can be either Email or Username
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(userInput) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both Username/Email and Password!");
                return;
            }

            // Hardcoded Admin Check (Optional)
            if (userInput == "Ahmad" && password == "Password")
            {
                MessageBox.Show($"Welcome Ahmad! Logged in as Admin");
                this.Hide();
                new Presentation.AddUser().Show();
                return;
            }

            // Normal Database Login
            User user = Connection.LoginUser(userInput, password);

            if (user != null)
            {
                MessageBox.Show($"Welcome {user.FirstName}! Logged in as {user.Role}");

                this.Hide();

                if (user.Role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                {
                    new Presentation.AddUser().Show(); // Admin goes to AddUser
                }
                else if (user.Role.Equals("Teacher", StringComparison.OrdinalIgnoreCase) ||
                         user.Role.Equals("Student", StringComparison.OrdinalIgnoreCase))
                {
                    new Presentation.Gridlayout().Show(); // Teacher or Student goes to Gridlayout
                }
                else
                {
                    MessageBox.Show("Unrecognized Role!");
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid Username/Email or Password!");
            }
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
