namespace MyLibraryApp1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnIssuedBooks = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDeleteBorrowers = new System.Windows.Forms.Button();
            this.btnEditBorrowers = new System.Windows.Forms.Button();
            this.btnAddBorrowers = new System.Windows.Forms.Button();
            this.dgvBorrowers = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowers)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(6, 6);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1183, 736);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btnIssuedBooks);
            this.tabPage1.Controls.Add(this.btnDeleteBook);
            this.tabPage1.Controls.Add(this.btnEditBook);
            this.tabPage1.Controls.Add(this.btnAddBook);
            this.tabPage1.Controls.Add(this.dgvBooks);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1175, 694);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Books Management";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SpringGreen;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(671, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 56);
            this.button1.TabIndex = 5;
            this.button1.Text = "View Issued Books";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIssuedBooks
            // 
            this.btnIssuedBooks.BackColor = System.Drawing.Color.SpringGreen;
            this.btnIssuedBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIssuedBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssuedBooks.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssuedBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIssuedBooks.Location = new System.Drawing.Point(333, 25);
            this.btnIssuedBooks.Name = "btnIssuedBooks";
            this.btnIssuedBooks.Size = new System.Drawing.Size(161, 49);
            this.btnIssuedBooks.TabIndex = 4;
            this.btnIssuedBooks.Text = "Return Book";
            this.btnIssuedBooks.UseVisualStyleBackColor = false;
            this.btnIssuedBooks.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBook.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeleteBook.Location = new System.Drawing.Point(56, 391);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(109, 49);
            this.btnDeleteBook.TabIndex = 3;
            this.btnDeleteBook.Text = "Delete Book";
            this.btnDeleteBook.UseVisualStyleBackColor = false;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnEditBook
            // 
            this.btnEditBook.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnEditBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditBook.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditBook.Location = new System.Drawing.Point(56, 244);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(109, 44);
            this.btnEditBook.TabIndex = 2;
            this.btnEditBook.Text = "Edit Book";
            this.btnEditBook.UseMnemonic = false;
            this.btnEditBook.UseVisualStyleBackColor = false;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnAddBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddBook.Location = new System.Drawing.Point(56, 96);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(109, 48);
            this.btnAddBook.TabIndex = 1;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(224, 96);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.RowTemplate.Height = 24;
            this.dgvBooks.Size = new System.Drawing.Size(851, 482);
            this.dgvBooks.TabIndex = 0;
            this.dgvBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tabPage2.Controls.Add(this.btnDeleteBorrowers);
            this.tabPage2.Controls.Add(this.btnEditBorrowers);
            this.tabPage2.Controls.Add(this.btnAddBorrowers);
            this.tabPage2.Controls.Add(this.dgvBorrowers);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1175, 694);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Borrowers Management";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnDeleteBorrowers
            // 
            this.btnDeleteBorrowers.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteBorrowers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteBorrowers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBorrowers.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBorrowers.Location = new System.Drawing.Point(23, 419);
            this.btnDeleteBorrowers.Name = "btnDeleteBorrowers";
            this.btnDeleteBorrowers.Size = new System.Drawing.Size(152, 54);
            this.btnDeleteBorrowers.TabIndex = 3;
            this.btnDeleteBorrowers.Text = "Delete Borrowers";
            this.btnDeleteBorrowers.UseVisualStyleBackColor = false;
            this.btnDeleteBorrowers.Click += new System.EventHandler(this.btnDeleteBorrowers_Click);
            // 
            // btnEditBorrowers
            // 
            this.btnEditBorrowers.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnEditBorrowers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditBorrowers.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBorrowers.Location = new System.Drawing.Point(23, 221);
            this.btnEditBorrowers.Name = "btnEditBorrowers";
            this.btnEditBorrowers.Size = new System.Drawing.Size(152, 62);
            this.btnEditBorrowers.TabIndex = 2;
            this.btnEditBorrowers.Text = "Edit Borrowers";
            this.btnEditBorrowers.UseVisualStyleBackColor = false;
            this.btnEditBorrowers.Click += new System.EventHandler(this.btnEditBorrowers_Click);
            // 
            // btnAddBorrowers
            // 
            this.btnAddBorrowers.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnAddBorrowers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBorrowers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBorrowers.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBorrowers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddBorrowers.Location = new System.Drawing.Point(23, 81);
            this.btnAddBorrowers.Name = "btnAddBorrowers";
            this.btnAddBorrowers.Size = new System.Drawing.Size(152, 48);
            this.btnAddBorrowers.TabIndex = 1;
            this.btnAddBorrowers.Text = "Add Borrowers";
            this.btnAddBorrowers.UseVisualStyleBackColor = false;
            this.btnAddBorrowers.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvBorrowers
            // 
            this.dgvBorrowers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowers.Location = new System.Drawing.Point(237, 81);
            this.dgvBorrowers.Name = "dgvBorrowers";
            this.dgvBorrowers.RowHeadersWidth = 51;
            this.dgvBorrowers.RowTemplate.Height = 24;
            this.dgvBorrowers.Size = new System.Drawing.Size(844, 348);
            this.dgvBorrowers.TabIndex = 0;
            this.dgvBorrowers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrowers_CellContentClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 799);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "S";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnDeleteBorrowers;
        private System.Windows.Forms.Button btnEditBorrowers;
        private System.Windows.Forms.Button btnAddBorrowers;
        private System.Windows.Forms.DataGridView dgvBorrowers;
        private System.Windows.Forms.Button btnIssuedBooks;
        private System.Windows.Forms.Button button1;
    }
}