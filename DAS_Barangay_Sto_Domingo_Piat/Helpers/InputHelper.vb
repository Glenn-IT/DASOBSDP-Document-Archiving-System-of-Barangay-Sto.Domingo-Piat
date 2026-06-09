Public Module InputHelper

    Public Function SanitizeInput(text As String) As String
        If text Is Nothing Then Return String.Empty
        Dim result As String = text.Trim()
        result = result.Replace("<", "")
        result = result.Replace(">", "")
        result = result.Replace(Chr(0), "")
        Return result
    End Function

End Module
