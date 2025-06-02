using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibraryApp1
{
    public partial class BorrowerForm : Form

    {
        private int borrowerId; 

        public BorrowerForm()
        {
            InitializeComponent();
        }
        public string BorrowerName
        {
            get { return txtName.Text.Trim(); }
        }

        public string BorrowerEmail
        {
            get { return txtemail.Text.Trim(); }
        }

        public string BorrowerPhone
        {
            get { return txtPhone.Text.Trim(); }
        }

        public BorrowerForm(int borrowerId, string name, string email, string phone)
        {
            InitializeComponent();
            this.borrowerId = borrowerId;
            txtName.Text = name;
            txtemail.Text = email;
            txtPhone.Text = phone;
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtemail.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtemail.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string phone = txtPhone.Text.Trim();
            if (phone.Length < 8 || phone.Length > 15 || !phone.All(char.IsDigit))
            {
                MessageBox.Show("Please Enter A Valid Phone Number!!!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string email = txtemail.Text.Trim();
            if (!System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BorrowerForm_Load(object sender, EventArgs e)
        {

        }
    }
}