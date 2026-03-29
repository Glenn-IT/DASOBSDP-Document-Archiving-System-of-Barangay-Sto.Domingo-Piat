<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserUploadDocumentPanel
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
        pnlTop           = New System.Windows.Forms.Panel()
        lblTitle         = New System.Windows.Forms.Label()
        pnlBody          = New System.Windows.Forms.Panel()
        pnlLeft          = New System.Windows.Forms.Panel()
        pnlRight         = New System.Windows.Forms.Panel()
        lblDocID         = New System.Windows.Forms.Label()
        txtDocumentID    = New System.Windows.Forms.TextBox()
        lblDocTitle      = New System.Windows.Forms.Label()
        txtDocumentTitle = New System.Windows.Forms.TextBox()
        lblDocType       = New System.Windows.Forms.Label()
        cmbDocumentType  = New System.Windows.Forms.ComboBox()
        lblDescription   = New System.Windows.Forms.Label()
        txtDescription   = New System.Windows.Forms.TextBox()
        lblDateTime      = New System.Windows.Forms.Label()
        dtpDateTime      = New System.Windows.Forms.DateTimePicker()
        lblUploadedBy    = New System.Windows.Forms.Label()
        txtUploadedBy    = New System.Windows.Forms.TextBox()
        lblStatus        = New System.Windows.Forms.Label()
        cmbStatus        = New System.Windows.Forms.ComboBox()
        lblImageBanner   = New System.Windows.Forms.Label()
        picBanner        = New System.Windows.Forms.PictureBox()
        btnUploadImage   = New System.Windows.Forms.Button()
        lblPDFDoc        = New System.Windows.Forms.Label()
        lblPDFFile       = New System.Windows.Forms.Label()
        btnUploadPDF     = New System.Windows.Forms.Button()
        pnlFooter        = New System.Windows.Forms.Panel()
        btnUpload        = New System.Windows.Forms.Button()
        btnCancel        = New System.Windows.Forms.Button()

        Me.SuspendLayout()

        Dim lbFont As New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Dim tbFont As New System.Drawing.Font("Segoe UI", 10)
        Dim cream  As System.Drawing.Color = System.Drawing.Color.FromArgb(242, 237, 194)
        Dim dark   As System.Drawing.Color = System.Drawing.Color.FromArgb(52, 103, 57)
        Dim mid    As System.Drawing.Color = System.Drawing.Color.FromArgb(121, 174, 111)

        ' ?? pnlTop ????????????????????????????????????????????????
        pnlTop.BackColor = mid : pnlTop.Dock = System.Windows.Forms.DockStyle.Top : pnlTop.Height = 52 : pnlTop.Name = "pnlTop"
        lblTitle.AutoSize = False : lblTitle.Text = "Upload Document"
        lblTitle.Font = New System.Drawing.Font("Segoe UI", 13, System.Drawing.FontStyle.Bold)
        lblTitle.ForeColor = System.Drawing.Color.White : lblTitle.BackColor = System.Drawing.Color.Transparent
        lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblTitle.Size = New System.Drawing.Size(400, 52) : lblTitle.Location = New System.Drawing.Point(16, 0) : lblTitle.Name = "lblTitle"
        pnlTop.Controls.Add(lblTitle)

        ' ?? pnlFooter ?????????????????????????????????????????????
        pnlFooter.BackColor = cream : pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom : pnlFooter.Height = 60 : pnlFooter.Name = "pnlFooter"
        pnlFooter.Padding = New System.Windows.Forms.Padding(16, 10, 16, 10)

        btnUpload.Text = "UPLOAD DOCUMENT" : btnUpload.Font = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        btnUpload.BackColor = dark : btnUpload.ForeColor = cream
        btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat : btnUpload.FlatAppearance.BorderSize = 0
        btnUpload.FlatAppearance.MouseOverBackColor = mid
        btnUpload.Size = New System.Drawing.Size(180, 38) : btnUpload.Location = New System.Drawing.Point(16, 11)
        btnUpload.Cursor = System.Windows.Forms.Cursors.Hand : btnUpload.Name = "btnUpload" : btnUpload.TabIndex = 0

        btnCancel.Text = "CANCEL" : btnCancel.Font = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        btnCancel.BackColor = System.Drawing.Color.FromArgb(160, 160, 160) : btnCancel.ForeColor = System.Drawing.Color.White
        btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat : btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(180, 60, 60)
        btnCancel.Size = New System.Drawing.Size(120, 38) : btnCancel.Location = New System.Drawing.Point(208, 11)
        btnCancel.Cursor = System.Windows.Forms.Cursors.Hand : btnCancel.Name = "btnCancel" : btnCancel.TabIndex = 1

        pnlFooter.Controls.Add(btnUpload) : pnlFooter.Controls.Add(btnCancel)

        ' ?? pnlBody ???????????????????????????????????????????????
        pnlBody.BackColor = cream : pnlBody.Dock = System.Windows.Forms.DockStyle.Fill : pnlBody.Name = "pnlBody" : pnlBody.Padding = New System.Windows.Forms.Padding(16)

        ' ?? pnlLeft ???????????????????????????????????????????????
        pnlLeft.BackColor = System.Drawing.Color.Transparent : pnlLeft.Dock = System.Windows.Forms.DockStyle.Left : pnlLeft.Width = 400 : pnlLeft.Name = "pnlLeft"

        lblDocID.AutoSize = False : lblDocID.Text = "Document ID" : lblDocID.Font = lbFont : lblDocID.ForeColor = dark : lblDocID.BackColor = System.Drawing.Color.Transparent : lblDocID.Size = New System.Drawing.Size(360, 20) : lblDocID.Location = New System.Drawing.Point(0, 10) : lblDocID.Name = "lblDocID"
        txtDocumentID.Font = tbFont : txtDocumentID.Size = New System.Drawing.Size(360, 32) : txtDocumentID.Location = New System.Drawing.Point(0, 32) : txtDocumentID.ReadOnly = True : txtDocumentID.BackColor = System.Drawing.Color.FromArgb(220, 215, 175) : txtDocumentID.ForeColor = dark : txtDocumentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle : txtDocumentID.Name = "txtDocumentID" : txtDocumentID.TabIndex = 0

        lblDocTitle.AutoSize = False : lblDocTitle.Text = "Document Title" : lblDocTitle.Font = lbFont : lblDocTitle.ForeColor = dark : lblDocTitle.BackColor = System.Drawing.Color.Transparent : lblDocTitle.Size = New System.Drawing.Size(360, 20) : lblDocTitle.Location = New System.Drawing.Point(0, 68) : lblDocTitle.Name = "lblDocTitle"
        txtDocumentTitle.Font = tbFont : txtDocumentTitle.Size = New System.Drawing.Size(360, 32) : txtDocumentTitle.Location = New System.Drawing.Point(0, 90) : txtDocumentTitle.BackColor = cream : txtDocumentTitle.ForeColor = dark : txtDocumentTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle : txtDocumentTitle.PlaceholderText = "Enter document title" : txtDocumentTitle.Name = "txtDocumentTitle" : txtDocumentTitle.TabIndex = 1

        lblDocType.AutoSize = False : lblDocType.Text = "Document Type" : lblDocType.Font = lbFont : lblDocType.ForeColor = dark : lblDocType.BackColor = System.Drawing.Color.Transparent : lblDocType.Size = New System.Drawing.Size(360, 20) : lblDocType.Location = New System.Drawing.Point(0, 136) : lblDocType.Name = "lblDocType"
        cmbDocumentType.Font = tbFont : cmbDocumentType.Size = New System.Drawing.Size(360, 32) : cmbDocumentType.Location = New System.Drawing.Point(0, 158) : cmbDocumentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList : cmbDocumentType.BackColor = cream : cmbDocumentType.ForeColor = dark : cmbDocumentType.FlatStyle = System.Windows.Forms.FlatStyle.Flat : cmbDocumentType.Name = "cmbDocumentType" : cmbDocumentType.TabIndex = 2

        lblDescription.AutoSize = False : lblDescription.Text = "Description" : lblDescription.Font = lbFont : lblDescription.ForeColor = dark : lblDescription.BackColor = System.Drawing.Color.Transparent : lblDescription.Size = New System.Drawing.Size(360, 20) : lblDescription.Location = New System.Drawing.Point(0, 204) : lblDescription.Name = "lblDescription"
        txtDescription.Font = tbFont : txtDescription.Size = New System.Drawing.Size(360, 72) : txtDescription.Location = New System.Drawing.Point(0, 226) : txtDescription.Multiline = True : txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical : txtDescription.BackColor = cream : txtDescription.ForeColor = dark : txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle : txtDescription.PlaceholderText = "Enter description" : txtDescription.Name = "txtDescription" : txtDescription.TabIndex = 3

        lblDateTime.AutoSize = False : lblDateTime.Text = "Date and Time" : lblDateTime.Font = lbFont : lblDateTime.ForeColor = dark : lblDateTime.BackColor = System.Drawing.Color.Transparent : lblDateTime.Size = New System.Drawing.Size(360, 20) : lblDateTime.Location = New System.Drawing.Point(0, 312) : lblDateTime.Name = "lblDateTime"
        dtpDateTime.Size = New System.Drawing.Size(360, 32) : dtpDateTime.Location = New System.Drawing.Point(0, 334) : dtpDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom : dtpDateTime.CustomFormat = "yyyy-MM-dd HH:mm" : dtpDateTime.BackColor = cream : dtpDateTime.Name = "dtpDateTime" : dtpDateTime.TabIndex = 4

        lblUploadedBy.AutoSize = False : lblUploadedBy.Text = "Uploaded By" : lblUploadedBy.Font = lbFont : lblUploadedBy.ForeColor = dark : lblUploadedBy.BackColor = System.Drawing.Color.Transparent : lblUploadedBy.Size = New System.Drawing.Size(360, 20) : lblUploadedBy.Location = New System.Drawing.Point(0, 380) : lblUploadedBy.Name = "lblUploadedBy"
        txtUploadedBy.Font = tbFont : txtUploadedBy.Size = New System.Drawing.Size(360, 32) : txtUploadedBy.Location = New System.Drawing.Point(0, 402) : txtUploadedBy.BackColor = cream : txtUploadedBy.ForeColor = dark : txtUploadedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle : txtUploadedBy.PlaceholderText = "Enter uploader name" : txtUploadedBy.Name = "txtUploadedBy" : txtUploadedBy.TabIndex = 5

        lblStatus.AutoSize = False : lblStatus.Text = "Status" : lblStatus.Font = lbFont : lblStatus.ForeColor = dark : lblStatus.BackColor = System.Drawing.Color.Transparent : lblStatus.Size = New System.Drawing.Size(360, 20) : lblStatus.Location = New System.Drawing.Point(0, 448) : lblStatus.Name = "lblStatus"
        cmbStatus.Font = tbFont : cmbStatus.Size = New System.Drawing.Size(360, 32) : cmbStatus.Location = New System.Drawing.Point(0, 470) : cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList : cmbStatus.BackColor = cream : cmbStatus.ForeColor = dark : cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat : cmbStatus.Name = "cmbStatus" : cmbStatus.TabIndex = 6

        pnlLeft.Controls.Add(lblDocID) : pnlLeft.Controls.Add(txtDocumentID)
        pnlLeft.Controls.Add(lblDocTitle) : pnlLeft.Controls.Add(txtDocumentTitle)
        pnlLeft.Controls.Add(lblDocType) : pnlLeft.Controls.Add(cmbDocumentType)
        pnlLeft.Controls.Add(lblDescription) : pnlLeft.Controls.Add(txtDescription)
        pnlLeft.Controls.Add(lblDateTime) : pnlLeft.Controls.Add(dtpDateTime)
        pnlLeft.Controls.Add(lblUploadedBy) : pnlLeft.Controls.Add(txtUploadedBy)
        pnlLeft.Controls.Add(lblStatus) : pnlLeft.Controls.Add(cmbStatus)

        ' ?? pnlRight ??????????????????????????????????????????????
        pnlRight.BackColor = System.Drawing.Color.Transparent : pnlRight.Dock = System.Windows.Forms.DockStyle.Fill : pnlRight.Name = "pnlRight" : pnlRight.Padding = New System.Windows.Forms.Padding(20, 10, 0, 0)

        lblImageBanner.AutoSize = False : lblImageBanner.Text = "Project Image Banner" : lblImageBanner.Font = lbFont : lblImageBanner.ForeColor = dark : lblImageBanner.BackColor = System.Drawing.Color.Transparent : lblImageBanner.Size = New System.Drawing.Size(340, 20) : lblImageBanner.Location = New System.Drawing.Point(20, 10) : lblImageBanner.Name = "lblImageBanner"
        picBanner.Size = New System.Drawing.Size(340, 180) : picBanner.Location = New System.Drawing.Point(20, 34) : picBanner.BackColor = System.Drawing.Color.FromArgb(220, 215, 175) : picBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle : picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom : picBanner.Name = "picBanner"
        btnUploadImage.Text = "Upload Image" : btnUploadImage.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold) : btnUploadImage.BackColor = mid : btnUploadImage.ForeColor = System.Drawing.Color.White : btnUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat : btnUploadImage.FlatAppearance.BorderSize = 0 : btnUploadImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(159, 203, 152) : btnUploadImage.Size = New System.Drawing.Size(340, 36) : btnUploadImage.Location = New System.Drawing.Point(20, 222) : btnUploadImage.Cursor = System.Windows.Forms.Cursors.Hand : btnUploadImage.Name = "btnUploadImage" : btnUploadImage.TabIndex = 7

        lblPDFDoc.AutoSize = False : lblPDFDoc.Text = "Project Document (PDF)" : lblPDFDoc.Font = lbFont : lblPDFDoc.ForeColor = dark : lblPDFDoc.BackColor = System.Drawing.Color.Transparent : lblPDFDoc.Size = New System.Drawing.Size(340, 20) : lblPDFDoc.Location = New System.Drawing.Point(20, 276) : lblPDFDoc.Name = "lblPDFDoc"
        lblPDFFile.AutoSize = False : lblPDFFile.Text = "No file selected" : lblPDFFile.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Italic) : lblPDFFile.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100) : lblPDFFile.BackColor = System.Drawing.Color.FromArgb(220, 215, 175) : lblPDFFile.Size = New System.Drawing.Size(340, 36) : lblPDFFile.Location = New System.Drawing.Point(20, 298) : lblPDFFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft : lblPDFFile.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0) : lblPDFFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle : lblPDFFile.Name = "lblPDFFile"
        btnUploadPDF.Text = "Upload PDF" : btnUploadPDF.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold) : btnUploadPDF.BackColor = mid : btnUploadPDF.ForeColor = System.Drawing.Color.White : btnUploadPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat : btnUploadPDF.FlatAppearance.BorderSize = 0 : btnUploadPDF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(159, 203, 152) : btnUploadPDF.Size = New System.Drawing.Size(340, 36) : btnUploadPDF.Location = New System.Drawing.Point(20, 342) : btnUploadPDF.Cursor = System.Windows.Forms.Cursors.Hand : btnUploadPDF.Name = "btnUploadPDF" : btnUploadPDF.TabIndex = 8

        pnlRight.Controls.Add(lblImageBanner) : pnlRight.Controls.Add(picBanner) : pnlRight.Controls.Add(btnUploadImage)
        pnlRight.Controls.Add(lblPDFDoc) : pnlRight.Controls.Add(lblPDFFile) : pnlRight.Controls.Add(btnUploadPDF)

        pnlBody.Controls.Add(pnlRight) : pnlBody.Controls.Add(pnlLeft)

        Me.Controls.Add(pnlBody) : Me.Controls.Add(pnlFooter) : Me.Controls.Add(pnlTop)
        Me.BackColor = cream : Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "UserUploadDocumentPanel" : Me.Size = New System.Drawing.Size(880, 640)

        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTop          As System.Windows.Forms.Panel
    Friend WithEvents lblTitle        As System.Windows.Forms.Label
    Friend WithEvents pnlBody         As System.Windows.Forms.Panel
    Friend WithEvents pnlLeft         As System.Windows.Forms.Panel
    Friend WithEvents pnlRight        As System.Windows.Forms.Panel
    Friend WithEvents lblDocID        As System.Windows.Forms.Label
    Friend WithEvents txtDocumentID   As System.Windows.Forms.TextBox
    Friend WithEvents lblDocTitle     As System.Windows.Forms.Label
    Friend WithEvents txtDocumentTitle As System.Windows.Forms.TextBox
    Friend WithEvents lblDocType      As System.Windows.Forms.Label
    Friend WithEvents cmbDocumentType As System.Windows.Forms.ComboBox
    Friend WithEvents lblDescription  As System.Windows.Forms.Label
    Friend WithEvents txtDescription  As System.Windows.Forms.TextBox
    Friend WithEvents lblDateTime     As System.Windows.Forms.Label
    Friend WithEvents dtpDateTime     As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblUploadedBy   As System.Windows.Forms.Label
    Friend WithEvents txtUploadedBy   As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus       As System.Windows.Forms.Label
    Friend WithEvents cmbStatus       As System.Windows.Forms.ComboBox
    Friend WithEvents lblImageBanner  As System.Windows.Forms.Label
    Friend WithEvents picBanner       As System.Windows.Forms.PictureBox
    Friend WithEvents btnUploadImage  As System.Windows.Forms.Button
    Friend WithEvents lblPDFDoc       As System.Windows.Forms.Label
    Friend WithEvents lblPDFFile      As System.Windows.Forms.Label
    Friend WithEvents btnUploadPDF    As System.Windows.Forms.Button
    Friend WithEvents pnlFooter       As System.Windows.Forms.Panel
    Friend WithEvents btnUpload       As System.Windows.Forms.Button
    Friend WithEvents btnCancel       As System.Windows.Forms.Button

End Class
