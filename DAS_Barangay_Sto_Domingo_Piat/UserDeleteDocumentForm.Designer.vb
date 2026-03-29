<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserDeleteDocumentForm

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlHeader    = New System.Windows.Forms.Panel()
        lblFormTitle = New System.Windows.Forms.Label()
        pnlBody      = New System.Windows.Forms.Panel()
        picWarning   = New System.Windows.Forms.PictureBox()
        lblMessage   = New System.Windows.Forms.Label()
        lblSubMsg    = New System.Windows.Forms.Label()
        pnlFooter    = New System.Windows.Forms.Panel()
        btnDelete    = New System.Windows.Forms.Button()
        btnCancel    = New System.Windows.Forms.Button()

        Me.SuspendLayout()

        Dim cream As System.Drawing.Color = System.Drawing.Color.FromArgb(242, 237, 194)

        pnlHeader.BackColor = System.Drawing.Color.FromArgb(192, 57, 43)
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top : pnlHeader.Height = 56 : pnlHeader.Name = "pnlHeader"

        lblFormTitle.AutoSize = False : lblFormTitle.Text = "Delete Document"
        lblFormTitle.Font = New System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold)
        lblFormTitle.ForeColor = System.Drawing.Color.White : lblFormTitle.BackColor = System.Drawing.Color.Transparent
        lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblFormTitle.Dock = System.Windows.Forms.DockStyle.Fill
        lblFormTitle.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0) : lblFormTitle.Name = "lblFormTitle"
        pnlHeader.Controls.Add(lblFormTitle)

        pnlBody.BackColor = cream : pnlBody.Dock = System.Windows.Forms.DockStyle.Fill : pnlBody.Name = "pnlBody"

        picWarning.Size = New System.Drawing.Size(56, 56) : picWarning.Location = New System.Drawing.Point(60, 40)
        picWarning.BackColor = System.Drawing.Color.Transparent
        picWarning.Image = System.Drawing.SystemIcons.Warning.ToBitmap()
        picWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage : picWarning.Name = "picWarning"

        lblMessage.AutoSize = False : lblMessage.Text = "Are you sure you want to delete this file?"
        lblMessage.Font = New System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold)
        lblMessage.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43) : lblMessage.BackColor = System.Drawing.Color.Transparent
        lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblMessage.Size = New System.Drawing.Size(320, 56) : lblMessage.Location = New System.Drawing.Point(130, 40)
        lblMessage.Name = "lblMessage"

        lblSubMsg.AutoSize = False : lblSubMsg.Text = "This action cannot be undone. The document will be permanently removed."
        lblSubMsg.Font = New System.Drawing.Font("Segoe UI", 9)
        lblSubMsg.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100) : lblSubMsg.BackColor = System.Drawing.Color.Transparent
        lblSubMsg.TextAlign = System.Drawing.ContentAlignment.TopLeft
        lblSubMsg.Size = New System.Drawing.Size(380, 40) : lblSubMsg.Location = New System.Drawing.Point(60, 112)
        lblSubMsg.Name = "lblSubMsg"

        pnlBody.Controls.Add(picWarning) : pnlBody.Controls.Add(lblMessage) : pnlBody.Controls.Add(lblSubMsg)

        pnlFooter.BackColor = System.Drawing.Color.FromArgb(230, 226, 180)
        pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom : pnlFooter.Height = 60 : pnlFooter.Name = "pnlFooter"
        pnlFooter.Padding = New System.Windows.Forms.Padding(20, 10, 20, 10)

        btnDelete.Text = "YES, DELETE" : btnDelete.Font = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        btnDelete.BackColor = System.Drawing.Color.FromArgb(192, 57, 43) : btnDelete.ForeColor = System.Drawing.Color.White
        btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat : btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(220, 80, 60)
        btnDelete.Size = New System.Drawing.Size(140, 38) : btnDelete.Location = New System.Drawing.Point(20, 11)
        btnDelete.Cursor = System.Windows.Forms.Cursors.Hand : btnDelete.Name = "btnDelete" : btnDelete.TabIndex = 0

        btnCancel.Text = "CANCEL" : btnCancel.Font = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        btnCancel.BackColor = System.Drawing.Color.FromArgb(160, 160, 160) : btnCancel.ForeColor = System.Drawing.Color.White
        btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat : btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(52, 103, 57)
        btnCancel.Size = New System.Drawing.Size(120, 38) : btnCancel.Location = New System.Drawing.Point(172, 11)
        btnCancel.Cursor = System.Windows.Forms.Cursors.Hand : btnCancel.Name = "btnCancel" : btnCancel.TabIndex = 1

        pnlFooter.Controls.Add(btnDelete) : pnlFooter.Controls.Add(btnCancel)

        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 230)
        Me.Controls.Add(pnlBody) : Me.Controls.Add(pnlFooter) : Me.Controls.Add(pnlHeader)
        Me.BackColor = cream : Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False : Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Name = "UserDeleteDocumentForm" : Me.Text = "Delete Document"

        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader    As System.Windows.Forms.Panel
    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents pnlBody      As System.Windows.Forms.Panel
    Friend WithEvents picWarning   As System.Windows.Forms.PictureBox
    Friend WithEvents lblMessage   As System.Windows.Forms.Label
    Friend WithEvents lblSubMsg    As System.Windows.Forms.Label
    Friend WithEvents pnlFooter    As System.Windows.Forms.Panel
    Friend WithEvents btnDelete    As System.Windows.Forms.Button
    Friend WithEvents btnCancel    As System.Windows.Forms.Button

End Class
