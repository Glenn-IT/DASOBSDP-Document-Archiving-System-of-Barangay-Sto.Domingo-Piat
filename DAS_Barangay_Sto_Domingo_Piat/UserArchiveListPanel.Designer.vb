<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserArchiveListPanel
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
        dgvUserArchiveList = New System.Windows.Forms.DataGridView()
        colDocID           = New System.Windows.Forms.DataGridViewTextBoxColumn()
        colDocTitle        = New System.Windows.Forms.DataGridViewTextBoxColumn()
        colDateTime        = New System.Windows.Forms.DataGridViewTextBoxColumn()
        colRemarks         = New System.Windows.Forms.DataGridViewTextBoxColumn()
        colStatus          = New System.Windows.Forms.DataGridViewTextBoxColumn()
        pnlTop             = New System.Windows.Forms.Panel()
        lblTitle           = New System.Windows.Forms.Label()
        txtSearch          = New System.Windows.Forms.TextBox()
        btnSearch          = New System.Windows.Forms.Button()
        pnlActions         = New System.Windows.Forms.Panel()
        btnDeleteDocument  = New System.Windows.Forms.Button()
        btnPrintDocument   = New System.Windows.Forms.Button()
        btnViewDocument    = New System.Windows.Forms.Button()
        lblTotalDocs       = New System.Windows.Forms.Label()
        cmbDocTypeFilter   = New System.Windows.Forms.ComboBox()
        chkFilterDate      = New System.Windows.Forms.CheckBox()
        dtpDateFrom        = New System.Windows.Forms.DateTimePicker()
        lblDateTo          = New System.Windows.Forms.Label()
        dtpDateTo          = New System.Windows.Forms.DateTimePicker()
        btnResetFilter     = New System.Windows.Forms.Button()

        Me.SuspendLayout()

        Dim dark  As System.Drawing.Color = System.Drawing.Color.FromArgb(52, 103, 57)
        Dim mid   As System.Drawing.Color = System.Drawing.Color.FromArgb(121, 174, 111)
        Dim cream As System.Drawing.Color = System.Drawing.Color.FromArgb(242, 237, 194)

        ' ?? pnlTop ????????????????????????????????????????????????
        pnlTop.BackColor = mid
        pnlTop.Dock      = System.Windows.Forms.DockStyle.Top
        pnlTop.Height    = 52
        pnlTop.Name      = "pnlTop"

        lblTitle.AutoSize  = False
        lblTitle.Text      = "Archive List"
        lblTitle.Font      = New System.Drawing.Font("Segoe UI", 13, System.Drawing.FontStyle.Bold)
        lblTitle.ForeColor = System.Drawing.Color.White
        lblTitle.BackColor = System.Drawing.Color.Transparent
        lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblTitle.Size      = New System.Drawing.Size(260, 52)
        lblTitle.Location  = New System.Drawing.Point(16, 0)
        lblTitle.Name      = "lblTitle"

        txtSearch.Font            = New System.Drawing.Font("Segoe UI", 10)
        txtSearch.Size            = New System.Drawing.Size(220, 30)
        txtSearch.Location        = New System.Drawing.Point(340, 11)
        txtSearch.BackColor       = cream
        txtSearch.ForeColor       = dark
        txtSearch.BorderStyle     = System.Windows.Forms.BorderStyle.FixedSingle
        txtSearch.PlaceholderText = "Search documents..."
        txtSearch.Anchor          = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
        txtSearch.Name            = "txtSearch"
        txtSearch.TabIndex        = 0

        btnSearch.Text                              = "Search"
        btnSearch.Font                              = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        btnSearch.BackColor                         = dark
        btnSearch.ForeColor                         = cream
        btnSearch.FlatStyle                         = System.Windows.Forms.FlatStyle.Flat
        btnSearch.FlatAppearance.BorderSize         = 0
        btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 80, 44)
        btnSearch.Size                              = New System.Drawing.Size(80, 30)
        btnSearch.Location                          = New System.Drawing.Point(568, 11)
        btnSearch.Anchor                            = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
        btnSearch.Cursor                            = System.Windows.Forms.Cursors.Hand
        btnSearch.Name                              = "btnSearch"
        btnSearch.TabIndex                          = 1

        pnlTop.Controls.Add(lblTitle)
        pnlTop.Controls.Add(txtSearch)
        pnlTop.Controls.Add(btnSearch)

        ' ?? pnlActions ????????????????????????????????????????????
        pnlActions.BackColor = cream
        pnlActions.Dock      = System.Windows.Forms.DockStyle.Bottom
        pnlActions.Height    = 60
        pnlActions.Name      = "pnlActions"
        pnlActions.Padding   = New System.Windows.Forms.Padding(12, 10, 12, 10)

        btnDeleteDocument.Text                              = "Delete"
        btnDeleteDocument.Font                              = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        btnDeleteDocument.BackColor                         = System.Drawing.Color.FromArgb(192, 57, 43)
        btnDeleteDocument.ForeColor                         = System.Drawing.Color.White
        btnDeleteDocument.FlatStyle                         = System.Windows.Forms.FlatStyle.Flat
        btnDeleteDocument.FlatAppearance.BorderSize         = 0
        btnDeleteDocument.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(220, 80, 60)
        btnDeleteDocument.Size                              = New System.Drawing.Size(120, 38)
        btnDeleteDocument.Location                          = New System.Drawing.Point(12, 11)
        btnDeleteDocument.Cursor                            = System.Windows.Forms.Cursors.Hand
        btnDeleteDocument.Name                              = "btnDeleteDocument"
        btnDeleteDocument.TabIndex                          = 0

        btnPrintDocument.Text = "🖨️ Print"
        btnPrintDocument.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        btnPrintDocument.BackColor = System.Drawing.Color.FromArgb(70, 130, 80)
        btnPrintDocument.ForeColor = System.Drawing.Color.White
        btnPrintDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnPrintDocument.FlatAppearance.BorderSize = 0
        btnPrintDocument.Size = New System.Drawing.Size(110, 38)
        btnPrintDocument.Location = New System.Drawing.Point(140, 11)
        btnPrintDocument.Cursor = System.Windows.Forms.Cursors.Hand

        btnViewDocument.Text = "View"
        btnViewDocument.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        btnViewDocument.BackColor = mid
        btnViewDocument.ForeColor = System.Drawing.Color.White
        btnViewDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnViewDocument.FlatAppearance.BorderSize = 0
        btnViewDocument.Size = New System.Drawing.Size(100, 38)
        btnViewDocument.Location = New System.Drawing.Point(258, 11)
        btnViewDocument.Cursor = System.Windows.Forms.Cursors.Hand

        lblTotalDocs.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
        lblTotalDocs.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
        lblTotalDocs.ForeColor = dark
        lblTotalDocs.Location = New System.Drawing.Point(540, 16)
        lblTotalDocs.Size = New System.Drawing.Size(320, 28)
        lblTotalDocs.Text = "Total Documents: 0"
        lblTotalDocs.TextAlign = System.Drawing.ContentAlignment.MiddleRight

        pnlActions.Controls.Add(btnDeleteDocument)
        pnlActions.Controls.Add(btnPrintDocument)
        pnlActions.Controls.Add(btnViewDocument)
        pnlActions.Controls.Add(lblTotalDocs)

        ' ?? dgvUserArchiveList ????????????????????????????????????
        dgvUserArchiveList.Dock                  = System.Windows.Forms.DockStyle.Fill
        dgvUserArchiveList.Name                  = "dgvUserArchiveList"
        dgvUserArchiveList.ReadOnly              = True
        dgvUserArchiveList.AllowUserToAddRows    = False
        dgvUserArchiveList.AllowUserToDeleteRows = False
        dgvUserArchiveList.SelectionMode         = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        dgvUserArchiveList.MultiSelect           = False
        dgvUserArchiveList.RowHeadersVisible     = False
        dgvUserArchiveList.AutoSizeColumnsMode   = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        dgvUserArchiveList.BackgroundColor       = cream
        dgvUserArchiveList.BorderStyle           = System.Windows.Forms.BorderStyle.None
        dgvUserArchiveList.GridColor             = System.Drawing.Color.FromArgb(159, 203, 152)
        dgvUserArchiveList.Font                  = New System.Drawing.Font("Segoe UI", 9)
        dgvUserArchiveList.TabIndex              = 2

        dgvUserArchiveList.ColumnHeadersDefaultCellStyle.BackColor  = dark
        dgvUserArchiveList.ColumnHeadersDefaultCellStyle.ForeColor  = cream
        dgvUserArchiveList.ColumnHeadersDefaultCellStyle.Font       = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        dgvUserArchiveList.ColumnHeadersDefaultCellStyle.Alignment  = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        dgvUserArchiveList.ColumnHeadersHeight                      = 36
        dgvUserArchiveList.ColumnHeadersHeightSizeMode              = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvUserArchiveList.EnableHeadersVisualStyles                = False

        dgvUserArchiveList.DefaultCellStyle.BackColor          = cream
        dgvUserArchiveList.DefaultCellStyle.ForeColor          = dark
        dgvUserArchiveList.DefaultCellStyle.SelectionBackColor = mid
        dgvUserArchiveList.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        dgvUserArchiveList.DefaultCellStyle.Alignment         = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        dgvUserArchiveList.RowTemplate.Height                 = 32
        dgvUserArchiveList.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(230, 226, 180)

        colDocID.Name       = "colDocID"    : colDocID.HeaderText    = "Document ID"    : colDocID.FillWeight    = 14
        colDocTitle.Name    = "colDocTitle" : colDocTitle.HeaderText  = "Document Title"  : colDocTitle.FillWeight  = 34
        colDocTitle.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        colDateTime.Name    = "colDateTime" : colDateTime.HeaderText  = "Date and Time"   : colDateTime.FillWeight  = 20
        colRemarks.Name     = "colRemarks"  : colRemarks.HeaderText   = "Remarks"          : colRemarks.FillWeight   = 18
        colStatus.Name      = "colStatus"   : colStatus.HeaderText    = "Status"           : colStatus.FillWeight    = 14

        dgvUserArchiveList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {
            colDocID, colDocTitle, colDateTime, colRemarks, colStatus
        })

        Me.Controls.Add(dgvUserArchiveList)
        Me.Controls.Add(pnlActions)
        Me.Controls.Add(pnlTop)
        Me.BackColor     = cream
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name          = "UserArchiveListPanel"
        Me.Size          = New System.Drawing.Size(880, 596)

        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents dgvUserArchiveList As System.Windows.Forms.DataGridView
    Friend WithEvents colDocID           As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDocTitle        As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDateTime        As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRemarks         As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus          As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnlTop             As System.Windows.Forms.Panel
    Friend WithEvents lblTitle           As System.Windows.Forms.Label
    Friend WithEvents txtSearch          As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch          As System.Windows.Forms.Button
    Friend WithEvents pnlActions         As System.Windows.Forms.Panel
    Friend WithEvents btnDeleteDocument  As System.Windows.Forms.Button
    Friend WithEvents btnPrintDocument   As System.Windows.Forms.Button
    Friend WithEvents btnViewDocument    As System.Windows.Forms.Button
    Friend WithEvents lblTotalDocs       As System.Windows.Forms.Label
    Friend WithEvents cmbDocTypeFilter   As System.Windows.Forms.ComboBox
    Friend WithEvents chkFilterDate      As System.Windows.Forms.CheckBox
    Friend WithEvents dtpDateFrom        As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDateTo          As System.Windows.Forms.Label
    Friend WithEvents dtpDateTo          As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnResetFilter     As System.Windows.Forms.Button

End Class
