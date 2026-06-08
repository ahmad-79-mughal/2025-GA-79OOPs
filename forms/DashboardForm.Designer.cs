namespace LibraryManagementSystem
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.btnIssueReturn = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblWelcome
            this.lblWelcome.Text = "Welcome to Library Management System";
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblWelcome.Location = new System.Drawing.Point(60, 30);
            this.lblWelcome.Size = new System.Drawing.Size(560, 35);
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // btnBooks
            this.btnBooks.Text = "📚  Manage Books";
            this.btnBooks.Location = new System.Drawing.Point(220, 110);
            this.btnBooks.Size = new System.Drawing.Size(200, 55);
            this.btnBooks.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBooks.ForeColor = System.Drawing.Color.White;
            this.btnBooks.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);

            // btnMembers
            this.btnMembers.Text = "👥  Manage Members";
            this.btnMembers.Location = new System.Drawing.Point(220, 185);
            this.btnMembers.Size = new System.Drawing.Size(200, 55);
            this.btnMembers.BackColor = System.Drawing.Color.SeaGreen;
            this.btnMembers.ForeColor = System.Drawing.Color.White;
            this.btnMembers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);

            // btnIssueReturn
            this.btnIssueReturn.Text = "📖  Issue / Return Book";
            this.btnIssueReturn.Location = new System.Drawing.Point(220, 260);
            this.btnIssueReturn.Size = new System.Drawing.Size(200, 55);
            this.btnIssueReturn.BackColor = System.Drawing.Color.DarkOrange;
            this.btnIssueReturn.ForeColor = System.Drawing.Color.White;
            this.btnIssueReturn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnIssueReturn.Click += new System.EventHandler(this.btnIssueReturn_Click);

            // btnLogout
            this.btnLogout.Text = "🚪  Logout";
            this.btnLogout.Location = new System.Drawing.Point(220, 335);
            this.btnLogout.Size = new System.Drawing.Size(200, 50);
            this.btnLogout.BackColor = System.Drawing.Color.Crimson;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // DashboardForm
            this.ClientSize = new System.Drawing.Size(640, 430);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnBooks);
            this.Controls.Add(this.btnMembers);
            this.Controls.Add(this.btnIssueReturn);
            this.Controls.Add(this.btnLogout);
            this.Text = "Dashboard - Library Management System";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button btnIssueReturn;
        private System.Windows.Forms.Button btnLogout;
    }
}