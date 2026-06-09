# Fix Checklist — DAS Barangay Sto. Domingo Piat
**Created:** 2026-06-09
> Work through this file phase by phase. Check off each task as it is completed.

---

## Phase 0 — Security Fixes (Do First Before Any CRUD)

### 0.1 Password Hashing ✅
- [x] Add `BCrypt.Net-Next` NuGet package to the project
- [x] Create a helper method `HashPassword(plainText)` and `VerifyPassword(plainText, hash)` in a new `Helpers/PasswordHelper.vb` file
- [x] Update `LoginForm.vb` — compare using `VerifyPassword` instead of plain-text equality
- [x] Update seed data in the database — re-hash all 7 user passwords with bcrypt (run `docs/migrations/rehash_passwords.sql` in SSMS)
- [x] Update `AdminAddAccountForm.vb` — hash password before inserting
- [x] Update `AdminUpdateAccountForm.vb` — hash new password before updating
- [x] Update `AdminViewProfilePanel.vb` — hash new password before saving
- [x] Update `UserViewProfilePanel.vb` — hash new password before saving
- [x] Update `AdminForgotPasswordForm.vb` — hash new password before saving
- [x] Update `UserForgotPasswordForm.vb` — hash new password before saving (stub — will be wired in Phase 6.2)

### 0.2 Login Brute Force Protection ✅
- [x] Add a module-level `Dictionary(Of String, Integer)` to track failed attempt counts per username in `LoginForm.vb`
- [x] Increment counter on each failed login
- [x] After 5 failed attempts for the same username, show lockout message and disable the login button temporarily
- [x] Reset counter on successful login

### 0.3 Input Sanitization ✅
- [x] Create a helper method `SanitizeInput(text)` that trims whitespace and strips dangerous characters
- [x] Apply it to all text inputs before any DB query or insert

### 0.4 File Upload Validation ✅
- [x] In `UserUploadDocumentPanel.vb` — validate image file size (max 5 MB) before accepting
- [x] In `UserUploadDocumentPanel.vb` — validate PDF file size (max 50 MB) before accepting
- [x] In `AdminNewDocumentForm.vb` — apply the same size limits
- [x] Show a clear error message if the file exceeds the limit

### 0.5 Connection String Cleanup ✅
- [x] Remove the hardcoded fallback connection string from `dbconstring.vb`
- [x] Add `config.txt` to `.gitignore` so it is never committed

---

## Phase 4A — Admin: Document Management ✅

### 4A.1 Load Document List ✅
- [x] In `AdminArchiveListPanel.vb` — remove `LoadPlaceholderData()` call
- [x] Write `LoadDocumentsFromDB()` that runs `SELECT * FROM tbl_Documents ORDER BY DateUploaded DESC`
- [x] Populate the DataGridView with real data
- [x] Call `LoadDocumentsFromDB()` on panel load

### 4A.2 Search / Filter ✅
- [x] Replace the in-memory `FilterArchive()` logic with a DB query using `LIKE @search` on `Title` and `DocumentType`
- [x] Wire the search to both the `TextChanged` event and the search button

### 4A.3 Add Document ✅
- [x] In `AdminNewDocumentForm.vb` — fix DocumentCode generation: query `MAX(DocumentID)` from `tbl_Documents` and format as `DOC-{n+1:D4}`
- [x] Validate that Title is not empty
- [x] Validate that DocumentType is selected (repurposed `cmbStatus` — designer had no `cmbDocumentType`)
- [x] Convert BannerImage file to `Byte()` and store in the insert
- [x] Convert PDF file to `Byte()` and store in the insert
- [x] Run `INSERT INTO tbl_Documents (DocumentCode, Title, Description, DocumentType, BannerImage, PDFFileName, PDFFile, UploadedBy, ApprovalStatus, Status) VALUES (...)`
- [x] Set `UploadedBy = SessionManager.Username`
- [x] Set `ApprovalStatus = 'For Review'` and `Status = 'Active'` by default
- [x] Log the action: `ActivityLogger.Log(username, "Success", "Admin added document: [Title]")`
- [x] On success close the form and refresh `AdminArchiveListPanel`

### 4A.4 Pass Selected Row to Update/Delete Forms ✅
- [x] In `AdminArchiveListPanel.vb` — read `dgvArchiveList.SelectedRows(0)` to get `DocumentID` and `DocumentCode`
- [x] Pass `DocumentID` to `AdminUpdateDocumentForm` and `AdminDeleteDocumentForm` via constructor or public property before `ShowDialog()`

### 4A.5 Update Document ✅
- [x] In `AdminUpdateDocumentForm.vb` — accept the `DocumentID` passed from the list panel
- [x] On load run `SELECT * FROM tbl_Documents WHERE DocumentID = @id` and pre-fill all fields with real data
- [x] Allow editing Title, Description, DocumentType, BannerImage, PDFFile
- [x] Run `UPDATE tbl_Documents SET ... WHERE DocumentID = @id`
- [x] Log the action: `ActivityLogger.Log(username, "Success", "Admin updated document: [DocumentCode]")`
- [x] On success close the form and refresh the list

### 4A.6 Delete Document ✅
- [x] In `AdminDeleteDocumentForm.vb` — accept the `DocumentID` passed from the list panel
- [x] On confirm run `DELETE FROM tbl_Documents WHERE DocumentID = @id`
- [x] Log the action: `ActivityLogger.Log(username, "Success", "Admin deleted document: [DocumentCode]")`
- [x] On success close the form and refresh the list

### 4A.7 Approval Workflow ✅
- [x] In `AdminArchiveListPanel.vb` — add an Approve button (or right-click context menu)
- [x] On click run `UPDATE tbl_Documents SET ApprovalStatus = 'Approved' WHERE DocumentID = @id`
- [x] Log the approval action
- [x] Refresh the list after approval

---

## Phase 4B — Admin: User Management ✅

### 4B.1 Load User List ✅
- [x] In `AdminUsersListPanel.vb` — remove `LoadPlaceholderData()` call
- [x] Write `LoadUsersFromDB()` that runs `SELECT * FROM tbl_Users ORDER BY CreatedAt DESC`
- [x] Populate the DataGridView with real data
- [x] Call `LoadUsersFromDB()` on panel load

### 4B.2 Add Account ✅
- [x] In `AdminAddAccountForm.vb` — generate UserCode: query `MAX(UserID)` and format as `USR-{n+1:D4}`
- [x] Check for duplicate username: `SELECT COUNT(*) FROM tbl_Users WHERE Username = @username` before insert
- [x] Show error if username already exists
- [x] Hash the password using `PasswordHelper.HashPassword()`
- [x] Run `INSERT INTO tbl_Users (UserCode, Username, PasswordHash, UserType, SecurityQuestion, SecurityAnswer, Status) VALUES (...)`
- [x] Log the action: `ActivityLogger.Log(adminUsername, "Success", "Admin created account: [Username]")`
- [x] On success close form and refresh the list

### 4B.3 Pass Selected Row to Update/Delete Forms ✅
- [x] In `AdminUsersListPanel.vb` — read `dgvUsersList.SelectedRows(0)` to get `UserID`
- [x] Pass `UserID` to `AdminUpdateAccountForm` and `AdminDeleteUserForm` before `ShowDialog()`

### 4B.4 Update Account ✅
- [x] In `AdminUpdateAccountForm.vb` — accept `UserID` from list panel
- [x] On load run `SELECT * FROM tbl_Users WHERE UserID = @id` and pre-fill all fields
- [x] If admin enters a new password, hash it before saving; if left blank, keep existing hash
- [x] Run `UPDATE tbl_Users SET ... WHERE UserID = @id`
- [x] Log the action: `ActivityLogger.Log(adminUsername, "Success", "Admin updated account: [Username]")`
- [x] On success close form and refresh the list

### 4B.5 Delete Account ✅
- [x] In `AdminDeleteUserForm.vb` — accept `UserID` from list panel
- [x] On confirm run `DELETE FROM tbl_Users WHERE UserID = @id`
- [x] Log the action: `ActivityLogger.Log(adminUsername, "Success", "Admin deleted account: [Username]")`
- [x] On success close form and refresh the list

---

## Phase 4C — Admin: Activity Logs ✅

### 4C.1 Load Logs from DB ✅
- [x] In `AdminActivityLogsPanel.vb` — remove hardcoded `LoadPlaceholderData()` call
- [x] Write `LoadLogsFromDB()` that runs `SELECT * FROM tbl_ActivityLogs ORDER BY LogDate DESC`
- [x] Populate the DataGridView with real data
- [x] Call `LoadLogsFromDB()` on panel load

### 4C.2 Search / Filter Logs ✅
- [x] Add a date range filter (From / To) above the DataGridView
- [x] Add a username filter input
- [x] On search click, reload with a filtered query using `WHERE LogDate BETWEEN @from AND @to AND Username LIKE @username`

---

## Phase 4D — Admin: View Profile ✅

### 4D.1 Load Real Profile ✅
- [x] In `AdminViewProfilePanel.vb` — remove hardcoded profile values
- [x] On panel load run `SELECT * FROM tbl_Users WHERE Username = @sessionUsername`
- [x] Pre-fill Username label, UserCode label, SecurityQuestion dropdown, and Status label with real data

### 4D.2 Save Profile Changes ✅
- [x] If the new password field is not empty, hash it and update `PasswordHash`
- [x] If the security question/answer fields are changed, update them
- [x] Run `UPDATE tbl_Users SET PasswordHash = @hash, SecurityQuestion = @q, SecurityAnswer = @a WHERE Username = @username`
- [x] Log the action: `ActivityLogger.Log(username, "Success", "Admin updated their profile")`
- [x] Show success message

---

## Phase 5A — User: Dashboard Statistics ✅

### 5A.1 Load Real Counts ✅
- [x] In `UserDashboardPanel.vb` — remove hardcoded stat values
- [x] Query total documents uploaded by current user: `SELECT COUNT(*) FROM tbl_Documents WHERE UploadedBy = @username`
- [x] Query recent uploads (last 30 days): add `AND DateUploaded >= DATEADD(day, -30, GETDATE())`
- [x] Query pending approvals: add `AND ApprovalStatus = 'For Review'`
- [x] Display each count in the respective label

---

## Phase 5B — User: Archive List ✅

### 5B.1 Load User's Documents ✅
- [x] In `UserArchiveListPanel.vb` — remove hardcoded data
- [x] Write `LoadMyDocuments()` that runs `SELECT * FROM tbl_Documents WHERE UploadedBy = @sessionUsername ORDER BY DateUploaded DESC`
- [x] Populate the DataGridView
- [x] Call on panel load

### 5B.2 Search / Filter ✅
- [x] Add live `TextChanged` event to the search box (currently requires button click — fix for consistency)
- [x] Filter against the loaded data or re-query with `LIKE @search`

### 5B.3 Delete Own Document ✅
- [x] In `UserArchiveListPanel.vb` — read selected row `DocumentID` and pass to `UserDeleteDocumentForm`
- [x] In `UserDeleteDocumentForm.vb` — accept `DocumentID`
- [x] On confirm run `DELETE FROM tbl_Documents WHERE DocumentID = @id AND UploadedBy = @sessionUsername`
- [x] Log the deletion
- [x] Refresh the list

---

## Phase 5C — User: Upload Document ✅

### 5C.1 DocumentCode Generation ✅
- [x] Remove timestamp-based DocumentCode logic from `UserUploadDocumentPanel.vb`
- [x] Query `MAX(DocumentID)` from `tbl_Documents` and format as `DOC-{n+1:D4}`

### 5C.2 File Handling ✅
- [x] When the user selects a banner image, read it into a `Byte()` array and keep it in memory
- [x] When the user selects a PDF, read it into a `Byte()` array and keep the original filename too
- [x] Validate file size before accepting (see Phase 0.4)

### 5C.3 DB Insert ✅
- [x] Set `UploadedBy = SessionManager.Username` automatically (do not let the user change this)
- [x] Set `ApprovalStatus = 'For Review'` and `Status = 'Active'` by default
- [x] Run the full `INSERT INTO tbl_Documents (...)` with all fields including binary data
- [x] Log the action: `ActivityLogger.Log(username, "Success", "User uploaded document: [Title]")`
- [x] Reset the form after successful upload

---

## Phase 5D — User: Search Archive ✅

### 5D.1 Load All Documents ✅
- [x] In `UserSearchArchivePanel.vb` — remove hardcoded data
- [x] On load run `SELECT * FROM tbl_Documents WHERE Status = 'Active' ORDER BY DateUploaded DESC`
- [x] Populate the DataGridView

### 5D.2 Search ✅
- [x] On search button click (or `TextChanged`) re-query with `WHERE Title LIKE @search OR DocumentType LIKE @search`
- [x] Add a DocumentType dropdown filter in addition to text search

---

## Phase 5E — User: View Profile ✅

### 5E.1 Load Real Profile ✅
- [x] In `UserViewProfilePanel.vb` — remove hardcoded `jdela` values
- [x] On panel load run `SELECT * FROM tbl_Users WHERE Username = @sessionUsername`
- [x] Pre-fill all fields with real data

### 5E.2 Save Profile Changes ✅
- [x] If password field is not empty, hash it and update `PasswordHash`
- [x] Update `SecurityQuestion` and `SecurityAnswer` if changed
- [x] Run `UPDATE tbl_Users SET ... WHERE Username = @sessionUsername`
- [x] Log the action
- [x] Show success message

---

## Phase 6 — Forgot Password ✅

### 6.1 Admin Forgot Password Form ✅
- [x] Add a Username input field at the top of `AdminForgotPasswordForm.vb`
- [x] On username entry, query `SELECT SecurityQuestion FROM tbl_Users WHERE Username = @username AND UserType = 'Admin'`
- [x] Populate the security question label/dropdown with the result
- [x] Validate the answer: `SELECT COUNT(*) FROM tbl_Users WHERE Username = @username AND SecurityAnswer = @answer`
- [x] If answer is wrong, show error and stop
- [x] If answer is correct, show the new password fields
- [x] Hash the new password and run `UPDATE tbl_Users SET PasswordHash = @hash WHERE Username = @username`
- [x] Log the password reset action
- [x] Show success and close the form

### 6.2 User Forgot Password Form ✅
- [x] Build out `UserForgotPasswordForm.vb` from scratch (currently an empty stub)
- [x] Same flow as Admin Forgot Password but filter by `UserType = 'User'`
- [x] Add Username input, security question display, security answer input, new password + confirm fields
- [x] Implement the same validation and DB update logic as 6.1
- [x] Log the action and show success

---

## Phase 7 — Logout Logging ✅

### 7.1 Admin Logout ✅
- [x] In `AdminDashboardForm.vb` — before `SessionManager.Clear()`, call `ActivityLogger.Log(SessionManager.Username, "Success", "User logged out.")`

### 7.2 User Logout ✅
- [x] In `UserDashboardForm.vb` — same as above

---

## Phase 8 — Cleanup & Polish ✅

### 8.1 Remove Duplicate Login Forms ✅
- [x] Verify `AdminLoginForm.vb` and `UserLoginForm.vb` are no longer referenced anywhere
- [x] Delete `AdminLoginForm.vb`, `AdminLoginForm.Designer.vb`
- [x] Delete `UserLoginForm.vb`, `UserLoginForm.Designer.vb`

### 8.2 Admin Dashboard Title Label ✅
- [x] In `AdminDashboardForm.vb` — update the title label text each time a panel is loaded (same pattern the User dashboard already uses)

### 8.3 Profile Navigation Warning ✅
- [x] In both profile panels — if the user has unsaved changes and clicks a sidebar button, show a `MessageBox` asking to save first

### 8.4 DocumentCode Format Consistency ✅
- [x] Confirm both `AdminNewDocumentForm.vb` and `UserUploadDocumentPanel.vb` use the same `DOC-{n:D4}` sequential format
- [x] Do the same check for `UserCode` generation in `AdminAddAccountForm.vb` (`USR-{n:D4}`)

### 8.5 String Constants ✅
- [x] Create a `Constants.vb` module with constants for all magic strings:
  - `UserType_Admin = "Admin"`, `UserType_User = "User"`
  - `Status_Active = "Active"`, `Status_Inactive = "Inactive"`
  - `Approval_ForReview = "For Review"`, `Approval_Approved = "Approved"`, `Approval_Archived = "Archived"`
- [x] Replace all hardcoded string literals with these constants across every file

### 8.6 Data Access Layer (Optional Refactor) ✅
- [x] Create `DataAccess/` folder
- [x] Create `UserRepository.vb` with methods: `GetAll`, `GetByUsername`, `Insert`, `Update`, `Delete`
- [x] Create `DocumentRepository.vb` with methods: `GetAll`, `GetByUser`, `Search`, `Insert`, `Update`, `Delete`
- [x] Create `ActivityLogRepository.vb` with methods: `GetAll`, `Insert`
- [x] Migrate all inline SQL from forms into the appropriate repository methods

---

*Reference `SYSTEM_AUDIT.md` for full details on each issue. Reference `BACKEND_ROADMAP.md` for implementation guidance.*
