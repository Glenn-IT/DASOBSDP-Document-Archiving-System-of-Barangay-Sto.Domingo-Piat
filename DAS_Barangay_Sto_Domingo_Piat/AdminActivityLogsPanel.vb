Public Class AdminActivityLogsPanel
    Inherits System.Windows.Forms.UserControl

    Private pnlFilter       As New System.Windows.Forms.Panel()
    Private dtpFrom         As New System.Windows.Forms.DateTimePicker()
    Private dtpTo           As New System.Windows.Forms.DateTimePicker()
    Private txtUserFilter   As New System.Windows.Forms.TextBox()
    Private btnFilterSearch As New System.Windows.Forms.Button()

    Public Sub New()
        InitializeComponent()
        BuildFilterBar()
    End Sub

    Private Sub BuildFilterBar()
        Dim cream As System.Drawing.Color = System.Drawing.Color.FromArgb(242, 237, 194)
        Dim dark  As System.Drawing.Color = System.Drawing.Color.FromArgb(52, 103, 57)
        Dim font  As New System.Drawing.Font("Segoe UI", 9)

        pnlFilter.Dock      = System.Windows.Forms.DockStyle.Top
        pnlFilter.Height    = 48
        pnlFilter.BackColor = cream
        pnlFilter.Padding   = New System.Windows.Forms.Padding(12, 8, 12, 8)

        Dim lblFrom As New System.Windows.Forms.Label() With {
            .Text      = "From:",
            .AutoSize  = True,
            .Font      = font,
            .ForeColor = dark,
            .Location  = New System.Drawing.Point(12, 14)
        }

        dtpFrom.Format   = System.Windows.Forms.DateTimePickerFormat.Short
        dtpFrom.Value    = Now.AddMonths(-1)
        dtpFrom.Font     = font
        dtpFrom.Size     = New System.Drawing.Size(110, 28)
        dtpFrom.Location = New System.Drawing.Point(52, 10)

        Dim lblTo As New System.Windows.Forms.Label() With {
            .Text      = "To:",
            .AutoSize  = True,
            .Font      = font,
            .ForeColor = dark,
            .Location  = New System.Drawing.Point(172, 14)
        }

        dtpTo.Format   = System.Windows.Forms.DateTimePickerFormat.Short
        dtpTo.Value    = Now
        dtpTo.Font     = font
        dtpTo.Size     = New System.Drawing.Size(110, 28)
        dtpTo.Location = New System.Drawing.Point(196, 10)

        Dim lblUser As New System.Windows.Forms.Label() With {
            .Text      = "Username:",
            .AutoSize  = True,
            .Font      = font,
            .ForeColor = dark,
            .Location  = New System.Drawing.Point(320, 14)
        }

        txtUserFilter.Font      = font
        txtUserFilter.Size      = New System.Drawing.Size(140, 28)
        txtUserFilter.Location  = New System.Drawing.Point(400, 10)
        txtUserFilter.BackColor = cream
        txtUserFilter.ForeColor = dark

        btnFilterSearch.Text      = "Search"
        btnFilterSearch.Font      = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        btnFilterSearch.Size      = New System.Drawing.Size(80, 28)
        btnFilterSearch.Location  = New System.Drawing.Point(552, 10)
        btnFilterSearch.BackColor = System.Drawing.Color.FromArgb(52, 103, 57)
        btnFilterSearch.ForeColor = System.Drawing.Color.White
        btnFilterSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        AddHandler btnFilterSearch.Click, AddressOf btnFilterSearch_Click

        pnlFilter.Controls.AddRange(New System.Windows.Forms.Control() {
            lblFrom, dtpFrom, lblTo, dtpTo, lblUser, txtUserFilter, btnFilterSearch
        })

        Me.Controls.Add(pnlFilter)
        Me.Controls.SetChildIndex(pnlFilter, 1)
    End Sub

    Private Sub AdminActivityLogsPanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadLogsFromDB()
    End Sub

    Friend Sub LoadLogsFromDB(Optional fromDate As DateTime = Nothing,
                               Optional toDate   As DateTime = Nothing,
                               Optional username As String   = Nothing)
        dgvActivityLogs.Rows.Clear()
        Try
            Dim dt As DataTable = ActivityLogRepository.GetAll(fromDate, toDate, username)
            For Each row As DataRow In dt.Rows
                dgvActivityLogs.Rows.Add(
                    row("LogCode").ToString(),
                    row("Username").ToString(),
                    Convert.ToDateTime(row("LogDate")).ToString("yyyy-MM-dd HH:mm"),
                    row("Result").ToString(),
                    row("Description").ToString()
                )
            Next
        Catch ex As Exception
            MessageBox.Show("Error loading logs: " & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnFilterSearch_Click(sender As Object, e As EventArgs)
        Dim usernameFilter As String = InputHelper.SanitizeInput(txtUserFilter.Text)
        LoadLogsFromDB(
            fromDate := dtpFrom.Value.Date,
            toDate   := dtpTo.Value.Date,
            username := If(usernameFilter = "", Nothing, usernameFilter)
        )
    End Sub

End Class
