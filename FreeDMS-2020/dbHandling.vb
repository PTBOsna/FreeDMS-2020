Imports Microsoft.Win32
Imports System.ComponentModel
Imports System.IO
Imports System.Data.OleDb
Imports System.Configuration
Imports Tesseract
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Public Class dbHandling : Inherits Form
    Public con As New OleDbConnection
    'DB-Standort-Daten
    Public dbName As String 'Name der DB 
    Public CurrDB As String ' Vollständiger Name mit Pfad
    Public sAppPath As String = System.AppDomain.CurrentDomain.BaseDirectory & "Daten\"


    'Verwaltungsordner
    Public ArchivOrdner As String
    Public InputOrdner As String
    Public MailInputOrdner As String
    Public FlagArchivOrdner As Boolean
    Public FlagInputOrdner As Boolean
    Public SettingOutlookArchiv As String
    Public FlagMailInputOrdner As Boolean
    Public StartMandant As String
    Public FlagStartMandant As Boolean
    Public FlagAppPath As Boolean
    Public StEmpfaenger As String
    Public FlagStEmpfaenger As Boolean
    Public FlagOutlook As Boolean = False
    Public mailAbrufStart As Boolean = False
    Dim OutlookNutzen As String = "nein"
    Dim MailAbruf As String = "nein"

    'Provider
    Public xmlProvider As String = System.AppDomain.CurrentDomain.BaseDirectory & "Daten\provider.xml"
    Public Function ChekDB() As Boolean
        If sAppPath = Nothing Then
            sAppPath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Daten")
        End If

        Dim Files() As String = Directory.GetFiles(sAppPath, "FreeDMS*.mdb")
        'je nach Anzahl der gefundenen Dateien handeln
        Select Case Files.Length
            Case 0 ' keine Startdatei vorhanden, also suchen
                MyFileDialog("Bitte die Start-DB auswählen!")
            Case 1  ' eine Startdatei vorhanden
                If Path.GetFileName(Files(0)) = dbName Then
                    ' MsgBox(Files(0))
                    CurrDB = Files(0)
                Else
                    MyFileDialog("Bitte die Datenbank auswählen!")
                    dbName = Path.GetFileName(CurrDB)
                    sAppPath = Path.GetDirectoryName(CurrDB)
                End If
            Case > 1 'Mehrere DB-Dateien vorhanden: eine auswählen
                MyFileDialog("Es sind mehrere Dateien vorhanden! Bitte die Start-DB auswählen!")
            Case Else
                MsgBox("Keine Datei vorhanden. Anwendung wird geschlossen")
                Close()
        End Select
    End Function
    ''' <summary>
    ''' FileDialog für DB-Auswahl
    ''' </summary>
    ''' <param name="sTitel"></param>
    Public Sub MyFileDialog(ByVal sTitel As String)
        Dim openFileDialog1 = New OpenFileDialog()
        With OpenFileDialog1
            .Title = sTitel
            .Filter = "FreeDMS* (FreeDMS*.mdb)|FreeDMS*.mdb"
            .InitialDirectory = System.AppDomain.CurrentDomain.BaseDirectory
            .FileName = ""
            .ShowDialog()
            If String.IsNullOrEmpty(.FileName) Then Exit Sub
            CurrDB = .FileName
            dbName = Path.GetFileName(.FileName)

        End With
        XMLWriter()
    End Sub
    ''' <summary>
    ''' Prüfen, ob Programm vorhanden (insbes. MS-Access)
    ''' </summary>
    ''' <param name="name"></param>
    ''' <returns></returns>
    Public Function CheckForSoftwareInstallation(ByVal name As String) As Boolean
        '-- Get all software names installed by Windows Installer --
        Dim softwareList As List(Of String) = New List(Of String)
        Dim products As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Classes\Installer\Products")
        For Each keyName As String In products.GetSubKeyNames
            For Each valueName As String In products.OpenSubKey(keyName).GetValueNames
                If (valueName = "ProductName") Then
                    Dim entry As String = products.OpenSubKey(keyName).GetValue("ProductName").ToString
                    If (Not (entry) Is Nothing) Then
                        softwareList.Add(UCase(entry))
                    End If
                End If
            Next
        Next
        '-- check if searched software is included --
        Dim found As Boolean = False
        For Each sName As String In softwareList
            If sName.Contains(UCase(name)) Then
                found = True
            End If
        Next
        Return found
    End Function
    ''' <summary>
    ''' Datembank.xml-Wreiter
    ''' Schreibt datenbankrelevante Parameter in dbName.xml
    ''' </summary>
    Public Sub XMLWriter()
        'Dim gd As GrundDaten
        ' Auswahl einer Kodierungsart für die Zeichenablage 
        Dim enc As New System.Text.UTF8Encoding
        Dim myDB As String = Path.GetFileNameWithoutExtension(CurrDB)
        '  MsgBox("XMLWriter CurrDB: " & CurrDB)
        If String.IsNullOrEmpty(myDB) Then
            myDB = "Nothing"
            CurrDB = "Nothing"
        End If
        ' XmlTextWriter-Objekt für unsere Ausgabedatei erzeugen: 
        Dim XMLobj As System.Xml.XmlTextWriter _
              = New System.Xml.XmlTextWriter(System.AppDomain.CurrentDomain.BaseDirectory & "Daten\" & myDB & ".xml", enc)

        With XMLobj
            If mailAbrufStart = True Then MailAbruf = "ja" Else MailAbruf = "nein"
            If FlagOutlook = True Then OutlookNutzen = "ja" Else OutlookNutzen = "nein"
            ' Formatierung: 4er-Einzüge verwenden 
            .Formatting = System.Xml.Formatting.Indented
            .Indentation = 4

            ' Dann fangen wir mal an: 
            .WriteStartDocument()

            ' Beginn eines Elements "Personen". Darin werden wir mehrere 
            ' Elemente "Person" unterbringen. 
            .WriteStartElement("settings")
            .WriteStartElement("setting") ' <Person 
            .WriteAttributeString("DBName", dbName)
            .WriteAttributeString("ArchivOrdner", ArchivOrdner)
            .WriteAttributeString("ScanInputOrdner", InputOrdner)
            .WriteAttributeString("OutlookNutzen", OutlookNutzen)
            .WriteAttributeString("OutlookPost", MailInputOrdner)
            .WriteAttributeString("OutlookArchiv", SettingOutlookArchiv)
            .WriteAttributeString("Mandant", StartMandant)
            .WriteAttributeString("Empfaenger", StEmpfaenger)
            .WriteAttributeString("OpenMailStart", MailAbruf)
            ' .WriteAttributeString("pdfToText", PdfToText)

            .WriteEndElement() ' Person /> 


            .WriteEndElement() ' </Personen> 

            ' ... und schließen das XML-Dokument (und die Datei) 
            .Close() ' Document 

        End With

    End Sub
    ''' <summary>
    ''' List die mit xmlWriter geschriebenen Daten aus und überträgt sie ggf. in die Settings
    ''' </summary>
    Public Sub XMLReader()
        Dim myPath As String = System.AppDomain.CurrentDomain.BaseDirectory 'Path.GetDirectoryName(CurrDB) & "\" 'CurrDB ist Pfad einschließlich '\Daten\
        If String.IsNullOrEmpty(CurrDB) Then MyFileDialog("Bitte DB auswählen")
        Dim MyDB As String = Path.GetFileNameWithoutExtension(CurrDB)

        If String.IsNullOrEmpty(MyDB) Then
            MyDB = Path.GetFileNameWithoutExtension(CurrDB)
        End If
        'MsgBox(MyDB & vbCrLf & CurrDB & vbCrLf & Path.GetDirectoryName(CurrDB))
        'prüfen, ob im Ordner der Aktuellen DB (CurrDB) die xml-Datei vohanden ist, wenn nicht prüfen ob sie im Anwendungs-Verzeichnis ist. Sonst neu erstellen
        If Not File.Exists(myPath & MyDB & ".xml") Then

            If Not File.Exists(System.AppDomain.CurrentDomain.BaseDirectory & "Daten\" & MyDB & ".xml") Then
                If MsgBox("Die Datei '" & MyDB & ".xml ist nicht vorhanden!" & vbCrLf & "Erstellen lassen (ok) oder zurück (cancel)?" & vbCrLf & "Wenn OK, bitte anschließend die Settings überprüfen!", vbOKCancel) = MsgBoxResult.Cancel Then
                    Exit Sub
                Else
                    XMLWriter()
                End If
            End If
            myPath = System.AppDomain.CurrentDomain.BaseDirectory & "Daten\"
        End If
        Dim XMLReader As System.Xml.XmlReader = New System.Xml.XmlTextReader(myPath & MyDB & ".xml")

        ' Es folgt das Auslesen der XML-Datei 
        With XMLReader
            Do While .Read ' Es sind noch Daten vorhanden 
                ' Welche Art von Daten liegt an? 
                Select Case .NodeType ' Ein Element 
                    Case System.Xml.XmlNodeType.Element
                        If .AttributeCount > 0 Then
                            ' Es sind noch weitere Attribute vorhanden 
                            While .MoveToNextAttribute ' nächstes 
                                Select Case .Name
                                    Case "DBName"
                                        dbName = .Value
                                    Case "ArchivOrdner"
                                        ArchivOrdner = .Value
                                    Case "ScanInputOrdner"
                                        InputOrdner = .Value
                                        'Case "OCRProgramm"
                                        '    PdfToText = .Value
                                    Case "OutlookPost"
                                        MailInputOrdner = .Value
                                    Case "OutlookNutzen"
                                        OutlookNutzen = .Value
                                      '  MsgBox(.Value)
                                    Case "OutlookArchiv"
                                        SettingOutlookArchiv = .Value
                                    Case "Mandant"
                                        StartMandant = .Value
                                    Case "Empfaenger"
                                        StEmpfaenger = .Value
                                    Case "OpenMailStart"
                                        MailAbruf = .Value
                                End Select
                            End While
                        End If
                End Select
            Loop  ' Weiter nach Daten schauen 
            .Close()  ' XMLTextReader schließen 
            If MailAbruf = "ja" Then mailAbrufStart = True Else mailAbrufStart = False
            If OutlookNutzen = "ja" Then FlagOutlook = True Else FlagOutlook = False
            CurrDB = sAppPath & dbName
            'MsgBox(ArchivOrdner & vbCrLf & PdfToText & vbCrLf & SettingOutlookArchiv & vbCrLf & MailInputOrdner & vbCrLf & currDB)
        End With
    End Sub
    ''' <summary>
    ''' Überprüfen der Settings und Eintrag in die entsprechenden globalen Variablen
    ''' </summary>
    Public Sub ChkSettings()

        If Not String.IsNullOrEmpty(MailInputOrdner) Then FlagMailInputOrdner = True
        If Not sAppPath.EndsWith("\") Then sAppPath = sAppPath & "\"
        If Not Directory.Exists(ArchivOrdner) Or Not Directory.Exists(InputOrdner) Then
            MsgBox("Die angegebenen Pfade existieren nicht." & vbCrLf & "Archiv und Inputordner werden zunächst unter '" & sAppPath & "ScanInput' und ...'Archiv\' eingerichtet." & vbCrLf & "Sie können diese unter 'SETTINGS' ändern.", vbSystemModal)
            Directory.CreateDirectory(sAppPath & "Archiv\")
            ArchivOrdner = sAppPath & "Archiv\"
            ArchivOrdner = ArchivOrdner
            Directory.CreateDirectory(sAppPath & "ScanInput\")
            InputOrdner = sAppPath & "ScanInput\"
            InputOrdner = InputOrdner
        ElseIf Not Directory.Exists(InputOrdner) Then
            MsgBox("Der angegebene Pfad existiert nicht." & vbCrLf & "Der  InputOrdner wird zunächst unter '" & sAppPath & "ScanInput' eingerichtet." & vbCrLf & "Sie können dies unter 'SETTINGS' ändern.")
            Directory.CreateDirectory(sAppPath & "ScanInput\")
            InputOrdner = sAppPath & "ScanInput\"
            InputOrdner = InputOrdner
        ElseIf Not Directory.Exists(ArchivOrdner) Then
            MsgBox("Der angegebene Pfad existiert nicht." & vbCrLf & "Der  ArchivOrdner wird zunächst unter '" & sAppPath & "Archiv' eingerichtet." & vbCrLf & "Sie können dies unter 'SETTINGS' ändern.")
            Directory.CreateDirectory(sAppPath & "Archiv\")
            ArchivOrdner = sAppPath & "Archiv\"
            ArchivOrdner = ArchivOrdner
        End If
        If Not ArchivOrdner.EndsWith("\") Then
            ArchivOrdner = ArchivOrdner & "\"
        End If
        If Not InputOrdner.EndsWith("\") Then
            InputOrdner = InputOrdner & "\"
        End If
        If String.IsNullOrEmpty(StEmpfaenger) Then
            StEmpfaenger = "0"
        End If
        If String.IsNullOrEmpty(StartMandant) Then
            StartMandant = "0"
        End If

        If MailAbruf.Contains("ja") Then mailAbrufStart = True
    End Sub


    ''' <summary>
    ''' DB laden
    ''' vollständiger Dateiname als Input erwartet
    ''' </summary>
    ''' <param name="sName"></param>
    Public Sub LoadDB(ByVal sName As String)
        ' MsgBox(sName)
        If File.Exists(sName) Then
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='" & sName & "'"
            'Provider=Microsoft.Jet.OLEDB.4.0;Data Source=H:\Access\freeDMS_DB_test.mdb
            Exit Sub

        ElseIf Not File.Exists(sAppPath & Path.GetFileName(sName)) Then
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='" & sName & "'"
            Exit Sub
        End If
        MsgBox("Datei " & sName & " nicht gefunden!",, "Bitte prüfen!")
    End Sub

End Class
