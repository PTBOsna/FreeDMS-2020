Imports OpenPop.Pop3
Imports OpenPop.Mime
Imports System.Text.RegularExpressions
Imports Message = OpenPop.Mime.Message
Imports System.IO
Public Class Start

    ''' <summary>
    ''' DocDate zum Zwischenspeichern der aktuellen Werte Mandant, Akte, Vorgang und Dokument
    ''' </summary>
    Class DocData
        Public Mandant As Integer
        Public Akte As Integer
        Public Vorgang As Integer
        Public Dokument As Integer
        Public DokName As String
    End Class

    Public lblClose As Boolean = False

    Dim dbH As New dbHandling
    Dim tempPath As String = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\" 'Speicherort für temp-Daten. 
    Public Shared currDoc As New DocData
    'Dim MailInputOrdner As String = MailInputOrdner
    Dim allMessages As New List(Of Message)()
    Dim selAttachments As New List(Of MessagePart)
    Dim host As String
    Dim user As String
    Dim password As String
    Dim port As Integer
    Dim ssl As Boolean
    '******************************
#Region "start"
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
        dbH.ChkSettings()
        Me.Text = "FreeDMS - Aktuelle DB: " & dbH.CurrDB
        'Setting laden:
        Dim myDB As String = Path.GetFileNameWithoutExtension(dbH.CurrDB)
        If Not My.Computer.FileSystem.FileExists(System.AppDomain.CurrentDomain.BaseDirectory & "Daten\" & myDB & ".xml") Then
            dbH.XMLWriter()
        End If
        If File.Exists(dbH.xmlProvider) Then
            ProviderDataBase.ReadXml(dbH.xmlProvider)
        End If
        ProviderBindingSource.Filter = "id=1"
        For Each el In ProviderDataBase.Provider
            If el.id = -1 Then   'Voreinstellung erforderlich
                'TODO:           nach Mail - Algorihtmen auskommentieren
                host = el.Host
                user = el.User
                port = el.Port
                password = el.Password
                ssl = el.SSL
            End If
        Next

        'Voreinstellungen
        RBAlles.Select()
        AnlagenSQLDataGridView.Visible = False
        LbAnlagen.Visible = False
        LbIstAnlage.Visible = False
        LbIstAnlage.Text = "Dokument ist Anlage (siehe Bearbeitungsvermerk)."
        With ComboBoxSuche
            .Items.Add("in allen Feldern (ohne OCR)")
            .Items.Add("im Kommentar")
            .Items.Add("im Dokument (OCR)")
            .Items.Add("in Datum erstellt/Datum Dokument")
            .Items.Add("nach Dokument-Nummer")
            .SelectedIndex = 0
        End With
        PanelSuche.Visible = False
        PanelSuchErgeb.Visible = False
        Dim maxWidth As Integer = DokumenteSQLDataGridView.Width
        With DokumenteSQLDataGridView
            .Columns(0).Width = CInt(maxWidth * 0.05)
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            '.Columns(1).Width = CInt(maxWidth * 0.2)
            .Columns(2).Width = CInt(maxWidth * 0.155)
            .Columns(3).Width = CInt(maxWidth * 0.075)
            .Columns(4).Width = CInt(maxWidth * 0.075)
            .Columns(5).Width = CInt(maxWidth * 0.1)
            .Columns(6).Width = CInt(maxWidth * 0.1)
            .Columns(7).Width = CInt(maxWidth * 0.075)
            .Columns(8).Width = CInt(maxWidth * 0.075)
            .Columns(9).Width = CInt(maxWidth * 0.075)
        End With
        LblWv.Text = "Wiedervorlage(n)" & vbCrLf & "Heute ist der " & Format(Now, "dd. MMMM yyyy")
        ProgressBar1.Visible = False

        'Voreinstellungen Mail
        PanelMailKopfDetail.Dock = DockStyle.Fill
        PanelMailKopfDetail.Visible = False
        PanelAtt.Visible = False
        PanelMail.Dock = DockStyle.Fill
        PanelMail.Visible = True
        PnlDokButton.Visible = True
        TxtCounter.Visible = False
        WebBrowser1.Dock = DockStyle.Fill
        WebBrowser1.Visible = False
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = My.Resources.FreeDMS_Logo
        cbMaxMails.SelectedIndex = 2
        lblStatusMsg.Visible = False
        If dbH.mailAbrufStart = True Then
            UserTextBox1.Text = user
            HostTextBox1.Text = host
            TxtCounter.Visible = True
            Read_Emails()
        End If


        'currDoc.Mandant = CInt(StartMandant)
        'NotizBindingSource1.Filter = "id=0"
        'LoadAll()
        'LoadLvDok(LvScanInput)
        'LoadLvDok(LVMailInput)
        'FillTreeView()
        'FindTreeNode(StartMandant)
        ''Beim Start kein Dokument anzeigen
        'DokumenteBindingSource.Filter = "id=0"
        Me.WindowState = FormWindowState.Maximized
    End Sub

#End Region

#Region "Mails"
    ''' <summary>
    ''' Provider auswählen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CbProviderAuswahl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbProviderAuswahl.SelectedIndexChanged
        If lblClose Then Exit Sub
        PanelMail.Visible = True
        For Each el In ProviderDataBase.Provider
            If el.id = CInt(CbProviderAuswahl.SelectedValue) Then   'Voreinstellung erforderlich
                host = el.Host
                user = el.User
                port = el.Port
                password = el.Password
                ssl = el.SSL
            End If
        Next
        UserTextBox1.Text = user
        HostTextBox1.Text = host
        TxtCounter.Visible = True
        Read_Emails()
    End Sub
    ''' <summary>
    ''' Abrufen und anzeigen der Mails vom Provider
    ''' </summary>
    Private Sub Read_Emails()
        Cursor.Current = Cursors.WaitCursor
        GVEmails.Rows.Clear()
        allMessages.Clear()
        SelAttachments1.Clear()
        '  Me.Cursor = Cursors.WaitCursor
        Dim CurrPath As String = dbH.sAppPath & user & "-uids.txt"
        Dim seenUids As List(Of String) = TXT2ListOfString(CurrPath)
        Dim usedPath As String = dbH.sAppPath & user & "-useduids.txt"
        Dim usedUids As List(Of String) = TXT2ListOfString(usedPath)
        Dim pop3Client As Pop3Client
        pop3Client = New Pop3Client()
        Try
            pop3Client.Connect(host, port, ssl)
        Catch ex As Exception
            MsgBox(ex.Message, vbSystemModal)
            'MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification, False)
            Exit Sub
        End Try

        If pop3Client.Connected = False Then
            TxtCounter.BackColor = Color.Red
        Else
            TxtCounter.BackColor = Color.LightGreen
            Try
                pop3Client.Authenticate(user, password, AuthenticationMethod.UsernameAndPassword)
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try

            ' If ChbReset.Checked = True Then pop3Client.Reset()
            lblStatusMsg.Visible = True
            lblStatusMsg.Text = "Mails werden geladen...."
            Dim count As Integer = pop3Client.GetMessageCount()
            '  MsgBox(count)
            Dim startCount As Integer = 1
            ' MsgBox(cbMaxMails.SelectedItem.ToString()) ' & "Value " & cbMaxMails.SelectedValue.ToString) ' & " Index " & cbMaxMails.SelectedIndex.ToString)
            If count >= CInt(cbMaxMails.SelectedItem) Then startCount = count - CInt(cbMaxMails.SelectedItem) + 1 Else startCount = 1
            lblStatusMsg.Text = "Es wurden die neuesten " & CInt(cbMaxMails.SelectedItem) & " von " & count & " Mails abgerufen."

            'MsgBox(count & " - " & cbMaxMails.SelectedItem.ToString)
            Dim uids As List(Of String) = pop3Client.GetMessageUids()
            TxtCounter.Text = count.ToString
            TxtCounter.Update()
            Dim Email(4) As String, GvIndex As Integer = -1, message As Message
            For i As Integer = count To startCount Step -1
                Try
                    TxtCounter.Text = GvIndex + 2 & "/" & count
                    TxtCounter.Update()
                    Dim currentUidOnServer As String = uids(i - 1)
                    allMessages.Add(pop3Client.GetMessage(i))
                    message = pop3Client.GetMessage(i)

                    Email(4) = pop3Client.GetMessageUid(i)
                    'Email(8) = message.Headers.MessageId
                    Email(2) = message.Headers.Subject
                    Email(1) = message.Headers.DateSent.ToString

                    Dim attachments As List(Of MessagePart) = message.FindAllAttachments()
                    attachments = message.FindAllAttachments()
                    If attachments.Count = 0 Then
                        Email(3) = ""
                    Else
                        Email(3) = "ja"
                    End If

                    GVEmails.Rows.Add()
                    GvIndex = GvIndex + 1
                    If Not seenUids.Contains(Email(4)) Then
                        GVEmails.Rows(GvIndex).DefaultCellStyle.Font = New Font(GVEmails.Font, FontStyle.Bold) 'ForeColor = Color.Red
                    Else
                        GVEmails.Rows(GvIndex).DefaultCellStyle.Font = New Font(GVEmails.Font, FontStyle.Regular)
                    End If

                    'Schon übernommenen Mails kennzeichnen
                    If usedUids.Contains(Email(4)) Then
                        GVEmails.Rows(GvIndex).DefaultCellStyle.Font = New Font(GVEmails.Font, FontStyle.Strikeout) 'ForeColor = Color.Red
                    Else
                        ' GVEmails.Rows(GvIndex).DefaultCellStyle.Font = New Font(GVEmails.Font, FontStyle.Regular)
                    End If
                    'Liste bereinigen

                    GVEmails.Item(0, GvIndex).Value = Email(3) 'Anlagen
                    GVEmails.Item(1, GvIndex).Value = Email(1) 'Datum 
                    GVEmails.Item(2, GvIndex).Value = Email(2) 'Betreff
                    GVEmails.Item(3, GvIndex).Value = Email(4) 'uid
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try


            Next
            For Each id In usedUids
                If Not seenUids.Contains(id) Then
                    ' MsgBox("löschen") 'usedUid löschen
                    usedUids.Remove(id)
                    Exit For
                End If
            Next
            ListOfString2TXT(usedPath, usedUids)
            ListOfString2TXT(CurrPath, uids)
            pop3Client.Disconnect()
        End If
        Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' Mailtext in ListOfString laden
    ''' </summary>
    ''' <param name="FullPath"></param>
    ''' <returns>lst</returns>
    Public Function TXT2ListOfString(ByVal FullPath As String) As List(Of String)
        Dim lst As New List(Of String)
        If IO.File.Exists(FullPath) Then lst.AddRange(IO.File.ReadAllLines(FullPath, System.Text.Encoding.Default))
        Return lst
    End Function
    ''' <summary>
    ''' List of String zu MailText
    ''' </summary>
    ''' <param name="FullPath"></param>
    ''' <param name="lst"></param>
    ''' <returns>True</returns>
    Public Function ListOfString2TXT(ByVal FullPath As String, ByVal lst As List(Of String)) As Boolean
        Dim f As New IO.FileInfo(FullPath)
        If f.Directory.Exists = True Then
            IO.File.WriteAllLines(FullPath, lst.ToArray, System.Text.Encoding.Default)
            Return True
        End If
        Return False
    End Function
    ''' <summary>
    ''' Anlagen aus der Message-Liste selektieren
    ''' </summary>
    ''' <returns></returns>
    Public Property SelAttachments1 As List(Of MessagePart)
        Get
            Return selAttachments
        End Get
        Set(value As List(Of MessagePart))
            selAttachments = value
        End Set
    End Property

#End Region
End Class
