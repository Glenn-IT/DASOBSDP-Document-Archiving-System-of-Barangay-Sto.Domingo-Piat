Public Class AdminDocumentTypesPanel
    Inherits System.Windows.Forms.UserControl

    Public Event TypeSelected As EventHandler(Of DocumentTypeEventArgs)

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub AdminDocumentTypesPanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        BuildCards()
    End Sub

    Private Sub BuildCards()
        pnlCardGrid.Controls.Clear()

        Dim counts As Dictionary(Of String, Integer)
        Try
            counts = DocumentRepository.GetTypeCounts()
        Catch ex As Exception
            MessageBox.Show("Error loading document type counts: " & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            counts = New Dictionary(Of String, Integer)
        End Try

        For Each docType As String In Constants.DocumentTypes
            Dim count As Integer = If(counts.ContainsKey(docType), counts(docType), 0)
            pnlCardGrid.Controls.Add(CreateCard(docType, count))
        Next
    End Sub

    Private Function CreateCard(docType As String, count As Integer) As Panel
        Dim dark As Color = Color.FromArgb(52, 103, 57)
        Dim mid As Color = Color.FromArgb(121, 174, 111)
        Dim cream As Color = Color.FromArgb(242, 237, 194)

        Dim card As New Panel() With {
            .Size = New Size(260, 130),
            .Margin = New Padding(10),
            .BackColor = dark,
            .Cursor = Cursors.Hand,
            .Tag = docType
        }
        Dim lbl As New Label() With {
            .Dock = DockStyle.Fill,
            .TextAlign = ContentAlignment.MiddleCenter,
            .ForeColor = cream,
            .BackColor = Color.Transparent,
            .Font = New Font("Segoe UI", 12, FontStyle.Bold),
            .Padding = New Padding(12),
            .Text = docType & vbCrLf & $"({count} document{If(count = 1, "", "s")})",
            .Tag = docType
        }
        card.Controls.Add(lbl)

        AddHandler card.Click, AddressOf Card_Click
        AddHandler lbl.Click, AddressOf Card_Click
        AddHandler card.MouseEnter, Sub() card.BackColor = mid
        AddHandler card.MouseLeave, Sub() card.BackColor = dark
        AddHandler lbl.MouseEnter, Sub() card.BackColor = mid
        AddHandler lbl.MouseLeave, Sub() card.BackColor = dark

        Return card
    End Function

    Private Sub Card_Click(sender As Object, e As EventArgs)
        Dim selectedType As String = CType(sender, Control).Tag.ToString()
        RaiseEvent TypeSelected(Me, New DocumentTypeEventArgs(selectedType))
    End Sub

End Class
