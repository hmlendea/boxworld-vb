Module Texturi
    Public SkinCutie As Image
    Public SkinJucator As Image
    Public SkinJucatorPeTinta As Image
    Public SkinNimic As Image
    Public SkinPerete As Image
    Public SkinRezolvat As Image
    Public SkinTeren As Image
    Public SkinTinta As Image

    Public Sub InitializareTexturi()
        If My.Settings.Texturi = "Default" Then
            SkinCutie = My.Resources.Cutie
            SkinJucator = My.Resources.Jucator
            SkinJucatorPeTinta = My.Resources.JucatorPeTinta
            SkinNimic = My.Resources.Nimic
            SkinPerete = My.Resources.Perete
            SkinRezolvat = My.Resources.Rezolvat
            SkinTeren = My.Resources.Teren
            SkinTinta = My.Resources.Tinta
        ElseIf My.Settings.Texturi = "Classic" Then
            SkinCutie = My.Resources.Cutie1
            SkinJucator = My.Resources.Jucator1
            SkinJucatorPeTinta = My.Resources.JucatorPeTinta1
            SkinNimic = My.Resources.Nimic1
            SkinPerete = My.Resources.Perete1
            SkinRezolvat = My.Resources.Rezolvat1
            SkinTeren = My.Resources.Teren1
            SkinTinta = My.Resources.Tinta1
        ElseIf My.Settings.Texturi = "Legacy" Then
            SkinCutie = My.Resources.Cutie2
            SkinJucator = My.Resources.Jucator2
            SkinJucatorPeTinta = My.Resources.JucatorPeTinta2
            SkinNimic = My.Resources.Nimic2
            SkinPerete = My.Resources.Perete2
            SkinRezolvat = My.Resources.Rezolvat2
            SkinTeren = My.Resources.Teren2
            SkinTinta = My.Resources.Tinta2
        ElseIf My.Settings.Texturi = "Minecraft" Then
            SkinCutie = My.Resources.Cutie3
            SkinJucator = My.Resources.Jucator3
            SkinJucatorPeTinta = My.Resources.JucatorPeTinta3
            SkinNimic = My.Resources.Nimic3
            SkinPerete = My.Resources.Perete3
            SkinRezolvat = My.Resources.Rezolvat3
            SkinTeren = My.Resources.Teren3
            SkinTinta = My.Resources.Tinta3
        End If
    End Sub

End Module
