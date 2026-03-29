Public Class AdminUpdateDocumentForm
    Inherits System.Windows.Forms.Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub AdminUpdateDocumentForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        cmbStatus.Items.AddRange(New String() {"Active", "Archived"})

        ' Pre-fill with placeholder selected record data
        txtDocumentID.Text    = "DOC-0003"
        txtDocumentTitle.Text = "Infrastructure Project Docs"
        txtDescription.Text   = "Documents related to the barangay infrastructure development project for FY 2025."
        dtpDateTime.Value     = New DateTime(2025, 2, 3, 10, 15, 0)
        txtUploadedBy.Text    = "mreyes"
        cmbStatus.SelectedItem = "Active"
        lblPDFFile.Text       = "infrastructure_project_2025.pdf"
    End Sub

    Private Sub btnUploadImage_Click(sender As Object, e As EventArgs) Handles btnUploadImage.Click
        Using ofd As New OpenFileDialog()
            ofd.Title  = "Select Image Banner"
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            If ofd.ShowDialog() = DialogResult.OK Then
                picBanner.Image    = System.Drawing.Image.FromFile(ofd.FileName)
                picBanner.SizeMode = PictureBoxSizeMode.Zoom
            End If
        End Using
    End Sub

    Private Sub btnUploadPDF_Click(sender As Object, e As EventArgs) Handles btnUploadPDF.Click
        Using ofd As New OpenFileDialog()
            ofd.Title  = "Select PDF Document"
            ofd.Filter = "PDF Files|*.pdf"
            If ofd.ShowDialog() = DialogResult.OK Then
                lblPDFFile.Text = System.IO.Path.GetFileName(ofd.FileName)
            End If
        End Using
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtDocumentTitle.Text.Trim() = "" OrElse txtUploadedBy.Text.Trim() = "" Then
            MessageBox.Show("Please fill in all required fields.", "Update Document",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        MessageBox.Show("Document updated successfully!", "Update Document",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class
