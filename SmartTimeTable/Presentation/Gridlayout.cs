using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SmartTimeTable.Data;
using FormsTimer = System.Windows.Forms.Timer;

namespace SmartTimeTable.Presentation
{
    public partial class Gridlayout : Form
    {
        private FormsTimer _checkTimer;

        private static readonly Regex EndTimeRx =
      new Regex(@"EndTime:\s*(\d{1,2}):(\d{2})", RegexOptions.Compiled);
        public Gridlayout()
        {
            InitializeComponent();
        }

        private void Gridlayout_Load(object sender, EventArgs e)
        {
            DataTable dt = Connection.GetTimeTableGrid();

            dgvTimeTable.DataSource = dt;
            dgvTimeTable.AutoGenerateColumns = true;
            dgvTimeTable.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvTimeTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            dgvTimeTable.Columns["SR#"].HeaderText = "Day of Week";
            dgvTimeTable.Columns["1st"].HeaderText = "1st Lecture";
            dgvTimeTable.Columns["2nd"].HeaderText = "2nd Lecture";
            dgvTimeTable.Columns["3rd"].HeaderText = "3rd Lecture";
            dgvTimeTable.Columns["4th"].HeaderText = "4th Lecture";
            dgvTimeTable.Columns["5th"].HeaderText = "5th Lecture";
            dgvTimeTable.Columns["6th"].HeaderText = "6th Lecture";
            dgvTimeTable.Columns["SR#"].ReadOnly = true;

            dgvTimeTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTimeTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTimeTable.DefaultCellStyle.WrapMode = DataGridViewTriState.True; dgvTimeTable.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9f, FontStyle.Bold);

            // 2) Set up the timer to fire every second
            _checkTimer = new FormsTimer
            {
                Interval = 1000,
                Enabled = true
            };
            _checkTimer.Tick += CheckTimer_Tick;
        }

        private void CheckTimer_Tick(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            int curH = now.Hour % 12;     // convert 24h to 12h range
            if (curH == 0) curH = 12;
            int curM = now.Minute;

            foreach (DataGridViewRow row in dgvTimeTable.Rows)
            {
                foreach (string lecCol in new[] { "1st", "2nd", "3rd", "4th", "5th", "6th" })
                {
                    var value = row.Cells[lecCol].Value as string;
                    if (string.IsNullOrEmpty(value))
                        continue;

                    var m = EndTimeRx.Match(value);
                    if (!m.Success)
                        continue;

                    // parse the two capture groups into ints
                    int h = int.Parse(m.Groups[1].Value);
                    int mnt = int.Parse(m.Groups[2].Value);

                    if (h == curH && mnt == curM)
                    {
                        row.Cells[lecCol].Style.BackColor = Color.Yellow;
                        Console.Beep(800, 300);
                        return;
                    }
                }
            }
        }

        private void LblCross_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
