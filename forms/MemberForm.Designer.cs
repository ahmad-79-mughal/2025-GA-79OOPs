namespace LibraryManagementSystem
{
    partial class MemberForm
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
            this.lblMemberID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.SuspendLayout();

            this.lblHeader.Text = "Member Management";
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblHeader.Location = new System.Drawing.Point(20, 15);
            this.lblHeader.Size = new System.Drawing.Size(300, 30);

            int y = 60;
            System.Windows.Forms.Label[] lbls = { lblMemberID, lblName, lblEmail, lblPhone, lblAddress };
            string[] ltxts = { "Member ID:", "Full Name:", "Email:", "Phone:", "Address:" };
            for (int i = 0; i < lbls.Length; i++)
            {
                lbls[i].Text = ltxts[i];
                lbls[i].Location = new System.Drawing.Point(20, y);
                lbls[i].Size = new System.Drawing.Size(90, 25);
                lbls[i].Font = new System.Drawing.Font("Segoe UI", 9F);
                y += 35;
            }

            this.txtMemberID.Location = new System.Drawing.Point(120, 60); this.txtMemberID.Size = new System.Drawing.Size(150, 26); this.txtMemberID.ReadOnly = true; this.txtMemberID.BackColor = System.Drawing.Color.LightGray;
            this.txtName.Location = new System.Drawing.Point(120, 95); this.txtName.Size = new System.Drawing.Size(300, 26);
            this.txtEmail.Location = new System.Drawing.Point(120, 130); this.txtEmail.Size = new System.Drawing.Size(300, 26);
            this.txtPhone.Location = new System.Drawing.Point(120, 165); this.txtPhone.Size = new System.Drawing.Size(200, 26);
            this.txtAddress.Location = new System.Drawing.Point(120, 200); this.txtAddress.Size = new System.Drawing.Size(350, 26);

            this.btnAdd.Text = "Add"; this.btnAdd.Location = new System.Drawing.Point(20, 250); this.btnAdd.Size = new System.Drawing.Size(90, 32); this.btnAdd.BackColor = System.Drawing.Color.SteelBlue; this.btnAdd.ForeColor = System.Drawing.Color.White; this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnUpdate.Text = "Update"; this.btnUpdate.Location = new System.Drawing.Point(120, 250); this.btnUpdate.Size = new System.Drawing.Size(90, 32); this.btnUpdate.BackColor = System.Drawing.Color.SeaGreen; this.btnUpdate.ForeColor = System.Drawing.Color.White; this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnDelete.Text = "Delete"; this.btnDelete.Location = new System.Drawing.Point(220, 250); this.btnDelete.Size = new System.Drawing.Size(90, 32); this.btnDelete.BackColor = System.Drawing.Color.Crimson; this.btnDelete.ForeColor = System.Drawing.Color.White; this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnClear.Text = "Clear"; this.btnClear.Location = new System.Drawing.Point(320, 250); this.btnClear.Size = new System.Drawing.Size(90, 32); this.btnClear.BackColor = System.Drawing.Color.Gray; this.btnClear.ForeColor = System.Drawing.Color.White; this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.dgvMembers.Location = new System.Drawing.Point(20, 300); this.dgvMembers.Size = new System.Drawing.Size(840, 270);
            this.dgvMembers.AllowUserToAddRows = false; this.dgvMembers.ReadOnly = true;
            this.dgvMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMembers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMembers_CellClick);

            this.ClientSize = new System.Drawing.Size(880, 590);
            this.Controls.Add(this.lblHeader);
            foreach (var l in lbls) this.Controls.Add(l);
            this.Controls.Add(this.txtMemberID); this.Controls.Add(this.txtName); this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone); this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnAdd); this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete); this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvMembers);
            this.Text = "Member Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblHeader, lblMemberID, lblName, lblEmail, lblPhone, lblAddress;
        private System.Windows.Forms.TextBox txtMemberID, txtName, txtEmail, txtPhone, txtAddress;
        private System.Windows.Forms.Button btnAdd, btnUpdate, btnDelete, btnClear;
        private System.Windows.Forms.DataGridView dgvMembers;
    }
}