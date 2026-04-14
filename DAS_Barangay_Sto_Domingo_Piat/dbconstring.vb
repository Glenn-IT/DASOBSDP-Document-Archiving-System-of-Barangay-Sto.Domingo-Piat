Imports System.IO

Public Class dbconstring

    ' Default connection string — matches DATABASE.md
    Private Const DefaultConnection As String =
        "Data Source=Glenn\SQLEXPRESS;" &
        "Initial Catalog=dasbsdp;" &
        "Integrated Security=True;"

    ''' <summary>
    ''' Returns the active connection string.
    ''' Reads from config.txt in the application directory if it exists,
    ''' otherwise falls back to the default hardcoded connection string.
    ''' </summary>
    Public Shared ReadOnly Property Connection As String
        Get
            Dim configPath As String = Path.Combine(
                Environment.CurrentDirectory, "config.txt")

            If File.Exists(configPath) Then
                Return File.ReadAllText(configPath).Trim()
            End If

            Return DefaultConnection
        End Get
    End Property

End Class
