using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibraryApp1
{
    public partial class ReturnBook : Form
    {
        // Use this connection string everywhere
        private string connectionString = @"Data Source=D:\assignments\C# Assignment\MyLibrary.db;Version=3;";

        public ReturnBook()
        {
            InitializeComponent();
            this.Load += new EventHandler(ReturnBook_Load);
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            LoadIssuedBooks();
        }

        private void LoadIssuedBooks()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = @"
                    SELECT 
                        ib.IssueID, 
                        b.Title AS BookTitle, 
                        br.Name AS BorrowerName, 
                        ib.IssueDate, 
                        ib.DueDate
                    FROM 
                        IssuedBooks ib
                    JOIN Books b ON ib.BookID = b.BookID
                    JOIN Borrowers br ON ib.BorrowerID = br.BorrowerID
                    WHERE 
                        ib.Returned = 0";

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvIssuedBooks.DataSource = table;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (dgvIssuedBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to return.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int issueId = Convert.ToInt32(dgvIssuedBooks.SelectedRows[0].Cells["IssueID"].Value);

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Get BookID from selected issue record
                string getBookIdQuery = "SELECT BookID FROM IssuedBooks WHERE IssueID = @IssueID";
                int bookId = -1;

                using (SQLiteCommand cmd = new SQLiteCommand(getBookIdQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@IssueID", issueId);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                        bookId = Convert.ToInt32(result);
                }

                if (bookId == -1)
                {
                    MessageBox.Show("Error retrieving BookID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Mark book as returned
                string updateIssueQuery = "UPDATE IssuedBooks SET Returned = 1 WHERE IssueID = @IssueID";
                using (SQLiteCommand cmd = new SQLiteCommand(updateIssueQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@IssueID", issueId);
                    cmd.ExecuteNonQuery();
                }

                // Increment available copies
                string incrementCopiesQuery = "UPDATE Books SET AvailableCopies = AvailableCopies + 1 WHERE BookID = @BookID";
                using (SQLiteCommand cmd = new SQLiteCommand(incrementCopiesQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@BookID", bookId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Book returned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Refresh the issued books list
            LoadIssuedBooks();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
