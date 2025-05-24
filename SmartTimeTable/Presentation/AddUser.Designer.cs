namespace SmartTimeTable.Presentation
{
    partial class AddUser
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
            LBLaddTeacher = new Label();
            TxtLastName = new TextBox();
            lblLastName = new Label();
            TxtFirstName = new TextBox();
            lblFirstName = new Label();
            TxtUserName = new TextBox();
            lblUserName = new Label();
            TxtEmail = new TextBox();
            Email = new Label();
            TxtDepartment = new TextBox();
            Department = new Label();
            CmbRole = new ComboBox();
            Role = new Label();
            DtpDOB = new DateTimePicker();
            lblDOB = new Label();
            BtnClear = new Button();
            BtnADD = new Button();
            TxtConfirmPassword = new TextBox();
            lblConfirmPassword = new Label();
            TxtPassword = new TextBox();
            lblPassword = new Label();
            LblCross = new Label();
            btnset = new Label();
            lblsettimetable = new Label();
            SuspendLayout();
            // 
            // LBLaddTeacher
            // 
            LBLaddTeacher.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LBLaddTeacher.AutoSize = true;
            LBLaddTeacher.Font = new Font("Nirmala UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLaddTeacher.ForeColor = Color.FromArgb(116, 86, 174);
            LBLaddTeacher.Location = new Point(505, 21);
            LBLaddTeacher.Name = "LBLaddTeacher";
            LBLaddTeacher.Size = new Size(230, 62);
            LBLaddTeacher.TabIndex = 0;
            LBLaddTeacher.Text = "Add User";
            // 
            // TxtLastName
            // 
            TxtLastName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtLastName.Font = new Font("Nirmala UI", 14.25F);
            TxtLastName.Location = new Point(357, 137);
            TxtLastName.Multiline = true;
            TxtLastName.Name = "TxtLastName";
            TxtLastName.Size = new Size(237, 37);
            TxtLastName.TabIndex = 20;
            // 
            // lblLastName
            // 
            lblLastName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastName.ForeColor = Color.Gray;
            lblLastName.Location = new Point(353, 104);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(112, 28);
            lblLastName.TabIndex = 0;
            lblLastName.Text = "Last Name";
            lblLastName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtFirstName
            // 
            TxtFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtFirstName.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtFirstName.Location = new Point(37, 137);
            TxtFirstName.Multiline = true;
            TxtFirstName.Name = "TxtFirstName";
            TxtFirstName.Size = new Size(237, 37);
            TxtFirstName.TabIndex = 19;
            // 
            // lblFirstName
            // 
            lblFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstName.ForeColor = Color.Gray;
            lblFirstName.Location = new Point(33, 104);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(115, 28);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // TxtUserName
            // 
            TxtUserName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtUserName.Font = new Font("Nirmala UI", 14.25F);
            TxtUserName.Location = new Point(37, 231);
            TxtUserName.Multiline = true;
            TxtUserName.Name = "TxtUserName";
            TxtUserName.Size = new Size(557, 37);
            TxtUserName.TabIndex = 23;
            // 
            // lblUserName
            // 
            lblUserName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = Color.Gray;
            lblUserName.Location = new Point(33, 199);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(116, 28);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "User Name";
            // 
            // TxtEmail
            // 
            TxtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtEmail.Font = new Font("Nirmala UI", 14.25F);
            TxtEmail.Location = new Point(39, 345);
            TxtEmail.Multiline = true;
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(883, 37);
            TxtEmail.TabIndex = 25;
            // 
            // Email
            // 
            Email.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Email.AutoSize = true;
            Email.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Email.ForeColor = Color.Gray;
            Email.Location = new Point(33, 311);
            Email.Name = "Email";
            Email.Size = new Size(64, 28);
            Email.TabIndex = 0;
            Email.Text = "Email";
            // 
            // TxtDepartment
            // 
            TxtDepartment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtDepartment.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtDepartment.Location = new Point(993, 137);
            TxtDepartment.Multiline = true;
            TxtDepartment.Name = "TxtDepartment";
            TxtDepartment.Size = new Size(237, 37);
            TxtDepartment.TabIndex = 22;
            TxtDepartment.TextChanged += TxtDepartment_TextChanged;
            // 
            // Department
            // 
            Department.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Department.AutoSize = true;
            Department.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Department.ForeColor = Color.Gray;
            Department.Location = new Point(993, 104);
            Department.Name = "Department";
            Department.Size = new Size(127, 28);
            Department.TabIndex = 0;
            Department.Text = "Department";
            // 
            // CmbRole
            // 
            CmbRole.Font = new Font("Nirmala UI", 14.25F);
            CmbRole.FormattingEnabled = true;
            CmbRole.Items.AddRange(new object[] { "Teacher", "Student" });
            CmbRole.Location = new Point(703, 137);
            CmbRole.Margin = new Padding(1);
            CmbRole.Name = "CmbRole";
            CmbRole.Size = new Size(197, 40);
            CmbRole.TabIndex = 21;
            // 
            // Role
            // 
            Role.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Role.AutoSize = true;
            Role.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Role.ForeColor = Color.Gray;
            Role.Location = new Point(703, 104);
            Role.Name = "Role";
            Role.Size = new Size(53, 28);
            Role.TabIndex = 0;
            Role.Text = "Role";
            Role.Click += Role_Click;
            // 
            // DtpDOB
            // 
            DtpDOB.Font = new Font("Nirmala UI", 14.25F);
            DtpDOB.Location = new Point(703, 241);
            DtpDOB.Name = "DtpDOB";
            DtpDOB.Size = new Size(525, 39);
            DtpDOB.TabIndex = 24;
            DtpDOB.ValueChanged += DtpDOB_ValueChanged;
            // 
            // lblDOB
            // 
            lblDOB.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDOB.ForeColor = Color.Gray;
            lblDOB.Location = new Point(697, 207);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(137, 28);
            lblDOB.TabIndex = 0;
            lblDOB.Text = "Date of Birth";
            // 
            // BtnClear
            // 
            BtnClear.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnClear.BackColor = Color.White;
            BtnClear.FlatStyle = FlatStyle.Flat;
            BtnClear.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnClear.ForeColor = Color.FromArgb(116, 86, 174);
            BtnClear.Location = new Point(1033, 527);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(207, 57);
            BtnClear.TabIndex = 29;
            BtnClear.Text = "CLEAR";
            BtnClear.UseVisualStyleBackColor = false;
            BtnClear.Click += BtnClear_Click;
            // 
            // BtnADD
            // 
            BtnADD.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnADD.BackColor = Color.FromArgb(116, 86, 174);
            BtnADD.FlatStyle = FlatStyle.Flat;
            BtnADD.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnADD.ForeColor = Color.White;
            BtnADD.Location = new Point(777, 527);
            BtnADD.Name = "BtnADD";
            BtnADD.Size = new Size(207, 57);
            BtnADD.TabIndex = 28;
            BtnADD.Text = "ADD";
            BtnADD.UseVisualStyleBackColor = false;
            BtnADD.Click += BtnADD_Click;
            // 
            // TxtConfirmPassword
            // 
            TxtConfirmPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtConfirmPassword.Font = new Font("Nirmala UI", 14.25F);
            TxtConfirmPassword.Location = new Point(687, 445);
            TxtConfirmPassword.Multiline = true;
            TxtConfirmPassword.Name = "TxtConfirmPassword";
            TxtConfirmPassword.PasswordChar = '*';
            TxtConfirmPassword.Size = new Size(551, 37);
            TxtConfirmPassword.TabIndex = 27;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirmPassword.ForeColor = Color.Gray;
            lblConfirmPassword.Location = new Point(683, 411);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(182, 28);
            lblConfirmPassword.TabIndex = 0;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // TxtPassword
            // 
            TxtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtPassword.Font = new Font("Nirmala UI", 14.25F);
            TxtPassword.Location = new Point(39, 445);
            TxtPassword.Multiline = true;
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '*';
            TxtPassword.Size = new Size(557, 37);
            TxtPassword.TabIndex = 26;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.Gray;
            lblPassword.Location = new Point(33, 411);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 28);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Password";
            // 
            // LblCross
            // 
            LblCross.AutoSize = true;
            LblCross.BackColor = Color.Red;
            LblCross.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblCross.Location = new Point(1225, 12);
            LblCross.Name = "LblCross";
            LblCross.Size = new Size(24, 28);
            LblCross.TabIndex = 0;
            LblCross.Text = "X";
            LblCross.Click += LblCross_Click;
            // 
            // btnset
            // 
            btnset.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnset.AutoSize = true;
            btnset.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnset.ForeColor = Color.FromArgb(116, 86, 174);
            btnset.Location = new Point(993, 608);
            btnset.Name = "btnset";
            btnset.Size = new Size(36, 23);
            btnset.TabIndex = 45;
            btnset.Text = "Set";
            btnset.Click += btnset_Click;
            // 
            // lblsettimetable
            // 
            lblsettimetable.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblsettimetable.AutoSize = true;
            lblsettimetable.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblsettimetable.Location = new Point(879, 608);
            lblsettimetable.Name = "lblsettimetable";
            lblsettimetable.Size = new Size(123, 23);
            lblsettimetable.TabIndex = 44;
            lblsettimetable.Text = "Set TimeTable?";
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1265, 692);
            Controls.Add(btnset);
            Controls.Add(lblsettimetable);
            Controls.Add(LblCross);
            Controls.Add(BtnClear);
            Controls.Add(BtnADD);
            Controls.Add(TxtConfirmPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(TxtPassword);
            Controls.Add(lblPassword);
            Controls.Add(DtpDOB);
            Controls.Add(lblDOB);
            Controls.Add(CmbRole);
            Controls.Add(Role);
            Controls.Add(TxtDepartment);
            Controls.Add(Department);
            Controls.Add(TxtEmail);
            Controls.Add(Email);
            Controls.Add(TxtUserName);
            Controls.Add(lblUserName);
            Controls.Add(TxtLastName);
            Controls.Add(lblLastName);
            Controls.Add(TxtFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(LBLaddTeacher);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(1);
            Name = "AddUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBLaddTeacher;
        private TextBox TxtLastName;
        private Label lblLastName;
        private TextBox TxtFirstName;
        private Label lblFirstName;
        private TextBox TxtUserName;
        private Label lblUserName;
        private TextBox TxtEmail;
        private Label Email;
        private TextBox TxtDepartment;
        private Label Department;
        private ComboBox CmbRole;
        private Label Role;
        private DateTimePicker DtpDOB;
        private Label lblDOB;
        private Button BtnClear;
        private Button BtnADD;
        private TextBox TxtConfirmPassword;
        private Label lblConfirmPassword;
        private TextBox TxtPassword;
        private Label lblPassword;
        private Label LblCross;
        private Label btnset;
        private Label lblsettimetable;
    }
}