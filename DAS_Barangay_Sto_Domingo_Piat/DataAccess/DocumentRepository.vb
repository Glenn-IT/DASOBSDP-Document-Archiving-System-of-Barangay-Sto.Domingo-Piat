Imports Microsoft.Data.SqlClient

Public Module DocumentRepository

    Public Function GetAll(Optional search As String = Nothing) As DataTable
        Dim dt As New DataTable()
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Dim sql As String
            Dim cmd As SqlCommand
            If String.IsNullOrEmpty(search) Then
                sql = "SELECT DocumentID, DocumentCode, Title, UploadedBy, DateUploaded, Status " &
                      "FROM tbl_Documents ORDER BY DateUploaded DESC"
                cmd = New SqlCommand(sql, con)
            Else
                sql = "SELECT DocumentID, DocumentCode, Title, UploadedBy, DateUploaded, Status " &
                      "FROM tbl_Documents " &
                      "WHERE Title LIKE @search OR DocumentType LIKE @search " &
                      "ORDER BY DateUploaded DESC"
                cmd = New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@search", "%" & search & "%")
            End If
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dt)
        End Using
        Return dt
    End Function

    Public Function GetByUser(username As String, Optional search As String = Nothing) As DataTable
        Dim dt As New DataTable()
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Dim sql As String
            Dim cmd As SqlCommand
            If String.IsNullOrEmpty(search) Then
                sql = "SELECT DocumentID, DocumentCode, Title, DateUploaded, ApprovalStatus, Status " &
                      "FROM tbl_Documents WHERE UploadedBy = @username ORDER BY DateUploaded DESC"
                cmd = New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@username", username)
            Else
                sql = "SELECT DocumentID, DocumentCode, Title, DateUploaded, ApprovalStatus, Status " &
                      "FROM tbl_Documents " &
                      "WHERE UploadedBy = @username " &
                      "AND (Title LIKE @search OR DocumentType LIKE @search) " &
                      "ORDER BY DateUploaded DESC"
                cmd = New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@search",   "%" & search & "%")
            End If
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dt)
        End Using
        Return dt
    End Function

    Public Function GetActive(Optional search As String = Nothing) As DataTable
        Dim dt As New DataTable()
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Dim sql As String
            Dim cmd As SqlCommand
            If String.IsNullOrEmpty(search) Then
                sql = "SELECT DocumentID, DocumentCode, Title, DateUploaded, ApprovalStatus, Status " &
                      "FROM tbl_Documents WHERE Status = 'Active' ORDER BY DateUploaded DESC"
                cmd = New SqlCommand(sql, con)
            Else
                sql = "SELECT DocumentID, DocumentCode, Title, DateUploaded, ApprovalStatus, Status " &
                      "FROM tbl_Documents " &
                      "WHERE Status = 'Active' " &
                      "AND (Title LIKE @search OR DocumentType LIKE @search) " &
                      "ORDER BY DateUploaded DESC"
                cmd = New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@search", "%" & search & "%")
            End If
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dt)
        End Using
        Return dt
    End Function

    Public Function GetByIdFull(documentID As Integer) As DataTable
        Dim dt As New DataTable()
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Dim cmd As New SqlCommand(
                "SELECT DocumentCode, Title, Description, DocumentType, " &
                "       UploadedBy, DateUploaded, ApprovalStatus, Status, " &
                "       BannerImage, PDFFile, PDFFileName " &
                "FROM tbl_Documents WHERE DocumentID = @id", con)
            cmd.Parameters.AddWithValue("@id", documentID)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dt)
        End Using
        Return dt
    End Function

    Public Function GetById(documentID As Integer) As DataTable
        Dim dt As New DataTable()
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Dim cmd As New SqlCommand(
                "SELECT DocumentCode, Title, Description, DocumentType, " &
                "       PDFFileName, UploadedBy, DateUploaded " &
                "FROM tbl_Documents WHERE DocumentID = @id", con)
            cmd.Parameters.AddWithValue("@id", documentID)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dt)
        End Using
        Return dt
    End Function

    Public Function CountByUser(username As String) As Integer
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Dim cmd As New SqlCommand(
                "SELECT COUNT(*) FROM tbl_Documents WHERE UploadedBy = @username", con)
            cmd.Parameters.AddWithValue("@username", username)
            Return CInt(cmd.ExecuteScalar())
        End Using
    End Function

    Public Function CountRecentByUser(username As String) As Integer
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Dim cmd As New SqlCommand(
                "SELECT COUNT(*) FROM tbl_Documents " &
                "WHERE UploadedBy = @username " &
                "AND DateUploaded >= DATEADD(day, -30, GETDATE())", con)
            cmd.Parameters.AddWithValue("@username", username)
            Return CInt(cmd.ExecuteScalar())
        End Using
    End Function

    Public Function CountPendingByUser(username As String) As Integer
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Dim cmd As New SqlCommand(
                "SELECT COUNT(*) FROM tbl_Documents " &
                "WHERE UploadedBy = @username " &
                "AND ApprovalStatus = 'For Review'", con)
            cmd.Parameters.AddWithValue("@username", username)
            Return CInt(cmd.ExecuteScalar())
        End Using
    End Function

    Public Function GenerateCode() As String
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Dim cmd As New SqlCommand("SELECT ISNULL(MAX(DocumentID), 0) FROM tbl_Documents", con)
            Dim maxId As Integer = CInt(cmd.ExecuteScalar())
            Return $"DOC-{(maxId + 1):D4}"
        End Using
    End Function

    Public Sub Insert(code As String, title As String, description As String,
                      docType As String, bannerBytes As Byte(), pdfFileName As String,
                      pdfBytes As Byte(), uploadedBy As String, dateUploaded As DateTime)
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Dim sql As String =
                "INSERT INTO tbl_Documents " &
                "(DocumentCode, Title, Description, DocumentType, BannerImage, PDFFileName, PDFFile, " &
                " UploadedBy, DateUploaded, ApprovalStatus, Status) " &
                "VALUES (@code, @title, @desc, @type, @image, @pdfName, @pdf, " &
                "        @uploadedBy, @dateUploaded, 'For Review', 'Active')"
            Using cmd As New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@code",         code)
                cmd.Parameters.AddWithValue("@title",        title)
                cmd.Parameters.AddWithValue("@desc",         If(String.IsNullOrEmpty(description), DBNull.Value, CObj(description)))
                cmd.Parameters.AddWithValue("@type",         docType)
                cmd.Parameters.AddWithValue("@image",        If(bannerBytes Is Nothing, DBNull.Value, CObj(bannerBytes)))
                cmd.Parameters.AddWithValue("@pdfName",      If(String.IsNullOrEmpty(pdfFileName), DBNull.Value, CObj(pdfFileName)))
                cmd.Parameters.AddWithValue("@pdf",          If(pdfBytes Is Nothing, DBNull.Value, CObj(pdfBytes)))
                cmd.Parameters.AddWithValue("@uploadedBy",   uploadedBy)
                cmd.Parameters.AddWithValue("@dateUploaded", dateUploaded)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub Update(documentID As Integer, title As String, description As String,
                      docType As String,
                      Optional imagePath As String = "",
                      Optional pdfPath   As String = "")
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Dim sql As String
            Dim cmd As SqlCommand

            If imagePath <> "" AndAlso pdfPath <> "" Then
                sql = "UPDATE tbl_Documents SET Title=@title, Description=@desc, DocumentType=@type, " &
                      "BannerImage=@image, PDFFileName=@pdfName, PDFFile=@pdf WHERE DocumentID=@id"
                cmd = New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@image",   System.IO.File.ReadAllBytes(imagePath))
                cmd.Parameters.AddWithValue("@pdfName", System.IO.Path.GetFileName(pdfPath))
                cmd.Parameters.AddWithValue("@pdf",     System.IO.File.ReadAllBytes(pdfPath))
            ElseIf imagePath <> "" Then
                sql = "UPDATE tbl_Documents SET Title=@title, Description=@desc, DocumentType=@type, " &
                      "BannerImage=@image WHERE DocumentID=@id"
                cmd = New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@image", System.IO.File.ReadAllBytes(imagePath))
            ElseIf pdfPath <> "" Then
                sql = "UPDATE tbl_Documents SET Title=@title, Description=@desc, DocumentType=@type, " &
                      "PDFFileName=@pdfName, PDFFile=@pdf WHERE DocumentID=@id"
                cmd = New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@pdfName", System.IO.Path.GetFileName(pdfPath))
                cmd.Parameters.AddWithValue("@pdf",     System.IO.File.ReadAllBytes(pdfPath))
            Else
                sql = "UPDATE tbl_Documents SET Title=@title, Description=@desc, " &
                      "DocumentType=@type WHERE DocumentID=@id"
                cmd = New SqlCommand(sql, con)
            End If

            cmd.Parameters.AddWithValue("@title", title)
            cmd.Parameters.AddWithValue("@desc",  If(String.IsNullOrEmpty(description), CObj(DBNull.Value), description))
            cmd.Parameters.AddWithValue("@type",  docType)
            cmd.Parameters.AddWithValue("@id",    documentID)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End Using
    End Sub

    Public Sub Approve(documentID As Integer)
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Dim cmd As New SqlCommand(
                "UPDATE tbl_Documents SET ApprovalStatus = 'Approved' WHERE DocumentID = @id", con)
            cmd.Parameters.AddWithValue("@id", documentID)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub Delete(documentID As Integer)
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Dim cmd As New SqlCommand(
                "DELETE FROM tbl_Documents WHERE DocumentID = @id", con)
            cmd.Parameters.AddWithValue("@id", documentID)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub DeleteByUser(documentID As Integer, username As String)
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Dim cmd As New SqlCommand(
                "DELETE FROM tbl_Documents WHERE DocumentID = @id AND UploadedBy = @username", con)
            cmd.Parameters.AddWithValue("@id",       documentID)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

End Module
