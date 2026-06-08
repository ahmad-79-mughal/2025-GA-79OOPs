namespace LibraryManagementSystem
{
    partial class IssueReturnForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblBook = new System.Windows.Forms.Label();
            this.lblMember = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbBook = new System.Windows.Forms.ComboBox();
            this.cmbMember = new System.Windows.Forms.ComboBox();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dgvIssued = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssued)).BeginInit();
            this.SuspendLayout();

            this.lblHeader.Text = "Issue / Return Books";
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblHeader.Location = new System.Drawing.Point(20, 15);
            this.lblHeader.Size = new System.Drawing.Size(300, 30);

            this.lblBook.Text = "Select Book:"; this.lblBook.Location = new System.Drawing.Point(20, 65); this.lblBook.Size = new System.Drawing.Size(100, 25); this.lblBook.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMember.Text = "Select Member:"; this.lblMember.Location = new System.Drawing.Point(20, 105); this.lblMember.Size = new System.Drawing.Size(100, 25); this.lblMember.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDate.Text = "Issue Date:"; this.lblDate.Location = new System.Drawing.Point(20, 145); this.lblDate.Size = new System.Drawing.Size(100, 25); this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.cmbBook.Location = new System.Drawing.Point(130, 63); this.cmbBook.Size = new System.Drawing.Size(350, 26); this.cmbBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMember.Location = new System.Drawing.Point(130, 103); this.cmbMember.Size = new System.Drawing.Size(350, 26); this.cmbMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dtpIssueDate.Location = new System.Drawing.Point(130, 143); this.dtpIssueDate.Size = new System.Drawing.Size(200, 26); this.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.btnIssue.Text = "Issue Book"; this.btnIssue.Location = new System.Drawing.Point(20, 195); this.btnIssue.Size = new System.Drawing.Size(120, 35);
            this.btnIssue.BackColor = System.Drawing.Color.SteelBlue; this.btnIssue.ForeColor = System.Drawing.Color.White;
            this.btnIssue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);

            this.btnReturn.Text = "Return Book"; this.btnReturn.Location = new System.Drawing.Point(160, 195); this.btnReturn.Size = new System.Drawing.Size(120, 35);
            this.btnReturn.BackColor = System.Drawing.Color.SeaGreen; this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);

            this.dgvIssued.Location = new System.Drawing.Point(20, 250); this.dgvIssued.Size = new System.Drawing.Size(840, 300);
            this.dgvIssued.AllowUserToAddRows = false; this.dgvIssued.ReadOnly = true;
            this.dgvIssued.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIssued.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.ClientSize = new System.Drawing.Size(880, 580);
            this.Controls.Add(this.lblHeader); this.Controls.Add(this.lblBook); this.Controls.Add(this.lblMember); this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cmbBook); this.Controls.Add(this.cmbMember); this.Controls.Add(this.dtpIssueDate);
            this.Controls.Add(this.btnIssue); this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dgvIssued);
            this.Text = "Issue / Return Books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssued)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblHeader, lblBook, lblMember, lblDate;
        private System.Windows.Forms.ComboBox cmbBook, cmbMember;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.Button btnIssue, btnReturn;
        private System.Windows.Forms.DataGridView dgvIssued;
    }
}