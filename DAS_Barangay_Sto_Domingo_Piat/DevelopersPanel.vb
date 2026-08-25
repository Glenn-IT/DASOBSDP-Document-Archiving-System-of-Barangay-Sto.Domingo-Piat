Imports System.Drawing
Imports System.Windows.Forms

Public Class DevelopersPanel
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
        lblHeaderTitle.Text = "System Developers"
        lblHeaderTitle.Font = New Font("Segoe UI", 15, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.White
        lblHeaderTitle.Dock = DockStyle.Top
        lblHeaderTitle.Height = 28

        Dim lblHeaderSub As New Label()
        lblHeaderSub.Text = "Project Development Team • Document Archiving System • Brgy. Sto. Domingo, Piat"
        lblHeaderSub.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular)
        lblHeaderSub.ForeColor = Color.FromArgb(242, 237, 194)
        lblHeaderSub.Dock = DockStyle.Bottom
        lblHeaderSub.Height = 22

        pnlHeader.Controls.Add(lblHeaderSub)
        pnlHeader.Controls.Add(lblHeaderTitle)

        ' Body Scroll Panel
        Dim pnlBody As New Panel()
        pnlBody.Dock = DockStyle.Fill
        pnlBody.AutoScroll = True
        pnlBody.Padding = New Padding(30, 20, 30, 30)
        pnlBody.BackColor = creamBg

        ' Cards Flow Layout
        Dim flowContainer As New FlowLayoutPanel()
        flowContainer.Dock = DockStyle.Top
        flowContainer.AutoSize = True
        flowContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flowContainer.FlowDirection = FlowDirection.LeftToRight
        flowContainer.WrapContents = True
        flowContainer.BackColor = Color.Transparent
        flowContainer.Padding = New Padding(10, 10, 10, 10)

        ' Developer 1 Card
        Dim cardDev1 As Panel = CreateDevCard("Developer 1", "Lead Developer / Full-Stack", "developer1@email.com", "System Architecture, Backend & Database Development", "BS in Information Technology", darkGreen, cardBg, textDark, subText, oliveGreen)
        ' Developer 2 Card
        Dim cardDev2 As Panel = CreateDevCard("Developer 2", "UI/UX Designer & Frontend Developer", "developer2@email.com", "User Interface Design, Client Workflows & Documentation", "BS in Information Technology", darkGreen, cardBg, textDark, subText, oliveGreen)

        flowContainer.Controls.Add(cardDev1)
        flowContainer.Controls.Add(cardDev2)

        ' Info Note Panel
        Dim pnlNote As New Panel()
        pnlNote.Dock = DockStyle.Top
        pnlNote.Height = 85
        pnlNote.BackColor = Color.FromArgb(220, 216, 170)
        pnlNote.Margin = New Padding(10, 20, 10, 20)
        pnlNote.Padding = New Padding(18, 14, 18, 14)

        Dim lblNoteTitle As New Label()
        lblNoteTitle.Text = "ℹ️  Developer Information & Project Credits"
        lblNoteTitle.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        lblNoteTitle.ForeColor = darkerGreen
        lblNoteTitle.Dock = DockStyle.Top
        lblNoteTitle.Height = 24

        Dim lblNoteBody As New Label()
        lblNoteBody.Text = "Developed for Barangay Sto. Domingo, Piat, Cagayan as an automated document archiving and management solution. Names and details can be configured and updated as needed."
        lblNoteBody.Font = New Font("Segoe UI", 9F, FontStyle.Regular)
        lblNoteBody.ForeColor = textDark
        lblNoteBody.Dock = DockStyle.Fill

        pnlNote.Controls.Add(lblNoteBody)
        pnlNote.Controls.Add(lblNoteTitle)

        pnlBody.Controls.Add(pnlNote)
        pnlBody.Controls.Add(flowContainer)

        Me.Controls.Add(pnlBody)
        Me.Controls.Add(pnlHeader)

        Me.ResumeLayout(False)
    End Sub

    Private Function CreateDevCard(devName As String, role As String, email As String, contribution As String, course As String, headerColor As Color, cardColor As Color, textColor As Color, subTextColor As Color, accentColor As Color) As Panel
        Dim card As New Panel()
        card.Width = 390
        card.Height = 360
        card.BackColor = cardColor
        card.Margin = New Padding(15, 15, 15, 15)
        card.Padding = New Padding(20)

        ' Avatar / Icon Circle
        Dim pnlAvatar As New Panel()
        pnlAvatar.Size = New Size(70, 70)
        pnlAvatar.Location = New Point(20, 20)
        pnlAvatar.BackColor = headerColor

        Dim lblAvatarIcon As New Label()
        lblAvatarIcon.Text = "👨‍💻"
        lblAvatarIcon.Font = New Font("Segoe UI Emoji", 26)
        lblAvatarIcon.TextAlign = ContentAlignment.MiddleCenter
        lblAvatarIcon.Dock = DockStyle.Fill
        lblAvatarIcon.ForeColor = Color.White
        lblAvatarIcon.BackColor = Color.Transparent
        pnlAvatar.Controls.Add(lblAvatarIcon)

        ' Developer Name
        Dim lblName As New Label()
        lblName.Text = devName
        lblName.Font = New Font("Segoe UI", 14, FontStyle.Bold)
        lblName.ForeColor = headerColor
        lblName.Location = New Point(105, 20)
        lblName.Size = New Size(265, 30)

        ' Developer Role
        Dim lblRole As New Label()
        lblRole.Text = role
        lblRole.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblRole.ForeColor = accentColor
        lblRole.Location = New Point(105, 52)
        lblRole.Size = New Size(265, 24)

        ' Divider Line
        Dim pnlDivider As New Panel()
        pnlDivider.Location = New Point(20, 100)
        pnlDivider.Size = New Size(350, 2)
        pnlDivider.BackColor = Color.FromArgb(200, 195, 150)

        ' Field: Course / Program
        Dim lblCourseTitle As New Label()
        lblCourseTitle.Text = "PROGRAM / COURSE:"
        lblCourseTitle.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        lblCourseTitle.ForeColor = subTextColor
        lblCourseTitle.Location = New Point(20, 115)
        lblCourseTitle.Size = New Size(350, 16)

        Dim lblCourseVal As New Label()
        lblCourseVal.Text = course
        lblCourseVal.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular)
        lblCourseVal.ForeColor = textColor
        lblCourseVal.Location = New Point(20, 133)
        lblCourseVal.Size = New Size(350, 22)

        ' Field: Email / Contact
        Dim lblEmailTitle As New Label()
        lblEmailTitle.Text = "CONTACT / EMAIL:"
        lblEmailTitle.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        lblEmailTitle.ForeColor = subTextColor
        lblEmailTitle.Location = New Point(20, 165)
        lblEmailTitle.Size = New Size(350, 16)

        Dim lblEmailVal As New Label()
        lblEmailVal.Text = email
        lblEmailVal.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular)
        lblEmailVal.ForeColor = textColor
        lblEmailVal.Location = New Point(20, 183)
        lblEmailVal.Size = New Size(350, 22)

        ' Field: Contribution / Responsibilities
        Dim lblContribTitle As New Label()
        lblContribTitle.Text = "KEY RESPONSIBILITIES:"
        lblContribTitle.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        lblContribTitle.ForeColor = subTextColor
        lblContribTitle.Location = New Point(20, 215)
        lblContribTitle.Size = New Size(350, 16)

        Dim lblContribVal As New Label()
        lblContribVal.Text = contribution
        lblContribVal.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular)
        lblContribVal.ForeColor = textColor
        lblContribVal.Location = New Point(20, 233)
        lblContribVal.Size = New Size(350, 48)

        ' Status Tag
        Dim lblStatus As New Label()
        lblStatus.Text = "● Active Contributor"
        lblStatus.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblStatus.ForeColor = headerColor
        lblStatus.Location = New Point(20, 310)
        lblStatus.Size = New Size(350, 20)

        card.Controls.Add(pnlAvatar)
        card.Controls.Add(lblName)
        card.Controls.Add(lblRole)
        card.Controls.Add(pnlDivider)
        card.Controls.Add(lblCourseTitle)
        card.Controls.Add(lblCourseVal)
        card.Controls.Add(lblEmailTitle)
        card.Controls.Add(lblEmailVal)
        card.Controls.Add(lblContribTitle)
        card.Controls.Add(lblContribVal)
        card.Controls.Add(lblStatus)

        Return card
    End Function

End Class
