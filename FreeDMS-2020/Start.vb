Imports System.IO
Public Class Start
    Dim dbH As New dbHandling
    Dim tempPath As String = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\" 'Speicherort für temp-Daten. 
    '******************************
    ''' <summary>
    ''' Hauptformular laden
    ''' Vorbereiten und Prüfen der Settings
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Vorbereitung
        Cursor.Current = Cursors.WaitCursor
        'testen ob Access installiert ist 
        If Not dbH.CheckForSoftwareInstallation("access") = True Then
            Me.TopMost = True
            Dim f As New MsgAccess
            f.ShowDialog()
            ' MsgBox("Microsoft Access ist nicht installiert!" & vbCrLf & "Wenn nicht vorhanden, bitte die kostenlose Runtime" & vbCrLf & "https://www.microsoft.com/de-de/download/details.aspx?id=4438" & vbCrLf & "installieren und FreeDMS neu starten!")
            End
        End If
        'Vorbereiten für Datei
        'Aufräumen aus letzter Sitzung
        For Each a As String In IO.Directory.GetFiles(tempPath)
            Try
                File.Delete(a)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next
        'Settings prüfen und laden
        dbH.XMLReader()

    End Sub
End Class
