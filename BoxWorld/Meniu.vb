Public Class Meniu

    Dim LocatieFereastra, LocatieCursor As New Point(0, 0)

    Private Sub Meniu_MouseUp(sender As System.Object, e As System.EventArgs) Handles MyBase.MouseUp
        MutareFereastra.Stop()
    End Sub

    Private Sub Meniu_MouseDown(sender As System.Object, e As System.EventArgs) Handles MyBase.MouseDown
        MutareFereastra.Start()
        LocatieFereastra = Me.Location
        LocatieCursor = Cursor.Position
    End Sub

    Private Sub MutareFereastra_Tick(sender As System.Object, e As System.EventArgs) Handles MutareFereastra.Tick
        Me.Location = LocatieFereastra - LocatieCursor + Cursor.Position
    End Sub

    Private Sub Meniu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DetectareLimba()
        InitializareLimba()
        InitializareTexturi()
    End Sub

    Private Sub Iesire_Click(sender As System.Object, e As System.EventArgs) Handles Iesire.Click
        End
    End Sub
    Private Sub IesireButon_Click(sender As System.Object, e As System.EventArgs) Handles IesireButon.Click
        End
    End Sub

    Private Sub JoacaButon_Click(sender As System.Object, e As System.EventArgs) Handles JoacaButon.Click
        Meniu2.Show()
        Meniu2.Location = Me.Location
        Me.Close()
    End Sub

    Private Sub EditorButon_Click(sender As System.Object, e As System.EventArgs) Handles EditorButon.Click
        Editor.Show()
        Editor.Location = Me.Location
        Me.Close()
    End Sub

    Private Sub OptiuniButon_Click(sender As System.Object, e As System.EventArgs) Handles OptiuniButon.Click
        Optiuni.Show()
        Optiuni.Location = Me.Location
        Me.Close()
    End Sub
End Class
