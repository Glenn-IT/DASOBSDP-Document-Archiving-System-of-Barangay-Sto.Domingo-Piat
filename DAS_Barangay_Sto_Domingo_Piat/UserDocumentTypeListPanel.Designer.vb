<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserDocumentTypeListPanel
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
        dgvTypeList = New DataGridView()
        colDocumentID = New DataGridViewTextBoxColumn()
        colDocID = New DataGridViewTextBoxColumn()
        colDocTitle = New DataGridViewTextBoxColumn()
        colDateTime = New DataGridViewTextBoxColumn()
        colRemarks = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        colView = New DataGridViewButtonColumn()
        pnlTop = New Panel()
        lblTitle = New Label()
        btnBack = New Button()
        CType(dgvTypeList, ComponentModel.ISupportInitialize).BeginInit()
        pnlTop.SuspendLayout()
        SuspendLayout()
        '
        ' dgvTypeList
        '
        dgvTypeList.AllowUserToAddRows = False
        dgvTypeList.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(230), CByte(226), CByte(180))
        dgvTypeList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        dgvTypeList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTypeList.BackgroundColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        dgvTypeList.BorderStyle = BorderStyle.None
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        dgvTypeList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        dgvTypeList.ColumnHeadersHeight = 36
        dgvTypeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvTypeList.Columns.AddRange(New DataGridViewColumn() {colDocumentID, colDocID, colDocTitle, colDateTime, colRemarks, colStatus, colView})
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        DataGridViewCellStyle8.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle8.ForeColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        DataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(CByte(121), CByte(174), CByte(111))
        DataGridViewCellStyle8.SelectionForeColor = Color.White
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.False
        dgvTypeList.DefaultCellStyle = DataGridViewCellStyle8
        dgvTypeList.Dock = DockStyle.Fill
        dgvTypeList.EnableHeadersVisualStyles = False
        dgvTypeList.Font = New Font("Segoe UI", 9F)
        dgvTypeList.GridColor = Color.FromArgb(CByte(159), CByte(203), CByte(152))
        dgvTypeList.Location = New Point(0, 52)
        dgvTypeList.MultiSelect = False
        dgvTypeList.Name = "dgvTypeList"
        dgvTypeList.ReadOnly = True
        dgvTypeList.RowHeadersVisible = False
        dgvTypeList.RowHeadersWidth = 45
        dgvTypeList.RowTemplate.Height = 32
        dgvTypeList.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTypeList.Size = New Size(1013, 606)
        dgvTypeList.TabIndex = 1
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
        pnlTop.Controls.Add(btnBack)
        pnlTop.Controls.Add(lblTitle)
        pnlTop.Dock = DockStyle.Top
        pnlTop.Location = New Point(0, 0)
        pnlTop.Name = "pnlTop"
        pnlTop.Size = New Size(1013, 52)
        pnlTop.TabIndex = 0
        '
        ' lblTitle
        '
        lblTitle.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(16, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(873, 52)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Document Type"
        lblTitle.TextAlign = ContentAlignment.MiddleLeft
        '
        ' btnBack
        '
        btnBack.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnBack.BackColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        btnBack.Cursor = Cursors.Hand
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(159), CByte(203), CByte(152))
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnBack.ForeColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        btnBack.Location = New Point(897, 10)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(100, 32)
        btnBack.TabIndex = 1
        btnBack.Text = "< Back"
        btnBack.UseVisualStyleBackColor = False
        '
        ' UserDocumentTypeListPanel
        '
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        Controls.Add(dgvTypeList)
        Controls.Add(pnlTop)
        Name = "UserDocumentTypeListPanel"
        Size = New Size(1013, 658)
        CType(dgvTypeList, ComponentModel.ISupportInitialize).EndInit()
        pnlTop.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvTypeList   As System.Windows.Forms.DataGridView
    Friend WithEvents colDocumentID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDocID      As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDocTitle   As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDateTime   As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRemarks    As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus     As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colView       As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents pnlTop        As System.Windows.Forms.Panel
    Friend WithEvents lblTitle      As System.Windows.Forms.Label
    Friend WithEvents btnBack       As System.Windows.Forms.Button

End Class
