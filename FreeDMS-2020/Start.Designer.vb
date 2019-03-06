<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DokumentLabel As System.Windows.Forms.Label
        Dim BetreffLabel As System.Windows.Forms.Label
        Dim BetragLabel As System.Windows.Forms.Label
        Dim AbsenderLabel As System.Windows.Forms.Label
        Dim EmpfaengerLabel As System.Windows.Forms.Label
        Dim DokDatumLabel As System.Windows.Forms.Label
        Dim KommentarLabel As System.Windows.Forms.Label
        Dim AblageLabel As System.Windows.Forms.Label
        Dim TypLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim DokNameLabel As System.Windows.Forms.Label
        Dim BearbVermerkLabel As System.Windows.Forms.Label
        Dim ArchivLabel1 As System.Windows.Forms.Label
        Dim VorgangLabel As System.Windows.Forms.Label
        Dim BeendetLabel As System.Windows.Forms.Label
        Dim BeschreibungLabel1 As System.Windows.Forms.Label
        Dim HinweiseLabel As System.Windows.Forms.Label
        Dim BegonnenLabel As System.Windows.Forms.Label
        Dim MandantLabel1 As System.Windows.Forms.Label
        Dim ArchivLabel As System.Windows.Forms.Label
        Dim AkteLabel As System.Windows.Forms.Label
        Dim ArchiviertLabel As System.Windows.Forms.Label
        Dim BeschreibungLabel As System.Windows.Forms.Label
        Dim AngelegtLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.DocNotizDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbNotizDok = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.PanelSuche = New System.Windows.Forms.Panel()
        Me.btClear = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btSearcj = New System.Windows.Forms.Button()
        Me.ComboBoxSuche = New System.Windows.Forms.ComboBox()
        Me.TextSuche = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CbAblageSuche = New System.Windows.Forms.ComboBox()
        Me.CbTypSuche = New System.Windows.Forms.ComboBox()
        Me.CbStatusSuche = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DokumenteDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.AnlagenSQLDataGridView = New System.Windows.Forms.DataGridView()
        Me.LbIstAnlage = New System.Windows.Forms.Label()
        Me.LbAnlagen = New System.Windows.Forms.Label()
        Me.PnlDokButton = New System.Windows.Forms.Panel()
        Me.btDocNotiz = New System.Windows.Forms.Button()
        Me.btShowDoc = New System.Windows.Forms.Button()
        Me.BtWiedervorlage = New System.Windows.Forms.Button()
        Me.BtPrint = New System.Windows.Forms.Button()
        Me.DokDatumTextBox = New System.Windows.Forms.TextBox()
        Me.DokumentTextBox = New System.Windows.Forms.TextBox()
        Me.BetreffTextBox = New System.Windows.Forms.TextBox()
        Me.BetragTextBox = New System.Windows.Forms.TextBox()
        Me.AbsenderTextBox = New System.Windows.Forms.TextBox()
        Me.EmpfaengerTextBox = New System.Windows.Forms.TextBox()
        Me.KommentarTextBox = New System.Windows.Forms.TextBox()
        Me.AblageTextBox = New System.Windows.Forms.TextBox()
        Me.TypTextBox = New System.Windows.Forms.TextBox()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.DokNameTextBox = New System.Windows.Forms.TextBox()
        Me.BearbVermerkTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BeendetTextBox = New System.Windows.Forms.TextBox()
        Me.BegonnenTextBox = New System.Windows.Forms.TextBox()
        Me.BeschreibungTextBox1 = New System.Windows.Forms.TextBox()
        Me.IdTextBox1 = New System.Windows.Forms.TextBox()
        Me.ArchivCheckBox1 = New System.Windows.Forms.CheckBox()
        Me.VorgangTextBox = New System.Windows.Forms.TextBox()
        Me.HinweiseTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ArchiviertTextBox = New System.Windows.Forms.TextBox()
        Me.AngelegtTextBox = New System.Windows.Forms.TextBox()
        Me.MandantTextBox1 = New System.Windows.Forms.TextBox()
        Me.BeschreibungTextBox = New System.Windows.Forms.TextBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.ArchivCheckBox = New System.Windows.Forms.CheckBox()
        Me.AkteTextBox = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbAz = New System.Windows.Forms.Label()
        Me.lbVorgang = New System.Windows.Forms.Label()
        Me.lbAkte = New System.Windows.Forms.Label()
        Me.lbMandant = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lbAnzahl = New System.Windows.Forms.Label()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NotizDataGridView = New System.Windows.Forms.DataGridView()
        Me.erstellt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelSuchBack = New System.Windows.Forms.Panel()
        Me.PanelSuchErgeb = New System.Windows.Forms.Panel()
        Me.lblSuchErgebnis = New System.Windows.Forms.Label()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBoxAnzeige = New System.Windows.Forms.GroupBox()
        Me.RBOrdnerArchiv = New System.Windows.Forms.RadioButton()
        Me.RBAktenArchiv = New System.Windows.Forms.RadioButton()
        Me.RBAlles = New System.Windows.Forms.RadioButton()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Wiedervorlage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LblWv = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.LbEingangsKorb = New System.Windows.Forms.Label()
        Me.LvScanInput = New System.Windows.Forms.ListView()
        DokumentLabel = New System.Windows.Forms.Label()
        BetreffLabel = New System.Windows.Forms.Label()
        BetragLabel = New System.Windows.Forms.Label()
        AbsenderLabel = New System.Windows.Forms.Label()
        EmpfaengerLabel = New System.Windows.Forms.Label()
        DokDatumLabel = New System.Windows.Forms.Label()
        KommentarLabel = New System.Windows.Forms.Label()
        AblageLabel = New System.Windows.Forms.Label()
        TypLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        DokNameLabel = New System.Windows.Forms.Label()
        BearbVermerkLabel = New System.Windows.Forms.Label()
        ArchivLabel1 = New System.Windows.Forms.Label()
        VorgangLabel = New System.Windows.Forms.Label()
        BeendetLabel = New System.Windows.Forms.Label()
        BeschreibungLabel1 = New System.Windows.Forms.Label()
        HinweiseLabel = New System.Windows.Forms.Label()
        BegonnenLabel = New System.Windows.Forms.Label()
        MandantLabel1 = New System.Windows.Forms.Label()
        ArchivLabel = New System.Windows.Forms.Label()
        AkteLabel = New System.Windows.Forms.Label()
        ArchiviertLabel = New System.Windows.Forms.Label()
        BeschreibungLabel = New System.Windows.Forms.Label()
        AngelegtLabel = New System.Windows.Forms.Label()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel21.SuspendLayout()
        CType(Me.DocNotizDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.PanelSuche.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DokumenteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.AnlagenSQLDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlDokButton.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel19.SuspendLayout()
        CType(Me.NotizDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSuchBack.SuspendLayout()
        Me.PanelSuchErgeb.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBoxAnzeige.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TabControl1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1459, 805)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(1459, 830)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1459, 805)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1451, 779)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(192, 74)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel21, 4, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel10, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DokumenteDataGridView, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel5, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel6, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel19, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelSuchBack, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TreeView1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel8, 5, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel7, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LvScanInput, 5, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 122.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1445, 773)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Panel21
        '
        Me.Panel21.AutoScroll = True
        Me.Panel21.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel21.Controls.Add(Me.DocNotizDataGridView)
        Me.Panel21.Controls.Add(Me.lbNotizDok)
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel21.Location = New System.Drawing.Point(731, 605)
        Me.Panel21.Name = "Panel21"
        Me.TableLayoutPanel1.SetRowSpan(Me.Panel21, 2)
        Me.Panel21.Size = New System.Drawing.Size(444, 144)
        Me.Panel21.TabIndex = 34
        '
        'DocNotizDataGridView
        '
        Me.DocNotizDataGridView.AllowUserToAddRows = False
        Me.DocNotizDataGridView.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.DocNotizDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DocNotizDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        Me.DocNotizDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DocNotizDataGridView.Location = New System.Drawing.Point(0, 26)
        Me.DocNotizDataGridView.MultiSelect = False
        Me.DocNotizDataGridView.Name = "DocNotizDataGridView"
        Me.DocNotizDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocNotizDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DocNotizDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DocNotizDataGridView.Size = New System.Drawing.Size(444, 118)
        Me.DocNotizDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "erstellt"
        DataGridViewCellStyle8.Format = "d"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn1.HeaderText = "Vom"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ToolTipText = "Maus-Klick für Details"
        Me.DataGridViewTextBoxColumn1.Width = 53
        '
        'lbNotizDok
        '
        Me.lbNotizDok.AutoSize = True
        Me.lbNotizDok.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNotizDok.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbNotizDok.Location = New System.Drawing.Point(4, 6)
        Me.lbNotizDok.Name = "lbNotizDok"
        Me.lbNotizDok.Size = New System.Drawing.Size(137, 13)
        Me.lbNotizDok.TabIndex = 0
        Me.lbNotizDok.Text = "Notizen zum Dokument"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel1.SetColumnSpan(Me.Panel10, 4)
        Me.Panel10.Controls.Add(Me.PanelSuche)
        Me.Panel10.Controls.Add(Me.Label6)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(178, 3)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(997, 69)
        Me.Panel10.TabIndex = 29
        '
        'PanelSuche
        '
        Me.PanelSuche.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelSuche.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelSuche.Controls.Add(Me.btClear)
        Me.PanelSuche.Controls.Add(Me.GroupBox2)
        Me.PanelSuche.Controls.Add(Me.GroupBox1)
        Me.PanelSuche.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelSuche.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuche.Name = "PanelSuche"
        Me.PanelSuche.Size = New System.Drawing.Size(995, 67)
        Me.PanelSuche.TabIndex = 26
        '
        'btClear
        '
        Me.btClear.Location = New System.Drawing.Point(945, 22)
        Me.btClear.Name = "btClear"
        Me.btClear.Size = New System.Drawing.Size(77, 33)
        Me.btClear.TabIndex = 32
        Me.btClear.Text = "Clear"
        Me.btClear.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btSearcj)
        Me.GroupBox2.Controls.Add(Me.ComboBoxSuche)
        Me.GroupBox2.Controls.Add(Me.TextSuche)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(422, 51)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Suche in Feldern"
        '
        'btSearcj
        '
        Me.btSearcj.Location = New System.Drawing.Point(320, 10)
        Me.btSearcj.Name = "btSearcj"
        Me.btSearcj.Size = New System.Drawing.Size(77, 33)
        Me.btSearcj.TabIndex = 31
        Me.btSearcj.Text = "Suchen "
        Me.btSearcj.UseVisualStyleBackColor = True
        '
        'ComboBoxSuche
        '
        Me.ComboBoxSuche.FormattingEnabled = True
        Me.ComboBoxSuche.Location = New System.Drawing.Point(151, 17)
        Me.ComboBoxSuche.Name = "ComboBoxSuche"
        Me.ComboBoxSuche.Size = New System.Drawing.Size(163, 21)
        Me.ComboBoxSuche.TabIndex = 36
        '
        'TextSuche
        '
        Me.TextSuche.Location = New System.Drawing.Point(8, 17)
        Me.TextSuche.Name = "TextSuche"
        Me.TextSuche.Size = New System.Drawing.Size(141, 20)
        Me.TextSuche.TabIndex = 35
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CbAblageSuche)
        Me.GroupBox1.Controls.Add(Me.CbTypSuche)
        Me.GroupBox1.Controls.Add(Me.CbStatusSuche)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(433, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(506, 50)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Schnellsuche"
        '
        'CbAblageSuche
        '
        Me.CbAblageSuche.DisplayMember = "Ablage"
        Me.CbAblageSuche.FormattingEnabled = True
        Me.CbAblageSuche.Location = New System.Drawing.Point(388, 19)
        Me.CbAblageSuche.Name = "CbAblageSuche"
        Me.CbAblageSuche.Size = New System.Drawing.Size(108, 21)
        Me.CbAblageSuche.TabIndex = 43
        Me.CbAblageSuche.ValueMember = "Nummer"
        '
        'CbTypSuche
        '
        Me.CbTypSuche.DisplayMember = "Typ"
        Me.CbTypSuche.FormattingEnabled = True
        Me.CbTypSuche.Location = New System.Drawing.Point(219, 19)
        Me.CbTypSuche.Name = "CbTypSuche"
        Me.CbTypSuche.Size = New System.Drawing.Size(105, 21)
        Me.CbTypSuche.TabIndex = 42
        Me.CbTypSuche.ValueMember = "id"
        '
        'CbStatusSuche
        '
        Me.CbStatusSuche.DisplayMember = "Status"
        Me.CbStatusSuche.FormattingEnabled = True
        Me.CbStatusSuche.Location = New System.Drawing.Point(67, 19)
        Me.CbStatusSuche.Name = "CbStatusSuche"
        Me.CbStatusSuche.Size = New System.Drawing.Size(105, 21)
        Me.CbStatusSuche.TabIndex = 41
        Me.CbStatusSuche.ValueMember = "id"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(336, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Ablage"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(185, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 13)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Typ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Status"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(46, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Suchen"
        '
        'DokumenteDataGridView
        '
        Me.DokumenteDataGridView.AllowUserToAddRows = False
        Me.DokumenteDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.LightSteelBlue
        Me.DokumenteDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DokumenteDataGridView.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.DokumenteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel1.SetColumnSpan(Me.DokumenteDataGridView, 2)
        Me.DokumenteDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DokumenteDataGridView.Location = New System.Drawing.Point(353, 78)
        Me.DokumenteDataGridView.MultiSelect = False
        Me.DokumenteDataGridView.Name = "DokumenteDataGridView"
        Me.DokumenteDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DokumenteDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle11
        Me.TableLayoutPanel1.SetRowSpan(Me.DokumenteDataGridView, 3)
        Me.DokumenteDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DokumenteDataGridView.Size = New System.Drawing.Size(372, 404)
        Me.DokumenteDataGridView.TabIndex = 36
        '
        'Panel5
        '
        Me.Panel5.AutoScroll = True
        Me.Panel5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.AnlagenSQLDataGridView)
        Me.Panel5.Controls.Add(Me.LbIstAnlage)
        Me.Panel5.Controls.Add(Me.LbAnlagen)
        Me.Panel5.Controls.Add(Me.PnlDokButton)
        Me.Panel5.Controls.Add(Me.DokDatumTextBox)
        Me.Panel5.Controls.Add(DokumentLabel)
        Me.Panel5.Controls.Add(Me.DokumentTextBox)
        Me.Panel5.Controls.Add(BetreffLabel)
        Me.Panel5.Controls.Add(Me.BetreffTextBox)
        Me.Panel5.Controls.Add(BetragLabel)
        Me.Panel5.Controls.Add(Me.BetragTextBox)
        Me.Panel5.Controls.Add(AbsenderLabel)
        Me.Panel5.Controls.Add(Me.AbsenderTextBox)
        Me.Panel5.Controls.Add(EmpfaengerLabel)
        Me.Panel5.Controls.Add(Me.EmpfaengerTextBox)
        Me.Panel5.Controls.Add(DokDatumLabel)
        Me.Panel5.Controls.Add(KommentarLabel)
        Me.Panel5.Controls.Add(Me.KommentarTextBox)
        Me.Panel5.Controls.Add(AblageLabel)
        Me.Panel5.Controls.Add(Me.AblageTextBox)
        Me.Panel5.Controls.Add(TypLabel)
        Me.Panel5.Controls.Add(Me.TypTextBox)
        Me.Panel5.Controls.Add(StatusLabel)
        Me.Panel5.Controls.Add(Me.StatusTextBox)
        Me.Panel5.Controls.Add(DokNameLabel)
        Me.Panel5.Controls.Add(Me.DokNameTextBox)
        Me.Panel5.Controls.Add(BearbVermerkLabel)
        Me.Panel5.Controls.Add(Me.BearbVermerkTextBox)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(731, 156)
        Me.Panel5.Name = "Panel5"
        Me.TableLayoutPanel1.SetRowSpan(Me.Panel5, 3)
        Me.Panel5.Size = New System.Drawing.Size(444, 443)
        Me.Panel5.TabIndex = 6
        '
        'AnlagenSQLDataGridView
        '
        Me.AnlagenSQLDataGridView.AllowUserToAddRows = False
        Me.AnlagenSQLDataGridView.AllowUserToDeleteRows = False
        Me.AnlagenSQLDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.AnlagenSQLDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AnlagenSQLDataGridView.Location = New System.Drawing.Point(34, 328)
        Me.AnlagenSQLDataGridView.Name = "AnlagenSQLDataGridView"
        Me.AnlagenSQLDataGridView.ReadOnly = True
        Me.AnlagenSQLDataGridView.RowHeadersVisible = False
        Me.AnlagenSQLDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AnlagenSQLDataGridView.Size = New System.Drawing.Size(366, 127)
        Me.AnlagenSQLDataGridView.TabIndex = 82
        '
        'LbIstAnlage
        '
        Me.LbIstAnlage.AutoSize = True
        Me.LbIstAnlage.Location = New System.Drawing.Point(55, 284)
        Me.LbIstAnlage.Name = "LbIstAnlage"
        Me.LbIstAnlage.Size = New System.Drawing.Size(51, 13)
        Me.LbIstAnlage.TabIndex = 82
        Me.LbIstAnlage.Text = "IstAnlage"
        '
        'LbAnlagen
        '
        Me.LbAnlagen.AutoSize = True
        Me.LbAnlagen.Location = New System.Drawing.Point(36, 307)
        Me.LbAnlagen.Name = "LbAnlagen"
        Me.LbAnlagen.Size = New System.Drawing.Size(55, 13)
        Me.LbAnlagen.TabIndex = 81
        Me.LbAnlagen.Text = "Anlage(n):"
        '
        'PnlDokButton
        '
        Me.PnlDokButton.Controls.Add(Me.btDocNotiz)
        Me.PnlDokButton.Controls.Add(Me.btShowDoc)
        Me.PnlDokButton.Controls.Add(Me.BtWiedervorlage)
        Me.PnlDokButton.Controls.Add(Me.BtPrint)
        Me.PnlDokButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlDokButton.Location = New System.Drawing.Point(0, 455)
        Me.PnlDokButton.Name = "PnlDokButton"
        Me.PnlDokButton.Size = New System.Drawing.Size(425, 55)
        Me.PnlDokButton.TabIndex = 80
        '
        'btDocNotiz
        '
        Me.btDocNotiz.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btDocNotiz.Location = New System.Drawing.Point(172, 32)
        Me.btDocNotiz.Name = "btDocNotiz"
        Me.btDocNotiz.Size = New System.Drawing.Size(98, 23)
        Me.btDocNotiz.TabIndex = 78
        Me.btDocNotiz.Text = "Neue Notiz"
        Me.btDocNotiz.UseVisualStyleBackColor = True
        '
        'btShowDoc
        '
        Me.btShowDoc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btShowDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btShowDoc.Location = New System.Drawing.Point(70, 3)
        Me.btShowDoc.Name = "btShowDoc"
        Me.btShowDoc.Size = New System.Drawing.Size(281, 23)
        Me.btShowDoc.TabIndex = 75
        Me.btShowDoc.Text = "Ansehen/Ändern"
        Me.btShowDoc.UseVisualStyleBackColor = True
        '
        'BtWiedervorlage
        '
        Me.BtWiedervorlage.Location = New System.Drawing.Point(3, 32)
        Me.BtWiedervorlage.Name = "BtWiedervorlage"
        Me.BtWiedervorlage.Size = New System.Drawing.Size(98, 23)
        Me.BtWiedervorlage.TabIndex = 76
        Me.BtWiedervorlage.Text = "Wiedervorlage"
        Me.BtWiedervorlage.UseVisualStyleBackColor = True
        '
        'BtPrint
        '
        Me.BtPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtPrint.Location = New System.Drawing.Point(341, 32)
        Me.BtPrint.Name = "BtPrint"
        Me.BtPrint.Size = New System.Drawing.Size(98, 23)
        Me.BtPrint.TabIndex = 77
        Me.BtPrint.Text = "Drucken"
        Me.BtPrint.UseVisualStyleBackColor = True
        '
        'DokDatumTextBox
        '
        Me.DokDatumTextBox.Location = New System.Drawing.Point(110, 174)
        Me.DokDatumTextBox.Name = "DokDatumTextBox"
        Me.DokDatumTextBox.ReadOnly = True
        Me.DokDatumTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DokDatumTextBox.TabIndex = 44
        '
        'DokumentLabel
        '
        DokumentLabel.AutoSize = True
        DokumentLabel.Location = New System.Drawing.Point(36, 8)
        DokumentLabel.Name = "DokumentLabel"
        DokumentLabel.Size = New System.Drawing.Size(59, 13)
        DokumentLabel.TabIndex = 8
        DokumentLabel.Text = "Dokument:"
        '
        'DokumentTextBox
        '
        Me.DokumentTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DokumentTextBox.Location = New System.Drawing.Point(110, 5)
        Me.DokumentTextBox.Name = "DokumentTextBox"
        Me.DokumentTextBox.ReadOnly = True
        Me.DokumentTextBox.Size = New System.Drawing.Size(291, 20)
        Me.DokumentTextBox.TabIndex = 9
        '
        'BetreffLabel
        '
        BetreffLabel.AutoSize = True
        BetreffLabel.Location = New System.Drawing.Point(55, 31)
        BetreffLabel.Name = "BetreffLabel"
        BetreffLabel.Size = New System.Drawing.Size(41, 13)
        BetreffLabel.TabIndex = 10
        BetreffLabel.Text = "Betreff:"
        '
        'BetreffTextBox
        '
        Me.BetreffTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BetreffTextBox.Location = New System.Drawing.Point(110, 31)
        Me.BetreffTextBox.Name = "BetreffTextBox"
        Me.BetreffTextBox.ReadOnly = True
        Me.BetreffTextBox.Size = New System.Drawing.Size(291, 20)
        Me.BetreffTextBox.TabIndex = 11
        '
        'BetragLabel
        '
        BetragLabel.AutoSize = True
        BetragLabel.Location = New System.Drawing.Point(56, 62)
        BetragLabel.Name = "BetragLabel"
        BetragLabel.Size = New System.Drawing.Size(41, 13)
        BetragLabel.TabIndex = 12
        BetragLabel.Text = "Betrag:"
        '
        'BetragTextBox
        '
        Me.BetragTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BetragTextBox.Location = New System.Drawing.Point(110, 62)
        Me.BetragTextBox.Name = "BetragTextBox"
        Me.BetragTextBox.ReadOnly = True
        Me.BetragTextBox.Size = New System.Drawing.Size(113, 20)
        Me.BetragTextBox.TabIndex = 13
        '
        'AbsenderLabel
        '
        AbsenderLabel.AutoSize = True
        AbsenderLabel.Location = New System.Drawing.Point(40, 122)
        AbsenderLabel.Name = "AbsenderLabel"
        AbsenderLabel.Size = New System.Drawing.Size(55, 13)
        AbsenderLabel.TabIndex = 16
        AbsenderLabel.Text = "Absender:"
        '
        'AbsenderTextBox
        '
        Me.AbsenderTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AbsenderTextBox.Location = New System.Drawing.Point(110, 122)
        Me.AbsenderTextBox.Name = "AbsenderTextBox"
        Me.AbsenderTextBox.ReadOnly = True
        Me.AbsenderTextBox.Size = New System.Drawing.Size(291, 20)
        Me.AbsenderTextBox.TabIndex = 17
        '
        'EmpfaengerLabel
        '
        EmpfaengerLabel.AutoSize = True
        EmpfaengerLabel.Location = New System.Drawing.Point(26, 148)
        EmpfaengerLabel.Name = "EmpfaengerLabel"
        EmpfaengerLabel.Size = New System.Drawing.Size(67, 13)
        EmpfaengerLabel.TabIndex = 18
        EmpfaengerLabel.Text = "Empfaenger:"
        '
        'EmpfaengerTextBox
        '
        Me.EmpfaengerTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpfaengerTextBox.Location = New System.Drawing.Point(110, 148)
        Me.EmpfaengerTextBox.Name = "EmpfaengerTextBox"
        Me.EmpfaengerTextBox.ReadOnly = True
        Me.EmpfaengerTextBox.Size = New System.Drawing.Size(291, 20)
        Me.EmpfaengerTextBox.TabIndex = 19
        '
        'DokDatumLabel
        '
        DokDatumLabel.AutoSize = True
        DokDatumLabel.Location = New System.Drawing.Point(30, 175)
        DokDatumLabel.Name = "DokDatumLabel"
        DokDatumLabel.Size = New System.Drawing.Size(64, 13)
        DokDatumLabel.TabIndex = 20
        DokDatumLabel.Text = "Dok Datum:"
        '
        'KommentarLabel
        '
        KommentarLabel.AutoSize = True
        KommentarLabel.Location = New System.Drawing.Point(31, 203)
        KommentarLabel.Name = "KommentarLabel"
        KommentarLabel.Size = New System.Drawing.Size(63, 13)
        KommentarLabel.TabIndex = 26
        KommentarLabel.Text = "Kommentar:"
        '
        'KommentarTextBox
        '
        Me.KommentarTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KommentarTextBox.Location = New System.Drawing.Point(110, 203)
        Me.KommentarTextBox.Multiline = True
        Me.KommentarTextBox.Name = "KommentarTextBox"
        Me.KommentarTextBox.ReadOnly = True
        Me.KommentarTextBox.Size = New System.Drawing.Size(291, 46)
        Me.KommentarTextBox.TabIndex = 27
        '
        'AblageLabel
        '
        AblageLabel.AutoSize = True
        AblageLabel.Location = New System.Drawing.Point(232, 88)
        AblageLabel.Name = "AblageLabel"
        AblageLabel.Size = New System.Drawing.Size(43, 13)
        AblageLabel.TabIndex = 30
        AblageLabel.Text = "Ablage:"
        '
        'AblageTextBox
        '
        Me.AblageTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AblageTextBox.Location = New System.Drawing.Point(287, 85)
        Me.AblageTextBox.Name = "AblageTextBox"
        Me.AblageTextBox.ReadOnly = True
        Me.AblageTextBox.Size = New System.Drawing.Size(113, 20)
        Me.AblageTextBox.TabIndex = 31
        '
        'TypLabel
        '
        TypLabel.AutoSize = True
        TypLabel.Location = New System.Drawing.Point(250, 62)
        TypLabel.Name = "TypLabel"
        TypLabel.Size = New System.Drawing.Size(28, 13)
        TypLabel.TabIndex = 32
        TypLabel.Text = "Typ:"
        '
        'TypTextBox
        '
        Me.TypTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TypTextBox.Location = New System.Drawing.Point(287, 59)
        Me.TypTextBox.Name = "TypTextBox"
        Me.TypTextBox.ReadOnly = True
        Me.TypTextBox.Size = New System.Drawing.Size(113, 20)
        Me.TypTextBox.TabIndex = 33
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(57, 88)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 34
        StatusLabel.Text = "Status:"
        '
        'StatusTextBox
        '
        Me.StatusTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusTextBox.Location = New System.Drawing.Point(110, 88)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.ReadOnly = True
        Me.StatusTextBox.Size = New System.Drawing.Size(113, 20)
        Me.StatusTextBox.TabIndex = 35
        '
        'DokNameLabel
        '
        DokNameLabel.AutoSize = True
        DokNameLabel.Location = New System.Drawing.Point(212, 177)
        DokNameLabel.Name = "DokNameLabel"
        DokNameLabel.Size = New System.Drawing.Size(61, 13)
        DokNameLabel.TabIndex = 36
        DokNameLabel.Text = "Dok Name:"
        '
        'DokNameTextBox
        '
        Me.DokNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DokNameTextBox.Location = New System.Drawing.Point(288, 174)
        Me.DokNameTextBox.Name = "DokNameTextBox"
        Me.DokNameTextBox.ReadOnly = True
        Me.DokNameTextBox.Size = New System.Drawing.Size(113, 20)
        Me.DokNameTextBox.TabIndex = 37
        '
        'BearbVermerkLabel
        '
        BearbVermerkLabel.AutoSize = True
        BearbVermerkLabel.Location = New System.Drawing.Point(9, 255)
        BearbVermerkLabel.Name = "BearbVermerkLabel"
        BearbVermerkLabel.Size = New System.Drawing.Size(80, 13)
        BearbVermerkLabel.TabIndex = 42
        BearbVermerkLabel.Text = "Bearb Vermerk:"
        '
        'BearbVermerkTextBox
        '
        Me.BearbVermerkTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BearbVermerkTextBox.Location = New System.Drawing.Point(109, 255)
        Me.BearbVermerkTextBox.Name = "BearbVermerkTextBox"
        Me.BearbVermerkTextBox.ReadOnly = True
        Me.BearbVermerkTextBox.Size = New System.Drawing.Size(291, 20)
        Me.BearbVermerkTextBox.TabIndex = 43
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BeendetTextBox)
        Me.Panel2.Controls.Add(Me.BegonnenTextBox)
        Me.Panel2.Controls.Add(Me.BeschreibungTextBox1)
        Me.Panel2.Controls.Add(Me.IdTextBox1)
        Me.Panel2.Controls.Add(Me.ArchivCheckBox1)
        Me.Panel2.Controls.Add(ArchivLabel1)
        Me.Panel2.Controls.Add(VorgangLabel)
        Me.Panel2.Controls.Add(BeendetLabel)
        Me.Panel2.Controls.Add(Me.VorgangTextBox)
        Me.Panel2.Controls.Add(BeschreibungLabel1)
        Me.Panel2.Controls.Add(HinweiseLabel)
        Me.Panel2.Controls.Add(BegonnenLabel)
        Me.Panel2.Controls.Add(Me.HinweiseTextBox)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(178, 488)
        Me.Panel2.Name = "Panel2"
        Me.TableLayoutPanel1.SetRowSpan(Me.Panel2, 3)
        Me.Panel2.Size = New System.Drawing.Size(169, 261)
        Me.Panel2.TabIndex = 3
        '
        'BeendetTextBox
        '
        Me.BeendetTextBox.Location = New System.Drawing.Point(3, 225)
        Me.BeendetTextBox.Name = "BeendetTextBox"
        Me.BeendetTextBox.Size = New System.Drawing.Size(154, 20)
        Me.BeendetTextBox.TabIndex = 19
        '
        'BegonnenTextBox
        '
        Me.BegonnenTextBox.Location = New System.Drawing.Point(3, 186)
        Me.BegonnenTextBox.Name = "BegonnenTextBox"
        Me.BegonnenTextBox.Size = New System.Drawing.Size(154, 20)
        Me.BegonnenTextBox.TabIndex = 18
        '
        'BeschreibungTextBox1
        '
        Me.BeschreibungTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeschreibungTextBox1.Location = New System.Drawing.Point(3, 65)
        Me.BeschreibungTextBox1.Multiline = True
        Me.BeschreibungTextBox1.Name = "BeschreibungTextBox1"
        Me.BeschreibungTextBox1.Size = New System.Drawing.Size(156, 52)
        Me.BeschreibungTextBox1.TabIndex = 7
        '
        'IdTextBox1
        '
        Me.IdTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTextBox1.Location = New System.Drawing.Point(3, 20)
        Me.IdTextBox1.Name = "IdTextBox1"
        Me.IdTextBox1.Size = New System.Drawing.Size(35, 20)
        Me.IdTextBox1.TabIndex = 1
        '
        'ArchivCheckBox1
        '
        Me.ArchivCheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArchivCheckBox1.Location = New System.Drawing.Point(64, 249)
        Me.ArchivCheckBox1.Name = "ArchivCheckBox1"
        Me.ArchivCheckBox1.Size = New System.Drawing.Size(14, 24)
        Me.ArchivCheckBox1.TabIndex = 17
        Me.ArchivCheckBox1.UseVisualStyleBackColor = True
        '
        'ArchivLabel1
        '
        ArchivLabel1.AutoSize = True
        ArchivLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ArchivLabel1.Location = New System.Drawing.Point(3, 254)
        ArchivLabel1.Name = "ArchivLabel1"
        ArchivLabel1.Size = New System.Drawing.Size(47, 13)
        ArchivLabel1.TabIndex = 16
        ArchivLabel1.Text = "Archiv:"
        '
        'VorgangLabel
        '
        VorgangLabel.AutoSize = True
        VorgangLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VorgangLabel.Location = New System.Drawing.Point(3, 6)
        VorgangLabel.Name = "VorgangLabel"
        VorgangLabel.Size = New System.Drawing.Size(58, 13)
        VorgangLabel.TabIndex = 4
        VorgangLabel.Text = "Vorgang:"
        '
        'BeendetLabel
        '
        BeendetLabel.AutoSize = True
        BeendetLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BeendetLabel.Location = New System.Drawing.Point(3, 209)
        BeendetLabel.Name = "BeendetLabel"
        BeendetLabel.Size = New System.Drawing.Size(58, 13)
        BeendetLabel.TabIndex = 14
        BeendetLabel.Text = "Beendet:"
        '
        'VorgangTextBox
        '
        Me.VorgangTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VorgangTextBox.Location = New System.Drawing.Point(44, 20)
        Me.VorgangTextBox.Name = "VorgangTextBox"
        Me.VorgangTextBox.Size = New System.Drawing.Size(115, 20)
        Me.VorgangTextBox.TabIndex = 5
        '
        'BeschreibungLabel1
        '
        BeschreibungLabel1.AutoSize = True
        BeschreibungLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BeschreibungLabel1.Location = New System.Drawing.Point(3, 49)
        BeschreibungLabel1.Name = "BeschreibungLabel1"
        BeschreibungLabel1.Size = New System.Drawing.Size(88, 13)
        BeschreibungLabel1.TabIndex = 6
        BeschreibungLabel1.Text = "Beschreibung:"
        '
        'HinweiseLabel
        '
        HinweiseLabel.AutoSize = True
        HinweiseLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HinweiseLabel.Location = New System.Drawing.Point(3, 123)
        HinweiseLabel.Name = "HinweiseLabel"
        HinweiseLabel.Size = New System.Drawing.Size(62, 13)
        HinweiseLabel.TabIndex = 8
        HinweiseLabel.Text = "Hinweise:"
        '
        'BegonnenLabel
        '
        BegonnenLabel.AutoSize = True
        BegonnenLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BegonnenLabel.Location = New System.Drawing.Point(3, 170)
        BegonnenLabel.Name = "BegonnenLabel"
        BegonnenLabel.Size = New System.Drawing.Size(68, 13)
        BegonnenLabel.TabIndex = 10
        BegonnenLabel.Text = "Begonnen:"
        '
        'HinweiseTextBox
        '
        Me.HinweiseTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HinweiseTextBox.Location = New System.Drawing.Point(3, 140)
        Me.HinweiseTextBox.Name = "HinweiseTextBox"
        Me.HinweiseTextBox.Size = New System.Drawing.Size(154, 20)
        Me.HinweiseTextBox.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ArchiviertTextBox)
        Me.Panel1.Controls.Add(Me.AngelegtTextBox)
        Me.Panel1.Controls.Add(MandantLabel1)
        Me.Panel1.Controls.Add(Me.MandantTextBox1)
        Me.Panel1.Controls.Add(Me.BeschreibungTextBox)
        Me.Panel1.Controls.Add(Me.IdTextBox)
        Me.Panel1.Controls.Add(Me.ArchivCheckBox)
        Me.Panel1.Controls.Add(ArchivLabel)
        Me.Panel1.Controls.Add(AkteLabel)
        Me.Panel1.Controls.Add(ArchiviertLabel)
        Me.Panel1.Controls.Add(Me.AkteTextBox)
        Me.Panel1.Controls.Add(BeschreibungLabel)
        Me.Panel1.Controls.Add(AngelegtLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 488)
        Me.Panel1.Name = "Panel1"
        Me.TableLayoutPanel1.SetRowSpan(Me.Panel1, 3)
        Me.Panel1.Size = New System.Drawing.Size(169, 261)
        Me.Panel1.TabIndex = 0
        '
        'ArchiviertTextBox
        '
        Me.ArchiviertTextBox.Location = New System.Drawing.Point(4, 225)
        Me.ArchiviertTextBox.Name = "ArchiviertTextBox"
        Me.ArchiviertTextBox.Size = New System.Drawing.Size(151, 20)
        Me.ArchiviertTextBox.TabIndex = 17
        '
        'AngelegtTextBox
        '
        Me.AngelegtTextBox.Location = New System.Drawing.Point(4, 186)
        Me.AngelegtTextBox.Name = "AngelegtTextBox"
        Me.AngelegtTextBox.Size = New System.Drawing.Size(162, 20)
        Me.AngelegtTextBox.TabIndex = 16
        '
        'MandantLabel1
        '
        MandantLabel1.AutoSize = True
        MandantLabel1.Location = New System.Drawing.Point(4, 6)
        MandantLabel1.Name = "MandantLabel1"
        MandantLabel1.Size = New System.Drawing.Size(46, 13)
        MandantLabel1.TabIndex = 14
        MandantLabel1.Text = "Bereich:"
        '
        'MandantTextBox1
        '
        Me.MandantTextBox1.Location = New System.Drawing.Point(4, 20)
        Me.MandantTextBox1.Name = "MandantTextBox1"
        Me.MandantTextBox1.Size = New System.Drawing.Size(162, 20)
        Me.MandantTextBox1.TabIndex = 15
        '
        'BeschreibungTextBox
        '
        Me.BeschreibungTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeschreibungTextBox.Location = New System.Drawing.Point(4, 108)
        Me.BeschreibungTextBox.Multiline = True
        Me.BeschreibungTextBox.Name = "BeschreibungTextBox"
        Me.BeschreibungTextBox.Size = New System.Drawing.Size(162, 52)
        Me.BeschreibungTextBox.TabIndex = 7
        '
        'IdTextBox
        '
        Me.IdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTextBox.Location = New System.Drawing.Point(4, 65)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(38, 20)
        Me.IdTextBox.TabIndex = 1
        '
        'ArchivCheckBox
        '
        Me.ArchivCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArchivCheckBox.Location = New System.Drawing.Point(64, 243)
        Me.ArchivCheckBox.Name = "ArchivCheckBox"
        Me.ArchivCheckBox.Size = New System.Drawing.Size(51, 24)
        Me.ArchivCheckBox.TabIndex = 13
        Me.ArchivCheckBox.UseVisualStyleBackColor = True
        '
        'ArchivLabel
        '
        ArchivLabel.AutoSize = True
        ArchivLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ArchivLabel.Location = New System.Drawing.Point(4, 248)
        ArchivLabel.Name = "ArchivLabel"
        ArchivLabel.Size = New System.Drawing.Size(47, 13)
        ArchivLabel.TabIndex = 12
        ArchivLabel.Text = "Archiv:"
        '
        'AkteLabel
        '
        AkteLabel.AutoSize = True
        AkteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AkteLabel.Location = New System.Drawing.Point(4, 49)
        AkteLabel.Name = "AkteLabel"
        AkteLabel.Size = New System.Drawing.Size(37, 13)
        AkteLabel.TabIndex = 4
        AkteLabel.Text = "Akte:"
        '
        'ArchiviertLabel
        '
        ArchiviertLabel.AutoSize = True
        ArchiviertLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ArchiviertLabel.Location = New System.Drawing.Point(4, 209)
        ArchiviertLabel.Name = "ArchiviertLabel"
        ArchiviertLabel.Size = New System.Drawing.Size(65, 13)
        ArchiviertLabel.TabIndex = 10
        ArchiviertLabel.Text = "Archiviert:"
        '
        'AkteTextBox
        '
        Me.AkteTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AkteTextBox.Location = New System.Drawing.Point(51, 65)
        Me.AkteTextBox.Name = "AkteTextBox"
        Me.AkteTextBox.Size = New System.Drawing.Size(115, 20)
        Me.AkteTextBox.TabIndex = 5
        '
        'BeschreibungLabel
        '
        BeschreibungLabel.AutoSize = True
        BeschreibungLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BeschreibungLabel.Location = New System.Drawing.Point(4, 92)
        BeschreibungLabel.Name = "BeschreibungLabel"
        BeschreibungLabel.Size = New System.Drawing.Size(88, 13)
        BeschreibungLabel.TabIndex = 6
        BeschreibungLabel.Text = "Beschreibung:"
        '
        'AngelegtLabel
        '
        AngelegtLabel.AutoSize = True
        AngelegtLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AngelegtLabel.Location = New System.Drawing.Point(4, 170)
        AngelegtLabel.Name = "AngelegtLabel"
        AngelegtLabel.Size = New System.Drawing.Size(61, 13)
        AngelegtLabel.TabIndex = 8
        AngelegtLabel.Text = "Angelegt:"
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lbAz)
        Me.Panel3.Controls.Add(Me.lbVorgang)
        Me.Panel3.Controls.Add(Me.lbAkte)
        Me.Panel3.Controls.Add(Me.lbMandant)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(731, 78)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(444, 72)
        Me.Panel3.TabIndex = 4
        '
        'lbAz
        '
        Me.lbAz.AutoSize = True
        Me.lbAz.Location = New System.Drawing.Point(9, 50)
        Me.lbAz.Name = "lbAz"
        Me.lbAz.Size = New System.Drawing.Size(72, 13)
        Me.lbAz.TabIndex = 53
        Me.lbAz.Text = "Aktenzeichen"
        '
        'lbVorgang
        '
        Me.lbVorgang.AutoSize = True
        Me.lbVorgang.Location = New System.Drawing.Point(4, 28)
        Me.lbVorgang.Name = "lbVorgang"
        Me.lbVorgang.Size = New System.Drawing.Size(47, 13)
        Me.lbVorgang.TabIndex = 52
        Me.lbVorgang.Text = "Vorgang"
        '
        'lbAkte
        '
        Me.lbAkte.AutoSize = True
        Me.lbAkte.Location = New System.Drawing.Point(4, 15)
        Me.lbAkte.Name = "lbAkte"
        Me.lbAkte.Size = New System.Drawing.Size(29, 13)
        Me.lbAkte.TabIndex = 51
        Me.lbAkte.Text = "Akte"
        '
        'lbMandant
        '
        Me.lbMandant.AutoSize = True
        Me.lbMandant.Location = New System.Drawing.Point(4, 2)
        Me.lbMandant.Name = "lbMandant"
        Me.lbMandant.Size = New System.Drawing.Size(43, 13)
        Me.lbMandant.TabIndex = 50
        Me.lbMandant.Text = "Bereich"
        '
        'Panel6
        '
        Me.Panel6.AutoScroll = True
        Me.Panel6.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.ProgressBar1)
        Me.Panel6.Controls.Add(Me.lbAnzahl)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(3, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(169, 69)
        Me.Panel6.TabIndex = 7
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(13, 41)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(142, 20)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 7
        '
        'lbAnzahl
        '
        Me.lbAnzahl.AutoSize = True
        Me.lbAnzahl.Location = New System.Drawing.Point(6, 23)
        Me.lbAnzahl.Name = "lbAnzahl"
        Me.lbAnzahl.Size = New System.Drawing.Size(39, 13)
        Me.lbAnzahl.TabIndex = 6
        Me.lbAnzahl.Text = "Anzahl"
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.Color.SteelBlue
        Me.TableLayoutPanel1.SetColumnSpan(Me.Panel19, 2)
        Me.Panel19.Controls.Add(Me.Label4)
        Me.Panel19.Controls.Add(Me.NotizDataGridView)
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel19.Location = New System.Drawing.Point(353, 488)
        Me.Panel19.Name = "Panel19"
        Me.TableLayoutPanel1.SetRowSpan(Me.Panel19, 3)
        Me.Panel19.Size = New System.Drawing.Size(372, 261)
        Me.Panel19.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(14, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Notizen"
        '
        'NotizDataGridView
        '
        Me.NotizDataGridView.AllowUserToAddRows = False
        Me.NotizDataGridView.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.NotizDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NotizDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.erstellt})
        Me.NotizDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.NotizDataGridView.Location = New System.Drawing.Point(0, 17)
        Me.NotizDataGridView.MultiSelect = False
        Me.NotizDataGridView.Name = "NotizDataGridView"
        Me.NotizDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotizDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle13
        Me.NotizDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.NotizDataGridView.Size = New System.Drawing.Size(372, 244)
        Me.NotizDataGridView.TabIndex = 26
        '
        'erstellt
        '
        Me.erstellt.DataPropertyName = "erstellt"
        DataGridViewCellStyle12.Format = "d"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.erstellt.DefaultCellStyle = DataGridViewCellStyle12
        Me.erstellt.HeaderText = "Vom"
        Me.erstellt.Name = "erstellt"
        '
        'PanelSuchBack
        '
        Me.PanelSuchBack.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelSuchBack.Controls.Add(Me.PanelSuchErgeb)
        Me.PanelSuchBack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelSuchBack.Location = New System.Drawing.Point(1181, 3)
        Me.PanelSuchBack.Name = "PanelSuchBack"
        Me.PanelSuchBack.Size = New System.Drawing.Size(261, 69)
        Me.PanelSuchBack.TabIndex = 38
        '
        'PanelSuchErgeb
        '
        Me.PanelSuchErgeb.Controls.Add(Me.lblSuchErgebnis)
        Me.PanelSuchErgeb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelSuchErgeb.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuchErgeb.Name = "PanelSuchErgeb"
        Me.PanelSuchErgeb.Size = New System.Drawing.Size(261, 69)
        Me.PanelSuchErgeb.TabIndex = 35
        '
        'lblSuchErgebnis
        '
        Me.lblSuchErgebnis.AutoSize = True
        Me.lblSuchErgebnis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuchErgebnis.Location = New System.Drawing.Point(10, 24)
        Me.lblSuchErgebnis.Name = "lblSuchErgebnis"
        Me.lblSuchErgebnis.Size = New System.Drawing.Size(84, 13)
        Me.lblSuchErgebnis.TabIndex = 34
        Me.lblSuchErgebnis.Text = "Suchergebnis"
        '
        'TreeView1
        '
        Me.TreeView1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel1.SetColumnSpan(Me.TreeView1, 2)
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Location = New System.Drawing.Point(3, 156)
        Me.TreeView1.Name = "TreeView1"
        Me.TableLayoutPanel1.SetRowSpan(Me.TreeView1, 2)
        Me.TreeView1.ShowRootLines = False
        Me.TreeView1.Size = New System.Drawing.Size(344, 326)
        Me.TreeView1.TabIndex = 2
        '
        'Panel4
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.Panel4, 2)
        Me.Panel4.Controls.Add(Me.GroupBoxAnzeige)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 78)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(344, 72)
        Me.Panel4.TabIndex = 39
        '
        'GroupBoxAnzeige
        '
        Me.GroupBoxAnzeige.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBoxAnzeige.Controls.Add(Me.RBOrdnerArchiv)
        Me.GroupBoxAnzeige.Controls.Add(Me.RBAktenArchiv)
        Me.GroupBoxAnzeige.Controls.Add(Me.RBAlles)
        Me.GroupBoxAnzeige.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxAnzeige.Location = New System.Drawing.Point(0, 0)
        Me.GroupBoxAnzeige.Name = "GroupBoxAnzeige"
        Me.GroupBoxAnzeige.Size = New System.Drawing.Size(344, 72)
        Me.GroupBoxAnzeige.TabIndex = 0
        Me.GroupBoxAnzeige.TabStop = False
        Me.GroupBoxAnzeige.Text = "Auswahl Anzeige"
        '
        'RBOrdnerArchiv
        '
        Me.RBOrdnerArchiv.AutoSize = True
        Me.RBOrdnerArchiv.Location = New System.Drawing.Point(220, 33)
        Me.RBOrdnerArchiv.Name = "RBOrdnerArchiv"
        Me.RBOrdnerArchiv.Size = New System.Drawing.Size(90, 17)
        Me.RBOrdnerArchiv.TabIndex = 2
        Me.RBOrdnerArchiv.TabStop = True
        Me.RBOrdnerArchiv.Text = "Archiv Ordner"
        Me.RBOrdnerArchiv.UseVisualStyleBackColor = True
        '
        'RBAktenArchiv
        '
        Me.RBAktenArchiv.AutoSize = True
        Me.RBAktenArchiv.Location = New System.Drawing.Point(98, 33)
        Me.RBAktenArchiv.Name = "RBAktenArchiv"
        Me.RBAktenArchiv.Size = New System.Drawing.Size(86, 17)
        Me.RBAktenArchiv.TabIndex = 1
        Me.RBAktenArchiv.TabStop = True
        Me.RBAktenArchiv.Text = "Archiv Akten"
        Me.RBAktenArchiv.UseVisualStyleBackColor = True
        '
        'RBAlles
        '
        Me.RBAlles.AutoSize = True
        Me.RBAlles.Location = New System.Drawing.Point(3, 33)
        Me.RBAlles.Name = "RBAlles"
        Me.RBAlles.Size = New System.Drawing.Size(57, 17)
        Me.RBAlles.TabIndex = 0
        Me.RBAlles.TabStop = True
        Me.RBAlles.Text = "Aktuell"
        Me.RBAlles.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.AutoScroll = True
        Me.Panel8.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel8.Controls.Add(Me.DataGridView1)
        Me.Panel8.Controls.Add(Me.LblWv)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(1181, 488)
        Me.Panel8.Name = "Panel8"
        Me.TableLayoutPanel1.SetRowSpan(Me.Panel8, 3)
        Me.Panel8.Size = New System.Drawing.Size(261, 261)
        Me.Panel8.TabIndex = 37
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Wiedervorlage})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 29)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(244, 233)
        Me.DataGridView1.TabIndex = 1
        '
        'Wiedervorlage
        '
        Me.Wiedervorlage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Wiedervorlage.DataPropertyName = "wiedervorlage"
        Me.Wiedervorlage.HeaderText = "Wiedervorlage"
        Me.Wiedervorlage.Name = "Wiedervorlage"
        '
        'LblWv
        '
        Me.LblWv.AutoSize = True
        Me.LblWv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWv.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblWv.Location = New System.Drawing.Point(6, 16)
        Me.LblWv.Name = "LblWv"
        Me.LblWv.Size = New System.Drawing.Size(176, 13)
        Me.LblWv.TabIndex = 0
        Me.LblWv.Text = "Wiedervorlage zum Dokument"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Moccasin
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.LbEingangsKorb)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(1181, 78)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(261, 72)
        Me.Panel7.TabIndex = 35
        '
        'LbEingangsKorb
        '
        Me.LbEingangsKorb.AutoSize = True
        Me.LbEingangsKorb.Location = New System.Drawing.Point(5, 12)
        Me.LbEingangsKorb.Name = "LbEingangsKorb"
        Me.LbEingangsKorb.Size = New System.Drawing.Size(75, 13)
        Me.LbEingangsKorb.TabIndex = 0
        Me.LbEingangsKorb.Text = "Eingangskorb:"
        '
        'LvScanInput
        '
        Me.LvScanInput.BackColor = System.Drawing.Color.Moccasin
        Me.LvScanInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LvScanInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LvScanInput.Location = New System.Drawing.Point(1181, 156)
        Me.LvScanInput.Name = "LvScanInput"
        Me.TableLayoutPanel1.SetRowSpan(Me.LvScanInput, 2)
        Me.LvScanInput.Size = New System.Drawing.Size(261, 326)
        Me.LvScanInput.TabIndex = 36
        Me.LvScanInput.UseCompatibleStateImageBehavior = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1459, 830)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel21.ResumeLayout(False)
        Me.Panel21.PerformLayout()
        CType(Me.DocNotizDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.PanelSuche.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DokumenteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.AnlagenSQLDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlDokButton.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel19.ResumeLayout(False)
        Me.Panel19.PerformLayout()
        CType(Me.NotizDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSuchBack.ResumeLayout(False)
        Me.PanelSuchErgeb.ResumeLayout(False)
        Me.PanelSuchErgeb.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.GroupBoxAnzeige.ResumeLayout(False)
        Me.GroupBoxAnzeige.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel21 As Panel
    Friend WithEvents DocNotizDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents lbNotizDok As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents PanelSuche As Panel
    Friend WithEvents btClear As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btSearcj As Button
    Friend WithEvents ComboBoxSuche As ComboBox
    Friend WithEvents TextSuche As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CbAblageSuche As ComboBox
    Friend WithEvents CbTypSuche As ComboBox
    Friend WithEvents CbStatusSuche As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DokumenteDataGridView As DataGridView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents AnlagenSQLDataGridView As DataGridView
    Friend WithEvents LbIstAnlage As Label
    Friend WithEvents LbAnlagen As Label
    Friend WithEvents PnlDokButton As Panel
    Friend WithEvents btDocNotiz As Button
    Friend WithEvents btShowDoc As Button
    Friend WithEvents BtWiedervorlage As Button
    Friend WithEvents BtPrint As Button
    Friend WithEvents DokDatumTextBox As TextBox
    Friend WithEvents DokumentTextBox As TextBox
    Friend WithEvents BetreffTextBox As TextBox
    Friend WithEvents BetragTextBox As TextBox
    Friend WithEvents AbsenderTextBox As TextBox
    Friend WithEvents EmpfaengerTextBox As TextBox
    Friend WithEvents KommentarTextBox As TextBox
    Friend WithEvents AblageTextBox As TextBox
    Friend WithEvents TypTextBox As TextBox
    Friend WithEvents StatusTextBox As TextBox
    Friend WithEvents DokNameTextBox As TextBox
    Friend WithEvents BearbVermerkTextBox As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BeendetTextBox As TextBox
    Friend WithEvents BegonnenTextBox As TextBox
    Friend WithEvents BeschreibungTextBox1 As TextBox
    Friend WithEvents IdTextBox1 As TextBox
    Friend WithEvents ArchivCheckBox1 As CheckBox
    Friend WithEvents VorgangTextBox As TextBox
    Friend WithEvents HinweiseTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ArchiviertTextBox As TextBox
    Friend WithEvents AngelegtTextBox As TextBox
    Friend WithEvents MandantTextBox1 As TextBox
    Friend WithEvents BeschreibungTextBox As TextBox
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents ArchivCheckBox As CheckBox
    Friend WithEvents AkteTextBox As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbAz As Label
    Friend WithEvents lbVorgang As Label
    Friend WithEvents lbAkte As Label
    Friend WithEvents lbMandant As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lbAnzahl As Label
    Friend WithEvents Panel19 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents NotizDataGridView As DataGridView
    Friend WithEvents erstellt As DataGridViewTextBoxColumn
    Friend WithEvents PanelSuchBack As Panel
    Friend WithEvents PanelSuchErgeb As Panel
    Friend WithEvents lblSuchErgebnis As Label
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents GroupBoxAnzeige As GroupBox
    Friend WithEvents RBOrdnerArchiv As RadioButton
    Friend WithEvents RBAktenArchiv As RadioButton
    Friend WithEvents RBAlles As RadioButton
    Friend WithEvents Panel8 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Wiedervorlage As DataGridViewTextBoxColumn
    Friend WithEvents LblWv As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents LbEingangsKorb As Label
    Friend WithEvents LvScanInput As ListView
    Friend WithEvents TabPage2 As TabPage
End Class
