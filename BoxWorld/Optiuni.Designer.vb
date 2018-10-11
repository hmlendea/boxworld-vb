<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Optiuni
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
        Me.Iesire = New System.Windows.Forms.Button()
        Me.Inapoi = New System.Windows.Forms.Button()
        Me.LimbaText = New System.Windows.Forms.Label()
        Me.SelectareTexturi = New System.Windows.Forms.ComboBox()
        Me.TexturiText = New System.Windows.Forms.Label()
        Me.SelectareLimba = New System.Windows.Forms.ComboBox()
        Me.ControaleText = New System.Windows.Forms.Label()
        Me.SelectareControale = New System.Windows.Forms.ComboBox()
        Me.MutareFereastra = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
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
        Me.Iesire.TabIndex = 10
        Me.Iesire.Text = "X"
        Me.Iesire.UseVisualStyleBackColor = False
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
        Me.Inapoi.TabIndex = 11
        Me.Inapoi.Text = "<"
        Me.Inapoi.UseVisualStyleBackColor = False
        '
        'LimbaText
        '
        Me.LimbaText.AutoSize = True
        Me.LimbaText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LimbaText.ForeColor = System.Drawing.Color.Lime
        Me.LimbaText.Location = New System.Drawing.Point(87, 109)
        Me.LimbaText.Name = "LimbaText"
        Me.LimbaText.Size = New System.Drawing.Size(76, 20)
        Me.LimbaText.TabIndex = 14
        Me.LimbaText.Text = "<limba>:"
        '
        'SelectareTexturi
        '
        Me.SelectareTexturi.BackColor = System.Drawing.Color.Black
        Me.SelectareTexturi.DisplayMember = "Română"
        Me.SelectareTexturi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SelectareTexturi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.SelectareTexturi.ForeColor = System.Drawing.Color.Lime
        Me.SelectareTexturi.FormattingEnabled = True
        Me.SelectareTexturi.Items.AddRange(New Object() {"Default", "Classic", "Legacy", "Minecraft"})
        Me.SelectareTexturi.Location = New System.Drawing.Point(230, 160)
        Me.SelectareTexturi.Name = "SelectareTexturi"
        Me.SelectareTexturi.Size = New System.Drawing.Size(196, 28)
        Me.SelectareTexturi.TabIndex = 17
        '
        'TexturiText
        '
        Me.TexturiText.AutoSize = True
        Me.TexturiText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexturiText.ForeColor = System.Drawing.Color.Lime
        Me.TexturiText.Location = New System.Drawing.Point(87, 163)
        Me.TexturiText.Name = "TexturiText"
        Me.TexturiText.Size = New System.Drawing.Size(84, 20)
        Me.TexturiText.TabIndex = 18
        Me.TexturiText.Text = "<texturi>:"
        '
        'SelectareLimba
        '
        Me.SelectareLimba.BackColor = System.Drawing.Color.Black
        Me.SelectareLimba.DisplayMember = "Română"
        Me.SelectareLimba.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SelectareLimba.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.SelectareLimba.ForeColor = System.Drawing.Color.Lime
        Me.SelectareLimba.FormattingEnabled = True
        Me.SelectareLimba.Items.AddRange(New Object() {"Română", "English"})
        Me.SelectareLimba.Location = New System.Drawing.Point(230, 106)
        Me.SelectareLimba.Name = "SelectareLimba"
        Me.SelectareLimba.Size = New System.Drawing.Size(196, 28)
        Me.SelectareLimba.TabIndex = 19
        '
        'ControaleText
        '
        Me.ControaleText.AutoSize = True
        Me.ControaleText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControaleText.ForeColor = System.Drawing.Color.Lime
        Me.ControaleText.Location = New System.Drawing.Point(87, 217)
        Me.ControaleText.Name = "ControaleText"
        Me.ControaleText.Size = New System.Drawing.Size(109, 20)
        Me.ControaleText.TabIndex = 20
        Me.ControaleText.Text = "<controale>:"
        '
        'SelectareControale
        '
        Me.SelectareControale.BackColor = System.Drawing.Color.Black
        Me.SelectareControale.DisplayMember = "Română"
        Me.SelectareControale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SelectareControale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.SelectareControale.ForeColor = System.Drawing.Color.Lime
        Me.SelectareControale.FormattingEnabled = True
        Me.SelectareControale.Items.AddRange(New Object() {"W A S D", "Numpad"})
        Me.SelectareControale.Location = New System.Drawing.Point(230, 214)
        Me.SelectareControale.Name = "SelectareControale"
        Me.SelectareControale.Size = New System.Drawing.Size(196, 28)
        Me.SelectareControale.TabIndex = 21
        '
        'Optiuni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(512, 512)
        Me.Controls.Add(Me.SelectareControale)
        Me.Controls.Add(Me.ControaleText)
        Me.Controls.Add(Me.SelectareLimba)
        Me.Controls.Add(Me.TexturiText)
        Me.Controls.Add(Me.LimbaText)
        Me.Controls.Add(Me.SelectareTexturi)
        Me.Controls.Add(Me.Inapoi)
        Me.Controls.Add(Me.Iesire)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Optiuni"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BoxWorld "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Iesire As System.Windows.Forms.Button
    Friend WithEvents Inapoi As System.Windows.Forms.Button
    Friend WithEvents LimbaText As System.Windows.Forms.Label
    Friend WithEvents SelectareTexturi As System.Windows.Forms.ComboBox
    Friend WithEvents TexturiText As System.Windows.Forms.Label
    Friend WithEvents SelectareLimba As System.Windows.Forms.ComboBox
    Friend WithEvents ControaleText As System.Windows.Forms.Label
    Friend WithEvents SelectareControale As System.Windows.Forms.ComboBox
    Friend WithEvents MutareFereastra As System.Windows.Forms.Timer
End Class
