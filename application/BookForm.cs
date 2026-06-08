using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using LibraryManagementSystem.Helper;

namespace LibraryManagementSystem
{
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
            LoadBooks();
        }

        private void LoadBooks()
        {
            try
            {
                using (var con = DBConnection.GetConnection())
                {
                    con.Open();
                    string query = "SELECT BookID, Title, Author, ISBN, Quantity, Available FROM Books";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvBooks.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                MessageBox.Show("Book Title is required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var con = DBConnection.GetConnection())
                {
                    con.Open();
                    string query = "INSERT INTO Books (Title, Author, ISBN, Quantity, Available) VALUES (@t, @a, @i, @q, @q)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@t", txtTitle.Text.Trim());
                    cmd.Parameters.AddWithValue("@a", txtAuthor.Text.Trim());
                    cmd.Parameters.AddWithValue("@i", txtISBN.Text.Trim());
                    cmd.Parameters.AddWithValue("@q", (int)numQuantity.Value);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadBooks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtBookID.Text == "") { MessageBox.Show("Select a book to update!"); return; }

            try
            {
                using (var con = DBConnection.GetConnection())
                {
                    con.Open();
                    string query = "UPDATE Books SET Title=@t, Author=@a, ISBN=@i, Quantity=@q WHERE BookID=@id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@t", txtTitle.Text.Trim());
                    cmd.Parameters.AddWithValue("@a", txtAuthor.Text.Trim());
                    cmd.Parameters.AddWithValue("@i", txtISBN.Text.Trim());
                    cmd.Parameters.AddWithValue("@q", (int)numQuantity.Value);
                    cmd.Parameters.AddWithValue("@id", int.Parse(txtBookID.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadBooks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtBookID.Text == "") { MessageBox.Show("Select a book to delete!"); return; }

            if (MessageBox.Show("Delete this book?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (var con = DBConnection.GetConnection())
                    {
                        con.Open();
                        string query = "DELETE FROM Books WHERE BookID=@id";
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@id", int.Parse(txtBookID.Text));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Book deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        LoadBooks();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearFields();

        private void ClearFields()
        {
            txtBookID.Clear(); txtTitle.Clear(); txtAuthor.Clear(); txtISBN.Clear();
            numQuantity.Value = 1;
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBooks.Rows[e.RowIndex];
                txtBookID.Text = row.Cells["BookID"].Value.ToString();
                txtTitle.Text = row.Cells["Title"].Value.ToString();
                txtAuthor.Text = row.Cells["Author"].Value.ToString();
                txtISBN.Text = row.Cells["ISBN"].Value.ToString();
                numQuantity.Value = Convert.ToInt32(row.Cells["Quantity"].Value);
            }
        }
    }
}