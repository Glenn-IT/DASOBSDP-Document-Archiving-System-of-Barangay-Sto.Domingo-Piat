Public Class UserDeleteDocumentForm
    Inherits System.Windows.Forms.Form

    Public Property DocumentID   As Integer
    Public Property DocumentCode As String

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub UserDeleteDocumentForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblMessage.Text = $"Delete document: {DocumentCode}?"
        lblSubMsg.Text  = "This action cannot be undone."
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            DocumentRepository.DeleteByUser(DocumentID, SessionManager.Username)
            ActivityLogger.Log(SessionManager.Username, "Success",
                $"User deleted document: {DocumentCode}")
            MessageBox.Show("Document deleted successfully.", "Delete Document",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error deleting document: " & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class
