Imports Microsoft.Win32
Imports System.ComponentModel
Imports System.IO
Imports System.Data.OleDb
Imports System.Configuration
Imports Tesseract
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Public Class dbHandling
    Public con As New OleDbConnection
    'DB-Standort-Daten
    Public dbName As String 'Name der DB 
    Public Shared CurrDB As String ' Vollständiger Name mit Pfad
    Public Shared sAppPath As String = System.AppDomain.CurrentDomain.BaseDirectory & "Daten\"


    'Verwaltungsordner
    Public Shared ArchivOrdner As String
    Public Shared InputOrdner As String
    Public Shared MailInputOrdner As String
    Public Shared FlagArchivOrdner As Boolean
    Public Shared FlagInputOrdner As Boolean
    Public Shared SettingOutlookArchiv As String
    Public Shared FlagMailInputOrdner As Boolean
    Public Shared StartMandant As String
    Public Shared FlagStartMandant As Boolean
    Public Shared FlagAppPath As Boolean
    Public Shared StEmpfaenger As String
    Public Shared FlagStEmpfaenger As Boolean
    Public Shared FlagOutlook As Boolean = False
    Public Shared mailAbrufStart As Boolean = False
    Dim OutlookNutzen As String = "nein"
    Dim MailAbruf As String = "nein"

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
        Dim MyDB As String = Path.GetFileNameWithoutExtension(CurrDB)
        If String.IsNullOrEmpty(MyDB) Then
            MyDB = "Nothing"
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
            'MsgBox(ArchivOrdner & vbCrLf & PdfToText & vbCrLf & SettingOutlookArchiv & vbCrLf & MailInputOrdner & vbCrLf & currDB)
        End With
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
