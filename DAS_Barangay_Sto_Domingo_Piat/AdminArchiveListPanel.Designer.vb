<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminArchiveListPanel
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        dgvArchiveList = New DataGridView()
        colDocID = New DataGridViewTextBoxColumn()
        colDocTitle = New DataGridViewTextBoxColumn()
        colUploadedBy = New DataGridViewTextBoxColumn()
        colDateTime = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        colView = New DataGridViewButtonColumn()
        pnlTop = New Panel()
        lblTitle = New Label()
        pnlSearch = New Panel()
        txtSearch = New TextBox()
        btnSearch = New Button()
        pnlActions = New Panel()
        btnAddDocument = New Button()
        btnUpdateDocument = New Button()
        btnDeleteDocument = New Button()
        CType(dgvArchiveList, ComponentModel.ISupportInitialize).BeginInit()
        pnlTop.SuspendLayout()
        pnlSearch.SuspendLayout()
        pnlActions.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvArchiveList
        ' 
        dgvArchiveList.AllowUserToAddRows = False
        dgvArchiveList.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(230), CByte(226), CByte(180))
        dgvArchiveList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvArchiveList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvArchiveList.BackgroundColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        dgvArchiveList.BorderStyle = BorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvArchiveList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvArchiveList.ColumnHeadersHeight = 36
        dgvArchiveList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvArchiveList.Columns.AddRange(New DataGridViewColumn() {colDocID, colDocTitle, colUploadedBy, colDateTime, colStatus, colView})
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle4.ForeColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(121), CByte(174), CByte(111))
        DataGridViewCellStyle4.SelectionForeColor = Color.White
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        dgvArchiveList.DefaultCellStyle = DataGridViewCellStyle4
        dgvArchiveList.Dock = DockStyle.Fill
        dgvArchiveList.EnableHeadersVisualStyles = False
        dgvArchiveList.Font = New Font("Segoe UI", 9F)
        dgvArchiveList.GridColor = Color.FromArgb(CByte(159), CByte(203), CByte(152))
        dgvArchiveList.Location = New Point(0, 104)
        dgvArchiveList.MultiSelect = False
        dgvArchiveList.Name = "dgvArchiveList"
        dgvArchiveList.ReadOnly = True
        dgvArchiveList.RowHeadersVisible = False
        dgvArchiveList.RowHeadersWidth = 45
        dgvArchiveList.RowTemplate.Height = 32
        dgvArchiveList.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvArchiveList.Size = New Size(1297, 432)
        dgvArchiveList.TabIndex = 5
        ' 
        ' colDocID
        ' 
        colDocID.FillWeight = 15F
        colDocID.HeaderText = "Document ID"
        colDocID.MinimumWidth = 6
        colDocID.Name = "colDocID"
        colDocID.ReadOnly = True
        ' 
        ' colDocTitle
        ' 
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        colDocTitle.DefaultCellStyle = DataGridViewCellStyle3
        colDocTitle.FillWeight = 35F
        colDocTitle.HeaderText = "Document Title"
        colDocTitle.MinimumWidth = 6
        colDocTitle.Name = "colDocTitle"
        colDocTitle.ReadOnly = True
        ' 
        ' colUploadedBy
        ' 
        colUploadedBy.FillWeight = 20F
        colUploadedBy.HeaderText = "Uploaded By"
        colUploadedBy.MinimumWidth = 6
        colUploadedBy.Name = "colUploadedBy"
        colUploadedBy.ReadOnly = True
        ' 
        ' colDateTime
        ' 
        colDateTime.FillWeight = 20F
        colDateTime.HeaderText = "Date and Time"
        colDateTime.MinimumWidth = 6
        colDateTime.Name = "colDateTime"
        colDateTime.ReadOnly = True
        ' 
        ' colStatus
        ' 
        colStatus.FillWeight = 10F
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
        pnlTop.Size = New Size(1297, 52)
        pnlTop.TabIndex = 8
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
        lblTitle.Text = "Archive List"
        lblTitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pnlSearch
        ' 
        pnlSearch.BackColor = Color.FromArgb(CByte(230), CByte(226), CByte(180))
        pnlSearch.Controls.Add(txtSearch)
        pnlSearch.Controls.Add(btnSearch)
        pnlSearch.Dock = DockStyle.Top
        pnlSearch.Location = New Point(0, 52)
        pnlSearch.Name = "pnlSearch"
        pnlSearch.Size = New Size(1297, 52)
        pnlSearch.TabIndex = 7
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtSearch.BackColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 10F)
        txtSearch.ForeColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        txtSearch.Location = New Point(3, 9)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Type to search documents..."
        txtSearch.Size = New Size(1197, 27)
        txtSearch.TabIndex = 0
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
        btnSearch.Location = New Point(1205, 6)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(90, 32)
        btnSearch.TabIndex = 1
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' pnlActions
        ' 
        pnlActions.BackColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        pnlActions.Controls.Add(btnAddDocument)
        pnlActions.Controls.Add(btnUpdateDocument)
        pnlActions.Controls.Add(btnDeleteDocument)
        pnlActions.Dock = DockStyle.Bottom
        pnlActions.Location = New Point(0, 536)
        pnlActions.Name = "pnlActions"
        pnlActions.Padding = New Padding(12, 10, 12, 10)
        pnlActions.Size = New Size(1297, 60)
        pnlActions.TabIndex = 6
        ' 
        ' btnAddDocument
        ' 
        btnAddDocument.BackColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        btnAddDocument.Cursor = Cursors.Hand
        btnAddDocument.FlatAppearance.BorderSize = 0
        btnAddDocument.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(121), CByte(174), CByte(111))
        btnAddDocument.FlatStyle = FlatStyle.Flat
        btnAddDocument.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnAddDocument.ForeColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        btnAddDocument.Location = New Point(12, 11)
        btnAddDocument.Name = "btnAddDocument"
        btnAddDocument.Size = New Size(120, 38)
        btnAddDocument.TabIndex = 2
        btnAddDocument.Text = "Add"
        btnAddDocument.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateDocument
        ' 
        btnUpdateDocument.BackColor = Color.FromArgb(CByte(121), CByte(174), CByte(111))
        btnUpdateDocument.Cursor = Cursors.Hand
        btnUpdateDocument.FlatAppearance.BorderSize = 0
        btnUpdateDocument.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(159), CByte(203), CByte(152))
        btnUpdateDocument.FlatStyle = FlatStyle.Flat
        btnUpdateDocument.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnUpdateDocument.ForeColor = Color.White
        btnUpdateDocument.Location = New Point(144, 11)
        btnUpdateDocument.Name = "btnUpdateDocument"
        btnUpdateDocument.Size = New Size(120, 38)
        btnUpdateDocument.TabIndex = 3
        btnUpdateDocument.Text = "Update"
        btnUpdateDocument.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteDocument
        ' 
        btnDeleteDocument.BackColor = Color.FromArgb(CByte(192), CByte(57), CByte(43))
        btnDeleteDocument.Cursor = Cursors.Hand
        btnDeleteDocument.FlatAppearance.BorderSize = 0
        btnDeleteDocument.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(220), CByte(80), CByte(60))
        btnDeleteDocument.FlatStyle = FlatStyle.Flat
        btnDeleteDocument.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnDeleteDocument.ForeColor = Color.White
        btnDeleteDocument.Location = New Point(276, 11)
        btnDeleteDocument.Name = "btnDeleteDocument"
        btnDeleteDocument.Size = New Size(120, 38)
        btnDeleteDocument.TabIndex = 4
        btnDeleteDocument.Text = "Delete"
        btnDeleteDocument.UseVisualStyleBackColor = False
        btnDeleteDocument.Visible = False
        ' 
        ' AdminArchiveListPanel
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        Controls.Add(dgvArchiveList)
        Controls.Add(pnlActions)
        Controls.Add(pnlSearch)
        Controls.Add(pnlTop)
        Name = "AdminArchiveListPanel"
        Size = New Size(1297, 596)
        CType(dgvArchiveList, ComponentModel.ISupportInitialize).EndInit()
        pnlTop.ResumeLayout(False)
        pnlSearch.ResumeLayout(False)
        pnlSearch.PerformLayout()
        pnlActions.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvArchiveList    As System.Windows.Forms.DataGridView
    Friend WithEvents colDocID          As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDocTitle       As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUploadedBy     As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDateTime       As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus         As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colView           As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents pnlTop            As System.Windows.Forms.Panel
    Friend WithEvents lblTitle          As System.Windows.Forms.Label
    Friend WithEvents pnlSearch         As System.Windows.Forms.Panel
    Friend WithEvents txtSearch         As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch         As System.Windows.Forms.Button
    Friend WithEvents pnlActions        As System.Windows.Forms.Panel
    Friend WithEvents btnAddDocument    As System.Windows.Forms.Button
    Friend WithEvents btnUpdateDocument As System.Windows.Forms.Button
    Friend WithEvents btnDeleteDocument As System.Windows.Forms.Button

End Class
