# Bug Fix Log — DAS Barangay Sto. Domingo, Piat

---

## 2026-06-10

---

### BUG-001 — Multiple Login Forms After "Go Back to Login" (Forgot Password)
**Reported:** 2026-06-10  
**Fixed:** 2026-06-10  
**Files:** `AdminForgotPasswordForm.vb`, `UserForgotPasswordForm.vb`

**Issue:**  
Clicking "Forgot Password" then "Go Back to Login" caused two login forms to appear simultaneously.

**Root Cause:**  
`btnBackToLogin_Click` in both forgot password forms created a `New LoginForm()` and called `.Show()` on it. Meanwhile, `LoginForm.btnForgotPassword_Click` uses `ShowDialog()` and calls `Me.Show()` after the dialog closes — so two login forms appeared: the original re-shown one and the newly created one.

**Fix:**  
Removed the `New LoginForm()` creation in both `AdminForgotPasswordForm.btnBackToLogin_Click` and `UserForgotPasswordForm.btnBackToLogin_Click`. Both now simply call `Me.Close()`. The original `LoginForm` handles re-showing itself after `ShowDialog()` returns.

---

### BUG-002 — Multiple Login Forms After Successful Password Reset (Forgot Password)
**Reported:** 2026-06-10  
**Fixed:** 2026-06-10  
**Files:** `AdminForgotPasswordForm.vb`, `UserForgotPasswordForm.vb`

**Issue:**  
After successfully resetting a password via Forgot Password, two login forms appeared.

**Root Cause:**  
Same pattern as BUG-001 — `btnConfirm_Click` in both forgot password forms created a `New LoginForm()` after showing the success message, while the original `LoginForm` also re-showed itself.

**Fix:**  
Removed the `New LoginForm()` creation in `btnConfirm_Click` for both forms. Both now call `Me.Close()` after the success message. The original `LoginForm` re-shows itself automatically.

---

### BUG-003 — Forgot Password Only Recognized Admin Accounts
**Reported:** 2026-06-10  
**Fixed:** 2026-06-10  
**Files:** `AdminForgotPasswordForm.vb`

**Issue:**  
When a non-admin user entered their username in the Forgot Password form, it displayed "No admin account found with that username" and would not proceed.

**Root Cause:**  
`AdminForgotPasswordForm` hardcoded `UserType_Admin` in all database calls (`GetSecurityQuestion`, `ValidateSecurityAnswer`, `UpdatePassword`), so it only ever looked up admin accounts.

**Fix:**  
Added a `_detectedUserType As String` field. In `txtUsernameField_Leave`, the form now calls `UserRepository.GetByUsername()` (no type filter) to fetch the user's actual `UserType` and stores it in `_detectedUserType`. All subsequent calls (`ValidateSecurityAnswer`, `UpdatePassword`, `ActivityLogger.Log`) now use `_detectedUserType` instead of the hardcoded `UserType_Admin`. Error message updated from "No admin account found" to "No account found with that username."

---

### BUG-004 — Brute Force Lock Shows "Contact Administrator" with No Recovery
**Reported:** 2026-06-10  
**Fixed:** 2026-06-10  
**Files:** `LoginForm.vb`

**Issue:**  
After 5 failed login attempts, the login button was permanently disabled and the user was told to contact the administrator, with no way to retry without restarting the application.

**Root Cause:**  
`IncrementFailedAttempts` disabled `btnLogin` and showed a static message. There was no timer or mechanism to re-enable the button.

**Fix:**  
Added a `System.Windows.Forms.Timer` (`_lockoutTimer`) with a 1-second interval. After 5 failed attempts, the timer starts a 15-second countdown displayed on the button text (`"Please wait (15s)..."`). When the countdown reaches 0, the button is re-enabled with its original text (`"LOGIN"`) and the failed attempt count for that username is cleared, giving the user another chance. The `btnLogin_Click` early-exit check now silently returns while the timer is active (covering the Enter-key bypass path).

---

### BUG-005 — Multiple Login Forms After Logout
**Reported:** 2026-06-10  
**Fixed:** 2026-06-10  
**Files:** `AdminDashboardForm.vb`, `UserDashboardForm.vb`

**Issue:**  
After logging in and clicking Logout, two login forms appeared simultaneously.

**Root Cause:**  
Both `AdminDashboardForm.btnLogout_Click` and `UserDashboardForm.btnLogout_Click` created a `New LoginForm()` and called `.Show()` on logout. Meanwhile, `LoginForm.btnLogin_Click` uses `ShowDialog()` for the dashboard and calls `Me.Show()` after the dialog closes — resulting in two login forms.

**Fix:**  
Removed the `New LoginForm()` creation from the logout handler in both dashboard forms. Both now call only `Me.Close()` after clearing the session. The original `LoginForm` re-shows itself automatically when the dashboard dialog closes.

---

### BUG-006 — Forgot Password Revealed the Correct Security Question Directly
**Reported:** 2026-06-10  
**Fixed:** 2026-06-10  
**Files:** `AdminForgotPasswordForm.vb`, `UserForgotPasswordForm.vb`, `DataAccess\UserRepository.vb`

**Issue:**  
The Forgot Password form fetched and displayed only the user's stored security question in the dropdown, effectively revealing which question they chose. The user had no choice — only their one correct question was shown, bypassing the point of the security question picker.

**Root Cause:**  
`txtUsernameField_Leave` called `GetSecurityQuestion()` (or `GetByUsername()`) and loaded only the single stored question into `cmbSecurityQuestion`. `ValidateSecurityAnswer` also did not verify the selected question, only the answer.

**Fix:**  
- Both forgot password forms now load all 5 security questions into the combobox after confirming the username exists (no stored question is revealed).  
- The user must pick the correct question themselves and provide the matching answer.  
- `UserRepository.ValidateSecurityAnswer` updated to include `SecurityQuestion = @question` in the WHERE clause, so both the selected question AND the answer must match what's stored in the database.

---

### FEAT-001 — Login Success Welcome Messagebox
**Reported:** 2026-06-10  
**Fixed:** 2026-06-10  
**Files:** `LoginForm.vb`

**Request:**  
Show a messagebox after a successful login welcoming the user by name.

**Fix:**  
Added `MessageBox.Show($"Login successful! Welcome, {username}.", ...)` in `btnLogin_Click` after the activity log and before `Me.Hide()`.

---

### FEAT-002 — Upload Document Success Messagebox
**Reported:** 2026-06-10  
**Status:** Already implemented — no change needed.  
**Files:** `UserUploadDocumentPanel.vb`

**Note:**  
`btnUpload_Click` already shows `MessageBox.Show("Document uploaded successfully!", ...)` at line 104 after a successful insert.

---

### FEAT-003 — Search Archive View Button
**Reported:** 2026-06-10  
**Fixed:** 2026-06-10  
**Files:** `UserSearchArchivePanel.Designer.vb`, `UserSearchArchivePanel.vb`, `DataAccess\DocumentRepository.vb`, `UserDocumentViewForm.vb` (new)

**Request:**  
Add a View button to the Search Archive DataGridView so users can click to see the full contents and details of a document.

**Fix:**  
- `DocumentRepository.GetActive()` updated to also return `DocumentID` so each row can be identified.  
- `DocumentRepository.GetByIdFull()` added — fetches all document fields including `BannerImage`, `Description`, `DocumentType`, `UploadedBy`, `ApprovalStatus`, and `Status` by `DocumentID`.  
- `UserSearchArchivePanel.Designer.vb` updated: added hidden `colDocumentID` column (stores the PK) and a `DataGridViewButtonColumn` (`colView`) with text "View".  
- `UserSearchArchivePanel.vb` updated: `LoadDocumentsFromDB` populates the new columns; `dgvSearchResults_CellContentClick` handler added — on View click, fetches the full document record and opens `UserDocumentViewForm` as a modal dialog.  
- `UserDocumentViewForm.vb` created: a programmatically built modal form showing Document Code, Title, Type, Description, Uploaded By, Date Uploaded, Approval Status, Status, and the banner image (if set).

---

### FEAT-004 — View PDF from Search Archive
**Reported:** 2026-06-10
**Fixed:** 2026-06-10
**Files:** `DataAccess\DocumentRepository.vb`, `UserSearchArchivePanel.vb`, `UserDocumentViewForm.vb`

**Request:**
When viewing a document from Search Archive, also allow the user to open and read the attached PDF.

**Fix:**
- `DocumentRepository.GetByIdFull()` updated to also fetch `PDFFile` and `PDFFileName` columns.
- `UserSearchArchivePanel.CellContentClick` updated to extract `pdfBytes` and `pdfFileName` from the fetched row and pass them to `UserDocumentViewForm`.
- `UserDocumentViewForm` updated with `pdfBytes` and `pdfFileName` parameters. If a PDF is attached, a **View PDF** button appears alongside the Close button. Clicking it writes the bytes to a temp file and opens it with the system's default PDF viewer (`Process.Start` with `UseShellExecute = True`). If no PDF is attached, only the Close button is shown and the PDF File row displays "No PDF attached".
