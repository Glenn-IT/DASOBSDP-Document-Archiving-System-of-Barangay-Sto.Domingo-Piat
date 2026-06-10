# Testing Guide — DAS Barangay Sto. Domingo Piat
**Created:** 2026-06-10
> Manual test plan covering every feature implemented in the fix checklist (Phases 0–8.6).
> Run each section in order. Mark each case ✅ Pass or ❌ Fail and note the issue.

---

## Prerequisites
- SQL Server (Glenn\SQLEXPRESS) is running
- `config.txt` is present and points to `dasbsdp`
- At least one Admin account and one User account exist in `tbl_Users` with bcrypt-hashed passwords
- Application is built (`dotnet build`) with 0 errors

**Test Accounts (update if different):**

| Username | Password | UserType | Status |
|----------|----------|----------|--------|
| admin01  | admin123 | Admin    | Active |
| user01   | user123  | User     | Active |
| inactive01 | any    | User     | Inactive |

---

## Section 1 — Login (LoginForm)

### 1.1 Valid Admin Login
- [x] Enter valid admin username and password → should open `AdminDashboardForm`
- [x] Activity log should record: `"Admin logged in successfully."`

### 1.2 Valid User Login
- [ ] Enter valid user username and password → should open `UserDashboardForm`
- [ ] Activity log should record: `"User logged in successfully."`

### 1.3 Wrong Password
- [ ] Enter correct username, wrong password → should show "Invalid username or password."
- [ ] Should NOT open any dashboard

### 1.4 Non-Existent Username
- [ ] Enter a username that does not exist → should show "Invalid username or password."

### 1.5 Inactive Account
- [ ] Log in with an account whose `Status = 'Inactive'` → should show "Your account is inactive."
- [ ] Activity log should record a failed login

### 1.6 Brute Force Lockout
- [ ] Enter wrong password 5 times for the same username
- [ ] On the 5th failure the login button should be disabled
- [ ] Message should warn about lockout after 5 failed attempts

### 1.7 Enter Key Submits Login
- [ ] Type username and password, press **Enter** in the password field → should attempt login

### 1.8 Empty Fields
- [ ] Click Login with both fields empty → should show "Please enter your username and password."

---

## Section 2 — Forgot Password

### 2.1 Admin Forgot Password — Happy Path
- [ ] Click "Forgot Password" on the login screen → `AdminForgotPasswordForm` opens
- [ ] Enter a valid admin username and tab out → security question should populate in the dropdown
- [ ] Enter the correct security answer, a new password, and matching confirm password → click Confirm
- [ ] Should show "Password reset successfully!" and navigate to `LoginForm`
- [ ] Log in with the new password → should succeed
- [ ] Activity log should record: `"Admin reset their password via forgot password."`

### 2.2 Admin Forgot Password — Unknown Username
- [ ] Enter a username that doesn't exist or isn't an Admin and tab out
- [ ] Should show "No admin account found with that username."
- [ ] Security question dropdown should remain empty

### 2.3 Admin Forgot Password — Wrong Answer
- [ ] Enter a valid admin username, tab out (question populates)
- [ ] Enter an incorrect security answer → click Confirm
- [ ] Should show "Incorrect security answer." and not change the password

### 2.4 Admin Forgot Password — Passwords Don't Match
- [ ] Fill valid username, correct answer, enter mismatched new/confirm passwords → click Confirm
- [ ] Should show "Passwords do not match."

### 2.5 User Forgot Password — Happy Path
- [ ] From `LoginForm` navigate to `UserForgotPasswordForm` (note: LoginForm's btnForgotPassword opens AdminForgotPasswordForm — verify the correct form is triggered for users)
- [ ] Enter a valid user username and tab out → security question should populate
- [ ] Enter correct answer, new password, matching confirm → click Confirm
- [ ] Should show "Password reset successfully!" and navigate to `LoginForm`
- [ ] Activity log should record: `"User reset their password via forgot password."`

### 2.6 User Forgot Password — Wrong Username (User not found)
- [ ] Enter a username that doesn't exist or belongs to an Admin → should show "No user account found with that username."

### 2.7 Back to Login Button
- [ ] Click "← Go Back to Login" on either forgot password form → should close the form and show `LoginForm`

---

## Section 3 — Admin Dashboard

### 3.1 Page Title Updates
- [ ] On load, title label should read `"Archive List"` and welcome label `"Welcome, [admin username]!"`
- [ ] Click each sidebar button → title label should update to match the section name

### 3.2 Sidebar Navigation
- [ ] Each sidebar button loads the correct panel in `pnlMainContent`
- [ ] The previously loaded panel is replaced (not stacked)

### 3.3 Unsaved Profile Navigation Warning
- [ ] Navigate to View Profile, make a change (e.g., change security answer)
- [ ] Click a different sidebar button → dialog: "You have unsaved profile changes. Discard and leave?"
- [ ] Click **No** → should stay on the profile panel
- [ ] Click **Yes** → should navigate away and discard changes

---

## Section 4 — Admin: Archive List (AdminArchiveListPanel)

### 4.1 Load Real Documents
- [ ] Documents panel loads with real data from `tbl_Documents`
- [ ] All columns (DocumentCode, Title, DocumentType, UploadedBy, Date, ApprovalStatus, Status) are populated

### 4.2 Search / Filter
- [ ] Type text in the search box → list filters live (TextChanged) or on button click
- [ ] Matching rows for Title and DocumentType are shown
- [ ] Clear the search → all rows return

### 4.3 Add Document
- [ ] Click Add → `AdminNewDocumentForm` opens
- [ ] DocumentCode is auto-generated in `DOC-XXXX` format (sequential, not timestamp)
- [ ] Leave Title blank → should show validation error
- [ ] Fill all fields, optionally attach image and PDF → click Save
- [ ] Document appears in the list after close
- [ ] Activity log records: `"Admin added document: [Title]"`

### 4.4 Update Document
- [ ] Select a row, click Update → `AdminUpdateDocumentForm` opens
- [ ] All existing fields are pre-filled with real data
- [ ] Change a field and save → list reflects the change
- [ ] Activity log records: `"Admin updated document: [DocumentCode]"`

### 4.5 Delete Document
- [ ] Select a row, click Delete → `AdminDeleteDocumentForm` opens
- [ ] Confirm delete → document is removed from the list
- [ ] Cancel → document remains
- [ ] Activity log records: `"Admin deleted document: [DocumentCode]"`

### 4.6 Approve Document
- [ ] Select a document with `ApprovalStatus = 'For Review'`
- [ ] Click Approve → `ApprovalStatus` changes to `'Approved'` in the list
- [ ] Activity log records the approval

---

## Section 5 — Admin: User Management (AdminUsersListPanel)

### 5.1 Load Real Users
- [ ] Users panel loads with real data from `tbl_Users`

### 5.2 Add Account
- [ ] Click Add → `AdminAddAccountForm` opens
- [ ] UserCode is auto-generated in `USR-XXXX` format
- [ ] Enter a duplicate username → should show "Username already exists."
- [ ] Fill all fields, set UserType (Admin or User), Status → Save
- [ ] New account appears in the list
- [ ] Activity log records: `"Admin created account: [Username]"`

### 5.3 Update Account
- [ ] Select a user, click Update → `AdminUpdateAccountForm` opens with pre-filled data
- [ ] Leave password blank → existing password is kept unchanged
- [ ] Enter a new password → it is hashed and saved
- [ ] Activity log records: `"Admin updated account: [Username]"`

### 5.4 Delete Account
- [ ] Select a user, click Delete → confirm → user is removed
- [ ] Activity log records: `"Admin deleted account: [Username]"`

---

## Section 6 — Admin: Activity Logs (AdminActivityLogsPanel)

### 6.1 Load Real Logs
- [ ] Logs panel loads with real entries from `tbl_ActivityLogs`
- [ ] Columns: LogCode, Username, Result, Description, LogDate

### 6.2 Date Range Filter
- [ ] Set a From/To date range → only logs within that range are shown

### 6.3 Username Filter
- [ ] Enter a partial username → only matching entries are shown

---

## Section 7 — Admin: View Profile (AdminViewProfilePanel)

### 7.1 Load Real Profile
- [ ] Panel loads with the current admin's real data (username, user type, security question/answer)

### 7.2 Update Security Question / Answer
- [ ] Change the security question and/or answer, click Update → saved successfully
- [ ] Reload the panel → updated values are shown

### 7.3 Update Password
- [ ] Enter matching new/confirm password → click Update → saved
- [ ] Log out and log back in with the new password → succeeds
- [ ] Activity log records: `"Admin updated their profile"`

### 7.4 Mismatched Passwords
- [ ] Enter non-matching new/confirm passwords → should show "Passwords do not match."

### 7.5 Cancel Discards Changes
- [ ] Make changes, click Cancel → fields revert to saved values
- [ ] `_isDirty` flag resets (no navigation warning after Cancel)

---

## Section 8 — Admin: Logout

### 8.1 Logout Confirmation
- [ ] Click Logout → confirmation dialog appears
- [ ] Click **No** → stay on the dashboard
- [ ] Click **Yes** → session is cleared, `LoginForm` appears
- [ ] Activity log records: `"User logged out."`

### 8.2 Session Cleared After Logout
- [ ] After logout, `SessionManager.Username` / `UserType` / `UserCode` are all empty
- [ ] Logging in as a different user immediately after works correctly

---

## Section 9 — User Dashboard (UserDashboardPanel)

### 9.1 Statistics Are Real
- [ ] "Total Uploaded" count matches actual documents by this user in `tbl_Documents`
- [ ] "Recent Uploads" count matches uploads in the last 30 days
- [ ] "Pending Approval" count matches `ApprovalStatus = 'For Review'` for this user

---

## Section 10 — User: Archive List (UserArchiveListPanel)

### 10.1 Load Own Documents
- [ ] List shows only documents where `UploadedBy = SessionManager.Username`
- [ ] Documents from other users are not visible

### 10.2 Search
- [ ] Type in the search box → list filters live against Title/DocumentType

### 10.3 Delete Own Document
- [ ] Select a row, click Delete → `UserDeleteDocumentForm` opens
- [ ] Confirm → document is deleted and removed from the list
- [ ] Attempt to delete a document not owned by this user is blocked by the `AND UploadedBy = @sessionUsername` clause (cannot select it from the list in the first place)
- [ ] Activity log records: `"User deleted document: [DocumentCode]"`

---

## Section 11 — User: Upload Document (UserUploadDocumentPanel)

### 11.1 DocumentCode Auto-Generated
- [ ] Code field is pre-filled and read-only in `DOC-XXXX` sequential format

### 11.2 UploadedBy Locked
- [ ] "Uploaded By" field shows the current session username and is read-only

### 11.3 Required Field Validation
- [ ] Leave Title empty, click Upload → should show "Document title is required."

### 11.4 Image Size Limit
- [ ] Attach an image file larger than 5 MB → should show "Image file exceeds the 5 MB limit."

### 11.5 PDF Size Limit
- [ ] Attach a PDF larger than 50 MB → should show "PDF file exceeds the 50 MB limit."

### 11.6 Successful Upload
- [ ] Fill Title, select Document Type, optionally attach image/PDF → click Upload
- [ ] Should show "Document uploaded successfully!"
- [ ] Form resets with a new DocumentCode
- [ ] Document appears in UserArchiveListPanel
- [ ] Activity log records: `"User uploaded document: [Title]"`

### 11.7 Cancel / Reset
- [ ] Click Cancel → all fields reset, new DocumentCode generated

---

## Section 12 — User: Search Archive (UserSearchArchivePanel)

### 12.1 Load All Active Documents
- [ ] On load, all documents with `Status = 'Active'` are shown (not just the current user's)

### 12.2 Search
- [ ] Enter text in search → results filter on Title and DocumentType (live + button)
- [ ] Clear text → all active documents shown again

---

## Section 13 — User: View Profile (UserViewProfilePanel)

### 13.1 Load Real Profile
- [ ] Username and UserType fields are read-only and show real values
- [ ] SecurityQuestion and SecurityAnswer are pre-filled

### 13.2 Update Profile
- [ ] Change security question/answer → click Update → saved
- [ ] Enter new matching password → click Update → saved, can log in with new password
- [ ] Activity log records: `"User updated their profile."`

### 13.3 Cancel Discards Changes
- [ ] Make changes, click Cancel → reverts to saved values

### 13.4 Unsaved Navigation Warning
- [ ] Change a field, then click a sidebar button → dialog: "You have unsaved profile changes. Discard and leave?"

---

## Section 14 — User: Logout

### 14.1 Logout Flow
- [ ] Click Logout → confirmation dialog
- [ ] Confirm → session cleared, `LoginForm` shown
- [ ] Activity log records: `"User logged out."`

---

## Section 15 — Security Checks

### 15.1 Password Hashing
- [ ] Open SSMS and inspect `tbl_Users.PasswordHash` → values should start with `$2a$` (bcrypt format), NOT plain text

### 15.2 Input Sanitization
- [ ] Enter `<script>alert(1)</script>` in a text field and save → `<>` characters should be stripped
- [ ] Enter leading/trailing whitespace in any field → should be trimmed before saving

### 15.3 Connection String Not Hardcoded
- [ ] Open `dbconstring.vb` — no fallback connection string should be present
- [ ] Delete or rename `config.txt` → application should throw a clear error on start, not silently use a hardcoded string

### 15.4 No Duplicate Login Forms
- [ ] Confirm `AdminLoginForm.vb` and `UserLoginForm.vb` no longer exist in the project
- [ ] Only `LoginForm` is used as the entry point

---

## Section 16 — Data Access Layer (Repository Pattern)

### 16.1 No Direct SQL in Forms
- [ ] Grep the project for `SqlConnection` — should only appear in the three `DataAccess/` repository files and `dbconstring.vb`
- [ ] `Imports Microsoft.Data.SqlClient` should not appear in any form or panel file

### 16.2 Repository Exceptions Propagate Correctly
- [ ] Temporarily point `config.txt` to an invalid server → any panel that loads data should catch the exception and show a "Database Error" message, not crash silently

---

## Post-Test Checklist

- [ ] All Section 1–14 test cases passed
- [ ] All Section 15 security checks passed
- [ ] Section 16 DAL verification passed
- [ ] No unhandled exceptions observed during the full test run
- [ ] Activity log contains entries for every action tested (login, logout, CRUD, forgot password, profile update)
