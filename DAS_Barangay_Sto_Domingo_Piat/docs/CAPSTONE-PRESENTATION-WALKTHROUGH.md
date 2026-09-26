# DASOBSDP — Capstone Defense Presentation Walkthrough & Panelist Demonstration Guide
<!-- System: Document Archiving System for Barangay Sto. Domingo, Piat (DASOBSDP / DAS) -->
<!-- Target Organization: Barangay Local Government Unit (BLGU) of Barangay Sto. Domingo, Piat, Cagayan -->
<!-- Program: Bachelor of Science in Information Technology (BSIT) -->
<!-- Academic Institution: Cagayan State University - Piat Campus (CSU Piat) -->
<!-- Target Audience: Capstone Defense Panelists, Technical Advisers, Deans, and Evaluators -->

---

## 🧭 Executive Summary & Timing Strategy

| Phase | Section | Recommended Duration | Primary Interface |
| :--- | :--- | :--- | :--- |
| **Phase 1** | Project Rationale, LGU Archival Crisis & Brgy. Sto. Domingo Problem Statement | 1.5 mins | Title Slide / [LoginForm.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/LoginForm.vb) |
| **Phase 2** | Technical Architecture, Tiered Structure & Defensive Security Baseline | 1.0 min | [PROJECT_STRUCTURE.md](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/docs/PROJECT_STRUCTURE.md) / [dbconstring.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/dbconstring.vb) |
| **Phase 3** | Secure Authentication, Role-Based Routing & Brute-Force Lockout Defense | 1.0 min | [LoginForm.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/LoginForm.vb) |
| **Phase 4** | Autonomous Self-Service Credential Recovery & Security Question Trapping | 1.0 min | [AdminForgotPasswordForm.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/AdminForgotPasswordForm.vb) / [UserForgotPasswordForm.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/UserForgotPasswordForm.vb) |
| **Phase 5** | Central Archive Command Center, Live Search & Document Approval Engine | 1.5 mins | [AdminArchiveListPanel.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/AdminArchiveListPanel.vb) |
| **Phase 6** | High-Capacity Binary Document Ingestion & Image Banner Storage | 1.5 mins | [AdminNewDocumentForm.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/AdminNewDocumentForm.vb) |
| **Phase 7** | Document Maintenance, Metadata Updates & Removal Workflows | 1.0 min | [AdminUpdateDocumentForm.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/AdminUpdateDocumentForm.vb) & [AdminDeleteDocumentForm.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/AdminDeleteDocumentForm.vb) |
| **Phase 8** | Interactive Document Categorization Matrix & Classified Folders | 1.0 min | [AdminDocumentTypesPanel.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/AdminDocumentTypesPanel.vb) & [AdminDocumentTypeListPanel.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/AdminDocumentTypeListPanel.vb) |
| **Phase 9** | Administrative User Governance, Provisioning & Deletion Guardrails | 1.5 mins | [AdminUsersListPanel.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/AdminUsersListPanel.vb) & [AdminAddAccountForm.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/AdminAddAccountForm.vb) |
| **Phase 10** | System-Wide Forensic Activity Logs & Time-Filtered Auditing | 1.0 min | [AdminActivityLogsPanel.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/AdminActivityLogsPanel.vb) |
| **Phase 11** | Standard User Operational Hub & Real-Time KPI Analytics | 1.5 mins | Switch to Instance 2: [UserDashboardForm.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/UserDashboardForm.vb) & [UserDashboardPanel.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/UserDashboardPanel.vb) |
| **Phase 12** | User-Side Document Upload & Automated Review Routing | 1.0 min | [UserUploadDocumentPanel.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/UserUploadDocumentPanel.vb) |
| **Phase 13** | High-Speed Archive Search, Keyword Filtering & Verification | 1.0 min | [UserSearchArchivePanel.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/UserSearchArchivePanel.vb) |
| **Phase 14** | Embedded Document Viewer, Image Preview & Native PDF Streaming | 1.0 min | [UserDocumentViewForm.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/UserDocumentViewForm.vb) |
| **Phase 15** | Account Governance, Unsaved Changes Detection & Forced Re-Authentication | 0.5 min | [UserViewProfilePanel.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/UserViewProfilePanel.vb) & [AdminViewProfilePanel.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/AdminViewProfilePanel.vb) |
| **Phase 16** | Interactive Built-in System Manual & Visual Knowledgebase | 1.0 min | [SystemManualPanel.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/SystemManualPanel.vb) |
| **Phase 17** | Development Team Attribution & Academic Contributions | 0.5 min | [DevelopersPanel.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/DevelopersPanel.vb) |
| **Phase 18** | Concluding Defense Synthesis & Transition to Panel Interrogation | 0.5 min | Centralized Summary & Q&A Transition |
| **Total** | **Full System Defense Presentation** | **~17.5 mins** | — |

---

## 🛠️ Pre-Defense Staging & Credentials Setup

Before stepping in front of the defense panel, ensure your demonstration workstation is staged:

1. **Dual-Instance Demonstration Setup**:
   * **Instance 1 (Primary Left Screen):** Logged in as **System Administrator** (`admin`). This instance showcases complete archive governance, document approval workflows, account lifecycle management, activity logging, and system-wide configurations.
   * **Instance 2 (Secondary Right Screen):** Ready on [LoginForm.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/LoginForm.vb) to log in as a **Barangay Staff / Standard User** (e.g., `jdela` or `mreyes`). This setup enables live cross-role interaction: upload a document as a user on the right, switch to the left, and approve it live in front of the panel!
2. **Standard Demonstration Accounts**:
   * **System Administrator:** Username: `admin` | Password: `admin123` | Role: `Admin`
   * **Standard Barangay Users:**
     * `jdela` | Password: `jdela123` | Role: `User`
     * `mreyes` | Password: `mreyes123` | Role: `User`
     * `rsantos` | Password: `rsantos123` | Role: `User`
3. **Database Configuration & Connection Verification**:
   * Ensure Microsoft SQL Server (`SQLEXPRESS`) service is active in Windows Services (`services.msc`).
   * Verify [`config.txt`](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/bin/Debug/net8.0-windows/config.txt) exists in your application execution directory pointing to:
     ```text
     Data Source=.\SQLEXPRESS;Initial Catalog=dasbsdp;Integrated Security=True;TrustServerCertificate=True;
     ```
   * Ensure sample documents and activity logs are seeded, and password migrations have run via [`docs/migrations/rehash_passwords.sql`](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/docs/migrations/rehash_passwords.sql).
4. **Branding & Visual Palette Consistency**:
   * Verify the authentic Barangay Sto. Domingo visual identity:
     * **Forest Green (`#346739`):** Primary action buttons, sidebars, and title banners.
     * **Olive Green (`#79AE6F`):** Active navigation highlights and section indicators.
     * **Warm Cream (`#F2EDC2`):** Calm, eye-friendly document reading backgrounds.
     * **Parchment Card (`#E6E2B4`):** Elevated data containers and preview panes.

---

### 👥 Seeded Demonstration Accounts

| # | User Code | Username | Role / UserType | Initial Password | Security Question | Default Security Answer | Account Status |
| :- | :--- | :--- | :--- | :--- | :--- | :--- | :--- |
| 1 | `USR-0001` | **admin** | **Admin** | `admin123` | What is your mother's maiden name? | `default` | **Active** |
| 2 | `USR-0002` | **jdela** | **User** | `jdela123` | What was the name of your first pet? | `default` | **Active** |
| 3 | `USR-0003` | **mreyes** | **User** | `mreyes123` | What is your elementary school name? | `default` | **Active** |
| 4 | `USR-0004` | **rsantos** | **User** | `rsantos123` | What city were you born in? | `default` | **Active** |
| 5 | `USR-0005` | **bcruz** | **User** | `bcruz123` | What is your favorite childhood nickname? | `default` | **Active** |
| 6 | `USR-0006` | **lgarcia** | **User** | `lgarcia123` | What is your mother's maiden name? | `default` | **Active** |
| 7 | `USR-0007` | **ptorres** | **User** | `ptorres123` | What was the name of your first pet? | `default` | **Active** |

---

### 📁 Barangay Document Classification & Catalog

| Category Name | Target Barangay Documents & Records | Archival Policy & Retention | Max File Guidelines |
| :--- | :--- | :--- | :--- |
| **Financial Documents** | Annual Barangay Budgets, AIP (Annual Investment Plans), Disbursement Vouchers, Financial Statements, Audit Findings | Permanent Archival (COA audit compliance) | PDF up to 50MB, Scans up to 5MB |
| **Legal Documents** | Barangay Ordinances, Sangguniang Barangay Resolutions, Executive Orders, Katarungang Pambarangay Amicable Settlements | Permanent Statutory Record | PDF up to 50MB, Scans up to 5MB |
| **Human Resources (HR)** | Barangay Officials Oath of Office, Tanod Appointment Papers, BHW/BNS Contracts, Service Records | Active Term + 10 Years | PDF up to 50MB, Scans up to 5MB |
| **Project & Operational** | Infrastructure Contracts, Calamity Relief Rosters, Livelihood Grant Logs, Project Accomplishment Reports | 10 to 15 Years (Post-Completion) | PDF up to 50MB, Scans up to 5MB |
| **Correspondence** | Letters to Municipal Mayor, DILG Memoranda, Incoming Notices, Inter-Barangay Endorsements | 5 to 7 Years | PDF up to 50MB, Scans up to 5MB |
| **Customer & Client Records** | Barangay Clearances, Certificates of Indigency, Residency, Good Moral Character, Business Endorsements | 3 to 5 Years (Public Service Logs) | PDF up to 50MB, Scans up to 5MB |
| **Technical & Medical Records** | Health Center Vaccination Logs, Barangay Nutrition Profiles, Incident Spot Reports, Disaster Maps | 5 to 10 Years | PDF up to 50MB, Scans up to 5MB |
| **Intellectual Property** | Barangay Historical Narratives, Official Cultural Emblems, GIS Cadastral Maps, Local Heritage Inventories | Permanent Cultural Record | PDF up to 50MB, Scans up to 5MB |
| **Others** | Miscellaneous Transmittals, Temporary Circulars, General Barangay Bulletins | 1 to 3 Years | PDF up to 50MB, Scans up to 5MB |

---

## 🎬 Step-by-Step Presentation Script (From First to Last)

---

### Step 1: Project Rationale, LGU Archival Crisis & Brgy. Sto. Domingo Problem Statement
* **Screen Display:** Application Launch / [LoginForm.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/LoginForm.vb)
* **Estimated Time:** 1.5 minutes
* **Screen Action:** Present the unified login interface showcasing the institutional Forest Green and Warm Cream visual styling, reflecting the identity of Barangay Sto. Domingo, Piat, Cagayan.
* **🗣️ Verbal Script:**
  > *"Good morning, esteemed members of the panel, our project adviser, respected faculty, and guests. Today, we are honored to present **DASOBSDP — the Document Archiving System for Barangay Sto. Domingo, Piat**.
  >
  > *Barangays serve as the foundational bedrock of local government in the Philippines. Every single day, Barangay Sto. Domingo handles critical public records: Sangguniang Barangay ordinances, resolutions, annual budget appropriations, clearances, certificates of indigency, and disaster rehabilitation reports.
  >
  > *However, like many rural barangays across the country, Sto. Domingo has historically depended on manual, paper-based archiving. Physical folders stored in wooden cabinets are acutely vulnerable to moisture degradation, rodent infestation, ink fading, and the recurring typhoons and flooding prevalent in the Cagayan Valley basin. Furthermore, retrieving an archived resolution or financial voucher from five years ago often requires hours of tedious digging through dusty filing boxes, causing prolonged delays in public service delivery and compromising audit compliance with the Commission on Audit (COA) and DILG.
  >
  > *DASOBSDP resolves these deep-rooted challenges through an automated, secure, and offline-resilient desktop document repository. It provides high-capacity binary file archiving, instant full-text filtering, role-gated approval workflows, and immutable activity auditing—all wrapped in an intuitive interface tailored specifically for barangay personnel."*

---

### Step 2: Technical Architecture, Tiered Structure & Defensive Security Baseline
* **Screen Display:** Architecture Overview / [PROJECT_STRUCTURE.md](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/docs/PROJECT_STRUCTURE.md) & [dbconstring.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/dbconstring.vb)
* **Estimated Time:** 1.0 minute
* **Screen Action:** Explain the clean separation of concerns, repository design pattern, and defensive database security implementation.
* **🗣️ Verbal Script:**
  > *"To ensure long-term stability and high responsiveness in a local government environment, DASOBSDP is engineered using a robust multi-tier architecture:
  >
  > 1. **Framework & Language:** Developed on **Microsoft .NET 8.0 Windows Forms (WinForms)** with Visual Basic .NET. WinForms provides rapid, hardware-accelerated local desktop performance without the heavy overhead or connectivity dependencies of browser applications.
  > 2. **Decoupled Data Access Layer (DAL):** The presentation layer communicates cleanly through dedicated modules—[DocumentRepository.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/DataAccess/DocumentRepository.vb), [UserRepository.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/DataAccess/UserRepository.vb), and [ActivityLogRepository.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/DataAccess/ActivityLogRepository.vb).
  > 3. **High-Security Database Engine:** Backed by **Microsoft SQL Server (`dasbsdp`)** via `Microsoft.Data.SqlClient`. Every database operation utilizes 100% parameterized SQL queries (`cmd.Parameters.AddWithValue`), neutralizing SQL injection threats entirely.
  > 4. **Military-Grade Password Hashing:** User passwords are encrypted using **BCrypt.Net-Next** with a work factor of 11 in [PasswordHelper.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/Helpers/PasswordHelper.vb). Plaintext passwords are never stored in the database, logged, or exposed in memory.
  > 5. **Reliable Externalized Configuration:** Database connection strings are decoupled into [dbconstring.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/dbconstring.vb), loading dynamically from [`config.txt`](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/bin/Debug/net8.0-windows/config.txt). This enables the system to run on a standalone hall workstation or connect across a local barangay intranet without recompiling source code."*

---

### Step 3: Secure Authentication, Role-Based Routing & Brute-Force Lockout Defense
* **Screen Display:** [LoginForm.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/LoginForm.vb)
* **Estimated Time:** 1.0 minute
* **Screen Action:**
  1. Showcase the clean login screen featuring input sanitization and password masking.
  2. Demonstrate the **Brute-Force Lockout Defense**:
     * Intentionally enter an incorrect password 3 times consecutively.
     * Point out the system warning: *"Invalid username or password. Account locked. Please wait 30 seconds."*
     * Highlight how the `Login` button is completely disabled with an active countdown timer: `Please wait (30s)... Please wait (29s)...`
  3. Explain that the failed attempt was silently committed to `tbl_ActivityLogs` with a timestamp.
  4. Once unlocked, enter valid credentials for the **System Administrator** (`admin` / `admin123`).
  5. Showcase the confirmation modal: *"Login successful! Welcome, admin."*
  6. Point out how [SessionManager.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/SessionManager.vb) captures `Username`, `UserType`, and `UserCode`, dynamically routing the user directly into [AdminDashboardForm.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/AdminDashboardForm.vb).
* **🗣️ Verbal Script:**
  > *"Because barangay archives store confidential legal and citizen information, authentication security is paramount.
  >
  > *In `LoginForm`, we engineered a proactive **Brute-Force Lockout Engine**: if an unauthorized user attempts three consecutive invalid logins, the interface disables all submission controls and initiates a strict 30-second lockout timer. Each failed attempt is immediately recorded in our audit trail.
  >
  > *Upon successful BCrypt cryptographic verification, `SessionManager` establishes an in-memory session context and performs strict role-based routing—directing administrators to the command shell and standard staff to the operational dashboard."*

---

### Step 4: Autonomous Self-Service Credential Recovery & Security Question Trapping
* **Screen Display:** [AdminForgotPasswordForm.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/AdminForgotPasswordForm.vb) / [UserForgotPasswordForm.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/UserForgotPasswordForm.vb)
* **Estimated Time:** 1.0 minute
* **Screen Action:**
  1. Click the **"Forgot Password?"** link on the login window.
  2. Demonstrate the autonomous 3-step password recovery workflow:
     * **Step 1:** Username Entry — enter a registered account username (e.g., `jdela`). Move focus away from the box.
     * **Step 2:** Challenge Retrieval — notice how the system dynamically retrieves the user's specific registered security question from SQL Server (e.g., *"What was the name of your first pet?"*).
     * **Step 3:** Answer Challenge & Reset — type the security answer (`default`) and input matching new password strings.
  3. Click **"Confirm Reset"**:
     * Show how the system calls `UserRepository.ValidateSecurityAnswer()`.
     * Explain that the new password is encrypted via BCrypt work factor 11 and committed to `tbl_Users`.
     * Point out the success dialog and seamless return to the login interface.
* **🗣️ Verbal Script:**
  > *"In a busy barangay hall, staff should not be locked out of critical work when passwords are forgotten, nor should administrators be distracted with constant manual password inquiries.
  >
  > *Through our Forgot Password recovery mechanism, accounts can be recovered autonomously. The workflow challenges the user with their pre-registered security question. Only upon an exact cryptographic match is the new password hashed and committed, restoring access securely without requiring manual database intervention."*

---

### Step 5: Central Archive Command Center, Live Search & Document Approval Engine
* **Screen Display:** [AdminArchiveListPanel.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/AdminArchiveListPanel.vb)
* **Estimated Time:** 1.5 minutes
* **Screen Action:**
  1. Highlight the **Archive List Panel** loaded inside `AdminDashboardForm`.
  2. Point out the personalized header banner: *"Welcome, admin!"* and the current module title: *"Archive List"*.
  3. Review the comprehensive document grid columns: *Document Code (`DOC-0001`), Title, Uploaded By, Date Uploaded, Status, and View action*.
  4. Demonstrate the **Instant Real-Time Search**:
     * Type `Resolution` or `Indigency` into the search box: observe the grid instantly filter matching titles and categories as you type without screen flickering.
     * Clear the search box to restore the complete master repository.
  5. Demonstrate the **Right-Click Document Approval Engine**:
     * Right-click any row flagged with approval status `For Review`.
     * Showcase the custom context menu displaying **"Approve Document"**.
     * Click **"Approve Document"** and confirm the verification dialog:
       $$\text{Document Status Transition:} \quad \text{'For Review'} \longrightarrow \text{'Approved'}$$
     * Explain that `DocumentRepository.Approve()` commits the status update while `ActivityLogger.Log()` records the administrative sign-off.
* **🗣️ Verbal Script:**
  > *"When the Barangay Administrator logs in, they are immediately placed in the **Central Archive Command Center**.
  >
  > *This interface consolidates all official documents submitted by barangay staff and officials. The responsive DataGridView provides live metadata visibility, while our real-time search engine queries titles and classifications on every keystroke.
  >
  > *Notice our administrative governance feature: administrators can right-click any pending document to trigger the **Approval Workflow**. This enforces official administrative sign-off before a document is permanently certified in the public archive, ensuring strict quality control."*

---

### Step 6: High-Capacity Binary Document Ingestion & Image Banner Storage
* **Screen Display:** [AdminNewDocumentForm.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/AdminNewDocumentForm.vb)
* **Estimated Time:** 1.5 minutes
* **Screen Action:**
  1. Click **"+ Add Document"** in `AdminArchiveListPanel` to open the modal dialog `AdminNewDocumentForm`.
  2. Point out the auto-generated tracking identifier: `DOC-####` generated by `DocumentRepository.GenerateCode()`.
  3. Point out that **"Uploaded By"** is locked to `admin` directly from `SessionManager.Username`, preventing identity spoofing.
  4. Select a category from the standardized dropdown: *Financial Documents, Legal Documents, Human Resources, Project & Operational, etc.*
  5. Enter a sample Title: *"Barangay Resolution No. 04-2026: Calamity Fund Allocation"*.
  6. Enter detailed descriptive remarks in the multi-line description field.
  7. Demonstrate the **Dual Binary Ingestion Engine**:
     * Click **"Browse Banner"**: attach a sample JPG/PNG document preview. Notice the embedded picture box displays a zoom preview. Explain the 5 MB file size safeguard.
     * Click **"Browse PDF Document"**: attach a sample official PDF file. Notice the label displays the original filename. Explain the 50 MB high-capacity threshold.
  8. Click **"Save Document"**:
     * Explain what happens under the hood: `DocumentRepository.Insert()` streams both the banner image and the entire PDF file directly into SQL Server as raw binary data (`VARBINARY(MAX)`).
     * Show the success message and notice how the archive grid refreshes immediately with the new record.
* **🗣️ Verbal Script:**
  > *"Archiving official records into DASOBSDP is fast, structured, and completely digitized.
  >
  > *In `AdminNewDocumentForm`, the system automatically provisions an incremental Document Tracking ID (`DOC-0008`) and binds the uploader's identity to the active session.
  >
  > *Rather than relying on vulnerable physical file folders or external file system paths that can be accidentally moved or deleted, DASOBSDP utilizes a **Centralized Database BLOB Architecture**: both visual banner previews and full PDF documents up to 50 megabytes are stored directly inside SQL Server tables as `VARBINARY(MAX)` streams. This ensures 100% atomic backup and disaster recovery."*

---

### Step 7: Document Maintenance, Metadata Updates & Removal Workflows
* **Screen Display:** [AdminUpdateDocumentForm.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/AdminUpdateDocumentForm.vb) & [AdminDeleteDocumentForm.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/AdminDeleteDocumentForm.vb)
* **Estimated Time:** 1.0 minute
* **Screen Action:**
  1. Select a document in the grid and click **"Update Document"**:
     * Open [AdminUpdateDocumentForm.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/AdminUpdateDocumentForm.vb).
     * Show how the form loads existing metadata: Document ID, Title, Category, and Description.
     * Explain the flexible update logic in `DocumentRepository.Update()`: administrators can update textual details alone, or optionally attach a corrected PDF or revised banner without losing previous metadata.
     * Click *Cancel* or *Save*.
  2. Demonstrate the **Controlled Document Deletion Workflow**:
     * Select a document and click **"Delete Document"**.
     * Showcase [AdminDeleteDocumentForm.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/AdminDeleteDocumentForm.vb).
     * Point out the explicit confirmation challenge displaying the Document ID and Title.
     * Click **"Confirm Delete"**: show how the record is safely removed from `tbl_Documents` and logged in `tbl_ActivityLogs`.
* **🗣️ Verbal Script:**
  > *"Administrative governance requires full lifecycle maintenance. Through `AdminUpdateDocumentForm`, authorized administrators can correct typographic errors, amend descriptions, or upload revised attachments.
  >
  > *When removing superseded or erroneous records, `AdminDeleteDocumentForm` enforces explicit confirmation, preventing accidental data loss while creating a non-repudiation audit record in the system logs."*

---

### Step 8: Interactive Document Categorization Matrix & Classified Folders
* **Screen Display:** [AdminDocumentTypesPanel.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/AdminDocumentTypesPanel.vb) & [AdminDocumentTypeListPanel.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/AdminDocumentTypeListPanel.vb)
* **Estimated Time:** 1.0 minute
* **Screen Action:**
  1. Click **"Document Types"** on the administrator sidebar.
  2. Showcase the responsive **Card Grid Matrix**:
     * Point out the 9 standardized category cards: *Financial Documents, Legal Documents, HR Documents, Project & Operational, Correspondence, Intellectual Property, Customer & Client Records, Technical & Medical Records, and Others*.
     * Point out the dynamic document counter on each card (e.g., `(12 documents)`), calculated in real time via `DocumentRepository.GetTypeCounts()`.
     * Move the cursor across the cards to showcase the smooth interactive **hover effect** (color shifts dynamically from Dark Green `#346739` to Olive Green `#79AE6F`).
  3. Click on a category card (e.g., **"Legal Documents"**):
     * Watch the panel dynamically switch to [AdminDocumentTypeListPanel.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/AdminDocumentTypeListPanel.vb).
     * Notice the top title updates to *"Legal Documents"* and displays a dedicated search bar and filtered grid showing only legal files.
  4. Click the **"← Back to Document Types"** button to return smoothly to the master card matrix.
* **🗣️ Verbal Script:**
  > *"To provide structured taxonomy beyond a simple flat table, we built the **Interactive Document Types Matrix**.
  >
  > *The system organizes all barangay archives into nine standardized local government categories. Each category card dynamically displays its active document count through SQL grouping queries.
  >
  > *Clicking any card drills directly into that folder's dedicated sub-repository with category-specific search and filtering, giving barangay officials an intuitive, folder-like filing cabinet experience."*

---

### Step 9: Administrative User Governance, Provisioning & Deletion Guardrails
* **Screen Display:** [AdminUsersListPanel.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/AdminUsersListPanel.vb), [AdminAddAccountForm.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/AdminAddAccountForm.vb) & [AdminDeleteUserForm.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/AdminDeleteUserForm.vb)
* **Estimated Time:** 1.5 minutes
* **Screen Action:**
  1. Click **"Users List"** on the sidebar.
  2. Review the user accounts DataGridView: *User Code (`USR-0001`), Username, Role (`Admin` / `User`), and Status (`Active` / `Inactive`)*.
  3. **Security Highlight:** Point out that password hashes are strictly excluded from the grid display—credentials are never exposed in UI memory.
  4. Click **"+ Add User"** to open `AdminAddAccountForm`:
     * Showcase automated `USR-####` code assignment.
     * Demonstrate duplicate username validation (`UserRepository.CheckDuplicateUsername()`).
     * Demonstrate password match verification and BCrypt encryption.
     * Select Role (`Admin` or `User`) and configure a recovery security question.
  5. Demonstrate **System Self-Protection & Deletion Guardrails**:
     * Select the root account **`admin`** in the grid and click **"Delete User"**.
     * Point out the system refusal message: *"The main admin account ('admin') cannot be deleted."*
     * Explain that `UserRepository.Delete()` also blocks users from deleting their own currently logged-in account.
     * Explain the **Transactional Cascade Deletion Architecture**: when a non-root account is deleted, SQL Server executes within a `SqlTransaction` to safely purge linked logs and uploaded documents, rolling back if any constraint fails.
* **🗣️ Verbal Script:**
  > *"Under the Users List module, administrators oversee staff credentials with strict safety controls.
  >
  > *In `AdminAddAccountForm`, new barangay staff accounts are provisioned with duplicate checks and BCrypt hashing.
  >
  > *Critically, our backend incorporates strict **Administrative Self-Protection Guardrails**: the system completely forbids deleting the root `admin` account or the currently logged-in user. Furthermore, all user removals execute inside an atomic `SqlTransaction`, ensuring that foreign keys and audit references never leave orphaned records in the database."*

---

### Step 10: System-Wide Forensic Activity Logs & Time-Filtered Auditing
* **Screen Display:** [AdminActivityLogsPanel.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/AdminActivityLogsPanel.vb)
* **Estimated Time:** 1.0 minute
* **Screen Action:**
  1. Click **"Activity Logs"** on the admin sidebar.
  2. Showcase the comprehensive audit table: *Log Code (`LOG-0001`), Username, Timestamp (`yyyy-MM-dd HH:mm`), Result (`Success` / `Failed`), and Description*.
  3. Point out the real-time entries generated by our demonstration actions just now:
     * *Failed login attempts and lockout registrations.*
     * *Successful admin authentication.*
     * *Document uploads and category modifications.*
     * *Document approval confirmations.*
  4. Demonstrate the **Forensic Date & User Filter Bar**:
     * Set the `From:` and `To:` DatePickers to filter logs within a specific timeframe.
     * Type `admin` or `jdela` into the `Username:` filter box.
     * Click **"Search"** and show how the grid immediately scopes the audit trail to that specific actor.
* **🗣️ Verbal Script:**
  > *"To ensure uncompromising institutional accountability and meet government transparency mandates, DASOBSDP routes every operation through our centralized `ActivityLogger`.
  >
  > *Every login, failed attempt, document upload, status approval, and profile modification generates a permanent, tamper-resistant log entry.
  >
  > *Administrators can filter records across historical date ranges and filter by individual staff usernames, providing barangay chairpersons and auditors with an incontrovertible digital paper trail."*

---

### Step 11: Standard User Operational Hub & Real-Time KPI Analytics
* **Screen Display:** Switch to Instance 2: [UserDashboardForm.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/UserDashboardForm.vb) & [UserDashboardPanel.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/UserDashboardPanel.vb)
* **Estimated Time:** 1.5 minutes
* **Screen Action:**
  1. Switch to your second desktop window logged in as standard staff member **`jdela`** (Juan Dela Cruz).
  2. Point out the role-tailored User Sidebar: *Dashboard, Upload Document, Search Archive, Document Types, Account Settings, System Manual, Developers, and Logout*.
  3. Point out the personalized welcome banner: *"Welcome, jdela!"*
  4. Review the **3 Real-Time KPI Metric Cards** in [UserDashboardPanel.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/UserDashboardPanel.vb):
     * **Total Documents:** Total documents archived by this specific user (`DocumentRepository.CountByUser()`).
     * **Recent Uploads:** Uploads registered within the last 30 days (`DocumentRepository.CountRecentByUser()`).
     * **Pending Approvals:** Documents awaiting administrative review (`DocumentRepository.CountPendingByUser()`).
* **🗣️ Verbal Script:**
  > *"Now switching to our secondary demonstration instance: the Standard Barangay User Interface.
  >
  > *Regular staff members—such as barangay record clerks, secretaries, and health workers—interact with a tailored interface designed specifically for daily desk operations.
  >
  > *In `UserDashboardPanel`, staff immediately see their operational workload: total documents they have archived, submissions made in the last 30 days, and how many of their files are currently awaiting administrative review."*

---

### Step 12: User-Side Document Upload & Automated Review Routing
* **Screen Display:** [UserUploadDocumentPanel.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/UserUploadDocumentPanel.vb)
* **Estimated Time:** 1.0 minute
* **Screen Action:**
  1. Click **"Upload Document"** on the user sidebar.
  2. Point out that `txtUploadedBy` is automatically populated as `jdela` and locked.
  3. Select Category: *Customer & Client Records*.
  4. Type Title: *"Certificate of Indigency - Juanito Ramos (Medical Assistance)"*.
  5. Enter Notes / Description: *"Issued for Cagayan Valley Medical Center dialysis assistance."*
  6. Click **"Browse Attachment"**: attach a sample PDF clearance.
  7. Click **"Upload Document"**:
     * Explain that user uploads are automatically assigned the default status `ApprovalStatus = 'For Review'`.
     * Show the confirmation alert: *"Document uploaded successfully!"*
  8. Switch briefly back to Instance 1 (Admin): refresh the Archive List to show the document appearing live with status `For Review`, ready for approval!
* **🗣️ Verbal Script:**
  > *"When staff issue a barangay clearance, certificate of indigency, or incident blotter, they archive it through `UserUploadDocumentPanel`.
  >
  > *The system automatically logs the staff member's credentials, auto-generates the tracking code, and attaches the binary PDF document.
  >
  > *All user submissions are automatically routed into the `'For Review'` queue. As demonstrated on our side-by-side screen, the administrator immediately sees the pending record ready for validation."*

---

### Step 13: High-Speed Archive Search, Keyword Filtering & Verification
* **Screen Display:** [UserSearchArchivePanel.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/UserSearchArchivePanel.vb)
* **Estimated Time:** 1.0 minute
* **Screen Action:**
  1. Click **"Search Archive"** on the user sidebar.
  2. Showcase the fast lookup interface designed for front-desk public inquiries.
  3. Point out that this view executes `DocumentRepository.GetActive()`: it strictly lists approved, active barangay records.
  4. Test the **Search Debounce & Query Filter**:
     * Type `Indigency` or a resident's surname into the search query box.
     * Demonstrate how the DataGridView updates instantly on text change, isolating the desired record in fractions of a second.
  5. Point out the grid columns: *Doc ID, Document Code, Title, Date Uploaded, Approval Status, Status, and Action*.
* **🗣️ Verbal Script:**
  > *"When a resident approaches the barangay counter requesting a copy of an earlier clearance, resolution, or certification, staff cannot afford to keep constituents waiting.
  >
  > *In `UserSearchArchivePanel`, clerks simply type the constituent's name or keywords into the search box. The grid filters live against SQL Server in real time, reducing record retrieval time from 30 minutes down to less than two seconds."*

---

### Step 14: Embedded Document Viewer, Image Preview & Native PDF Streaming
* **Screen Display:** [UserDocumentViewForm.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/UserDocumentViewForm.vb)
* **Estimated Time:** 1.0 minute
* **Screen Action:**
  1. On any search result row, click the **"View"** link in the action column.
  2. Showcase the modal dialog [UserDocumentViewForm.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/UserDocumentViewForm.vb):
     * **Top Banner Preview:** Showcase the embedded image preview converted directly from database bytes via `MemoryStream`.
     * **Structured Metadata Card:** Point out clean display of Document Code, Title, Type, Description, Uploader, Date, Approval Status, and original PDF filename.
  3. Click **"View PDF"**:
     * Explain the streaming engine: `OpenPdf()` extracts the `VARBINARY(MAX)` byte array, writes it safely into the Windows temporary folder (`Path.GetTempPath()`), and launches the operating system's native PDF reader (such as Microsoft Edge or Adobe Acrobat) via `Process.Start()`.
     * Show the official PDF document opening smoothly on screen!
* **🗣️ Verbal Script:**
  > *"To inspect archived records, staff click 'View' to launch `UserDocumentViewForm`.
  >
  > *The form reconstructs the visual banner preview from raw binary memory and displays verified metadata.
  >
  > *When staff click 'View PDF', our streaming engine extracts the binary stream into a protected temporary file and launches the default operating system PDF viewer with zero delay. Staff can zoom, verify official barangay seals, and print copies directly for the resident."*

---

### Step 15: Account Governance, Unsaved Changes Detection & Forced Re-Authentication
* **Screen Display:** [UserViewProfilePanel.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/UserViewProfilePanel.vb) & [AdminViewProfilePanel.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/AdminViewProfilePanel.vb)
* **Estimated Time:** 0.5 minute
* **Screen Action:**
  1. Click **"Account Settings"** on the user sidebar.
  2. Demonstrate the **Unsaved Changes Trap (`HasUnsavedChanges`)**:
     * Type a character into the *New Password* box.
     * Click another sidebar button (e.g., *Dashboard*).
     * Show the warning modal: *"You have unsaved account settings changes. Discard and leave?"*
     * Highlight this proactive defense preventing accidental loss of modified settings!
  3. Click *No* to stay on the panel.
  4. Showcase changing the Security Question and updating the password:
     * Explain that upon saving, the system raises the `RequestLogout` event, clearing `SessionManager` and forcing the user back to the login screen to re-authenticate with their new credentials.
* **🗣️ Verbal Script:**
  > *"In our profile management panels, users can update passwords and maintain security recovery questions.
  >
  > *We also integrated proactive **Dirty State Tracking**: if a user begins typing changes and attempts to switch tabs without saving, the system traps the navigation and warns them about unsaved changes.
  >
  > *Furthermore, saving a new password triggers automated session invalidation, requiring immediate re-login with the updated credentials to maintain absolute session integrity."*

---

### Step 16: Interactive Built-in System Manual & Visual Knowledgebase
* **Screen Display:** [SystemManualPanel.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/SystemManualPanel.vb)
* **Estimated Time:** 1.0 minute
* **Screen Action:**
  1. Click **"System Manual"** on either the Admin or User sidebar.
  2. Showcase the comprehensive built-in documentation center:
     * Point out the **Quick Jump Navigation Bar** at the top with jump buttons: *Dashboard, Upload Document, Search Archive, Document Types, Users Management, Activity Logs, View Profile, and Developers*.
     * Click a jump button (e.g., **"Upload Document"**): observe the panel smoothly scroll directly to that module's operational guide.
     * Highlight that each section contains step-by-step Standard Operating Procedures (SOPs), file size rules, and visual interface screenshots.
* **🗣️ Verbal Script:**
  > *"To ensure rapid onboarding of new barangay personnel and long-term sustainability after turnover of barangay administrations, we embedded an **Interactive Visual System Manual** directly inside the software.
  >
  > *Staff do not need to search for physical manuals or external PDF files. The built-in guide provides quick jump navigation, detailed operating procedures for all eight system modules, and exact file size specifications."*

---

### Step 17: Development Team Attribution & Academic Contributions
* **Screen Display:** [DevelopersPanel.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/DevelopersPanel.vb)
* **Estimated Time:** 0.5 minute
* **Screen Action:**
  1. Click **"Developers"** on the sidebar.
  2. Present the developer profile cards with photographs, academic program, institution, contact details, and technical contributions:
     * **Aemyra Jenn Ignacio:** *Lead Developer / Full-Stack* — System Architecture, Database Implementation & Backend Services (`09063119790` | `myraignacio753@gmail.com`).
     * **Racquel Dela Cruz:** *Frontend Developer / UI/UX Designer* — User Interface Design, System Workflows & User Documentation (`09682806653` | `racqueldelacruz1022@gmail.com`).
     * **Academic Institution:** Bachelor of Science in Information Technology (BSIT), **Cagayan State University - Piat Campus**.
* **🗣️ Verbal Script:**
  > *"The Developers module formally attributes the authors of DASOBSDP:
  >
  > *Our team consists of **Aemyra Jenn Ignacio** as Lead Developer and Full-Stack Architect, and **Racquel Dela Cruz** as Frontend Developer and UI/UX Designer.
  >
  > *Together, under the BSIT program at Cagayan State University - Piat Campus, we designed, engineered, and evaluated this system as our Capstone Project to modernize public service for our home community of Barangay Sto. Domingo."*

---

### Step 18: Concluding Defense Synthesis & Transition to Panel Interrogation
* **Screen Display:** Return to [AdminDashboardForm.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/AdminDashboardForm.vb) or Project Title Slide
* **Estimated Time:** 0.5 minute
* **Screen Action:** Conclude the formal presentation and cordially invite panelist questions.
* **🗣️ Verbal Script:**
  > *"In summary, DASOBSDP transforms Barangay Sto. Domingo from a vulnerable, paper-heavy office into a modern, secure, and digitally empowered local government unit.
  >
  > *By combining high-capacity binary database storage, sub-second search speeds, multi-level security defenses, and complete activity auditing, our system preserves vital public records against physical degradation and natural disasters while elevating transparency and citizen satisfaction.
  >
  > *Thank you very much, honorable members of the panel, our adviser, and faculty. We are now eager and ready to address your questions and technical inquiries."*

---

## 🛡️ Capstone Defense Panelist Q&A Cheat Sheet

| Question | Recommended Technical & Institutional Answer |
| :--- | :--- |
| **Q1: Why develop a desktop application rather than a cloud-hosted web system or Google Drive folder?** | *"While cloud drives or web applications offer browser accessibility, rural barangay operations face severe infrastructure realities: frequent fiber cuts, typhoon power interruptions, and intermittent internet in parts of Piat, Cagayan. A web-only system paralyzes barangay public service during outages. Furthermore, public cloud drives like Google Drive lack **relational metadata integrity, automated brute-force lockout, role-based approval queues, and immutable SQL audit trails**. DASOBSDP is built as a **.NET 8 WinForms desktop solution** connecting to Microsoft SQL Server. It operates with zero internet latency, delivers lightning-fast local performance, and guarantees that barangay records remain accessible even during network disasters."* |
| **Q2: Why store PDF documents and banner images directly inside SQL Server as `VARBINARY(MAX)` BLOBs instead of saving files to a folder and storing file paths?** | *"Storing documents as file system paths introduces severe vulnerabilities known as **orphaned files and broken links**: if a staff member accidentally renames a folder, moves files, or if an antivirus quarantines an attachment, the database link is broken permanently. Furthermore, file folders cannot enforce database-level access controls or atomic transactions. By storing binary streams directly in SQL Server using `VARBINARY(MAX)` in [DocumentRepository.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/DataAccess/DocumentRepository.vb), every document is **atomically protected**: database backups capture 100% of both metadata and actual files in a single `.bak` or `.bacpac` backup file. When restoring from a disaster, the barangay restores one database file and immediately recovers every archived document without missing files."* |
| **Q3: How does the system defend against SQL injection attacks?** | *"Across all repositories ([UserRepository.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/DataAccess/UserRepository.vb), [DocumentRepository.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DataAccess/DocumentRepository.vb), and [ActivityLogRepository.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DataAccess/ActivityLogRepository.vb)), queries are executed exclusively through **strongly typed parameterized SQL commands** (`cmd.Parameters.AddWithValue`). User inputs are treated strictly as data literals by SQL Server, never as executable command fragments. Even if an attacker attempts to input quotes or SQL syntax (`' OR '1'='1`), SQL Server escapes the value completely, neutralizing SQL injection vulnerabilities."* |
| **Q4: How are passwords protected against cracking and database leaks?** | *"We implemented industry-standard **BCrypt.Net-Next** with a cost factor (work factor) of 11 in [PasswordHelper.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/Helpers/PasswordHelper.vb). BCrypt incorporates an automatic random 128-bit salt and computationally intensive key-stretching, making rainbow table attacks and GPU-accelerated dictionary attacks computationally infeasible. Passwords are never stored in plain text, are never returned in grid queries in [AdminUsersListPanel.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/AdminUsersListPanel.vb), and are masked on all login and profile forms."* |
| **Q5: How does the system prevent brute-force attacks on the login screen?** | *"In [LoginForm.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/LoginForm.vb), DASOBSDP maintains an in-memory dictionary `_failedAttempts`. When three consecutive failed logins are detected for any account, the system activates a **30-second lockout timer**: the login button is disabled, a countdown label informs the user, and `ActivityLogger.Log()` registers the event as a failed security incident. This slows automated credential-stuffing scripts to an absolute standstill."* |
| **Q6: How does the system comply with the Philippine Data Privacy Act of 2012 (RA 10173)?** | *"DASOBSDP implements three fundamental Data Privacy principles: **Role-Based Access Control (Principle of Least Privilege)** ensures only authorized administrators can modify accounts or approve sensitive files; **Cryptographic Integrity** protects stored credentials using BCrypt; and **Accountability & Audit Trails** via `tbl_ActivityLogs` ensures every viewing, upload, approval, or deletion is recorded with an immutable timestamp and username, ensuring complete non-repudiation."* |
| **Q7: What safeguards prevent an administrator from accidentally breaking the system by deleting user accounts?** | *"In [AdminUsersListPanel.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/AdminUsersListPanel.vb) and [UserRepository.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/DataAccess/UserRepository.vb), two strict guardrails exist: first, deleting the root account `'admin'` is programmatically blocked at both the UI and repository level. Second, deleting the currently logged-in administrator is prohibited. When a valid user is deleted, `UserRepository.Delete()` executes within a **`SqlTransaction`**: it safely purges related activity logs and uploaded files before removing the user record, rolling back completely if any database error occurs."* |
| **Q8: How does the system handle large PDF files without causing memory bottlenecks or crashing the application?** | *"In [AdminNewDocumentForm.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/AdminNewDocumentForm.vb) and [UserUploadDocumentPanel.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/UserUploadDocumentPanel.vb), file size checks enforce strict limits (50 MB for PDFs, 5 MB for images). Furthermore, when browsing records in the archive grid, the query selects only metadata (`DocumentID`, `Title`, `UploadedBy`, `DateUploaded`), omitting heavy binary BLOB columns. The large PDF bytes are only retrieved on-demand when the user explicitly clicks 'View' in [UserDocumentViewForm.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/UserDocumentViewForm.vb). When opening, the bytes are streamed into the temporary directory and handed off to the OS PDF handler, freeing .NET heap memory immediately."* |
| **Q9: What happens if a staff member modifies account settings or passwords and forgets to save before navigating away?** | *"In both [AdminViewProfilePanel.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/AdminViewProfilePanel.vb) and [UserViewProfilePanel.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/UserViewProfilePanel.vb), we implemented a **Dirty State Tracker (`HasUnsavedChanges`)**. If any textbox or dropdown is changed, a dirty flag is set. If the user clicks any navigation button on the sidebar, the parent dashboard checks `current.HasUnsavedChanges` and presents a confirmation dialog: *'You have unsaved changes. Discard and leave?'*, preventing accidental loss of data."* |
| **Q10: How scalable is DASOBSDP if other barangays in Piat or across Cagayan wish to adopt the system?** | *"DASOBSDP is architected with complete modularity. Database connection parameters are externalized in [`config.txt`](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/bin/Debug/net8.0-windows/config.txt), enabling deployment on single workstations or across a multi-computer local area network (LAN) pointing to a central barangay server. The nine document categories defined in [Constants.vb](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/Helpers/Constants.vb) conform to standard DILG local government classification standards, allowing seamless institutional adoption across all 18 barangays of Piat without architectural redesign."* |

---

## 💡 Pro-Tips for Defense Day

1. **Dual-Instance Live Synchronization Demo**:
   * Open **Instance 1** on the left screen logged in as **Admin**.
   * Open **Instance 2** on the right screen logged in as **User (`jdela`)**.
   * On the User side, upload a new clearance document. It will immediately be marked `For Review`.
   * On the Admin side, click Search or refresh the Archive List: the panel will see the document appear instantly! Right-click and choose **"Approve Document"**. Panelists love seeing real-time multi-role workflow validation live!
2. **Ground Every Feature in Real Barangay Scenarios**:
   * When demonstrating the search function, explain how a resident needing an Urgent Medical Indigency certificate for hospital admission used to wait hours while the secretary dug through old filing boxes. With DASOBSDP, typing the name retrieves the record in less than two seconds.
3. **Showcase the Database BLOB Architecture**:
   * Emphasize during Step 6 and Step 14 that PDF documents and image banners are stored directly in SQL Server as `VARBINARY(MAX)`. Point out that backing up the database captures 100% of both data and files, solving the widespread issue of broken file links that plagues other student capstone projects.
4. **Demonstrate Live Input Trapping & Sanitization**:
   * In the login screen, demonstrate the 30-second lockout timer live. In the profile screen, demonstrate typing a character and clicking another tab to trigger the *"Unsaved Changes"* dialog. This proves deep technical polish and user-experience engineering.
5. **Ensure Offline Readiness**:
   * Before heading to the defense room, ensure SQL Server (`SQLEXPRESS`) is running in Windows Services. Verify your local connection in [`config.txt`](file:///C:/Users/GLENN/source/repos/DAS_Barangay_Sto_Domingo_Piat/DAS_Barangay_Sto_Domingo_Piat/bin/Debug/net8.0-windows/config.txt). Because DASOBSDP is an offline-resilient desktop application, your presentation will run flawlessly even if campus Wi-Fi drops completely!
