Public Class UserUploadDocumentPanel
    Inherits System.Windows.Forms.UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub UserUploadDocumentPanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        cmbDocumentType.Items.AddRange(New String() {
            "Ordinance", "Resolution", "Budget Report",
            "Health Report", "Infrastructure", "Livelihood", "Others"
        })
        cmbDocumentType.SelectedIndex = 0
        cmbStatus.Items.AddRange(New String() {"Active", "Archived"})
        cmbStatus.SelectedIndex = 0
        txtDocumentID.Text = "DOC-" & Format(Now, "yyyyMMddHHmmss")
        dtpDateTime.Value  = Now
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

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        If txtDocumentTitle.Text.Trim() = "" OrElse txtUploadedBy.Text.Trim() = "" Then
            MessageBox.Show("Please fill in all required fields.", "Upload Document",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        MessageBox.Show("Document uploaded successfully!", "Upload Document",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' Reset form
        txtDocumentTitle.Clear()
        txtDescription.Clear()
        txtUploadedBy.Clear()
        picBanner.Image = Nothing
        lblPDFFile.Text = "No file selected"
        cmbStatus.SelectedIndex = 0
        cmbDocumentType.SelectedIndex = 0
        txtDocumentID.Text = "DOC-" & Format(Now, "yyyyMMddHHmmss")
        dtpDateTime.Value = Now
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        UserUploadDocumentPanel_Load(Nothing, EventArgs.Empty)
        txtDocumentTitle.Clear()
        txtDescription.Clear()
        txtUploadedBy.Clear()
        picBanner.Image = Nothing
        lblPDFFile.Text = "No file selected"
    End Sub

End Class
