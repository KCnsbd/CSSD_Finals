namespace CSSD_Finals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnDash.BackColor = Color.FromArgb(15, 15, 30);

            frmTitle.Text = "DASHBOARD";
            this.mainPanel.Controls.Clear();
            frmDashboard FrmDashboard_vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.mainPanel.Controls.Add(FrmDashboard_vrb);
            FrmDashboard_vrb.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            btnHistory.BackColor = Color.FromArgb(15, 15, 30);

            frmTitle.Text = "HISTORY";
            this.mainPanel.Controls.Clear();
            frmHistory FrmHistory_vrb = new frmHistory() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmHistory_vrb.FormBorderStyle = FormBorderStyle.None;
            this.mainPanel.Controls.Add(FrmHistory_vrb);
            FrmHistory_vrb.Show();
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            btnCalendar.BackColor = Color.FromArgb(15, 15, 30);

            frmTitle.Text = "CALENDAR";
            this.mainPanel.Controls.Clear();
            frmCalendar FrmCalendar_vrb = new frmCalendar() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmCalendar_vrb.FormBorderStyle = FormBorderStyle.None;
            this.mainPanel.Controls.Add(FrmCalendar_vrb);
            FrmCalendar_vrb.Show();
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            btnDash.BackColor = Color.FromArgb(15, 15, 30);

            frmTitle.Text = "DASHBOARD";
            this.mainPanel.Controls.Clear();
            frmDashboard FrmDashboard_vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.mainPanel.Controls.Add(FrmDashboard_vrb);
            FrmDashboard_vrb.Show();
        }

        private void btnDash_Leave(object sender, EventArgs e)
        {
            btnDash.BackColor = Color.FromArgb(31, 40, 80);
        }

        private void btnHistory_Leave(object sender, EventArgs e)
        {
            btnHistory.BackColor = Color.FromArgb(31, 40, 80);
        }

        private void btnCalendar_Leave(object sender, EventArgs e)
        {
            btnCalendar.BackColor = Color.FromArgb(31, 40, 80);
        }

    }
}
