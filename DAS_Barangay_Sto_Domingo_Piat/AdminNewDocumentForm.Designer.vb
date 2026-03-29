<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminNewDocumentForm

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
        pnlHeader       = New System.Windows.Forms.Panel()
        lblFormTitle    = New System.Windows.Forms.Label()
        pnlBody         = New System.Windows.Forms.Panel()
        pnlLeft         = New System.Windows.Forms.Panel()
        pnlRight        = New System.Windows.Forms.Panel()
        lblDocID        = New System.Windows.Forms.Label()
        txtDocumentID   = New System.Windows.Forms.TextBox()
        lblDocTitle     = New System.Windows.Forms.Label()
        txtDocumentTitle = New System.Windows.Forms.TextBox()
        lblDescription  = New System.Windows.Forms.Label()
        txtDescription  = New System.Windows.Forms.TextBox()
        lblDateTime     = New System.Windows.Forms.Label()
        dtpDateTime     = New System.Windows.Forms.DateTimePicker()
        lblUploadedBy   = New System.Windows.Forms.Label()
        txtUploadedBy   = New System.Windows.Forms.TextBox()
        lblStatus       = New System.Windows.Forms.Label()
        cmbStatus       = New System.Windows.Forms.ComboBox()
        lblImageBanner  = New System.Windows.Forms.Label()
        picBanner       = New System.Windows.Forms.PictureBox()
        btnUploadImage  = New System.Windows.Forms.Button()
        lblPDFDoc       = New System.Windows.Forms.Label()
        lblPDFFile      = New System.Windows.Forms.Label()
        btnUploadPDF    = New System.Windows.Forms.Button()
        pnlFooter       = New System.Windows.Forms.Panel()
        btnAdd          = New System.Windows.Forms.Button()
        btnCancel       = New System.Windows.Forms.Button()

        Me.SuspendLayout()

        ' ?? pnlHeader  (#79AE6F) ??????????????????????????????????
        pnlHeader.BackColor = System.Drawing.Color.FromArgb(121, 174, 111)
        pnlHeader.Dock      = System.Windows.Forms.DockStyle.Top
        pnlHeader.Height    = 56
        pnlHeader.Name      = "pnlHeader"

        lblFormTitle.AutoSize  = False
        lblFormTitle.Text      = "New Document"
        lblFormTitle.Font      = New System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold)
        lblFormTitle.ForeColor = System.Drawing.Color.White
        lblFormTitle.BackColor = System.Drawing.Color.Transparent
        lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblFormTitle.Dock      = System.Windows.Forms.DockStyle.Fill
        lblFormTitle.Padding   = New System.Windows.Forms.Padding(20, 0, 0, 0)
        lblFormTitle.Name      = "lblFormTitle"

        pnlHeader.Controls.Add(lblFormTitle)

        ' ?? pnlFooter  (Cream, action buttons) ????????????????????
        pnlFooter.BackColor = System.Drawing.Color.FromArgb(242, 237, 194)
        pnlFooter.Dock      = System.Windows.Forms.DockStyle.Bottom
        pnlFooter.Height    = 60
        pnlFooter.Name      = "pnlFooter"
        pnlFooter.Padding   = New System.Windows.Forms.Padding(20, 10, 20, 10)

        btnAdd.Text                              = "ADD DOCUMENT"
        btnAdd.Font                              = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        btnAdd.BackColor                         = System.Drawing.Color.FromArgb(52, 103, 57)
        btnAdd.ForeColor                         = System.Drawing.Color.FromArgb(242, 237, 194)
        btnAdd.FlatStyle                         = System.Windows.Forms.FlatStyle.Flat
        btnAdd.FlatAppearance.BorderSize         = 0
        btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(121, 174, 111)
        btnAdd.Size                              = New System.Drawing.Size(160, 38)
        btnAdd.Location                          = New System.Drawing.Point(20, 11)
        btnAdd.Cursor                            = System.Windows.Forms.Cursors.Hand
        btnAdd.Name                              = "btnAdd"
        btnAdd.TabIndex                          = 0

        btnCancel.Text                              = "CANCEL"
        btnCancel.Font                              = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        btnCancel.BackColor                         = System.Drawing.Color.FromArgb(160, 160, 160)
        btnCancel.ForeColor                         = System.Drawing.Color.White
        btnCancel.FlatStyle                         = System.Windows.Forms.FlatStyle.Flat
        btnCancel.FlatAppearance.BorderSize         = 0
        btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(180, 60, 60)
        btnCancel.Size                              = New System.Drawing.Size(120, 38)
        btnCancel.Location                          = New System.Drawing.Point(192, 11)
        btnCancel.Cursor                            = System.Windows.Forms.Cursors.Hand
        btnCancel.Name                              = "btnCancel"
        btnCancel.TabIndex                          = 1

        pnlFooter.Controls.Add(btnAdd)
        pnlFooter.Controls.Add(btnCancel)

        ' ?? pnlBody  (Cream, fills between header and footer) ?????
        pnlBody.BackColor = System.Drawing.Color.FromArgb(242, 237, 194)
        pnlBody.Dock      = System.Windows.Forms.DockStyle.Fill
        pnlBody.Name      = "pnlBody"
        pnlBody.Padding   = New System.Windows.Forms.Padding(20)

        ' ?? pnlLeft  (left half of body) ??????????????????????????
        pnlLeft.BackColor = System.Drawing.Color.Transparent
        pnlLeft.Dock      = System.Windows.Forms.DockStyle.Left
        pnlLeft.Width     = 400
        pnlLeft.Name      = "pnlLeft"

        Dim lbFont As New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Dim tbFont As New System.Drawing.Font("Segoe UI", 10)
        Dim cream  As System.Drawing.Color = System.Drawing.Color.FromArgb(242, 237, 194)
        Dim dark   As System.Drawing.Color = System.Drawing.Color.FromArgb(52, 103, 57)

        ' Document ID
        lblDocID.AutoSize  = False
        lblDocID.Text      = "Document ID"
        lblDocID.Font      = lbFont
        lblDocID.ForeColor = dark
        lblDocID.BackColor = System.Drawing.Color.Transparent
        lblDocID.Size      = New System.Drawing.Size(360, 20)
        lblDocID.Location  = New System.Drawing.Point(0, 10)
        lblDocID.Name      = "lblDocID"

        txtDocumentID.Font        = tbFont
        txtDocumentID.Size        = New System.Drawing.Size(360, 32)
        txtDocumentID.Location    = New System.Drawing.Point(0, 32)
        txtDocumentID.ReadOnly    = True
        txtDocumentID.BackColor   = System.Drawing.Color.FromArgb(220, 215, 175)
        txtDocumentID.ForeColor   = dark
        txtDocumentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtDocumentID.Name        = "txtDocumentID"
        txtDocumentID.TabIndex    = 0

        ' Document Title
        lblDocTitle.AutoSize  = False
        lblDocTitle.Text      = "Document Title"
        lblDocTitle.Font      = lbFont
        lblDocTitle.ForeColor = dark
        lblDocTitle.BackColor = System.Drawing.Color.Transparent
        lblDocTitle.Size      = New System.Drawing.Size(360, 20)
        lblDocTitle.Location  = New System.Drawing.Point(0, 76)
        lblDocTitle.Name      = "lblDocTitle"

        txtDocumentTitle.Font        = tbFont
        txtDocumentTitle.Size        = New System.Drawing.Size(360, 32)
        txtDocumentTitle.Location    = New System.Drawing.Point(0, 98)
        txtDocumentTitle.BackColor   = cream
        txtDocumentTitle.ForeColor   = dark
        txtDocumentTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtDocumentTitle.PlaceholderText = "Enter document title"
        txtDocumentTitle.Name        = "txtDocumentTitle"
        txtDocumentTitle.TabIndex    = 1

        ' Description
        lblDescription.AutoSize  = False
        lblDescription.Text      = "Description"
        lblDescription.Font      = lbFont
        lblDescription.ForeColor = dark
        lblDescription.BackColor = System.Drawing.Color.Transparent
        lblDescription.Size      = New System.Drawing.Size(360, 20)
        lblDescription.Location  = New System.Drawing.Point(0, 144)
        lblDescription.Name      = "lblDescription"

        txtDescription.Font        = tbFont
        txtDescription.Size        = New System.Drawing.Size(360, 90)
        txtDescription.Location    = New System.Drawing.Point(0, 166)
        txtDescription.Multiline   = True
        txtDescription.ScrollBars  = System.Windows.Forms.ScrollBars.Vertical
        txtDescription.BackColor   = cream
        txtDescription.ForeColor   = dark
        txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtDescription.PlaceholderText = "Enter document description"
        txtDescription.Name        = "txtDescription"
        txtDescription.TabIndex    = 2

        ' Date and Time
        lblDateTime.AutoSize  = False
        lblDateTime.Text      = "Date and Time"
        lblDateTime.Font      = lbFont
        lblDateTime.ForeColor = dark
        lblDateTime.BackColor = System.Drawing.Color.Transparent
        lblDateTime.Size      = New System.Drawing.Size(360, 20)
        lblDateTime.Location  = New System.Drawing.Point(0, 270)
        lblDateTime.Name      = "lblDateTime"

        dtpDateTime.Size      = New System.Drawing.Size(360, 32)
        dtpDateTime.Location  = New System.Drawing.Point(0, 292)
        dtpDateTime.Format    = System.Windows.Forms.DateTimePickerFormat.Custom
        dtpDateTime.CustomFormat = "yyyy-MM-dd HH:mm"
        dtpDateTime.CalendarMonthBackground = cream
        dtpDateTime.BackColor = cream
        dtpDateTime.Name      = "dtpDateTime"
        dtpDateTime.TabIndex  = 3

        ' Uploaded By
        lblUploadedBy.AutoSize  = False
        lblUploadedBy.Text      = "Uploaded By"
        lblUploadedBy.Font      = lbFont
        lblUploadedBy.ForeColor = dark
        lblUploadedBy.BackColor = System.Drawing.Color.Transparent
        lblUploadedBy.Size      = New System.Drawing.Size(360, 20)
        lblUploadedBy.Location  = New System.Drawing.Point(0, 338)
        lblUploadedBy.Name      = "lblUploadedBy"

        txtUploadedBy.Font        = tbFont
        txtUploadedBy.Size        = New System.Drawing.Size(360, 32)
        txtUploadedBy.Location    = New System.Drawing.Point(0, 360)
        txtUploadedBy.BackColor   = cream
        txtUploadedBy.ForeColor   = dark
        txtUploadedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtUploadedBy.PlaceholderText = "Enter uploader name"
        txtUploadedBy.Name        = "txtUploadedBy"
        txtUploadedBy.TabIndex    = 4

        ' Status
        lblStatus.AutoSize  = False
        lblStatus.Text      = "Status"
        lblStatus.Font      = lbFont
        lblStatus.ForeColor = dark
        lblStatus.BackColor = System.Drawing.Color.Transparent
        lblStatus.Size      = New System.Drawing.Size(360, 20)
        lblStatus.Location  = New System.Drawing.Point(0, 406)
        lblStatus.Name      = "lblStatus"

        cmbStatus.Font          = tbFont
        cmbStatus.Size          = New System.Drawing.Size(360, 32)
        cmbStatus.Location      = New System.Drawing.Point(0, 428)
        cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        cmbStatus.BackColor     = cream
        cmbStatus.ForeColor     = dark
        cmbStatus.FlatStyle     = System.Windows.Forms.FlatStyle.Flat
        cmbStatus.Name          = "cmbStatus"
        cmbStatus.TabIndex      = 5

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

        ' ?? pnlRight  (right half — image + PDF) ??????????????????
        pnlRight.BackColor = System.Drawing.Color.Transparent
        pnlRight.Dock      = System.Windows.Forms.DockStyle.Fill
        pnlRight.Name      = "pnlRight"
        pnlRight.Padding   = New System.Windows.Forms.Padding(20, 10, 0, 0)

        ' Image Banner
        lblImageBanner.AutoSize  = False
        lblImageBanner.Text      = "Project Image Banner"
        lblImageBanner.Font      = lbFont
        lblImageBanner.ForeColor = dark
        lblImageBanner.BackColor = System.Drawing.Color.Transparent
        lblImageBanner.Size      = New System.Drawing.Size(340, 20)
        lblImageBanner.Location  = New System.Drawing.Point(20, 10)
        lblImageBanner.Name      = "lblImageBanner"

        picBanner.Size      = New System.Drawing.Size(340, 180)
        picBanner.Location  = New System.Drawing.Point(20, 34)
        picBanner.BackColor = System.Drawing.Color.FromArgb(220, 215, 175)
        picBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        picBanner.SizeMode  = System.Windows.Forms.PictureBoxSizeMode.Zoom
        picBanner.Name      = "picBanner"

        btnUploadImage.Text                              = "Upload Image"
        btnUploadImage.Font                              = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        btnUploadImage.BackColor                         = System.Drawing.Color.FromArgb(121, 174, 111)
        btnUploadImage.ForeColor                         = System.Drawing.Color.White
        btnUploadImage.FlatStyle                         = System.Windows.Forms.FlatStyle.Flat
        btnUploadImage.FlatAppearance.BorderSize         = 0
        btnUploadImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(159, 203, 152)
        btnUploadImage.Size                              = New System.Drawing.Size(340, 36)
        btnUploadImage.Location                          = New System.Drawing.Point(20, 222)
        btnUploadImage.Cursor                            = System.Windows.Forms.Cursors.Hand
        btnUploadImage.Name                              = "btnUploadImage"
        btnUploadImage.TabIndex                          = 6

        ' PDF Document
        lblPDFDoc.AutoSize  = False
        lblPDFDoc.Text      = "Project Document (PDF)"
        lblPDFDoc.Font      = lbFont
        lblPDFDoc.ForeColor = dark
        lblPDFDoc.BackColor = System.Drawing.Color.Transparent
        lblPDFDoc.Size      = New System.Drawing.Size(340, 20)
        lblPDFDoc.Location  = New System.Drawing.Point(20, 276)
        lblPDFDoc.Name      = "lblPDFDoc"

        lblPDFFile.AutoSize  = False
        lblPDFFile.Text      = "No file selected"
        lblPDFFile.Font      = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Italic)
        lblPDFFile.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100)
        lblPDFFile.BackColor = System.Drawing.Color.FromArgb(220, 215, 175)
        lblPDFFile.Size      = New System.Drawing.Size(340, 36)
        lblPDFFile.Location  = New System.Drawing.Point(20, 298)
        lblPDFFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblPDFFile.Padding   = New System.Windows.Forms.Padding(8, 0, 0, 0)
        lblPDFFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        lblPDFFile.Name      = "lblPDFFile"

        btnUploadPDF.Text                              = "Upload PDF"
        btnUploadPDF.Font                              = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        btnUploadPDF.BackColor                         = System.Drawing.Color.FromArgb(121, 174, 111)
        btnUploadPDF.ForeColor                         = System.Drawing.Color.White
        btnUploadPDF.FlatStyle                         = System.Windows.Forms.FlatStyle.Flat
        btnUploadPDF.FlatAppearance.BorderSize         = 0
        btnUploadPDF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(159, 203, 152)
        btnUploadPDF.Size                              = New System.Drawing.Size(340, 36)
        btnUploadPDF.Location                          = New System.Drawing.Point(20, 342)
        btnUploadPDF.Cursor                            = System.Windows.Forms.Cursors.Hand
        btnUploadPDF.Name                              = "btnUploadPDF"
        btnUploadPDF.TabIndex                          = 7

        pnlRight.Controls.Add(lblImageBanner)
        pnlRight.Controls.Add(picBanner)
        pnlRight.Controls.Add(btnUploadImage)
        pnlRight.Controls.Add(lblPDFDoc)
        pnlRight.Controls.Add(lblPDFFile)
        pnlRight.Controls.Add(btnUploadPDF)

        pnlBody.Controls.Add(pnlRight)
        pnlBody.Controls.Add(pnlLeft)

        ' ?? Form ??????????????????????????????????????????????????
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize          = New System.Drawing.Size(860, 580)
        Me.Controls.Add(pnlBody)
        Me.Controls.Add(pnlFooter)
        Me.Controls.Add(pnlHeader)
        Me.BackColor           = System.Drawing.Color.FromArgb(242, 237, 194)
        Me.FormBorderStyle     = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox         = False
        Me.StartPosition       = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Name                = "AdminNewDocumentForm"
        Me.Text                = "New Document"

        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader       As System.Windows.Forms.Panel
    Friend WithEvents lblFormTitle    As System.Windows.Forms.Label
    Friend WithEvents pnlBody         As System.Windows.Forms.Panel
    Friend WithEvents pnlLeft         As System.Windows.Forms.Panel
    Friend WithEvents pnlRight        As System.Windows.Forms.Panel
    Friend WithEvents lblDocID        As System.Windows.Forms.Label
    Friend WithEvents txtDocumentID   As System.Windows.Forms.TextBox
    Friend WithEvents lblDocTitle     As System.Windows.Forms.Label
    Friend WithEvents txtDocumentTitle As System.Windows.Forms.TextBox
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
    Friend WithEvents btnAdd          As System.Windows.Forms.Button
    Friend WithEvents btnCancel       As System.Windows.Forms.Button

End Class
