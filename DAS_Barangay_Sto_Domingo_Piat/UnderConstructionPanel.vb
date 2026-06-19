Public Class UnderConstructionPanel
    Inherits System.Windows.Forms.UserControl

    Public Sub New()
        Me.BackColor = Drawing.Color.FromArgb(242, 237, 194)
        Me.Dock = DockStyle.Fill
        BuildUI()
    End Sub

    Private Sub BuildUI()
        Dim tbl As New TableLayoutPanel()
        tbl.Dock = DockStyle.Fill
        tbl.BackColor = Drawing.Color.Transparent
        tbl.RowCount = 1
        tbl.ColumnCount = 1
        tbl.RowStyles.Add(New RowStyle(SizeType.Percent, 100))
        tbl.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100))

        Dim inner As New FlowLayoutPanel()
        inner.AutoSize = True
        inner.AutoSizeMode = AutoSizeMode.GrowAndShrink
        inner.FlowDirection = FlowDirection.TopDown
        inner.WrapContents = False
        inner.BackColor = Drawing.Color.Transparent
        inner.Anchor = AnchorStyles.None

        Dim lblEmoji As New Label()
        lblEmoji.Text = "🚧"
        lblEmoji.Font = New Drawing.Font("Segoe UI Emoji", 52, Drawing.FontStyle.Regular)
        lblEmoji.ForeColor = Drawing.Color.FromArgb(52, 103, 57)
        lblEmoji.AutoSize = False
        lblEmoji.Width = 520
        lblEmoji.Height = 80
        lblEmoji.TextAlign = ContentAlignment.MiddleCenter

        Dim lblTitle As New Label()
        lblTitle.Text = "Under Construction"
        lblTitle.Font = New Drawing.Font("Segoe UI", 26, Drawing.FontStyle.Bold)
        lblTitle.ForeColor = Drawing.Color.FromArgb(40, 80, 44)
        lblTitle.AutoSize = False
        lblTitle.Width = 520
        lblTitle.Height = 50
        lblTitle.TextAlign = ContentAlignment.MiddleCenter

        Dim lblVersion As New Label()
        lblVersion.Text = "Current Version: " & CURRENT_VERSION
        lblVersion.Font = New Drawing.Font("Segoe UI", 13, Drawing.FontStyle.Regular)
        lblVersion.ForeColor = Drawing.Color.FromArgb(52, 103, 57)
        lblVersion.AutoSize = False
        lblVersion.Width = 520
        lblVersion.Height = 34
        lblVersion.TextAlign = ContentAlignment.MiddleCenter

        Dim lblDesc As New Label()
        lblDesc.Text = "This feature is not yet available in the current presentation version."
        lblDesc.Font = New Drawing.Font("Segoe UI", 10, Drawing.FontStyle.Regular)
        lblDesc.ForeColor = Drawing.Color.FromArgb(100, 130, 100)
        lblDesc.AutoSize = False
        lblDesc.Width = 520
        lblDesc.Height = 30
        lblDesc.TextAlign = ContentAlignment.MiddleCenter

        inner.Controls.AddRange({lblEmoji, lblTitle, lblVersion, lblDesc})
        tbl.Controls.Add(inner, 0, 0)
        Me.Controls.Add(tbl)
    End Sub

End Class
