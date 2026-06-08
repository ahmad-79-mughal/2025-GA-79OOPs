namespace LibraryManagementSystem
{
    partial class BookForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();

            // lblTitle2
            this.lblTitle2.Text = "Book Management";
            this.lblTitle2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle2.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle2.Location = new System.Drawing.Point(20, 15);
            this.lblTitle2.Size = new System.Drawing.Size(300, 30);

            // Labels
            string[] labels = { "Book ID:", "Title:", "Author:", "ISBN:", "Quantity:" };
            System.Windows.Forms.Label[] lblArr = { lblBookID, lblTitle, lblAuthor, lblISBN, lblQty };
            int y = 60;
            for (int i = 0; i < labels.Length; i++)
            {
                lblArr[i].Text = labels[i];
                lblArr[i].Location = new System.Drawing.Point(20, y);
                lblArr[i].Size = new System.Drawing.Size(80, 25);
                lblArr[i].Font = new System.Drawing.Font("Segoe UI", 9F);
                y += 35;
            }

            // txtBookID
            this.txtBookID.Location = new System.Drawing.Point(110, 60);
            this.txtBookID.Size = new System.Drawing.Size(180, 26);
            this.txtBookID.ReadOnly = true;
            this.txtBookID.BackColor = System.Drawing.Color.LightGray;

            // txtTitle
            this.txtTitle.Location = new System.Drawing.Point(110, 95);
            this.txtTitle.Size = new System.Drawing.Size(300, 26);

            // txtAuthor
            this.txtAuthor.Location = new System.Drawing.Point(110, 130);
            this.txtAuthor.Size = new System.Drawing.Size(300, 26);

            // txtISBN
            this.txtISBN.Location = new System.Drawing.Point(110, 165);
            this.txtISBN.Size = new System.Drawing.Size(200, 26);

            // numQuantity
            this.numQuantity.Location = new System.Drawing.Point(110, 200);
            this.numQuantity.Size = new System.Drawing.Size(80, 26);
            this.numQuantity.Minimum = 1;
            this.numQuantity.Maximum = 1000;
            this.numQuantity.Value = 1;

            // Buttons
            this.btnAdd.Text = "Add Book"; this.btnAdd.Location = new System.Drawing.Point(20, 250);
            this.btnAdd.Size = new System.Drawing.Size(90, 32); this.btnAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.ForeColor = System.Drawing.Color.White; this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnUpdate.Text = "Update"; this.btnUpdate.Location = new System.Drawing.Point(120, 250);
            this.btnUpdate.Size = new System.Drawing.Size(90, 32); this.btnUpdate.BackColor = System.Drawing.Color.SeaGreen;
            this.btnUpdate.ForeColor = System.Drawing.Color.White; this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.Text = "Delete"; this.btnDelete.Location = new System.Drawing.Point(220, 250);
            this.btnDelete.Size = new System.Drawing.Size(90, 32); this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.ForeColor = System.Drawing.Color.White; this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnClear.Text = "Clear"; this.btnClear.Location = new System.Drawing.Point(320, 250);
            this.btnClear.Size = new System.Drawing.Size(90, 32); this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.ForeColor = System.Drawing.Color.White; this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // dgvBooks
            this.dgvBooks.Location = new System.Drawing.Point(20, 300);
            this.dgvBooks.Size = new System.Drawing.Size(840, 280);
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellClick);

            // BookForm
            this.ClientSize = new System.Drawing.Size(880, 600);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.lblBookID); this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblAuthor); this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.txtBookID); this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtAuthor); this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.btnAdd); this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete); this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvBooks);
            this.Text = "Book Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitle2, lblBookID, lblTitle, lblAuthor, lblISBN, lblQty;
        private System.Windows.Forms.TextBox txtBookID, txtTitle, txtAuthor, txtISBN;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Button btnAdd, btnUpdate, btnDelete, btnClear;
        private System.Windows.Forms.DataGridView dgvBooks;
    }
}