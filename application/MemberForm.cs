using LibraryManagementSystem.Helper;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LibraryManagementSystem
{
    public partial class MemberForm : Form
    {
        public MemberForm()
        {
            InitializeComponent();
            LoadMembers();
        }

        private void LoadMembers()
        {
            try
            {
                using (var con = DBConnection.GetConnection())
                {
                    con.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM Members", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvMembers.DataSource = dt;
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text)) { MessageBox.Show("Name is required!"); return; }

            try
            {
                using (var con = DBConnection.GetConnection())
                {
                    con.Open();
                    string query = "INSERT INTO Members (FullName, Email, Phone, Address) VALUES (@n, @e, @p, @a)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@n", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@e", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@p", txtPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@a", txtAddress.Text.Trim());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields(); LoadMembers();
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMemberID.Text == "") { MessageBox.Show("Select a member!"); return; }

            try
            {
                using (var con = DBConnection.GetConnection())
                {
                    con.Open();
                    string query = "UPDATE Members SET FullName=@n, Email=@e, Phone=@p, Address=@a WHERE MemberID=@id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@n", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@e", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@p", txtPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@a", txtAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", int.Parse(txtMemberID.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields(); LoadMembers();
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMemberID.Text == "") { MessageBox.Show("Select a member!"); return; }

            if (MessageBox.Show("Delete this member?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (var con = DBConnection.GetConnection())
                    {
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM Members WHERE MemberID=@id", con);
                        cmd.Parameters.AddWithValue("@id", int.Parse(txtMemberID.Text));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Member deleted!", "Success");
                        ClearFields(); LoadMembers();
                    }
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearFields();

        private void ClearFields()
        {
            txtMemberID.Clear(); txtName.Clear(); txtEmail.Clear();
            txtPhone.Clear(); txtAddress.Clear();
        }

        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMembers.Rows[e.RowIndex];
                txtMemberID.Text = row.Cells["MemberID"].Value.ToString();
                txtName.Text = row.Cells["FullName"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
            }
        }
    }
}