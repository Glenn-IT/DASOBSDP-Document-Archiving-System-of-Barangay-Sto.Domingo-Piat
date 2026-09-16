Imports System.Drawing
Imports System.Windows.Forms

Public Class SystemManualPanel
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()

        Dim darkGreen As Color = Color.FromArgb(52, 103, 57)
        Dim darkerGreen As Color = Color.FromArgb(40, 80, 44)
        Dim oliveGreen As Color = Color.FromArgb(121, 174, 111)
        Dim creamBg As Color = Color.FromArgb(242, 237, 194)
        Dim cardBg As Color = Color.FromArgb(230, 226, 180)
        Dim textDark As Color = Color.FromArgb(40, 60, 40)
        Dim subText As Color = Color.FromArgb(80, 110, 80)

        Me.BackColor = creamBg
        Me.Dock = DockStyle.Fill
        Me.AutoScroll = True

        ' Header Banner
        Dim pnlHeader As New Panel()
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Height = 70
        pnlHeader.BackColor = oliveGreen
        pnlHeader.Padding = New Padding(24, 10, 24, 10)

        Dim lblHeaderTitle As New Label()
        lblHeaderTitle.Text = "System User Manual & Operations Guide"
        lblHeaderTitle.Font = New Font("Segoe UI", 15, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.White
        lblHeaderTitle.Dock = DockStyle.Top
        lblHeaderTitle.Height = 28

        Dim lblHeaderSub As New Label()
        lblHeaderSub.Text = "Standard Operating Procedures • Document Archiving System • Brgy. Sto. Domingo, Piat"
        lblHeaderSub.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular)
        lblHeaderSub.ForeColor = Color.FromArgb(242, 237, 194)
        lblHeaderSub.Dock = DockStyle.Bottom
        lblHeaderSub.Height = 22

        pnlHeader.Controls.Add(lblHeaderSub)
        pnlHeader.Controls.Add(lblHeaderTitle)

        ' Main Content Flow Layout
        Dim pnlBody As New Panel()
        pnlBody.Dock = DockStyle.Fill
        pnlBody.AutoScroll = True
        pnlBody.Padding = New Padding(25, 20, 25, 30)
        pnlBody.BackColor = creamBg

        Dim flowContainer As New FlowLayoutPanel()
        flowContainer.Dock = DockStyle.Top
        flowContainer.AutoSize = True
        flowContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flowContainer.FlowDirection = FlowDirection.TopDown
        flowContainer.WrapContents = False
        flowContainer.BackColor = Color.Transparent
        flowContainer.Padding = New Padding(0)

        ' Section 1: Overview
        flowContainer.Controls.Add(CreateManualSection(
            "📖  1. System Overview & Purpose",
            "The Document Archiving System (DAS) for Barangay Sto. Domingo, Piat is a secure, digitized repository designed to replace manual paper filing with structured digital archiving." & vbCrLf & vbCrLf &
            "• Digital Record Repository: Store and organize barangay clearances, certifications, indigency records, ordinances, resolutions, and business permits." & vbCrLf &
            "• Rapid Search & Retrieval: Search archived records instantly by tracking number, resident name, keyword, or document category." & vbCrLf &
            "• Audit Accountability: Maintain detailed activity logs of all actions performed by staff and administrators.",
            darkGreen, cardBg, textDark, 175))

        ' Section 2: Roles and Permissions
        flowContainer.Controls.Add(CreateManualSection(
            "👥  2. User Roles & Access Control",
            "• Administrator Account:" & vbCrLf &
            "   - Full access to Archive List, Document Classification, Users Management, and Activity Audit Logs." & vbCrLf &
            "   - Can add, update status, change passwords, and manage accounts (primary administrator is protected from deletion)." & vbCrLf &
            "   - Full capability to view, edit, and archive records across all categories." & vbCrLf & vbCrLf &
            "• Standard User Account:" & vbCrLf &
            "   - Access to Dashboard, Upload Document, Search Archive, and Document Type filtering." & vbCrLf &
            "   - Can upload new records, view document previews, search public archive entries, and update own profile.",
            darkGreen, cardBg, textDark, 200))

        ' Section 3: Document Upload Process
        flowContainer.Controls.Add(CreateManualSection(
            "📤  3. How to Upload & Archive Documents",
            "1. Click 'Upload Document' (User) or 'New Document' (Admin) from the sidebar menu." & vbCrLf &
            "2. Fill in the required metadata fields:" & vbCrLf &
            "   • Document Title: Short, descriptive name (e.g. Barangay Clearance - Juan Dela Cruz)." & vbCrLf &
            "   • Document Type: Choose appropriate type (Clearance, Indigency, Resolution, Ordinance, etc.)." & vbCrLf &
            "   • Resident / Owner Name: Name of the concerned constituent or official." & vbCrLf &
            "   • Date Filed: Official issuance or filing date." & vbCrLf &
            "   • Description & Tags: Important notes and comma-separated search keywords." & vbCrLf &
            "3. Click 'Browse Attachment' to attach the digitized file (PDF, Scanned Image, DOCX)." & vbCrLf &
            "4. Click 'Save Document'. The system generates a tracking entry and creates an audit record.",
            darkGreen, cardBg, textDark, 220))

        ' Section 4: Searching & Retrieval
        flowContainer.Controls.Add(CreateManualSection(
            "🔍  4. Searching & Retrieving Records",
            "• Keyword Search: Enter resident name, tracking number, or keyword in the Search Archive box to filter results in real time." & vbCrLf &
            "• Category Navigation: Click 'Document Types' from the sidebar to view documents organized into folders/cards by category (e.g., Barangay Clearance, Indigency, Resolutions, Others)." & vbCrLf &
            "• Document Viewing: Double-click or click 'View' on any row in the archive list to open the detailed record viewer and download/open attachments." & vbCrLf &
            "• Sorting: Click any column header (Date, Title, Resident, Type) to sort ascending or descending.",
            darkGreen, cardBg, textDark, 185))

        ' Section 5: Security & Password Management
        flowContainer.Controls.Add(CreateManualSection(
            "🔒  5. Account Security & Password Recovery",
            "• Updating Profile: Navigate to 'Account Settings' / 'View Profile' to change password or update security questions." & vbCrLf &
            "• Password Requirements: Use strong passwords combining letters, numbers, and symbols." & vbCrLf &
            "• Forgot Password Recovery: On the Login screen, click 'Forgot Password' and answer your registered Security Question to reset your password without administrative intervention." & vbCrLf &
            "• Session Logout: Always click 'Logout' in the bottom sidebar menu when leaving the computer.",
            darkGreen, cardBg, textDark, 180))

        ' Section 6: System Maintenance & Troubleshooting
        flowContainer.Controls.Add(CreateManualSection(
            "⚙️  6. Troubleshooting & System Best Practices",
            "• Database Connection Error: Ensure SQL Server service (LocalDB or MSSQL) is running and 'config.txt' has valid credentials." & vbCrLf &
            "• Duplicate Entries: Search before uploading to prevent redundant document archiving." & vbCrLf &
            "• File Sizes: Keep scanned documents under 25MB for optimal database and network performance." & vbCrLf &
            "• Technical Support: Refer to the Developers page in the sidebar for contact information (Aemyra Jenn Ignacio & Racquel Dela Cruz), or contact the Barangay IT Administrator.",
            darkGreen, cardBg, textDark, 175))

        pnlBody.Controls.Add(flowContainer)
        Me.Controls.Add(pnlBody)
        Me.Controls.Add(pnlHeader)

        Me.ResumeLayout(False)
    End Sub

    Private Function CreateManualSection(title As String, body As String, headerColor As Color, cardColor As Color, textColor As Color, height As Integer) As Panel
        Dim card As New Panel()
        card.Width = 820
        card.Height = height
        card.BackColor = cardColor
        card.Margin = New Padding(0, 0, 0, 18)
        card.Padding = New Padding(20, 14, 20, 14)

        Dim lblTitle As New Label()
        lblTitle.Text = title
        lblTitle.Font = New Font("Segoe UI", 11.5F, FontStyle.Bold)
        lblTitle.ForeColor = headerColor
        lblTitle.Dock = DockStyle.Top
        lblTitle.Height = 28

        Dim pnlLine As New Panel()
        pnlLine.Dock = DockStyle.Top
        pnlLine.Height = 2
        pnlLine.BackColor = Color.FromArgb(200, 195, 150)
        pnlLine.Margin = New Padding(0, 0, 0, 8)

        Dim lblBody As New Label()
        lblBody.Text = body
        lblBody.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular)
        lblBody.ForeColor = textColor
        lblBody.Dock = DockStyle.Fill
        lblBody.Padding = New Padding(0, 6, 0, 0)

        card.Controls.Add(lblBody)
        card.Controls.Add(pnlLine)
        card.Controls.Add(lblTitle)

        Return card
    End Function

End Class
