<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminDocumentTypeListPanel
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
        dgvTypeList = New DataGridView()
        colDocID = New DataGridViewTextBoxColumn()
        colDocTitle = New DataGridViewTextBoxColumn()
        colUploadedBy = New DataGridViewTextBoxColumn()
        colDateTime = New DataGridViewTextBoxColumn()
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
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(230), CByte(226), CByte(180))
        dgvTypeList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvTypeList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTypeList.BackgroundColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        dgvTypeList.BorderStyle = BorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvTypeList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvTypeList.ColumnHeadersHeight = 36
        dgvTypeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvTypeList.Columns.AddRange(New DataGridViewColumn() {colDocID, colDocTitle, colUploadedBy, colDateTime, colStatus, colView})
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle4.ForeColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(121), CByte(174), CByte(111))
        DataGridViewCellStyle4.SelectionForeColor = Color.White
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        dgvTypeList.DefaultCellStyle = DataGridViewCellStyle4
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
        dgvTypeList.Size = New Size(1297, 544)
        dgvTypeList.TabIndex = 1
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
        pnlTop.Controls.Add(btnBack)
        pnlTop.Controls.Add(lblTitle)
        pnlTop.Dock = DockStyle.Top
        pnlTop.Location = New Point(0, 0)
        pnlTop.Name = "pnlTop"
        pnlTop.Size = New Size(1297, 52)
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
        lblTitle.Size = New Size(1157, 52)
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
        btnBack.Location = New Point(1181, 10)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(100, 32)
        btnBack.TabIndex = 1
        btnBack.Text = "< Back"
        btnBack.UseVisualStyleBackColor = False
        '
        ' AdminDocumentTypeListPanel
        '
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        Controls.Add(dgvTypeList)
        Controls.Add(pnlTop)
        Name = "AdminDocumentTypeListPanel"
        Size = New Size(1297, 596)
        CType(dgvTypeList, ComponentModel.ISupportInitialize).EndInit()
        pnlTop.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvTypeList   As System.Windows.Forms.DataGridView
    Friend WithEvents colDocID      As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDocTitle   As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUploadedBy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDateTime   As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus     As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colView       As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents pnlTop        As System.Windows.Forms.Panel
    Friend WithEvents lblTitle      As System.Windows.Forms.Label
    Friend WithEvents btnBack       As System.Windows.Forms.Button

End Class
