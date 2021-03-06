﻿Imports OpenPop.Pop3
Imports OpenPop.Mime
Imports System.Text.RegularExpressions
Imports Message = OpenPop.Mime.Message
Imports System.IO
Imports System.ComponentModel
Imports FreeDMS_2020.dbHandling

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

    Dim todaySuche As Boolean = False
    Dim offenSuche As Boolean = False
    Dim FlagAkteArchiv As Boolean = False
    Dim flagOrdnerArchiv As Boolean = False
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

        Cursor.Current = Cursors.WaitCursor
        CurrDB = My.Settings.LastDB
        MsgBox(CurrDB)
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
        dbH.ChekDB()
        dbH.ChkSettings()
        Me.Text = "FreeDMS - Aktuelle DB: " & CurrDB
        'Setting laden:
        Dim myDB As String = Path.GetFileNameWithoutExtension(CurrDB)
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
        If mailAbrufStart = True Then
            UserTextBox1.Text = user
            HostTextBox1.Text = host
            TxtCounter.Visible = True
            Read_Emails()
        End If


        currDoc.Mandant = CInt(StartMandant)
        NotizBindingSource1.Filter = "id=0"
        LoadAll()
        LoadLvDok(LvScanInput)
        LoadLvDok(LVMailInput)
        FillTreeView()
        FindTreeNode(StartMandant)
        ''Beim Start kein Dokument anzeigen
        'DokumenteBindingSource.Filter = "id=0"
        Me.WindowState = FormWindowState.Maximized
    End Sub
    ''' <summary>
    ''' Tabeladapter füllen
    ''' Wiedervorlage prüfen
    ''' </summary>
    Private Sub LoadAll()

        dbH.LoadDB(CurrDB)
        MandantTableAdapter.Connection = con
        DokumenteTableAdapter.Connection = con
        DokumenteSQLTableAdapter.Connection = con
        VorgaengeTableAdapter.Connection = con
        AktenTableAdapter.Connection = con
        AnschriftenTableAdapter.Connection = con
        TypTableAdapter.Connection = con
        StatusTableAdapter.Connection = con
        AblageTableAdapter.Connection = con
        NotizTableAdapter.Connection = con
        SqlVorgangAkteTableAdapter.Connection = con
        WiedervorlageTableAdapter.Connection = con
        VorlagenTableAdapter.Connection = con
        AnlagenSQLTableAdapter.Connection = con

        MandantTableAdapter.Fill(_FreeDMS_StartDBDataSet.Mandant)
        DokumenteTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.Dokumente)
        DokumenteSQLTableAdapter.Fill(_FreeDMS_StartDBDataSet.DokumenteSQL)
        VorgaengeTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.Vorgaenge)
        AktenTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.Akten)
        AnschriftenTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.Anschriften)
        TypTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.Typ)
        StatusTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.Status)
        AblageTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.Ablage)
        NotizTableAdapter.Fill(_FreeDMS_StartDBDataSet.notiz)
        SqlVorgangAkteTableAdapter.Fill(_FreeDMS_StartDBDataSet.sqlVorgangAkte)
        WiedervorlageTableAdapter.Fill(_FreeDMS_StartDBDataSet.wiedervorlage)
        VorlagenTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.Vorlagen)
        AnlagenSQLTableAdapter.Fill(_FreeDMS_StartDBDataSet.AnlagenSQL)
        AnlagenSQLBindingSource.Filter = "id=0"

        'WiedevorlageDG markieren
        'Dim wv() As String '= Nothing
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            With DataGridView1
                Dim wvDate As String = .Rows(i).Cells(1).Value.ToString
                ' MsgBox(wvDate)
                Dim wv() As String = Split(wvDate)
                ' wv = String.Format("{0:M/dd/yyyy}", .Rows(i).Cells(1).Value.ToString)
                'MsgBox(Now.ToShortDateString & "-" & wv(0))
                If CDate(wv(0)) <= Now Then
                    .Rows(i).DefaultCellStyle.BackColor = Color.Red
                    .Rows(i).DefaultCellStyle.SelectionBackColor = Color.Red
                Else
                    .Rows(i).DefaultCellStyle.BackColor = Color.White
                End If
            End With
        Next
        SetCurrDoc()
    End Sub
    ''' <summary>
    ''' Das mit lv festgelegte ListView füllen
    ''' </summary>
    ''' <param name="lv"></param>
    Private Sub LoadLvDok(ByRef lv As ListView)
        Dim locDirInfo As DirectoryInfo = Nothing
        Dim locLtvItem As ListViewItem = Nothing
        'Dim ltv As ListView
        Dim okFile As String = ".DOC .MSG .PDF .JPG .JPEG .DOCX .TIF .GIF .TXT .XLS .XLSX .EML .PNG .DOT .PUB .BMP"
        Dim AnzahlFiles As Integer = 0
        'ltv = lvDoc
        ' ltv = lv 'lvScaninput
        With lv 'ltv
            Try
                .BeginUpdate()
                Dim items As ListView.ListViewItemCollection = .Items

                ' Spalten und Zeilen zurücksetzen
                items.Clear()
                .Columns.Clear()

                .MultiSelect = False
                .View = View.LargeIcon
                ' ImageList zurücksetzen
                ImageList1.Images.Clear()

                ' ImageList zuweisen
                .SmallImageList = ImageList1
                .LargeImageList = ImageList1
                ' Dateien ermitteln
                Try
                    locDirInfo = New DirectoryInfo(InputOrdner)
                Catch ex As Exception
                    MsgBox("Ordner nicht gefunden! Bitte die Settings überprüfen!")
                    Exit Sub
                End Try

                If Not locDirInfo.Exists Then Throw New DirectoryNotFoundException

                ' MsgBox(locDirInfo.GetFiles.Count.ToString)
                For Each locFi As FileInfo In locDirInfo.GetFiles("*.*", SearchOption.TopDirectoryOnly)

                    ' Icon zur ImageList hinzufügen - Key = Dateiendung
                    If Not ImageList1.Images.ContainsKey(locFi.Extension) Then
                        ImageList1.Images.Add(locFi.Extension, Icon.ExtractAssociatedIcon(locFi.FullName))
                    End If
                    If InStr(okFile, UCase(locFi.Extension)) <> 0 Then
                        locLtvItem = New ListViewItem(New String() {locFi.Name,
                                                                    locFi.Length.ToString(),
                                                                    locFi.Extension,
                                                                    locFi.LastAccessTime.ToString}) With {
                            .Tag = locFi, ' Für spätere Verarbeitung der Datei merken
                            .ImageKey = locFi.Extension   ' Icon zuweisen
                            }

                        items.Add(locLtvItem)
                        AnzahlFiles = AnzahlFiles + 1
                    End If
                Next

            Catch ex As Exception
                ' Throw
            Finally
                .EndUpdate()
                locDirInfo = Nothing
                locLtvItem = Nothing
            End Try
        End With
        If AnzahlFiles = 0 Then
            LbEingangsKorb.Text = "Der Eingangskorb ist leer."
        Else
            LbEingangsKorb.Text = "Eingangskorb (" & InputOrdner & ") mit " & AnzahlFiles & " Eingängen"
        End If
    End Sub
    ''' <summary>
    ''' Alle BindingSources beenden und Update der TableAdapter
    ''' </summary>
    Private Sub SaveAll()
        Try
            Validate()
            MandantBindingSource.EndEdit()
            DokumenteBindingSource.EndEdit()
            VorgaengeBindingSource.EndEdit()
            AktenBindingSource.EndEdit()
            AnschriftenBindingSource.EndEdit()
            AblageBindingSource.EndEdit()
            TypBindingSource.EndEdit()
            StatusBindingSource.EndEdit()
            NotizBindingSource.EndEdit()
            WiedervorlageBindingSource.EndEdit()
            VorlagenBindingSource.EndEdit()
            AnlagenSQLBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(Me._FreeDMS_StartDBDataSet)
        Catch ex As Exception
            MsgBox("Fehler beim Speichern! Bitte prüfen!")
        End Try
        'Aktuelle Settings zurückschreiben

        dbH.XMLWriter()
    End Sub
    ''' <summary>
    ''' DataGridViews auf letzze Zeile setzen
    ''' </summary>
    Private Sub SetLastDGVRow()
        'DGVs auf letzte Zeile fokussieren
        Dim row As Integer = DokumenteSQLBindingSource.Count - 1
        If DokumenteSQLDataGridView.Rows.Count > 1 Then
            DokumenteSQLDataGridView.FirstDisplayedScrollingRowIndex = row
            DokumenteSQLDataGridView.CurrentCell = DokumenteSQLDataGridView.Rows(row).Cells(0)
            DokumenteSQLDataGridView.Rows(row).Selected = True
        End If

    End Sub
    ''' <summary>
    ''' TreeView Mandant-Akte-Vorgang füllen
    ''' </summary>
    Private Sub FillTreeView()
        TreeView1.Nodes.Clear()
        Dim topNode As New TreeNode("Bereiche")
        TreeView1.Nodes.Add(topNode)
        topNode.Tag = "r;0"
        ' TreeView1.Font = New Font("Arial", 10, FontStyle.Bold)
        ' topNode.NodeFont = New Font(FontFamily.GenericSansSerif, FontStyle.Bold)
        ' Add topNode to the TreeView.
        ' TreeView1.Nodes.Add(topNode)
        Dim NodeMandant As TreeNode
        Dim NodeAkte As TreeNode
        Dim NodeVorgang As TreeNode
        NodeMandant = New TreeNode()
        ' NodeMandant.Tag = "Alles"
        NodeAkte = New TreeNode()
        NodeVorgang = New TreeNode

        Dim mandanten = From p In _FreeDMS_StartDBDataSet.Mandant
        'NodeMandant.ImageIndex = 0
        For Each myMandant In mandanten

            NodeMandant = New TreeNode(myMandant.id & " " & myMandant.Mandant, 0, 1) With {
                .Name = myMandant.id.ToString
            }
            topNode.NodeFont = New Font("Arial", 10, FontStyle.Bold)
            topNode.Nodes.Add(NodeMandant) 'TreeView1.Nodes.Add(NodeMandant)
            NodeMandant.Tag = "m;" & myMandant.id
            NodeMandant.Collapse()
            ''----für SubNode Akte

            Dim akten = From p In _FreeDMS_StartDBDataSet.Akten Where p.Mandant = CDbl(myMandant.id) And p.Archiv = FlagAkteArchiv
            For Each myAkte In akten
                NodeAkte = New TreeNode(myAkte.id & " " & myAkte.Akte, 2, 2) With {
                    .Name = myAkte.id.ToString
                }
                NodeMandant.Nodes.Add(NodeAkte)
                NodeAkte.Tag = "a;" & myAkte.id
                NodeAkte.Collapse()
                '--- Subnote Vorgang
                Dim vorgang = From p In _FreeDMS_StartDBDataSet.Vorgaenge Where p.Akte = CDbl(myAkte.id) And p.Archiv = flagOrdnerArchiv
                'MsgBox("Vorgänge: " & vorgang.Count.ToString)
                For Each myVorgang In vorgang
                    NodeVorgang = New TreeNode(myVorgang.id & " " & myVorgang.Vorgang, 3, 4) With {
                        .Name = myVorgang.id.ToString
                    }
                    NodeAkte.Nodes.Add(NodeVorgang)
                    NodeVorgang.NodeFont = New Font("Arial", 10, FontStyle.Regular)
                    NodeVorgang.Tag = "v;" & myVorgang.id
                    NodeVorgang.Collapse()
                Next
                'Next
            Next
        Next
        topNode.Expand()

    End Sub
    ''' <summary>
    ''' Festlegen des Starpunktes für TreeView
    ''' Ermitteln des aktuellen Knotens im TreeView
    ''' </summary>
    ''' <param name="az"></param>
    Private Sub FindTreeNode(ByVal az As String)
        Dim tn = TreeView1.Nodes.Find(az, True)

        If Not tn.Count = 1 Then
            Return
        End If
        TreeView1.SelectedNode = tn(0)
        TreeView1.Select()
    End Sub
    ''' <summary>
    ''' DataGridView Dokumente auf aktuelles Dok setzen
    ''' </summary>
    Private Sub SetCurrDoc()
        FindTreeNode(currDoc.Vorgang.ToString)
        Try
            For i = 0 To DokumenteDataGridView.Rows.Count - 1
                If CInt(DokumenteDataGridView.Rows(i).Cells(0).Value) = currDoc.Dokument Then

                    DokumenteDataGridView.Rows(i).Selected = True
                    DokumenteDataGridView.Refresh()
                End If
            Next
        Catch ex As Exception

        End Try

        DokShow()
    End Sub
    ''' <summary>
    ''' Zentrales Anzeigemodul
    ''' </summary>
    Private Sub DokShow()
        AblageTextBox.Text = Nothing
        TypTextBox.Text = Nothing
        StatusTextBox.Text = Nothing
        AnlagenSQLDataGridView.Visible = False
        LbAnlagen.Visible = True
        Try
            If DokumenteBindingSource.Current Is Nothing Then Exit Sub
            Dim rwDokument = DirectCast(DirectCast(DokumenteBindingSource.Current, DataRowView).Row, _FreeDMS_StartDBDataSet.DokumenteRow)
            GetMandantAkteVorgang()
            'MsgBox(rwDokument.Typ & ", " & rwDokument.Status & ", " & rwDokument.Ablage)
            With currDoc
                .Mandant = rwDokument.Mandant
                .Akte = rwDokument.Akte
                .Vorgang = rwDokument.Vorgang
                .Dokument = rwDokument.id
                If (Not rwDokument.IsDokNameNull) OrElse (Not rwDokument.Anlagen = Nothing) Then
                    .DokName = rwDokument.DokName
                End If
            End With
            If rwDokument.Anlagen > 0 Then
                ' MsgBox(rwDokument.Anlagen.ToString)
                AnlagenSQLBindingSource.Filter = "Dokid=" & rwDokument.id
                If AnlagenSQLBindingSource.Count > 0 Then
                    AnlagenSQLDataGridView.Visible = True
                    LbAnlagen.Text = "Anlage(n)"
                Else
                    AnlagenSQLDataGridView.Visible = False
                    LbAnlagen.Text = "Anlage nicht zugeordnet (stammt aus früherer FreeDMS-Version)!"
                End If
            Else
                AnlagenSQLDataGridView.Visible = False
                LbAnlagen.Text = "keine Anlage(n)"
            End If
            If Not rwDokument.IsistAnlageNull Then
                If rwDokument.istAnlage = True Then
                    LbIstAnlage.Visible = True

                Else
                    LbIstAnlage.Visible = False
                End If
            End If
            If Not rwDokument.IsAbsenderNull Then
                AnschriftenBindingSource.Filter = "id=" & rwDokument.Absender
            Else
                AbsenderTextBox.Text = ""
            End If
            If Not rwDokument.IsEmpfaengerNull Then
                AnschriftenBindingSource1.Filter = "id=" & rwDokument.Empfaenger
            Else
                EmpfaengerTextBox.Text = ""
            End If
            If Not rwDokument.IsBetragNull Then
                BetragTextBox.Text = rwDokument.Betrag.ToString("C")
            Else
                BetragTextBox.Text = Nothing
            End If
            Dim status = From p In _FreeDMS_StartDBDataSet.Status Where p.id = CInt(rwDokument.Status) Select p
            If status.Count > 0 Then
                For Each eintrag In status
                    StatusTextBox.Text = eintrag.Status
                Next
            Else
                StatusTextBox.Text = "Nicht zugeordnet"
            End If
            Dim typ = From p In _FreeDMS_StartDBDataSet.Typ Where p.id = CInt(rwDokument.Typ) Select p
            If typ.Count > 0 Then
                For Each eintrag In typ
                    TypTextBox.Text = eintrag.Typ
                Next
            Else
                TypTextBox.Text = "Nicht zugeordnet"
            End If
            Dim ablage = From p In _FreeDMS_StartDBDataSet.Ablage Where p.Nummer = CInt(rwDokument.Ablage) Select p
            If ablage.Count > 0 Then
                For Each eintrag In ablage
                    AblageTextBox.Text = eintrag.Ablage
                Next
            Else
                AblageTextBox.Text = "Nicht zugeordnet"
            End If


            NotizBindingSource1.Filter = "dokument=" & currDoc.Dokument
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    ''' <summary>
    ''' Syncronisation von Mandant-Akte-Vorgang
    ''' </summary>
    Private Sub GetMandantAkteVorgang()
        Dim txtMandant As String = Nothing
        Dim txtAkte As String = Nothing
        Dim txtVorgang As String = Nothing
        Dim az As String = Nothing

        Try
            Dim rwDokument = DirectCast(DirectCast(DokumenteBindingSource.Current, DataRowView).Row, _FreeDMS_StartDBDataSet.DokumenteRow)
            lbAnzahl.Text = "Enthält " & DokumenteBindingSource.Count & " Dokumente"
            If rwDokument.id > 0 Then
                MandantBindingSource.Filter = "id=" & rwDokument.Mandant
                AktenBindingSource.Filter = "id=" & rwDokument.Akte
                VorgaengeBindingSource.Filter = "id=" & rwDokument.Vorgang
                az = rwDokument.Mandant & "-" & rwDokument.Akte & "-" & rwDokument.Vorgang & "/" & rwDokument.id
            End If
            'Mandat auslesen
            Dim rwMandant = DirectCast(DirectCast(MandantBindingSource.Current, DataRowView).Row, _FreeDMS_StartDBDataSet.MandantRow)
            If Not rwMandant.IsMandantNull Then
                txtMandant = rwMandant.Mandant
            End If
            'Akte auslesen
            Dim rwAkten = DirectCast(DirectCast(AktenBindingSource.Current, DataRowView).Row, _FreeDMS_StartDBDataSet.AktenRow)
            If Not rwAkten.IsAkteNull Then
                txtAkte = rwAkten.Akte
            End If
            'Vorgang auslesen
            Dim rwVorgang = DirectCast(DirectCast(VorgaengeBindingSource.Current, DataRowView).Row, _FreeDMS_StartDBDataSet.VorgaengeRow)
            If Not rwVorgang.IsVorgangNull Then
                txtVorgang = rwVorgang.Vorgang
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        lbMandant.Text = txtMandant
        lbAkte.Text = txtAkte
        lbVorgang.Text = txtVorgang
        lbAz.Text = "Aktenzeichen " & az
    End Sub

    ''' <summary>
    ''' Aufruf Detailansicht Dokumente aus DokumenteDataGridView
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DokumenteDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DokumenteDataGridView.CellClick
        DokShow()
    End Sub
    Private Sub DokumenteDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DokumenteDataGridView.CellDoubleClick
        '  DocEdit(DirectCast(DokumenteBindingSource.Current, DataRowView).Item("id").ToString)
    End Sub
    Private Sub ArchivierteVorgängeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArchivierteVorgängeToolStripMenuItem.Click
        'Dim f As New VorgaengeArchiv
        'f.AktenBindingSource.DataSource = _FreeDMS_StartDBDataSet
        'f.AktenBindingSource1.DataSource = _FreeDMS_StartDBDataSet
        'f.VorgaengeBindingSource.DataSource = _FreeDMS_StartDBDataSet
        'f.ShowDialog()
        'If _FreeDMS_StartDBDataSet.HasChanges Then Update()
    End Sub
    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        UpdateAll()
    End Sub
    Private Sub UpdateAll()
        If Not DokumenteBindingSource.Current Is Nothing OrElse DokumenteBindingSource.Count > 0 Then
            Dim rwAkten = DirectCast(DirectCast(DokumenteBindingSource.Current, DataRowView).Row, _FreeDMS_StartDBDataSet.DokumenteRow)
            With currDoc
                .Mandant = CInt(rwAkten.Mandant)
                .Akte = CInt(rwAkten.Akte)
                .Vorgang = CInt(rwAkten.Vorgang)
                .Dokument = rwAkten.id
            End With
            DokumenteDataGridView.DataSource = Nothing

            ' Else
            'MsgBox("Bitte zunächst einen Vorgang auswählen!")
        End If
        StartRefresh()
    End Sub
    Public Sub StartRefresh()
        'SetCurrDoc()

        BGWRefresh.RunWorkerAsync()
        ProgressBar1.Visible = True
    End Sub

    Private Sub BGWRefresh_DoWork(sender As Object, e As DoWorkEventArgs) Handles BGWRefresh.DoWork
        SaveAll()
        LoadAll()

    End Sub

    Private Sub BGWRefresh_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BGWRefresh.RunWorkerCompleted
        ProgressBar1.Visible = False
        LoadLvDok(LvScanInput)

        DokumenteDataGridView.DataSource = DokumenteBindingSource
        FillTreeView()
        SetCurrDoc()

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
        Dim CurrPath As String = sAppPath & user & "-uids.txt"
        Dim seenUids As List(Of String) = TXT2ListOfString(CurrPath)
        Dim usedPath As String = sAppPath & user & "-useduids.txt"
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
#Region "Handling"

    ''' <summary>
    ''' Die mit TreeView ausgewälten Daten anzeigen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        Dim sItem(2) As String
        Dim lbVorhanden As Boolean = True
        sItem = Split(TreeView1.SelectedNode.Tag.ToString, ";")
        TreeView1.SelectedNode.Expand()
        'MsgBox(TreeView1.SelectedNode.Name)
        Select Case sItem(0)
            Case "r" 'Alles (Root)
                Me.DokumenteBindingSource.Filter = "ID > 0"
                GetMandantAkteVorgang()

            Case "m" 'Mandante
                Me.DokumenteBindingSource.Filter = "Mandant=" & sItem(1)

                If DokumenteBindingSource.Count > 0 Then

                    GetMandantAkteVorgang()
                Else
                    lbVorhanden = False
                End If

            Case "a" 'Akte
                Me.DokumenteBindingSource.Filter = "Akte=" & sItem(1)
                If DokumenteBindingSource.Count > 0 Then
                    GetMandantAkteVorgang()

                Else
                    lbVorhanden = False
                End If

            Case "v" 'Vorgang
                Me.DokumenteBindingSource.Filter = "Vorgang=" & sItem(1)
                If DokumenteBindingSource.Count > 0 Then

                    GetMandantAkteVorgang()
                Else
                    lbVorhanden = False
                End If

                If lbVorhanden = False Then
                    MsgBox("Kein Vorgang Vorhanden!")
                End If

        End Select
        SetLastDGVRow()

    End Sub
#End Region
#Region "Buttons"
    ''' <summary>
    ''' Programm beenden
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ToolStripButtonExit_Click(sender As Object, e As EventArgs) Handles ToolStripButtonExit.Click, BeendenToolStripMenuItem.Click
        lblClose = True
        SaveAll()
        My.Settings.LastDB = CurrDB
        Application.Exit()
        ' Close()
    End Sub

    Private Sub OptionenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionenToolStripMenuItem.Click
        Dim f As New Settings
        f.MandantBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.AnschriftenBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.ShowDialog()
        If _FreeDMS_StartDBDataSet.HasChanges Then SaveAll()
    End Sub





#End Region
End Class
