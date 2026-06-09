# System Audit — DAS Barangay Sto. Domingo Piat
**Audit Date:** 2026-06-09
**Project:** Document Archiving System (DAS) — Barangay Sto. Domingo, Piat
**Stack:** VB.NET · .NET 8.0 · Windows Forms · SQL Server Express

---

## Overall Status: 28% Production-Ready

| Phase | Description | Status | % Done |
|-------|-------------|--------|--------|
| 1 | UI Scaffolding | Complete | 100% |
| 2 | Database & Connection | Complete | 100% |
| 3 | Authentication | Complete | 100% |
| 4 | Admin CRUD Operations | Not Started | 0% |
| 5 | User Features | Not Started | 0% |
| 6 | Forgot Password | Stub Only | 5% |
| 7 | Logout Logging | Partial | 50% |

---

## 1. Critical Security Issues

### 1.1 — Plain-Text Passwords (CRITICAL)
**Where:** `tbl_Users.PasswordHash` column, all seed data in `DATABASE.md`
**Problem:** Passwords are stored as plain text (`admin123`, `jdela123`, etc.). If the database is ever accessed by an unauthorized party, all user credentials are immediately exposed.
**Fix Required:**
- Implement password hashing using `BCrypt.Net` or `System.Security.Cryptography.PBKDF2`
- Hash passwords before inserting into the database
- Compare hash during login (not plain text)
- Re-hash all existing seed data

### 1.2 — No Input Sanitization (HIGH)
**Where:** All form text inputs — usernames, document titles, descriptions, security answers
**Problem:** User-entered data is inserted directly into SQL queries via string interpolation in some places. This opens SQL injection attack vectors.
**Fix Required:**
- Use `SqlCommand` with parameterized queries (`@Username`, `@Password`) for every DB operation
- Validate and trim input before use

### 1.3 — No Brute Force Protection on Login (HIGH)
**Where:** `LoginForm.vb`
**Problem:** The login form allows unlimited attempts with no lockout or delay. An attacker can guess credentials infinitely.
**Fix Required:**
- Track consecutive failed login attempts per username in memory or DB
- Lock account temporarily after 5 failed attempts
- Show appropriate message to user

### 1.4 — File Upload Size Not Validated (MEDIUM)
**Where:** `UserUploadDocumentPanel.vb`, `AdminNewDocumentForm.vb`
**Problem:** `BannerImage` and `PDFFile` stored as `VARBINARY(MAX)` with no size limit. A user can upload a multi-GB file and crash the application or fill disk space.
**Fix Required:**
- Validate file size before upload (e.g., max 10 MB for image, max 50 MB for PDF)
- Show error if file exceeds limit

### 1.5 — Connection String Exposed in Source Code (LOW)
**Where:** `dbconstring.vb` — hardcoded fallback string
**Problem:** Server name (`Glenn\SQLEXPRESS`) and database name are visible in version-controlled source code.
**Fix Required:**
- Store all connection info in `config.txt` only (already partially done)
- Add `config.txt` to `.gitignore`

---

## 2. Missing Core Features (Phases 4 & 5)

Every form and panel was created in Phase 1 with placeholder/hardcoded data. None of them query or write to the database yet. Below is the complete list of missing implementations.

### 2.1 — Admin: Document Management (Phase 4A)
**Affected Files:** `AdminArchiveListPanel.vb`, `AdminNewDocumentForm.vb`, `AdminUpdateDocumentForm.vb`, `AdminDeleteDocumentForm.vb`

| Feature | Status | What's Missing |
|---------|--------|----------------|
| Load document list | Hardcoded 7 rows | `SELECT * FROM tbl_Documents` query |
| Live search | Filters hardcoded rows | Must filter from DB query result |
| Add document | Shows success only | `INSERT INTO tbl_Documents`, auto-generate `DOC-XXXX` code |
| Update document | Hardcoded pre-fill | Pass selected row to form, run `UPDATE tbl_Documents` |
| Delete document | Confirmation only | Run `DELETE FROM tbl_Documents WHERE DocumentID = @id` |
| Activity logging | None | Log every Add/Update/Delete to `tbl_ActivityLogs` |

**Note:** `AdminNewDocumentForm.vb` generates DocumentCode in timestamp format (`DOC-20250609120530`). The spec requires sequential `DOC-XXXX` format (e.g., `DOC-0008`). This must be fixed.

### 2.2 — Admin: User Management (Phase 4B)
**Affected Files:** `AdminUsersListPanel.vb`, `AdminAddAccountForm.vb`, `AdminUpdateAccountForm.vb`, `AdminDeleteUserForm.vb`

| Feature | Status | What's Missing |
|---------|--------|----------------|
| Load user list | Hardcoded 7 rows | `SELECT * FROM tbl_Users` query |
| Add account | Validates form only | `INSERT INTO tbl_Users`, auto-generate `USR-XXXX` code, check duplicate username, hash password |
| Update account | Hardcoded pre-fill | Pass selected row to form, run `UPDATE tbl_Users` |
| Delete account | Confirmation only | `DELETE FROM tbl_Users WHERE UserID = @id` |
| Activity logging | None | Log every operation |

### 2.3 — Admin: Activity Logs Panel (Phase 4C)
**Affected File:** `AdminActivityLogsPanel.vb`
**Missing:** Replace 7 hardcoded rows with `SELECT * FROM tbl_ActivityLogs ORDER BY LogDate DESC`

### 2.4 — Admin: View Profile (Phase 4D)
**Affected File:** `AdminViewProfilePanel.vb`
**Missing:**
- Load profile from `tbl_Users WHERE Username = SessionManager.Username` (currently hardcoded to `admin`)
- Save updated password (hashed) and security Q&A back to DB
- Log profile changes to `tbl_ActivityLogs`

### 2.5 — User: Dashboard Statistics (Phase 5A)
**Affected File:** `UserDashboardPanel.vb`
**Current:** Hardcoded labels showing 7 / 3 / 3
**Missing:**
- Total documents: `SELECT COUNT(*) FROM tbl_Documents WHERE UploadedBy = @username`
- Recent uploads: filter by `DateUploaded >= DATEADD(day, -30, GETDATE())`
- Pending approvals: filter by `ApprovalStatus = 'For Review'`

### 2.6 — User: Archive List (Phase 5B)
**Affected Files:** `UserArchiveListPanel.vb`, `UserDeleteDocumentForm.vb`
**Missing:**
- Load only current user's documents: `WHERE UploadedBy = SessionManager.Username`
- Wire delete form to actually run `DELETE FROM tbl_Documents`
- Log deletions

### 2.7 — User: Upload Document (Phase 5C)
**Affected File:** `UserUploadDocumentPanel.vb`
**Missing:**
- Auto-generate sequential `DOC-XXXX` code (same issue as admin side)
- Convert image and PDF to byte arrays and insert as `VARBINARY(MAX)`
- Set `UploadedBy = SessionManager.Username` automatically
- Default `ApprovalStatus = 'For Review'`
- Log the upload action

### 2.8 — User: Search Archive (Phase 5D)
**Affected File:** `UserSearchArchivePanel.vb`
**Missing:**
- Replace hardcoded rows with `SELECT * FROM tbl_Documents` query
- Filter by `Title LIKE @search OR DocumentType LIKE @search` via DB query (not in-memory)

### 2.9 — User: View Profile (Phase 5E)
**Affected File:** `UserViewProfilePanel.vb`
**Missing:** Same as Admin Profile (2.4) — currently hardcoded to `jdela`

---

## 3. Forgot Password — Not Implemented (Phase 6)

**Affected Files:** `AdminForgotPasswordForm.vb`, `UserForgotPasswordForm.vb`

`AdminForgotPasswordForm.vb` has a complete UI but pressing the reset button just shows a success message without any validation or database update.

`UserForgotPasswordForm.vb` is a completely empty stub — the form opens but has no controls and no code.

**What's Missing (Both Forms):**
1. User enters their username
2. App queries `tbl_Users` to find their registered `SecurityQuestion`
3. User answers the question
4. App compares their answer to `SecurityAnswer` in DB (case-insensitive)
5. If correct: allow user to set a new password (must be hashed before saving)
6. Log the password reset action to `tbl_ActivityLogs`

---

## 4. Incomplete Partial Implementations

### 4.1 — Logout Not Logged (Phase 7)
**Affected Files:** `AdminDashboardForm.vb`, `UserDashboardForm.vb`
**Problem:** Both dashboards confirm logout and clear the session, but do not write a logout event to `tbl_ActivityLogs` before clearing.
**Fix:** Call `ActivityLogger.Log(SessionManager.Username, "Success", "User logged out.")` before `SessionManager.Clear()`.

### 4.2 — ApprovalStatus Workflow Has No UI
**Where:** `tbl_Documents.ApprovalStatus` (values: `For Review`, `Approved`, `Archived`)
**Problem:** The column exists in the DB and seed data uses it, but no admin UI exists to review and approve/reject documents. Users upload with `For Review` status and it stays there permanently.
**Fix Required:** Add an approval action in `AdminArchiveListPanel` — a button or dropdown that lets admin change `ApprovalStatus` for a selected document.

### 4.3 — Archive Status Workflow Has No UI
**Where:** `tbl_Documents.Status` (values: `Active`, `Archived`)
**Problem:** The column exists but no UI lets admin or users move a document to `Archived` status.
**Fix Required:** Add an archive action in the document management panel.

### 4.4 — Duplicate Admin Login Forms
**Affected Files:** `AdminLoginForm.vb`, `UserLoginForm.vb`
**Problem:** These two forms are near-identical copies of `LoginForm.vb` with only minor differences. This creates three places to fix any login bug.
**Fix Required:** Delete `AdminLoginForm.vb` and `UserLoginForm.vb`. Rely exclusively on `LoginForm.vb` which already auto-routes by `UserType`.

### 4.5 — Row Selection Not Passed to Edit/Delete Forms
**Where:** `AdminArchiveListPanel.vb`, `AdminUsersListPanel.vb`, `UserArchiveListPanel.vb`
**Problem:** When the user selects a row in the DataGridView and clicks Update or Delete, the selected row's data is not passed to the modal form. The edit forms currently pre-fill with hardcoded data.
**Fix Required:** Read `dgv.SelectedRows(0)` and pass the `DocumentID` or `UserID` to the child form via a constructor parameter or public property before calling `ShowDialog()`.

---

## 5. Architecture & Code Quality Issues

### 5.1 — No Data Access Layer (HIGH)
**Problem:** All SQL is written directly inside form code-behind files (`_Load`, button click handlers). This makes it impossible to unit-test business logic and duplicates connection/query code across dozens of files.
**Recommended Fix:** Create a `DataAccess/` folder with:
- `UserRepository.vb` — GetAll, GetById, GetByUsername, Insert, Update, Delete
- `DocumentRepository.vb` — GetAll, GetByUser, Insert, Update, Delete, Search
- `ActivityLogRepository.vb` — Insert, GetAll

### 5.2 — No Entity Models (MEDIUM)
**Problem:** There are no POCO/model classes for `User`, `Document`, or `ActivityLog`. Data is passed around as raw DataRow values, making code harder to read and refactor.
**Recommended Fix:** Create a `Models/` folder with:
- `UserModel.vb` — UserID, UserCode, Username, UserType, Status, etc.
- `DocumentModel.vb` — DocumentID, DocumentCode, Title, DocumentType, etc.
- `ActivityLogModel.vb` — LogID, LogCode, Username, LogDate, Result, Description

### 5.3 — No Async Database Calls (MEDIUM)
**Problem:** All database calls use synchronous ADO.NET methods (`ExecuteReader`, `ExecuteNonQuery`). On a slow network or when loading large binary files (PDFs), the UI will freeze.
**Recommended Fix:** Use `Async/Await` with `ExecuteReaderAsync`, `ExecuteNonQueryAsync`, and show a loading indicator while waiting.

### 5.4 — No Transaction Support (MEDIUM)
**Problem:** Multi-step operations (e.g., insert a document then log the action) are two separate SQL commands. If the log insert fails after the document is inserted, the audit trail is incomplete with no rollback.
**Recommended Fix:** Wrap multi-step operations in a `SqlTransaction`.

### 5.5 — String-Based Enums (LOW)
**Problem:** `UserType` (`"Admin"/"User"`), `Status` (`"Active"/"Inactive"`), `ApprovalStatus` (`"For Review"/"Approved"/"Archived"`) are magic strings scattered across the codebase. A typo anywhere causes a silent bug.
**Recommended Fix:** Define VB.NET `Enum` types or `Module`-level constants:
```vb
Module UserStatus
    Public Const Active As String = "Active"
    Public Const Inactive As String = "Inactive"
End Module
```

### 5.6 — No Unit Tests (LOW)
**Problem:** There are zero automated tests in the project. All testing is manual (run app, click through UI).
**Recommended Fix:** Add an `xUnit` or `NUnit` test project. Once a data access layer exists, test repositories with an in-memory or test database.

---

## 6. UX / Minor Issues

| # | Issue | Location | Fix |
|---|-------|----------|-----|
| 1 | Admin dashboard title label never changes | `AdminDashboardForm.vb` | Update title when each panel loads (User side already does this correctly) |
| 2 | Profile panel loses unsaved changes on navigation | `AdminViewProfilePanel.vb`, `UserViewProfilePanel.vb` | Prompt user to save before switching panels |
| 3 | Search in UserArchiveListPanel requires button click | `UserArchiveListPanel.vb` | Add live `TextChanged` filter like other panels have |
| 4 | No confirmation when navigating away from an open form | All modal forms | Low priority, acceptable behavior |
| 5 | DocumentCode uses timestamp format instead of DOC-XXXX | `AdminNewDocumentForm.vb`, `UserUploadDocumentPanel.vb` | Query `MAX(DocumentID)` and format as `DOC-{n+1:D4}` |

---

## 7. Prioritized Fix List

### Priority 1 — Must Fix Before Any Real Use
1. Hash all passwords (bcrypt/PBKDF2) — `tbl_Users`, login, password reset, profile update
2. Implement Admin Document CRUD with DB (Phase 4A)
3. Implement User Upload Document with DB (Phase 5C)
4. Fix DocumentCode generation to use sequential `DOC-XXXX` format

### Priority 2 — Core Functionality
5. Implement Admin User Management CRUD with DB (Phase 4B)
6. Implement User Archive List with DB + delete (Phase 5B)
7. Load Activity Logs from DB (Phase 4C)
8. Load profiles from DB and allow updates (Phase 4D, 5E)
9. Wire row selection from DataGridView to edit/delete forms

### Priority 3 — Important but Not Blocking
10. Implement Forgot Password validation and DB update (Phase 6)
11. Implement User Search Archive from DB (Phase 5D)
12. Implement User Dashboard statistics from DB (Phase 5A)
13. Add logout logging (Phase 7)
14. Add approval workflow UI for admin

### Priority 4 — Quality & Maintainability
15. Create data access layer (Repository classes)
16. Create entity model classes
17. Add async/await for all DB calls
18. Remove duplicate `AdminLoginForm.vb` and `UserLoginForm.vb`
19. Add input validation (length limits, whitespace trimming)
20. Add transaction support for multi-step operations

---

## 8. Estimated Effort to Production

| Area | Estimated Time |
|------|----------------|
| Password hashing (Priority 1.1) | 2–4 hours |
| Admin Document CRUD (Phase 4A) | 1–2 days |
| User Upload Document (Phase 5C) | 1 day |
| Admin User CRUD (Phase 4B) | 1–2 days |
| User Archive + Delete (Phase 5B) | 4–6 hours |
| Activity Logs, Profile, Stats | 1 day |
| Forgot Password (Phase 6) | 4–6 hours |
| Logout logging + row-selection fixes | 2–3 hours |
| Approval/Archive workflow | 4–6 hours |
| Data access layer refactor | 1–2 days |
| **Total Estimate** | **~4–6 weeks (solo developer)** |

---

## 9. What Is Already Working Well

- Login authentication flow is solid — validates credentials, checks account status, routes by role, logs all attempts
- Session management is clean and simple
- Activity logging infrastructure is in place (`ActivityLogger.vb`)
- Database schema is well-designed: normalized, constrained, and seeded
- Panel-based navigation pattern is clean and consistent
- UI layout is complete — all screens exist and are visually consistent
- Docs folder is well-maintained with schema, roadmap, and progress tracked

---

*Audit generated by Claude Code on 2026-06-09. For implementation roadmap see `BACKEND_ROADMAP.md`.*
