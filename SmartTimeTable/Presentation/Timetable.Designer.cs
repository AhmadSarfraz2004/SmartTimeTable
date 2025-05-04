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
            SuspendLayout();
            // 
            // LBLTimetable
            // 
            LBLTimetable.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LBLTimetable.AutoSize = true;
            LBLTimetable.Font = new Font("Nirmala UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLTimetable.ForeColor = Color.FromArgb(116, 86, 174);
            LBLTimetable.Location = new Point(570, 51);
            LBLTimetable.Margin = new Padding(4, 0, 4, 0);
            LBLTimetable.Name = "LBLTimetable";
            LBLTimetable.Size = new Size(455, 76);
            LBLTimetable.TabIndex = 0;
            LBLTimetable.Text = "Timetable Form";
            // 
            // LBLteacherName
            // 
            LBLteacherName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LBLteacherName.AutoSize = true;
            LBLteacherName.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLteacherName.ForeColor = Color.Gray;
            LBLteacherName.Location = new Point(86, 158);
            LBLteacherName.Margin = new Padding(4, 0, 4, 0);
            LBLteacherName.Name = "LBLteacherName";
            LBLteacherName.Size = new Size(175, 32);
            LBLteacherName.TabIndex = 0;
            LBLteacherName.Text = "Teacher Name";
            // 
            // LBLteacherID
            // 
            LBLteacherID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LBLteacherID.AutoSize = true;
            LBLteacherID.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLteacherID.ForeColor = Color.Gray;
            LBLteacherID.Location = new Point(582, 158);
            LBLteacherID.Margin = new Padding(4, 0, 4, 0);
            LBLteacherID.Name = "LBLteacherID";
            LBLteacherID.Size = new Size(134, 32);
            LBLteacherID.TabIndex = 0;
            LBLteacherID.Text = "Teacher ID";
            // 
            // txtTeacherID
            // 
            txtTeacherID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTeacherID.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTeacherID.Location = new Point(588, 200);
            txtTeacherID.Margin = new Padding(4);
            txtTeacherID.Multiline = true;
            txtTeacherID.Name = "txtTeacherID";
            txtTeacherID.Size = new Size(423, 45);
            txtTeacherID.TabIndex = 31;
            // 
            // LBLDept
            // 
            LBLDept.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LBLDept.AutoSize = true;
            LBLDept.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLDept.ForeColor = Color.Gray;
            LBLDept.Location = new Point(1109, 158);
            LBLDept.Margin = new Padding(4, 0, 4, 0);
            LBLDept.Name = "LBLDept";
            LBLDept.Size = new Size(152, 32);
            LBLDept.TabIndex = 0;
            LBLDept.Text = "Department";
            // 
            // txtDept
            // 
            txtDept.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDept.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDept.Location = new Point(1114, 200);
            txtDept.Margin = new Padding(4);
            txtDept.Multiline = true;
            txtDept.Name = "txtDept";
            txtDept.Size = new Size(393, 45);
            txtDept.TabIndex = 32;
            // 
            // LBLDate
            // 
            LBLDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LBLDate.AutoSize = true;
            LBLDate.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLDate.ForeColor = Color.Gray;
            LBLDate.Location = new Point(86, 324);
            LBLDate.Margin = new Padding(4, 0, 4, 0);
            LBLDate.Name = "LBLDate";
            LBLDate.Size = new Size(239, 32);
            LBLDate.TabIndex = 0;
            LBLDate.Text = "Date (MM-DD-YYY)";
            // 
            // LBLDay
            // 
            LBLDay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LBLDay.AutoSize = true;
            LBLDay.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLDay.ForeColor = Color.Gray;
            LBLDay.Location = new Point(578, 324);
            LBLDay.Margin = new Padding(4, 0, 4, 0);
            LBLDay.Name = "LBLDay";
            LBLDay.Size = new Size(58, 32);
            LBLDay.TabIndex = 0;
            LBLDay.Text = "Day";
            // 
            // LBLroomNumber
            // 
            LBLroomNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LBLroomNumber.AutoSize = true;
            LBLroomNumber.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLroomNumber.ForeColor = Color.Gray;
            LBLroomNumber.Location = new Point(1109, 324);
            LBLroomNumber.Margin = new Padding(4, 0, 4, 0);
            LBLroomNumber.Name = "LBLroomNumber";
            LBLroomNumber.Size = new Size(182, 32);
            LBLroomNumber.TabIndex = 0;
            LBLroomNumber.Text = "Room Number";
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRoomNumber.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoomNumber.Location = new Point(1114, 366);
            txtRoomNumber.Margin = new Padding(4);
            txtRoomNumber.Multiline = true;
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new Size(393, 45);
            txtRoomNumber.TabIndex = 35;
            // 
            // LBLcourseName
            // 
            LBLcourseName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LBLcourseName.AutoSize = true;
            LBLcourseName.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLcourseName.ForeColor = Color.Gray;
            LBLcourseName.Location = new Point(86, 466);
            LBLcourseName.Margin = new Padding(4, 0, 4, 0);
            LBLcourseName.Name = "LBLcourseName";
            LBLcourseName.Size = new Size(167, 32);
            LBLcourseName.TabIndex = 0;
            LBLcourseName.Text = "Course Name";
            // 
            // txtCourseName
            // 
            txtCourseName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCourseName.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCourseName.Location = new Point(91, 509);
            txtCourseName.Margin = new Padding(4);
            txtCourseName.Multiline = true;
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(920, 45);
            txtCourseName.TabIndex = 36;
            // 
            // LBLcourseCode
            // 
            LBLcourseCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LBLcourseCode.AutoSize = true;
            LBLcourseCode.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLcourseCode.ForeColor = Color.Gray;
            LBLcourseCode.Location = new Point(1109, 466);
            LBLcourseCode.Margin = new Padding(4, 0, 4, 0);
            LBLcourseCode.Name = "LBLcourseCode";
            LBLcourseCode.Size = new Size(158, 32);
            LBLcourseCode.TabIndex = 0;
            LBLcourseCode.Text = "Course Code";
            // 
            // txtCourseCode
            // 
            txtCourseCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCourseCode.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCourseCode.Location = new Point(1114, 509);
            txtCourseCode.Margin = new Padding(4);
            txtCourseCode.Multiline = true;
            txtCourseCode.Name = "txtCourseCode";
            txtCourseCode.Size = new Size(393, 45);
            txtCourseCode.TabIndex = 37;
            txtCourseCode.TextChanged += textBox1_TextChanged;
            // 
            // LBLstartTime
            // 
            LBLstartTime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LBLstartTime.AutoSize = true;
            LBLstartTime.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLstartTime.ForeColor = Color.Gray;
            LBLstartTime.Location = new Point(617, 630);
            LBLstartTime.Margin = new Padding(4, 0, 4, 0);
            LBLstartTime.Name = "LBLstartTime";
            LBLstartTime.Size = new Size(222, 32);
            LBLstartTime.TabIndex = 0;
            LBLstartTime.Text = "Lecture Start Time";
            // 
            // txtStartTime
            // 
            txtStartTime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStartTime.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStartTime.Location = new Point(622, 672);
            txtStartTime.Margin = new Padding(4);
            txtStartTime.Multiline = true;
            txtStartTime.Name = "txtStartTime";
            txtStartTime.Size = new Size(382, 45);
            txtStartTime.TabIndex = 39;
            // 
            // LBLendTime
            // 
            LBLendTime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LBLendTime.AutoSize = true;
            LBLendTime.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLendTime.ForeColor = Color.Gray;
            LBLendTime.Location = new Point(1114, 630);
            LBLendTime.Margin = new Padding(4, 0, 4, 0);
            LBLendTime.Name = "LBLendTime";
            LBLendTime.Size = new Size(211, 32);
            LBLendTime.TabIndex = 0;
            LBLendTime.Text = "Lecture End Time";
            // 
            // txtEndTime
            // 
            txtEndTime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEndTime.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEndTime.Location = new Point(1114, 672);
            txtEndTime.Margin = new Padding(4);
            txtEndTime.Multiline = true;
            txtEndTime.Name = "txtEndTime";
            txtEndTime.Size = new Size(393, 45);
            txtEndTime.TabIndex = 40;
            // 
            // BtnClear
            // 
            BtnClear.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnClear.BackColor = Color.White;
            BtnClear.FlatStyle = FlatStyle.Flat;
            BtnClear.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnClear.ForeColor = Color.FromArgb(116, 86, 174);
            BtnClear.Location = new Point(1249, 758);
            BtnClear.Margin = new Padding(4);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(258, 72);
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
            btnSubmit.Location = new Point(931, 758);
            btnSubmit.Margin = new Padding(4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(258, 72);
            btnSubmit.TabIndex = 41;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // cmbTeacherName
            // 
            cmbTeacherName.FormattingEnabled = true;
            cmbTeacherName.Location = new Point(91, 200);
            cmbTeacherName.Name = "cmbTeacherName";
            cmbTeacherName.Size = new Size(384, 33);
            cmbTeacherName.TabIndex = 30;
            cmbTeacherName.SelectedIndexChanged += cmbTeacherName_SelectedIndexChanged;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(91, 368);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(384, 31);
            dtpDate.TabIndex = 42;
            // 
            // LblCross
            // 
            LblCross.AutoSize = true;
            LblCross.BackColor = Color.Red;
            LblCross.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblCross.Location = new Point(1563, 20);
            LblCross.Margin = new Padding(4, 0, 4, 0);
            LblCross.Name = "LblCross";
            LblCross.Size = new Size(28, 32);
            LblCross.TabIndex = 0;
            LblCross.Text = "X";
            LblCross.Click += LblCross_Click;
            // 
            // cmbDay
            // 
            cmbDay.FormattingEnabled = true;
            cmbDay.Items.AddRange(new object[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" });
            cmbDay.Location = new Point(588, 370);
            cmbDay.Name = "cmbDay";
            cmbDay.Size = new Size(423, 33);
            cmbDay.TabIndex = 30;
            cmbDay.SelectedIndexChanged += cmbTeacherName_SelectedIndexChanged;
            // 
            // btnchecktimetbl
            // 
            btnchecktimetbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnchecktimetbl.AutoSize = true;
            btnchecktimetbl.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnchecktimetbl.ForeColor = Color.FromArgb(116, 86, 174);
            btnchecktimetbl.Location = new Point(1233, 858);
            btnchecktimetbl.Margin = new Padding(4, 0, 4, 0);
            btnchecktimetbl.Name = "btnchecktimetbl";
            btnchecktimetbl.Size = new Size(72, 30);
            btnchecktimetbl.TabIndex = 43;
            btnchecktimetbl.Text = "Check";
            btnchecktimetbl.Click += btnchecktimetbl_Click;
            // 
            // lbltimetbl
            // 
            lbltimetbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbltimetbl.AutoSize = true;
            lbltimetbl.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltimetbl.Location = new Point(1064, 858);
            lbltimetbl.Margin = new Padding(4, 0, 4, 0);
            lbltimetbl.Name = "lbltimetbl";
            lbltimetbl.Size = new Size(177, 30);
            lbltimetbl.TabIndex = 0;
            lbltimetbl.Text = "Check TimeTable?";
            // 
            // lblLecture
            // 
            lblLecture.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblLecture.AutoSize = true;
            lblLecture.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLecture.ForeColor = Color.Gray;
            lblLecture.Location = new Point(91, 630);
            lblLecture.Margin = new Padding(4, 0, 4, 0);
            lblLecture.Name = "lblLecture";
            lblLecture.Size = new Size(98, 32);
            lblLecture.TabIndex = 0;
            lblLecture.Text = "Lecture";
            // 
            // cmbLecture
            // 
            cmbLecture.FormattingEnabled = true;
            cmbLecture.Items.AddRange(new object[] { "1st", "2nd", "3rd", "4th", "5th", "6th" });
            cmbLecture.Location = new Point(91, 672);
            cmbLecture.Name = "cmbLecture";
            cmbLecture.Size = new Size(423, 33);
            cmbLecture.TabIndex = 38;
            cmbLecture.SelectedIndexChanged += cmbTeacherName_SelectedIndexChanged;
            // 
            // Timetable
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1604, 921);
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
            Margin = new Padding(4);
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
    }
}