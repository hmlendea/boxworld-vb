<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Meniu2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Inapoi = New System.Windows.Forms.Button()
        Me.Iesire = New System.Windows.Forms.Button()
        Me.ContinuareButon = New System.Windows.Forms.Button()
        Me.JocNouButon = New System.Windows.Forms.Button()
        Me.NivelRecordButon = New System.Windows.Forms.Button()
        Me.MutareFereastra = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Inapoi
        '
        Me.Inapoi.BackColor = System.Drawing.Color.Black
        Me.Inapoi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Inapoi.FlatAppearance.BorderSize = 3
        Me.Inapoi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Inapoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Inapoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Inapoi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inapoi.ForeColor = System.Drawing.Color.Lime
        Me.Inapoi.Location = New System.Drawing.Point(434, 9)
        Me.Inapoi.Margin = New System.Windows.Forms.Padding(0)
        Me.Inapoi.Name = "Inapoi"
        Me.Inapoi.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Inapoi.Size = New System.Drawing.Size(32, 32)
        Me.Inapoi.TabIndex = 13
        Me.Inapoi.Text = "<"
        Me.Inapoi.UseVisualStyleBackColor = False
        '
        'Iesire
        '
        Me.Iesire.BackColor = System.Drawing.Color.Black
        Me.Iesire.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Iesire.FlatAppearance.BorderSize = 3
        Me.Iesire.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Iesire.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Iesire.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Iesire.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Iesire.ForeColor = System.Drawing.Color.Lime
        Me.Iesire.Location = New System.Drawing.Point(471, 9)
        Me.Iesire.Margin = New System.Windows.Forms.Padding(0)
        Me.Iesire.Name = "Iesire"
        Me.Iesire.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Iesire.Size = New System.Drawing.Size(32, 32)
        Me.Iesire.TabIndex = 12
        Me.Iesire.Text = "X"
        Me.Iesire.UseVisualStyleBackColor = False
        '
        'ContinuareButon
        '
        Me.ContinuareButon.BackColor = System.Drawing.Color.Black
        Me.ContinuareButon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ContinuareButon.FlatAppearance.BorderSize = 3
        Me.ContinuareButon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ContinuareButon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.ContinuareButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ContinuareButon.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContinuareButon.ForeColor = System.Drawing.Color.Lime
        Me.ContinuareButon.Location = New System.Drawing.Point(64, 114)
        Me.ContinuareButon.Name = "ContinuareButon"
        Me.ContinuareButon.Size = New System.Drawing.Size(384, 64)
        Me.ContinuareButon.TabIndex = 14
        Me.ContinuareButon.Text = "<continua>"
        Me.ContinuareButon.UseVisualStyleBackColor = False
        '
        'JocNouButon
        '
        Me.JocNouButon.BackColor = System.Drawing.Color.Black
        Me.JocNouButon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.JocNouButon.FlatAppearance.BorderSize = 3
        Me.JocNouButon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.JocNouButon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.JocNouButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.JocNouButon.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JocNouButon.ForeColor = System.Drawing.Color.Lime
        Me.JocNouButon.Location = New System.Drawing.Point(64, 224)
        Me.JocNouButon.Name = "JocNouButon"
        Me.JocNouButon.Size = New System.Drawing.Size(384, 64)
        Me.JocNouButon.TabIndex = 15
        Me.JocNouButon.Text = "<joc nou>"
        Me.JocNouButon.UseVisualStyleBackColor = False
        '
        'NivelRecordButon
        '
        Me.NivelRecordButon.BackColor = System.Drawing.Color.Black
        Me.NivelRecordButon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NivelRecordButon.FlatAppearance.BorderSize = 3
        Me.NivelRecordButon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.NivelRecordButon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.NivelRecordButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NivelRecordButon.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NivelRecordButon.ForeColor = System.Drawing.Color.Lime
        Me.NivelRecordButon.Location = New System.Drawing.Point(64, 334)
        Me.NivelRecordButon.Name = "NivelRecordButon"
        Me.NivelRecordButon.Size = New System.Drawing.Size(384, 64)
        Me.NivelRecordButon.TabIndex = 16
        Me.NivelRecordButon.Text = "<nivelrecord>"
        Me.NivelRecordButon.UseVisualStyleBackColor = False
        '
        'Meniu2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(512, 512)
        Me.Controls.Add(Me.NivelRecordButon)
        Me.Controls.Add(Me.JocNouButon)
        Me.Controls.Add(Me.ContinuareButon)
        Me.Controls.Add(Me.Inapoi)
        Me.Controls.Add(Me.Iesire)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Meniu2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BoxWorld"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Inapoi As System.Windows.Forms.Button
    Friend WithEvents Iesire As System.Windows.Forms.Button
    Friend WithEvents ContinuareButon As System.Windows.Forms.Button
    Friend WithEvents JocNouButon As System.Windows.Forms.Button
    Friend WithEvents NivelRecordButon As System.Windows.Forms.Button
    Friend WithEvents MutareFereastra As System.Windows.Forms.Timer
End Class
