Module Recorduri

    Public Sub InitializareRecorduri()
        Meniu2.NivelRecordButon.Text += " (" & My.Settings.RecordNivel & ")"
        Joc.NivelRecordText.Text += " (" & My.Settings.RecordNivel & ")"
    End Sub
End Module
