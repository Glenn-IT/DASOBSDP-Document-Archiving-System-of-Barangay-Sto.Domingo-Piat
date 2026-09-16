Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms

Public Class SystemManualPanel
    Inherits UserControl

    Private pnlBody As Panel
    Private flowContainer As FlowLayoutPanel

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
        pnlHeader.Height = 72
        pnlHeader.BackColor = oliveGreen
        pnlHeader.Padding = New Padding(24, 10, 24, 10)

        Dim lblHeaderTitle As New Label()
        lblHeaderTitle.Text = "System User Manual & Visual Operations Guide"
        lblHeaderTitle.Font = New Font("Segoe UI", 15, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.White
        lblHeaderTitle.Dock = DockStyle.Top
        lblHeaderTitle.Height = 28

        Dim lblHeaderSub As New Label()
        lblHeaderSub.Text = "Standard Operating Procedures • Tab Walkthrough & Screenshots • Brgy. Sto. Domingo, Piat"
        lblHeaderSub.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular)
        lblHeaderSub.ForeColor = Color.FromArgb(242, 237, 194)
        lblHeaderSub.Dock = DockStyle.Bottom
        lblHeaderSub.Height = 22

        pnlHeader.Controls.Add(lblHeaderSub)
        pnlHeader.Controls.Add(lblHeaderTitle)

        ' Body Scroll Panel
        pnlBody = New Panel()
        pnlBody.Dock = DockStyle.Fill
        pnlBody.AutoScroll = True
        pnlBody.Padding = New Padding(25, 15, 25, 30)
        pnlBody.BackColor = creamBg

        flowContainer = New FlowLayoutPanel()
        flowContainer.Dock = DockStyle.Top
        flowContainer.AutoSize = True
        flowContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flowContainer.FlowDirection = FlowDirection.TopDown
        flowContainer.WrapContents = False
        flowContainer.BackColor = Color.Transparent
        flowContainer.Padding = New Padding(0)

        ' Navigation Bar with Quick Jump Buttons
        Dim pnlNav As New FlowLayoutPanel()
        pnlNav.Width = 830
        pnlNav.AutoSize = True
        pnlNav.AutoSizeMode = AutoSizeMode.GrowAndShrink
        pnlNav.FlowDirection = FlowDirection.TopDown
        pnlNav.WrapContents = False
        pnlNav.BackColor = Color.FromArgb(220, 216, 170)
        pnlNav.Margin = New Padding(0, 0, 0, 20)
        pnlNav.Padding = New Padding(14, 12, 14, 12)

        Dim lblNavTitle As New Label()
        lblNavTitle.Text = "📑 Quick Jump to Tab Guide (Click any button below to jump to instructions & screenshots):"
        lblNavTitle.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblNavTitle.ForeColor = darkerGreen
        lblNavTitle.Width = 800
        lblNavTitle.Height = 24
        lblNavTitle.Margin = New Padding(0, 0, 0, 10)
        pnlNav.Controls.Add(lblNavTitle)

        Dim flowNavButtons As New FlowLayoutPanel()
        flowNavButtons.Width = 800
        flowNavButtons.AutoSize = True
        flowNavButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flowNavButtons.FlowDirection = FlowDirection.LeftToRight
        flowNavButtons.WrapContents = True
        flowNavButtons.BackColor = Color.Transparent
        flowNavButtons.Margin = New Padding(0)
        flowNavButtons.Padding = New Padding(0)
        pnlNav.Controls.Add(flowNavButtons)

        ' Section 1: Dashboard
        Dim sec1 As Panel = CreateManualSection(
            "📊  1. Dashboard & Operations Overview",
            "The System Dashboard gives administrators and barangay personnel an instant snapshot of archived records." & vbCrLf &
            "• Total Documents & Category Metrics: View counts of archived clearances, certifications, and resolutions." & vbCrLf &
            "• Recent Uploads Feed: Quick access to the most recently registered documents with status indicators." & vbCrLf &
            "• System Navigation: One-click access to document uploading, search, user management, and audit logs.",
            "tab_dashboard.png",
            "Dashboard Tab",
            darkGreen, cardBg, textDark, 410)

        ' Section 2: Upload Document
        Dim sec2 As Panel = CreateManualSection(
            "📤  2. How to Upload & Archive Documents",
            "Archiving new constituents' records and official barangay files into the system:" & vbCrLf &
            "1. Click 'Upload Document' from the sidebar menu." & vbCrLf &
            "2. System automatically generates a unique Document Tracking ID (e.g. DOC-2026-0128)." & vbCrLf &
            "3. Select Category (Clearance, Indigency, Resolution, Ordinance, Business Permit, Others)." & vbCrLf &
            "4. Fill in Document Title, Resident / Owner Name, Date Filed, and Notes." & vbCrLf &
            "5. Click 'Browse Attachment' to attach PDF or scanned image (up to 50MB PDF / 5MB image)." & vbCrLf &
            "6. Click 'Save Document'. The record is saved and an audit entry is automatically created.",
            "tab_upload.png",
            "Upload Document Tab",
            darkGreen, cardBg, textDark, 450)

        ' Section 3: Search Archive
        Dim sec3 As Panel = CreateManualSection(
            "🔍  3. Searching & Retrieving Records",
            "Finding archived constituents' files quickly with real-time filtering:" & vbCrLf &
            "• Real-Time Search: Type constituent name, tracking ID, or keywords in the search bar." & vbCrLf &
            "• Document Actions: Click 'View' on any row to open the complete details and preview attachments." & vbCrLf &
            "• Download & Export: Open or download attached PDF/scanned documents directly from the viewer." & vbCrLf &
            "• Column Sorting: Click column headers (Doc ID, Category, Date, Resident) to sort results instantly.",
            "tab_search.png",
            "Search Archive Tab",
            darkGreen, cardBg, textDark, 420)

        ' Section 4: Document Types
        Dim sec4 As Panel = CreateManualSection(
            "📁  4. Document Classification & Category Folders",
            "Categorized repository organizing barangay records into dedicated classification folders:" & vbCrLf &
            "• Barangay Clearance: Constituent residency, good standing, and employment clearances." & vbCrLf &
            "• Certificate of Indigency: Medical, financial, burial, and educational scholarship assistance records." & vbCrLf &
            "• Barangay Resolutions & Ordinances: Official legislation, peace & order policies, and council acts." & vbCrLf &
            "• Business Permit Endorsements: Commercial and micro-enterprise local endorsements." & vbCrLf &
            "• Click on any category card to open its filtered document list view with dedicated search.",
            "tab_doctypes.png",
            "Document Types Tab",
            darkGreen, cardBg, textDark, 430)

        ' Section 5: Users Management
        Dim sec5 As Panel = CreateManualSection(
            "👥  5. User Accounts & Access Control (Admin Only)",
            "Role-based account management for barangay staff and officials:" & vbCrLf &
            "• Administrator: Full privileges to manage accounts, edit/delete documents, and view audit trails." & vbCrLf &
            "• Standard User: Privileges to upload records, search the archive, and view documents." & vbCrLf &
            "• Adding Accounts: Click '+ Add Account', enter Username, select Role, set temporary password." & vbCrLf &
            "• Status & Password Reset: Admins can update account status (Active/Inactive) or reset passwords.",
            "tab_users.png",
            "Users List Tab",
            darkGreen, cardBg, textDark, 420)

        ' Section 6: Activity Logs
        Dim sec6 As Panel = CreateManualSection(
            "📜  6. Activity Audit Logs & System Accountability",
            "Comprehensive, tamper-resistant audit trail ensuring transparency in barangay document handling:" & vbCrLf &
            "• Automated Logging: Every login, logout, document upload, modification, and deletion is recorded." & vbCrLf &
            "• Log Details: Records exact Timestamp, Username, Action Performed, and Status (Success/Failed)." & vbCrLf &
            "• Non-repudiation: Audit entries cannot be modified or erased, ensuring data integrity for audits.",
            "tab_logs.png",
            "Activity Logs Tab",
            darkGreen, cardBg, textDark, 410)

        ' Section 7: View Profile & Security
        Dim sec7 As Panel = CreateManualSection(
            "🔒  7. Account Security & Self-Service Password Recovery",
            "Managing your own profile credentials and automated password recovery settings:" & vbCrLf &
            "• Update Password: Change your account password anytime by entering a secure new password." & vbCrLf &
            "• Security Question: Set your security question and answer for forgotten password recovery." & vbCrLf &
            "• Forgot Password Recovery: Recover access from the login screen without needing an administrator." & vbCrLf &
            "• Always remember to click 'Logout' in the bottom sidebar before leaving your workstation.",
            "tab_profile.png",
            "View Profile Tab",
            darkGreen, cardBg, textDark, 420)

        ' Section 8: Developers
        Dim sec8 As Panel = CreateManualSection(
            "👨‍💻  8. Developers Team & Technical Support",
            "Credits and contact information for the project development team:" & vbCrLf &
            "• Lead Developer / Full-Stack: Aemyra Jenn Ignacio (09063119790 • myraignacio753@gmail.com)" & vbCrLf &
            "• Frontend Developer / UI/UX: Racquel Dela Cruz (09682806653 • racqueldelacruz1022@gmail.com)" & vbCrLf &
            "• Institution: Bachelor of Science in Information Technology (BSIT) • CSU - Piat Campus" & vbCrLf &
            "• Technical Support: Contact the developers or the designated Barangay IT Administrator for assistance.",
            "tab_developers.png",
            "Developers Tab",
            darkGreen, cardBg, textDark, 420)

        ' Add Nav Jump Buttons
        AddNavButton(flowNavButtons, "📊 Dashboard", sec1, darkGreen)
        AddNavButton(flowNavButtons, "📤 Upload Document", sec2, darkGreen)
        AddNavButton(flowNavButtons, "🔍 Search Archive", sec3, darkGreen)
        AddNavButton(flowNavButtons, "📁 Document Types", sec4, darkGreen)
        AddNavButton(flowNavButtons, "👥 Users List", sec5, darkGreen)
        AddNavButton(flowNavButtons, "📜 Activity Logs", sec6, darkGreen)
        AddNavButton(flowNavButtons, "🔒 View Profile", sec7, darkGreen)
        AddNavButton(flowNavButtons, "👨‍💻 Developers", sec8, darkGreen)

        ' Add to Flow Container
        flowContainer.Controls.Add(pnlNav)
        flowContainer.Controls.Add(sec1)
        flowContainer.Controls.Add(sec2)
        flowContainer.Controls.Add(sec3)
        flowContainer.Controls.Add(sec4)
        flowContainer.Controls.Add(sec5)
        flowContainer.Controls.Add(sec6)
        flowContainer.Controls.Add(sec7)
        flowContainer.Controls.Add(sec8)

        pnlBody.Controls.Add(flowContainer)
        Me.Controls.Add(pnlBody)
        Me.Controls.Add(pnlHeader)

        Me.ResumeLayout(False)
    End Sub

    Private Sub AddNavButton(container As FlowLayoutPanel, text As String, targetSection As Panel, btnColor As Color)
        Dim btn As New Button()
        btn.Text = text
        btn.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        btn.BackColor = btnColor
        btn.ForeColor = Color.White
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.AutoSize = True
        btn.Height = 32
        btn.Margin = New Padding(0, 0, 8, 8)
        btn.Padding = New Padding(10, 2, 10, 2)
        btn.Cursor = Cursors.Hand
        AddHandler btn.Click, Sub(s, e)
            pnlBody.ScrollControlIntoView(targetSection)
        End Sub
        container.Controls.Add(btn)
    End Sub

    Private Function CreateManualSection(title As String,
                                         body As String,
                                         imageFileName As String,
                                         tabName As String,
                                         headerColor As Color,
                                         cardColor As Color,
                                         textColor As Color,
                                         height As Integer) As Panel

        Dim card As New Panel()
        card.Width = 830
        card.Height = height
        card.BackColor = cardColor
        card.Margin = New Padding(0, 0, 0, 20)
        card.Padding = New Padding(20, 14, 20, 16)

        ' Section Title
        Dim lblTitle As New Label()
        lblTitle.Text = title
        lblTitle.Font = New Font("Segoe UI", 11.5F, FontStyle.Bold)
        lblTitle.ForeColor = headerColor
        lblTitle.Dock = DockStyle.Top
        lblTitle.Height = 26

        ' Divider Line
        Dim pnlLine As New Panel()
        pnlLine.Dock = DockStyle.Top
        pnlLine.Height = 2
        pnlLine.BackColor = Color.FromArgb(200, 195, 150)
        pnlLine.Margin = New Padding(0, 0, 0, 6)

        ' Section Body Text
        Dim lblBody As New Label()
        lblBody.Text = body
        lblBody.Font = New Font("Segoe UI", 9.25F, FontStyle.Regular)
        lblBody.ForeColor = textColor
        lblBody.Dock = DockStyle.Top
        lblBody.Height = 115
        lblBody.Padding = New Padding(0, 4, 0, 4)

        ' Screenshot Frame Card
        Dim pnlScreenshotCard As New Panel()
        pnlScreenshotCard.Dock = DockStyle.Fill
        pnlScreenshotCard.BackColor = Color.FromArgb(40, 70, 44)
        pnlScreenshotCard.Padding = New Padding(2)

        ' Screenshot Top Bar
        Dim pnlShotBar As New Panel()
        pnlShotBar.Dock = DockStyle.Top
        pnlShotBar.Height = 26
        pnlShotBar.BackColor = Color.FromArgb(52, 103, 57)
        pnlShotBar.Padding = New Padding(8, 4, 8, 2)

        Dim lblShotTitle As New Label()
        lblShotTitle.Text = $"📷  Interface Screenshot: {tabName}"
        lblShotTitle.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblShotTitle.ForeColor = Color.White
        lblShotTitle.Dock = DockStyle.Left
        lblShotTitle.AutoSize = True

        Dim lblEnlargeHint As New Label()
        lblEnlargeHint.Text = "🔍 Click image to enlarge full preview"
        lblEnlargeHint.Font = New Font("Segoe UI", 8F, FontStyle.Italic)
        lblEnlargeHint.ForeColor = Color.FromArgb(242, 237, 194)
        lblEnlargeHint.Dock = DockStyle.Right
        lblEnlargeHint.AutoSize = True

        pnlShotBar.Controls.Add(lblEnlargeHint)
        pnlShotBar.Controls.Add(lblShotTitle)

        ' PictureBox
        Dim picScreenshot As New PictureBox()
        picScreenshot.Dock = DockStyle.Fill
        picScreenshot.SizeMode = PictureBoxSizeMode.Zoom
        picScreenshot.BackColor = Color.FromArgb(30, 45, 30)
        picScreenshot.Cursor = Cursors.Hand

        Dim tabImg As Image = LoadManualImage(imageFileName)
        If tabImg IsNot Nothing Then
            picScreenshot.Image = tabImg
            Dim currentImg As Image = tabImg
            Dim currentTitle As String = tabName
            AddHandler picScreenshot.Click, Sub(s, e)
                Using viewer As New ManualScreenshotPreviewForm(currentTitle, currentImg)
                    viewer.ShowDialog()
                End Using
            End Sub
            AddHandler lblEnlargeHint.Click, Sub(s, e)
                Using viewer As New ManualScreenshotPreviewForm(currentTitle, currentImg)
                    viewer.ShowDialog()
                End Using
            End Sub
            lblEnlargeHint.Cursor = Cursors.Hand
        Else
            Dim lblNoImg As New Label()
            lblNoImg.Text = $"Preview image ({imageFileName}) not found in img/ folder."
            lblNoImg.Font = New Font("Segoe UI", 9F, FontStyle.Italic)
            lblNoImg.ForeColor = Color.FromArgb(220, 220, 220)
            lblNoImg.Dock = DockStyle.Fill
            lblNoImg.TextAlign = ContentAlignment.MiddleCenter
            pnlScreenshotCard.Controls.Add(lblNoImg)
        End If

        pnlScreenshotCard.Controls.Add(picScreenshot)
        pnlScreenshotCard.Controls.Add(pnlShotBar)

        card.Controls.Add(pnlScreenshotCard)
        card.Controls.Add(lblBody)
        card.Controls.Add(pnlLine)
        card.Controls.Add(lblTitle)

        Return card
    End Function

    Private Function LoadManualImage(imageFileName As String) As Image
        Try
            Dim candidatePaths As String() = {
                Path.Combine(Application.StartupPath, "img", imageFileName),
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img", imageFileName),
                Path.Combine(Application.StartupPath, "..", "..", "..", "img", imageFileName),
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "img", imageFileName),
                Path.Combine(Application.StartupPath, "DAS_Barangay_Sto_Domingo_Piat", "img", imageFileName),
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DAS_Barangay_Sto_Domingo_Piat", "img", imageFileName)
            }

            For Each candidate In candidatePaths
                Dim fullPath As String = Path.GetFullPath(candidate)
                If File.Exists(fullPath) Then
                    Using fs As New FileStream(fullPath, FileMode.Open, FileAccess.Read)
                        Using tempImg As Image = Image.FromStream(fs)
                            Return New Bitmap(tempImg)
                        End Using
                    End Using
                End If
            Next
        Catch ex As Exception
            ' Return Nothing on failure so error fallback is shown
        End Try
        Return Nothing
    End Function

End Class

''' <summary>
''' High-definition fullscreen/modal preview dialog for tab screenshots in the System Manual.
''' </summary>
Public Class ManualScreenshotPreviewForm
    Inherits Form

    Public Sub New(tabName As String, img As Image)
        Me.Text = $"System Manual - {tabName} (Full Preview)"
        Me.Size = New Size(1060, 720)
        Me.MinimumSize = New Size(800, 550)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackColor = Color.FromArgb(40, 65, 42)

        Dim pnlTop As New Panel()
        pnlTop.Dock = DockStyle.Top
        pnlTop.Height = 52
        pnlTop.BackColor = Color.FromArgb(52, 103, 57)
        pnlTop.Padding = New Padding(18, 10, 18, 10)

        Dim lblTitle As New Label()
        lblTitle.Text = $"📷  {tabName} — Full Visual Interface"
        lblTitle.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Dock = DockStyle.Left
        lblTitle.AutoSize = True

        Dim btnClose As New Button()
        btnClose.Text = "✕ Close Preview"
        btnClose.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnClose.BackColor = Color.FromArgb(121, 174, 111)
        btnClose.ForeColor = Color.White
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.Dock = DockStyle.Right
        btnClose.Width = 140
        btnClose.Cursor = Cursors.Hand
        AddHandler btnClose.Click, Sub(s, e) Me.Close()

        pnlTop.Controls.Add(btnClose)
        pnlTop.Controls.Add(lblTitle)

        Dim picFull As New PictureBox()
        picFull.Dock = DockStyle.Fill
        picFull.SizeMode = PictureBoxSizeMode.Zoom
        picFull.BackColor = Color.FromArgb(28, 42, 28)
        picFull.Image = img

        Me.Controls.Add(picFull)
        Me.Controls.Add(pnlTop)
        Me.KeyPreview = True
        AddHandler Me.KeyDown, Sub(s, e)
            If e.KeyCode = Keys.Escape Then Me.Close()
        End Sub
    End Sub

End Class
