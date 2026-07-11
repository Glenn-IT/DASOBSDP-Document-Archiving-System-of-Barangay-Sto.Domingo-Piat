<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminUpdateDocumentForm

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
        pnlHeader = New Panel()
        lblFormTitle = New Label()
        pnlBody = New Panel()
        pnlRight = New Panel()
        lblImageBanner = New Label()
        picBanner = New PictureBox()
        btnUploadImage = New Button()
        lblPDFDoc = New Label()
        lblPDFFile = New Label()
        btnUploadPDF = New Button()
        pnlLeft = New Panel()
        lblDocID = New Label()
        txtDocumentID = New TextBox()
        lblDocTitle = New Label()
        txtDocumentTitle = New TextBox()
        lblDescription = New Label()
        txtDescription = New TextBox()
        lblDateTime = New Label()
        dtpDateTime = New DateTimePicker()
        lblUploadedBy = New Label()
        txtUploadedBy = New TextBox()
        lblStatus = New Label()
        cmbStatus = New ComboBox()
        pnlFooter = New Panel()
        btnUpdate = New Button()
        btnCancel = New Button()
        pnlHeader.SuspendLayout()
        pnlBody.SuspendLayout()
        pnlRight.SuspendLayout()
        CType(picBanner, ComponentModel.ISupportInitialize).BeginInit()
        pnlLeft.SuspendLayout()
        pnlFooter.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(121), CByte(174), CByte(111))
        pnlHeader.Controls.Add(lblFormTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(876, 63)
        pnlHeader.TabIndex = 2
        ' 
        ' lblFormTitle
        ' 
        lblFormTitle.BackColor = Color.Transparent
        lblFormTitle.Dock = DockStyle.Fill
        lblFormTitle.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        lblFormTitle.ForeColor = Color.White
        lblFormTitle.Location = New Point(0, 0)
        lblFormTitle.Name = "lblFormTitle"
        lblFormTitle.Padding = New Padding(20, 0, 0, 0)
        lblFormTitle.Size = New Size(876, 63)
        lblFormTitle.TabIndex = 0
        lblFormTitle.Text = "Update Document"
        lblFormTitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pnlBody
        ' 
        pnlBody.BackColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        pnlBody.Controls.Add(pnlRight)
        pnlBody.Controls.Add(pnlLeft)
        pnlBody.Dock = DockStyle.Fill
        pnlBody.Location = New Point(0, 63)
        pnlBody.Name = "pnlBody"
        pnlBody.Padding = New Padding(20, 23, 20, 23)
        pnlBody.Size = New Size(876, 584)
        pnlBody.TabIndex = 0
        ' 
        ' pnlRight
        ' 
        pnlRight.BackColor = Color.Transparent
        pnlRight.Controls.Add(lblImageBanner)
        pnlRight.Controls.Add(picBanner)
        pnlRight.Controls.Add(btnUploadImage)
        pnlRight.Controls.Add(lblPDFDoc)
        pnlRight.Controls.Add(lblPDFFile)
        pnlRight.Controls.Add(btnUploadPDF)
        pnlRight.Dock = DockStyle.Fill
        pnlRight.Location = New Point(420, 23)
        pnlRight.Name = "pnlRight"
        pnlRight.Padding = New Padding(20, 11, 0, 0)
        pnlRight.Size = New Size(436, 538)
        pnlRight.TabIndex = 0
        ' 
        ' lblImageBanner
        ' 
        lblImageBanner.BackColor = Color.Transparent
        lblImageBanner.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblImageBanner.ForeColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        lblImageBanner.Location = New Point(20, 11)
        lblImageBanner.Name = "lblImageBanner"
        lblImageBanner.Size = New Size(340, 23)
        lblImageBanner.TabIndex = 0
        lblImageBanner.Text = "Project Image Banner"
        ' 
        ' picBanner
        ' 
        picBanner.BackColor = Color.FromArgb(CByte(220), CByte(215), CByte(175))
        picBanner.BorderStyle = BorderStyle.FixedSingle
        picBanner.Location = New Point(20, 39)
        picBanner.Name = "picBanner"
        picBanner.Size = New Size(340, 204)
        picBanner.SizeMode = PictureBoxSizeMode.Zoom
        picBanner.TabIndex = 1
        picBanner.TabStop = False
        ' 
        ' btnUploadImage
        ' 
        btnUploadImage.BackColor = Color.FromArgb(CByte(121), CByte(174), CByte(111))
        btnUploadImage.Cursor = Cursors.Hand
        btnUploadImage.FlatAppearance.BorderSize = 0
        btnUploadImage.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(159), CByte(203), CByte(152))
        btnUploadImage.FlatStyle = FlatStyle.Flat
        btnUploadImage.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnUploadImage.ForeColor = Color.White
        btnUploadImage.Location = New Point(20, 252)
        btnUploadImage.Name = "btnUploadImage"
        btnUploadImage.Size = New Size(340, 41)
        btnUploadImage.TabIndex = 6
        btnUploadImage.Text = "Upload Image"
        btnUploadImage.UseVisualStyleBackColor = False
        ' 
        ' lblPDFDoc
        ' 
        lblPDFDoc.BackColor = Color.Transparent
        lblPDFDoc.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblPDFDoc.ForeColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        lblPDFDoc.Location = New Point(20, 313)
        lblPDFDoc.Name = "lblPDFDoc"
        lblPDFDoc.Size = New Size(340, 23)
        lblPDFDoc.TabIndex = 7
        lblPDFDoc.Text = "Project Document (PDF)"
        ' 
        ' lblPDFFile
        ' 
        lblPDFFile.BackColor = Color.FromArgb(CByte(220), CByte(215), CByte(175))
        lblPDFFile.BorderStyle = BorderStyle.FixedSingle
        lblPDFFile.Font = New Font("Segoe UI", 9F, FontStyle.Italic)
        lblPDFFile.ForeColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        lblPDFFile.Location = New Point(20, 338)
        lblPDFFile.Name = "lblPDFFile"
        lblPDFFile.Padding = New Padding(8, 0, 0, 0)
        lblPDFFile.Size = New Size(340, 41)
        lblPDFFile.TabIndex = 8
        lblPDFFile.Text = "No file selected"
        lblPDFFile.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnUploadPDF
        ' 
        btnUploadPDF.BackColor = Color.FromArgb(CByte(121), CByte(174), CByte(111))
        btnUploadPDF.Cursor = Cursors.Hand
        btnUploadPDF.FlatAppearance.BorderSize = 0
        btnUploadPDF.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(159), CByte(203), CByte(152))
        btnUploadPDF.FlatStyle = FlatStyle.Flat
        btnUploadPDF.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnUploadPDF.ForeColor = Color.White
        btnUploadPDF.Location = New Point(20, 388)
        btnUploadPDF.Name = "btnUploadPDF"
        btnUploadPDF.Size = New Size(340, 41)
        btnUploadPDF.TabIndex = 7
        btnUploadPDF.Text = "Upload PDF"
        btnUploadPDF.UseVisualStyleBackColor = False
        ' 
        ' pnlLeft
        ' 
        pnlLeft.BackColor = Color.Transparent
        pnlLeft.Controls.Add(lblDocID)
        pnlLeft.Controls.Add(txtDocumentID)
        pnlLeft.Controls.Add(lblDocTitle)
        pnlLeft.Controls.Add(txtDocumentTitle)
        pnlLeft.Controls.Add(lblDescription)
        pnlLeft.Controls.Add(txtDescription)
        pnlLeft.Controls.Add(lblDateTime)
        pnlLeft.Controls.Add(dtpDateTime)
        pnlLeft.Controls.Add(lblUploadedBy)
        pnlLeft.Controls.Add(txtUploadedBy)
        pnlLeft.Controls.Add(lblStatus)
        pnlLeft.Controls.Add(cmbStatus)
        pnlLeft.Dock = DockStyle.Left
        pnlLeft.Location = New Point(20, 23)
        pnlLeft.Name = "pnlLeft"
        pnlLeft.Size = New Size(400, 538)
        pnlLeft.TabIndex = 1
        ' 
        ' lblDocID
        ' 
        lblDocID.BackColor = Color.Transparent
        lblDocID.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblDocID.ForeColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        lblDocID.Location = New Point(0, 11)
        lblDocID.Name = "lblDocID"
        lblDocID.Size = New Size(360, 23)
        lblDocID.TabIndex = 0
        lblDocID.Text = "Document ID"
        ' 
        ' txtDocumentID
        ' 
        txtDocumentID.BackColor = Color.FromArgb(CByte(220), CByte(215), CByte(175))
        txtDocumentID.BorderStyle = BorderStyle.FixedSingle
        txtDocumentID.Font = New Font("Segoe UI", 10F)
        txtDocumentID.ForeColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        txtDocumentID.Location = New Point(0, 36)
        txtDocumentID.Name = "txtDocumentID"
        txtDocumentID.ReadOnly = True
        txtDocumentID.Size = New Size(360, 27)
        txtDocumentID.TabIndex = 0
        ' 
        ' lblDocTitle
        ' 
        lblDocTitle.BackColor = Color.Transparent
        lblDocTitle.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblDocTitle.ForeColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        lblDocTitle.Location = New Point(0, 86)
        lblDocTitle.Name = "lblDocTitle"
        lblDocTitle.Size = New Size(360, 23)
        lblDocTitle.TabIndex = 1
        lblDocTitle.Text = "Document Title"
        ' 
        ' txtDocumentTitle
        ' 
        txtDocumentTitle.BackColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        txtDocumentTitle.BorderStyle = BorderStyle.FixedSingle
        txtDocumentTitle.Font = New Font("Segoe UI", 10F)
        txtDocumentTitle.ForeColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        txtDocumentTitle.Location = New Point(0, 111)
        txtDocumentTitle.Name = "txtDocumentTitle"
        txtDocumentTitle.PlaceholderText = "Enter document title"
        txtDocumentTitle.Size = New Size(360, 27)
        txtDocumentTitle.TabIndex = 1
        ' 
        ' lblDescription
        ' 
        lblDescription.BackColor = Color.Transparent
        lblDescription.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblDescription.ForeColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        lblDescription.Location = New Point(0, 163)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(360, 23)
        lblDescription.TabIndex = 2
        lblDescription.Text = "Description"
        ' 
        ' txtDescription
        ' 
        txtDescription.BackColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        txtDescription.BorderStyle = BorderStyle.FixedSingle
        txtDescription.Font = New Font("Segoe UI", 10F)
        txtDescription.ForeColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        txtDescription.Location = New Point(0, 188)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.ScrollBars = ScrollBars.Vertical
        txtDescription.Size = New Size(360, 102)
        txtDescription.TabIndex = 2
        ' 
        ' lblDateTime
        ' 
        lblDateTime.BackColor = Color.Transparent
        lblDateTime.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblDateTime.ForeColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        lblDateTime.Location = New Point(0, 306)
        lblDateTime.Name = "lblDateTime"
        lblDateTime.Size = New Size(360, 23)
        lblDateTime.TabIndex = 3
        lblDateTime.Text = "Date and Time"
        ' 
        ' dtpDateTime
        ' 
        dtpDateTime.BackColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        dtpDateTime.CustomFormat = "yyyy-MM-dd HH:mm"
        dtpDateTime.Format = DateTimePickerFormat.Custom
        dtpDateTime.Location = New Point(0, 331)
        dtpDateTime.Name = "dtpDateTime"
        dtpDateTime.Size = New Size(360, 25)
        dtpDateTime.TabIndex = 3
        ' 
        ' lblUploadedBy
        ' 
        lblUploadedBy.BackColor = Color.Transparent
        lblUploadedBy.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblUploadedBy.ForeColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        lblUploadedBy.Location = New Point(0, 383)
        lblUploadedBy.Name = "lblUploadedBy"
        lblUploadedBy.Size = New Size(360, 23)
        lblUploadedBy.TabIndex = 4
        lblUploadedBy.Text = "Uploaded By"
        ' 
        ' txtUploadedBy
        ' 
        txtUploadedBy.BackColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        txtUploadedBy.BorderStyle = BorderStyle.FixedSingle
        txtUploadedBy.Font = New Font("Segoe UI", 10F)
        txtUploadedBy.ForeColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        txtUploadedBy.Location = New Point(0, 408)
        txtUploadedBy.Name = "txtUploadedBy"
        txtUploadedBy.PlaceholderText = "Enter uploader name"
        txtUploadedBy.Size = New Size(360, 27)
        txtUploadedBy.TabIndex = 4
        ' 
        ' lblStatus
        ' 
        lblStatus.BackColor = Color.Transparent
        lblStatus.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblStatus.ForeColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        lblStatus.Location = New Point(0, 460)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(360, 23)
        lblStatus.TabIndex = 5
        lblStatus.Text = "Document Type"
        ' 
        ' cmbStatus
        ' 
        cmbStatus.BackColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStatus.FlatStyle = FlatStyle.Flat
        cmbStatus.Font = New Font("Segoe UI", 10F)
        cmbStatus.ForeColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        cmbStatus.Location = New Point(0, 485)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(360, 28)
        cmbStatus.TabIndex = 5
        ' 
        ' pnlFooter
        ' 
        pnlFooter.BackColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        pnlFooter.Controls.Add(btnUpdate)
        pnlFooter.Controls.Add(btnCancel)
        pnlFooter.Dock = DockStyle.Bottom
        pnlFooter.Location = New Point(0, 647)
        pnlFooter.Name = "pnlFooter"
        pnlFooter.Padding = New Padding(20, 11, 20, 11)
        pnlFooter.Size = New Size(876, 68)
        pnlFooter.TabIndex = 1
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        btnUpdate.Cursor = Cursors.Hand
        btnUpdate.FlatAppearance.BorderSize = 0
        btnUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(121), CByte(174), CByte(111))
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnUpdate.ForeColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        btnUpdate.Location = New Point(20, 12)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(180, 43)
        btnUpdate.TabIndex = 0
        btnUpdate.Text = "UPDATE DOCUMENT"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(160), CByte(160), CByte(160))
        btnCancel.Cursor = Cursors.Hand
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(180), CByte(60), CByte(60))
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(212, 12)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(120, 43)
        btnCancel.TabIndex = 1
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' AdminUpdateDocumentForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        ClientSize = New Size(876, 715)
        Controls.Add(pnlBody)
        Controls.Add(pnlFooter)
        Controls.Add(pnlHeader)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "AdminUpdateDocumentForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Update Document"
        pnlHeader.ResumeLayout(False)
        pnlBody.ResumeLayout(False)
        pnlRight.ResumeLayout(False)
        CType(picBanner, ComponentModel.ISupportInitialize).EndInit()
        pnlLeft.ResumeLayout(False)
        pnlLeft.PerformLayout()
        pnlFooter.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader        As System.Windows.Forms.Panel
    Friend WithEvents lblFormTitle     As System.Windows.Forms.Label
    Friend WithEvents pnlBody          As System.Windows.Forms.Panel
    Friend WithEvents pnlLeft          As System.Windows.Forms.Panel
    Friend WithEvents pnlRight         As System.Windows.Forms.Panel
    Friend WithEvents lblDocID         As System.Windows.Forms.Label
    Friend WithEvents txtDocumentID    As System.Windows.Forms.TextBox
    Friend WithEvents lblDocTitle      As System.Windows.Forms.Label
    Friend WithEvents txtDocumentTitle As System.Windows.Forms.TextBox
    Friend WithEvents lblDescription   As System.Windows.Forms.Label
    Friend WithEvents txtDescription   As System.Windows.Forms.TextBox
    Friend WithEvents lblDateTime      As System.Windows.Forms.Label
    Friend WithEvents dtpDateTime      As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblUploadedBy    As System.Windows.Forms.Label
    Friend WithEvents txtUploadedBy    As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus        As System.Windows.Forms.Label
    Friend WithEvents cmbStatus        As System.Windows.Forms.ComboBox
    Friend WithEvents lblImageBanner   As System.Windows.Forms.Label
    Friend WithEvents picBanner        As System.Windows.Forms.PictureBox
    Friend WithEvents btnUploadImage   As System.Windows.Forms.Button
    Friend WithEvents lblPDFDoc        As System.Windows.Forms.Label
    Friend WithEvents lblPDFFile       As System.Windows.Forms.Label
    Friend WithEvents btnUploadPDF     As System.Windows.Forms.Button
    Friend WithEvents pnlFooter        As System.Windows.Forms.Panel
    Friend WithEvents btnUpdate        As System.Windows.Forms.Button
    Friend WithEvents btnCancel        As System.Windows.Forms.Button

End Class
