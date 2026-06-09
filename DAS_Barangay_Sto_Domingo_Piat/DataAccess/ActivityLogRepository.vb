Imports Microsoft.Data.SqlClient

Public Module ActivityLogRepository

    Public Function GetAll(Optional fromDate As DateTime = Nothing,
                           Optional toDate   As DateTime = Nothing,
                           Optional username As String   = Nothing) As DataTable
        If fromDate = Nothing Then fromDate = DateTime.MinValue
        If toDate   = Nothing Then toDate   = DateTime.MaxValue

        Dim dt As New DataTable()
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Dim sql As String
            Dim cmd As SqlCommand

            If String.IsNullOrEmpty(username) AndAlso
               fromDate = DateTime.MinValue AndAlso toDate = DateTime.MaxValue Then
                sql = "SELECT LogCode, Username, LogDate, Result, Description " &
                      "FROM tbl_ActivityLogs ORDER BY LogDate DESC"
                cmd = New SqlCommand(sql, con)
            Else
                sql = "SELECT LogCode, Username, LogDate, Result, Description " &
                      "FROM tbl_ActivityLogs " &
                      "WHERE LogDate BETWEEN @from AND @to " &
                      "AND Username LIKE @username " &
                      "ORDER BY LogDate DESC"
                cmd = New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@from",     fromDate)
                cmd.Parameters.AddWithValue("@to",       toDate.Date.AddDays(1).AddSeconds(-1))
                cmd.Parameters.AddWithValue("@username", "%" & If(username, "") & "%")
            End If

            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dt)
        End Using
        Return dt
    End Function

    Public Sub Insert(username As String, result As String, description As String)
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()

            Dim logCode As String = "LOG-0001"
            Dim cmdCode As New SqlCommand(
                "SELECT TOP 1 LogCode FROM tbl_ActivityLogs ORDER BY LogID DESC", con)
            Dim lastCode As Object = cmdCode.ExecuteScalar()
            If lastCode IsNot Nothing AndAlso lastCode IsNot DBNull.Value Then
                Dim lastNum As Integer = Integer.Parse(lastCode.ToString().Replace("LOG-", ""))
                logCode = "LOG-" & (lastNum + 1).ToString("D4")
            End If

            Dim sql As String =
                "INSERT INTO tbl_ActivityLogs (LogCode, Username, LogDate, Result, Description) " &
                "VALUES (@LogCode, @Username, GETDATE(), @Result, @Description)"
            Using cmd As New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@LogCode",     logCode)
                cmd.Parameters.AddWithValue("@Username",    username)
                cmd.Parameters.AddWithValue("@Result",      result)
                cmd.Parameters.AddWithValue("@Description", description)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

End Module
