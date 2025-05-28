namespace SmartTimeTable
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtUserName = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            btnLogIn = new Button();
            label4 = new Label();
            label5 = new Label();
            lblRole = new Label();
            comboBox1 = new ComboBox();
            lblCross = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(209, 75);
            label1.Name = "label1";
            label1.Size = new Size(150, 62);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(67, 261);
            label2.Name = "label2";
            label2.Size = new Size(116, 28);
            label2.TabIndex = 0;
            label2.Text = "User Name";
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUserName.Font = new Font("Nirmala UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(71, 295);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(415, 45);
            txtUserName.TabIndex = 15;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(69, 371);
            label3.Name = "label3";
            label3.Size = new Size(100, 28);
            label3.TabIndex = 0;
            label3.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Font = new Font("Nirmala UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(71, 404);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(415, 43);
            txtPassword.TabIndex = 16;
            // 
            // btnLogIn
            // 
            btnLogIn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnLogIn.BackColor = Color.FromArgb(116, 86, 174);
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogIn.ForeColor = Color.White;
            btnLogIn.Location = new Point(133, 523);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(312, 59);
            btnLogIn.TabIndex = 17;
            btnLogIn.Text = "LOGIN";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(149, 612);
            label4.Name = "label4";
            label4.Size = new Size(194, 23);
            label4.TabIndex = 0;
            label4.Text = "Don't Have an Account?";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(116, 86, 174);
            label5.Location = new Point(341, 612);
            label5.Name = "label5";
            label5.Size = new Size(76, 23);
            label5.TabIndex = 18;
            label5.Text = "Register";
            label5.Click += label5_Click;
            // 
            // lblRole
            // 
            lblRole.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.Gray;
            lblRole.Location = new Point(71, 175);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(53, 28);
            lblRole.TabIndex = 0;
            lblRole.Text = "Role";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Nirmala UI", 14.25F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "Teacher", "Student" });
            comboBox1.Location = new Point(71, 201);
            comboBox1.Margin = new Padding(1);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(415, 40);
            comboBox1.TabIndex = 14;
            // 
            // lblCross
            // 
            lblCross.AutoSize = true;
            lblCross.BackColor = Color.Red;
            lblCross.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCross.Location = new Point(565, 17);
            lblCross.Name = "lblCross";
            lblCross.Size = new Size(24, 28);
            lblCross.TabIndex = 13;
            lblCross.Text = "X";
            lblCross.Click += lblCross_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 768);
            Controls.Add(lblCross);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnLogIn);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(lblRole);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUserName;
        private Label label3;
        private TextBox txtPassword;
        private CheckBox bxShowPassword;
        private Button btnLogIn;
        private Label label4;
        private Label label5;
        private Label lblRole;
        private ComboBox comboBox1;
        private Label lblCross;
    }
}
