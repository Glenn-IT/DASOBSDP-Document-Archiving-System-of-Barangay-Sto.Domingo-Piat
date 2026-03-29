Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim checklist As New frmDocumentChecklist()
        checklist.Show()
        Me.Hide()
    End Sub

End Class
