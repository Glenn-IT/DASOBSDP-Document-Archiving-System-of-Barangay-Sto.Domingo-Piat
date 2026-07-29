Public Class DocumentTypeEventArgs
    Inherits EventArgs

    Public ReadOnly Property DocumentType As String

    Public Sub New(documentType As String)
        Me.DocumentType = documentType
    End Sub

End Class
