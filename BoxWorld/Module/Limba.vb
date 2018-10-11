Module Limba

    '===' Meniu
    Public TextJoaca
    Public TextEditor
    Public TextOptiuni
    Public TextIesire
    Public TextFacutInRomania
    Public TextDe

    '===' Meniu2
    Public TextContinuare
    Public TextJocNou
    Public TextNivelulRecord

    '===' Editor
    Public TextGolire
    Public TextGenerare
    Public TextCopiaza
    'Public TextNivel
    Public TextCod

    '===' Optiuni
    Public TextLimba
    Public TextTexturi
    Public TextControale

    '===' Joc
    Public TextResetare
    Public TextMaiDeparte
    Public TextNivel
    Public TextTimp
    Public TextMutari
    Public TextRecord
    Public TextFelicitari

    Public Sub DetectareLimba()
        If My.Settings.Limba = "Română" Then
            '===' Meniu
            TextJoaca = "Joacă"
            TextEditor = "Editor de Nivele"
            TextOptiuni = "Opțiuni"
            TextIesire = "Ieșire"
            TextFacutInRomania = "Făcut în România"
            TextDe = "de Mlendea Horațiu"

            '===' Meniu2
            TextContinuare = "Continuare"
            TextJocNou = "Joc Nou"
            TextNivelulRecord = "Nivelul Record"

            '===' Editor
            TextGolire = "Golire"
            TextGenerare = "Generare"
            TextCopiaza = "Copiază"
            'TextNivel = "Nivel: "
            TextCod = "Cod: "

            '===' Optiuni
            TextLimba = "Limba"
            TextTexturi = "Texturi"
            TextControale = "Controale"

            '===' Joc
            TextResetare = "Resetare"
            TextMaiDeparte = "Mai Departe"
            TextNivel = "Nivel"
            TextTimp = "Timp"
            TextMutari = "Mutări"
            TextRecord = "Record"
            TextFelicitari = "Felicitări! Ai reușit!"

        ElseIf My.Settings.Limba = "English" Then
            '===' Meniu
            TextJoaca = "Play"
            TextEditor = "Level Editor"
            TextOptiuni = "Options"
            TextIesire = "Exit"
            TextFacutInRomania = "Made in Romania"
            TextDe = "by Mlendea Horațiu"

            '===' Meniu2
            TextContinuare = "Contiune"
            TextJocNou = "New Game"
            TextNivelulRecord = "Best Level"

            '===' Editor
            TextGolire = "Empty"
            TextGenerare = "Generate"
            TextCopiaza = "Copy"
            'TextNivel = "Level: "
            TextCod = "Code"

            '===' Optiuni
            TextLimba = "Language"
            TextTexturi = "Textures"
            TextControale = "Controls"

            '===' Joc
            TextResetare = "Reset"
            TextMaiDeparte = "Next"
            TextNivel = "Level"
            TextTimp = "Time"
            TextMutari = "Moves"
            TextRecord = "Best"
            TextFelicitari = "Congratulations! You did it!"
        End If
    End Sub

    Public Sub InitializareLimba()
        '===' Meniu
        Meniu.JoacaButon.Text = TextJoaca
        Meniu.EditorButon.Text = TextEditor
        Meniu.OptiuniButon.Text = TextOptiuni
        Meniu.IesireButon.Text = TextIesire
        Meniu.MadeIn.Text = TextFacutInRomania
        Meniu.Credite.Text = TextDe

        '===' Meniu2
        Meniu2.ContinuareButon.Text = TextContinuare
        Meniu2.JocNouButon.Text = TextJocNou
        Meniu2.NivelRecordButon.Text = TextNivelulRecord

        '===' Editor
        Editor.GolireButon.Text = TextGolire
        Editor.GenerareButon.Text = TextGenerare
        Editor.CopiazaButon.Text = TextCopiaza
        Editor.NivelText.Text = TextNivel
        Editor.CodText.Text = TextCod

        '===' Optiuni
        Optiuni.LimbaText.Text = TextLimba + ": "
        Optiuni.TexturiText.Text = TextTexturi + ": "
        Optiuni.ControaleText.Text = TextControale + ": "

        '===' Joc
        Joc.ResetareButon.Text = TextResetare
        Joc.MaiDeparteButon.Text = TextMaiDeparte
        Joc.NivelText.Text = TextNivel + ": "
        Joc.TimpText.Text = TextTimp + ": "
        Joc.MutariText.Text = TextMutari + ": "
        Joc.NivelRecordText.Text = TextRecord + ": " & My.Settings.RecordNivel
        'Joc.TimpRecordText.Text = TextRecord + ": "
        'Joc.MutariRecordText.Text = TextRecord + ": "
        Joc.FelicitariText.Text = TextFelicitari
    End Sub

End Module
