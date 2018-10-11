Public Class Meniu2

    Private Sub Meniu2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        InitializareLimba()
    End Sub

    Private Sub Iesire_Click(sender As System.Object, e As System.EventArgs) Handles Iesire.Click
        End
    End Sub

    Private Sub Inapoi_Click(sender As System.Object, e As System.EventArgs) Handles Inapoi.Click
        Meniu.Show()
        Meniu.Location = Me.Location
        Me.Close()
    End Sub

    Private Sub ContiuareButon_Click(sender As System.Object, e As System.EventArgs) Handles ContinuareButon.Click
        Joc.Show()
        Joc.Location = Me.Location
        Me.Close()
    End Sub

    Private Sub JocNouButon_Click(sender As System.Object, e As System.EventArgs) Handles JocNouButon.Click
        My.Settings.Nivel = 0
        My.Settings.Save()
        Joc.Show()
        Joc.Location = Me.Location
        Me.Close()
    End Sub

    Private Sub NivelRecordButon_Click(sender As System.Object, e As System.EventArgs) Handles NivelRecordButon.Click
        My.Settings.Nivel = My.Settings.RecordNivel
        My.Settings.Save()
        Joc.Show()
        Joc.Location = Me.Location
        Me.Close()
    End Sub

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
End Class