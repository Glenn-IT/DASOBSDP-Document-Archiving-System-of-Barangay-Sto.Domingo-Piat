# Document Archiving System — Barangay Sto. Domingo, Piat

A desktop document archiving and management system built for **Barangay Sto. Domingo, Piat, Cagayan**. It provides a centralized platform for storing, organizing, and managing official barangay documents with two distinct roles: **Admin** and **User**.

---

## Tech Stack

| Item | Details |
|------|---------|
| Language | Visual Basic .NET (VB.NET) |
| Framework | .NET 8.0 (Windows) |
| UI | Windows Forms (WinForms) |
| Database | SQL Server (SQL Express) |
| ORM / DB Driver | `Microsoft.Data.SqlClient` 5.x |
| Password Hashing | `BCrypt.Net-Next` 4.x |

---

## Features

### Admin
- Unified login with brute-force lockout (5 failed attempts)
- **Document management** — add, view, update, delete, and approve documents
- **User account management** — create, update, deactivate, and delete accounts
- **Activity log viewer** — full audit trail with date range and username filters
- **Profile management** — update security question/answer and password
- **Forgot password** — self-service recovery via security question

### User
- Dashboard with live statistics (total uploads, recent uploads, pending approvals)
- **Upload documents** — attach image banner and PDF, auto-generated document code
- **Archive list** — view and delete own uploaded documents
- **Search archive** — search all active documents by title or type
- **Profile management** — update security question/answer and password
- **Forgot password** — self-service recovery via security question

### Security
- Passwords hashed with **BCrypt** (never stored in plain text)
- Login locked after **5 failed attempts**
- Input sanitization on all text fields (trim + strip `<>` and null bytes)
- File size limits enforced (image: 5 MB, PDF: 50 MB)
- Connection string stored in `config.txt` outside source control
- Unsaved profile changes warn before navigating away

---

## Getting Started

### 1. Prerequisites
- [Visual Studio 2022](https://visualstudio.microsoft.com/) with the **.NET desktop development** workload
- [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or any SQL Server instance)
- [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms)

### 2. Database Setup
1. Open **SSMS** and connect to your SQL Server instance
2. Open a **New Query** window
3. Copy and run the full SQL script from [`docs/DATABASE.md`](DAS_Barangay_Sto_Domingo_Piat/docs/DATABASE.md)
4. This creates the `dasbsdp` database, all three tables, and seed data automatically

### 3. Connection String
1. Copy `config.txt.example` (found in the project folder) and rename it to `config.txt`
2. Edit `config.txt` and replace the values with your actual server instance and database name:

```
Data Source=YOUR_SERVER\SQLEXPRESS;Initial Catalog=dasbsdp;Integrated Security=True;TrustServerCertificate=True;Encrypt=False;
```

3. Place `config.txt` next to the compiled `.exe` — in `DAS_Barangay_Sto_Domingo_Piat\bin\Debug\net8.0-windows\`

> `config.txt` is listed in `.gitignore` and will never be committed.

### 4. Build and Run
1. Open `DAS_Barangay_Sto_Domingo_Piat.sln` in Visual Studio
2. Restore NuGet packages (Visual Studio does this automatically on first build)
3. Press **F5** or click **Start** to build and run

---

## Default Accounts

| Username | Password | Role | Status |
|----------|----------|------|--------|
| `admin` | `Admin@123` | Admin | Active |
| `jdela` | `User@123` | User | Active |
| `mreyes` | `User@123` | User | Active |
| `bcruz` | `User@123` | User | Active |
| `lgarcia` | `Admin@123` | Admin | Active |
| `rsantos` | `User@123` | User | Inactive |
| `ptorres` | `User@123` | User | Inactive |

> Passwords are stored as BCrypt hashes in the database. The values above match the seed data in `DATABASE.md`.

---

## Project Structure

```
DAS_Barangay_Sto_Domingo_Piat/
│
├── docs/
│   ├── DATABASE.md               ← DB schema + full SQL creation script
│   ├── DB_CONNECTION_PATTERN.md  ← Connection pattern guide for reuse
│   ├── TESTING_GUIDE.md          ← Manual test plan
│   ├── FIX_CHECKLIST.md          ← Implementation checklist (all phases)
│   ├── SYSTEM_AUDIT.md           ← Original audit findings
│   └── BACKEND_ROADMAP.md        ← Implementation roadmap
│
├── DataAccess/
│   ├── UserRepository.vb         ← All SQL for tbl_Users
│   ├── DocumentRepository.vb     ← All SQL for tbl_Documents
│   └── ActivityLogRepository.vb  ← All SQL for tbl_ActivityLogs
│
├── Helpers/
│   ├── Constants.vb              ← App-wide string constants
│   ├── InputHelper.vb            ← SanitizeInput()
│   └── PasswordHelper.vb         ← BCrypt HashPassword / VerifyPassword
│
├── LoginForm.vb                  ← Unified login (Admin + User)
├── AdminForgotPasswordForm.vb
├── UserForgotPasswordForm.vb
│
├── AdminDashboardForm.vb         ← Admin shell (sidebar + panel host)
├── AdminArchiveListPanel.vb
├── AdminNewDocumentForm.vb
├── AdminUpdateDocumentForm.vb
├── AdminDeleteDocumentForm.vb
├── AdminUsersListPanel.vb
├── AdminAddAccountForm.vb
├── AdminUpdateAccountForm.vb
├── AdminDeleteUserForm.vb
├── AdminActivityLogsPanel.vb
├── AdminViewProfilePanel.vb
│
├── UserDashboardForm.vb          ← User shell (sidebar + panel host)
├── UserDashboardPanel.vb
├── UserUploadDocumentPanel.vb
├── UserSearchArchivePanel.vb
├── UserArchiveListPanel.vb
├── UserDeleteDocumentForm.vb
├── UserViewProfilePanel.vb
│
├── SessionManager.vb             ← Stores Username, UserType, UserCode
├── ActivityLogger.vb             ← Log(username, result, description)
├── dbconstring.vb                ← Reads connection string from config.txt
└── config.txt.example            ← Connection string template
```

---

## Database Schema

Three tables:

| Table | Description |
|-------|-------------|
| `tbl_Users` | All accounts — Admins and Users |
| `tbl_Documents` | Uploaded barangay documents |
| `tbl_ActivityLogs` | Full audit trail of system events |

See [`docs/DATABASE.md`](DAS_Barangay_Sto_Domingo_Piat/docs/DATABASE.md) for the full schema, column definitions, relationships, and the SQL creation script.

---

## Development Notes

- All SQL is centralized in `DataAccess/` repository modules — no `SqlConnection` inside forms or panels
- `SessionManager` module holds the active session; `SessionManager.Clear()` is called on logout
- `ActivityLogger.Log()` swallows its own exceptions so a logging failure never crashes the app
- Document codes follow `DOC-XXXX` format; user codes follow `USR-XXXX` format (sequential, based on `MAX(ID) + 1`)

---

## License

This project was developed as an academic/community system for **Barangay Sto. Domingo, Piat, Cagayan**.
