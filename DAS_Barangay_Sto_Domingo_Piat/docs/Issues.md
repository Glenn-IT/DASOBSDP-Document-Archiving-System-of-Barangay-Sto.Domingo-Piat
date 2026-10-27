# System Issues & Enhancements Tracker

- [x] **1. Remove the image on the view function on the archive list it should be a preview of the pdf that is uploaded**
  - *Implemented in `UserDocumentViewForm.vb`: Removed `picBanner` and replaced with an embedded Microsoft Edge Chromium WebView2 PDF preview viewer with fallbacks and clean spacing to avoid text overlap.*

- [x] **3. Add print function on archive list (details including PDF shown on Chrome)**
  - *Implemented in `ReportHelper.PrintSingleDocumentReport()`: Generates printable HTML report containing complete document metadata, embedded PDF preview, action buttons, and official BLGU signatories; automatically launched in Google Chrome.*
  - *Added "Print Document" buttons in `AdminArchiveListPanel.vb`, `UserArchiveListPanel.vb`, and `UserDocumentViewForm.vb`.*

- [x] **4. Remove Document Type from sidebar menu & add Document Type filter to Archive List**
  - *Removed `btnDocumentTypes` from sidebars in `AdminDashboardForm` and `UserDashboardForm`.*
  - *Added `cmbDocTypeFilter` dropdown filter in both `AdminArchiveListPanel.vb` and `UserArchiveListPanel.vb`.*
  - *Updated `DocumentRepository.GetAll()` and `GetByUser()` to filter by `DocumentType`.*

- [x] **5. Add total number of docs below DataGridView on Archive List**
  - *Added dynamic `lblTotalDocs` beneath the DataGridView in `AdminArchiveListPanel`, `UserArchiveListPanel`, and `UserSearchArchivePanel`.*

- [x] **6. Add deactivation of account for users**
  - *Added `UpdateStatus` in `UserRepository.vb`.*
  - *Added `Deactivate / Activate` toggle button in `AdminUsersListPanel.vb` with confirmation dialogs, audit logging, and safeguards protecting the primary `admin` and current user accounts.*
  - *Added status indicator coloring (Green for Active, Red for Inactive).*

- [x] **7. Account Management: Add customizable security questions**
  - *Added `"[ + Write Custom Security Question... ]"` prompt and dynamic question handling in `AdminViewProfilePanel.vb` and `UserViewProfilePanel.vb`.*
  - *Updated `AdminForgotPasswordForm.vb` and `UserForgotPasswordForm.vb` to support stored custom questions.*

- [x] **8. Archive List: Add From and To DateTime filter**
  - *Added `dtpDateFrom`, `dtpDateTo`, and `chkFilterDate` range controls with a "Clear Filters" button in both `AdminArchiveListPanel.vb` and `UserArchiveListPanel.vb`.*
  - *Added date-range querying in `DocumentRepository.GetAll()` and `GetByUser()`.*

- [x] **11. Change Account Settings to Account Management**
  - *Renamed all UI button labels, window titles, dialogs, and System Manual references from "Account Settings" to "Account Management".*

- [x] **12. Clear inputted data on textboxes for Forgot Password**
  - *In `LoginForm.vb`: Clears username and password before and after opening Forgot Password.*
  - *In `AdminForgotPasswordForm.vb` and `UserForgotPasswordForm.vb`: Clears all fields (`txtUsernameField`, `txtSecurityAnswer`, `txtNewPassword`, `txtConfirmPassword`, `cmbSecurityQuestion`) on load, reset, and form close.*

- [x] **13. Add signatories function for all print output**
  - *Updated Master Document Archive Report with official 3-signature BLGU block (Records Custodian, Barangay Secretary, Hon. Punong Barangay).*
  - *Added 3-signature BLGU block to Single Document Print Reports in `ReportHelper.vb`.*
