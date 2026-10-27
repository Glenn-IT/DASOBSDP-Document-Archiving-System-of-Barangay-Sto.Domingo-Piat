Imports System.IO
Imports System.Drawing
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports Microsoft.Web.WebView2.WinForms

Public Class UserDocumentViewForm
    Inherits Form

    Private _pdfBytes      As Byte()
    Private _pdfFileName   As String
    Private _documentID    As Integer = 0
    Private _tempPdfPath   As String = ""
    Private _webView       As WebView2
    Private _pnlPreviewBox As Panel

    Public Sub New(documentCode As String, title As String, docType As String,
                   description As String, uploadedBy As String,
                   dateUploaded As String, approvalStatus As String,
                   status As String, bannerBytes As Byte(),
                   pdfBytes As Byte(), pdfFileName As String,
                   Optional documentID As Integer = 0)
        _pdfBytes    = pdfBytes
        _pdfFileName = pdfFileName
        _documentID  = documentID

        BuildUI(documentCode, title, docType, description, uploadedBy,
                dateUploaded, approvalStatus, status)
    End Sub

    Private Sub BuildUI(documentCode As String, title As String, docType As String,
                        description As String, uploadedBy As String,
                        dateUploaded As String, approvalStatus As String,
                        status As String)

        Dim cream As Color = Color.FromArgb(242, 237, 194)
        Dim dark  As Color = Color.FromArgb(52, 103, 57)
        Dim mid   As Color = Color.FromArgb(121, 174, 111)
        Dim teal  As Color = Color.FromArgb(32, 148, 148)
        Dim cardBg As Color = Color.FromArgb(235, 231, 190)

        Me.Text            = $"Document Details - {documentCode}"
        Me.ClientSize      = New Size(1040, 700)
        Me.MinimumSize     = New Size(880, 600)
        Me.StartPosition   = FormStartPosition.CenterParent
        Me.BackColor       = cream

        ' Top Header
        Dim pnlHeader As New Panel() With {
            .BackColor = dark,
            .Dock      = DockStyle.Top,
            .Height    = 54,
            .Padding   = New Padding(20, 0, 20, 0)
        }
        Dim lblHeader As New Label() With {
            .Text      = $"Official Archive Document: {documentCode}",
            .Dock      = DockStyle.Fill,
            .ForeColor = cream,
            .Font      = New Font("Segoe UI", 12.5F, FontStyle.Bold),
            .TextAlign = ContentAlignment.MiddleLeft
        }
        pnlHeader.Controls.Add(lblHeader)

        ' Bottom Action Bar
        Dim pnlBottom As New Panel() With {
            .BackColor = dark,
            .Dock      = DockStyle.Bottom,
            .Height    = 60,
            .Padding   = New Padding(16, 11, 16, 11)
        }

        Dim hasPdf As Boolean = (_pdfBytes IsNot Nothing AndAlso _pdfBytes.Length > 0)
        Dim canApprove As Boolean = (SessionManager.UserType = "Admin" AndAlso approvalStatus = "For Review" AndAlso _documentID > 0)

        ' Left Flow / Buttons
        Dim flowButtons As New FlowLayoutPanel() With {
            .Dock = DockStyle.Fill,
            .FlowDirection = FlowDirection.LeftToRight,
            .BackColor = Color.Transparent,
            .WrapContents = False
        }

        ' 1. Print via Chrome Button (Item 3)
        Dim btnPrintChrome As New Button() With {
            .Text      = "🖨️  Print Document (Chrome)",
            .Font      = New Font("Segoe UI", 9.5F, FontStyle.Bold),
            .BackColor = mid,
            .ForeColor = Color.White,
            .FlatStyle = FlatStyle.Flat,
            .Size      = New Size(220, 38),
            .Margin    = New Padding(0, 0, 10, 0),
            .Cursor    = Cursors.Hand
        }
        btnPrintChrome.FlatAppearance.BorderSize = 0
        AddHandler btnPrintChrome.Click,
            Sub()
                If _documentID > 0 Then
                    ReportHelper.PrintSingleDocumentReport(_documentID)
                Else
                    MessageBox.Show("Cannot generate print report for unsaved document.", "Print", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Sub
        flowButtons.Controls.Add(btnPrintChrome)

        ' 2. Open PDF Externally Button
        If hasPdf Then
            Dim btnOpenPdf As New Button() With {
                .Text      = "📄  Open PDF",
                .Font      = New Font("Segoe UI", 9.5F, FontStyle.Bold),
                .BackColor = Color.FromArgb(70, 130, 80),
                .ForeColor = cream,
                .FlatStyle = FlatStyle.Flat,
                .Size      = New Size(130, 38),
                .Margin    = New Padding(0, 0, 10, 0),
                .Cursor    = Cursors.Hand
            }
            btnOpenPdf.FlatAppearance.BorderSize = 0
            AddHandler btnOpenPdf.Click, AddressOf OpenPdf
            flowButtons.Controls.Add(btnOpenPdf)
        End If

        ' 3. Approve Button (If Admin)
        If canApprove Then
            Dim btnApprove As New Button() With {
                .Text      = "✓  Approve Document",
                .Font      = New Font("Segoe UI", 9.5F, FontStyle.Bold),
                .BackColor = teal,
                .ForeColor = Color.White,
                .FlatStyle = FlatStyle.Flat,
                .Size      = New Size(170, 38),
                .Margin    = New Padding(0, 0, 10, 0),
                .Cursor    = Cursors.Hand
            }
            btnApprove.FlatAppearance.BorderSize = 0
            AddHandler btnApprove.Click,
                Sub()
                    Dim res = MessageBox.Show($"Approve document '{documentCode}' now?{Environment.NewLine}{Environment.NewLine}This will officially verify the document for the archive.",
                                              "Approve Document", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If res = DialogResult.Yes Then
                        Try
                            DocumentRepository.Approve(_documentID)
                            ActivityLogger.Log(SessionManager.Username, "Success", $"Admin approved document: {documentCode}")
                            MessageBox.Show($"Document {documentCode} approved successfully.", "Approve Document", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.DialogResult = DialogResult.OK
                            Me.Close()
                        Catch ex As Exception
                            MessageBox.Show("Error approving document: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End If
                End Sub
            flowButtons.Controls.Add(btnApprove)
        End If

        ' 4. Close Button
        Dim btnClose As New Button() With {
            .Text      = "Close",
            .Font      = New Font("Segoe UI", 9.5F, FontStyle.Bold),
            .BackColor = Color.FromArgb(80, 80, 80),
            .ForeColor = Color.White,
            .FlatStyle = FlatStyle.Flat,
            .Size      = New Size(100, 38),
            .Margin    = New Padding(0, 0, 10, 0),
            .Cursor    = Cursors.Hand
        }
        btnClose.FlatAppearance.BorderSize = 0
        AddHandler btnClose.Click, Sub() Me.Close()
        flowButtons.Controls.Add(btnClose)

        pnlBottom.Controls.Add(flowButtons)

        ' Main Body Split: Left = Metadata Details, Right = PDF Preview (Item 1)
        Dim pnlBody As New Panel() With {
            .Dock = DockStyle.Fill,
            .BackColor = cream
        }

        ' Left Details Panel (No dock on header to eliminate overlap)
        Dim pnlDetails As New Panel() With {
            .Dock       = DockStyle.Left,
            .Width      = 430,
            .BackColor  = cardBg,
            .Padding    = New Padding(20, 16, 20, 16),
            .AutoScroll = True
        }

        Dim lblDetailsHeader As New Label() With {
            .Text      = "DOCUMENT INFORMATION",
            .Font      = New Font("Segoe UI", 11.0F, FontStyle.Bold),
            .ForeColor = dark,
            .Location  = New Point(18, 16),
            .Size      = New Size(390, 26)
        }
        pnlDetails.Controls.Add(lblDetailsHeader)

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

        Dim yPos As Integer = 54
        For Each pair In fields
            Dim isDesc As Boolean = (pair(0) = "Description")
            Dim lblName As New Label() With {
                .Text      = pair(0) & ":",
                .Font      = New Font("Segoe UI", 9.0F, FontStyle.Bold),
                .ForeColor = dark,
                .Size      = New Size(390, 18),
                .Location  = New Point(18, yPos)
            }
            Dim lblVal As New Label() With {
                .Text      = pair(1),
                .Font      = New Font("Segoe UI", 9.5F, FontStyle.Regular),
                .ForeColor = Color.FromArgb(30, 45, 30),
                .Size      = New Size(390, If(isDesc, 56, 22)),
                .Location  = New Point(18, yPos + 20)
            }
            pnlDetails.Controls.Add(lblName)
            pnlDetails.Controls.Add(lblVal)
            yPos += If(isDesc, 82, 48)
        Next

        ' Right PDF Preview Panel (Item 1)
        Dim pnlPreviewContainer As New Panel() With {
            .Dock      = DockStyle.Fill,
            .BackColor = Color.FromArgb(220, 216, 175),
            .Padding   = New Padding(12)
        }

        _pnlPreviewBox = New Panel() With {
            .Dock      = DockStyle.Fill,
            .BackColor = Color.White
        }

        Dim pnlPreviewTitle As New Panel() With {
            .Dock      = DockStyle.Top,
            .Height    = 34,
            .BackColor = mid,
            .Padding   = New Padding(12, 6, 12, 6)
        }
        Dim lblPreviewTitle As New Label() With {
            .Text      = If(hasPdf, $"📄 PDF Document Preview: {_pdfFileName}", "📄 PDF Document Preview"),
            .Font      = New Font("Segoe UI", 9.5F, FontStyle.Bold),
            .ForeColor = Color.White,
            .Dock      = DockStyle.Fill,
            .TextAlign = ContentAlignment.MiddleLeft
        }
        pnlPreviewTitle.Controls.Add(lblPreviewTitle)
        _pnlPreviewBox.Controls.Add(pnlPreviewTitle)

        If hasPdf Then
            Try
                Dim safeName As String = "PREV_" & documentCode.Replace("-", "_") & "_" & Path.GetFileName(_pdfFileName)
                _tempPdfPath = Path.Combine(Path.GetTempPath(), safeName)
                File.WriteAllBytes(_tempPdfPath, _pdfBytes)

                _webView = New WebView2() With {
                    .Dock = DockStyle.Fill
                }
                _pnlPreviewBox.Controls.Add(_webView)
                _webView.BringToFront()

                AddHandler Me.Shown, Async Sub(s, e)
                    Await InitializePdfViewerAsync(_tempPdfPath)
                End Sub
            Catch ex As Exception
                ShowPreviewFallback("Unable to initialize PDF preview: " & ex.Message)
            End Try
        Else
            ShowNoPdfMessage()
        End If

        pnlPreviewContainer.Controls.Add(_pnlPreviewBox)
        pnlBody.Controls.Add(pnlPreviewContainer)
        pnlBody.Controls.Add(pnlDetails)

        Me.Controls.Add(pnlBody)
        Me.Controls.Add(pnlBottom)
        Me.Controls.Add(pnlHeader)
    End Sub

    Private Async Function InitializePdfViewerAsync(pdfPath As String) As Task
        Try
            If _webView Is Nothing OrElse _webView.IsDisposed Then Return

            ' Initialize WebView2 Chromium Core
            Await _webView.EnsureCoreWebView2Async()

            If _webView.CoreWebView2 IsNot Nothing Then
                _webView.CoreWebView2.Settings.AreDefaultContextMenusEnabled = True
                _webView.CoreWebView2.Settings.IsZoomControlEnabled = True
                _webView.CoreWebView2.Settings.AreDevToolsEnabled = False

                Dim uri As New Uri(pdfPath)
                _webView.CoreWebView2.Navigate(uri.AbsoluteUri)
            End If
        Catch ex As Exception
            ShowPreviewFallback("WebView2 preview could not be displayed: " & ex.Message)
        End Try
    End Function

    Private Sub ShowPreviewFallback(errorMessage As String)
        If _pnlPreviewBox Is Nothing OrElse _pnlPreviewBox.IsDisposed Then Return

        If _webView IsNot Nothing Then
            Try
                _pnlPreviewBox.Controls.Remove(_webView)
                _webView.Dispose()
                _webView = Nothing
            Catch
            End Try
        End If

        Dim pnlFallback As New Panel() With {
            .Dock = DockStyle.Fill,
            .BackColor = Color.White,
            .Padding = New Padding(30)
        }

        Dim lblIcon As New Label() With {
            .Text = "📄",
            .Font = New Font("Segoe UI", 48),
            .ForeColor = Color.FromArgb(70, 130, 80),
            .Dock = DockStyle.Top,
            .Height = 80,
            .TextAlign = ContentAlignment.MiddleCenter
        }

        Dim lblMessage As New Label() With {
            .Text = $"PDF preview is not supported in the embedded viewer.{Environment.NewLine}{Environment.NewLine}" &
                    $"Click 'Open PDF' or 'Print Document (Chrome)' below to view the full document.{Environment.NewLine}{Environment.NewLine}" &
                    $"Note: {errorMessage}",
            .Font = New Font("Segoe UI", 10.0F),
            .ForeColor = Color.FromArgb(80, 80, 80),
            .Dock = DockStyle.Fill,
            .TextAlign = ContentAlignment.TopCenter
        }

        pnlFallback.Controls.Add(lblMessage)
        pnlFallback.Controls.Add(lblIcon)
        _pnlPreviewBox.Controls.Add(pnlFallback)
        pnlFallback.BringToFront()
    End Sub

    Private Sub ShowNoPdfMessage()
        If _pnlPreviewBox Is Nothing OrElse _pnlPreviewBox.IsDisposed Then Return

        Dim pnlNoPdf As New Panel() With {
            .Dock = DockStyle.Fill,
            .BackColor = Color.White,
            .Padding = New Padding(30)
        }

        Dim lblIcon As New Label() With {
            .Text = "ℹ️",
            .Font = New Font("Segoe UI", 40),
            .ForeColor = Color.FromArgb(120, 150, 120),
            .Dock = DockStyle.Top,
            .Height = 70,
            .TextAlign = ContentAlignment.MiddleCenter
        }

        Dim lblMessage As New Label() With {
            .Text = "No PDF document uploaded for this record." & Environment.NewLine & Environment.NewLine &
                    "Scanned documents or digital attachments will be displayed here.",
            .Font = New Font("Segoe UI", 10.5F, FontStyle.Italic),
            .ForeColor = Color.FromArgb(100, 110, 100),
            .Dock = DockStyle.Fill,
            .TextAlign = ContentAlignment.TopCenter
        }

        pnlNoPdf.Controls.Add(lblMessage)
        pnlNoPdf.Controls.Add(lblIcon)
        _pnlPreviewBox.Controls.Add(pnlNoPdf)
        pnlNoPdf.BringToFront()
    End Sub

    Private Sub OpenPdf(sender As Object, e As EventArgs)
        If _pdfBytes Is Nothing OrElse _pdfBytes.Length = 0 Then
            MessageBox.Show("No PDF file attached to this document.", "PDF Viewer",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            If String.IsNullOrEmpty(_tempPdfPath) OrElse Not File.Exists(_tempPdfPath) Then
                Dim fileName As String = If(String.IsNullOrEmpty(_pdfFileName), "document.pdf", _pdfFileName)
                _tempPdfPath = Path.Combine(Path.GetTempPath(), fileName)
                File.WriteAllBytes(_tempPdfPath, _pdfBytes)
            End If

            Process.Start(New ProcessStartInfo(_tempPdfPath) With {.UseShellExecute = True})
        Catch ex As Exception
            MessageBox.Show("Could not open PDF: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing Then
            Try
                If _webView IsNot Nothing Then
                    _webView.Dispose()
                    _webView = Nothing
                End If
            Catch
            End Try

            If Not String.IsNullOrEmpty(_tempPdfPath) AndAlso File.Exists(_tempPdfPath) Then
                Try
                    File.Delete(_tempPdfPath)
                Catch
                End Try
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

End Class
