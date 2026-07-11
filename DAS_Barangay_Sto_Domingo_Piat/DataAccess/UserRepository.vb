Imports Microsoft.Data.SqlClient

Public Module UserRepository

    Public Function GetAll() As DataTable
        Dim dt As New DataTable()
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Dim cmd As New SqlCommand(
                "SELECT UserID, UserCode, Username, UserType, Status " &
                "FROM tbl_Users ORDER BY CreatedAt DESC", con)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dt)
        End Using
        Return dt
    End Function

    Public Function GetById(userID As Integer) As DataTable
        Dim dt As New DataTable()
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Dim cmd As New SqlCommand(
                "SELECT Username, UserType, SecurityQuestion, SecurityAnswer " &
                "FROM tbl_Users WHERE UserID = @id", con)
            cmd.Parameters.AddWithValue("@id", userID)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dt)
        End Using
        Return dt
    End Function

    Public Function GetByUsername(username As String) As DataTable
        Dim dt As New DataTable()
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Dim cmd As New SqlCommand(
                "SELECT UserCode, UserType, PasswordHash, Status, " &
                "       SecurityQuestion, SecurityAnswer " &
                "FROM tbl_Users WHERE Username COLLATE Latin1_General_CS_AS = @username", con)
            cmd.Parameters.AddWithValue("@username", username)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dt)
        End Using
        Return dt
    End Function

    Public Function GetSecurityQuestion(username As String, userType As String) As String
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Dim cmd As New SqlCommand(
                "SELECT SecurityQuestion FROM tbl_Users " &
                "WHERE Username = @username AND UserType = @userType", con)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@userType", userType)
            Dim result As Object = cmd.ExecuteScalar()
            Return If(result Is Nothing OrElse result Is DBNull.Value, Nothing, result.ToString())
        End Using
    End Function

    Public Function ValidateSecurityAnswer(username As String,
                                           userType As String,
                                           question As String,
                                           answer   As String) As Boolean
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Dim cmd As New SqlCommand(
                "SELECT COUNT(*) FROM tbl_Users " &
                "WHERE Username = @username AND UserType = @userType " &
                "AND SecurityQuestion = @question AND SecurityAnswer = @answer", con)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@userType", userType)
            cmd.Parameters.AddWithValue("@question", question)
            cmd.Parameters.AddWithValue("@answer",   answer)
            Return CInt(cmd.ExecuteScalar()) > 0
        End Using
    End Function

    Public Function GenerateCode() As String
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Dim cmd As New SqlCommand("SELECT ISNULL(MAX(UserID), 0) FROM tbl_Users", con)
            Dim maxId As Integer = CInt(cmd.ExecuteScalar())
            Return $"USR-{(maxId + 1):D4}"
        End Using
    End Function

    Public Function CheckDuplicateUsername(username As String) As Boolean
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Dim cmd As New SqlCommand(
                "SELECT COUNT(*) FROM tbl_Users WHERE Username = @username", con)
            cmd.Parameters.AddWithValue("@username", username)
            Return CInt(cmd.ExecuteScalar()) > 0
        End Using
    End Function

    Public Sub Insert(userCode As String, username As String, passwordHash As String,
                      userType As String, securityQuestion As String, securityAnswer As String)
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Dim sql As String =
                "INSERT INTO tbl_Users " &
                "(UserCode, Username, PasswordHash, UserType, SecurityQuestion, SecurityAnswer, Status) " &
                "VALUES (@code, @username, @password, @type, @question, @answer, 'Active')"
            Using cmd As New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@code",     userCode)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", passwordHash)
                cmd.Parameters.AddWithValue("@type",     userType)
                cmd.Parameters.AddWithValue("@question", securityQuestion)
                cmd.Parameters.AddWithValue("@answer",   securityAnswer)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub Update(userID As Integer, username As String, userType As String,
                      securityQuestion As String, securityAnswer As String,
                      Optional passwordHash As String = Nothing)
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Dim sql As String
            Dim cmd As SqlCommand

            If Not String.IsNullOrEmpty(passwordHash) Then
                sql = "UPDATE tbl_Users SET Username=@username, PasswordHash=@password, " &
                      "UserType=@type, SecurityQuestion=@question, SecurityAnswer=@answer " &
                      "WHERE UserID=@id"
                cmd = New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@password", passwordHash)
            Else
                sql = "UPDATE tbl_Users SET Username=@username, UserType=@type, " &
                      "SecurityQuestion=@question, SecurityAnswer=@answer WHERE UserID=@id"
                cmd = New SqlCommand(sql, con)
            End If

            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@type",     userType)
            cmd.Parameters.AddWithValue("@question", securityQuestion)
            cmd.Parameters.AddWithValue("@answer",   securityAnswer)
            cmd.Parameters.AddWithValue("@id",       userID)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End Using
    End Sub

    Public Sub UpdateProfile(username As String, securityQuestion As String,
                             securityAnswer As String,
                             Optional passwordHash As String = Nothing)
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Dim sql As String
            Dim cmd As SqlCommand

            If Not String.IsNullOrEmpty(passwordHash) Then
                sql = "UPDATE tbl_Users SET PasswordHash=@hash, SecurityQuestion=@question, " &
                      "SecurityAnswer=@answer WHERE Username=@username"
                cmd = New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@hash", passwordHash)
            Else
                sql = "UPDATE tbl_Users SET SecurityQuestion=@question, " &
                      "SecurityAnswer=@answer WHERE Username=@username"
                cmd = New SqlCommand(sql, con)
            End If

            cmd.Parameters.AddWithValue("@question", securityQuestion)
            cmd.Parameters.AddWithValue("@answer",   securityAnswer)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End Using
    End Sub

    Public Sub UpdatePassword(username As String, userType As String, passwordHash As String)
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Dim cmd As New SqlCommand(
                "UPDATE tbl_Users SET PasswordHash = @hash " &
                "WHERE Username = @username AND UserType = @userType", con)
            cmd.Parameters.AddWithValue("@hash",     passwordHash)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@userType", userType)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub Delete(userID As Integer)
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Dim cmd As New SqlCommand(
                "DELETE FROM tbl_Users WHERE UserID = @id", con)
            cmd.Parameters.AddWithValue("@id", userID)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

End Module
