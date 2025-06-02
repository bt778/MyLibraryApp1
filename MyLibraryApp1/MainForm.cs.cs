using LibraryManagementSystem;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AddReturnedColumnIfMissing(); // Ensure 'Returned' column exists
            LoadBooks();
            LoadBorrowers();
        }

        private void AddReturnedColumnIfMissing()
        {
            string connectionString = @"Data Source=D:\assignments\C# Assignment\MyLibrary.db;Version=3;";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string checkColumnQuery = "PRAGMA table_info(IssuedBooks)";
                using (SQLiteCommand cmd = new SQLiteCommand(checkColumnQuery, conn))
                {
                    bool columnExists = false;
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["name"].ToString().Equals("Returned", StringComparison.OrdinalIgnoreCase))
                            {
                                columnExists = true;
                                break;
                            }
                        }
                    }

                    if (!columnExists)
                    {
                        string alterQuery = "ALTER TABLE IssuedBooks ADD COLUMN Returned INTEGER NOT NULL DEFAULT 0";
                        using (SQLiteCommand alterCmd = new SQLiteCommand(alterQuery, conn))
                        {
                            alterCmd.ExecuteNonQuery();
                            MessageBox.Show("Returned column added to IssuedBooks table.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                conn.Close();
            }
        }

        private void LoadBooks()
        {
            try
            {
                string connectionString = @"Data Source=D:\assignments\C# Assignment\MyLibrary.db;Version=3;";

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    string selectQuery = "SELECT BookID, Title, Author, Year, AvailableCopies FROM Books";

                    using (SQLiteCommand cmd = new SQLiteCommand(selectQuery, conn))
                    {
                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvBooks.DataSource = dt;
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm addForm = new AddBookForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadBooks();
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int bookId = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells["BookID"].Value);

            DialogResult result = MessageBox.Show("Are you sure you want to delete this book?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string connectionString = @"Data Source=D:\assignments\C# Assignment\MyLibrary.db;Version=3;";
                    using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                    {
                        conn.Open();

                        string deleteQuery = "DELETE FROM Books WHERE BookID = @BookID";

                        using (SQLiteCommand cmd = new SQLiteCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@BookID", bookId);
                            cmd.ExecuteNonQuery();
                        }

                        conn.Close();
                    }

                    MessageBox.Show("Book deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBooks();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting book: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dgvBooks.SelectedRows[0];

            int bookId = Convert.ToInt32(selectedRow.Cells["BookID"].Value);
            string title = selectedRow.Cells["Title"].Value.ToString();
            string author = selectedRow.Cells["Author"].Value.ToString();
            int year = Convert.ToInt32(selectedRow.Cells["Year"].Value);
            int available = Convert.ToInt32(selectedRow.Cells["AvailableCopies"].Value);

            EditBookForm editForm = new EditBookForm(bookId, title, author, year, available);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadBooks();
            }
        }

        private void LoadBorrowers()
        {
            try
            {
                string connectionString = @"Data Source=D:\assignments\C# Assignment\MyLibrary.db;Version=3;";
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    string selectQuery = "SELECT BorrowerID, Name, Phone, Email FROM Borrowers";

                    using (SQLiteCommand cmd = new SQLiteCommand(selectQuery, conn))
                    {
                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvBorrowers.DataSource = dt;
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading borrowers: " + ex.Message);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BorrowerForm borrowerForm = new BorrowerForm();
            if (borrowerForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string connectionString = @"Data Source=D:\assignments\C# Assignment\MyLibrary.db;Version=3;";
                    using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                    {
                        conn.Open();

                        string insertQuery = "INSERT INTO Borrowers (Name, Email, Phone) VALUES (@Name, @Email, @Phone)";

                        using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@Name", borrowerForm.BorrowerName);
                            cmd.Parameters.AddWithValue("@Email", borrowerForm.BorrowerEmail);
                            cmd.Parameters.AddWithValue("@Phone", borrowerForm.BorrowerPhone);

                            cmd.ExecuteNonQuery();
                        }

                        conn.Close();
                    }

                    MessageBox.Show("Borrower added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBorrowers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding borrower: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditBorrowers_Click(object sender, EventArgs e)
        {
            if (dgvBorrowers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a borrower to edit.");
                return;
            }

            DataGridViewRow selectedRow = dgvBorrowers.SelectedRows[0];
            int borrowerId = Convert.ToInt32(selectedRow.Cells["BorrowerID"].Value);
            string name = selectedRow.Cells["Name"].Value.ToString();
            string email = selectedRow.Cells["Email"].Value.ToString();
            string phone = selectedRow.Cells["Phone"].Value.ToString();

            BorrowerForm borrowerForm = new BorrowerForm(borrowerId, name, email, phone);
            if (borrowerForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string connectionString = @"Data Source=D:\assignments\C# Assignment\MyLibrary.db;Version=3;";
                    using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                    {
                        conn.Open();

                        string updateQuery = "UPDATE Borrowers SET Name = @Name, Email = @Email, Phone = @Phone WHERE BorrowerID = @BorrowerID";
                        using (SQLiteCommand cmd = new SQLiteCommand(updateQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@Name", borrowerForm.BorrowerName);
                            cmd.Parameters.AddWithValue("@Email", borrowerForm.BorrowerEmail);
                            cmd.Parameters.AddWithValue("@Phone", borrowerForm.BorrowerPhone);
                            cmd.Parameters.AddWithValue("@BorrowerID", borrowerId);

                            cmd.ExecuteNonQuery();
                        }

                        conn.Close();
                    }

                    MessageBox.Show("Borrower updated successfully.");
                    LoadBorrowers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating borrower: " + ex.Message);
                }
            }
        }

        private void btnDeleteBorrowers_Click(object sender, EventArgs e)
        {
            if (dgvBorrowers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a borrower to delete.");
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this borrower?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                DataGridViewRow selectedRow = dgvBorrowers.SelectedRows[0];
                int borrowerId = Convert.ToInt32(selectedRow.Cells["BorrowerID"].Value);

                try
                {
                    string connectionString = @"Data Source=D:\assignments\C# Assignment\MyLibrary.db;Version=3;";
                    using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                    {
                        conn.Open();

                        string deleteQuery = "DELETE FROM Borrowers WHERE BorrowerID = @BorrowerID";

                        using (SQLiteCommand cmd = new SQLiteCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@BorrowerID", borrowerId);
                            cmd.ExecuteNonQuery();
                        }

                        conn.Close();
                    }

                    MessageBox.Show("Borrower deleted successfully.");
                    LoadBorrowers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting borrower: " + ex.Message);
                }
            }
        }

        private void dgvBorrowers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            ReturnBook returnForm = new ReturnBook();
            returnForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IssueBookForm issuedBooksForm = new IssueBookForm();
            issuedBooksForm.ShowDialog();
        }
    }
}
