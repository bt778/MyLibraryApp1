#  MyLibrary – Desktop Library Management App

An individual assignment for **3rd Year Information Systems**  
**Course:** Event-Driven Programming with C#  
**Title:** MyLibrary – Windows Forms Desktop App with SQLite Integration

---

##  Tech Stack

- **Language:** C#  
- **Framework:** .NET (WinForms)  
- **Database:** SQLite (Local file-based)  
- **Data Access:** ADO.NET with parameterized queries  
- **IDE:** Visual Studio 2022

---

## Features Overview

###  Login System
- Login form with **admin** and **admin123**.
- Authenticates against a `Users` table.
- On success: opens main application.
- On failure: displays an error message.

###  Book Management
- Displays a list of books in a DataGridView.
- Supports:
  - Add Book
  - Edit Book
  - Delete Book
- Validates all fields (e.g., year, available copies).

###  Borrower Management
- Displays all borrowers.
- Supports:
  - Add Borrower
  - Edit Borrower
  - Delete Borrower

### Issue & Return Books
- **Issue Book:**
  - Select book + borrower
  - Decrements available copies
  - Saves to `IssuedBooks` table with issue and due date
- **Return Book:**
  - Select a borrowed book record
  - Increments available copies
  - Marks as returned or deletes from issue table

###  Bonus Features
- Filter books by author or year range.
- Generate overdue report where `DueDate < Today`.

---



