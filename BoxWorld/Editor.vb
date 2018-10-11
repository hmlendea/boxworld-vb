Public Class Editor

    Dim P(14, 14) As String
    Dim Cutii As Integer = 0
    Dim Ok As Boolean = True

    Dim xJucator As Integer
    Dim yJucator As Integer

    Private Sub Editor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        InitializareLimba()
        GolireButon_Click(GolireButon, EventArgs.Empty)
    End Sub

    Private Sub Inapoi_Click(sender As System.Object, e As System.EventArgs) Handles Inapoi.Click
        Meniu.Show()
        Meniu.Location = Me.Location
        Me.Close()
    End Sub
    Private Sub Iesire_Click(sender As System.Object, e As System.EventArgs) Handles Iesire.Click
        End
    End Sub
    Private Sub GolireButon_Click(sender As System.Object, e As System.EventArgs) Handles GolireButon.Click
        P(1, 1) = "Nimic"
        P(1, 2) = "Nimic"
        P(1, 3) = "Nimic"
        P(1, 4) = "Nimic"
        P(1, 5) = "Nimic"
        P(1, 6) = "Nimic"
        P(1, 7) = "Nimic"
        P(1, 8) = "Nimic"
        P(1, 9) = "Nimic"
        P(1, 10) = "Nimic"
        P(1, 11) = "Nimic"
        P(1, 12) = "Nimic"
        P(1, 13) = "Nimic"
        P(1, 14) = "Nimic"
        P(2, 1) = "Nimic"
        P(2, 2) = "Nimic"
        P(2, 3) = "Nimic"
        P(2, 4) = "Nimic"
        P(2, 5) = "Nimic"
        P(2, 6) = "Nimic"
        P(2, 7) = "Nimic"
        P(2, 8) = "Nimic"
        P(2, 9) = "Nimic"
        P(2, 10) = "Nimic"
        P(2, 11) = "Nimic"
        P(2, 12) = "Nimic"
        P(2, 13) = "Nimic"
        P(2, 14) = "Nimic"
        P(3, 1) = "Nimic"
        P(3, 2) = "Nimic"
        P(3, 3) = "Nimic"
        P(3, 4) = "Nimic"
        P(3, 5) = "Nimic"
        P(3, 6) = "Nimic"
        P(3, 7) = "Nimic"
        P(3, 8) = "Nimic"
        P(3, 9) = "Nimic"
        P(3, 10) = "Nimic"
        P(3, 11) = "Nimic"
        P(3, 12) = "Nimic"
        P(3, 13) = "Nimic"
        P(3, 14) = "Nimic"
        P(4, 1) = "Nimic"
        P(4, 2) = "Nimic"
        P(4, 3) = "Nimic"
        P(4, 4) = "Nimic"
        P(4, 5) = "Nimic"
        P(4, 6) = "Nimic"
        P(4, 7) = "Nimic"
        P(4, 8) = "Nimic"
        P(4, 9) = "Nimic"
        P(4, 10) = "Nimic"
        P(4, 11) = "Nimic"
        P(4, 12) = "Nimic"
        P(4, 13) = "Nimic"
        P(4, 14) = "Nimic"
        P(5, 1) = "Nimic"
        P(5, 2) = "Nimic"
        P(5, 3) = "Nimic"
        P(5, 4) = "Nimic"
        P(5, 5) = "Nimic"
        P(5, 6) = "Nimic"
        P(5, 7) = "Nimic"
        P(5, 8) = "Nimic"
        P(5, 9) = "Nimic"
        P(5, 10) = "Nimic"
        P(5, 11) = "Nimic"
        P(5, 12) = "Nimic"
        P(5, 13) = "Nimic"
        P(5, 14) = "Nimic"
        P(6, 1) = "Nimic"
        P(6, 2) = "Nimic"
        P(6, 3) = "Nimic"
        P(6, 4) = "Nimic"
        P(6, 5) = "Nimic"
        P(6, 6) = "Nimic"
        P(6, 7) = "Nimic"
        P(6, 8) = "Nimic"
        P(6, 9) = "Nimic"
        P(6, 10) = "Nimic"
        P(6, 11) = "Nimic"
        P(6, 12) = "Nimic"
        P(6, 13) = "Nimic"
        P(6, 14) = "Nimic"
        P(7, 1) = "Nimic"
        P(7, 2) = "Nimic"
        P(7, 3) = "Nimic"
        P(7, 4) = "Nimic"
        P(7, 5) = "Nimic"
        P(7, 6) = "Nimic"
        P(7, 7) = "Nimic"
        P(7, 8) = "Nimic"
        P(7, 9) = "Nimic"
        P(7, 10) = "Nimic"
        P(7, 11) = "Nimic"
        P(7, 12) = "Nimic"
        P(7, 13) = "Nimic"
        P(7, 14) = "Nimic"
        P(8, 1) = "Nimic"
        P(8, 2) = "Nimic"
        P(8, 3) = "Nimic"
        P(8, 4) = "Nimic"
        P(8, 5) = "Nimic"
        P(8, 6) = "Nimic"
        P(8, 7) = "Nimic"
        P(8, 8) = "Nimic"
        P(8, 9) = "Nimic"
        P(8, 10) = "Nimic"
        P(8, 11) = "Nimic"
        P(8, 12) = "Nimic"
        P(8, 13) = "Nimic"
        P(8, 14) = "Nimic"
        P(9, 1) = "Nimic"
        P(9, 2) = "Nimic"
        P(9, 3) = "Nimic"
        P(9, 4) = "Nimic"
        P(9, 5) = "Nimic"
        P(9, 6) = "Nimic"
        P(9, 7) = "Nimic"
        P(9, 8) = "Nimic"
        P(9, 9) = "Nimic"
        P(9, 10) = "Nimic"
        P(9, 11) = "Nimic"
        P(9, 12) = "Nimic"
        P(9, 13) = "Nimic"
        P(9, 14) = "Nimic"
        P(10, 1) = "Nimic"
        P(10, 2) = "Nimic"
        P(10, 3) = "Nimic"
        P(10, 4) = "Nimic"
        P(10, 5) = "Nimic"
        P(10, 6) = "Nimic"
        P(10, 7) = "Nimic"
        P(10, 8) = "Nimic"
        P(10, 9) = "Nimic"
        P(10, 10) = "Nimic"
        P(10, 11) = "Nimic"
        P(10, 12) = "Nimic"
        P(10, 13) = "Nimic"
        P(10, 14) = "Nimic"
        P(11, 1) = "Nimic"
        P(11, 2) = "Nimic"
        P(11, 3) = "Nimic"
        P(11, 4) = "Nimic"
        P(11, 5) = "Nimic"
        P(11, 6) = "Nimic"
        P(11, 7) = "Nimic"
        P(11, 8) = "Nimic"
        P(11, 9) = "Nimic"
        P(11, 10) = "Nimic"
        P(11, 11) = "Nimic"
        P(11, 12) = "Nimic"
        P(11, 13) = "Nimic"
        P(11, 14) = "Nimic"
        P(12, 1) = "Nimic"
        P(12, 2) = "Nimic"
        P(12, 3) = "Nimic"
        P(12, 4) = "Nimic"
        P(12, 5) = "Nimic"
        P(12, 6) = "Nimic"
        P(12, 7) = "Nimic"
        P(12, 8) = "Nimic"
        P(12, 9) = "Nimic"
        P(12, 10) = "Nimic"
        P(12, 11) = "Nimic"
        P(12, 12) = "Nimic"
        P(12, 13) = "Nimic"
        P(12, 14) = "Nimic"
        P(13, 1) = "Nimic"
        P(13, 2) = "Nimic"
        P(13, 3) = "Nimic"
        P(13, 4) = "Nimic"
        P(13, 5) = "Nimic"
        P(13, 6) = "Nimic"
        P(13, 7) = "Nimic"
        P(13, 8) = "Nimic"
        P(13, 9) = "Nimic"
        P(13, 10) = "Nimic"
        P(13, 11) = "Nimic"
        P(13, 12) = "Nimic"
        P(13, 13) = "Nimic"
        P(13, 14) = "Nimic"
        P(14, 1) = "Nimic"
        P(14, 2) = "Nimic"
        P(14, 3) = "Nimic"
        P(14, 4) = "Nimic"
        P(14, 5) = "Nimic"
        P(14, 6) = "Nimic"
        P(14, 7) = "Nimic"
        P(14, 8) = "Nimic"
        P(14, 9) = "Nimic"
        P(14, 10) = "Nimic"
        P(14, 11) = "Nimic"
        P(14, 12) = "Nimic"
        P(14, 13) = "Nimic"
        P(14, 14) = "Nimic"
        pct1cu1.Image = SkinNimic
        pct1cu2.Image = SkinNimic
        pct1cu3.Image = SkinNimic
        pct1cu4.Image = SkinNimic
        pct1cu5.Image = SkinNimic
        pct1cu6.Image = SkinNimic
        pct1cu7.Image = SkinNimic
        pct1cu8.Image = SkinNimic
        pct1cu9.Image = SkinNimic
        pct1cu10.Image = SkinNimic
        pct1cu11.Image = SkinNimic
        pct1cu12.Image = SkinNimic
        pct1cu13.Image = SkinNimic
        pct1cu14.Image = SkinNimic
        pct2cu1.Image = SkinNimic
        pct2cu2.Image = SkinNimic
        pct2cu3.Image = SkinNimic
        pct2cu4.Image = SkinNimic
        pct2cu5.Image = SkinNimic
        pct2cu6.Image = SkinNimic
        pct2cu7.Image = SkinNimic
        pct2cu8.Image = SkinNimic
        pct2cu9.Image = SkinNimic
        pct2cu10.Image = SkinNimic
        pct2cu11.Image = SkinNimic
        pct2cu12.Image = SkinNimic
        pct2cu13.Image = SkinNimic
        pct2cu14.Image = SkinNimic
        pct3cu1.Image = SkinNimic
        pct3cu2.Image = SkinNimic
        pct3cu3.Image = SkinNimic
        pct3cu4.Image = SkinNimic
        pct3cu5.Image = SkinNimic
        pct3cu6.Image = SkinNimic
        pct3cu7.Image = SkinNimic
        pct3cu8.Image = SkinNimic
        pct3cu9.Image = SkinNimic
        pct3cu10.Image = SkinNimic
        pct3cu11.Image = SkinNimic
        pct3cu12.Image = SkinNimic
        pct3cu13.Image = SkinNimic
        pct3cu14.Image = SkinNimic
        pct4cu1.Image = SkinNimic
        pct4cu2.Image = SkinNimic
        pct4cu3.Image = SkinNimic
        pct4cu4.Image = SkinNimic
        pct4cu5.Image = SkinNimic
        pct4cu6.Image = SkinNimic
        pct4cu7.Image = SkinNimic
        pct4cu8.Image = SkinNimic
        pct4cu9.Image = SkinNimic
        pct4cu10.Image = SkinNimic
        pct4cu11.Image = SkinNimic
        pct4cu12.Image = SkinNimic
        pct4cu13.Image = SkinNimic
        pct4cu14.Image = SkinNimic
        pct5cu1.Image = SkinNimic
        pct5cu2.Image = SkinNimic
        pct5cu3.Image = SkinNimic
        pct5cu4.Image = SkinNimic
        pct5cu5.Image = SkinNimic
        pct5cu6.Image = SkinNimic
        pct5cu7.Image = SkinNimic
        pct5cu8.Image = SkinNimic
        pct5cu9.Image = SkinNimic
        pct5cu10.Image = SkinNimic
        pct5cu11.Image = SkinNimic
        pct5cu12.Image = SkinNimic
        pct5cu13.Image = SkinNimic
        pct5cu14.Image = SkinNimic
        pct6cu1.Image = SkinNimic
        pct6cu2.Image = SkinNimic
        pct6cu3.Image = SkinNimic
        pct6cu4.Image = SkinNimic
        pct6cu5.Image = SkinNimic
        pct6cu6.Image = SkinNimic
        pct6cu7.Image = SkinNimic
        pct6cu8.Image = SkinNimic
        pct6cu9.Image = SkinNimic
        pct6cu10.Image = SkinNimic
        pct6cu11.Image = SkinNimic
        pct6cu12.Image = SkinNimic
        pct6cu13.Image = SkinNimic
        pct6cu14.Image = SkinNimic
        pct7cu1.Image = SkinNimic
        pct7cu2.Image = SkinNimic
        pct7cu3.Image = SkinNimic
        pct7cu4.Image = SkinNimic
        pct7cu5.Image = SkinNimic
        pct7cu6.Image = SkinNimic
        pct7cu7.Image = SkinNimic
        pct7cu8.Image = SkinNimic
        pct7cu9.Image = SkinNimic
        pct7cu10.Image = SkinNimic
        pct7cu11.Image = SkinNimic
        pct7cu12.Image = SkinNimic
        pct7cu13.Image = SkinNimic
        pct7cu14.Image = SkinNimic
        pct8cu1.Image = SkinNimic
        pct8cu2.Image = SkinNimic
        pct8cu3.Image = SkinNimic
        pct8cu4.Image = SkinNimic
        pct8cu5.Image = SkinNimic
        pct8cu6.Image = SkinNimic
        pct8cu7.Image = SkinNimic
        pct8cu8.Image = SkinNimic
        pct8cu9.Image = SkinNimic
        pct8cu10.Image = SkinNimic
        pct8cu11.Image = SkinNimic
        pct8cu12.Image = SkinNimic
        pct8cu13.Image = SkinNimic
        pct8cu14.Image = SkinNimic
        pct9cu1.Image = SkinNimic
        pct9cu2.Image = SkinNimic
        pct9cu3.Image = SkinNimic
        pct9cu4.Image = SkinNimic
        pct9cu5.Image = SkinNimic
        pct9cu6.Image = SkinNimic
        pct9cu7.Image = SkinNimic
        pct9cu8.Image = SkinNimic
        pct9cu9.Image = SkinNimic
        pct9cu10.Image = SkinNimic
        pct9cu11.Image = SkinNimic
        pct9cu12.Image = SkinNimic
        pct9cu13.Image = SkinNimic
        pct9cu14.Image = SkinNimic
        pct10cu1.Image = SkinNimic
        pct10cu2.Image = SkinNimic
        pct10cu3.Image = SkinNimic
        pct10cu4.Image = SkinNimic
        pct10cu5.Image = SkinNimic
        pct10cu6.Image = SkinNimic
        pct10cu7.Image = SkinNimic
        pct10cu8.Image = SkinNimic
        pct10cu9.Image = SkinNimic
        pct10cu10.Image = SkinNimic
        pct10cu11.Image = SkinNimic
        pct10cu12.Image = SkinNimic
        pct10cu13.Image = SkinNimic
        pct10cu14.Image = SkinNimic
        pct11cu1.Image = SkinNimic
        pct11cu2.Image = SkinNimic
        pct11cu3.Image = SkinNimic
        pct11cu4.Image = SkinNimic
        pct11cu5.Image = SkinNimic
        pct11cu6.Image = SkinNimic
        pct11cu7.Image = SkinNimic
        pct11cu8.Image = SkinNimic
        pct11cu9.Image = SkinNimic
        pct11cu10.Image = SkinNimic
        pct11cu11.Image = SkinNimic
        pct11cu12.Image = SkinNimic
        pct11cu13.Image = SkinNimic
        pct11cu14.Image = SkinNimic
        pct12cu1.Image = SkinNimic
        pct12cu2.Image = SkinNimic
        pct12cu3.Image = SkinNimic
        pct12cu4.Image = SkinNimic
        pct12cu5.Image = SkinNimic
        pct12cu6.Image = SkinNimic
        pct12cu7.Image = SkinNimic
        pct12cu8.Image = SkinNimic
        pct12cu9.Image = SkinNimic
        pct12cu10.Image = SkinNimic
        pct12cu11.Image = SkinNimic
        pct12cu12.Image = SkinNimic
        pct12cu13.Image = SkinNimic
        pct12cu14.Image = SkinNimic
        pct13cu1.Image = SkinNimic
        pct13cu2.Image = SkinNimic
        pct13cu3.Image = SkinNimic
        pct13cu4.Image = SkinNimic
        pct13cu5.Image = SkinNimic
        pct13cu6.Image = SkinNimic
        pct13cu7.Image = SkinNimic
        pct13cu8.Image = SkinNimic
        pct13cu9.Image = SkinNimic
        pct13cu10.Image = SkinNimic
        pct13cu11.Image = SkinNimic
        pct13cu12.Image = SkinNimic
        pct13cu13.Image = SkinNimic
        pct13cu14.Image = SkinNimic
        pct14cu1.Image = SkinNimic
        pct14cu2.Image = SkinNimic
        pct14cu3.Image = SkinNimic
        pct14cu4.Image = SkinNimic
        pct14cu5.Image = SkinNimic
        pct14cu6.Image = SkinNimic
        pct14cu7.Image = SkinNimic
        pct14cu8.Image = SkinNimic
        pct14cu9.Image = SkinNimic
        pct14cu10.Image = SkinNimic
        pct14cu11.Image = SkinNimic
        pct14cu12.Image = SkinNimic
        pct14cu13.Image = SkinNimic
        pct14cu14.Image = SkinNimic
        Cutii = 0
        Ok = True
        CodNivel.Text = ""
    End Sub

    Private Sub GenerareButon_Click(sender As System.Object, e As System.EventArgs) Handles GenerareButon.Click
        CodNivel.Text = ""
        For x As Integer = 1 To 14
            For y As Integer = 1 To 14
                If P(x, y) <> "Nimic" Then
                    CodNivel.Text += "P(" & x & ", " & y & ") = " & Chr(34) & P(x, y) & Chr(34) & vbNewLine
                    If P(x, y) = "Jucator" Then
                        xJucator = x
                        yJucator = y
                    End If
                End If
            Next
        Next
        CodNivel.Text += vbNewLine & "xJucator = " & xJucator & vbNewLine & "yJucator = " & yJucator & vbNewLine & vbNewLine & "Cutii = " & Cutii
    End Sub

    Private Sub CopiazaButon_Click(sender As System.Object, e As System.EventArgs) Handles CopiazaButon.Click
        Clipboard.SetText(CodNivel.Text)
    End Sub

    Private Sub pct1cu1_Click(sender As System.Object, e As System.EventArgs) Handles pct1cu1.MouseDown
        If P(1, 1) = "Nimic" Then
            P(1, 1) = "Perete"
            pct1cu1.Image = SkinPerete
        ElseIf P(1, 1) = "Perete" Then
            P(1, 1) = "Teren"
            pct1cu1.Image = SkinTeren
        ElseIf P(1, 1) = "Teren" Then
            P(1, 1) = "Cutie"
            pct1cu1.Image = SkinCutie
            Cutii += 1
        ElseIf P(1, 1) = "Cutie" Then
            P(1, 1) = "Tinta"
            pct1cu1.Image = SkinTinta
            Cutii -= 1
        ElseIf P(1, 1) = "Tinta" Then
            P(1, 1) = "Rezolvat"
            pct1cu1.Image = SkinRezolvat
        ElseIf P(1, 1) = "Rezolvat" Then
            If Ok Then
                P(1, 1) = "Jucator"
                pct1cu1.Image = SkinJucator
                Ok = False
            Else
                P(1, 1) = "Nimic"
                pct1cu1.Image = SkinNimic
            End If
        ElseIf P(1, 1) = "Jucator" Then
            P(1, 1) = "JucatorPeTinta"
            pct1cu1.Image = SkinJucatorPeTinta
        ElseIf P(1, 1) = "JucatorPeTinta" Then
            P(1, 1) = "Nimic"
            pct1cu1.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct1cu2_Click(sender As System.Object, e As System.EventArgs) Handles pct1cu2.MouseDown
        If P(1, 2) = "Nimic" Then
            P(1, 2) = "Perete"
            pct1cu2.Image = SkinPerete
        ElseIf P(1, 2) = "Perete" Then
            P(1, 2) = "Teren"
            pct1cu2.Image = SkinTeren
        ElseIf P(1, 2) = "Teren" Then
            P(1, 2) = "Cutie"
            pct1cu2.Image = SkinCutie
            Cutii += 1
        ElseIf P(1, 2) = "Cutie" Then
            P(1, 2) = "Tinta"
            pct1cu2.Image = SkinTinta
            Cutii -= 1
        ElseIf P(1, 2) = "Tinta" Then
            P(1, 2) = "Rezolvat"
            pct1cu2.Image = SkinRezolvat
        ElseIf P(1, 2) = "Rezolvat" Then
            If Ok Then
                P(1, 2) = "Jucator"
                pct1cu2.Image = SkinJucator
                Ok = False
            Else
                P(1, 2) = "Nimic"
                pct1cu2.Image = SkinNimic
            End If
        ElseIf P(1, 2) = "Jucator" Then
            P(1, 2) = "JucatorPeTinta"
            pct1cu2.Image = SkinJucatorPeTinta
        ElseIf P(1, 2) = "JucatorPeTinta" Then
            P(1, 2) = "Nimic"
            pct1cu2.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct1cu3_Click(sender As System.Object, e As System.EventArgs) Handles pct1cu3.MouseDown
        If P(1, 3) = "Nimic" Then
            P(1, 3) = "Perete"
            pct1cu3.Image = SkinPerete
        ElseIf P(1, 3) = "Perete" Then
            P(1, 3) = "Teren"
            pct1cu3.Image = SkinTeren
        ElseIf P(1, 3) = "Teren" Then
            P(1, 3) = "Cutie"
            pct1cu3.Image = SkinCutie
            Cutii += 1
        ElseIf P(1, 3) = "Cutie" Then
            P(1, 3) = "Tinta"
            pct1cu3.Image = SkinTinta
            Cutii -= 1
        ElseIf P(1, 3) = "Tinta" Then
            P(1, 3) = "Rezolvat"
            pct1cu3.Image = SkinRezolvat
        ElseIf P(1, 3) = "Rezolvat" Then
            If Ok Then
                P(1, 3) = "Jucator"
                pct1cu3.Image = SkinJucator
                Ok = False
            Else
                P(1, 3) = "Nimic"
                pct1cu3.Image = SkinNimic
            End If
        ElseIf P(1, 3) = "Jucator" Then
            P(1, 3) = "JucatorPeTinta"
            pct1cu3.Image = SkinJucatorPeTinta
        ElseIf P(1, 3) = "JucatorPeTinta" Then
            P(1, 3) = "Nimic"
            pct1cu3.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct1cu4_Click(sender As System.Object, e As System.EventArgs) Handles pct1cu4.MouseDown
        If P(1, 4) = "Nimic" Then
            P(1, 4) = "Perete"
            pct1cu4.Image = SkinPerete
        ElseIf P(1, 4) = "Perete" Then
            P(1, 4) = "Teren"
            pct1cu4.Image = SkinTeren
        ElseIf P(1, 4) = "Teren" Then
            P(1, 4) = "Cutie"
            pct1cu4.Image = SkinCutie
            Cutii += 1
        ElseIf P(1, 4) = "Cutie" Then
            P(1, 4) = "Tinta"
            pct1cu4.Image = SkinTinta
            Cutii -= 1
        ElseIf P(1, 4) = "Tinta" Then
            P(1, 4) = "Rezolvat"
            pct1cu4.Image = SkinRezolvat
        ElseIf P(1, 4) = "Rezolvat" Then
            If Ok Then
                P(1, 4) = "Jucator"
                pct1cu4.Image = SkinJucator
                Ok = False
            Else
                P(1, 4) = "Nimic"
                pct1cu4.Image = SkinNimic
            End If
        ElseIf P(1, 4) = "Jucator" Then
            P(1, 4) = "JucatorPeTinta"
            pct1cu4.Image = SkinJucatorPeTinta
        ElseIf P(1, 4) = "JucatorPeTinta" Then
            P(1, 4) = "Nimic"
            pct1cu4.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct1cu5_Click(sender As System.Object, e As System.EventArgs) Handles pct1cu5.MouseDown
        If P(1, 5) = "Nimic" Then
            P(1, 5) = "Perete"
            pct1cu5.Image = SkinPerete
        ElseIf P(1, 5) = "Perete" Then
            P(1, 5) = "Teren"
            pct1cu5.Image = SkinTeren
        ElseIf P(1, 5) = "Teren" Then
            P(1, 5) = "Cutie"
            pct1cu5.Image = SkinCutie
            Cutii += 1
        ElseIf P(1, 5) = "Cutie" Then
            P(1, 5) = "Tinta"
            pct1cu5.Image = SkinTinta
            Cutii -= 1
        ElseIf P(1, 5) = "Tinta" Then
            P(1, 5) = "Rezolvat"
            pct1cu5.Image = SkinRezolvat
        ElseIf P(1, 5) = "Rezolvat" Then
            If Ok Then
                P(1, 5) = "Jucator"
                pct1cu5.Image = SkinJucator
                Ok = False
            Else
                P(1, 5) = "Nimic"
                pct1cu5.Image = SkinNimic
            End If
        ElseIf P(1, 5) = "Jucator" Then
            P(1, 5) = "JucatorPeTinta"
            pct1cu5.Image = SkinJucatorPeTinta
        ElseIf P(1, 5) = "JucatorPeTinta" Then
            P(1, 5) = "Nimic"
            pct1cu5.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct1cu6_Click(sender As System.Object, e As System.EventArgs) Handles pct1cu6.MouseDown
        If P(1, 6) = "Nimic" Then
            P(1, 6) = "Perete"
            pct1cu6.Image = SkinPerete
        ElseIf P(1, 6) = "Perete" Then
            P(1, 6) = "Teren"
            pct1cu6.Image = SkinTeren
        ElseIf P(1, 6) = "Teren" Then
            P(1, 6) = "Cutie"
            pct1cu6.Image = SkinCutie
            Cutii += 1
        ElseIf P(1, 6) = "Cutie" Then
            P(1, 6) = "Tinta"
            pct1cu6.Image = SkinTinta
            Cutii -= 1
        ElseIf P(1, 6) = "Tinta" Then
            P(1, 6) = "Rezolvat"
            pct1cu6.Image = SkinRezolvat
        ElseIf P(1, 6) = "Rezolvat" Then
            If Ok Then
                P(1, 6) = "Jucator"
                pct1cu6.Image = SkinJucator
                Ok = False
            Else
                P(1, 6) = "Nimic"
                pct1cu6.Image = SkinNimic
            End If
        ElseIf P(1, 6) = "Jucator" Then
            P(1, 6) = "JucatorPeTinta"
            pct1cu6.Image = SkinJucatorPeTinta
        ElseIf P(1, 6) = "JucatorPeTinta" Then
            P(1, 6) = "Nimic"
            pct1cu6.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct1cu7_Click(sender As System.Object, e As System.EventArgs) Handles pct1cu7.MouseDown
        If P(1, 7) = "Nimic" Then
            P(1, 7) = "Perete"
            pct1cu7.Image = SkinPerete
        ElseIf P(1, 7) = "Perete" Then
            P(1, 7) = "Teren"
            pct1cu7.Image = SkinTeren
        ElseIf P(1, 7) = "Teren" Then
            P(1, 7) = "Cutie"
            pct1cu7.Image = SkinCutie
            Cutii += 1
        ElseIf P(1, 7) = "Cutie" Then
            P(1, 7) = "Tinta"
            pct1cu7.Image = SkinTinta
            Cutii -= 1
        ElseIf P(1, 7) = "Tinta" Then
            P(1, 7) = "Rezolvat"
            pct1cu7.Image = SkinRezolvat
        ElseIf P(1, 7) = "Rezolvat" Then
            If Ok Then
                P(1, 7) = "Jucator"
                pct1cu7.Image = SkinJucator
                Ok = False
            Else
                P(1, 7) = "Nimic"
                pct1cu7.Image = SkinNimic
            End If
        ElseIf P(1, 7) = "Jucator" Then
            P(1, 7) = "JucatorPeTinta"
            pct1cu7.Image = SkinJucatorPeTinta
        ElseIf P(1, 7) = "JucatorPeTinta" Then
            P(1, 7) = "Nimic"
            pct1cu7.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct1cu8_Click(sender As System.Object, e As System.EventArgs) Handles pct1cu8.MouseDown
        If P(1, 8) = "Nimic" Then
            P(1, 8) = "Perete"
            pct1cu8.Image = SkinPerete
        ElseIf P(1, 8) = "Perete" Then
            P(1, 8) = "Teren"
            pct1cu8.Image = SkinTeren
        ElseIf P(1, 8) = "Teren" Then
            P(1, 8) = "Cutie"
            pct1cu8.Image = SkinCutie
            Cutii += 1
        ElseIf P(1, 8) = "Cutie" Then
            P(1, 8) = "Tinta"
            pct1cu8.Image = SkinTinta
            Cutii -= 1
        ElseIf P(1, 8) = "Tinta" Then
            P(1, 8) = "Rezolvat"
            pct1cu8.Image = SkinRezolvat
        ElseIf P(1, 8) = "Rezolvat" Then
            If Ok Then
                P(1, 8) = "Jucator"
                pct1cu8.Image = SkinJucator
                Ok = False
            Else
                P(1, 8) = "Nimic"
                pct1cu8.Image = SkinNimic
            End If
        ElseIf P(1, 8) = "Jucator" Then
            P(1, 8) = "JucatorPeTinta"
            pct1cu8.Image = SkinJucatorPeTinta
        ElseIf P(1, 8) = "JucatorPeTinta" Then
            P(1, 8) = "Nimic"
            pct1cu8.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct1cu9_Click(sender As System.Object, e As System.EventArgs) Handles pct1cu9.MouseDown
        If P(1, 9) = "Nimic" Then
            P(1, 9) = "Perete"
            pct1cu9.Image = SkinPerete
        ElseIf P(1, 9) = "Perete" Then
            P(1, 9) = "Teren"
            pct1cu9.Image = SkinTeren
        ElseIf P(1, 9) = "Teren" Then
            P(1, 9) = "Cutie"
            pct1cu9.Image = SkinCutie
            Cutii += 1
        ElseIf P(1, 9) = "Cutie" Then
            P(1, 9) = "Tinta"
            pct1cu9.Image = SkinTinta
            Cutii -= 1
        ElseIf P(1, 9) = "Tinta" Then
            P(1, 9) = "Rezolvat"
            pct1cu9.Image = SkinRezolvat
        ElseIf P(1, 9) = "Rezolvat" Then
            If Ok Then
                P(1, 9) = "Jucator"
                pct1cu9.Image = SkinJucator
                Ok = False
            Else
                P(1, 9) = "Nimic"
                pct1cu9.Image = SkinNimic
            End If
        ElseIf P(1, 9) = "Jucator" Then
            P(1, 9) = "JucatorPeTinta"
            pct1cu9.Image = SkinJucatorPeTinta
        ElseIf P(1, 9) = "JucatorPeTinta" Then
            P(1, 9) = "Nimic"
            pct1cu9.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct1cu10_Click(sender As System.Object, e As System.EventArgs) Handles pct1cu10.MouseDown
        If P(1, 10) = "Nimic" Then
            P(1, 10) = "Perete"
            pct1cu10.Image = SkinPerete
        ElseIf P(1, 10) = "Perete" Then
            P(1, 10) = "Teren"
            pct1cu10.Image = SkinTeren
        ElseIf P(1, 10) = "Teren" Then
            P(1, 10) = "Cutie"
            pct1cu10.Image = SkinCutie
            Cutii += 1
        ElseIf P(1, 10) = "Cutie" Then
            P(1, 10) = "Tinta"
            pct1cu10.Image = SkinTinta
            Cutii -= 1
        ElseIf P(1, 10) = "Tinta" Then
            P(1, 10) = "Rezolvat"
            pct1cu10.Image = SkinRezolvat
        ElseIf P(1, 10) = "Rezolvat" Then
            If Ok Then
                P(1, 10) = "Jucator"
                pct1cu10.Image = SkinJucator
                Ok = False
            Else
                P(1, 10) = "Nimic"
                pct1cu10.Image = SkinNimic
            End If
        ElseIf P(1, 10) = "Jucator" Then
            P(1, 10) = "JucatorPeTinta"
            pct1cu10.Image = SkinJucatorPeTinta
        ElseIf P(1, 10) = "JucatorPeTinta" Then
            P(1, 10) = "Nimic"
            pct1cu10.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct1cu11_Click(sender As System.Object, e As System.EventArgs) Handles pct1cu11.MouseDown
        If P(1, 11) = "Nimic" Then
            P(1, 11) = "Perete"
            pct1cu11.Image = SkinPerete
        ElseIf P(1, 11) = "Perete" Then
            P(1, 11) = "Teren"
            pct1cu11.Image = SkinTeren
        ElseIf P(1, 11) = "Teren" Then
            P(1, 11) = "Cutie"
            pct1cu11.Image = SkinCutie
            Cutii += 1
        ElseIf P(1, 11) = "Cutie" Then
            P(1, 11) = "Tinta"
            pct1cu11.Image = SkinTinta
            Cutii -= 1
        ElseIf P(1, 11) = "Tinta" Then
            P(1, 11) = "Rezolvat"
            pct1cu11.Image = SkinRezolvat
        ElseIf P(1, 11) = "Rezolvat" Then
            If Ok Then
                P(1, 11) = "Jucator"
                pct1cu11.Image = SkinJucator
                Ok = False
            Else
                P(1, 11) = "Nimic"
                pct1cu11.Image = SkinNimic
            End If
        ElseIf P(1, 11) = "Jucator" Then
            P(1, 11) = "JucatorPeTinta"
            pct1cu11.Image = SkinJucatorPeTinta
        ElseIf P(1, 11) = "JucatorPeTinta" Then
            P(1, 11) = "Nimic"
            pct1cu11.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct1cu12_Click(sender As System.Object, e As System.EventArgs) Handles pct1cu12.MouseDown
        If P(1, 12) = "Nimic" Then
            P(1, 12) = "Perete"
            pct1cu12.Image = SkinPerete
        ElseIf P(1, 12) = "Perete" Then
            P(1, 12) = "Teren"
            pct1cu12.Image = SkinTeren
        ElseIf P(1, 12) = "Teren" Then
            P(1, 12) = "Cutie"
            pct1cu12.Image = SkinCutie
            Cutii += 1
        ElseIf P(1, 12) = "Cutie" Then
            P(1, 12) = "Tinta"
            pct1cu12.Image = SkinTinta
            Cutii -= 1
        ElseIf P(1, 12) = "Tinta" Then
            P(1, 12) = "Rezolvat"
            pct1cu12.Image = SkinRezolvat
        ElseIf P(1, 12) = "Rezolvat" Then
            If Ok Then
                P(1, 12) = "Jucator"
                pct1cu12.Image = SkinJucator
                Ok = False
            Else
                P(1, 12) = "Nimic"
                pct1cu12.Image = SkinNimic
            End If
        ElseIf P(1, 12) = "Jucator" Then
            P(1, 12) = "JucatorPeTinta"
            pct1cu12.Image = SkinJucatorPeTinta
        ElseIf P(1, 12) = "JucatorPeTinta" Then
            P(1, 12) = "Nimic"
            pct1cu12.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct1cu13_Click(sender As System.Object, e As System.EventArgs) Handles pct1cu13.MouseDown
        If P(1, 13) = "Nimic" Then
            P(1, 13) = "Perete"
            pct1cu13.Image = SkinPerete
        ElseIf P(1, 13) = "Perete" Then
            P(1, 13) = "Teren"
            pct1cu13.Image = SkinTeren
        ElseIf P(1, 13) = "Teren" Then
            P(1, 13) = "Cutie"
            pct1cu13.Image = SkinCutie
            Cutii += 1
        ElseIf P(1, 13) = "Cutie" Then
            P(1, 13) = "Tinta"
            pct1cu13.Image = SkinTinta
            Cutii -= 1
        ElseIf P(1, 13) = "Tinta" Then
            P(1, 13) = "Rezolvat"
            pct1cu13.Image = SkinRezolvat
        ElseIf P(1, 13) = "Rezolvat" Then
            If Ok Then
                P(1, 13) = "Jucator"
                pct1cu13.Image = SkinJucator
                Ok = False
            Else
                P(1, 13) = "Nimic"
                pct1cu13.Image = SkinNimic
            End If
        ElseIf P(1, 13) = "Jucator" Then
            P(1, 13) = "JucatorPeTinta"
            pct1cu13.Image = SkinJucatorPeTinta
        ElseIf P(1, 13) = "JucatorPeTinta" Then
            P(1, 13) = "Nimic"
            pct1cu13.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct1cu14_Click(sender As System.Object, e As System.EventArgs) Handles pct1cu14.MouseDown
        If P(1, 14) = "Nimic" Then
            P(1, 14) = "Perete"
            pct1cu14.Image = SkinPerete
        ElseIf P(1, 14) = "Perete" Then
            P(1, 14) = "Teren"
            pct1cu14.Image = SkinTeren
        ElseIf P(1, 14) = "Teren" Then
            P(1, 14) = "Cutie"
            pct1cu14.Image = SkinCutie
            Cutii += 1
        ElseIf P(1, 14) = "Cutie" Then
            P(1, 14) = "Tinta"
            pct1cu14.Image = SkinTinta
            Cutii -= 1
        ElseIf P(1, 14) = "Tinta" Then
            P(1, 14) = "Rezolvat"
            pct1cu14.Image = SkinRezolvat
        ElseIf P(1, 14) = "Rezolvat" Then
            If Ok Then
                P(1, 14) = "Jucator"
                pct1cu14.Image = SkinJucator
                Ok = False
            Else
                P(1, 14) = "Nimic"
                pct1cu14.Image = SkinNimic
            End If
        ElseIf P(1, 14) = "Jucator" Then
            P(1, 14) = "JucatorPeTinta"
            pct1cu14.Image = SkinJucatorPeTinta
        ElseIf P(1, 14) = "JucatorPeTinta" Then
            P(1, 14) = "Nimic"
            pct1cu14.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct2cu1_Click(sender As System.Object, e As System.EventArgs) Handles pct2cu1.MouseDown
        If P(2, 1) = "Nimic" Then
            P(2, 1) = "Perete"
            pct2cu1.Image = SkinPerete
        ElseIf P(2, 1) = "Perete" Then
            P(2, 1) = "Teren"
            pct2cu1.Image = SkinTeren
        ElseIf P(2, 1) = "Teren" Then
            P(2, 1) = "Cutie"
            pct2cu1.Image = SkinCutie
            Cutii += 1
        ElseIf P(2, 1) = "Cutie" Then
            P(2, 1) = "Tinta"
            pct2cu1.Image = SkinTinta
            Cutii -= 1
        ElseIf P(2, 1) = "Tinta" Then
            P(2, 1) = "Rezolvat"
            pct2cu1.Image = SkinRezolvat
        ElseIf P(2, 1) = "Rezolvat" Then
            If Ok Then
                P(2, 1) = "Jucator"
                pct2cu1.Image = SkinJucator
                Ok = False
            Else
                P(2, 1) = "Nimic"
                pct2cu1.Image = SkinNimic
            End If
        ElseIf P(2, 1) = "Jucator" Then
            P(2, 1) = "JucatorPeTinta"
            pct2cu1.Image = SkinJucatorPeTinta
        ElseIf P(2, 1) = "JucatorPeTinta" Then
            P(2, 1) = "Nimic"
            pct2cu1.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct2cu2_Click(sender As System.Object, e As System.EventArgs) Handles pct2cu2.MouseDown
        If P(2, 2) = "Nimic" Then
            P(2, 2) = "Perete"
            pct2cu2.Image = SkinPerete
        ElseIf P(2, 2) = "Perete" Then
            P(2, 2) = "Teren"
            pct2cu2.Image = SkinTeren
        ElseIf P(2, 2) = "Teren" Then
            P(2, 2) = "Cutie"
            pct2cu2.Image = SkinCutie
            Cutii += 1
        ElseIf P(2, 2) = "Cutie" Then
            P(2, 2) = "Tinta"
            pct2cu2.Image = SkinTinta
            Cutii -= 1
        ElseIf P(2, 2) = "Tinta" Then
            P(2, 2) = "Rezolvat"
            pct2cu2.Image = SkinRezolvat
        ElseIf P(2, 2) = "Rezolvat" Then
            If Ok Then
                P(2, 2) = "Jucator"
                pct2cu2.Image = SkinJucator
                Ok = False
            Else
                P(2, 2) = "Nimic"
                pct2cu2.Image = SkinNimic
            End If
        ElseIf P(2, 2) = "Jucator" Then
            P(2, 2) = "JucatorPeTinta"
            pct2cu2.Image = SkinJucatorPeTinta
        ElseIf P(2, 2) = "JucatorPeTinta" Then
            P(2, 2) = "Nimic"
            pct2cu2.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct2cu3_Click(sender As System.Object, e As System.EventArgs) Handles pct2cu3.MouseDown
        If P(2, 3) = "Nimic" Then
            P(2, 3) = "Perete"
            pct2cu3.Image = SkinPerete
        ElseIf P(2, 3) = "Perete" Then
            P(2, 3) = "Teren"
            pct2cu3.Image = SkinTeren
        ElseIf P(2, 3) = "Teren" Then
            P(2, 3) = "Cutie"
            pct2cu3.Image = SkinCutie
            Cutii += 1
        ElseIf P(2, 3) = "Cutie" Then
            P(2, 3) = "Tinta"
            pct2cu3.Image = SkinTinta
            Cutii -= 1
        ElseIf P(2, 3) = "Tinta" Then
            P(2, 3) = "Rezolvat"
            pct2cu3.Image = SkinRezolvat
        ElseIf P(2, 3) = "Rezolvat" Then
            If Ok Then
                P(2, 3) = "Jucator"
                pct2cu3.Image = SkinJucator
                Ok = False
            Else
                P(2, 3) = "Nimic"
                pct2cu3.Image = SkinNimic
            End If
        ElseIf P(2, 3) = "Jucator" Then
            P(2, 3) = "JucatorPeTinta"
            pct2cu3.Image = SkinJucatorPeTinta
        ElseIf P(2, 3) = "JucatorPeTinta" Then
            P(2, 3) = "Nimic"
            pct2cu3.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct2cu4_Click(sender As System.Object, e As System.EventArgs) Handles pct2cu4.MouseDown
        If P(2, 4) = "Nimic" Then
            P(2, 4) = "Perete"
            pct2cu4.Image = SkinPerete
        ElseIf P(2, 4) = "Perete" Then
            P(2, 4) = "Teren"
            pct2cu4.Image = SkinTeren
        ElseIf P(2, 4) = "Teren" Then
            P(2, 4) = "Cutie"
            pct2cu4.Image = SkinCutie
            Cutii += 1
        ElseIf P(2, 4) = "Cutie" Then
            P(2, 4) = "Tinta"
            pct2cu4.Image = SkinTinta
            Cutii -= 1
        ElseIf P(2, 4) = "Tinta" Then
            P(2, 4) = "Rezolvat"
            pct2cu4.Image = SkinRezolvat
        ElseIf P(2, 4) = "Rezolvat" Then
            If Ok Then
                P(2, 4) = "Jucator"
                pct2cu4.Image = SkinJucator
                Ok = False
            Else
                P(2, 4) = "Nimic"
                pct2cu4.Image = SkinNimic
            End If
        ElseIf P(2, 4) = "Jucator" Then
            P(2, 4) = "JucatorPeTinta"
            pct2cu4.Image = SkinJucatorPeTinta
        ElseIf P(2, 4) = "JucatorPeTinta" Then
            P(2, 4) = "Nimic"
            pct2cu4.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct2cu5_Click(sender As System.Object, e As System.EventArgs) Handles pct2cu5.MouseDown
        If P(2, 5) = "Nimic" Then
            P(2, 5) = "Perete"
            pct2cu5.Image = SkinPerete
        ElseIf P(2, 5) = "Perete" Then
            P(2, 5) = "Teren"
            pct2cu5.Image = SkinTeren
        ElseIf P(2, 5) = "Teren" Then
            P(2, 5) = "Cutie"
            pct2cu5.Image = SkinCutie
            Cutii += 1
        ElseIf P(2, 5) = "Cutie" Then
            P(2, 5) = "Tinta"
            pct2cu5.Image = SkinTinta
            Cutii -= 1
        ElseIf P(2, 5) = "Tinta" Then
            P(2, 5) = "Rezolvat"
            pct2cu5.Image = SkinRezolvat
        ElseIf P(2, 5) = "Rezolvat" Then
            If Ok Then
                P(2, 5) = "Jucator"
                pct2cu5.Image = SkinJucator
                Ok = False
            Else
                P(2, 5) = "Nimic"
                pct2cu5.Image = SkinNimic
            End If
        ElseIf P(2, 5) = "Jucator" Then
            P(2, 5) = "JucatorPeTinta"
            pct2cu5.Image = SkinJucatorPeTinta
        ElseIf P(2, 5) = "JucatorPeTinta" Then
            P(2, 5) = "Nimic"
            pct2cu5.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct2cu6_Click(sender As System.Object, e As System.EventArgs) Handles pct2cu6.MouseDown
        If P(2, 6) = "Nimic" Then
            P(2, 6) = "Perete"
            pct2cu6.Image = SkinPerete
        ElseIf P(2, 6) = "Perete" Then
            P(2, 6) = "Teren"
            pct2cu6.Image = SkinTeren
        ElseIf P(2, 6) = "Teren" Then
            P(2, 6) = "Cutie"
            pct2cu6.Image = SkinCutie
            Cutii += 1
        ElseIf P(2, 6) = "Cutie" Then
            P(2, 6) = "Tinta"
            pct2cu6.Image = SkinTinta
            Cutii -= 1
        ElseIf P(2, 6) = "Tinta" Then
            P(2, 6) = "Rezolvat"
            pct2cu6.Image = SkinRezolvat
        ElseIf P(2, 6) = "Rezolvat" Then
            If Ok Then
                P(2, 6) = "Jucator"
                pct2cu6.Image = SkinJucator
                Ok = False
            Else
                P(2, 6) = "Nimic"
                pct2cu6.Image = SkinNimic
            End If
        ElseIf P(2, 6) = "Jucator" Then
            P(2, 6) = "JucatorPeTinta"
            pct2cu6.Image = SkinJucatorPeTinta
        ElseIf P(2, 6) = "JucatorPeTinta" Then
            P(2, 6) = "Nimic"
            pct2cu6.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct2cu7_Click(sender As System.Object, e As System.EventArgs) Handles pct2cu7.MouseDown
        If P(2, 7) = "Nimic" Then
            P(2, 7) = "Perete"
            pct2cu7.Image = SkinPerete
        ElseIf P(2, 7) = "Perete" Then
            P(2, 7) = "Teren"
            pct2cu7.Image = SkinTeren
        ElseIf P(2, 7) = "Teren" Then
            P(2, 7) = "Cutie"
            pct2cu7.Image = SkinCutie
            Cutii += 1
        ElseIf P(2, 7) = "Cutie" Then
            P(2, 7) = "Tinta"
            pct2cu7.Image = SkinTinta
            Cutii -= 1
        ElseIf P(2, 7) = "Tinta" Then
            P(2, 7) = "Rezolvat"
            pct2cu7.Image = SkinRezolvat
        ElseIf P(2, 7) = "Rezolvat" Then
            If Ok Then
                P(2, 7) = "Jucator"
                pct2cu7.Image = SkinJucator
                Ok = False
            Else
                P(2, 7) = "Nimic"
                pct2cu7.Image = SkinNimic
            End If
        ElseIf P(2, 7) = "Jucator" Then
            P(2, 7) = "JucatorPeTinta"
            pct2cu7.Image = SkinJucatorPeTinta
        ElseIf P(2, 7) = "JucatorPeTinta" Then
            P(2, 7) = "Nimic"
            pct2cu7.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct2cu8_Click(sender As System.Object, e As System.EventArgs) Handles pct2cu8.MouseDown
        If P(2, 8) = "Nimic" Then
            P(2, 8) = "Perete"
            pct2cu8.Image = SkinPerete
        ElseIf P(2, 8) = "Perete" Then
            P(2, 8) = "Teren"
            pct2cu8.Image = SkinTeren
        ElseIf P(2, 8) = "Teren" Then
            P(2, 8) = "Cutie"
            pct2cu8.Image = SkinCutie
            Cutii += 1
        ElseIf P(2, 8) = "Cutie" Then
            P(2, 8) = "Tinta"
            pct2cu8.Image = SkinTinta
            Cutii -= 1
        ElseIf P(2, 8) = "Tinta" Then
            P(2, 8) = "Rezolvat"
            pct2cu8.Image = SkinRezolvat
        ElseIf P(2, 8) = "Rezolvat" Then
            If Ok Then
                P(2, 8) = "Jucator"
                pct2cu8.Image = SkinJucator
                Ok = False
            Else
                P(2, 8) = "Nimic"
                pct2cu8.Image = SkinNimic
            End If
        ElseIf P(2, 8) = "Jucator" Then
            P(2, 8) = "JucatorPeTinta"
            pct2cu8.Image = SkinJucatorPeTinta
        ElseIf P(2, 8) = "JucatorPeTinta" Then
            P(2, 8) = "Nimic"
            pct2cu8.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct2cu9_Click(sender As System.Object, e As System.EventArgs) Handles pct2cu9.MouseDown
        If P(2, 9) = "Nimic" Then
            P(2, 9) = "Perete"
            pct2cu9.Image = SkinPerete
        ElseIf P(2, 9) = "Perete" Then
            P(2, 9) = "Teren"
            pct2cu9.Image = SkinTeren
        ElseIf P(2, 9) = "Teren" Then
            P(2, 9) = "Cutie"
            pct2cu9.Image = SkinCutie
            Cutii += 1
        ElseIf P(2, 9) = "Cutie" Then
            P(2, 9) = "Tinta"
            pct2cu9.Image = SkinTinta
            Cutii -= 1
        ElseIf P(2, 9) = "Tinta" Then
            P(2, 9) = "Rezolvat"
            pct2cu9.Image = SkinRezolvat
        ElseIf P(2, 9) = "Rezolvat" Then
            If Ok Then
                P(2, 9) = "Jucator"
                pct2cu9.Image = SkinJucator
                Ok = False
            Else
                P(2, 9) = "Nimic"
                pct2cu9.Image = SkinNimic
            End If
        ElseIf P(2, 9) = "Jucator" Then
            P(2, 9) = "JucatorPeTinta"
            pct2cu9.Image = SkinJucatorPeTinta
        ElseIf P(2, 9) = "JucatorPeTinta" Then
            P(2, 9) = "Nimic"
            pct2cu9.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct2cu10_Click(sender As System.Object, e As System.EventArgs) Handles pct2cu10.MouseDown
        If P(2, 10) = "Nimic" Then
            P(2, 10) = "Perete"
            pct2cu10.Image = SkinPerete
        ElseIf P(2, 10) = "Perete" Then
            P(2, 10) = "Teren"
            pct2cu10.Image = SkinTeren
        ElseIf P(2, 10) = "Teren" Then
            P(2, 10) = "Cutie"
            pct2cu10.Image = SkinCutie
            Cutii += 1
        ElseIf P(2, 10) = "Cutie" Then
            P(2, 10) = "Tinta"
            pct2cu10.Image = SkinTinta
            Cutii -= 1
        ElseIf P(2, 10) = "Tinta" Then
            P(2, 10) = "Rezolvat"
            pct2cu10.Image = SkinRezolvat
        ElseIf P(2, 10) = "Rezolvat" Then
            If Ok Then
                P(2, 10) = "Jucator"
                pct2cu10.Image = SkinJucator
                Ok = False
            Else
                P(2, 10) = "Nimic"
                pct2cu10.Image = SkinNimic
            End If
        ElseIf P(2, 10) = "Jucator" Then
            P(2, 10) = "JucatorPeTinta"
            pct2cu10.Image = SkinJucatorPeTinta
        ElseIf P(2, 10) = "JucatorPeTinta" Then
            P(2, 10) = "Nimic"
            pct2cu10.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct2cu11_Click(sender As System.Object, e As System.EventArgs) Handles pct2cu11.MouseDown
        If P(2, 11) = "Nimic" Then
            P(2, 11) = "Perete"
            pct2cu11.Image = SkinPerete
        ElseIf P(2, 11) = "Perete" Then
            P(2, 11) = "Teren"
            pct2cu11.Image = SkinTeren
        ElseIf P(2, 11) = "Teren" Then
            P(2, 11) = "Cutie"
            pct2cu11.Image = SkinCutie
            Cutii += 1
        ElseIf P(2, 11) = "Cutie" Then
            P(2, 11) = "Tinta"
            pct2cu11.Image = SkinTinta
            Cutii -= 1
        ElseIf P(2, 11) = "Tinta" Then
            P(2, 11) = "Rezolvat"
            pct2cu11.Image = SkinRezolvat
        ElseIf P(2, 11) = "Rezolvat" Then
            If Ok Then
                P(2, 11) = "Jucator"
                pct2cu11.Image = SkinJucator
                Ok = False
            Else
                P(2, 11) = "Nimic"
                pct2cu11.Image = SkinNimic
            End If
        ElseIf P(2, 11) = "Jucator" Then
            P(2, 11) = "JucatorPeTinta"
            pct2cu11.Image = SkinJucatorPeTinta
        ElseIf P(2, 11) = "JucatorPeTinta" Then
            P(2, 11) = "Nimic"
            pct2cu11.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct2cu12_Click(sender As System.Object, e As System.EventArgs) Handles pct2cu12.MouseDown
        If P(2, 12) = "Nimic" Then
            P(2, 12) = "Perete"
            pct2cu12.Image = SkinPerete
        ElseIf P(2, 12) = "Perete" Then
            P(2, 12) = "Teren"
            pct2cu12.Image = SkinTeren
        ElseIf P(2, 12) = "Teren" Then
            P(2, 12) = "Cutie"
            pct2cu12.Image = SkinCutie
            Cutii += 1
        ElseIf P(2, 12) = "Cutie" Then
            P(2, 12) = "Tinta"
            pct2cu12.Image = SkinTinta
            Cutii -= 1
        ElseIf P(2, 12) = "Tinta" Then
            P(2, 12) = "Rezolvat"
            pct2cu12.Image = SkinRezolvat
        ElseIf P(2, 12) = "Rezolvat" Then
            If Ok Then
                P(2, 12) = "Jucator"
                pct2cu12.Image = SkinJucator
                Ok = False
            Else
                P(2, 12) = "Nimic"
                pct2cu12.Image = SkinNimic
            End If
        ElseIf P(2, 12) = "Jucator" Then
            P(2, 12) = "JucatorPeTinta"
            pct2cu12.Image = SkinJucatorPeTinta
        ElseIf P(2, 12) = "JucatorPeTinta" Then
            P(2, 12) = "Nimic"
            pct2cu12.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct2cu13_Click(sender As System.Object, e As System.EventArgs) Handles pct2cu13.MouseDown
        If P(2, 13) = "Nimic" Then
            P(2, 13) = "Perete"
            pct2cu13.Image = SkinPerete
        ElseIf P(2, 13) = "Perete" Then
            P(2, 13) = "Teren"
            pct2cu13.Image = SkinTeren
        ElseIf P(2, 13) = "Teren" Then
            P(2, 13) = "Cutie"
            pct2cu13.Image = SkinCutie
            Cutii += 1
        ElseIf P(2, 13) = "Cutie" Then
            P(2, 13) = "Tinta"
            pct2cu13.Image = SkinTinta
            Cutii -= 1
        ElseIf P(2, 13) = "Tinta" Then
            P(2, 13) = "Rezolvat"
            pct2cu13.Image = SkinRezolvat
        ElseIf P(2, 13) = "Rezolvat" Then
            If Ok Then
                P(2, 13) = "Jucator"
                pct2cu13.Image = SkinJucator
                Ok = False
            Else
                P(2, 13) = "Nimic"
                pct2cu13.Image = SkinNimic
            End If
        ElseIf P(2, 13) = "Jucator" Then
            P(2, 13) = "JucatorPeTinta"
            pct2cu13.Image = SkinJucatorPeTinta
        ElseIf P(2, 13) = "JucatorPeTinta" Then
            P(2, 13) = "Nimic"
            pct2cu13.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct2cu14_Click(sender As System.Object, e As System.EventArgs) Handles pct2cu14.MouseDown
        If P(2, 14) = "Nimic" Then
            P(2, 14) = "Perete"
            pct2cu14.Image = SkinPerete
        ElseIf P(2, 14) = "Perete" Then
            P(2, 14) = "Teren"
            pct2cu14.Image = SkinTeren
        ElseIf P(2, 14) = "Teren" Then
            P(2, 14) = "Cutie"
            pct2cu14.Image = SkinCutie
            Cutii += 1
        ElseIf P(2, 14) = "Cutie" Then
            P(2, 14) = "Tinta"
            pct2cu14.Image = SkinTinta
            Cutii -= 1
        ElseIf P(2, 14) = "Tinta" Then
            P(2, 14) = "Rezolvat"
            pct2cu14.Image = SkinRezolvat
        ElseIf P(2, 14) = "Rezolvat" Then
            If Ok Then
                P(2, 14) = "Jucator"
                pct2cu14.Image = SkinJucator
                Ok = False
            Else
                P(2, 14) = "Nimic"
                pct2cu14.Image = SkinNimic
            End If
        ElseIf P(2, 14) = "Jucator" Then
            P(2, 14) = "JucatorPeTinta"
            pct2cu14.Image = SkinJucatorPeTinta
        ElseIf P(2, 14) = "JucatorPeTinta" Then
            P(2, 14) = "Nimic"
            pct2cu14.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct3cu1_Click(sender As System.Object, e As System.EventArgs) Handles pct3cu1.MouseDown
        If P(3, 1) = "Nimic" Then
            P(3, 1) = "Perete"
            pct3cu1.Image = SkinPerete
        ElseIf P(3, 1) = "Perete" Then
            P(3, 1) = "Teren"
            pct3cu1.Image = SkinTeren
        ElseIf P(3, 1) = "Teren" Then
            P(3, 1) = "Cutie"
            pct3cu1.Image = SkinCutie
            Cutii += 1
        ElseIf P(3, 1) = "Cutie" Then
            P(3, 1) = "Tinta"
            pct3cu1.Image = SkinTinta
            Cutii -= 1
        ElseIf P(3, 1) = "Tinta" Then
            P(3, 1) = "Rezolvat"
            pct3cu1.Image = SkinRezolvat
        ElseIf P(3, 1) = "Rezolvat" Then
            If Ok Then
                P(3, 1) = "Jucator"
                pct3cu1.Image = SkinJucator
                Ok = False
            Else
                P(3, 1) = "Nimic"
                pct3cu1.Image = SkinNimic
            End If
        ElseIf P(3, 1) = "Jucator" Then
            P(3, 1) = "JucatorPeTinta"
            pct3cu1.Image = SkinJucatorPeTinta
        ElseIf P(3, 1) = "JucatorPeTinta" Then
            P(3, 1) = "Nimic"
            pct3cu1.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct3cu2_Click(sender As System.Object, e As System.EventArgs) Handles pct3cu2.MouseDown
        If P(3, 2) = "Nimic" Then
            P(3, 2) = "Perete"
            pct3cu2.Image = SkinPerete
        ElseIf P(3, 2) = "Perete" Then
            P(3, 2) = "Teren"
            pct3cu2.Image = SkinTeren
        ElseIf P(3, 2) = "Teren" Then
            P(3, 2) = "Cutie"
            pct3cu2.Image = SkinCutie
            Cutii += 1
        ElseIf P(3, 2) = "Cutie" Then
            P(3, 2) = "Tinta"
            pct3cu2.Image = SkinTinta
            Cutii -= 1
        ElseIf P(3, 2) = "Tinta" Then
            P(3, 2) = "Rezolvat"
            pct3cu2.Image = SkinRezolvat
        ElseIf P(3, 2) = "Rezolvat" Then
            If Ok Then
                P(3, 2) = "Jucator"
                pct3cu2.Image = SkinJucator
                Ok = False
            Else
                P(3, 2) = "Nimic"
                pct3cu2.Image = SkinNimic
            End If
        ElseIf P(3, 2) = "Jucator" Then
            P(3, 2) = "JucatorPeTinta"
            pct3cu2.Image = SkinJucatorPeTinta
        ElseIf P(3, 2) = "JucatorPeTinta" Then
            P(3, 2) = "Nimic"
            pct3cu2.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct3cu3_Click(sender As System.Object, e As System.EventArgs) Handles pct3cu3.MouseDown
        If P(3, 3) = "Nimic" Then
            P(3, 3) = "Perete"
            pct3cu3.Image = SkinPerete
        ElseIf P(3, 3) = "Perete" Then
            P(3, 3) = "Teren"
            pct3cu3.Image = SkinTeren
        ElseIf P(3, 3) = "Teren" Then
            P(3, 3) = "Cutie"
            pct3cu3.Image = SkinCutie
            Cutii += 1
        ElseIf P(3, 3) = "Cutie" Then
            P(3, 3) = "Tinta"
            pct3cu3.Image = SkinTinta
            Cutii -= 1
        ElseIf P(3, 3) = "Tinta" Then
            P(3, 3) = "Rezolvat"
            pct3cu3.Image = SkinRezolvat
        ElseIf P(3, 3) = "Rezolvat" Then
            If Ok Then
                P(3, 3) = "Jucator"
                pct3cu3.Image = SkinJucator
                Ok = False
            Else
                P(3, 3) = "Nimic"
                pct3cu3.Image = SkinNimic
            End If
        ElseIf P(3, 3) = "Jucator" Then
            P(3, 3) = "JucatorPeTinta"
            pct3cu3.Image = SkinJucatorPeTinta
        ElseIf P(3, 3) = "JucatorPeTinta" Then
            P(3, 3) = "Nimic"
            pct3cu3.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct3cu4_Click(sender As System.Object, e As System.EventArgs) Handles pct3cu4.MouseDown
        If P(3, 4) = "Nimic" Then
            P(3, 4) = "Perete"
            pct3cu4.Image = SkinPerete
        ElseIf P(3, 4) = "Perete" Then
            P(3, 4) = "Teren"
            pct3cu4.Image = SkinTeren
        ElseIf P(3, 4) = "Teren" Then
            P(3, 4) = "Cutie"
            pct3cu4.Image = SkinCutie
            Cutii += 1
        ElseIf P(3, 4) = "Cutie" Then
            P(3, 4) = "Tinta"
            pct3cu4.Image = SkinTinta
            Cutii -= 1
        ElseIf P(3, 4) = "Tinta" Then
            P(3, 4) = "Rezolvat"
            pct3cu4.Image = SkinRezolvat
        ElseIf P(3, 4) = "Rezolvat" Then
            If Ok Then
                P(3, 4) = "Jucator"
                pct3cu4.Image = SkinJucator
                Ok = False
            Else
                P(3, 4) = "Nimic"
                pct3cu4.Image = SkinNimic
            End If
        ElseIf P(3, 4) = "Jucator" Then
            P(3, 4) = "JucatorPeTinta"
            pct3cu4.Image = SkinJucatorPeTinta
        ElseIf P(3, 4) = "JucatorPeTinta" Then
            P(3, 4) = "Nimic"
            pct3cu4.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct3cu5_Click(sender As System.Object, e As System.EventArgs) Handles pct3cu5.MouseDown
        If P(3, 5) = "Nimic" Then
            P(3, 5) = "Perete"
            pct3cu5.Image = SkinPerete
        ElseIf P(3, 5) = "Perete" Then
            P(3, 5) = "Teren"
            pct3cu5.Image = SkinTeren
        ElseIf P(3, 5) = "Teren" Then
            P(3, 5) = "Cutie"
            pct3cu5.Image = SkinCutie
            Cutii += 1
        ElseIf P(3, 5) = "Cutie" Then
            P(3, 5) = "Tinta"
            pct3cu5.Image = SkinTinta
            Cutii -= 1
        ElseIf P(3, 5) = "Tinta" Then
            P(3, 5) = "Rezolvat"
            pct3cu5.Image = SkinRezolvat
        ElseIf P(3, 5) = "Rezolvat" Then
            If Ok Then
                P(3, 5) = "Jucator"
                pct3cu5.Image = SkinJucator
                Ok = False
            Else
                P(3, 5) = "Nimic"
                pct3cu5.Image = SkinNimic
            End If
        ElseIf P(3, 5) = "Jucator" Then
            P(3, 5) = "JucatorPeTinta"
            pct3cu5.Image = SkinJucatorPeTinta
        ElseIf P(3, 5) = "JucatorPeTinta" Then
            P(3, 5) = "Nimic"
            pct3cu5.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct3cu6_Click(sender As System.Object, e As System.EventArgs) Handles pct3cu6.MouseDown
        If P(3, 6) = "Nimic" Then
            P(3, 6) = "Perete"
            pct3cu6.Image = SkinPerete
        ElseIf P(3, 6) = "Perete" Then
            P(3, 6) = "Teren"
            pct3cu6.Image = SkinTeren
        ElseIf P(3, 6) = "Teren" Then
            P(3, 6) = "Cutie"
            pct3cu6.Image = SkinCutie
            Cutii += 1
        ElseIf P(3, 6) = "Cutie" Then
            P(3, 6) = "Tinta"
            pct3cu6.Image = SkinTinta
            Cutii -= 1
        ElseIf P(3, 6) = "Tinta" Then
            P(3, 6) = "Rezolvat"
            pct3cu6.Image = SkinRezolvat
        ElseIf P(3, 6) = "Rezolvat" Then
            If Ok Then
                P(3, 6) = "Jucator"
                pct3cu6.Image = SkinJucator
                Ok = False
            Else
                P(3, 6) = "Nimic"
                pct3cu6.Image = SkinNimic
            End If
        ElseIf P(3, 6) = "Jucator" Then
            P(3, 6) = "JucatorPeTinta"
            pct3cu6.Image = SkinJucatorPeTinta
        ElseIf P(3, 6) = "JucatorPeTinta" Then
            P(3, 6) = "Nimic"
            pct3cu6.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct3cu7_Click(sender As System.Object, e As System.EventArgs) Handles pct3cu7.MouseDown
        If P(3, 7) = "Nimic" Then
            P(3, 7) = "Perete"
            pct3cu7.Image = SkinPerete
        ElseIf P(3, 7) = "Perete" Then
            P(3, 7) = "Teren"
            pct3cu7.Image = SkinTeren
        ElseIf P(3, 7) = "Teren" Then
            P(3, 7) = "Cutie"
            pct3cu7.Image = SkinCutie
            Cutii += 1
        ElseIf P(3, 7) = "Cutie" Then
            P(3, 7) = "Tinta"
            pct3cu7.Image = SkinTinta
            Cutii -= 1
        ElseIf P(3, 7) = "Tinta" Then
            P(3, 7) = "Rezolvat"
            pct3cu7.Image = SkinRezolvat
        ElseIf P(3, 7) = "Rezolvat" Then
            If Ok Then
                P(3, 7) = "Jucator"
                pct3cu7.Image = SkinJucator
                Ok = False
            Else
                P(3, 7) = "Nimic"
                pct3cu7.Image = SkinNimic
            End If
        ElseIf P(3, 7) = "Jucator" Then
            P(3, 7) = "JucatorPeTinta"
            pct3cu7.Image = SkinJucatorPeTinta
        ElseIf P(3, 7) = "JucatorPeTinta" Then
            P(3, 7) = "Nimic"
            pct3cu7.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct3cu8_Click(sender As System.Object, e As System.EventArgs) Handles pct3cu8.MouseDown
        If P(3, 8) = "Nimic" Then
            P(3, 8) = "Perete"
            pct3cu8.Image = SkinPerete
        ElseIf P(3, 8) = "Perete" Then
            P(3, 8) = "Teren"
            pct3cu8.Image = SkinTeren
        ElseIf P(3, 8) = "Teren" Then
            P(3, 8) = "Cutie"
            pct3cu8.Image = SkinCutie
            Cutii += 1
        ElseIf P(3, 8) = "Cutie" Then
            P(3, 8) = "Tinta"
            pct3cu8.Image = SkinTinta
            Cutii -= 1
        ElseIf P(3, 8) = "Tinta" Then
            P(3, 8) = "Rezolvat"
            pct3cu8.Image = SkinRezolvat
        ElseIf P(3, 8) = "Rezolvat" Then
            If Ok Then
                P(3, 8) = "Jucator"
                pct3cu8.Image = SkinJucator
                Ok = False
            Else
                P(3, 8) = "Nimic"
                pct3cu8.Image = SkinNimic
            End If
        ElseIf P(3, 8) = "Jucator" Then
            P(3, 8) = "JucatorPeTinta"
            pct3cu8.Image = SkinJucatorPeTinta
        ElseIf P(3, 8) = "JucatorPeTinta" Then
            P(3, 8) = "Nimic"
            pct3cu8.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct3cu9_Click(sender As System.Object, e As System.EventArgs) Handles pct3cu9.MouseDown
        If P(3, 9) = "Nimic" Then
            P(3, 9) = "Perete"
            pct3cu9.Image = SkinPerete
        ElseIf P(3, 9) = "Perete" Then
            P(3, 9) = "Teren"
            pct3cu9.Image = SkinTeren
        ElseIf P(3, 9) = "Teren" Then
            P(3, 9) = "Cutie"
            pct3cu9.Image = SkinCutie
            Cutii += 1
        ElseIf P(3, 9) = "Cutie" Then
            P(3, 9) = "Tinta"
            pct3cu9.Image = SkinTinta
            Cutii -= 1
        ElseIf P(3, 9) = "Tinta" Then
            P(3, 9) = "Rezolvat"
            pct3cu9.Image = SkinRezolvat
        ElseIf P(3, 9) = "Rezolvat" Then
            If Ok Then
                P(3, 9) = "Jucator"
                pct3cu9.Image = SkinJucator
                Ok = False
            Else
                P(3, 9) = "Nimic"
                pct3cu9.Image = SkinNimic
            End If
        ElseIf P(3, 9) = "Jucator" Then
            P(3, 9) = "JucatorPeTinta"
            pct3cu9.Image = SkinJucatorPeTinta
        ElseIf P(3, 9) = "JucatorPeTinta" Then
            P(3, 9) = "Nimic"
            pct3cu9.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct3cu10_Click(sender As System.Object, e As System.EventArgs) Handles pct3cu10.MouseDown
        If P(3, 10) = "Nimic" Then
            P(3, 10) = "Perete"
            pct3cu10.Image = SkinPerete
        ElseIf P(3, 10) = "Perete" Then
            P(3, 10) = "Teren"
            pct3cu10.Image = SkinTeren
        ElseIf P(3, 10) = "Teren" Then
            P(3, 10) = "Cutie"
            pct3cu10.Image = SkinCutie
            Cutii += 1
        ElseIf P(3, 10) = "Cutie" Then
            P(3, 10) = "Tinta"
            pct3cu10.Image = SkinTinta
            Cutii -= 1
        ElseIf P(3, 10) = "Tinta" Then
            P(3, 10) = "Rezolvat"
            pct3cu10.Image = SkinRezolvat
        ElseIf P(3, 10) = "Rezolvat" Then
            If Ok Then
                P(3, 10) = "Jucator"
                pct3cu10.Image = SkinJucator
                Ok = False
            Else
                P(3, 10) = "Nimic"
                pct3cu10.Image = SkinNimic
            End If
        ElseIf P(3, 10) = "Jucator" Then
            P(3, 10) = "JucatorPeTinta"
            pct3cu10.Image = SkinJucatorPeTinta
        ElseIf P(3, 10) = "JucatorPeTinta" Then
            P(3, 10) = "Nimic"
            pct3cu10.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct3cu11_Click(sender As System.Object, e As System.EventArgs) Handles pct3cu11.MouseDown
        If P(3, 11) = "Nimic" Then
            P(3, 11) = "Perete"
            pct3cu11.Image = SkinPerete
        ElseIf P(3, 11) = "Perete" Then
            P(3, 11) = "Teren"
            pct3cu11.Image = SkinTeren
        ElseIf P(3, 11) = "Teren" Then
            P(3, 11) = "Cutie"
            pct3cu11.Image = SkinCutie
            Cutii += 1
        ElseIf P(3, 11) = "Cutie" Then
            P(3, 11) = "Tinta"
            pct3cu11.Image = SkinTinta
            Cutii -= 1
        ElseIf P(3, 11) = "Tinta" Then
            P(3, 11) = "Rezolvat"
            pct3cu11.Image = SkinRezolvat
        ElseIf P(3, 11) = "Rezolvat" Then
            If Ok Then
                P(3, 11) = "Jucator"
                pct3cu11.Image = SkinJucator
                Ok = False
            Else
                P(3, 11) = "Nimic"
                pct3cu11.Image = SkinNimic
            End If
        ElseIf P(3, 11) = "Jucator" Then
            P(3, 11) = "JucatorPeTinta"
            pct3cu11.Image = SkinJucatorPeTinta
        ElseIf P(3, 11) = "JucatorPeTinta" Then
            P(3, 11) = "Nimic"
            pct3cu11.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct3cu12_Click(sender As System.Object, e As System.EventArgs) Handles pct3cu12.MouseDown
        If P(3, 12) = "Nimic" Then
            P(3, 12) = "Perete"
            pct3cu12.Image = SkinPerete
        ElseIf P(3, 12) = "Perete" Then
            P(3, 12) = "Teren"
            pct3cu12.Image = SkinTeren
        ElseIf P(3, 12) = "Teren" Then
            P(3, 12) = "Cutie"
            pct3cu12.Image = SkinCutie
            Cutii += 1
        ElseIf P(3, 12) = "Cutie" Then
            P(3, 12) = "Tinta"
            pct3cu12.Image = SkinTinta
            Cutii -= 1
        ElseIf P(3, 12) = "Tinta" Then
            P(3, 12) = "Rezolvat"
            pct3cu12.Image = SkinRezolvat
        ElseIf P(3, 12) = "Rezolvat" Then
            If Ok Then
                P(3, 12) = "Jucator"
                pct3cu12.Image = SkinJucator
                Ok = False
            Else
                P(3, 12) = "Nimic"
                pct3cu12.Image = SkinNimic
            End If
        ElseIf P(3, 12) = "Jucator" Then
            P(3, 12) = "JucatorPeTinta"
            pct3cu12.Image = SkinJucatorPeTinta
        ElseIf P(3, 12) = "JucatorPeTinta" Then
            P(3, 12) = "Nimic"
            pct3cu12.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct3cu13_Click(sender As System.Object, e As System.EventArgs) Handles pct3cu13.MouseDown
        If P(3, 13) = "Nimic" Then
            P(3, 13) = "Perete"
            pct3cu13.Image = SkinPerete
        ElseIf P(3, 13) = "Perete" Then
            P(3, 13) = "Teren"
            pct3cu13.Image = SkinTeren
        ElseIf P(3, 13) = "Teren" Then
            P(3, 13) = "Cutie"
            pct3cu13.Image = SkinCutie
            Cutii += 1
        ElseIf P(3, 13) = "Cutie" Then
            P(3, 13) = "Tinta"
            pct3cu13.Image = SkinTinta
            Cutii -= 1
        ElseIf P(3, 13) = "Tinta" Then
            P(3, 13) = "Rezolvat"
            pct3cu13.Image = SkinRezolvat
        ElseIf P(3, 13) = "Rezolvat" Then
            If Ok Then
                P(3, 13) = "Jucator"
                pct3cu13.Image = SkinJucator
                Ok = False
            Else
                P(3, 13) = "Nimic"
                pct3cu13.Image = SkinNimic
            End If
        ElseIf P(3, 13) = "Jucator" Then
            P(3, 13) = "JucatorPeTinta"
            pct3cu13.Image = SkinJucatorPeTinta
        ElseIf P(3, 13) = "JucatorPeTinta" Then
            P(3, 13) = "Nimic"
            pct3cu13.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct3cu14_Click(sender As System.Object, e As System.EventArgs) Handles pct3cu14.MouseDown
        If P(3, 14) = "Nimic" Then
            P(3, 14) = "Perete"
            pct3cu14.Image = SkinPerete
        ElseIf P(3, 14) = "Perete" Then
            P(3, 14) = "Teren"
            pct3cu14.Image = SkinTeren
        ElseIf P(3, 14) = "Teren" Then
            P(3, 14) = "Cutie"
            pct3cu14.Image = SkinCutie
            Cutii += 1
        ElseIf P(3, 14) = "Cutie" Then
            P(3, 14) = "Tinta"
            pct3cu14.Image = SkinTinta
            Cutii -= 1
        ElseIf P(3, 14) = "Tinta" Then
            P(3, 14) = "Rezolvat"
            pct3cu14.Image = SkinRezolvat
        ElseIf P(3, 14) = "Rezolvat" Then
            If Ok Then
                P(3, 14) = "Jucator"
                pct3cu14.Image = SkinJucator
                Ok = False
            Else
                P(3, 14) = "Nimic"
                pct3cu14.Image = SkinNimic
            End If
        ElseIf P(3, 14) = "Jucator" Then
            P(3, 14) = "JucatorPeTinta"
            pct3cu14.Image = SkinJucatorPeTinta
        ElseIf P(3, 14) = "JucatorPeTinta" Then
            P(3, 14) = "Nimic"
            pct3cu14.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct4cu1_Click(sender As System.Object, e As System.EventArgs) Handles pct4cu1.MouseDown
        If P(4, 1) = "Nimic" Then
            P(4, 1) = "Perete"
            pct4cu1.Image = SkinPerete
        ElseIf P(4, 1) = "Perete" Then
            P(4, 1) = "Teren"
            pct4cu1.Image = SkinTeren
        ElseIf P(4, 1) = "Teren" Then
            P(4, 1) = "Cutie"
            pct4cu1.Image = SkinCutie
            Cutii += 1
        ElseIf P(4, 1) = "Cutie" Then
            P(4, 1) = "Tinta"
            pct4cu1.Image = SkinTinta
            Cutii -= 1
        ElseIf P(4, 1) = "Tinta" Then
            P(4, 1) = "Rezolvat"
            pct4cu1.Image = SkinRezolvat
        ElseIf P(4, 1) = "Rezolvat" Then
            If Ok Then
                P(4, 1) = "Jucator"
                pct4cu1.Image = SkinJucator
                Ok = False
            Else
                P(4, 1) = "Nimic"
                pct4cu1.Image = SkinNimic
            End If
        ElseIf P(4, 1) = "Jucator" Then
            P(4, 1) = "JucatorPeTinta"
            pct4cu1.Image = SkinJucatorPeTinta
        ElseIf P(4, 1) = "JucatorPeTinta" Then
            P(4, 1) = "Nimic"
            pct4cu1.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct4cu2_Click(sender As System.Object, e As System.EventArgs) Handles pct4cu2.MouseDown
        If P(4, 2) = "Nimic" Then
            P(4, 2) = "Perete"
            pct4cu2.Image = SkinPerete
        ElseIf P(4, 2) = "Perete" Then
            P(4, 2) = "Teren"
            pct4cu2.Image = SkinTeren
        ElseIf P(4, 2) = "Teren" Then
            P(4, 2) = "Cutie"
            pct4cu2.Image = SkinCutie
            Cutii += 1
        ElseIf P(4, 2) = "Cutie" Then
            P(4, 2) = "Tinta"
            pct4cu2.Image = SkinTinta
            Cutii -= 1
        ElseIf P(4, 2) = "Tinta" Then
            P(4, 2) = "Rezolvat"
            pct4cu2.Image = SkinRezolvat
        ElseIf P(4, 2) = "Rezolvat" Then
            If Ok Then
                P(4, 2) = "Jucator"
                pct4cu2.Image = SkinJucator
                Ok = False
            Else
                P(4, 2) = "Nimic"
                pct4cu2.Image = SkinNimic
            End If
        ElseIf P(4, 2) = "Jucator" Then
            P(4, 2) = "JucatorPeTinta"
            pct4cu2.Image = SkinJucatorPeTinta
        ElseIf P(4, 2) = "JucatorPeTinta" Then
            P(4, 2) = "Nimic"
            pct4cu2.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct4cu3_Click(sender As System.Object, e As System.EventArgs) Handles pct4cu3.MouseDown
        If P(4, 3) = "Nimic" Then
            P(4, 3) = "Perete"
            pct4cu3.Image = SkinPerete
        ElseIf P(4, 3) = "Perete" Then
            P(4, 3) = "Teren"
            pct4cu3.Image = SkinTeren
        ElseIf P(4, 3) = "Teren" Then
            P(4, 3) = "Cutie"
            pct4cu3.Image = SkinCutie
            Cutii += 1
        ElseIf P(4, 3) = "Cutie" Then
            P(4, 3) = "Tinta"
            pct4cu3.Image = SkinTinta
            Cutii -= 1
        ElseIf P(4, 3) = "Tinta" Then
            P(4, 3) = "Rezolvat"
            pct4cu3.Image = SkinRezolvat
        ElseIf P(4, 3) = "Rezolvat" Then
            If Ok Then
                P(4, 3) = "Jucator"
                pct4cu3.Image = SkinJucator
                Ok = False
            Else
                P(4, 3) = "Nimic"
                pct4cu3.Image = SkinNimic
            End If
        ElseIf P(4, 3) = "Jucator" Then
            P(4, 3) = "JucatorPeTinta"
            pct4cu3.Image = SkinJucatorPeTinta
        ElseIf P(4, 3) = "JucatorPeTinta" Then
            P(4, 3) = "Nimic"
            pct4cu3.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct4cu4_Click(sender As System.Object, e As System.EventArgs) Handles pct4cu4.MouseDown
        If P(4, 4) = "Nimic" Then
            P(4, 4) = "Perete"
            pct4cu4.Image = SkinPerete
        ElseIf P(4, 4) = "Perete" Then
            P(4, 4) = "Teren"
            pct4cu4.Image = SkinTeren
        ElseIf P(4, 4) = "Teren" Then
            P(4, 4) = "Cutie"
            pct4cu4.Image = SkinCutie
            Cutii += 1
        ElseIf P(4, 4) = "Cutie" Then
            P(4, 4) = "Tinta"
            pct4cu4.Image = SkinTinta
            Cutii -= 1
        ElseIf P(4, 4) = "Tinta" Then
            P(4, 4) = "Rezolvat"
            pct4cu4.Image = SkinRezolvat
        ElseIf P(4, 4) = "Rezolvat" Then
            If Ok Then
                P(4, 4) = "Jucator"
                pct4cu4.Image = SkinJucator
                Ok = False
            Else
                P(4, 4) = "Nimic"
                pct4cu4.Image = SkinNimic
            End If
        ElseIf P(4, 4) = "Jucator" Then
            P(4, 4) = "JucatorPeTinta"
            pct4cu4.Image = SkinJucatorPeTinta
        ElseIf P(4, 4) = "JucatorPeTinta" Then
            P(4, 4) = "Nimic"
            pct4cu4.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct4cu5_Click(sender As System.Object, e As System.EventArgs) Handles pct4cu5.MouseDown
        If P(4, 5) = "Nimic" Then
            P(4, 5) = "Perete"
            pct4cu5.Image = SkinPerete
        ElseIf P(4, 5) = "Perete" Then
            P(4, 5) = "Teren"
            pct4cu5.Image = SkinTeren
        ElseIf P(4, 5) = "Teren" Then
            P(4, 5) = "Cutie"
            pct4cu5.Image = SkinCutie
            Cutii += 1
        ElseIf P(4, 5) = "Cutie" Then
            P(4, 5) = "Tinta"
            pct4cu5.Image = SkinTinta
            Cutii -= 1
        ElseIf P(4, 5) = "Tinta" Then
            P(4, 5) = "Rezolvat"
            pct4cu5.Image = SkinRezolvat
        ElseIf P(4, 5) = "Rezolvat" Then
            If Ok Then
                P(4, 5) = "Jucator"
                pct4cu5.Image = SkinJucator
                Ok = False
            Else
                P(4, 5) = "Nimic"
                pct4cu5.Image = SkinNimic
            End If
        ElseIf P(4, 5) = "Jucator" Then
            P(4, 5) = "JucatorPeTinta"
            pct4cu5.Image = SkinJucatorPeTinta
        ElseIf P(4, 5) = "JucatorPeTinta" Then
            P(4, 5) = "Nimic"
            pct4cu5.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct4cu6_Click(sender As System.Object, e As System.EventArgs) Handles pct4cu6.MouseDown
        If P(4, 6) = "Nimic" Then
            P(4, 6) = "Perete"
            pct4cu6.Image = SkinPerete
        ElseIf P(4, 6) = "Perete" Then
            P(4, 6) = "Teren"
            pct4cu6.Image = SkinTeren
        ElseIf P(4, 6) = "Teren" Then
            P(4, 6) = "Cutie"
            pct4cu6.Image = SkinCutie
            Cutii += 1
        ElseIf P(4, 6) = "Cutie" Then
            P(4, 6) = "Tinta"
            pct4cu6.Image = SkinTinta
            Cutii -= 1
        ElseIf P(4, 6) = "Tinta" Then
            P(4, 6) = "Rezolvat"
            pct4cu6.Image = SkinRezolvat
        ElseIf P(4, 6) = "Rezolvat" Then
            If Ok Then
                P(4, 6) = "Jucator"
                pct4cu6.Image = SkinJucator
                Ok = False
            Else
                P(4, 6) = "Nimic"
                pct4cu6.Image = SkinNimic
            End If
        ElseIf P(4, 6) = "Jucator" Then
            P(4, 6) = "JucatorPeTinta"
            pct4cu6.Image = SkinJucatorPeTinta
        ElseIf P(4, 6) = "JucatorPeTinta" Then
            P(4, 6) = "Nimic"
            pct4cu6.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct4cu7_Click(sender As System.Object, e As System.EventArgs) Handles pct4cu7.MouseDown
        If P(4, 7) = "Nimic" Then
            P(4, 7) = "Perete"
            pct4cu7.Image = SkinPerete
        ElseIf P(4, 7) = "Perete" Then
            P(4, 7) = "Teren"
            pct4cu7.Image = SkinTeren
        ElseIf P(4, 7) = "Teren" Then
            P(4, 7) = "Cutie"
            pct4cu7.Image = SkinCutie
            Cutii += 1
        ElseIf P(4, 7) = "Cutie" Then
            P(4, 7) = "Tinta"
            pct4cu7.Image = SkinTinta
            Cutii -= 1
        ElseIf P(4, 7) = "Tinta" Then
            P(4, 7) = "Rezolvat"
            pct4cu7.Image = SkinRezolvat
        ElseIf P(4, 7) = "Rezolvat" Then
            If Ok Then
                P(4, 7) = "Jucator"
                pct4cu7.Image = SkinJucator
                Ok = False
            Else
                P(4, 7) = "Nimic"
                pct4cu7.Image = SkinNimic
            End If
        ElseIf P(4, 7) = "Jucator" Then
            P(4, 7) = "JucatorPeTinta"
            pct4cu7.Image = SkinJucatorPeTinta
        ElseIf P(4, 7) = "JucatorPeTinta" Then
            P(4, 7) = "Nimic"
            pct4cu7.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct4cu8_Click(sender As System.Object, e As System.EventArgs) Handles pct4cu8.MouseDown
        If P(4, 8) = "Nimic" Then
            P(4, 8) = "Perete"
            pct4cu8.Image = SkinPerete
        ElseIf P(4, 8) = "Perete" Then
            P(4, 8) = "Teren"
            pct4cu8.Image = SkinTeren
        ElseIf P(4, 8) = "Teren" Then
            P(4, 8) = "Cutie"
            pct4cu8.Image = SkinCutie
            Cutii += 1
        ElseIf P(4, 8) = "Cutie" Then
            P(4, 8) = "Tinta"
            pct4cu8.Image = SkinTinta
            Cutii -= 1
        ElseIf P(4, 8) = "Tinta" Then
            P(4, 8) = "Rezolvat"
            pct4cu8.Image = SkinRezolvat
        ElseIf P(4, 8) = "Rezolvat" Then
            If Ok Then
                P(4, 8) = "Jucator"
                pct4cu8.Image = SkinJucator
                Ok = False
            Else
                P(4, 8) = "Nimic"
                pct4cu8.Image = SkinNimic
            End If
        ElseIf P(4, 8) = "Jucator" Then
            P(4, 8) = "JucatorPeTinta"
            pct4cu8.Image = SkinJucatorPeTinta
        ElseIf P(4, 8) = "JucatorPeTinta" Then
            P(4, 8) = "Nimic"
            pct4cu8.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct4cu9_Click(sender As System.Object, e As System.EventArgs) Handles pct4cu9.MouseDown
        If P(4, 9) = "Nimic" Then
            P(4, 9) = "Perete"
            pct4cu9.Image = SkinPerete
        ElseIf P(4, 9) = "Perete" Then
            P(4, 9) = "Teren"
            pct4cu9.Image = SkinTeren
        ElseIf P(4, 9) = "Teren" Then
            P(4, 9) = "Cutie"
            pct4cu9.Image = SkinCutie
            Cutii += 1
        ElseIf P(4, 9) = "Cutie" Then
            P(4, 9) = "Tinta"
            pct4cu9.Image = SkinTinta
            Cutii -= 1
        ElseIf P(4, 9) = "Tinta" Then
            P(4, 9) = "Rezolvat"
            pct4cu9.Image = SkinRezolvat
        ElseIf P(4, 9) = "Rezolvat" Then
            If Ok Then
                P(4, 9) = "Jucator"
                pct4cu9.Image = SkinJucator
                Ok = False
            Else
                P(4, 9) = "Nimic"
                pct4cu9.Image = SkinNimic
            End If
        ElseIf P(4, 9) = "Jucator" Then
            P(4, 9) = "JucatorPeTinta"
            pct4cu9.Image = SkinJucatorPeTinta
        ElseIf P(4, 9) = "JucatorPeTinta" Then
            P(4, 9) = "Nimic"
            pct4cu9.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct4cu10_Click(sender As System.Object, e As System.EventArgs) Handles pct4cu10.MouseDown
        If P(4, 10) = "Nimic" Then
            P(4, 10) = "Perete"
            pct4cu10.Image = SkinPerete
        ElseIf P(4, 10) = "Perete" Then
            P(4, 10) = "Teren"
            pct4cu10.Image = SkinTeren
        ElseIf P(4, 10) = "Teren" Then
            P(4, 10) = "Cutie"
            pct4cu10.Image = SkinCutie
            Cutii += 1
        ElseIf P(4, 10) = "Cutie" Then
            P(4, 10) = "Tinta"
            pct4cu10.Image = SkinTinta
            Cutii -= 1
        ElseIf P(4, 10) = "Tinta" Then
            P(4, 10) = "Rezolvat"
            pct4cu10.Image = SkinRezolvat
        ElseIf P(4, 10) = "Rezolvat" Then
            If Ok Then
                P(4, 10) = "Jucator"
                pct4cu10.Image = SkinJucator
                Ok = False
            Else
                P(4, 10) = "Nimic"
                pct4cu10.Image = SkinNimic
            End If
        ElseIf P(4, 10) = "Jucator" Then
            P(4, 10) = "JucatorPeTinta"
            pct4cu10.Image = SkinJucatorPeTinta
        ElseIf P(4, 10) = "JucatorPeTinta" Then
            P(4, 10) = "Nimic"
            pct4cu10.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct4cu11_Click(sender As System.Object, e As System.EventArgs) Handles pct4cu11.MouseDown
        If P(4, 11) = "Nimic" Then
            P(4, 11) = "Perete"
            pct4cu11.Image = SkinPerete
        ElseIf P(4, 11) = "Perete" Then
            P(4, 11) = "Teren"
            pct4cu11.Image = SkinTeren
        ElseIf P(4, 11) = "Teren" Then
            P(4, 11) = "Cutie"
            pct4cu11.Image = SkinCutie
            Cutii += 1
        ElseIf P(4, 11) = "Cutie" Then
            P(4, 11) = "Tinta"
            pct4cu11.Image = SkinTinta
            Cutii -= 1
        ElseIf P(4, 11) = "Tinta" Then
            P(4, 11) = "Rezolvat"
            pct4cu11.Image = SkinRezolvat
        ElseIf P(4, 11) = "Rezolvat" Then
            If Ok Then
                P(4, 11) = "Jucator"
                pct4cu11.Image = SkinJucator
                Ok = False
            Else
                P(4, 11) = "Nimic"
                pct4cu11.Image = SkinNimic
            End If
        ElseIf P(4, 11) = "Jucator" Then
            P(4, 11) = "JucatorPeTinta"
            pct4cu11.Image = SkinJucatorPeTinta
        ElseIf P(4, 11) = "JucatorPeTinta" Then
            P(4, 11) = "Nimic"
            pct4cu11.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct4cu12_Click(sender As System.Object, e As System.EventArgs) Handles pct4cu12.MouseDown
        If P(4, 12) = "Nimic" Then
            P(4, 12) = "Perete"
            pct4cu12.Image = SkinPerete
        ElseIf P(4, 12) = "Perete" Then
            P(4, 12) = "Teren"
            pct4cu12.Image = SkinTeren
        ElseIf P(4, 12) = "Teren" Then
            P(4, 12) = "Cutie"
            pct4cu12.Image = SkinCutie
            Cutii += 1
        ElseIf P(4, 12) = "Cutie" Then
            P(4, 12) = "Tinta"
            pct4cu12.Image = SkinTinta
            Cutii -= 1
        ElseIf P(4, 12) = "Tinta" Then
            P(4, 12) = "Rezolvat"
            pct4cu12.Image = SkinRezolvat
        ElseIf P(4, 12) = "Rezolvat" Then
            If Ok Then
                P(4, 12) = "Jucator"
                pct4cu12.Image = SkinJucator
                Ok = False
            Else
                P(4, 12) = "Nimic"
                pct4cu12.Image = SkinNimic
            End If
        ElseIf P(4, 12) = "Jucator" Then
            P(4, 12) = "JucatorPeTinta"
            pct4cu12.Image = SkinJucatorPeTinta
        ElseIf P(4, 12) = "JucatorPeTinta" Then
            P(4, 12) = "Nimic"
            pct4cu12.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct4cu13_Click(sender As System.Object, e As System.EventArgs) Handles pct4cu13.MouseDown
        If P(4, 13) = "Nimic" Then
            P(4, 13) = "Perete"
            pct4cu13.Image = SkinPerete
        ElseIf P(4, 13) = "Perete" Then
            P(4, 13) = "Teren"
            pct4cu13.Image = SkinTeren
        ElseIf P(4, 13) = "Teren" Then
            P(4, 13) = "Cutie"
            pct4cu13.Image = SkinCutie
            Cutii += 1
        ElseIf P(4, 13) = "Cutie" Then
            P(4, 13) = "Tinta"
            pct4cu13.Image = SkinTinta
            Cutii -= 1
        ElseIf P(4, 13) = "Tinta" Then
            P(4, 13) = "Rezolvat"
            pct4cu13.Image = SkinRezolvat
        ElseIf P(4, 13) = "Rezolvat" Then
            If Ok Then
                P(4, 13) = "Jucator"
                pct4cu13.Image = SkinJucator
                Ok = False
            Else
                P(4, 13) = "Nimic"
                pct4cu13.Image = SkinNimic
            End If
        ElseIf P(4, 13) = "Jucator" Then
            P(4, 13) = "JucatorPeTinta"
            pct4cu13.Image = SkinJucatorPeTinta
        ElseIf P(4, 13) = "JucatorPeTinta" Then
            P(4, 13) = "Nimic"
            pct4cu13.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct4cu14_Click(sender As System.Object, e As System.EventArgs) Handles pct4cu14.MouseDown
        If P(4, 14) = "Nimic" Then
            P(4, 14) = "Perete"
            pct4cu14.Image = SkinPerete
        ElseIf P(4, 14) = "Perete" Then
            P(4, 14) = "Teren"
            pct4cu14.Image = SkinTeren
        ElseIf P(4, 14) = "Teren" Then
            P(4, 14) = "Cutie"
            pct4cu14.Image = SkinCutie
            Cutii += 1
        ElseIf P(4, 14) = "Cutie" Then
            P(4, 14) = "Tinta"
            pct4cu14.Image = SkinTinta
            Cutii -= 1
        ElseIf P(4, 14) = "Tinta" Then
            P(4, 14) = "Rezolvat"
            pct4cu14.Image = SkinRezolvat
        ElseIf P(4, 14) = "Rezolvat" Then
            If Ok Then
                P(4, 14) = "Jucator"
                pct4cu14.Image = SkinJucator
                Ok = False
            Else
                P(4, 14) = "Nimic"
                pct4cu14.Image = SkinNimic
            End If
        ElseIf P(4, 14) = "Jucator" Then
            P(4, 14) = "JucatorPeTinta"
            pct4cu14.Image = SkinJucatorPeTinta
        ElseIf P(4, 14) = "JucatorPeTinta" Then
            P(4, 14) = "Nimic"
            pct4cu14.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct5cu1_Click(sender As System.Object, e As System.EventArgs) Handles pct5cu1.MouseDown
        If P(5, 1) = "Nimic" Then
            P(5, 1) = "Perete"
            pct5cu1.Image = SkinPerete
        ElseIf P(5, 1) = "Perete" Then
            P(5, 1) = "Teren"
            pct5cu1.Image = SkinTeren
        ElseIf P(5, 1) = "Teren" Then
            P(5, 1) = "Cutie"
            pct5cu1.Image = SkinCutie
            Cutii += 1
        ElseIf P(5, 1) = "Cutie" Then
            P(5, 1) = "Tinta"
            pct5cu1.Image = SkinTinta
            Cutii -= 1
        ElseIf P(5, 1) = "Tinta" Then
            P(5, 1) = "Rezolvat"
            pct5cu1.Image = SkinRezolvat
        ElseIf P(5, 1) = "Rezolvat" Then
            If Ok Then
                P(5, 1) = "Jucator"
                pct5cu1.Image = SkinJucator
                Ok = False
            Else
                P(5, 1) = "Nimic"
                pct5cu1.Image = SkinNimic
            End If
        ElseIf P(5, 1) = "Jucator" Then
            P(5, 1) = "JucatorPeTinta"
            pct5cu1.Image = SkinJucatorPeTinta
        ElseIf P(5, 1) = "JucatorPeTinta" Then
            P(5, 1) = "Nimic"
            pct5cu1.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct5cu2_Click(sender As System.Object, e As System.EventArgs) Handles pct5cu2.MouseDown
        If P(5, 2) = "Nimic" Then
            P(5, 2) = "Perete"
            pct5cu2.Image = SkinPerete
        ElseIf P(5, 2) = "Perete" Then
            P(5, 2) = "Teren"
            pct5cu2.Image = SkinTeren
        ElseIf P(5, 2) = "Teren" Then
            P(5, 2) = "Cutie"
            pct5cu2.Image = SkinCutie
            Cutii += 1
        ElseIf P(5, 2) = "Cutie" Then
            P(5, 2) = "Tinta"
            pct5cu2.Image = SkinTinta
            Cutii -= 1
        ElseIf P(5, 2) = "Tinta" Then
            P(5, 2) = "Rezolvat"
            pct5cu2.Image = SkinRezolvat
        ElseIf P(5, 2) = "Rezolvat" Then
            If Ok Then
                P(5, 2) = "Jucator"
                pct5cu2.Image = SkinJucator
                Ok = False
            Else
                P(5, 2) = "Nimic"
                pct5cu2.Image = SkinNimic
            End If
        ElseIf P(5, 2) = "Jucator" Then
            P(5, 2) = "JucatorPeTinta"
            pct5cu2.Image = SkinJucatorPeTinta
        ElseIf P(5, 2) = "JucatorPeTinta" Then
            P(5, 2) = "Nimic"
            pct5cu2.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct5cu3_Click(sender As System.Object, e As System.EventArgs) Handles pct5cu3.MouseDown
        If P(5, 3) = "Nimic" Then
            P(5, 3) = "Perete"
            pct5cu3.Image = SkinPerete
        ElseIf P(5, 3) = "Perete" Then
            P(5, 3) = "Teren"
            pct5cu3.Image = SkinTeren
        ElseIf P(5, 3) = "Teren" Then
            P(5, 3) = "Cutie"
            pct5cu3.Image = SkinCutie
            Cutii += 1
        ElseIf P(5, 3) = "Cutie" Then
            P(5, 3) = "Tinta"
            pct5cu3.Image = SkinTinta
            Cutii -= 1
        ElseIf P(5, 3) = "Tinta" Then
            P(5, 3) = "Rezolvat"
            pct5cu3.Image = SkinRezolvat
        ElseIf P(5, 3) = "Rezolvat" Then
            If Ok Then
                P(5, 3) = "Jucator"
                pct5cu3.Image = SkinJucator
                Ok = False
            Else
                P(5, 3) = "Nimic"
                pct5cu3.Image = SkinNimic
            End If
        ElseIf P(5, 3) = "Jucator" Then
            P(5, 3) = "JucatorPeTinta"
            pct5cu3.Image = SkinJucatorPeTinta
        ElseIf P(5, 3) = "JucatorPeTinta" Then
            P(5, 3) = "Nimic"
            pct5cu3.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct5cu4_Click(sender As System.Object, e As System.EventArgs) Handles pct5cu4.MouseDown
        If P(5, 4) = "Nimic" Then
            P(5, 4) = "Perete"
            pct5cu4.Image = SkinPerete
        ElseIf P(5, 4) = "Perete" Then
            P(5, 4) = "Teren"
            pct5cu4.Image = SkinTeren
        ElseIf P(5, 4) = "Teren" Then
            P(5, 4) = "Cutie"
            pct5cu4.Image = SkinCutie
            Cutii += 1
        ElseIf P(5, 4) = "Cutie" Then
            P(5, 4) = "Tinta"
            pct5cu4.Image = SkinTinta
            Cutii -= 1
        ElseIf P(5, 4) = "Tinta" Then
            P(5, 4) = "Rezolvat"
            pct5cu4.Image = SkinRezolvat
        ElseIf P(5, 4) = "Rezolvat" Then
            If Ok Then
                P(5, 4) = "Jucator"
                pct5cu4.Image = SkinJucator
                Ok = False
            Else
                P(5, 4) = "Nimic"
                pct5cu4.Image = SkinNimic
            End If
        ElseIf P(5, 4) = "Jucator" Then
            P(5, 4) = "JucatorPeTinta"
            pct5cu4.Image = SkinJucatorPeTinta
        ElseIf P(5, 4) = "JucatorPeTinta" Then
            P(5, 4) = "Nimic"
            pct5cu4.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct5cu5_Click(sender As System.Object, e As System.EventArgs) Handles pct5cu5.MouseDown
        If P(5, 5) = "Nimic" Then
            P(5, 5) = "Perete"
            pct5cu5.Image = SkinPerete
        ElseIf P(5, 5) = "Perete" Then
            P(5, 5) = "Teren"
            pct5cu5.Image = SkinTeren
        ElseIf P(5, 5) = "Teren" Then
            P(5, 5) = "Cutie"
            pct5cu5.Image = SkinCutie
            Cutii += 1
        ElseIf P(5, 5) = "Cutie" Then
            P(5, 5) = "Tinta"
            pct5cu5.Image = SkinTinta
            Cutii -= 1
        ElseIf P(5, 5) = "Tinta" Then
            P(5, 5) = "Rezolvat"
            pct5cu5.Image = SkinRezolvat
        ElseIf P(5, 5) = "Rezolvat" Then
            If Ok Then
                P(5, 5) = "Jucator"
                pct5cu5.Image = SkinJucator
                Ok = False
            Else
                P(5, 5) = "Nimic"
                pct5cu5.Image = SkinNimic
            End If
        ElseIf P(5, 5) = "Jucator" Then
            P(5, 5) = "JucatorPeTinta"
            pct5cu5.Image = SkinJucatorPeTinta
        ElseIf P(5, 5) = "JucatorPeTinta" Then
            P(5, 5) = "Nimic"
            pct5cu5.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct5cu6_Click(sender As System.Object, e As System.EventArgs) Handles pct5cu6.MouseDown
        If P(5, 6) = "Nimic" Then
            P(5, 6) = "Perete"
            pct5cu6.Image = SkinPerete
        ElseIf P(5, 6) = "Perete" Then
            P(5, 6) = "Teren"
            pct5cu6.Image = SkinTeren
        ElseIf P(5, 6) = "Teren" Then
            P(5, 6) = "Cutie"
            pct5cu6.Image = SkinCutie
            Cutii += 1
        ElseIf P(5, 6) = "Cutie" Then
            P(5, 6) = "Tinta"
            pct5cu6.Image = SkinTinta
            Cutii -= 1
        ElseIf P(5, 6) = "Tinta" Then
            P(5, 6) = "Rezolvat"
            pct5cu6.Image = SkinRezolvat
        ElseIf P(5, 6) = "Rezolvat" Then
            If Ok Then
                P(5, 6) = "Jucator"
                pct5cu6.Image = SkinJucator
                Ok = False
            Else
                P(5, 6) = "Nimic"
                pct5cu6.Image = SkinNimic
            End If
        ElseIf P(5, 6) = "Jucator" Then
            P(5, 6) = "JucatorPeTinta"
            pct5cu6.Image = SkinJucatorPeTinta
        ElseIf P(5, 6) = "JucatorPeTinta" Then
            P(5, 6) = "Nimic"
            pct5cu6.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct5cu7_Click(sender As System.Object, e As System.EventArgs) Handles pct5cu7.MouseDown
        If P(5, 7) = "Nimic" Then
            P(5, 7) = "Perete"
            pct5cu7.Image = SkinPerete
        ElseIf P(5, 7) = "Perete" Then
            P(5, 7) = "Teren"
            pct5cu7.Image = SkinTeren
        ElseIf P(5, 7) = "Teren" Then
            P(5, 7) = "Cutie"
            pct5cu7.Image = SkinCutie
            Cutii += 1
        ElseIf P(5, 7) = "Cutie" Then
            P(5, 7) = "Tinta"
            pct5cu7.Image = SkinTinta
            Cutii -= 1
        ElseIf P(5, 7) = "Tinta" Then
            P(5, 7) = "Rezolvat"
            pct5cu7.Image = SkinRezolvat
        ElseIf P(5, 7) = "Rezolvat" Then
            If Ok Then
                P(5, 7) = "Jucator"
                pct5cu7.Image = SkinJucator
                Ok = False
            Else
                P(5, 7) = "Nimic"
                pct5cu7.Image = SkinNimic
            End If
        ElseIf P(5, 7) = "Jucator" Then
            P(5, 7) = "JucatorPeTinta"
            pct5cu7.Image = SkinJucatorPeTinta
        ElseIf P(5, 7) = "JucatorPeTinta" Then
            P(5, 7) = "Nimic"
            pct5cu7.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct5cu8_Click(sender As System.Object, e As System.EventArgs) Handles pct5cu8.MouseDown
        If P(5, 8) = "Nimic" Then
            P(5, 8) = "Perete"
            pct5cu8.Image = SkinPerete
        ElseIf P(5, 8) = "Perete" Then
            P(5, 8) = "Teren"
            pct5cu8.Image = SkinTeren
        ElseIf P(5, 8) = "Teren" Then
            P(5, 8) = "Cutie"
            pct5cu8.Image = SkinCutie
            Cutii += 1
        ElseIf P(5, 8) = "Cutie" Then
            P(5, 8) = "Tinta"
            pct5cu8.Image = SkinTinta
            Cutii -= 1
        ElseIf P(5, 8) = "Tinta" Then
            P(5, 8) = "Rezolvat"
            pct5cu8.Image = SkinRezolvat
        ElseIf P(5, 8) = "Rezolvat" Then
            If Ok Then
                P(5, 8) = "Jucator"
                pct5cu8.Image = SkinJucator
                Ok = False
            Else
                P(5, 8) = "Nimic"
                pct5cu8.Image = SkinNimic
            End If
        ElseIf P(5, 8) = "Jucator" Then
            P(5, 8) = "JucatorPeTinta"
            pct5cu8.Image = SkinJucatorPeTinta
        ElseIf P(5, 8) = "JucatorPeTinta" Then
            P(5, 8) = "Nimic"
            pct5cu8.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct5cu9_Click(sender As System.Object, e As System.EventArgs) Handles pct5cu9.MouseDown
        If P(5, 9) = "Nimic" Then
            P(5, 9) = "Perete"
            pct5cu9.Image = SkinPerete
        ElseIf P(5, 9) = "Perete" Then
            P(5, 9) = "Teren"
            pct5cu9.Image = SkinTeren
        ElseIf P(5, 9) = "Teren" Then
            P(5, 9) = "Cutie"
            pct5cu9.Image = SkinCutie
            Cutii += 1
        ElseIf P(5, 9) = "Cutie" Then
            P(5, 9) = "Tinta"
            pct5cu9.Image = SkinTinta
            Cutii -= 1
        ElseIf P(5, 9) = "Tinta" Then
            P(5, 9) = "Rezolvat"
            pct5cu9.Image = SkinRezolvat
        ElseIf P(5, 9) = "Rezolvat" Then
            If Ok Then
                P(5, 9) = "Jucator"
                pct5cu9.Image = SkinJucator
                Ok = False
            Else
                P(5, 9) = "Nimic"
                pct5cu9.Image = SkinNimic
            End If
        ElseIf P(5, 9) = "Jucator" Then
            P(5, 9) = "JucatorPeTinta"
            pct5cu9.Image = SkinJucatorPeTinta
        ElseIf P(5, 9) = "JucatorPeTinta" Then
            P(5, 9) = "Nimic"
            pct5cu9.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct5cu10_Click(sender As System.Object, e As System.EventArgs) Handles pct5cu10.MouseDown
        If P(5, 10) = "Nimic" Then
            P(5, 10) = "Perete"
            pct5cu10.Image = SkinPerete
        ElseIf P(5, 10) = "Perete" Then
            P(5, 10) = "Teren"
            pct5cu10.Image = SkinTeren
        ElseIf P(5, 10) = "Teren" Then
            P(5, 10) = "Cutie"
            pct5cu10.Image = SkinCutie
            Cutii += 1
        ElseIf P(5, 10) = "Cutie" Then
            P(5, 10) = "Tinta"
            pct5cu10.Image = SkinTinta
            Cutii -= 1
        ElseIf P(5, 10) = "Tinta" Then
            P(5, 10) = "Rezolvat"
            pct5cu10.Image = SkinRezolvat
        ElseIf P(5, 10) = "Rezolvat" Then
            If Ok Then
                P(5, 10) = "Jucator"
                pct5cu10.Image = SkinJucator
                Ok = False
            Else
                P(5, 10) = "Nimic"
                pct5cu10.Image = SkinNimic
            End If
        ElseIf P(5, 10) = "Jucator" Then
            P(5, 10) = "JucatorPeTinta"
            pct5cu10.Image = SkinJucatorPeTinta
        ElseIf P(5, 10) = "JucatorPeTinta" Then
            P(5, 10) = "Nimic"
            pct5cu10.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct5cu11_Click(sender As System.Object, e As System.EventArgs) Handles pct5cu11.MouseDown
        If P(5, 11) = "Nimic" Then
            P(5, 11) = "Perete"
            pct5cu11.Image = SkinPerete
        ElseIf P(5, 11) = "Perete" Then
            P(5, 11) = "Teren"
            pct5cu11.Image = SkinTeren
        ElseIf P(5, 11) = "Teren" Then
            P(5, 11) = "Cutie"
            pct5cu11.Image = SkinCutie
            Cutii += 1
        ElseIf P(5, 11) = "Cutie" Then
            P(5, 11) = "Tinta"
            pct5cu11.Image = SkinTinta
            Cutii -= 1
        ElseIf P(5, 11) = "Tinta" Then
            P(5, 11) = "Rezolvat"
            pct5cu11.Image = SkinRezolvat
        ElseIf P(5, 11) = "Rezolvat" Then
            If Ok Then
                P(5, 11) = "Jucator"
                pct5cu11.Image = SkinJucator
                Ok = False
            Else
                P(5, 11) = "Nimic"
                pct5cu11.Image = SkinNimic
            End If
        ElseIf P(5, 11) = "Jucator" Then
            P(5, 11) = "JucatorPeTinta"
            pct5cu11.Image = SkinJucatorPeTinta
        ElseIf P(5, 11) = "JucatorPeTinta" Then
            P(5, 11) = "Nimic"
            pct5cu11.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct5cu12_Click(sender As System.Object, e As System.EventArgs) Handles pct5cu12.MouseDown
        If P(5, 12) = "Nimic" Then
            P(5, 12) = "Perete"
            pct5cu12.Image = SkinPerete
        ElseIf P(5, 12) = "Perete" Then
            P(5, 12) = "Teren"
            pct5cu12.Image = SkinTeren
        ElseIf P(5, 12) = "Teren" Then
            P(5, 12) = "Cutie"
            pct5cu12.Image = SkinCutie
            Cutii += 1
        ElseIf P(5, 12) = "Cutie" Then
            P(5, 12) = "Tinta"
            pct5cu12.Image = SkinTinta
            Cutii -= 1
        ElseIf P(5, 12) = "Tinta" Then
            P(5, 12) = "Rezolvat"
            pct5cu12.Image = SkinRezolvat
        ElseIf P(5, 12) = "Rezolvat" Then
            If Ok Then
                P(5, 12) = "Jucator"
                pct5cu12.Image = SkinJucator
                Ok = False
            Else
                P(5, 12) = "Nimic"
                pct5cu12.Image = SkinNimic
            End If
        ElseIf P(5, 12) = "Jucator" Then
            P(5, 12) = "JucatorPeTinta"
            pct5cu12.Image = SkinJucatorPeTinta
        ElseIf P(5, 12) = "JucatorPeTinta" Then
            P(5, 12) = "Nimic"
            pct5cu12.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct5cu13_Click(sender As System.Object, e As System.EventArgs) Handles pct5cu13.MouseDown
        If P(5, 13) = "Nimic" Then
            P(5, 13) = "Perete"
            pct5cu13.Image = SkinPerete
        ElseIf P(5, 13) = "Perete" Then
            P(5, 13) = "Teren"
            pct5cu13.Image = SkinTeren
        ElseIf P(5, 13) = "Teren" Then
            P(5, 13) = "Cutie"
            pct5cu13.Image = SkinCutie
            Cutii += 1
        ElseIf P(5, 13) = "Cutie" Then
            P(5, 13) = "Tinta"
            pct5cu13.Image = SkinTinta
            Cutii -= 1
        ElseIf P(5, 13) = "Tinta" Then
            P(5, 13) = "Rezolvat"
            pct5cu13.Image = SkinRezolvat
        ElseIf P(5, 13) = "Rezolvat" Then
            If Ok Then
                P(5, 13) = "Jucator"
                pct5cu13.Image = SkinJucator
                Ok = False
            Else
                P(5, 13) = "Nimic"
                pct5cu13.Image = SkinNimic
            End If
        ElseIf P(5, 13) = "Jucator" Then
            P(5, 13) = "JucatorPeTinta"
            pct5cu13.Image = SkinJucatorPeTinta
        ElseIf P(5, 13) = "JucatorPeTinta" Then
            P(5, 13) = "Nimic"
            pct5cu13.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct5cu14_Click(sender As System.Object, e As System.EventArgs) Handles pct5cu14.MouseDown
        If P(5, 14) = "Nimic" Then
            P(5, 14) = "Perete"
            pct5cu14.Image = SkinPerete
        ElseIf P(5, 14) = "Perete" Then
            P(5, 14) = "Teren"
            pct5cu14.Image = SkinTeren
        ElseIf P(5, 14) = "Teren" Then
            P(5, 14) = "Cutie"
            pct5cu14.Image = SkinCutie
            Cutii += 1
        ElseIf P(5, 14) = "Cutie" Then
            P(5, 14) = "Tinta"
            pct5cu14.Image = SkinTinta
            Cutii -= 1
        ElseIf P(5, 14) = "Tinta" Then
            P(5, 14) = "Rezolvat"
            pct5cu14.Image = SkinRezolvat
        ElseIf P(5, 14) = "Rezolvat" Then
            If Ok Then
                P(5, 14) = "Jucator"
                pct5cu14.Image = SkinJucator
                Ok = False
            Else
                P(5, 14) = "Nimic"
                pct5cu14.Image = SkinNimic
            End If
        ElseIf P(5, 14) = "Jucator" Then
            P(5, 14) = "JucatorPeTinta"
            pct5cu14.Image = SkinJucatorPeTinta
        ElseIf P(5, 14) = "JucatorPeTinta" Then
            P(5, 14) = "Nimic"
            pct5cu14.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct6cu1_Click(sender As System.Object, e As System.EventArgs) Handles pct6cu1.MouseDown
        If P(6, 1) = "Nimic" Then
            P(6, 1) = "Perete"
            pct6cu1.Image = SkinPerete
        ElseIf P(6, 1) = "Perete" Then
            P(6, 1) = "Teren"
            pct6cu1.Image = SkinTeren
        ElseIf P(6, 1) = "Teren" Then
            P(6, 1) = "Cutie"
            pct6cu1.Image = SkinCutie
            Cutii += 1
        ElseIf P(6, 1) = "Cutie" Then
            P(6, 1) = "Tinta"
            pct6cu1.Image = SkinTinta
            Cutii -= 1
        ElseIf P(6, 1) = "Tinta" Then
            P(6, 1) = "Rezolvat"
            pct6cu1.Image = SkinRezolvat
        ElseIf P(6, 1) = "Rezolvat" Then
            If Ok Then
                P(6, 1) = "Jucator"
                pct6cu1.Image = SkinJucator
                Ok = False
            Else
                P(6, 1) = "Nimic"
                pct6cu1.Image = SkinNimic
            End If
        ElseIf P(6, 1) = "Jucator" Then
            P(6, 1) = "JucatorPeTinta"
            pct6cu1.Image = SkinJucatorPeTinta
        ElseIf P(6, 1) = "JucatorPeTinta" Then
            P(6, 1) = "Nimic"
            pct6cu1.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct6cu2_Click(sender As System.Object, e As System.EventArgs) Handles pct6cu2.MouseDown
        If P(6, 2) = "Nimic" Then
            P(6, 2) = "Perete"
            pct6cu2.Image = SkinPerete
        ElseIf P(6, 2) = "Perete" Then
            P(6, 2) = "Teren"
            pct6cu2.Image = SkinTeren
        ElseIf P(6, 2) = "Teren" Then
            P(6, 2) = "Cutie"
            pct6cu2.Image = SkinCutie
            Cutii += 1
        ElseIf P(6, 2) = "Cutie" Then
            P(6, 2) = "Tinta"
            pct6cu2.Image = SkinTinta
            Cutii -= 1
        ElseIf P(6, 2) = "Tinta" Then
            P(6, 2) = "Rezolvat"
            pct6cu2.Image = SkinRezolvat
        ElseIf P(6, 2) = "Rezolvat" Then
            If Ok Then
                P(6, 2) = "Jucator"
                pct6cu2.Image = SkinJucator
                Ok = False
            Else
                P(6, 2) = "Nimic"
                pct6cu2.Image = SkinNimic
            End If
        ElseIf P(6, 2) = "Jucator" Then
            P(6, 2) = "JucatorPeTinta"
            pct6cu2.Image = SkinJucatorPeTinta
        ElseIf P(6, 2) = "JucatorPeTinta" Then
            P(6, 2) = "Nimic"
            pct6cu2.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct6cu3_Click(sender As System.Object, e As System.EventArgs) Handles pct6cu3.MouseDown
        If P(6, 3) = "Nimic" Then
            P(6, 3) = "Perete"
            pct6cu3.Image = SkinPerete
        ElseIf P(6, 3) = "Perete" Then
            P(6, 3) = "Teren"
            pct6cu3.Image = SkinTeren
        ElseIf P(6, 3) = "Teren" Then
            P(6, 3) = "Cutie"
            pct6cu3.Image = SkinCutie
            Cutii += 1
        ElseIf P(6, 3) = "Cutie" Then
            P(6, 3) = "Tinta"
            pct6cu3.Image = SkinTinta
            Cutii -= 1
        ElseIf P(6, 3) = "Tinta" Then
            P(6, 3) = "Rezolvat"
            pct6cu3.Image = SkinRezolvat
        ElseIf P(6, 3) = "Rezolvat" Then
            If Ok Then
                P(6, 3) = "Jucator"
                pct6cu3.Image = SkinJucator
                Ok = False
            Else
                P(6, 3) = "Nimic"
                pct6cu3.Image = SkinNimic
            End If
        ElseIf P(6, 3) = "Jucator" Then
            P(6, 3) = "JucatorPeTinta"
            pct6cu3.Image = SkinJucatorPeTinta
        ElseIf P(6, 3) = "JucatorPeTinta" Then
            P(6, 3) = "Nimic"
            pct6cu3.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct6cu4_Click(sender As System.Object, e As System.EventArgs) Handles pct6cu4.MouseDown
        If P(6, 4) = "Nimic" Then
            P(6, 4) = "Perete"
            pct6cu4.Image = SkinPerete
        ElseIf P(6, 4) = "Perete" Then
            P(6, 4) = "Teren"
            pct6cu4.Image = SkinTeren
        ElseIf P(6, 4) = "Teren" Then
            P(6, 4) = "Cutie"
            pct6cu4.Image = SkinCutie
            Cutii += 1
        ElseIf P(6, 4) = "Cutie" Then
            P(6, 4) = "Tinta"
            pct6cu4.Image = SkinTinta
            Cutii -= 1
        ElseIf P(6, 4) = "Tinta" Then
            P(6, 4) = "Rezolvat"
            pct6cu4.Image = SkinRezolvat
        ElseIf P(6, 4) = "Rezolvat" Then
            If Ok Then
                P(6, 4) = "Jucator"
                pct6cu4.Image = SkinJucator
                Ok = False
            Else
                P(6, 4) = "Nimic"
                pct6cu4.Image = SkinNimic
            End If
        ElseIf P(6, 4) = "Jucator" Then
            P(6, 4) = "JucatorPeTinta"
            pct6cu4.Image = SkinJucatorPeTinta
        ElseIf P(6, 4) = "JucatorPeTinta" Then
            P(6, 4) = "Nimic"
            pct6cu4.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct6cu5_Click(sender As System.Object, e As System.EventArgs) Handles pct6cu5.MouseDown
        If P(6, 5) = "Nimic" Then
            P(6, 5) = "Perete"
            pct6cu5.Image = SkinPerete
        ElseIf P(6, 5) = "Perete" Then
            P(6, 5) = "Teren"
            pct6cu5.Image = SkinTeren
        ElseIf P(6, 5) = "Teren" Then
            P(6, 5) = "Cutie"
            pct6cu5.Image = SkinCutie
            Cutii += 1
        ElseIf P(6, 5) = "Cutie" Then
            P(6, 5) = "Tinta"
            pct6cu5.Image = SkinTinta
            Cutii -= 1
        ElseIf P(6, 5) = "Tinta" Then
            P(6, 5) = "Rezolvat"
            pct6cu5.Image = SkinRezolvat
        ElseIf P(6, 5) = "Rezolvat" Then
            If Ok Then
                P(6, 5) = "Jucator"
                pct6cu5.Image = SkinJucator
                Ok = False
            Else
                P(6, 5) = "Nimic"
                pct6cu5.Image = SkinNimic
            End If
        ElseIf P(6, 5) = "Jucator" Then
            P(6, 5) = "JucatorPeTinta"
            pct6cu5.Image = SkinJucatorPeTinta
        ElseIf P(6, 5) = "JucatorPeTinta" Then
            P(6, 5) = "Nimic"
            pct6cu5.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct6cu6_Click(sender As System.Object, e As System.EventArgs) Handles pct6cu6.MouseDown
        If P(6, 6) = "Nimic" Then
            P(6, 6) = "Perete"
            pct6cu6.Image = SkinPerete
        ElseIf P(6, 6) = "Perete" Then
            P(6, 6) = "Teren"
            pct6cu6.Image = SkinTeren
        ElseIf P(6, 6) = "Teren" Then
            P(6, 6) = "Cutie"
            pct6cu6.Image = SkinCutie
            Cutii += 1
        ElseIf P(6, 6) = "Cutie" Then
            P(6, 6) = "Tinta"
            pct6cu6.Image = SkinTinta
            Cutii -= 1
        ElseIf P(6, 6) = "Tinta" Then
            P(6, 6) = "Rezolvat"
            pct6cu6.Image = SkinRezolvat
        ElseIf P(6, 6) = "Rezolvat" Then
            If Ok Then
                P(6, 6) = "Jucator"
                pct6cu6.Image = SkinJucator
                Ok = False
            Else
                P(6, 6) = "Nimic"
                pct6cu6.Image = SkinNimic
            End If
        ElseIf P(6, 6) = "Jucator" Then
            P(6, 6) = "JucatorPeTinta"
            pct6cu6.Image = SkinJucatorPeTinta
        ElseIf P(6, 6) = "JucatorPeTinta" Then
            P(6, 6) = "Nimic"
            pct6cu6.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct6cu7_Click(sender As System.Object, e As System.EventArgs) Handles pct6cu7.MouseDown
        If P(6, 7) = "Nimic" Then
            P(6, 7) = "Perete"
            pct6cu7.Image = SkinPerete
        ElseIf P(6, 7) = "Perete" Then
            P(6, 7) = "Teren"
            pct6cu7.Image = SkinTeren
        ElseIf P(6, 7) = "Teren" Then
            P(6, 7) = "Cutie"
            pct6cu7.Image = SkinCutie
            Cutii += 1
        ElseIf P(6, 7) = "Cutie" Then
            P(6, 7) = "Tinta"
            pct6cu7.Image = SkinTinta
            Cutii -= 1
        ElseIf P(6, 7) = "Tinta" Then
            P(6, 7) = "Rezolvat"
            pct6cu7.Image = SkinRezolvat
        ElseIf P(6, 7) = "Rezolvat" Then
            If Ok Then
                P(6, 7) = "Jucator"
                pct6cu7.Image = SkinJucator
                Ok = False
            Else
                P(6, 7) = "Nimic"
                pct6cu7.Image = SkinNimic
            End If
        ElseIf P(6, 7) = "Jucator" Then
            P(6, 7) = "JucatorPeTinta"
            pct6cu7.Image = SkinJucatorPeTinta
        ElseIf P(6, 7) = "JucatorPeTinta" Then
            P(6, 7) = "Nimic"
            pct6cu7.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct6cu8_Click(sender As System.Object, e As System.EventArgs) Handles pct6cu8.MouseDown
        If P(6, 8) = "Nimic" Then
            P(6, 8) = "Perete"
            pct6cu8.Image = SkinPerete
        ElseIf P(6, 8) = "Perete" Then
            P(6, 8) = "Teren"
            pct6cu8.Image = SkinTeren
        ElseIf P(6, 8) = "Teren" Then
            P(6, 8) = "Cutie"
            pct6cu8.Image = SkinCutie
            Cutii += 1
        ElseIf P(6, 8) = "Cutie" Then
            P(6, 8) = "Tinta"
            pct6cu8.Image = SkinTinta
            Cutii -= 1
        ElseIf P(6, 8) = "Tinta" Then
            P(6, 8) = "Rezolvat"
            pct6cu8.Image = SkinRezolvat
        ElseIf P(6, 8) = "Rezolvat" Then
            If Ok Then
                P(6, 8) = "Jucator"
                pct6cu8.Image = SkinJucator
                Ok = False
            Else
                P(6, 8) = "Nimic"
                pct6cu8.Image = SkinNimic
            End If
        ElseIf P(6, 8) = "Jucator" Then
            P(6, 8) = "JucatorPeTinta"
            pct6cu8.Image = SkinJucatorPeTinta
        ElseIf P(6, 8) = "JucatorPeTinta" Then
            P(6, 8) = "Nimic"
            pct6cu8.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct6cu9_Click(sender As System.Object, e As System.EventArgs) Handles pct6cu9.MouseDown
        If P(6, 9) = "Nimic" Then
            P(6, 9) = "Perete"
            pct6cu9.Image = SkinPerete
        ElseIf P(6, 9) = "Perete" Then
            P(6, 9) = "Teren"
            pct6cu9.Image = SkinTeren
        ElseIf P(6, 9) = "Teren" Then
            P(6, 9) = "Cutie"
            pct6cu9.Image = SkinCutie
            Cutii += 1
        ElseIf P(6, 9) = "Cutie" Then
            P(6, 9) = "Tinta"
            pct6cu9.Image = SkinTinta
            Cutii -= 1
        ElseIf P(6, 9) = "Tinta" Then
            P(6, 9) = "Rezolvat"
            pct6cu9.Image = SkinRezolvat
        ElseIf P(6, 9) = "Rezolvat" Then
            If Ok Then
                P(6, 9) = "Jucator"
                pct6cu9.Image = SkinJucator
                Ok = False
            Else
                P(6, 9) = "Nimic"
                pct6cu9.Image = SkinNimic
            End If
        ElseIf P(6, 9) = "Jucator" Then
            P(6, 9) = "JucatorPeTinta"
            pct6cu9.Image = SkinJucatorPeTinta
        ElseIf P(6, 9) = "JucatorPeTinta" Then
            P(6, 9) = "Nimic"
            pct6cu9.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct6cu10_Click(sender As System.Object, e As System.EventArgs) Handles pct6cu10.MouseDown
        If P(6, 10) = "Nimic" Then
            P(6, 10) = "Perete"
            pct6cu10.Image = SkinPerete
        ElseIf P(6, 10) = "Perete" Then
            P(6, 10) = "Teren"
            pct6cu10.Image = SkinTeren
        ElseIf P(6, 10) = "Teren" Then
            P(6, 10) = "Cutie"
            pct6cu10.Image = SkinCutie
            Cutii += 1
        ElseIf P(6, 10) = "Cutie" Then
            P(6, 10) = "Tinta"
            pct6cu10.Image = SkinTinta
            Cutii -= 1
        ElseIf P(6, 10) = "Tinta" Then
            P(6, 10) = "Rezolvat"
            pct6cu10.Image = SkinRezolvat
        ElseIf P(6, 10) = "Rezolvat" Then
            If Ok Then
                P(6, 10) = "Jucator"
                pct6cu10.Image = SkinJucator
                Ok = False
            Else
                P(6, 10) = "Nimic"
                pct6cu10.Image = SkinNimic
            End If
        ElseIf P(6, 10) = "Jucator" Then
            P(6, 10) = "JucatorPeTinta"
            pct6cu10.Image = SkinJucatorPeTinta
        ElseIf P(6, 10) = "JucatorPeTinta" Then
            P(6, 10) = "Nimic"
            pct6cu10.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct6cu11_Click(sender As System.Object, e As System.EventArgs) Handles pct6cu11.MouseDown
        If P(6, 11) = "Nimic" Then
            P(6, 11) = "Perete"
            pct6cu11.Image = SkinPerete
        ElseIf P(6, 11) = "Perete" Then
            P(6, 11) = "Teren"
            pct6cu11.Image = SkinTeren
        ElseIf P(6, 11) = "Teren" Then
            P(6, 11) = "Cutie"
            pct6cu11.Image = SkinCutie
            Cutii += 1
        ElseIf P(6, 11) = "Cutie" Then
            P(6, 11) = "Tinta"
            pct6cu11.Image = SkinTinta
            Cutii -= 1
        ElseIf P(6, 11) = "Tinta" Then
            P(6, 11) = "Rezolvat"
            pct6cu11.Image = SkinRezolvat
        ElseIf P(6, 11) = "Rezolvat" Then
            If Ok Then
                P(6, 11) = "Jucator"
                pct6cu11.Image = SkinJucator
                Ok = False
            Else
                P(6, 11) = "Nimic"
                pct6cu11.Image = SkinNimic
            End If
        ElseIf P(6, 11) = "Jucator" Then
            P(6, 11) = "JucatorPeTinta"
            pct6cu11.Image = SkinJucatorPeTinta
        ElseIf P(6, 11) = "JucatorPeTinta" Then
            P(6, 11) = "Nimic"
            pct6cu11.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct6cu12_Click(sender As System.Object, e As System.EventArgs) Handles pct6cu12.MouseDown
        If P(6, 12) = "Nimic" Then
            P(6, 12) = "Perete"
            pct6cu12.Image = SkinPerete
        ElseIf P(6, 12) = "Perete" Then
            P(6, 12) = "Teren"
            pct6cu12.Image = SkinTeren
        ElseIf P(6, 12) = "Teren" Then
            P(6, 12) = "Cutie"
            pct6cu12.Image = SkinCutie
            Cutii += 1
        ElseIf P(6, 12) = "Cutie" Then
            P(6, 12) = "Tinta"
            pct6cu12.Image = SkinTinta
            Cutii -= 1
        ElseIf P(6, 12) = "Tinta" Then
            P(6, 12) = "Rezolvat"
            pct6cu12.Image = SkinRezolvat
        ElseIf P(6, 12) = "Rezolvat" Then
            If Ok Then
                P(6, 12) = "Jucator"
                pct6cu12.Image = SkinJucator
                Ok = False
            Else
                P(6, 12) = "Nimic"
                pct6cu12.Image = SkinNimic
            End If
        ElseIf P(6, 12) = "Jucator" Then
            P(6, 12) = "JucatorPeTinta"
            pct6cu12.Image = SkinJucatorPeTinta
        ElseIf P(6, 12) = "JucatorPeTinta" Then
            P(6, 12) = "Nimic"
            pct6cu12.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct6cu13_Click(sender As System.Object, e As System.EventArgs) Handles pct6cu13.MouseDown
        If P(6, 13) = "Nimic" Then
            P(6, 13) = "Perete"
            pct6cu13.Image = SkinPerete
        ElseIf P(6, 13) = "Perete" Then
            P(6, 13) = "Teren"
            pct6cu13.Image = SkinTeren
        ElseIf P(6, 13) = "Teren" Then
            P(6, 13) = "Cutie"
            pct6cu13.Image = SkinCutie
            Cutii += 1
        ElseIf P(6, 13) = "Cutie" Then
            P(6, 13) = "Tinta"
            pct6cu13.Image = SkinTinta
            Cutii -= 1
        ElseIf P(6, 13) = "Tinta" Then
            P(6, 13) = "Rezolvat"
            pct6cu13.Image = SkinRezolvat
        ElseIf P(6, 13) = "Rezolvat" Then
            If Ok Then
                P(6, 13) = "Jucator"
                pct6cu13.Image = SkinJucator
                Ok = False
            Else
                P(6, 13) = "Nimic"
                pct6cu13.Image = SkinNimic
            End If
        ElseIf P(6, 13) = "Jucator" Then
            P(6, 13) = "JucatorPeTinta"
            pct6cu13.Image = SkinJucatorPeTinta
        ElseIf P(6, 13) = "JucatorPeTinta" Then
            P(6, 13) = "Nimic"
            pct6cu13.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct6cu14_Click(sender As System.Object, e As System.EventArgs) Handles pct6cu14.MouseDown
        If P(6, 14) = "Nimic" Then
            P(6, 14) = "Perete"
            pct6cu14.Image = SkinPerete
        ElseIf P(6, 14) = "Perete" Then
            P(6, 14) = "Teren"
            pct6cu14.Image = SkinTeren
        ElseIf P(6, 14) = "Teren" Then
            P(6, 14) = "Cutie"
            pct6cu14.Image = SkinCutie
            Cutii += 1
        ElseIf P(6, 14) = "Cutie" Then
            P(6, 14) = "Tinta"
            pct6cu14.Image = SkinTinta
            Cutii -= 1
        ElseIf P(6, 14) = "Tinta" Then
            P(6, 14) = "Rezolvat"
            pct6cu14.Image = SkinRezolvat
        ElseIf P(6, 14) = "Rezolvat" Then
            If Ok Then
                P(6, 14) = "Jucator"
                pct6cu14.Image = SkinJucator
                Ok = False
            Else
                P(6, 14) = "Nimic"
                pct6cu14.Image = SkinNimic
            End If
        ElseIf P(6, 14) = "Jucator" Then
            P(6, 14) = "JucatorPeTinta"
            pct6cu14.Image = SkinJucatorPeTinta
        ElseIf P(6, 14) = "JucatorPeTinta" Then
            P(6, 14) = "Nimic"
            pct6cu14.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct7cu1_Click(sender As System.Object, e As System.EventArgs) Handles pct7cu1.MouseDown
        If P(7, 1) = "Nimic" Then
            P(7, 1) = "Perete"
            pct7cu1.Image = SkinPerete
        ElseIf P(7, 1) = "Perete" Then
            P(7, 1) = "Teren"
            pct7cu1.Image = SkinTeren
        ElseIf P(7, 1) = "Teren" Then
            P(7, 1) = "Cutie"
            pct7cu1.Image = SkinCutie
            Cutii += 1
        ElseIf P(7, 1) = "Cutie" Then
            P(7, 1) = "Tinta"
            pct7cu1.Image = SkinTinta
            Cutii -= 1
        ElseIf P(7, 1) = "Tinta" Then
            P(7, 1) = "Rezolvat"
            pct7cu1.Image = SkinRezolvat
        ElseIf P(7, 1) = "Rezolvat" Then
            If Ok Then
                P(7, 1) = "Jucator"
                pct7cu1.Image = SkinJucator
                Ok = False
            Else
                P(7, 1) = "Nimic"
                pct7cu1.Image = SkinNimic
            End If
        ElseIf P(7, 1) = "Jucator" Then
            P(7, 1) = "JucatorPeTinta"
            pct7cu1.Image = SkinJucatorPeTinta
        ElseIf P(7, 1) = "JucatorPeTinta" Then
            P(7, 1) = "Nimic"
            pct7cu1.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct7cu2_Click(sender As System.Object, e As System.EventArgs) Handles pct7cu2.MouseDown
        If P(7, 2) = "Nimic" Then
            P(7, 2) = "Perete"
            pct7cu2.Image = SkinPerete
        ElseIf P(7, 2) = "Perete" Then
            P(7, 2) = "Teren"
            pct7cu2.Image = SkinTeren
        ElseIf P(7, 2) = "Teren" Then
            P(7, 2) = "Cutie"
            pct7cu2.Image = SkinCutie
            Cutii += 1
        ElseIf P(7, 2) = "Cutie" Then
            P(7, 2) = "Tinta"
            pct7cu2.Image = SkinTinta
            Cutii -= 1
        ElseIf P(7, 2) = "Tinta" Then
            P(7, 2) = "Rezolvat"
            pct7cu2.Image = SkinRezolvat
        ElseIf P(7, 2) = "Rezolvat" Then
            If Ok Then
                P(7, 2) = "Jucator"
                pct7cu2.Image = SkinJucator
                Ok = False
            Else
                P(7, 2) = "Nimic"
                pct7cu2.Image = SkinNimic
            End If
        ElseIf P(7, 2) = "Jucator" Then
            P(7, 2) = "JucatorPeTinta"
            pct7cu2.Image = SkinJucatorPeTinta
        ElseIf P(7, 2) = "JucatorPeTinta" Then
            P(7, 2) = "Nimic"
            pct7cu2.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct7cu3_Click(sender As System.Object, e As System.EventArgs) Handles pct7cu3.MouseDown
        If P(7, 3) = "Nimic" Then
            P(7, 3) = "Perete"
            pct7cu3.Image = SkinPerete
        ElseIf P(7, 3) = "Perete" Then
            P(7, 3) = "Teren"
            pct7cu3.Image = SkinTeren
        ElseIf P(7, 3) = "Teren" Then
            P(7, 3) = "Cutie"
            pct7cu3.Image = SkinCutie
            Cutii += 1
        ElseIf P(7, 3) = "Cutie" Then
            P(7, 3) = "Tinta"
            pct7cu3.Image = SkinTinta
            Cutii -= 1
        ElseIf P(7, 3) = "Tinta" Then
            P(7, 3) = "Rezolvat"
            pct7cu3.Image = SkinRezolvat
        ElseIf P(7, 3) = "Rezolvat" Then
            If Ok Then
                P(7, 3) = "Jucator"
                pct7cu3.Image = SkinJucator
                Ok = False
            Else
                P(7, 3) = "Nimic"
                pct7cu3.Image = SkinNimic
            End If
        ElseIf P(7, 3) = "Jucator" Then
            P(7, 3) = "JucatorPeTinta"
            pct7cu3.Image = SkinJucatorPeTinta
        ElseIf P(7, 3) = "JucatorPeTinta" Then
            P(7, 3) = "Nimic"
            pct7cu3.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct7cu4_Click(sender As System.Object, e As System.EventArgs) Handles pct7cu4.MouseDown
        If P(7, 4) = "Nimic" Then
            P(7, 4) = "Perete"
            pct7cu4.Image = SkinPerete
        ElseIf P(7, 4) = "Perete" Then
            P(7, 4) = "Teren"
            pct7cu4.Image = SkinTeren
        ElseIf P(7, 4) = "Teren" Then
            P(7, 4) = "Cutie"
            pct7cu4.Image = SkinCutie
            Cutii += 1
        ElseIf P(7, 4) = "Cutie" Then
            P(7, 4) = "Tinta"
            pct7cu4.Image = SkinTinta
            Cutii -= 1
        ElseIf P(7, 4) = "Tinta" Then
            P(7, 4) = "Rezolvat"
            pct7cu4.Image = SkinRezolvat
        ElseIf P(7, 4) = "Rezolvat" Then
            If Ok Then
                P(7, 4) = "Jucator"
                pct7cu4.Image = SkinJucator
                Ok = False
            Else
                P(7, 4) = "Nimic"
                pct7cu4.Image = SkinNimic
            End If
        ElseIf P(7, 4) = "Jucator" Then
            P(7, 4) = "JucatorPeTinta"
            pct7cu4.Image = SkinJucatorPeTinta
        ElseIf P(7, 4) = "JucatorPeTinta" Then
            P(7, 4) = "Nimic"
            pct7cu4.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct7cu5_Click(sender As System.Object, e As System.EventArgs) Handles pct7cu5.MouseDown
        If P(7, 5) = "Nimic" Then
            P(7, 5) = "Perete"
            pct7cu5.Image = SkinPerete
        ElseIf P(7, 5) = "Perete" Then
            P(7, 5) = "Teren"
            pct7cu5.Image = SkinTeren
        ElseIf P(7, 5) = "Teren" Then
            P(7, 5) = "Cutie"
            pct7cu5.Image = SkinCutie
            Cutii += 1
        ElseIf P(7, 5) = "Cutie" Then
            P(7, 5) = "Tinta"
            pct7cu5.Image = SkinTinta
            Cutii -= 1
        ElseIf P(7, 5) = "Tinta" Then
            P(7, 5) = "Rezolvat"
            pct7cu5.Image = SkinRezolvat
        ElseIf P(7, 5) = "Rezolvat" Then
            If Ok Then
                P(7, 5) = "Jucator"
                pct7cu5.Image = SkinJucator
                Ok = False
            Else
                P(7, 5) = "Nimic"
                pct7cu5.Image = SkinNimic
            End If
        ElseIf P(7, 5) = "Jucator" Then
            P(7, 5) = "JucatorPeTinta"
            pct7cu5.Image = SkinJucatorPeTinta
        ElseIf P(7, 5) = "JucatorPeTinta" Then
            P(7, 5) = "Nimic"
            pct7cu5.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct7cu6_Click(sender As System.Object, e As System.EventArgs) Handles pct7cu6.MouseDown
        If P(7, 6) = "Nimic" Then
            P(7, 6) = "Perete"
            pct7cu6.Image = SkinPerete
        ElseIf P(7, 6) = "Perete" Then
            P(7, 6) = "Teren"
            pct7cu6.Image = SkinTeren
        ElseIf P(7, 6) = "Teren" Then
            P(7, 6) = "Cutie"
            pct7cu6.Image = SkinCutie
            Cutii += 1
        ElseIf P(7, 6) = "Cutie" Then
            P(7, 6) = "Tinta"
            pct7cu6.Image = SkinTinta
            Cutii -= 1
        ElseIf P(7, 6) = "Tinta" Then
            P(7, 6) = "Rezolvat"
            pct7cu6.Image = SkinRezolvat
        ElseIf P(7, 6) = "Rezolvat" Then
            If Ok Then
                P(7, 6) = "Jucator"
                pct7cu6.Image = SkinJucator
                Ok = False
            Else
                P(7, 6) = "Nimic"
                pct7cu6.Image = SkinNimic
            End If
        ElseIf P(7, 6) = "Jucator" Then
            P(7, 6) = "JucatorPeTinta"
            pct7cu6.Image = SkinJucatorPeTinta
        ElseIf P(7, 6) = "JucatorPeTinta" Then
            P(7, 6) = "Nimic"
            pct7cu6.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct7cu7_Click(sender As System.Object, e As System.EventArgs) Handles pct7cu7.MouseDown
        If P(7, 7) = "Nimic" Then
            P(7, 7) = "Perete"
            pct7cu7.Image = SkinPerete
        ElseIf P(7, 7) = "Perete" Then
            P(7, 7) = "Teren"
            pct7cu7.Image = SkinTeren
        ElseIf P(7, 7) = "Teren" Then
            P(7, 7) = "Cutie"
            pct7cu7.Image = SkinCutie
            Cutii += 1
        ElseIf P(7, 7) = "Cutie" Then
            P(7, 7) = "Tinta"
            pct7cu7.Image = SkinTinta
            Cutii -= 1
        ElseIf P(7, 7) = "Tinta" Then
            P(7, 7) = "Rezolvat"
            pct7cu7.Image = SkinRezolvat
        ElseIf P(7, 7) = "Rezolvat" Then
            If Ok Then
                P(7, 7) = "Jucator"
                pct7cu7.Image = SkinJucator
                Ok = False
            Else
                P(7, 7) = "Nimic"
                pct7cu7.Image = SkinNimic
            End If
        ElseIf P(7, 7) = "Jucator" Then
            P(7, 7) = "JucatorPeTinta"
            pct7cu7.Image = SkinJucatorPeTinta
        ElseIf P(7, 7) = "JucatorPeTinta" Then
            P(7, 7) = "Nimic"
            pct7cu7.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct7cu8_Click(sender As System.Object, e As System.EventArgs) Handles pct7cu8.MouseDown
        If P(7, 8) = "Nimic" Then
            P(7, 8) = "Perete"
            pct7cu8.Image = SkinPerete
        ElseIf P(7, 8) = "Perete" Then
            P(7, 8) = "Teren"
            pct7cu8.Image = SkinTeren
        ElseIf P(7, 8) = "Teren" Then
            P(7, 8) = "Cutie"
            pct7cu8.Image = SkinCutie
            Cutii += 1
        ElseIf P(7, 8) = "Cutie" Then
            P(7, 8) = "Tinta"
            pct7cu8.Image = SkinTinta
            Cutii -= 1
        ElseIf P(7, 8) = "Tinta" Then
            P(7, 8) = "Rezolvat"
            pct7cu8.Image = SkinRezolvat
        ElseIf P(7, 8) = "Rezolvat" Then
            If Ok Then
                P(7, 8) = "Jucator"
                pct7cu8.Image = SkinJucator
                Ok = False
            Else
                P(7, 8) = "Nimic"
                pct7cu8.Image = SkinNimic
            End If
        ElseIf P(7, 8) = "Jucator" Then
            P(7, 8) = "JucatorPeTinta"
            pct7cu8.Image = SkinJucatorPeTinta
        ElseIf P(7, 8) = "JucatorPeTinta" Then
            P(7, 8) = "Nimic"
            pct7cu8.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct7cu9_Click(sender As System.Object, e As System.EventArgs) Handles pct7cu9.MouseDown
        If P(7, 9) = "Nimic" Then
            P(7, 9) = "Perete"
            pct7cu9.Image = SkinPerete
        ElseIf P(7, 9) = "Perete" Then
            P(7, 9) = "Teren"
            pct7cu9.Image = SkinTeren
        ElseIf P(7, 9) = "Teren" Then
            P(7, 9) = "Cutie"
            pct7cu9.Image = SkinCutie
            Cutii += 1
        ElseIf P(7, 9) = "Cutie" Then
            P(7, 9) = "Tinta"
            pct7cu9.Image = SkinTinta
            Cutii -= 1
        ElseIf P(7, 9) = "Tinta" Then
            P(7, 9) = "Rezolvat"
            pct7cu9.Image = SkinRezolvat
        ElseIf P(7, 9) = "Rezolvat" Then
            If Ok Then
                P(7, 9) = "Jucator"
                pct7cu9.Image = SkinJucator
                Ok = False
            Else
                P(7, 9) = "Nimic"
                pct7cu9.Image = SkinNimic
            End If
        ElseIf P(7, 9) = "Jucator" Then
            P(7, 9) = "JucatorPeTinta"
            pct7cu9.Image = SkinJucatorPeTinta
        ElseIf P(7, 9) = "JucatorPeTinta" Then
            P(7, 9) = "Nimic"
            pct7cu9.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct7cu10_Click(sender As System.Object, e As System.EventArgs) Handles pct7cu10.MouseDown
        If P(7, 10) = "Nimic" Then
            P(7, 10) = "Perete"
            pct7cu10.Image = SkinPerete
        ElseIf P(7, 10) = "Perete" Then
            P(7, 10) = "Teren"
            pct7cu10.Image = SkinTeren
        ElseIf P(7, 10) = "Teren" Then
            P(7, 10) = "Cutie"
            pct7cu10.Image = SkinCutie
            Cutii += 1
        ElseIf P(7, 10) = "Cutie" Then
            P(7, 10) = "Tinta"
            pct7cu10.Image = SkinTinta
            Cutii -= 1
        ElseIf P(7, 10) = "Tinta" Then
            P(7, 10) = "Rezolvat"
            pct7cu10.Image = SkinRezolvat
        ElseIf P(7, 10) = "Rezolvat" Then
            If Ok Then
                P(7, 10) = "Jucator"
                pct7cu10.Image = SkinJucator
                Ok = False
            Else
                P(7, 10) = "Nimic"
                pct7cu10.Image = SkinNimic
            End If
        ElseIf P(7, 10) = "Jucator" Then
            P(7, 10) = "JucatorPeTinta"
            pct7cu10.Image = SkinJucatorPeTinta
        ElseIf P(7, 10) = "JucatorPeTinta" Then
            P(7, 10) = "Nimic"
            pct7cu10.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct7cu11_Click(sender As System.Object, e As System.EventArgs) Handles pct7cu11.MouseDown
        If P(7, 11) = "Nimic" Then
            P(7, 11) = "Perete"
            pct7cu11.Image = SkinPerete
        ElseIf P(7, 11) = "Perete" Then
            P(7, 11) = "Teren"
            pct7cu11.Image = SkinTeren
        ElseIf P(7, 11) = "Teren" Then
            P(7, 11) = "Cutie"
            pct7cu11.Image = SkinCutie
            Cutii += 1
        ElseIf P(7, 11) = "Cutie" Then
            P(7, 11) = "Tinta"
            pct7cu11.Image = SkinTinta
            Cutii -= 1
        ElseIf P(7, 11) = "Tinta" Then
            P(7, 11) = "Rezolvat"
            pct7cu11.Image = SkinRezolvat
        ElseIf P(7, 11) = "Rezolvat" Then
            If Ok Then
                P(7, 11) = "Jucator"
                pct7cu11.Image = SkinJucator
                Ok = False
            Else
                P(7, 11) = "Nimic"
                pct7cu11.Image = SkinNimic
            End If
        ElseIf P(7, 11) = "Jucator" Then
            P(7, 11) = "JucatorPeTinta"
            pct7cu11.Image = SkinJucatorPeTinta
        ElseIf P(7, 11) = "JucatorPeTinta" Then
            P(7, 11) = "Nimic"
            pct7cu11.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct7cu12_Click(sender As System.Object, e As System.EventArgs) Handles pct7cu12.MouseDown
        If P(7, 12) = "Nimic" Then
            P(7, 12) = "Perete"
            pct7cu12.Image = SkinPerete
        ElseIf P(7, 12) = "Perete" Then
            P(7, 12) = "Teren"
            pct7cu12.Image = SkinTeren
        ElseIf P(7, 12) = "Teren" Then
            P(7, 12) = "Cutie"
            pct7cu12.Image = SkinCutie
            Cutii += 1
        ElseIf P(7, 12) = "Cutie" Then
            P(7, 12) = "Tinta"
            pct7cu12.Image = SkinTinta
            Cutii -= 1
        ElseIf P(7, 12) = "Tinta" Then
            P(7, 12) = "Rezolvat"
            pct7cu12.Image = SkinRezolvat
        ElseIf P(7, 12) = "Rezolvat" Then
            If Ok Then
                P(7, 12) = "Jucator"
                pct7cu12.Image = SkinJucator
                Ok = False
            Else
                P(7, 12) = "Nimic"
                pct7cu12.Image = SkinNimic
            End If
        ElseIf P(7, 12) = "Jucator" Then
            P(7, 12) = "JucatorPeTinta"
            pct7cu12.Image = SkinJucatorPeTinta
        ElseIf P(7, 12) = "JucatorPeTinta" Then
            P(7, 12) = "Nimic"
            pct7cu12.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct7cu13_Click(sender As System.Object, e As System.EventArgs) Handles pct7cu13.MouseDown
        If P(7, 13) = "Nimic" Then
            P(7, 13) = "Perete"
            pct7cu13.Image = SkinPerete
        ElseIf P(7, 13) = "Perete" Then
            P(7, 13) = "Teren"
            pct7cu13.Image = SkinTeren
        ElseIf P(7, 13) = "Teren" Then
            P(7, 13) = "Cutie"
            pct7cu13.Image = SkinCutie
            Cutii += 1
        ElseIf P(7, 13) = "Cutie" Then
            P(7, 13) = "Tinta"
            pct7cu13.Image = SkinTinta
            Cutii -= 1
        ElseIf P(7, 13) = "Tinta" Then
            P(7, 13) = "Rezolvat"
            pct7cu13.Image = SkinRezolvat
        ElseIf P(7, 13) = "Rezolvat" Then
            If Ok Then
                P(7, 13) = "Jucator"
                pct7cu13.Image = SkinJucator
                Ok = False
            Else
                P(7, 13) = "Nimic"
                pct7cu13.Image = SkinNimic
            End If
        ElseIf P(7, 13) = "Jucator" Then
            P(7, 13) = "JucatorPeTinta"
            pct7cu13.Image = SkinJucatorPeTinta
        ElseIf P(7, 13) = "JucatorPeTinta" Then
            P(7, 13) = "Nimic"
            pct7cu13.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct7cu14_Click(sender As System.Object, e As System.EventArgs) Handles pct7cu14.MouseDown
        If P(7, 14) = "Nimic" Then
            P(7, 14) = "Perete"
            pct7cu14.Image = SkinPerete
        ElseIf P(7, 14) = "Perete" Then
            P(7, 14) = "Teren"
            pct7cu14.Image = SkinTeren
        ElseIf P(7, 14) = "Teren" Then
            P(7, 14) = "Cutie"
            pct7cu14.Image = SkinCutie
            Cutii += 1
        ElseIf P(7, 14) = "Cutie" Then
            P(7, 14) = "Tinta"
            pct7cu14.Image = SkinTinta
            Cutii -= 1
        ElseIf P(7, 14) = "Tinta" Then
            P(7, 14) = "Rezolvat"
            pct7cu14.Image = SkinRezolvat
        ElseIf P(7, 14) = "Rezolvat" Then
            If Ok Then
                P(7, 14) = "Jucator"
                pct7cu14.Image = SkinJucator
                Ok = False
            Else
                P(7, 14) = "Nimic"
                pct7cu14.Image = SkinNimic
            End If
        ElseIf P(7, 14) = "Jucator" Then
            P(7, 14) = "JucatorPeTinta"
            pct7cu14.Image = SkinJucatorPeTinta
        ElseIf P(7, 14) = "JucatorPeTinta" Then
            P(7, 14) = "Nimic"
            pct7cu14.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct8cu1_Click(sender As System.Object, e As System.EventArgs) Handles pct8cu1.MouseDown
        If P(8, 1) = "Nimic" Then
            P(8, 1) = "Perete"
            pct8cu1.Image = SkinPerete
        ElseIf P(8, 1) = "Perete" Then
            P(8, 1) = "Teren"
            pct8cu1.Image = SkinTeren
        ElseIf P(8, 1) = "Teren" Then
            P(8, 1) = "Cutie"
            pct8cu1.Image = SkinCutie
            Cutii += 1
        ElseIf P(8, 1) = "Cutie" Then
            P(8, 1) = "Tinta"
            pct8cu1.Image = SkinTinta
            Cutii -= 1
        ElseIf P(8, 1) = "Tinta" Then
            P(8, 1) = "Rezolvat"
            pct8cu1.Image = SkinRezolvat
        ElseIf P(8, 1) = "Rezolvat" Then
            If Ok Then
                P(8, 1) = "Jucator"
                pct8cu1.Image = SkinJucator
                Ok = False
            Else
                P(8, 1) = "Nimic"
                pct8cu1.Image = SkinNimic
            End If
        ElseIf P(8, 1) = "Jucator" Then
            P(8, 1) = "JucatorPeTinta"
            pct8cu1.Image = SkinJucatorPeTinta
        ElseIf P(8, 1) = "JucatorPeTinta" Then
            P(8, 1) = "Nimic"
            pct8cu1.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct8cu2_Click(sender As System.Object, e As System.EventArgs) Handles pct8cu2.MouseDown
        If P(8, 2) = "Nimic" Then
            P(8, 2) = "Perete"
            pct8cu2.Image = SkinPerete
        ElseIf P(8, 2) = "Perete" Then
            P(8, 2) = "Teren"
            pct8cu2.Image = SkinTeren
        ElseIf P(8, 2) = "Teren" Then
            P(8, 2) = "Cutie"
            pct8cu2.Image = SkinCutie
            Cutii += 1
        ElseIf P(8, 2) = "Cutie" Then
            P(8, 2) = "Tinta"
            pct8cu2.Image = SkinTinta
            Cutii -= 1
        ElseIf P(8, 2) = "Tinta" Then
            P(8, 2) = "Rezolvat"
            pct8cu2.Image = SkinRezolvat
        ElseIf P(8, 2) = "Rezolvat" Then
            If Ok Then
                P(8, 2) = "Jucator"
                pct8cu2.Image = SkinJucator
                Ok = False
            Else
                P(8, 2) = "Nimic"
                pct8cu2.Image = SkinNimic
            End If
        ElseIf P(8, 2) = "Jucator" Then
            P(8, 2) = "JucatorPeTinta"
            pct8cu2.Image = SkinJucatorPeTinta
        ElseIf P(8, 2) = "JucatorPeTinta" Then
            P(8, 2) = "Nimic"
            pct8cu2.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct8cu3_Click(sender As System.Object, e As System.EventArgs) Handles pct8cu3.MouseDown
        If P(8, 3) = "Nimic" Then
            P(8, 3) = "Perete"
            pct8cu3.Image = SkinPerete
        ElseIf P(8, 3) = "Perete" Then
            P(8, 3) = "Teren"
            pct8cu3.Image = SkinTeren
        ElseIf P(8, 3) = "Teren" Then
            P(8, 3) = "Cutie"
            pct8cu3.Image = SkinCutie
            Cutii += 1
        ElseIf P(8, 3) = "Cutie" Then
            P(8, 3) = "Tinta"
            pct8cu3.Image = SkinTinta
            Cutii -= 1
        ElseIf P(8, 3) = "Tinta" Then
            P(8, 3) = "Rezolvat"
            pct8cu3.Image = SkinRezolvat
        ElseIf P(8, 3) = "Rezolvat" Then
            If Ok Then
                P(8, 3) = "Jucator"
                pct8cu3.Image = SkinJucator
                Ok = False
            Else
                P(8, 3) = "Nimic"
                pct8cu3.Image = SkinNimic
            End If
        ElseIf P(8, 3) = "Jucator" Then
            P(8, 3) = "JucatorPeTinta"
            pct8cu3.Image = SkinJucatorPeTinta
        ElseIf P(8, 3) = "JucatorPeTinta" Then
            P(8, 3) = "Nimic"
            pct8cu3.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct8cu4_Click(sender As System.Object, e As System.EventArgs) Handles pct8cu4.MouseDown
        If P(8, 4) = "Nimic" Then
            P(8, 4) = "Perete"
            pct8cu4.Image = SkinPerete
        ElseIf P(8, 4) = "Perete" Then
            P(8, 4) = "Teren"
            pct8cu4.Image = SkinTeren
        ElseIf P(8, 4) = "Teren" Then
            P(8, 4) = "Cutie"
            pct8cu4.Image = SkinCutie
            Cutii += 1
        ElseIf P(8, 4) = "Cutie" Then
            P(8, 4) = "Tinta"
            pct8cu4.Image = SkinTinta
            Cutii -= 1
        ElseIf P(8, 4) = "Tinta" Then
            P(8, 4) = "Rezolvat"
            pct8cu4.Image = SkinRezolvat
        ElseIf P(8, 4) = "Rezolvat" Then
            If Ok Then
                P(8, 4) = "Jucator"
                pct8cu4.Image = SkinJucator
                Ok = False
            Else
                P(8, 4) = "Nimic"
                pct8cu4.Image = SkinNimic
            End If
        ElseIf P(8, 4) = "Jucator" Then
            P(8, 4) = "JucatorPeTinta"
            pct8cu4.Image = SkinJucatorPeTinta
        ElseIf P(8, 4) = "JucatorPeTinta" Then
            P(8, 4) = "Nimic"
            pct8cu4.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct8cu5_Click(sender As System.Object, e As System.EventArgs) Handles pct8cu5.MouseDown
        If P(8, 5) = "Nimic" Then
            P(8, 5) = "Perete"
            pct8cu5.Image = SkinPerete
        ElseIf P(8, 5) = "Perete" Then
            P(8, 5) = "Teren"
            pct8cu5.Image = SkinTeren
        ElseIf P(8, 5) = "Teren" Then
            P(8, 5) = "Cutie"
            pct8cu5.Image = SkinCutie
            Cutii += 1
        ElseIf P(8, 5) = "Cutie" Then
            P(8, 5) = "Tinta"
            pct8cu5.Image = SkinTinta
            Cutii -= 1
        ElseIf P(8, 5) = "Tinta" Then
            P(8, 5) = "Rezolvat"
            pct8cu5.Image = SkinRezolvat
        ElseIf P(8, 5) = "Rezolvat" Then
            If Ok Then
                P(8, 5) = "Jucator"
                pct8cu5.Image = SkinJucator
                Ok = False
            Else
                P(8, 5) = "Nimic"
                pct8cu5.Image = SkinNimic
            End If
        ElseIf P(8, 5) = "Jucator" Then
            P(8, 5) = "JucatorPeTinta"
            pct8cu5.Image = SkinJucatorPeTinta
        ElseIf P(8, 5) = "JucatorPeTinta" Then
            P(8, 5) = "Nimic"
            pct8cu5.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct8cu6_Click(sender As System.Object, e As System.EventArgs) Handles pct8cu6.MouseDown
        If P(8, 6) = "Nimic" Then
            P(8, 6) = "Perete"
            pct8cu6.Image = SkinPerete
        ElseIf P(8, 6) = "Perete" Then
            P(8, 6) = "Teren"
            pct8cu6.Image = SkinTeren
        ElseIf P(8, 6) = "Teren" Then
            P(8, 6) = "Cutie"
            pct8cu6.Image = SkinCutie
            Cutii += 1
        ElseIf P(8, 6) = "Cutie" Then
            P(8, 6) = "Tinta"
            pct8cu6.Image = SkinTinta
            Cutii -= 1
        ElseIf P(8, 6) = "Tinta" Then
            P(8, 6) = "Rezolvat"
            pct8cu6.Image = SkinRezolvat
        ElseIf P(8, 6) = "Rezolvat" Then
            If Ok Then
                P(8, 6) = "Jucator"
                pct8cu6.Image = SkinJucator
                Ok = False
            Else
                P(8, 6) = "Nimic"
                pct8cu6.Image = SkinNimic
            End If
        ElseIf P(8, 6) = "Jucator" Then
            P(8, 6) = "JucatorPeTinta"
            pct8cu6.Image = SkinJucatorPeTinta
        ElseIf P(8, 6) = "JucatorPeTinta" Then
            P(8, 6) = "Nimic"
            pct8cu6.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct8cu7_Click(sender As System.Object, e As System.EventArgs) Handles pct8cu7.MouseDown
        If P(8, 7) = "Nimic" Then
            P(8, 7) = "Perete"
            pct8cu7.Image = SkinPerete
        ElseIf P(8, 7) = "Perete" Then
            P(8, 7) = "Teren"
            pct8cu7.Image = SkinTeren
        ElseIf P(8, 7) = "Teren" Then
            P(8, 7) = "Cutie"
            pct8cu7.Image = SkinCutie
            Cutii += 1
        ElseIf P(8, 7) = "Cutie" Then
            P(8, 7) = "Tinta"
            pct8cu7.Image = SkinTinta
            Cutii -= 1
        ElseIf P(8, 7) = "Tinta" Then
            P(8, 7) = "Rezolvat"
            pct8cu7.Image = SkinRezolvat
        ElseIf P(8, 7) = "Rezolvat" Then
            If Ok Then
                P(8, 7) = "Jucator"
                pct8cu7.Image = SkinJucator
                Ok = False
            Else
                P(8, 7) = "Nimic"
                pct8cu7.Image = SkinNimic
            End If
        ElseIf P(8, 7) = "Jucator" Then
            P(8, 7) = "JucatorPeTinta"
            pct8cu7.Image = SkinJucatorPeTinta
        ElseIf P(8, 7) = "JucatorPeTinta" Then
            P(8, 7) = "Nimic"
            pct8cu7.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct8cu8_Click(sender As System.Object, e As System.EventArgs) Handles pct8cu8.MouseDown
        If P(8, 8) = "Nimic" Then
            P(8, 8) = "Perete"
            pct8cu8.Image = SkinPerete
        ElseIf P(8, 8) = "Perete" Then
            P(8, 8) = "Teren"
            pct8cu8.Image = SkinTeren
        ElseIf P(8, 8) = "Teren" Then
            P(8, 8) = "Cutie"
            pct8cu8.Image = SkinCutie
            Cutii += 1
        ElseIf P(8, 8) = "Cutie" Then
            P(8, 8) = "Tinta"
            pct8cu8.Image = SkinTinta
            Cutii -= 1
        ElseIf P(8, 8) = "Tinta" Then
            P(8, 8) = "Rezolvat"
            pct8cu8.Image = SkinRezolvat
        ElseIf P(8, 8) = "Rezolvat" Then
            If Ok Then
                P(8, 8) = "Jucator"
                pct8cu8.Image = SkinJucator
                Ok = False
            Else
                P(8, 8) = "Nimic"
                pct8cu8.Image = SkinNimic
            End If
        ElseIf P(8, 8) = "Jucator" Then
            P(8, 8) = "JucatorPeTinta"
            pct8cu8.Image = SkinJucatorPeTinta
        ElseIf P(8, 8) = "JucatorPeTinta" Then
            P(8, 8) = "Nimic"
            pct8cu8.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct8cu9_Click(sender As System.Object, e As System.EventArgs) Handles pct8cu9.MouseDown
        If P(8, 9) = "Nimic" Then
            P(8, 9) = "Perete"
            pct8cu9.Image = SkinPerete
        ElseIf P(8, 9) = "Perete" Then
            P(8, 9) = "Teren"
            pct8cu9.Image = SkinTeren
        ElseIf P(8, 9) = "Teren" Then
            P(8, 9) = "Cutie"
            pct8cu9.Image = SkinCutie
            Cutii += 1
        ElseIf P(8, 9) = "Cutie" Then
            P(8, 9) = "Tinta"
            pct8cu9.Image = SkinTinta
            Cutii -= 1
        ElseIf P(8, 9) = "Tinta" Then
            P(8, 9) = "Rezolvat"
            pct8cu9.Image = SkinRezolvat
        ElseIf P(8, 9) = "Rezolvat" Then
            If Ok Then
                P(8, 9) = "Jucator"
                pct8cu9.Image = SkinJucator
                Ok = False
            Else
                P(8, 9) = "Nimic"
                pct8cu9.Image = SkinNimic
            End If
        ElseIf P(8, 9) = "Jucator" Then
            P(8, 9) = "JucatorPeTinta"
            pct8cu9.Image = SkinJucatorPeTinta
        ElseIf P(8, 9) = "JucatorPeTinta" Then
            P(8, 9) = "Nimic"
            pct8cu9.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct8cu10_Click(sender As System.Object, e As System.EventArgs) Handles pct8cu10.MouseDown
        If P(8, 10) = "Nimic" Then
            P(8, 10) = "Perete"
            pct8cu10.Image = SkinPerete
        ElseIf P(8, 10) = "Perete" Then
            P(8, 10) = "Teren"
            pct8cu10.Image = SkinTeren
        ElseIf P(8, 10) = "Teren" Then
            P(8, 10) = "Cutie"
            pct8cu10.Image = SkinCutie
            Cutii += 1
        ElseIf P(8, 10) = "Cutie" Then
            P(8, 10) = "Tinta"
            pct8cu10.Image = SkinTinta
            Cutii -= 1
        ElseIf P(8, 10) = "Tinta" Then
            P(8, 10) = "Rezolvat"
            pct8cu10.Image = SkinRezolvat
        ElseIf P(8, 10) = "Rezolvat" Then
            If Ok Then
                P(8, 10) = "Jucator"
                pct8cu10.Image = SkinJucator
                Ok = False
            Else
                P(8, 10) = "Nimic"
                pct8cu10.Image = SkinNimic
            End If
        ElseIf P(8, 10) = "Jucator" Then
            P(8, 10) = "JucatorPeTinta"
            pct8cu10.Image = SkinJucatorPeTinta
        ElseIf P(8, 10) = "JucatorPeTinta" Then
            P(8, 10) = "Nimic"
            pct8cu10.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct8cu11_Click(sender As System.Object, e As System.EventArgs) Handles pct8cu11.MouseDown
        If P(8, 11) = "Nimic" Then
            P(8, 11) = "Perete"
            pct8cu11.Image = SkinPerete
        ElseIf P(8, 11) = "Perete" Then
            P(8, 11) = "Teren"
            pct8cu11.Image = SkinTeren
        ElseIf P(8, 11) = "Teren" Then
            P(8, 11) = "Cutie"
            pct8cu11.Image = SkinCutie
            Cutii += 1
        ElseIf P(8, 11) = "Cutie" Then
            P(8, 11) = "Tinta"
            pct8cu11.Image = SkinTinta
            Cutii -= 1
        ElseIf P(8, 11) = "Tinta" Then
            P(8, 11) = "Rezolvat"
            pct8cu11.Image = SkinRezolvat
        ElseIf P(8, 11) = "Rezolvat" Then
            If Ok Then
                P(8, 11) = "Jucator"
                pct8cu11.Image = SkinJucator
                Ok = False
            Else
                P(8, 11) = "Nimic"
                pct8cu11.Image = SkinNimic
            End If
        ElseIf P(8, 11) = "Jucator" Then
            P(8, 11) = "JucatorPeTinta"
            pct8cu11.Image = SkinJucatorPeTinta
        ElseIf P(8, 11) = "JucatorPeTinta" Then
            P(8, 11) = "Nimic"
            pct8cu11.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct8cu12_Click(sender As System.Object, e As System.EventArgs) Handles pct8cu12.MouseDown
        If P(8, 12) = "Nimic" Then
            P(8, 12) = "Perete"
            pct8cu12.Image = SkinPerete
        ElseIf P(8, 12) = "Perete" Then
            P(8, 12) = "Teren"
            pct8cu12.Image = SkinTeren
        ElseIf P(8, 12) = "Teren" Then
            P(8, 12) = "Cutie"
            pct8cu12.Image = SkinCutie
            Cutii += 1
        ElseIf P(8, 12) = "Cutie" Then
            P(8, 12) = "Tinta"
            pct8cu12.Image = SkinTinta
            Cutii -= 1
        ElseIf P(8, 12) = "Tinta" Then
            P(8, 12) = "Rezolvat"
            pct8cu12.Image = SkinRezolvat
        ElseIf P(8, 12) = "Rezolvat" Then
            If Ok Then
                P(8, 12) = "Jucator"
                pct8cu12.Image = SkinJucator
                Ok = False
            Else
                P(8, 12) = "Nimic"
                pct8cu12.Image = SkinNimic
            End If
        ElseIf P(8, 12) = "Jucator" Then
            P(8, 12) = "JucatorPeTinta"
            pct8cu12.Image = SkinJucatorPeTinta
        ElseIf P(8, 12) = "JucatorPeTinta" Then
            P(8, 12) = "Nimic"
            pct8cu12.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct8cu13_Click(sender As System.Object, e As System.EventArgs) Handles pct8cu13.MouseDown
        If P(8, 13) = "Nimic" Then
            P(8, 13) = "Perete"
            pct8cu13.Image = SkinPerete
        ElseIf P(8, 13) = "Perete" Then
            P(8, 13) = "Teren"
            pct8cu13.Image = SkinTeren
        ElseIf P(8, 13) = "Teren" Then
            P(8, 13) = "Cutie"
            pct8cu13.Image = SkinCutie
            Cutii += 1
        ElseIf P(8, 13) = "Cutie" Then
            P(8, 13) = "Tinta"
            pct8cu13.Image = SkinTinta
            Cutii -= 1
        ElseIf P(8, 13) = "Tinta" Then
            P(8, 13) = "Rezolvat"
            pct8cu13.Image = SkinRezolvat
        ElseIf P(8, 13) = "Rezolvat" Then
            If Ok Then
                P(8, 13) = "Jucator"
                pct8cu13.Image = SkinJucator
                Ok = False
            Else
                P(8, 13) = "Nimic"
                pct8cu13.Image = SkinNimic
            End If
        ElseIf P(8, 13) = "Jucator" Then
            P(8, 13) = "JucatorPeTinta"
            pct8cu13.Image = SkinJucatorPeTinta
        ElseIf P(8, 13) = "JucatorPeTinta" Then
            P(8, 13) = "Nimic"
            pct8cu13.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct8cu14_Click(sender As System.Object, e As System.EventArgs) Handles pct8cu14.MouseDown
        If P(8, 14) = "Nimic" Then
            P(8, 14) = "Perete"
            pct8cu14.Image = SkinPerete
        ElseIf P(8, 14) = "Perete" Then
            P(8, 14) = "Teren"
            pct8cu14.Image = SkinTeren
        ElseIf P(8, 14) = "Teren" Then
            P(8, 14) = "Cutie"
            pct8cu14.Image = SkinCutie
            Cutii += 1
        ElseIf P(8, 14) = "Cutie" Then
            P(8, 14) = "Tinta"
            pct8cu14.Image = SkinTinta
            Cutii -= 1
        ElseIf P(8, 14) = "Tinta" Then
            P(8, 14) = "Rezolvat"
            pct8cu14.Image = SkinRezolvat
        ElseIf P(8, 14) = "Rezolvat" Then
            If Ok Then
                P(8, 14) = "Jucator"
                pct8cu14.Image = SkinJucator
                Ok = False
            Else
                P(8, 14) = "Nimic"
                pct8cu14.Image = SkinNimic
            End If
        ElseIf P(8, 14) = "Jucator" Then
            P(8, 14) = "JucatorPeTinta"
            pct8cu14.Image = SkinJucatorPeTinta
        ElseIf P(8, 14) = "JucatorPeTinta" Then
            P(8, 14) = "Nimic"
            pct8cu14.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct9cu1_Click(sender As System.Object, e As System.EventArgs) Handles pct9cu1.MouseDown
        If P(9, 1) = "Nimic" Then
            P(9, 1) = "Perete"
            pct9cu1.Image = SkinPerete
        ElseIf P(9, 1) = "Perete" Then
            P(9, 1) = "Teren"
            pct9cu1.Image = SkinTeren
        ElseIf P(9, 1) = "Teren" Then
            P(9, 1) = "Cutie"
            pct9cu1.Image = SkinCutie
            Cutii += 1
        ElseIf P(9, 1) = "Cutie" Then
            P(9, 1) = "Tinta"
            pct9cu1.Image = SkinTinta
            Cutii -= 1
        ElseIf P(9, 1) = "Tinta" Then
            P(9, 1) = "Rezolvat"
            pct9cu1.Image = SkinRezolvat
        ElseIf P(9, 1) = "Rezolvat" Then
            If Ok Then
                P(9, 1) = "Jucator"
                pct9cu1.Image = SkinJucator
                Ok = False
            Else
                P(9, 1) = "Nimic"
                pct9cu1.Image = SkinNimic
            End If
        ElseIf P(9, 1) = "Jucator" Then
            P(9, 1) = "JucatorPeTinta"
            pct9cu1.Image = SkinJucatorPeTinta
        ElseIf P(9, 1) = "JucatorPeTinta" Then
            P(9, 1) = "Nimic"
            pct9cu1.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct9cu2_Click(sender As System.Object, e As System.EventArgs) Handles pct9cu2.MouseDown
        If P(9, 2) = "Nimic" Then
            P(9, 2) = "Perete"
            pct9cu2.Image = SkinPerete
        ElseIf P(9, 2) = "Perete" Then
            P(9, 2) = "Teren"
            pct9cu2.Image = SkinTeren
        ElseIf P(9, 2) = "Teren" Then
            P(9, 2) = "Cutie"
            pct9cu2.Image = SkinCutie
            Cutii += 1
        ElseIf P(9, 2) = "Cutie" Then
            P(9, 2) = "Tinta"
            pct9cu2.Image = SkinTinta
            Cutii -= 1
        ElseIf P(9, 2) = "Tinta" Then
            P(9, 2) = "Rezolvat"
            pct9cu2.Image = SkinRezolvat
        ElseIf P(9, 2) = "Rezolvat" Then
            If Ok Then
                P(9, 2) = "Jucator"
                pct9cu2.Image = SkinJucator
                Ok = False
            Else
                P(9, 2) = "Nimic"
                pct9cu2.Image = SkinNimic
            End If
        ElseIf P(9, 2) = "Jucator" Then
            P(9, 2) = "JucatorPeTinta"
            pct9cu2.Image = SkinJucatorPeTinta
        ElseIf P(9, 2) = "JucatorPeTinta" Then
            P(9, 2) = "Nimic"
            pct9cu2.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct9cu3_Click(sender As System.Object, e As System.EventArgs) Handles pct9cu3.MouseDown
        If P(9, 3) = "Nimic" Then
            P(9, 3) = "Perete"
            pct9cu3.Image = SkinPerete
        ElseIf P(9, 3) = "Perete" Then
            P(9, 3) = "Teren"
            pct9cu3.Image = SkinTeren
        ElseIf P(9, 3) = "Teren" Then
            P(9, 3) = "Cutie"
            pct9cu3.Image = SkinCutie
            Cutii += 1
        ElseIf P(9, 3) = "Cutie" Then
            P(9, 3) = "Tinta"
            pct9cu3.Image = SkinTinta
            Cutii -= 1
        ElseIf P(9, 3) = "Tinta" Then
            P(9, 3) = "Rezolvat"
            pct9cu3.Image = SkinRezolvat
        ElseIf P(9, 3) = "Rezolvat" Then
            If Ok Then
                P(9, 3) = "Jucator"
                pct9cu3.Image = SkinJucator
                Ok = False
            Else
                P(9, 3) = "Nimic"
                pct9cu3.Image = SkinNimic
            End If
        ElseIf P(9, 3) = "Jucator" Then
            P(9, 3) = "JucatorPeTinta"
            pct9cu3.Image = SkinJucatorPeTinta
        ElseIf P(9, 3) = "JucatorPeTinta" Then
            P(9, 3) = "Nimic"
            pct9cu3.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct9cu4_Click(sender As System.Object, e As System.EventArgs) Handles pct9cu4.MouseDown
        If P(9, 4) = "Nimic" Then
            P(9, 4) = "Perete"
            pct9cu4.Image = SkinPerete
        ElseIf P(9, 4) = "Perete" Then
            P(9, 4) = "Teren"
            pct9cu4.Image = SkinTeren
        ElseIf P(9, 4) = "Teren" Then
            P(9, 4) = "Cutie"
            pct9cu4.Image = SkinCutie
            Cutii += 1
        ElseIf P(9, 4) = "Cutie" Then
            P(9, 4) = "Tinta"
            pct9cu4.Image = SkinTinta
            Cutii -= 1
        ElseIf P(9, 4) = "Tinta" Then
            P(9, 4) = "Rezolvat"
            pct9cu4.Image = SkinRezolvat
        ElseIf P(9, 4) = "Rezolvat" Then
            If Ok Then
                P(9, 4) = "Jucator"
                pct9cu4.Image = SkinJucator
                Ok = False
            Else
                P(9, 4) = "Nimic"
                pct9cu4.Image = SkinNimic
            End If
        ElseIf P(9, 4) = "Jucator" Then
            P(9, 4) = "JucatorPeTinta"
            pct9cu4.Image = SkinJucatorPeTinta
        ElseIf P(9, 4) = "JucatorPeTinta" Then
            P(9, 4) = "Nimic"
            pct9cu4.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct9cu5_Click(sender As System.Object, e As System.EventArgs) Handles pct9cu5.MouseDown
        If P(9, 5) = "Nimic" Then
            P(9, 5) = "Perete"
            pct9cu5.Image = SkinPerete
        ElseIf P(9, 5) = "Perete" Then
            P(9, 5) = "Teren"
            pct9cu5.Image = SkinTeren
        ElseIf P(9, 5) = "Teren" Then
            P(9, 5) = "Cutie"
            pct9cu5.Image = SkinCutie
            Cutii += 1
        ElseIf P(9, 5) = "Cutie" Then
            P(9, 5) = "Tinta"
            pct9cu5.Image = SkinTinta
            Cutii -= 1
        ElseIf P(9, 5) = "Tinta" Then
            P(9, 5) = "Rezolvat"
            pct9cu5.Image = SkinRezolvat
        ElseIf P(9, 5) = "Rezolvat" Then
            If Ok Then
                P(9, 5) = "Jucator"
                pct9cu5.Image = SkinJucator
                Ok = False
            Else
                P(9, 5) = "Nimic"
                pct9cu5.Image = SkinNimic
            End If
        ElseIf P(9, 5) = "Jucator" Then
            P(9, 5) = "JucatorPeTinta"
            pct9cu5.Image = SkinJucatorPeTinta
        ElseIf P(9, 5) = "JucatorPeTinta" Then
            P(9, 5) = "Nimic"
            pct9cu5.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct9cu6_Click(sender As System.Object, e As System.EventArgs) Handles pct9cu6.MouseDown
        If P(9, 6) = "Nimic" Then
            P(9, 6) = "Perete"
            pct9cu6.Image = SkinPerete
        ElseIf P(9, 6) = "Perete" Then
            P(9, 6) = "Teren"
            pct9cu6.Image = SkinTeren
        ElseIf P(9, 6) = "Teren" Then
            P(9, 6) = "Cutie"
            pct9cu6.Image = SkinCutie
            Cutii += 1
        ElseIf P(9, 6) = "Cutie" Then
            P(9, 6) = "Tinta"
            pct9cu6.Image = SkinTinta
            Cutii -= 1
        ElseIf P(9, 6) = "Tinta" Then
            P(9, 6) = "Rezolvat"
            pct9cu6.Image = SkinRezolvat
        ElseIf P(9, 6) = "Rezolvat" Then
            If Ok Then
                P(9, 6) = "Jucator"
                pct9cu6.Image = SkinJucator
                Ok = False
            Else
                P(9, 6) = "Nimic"
                pct9cu6.Image = SkinNimic
            End If
        ElseIf P(9, 6) = "Jucator" Then
            P(9, 6) = "JucatorPeTinta"
            pct9cu6.Image = SkinJucatorPeTinta
        ElseIf P(9, 6) = "JucatorPeTinta" Then
            P(9, 6) = "Nimic"
            pct9cu6.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct9cu7_Click(sender As System.Object, e As System.EventArgs) Handles pct9cu7.MouseDown
        If P(9, 7) = "Nimic" Then
            P(9, 7) = "Perete"
            pct9cu7.Image = SkinPerete
        ElseIf P(9, 7) = "Perete" Then
            P(9, 7) = "Teren"
            pct9cu7.Image = SkinTeren
        ElseIf P(9, 7) = "Teren" Then
            P(9, 7) = "Cutie"
            pct9cu7.Image = SkinCutie
            Cutii += 1
        ElseIf P(9, 7) = "Cutie" Then
            P(9, 7) = "Tinta"
            pct9cu7.Image = SkinTinta
            Cutii -= 1
        ElseIf P(9, 7) = "Tinta" Then
            P(9, 7) = "Rezolvat"
            pct9cu7.Image = SkinRezolvat
        ElseIf P(9, 7) = "Rezolvat" Then
            If Ok Then
                P(9, 7) = "Jucator"
                pct9cu7.Image = SkinJucator
                Ok = False
            Else
                P(9, 7) = "Nimic"
                pct9cu7.Image = SkinNimic
            End If
        ElseIf P(9, 7) = "Jucator" Then
            P(9, 7) = "JucatorPeTinta"
            pct9cu7.Image = SkinJucatorPeTinta
        ElseIf P(9, 7) = "JucatorPeTinta" Then
            P(9, 7) = "Nimic"
            pct9cu7.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct9cu8_Click(sender As System.Object, e As System.EventArgs) Handles pct9cu8.MouseDown
        If P(9, 8) = "Nimic" Then
            P(9, 8) = "Perete"
            pct9cu8.Image = SkinPerete
        ElseIf P(9, 8) = "Perete" Then
            P(9, 8) = "Teren"
            pct9cu8.Image = SkinTeren
        ElseIf P(9, 8) = "Teren" Then
            P(9, 8) = "Cutie"
            pct9cu8.Image = SkinCutie
            Cutii += 1
        ElseIf P(9, 8) = "Cutie" Then
            P(9, 8) = "Tinta"
            pct9cu8.Image = SkinTinta
            Cutii -= 1
        ElseIf P(9, 8) = "Tinta" Then
            P(9, 8) = "Rezolvat"
            pct9cu8.Image = SkinRezolvat
        ElseIf P(9, 8) = "Rezolvat" Then
            If Ok Then
                P(9, 8) = "Jucator"
                pct9cu8.Image = SkinJucator
                Ok = False
            Else
                P(9, 8) = "Nimic"
                pct9cu8.Image = SkinNimic
            End If
        ElseIf P(9, 8) = "Jucator" Then
            P(9, 8) = "JucatorPeTinta"
            pct9cu8.Image = SkinJucatorPeTinta
        ElseIf P(9, 8) = "JucatorPeTinta" Then
            P(9, 8) = "Nimic"
            pct9cu8.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct9cu9_Click(sender As System.Object, e As System.EventArgs) Handles pct9cu9.MouseDown
        If P(9, 9) = "Nimic" Then
            P(9, 9) = "Perete"
            pct9cu9.Image = SkinPerete
        ElseIf P(9, 9) = "Perete" Then
            P(9, 9) = "Teren"
            pct9cu9.Image = SkinTeren
        ElseIf P(9, 9) = "Teren" Then
            P(9, 9) = "Cutie"
            pct9cu9.Image = SkinCutie
            Cutii += 1
        ElseIf P(9, 9) = "Cutie" Then
            P(9, 9) = "Tinta"
            pct9cu9.Image = SkinTinta
            Cutii -= 1
        ElseIf P(9, 9) = "Tinta" Then
            P(9, 9) = "Rezolvat"
            pct9cu9.Image = SkinRezolvat
        ElseIf P(9, 9) = "Rezolvat" Then
            If Ok Then
                P(9, 9) = "Jucator"
                pct9cu9.Image = SkinJucator
                Ok = False
            Else
                P(9, 9) = "Nimic"
                pct9cu9.Image = SkinNimic
            End If
        ElseIf P(9, 9) = "Jucator" Then
            P(9, 9) = "JucatorPeTinta"
            pct9cu9.Image = SkinJucatorPeTinta
        ElseIf P(9, 9) = "JucatorPeTinta" Then
            P(9, 9) = "Nimic"
            pct9cu9.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct9cu10_Click(sender As System.Object, e As System.EventArgs) Handles pct9cu10.MouseDown
        If P(9, 10) = "Nimic" Then
            P(9, 10) = "Perete"
            pct9cu10.Image = SkinPerete
        ElseIf P(9, 10) = "Perete" Then
            P(9, 10) = "Teren"
            pct9cu10.Image = SkinTeren
        ElseIf P(9, 10) = "Teren" Then
            P(9, 10) = "Cutie"
            pct9cu10.Image = SkinCutie
            Cutii += 1
        ElseIf P(9, 10) = "Cutie" Then
            P(9, 10) = "Tinta"
            pct9cu10.Image = SkinTinta
            Cutii -= 1
        ElseIf P(9, 10) = "Tinta" Then
            P(9, 10) = "Rezolvat"
            pct9cu10.Image = SkinRezolvat
        ElseIf P(9, 10) = "Rezolvat" Then
            If Ok Then
                P(9, 10) = "Jucator"
                pct9cu10.Image = SkinJucator
                Ok = False
            Else
                P(9, 10) = "Nimic"
                pct9cu10.Image = SkinNimic
            End If
        ElseIf P(9, 10) = "Jucator" Then
            P(9, 10) = "JucatorPeTinta"
            pct9cu10.Image = SkinJucatorPeTinta
        ElseIf P(9, 10) = "JucatorPeTinta" Then
            P(9, 10) = "Nimic"
            pct9cu10.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct9cu11_Click(sender As System.Object, e As System.EventArgs) Handles pct9cu11.MouseDown
        If P(9, 11) = "Nimic" Then
            P(9, 11) = "Perete"
            pct9cu11.Image = SkinPerete
        ElseIf P(9, 11) = "Perete" Then
            P(9, 11) = "Teren"
            pct9cu11.Image = SkinTeren
        ElseIf P(9, 11) = "Teren" Then
            P(9, 11) = "Cutie"
            pct9cu11.Image = SkinCutie
            Cutii += 1
        ElseIf P(9, 11) = "Cutie" Then
            P(9, 11) = "Tinta"
            pct9cu11.Image = SkinTinta
            Cutii -= 1
        ElseIf P(9, 11) = "Tinta" Then
            P(9, 11) = "Rezolvat"
            pct9cu11.Image = SkinRezolvat
        ElseIf P(9, 11) = "Rezolvat" Then
            If Ok Then
                P(9, 11) = "Jucator"
                pct9cu11.Image = SkinJucator
                Ok = False
            Else
                P(9, 11) = "Nimic"
                pct9cu11.Image = SkinNimic
            End If
        ElseIf P(9, 11) = "Jucator" Then
            P(9, 11) = "JucatorPeTinta"
            pct9cu11.Image = SkinJucatorPeTinta
        ElseIf P(9, 11) = "JucatorPeTinta" Then
            P(9, 11) = "Nimic"
            pct9cu11.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct9cu12_Click(sender As System.Object, e As System.EventArgs) Handles pct9cu12.MouseDown
        If P(9, 12) = "Nimic" Then
            P(9, 12) = "Perete"
            pct9cu12.Image = SkinPerete
        ElseIf P(9, 12) = "Perete" Then
            P(9, 12) = "Teren"
            pct9cu12.Image = SkinTeren
        ElseIf P(9, 12) = "Teren" Then
            P(9, 12) = "Cutie"
            pct9cu12.Image = SkinCutie
            Cutii += 1
        ElseIf P(9, 12) = "Cutie" Then
            P(9, 12) = "Tinta"
            pct9cu12.Image = SkinTinta
            Cutii -= 1
        ElseIf P(9, 12) = "Tinta" Then
            P(9, 12) = "Rezolvat"
            pct9cu12.Image = SkinRezolvat
        ElseIf P(9, 12) = "Rezolvat" Then
            If Ok Then
                P(9, 12) = "Jucator"
                pct9cu12.Image = SkinJucator
                Ok = False
            Else
                P(9, 12) = "Nimic"
                pct9cu12.Image = SkinNimic
            End If
        ElseIf P(9, 12) = "Jucator" Then
            P(9, 12) = "JucatorPeTinta"
            pct9cu12.Image = SkinJucatorPeTinta
        ElseIf P(9, 12) = "JucatorPeTinta" Then
            P(9, 12) = "Nimic"
            pct9cu12.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct9cu13_Click(sender As System.Object, e As System.EventArgs) Handles pct9cu13.MouseDown
        If P(9, 13) = "Nimic" Then
            P(9, 13) = "Perete"
            pct9cu13.Image = SkinPerete
        ElseIf P(9, 13) = "Perete" Then
            P(9, 13) = "Teren"
            pct9cu13.Image = SkinTeren
        ElseIf P(9, 13) = "Teren" Then
            P(9, 13) = "Cutie"
            pct9cu13.Image = SkinCutie
            Cutii += 1
        ElseIf P(9, 13) = "Cutie" Then
            P(9, 13) = "Tinta"
            pct9cu13.Image = SkinTinta
            Cutii -= 1
        ElseIf P(9, 13) = "Tinta" Then
            P(9, 13) = "Rezolvat"
            pct9cu13.Image = SkinRezolvat
        ElseIf P(9, 13) = "Rezolvat" Then
            If Ok Then
                P(9, 13) = "Jucator"
                pct9cu13.Image = SkinJucator
                Ok = False
            Else
                P(9, 13) = "Nimic"
                pct9cu13.Image = SkinNimic
            End If
        ElseIf P(9, 13) = "Jucator" Then
            P(9, 13) = "JucatorPeTinta"
            pct9cu13.Image = SkinJucatorPeTinta
        ElseIf P(9, 13) = "JucatorPeTinta" Then
            P(9, 13) = "Nimic"
            pct9cu13.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct9cu14_Click(sender As System.Object, e As System.EventArgs) Handles pct9cu14.MouseDown
        If P(9, 14) = "Nimic" Then
            P(9, 14) = "Perete"
            pct9cu14.Image = SkinPerete
        ElseIf P(9, 14) = "Perete" Then
            P(9, 14) = "Teren"
            pct9cu14.Image = SkinTeren
        ElseIf P(9, 14) = "Teren" Then
            P(9, 14) = "Cutie"
            pct9cu14.Image = SkinCutie
            Cutii += 1
        ElseIf P(9, 14) = "Cutie" Then
            P(9, 14) = "Tinta"
            pct9cu14.Image = SkinTinta
            Cutii -= 1
        ElseIf P(9, 14) = "Tinta" Then
            P(9, 14) = "Rezolvat"
            pct9cu14.Image = SkinRezolvat
        ElseIf P(9, 14) = "Rezolvat" Then
            If Ok Then
                P(9, 14) = "Jucator"
                pct9cu14.Image = SkinJucator
                Ok = False
            Else
                P(9, 14) = "Nimic"
                pct9cu14.Image = SkinNimic
            End If
        ElseIf P(9, 14) = "Jucator" Then
            P(9, 14) = "JucatorPeTinta"
            pct9cu14.Image = SkinJucatorPeTinta
        ElseIf P(9, 14) = "JucatorPeTinta" Then
            P(9, 14) = "Nimic"
            pct9cu14.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct10cu1_Click(sender As System.Object, e As System.EventArgs) Handles pct10cu1.MouseDown
        If P(10, 1) = "Nimic" Then
            P(10, 1) = "Perete"
            pct10cu1.Image = SkinPerete
        ElseIf P(10, 1) = "Perete" Then
            P(10, 1) = "Teren"
            pct10cu1.Image = SkinTeren
        ElseIf P(10, 1) = "Teren" Then
            P(10, 1) = "Cutie"
            pct10cu1.Image = SkinCutie
            Cutii += 1
        ElseIf P(10, 1) = "Cutie" Then
            P(10, 1) = "Tinta"
            pct10cu1.Image = SkinTinta
            Cutii -= 1
        ElseIf P(10, 1) = "Tinta" Then
            P(10, 1) = "Rezolvat"
            pct10cu1.Image = SkinRezolvat
        ElseIf P(10, 1) = "Rezolvat" Then
            If Ok Then
                P(10, 1) = "Jucator"
                pct10cu1.Image = SkinJucator
                Ok = False
            Else
                P(10, 1) = "Nimic"
                pct10cu1.Image = SkinNimic
            End If
        ElseIf P(10, 1) = "Jucator" Then
            P(10, 1) = "JucatorPeTinta"
            pct10cu1.Image = SkinJucatorPeTinta
        ElseIf P(10, 1) = "JucatorPeTinta" Then
            P(10, 1) = "Nimic"
            pct10cu1.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct10cu2_Click(sender As System.Object, e As System.EventArgs) Handles pct10cu2.MouseDown
        If P(10, 2) = "Nimic" Then
            P(10, 2) = "Perete"
            pct10cu2.Image = SkinPerete
        ElseIf P(10, 2) = "Perete" Then
            P(10, 2) = "Teren"
            pct10cu2.Image = SkinTeren
        ElseIf P(10, 2) = "Teren" Then
            P(10, 2) = "Cutie"
            pct10cu2.Image = SkinCutie
            Cutii += 1
        ElseIf P(10, 2) = "Cutie" Then
            P(10, 2) = "Tinta"
            pct10cu2.Image = SkinTinta
            Cutii -= 1
        ElseIf P(10, 2) = "Tinta" Then
            P(10, 2) = "Rezolvat"
            pct10cu2.Image = SkinRezolvat
        ElseIf P(10, 2) = "Rezolvat" Then
            If Ok Then
                P(10, 2) = "Jucator"
                pct10cu2.Image = SkinJucator
                Ok = False
            Else
                P(10, 2) = "Nimic"
                pct10cu2.Image = SkinNimic
            End If
        ElseIf P(10, 2) = "Jucator" Then
            P(10, 2) = "JucatorPeTinta"
            pct10cu2.Image = SkinJucatorPeTinta
        ElseIf P(10, 2) = "JucatorPeTinta" Then
            P(10, 2) = "Nimic"
            pct10cu2.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct10cu3_Click(sender As System.Object, e As System.EventArgs) Handles pct10cu3.MouseDown
        If P(10, 3) = "Nimic" Then
            P(10, 3) = "Perete"
            pct10cu3.Image = SkinPerete
        ElseIf P(10, 3) = "Perete" Then
            P(10, 3) = "Teren"
            pct10cu3.Image = SkinTeren
        ElseIf P(10, 3) = "Teren" Then
            P(10, 3) = "Cutie"
            pct10cu3.Image = SkinCutie
            Cutii += 1
        ElseIf P(10, 3) = "Cutie" Then
            P(10, 3) = "Tinta"
            pct10cu3.Image = SkinTinta
            Cutii -= 1
        ElseIf P(10, 3) = "Tinta" Then
            P(10, 3) = "Rezolvat"
            pct10cu3.Image = SkinRezolvat
        ElseIf P(10, 3) = "Rezolvat" Then
            If Ok Then
                P(10, 3) = "Jucator"
                pct10cu3.Image = SkinJucator
                Ok = False
            Else
                P(10, 3) = "Nimic"
                pct10cu3.Image = SkinNimic
            End If
        ElseIf P(10, 3) = "Jucator" Then
            P(10, 3) = "JucatorPeTinta"
            pct10cu3.Image = SkinJucatorPeTinta
        ElseIf P(10, 3) = "JucatorPeTinta" Then
            P(10, 3) = "Nimic"
            pct10cu3.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct10cu4_Click(sender As System.Object, e As System.EventArgs) Handles pct10cu4.MouseDown
        If P(10, 4) = "Nimic" Then
            P(10, 4) = "Perete"
            pct10cu4.Image = SkinPerete
        ElseIf P(10, 4) = "Perete" Then
            P(10, 4) = "Teren"
            pct10cu4.Image = SkinTeren
        ElseIf P(10, 4) = "Teren" Then
            P(10, 4) = "Cutie"
            pct10cu4.Image = SkinCutie
            Cutii += 1
        ElseIf P(10, 4) = "Cutie" Then
            P(10, 4) = "Tinta"
            pct10cu4.Image = SkinTinta
            Cutii -= 1
        ElseIf P(10, 4) = "Tinta" Then
            P(10, 4) = "Rezolvat"
            pct10cu4.Image = SkinRezolvat
        ElseIf P(10, 4) = "Rezolvat" Then
            If Ok Then
                P(10, 4) = "Jucator"
                pct10cu4.Image = SkinJucator
                Ok = False
            Else
                P(10, 4) = "Nimic"
                pct10cu4.Image = SkinNimic
            End If
        ElseIf P(10, 4) = "Jucator" Then
            P(10, 4) = "JucatorPeTinta"
            pct10cu4.Image = SkinJucatorPeTinta
        ElseIf P(10, 4) = "JucatorPeTinta" Then
            P(10, 4) = "Nimic"
            pct10cu4.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct10cu5_Click(sender As System.Object, e As System.EventArgs) Handles pct10cu5.MouseDown
        If P(10, 5) = "Nimic" Then
            P(10, 5) = "Perete"
            pct10cu5.Image = SkinPerete
        ElseIf P(10, 5) = "Perete" Then
            P(10, 5) = "Teren"
            pct10cu5.Image = SkinTeren
        ElseIf P(10, 5) = "Teren" Then
            P(10, 5) = "Cutie"
            pct10cu5.Image = SkinCutie
            Cutii += 1
        ElseIf P(10, 5) = "Cutie" Then
            P(10, 5) = "Tinta"
            pct10cu5.Image = SkinTinta
            Cutii -= 1
        ElseIf P(10, 5) = "Tinta" Then
            P(10, 5) = "Rezolvat"
            pct10cu5.Image = SkinRezolvat
        ElseIf P(10, 5) = "Rezolvat" Then
            If Ok Then
                P(10, 5) = "Jucator"
                pct10cu5.Image = SkinJucator
                Ok = False
            Else
                P(10, 5) = "Nimic"
                pct10cu5.Image = SkinNimic
            End If
        ElseIf P(10, 5) = "Jucator" Then
            P(10, 5) = "JucatorPeTinta"
            pct10cu5.Image = SkinJucatorPeTinta
        ElseIf P(10, 5) = "JucatorPeTinta" Then
            P(10, 5) = "Nimic"
            pct10cu5.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct10cu6_Click(sender As System.Object, e As System.EventArgs) Handles pct10cu6.MouseDown
        If P(10, 6) = "Nimic" Then
            P(10, 6) = "Perete"
            pct10cu6.Image = SkinPerete
        ElseIf P(10, 6) = "Perete" Then
            P(10, 6) = "Teren"
            pct10cu6.Image = SkinTeren
        ElseIf P(10, 6) = "Teren" Then
            P(10, 6) = "Cutie"
            pct10cu6.Image = SkinCutie
            Cutii += 1
        ElseIf P(10, 6) = "Cutie" Then
            P(10, 6) = "Tinta"
            pct10cu6.Image = SkinTinta
            Cutii -= 1
        ElseIf P(10, 6) = "Tinta" Then
            P(10, 6) = "Rezolvat"
            pct10cu6.Image = SkinRezolvat
        ElseIf P(10, 6) = "Rezolvat" Then
            If Ok Then
                P(10, 6) = "Jucator"
                pct10cu6.Image = SkinJucator
                Ok = False
            Else
                P(10, 6) = "Nimic"
                pct10cu6.Image = SkinNimic
            End If
        ElseIf P(10, 6) = "Jucator" Then
            P(10, 6) = "JucatorPeTinta"
            pct10cu6.Image = SkinJucatorPeTinta
        ElseIf P(10, 6) = "JucatorPeTinta" Then
            P(10, 6) = "Nimic"
            pct10cu6.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct10cu7_Click(sender As System.Object, e As System.EventArgs) Handles pct10cu7.MouseDown
        If P(10, 7) = "Nimic" Then
            P(10, 7) = "Perete"
            pct10cu7.Image = SkinPerete
        ElseIf P(10, 7) = "Perete" Then
            P(10, 7) = "Teren"
            pct10cu7.Image = SkinTeren
        ElseIf P(10, 7) = "Teren" Then
            P(10, 7) = "Cutie"
            pct10cu7.Image = SkinCutie
            Cutii += 1
        ElseIf P(10, 7) = "Cutie" Then
            P(10, 7) = "Tinta"
            pct10cu7.Image = SkinTinta
            Cutii -= 1
        ElseIf P(10, 7) = "Tinta" Then
            P(10, 7) = "Rezolvat"
            pct10cu7.Image = SkinRezolvat
        ElseIf P(10, 7) = "Rezolvat" Then
            If Ok Then
                P(10, 7) = "Jucator"
                pct10cu7.Image = SkinJucator
                Ok = False
            Else
                P(10, 7) = "Nimic"
                pct10cu7.Image = SkinNimic
            End If
        ElseIf P(10, 7) = "Jucator" Then
            P(10, 7) = "JucatorPeTinta"
            pct10cu7.Image = SkinJucatorPeTinta
        ElseIf P(10, 7) = "JucatorPeTinta" Then
            P(10, 7) = "Nimic"
            pct10cu7.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct10cu8_Click(sender As System.Object, e As System.EventArgs) Handles pct10cu8.MouseDown
        If P(10, 8) = "Nimic" Then
            P(10, 8) = "Perete"
            pct10cu8.Image = SkinPerete
        ElseIf P(10, 8) = "Perete" Then
            P(10, 8) = "Teren"
            pct10cu8.Image = SkinTeren
        ElseIf P(10, 8) = "Teren" Then
            P(10, 8) = "Cutie"
            pct10cu8.Image = SkinCutie
            Cutii += 1
        ElseIf P(10, 8) = "Cutie" Then
            P(10, 8) = "Tinta"
            pct10cu8.Image = SkinTinta
            Cutii -= 1
        ElseIf P(10, 8) = "Tinta" Then
            P(10, 8) = "Rezolvat"
            pct10cu8.Image = SkinRezolvat
        ElseIf P(10, 8) = "Rezolvat" Then
            If Ok Then
                P(10, 8) = "Jucator"
                pct10cu8.Image = SkinJucator
                Ok = False
            Else
                P(10, 8) = "Nimic"
                pct10cu8.Image = SkinNimic
            End If
        ElseIf P(10, 8) = "Jucator" Then
            P(10, 8) = "JucatorPeTinta"
            pct10cu8.Image = SkinJucatorPeTinta
        ElseIf P(10, 8) = "JucatorPeTinta" Then
            P(10, 8) = "Nimic"
            pct10cu8.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct10cu9_Click(sender As System.Object, e As System.EventArgs) Handles pct10cu9.MouseDown
        If P(10, 9) = "Nimic" Then
            P(10, 9) = "Perete"
            pct10cu9.Image = SkinPerete
        ElseIf P(10, 9) = "Perete" Then
            P(10, 9) = "Teren"
            pct10cu9.Image = SkinTeren
        ElseIf P(10, 9) = "Teren" Then
            P(10, 9) = "Cutie"
            pct10cu9.Image = SkinCutie
            Cutii += 1
        ElseIf P(10, 9) = "Cutie" Then
            P(10, 9) = "Tinta"
            pct10cu9.Image = SkinTinta
            Cutii -= 1
        ElseIf P(10, 9) = "Tinta" Then
            P(10, 9) = "Rezolvat"
            pct10cu9.Image = SkinRezolvat
        ElseIf P(10, 9) = "Rezolvat" Then
            If Ok Then
                P(10, 9) = "Jucator"
                pct10cu9.Image = SkinJucator
                Ok = False
            Else
                P(10, 9) = "Nimic"
                pct10cu9.Image = SkinNimic
            End If
        ElseIf P(10, 9) = "Jucator" Then
            P(10, 9) = "JucatorPeTinta"
            pct10cu9.Image = SkinJucatorPeTinta
        ElseIf P(10, 9) = "JucatorPeTinta" Then
            P(10, 9) = "Nimic"
            pct10cu9.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct10cu10_Click(sender As System.Object, e As System.EventArgs) Handles pct10cu10.MouseDown
        If P(10, 10) = "Nimic" Then
            P(10, 10) = "Perete"
            pct10cu10.Image = SkinPerete
        ElseIf P(10, 10) = "Perete" Then
            P(10, 10) = "Teren"
            pct10cu10.Image = SkinTeren
        ElseIf P(10, 10) = "Teren" Then
            P(10, 10) = "Cutie"
            pct10cu10.Image = SkinCutie
            Cutii += 1
        ElseIf P(10, 10) = "Cutie" Then
            P(10, 10) = "Tinta"
            pct10cu10.Image = SkinTinta
            Cutii -= 1
        ElseIf P(10, 10) = "Tinta" Then
            P(10, 10) = "Rezolvat"
            pct10cu10.Image = SkinRezolvat
        ElseIf P(10, 10) = "Rezolvat" Then
            If Ok Then
                P(10, 10) = "Jucator"
                pct10cu10.Image = SkinJucator
                Ok = False
            Else
                P(10, 10) = "Nimic"
                pct10cu10.Image = SkinNimic
            End If
        ElseIf P(10, 10) = "Jucator" Then
            P(10, 10) = "JucatorPeTinta"
            pct10cu10.Image = SkinJucatorPeTinta
        ElseIf P(10, 10) = "JucatorPeTinta" Then
            P(10, 10) = "Nimic"
            pct10cu10.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct10cu11_Click(sender As System.Object, e As System.EventArgs) Handles pct10cu11.MouseDown
        If P(10, 11) = "Nimic" Then
            P(10, 11) = "Perete"
            pct10cu11.Image = SkinPerete
        ElseIf P(10, 11) = "Perete" Then
            P(10, 11) = "Teren"
            pct10cu11.Image = SkinTeren
        ElseIf P(10, 11) = "Teren" Then
            P(10, 11) = "Cutie"
            pct10cu11.Image = SkinCutie
            Cutii += 1
        ElseIf P(10, 11) = "Cutie" Then
            P(10, 11) = "Tinta"
            pct10cu11.Image = SkinTinta
            Cutii -= 1
        ElseIf P(10, 11) = "Tinta" Then
            P(10, 11) = "Rezolvat"
            pct10cu11.Image = SkinRezolvat
        ElseIf P(10, 11) = "Rezolvat" Then
            If Ok Then
                P(10, 11) = "Jucator"
                pct10cu11.Image = SkinJucator
                Ok = False
            Else
                P(10, 11) = "Nimic"
                pct10cu11.Image = SkinNimic
            End If
        ElseIf P(10, 11) = "Jucator" Then
            P(10, 11) = "JucatorPeTinta"
            pct10cu11.Image = SkinJucatorPeTinta
        ElseIf P(10, 11) = "JucatorPeTinta" Then
            P(10, 11) = "Nimic"
            pct10cu11.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct10cu12_Click(sender As System.Object, e As System.EventArgs) Handles pct10cu12.MouseDown
        If P(10, 12) = "Nimic" Then
            P(10, 12) = "Perete"
            pct10cu12.Image = SkinPerete
        ElseIf P(10, 12) = "Perete" Then
            P(10, 12) = "Teren"
            pct10cu12.Image = SkinTeren
        ElseIf P(10, 12) = "Teren" Then
            P(10, 12) = "Cutie"
            pct10cu12.Image = SkinCutie
            Cutii += 1
        ElseIf P(10, 12) = "Cutie" Then
            P(10, 12) = "Tinta"
            pct10cu12.Image = SkinTinta
            Cutii -= 1
        ElseIf P(10, 12) = "Tinta" Then
            P(10, 12) = "Rezolvat"
            pct10cu12.Image = SkinRezolvat
        ElseIf P(10, 12) = "Rezolvat" Then
            If Ok Then
                P(10, 12) = "Jucator"
                pct10cu12.Image = SkinJucator
                Ok = False
            Else
                P(10, 12) = "Nimic"
                pct10cu12.Image = SkinNimic
            End If
        ElseIf P(10, 12) = "Jucator" Then
            P(10, 12) = "JucatorPeTinta"
            pct10cu12.Image = SkinJucatorPeTinta
        ElseIf P(10, 12) = "JucatorPeTinta" Then
            P(10, 12) = "Nimic"
            pct10cu12.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct10cu13_Click(sender As System.Object, e As System.EventArgs) Handles pct10cu13.MouseDown
        If P(10, 13) = "Nimic" Then
            P(10, 13) = "Perete"
            pct10cu13.Image = SkinPerete
        ElseIf P(10, 13) = "Perete" Then
            P(10, 13) = "Teren"
            pct10cu13.Image = SkinTeren
        ElseIf P(10, 13) = "Teren" Then
            P(10, 13) = "Cutie"
            pct10cu13.Image = SkinCutie
            Cutii += 1
        ElseIf P(10, 13) = "Cutie" Then
            P(10, 13) = "Tinta"
            pct10cu13.Image = SkinTinta
            Cutii -= 1
        ElseIf P(10, 13) = "Tinta" Then
            P(10, 13) = "Rezolvat"
            pct10cu13.Image = SkinRezolvat
        ElseIf P(10, 13) = "Rezolvat" Then
            If Ok Then
                P(10, 13) = "Jucator"
                pct10cu13.Image = SkinJucator
                Ok = False
            Else
                P(10, 13) = "Nimic"
                pct10cu13.Image = SkinNimic
            End If
        ElseIf P(10, 13) = "Jucator" Then
            P(10, 13) = "JucatorPeTinta"
            pct10cu13.Image = SkinJucatorPeTinta
        ElseIf P(10, 13) = "JucatorPeTinta" Then
            P(10, 13) = "Nimic"
            pct10cu13.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct10cu14_Click(sender As System.Object, e As System.EventArgs) Handles pct10cu14.MouseDown
        If P(10, 14) = "Nimic" Then
            P(10, 14) = "Perete"
            pct10cu14.Image = SkinPerete
        ElseIf P(10, 14) = "Perete" Then
            P(10, 14) = "Teren"
            pct10cu14.Image = SkinTeren
        ElseIf P(10, 14) = "Teren" Then
            P(10, 14) = "Cutie"
            pct10cu14.Image = SkinCutie
            Cutii += 1
        ElseIf P(10, 14) = "Cutie" Then
            P(10, 14) = "Tinta"
            pct10cu14.Image = SkinTinta
            Cutii -= 1
        ElseIf P(10, 14) = "Tinta" Then
            P(10, 14) = "Rezolvat"
            pct10cu14.Image = SkinRezolvat
        ElseIf P(10, 14) = "Rezolvat" Then
            If Ok Then
                P(10, 14) = "Jucator"
                pct10cu14.Image = SkinJucator
                Ok = False
            Else
                P(10, 14) = "Nimic"
                pct10cu14.Image = SkinNimic
            End If
        ElseIf P(10, 14) = "Jucator" Then
            P(10, 14) = "JucatorPeTinta"
            pct10cu14.Image = SkinJucatorPeTinta
        ElseIf P(10, 14) = "JucatorPeTinta" Then
            P(10, 14) = "Nimic"
            pct10cu14.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct11cu1_Click(sender As System.Object, e As System.EventArgs) Handles pct11cu1.MouseDown
        If P(11, 1) = "Nimic" Then
            P(11, 1) = "Perete"
            pct11cu1.Image = SkinPerete
        ElseIf P(11, 1) = "Perete" Then
            P(11, 1) = "Teren"
            pct11cu1.Image = SkinTeren
        ElseIf P(11, 1) = "Teren" Then
            P(11, 1) = "Cutie"
            pct11cu1.Image = SkinCutie
            Cutii += 1
        ElseIf P(11, 1) = "Cutie" Then
            P(11, 1) = "Tinta"
            pct11cu1.Image = SkinTinta
            Cutii -= 1
        ElseIf P(11, 1) = "Tinta" Then
            P(11, 1) = "Rezolvat"
            pct11cu1.Image = SkinRezolvat
        ElseIf P(11, 1) = "Rezolvat" Then
            If Ok Then
                P(11, 1) = "Jucator"
                pct11cu1.Image = SkinJucator
                Ok = False
            Else
                P(11, 1) = "Nimic"
                pct11cu1.Image = SkinNimic
            End If
        ElseIf P(11, 1) = "Jucator" Then
            P(11, 1) = "JucatorPeTinta"
            pct11cu1.Image = SkinJucatorPeTinta
        ElseIf P(11, 1) = "JucatorPeTinta" Then
            P(11, 1) = "Nimic"
            pct11cu1.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct11cu2_Click(sender As System.Object, e As System.EventArgs) Handles pct11cu2.MouseDown
        If P(11, 2) = "Nimic" Then
            P(11, 2) = "Perete"
            pct11cu2.Image = SkinPerete
        ElseIf P(11, 2) = "Perete" Then
            P(11, 2) = "Teren"
            pct11cu2.Image = SkinTeren
        ElseIf P(11, 2) = "Teren" Then
            P(11, 2) = "Cutie"
            pct11cu2.Image = SkinCutie
            Cutii += 1
        ElseIf P(11, 2) = "Cutie" Then
            P(11, 2) = "Tinta"
            pct11cu2.Image = SkinTinta
            Cutii -= 1
        ElseIf P(11, 2) = "Tinta" Then
            P(11, 2) = "Rezolvat"
            pct11cu2.Image = SkinRezolvat
        ElseIf P(11, 2) = "Rezolvat" Then
            If Ok Then
                P(11, 2) = "Jucator"
                pct11cu2.Image = SkinJucator
                Ok = False
            Else
                P(11, 2) = "Nimic"
                pct11cu2.Image = SkinNimic
            End If
        ElseIf P(11, 2) = "Jucator" Then
            P(11, 2) = "JucatorPeTinta"
            pct11cu2.Image = SkinJucatorPeTinta
        ElseIf P(11, 2) = "JucatorPeTinta" Then
            P(11, 2) = "Nimic"
            pct11cu2.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct11cu3_Click(sender As System.Object, e As System.EventArgs) Handles pct11cu3.MouseDown
        If P(11, 3) = "Nimic" Then
            P(11, 3) = "Perete"
            pct11cu3.Image = SkinPerete
        ElseIf P(11, 3) = "Perete" Then
            P(11, 3) = "Teren"
            pct11cu3.Image = SkinTeren
        ElseIf P(11, 3) = "Teren" Then
            P(11, 3) = "Cutie"
            pct11cu3.Image = SkinCutie
            Cutii += 1
        ElseIf P(11, 3) = "Cutie" Then
            P(11, 3) = "Tinta"
            pct11cu3.Image = SkinTinta
            Cutii -= 1
        ElseIf P(11, 3) = "Tinta" Then
            P(11, 3) = "Rezolvat"
            pct11cu3.Image = SkinRezolvat
        ElseIf P(11, 3) = "Rezolvat" Then
            If Ok Then
                P(11, 3) = "Jucator"
                pct11cu3.Image = SkinJucator
                Ok = False
            Else
                P(11, 3) = "Nimic"
                pct11cu3.Image = SkinNimic
            End If
        ElseIf P(11, 3) = "Jucator" Then
            P(11, 3) = "JucatorPeTinta"
            pct11cu3.Image = SkinJucatorPeTinta
        ElseIf P(11, 3) = "JucatorPeTinta" Then
            P(11, 3) = "Nimic"
            pct11cu3.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct11cu4_Click(sender As System.Object, e As System.EventArgs) Handles pct11cu4.MouseDown
        If P(11, 4) = "Nimic" Then
            P(11, 4) = "Perete"
            pct11cu4.Image = SkinPerete
        ElseIf P(11, 4) = "Perete" Then
            P(11, 4) = "Teren"
            pct11cu4.Image = SkinTeren
        ElseIf P(11, 4) = "Teren" Then
            P(11, 4) = "Cutie"
            pct11cu4.Image = SkinCutie
            Cutii += 1
        ElseIf P(11, 4) = "Cutie" Then
            P(11, 4) = "Tinta"
            pct11cu4.Image = SkinTinta
            Cutii -= 1
        ElseIf P(11, 4) = "Tinta" Then
            P(11, 4) = "Rezolvat"
            pct11cu4.Image = SkinRezolvat
        ElseIf P(11, 4) = "Rezolvat" Then
            If Ok Then
                P(11, 4) = "Jucator"
                pct11cu4.Image = SkinJucator
                Ok = False
            Else
                P(11, 4) = "Nimic"
                pct11cu4.Image = SkinNimic
            End If
        ElseIf P(11, 4) = "Jucator" Then
            P(11, 4) = "JucatorPeTinta"
            pct11cu4.Image = SkinJucatorPeTinta
        ElseIf P(11, 4) = "JucatorPeTinta" Then
            P(11, 4) = "Nimic"
            pct11cu4.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct11cu5_Click(sender As System.Object, e As System.EventArgs) Handles pct11cu5.MouseDown
        If P(11, 5) = "Nimic" Then
            P(11, 5) = "Perete"
            pct11cu5.Image = SkinPerete
        ElseIf P(11, 5) = "Perete" Then
            P(11, 5) = "Teren"
            pct11cu5.Image = SkinTeren
        ElseIf P(11, 5) = "Teren" Then
            P(11, 5) = "Cutie"
            pct11cu5.Image = SkinCutie
            Cutii += 1
        ElseIf P(11, 5) = "Cutie" Then
            P(11, 5) = "Tinta"
            pct11cu5.Image = SkinTinta
            Cutii -= 1
        ElseIf P(11, 5) = "Tinta" Then
            P(11, 5) = "Rezolvat"
            pct11cu5.Image = SkinRezolvat
        ElseIf P(11, 5) = "Rezolvat" Then
            If Ok Then
                P(11, 5) = "Jucator"
                pct11cu5.Image = SkinJucator
                Ok = False
            Else
                P(11, 5) = "Nimic"
                pct11cu5.Image = SkinNimic
            End If
        ElseIf P(11, 5) = "Jucator" Then
            P(11, 5) = "JucatorPeTinta"
            pct11cu5.Image = SkinJucatorPeTinta
        ElseIf P(11, 5) = "JucatorPeTinta" Then
            P(11, 5) = "Nimic"
            pct11cu5.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct11cu6_Click(sender As System.Object, e As System.EventArgs) Handles pct11cu6.MouseDown
        If P(11, 6) = "Nimic" Then
            P(11, 6) = "Perete"
            pct11cu6.Image = SkinPerete
        ElseIf P(11, 6) = "Perete" Then
            P(11, 6) = "Teren"
            pct11cu6.Image = SkinTeren
        ElseIf P(11, 6) = "Teren" Then
            P(11, 6) = "Cutie"
            pct11cu6.Image = SkinCutie
            Cutii += 1
        ElseIf P(11, 6) = "Cutie" Then
            P(11, 6) = "Tinta"
            pct11cu6.Image = SkinTinta
            Cutii -= 1
        ElseIf P(11, 6) = "Tinta" Then
            P(11, 6) = "Rezolvat"
            pct11cu6.Image = SkinRezolvat
        ElseIf P(11, 6) = "Rezolvat" Then
            If Ok Then
                P(11, 6) = "Jucator"
                pct11cu6.Image = SkinJucator
                Ok = False
            Else
                P(11, 6) = "Nimic"
                pct11cu6.Image = SkinNimic
            End If
        ElseIf P(11, 6) = "Jucator" Then
            P(11, 6) = "JucatorPeTinta"
            pct11cu6.Image = SkinJucatorPeTinta
        ElseIf P(11, 6) = "JucatorPeTinta" Then
            P(11, 6) = "Nimic"
            pct11cu6.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct11cu7_Click(sender As System.Object, e As System.EventArgs) Handles pct11cu7.MouseDown
        If P(11, 7) = "Nimic" Then
            P(11, 7) = "Perete"
            pct11cu7.Image = SkinPerete
        ElseIf P(11, 7) = "Perete" Then
            P(11, 7) = "Teren"
            pct11cu7.Image = SkinTeren
        ElseIf P(11, 7) = "Teren" Then
            P(11, 7) = "Cutie"
            pct11cu7.Image = SkinCutie
            Cutii += 1
        ElseIf P(11, 7) = "Cutie" Then
            P(11, 7) = "Tinta"
            pct11cu7.Image = SkinTinta
            Cutii -= 1
        ElseIf P(11, 7) = "Tinta" Then
            P(11, 7) = "Rezolvat"
            pct11cu7.Image = SkinRezolvat
        ElseIf P(11, 7) = "Rezolvat" Then
            If Ok Then
                P(11, 7) = "Jucator"
                pct11cu7.Image = SkinJucator
                Ok = False
            Else
                P(11, 7) = "Nimic"
                pct11cu7.Image = SkinNimic
            End If
        ElseIf P(11, 7) = "Jucator" Then
            P(11, 7) = "JucatorPeTinta"
            pct11cu7.Image = SkinJucatorPeTinta
        ElseIf P(11, 7) = "JucatorPeTinta" Then
            P(11, 7) = "Nimic"
            pct11cu7.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct11cu8_Click(sender As System.Object, e As System.EventArgs) Handles pct11cu8.MouseDown
        If P(11, 8) = "Nimic" Then
            P(11, 8) = "Perete"
            pct11cu8.Image = SkinPerete
        ElseIf P(11, 8) = "Perete" Then
            P(11, 8) = "Teren"
            pct11cu8.Image = SkinTeren
        ElseIf P(11, 8) = "Teren" Then
            P(11, 8) = "Cutie"
            pct11cu8.Image = SkinCutie
            Cutii += 1
        ElseIf P(11, 8) = "Cutie" Then
            P(11, 8) = "Tinta"
            pct11cu8.Image = SkinTinta
            Cutii -= 1
        ElseIf P(11, 8) = "Tinta" Then
            P(11, 8) = "Rezolvat"
            pct11cu8.Image = SkinRezolvat
        ElseIf P(11, 8) = "Rezolvat" Then
            If Ok Then
                P(11, 8) = "Jucator"
                pct11cu8.Image = SkinJucator
                Ok = False
            Else
                P(11, 8) = "Nimic"
                pct11cu8.Image = SkinNimic
            End If
        ElseIf P(11, 8) = "Jucator" Then
            P(11, 8) = "JucatorPeTinta"
            pct11cu8.Image = SkinJucatorPeTinta
        ElseIf P(11, 8) = "JucatorPeTinta" Then
            P(11, 8) = "Nimic"
            pct11cu8.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct11cu9_Click(sender As System.Object, e As System.EventArgs) Handles pct11cu9.MouseDown
        If P(11, 9) = "Nimic" Then
            P(11, 9) = "Perete"
            pct11cu9.Image = SkinPerete
        ElseIf P(11, 9) = "Perete" Then
            P(11, 9) = "Teren"
            pct11cu9.Image = SkinTeren
        ElseIf P(11, 9) = "Teren" Then
            P(11, 9) = "Cutie"
            pct11cu9.Image = SkinCutie
            Cutii += 1
        ElseIf P(11, 9) = "Cutie" Then
            P(11, 9) = "Tinta"
            pct11cu9.Image = SkinTinta
            Cutii -= 1
        ElseIf P(11, 9) = "Tinta" Then
            P(11, 9) = "Rezolvat"
            pct11cu9.Image = SkinRezolvat
        ElseIf P(11, 9) = "Rezolvat" Then
            If Ok Then
                P(11, 9) = "Jucator"
                pct11cu9.Image = SkinJucator
                Ok = False
            Else
                P(11, 9) = "Nimic"
                pct11cu9.Image = SkinNimic
            End If
        ElseIf P(11, 9) = "Jucator" Then
            P(11, 9) = "JucatorPeTinta"
            pct11cu9.Image = SkinJucatorPeTinta
        ElseIf P(11, 9) = "JucatorPeTinta" Then
            P(11, 9) = "Nimic"
            pct11cu9.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct11cu10_Click(sender As System.Object, e As System.EventArgs) Handles pct11cu10.MouseDown
        If P(11, 10) = "Nimic" Then
            P(11, 10) = "Perete"
            pct11cu10.Image = SkinPerete
        ElseIf P(11, 10) = "Perete" Then
            P(11, 10) = "Teren"
            pct11cu10.Image = SkinTeren
        ElseIf P(11, 10) = "Teren" Then
            P(11, 10) = "Cutie"
            pct11cu10.Image = SkinCutie
            Cutii += 1
        ElseIf P(11, 10) = "Cutie" Then
            P(11, 10) = "Tinta"
            pct11cu10.Image = SkinTinta
            Cutii -= 1
        ElseIf P(11, 10) = "Tinta" Then
            P(11, 10) = "Rezolvat"
            pct11cu10.Image = SkinRezolvat
        ElseIf P(11, 10) = "Rezolvat" Then
            If Ok Then
                P(11, 10) = "Jucator"
                pct11cu10.Image = SkinJucator
                Ok = False
            Else
                P(11, 10) = "Nimic"
                pct11cu10.Image = SkinNimic
            End If
        ElseIf P(11, 10) = "Jucator" Then
            P(11, 10) = "JucatorPeTinta"
            pct11cu10.Image = SkinJucatorPeTinta
        ElseIf P(11, 10) = "JucatorPeTinta" Then
            P(11, 10) = "Nimic"
            pct11cu10.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct11cu11_Click(sender As System.Object, e As System.EventArgs) Handles pct11cu11.MouseDown
        If P(11, 11) = "Nimic" Then
            P(11, 11) = "Perete"
            pct11cu11.Image = SkinPerete
        ElseIf P(11, 11) = "Perete" Then
            P(11, 11) = "Teren"
            pct11cu11.Image = SkinTeren
        ElseIf P(11, 11) = "Teren" Then
            P(11, 11) = "Cutie"
            pct11cu11.Image = SkinCutie
            Cutii += 1
        ElseIf P(11, 11) = "Cutie" Then
            P(11, 11) = "Tinta"
            pct11cu11.Image = SkinTinta
            Cutii -= 1
        ElseIf P(11, 11) = "Tinta" Then
            P(11, 11) = "Rezolvat"
            pct11cu11.Image = SkinRezolvat
        ElseIf P(11, 11) = "Rezolvat" Then
            If Ok Then
                P(11, 11) = "Jucator"
                pct11cu11.Image = SkinJucator
                Ok = False
            Else
                P(11, 11) = "Nimic"
                pct11cu11.Image = SkinNimic
            End If
        ElseIf P(11, 11) = "Jucator" Then
            P(11, 11) = "JucatorPeTinta"
            pct11cu11.Image = SkinJucatorPeTinta
        ElseIf P(11, 11) = "JucatorPeTinta" Then
            P(11, 11) = "Nimic"
            pct11cu11.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct11cu12_Click(sender As System.Object, e As System.EventArgs) Handles pct11cu12.MouseDown
        If P(11, 12) = "Nimic" Then
            P(11, 12) = "Perete"
            pct11cu12.Image = SkinPerete
        ElseIf P(11, 12) = "Perete" Then
            P(11, 12) = "Teren"
            pct11cu12.Image = SkinTeren
        ElseIf P(11, 12) = "Teren" Then
            P(11, 12) = "Cutie"
            pct11cu12.Image = SkinCutie
            Cutii += 1
        ElseIf P(11, 12) = "Cutie" Then
            P(11, 12) = "Tinta"
            pct11cu12.Image = SkinTinta
            Cutii -= 1
        ElseIf P(11, 12) = "Tinta" Then
            P(11, 12) = "Rezolvat"
            pct11cu12.Image = SkinRezolvat
        ElseIf P(11, 12) = "Rezolvat" Then
            If Ok Then
                P(11, 12) = "Jucator"
                pct11cu12.Image = SkinJucator
                Ok = False
            Else
                P(11, 12) = "Nimic"
                pct11cu12.Image = SkinNimic
            End If
        ElseIf P(11, 12) = "Jucator" Then
            P(11, 12) = "JucatorPeTinta"
            pct11cu12.Image = SkinJucatorPeTinta
        ElseIf P(11, 12) = "JucatorPeTinta" Then
            P(11, 12) = "Nimic"
            pct11cu12.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct11cu13_Click(sender As System.Object, e As System.EventArgs) Handles pct11cu13.MouseDown
        If P(11, 13) = "Nimic" Then
            P(11, 13) = "Perete"
            pct11cu13.Image = SkinPerete
        ElseIf P(11, 13) = "Perete" Then
            P(11, 13) = "Teren"
            pct11cu13.Image = SkinTeren
        ElseIf P(11, 13) = "Teren" Then
            P(11, 13) = "Cutie"
            pct11cu13.Image = SkinCutie
            Cutii += 1
        ElseIf P(11, 13) = "Cutie" Then
            P(11, 13) = "Tinta"
            pct11cu13.Image = SkinTinta
            Cutii -= 1
        ElseIf P(11, 13) = "Tinta" Then
            P(11, 13) = "Rezolvat"
            pct11cu13.Image = SkinRezolvat
        ElseIf P(11, 13) = "Rezolvat" Then
            If Ok Then
                P(11, 13) = "Jucator"
                pct11cu13.Image = SkinJucator
                Ok = False
            Else
                P(11, 13) = "Nimic"
                pct11cu13.Image = SkinNimic
            End If
        ElseIf P(11, 13) = "Jucator" Then
            P(11, 13) = "JucatorPeTinta"
            pct11cu13.Image = SkinJucatorPeTinta
        ElseIf P(11, 13) = "JucatorPeTinta" Then
            P(11, 13) = "Nimic"
            pct11cu13.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct11cu14_Click(sender As System.Object, e As System.EventArgs) Handles pct11cu14.MouseDown
        If P(11, 14) = "Nimic" Then
            P(11, 14) = "Perete"
            pct11cu14.Image = SkinPerete
        ElseIf P(11, 14) = "Perete" Then
            P(11, 14) = "Teren"
            pct11cu14.Image = SkinTeren
        ElseIf P(11, 14) = "Teren" Then
            P(11, 14) = "Cutie"
            pct11cu14.Image = SkinCutie
            Cutii += 1
        ElseIf P(11, 14) = "Cutie" Then
            P(11, 14) = "Tinta"
            pct11cu14.Image = SkinTinta
            Cutii -= 1
        ElseIf P(11, 14) = "Tinta" Then
            P(11, 14) = "Rezolvat"
            pct11cu14.Image = SkinRezolvat
        ElseIf P(11, 14) = "Rezolvat" Then
            If Ok Then
                P(11, 14) = "Jucator"
                pct11cu14.Image = SkinJucator
                Ok = False
            Else
                P(11, 14) = "Nimic"
                pct11cu14.Image = SkinNimic
            End If
        ElseIf P(11, 14) = "Jucator" Then
            P(11, 14) = "JucatorPeTinta"
            pct11cu14.Image = SkinJucatorPeTinta
        ElseIf P(11, 14) = "JucatorPeTinta" Then
            P(11, 14) = "Nimic"
            pct11cu14.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct12cu1_Click(sender As System.Object, e As System.EventArgs) Handles pct12cu1.MouseDown
        If P(12, 1) = "Nimic" Then
            P(12, 1) = "Perete"
            pct12cu1.Image = SkinPerete
        ElseIf P(12, 1) = "Perete" Then
            P(12, 1) = "Teren"
            pct12cu1.Image = SkinTeren
        ElseIf P(12, 1) = "Teren" Then
            P(12, 1) = "Cutie"
            pct12cu1.Image = SkinCutie
            Cutii += 1
        ElseIf P(12, 1) = "Cutie" Then
            P(12, 1) = "Tinta"
            pct12cu1.Image = SkinTinta
            Cutii -= 1
        ElseIf P(12, 1) = "Tinta" Then
            P(12, 1) = "Rezolvat"
            pct12cu1.Image = SkinRezolvat
        ElseIf P(12, 1) = "Rezolvat" Then
            If Ok Then
                P(12, 1) = "Jucator"
                pct12cu1.Image = SkinJucator
                Ok = False
            Else
                P(12, 1) = "Nimic"
                pct12cu1.Image = SkinNimic
            End If
        ElseIf P(12, 1) = "Jucator" Then
            P(12, 1) = "JucatorPeTinta"
            pct12cu1.Image = SkinJucatorPeTinta
        ElseIf P(12, 1) = "JucatorPeTinta" Then
            P(12, 1) = "Nimic"
            pct12cu1.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct12cu2_Click(sender As System.Object, e As System.EventArgs) Handles pct12cu2.MouseDown
        If P(12, 2) = "Nimic" Then
            P(12, 2) = "Perete"
            pct12cu2.Image = SkinPerete
        ElseIf P(12, 2) = "Perete" Then
            P(12, 2) = "Teren"
            pct12cu2.Image = SkinTeren
        ElseIf P(12, 2) = "Teren" Then
            P(12, 2) = "Cutie"
            pct12cu2.Image = SkinCutie
            Cutii += 1
        ElseIf P(12, 2) = "Cutie" Then
            P(12, 2) = "Tinta"
            pct12cu2.Image = SkinTinta
            Cutii -= 1
        ElseIf P(12, 2) = "Tinta" Then
            P(12, 2) = "Rezolvat"
            pct12cu2.Image = SkinRezolvat
        ElseIf P(12, 2) = "Rezolvat" Then
            If Ok Then
                P(12, 2) = "Jucator"
                pct12cu2.Image = SkinJucator
                Ok = False
            Else
                P(12, 2) = "Nimic"
                pct12cu2.Image = SkinNimic
            End If
        ElseIf P(12, 2) = "Jucator" Then
            P(12, 2) = "JucatorPeTinta"
            pct12cu2.Image = SkinJucatorPeTinta
        ElseIf P(12, 2) = "JucatorPeTinta" Then
            P(12, 2) = "Nimic"
            pct12cu2.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct12cu3_Click(sender As System.Object, e As System.EventArgs) Handles pct12cu3.MouseDown
        If P(12, 3) = "Nimic" Then
            P(12, 3) = "Perete"
            pct12cu3.Image = SkinPerete
        ElseIf P(12, 3) = "Perete" Then
            P(12, 3) = "Teren"
            pct12cu3.Image = SkinTeren
        ElseIf P(12, 3) = "Teren" Then
            P(12, 3) = "Cutie"
            pct12cu3.Image = SkinCutie
            Cutii += 1
        ElseIf P(12, 3) = "Cutie" Then
            P(12, 3) = "Tinta"
            pct12cu3.Image = SkinTinta
            Cutii -= 1
        ElseIf P(12, 3) = "Tinta" Then
            P(12, 3) = "Rezolvat"
            pct12cu3.Image = SkinRezolvat
        ElseIf P(12, 3) = "Rezolvat" Then
            If Ok Then
                P(12, 3) = "Jucator"
                pct12cu3.Image = SkinJucator
                Ok = False
            Else
                P(12, 3) = "Nimic"
                pct12cu3.Image = SkinNimic
            End If
        ElseIf P(12, 3) = "Jucator" Then
            P(12, 3) = "JucatorPeTinta"
            pct12cu3.Image = SkinJucatorPeTinta
        ElseIf P(12, 3) = "JucatorPeTinta" Then
            P(12, 3) = "Nimic"
            pct12cu3.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct12cu4_Click(sender As System.Object, e As System.EventArgs) Handles pct12cu4.MouseDown
        If P(12, 4) = "Nimic" Then
            P(12, 4) = "Perete"
            pct12cu4.Image = SkinPerete
        ElseIf P(12, 4) = "Perete" Then
            P(12, 4) = "Teren"
            pct12cu4.Image = SkinTeren
        ElseIf P(12, 4) = "Teren" Then
            P(12, 4) = "Cutie"
            pct12cu4.Image = SkinCutie
            Cutii += 1
        ElseIf P(12, 4) = "Cutie" Then
            P(12, 4) = "Tinta"
            pct12cu4.Image = SkinTinta
            Cutii -= 1
        ElseIf P(12, 4) = "Tinta" Then
            P(12, 4) = "Rezolvat"
            pct12cu4.Image = SkinRezolvat
        ElseIf P(12, 4) = "Rezolvat" Then
            If Ok Then
                P(12, 4) = "Jucator"
                pct12cu4.Image = SkinJucator
                Ok = False
            Else
                P(12, 4) = "Nimic"
                pct12cu4.Image = SkinNimic
            End If
        ElseIf P(12, 4) = "Jucator" Then
            P(12, 4) = "JucatorPeTinta"
            pct12cu4.Image = SkinJucatorPeTinta
        ElseIf P(12, 4) = "JucatorPeTinta" Then
            P(12, 4) = "Nimic"
            pct12cu4.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct12cu5_Click(sender As System.Object, e As System.EventArgs) Handles pct12cu5.MouseDown
        If P(12, 5) = "Nimic" Then
            P(12, 5) = "Perete"
            pct12cu5.Image = SkinPerete
        ElseIf P(12, 5) = "Perete" Then
            P(12, 5) = "Teren"
            pct12cu5.Image = SkinTeren
        ElseIf P(12, 5) = "Teren" Then
            P(12, 5) = "Cutie"
            pct12cu5.Image = SkinCutie
            Cutii += 1
        ElseIf P(12, 5) = "Cutie" Then
            P(12, 5) = "Tinta"
            pct12cu5.Image = SkinTinta
            Cutii -= 1
        ElseIf P(12, 5) = "Tinta" Then
            P(12, 5) = "Rezolvat"
            pct12cu5.Image = SkinRezolvat
        ElseIf P(12, 5) = "Rezolvat" Then
            If Ok Then
                P(12, 5) = "Jucator"
                pct12cu5.Image = SkinJucator
                Ok = False
            Else
                P(12, 5) = "Nimic"
                pct12cu5.Image = SkinNimic
            End If
        ElseIf P(12, 5) = "Jucator" Then
            P(12, 5) = "JucatorPeTinta"
            pct12cu5.Image = SkinJucatorPeTinta
        ElseIf P(12, 5) = "JucatorPeTinta" Then
            P(12, 5) = "Nimic"
            pct12cu5.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct12cu6_Click(sender As System.Object, e As System.EventArgs) Handles pct12cu6.MouseDown
        If P(12, 6) = "Nimic" Then
            P(12, 6) = "Perete"
            pct12cu6.Image = SkinPerete
        ElseIf P(12, 6) = "Perete" Then
            P(12, 6) = "Teren"
            pct12cu6.Image = SkinTeren
        ElseIf P(12, 6) = "Teren" Then
            P(12, 6) = "Cutie"
            pct12cu6.Image = SkinCutie
            Cutii += 1
        ElseIf P(12, 6) = "Cutie" Then
            P(12, 6) = "Tinta"
            pct12cu6.Image = SkinTinta
            Cutii -= 1
        ElseIf P(12, 6) = "Tinta" Then
            P(12, 6) = "Rezolvat"
            pct12cu6.Image = SkinRezolvat
        ElseIf P(12, 6) = "Rezolvat" Then
            If Ok Then
                P(12, 6) = "Jucator"
                pct12cu6.Image = SkinJucator
                Ok = False
            Else
                P(12, 6) = "Nimic"
                pct12cu6.Image = SkinNimic
            End If
        ElseIf P(12, 6) = "Jucator" Then
            P(12, 6) = "JucatorPeTinta"
            pct12cu6.Image = SkinJucatorPeTinta
        ElseIf P(12, 6) = "JucatorPeTinta" Then
            P(12, 6) = "Nimic"
            pct12cu6.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct12cu7_Click(sender As System.Object, e As System.EventArgs) Handles pct12cu7.MouseDown
        If P(12, 7) = "Nimic" Then
            P(12, 7) = "Perete"
            pct12cu7.Image = SkinPerete
        ElseIf P(12, 7) = "Perete" Then
            P(12, 7) = "Teren"
            pct12cu7.Image = SkinTeren
        ElseIf P(12, 7) = "Teren" Then
            P(12, 7) = "Cutie"
            pct12cu7.Image = SkinCutie
            Cutii += 1
        ElseIf P(12, 7) = "Cutie" Then
            P(12, 7) = "Tinta"
            pct12cu7.Image = SkinTinta
            Cutii -= 1
        ElseIf P(12, 7) = "Tinta" Then
            P(12, 7) = "Rezolvat"
            pct12cu7.Image = SkinRezolvat
        ElseIf P(12, 7) = "Rezolvat" Then
            If Ok Then
                P(12, 7) = "Jucator"
                pct12cu7.Image = SkinJucator
                Ok = False
            Else
                P(12, 7) = "Nimic"
                pct12cu7.Image = SkinNimic
            End If
        ElseIf P(12, 7) = "Jucator" Then
            P(12, 7) = "JucatorPeTinta"
            pct12cu7.Image = SkinJucatorPeTinta
        ElseIf P(12, 7) = "JucatorPeTinta" Then
            P(12, 7) = "Nimic"
            pct12cu7.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct12cu8_Click(sender As System.Object, e As System.EventArgs) Handles pct12cu8.MouseDown
        If P(12, 8) = "Nimic" Then
            P(12, 8) = "Perete"
            pct12cu8.Image = SkinPerete
        ElseIf P(12, 8) = "Perete" Then
            P(12, 8) = "Teren"
            pct12cu8.Image = SkinTeren
        ElseIf P(12, 8) = "Teren" Then
            P(12, 8) = "Cutie"
            pct12cu8.Image = SkinCutie
            Cutii += 1
        ElseIf P(12, 8) = "Cutie" Then
            P(12, 8) = "Tinta"
            pct12cu8.Image = SkinTinta
            Cutii -= 1
        ElseIf P(12, 8) = "Tinta" Then
            P(12, 8) = "Rezolvat"
            pct12cu8.Image = SkinRezolvat
        ElseIf P(12, 8) = "Rezolvat" Then
            If Ok Then
                P(12, 8) = "Jucator"
                pct12cu8.Image = SkinJucator
                Ok = False
            Else
                P(12, 8) = "Nimic"
                pct12cu8.Image = SkinNimic
            End If
        ElseIf P(12, 8) = "Jucator" Then
            P(12, 8) = "JucatorPeTinta"
            pct12cu8.Image = SkinJucatorPeTinta
        ElseIf P(12, 8) = "JucatorPeTinta" Then
            P(12, 8) = "Nimic"
            pct12cu8.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct12cu9_Click(sender As System.Object, e As System.EventArgs) Handles pct12cu9.MouseDown
        If P(12, 9) = "Nimic" Then
            P(12, 9) = "Perete"
            pct12cu9.Image = SkinPerete
        ElseIf P(12, 9) = "Perete" Then
            P(12, 9) = "Teren"
            pct12cu9.Image = SkinTeren
        ElseIf P(12, 9) = "Teren" Then
            P(12, 9) = "Cutie"
            pct12cu9.Image = SkinCutie
            Cutii += 1
        ElseIf P(12, 9) = "Cutie" Then
            P(12, 9) = "Tinta"
            pct12cu9.Image = SkinTinta
            Cutii -= 1
        ElseIf P(12, 9) = "Tinta" Then
            P(12, 9) = "Rezolvat"
            pct12cu9.Image = SkinRezolvat
        ElseIf P(12, 9) = "Rezolvat" Then
            If Ok Then
                P(12, 9) = "Jucator"
                pct12cu9.Image = SkinJucator
                Ok = False
            Else
                P(12, 9) = "Nimic"
                pct12cu9.Image = SkinNimic
            End If
        ElseIf P(12, 9) = "Jucator" Then
            P(12, 9) = "JucatorPeTinta"
            pct12cu9.Image = SkinJucatorPeTinta
        ElseIf P(12, 9) = "JucatorPeTinta" Then
            P(12, 9) = "Nimic"
            pct12cu9.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct12cu10_Click(sender As System.Object, e As System.EventArgs) Handles pct12cu10.MouseDown
        If P(12, 10) = "Nimic" Then
            P(12, 10) = "Perete"
            pct12cu10.Image = SkinPerete
        ElseIf P(12, 10) = "Perete" Then
            P(12, 10) = "Teren"
            pct12cu10.Image = SkinTeren
        ElseIf P(12, 10) = "Teren" Then
            P(12, 10) = "Cutie"
            pct12cu10.Image = SkinCutie
            Cutii += 1
        ElseIf P(12, 10) = "Cutie" Then
            P(12, 10) = "Tinta"
            pct12cu10.Image = SkinTinta
            Cutii -= 1
        ElseIf P(12, 10) = "Tinta" Then
            P(12, 10) = "Rezolvat"
            pct12cu10.Image = SkinRezolvat
        ElseIf P(12, 10) = "Rezolvat" Then
            If Ok Then
                P(12, 10) = "Jucator"
                pct12cu10.Image = SkinJucator
                Ok = False
            Else
                P(12, 10) = "Nimic"
                pct12cu10.Image = SkinNimic
            End If
        ElseIf P(12, 10) = "Jucator" Then
            P(12, 10) = "JucatorPeTinta"
            pct12cu10.Image = SkinJucatorPeTinta
        ElseIf P(12, 10) = "JucatorPeTinta" Then
            P(12, 10) = "Nimic"
            pct12cu10.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct12cu11_Click(sender As System.Object, e As System.EventArgs) Handles pct12cu11.MouseDown
        If P(12, 11) = "Nimic" Then
            P(12, 11) = "Perete"
            pct12cu11.Image = SkinPerete
        ElseIf P(12, 11) = "Perete" Then
            P(12, 11) = "Teren"
            pct12cu11.Image = SkinTeren
        ElseIf P(12, 11) = "Teren" Then
            P(12, 11) = "Cutie"
            pct12cu11.Image = SkinCutie
            Cutii += 1
        ElseIf P(12, 11) = "Cutie" Then
            P(12, 11) = "Tinta"
            pct12cu11.Image = SkinTinta
            Cutii -= 1
        ElseIf P(12, 11) = "Tinta" Then
            P(12, 11) = "Rezolvat"
            pct12cu11.Image = SkinRezolvat
        ElseIf P(12, 11) = "Rezolvat" Then
            If Ok Then
                P(12, 11) = "Jucator"
                pct12cu11.Image = SkinJucator
                Ok = False
            Else
                P(12, 11) = "Nimic"
                pct12cu11.Image = SkinNimic
            End If
        ElseIf P(12, 11) = "Jucator" Then
            P(12, 11) = "JucatorPeTinta"
            pct12cu11.Image = SkinJucatorPeTinta
        ElseIf P(12, 11) = "JucatorPeTinta" Then
            P(12, 11) = "Nimic"
            pct12cu11.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct12cu12_Click(sender As System.Object, e As System.EventArgs) Handles pct12cu12.MouseDown
        If P(12, 12) = "Nimic" Then
            P(12, 12) = "Perete"
            pct12cu12.Image = SkinPerete
        ElseIf P(12, 12) = "Perete" Then
            P(12, 12) = "Teren"
            pct12cu12.Image = SkinTeren
        ElseIf P(12, 12) = "Teren" Then
            P(12, 12) = "Cutie"
            pct12cu12.Image = SkinCutie
            Cutii += 1
        ElseIf P(12, 12) = "Cutie" Then
            P(12, 12) = "Tinta"
            pct12cu12.Image = SkinTinta
            Cutii -= 1
        ElseIf P(12, 12) = "Tinta" Then
            P(12, 12) = "Rezolvat"
            pct12cu12.Image = SkinRezolvat
        ElseIf P(12, 12) = "Rezolvat" Then
            If Ok Then
                P(12, 12) = "Jucator"
                pct12cu12.Image = SkinJucator
                Ok = False
            Else
                P(12, 12) = "Nimic"
                pct12cu12.Image = SkinNimic
            End If
        ElseIf P(12, 12) = "Jucator" Then
            P(12, 12) = "JucatorPeTinta"
            pct12cu12.Image = SkinJucatorPeTinta
        ElseIf P(12, 12) = "JucatorPeTinta" Then
            P(12, 12) = "Nimic"
            pct12cu12.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct12cu13_Click(sender As System.Object, e As System.EventArgs) Handles pct12cu13.MouseDown
        If P(12, 13) = "Nimic" Then
            P(12, 13) = "Perete"
            pct12cu13.Image = SkinPerete
        ElseIf P(12, 13) = "Perete" Then
            P(12, 13) = "Teren"
            pct12cu13.Image = SkinTeren
        ElseIf P(12, 13) = "Teren" Then
            P(12, 13) = "Cutie"
            pct12cu13.Image = SkinCutie
            Cutii += 1
        ElseIf P(12, 13) = "Cutie" Then
            P(12, 13) = "Tinta"
            pct12cu13.Image = SkinTinta
            Cutii -= 1
        ElseIf P(12, 13) = "Tinta" Then
            P(12, 13) = "Rezolvat"
            pct12cu13.Image = SkinRezolvat
        ElseIf P(12, 13) = "Rezolvat" Then
            If Ok Then
                P(12, 13) = "Jucator"
                pct12cu13.Image = SkinJucator
                Ok = False
            Else
                P(12, 13) = "Nimic"
                pct12cu13.Image = SkinNimic
            End If
        ElseIf P(12, 13) = "Jucator" Then
            P(12, 13) = "JucatorPeTinta"
            pct12cu13.Image = SkinJucatorPeTinta
        ElseIf P(12, 13) = "JucatorPeTinta" Then
            P(12, 13) = "Nimic"
            pct12cu13.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct12cu14_Click(sender As System.Object, e As System.EventArgs) Handles pct12cu14.MouseDown
        If P(12, 14) = "Nimic" Then
            P(12, 14) = "Perete"
            pct12cu14.Image = SkinPerete
        ElseIf P(12, 14) = "Perete" Then
            P(12, 14) = "Teren"
            pct12cu14.Image = SkinTeren
        ElseIf P(12, 14) = "Teren" Then
            P(12, 14) = "Cutie"
            pct12cu14.Image = SkinCutie
            Cutii += 1
        ElseIf P(12, 14) = "Cutie" Then
            P(12, 14) = "Tinta"
            pct12cu14.Image = SkinTinta
            Cutii -= 1
        ElseIf P(12, 14) = "Tinta" Then
            P(12, 14) = "Rezolvat"
            pct12cu14.Image = SkinRezolvat
        ElseIf P(12, 14) = "Rezolvat" Then
            If Ok Then
                P(12, 14) = "Jucator"
                pct12cu14.Image = SkinJucator
                Ok = False
            Else
                P(12, 14) = "Nimic"
                pct12cu14.Image = SkinNimic
            End If
        ElseIf P(12, 14) = "Jucator" Then
            P(12, 14) = "JucatorPeTinta"
            pct12cu14.Image = SkinJucatorPeTinta
        ElseIf P(12, 14) = "JucatorPeTinta" Then
            P(12, 14) = "Nimic"
            pct12cu14.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct13cu1_Click(sender As System.Object, e As System.EventArgs) Handles pct13cu1.MouseDown
        If P(13, 1) = "Nimic" Then
            P(13, 1) = "Perete"
            pct13cu1.Image = SkinPerete
        ElseIf P(13, 1) = "Perete" Then
            P(13, 1) = "Teren"
            pct13cu1.Image = SkinTeren
        ElseIf P(13, 1) = "Teren" Then
            P(13, 1) = "Cutie"
            pct13cu1.Image = SkinCutie
            Cutii += 1
        ElseIf P(13, 1) = "Cutie" Then
            P(13, 1) = "Tinta"
            pct13cu1.Image = SkinTinta
            Cutii -= 1
        ElseIf P(13, 1) = "Tinta" Then
            P(13, 1) = "Rezolvat"
            pct13cu1.Image = SkinRezolvat
        ElseIf P(13, 1) = "Rezolvat" Then
            If Ok Then
                P(13, 1) = "Jucator"
                pct13cu1.Image = SkinJucator
                Ok = False
            Else
                P(13, 1) = "Nimic"
                pct13cu1.Image = SkinNimic
            End If
        ElseIf P(13, 1) = "Jucator" Then
            P(13, 1) = "JucatorPeTinta"
            pct13cu1.Image = SkinJucatorPeTinta
        ElseIf P(13, 1) = "JucatorPeTinta" Then
            P(13, 1) = "Nimic"
            pct13cu1.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct13cu2_Click(sender As System.Object, e As System.EventArgs) Handles pct13cu2.MouseDown
        If P(13, 2) = "Nimic" Then
            P(13, 2) = "Perete"
            pct13cu2.Image = SkinPerete
        ElseIf P(13, 2) = "Perete" Then
            P(13, 2) = "Teren"
            pct13cu2.Image = SkinTeren
        ElseIf P(13, 2) = "Teren" Then
            P(13, 2) = "Cutie"
            pct13cu2.Image = SkinCutie
            Cutii += 1
        ElseIf P(13, 2) = "Cutie" Then
            P(13, 2) = "Tinta"
            pct13cu2.Image = SkinTinta
            Cutii -= 1
        ElseIf P(13, 2) = "Tinta" Then
            P(13, 2) = "Rezolvat"
            pct13cu2.Image = SkinRezolvat
        ElseIf P(13, 2) = "Rezolvat" Then
            If Ok Then
                P(13, 2) = "Jucator"
                pct13cu2.Image = SkinJucator
                Ok = False
            Else
                P(13, 2) = "Nimic"
                pct13cu2.Image = SkinNimic
            End If
        ElseIf P(13, 2) = "Jucator" Then
            P(13, 2) = "JucatorPeTinta"
            pct13cu2.Image = SkinJucatorPeTinta
        ElseIf P(13, 2) = "JucatorPeTinta" Then
            P(13, 2) = "Nimic"
            pct13cu2.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct13cu3_Click(sender As System.Object, e As System.EventArgs) Handles pct13cu3.MouseDown
        If P(13, 3) = "Nimic" Then
            P(13, 3) = "Perete"
            pct13cu3.Image = SkinPerete
        ElseIf P(13, 3) = "Perete" Then
            P(13, 3) = "Teren"
            pct13cu3.Image = SkinTeren
        ElseIf P(13, 3) = "Teren" Then
            P(13, 3) = "Cutie"
            pct13cu3.Image = SkinCutie
            Cutii += 1
        ElseIf P(13, 3) = "Cutie" Then
            P(13, 3) = "Tinta"
            pct13cu3.Image = SkinTinta
            Cutii -= 1
        ElseIf P(13, 3) = "Tinta" Then
            P(13, 3) = "Rezolvat"
            pct13cu3.Image = SkinRezolvat
        ElseIf P(13, 3) = "Rezolvat" Then
            If Ok Then
                P(13, 3) = "Jucator"
                pct13cu3.Image = SkinJucator
                Ok = False
            Else
                P(13, 3) = "Nimic"
                pct13cu3.Image = SkinNimic
            End If
        ElseIf P(13, 3) = "Jucator" Then
            P(13, 3) = "JucatorPeTinta"
            pct13cu3.Image = SkinJucatorPeTinta
        ElseIf P(13, 3) = "JucatorPeTinta" Then
            P(13, 3) = "Nimic"
            pct13cu3.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct13cu4_Click(sender As System.Object, e As System.EventArgs) Handles pct13cu4.MouseDown
        If P(13, 4) = "Nimic" Then
            P(13, 4) = "Perete"
            pct13cu4.Image = SkinPerete
        ElseIf P(13, 4) = "Perete" Then
            P(13, 4) = "Teren"
            pct13cu4.Image = SkinTeren
        ElseIf P(13, 4) = "Teren" Then
            P(13, 4) = "Cutie"
            pct13cu4.Image = SkinCutie
            Cutii += 1
        ElseIf P(13, 4) = "Cutie" Then
            P(13, 4) = "Tinta"
            pct13cu4.Image = SkinTinta
            Cutii -= 1
        ElseIf P(13, 4) = "Tinta" Then
            P(13, 4) = "Rezolvat"
            pct13cu4.Image = SkinRezolvat
        ElseIf P(13, 4) = "Rezolvat" Then
            If Ok Then
                P(13, 4) = "Jucator"
                pct13cu4.Image = SkinJucator
                Ok = False
            Else
                P(13, 4) = "Nimic"
                pct13cu4.Image = SkinNimic
            End If
        ElseIf P(13, 4) = "Jucator" Then
            P(13, 4) = "JucatorPeTinta"
            pct13cu4.Image = SkinJucatorPeTinta
        ElseIf P(13, 4) = "JucatorPeTinta" Then
            P(13, 4) = "Nimic"
            pct13cu4.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct13cu5_Click(sender As System.Object, e As System.EventArgs) Handles pct13cu5.MouseDown
        If P(13, 5) = "Nimic" Then
            P(13, 5) = "Perete"
            pct13cu5.Image = SkinPerete
        ElseIf P(13, 5) = "Perete" Then
            P(13, 5) = "Teren"
            pct13cu5.Image = SkinTeren
        ElseIf P(13, 5) = "Teren" Then
            P(13, 5) = "Cutie"
            pct13cu5.Image = SkinCutie
            Cutii += 1
        ElseIf P(13, 5) = "Cutie" Then
            P(13, 5) = "Tinta"
            pct13cu5.Image = SkinTinta
            Cutii -= 1
        ElseIf P(13, 5) = "Tinta" Then
            P(13, 5) = "Rezolvat"
            pct13cu5.Image = SkinRezolvat
        ElseIf P(13, 5) = "Rezolvat" Then
            If Ok Then
                P(13, 5) = "Jucator"
                pct13cu5.Image = SkinJucator
                Ok = False
            Else
                P(13, 5) = "Nimic"
                pct13cu5.Image = SkinNimic
            End If
        ElseIf P(13, 5) = "Jucator" Then
            P(13, 5) = "JucatorPeTinta"
            pct13cu5.Image = SkinJucatorPeTinta
        ElseIf P(13, 5) = "JucatorPeTinta" Then
            P(13, 5) = "Nimic"
            pct13cu5.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct13cu6_Click(sender As System.Object, e As System.EventArgs) Handles pct13cu6.MouseDown
        If P(13, 6) = "Nimic" Then
            P(13, 6) = "Perete"
            pct13cu6.Image = SkinPerete
        ElseIf P(13, 6) = "Perete" Then
            P(13, 6) = "Teren"
            pct13cu6.Image = SkinTeren
        ElseIf P(13, 6) = "Teren" Then
            P(13, 6) = "Cutie"
            pct13cu6.Image = SkinCutie
            Cutii += 1
        ElseIf P(13, 6) = "Cutie" Then
            P(13, 6) = "Tinta"
            pct13cu6.Image = SkinTinta
            Cutii -= 1
        ElseIf P(13, 6) = "Tinta" Then
            P(13, 6) = "Rezolvat"
            pct13cu6.Image = SkinRezolvat
        ElseIf P(13, 6) = "Rezolvat" Then
            If Ok Then
                P(13, 6) = "Jucator"
                pct13cu6.Image = SkinJucator
                Ok = False
            Else
                P(13, 6) = "Nimic"
                pct13cu6.Image = SkinNimic
            End If
        ElseIf P(13, 6) = "Jucator" Then
            P(13, 6) = "JucatorPeTinta"
            pct13cu6.Image = SkinJucatorPeTinta
        ElseIf P(13, 6) = "JucatorPeTinta" Then
            P(13, 6) = "Nimic"
            pct13cu6.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct13cu7_Click(sender As System.Object, e As System.EventArgs) Handles pct13cu7.MouseDown
        If P(13, 7) = "Nimic" Then
            P(13, 7) = "Perete"
            pct13cu7.Image = SkinPerete
        ElseIf P(13, 7) = "Perete" Then
            P(13, 7) = "Teren"
            pct13cu7.Image = SkinTeren
        ElseIf P(13, 7) = "Teren" Then
            P(13, 7) = "Cutie"
            pct13cu7.Image = SkinCutie
            Cutii += 1
        ElseIf P(13, 7) = "Cutie" Then
            P(13, 7) = "Tinta"
            pct13cu7.Image = SkinTinta
            Cutii -= 1
        ElseIf P(13, 7) = "Tinta" Then
            P(13, 7) = "Rezolvat"
            pct13cu7.Image = SkinRezolvat
        ElseIf P(13, 7) = "Rezolvat" Then
            If Ok Then
                P(13, 7) = "Jucator"
                pct13cu7.Image = SkinJucator
                Ok = False
            Else
                P(13, 7) = "Nimic"
                pct13cu7.Image = SkinNimic
            End If
        ElseIf P(13, 7) = "Jucator" Then
            P(13, 7) = "JucatorPeTinta"
            pct13cu7.Image = SkinJucatorPeTinta
        ElseIf P(13, 7) = "JucatorPeTinta" Then
            P(13, 7) = "Nimic"
            pct13cu7.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct13cu8_Click(sender As System.Object, e As System.EventArgs) Handles pct13cu8.MouseDown
        If P(13, 8) = "Nimic" Then
            P(13, 8) = "Perete"
            pct13cu8.Image = SkinPerete
        ElseIf P(13, 8) = "Perete" Then
            P(13, 8) = "Teren"
            pct13cu8.Image = SkinTeren
        ElseIf P(13, 8) = "Teren" Then
            P(13, 8) = "Cutie"
            pct13cu8.Image = SkinCutie
            Cutii += 1
        ElseIf P(13, 8) = "Cutie" Then
            P(13, 8) = "Tinta"
            pct13cu8.Image = SkinTinta
            Cutii -= 1
        ElseIf P(13, 8) = "Tinta" Then
            P(13, 8) = "Rezolvat"
            pct13cu8.Image = SkinRezolvat
        ElseIf P(13, 8) = "Rezolvat" Then
            If Ok Then
                P(13, 8) = "Jucator"
                pct13cu8.Image = SkinJucator
                Ok = False
            Else
                P(13, 8) = "Nimic"
                pct13cu8.Image = SkinNimic
            End If
        ElseIf P(13, 8) = "Jucator" Then
            P(13, 8) = "JucatorPeTinta"
            pct13cu8.Image = SkinJucatorPeTinta
        ElseIf P(13, 8) = "JucatorPeTinta" Then
            P(13, 8) = "Nimic"
            pct13cu8.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct13cu9_Click(sender As System.Object, e As System.EventArgs) Handles pct13cu9.MouseDown
        If P(13, 9) = "Nimic" Then
            P(13, 9) = "Perete"
            pct13cu9.Image = SkinPerete
        ElseIf P(13, 9) = "Perete" Then
            P(13, 9) = "Teren"
            pct13cu9.Image = SkinTeren
        ElseIf P(13, 9) = "Teren" Then
            P(13, 9) = "Cutie"
            pct13cu9.Image = SkinCutie
            Cutii += 1
        ElseIf P(13, 9) = "Cutie" Then
            P(13, 9) = "Tinta"
            pct13cu9.Image = SkinTinta
            Cutii -= 1
        ElseIf P(13, 9) = "Tinta" Then
            P(13, 9) = "Rezolvat"
            pct13cu9.Image = SkinRezolvat
        ElseIf P(13, 9) = "Rezolvat" Then
            If Ok Then
                P(13, 9) = "Jucator"
                pct13cu9.Image = SkinJucator
                Ok = False
            Else
                P(13, 9) = "Nimic"
                pct13cu9.Image = SkinNimic
            End If
        ElseIf P(13, 9) = "Jucator" Then
            P(13, 9) = "JucatorPeTinta"
            pct13cu9.Image = SkinJucatorPeTinta
        ElseIf P(13, 9) = "JucatorPeTinta" Then
            P(13, 9) = "Nimic"
            pct13cu9.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct13cu10_Click(sender As System.Object, e As System.EventArgs) Handles pct13cu10.MouseDown
        If P(13, 10) = "Nimic" Then
            P(13, 10) = "Perete"
            pct13cu10.Image = SkinPerete
        ElseIf P(13, 10) = "Perete" Then
            P(13, 10) = "Teren"
            pct13cu10.Image = SkinTeren
        ElseIf P(13, 10) = "Teren" Then
            P(13, 10) = "Cutie"
            pct13cu10.Image = SkinCutie
            Cutii += 1
        ElseIf P(13, 10) = "Cutie" Then
            P(13, 10) = "Tinta"
            pct13cu10.Image = SkinTinta
            Cutii -= 1
        ElseIf P(13, 10) = "Tinta" Then
            P(13, 10) = "Rezolvat"
            pct13cu10.Image = SkinRezolvat
        ElseIf P(13, 10) = "Rezolvat" Then
            If Ok Then
                P(13, 10) = "Jucator"
                pct13cu10.Image = SkinJucator
                Ok = False
            Else
                P(13, 10) = "Nimic"
                pct13cu10.Image = SkinNimic
            End If
        ElseIf P(13, 10) = "Jucator" Then
            P(13, 10) = "JucatorPeTinta"
            pct13cu10.Image = SkinJucatorPeTinta
        ElseIf P(13, 10) = "JucatorPeTinta" Then
            P(13, 10) = "Nimic"
            pct13cu10.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct13cu11_Click(sender As System.Object, e As System.EventArgs) Handles pct13cu11.MouseDown
        If P(13, 11) = "Nimic" Then
            P(13, 11) = "Perete"
            pct13cu11.Image = SkinPerete
        ElseIf P(13, 11) = "Perete" Then
            P(13, 11) = "Teren"
            pct13cu11.Image = SkinTeren
        ElseIf P(13, 11) = "Teren" Then
            P(13, 11) = "Cutie"
            pct13cu11.Image = SkinCutie
            Cutii += 1
        ElseIf P(13, 11) = "Cutie" Then
            P(13, 11) = "Tinta"
            pct13cu11.Image = SkinTinta
            Cutii -= 1
        ElseIf P(13, 11) = "Tinta" Then
            P(13, 11) = "Rezolvat"
            pct13cu11.Image = SkinRezolvat
        ElseIf P(13, 11) = "Rezolvat" Then
            If Ok Then
                P(13, 11) = "Jucator"
                pct13cu11.Image = SkinJucator
                Ok = False
            Else
                P(13, 11) = "Nimic"
                pct13cu11.Image = SkinNimic
            End If
        ElseIf P(13, 11) = "Jucator" Then
            P(13, 11) = "JucatorPeTinta"
            pct13cu11.Image = SkinJucatorPeTinta
        ElseIf P(13, 11) = "JucatorPeTinta" Then
            P(13, 11) = "Nimic"
            pct13cu11.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct13cu12_Click(sender As System.Object, e As System.EventArgs) Handles pct13cu12.MouseDown
        If P(13, 12) = "Nimic" Then
            P(13, 12) = "Perete"
            pct13cu12.Image = SkinPerete
        ElseIf P(13, 12) = "Perete" Then
            P(13, 12) = "Teren"
            pct13cu12.Image = SkinTeren
        ElseIf P(13, 12) = "Teren" Then
            P(13, 12) = "Cutie"
            pct13cu12.Image = SkinCutie
            Cutii += 1
        ElseIf P(13, 12) = "Cutie" Then
            P(13, 12) = "Tinta"
            pct13cu12.Image = SkinTinta
            Cutii -= 1
        ElseIf P(13, 12) = "Tinta" Then
            P(13, 12) = "Rezolvat"
            pct13cu12.Image = SkinRezolvat
        ElseIf P(13, 12) = "Rezolvat" Then
            If Ok Then
                P(13, 12) = "Jucator"
                pct13cu12.Image = SkinJucator
                Ok = False
            Else
                P(13, 12) = "Nimic"
                pct13cu12.Image = SkinNimic
            End If
        ElseIf P(13, 12) = "Jucator" Then
            P(13, 12) = "JucatorPeTinta"
            pct13cu12.Image = SkinJucatorPeTinta
        ElseIf P(13, 12) = "JucatorPeTinta" Then
            P(13, 12) = "Nimic"
            pct13cu12.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct13cu13_Click(sender As System.Object, e As System.EventArgs) Handles pct13cu13.MouseDown
        If P(13, 13) = "Nimic" Then
            P(13, 13) = "Perete"
            pct13cu13.Image = SkinPerete
        ElseIf P(13, 13) = "Perete" Then
            P(13, 13) = "Teren"
            pct13cu13.Image = SkinTeren
        ElseIf P(13, 13) = "Teren" Then
            P(13, 13) = "Cutie"
            pct13cu13.Image = SkinCutie
            Cutii += 1
        ElseIf P(13, 13) = "Cutie" Then
            P(13, 13) = "Tinta"
            pct13cu13.Image = SkinTinta
            Cutii -= 1
        ElseIf P(13, 13) = "Tinta" Then
            P(13, 13) = "Rezolvat"
            pct13cu13.Image = SkinRezolvat
        ElseIf P(13, 13) = "Rezolvat" Then
            If Ok Then
                P(13, 13) = "Jucator"
                pct13cu13.Image = SkinJucator
                Ok = False
            Else
                P(13, 13) = "Nimic"
                pct13cu13.Image = SkinNimic
            End If
        ElseIf P(13, 13) = "Jucator" Then
            P(13, 13) = "JucatorPeTinta"
            pct13cu13.Image = SkinJucatorPeTinta
        ElseIf P(13, 13) = "JucatorPeTinta" Then
            P(13, 13) = "Nimic"
            pct13cu13.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct13cu14_Click(sender As System.Object, e As System.EventArgs) Handles pct13cu14.MouseDown
        If P(13, 14) = "Nimic" Then
            P(13, 14) = "Perete"
            pct13cu14.Image = SkinPerete
        ElseIf P(13, 14) = "Perete" Then
            P(13, 14) = "Teren"
            pct13cu14.Image = SkinTeren
        ElseIf P(13, 14) = "Teren" Then
            P(13, 14) = "Cutie"
            pct13cu14.Image = SkinCutie
            Cutii += 1
        ElseIf P(13, 14) = "Cutie" Then
            P(13, 14) = "Tinta"
            pct13cu14.Image = SkinTinta
            Cutii -= 1
        ElseIf P(13, 14) = "Tinta" Then
            P(13, 14) = "Rezolvat"
            pct13cu14.Image = SkinRezolvat
        ElseIf P(13, 14) = "Rezolvat" Then
            If Ok Then
                P(13, 14) = "Jucator"
                pct13cu14.Image = SkinJucator
                Ok = False
            Else
                P(13, 14) = "Nimic"
                pct13cu14.Image = SkinNimic
            End If
        ElseIf P(13, 14) = "Jucator" Then
            P(13, 14) = "JucatorPeTinta"
            pct13cu14.Image = SkinJucatorPeTinta
        ElseIf P(13, 14) = "JucatorPeTinta" Then
            P(13, 14) = "Nimic"
            pct13cu14.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct14cu1_Click(sender As System.Object, e As System.EventArgs) Handles pct14cu1.MouseDown
        If P(14, 1) = "Nimic" Then
            P(14, 1) = "Perete"
            pct14cu1.Image = SkinPerete
        ElseIf P(14, 1) = "Perete" Then
            P(14, 1) = "Teren"
            pct14cu1.Image = SkinTeren
        ElseIf P(14, 1) = "Teren" Then
            P(14, 1) = "Cutie"
            pct14cu1.Image = SkinCutie
            Cutii += 1
        ElseIf P(14, 1) = "Cutie" Then
            P(14, 1) = "Tinta"
            pct14cu1.Image = SkinTinta
            Cutii -= 1
        ElseIf P(14, 1) = "Tinta" Then
            P(14, 1) = "Rezolvat"
            pct14cu1.Image = SkinRezolvat
        ElseIf P(14, 1) = "Rezolvat" Then
            If Ok Then
                P(14, 1) = "Jucator"
                pct14cu1.Image = SkinJucator
                Ok = False
            Else
                P(14, 1) = "Nimic"
                pct14cu1.Image = SkinNimic
            End If
        ElseIf P(14, 1) = "Jucator" Then
            P(14, 1) = "JucatorPeTinta"
            pct14cu1.Image = SkinJucatorPeTinta
        ElseIf P(14, 1) = "JucatorPeTinta" Then
            P(14, 1) = "Nimic"
            pct14cu1.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct14cu2_Click(sender As System.Object, e As System.EventArgs) Handles pct14cu2.MouseDown
        If P(14, 2) = "Nimic" Then
            P(14, 2) = "Perete"
            pct14cu2.Image = SkinPerete
        ElseIf P(14, 2) = "Perete" Then
            P(14, 2) = "Teren"
            pct14cu2.Image = SkinTeren
        ElseIf P(14, 2) = "Teren" Then
            P(14, 2) = "Cutie"
            pct14cu2.Image = SkinCutie
            Cutii += 1
        ElseIf P(14, 2) = "Cutie" Then
            P(14, 2) = "Tinta"
            pct14cu2.Image = SkinTinta
            Cutii -= 1
        ElseIf P(14, 2) = "Tinta" Then
            P(14, 2) = "Rezolvat"
            pct14cu2.Image = SkinRezolvat
        ElseIf P(14, 2) = "Rezolvat" Then
            If Ok Then
                P(14, 2) = "Jucator"
                pct14cu2.Image = SkinJucator
                Ok = False
            Else
                P(14, 2) = "Nimic"
                pct14cu2.Image = SkinNimic
            End If
        ElseIf P(14, 2) = "Jucator" Then
            P(14, 2) = "JucatorPeTinta"
            pct14cu2.Image = SkinJucatorPeTinta
        ElseIf P(14, 2) = "JucatorPeTinta" Then
            P(14, 2) = "Nimic"
            pct14cu2.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct14cu3_Click(sender As System.Object, e As System.EventArgs) Handles pct14cu3.MouseDown
        If P(14, 3) = "Nimic" Then
            P(14, 3) = "Perete"
            pct14cu3.Image = SkinPerete
        ElseIf P(14, 3) = "Perete" Then
            P(14, 3) = "Teren"
            pct14cu3.Image = SkinTeren
        ElseIf P(14, 3) = "Teren" Then
            P(14, 3) = "Cutie"
            pct14cu3.Image = SkinCutie
            Cutii += 1
        ElseIf P(14, 3) = "Cutie" Then
            P(14, 3) = "Tinta"
            pct14cu3.Image = SkinTinta
            Cutii -= 1
        ElseIf P(14, 3) = "Tinta" Then
            P(14, 3) = "Rezolvat"
            pct14cu3.Image = SkinRezolvat
        ElseIf P(14, 3) = "Rezolvat" Then
            If Ok Then
                P(14, 3) = "Jucator"
                pct14cu3.Image = SkinJucator
                Ok = False
            Else
                P(14, 3) = "Nimic"
                pct14cu3.Image = SkinNimic
            End If
        ElseIf P(14, 3) = "Jucator" Then
            P(14, 3) = "JucatorPeTinta"
            pct14cu3.Image = SkinJucatorPeTinta
        ElseIf P(14, 3) = "JucatorPeTinta" Then
            P(14, 3) = "Nimic"
            pct14cu3.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct14cu4_Click(sender As System.Object, e As System.EventArgs) Handles pct14cu4.MouseDown
        If P(14, 4) = "Nimic" Then
            P(14, 4) = "Perete"
            pct14cu4.Image = SkinPerete
        ElseIf P(14, 4) = "Perete" Then
            P(14, 4) = "Teren"
            pct14cu4.Image = SkinTeren
        ElseIf P(14, 4) = "Teren" Then
            P(14, 4) = "Cutie"
            pct14cu4.Image = SkinCutie
            Cutii += 1
        ElseIf P(14, 4) = "Cutie" Then
            P(14, 4) = "Tinta"
            pct14cu4.Image = SkinTinta
            Cutii -= 1
        ElseIf P(14, 4) = "Tinta" Then
            P(14, 4) = "Rezolvat"
            pct14cu4.Image = SkinRezolvat
        ElseIf P(14, 4) = "Rezolvat" Then
            If Ok Then
                P(14, 4) = "Jucator"
                pct14cu4.Image = SkinJucator
                Ok = False
            Else
                P(14, 4) = "Nimic"
                pct14cu4.Image = SkinNimic
            End If
        ElseIf P(14, 4) = "Jucator" Then
            P(14, 4) = "JucatorPeTinta"
            pct14cu4.Image = SkinJucatorPeTinta
        ElseIf P(14, 4) = "JucatorPeTinta" Then
            P(14, 4) = "Nimic"
            pct14cu4.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct14cu5_Click(sender As System.Object, e As System.EventArgs) Handles pct14cu5.MouseDown
        If P(14, 5) = "Nimic" Then
            P(14, 5) = "Perete"
            pct14cu5.Image = SkinPerete
        ElseIf P(14, 5) = "Perete" Then
            P(14, 5) = "Teren"
            pct14cu5.Image = SkinTeren
        ElseIf P(14, 5) = "Teren" Then
            P(14, 5) = "Cutie"
            pct14cu5.Image = SkinCutie
            Cutii += 1
        ElseIf P(14, 5) = "Cutie" Then
            P(14, 5) = "Tinta"
            pct14cu5.Image = SkinTinta
            Cutii -= 1
        ElseIf P(14, 5) = "Tinta" Then
            P(14, 5) = "Rezolvat"
            pct14cu5.Image = SkinRezolvat
        ElseIf P(14, 5) = "Rezolvat" Then
            If Ok Then
                P(14, 5) = "Jucator"
                pct14cu5.Image = SkinJucator
                Ok = False
            Else
                P(14, 5) = "Nimic"
                pct14cu5.Image = SkinNimic
            End If
        ElseIf P(14, 5) = "Jucator" Then
            P(14, 5) = "JucatorPeTinta"
            pct14cu5.Image = SkinJucatorPeTinta
        ElseIf P(14, 5) = "JucatorPeTinta" Then
            P(14, 5) = "Nimic"
            pct14cu5.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct14cu6_Click(sender As System.Object, e As System.EventArgs) Handles pct14cu6.MouseDown
        If P(14, 6) = "Nimic" Then
            P(14, 6) = "Perete"
            pct14cu6.Image = SkinPerete
        ElseIf P(14, 6) = "Perete" Then
            P(14, 6) = "Teren"
            pct14cu6.Image = SkinTeren
        ElseIf P(14, 6) = "Teren" Then
            P(14, 6) = "Cutie"
            pct14cu6.Image = SkinCutie
            Cutii += 1
        ElseIf P(14, 6) = "Cutie" Then
            P(14, 6) = "Tinta"
            pct14cu6.Image = SkinTinta
            Cutii -= 1
        ElseIf P(14, 6) = "Tinta" Then
            P(14, 6) = "Rezolvat"
            pct14cu6.Image = SkinRezolvat
        ElseIf P(14, 6) = "Rezolvat" Then
            If Ok Then
                P(14, 6) = "Jucator"
                pct14cu6.Image = SkinJucator
                Ok = False
            Else
                P(14, 6) = "Nimic"
                pct14cu6.Image = SkinNimic
            End If
        ElseIf P(14, 6) = "Jucator" Then
            P(14, 6) = "JucatorPeTinta"
            pct14cu6.Image = SkinJucatorPeTinta
        ElseIf P(14, 6) = "JucatorPeTinta" Then
            P(14, 6) = "Nimic"
            pct14cu6.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct14cu7_Click(sender As System.Object, e As System.EventArgs) Handles pct14cu7.MouseDown
        If P(14, 7) = "Nimic" Then
            P(14, 7) = "Perete"
            pct14cu7.Image = SkinPerete
        ElseIf P(14, 7) = "Perete" Then
            P(14, 7) = "Teren"
            pct14cu7.Image = SkinTeren
        ElseIf P(14, 7) = "Teren" Then
            P(14, 7) = "Cutie"
            pct14cu7.Image = SkinCutie
            Cutii += 1
        ElseIf P(14, 7) = "Cutie" Then
            P(14, 7) = "Tinta"
            pct14cu7.Image = SkinTinta
            Cutii -= 1
        ElseIf P(14, 7) = "Tinta" Then
            P(14, 7) = "Rezolvat"
            pct14cu7.Image = SkinRezolvat
        ElseIf P(14, 7) = "Rezolvat" Then
            If Ok Then
                P(14, 7) = "Jucator"
                pct14cu7.Image = SkinJucator
                Ok = False
            Else
                P(14, 7) = "Nimic"
                pct14cu7.Image = SkinNimic
            End If
        ElseIf P(14, 7) = "Jucator" Then
            P(14, 7) = "JucatorPeTinta"
            pct14cu7.Image = SkinJucatorPeTinta
        ElseIf P(14, 7) = "JucatorPeTinta" Then
            P(14, 7) = "Nimic"
            pct14cu7.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct14cu8_Click(sender As System.Object, e As System.EventArgs) Handles pct14cu8.MouseDown
        If P(14, 8) = "Nimic" Then
            P(14, 8) = "Perete"
            pct14cu8.Image = SkinPerete
        ElseIf P(14, 8) = "Perete" Then
            P(14, 8) = "Teren"
            pct14cu8.Image = SkinTeren
        ElseIf P(14, 8) = "Teren" Then
            P(14, 8) = "Cutie"
            pct14cu8.Image = SkinCutie
            Cutii += 1
        ElseIf P(14, 8) = "Cutie" Then
            P(14, 8) = "Tinta"
            pct14cu8.Image = SkinTinta
            Cutii -= 1
        ElseIf P(14, 8) = "Tinta" Then
            P(14, 8) = "Rezolvat"
            pct14cu8.Image = SkinRezolvat
        ElseIf P(14, 8) = "Rezolvat" Then
            If Ok Then
                P(14, 8) = "Jucator"
                pct14cu8.Image = SkinJucator
                Ok = False
            Else
                P(14, 8) = "Nimic"
                pct14cu8.Image = SkinNimic
            End If
        ElseIf P(14, 8) = "Jucator" Then
            P(14, 8) = "JucatorPeTinta"
            pct14cu8.Image = SkinJucatorPeTinta
        ElseIf P(14, 8) = "JucatorPeTinta" Then
            P(14, 8) = "Nimic"
            pct14cu8.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct14cu9_Click(sender As System.Object, e As System.EventArgs) Handles pct14cu9.MouseDown
        If P(14, 9) = "Nimic" Then
            P(14, 9) = "Perete"
            pct14cu9.Image = SkinPerete
        ElseIf P(14, 9) = "Perete" Then
            P(14, 9) = "Teren"
            pct14cu9.Image = SkinTeren
        ElseIf P(14, 9) = "Teren" Then
            P(14, 9) = "Cutie"
            pct14cu9.Image = SkinCutie
            Cutii += 1
        ElseIf P(14, 9) = "Cutie" Then
            P(14, 9) = "Tinta"
            pct14cu9.Image = SkinTinta
            Cutii -= 1
        ElseIf P(14, 9) = "Tinta" Then
            P(14, 9) = "Rezolvat"
            pct14cu9.Image = SkinRezolvat
        ElseIf P(14, 9) = "Rezolvat" Then
            If Ok Then
                P(14, 9) = "Jucator"
                pct14cu9.Image = SkinJucator
                Ok = False
            Else
                P(14, 9) = "Nimic"
                pct14cu9.Image = SkinNimic
            End If
        ElseIf P(14, 9) = "Jucator" Then
            P(14, 9) = "JucatorPeTinta"
            pct14cu9.Image = SkinJucatorPeTinta
        ElseIf P(14, 9) = "JucatorPeTinta" Then
            P(14, 9) = "Nimic"
            pct14cu9.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct14cu10_Click(sender As System.Object, e As System.EventArgs) Handles pct14cu10.MouseDown
        If P(14, 10) = "Nimic" Then
            P(14, 10) = "Perete"
            pct14cu10.Image = SkinPerete
        ElseIf P(14, 10) = "Perete" Then
            P(14, 10) = "Teren"
            pct14cu10.Image = SkinTeren
        ElseIf P(14, 10) = "Teren" Then
            P(14, 10) = "Cutie"
            pct14cu10.Image = SkinCutie
            Cutii += 1
        ElseIf P(14, 10) = "Cutie" Then
            P(14, 10) = "Tinta"
            pct14cu10.Image = SkinTinta
            Cutii -= 1
        ElseIf P(14, 10) = "Tinta" Then
            P(14, 10) = "Rezolvat"
            pct14cu10.Image = SkinRezolvat
        ElseIf P(14, 10) = "Rezolvat" Then
            If Ok Then
                P(14, 10) = "Jucator"
                pct14cu10.Image = SkinJucator
                Ok = False
            Else
                P(14, 10) = "Nimic"
                pct14cu10.Image = SkinNimic
            End If
        ElseIf P(14, 10) = "Jucator" Then
            P(14, 10) = "JucatorPeTinta"
            pct14cu10.Image = SkinJucatorPeTinta
        ElseIf P(14, 10) = "JucatorPeTinta" Then
            P(14, 10) = "Nimic"
            pct14cu10.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct14cu11_Click(sender As System.Object, e As System.EventArgs) Handles pct14cu11.MouseDown
        If P(14, 11) = "Nimic" Then
            P(14, 11) = "Perete"
            pct14cu11.Image = SkinPerete
        ElseIf P(14, 11) = "Perete" Then
            P(14, 11) = "Teren"
            pct14cu11.Image = SkinTeren
        ElseIf P(14, 11) = "Teren" Then
            P(14, 11) = "Cutie"
            pct14cu11.Image = SkinCutie
            Cutii += 1
        ElseIf P(14, 11) = "Cutie" Then
            P(14, 11) = "Tinta"
            pct14cu11.Image = SkinTinta
            Cutii -= 1
        ElseIf P(14, 11) = "Tinta" Then
            P(14, 11) = "Rezolvat"
            pct14cu11.Image = SkinRezolvat
        ElseIf P(14, 11) = "Rezolvat" Then
            If Ok Then
                P(14, 11) = "Jucator"
                pct14cu11.Image = SkinJucator
                Ok = False
            Else
                P(14, 11) = "Nimic"
                pct14cu11.Image = SkinNimic
            End If
        ElseIf P(14, 11) = "Jucator" Then
            P(14, 11) = "JucatorPeTinta"
            pct14cu11.Image = SkinJucatorPeTinta
        ElseIf P(14, 11) = "JucatorPeTinta" Then
            P(14, 11) = "Nimic"
            pct14cu11.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct14cu12_Click(sender As System.Object, e As System.EventArgs) Handles pct14cu12.MouseDown
        If P(14, 12) = "Nimic" Then
            P(14, 12) = "Perete"
            pct14cu12.Image = SkinPerete
        ElseIf P(14, 12) = "Perete" Then
            P(14, 12) = "Teren"
            pct14cu12.Image = SkinTeren
        ElseIf P(14, 12) = "Teren" Then
            P(14, 12) = "Cutie"
            pct14cu12.Image = SkinCutie
            Cutii += 1
        ElseIf P(14, 12) = "Cutie" Then
            P(14, 12) = "Tinta"
            pct14cu12.Image = SkinTinta
            Cutii -= 1
        ElseIf P(14, 12) = "Tinta" Then
            P(14, 12) = "Rezolvat"
            pct14cu12.Image = SkinRezolvat
        ElseIf P(14, 12) = "Rezolvat" Then
            If Ok Then
                P(14, 12) = "Jucator"
                pct14cu12.Image = SkinJucator
                Ok = False
            Else
                P(14, 12) = "Nimic"
                pct14cu12.Image = SkinNimic
            End If
        ElseIf P(14, 12) = "Jucator" Then
            P(14, 12) = "JucatorPeTinta"
            pct14cu12.Image = SkinJucatorPeTinta
        ElseIf P(14, 12) = "JucatorPeTinta" Then
            P(14, 12) = "Nimic"
            pct14cu12.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct14cu13_Click(sender As System.Object, e As System.EventArgs) Handles pct14cu13.MouseDown
        If P(14, 13) = "Nimic" Then
            P(14, 13) = "Perete"
            pct14cu13.Image = SkinPerete
        ElseIf P(14, 13) = "Perete" Then
            P(14, 13) = "Teren"
            pct14cu13.Image = SkinTeren
        ElseIf P(14, 13) = "Teren" Then
            P(14, 13) = "Cutie"
            pct14cu13.Image = SkinCutie
            Cutii += 1
        ElseIf P(14, 13) = "Cutie" Then
            P(14, 13) = "Tinta"
            pct14cu13.Image = SkinTinta
            Cutii -= 1
        ElseIf P(14, 13) = "Tinta" Then
            P(14, 13) = "Rezolvat"
            pct14cu13.Image = SkinRezolvat
        ElseIf P(14, 13) = "Rezolvat" Then
            If Ok Then
                P(14, 13) = "Jucator"
                pct14cu13.Image = SkinJucator
                Ok = False
            Else
                P(14, 13) = "Nimic"
                pct14cu13.Image = SkinNimic
            End If
        ElseIf P(14, 13) = "Jucator" Then
            P(14, 13) = "JucatorPeTinta"
            pct14cu13.Image = SkinJucatorPeTinta
        ElseIf P(14, 13) = "JucatorPeTinta" Then
            P(14, 13) = "Nimic"
            pct14cu13.Image = SkinNimic
            Ok = True
        End If
    End Sub
    Private Sub pct14cu14_Click(sender As System.Object, e As System.EventArgs) Handles pct14cu14.MouseDown
        If P(14, 14) = "Nimic" Then
            P(14, 14) = "Perete"
            pct14cu14.Image = SkinPerete
        ElseIf P(14, 14) = "Perete" Then
            P(14, 14) = "Teren"
            pct14cu14.Image = SkinTeren
        ElseIf P(14, 14) = "Teren" Then
            P(14, 14) = "Cutie"
            pct14cu14.Image = SkinCutie
            Cutii += 1
        ElseIf P(14, 14) = "Cutie" Then
            P(14, 14) = "Tinta"
            pct14cu14.Image = SkinTinta
            Cutii -= 1
        ElseIf P(14, 14) = "Tinta" Then
            P(14, 14) = "Rezolvat"
            pct14cu14.Image = SkinRezolvat
        ElseIf P(14, 14) = "Rezolvat" Then
            If Ok Then
                P(14, 14) = "Jucator"
                pct14cu14.Image = SkinJucator
                Ok = False
            Else
                P(14, 14) = "Nimic"
                pct14cu14.Image = SkinNimic
            End If
        ElseIf P(14, 14) = "Jucator" Then
            P(14, 14) = "JucatorPeTinta"
            pct14cu14.Image = SkinJucatorPeTinta
        ElseIf P(14, 14) = "JucatorPeTinta" Then
            P(14, 14) = "Nimic"
            pct14cu14.Image = SkinNimic
            Ok = True
        End If
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