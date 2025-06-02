using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class IssueBookForm : Form
    {
        public IssueBookForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(IssueBookForm_Load);
        }

        private void IssueBookForm_Load(object sender, EventArgs e)
        {
            LoadBorrowers();
            LoadBooks();
        }

        private void LoadBorrowers()
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(@"Data Source=D:\assignments\C# Assignment\MyLibrary.db;Version=3;"))
                {
                    con.Open();
                    string query = "SELECT BorrowerID, Name FROM Borrowers";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    cmbBorrower.DataSource = dt;
                    cmbBorrower.DisplayMember = "Name";
                    cmbBorrower.ValueMember = "BorrowerID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading borrowers: " + ex.Message);
            }
        }

        private void LoadBooks()
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(@"Data Source=D:\assignments\C# Assignment\MyLibrary.db;Version=3;"))
                {
                    con.Open();
                    string query = "SELECT BookID, Title FROM Books WHERE AvailableCopies > 0";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    cmbBook.DataSource = dt;
                    cmbBook.DisplayMember = "Title";
                    cmbBook.ValueMember = "BookID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message);
            }
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            if (cmbBorrower.SelectedValue == null || cmbBook.SelectedValue == null)
            {
                MessageBox.Show("Please select both a borrower and a book.");
                return;
            }

            int borrowerId = Convert.ToInt32(cmbBorrower.SelectedValue);
            int bookId = Convert.ToInt32(cmbBook.SelectedValue);
            DateTime issueDate = dtpIssueDate.Value;
            DateTime dueDate = dtpDueDate.Value;

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(@"Data Source=D:\assignments\C# Assignment\MyLibrary.db;Version=3;"))
                {
                    con.Open();

                    using (SQLiteTransaction transaction = con.BeginTransaction())
                    {
                        // Insert into IssuedBooks
                        string insertIssuedBook = "INSERT INTO IssuedBooks (BookID, BorrowerID, IssueDate, DueDate, Returned) VALUES (@BookID, @BorrowerID, @IssueDate, @DueDate, 0)";
                        SQLiteCommand cmd = new SQLiteCommand(insertIssuedBook, con);
                        cmd.Parameters.AddWithValue("@BookID", bookId);
                        cmd.Parameters.AddWithValue("@BorrowerID", borrowerId);
                        cmd.Parameters.AddWithValue("@IssueDate", issueDate);
                        cmd.Parameters.AddWithValue("@DueDate", dueDate);
                        cmd.ExecuteNonQuery();

                        // Decrease available copies in Books
                        string updateBook = "UPDATE Books SET AvailableCopies = AvailableCopies - 1 WHERE BookID = @BookID";
                        SQLiteCommand cmd2 = new SQLiteCommand(updateBook, con);
                        cmd2.Parameters.AddWithValue("@BookID", bookId);
                        cmd2.ExecuteNonQuery();

                        transaction.Commit();
                    }
                }

                MessageBox.Show("Book issued successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error issuing book: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}