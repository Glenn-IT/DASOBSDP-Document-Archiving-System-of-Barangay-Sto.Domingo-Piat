<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminDashboardPanel
    Inherits System.Windows.Forms.UserControl

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlTop = New System.Windows.Forms.Panel()
        lblTitle = New System.Windows.Forms.Label()
        pnlTopRight = New System.Windows.Forms.Panel()
        btnPrintReport = New System.Windows.Forms.Button()
        pnlBody = New System.Windows.Forms.Panel()
        lblGreeting = New System.Windows.Forms.Label()
        lblSubGreeting = New System.Windows.Forms.Label()
        pnlCards = New System.Windows.Forms.Panel()

        ' Card 1 - Total Documents
        pnlCardTotal = New System.Windows.Forms.Panel()
        lblTotalTitle = New System.Windows.Forms.Label()
        lblTotalCount = New System.Windows.Forms.Label()
        lblTotalSub = New System.Windows.Forms.Label()

        ' Card 2 - Recent Upload
        pnlCardRecent = New System.Windows.Forms.Panel()
        lblRecentTitle = New System.Windows.Forms.Label()
        lblRecentCount = New System.Windows.Forms.Label()
        lblRecentSub = New System.Windows.Forms.Label()

        ' Card 3 - Pending for Approval
        pnlCardPending = New System.Windows.Forms.Panel()
        lblPendingTitle = New System.Windows.Forms.Label()
        lblPendingCount = New System.Windows.Forms.Label()
        lblPendingSub = New System.Windows.Forms.Label()

        ' Card 4 - Print Report Action Card
        pnlCardPrint = New System.Windows.Forms.Panel()
        lblPrintTitle = New System.Windows.Forms.Label()
        lblPrintIcon = New System.Windows.Forms.Label()
        lblPrintSub = New System.Windows.Forms.Label()

        pnlTop.SuspendLayout()
        pnlTopRight.SuspendLayout()
        pnlBody.SuspendLayout()
        pnlCards.SuspendLayout()
        pnlCardTotal.SuspendLayout()
        pnlCardRecent.SuspendLayout()
        pnlCardPending.SuspendLayout()
        pnlCardPrint.SuspendLayout()
        Me.SuspendLayout()

        Dim dark As System.Drawing.Color = System.Drawing.Color.FromArgb(52, 103, 57)
        Dim mid As System.Drawing.Color = System.Drawing.Color.FromArgb(121, 174, 111)
        Dim cream As System.Drawing.Color = System.Drawing.Color.FromArgb(242, 237, 194)
        Dim amber As System.Drawing.Color = System.Drawing.Color.FromArgb(211, 152, 34)
        Dim teal As System.Drawing.Color = System.Drawing.Color.FromArgb(32, 148, 148)
        Dim printGreen As System.Drawing.Color = System.Drawing.Color.FromArgb(40, 92, 50)
        Dim cardW As Integer = 260
        Dim cardH As Integer = 160

        ' ── pnlTop ────────────────────────────────────────────────
        pnlTop.BackColor = mid
        pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        pnlTop.Height = 52
        pnlTop.Name = "pnlTop"

        ' lblTitle (left-aligned)
        lblTitle.Dock = System.Windows.Forms.DockStyle.Left
        lblTitle.Text = "Dashboard"
        lblTitle.Font = New System.Drawing.Font("Segoe UI", 13, System.Drawing.FontStyle.Bold)
        lblTitle.ForeColor = System.Drawing.Color.White
        lblTitle.BackColor = System.Drawing.Color.Transparent
        lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblTitle.Width = 250
        lblTitle.Padding = New System.Windows.Forms.Padding(16, 0, 0, 0)
        lblTitle.Name = "lblTitle"

        ' pnlTopRight (right-docked container for print button)
        pnlTopRight.Dock = System.Windows.Forms.DockStyle.Right
        pnlTopRight.Width = 230
        pnlTopRight.BackColor = System.Drawing.Color.Transparent
        pnlTopRight.Padding = New System.Windows.Forms.Padding(0, 8, 16, 8)
        pnlTopRight.Name = "pnlTopRight"

        ' btnPrintReport (docked inside pnlTopRight)
        btnPrintReport.Text = "🖨️  Print Report (PDF)"
        btnPrintReport.Font = New System.Drawing.Font("Segoe UI", 9.5, System.Drawing.FontStyle.Bold)
        btnPrintReport.BackColor = dark
        btnPrintReport.ForeColor = cream
        btnPrintReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnPrintReport.FlatAppearance.BorderSize = 1
        btnPrintReport.FlatAppearance.BorderColor = cream
        btnPrintReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(30, 65, 34)
        btnPrintReport.Dock = System.Windows.Forms.DockStyle.Fill
        btnPrintReport.Cursor = System.Windows.Forms.Cursors.Hand
        btnPrintReport.Name = "btnPrintReport"

        pnlTopRight.Controls.Add(btnPrintReport)
        pnlTop.Controls.Add(lblTitle)
        pnlTop.Controls.Add(pnlTopRight)

        ' ── pnlBody ───────────────────────────────────────────────
        pnlBody.BackColor = cream
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
        pnlBody.AutoScroll = True
        pnlBody.Name = "pnlBody"

        ' Greeting
        lblGreeting.AutoSize = False
        lblGreeting.Text = "Welcome back!"
        lblGreeting.Font = New System.Drawing.Font("Segoe UI", 18, System.Drawing.FontStyle.Bold)
        lblGreeting.ForeColor = dark
        lblGreeting.BackColor = System.Drawing.Color.Transparent
        lblGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblGreeting.Size = New System.Drawing.Size(700, 48)
        lblGreeting.Location = New System.Drawing.Point(40, 30)
        lblGreeting.Name = "lblGreeting"

        lblSubGreeting.AutoSize = False
        lblSubGreeting.Text = "Here is a summary of the document archive."
        lblSubGreeting.Font = New System.Drawing.Font("Segoe UI", 10)
        lblSubGreeting.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100)
        lblSubGreeting.BackColor = System.Drawing.Color.Transparent
        lblSubGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblSubGreeting.Size = New System.Drawing.Size(700, 28)
        lblSubGreeting.Location = New System.Drawing.Point(40, 78)
        lblSubGreeting.Name = "lblSubGreeting"

        ' ── pnlCards (row of 4 cards) ─────────────────────────────
        pnlCards.BackColor = System.Drawing.Color.Transparent
        pnlCards.Size = New System.Drawing.Size(cardW * 4 + 80, cardH)
        pnlCards.Location = New System.Drawing.Point(40, 130)
        pnlCards.Name = "pnlCards"

        ' ── Card 1: Total Documents (#346739 dark green) ──────────
        pnlCardTotal.BackColor = dark
        pnlCardTotal.Size = New System.Drawing.Size(cardW, cardH)
        pnlCardTotal.Location = New System.Drawing.Point(0, 0)
        pnlCardTotal.Name = "pnlCardTotal"

        lblTotalTitle.AutoSize = False
        lblTotalTitle.Text = "Total Documents"
        lblTotalTitle.Font = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        lblTotalTitle.ForeColor = cream
        lblTotalTitle.BackColor = System.Drawing.Color.Transparent
        lblTotalTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblTotalTitle.Size = New System.Drawing.Size(220, 28)
        lblTotalTitle.Location = New System.Drawing.Point(20, 18)
        lblTotalTitle.Name = "lblTotalTitle"

        lblTotalCount.AutoSize = False
        lblTotalCount.Text = "0"
        lblTotalCount.Font = New System.Drawing.Font("Segoe UI", 36, System.Drawing.FontStyle.Bold)
        lblTotalCount.ForeColor = System.Drawing.Color.White
        lblTotalCount.BackColor = System.Drawing.Color.Transparent
        lblTotalCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblTotalCount.Size = New System.Drawing.Size(220, 72)
        lblTotalCount.Location = New System.Drawing.Point(20, 46)
        lblTotalCount.Name = "lblTotalCount"

        lblTotalSub.AutoSize = False
        lblTotalSub.Text = "All archived documents"
        lblTotalSub.Font = New System.Drawing.Font("Segoe UI", 8)
        lblTotalSub.ForeColor = System.Drawing.Color.FromArgb(159, 203, 152)
        lblTotalSub.BackColor = System.Drawing.Color.Transparent
        lblTotalSub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblTotalSub.Size = New System.Drawing.Size(220, 20)
        lblTotalSub.Location = New System.Drawing.Point(20, 128)
        lblTotalSub.Name = "lblTotalSub"

        pnlCardTotal.Controls.Add(lblTotalTitle)
        pnlCardTotal.Controls.Add(lblTotalCount)
        pnlCardTotal.Controls.Add(lblTotalSub)

        ' ── Card 2: Recent Upload (teal) ──────────────────────────
        pnlCardRecent.BackColor = teal
        pnlCardRecent.Size = New System.Drawing.Size(cardW, cardH)
        pnlCardRecent.Location = New System.Drawing.Point(cardW + 20, 0)
        pnlCardRecent.Name = "pnlCardRecent"

        lblRecentTitle.AutoSize = False
        lblRecentTitle.Text = "Recent Uploads"
        lblRecentTitle.Font = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        lblRecentTitle.ForeColor = System.Drawing.Color.White
        lblRecentTitle.BackColor = System.Drawing.Color.Transparent
        lblRecentTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblRecentTitle.Size = New System.Drawing.Size(220, 28)
        lblRecentTitle.Location = New System.Drawing.Point(20, 18)
        lblRecentTitle.Name = "lblRecentTitle"

        lblRecentCount.AutoSize = False
        lblRecentCount.Text = "0"
        lblRecentCount.Font = New System.Drawing.Font("Segoe UI", 36, System.Drawing.FontStyle.Bold)
        lblRecentCount.ForeColor = System.Drawing.Color.White
        lblRecentCount.BackColor = System.Drawing.Color.Transparent
        lblRecentCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblRecentCount.Size = New System.Drawing.Size(220, 72)
        lblRecentCount.Location = New System.Drawing.Point(20, 46)
        lblRecentCount.Name = "lblRecentCount"

        lblRecentSub.AutoSize = False
        lblRecentSub.Text = "Uploaded in the last 30 days"
        lblRecentSub.Font = New System.Drawing.Font("Segoe UI", 8)
        lblRecentSub.ForeColor = System.Drawing.Color.FromArgb(180, 230, 230)
        lblRecentSub.BackColor = System.Drawing.Color.Transparent
        lblRecentSub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblRecentSub.Size = New System.Drawing.Size(220, 20)
        lblRecentSub.Location = New System.Drawing.Point(20, 128)
        lblRecentSub.Name = "lblRecentSub"

        pnlCardRecent.Controls.Add(lblRecentTitle)
        pnlCardRecent.Controls.Add(lblRecentCount)
        pnlCardRecent.Controls.Add(lblRecentSub)

        ' ── Card 3: Pending for Approval (amber) ──────────────────
        pnlCardPending.BackColor = amber
        pnlCardPending.Size = New System.Drawing.Size(cardW, cardH)
        pnlCardPending.Location = New System.Drawing.Point((cardW + 20) * 2, 0)
        pnlCardPending.Name = "pnlCardPending"

        lblPendingTitle.AutoSize = False
        lblPendingTitle.Text = "Pending for Approval"
        lblPendingTitle.Font = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        lblPendingTitle.ForeColor = System.Drawing.Color.White
        lblPendingTitle.BackColor = System.Drawing.Color.Transparent
        lblPendingTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblPendingTitle.Size = New System.Drawing.Size(220, 28)
        lblPendingTitle.Location = New System.Drawing.Point(20, 18)
        lblPendingTitle.Name = "lblPendingTitle"

        lblPendingCount.AutoSize = False
        lblPendingCount.Text = "0"
        lblPendingCount.Font = New System.Drawing.Font("Segoe UI", 36, System.Drawing.FontStyle.Bold)
        lblPendingCount.ForeColor = System.Drawing.Color.White
        lblPendingCount.BackColor = System.Drawing.Color.Transparent
        lblPendingCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblPendingCount.Size = New System.Drawing.Size(220, 72)
        lblPendingCount.Location = New System.Drawing.Point(20, 46)
        lblPendingCount.Name = "lblPendingCount"

        lblPendingSub.AutoSize = False
        lblPendingSub.Text = "Documents awaiting review"
        lblPendingSub.Font = New System.Drawing.Font("Segoe UI", 8)
        lblPendingSub.ForeColor = System.Drawing.Color.FromArgb(255, 235, 180)
        lblPendingSub.BackColor = System.Drawing.Color.Transparent
        lblPendingSub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblPendingSub.Size = New System.Drawing.Size(220, 20)
        lblPendingSub.Location = New System.Drawing.Point(20, 128)
        lblPendingSub.Name = "lblPendingSub"

        pnlCardPending.Controls.Add(lblPendingTitle)
        pnlCardPending.Controls.Add(lblPendingCount)
        pnlCardPending.Controls.Add(lblPendingSub)

        ' ── Card 4: Print Report Action Card (printGreen) ──────────
        pnlCardPrint.BackColor = printGreen
        pnlCardPrint.Size = New System.Drawing.Size(cardW, cardH)
        pnlCardPrint.Location = New System.Drawing.Point((cardW + 20) * 3, 0)
        pnlCardPrint.Name = "pnlCardPrint"
        pnlCardPrint.Cursor = System.Windows.Forms.Cursors.Hand

        lblPrintTitle.AutoSize = False
        lblPrintTitle.Text = "Archive Report"
        lblPrintTitle.Font = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        lblPrintTitle.ForeColor = cream
        lblPrintTitle.BackColor = System.Drawing.Color.Transparent
        lblPrintTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblPrintTitle.Size = New System.Drawing.Size(220, 28)
        lblPrintTitle.Location = New System.Drawing.Point(20, 18)
        lblPrintTitle.Name = "lblPrintTitle"

        lblPrintIcon.AutoSize = False
        lblPrintIcon.Text = "🖨️ PDF"
        lblPrintIcon.Font = New System.Drawing.Font("Segoe UI", 28, System.Drawing.FontStyle.Bold)
        lblPrintIcon.ForeColor = System.Drawing.Color.White
        lblPrintIcon.BackColor = System.Drawing.Color.Transparent
        lblPrintIcon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblPrintIcon.Size = New System.Drawing.Size(220, 72)
        lblPrintIcon.Location = New System.Drawing.Point(20, 46)
        lblPrintIcon.Name = "lblPrintIcon"

        lblPrintSub.AutoSize = False
        lblPrintSub.Text = "Click to generate & print report"
        lblPrintSub.Font = New System.Drawing.Font("Segoe UI", 8)
        lblPrintSub.ForeColor = System.Drawing.Color.FromArgb(180, 225, 180)
        lblPrintSub.BackColor = System.Drawing.Color.Transparent
        lblPrintSub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblPrintSub.Size = New System.Drawing.Size(220, 20)
        lblPrintSub.Location = New System.Drawing.Point(20, 128)
        lblPrintSub.Name = "lblPrintSub"

        pnlCardPrint.Controls.Add(lblPrintTitle)
        pnlCardPrint.Controls.Add(lblPrintIcon)
        pnlCardPrint.Controls.Add(lblPrintSub)

        pnlCards.Controls.Add(pnlCardTotal)
        pnlCards.Controls.Add(pnlCardRecent)
        pnlCards.Controls.Add(pnlCardPending)
        pnlCards.Controls.Add(pnlCardPrint)

        pnlBody.Controls.Add(lblGreeting)
        pnlBody.Controls.Add(lblSubGreeting)
        pnlBody.Controls.Add(pnlCards)

        Me.Controls.Add(pnlBody)
        Me.Controls.Add(pnlTop)
        Me.BackColor = cream
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "AdminDashboardPanel"
        Me.Size = New System.Drawing.Size(1200, 650)

        pnlTopRight.ResumeLayout(False)
        pnlTop.ResumeLayout(False)
        pnlCardTotal.ResumeLayout(False)
        pnlCardRecent.ResumeLayout(False)
        pnlCardPending.ResumeLayout(False)
        pnlCardPrint.ResumeLayout(False)
        pnlCards.ResumeLayout(False)
        pnlBody.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pnlTopRight As System.Windows.Forms.Panel
    Friend WithEvents btnPrintReport As System.Windows.Forms.Button
    Friend WithEvents pnlBody As System.Windows.Forms.Panel
    Friend WithEvents lblGreeting As System.Windows.Forms.Label
    Friend WithEvents lblSubGreeting As System.Windows.Forms.Label
    Friend WithEvents pnlCards As System.Windows.Forms.Panel
    Friend WithEvents pnlCardTotal As System.Windows.Forms.Panel
    Friend WithEvents lblTotalTitle As System.Windows.Forms.Label
    Friend WithEvents lblTotalCount As System.Windows.Forms.Label
    Friend WithEvents lblTotalSub As System.Windows.Forms.Label
    Friend WithEvents pnlCardRecent As System.Windows.Forms.Panel
    Friend WithEvents lblRecentTitle As System.Windows.Forms.Label
    Friend WithEvents lblRecentCount As System.Windows.Forms.Label
    Friend WithEvents lblRecentSub As System.Windows.Forms.Label
    Friend WithEvents pnlCardPending As System.Windows.Forms.Panel
    Friend WithEvents lblPendingTitle As System.Windows.Forms.Label
    Friend WithEvents lblPendingCount As System.Windows.Forms.Label
    Friend WithEvents lblPendingSub As System.Windows.Forms.Label
    Friend WithEvents pnlCardPrint As System.Windows.Forms.Panel
    Friend WithEvents lblPrintTitle As System.Windows.Forms.Label
    Friend WithEvents lblPrintIcon As System.Windows.Forms.Label
    Friend WithEvents lblPrintSub As System.Windows.Forms.Label

End Class
