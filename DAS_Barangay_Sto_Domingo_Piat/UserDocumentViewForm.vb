Public Class UserDocumentViewForm
    Inherits System.Windows.Forms.Form

    Private _bannerImage As System.Drawing.Image
    Private _pdfBytes    As Byte()
    Private _pdfFileName As String

    Public Sub New(documentCode As String, title As String, docType As String,
                   description As String, uploadedBy As String,
                   dateUploaded As String, approvalStatus As String,
                   status As String, bannerBytes As Byte(),
                   pdfBytes As Byte(), pdfFileName As String)
        _pdfBytes    = pdfBytes
        _pdfFileName = pdfFileName
        BuildUI(documentCode, title, docType, description, uploadedBy,
                dateUploaded, approvalStatus, status, bannerBytes)
    End Sub

    Private Sub BuildUI(documentCode As String, title As String, docType As String,
                        description As String, uploadedBy As String,
                        dateUploaded As String, approvalStatus As String,
                        status As String, bannerBytes As Byte())

        Dim cream As System.Drawing.Color = System.Drawing.Color.FromArgb(242, 237, 194)
        Dim dark  As System.Drawing.Color = System.Drawing.Color.FromArgb(52, 103, 57)
        Dim mid   As System.Drawing.Color = System.Drawing.Color.FromArgb(121, 174, 111)

        Me.Text            = "Document Details"
        Me.ClientSize      = New System.Drawing.Size(560, 580)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox     = False
        Me.StartPosition   = System.Windows.Forms.FormStartPosition.CenterParent
        Me.BackColor       = cream

        ' Header
        Dim pnlHeader As New System.Windows.Forms.Panel() With {
            .BackColor = dark,
            .Dock      = System.Windows.Forms.DockStyle.Top,
            .Height    = 52
        }
        Dim lblHeader As New System.Windows.Forms.Label() With {
            .Text      = "Document Details",
            .Dock      = System.Windows.Forms.DockStyle.Fill,
            .ForeColor = cream,
            .Font      = New System.Drawing.Font("Segoe UI", 13, System.Drawing.FontStyle.Bold),
            .TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        }
        pnlHeader.Controls.Add(lblHeader)

        ' Banner image
        Dim picBanner As New System.Windows.Forms.PictureBox() With {
            .Dock      = System.Windows.Forms.DockStyle.Top,
            .Height    = 150,
            .SizeMode  = System.Windows.Forms.PictureBoxSizeMode.Zoom,
            .BackColor = System.Drawing.Color.FromArgb(230, 226, 180)
        }
        If bannerBytes IsNot Nothing AndAlso bannerBytes.Length > 0 Then
            Dim ms As New System.IO.MemoryStream(bannerBytes)
            _bannerImage    = System.Drawing.Image.FromStream(ms)
            picBanner.Image = _bannerImage
        End If

        ' Bottom button panel
        Dim pnlBottom As New System.Windows.Forms.Panel() With {
            .BackColor = cream,
            .Dock      = System.Windows.Forms.DockStyle.Bottom,
            .Height    = 58
        }

        Dim hasPdf As Boolean = _pdfBytes IsNot Nothing AndAlso _pdfBytes.Length > 0

        If hasPdf Then
            ' Two buttons: View PDF + Close
            Dim btnViewPdf As New System.Windows.Forms.Button() With {
                .Text      = "View PDF",
                .Font      = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold),
                .BackColor = mid,
                .ForeColor = cream,
                .FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                .Size      = New System.Drawing.Size(140, 36),
                .Location  = New System.Drawing.Point(140, 11),
                .Cursor    = System.Windows.Forms.Cursors.Hand
            }
            btnViewPdf.FlatAppearance.BorderSize = 0
            AddHandler btnViewPdf.Click, AddressOf OpenPdf
            pnlBottom.Controls.Add(btnViewPdf)

            Dim btnClose As New System.Windows.Forms.Button() With {
                .Text      = "Close",
                .Font      = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold),
                .BackColor = dark,
                .ForeColor = cream,
                .FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                .Size      = New System.Drawing.Size(140, 36),
                .Location  = New System.Drawing.Point(296, 11),
                .Cursor    = System.Windows.Forms.Cursors.Hand
            }
            btnClose.FlatAppearance.BorderSize = 0
            AddHandler btnClose.Click, Sub() Me.Close()
            pnlBottom.Controls.Add(btnClose)
        Else
            ' Single Close button centered
            Dim btnClose As New System.Windows.Forms.Button() With {
                .Text      = "Close",
                .Font      = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold),
                .BackColor = dark,
                .ForeColor = cream,
                .FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                .Size      = New System.Drawing.Size(140, 36),
                .Location  = New System.Drawing.Point(210, 11),
                .Cursor    = System.Windows.Forms.Cursors.Hand
            }
            btnClose.FlatAppearance.BorderSize = 0
            AddHandler btnClose.Click, Sub() Me.Close()
            pnlBottom.Controls.Add(btnClose)
        End If

        ' Details panel (fills remaining space)
        Dim pnlDetails As New System.Windows.Forms.Panel() With {
            .Dock       = System.Windows.Forms.DockStyle.Fill,
            .BackColor  = cream,
            .Padding    = New System.Windows.Forms.Padding(24, 12, 24, 12),
            .AutoScroll = True
        }

        Dim fields As String()() = {
            New String() {"Document Code",   documentCode},
            New String() {"Title",           title},
            New String() {"Document Type",   If(String.IsNullOrEmpty(docType), "-", docType)},
            New String() {"Description",     If(String.IsNullOrEmpty(description), "-", description)},
            New String() {"Uploaded By",     uploadedBy},
            New String() {"Date Uploaded",   dateUploaded},
            New String() {"Approval Status", approvalStatus},
            New String() {"Status",          status},
            New String() {"PDF File",        If(String.IsNullOrEmpty(_pdfFileName), "No PDF attached", _pdfFileName)}
        }

        Dim yPos As Integer = 10
        For Each pair In fields
            Dim lbl As New System.Windows.Forms.Label() With {
                .Text      = pair(0) & ":",
                .Font      = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold),
                .ForeColor = dark,
                .AutoSize  = False,
                .Size      = New System.Drawing.Size(130, 24),
                .Location  = New System.Drawing.Point(0, yPos)
            }
            Dim val As New System.Windows.Forms.Label() With {
                .Text      = pair(1),
                .Font      = New System.Drawing.Font("Segoe UI", 9),
                .ForeColor = dark,
                .AutoSize  = False,
                .Size      = New System.Drawing.Size(370, 24),
                .Location  = New System.Drawing.Point(134, yPos)
            }
            pnlDetails.Controls.Add(lbl)
            pnlDetails.Controls.Add(val)
            yPos += 32
        Next

        ' Add in correct dock order: Fill first, Bottom, then Top (last added = topmost)
        Me.Controls.Add(pnlDetails)
        Me.Controls.Add(pnlBottom)
        Me.Controls.Add(picBanner)
        Me.Controls.Add(pnlHeader)
    End Sub

    Private Sub OpenPdf(sender As Object, e As EventArgs)
        Try
            Dim fileName As String = If(String.IsNullOrEmpty(_pdfFileName), "document.pdf", _pdfFileName)
            Dim tempPath As String = System.IO.Path.Combine(System.IO.Path.GetTempPath(), fileName)
            System.IO.File.WriteAllBytes(tempPath, _pdfBytes)
            System.Diagnostics.Process.Start(
                New System.Diagnostics.ProcessStartInfo(tempPath) With {.UseShellExecute = True})
        Catch ex As Exception
            MessageBox.Show("Could not open PDF: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing Then
            _bannerImage?.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

End Class
