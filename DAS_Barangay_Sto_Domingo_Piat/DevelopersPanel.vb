Imports System.Drawing
Imports System.IO
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

        ' Developer 1 Card - Aemyra Jenn Ignacio
        Dim cardDev1 As Panel = CreateDevCard(
            "Aemyra Jenn Ignacio",
            "Lead Developer / Full-Stack",
            "09063119790",
            "myraignacio753@gmail.com",
            "BS in Information Technology (BSIT)",
            "Cagayan State University - Piat Campus",
            "System Architecture, Database Implementation & Backend Services",
            "Aemyra.jpg",
            darkGreen, cardBg, textDark, subText, oliveGreen)

        ' Developer 2 Card - Racquel Dela Cruz
        Dim cardDev2 As Panel = CreateDevCard(
            "Racquel Dela Cruz",
            "Frontend Developer / UI/UX Designer",
            "09682806653",
            "racqueldelacruz1022@gmail.com",
            "BS in Information Technology (BSIT)",
            "Cagayan State University - Piat Campus",
            "User Interface Design, System Workflows & User Documentation",
            "Racquel.jpg",
            darkGreen, cardBg, textDark, subText, oliveGreen)

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
        lblNoteBody.Text = "Developed for Barangay Sto. Domingo, Piat, Cagayan as an automated document archiving and management solution. Project developed by students of Cagayan State University - Piat Campus."
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

    Private Function CreateDevCard(devName As String,
                                   role As String,
                                   contactNumber As String,
                                   email As String,
                                   course As String,
                                   school As String,
                                   contribution As String,
                                   imageName As String,
                                   headerColor As Color,
                                   cardColor As Color,
                                   textColor As Color,
                                   subTextColor As Color,
                                   accentColor As Color) As Panel

        Dim card As New Panel()
        card.Width = 440
        card.Height = 310
        card.BackColor = cardColor
        card.Margin = New Padding(15)
        card.Padding = New Padding(18)

        ' Photo Container Frame
        Dim pnlPhotoFrame As New Panel()
        pnlPhotoFrame.Size = New Size(92, 112)
        pnlPhotoFrame.Location = New Point(18, 18)
        pnlPhotoFrame.BackColor = headerColor
        pnlPhotoFrame.Padding = New Padding(2)

        Dim devImg As Image = LoadDevImage(imageName)
        If devImg IsNot Nothing Then
            Dim picAvatar As New PictureBox()
            picAvatar.Dock = DockStyle.Fill
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom
            picAvatar.BackColor = Color.White
            picAvatar.Image = devImg
            pnlPhotoFrame.Controls.Add(picAvatar)
        Else
            Dim lblAvatarIcon As New Label()
            lblAvatarIcon.Text = "👩‍💻"
            lblAvatarIcon.Font = New Font("Segoe UI Emoji", 26)
            lblAvatarIcon.TextAlign = ContentAlignment.MiddleCenter
            lblAvatarIcon.Dock = DockStyle.Fill
            lblAvatarIcon.ForeColor = Color.White
            lblAvatarIcon.BackColor = headerColor
            pnlPhotoFrame.Controls.Add(lblAvatarIcon)
        End If

        ' Developer Name
        Dim lblName As New Label()
        lblName.Text = devName
        lblName.Font = New Font("Segoe UI", 12.5F, FontStyle.Bold)
        lblName.ForeColor = headerColor
        lblName.Location = New Point(120, 18)
        lblName.Size = New Size(300, 26)

        ' Developer Role
        Dim lblRole As New Label()
        lblRole.Text = role
        lblRole.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblRole.ForeColor = accentColor
        lblRole.Location = New Point(120, 44)
        lblRole.Size = New Size(300, 20)

        ' Program / Course
        Dim lblCourseVal As New Label()
        lblCourseVal.Text = course
        lblCourseVal.Font = New Font("Segoe UI", 8.5F, FontStyle.Regular)
        lblCourseVal.ForeColor = textColor
        lblCourseVal.Location = New Point(120, 66)
        lblCourseVal.Size = New Size(300, 18)

        ' School / Campus
        Dim lblSchoolVal As New Label()
        lblSchoolVal.Text = school
        lblSchoolVal.Font = New Font("Segoe UI", 8F, FontStyle.Italic)
        lblSchoolVal.ForeColor = subTextColor
        lblSchoolVal.Location = New Point(120, 86)
        lblSchoolVal.Size = New Size(300, 18)

        ' Status Tag
        Dim lblStatus As New Label()
        lblStatus.Text = "● Active Contributor"
        lblStatus.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblStatus.ForeColor = headerColor
        lblStatus.Location = New Point(120, 106)
        lblStatus.Size = New Size(300, 18)

        ' Divider Line
        Dim pnlDivider As New Panel()
        pnlDivider.Location = New Point(18, 138)
        pnlDivider.Size = New Size(404, 2)
        pnlDivider.BackColor = Color.FromArgb(200, 195, 150)

        ' Field: Contact Number
        Dim lblContactTitle As New Label()
        lblContactTitle.Text = "CONTACT NUMBER:"
        lblContactTitle.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        lblContactTitle.ForeColor = subTextColor
        lblContactTitle.Location = New Point(18, 148)
        lblContactTitle.Size = New Size(404, 15)

        Dim lblContactVal As New Label()
        lblContactVal.Text = contactNumber
        lblContactVal.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular)
        lblContactVal.ForeColor = textColor
        lblContactVal.Location = New Point(18, 163)
        lblContactVal.Size = New Size(404, 20)

        ' Field: Email / Gmail
        Dim lblEmailTitle As New Label()
        lblEmailTitle.Text = "GMAIL / CONTACT EMAIL:"
        lblEmailTitle.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        lblEmailTitle.ForeColor = subTextColor
        lblEmailTitle.Location = New Point(18, 188)
        lblEmailTitle.Size = New Size(404, 15)

        Dim lblEmailVal As New Label()
        lblEmailVal.Text = email
        lblEmailVal.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular)
        lblEmailVal.ForeColor = textColor
        lblEmailVal.Location = New Point(18, 203)
        lblEmailVal.Size = New Size(404, 20)

        ' Field: Contribution / Key Responsibilities
        Dim lblContribTitle As New Label()
        lblContribTitle.Text = "KEY RESPONSIBILITIES:"
        lblContribTitle.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        lblContribTitle.ForeColor = subTextColor
        lblContribTitle.Location = New Point(18, 228)
        lblContribTitle.Size = New Size(404, 15)

        Dim lblContribVal As New Label()
        lblContribVal.Text = contribution
        lblContribVal.Font = New Font("Segoe UI", 9F, FontStyle.Regular)
        lblContribVal.ForeColor = textColor
        lblContribVal.Location = New Point(18, 243)
        lblContribVal.Size = New Size(404, 42)

        card.Controls.Add(pnlPhotoFrame)
        card.Controls.Add(lblName)
        card.Controls.Add(lblRole)
        card.Controls.Add(lblCourseVal)
        card.Controls.Add(lblSchoolVal)
        card.Controls.Add(lblStatus)
        card.Controls.Add(pnlDivider)
        card.Controls.Add(lblContactTitle)
        card.Controls.Add(lblContactVal)
        card.Controls.Add(lblEmailTitle)
        card.Controls.Add(lblEmailVal)
        card.Controls.Add(lblContribTitle)
        card.Controls.Add(lblContribVal)

        Return card
    End Function

    Private Function LoadDevImage(imageFileName As String) As Image
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
            ' Return Nothing on failure so fallback icon is shown safely
        End Try
        Return Nothing
    End Function

End Class
