namespace SmartTimeTable.Presentation
{
    partial class Gridlayout
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
            LblCross = new Label();
            dgvTimeTable = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTimeTable).BeginInit();
            SuspendLayout();
            // 
            // LblCross
            // 
            LblCross.AutoSize = true;
            LblCross.BackColor = Color.Red;
            LblCross.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblCross.Location = new Point(1078, 5);
            LblCross.Name = "LblCross";
            LblCross.Size = new Size(19, 21);
            LblCross.TabIndex = 2;
            LblCross.Text = "X";
            LblCross.Click += LblCross_Click;
            // 
            // dgvTimeTable
            // 
            dgvTimeTable.BackgroundColor = Color.WhiteSmoke;
            dgvTimeTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTimeTable.Dock = DockStyle.Fill;
            dgvTimeTable.GridColor = Color.DimGray;
            dgvTimeTable.Location = new Point(0, 0);
            dgvTimeTable.Margin = new Padding(2, 2, 2, 2);
            dgvTimeTable.Name = "dgvTimeTable";
            dgvTimeTable.RowHeadersWidth = 62;
            dgvTimeTable.Size = new Size(1107, 586);
            dgvTimeTable.TabIndex = 3;
            dgvTimeTable.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(1079, 5);
            label1.Name = "label1";
            label1.Size = new Size(19, 21);
            label1.TabIndex = 14;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // Gridlayout
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 586);
            Controls.Add(label1);
            Controls.Add(dgvTimeTable);
            Controls.Add(LblCross);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Gridlayout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gridlayout";
            Load += Gridlayout_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTimeTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LblCross;
        private DataGridView dgvTimeTable;
        private Label label1;
    }
}