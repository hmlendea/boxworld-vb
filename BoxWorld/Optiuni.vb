Public Class Optiuni

    Private Sub Iesire_Click(sender As System.Object, e As System.EventArgs) Handles Iesire.Click
        End
    End Sub

    Private Sub Inapoi_Click(sender As System.Object, e As System.EventArgs) Handles Inapoi.Click
        Meniu.Show()
        Meniu.Location = Me.Location
        Me.Close()
    End Sub

    Private Sub SelectareLimba_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles SelectareLimba.SelectedIndexChanged
        My.Settings.Limba = SelectareLimba.Text
        My.Settings.Save()
        DetectareLimba()
        InitializareLimba()
    End Sub

    Private Sub SelectareTexturi_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles SelectareTexturi.SelectedIndexChanged
        My.Settings.Texturi = SelectareTexturi.Text
        My.Settings.Save()
        InitializareTexturi()
    End Sub

    Private Sub SelectareControale_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles SelectareControale.SelectedIndexChanged
        My.Settings.Controale = SelectareControale.Text
        If My.Settings.Controale = "W A S D" Then
            My.Settings.TastaSus = Keys.W
            My.Settings.TastaStanga = Keys.A
            My.Settings.TastaJos = Keys.S
            My.Settings.TastaDreapta = Keys.D
        ElseIf My.Settings.Controale = "Numpad" Then
            My.Settings.TastaSus = Keys.NumPad8
            My.Settings.TastaStanga = Keys.NumPad4
            My.Settings.TastaJos = Keys.NumPad5
            My.Settings.TastaDreapta = Keys.NumPad6
        End If
        My.Settings.Save()
    End Sub

    Private Sub Optiuni_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DetectareLimba()
        InitializareLimba()
        SelectareLimba.Text = My.Settings.Limba
        SelectareTexturi.Text = My.Settings.Texturi
        SelectareControale.Text = My.Settings.Controale
    End Sub

    Private Sub SelectareLimba_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SelectareLimba.KeyPress
        e.Handled = True
    End Sub
    Private Sub SelectareTexturi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SelectareTexturi.KeyPress
        e.Handled = True
    End Sub
    Private Sub SelectareControale_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SelectareControale.KeyPress
        e.Handled = True
    End Sub

    Dim LocatieFereastra, LocatieCursor As New Point(0, 0)

    Private Sub MyBase_MouseUp(sender As System.Object, e As System.EventArgs) Handles MyBase.MouseUp
        MutareFereastra.Stop()
    End Sub

    Private Sub MyBase_MouseDown(sender As System.Object, e As System.EventArgs) Handles MyBase.MouseDown
        MutareFereastra.Start()
        LocatieFereastra = Me.Location
        LocatieCursor = Cursor.Position
    End Sub

    Private Sub MutareFereastra_Tick(sender As System.Object, e As System.EventArgs) Handles MutareFereastra.Tick
        Me.Location = LocatieFereastra - LocatieCursor + Cursor.Position
    End Sub

End Class