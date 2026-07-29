<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminDocumentTypesPanel
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
        pnlTop = New Panel()
        lblTitle = New Label()
        pnlCardGrid = New FlowLayoutPanel()
        pnlTop.SuspendLayout()
        SuspendLayout()
        '
        ' pnlTop
        '
        pnlTop.BackColor = Color.FromArgb(CByte(121), CByte(174), CByte(111))
        pnlTop.Controls.Add(lblTitle)
        pnlTop.Dock = DockStyle.Top
        pnlTop.Location = New Point(0, 0)
        pnlTop.Name = "pnlTop"
        pnlTop.Size = New Size(1297, 52)
        pnlTop.TabIndex = 1
        '
        ' lblTitle
        '
        lblTitle.BackColor = Color.Transparent
        lblTitle.Dock = DockStyle.Fill
        lblTitle.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(0, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Padding = New Padding(16, 0, 0, 0)
        lblTitle.Size = New Size(1297, 52)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Document Types"
        lblTitle.TextAlign = ContentAlignment.MiddleLeft
        '
        ' pnlCardGrid
        '
        pnlCardGrid.AutoScroll = True
        pnlCardGrid.BackColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        pnlCardGrid.Dock = DockStyle.Fill
        pnlCardGrid.FlowDirection = FlowDirection.LeftToRight
        pnlCardGrid.Location = New Point(0, 52)
        pnlCardGrid.Name = "pnlCardGrid"
        pnlCardGrid.Padding = New Padding(20)
        pnlCardGrid.Size = New Size(1297, 544)
        pnlCardGrid.TabIndex = 0
        pnlCardGrid.WrapContents = True
        '
        ' AdminDocumentTypesPanel
        '
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        Controls.Add(pnlCardGrid)
        Controls.Add(pnlTop)
        Name = "AdminDocumentTypesPanel"
        Size = New Size(1297, 596)
        pnlTop.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTop      As System.Windows.Forms.Panel
    Friend WithEvents lblTitle    As System.Windows.Forms.Label
    Friend WithEvents pnlCardGrid As System.Windows.Forms.FlowLayoutPanel

End Class
