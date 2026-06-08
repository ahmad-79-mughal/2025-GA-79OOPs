using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using LibraryManagementSystem.Helper;

namespace LibraryManagementSystem
{
    public partial class IssueReturnForm : Form
    {
        public IssueReturnForm()
        {
            InitializeComponent();
            LoadIssuedBooks();
            LoadComboData();
        }

        private void LoadComboData()
        {
            try
            {
                using (var con = DBConnection.GetConnection())
                {
                    con.Open();
                    MySqlDataAdapter daB = new MySqlDataAdapter("SELECT BookID, Title FROM Books WHERE Available > 0", con);
                    DataTable dtB = new DataTable();
                    daB.Fill(dtB);
                    cmbBook.DataSource = dtB;
                    cmbBook.DisplayMember = "Title";
                    cmbBook.ValueMember = "BookID";

                    MySqlDataAdapter daM = new MySqlDataAdapter("SELECT MemberID, FullName FROM Members", con);
                    DataTable dtM = new DataTable();
                    daM.Fill(dtM);
                    cmbMember.DataSource = dtM;
                    cmbMember.DisplayMember = "FullName";
                    cmbMember.ValueMember = "MemberID";
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void LoadIssuedBooks()
        {
            try
            {
                using (var con = DBConnection.GetConnection())
                {
                    con.Open();
                    string query = @"SELECT ib.IssueID, b.Title AS Book, m.FullName AS Member, 
                                     ib.IssueDate, ib.ReturnDate, ib.Status 
                                     FROM IssuedBooks ib
                                     JOIN Books b ON ib.BookID = b.BookID
                                     JOIN Members m ON ib.MemberID = m.MemberID
                                     ORDER BY ib.IssueID DESC";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvIssued.DataSource = dt;
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (cmbBook.SelectedValue == null || cmbMember.SelectedValue == null)
            {
                MessageBox.Show("Select Book and Member!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var con = DBConnection.GetConnection())
                {
                    con.Open();
                    // Insert issued record
                    string q1 = "INSERT INTO IssuedBooks (BookID, MemberID, IssueDate, Status) VALUES (@b, @m, @d, 'Issued')";
                    MySqlCommand cmd = new MySqlCommand(q1, con);
                    cmd.Parameters.AddWithValue("@b", cmbBook.SelectedValue);
                    cmd.Parameters.AddWithValue("@m", cmbMember.SelectedValue);
                    cmd.Parameters.AddWithValue("@d", dtpIssueDate.Value.Date);
                    cmd.ExecuteNonQuery();

                    // Decrease available count
                    string q2 = "UPDATE Books SET Available = Available - 1 WHERE BookID = @b";
                    MySqlCommand cmd2 = new MySqlCommand(q2, con);
                    cmd2.Parameters.AddWithValue("@b", cmbBook.SelectedValue);
                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("Book issued successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadIssuedBooks();
                    LoadComboData();
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (dgvIssued.SelectedRows.Count == 0) { MessageBox.Show("Select an issued record to return!"); return; }

            string status = dgvIssued.SelectedRows[0].Cells["Status"].Value.ToString();
            if (status == "Returned") { MessageBox.Show("This book is already returned!"); return; }

            int issueID = Convert.ToInt32(dgvIssued.SelectedRows[0].Cells["IssueID"].Value);

            try
            {
                using (var con = DBConnection.GetConnection())
                {
                    con.Open();
                    // Get BookID
                    MySqlCommand getBook = new MySqlCommand("SELECT BookID FROM IssuedBooks WHERE IssueID=@id", con);
                    getBook.Parameters.AddWithValue("@id", issueID);
                    int bookID = Convert.ToInt32(getBook.ExecuteScalar());

                    // Update return
                    string q1 = "UPDATE IssuedBooks SET ReturnDate=@d, Status='Returned' WHERE IssueID=@id";
                    MySqlCommand cmd = new MySqlCommand(q1, con);
                    cmd.Parameters.AddWithValue("@d", DateTime.Now.Date);
                    cmd.Parameters.AddWithValue("@id", issueID);
                    cmd.ExecuteNonQuery();

                    // Increase available
                    string q2 = "UPDATE Books SET Available = Available + 1 WHERE BookID = @b";
                    MySqlCommand cmd2 = new MySqlCommand(q2, con);
                    cmd2.Parameters.AddWithValue("@b", bookID);
                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("Book returned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadIssuedBooks();
                    LoadComboData();
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }
    }
}