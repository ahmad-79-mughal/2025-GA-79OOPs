namespace LibraryManagementSystem
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.Text = "Library Management System";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(60, 30);
            this.lblTitle.Size = new System.Drawing.Size(400, 35);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblUsername
            this.lblUsername.Text = "Username:";
            this.lblUsername.Location = new System.Drawing.Point(80, 110);
            this.lblUsername.Size = new System.Drawing.Size(100, 25);
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10F);

            // txtUsername
            this.txtUsername.Location = new System.Drawing.Point(190, 108);
            this.txtUsername.Size = new System.Drawing.Size(220, 26);
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);

            // lblPassword
            this.lblPassword.Text = "Password:";
            this.lblPassword.Location = new System.Drawing.Point(80, 160);
            this.lblPassword.Size = new System.Drawing.Size(100, 25);
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F);

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(190, 158);
            this.txtPassword.Size = new System.Drawing.Size(220, 26);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);

            // btnLogin
            this.btnLogin.Text = "Login";
            this.btnLogin.Location = new System.Drawing.Point(150, 220);
            this.btnLogin.Size = new System.Drawing.Size(100, 35);
            this.btnLogin.BackColor = System.Drawing.Color.DarkBlue;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // btnClear
            this.btnClear.Text = "Clear";
            this.btnClear.Location = new System.Drawing.Point(270, 220);
            this.btnClear.Size = new System.Drawing.Size(100, 35);
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // LoginForm
            this.ClientSize = new System.Drawing.Size(520, 310);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnClear);
            this.Text = "Login - Library Management System";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClear;
    }
}