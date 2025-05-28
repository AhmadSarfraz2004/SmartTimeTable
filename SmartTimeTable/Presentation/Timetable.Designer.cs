namespace SmartTimeTable.Presentation
{
    partial class Timetable
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
            LBLTimetable = new Label();
            LBLteacherName = new Label();
            LBLteacherID = new Label();
            txtTeacherID = new TextBox();
            LBLDept = new Label();
            txtDept = new TextBox();
            LBLDate = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            LBLDay = new Label();
            LBLroomNumber = new Label();
            txtRoomNumber = new TextBox();
            LBLcourseName = new Label();
            txtCourseName = new TextBox();
            LBLcourseCode = new Label();
            txtCourseCode = new TextBox();
            LBLstartTime = new Label();
            txtStartTime = new TextBox();
            LBLendTime = new Label();
            txtEndTime = new TextBox();
            BtnClear = new Button();
            btnSubmit = new Button();
            cmbTeacherName = new ComboBox();
            dtpDate = new DateTimePicker();
            LblCross = new Label();
            cmbDay = new ComboBox();
            btnchecktimetbl = new Label();
            lbltimetbl = new Label();
            lblLecture = new Label();
            cmbLecture = new ComboBox();
            btnBack = new Label();
            SuspendLayout();
            // 
            // LBLTimetable
            // 
            LBLTimetable.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LBLTimetable.AutoSize = true;
            LBLTimetable.Font = new Font("Nirmala UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLTimetable.ForeColor = Color.FromArgb(116, 86, 174);
            LBLTimetable.Location = new Point(456, 41);
            LBLTimetable.Name = "LBLTimetable";
            LBLTimetable.Size = new Size(374, 62);
            LBLTimetable.TabIndex = 0;
            LBLTimetable.Text = "Timetable Form";
            // 
            // LBLteacherName
            // 
            LBLteacherName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LBLteacherName.AutoSize = true;
            LBLteacherName.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLteacherName.ForeColor = Color.Gray;
            LBLteacherName.Location = new Point(69, 127);
            LBLteacherName.Name = "LBLteacherName";
            LBLteacherName.Size = new Size(147, 28);
            LBLteacherName.TabIndex = 0;
            LBLteacherName.Text = "Teacher Name";
            // 
            // LBLteacherID
            // 
            LBLteacherID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LBLteacherID.AutoSize = true;
            LBLteacherID.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLteacherID.ForeColor = Color.Gray;
            LBLteacherID.Location = new Point(465, 127);
            LBLteacherID.Name = "LBLteacherID";
            LBLteacherID.Size = new Size(112, 28);
            LBLteacherID.TabIndex = 0;
            LBLteacherID.Text = "Teacher ID";
            // 
            // txtTeacherID
            // 
            txtTeacherID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTeacherID.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTeacherID.Location = new Point(471, 160);
            txtTeacherID.Multiline = true;
            txtTeacherID.Name = "txtTeacherID";
            txtTeacherID.Size = new Size(339, 37);
            txtTeacherID.TabIndex = 31;
            // 
            // LBLDept
            // 
            LBLDept.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LBLDept.AutoSize = true;
            LBLDept.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLDept.ForeColor = Color.Gray;
            LBLDept.Location = new Point(887, 127);
            LBLDept.Name = "LBLDept";
            LBLDept.Size = new Size(127, 28);
            LBLDept.TabIndex = 0;
            LBLDept.Text = "Department";
            // 
            // txtDept
            // 
            txtDept.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDept.Font = new Font("Nirmala UI", 12F);
            txtDept.Location = new Point(891, 160);
            txtDept.Multiline = true;
            txtDept.Name = "txtDept";
            txtDept.Size = new Size(315, 37);
            txtDept.TabIndex = 32;
            // 
            // LBLDate
            // 
            LBLDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LBLDate.AutoSize = true;
            LBLDate.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLDate.ForeColor = Color.Gray;
            LBLDate.Location = new Point(69, 259);
            LBLDate.Name = "LBLDate";
            LBLDate.Size = new Size(197, 28);
            LBLDate.TabIndex = 0;
            LBLDate.Text = "Date (MM-DD-YYY)";
            // 
            // LBLDay
            // 
            LBLDay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LBLDay.AutoSize = true;
            LBLDay.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLDay.ForeColor = Color.Gray;
            LBLDay.Location = new Point(463, 259);
            LBLDay.Name = "LBLDay";
            LBLDay.Size = new Size(49, 28);
            LBLDay.TabIndex = 0;
            LBLDay.Text = "Day";
            // 
            // LBLroomNumber
            // 
            LBLroomNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LBLroomNumber.AutoSize = true;
            LBLroomNumber.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLroomNumber.ForeColor = Color.Gray;
            LBLroomNumber.Location = new Point(887, 259);
            LBLroomNumber.Name = "LBLroomNumber";
            LBLroomNumber.Size = new Size(149, 28);
            LBLroomNumber.TabIndex = 0;
            LBLroomNumber.Text = "Room Number";
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRoomNumber.Font = new Font("Nirmala UI", 12F);
            txtRoomNumber.Location = new Point(891, 293);
            txtRoomNumber.Multiline = true;
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new Size(315, 37);
            txtRoomNumber.TabIndex = 35;
            // 
            // LBLcourseName
            // 
            LBLcourseName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LBLcourseName.AutoSize = true;
            LBLcourseName.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLcourseName.ForeColor = Color.Gray;
            LBLcourseName.Location = new Point(69, 373);
            LBLcourseName.Name = "LBLcourseName";
            LBLcourseName.Size = new Size(138, 28);
            LBLcourseName.TabIndex = 0;
            LBLcourseName.Text = "Course Name";
            // 
            // txtCourseName
            // 
            txtCourseName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCourseName.Font = new Font("Nirmala UI", 12F);
            txtCourseName.Location = new Point(73, 407);
            txtCourseName.Multiline = true;
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(737, 37);
            txtCourseName.TabIndex = 36;
            // 
            // LBLcourseCode
            // 
            LBLcourseCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LBLcourseCode.AutoSize = true;
            LBLcourseCode.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLcourseCode.ForeColor = Color.Gray;
            LBLcourseCode.Location = new Point(887, 373);
            LBLcourseCode.Name = "LBLcourseCode";
            LBLcourseCode.Size = new Size(129, 28);
            LBLcourseCode.TabIndex = 0;
            LBLcourseCode.Text = "Course Code";
            // 
            // txtCourseCode
            // 
            txtCourseCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCourseCode.Font = new Font("Nirmala UI", 12F);
            txtCourseCode.Location = new Point(891, 407);
            txtCourseCode.Multiline = true;
            txtCourseCode.Name = "txtCourseCode";
            txtCourseCode.Size = new Size(315, 37);
            txtCourseCode.TabIndex = 37;
            txtCourseCode.TextChanged += textBox1_TextChanged;
            // 
            // LBLstartTime
            // 
            LBLstartTime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LBLstartTime.AutoSize = true;
            LBLstartTime.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLstartTime.ForeColor = Color.Gray;
            LBLstartTime.Location = new Point(494, 504);
            LBLstartTime.Name = "LBLstartTime";
            LBLstartTime.Size = new Size(187, 28);
            LBLstartTime.TabIndex = 0;
            LBLstartTime.Text = "Lecture Start Time";
            // 
            // txtStartTime
            // 
            txtStartTime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStartTime.Font = new Font("Nirmala UI", 12F);
            txtStartTime.Location = new Point(497, 537);
            txtStartTime.Multiline = true;
            txtStartTime.Name = "txtStartTime";
            txtStartTime.Size = new Size(307, 37);
            txtStartTime.TabIndex = 39;
            // 
            // LBLendTime
            // 
            LBLendTime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LBLendTime.AutoSize = true;
            LBLendTime.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLendTime.ForeColor = Color.Gray;
            LBLendTime.Location = new Point(891, 504);
            LBLendTime.Name = "LBLendTime";
            LBLendTime.Size = new Size(176, 28);
            LBLendTime.TabIndex = 0;
            LBLendTime.Text = "Lecture End Time";
            // 
            // txtEndTime
            // 
            txtEndTime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEndTime.Font = new Font("Nirmala UI", 12F);
            txtEndTime.Location = new Point(891, 537);
            txtEndTime.Multiline = true;
            txtEndTime.Name = "txtEndTime";
            txtEndTime.Size = new Size(315, 37);
            txtEndTime.TabIndex = 40;
            // 
            // BtnClear
            // 
            BtnClear.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnClear.BackColor = Color.White;
            BtnClear.FlatStyle = FlatStyle.Flat;
            BtnClear.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnClear.ForeColor = Color.FromArgb(116, 86, 174);
            BtnClear.Location = new Point(999, 607);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(207, 57);
            BtnClear.TabIndex = 42;
            BtnClear.Text = "CLEAR";
            BtnClear.UseVisualStyleBackColor = false;
            BtnClear.Click += BtnClear_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSubmit.BackColor = Color.FromArgb(116, 86, 174);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(745, 607);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(207, 57);
            btnSubmit.TabIndex = 41;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // cmbTeacherName
            // 
            cmbTeacherName.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbTeacherName.FormattingEnabled = true;
            cmbTeacherName.Location = new Point(73, 160);
            cmbTeacherName.Margin = new Padding(2, 3, 2, 3);
            cmbTeacherName.Name = "cmbTeacherName";
            cmbTeacherName.Size = new Size(308, 36);
            cmbTeacherName.TabIndex = 30;
            cmbTeacherName.SelectedIndexChanged += cmbTeacherName_SelectedIndexChanged;
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Nirmala UI", 12F);
            dtpDate.Location = new Point(73, 295);
            dtpDate.Margin = new Padding(2, 3, 2, 3);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(308, 34);
            dtpDate.TabIndex = 42;
            // 
            // LblCross
            // 
            LblCross.AutoSize = true;
            LblCross.BackColor = Color.Red;
            LblCross.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblCross.Location = new Point(1250, 16);
            LblCross.Name = "LblCross";
            LblCross.Size = new Size(24, 28);
            LblCross.TabIndex = 0;
            LblCross.Text = "X";
            LblCross.Click += LblCross_Click;
            // 
            // cmbDay
            // 
            cmbDay.Font = new Font("Nirmala UI", 12F);
            cmbDay.FormattingEnabled = true;
            cmbDay.Items.AddRange(new object[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" });
            cmbDay.Location = new Point(471, 296);
            cmbDay.Margin = new Padding(2, 3, 2, 3);
            cmbDay.Name = "cmbDay";
            cmbDay.Size = new Size(339, 36);
            cmbDay.TabIndex = 30;
            cmbDay.SelectedIndexChanged += cmbTeacherName_SelectedIndexChanged;
            // 
            // btnchecktimetbl
            // 
            btnchecktimetbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnchecktimetbl.AutoSize = true;
            btnchecktimetbl.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnchecktimetbl.ForeColor = Color.FromArgb(116, 86, 174);
            btnchecktimetbl.Location = new Point(994, 687);
            btnchecktimetbl.Name = "btnchecktimetbl";
            btnchecktimetbl.Size = new Size(58, 23);
            btnchecktimetbl.TabIndex = 43;
            btnchecktimetbl.Text = "Check";
            btnchecktimetbl.Click += btnchecktimetbl_Click;
            // 
            // lbltimetbl
            // 
            lbltimetbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbltimetbl.AutoSize = true;
            lbltimetbl.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltimetbl.Location = new Point(851, 687);
            lbltimetbl.Name = "lbltimetbl";
            lbltimetbl.Size = new Size(145, 23);
            lbltimetbl.TabIndex = 0;
            lbltimetbl.Text = "Check TimeTable?";
            // 
            // lblLecture
            // 
            lblLecture.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblLecture.AutoSize = true;
            lblLecture.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLecture.ForeColor = Color.Gray;
            lblLecture.Location = new Point(73, 504);
            lblLecture.Name = "lblLecture";
            lblLecture.Size = new Size(82, 28);
            lblLecture.TabIndex = 0;
            lblLecture.Text = "Lecture";
            // 
            // cmbLecture
            // 
            cmbLecture.Font = new Font("Nirmala UI", 12F);
            cmbLecture.FormattingEnabled = true;
            cmbLecture.Items.AddRange(new object[] { "1st", "2nd", "3rd", "4th", "5th", "6th" });
            cmbLecture.Location = new Point(73, 537);
            cmbLecture.Margin = new Padding(2, 3, 2, 3);
            cmbLecture.Name = "cmbLecture";
            cmbLecture.Size = new Size(339, 36);
            cmbLecture.TabIndex = 38;
            cmbLecture.SelectedIndexChanged += cmbTeacherName_SelectedIndexChanged;
            // 
            // btnBack
            // 
            btnBack.AutoSize = true;
            btnBack.Font = new Font("Nirmala UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.FromArgb(116, 86, 174);
            btnBack.Location = new Point(57, 31);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(59, 62);
            btnBack.TabIndex = 44;
            btnBack.Text = "⮌\t";
            btnBack.Click += btnBack_Click;
            // 
            // Timetable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 737);
            Controls.Add(btnBack);
            Controls.Add(btnchecktimetbl);
            Controls.Add(lbltimetbl);
            Controls.Add(LblCross);
            Controls.Add(dtpDate);
            Controls.Add(cmbLecture);
            Controls.Add(cmbDay);
            Controls.Add(cmbTeacherName);
            Controls.Add(BtnClear);
            Controls.Add(btnSubmit);
            Controls.Add(txtDept);
            Controls.Add(LBLDept);
            Controls.Add(txtTeacherID);
            Controls.Add(LBLteacherID);
            Controls.Add(txtEndTime);
            Controls.Add(LBLendTime);
            Controls.Add(txtStartTime);
            Controls.Add(lblLecture);
            Controls.Add(LBLstartTime);
            Controls.Add(txtCourseCode);
            Controls.Add(LBLcourseCode);
            Controls.Add(txtRoomNumber);
            Controls.Add(LBLroomNumber);
            Controls.Add(txtCourseName);
            Controls.Add(LBLcourseName);
            Controls.Add(LBLDay);
            Controls.Add(LBLDate);
            Controls.Add(LBLteacherName);
            Controls.Add(LBLTimetable);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Timetable";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Timetable";
            Load += Timetable_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBLTimetable;
        private Label LBLteacherName;
        private Label LBLteacherID;
        private TextBox txtTeacherID;
        private Label LBLDept;
        private TextBox txtDept;
        private Label LBLDate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label LBLDay;
        private Label LBLroomNumber;
        private TextBox txtRoomNumber;
        private Label LBLcourseName;
        private TextBox txtCourseName;
        private Label LBLcourseCode;
        private TextBox txtCourseCode;
        private Label LBLstartTime;
        private TextBox txtStartTime;
        private Label LBLendTime;
        private TextBox txtEndTime;
        private Button BtnClear;
        private Button btnSubmit;
        private ComboBox cmbTeacherName;
        private DateTimePicker dtpDate;
        private Label LblCross;
        private ComboBox cmbDay;
        private Label btnchecktimetbl;
        private Label lbltimetbl;
        private Label lblLecture;
        private ComboBox cmbLecture;
        private Label btnBack;
    }
}