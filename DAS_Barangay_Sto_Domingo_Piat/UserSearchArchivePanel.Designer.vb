<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserSearchArchivePanel
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
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        dgvSearchResults = New DataGridView()
        colDocumentID = New DataGridViewTextBoxColumn()
        colDocID = New DataGridViewTextBoxColumn()
        colDocTitle = New DataGridViewTextBoxColumn()
        colDateTime = New DataGridViewTextBoxColumn()
        colRemarks = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        colView = New DataGridViewButtonColumn()
        pnlTop = New Panel()
        lblTitle = New Label()
        pnlSearch = New Panel()
        txtSearchQuery = New TextBox()
        btnSearch = New Button()
        CType(dgvSearchResults, ComponentModel.ISupportInitialize).BeginInit()
        pnlTop.SuspendLayout()
        pnlSearch.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvSearchResults
        ' 
        dgvSearchResults.AllowUserToAddRows = False
        dgvSearchResults.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(230), CByte(226), CByte(180))
        dgvSearchResults.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        dgvSearchResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSearchResults.BackgroundColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        dgvSearchResults.BorderStyle = BorderStyle.None
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        dgvSearchResults.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        dgvSearchResults.ColumnHeadersHeight = 36
        dgvSearchResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvSearchResults.Columns.AddRange(New DataGridViewColumn() {colDocumentID, colDocID, colDocTitle, colDateTime, colRemarks, colStatus, colView})
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        DataGridViewCellStyle8.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle8.ForeColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        DataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(CByte(121), CByte(174), CByte(111))
        DataGridViewCellStyle8.SelectionForeColor = Color.White
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.False
        dgvSearchResults.DefaultCellStyle = DataGridViewCellStyle8
        dgvSearchResults.Dock = DockStyle.Fill
        dgvSearchResults.EnableHeadersVisualStyles = False
        dgvSearchResults.Font = New Font("Segoe UI", 9F)
        dgvSearchResults.GridColor = Color.FromArgb(CByte(159), CByte(203), CByte(152))
        dgvSearchResults.Location = New Point(0, 104)
        dgvSearchResults.MultiSelect = False
        dgvSearchResults.Name = "dgvSearchResults"
        dgvSearchResults.ReadOnly = True
        dgvSearchResults.RowHeadersVisible = False
        dgvSearchResults.RowHeadersWidth = 45
        dgvSearchResults.RowTemplate.Height = 32
        dgvSearchResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSearchResults.Size = New Size(1013, 554)
        dgvSearchResults.TabIndex = 2
        ' 
        ' colDocumentID
        ' 
        colDocumentID.HeaderText = "DocumentID"
        colDocumentID.MinimumWidth = 6
        colDocumentID.Name = "colDocumentID"
        colDocumentID.ReadOnly = True
        colDocumentID.Visible = False
        ' 
        ' colDocID
        ' 
        colDocID.FillWeight = 14F
        colDocID.HeaderText = "Document ID"
        colDocID.MinimumWidth = 6
        colDocID.Name = "colDocID"
        colDocID.ReadOnly = True
        ' 
        ' colDocTitle
        ' 
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        colDocTitle.DefaultCellStyle = DataGridViewCellStyle7
        colDocTitle.FillWeight = 34F
        colDocTitle.HeaderText = "Document Title"
        colDocTitle.MinimumWidth = 6
        colDocTitle.Name = "colDocTitle"
        colDocTitle.ReadOnly = True
        ' 
        ' colDateTime
        ' 
        colDateTime.FillWeight = 20F
        colDateTime.HeaderText = "Date and Time"
        colDateTime.MinimumWidth = 6
        colDateTime.Name = "colDateTime"
        colDateTime.ReadOnly = True
        ' 
        ' colRemarks
        ' 
        colRemarks.FillWeight = 18F
        colRemarks.HeaderText = "Remarks"
        colRemarks.MinimumWidth = 6
        colRemarks.Name = "colRemarks"
        colRemarks.ReadOnly = True
        ' 
        ' colStatus
        ' 
        colStatus.FillWeight = 14F
        colStatus.HeaderText = "Status"
        colStatus.MinimumWidth = 6
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        ' 
        ' colView
        ' 
        colView.FillWeight = 10F
        colView.HeaderText = "Action"
        colView.MinimumWidth = 64
        colView.Name = "colView"
        colView.ReadOnly = True
        colView.Text = "View"
        colView.UseColumnTextForButtonValue = True
        ' 
        ' pnlTop
        ' 
        pnlTop.BackColor = Color.FromArgb(CByte(121), CByte(174), CByte(111))
        pnlTop.Controls.Add(lblTitle)
        pnlTop.Dock = DockStyle.Top
        pnlTop.Location = New Point(0, 0)
        pnlTop.Name = "pnlTop"
        pnlTop.Size = New Size(1013, 52)
        pnlTop.TabIndex = 4
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
        lblTitle.Size = New Size(1013, 52)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Search Archive"
        lblTitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pnlSearch
        ' 
        pnlSearch.BackColor = Color.FromArgb(CByte(230), CByte(226), CByte(180))
        pnlSearch.Controls.Add(txtSearchQuery)
        pnlSearch.Controls.Add(btnSearch)
        pnlSearch.Dock = DockStyle.Top
        pnlSearch.Location = New Point(0, 52)
        pnlSearch.Name = "pnlSearch"
        pnlSearch.Padding = New Padding(16, 10, 16, 10)
        pnlSearch.Size = New Size(1013, 52)
        pnlSearch.TabIndex = 3
        ' 
        ' txtSearchQuery
        ' 
        txtSearchQuery.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtSearchQuery.BackColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        txtSearchQuery.BorderStyle = BorderStyle.FixedSingle
        txtSearchQuery.Font = New Font("Segoe UI", 10F)
        txtSearchQuery.ForeColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        txtSearchQuery.Location = New Point(3, 12)
        txtSearchQuery.Name = "txtSearchQuery"
        txtSearchQuery.PlaceholderText = "Type to search documents..."
        txtSearchQuery.Size = New Size(264, 27)
        txtSearchQuery.TabIndex = 0
        ' 
        ' btnSearch
        ' 
        btnSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSearch.BackColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        btnSearch.Cursor = Cursors.Hand
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(121), CByte(174), CByte(111))
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnSearch.ForeColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        btnSearch.Location = New Point(273, 11)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(90, 32)
        btnSearch.TabIndex = 1
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' UserSearchArchivePanel
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        Controls.Add(dgvSearchResults)
        Controls.Add(pnlSearch)
        Controls.Add(pnlTop)
        Name = "UserSearchArchivePanel"
        Size = New Size(1013, 658)
        CType(dgvSearchResults, ComponentModel.ISupportInitialize).EndInit()
        pnlTop.ResumeLayout(False)
        pnlSearch.ResumeLayout(False)
        pnlSearch.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvSearchResults As System.Windows.Forms.DataGridView
    Friend WithEvents colDocumentID    As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDocID         As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDocTitle      As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDateTime      As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRemarks       As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus        As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colView          As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents pnlTop           As System.Windows.Forms.Panel
    Friend WithEvents lblTitle         As System.Windows.Forms.Label
    Friend WithEvents pnlSearch        As System.Windows.Forms.Panel
    Friend WithEvents txtSearchQuery   As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch        As System.Windows.Forms.Button

End Class
