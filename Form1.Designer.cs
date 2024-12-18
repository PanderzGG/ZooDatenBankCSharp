namespace DatenBankZoo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPageThemenbereiche = new TabPage();
            buttonThemenbereichNeu = new Button();
            buttonLoeschen = new Button();
            buttonThemenbereichSpeichern = new Button();
            listBoxThemenbereiche = new ListBox();
            tbTheme = new TextBox();
            label1 = new Label();
            tabPageGehege = new TabPage();
            buttonGehegeLoeschen = new Button();
            buttonGehegeNeu = new Button();
            dataGridGehege = new DataGridView();
            colGehegeName = new DataGridViewTextBoxColumn();
            colGehegeThemenbereich = new DataGridViewTextBoxColumn();
            buttonGehegeSpeichern = new Button();
            labelGehegeThemenBereich = new Label();
            comboBoxThemenBereiche = new ComboBox();
            tbGehegeName = new TextBox();
            lbGehegeName = new Label();
            tabPageTierarten = new TabPage();
            buttonLöschenTierart = new Button();
            buttonNeuTierart = new Button();
            buttonSpeichernTierart = new Button();
            listBoxTierart = new ListBox();
            tbTierart = new TextBox();
            lbTierart = new Label();
            tabPageTiere = new TabPage();
            comboBoxTierThemenbereich = new ComboBox();
            lbTierThemenbereich = new Label();
            buttonTierLoeschen = new Button();
            buttonTierSpeichern = new Button();
            buttonTierNeu = new Button();
            comboBoxTierTierart = new ComboBox();
            comboBoxTierGehege = new ComboBox();
            tbTierName = new TextBox();
            lbTierTierart = new Label();
            lbTierGehege = new Label();
            lbTiername = new Label();
            lbTierIDWert = new Label();
            lbTierIDText = new Label();
            dataGridViewTiere = new DataGridView();
            colTiername = new DataGridViewTextBoxColumn();
            colTierTierart = new DataGridViewTextBoxColumn();
            colTierGehegeID = new DataGridViewTextBoxColumn();
            colTierThemenbereich = new DataGridViewTextBoxColumn();
            tabPageStatistik = new TabPage();
            dataGridViewStatistik = new DataGridView();
            radioButtonThemenbereichTierarten = new RadioButton();
            radioButtonThemenbereicheOhneGehege = new RadioButton();
            radioButtonAnzahlTierartenTiere = new RadioButton();
            radioButtonAnzahlTierarten = new RadioButton();
            radioButtonLeereGehege = new RadioButton();
            radioButtonWelcheTiereGehege = new RadioButton();
            radioButtonAnzahlTiereZoo = new RadioButton();
            tabPagePersonalEinteilung = new TabPage();
            listBoxNormalPfleger = new ListBox();
            listBoxHauptpfleger = new ListBox();
            lbNormalPfleger = new Label();
            lbHauptpfleger = new Label();
            textBoxArbeitskraft = new TextBox();
            lbPersonalName = new Label();
            lbPersonalIDWert = new Label();
            lbPersonalID = new Label();
            dataGridViewPersonalEinteilung = new DataGridView();
            Personalnummer = new DataGridViewTextBoxColumn();
            PersonalName = new DataGridViewTextBoxColumn();
            GehegeHauptpfleger = new DataGridViewTextBoxColumn();
            GehegeNormalPfleger = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPageThemenbereiche.SuspendLayout();
            tabPageGehege.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridGehege).BeginInit();
            tabPageTierarten.SuspendLayout();
            tabPageTiere.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTiere).BeginInit();
            tabPageStatistik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStatistik).BeginInit();
            tabPagePersonalEinteilung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersonalEinteilung).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPageThemenbereiche);
            tabControl1.Controls.Add(tabPageGehege);
            tabControl1.Controls.Add(tabPageTierarten);
            tabControl1.Controls.Add(tabPageTiere);
            tabControl1.Controls.Add(tabPageStatistik);
            tabControl1.Controls.Add(tabPagePersonalEinteilung);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(627, 466);
            tabControl1.TabIndex = 0;
            // 
            // tabPageThemenbereiche
            // 
            tabPageThemenbereiche.Controls.Add(buttonThemenbereichNeu);
            tabPageThemenbereiche.Controls.Add(buttonLoeschen);
            tabPageThemenbereiche.Controls.Add(buttonThemenbereichSpeichern);
            tabPageThemenbereiche.Controls.Add(listBoxThemenbereiche);
            tabPageThemenbereiche.Controls.Add(tbTheme);
            tabPageThemenbereiche.Controls.Add(label1);
            tabPageThemenbereiche.Location = new Point(4, 24);
            tabPageThemenbereiche.Name = "tabPageThemenbereiche";
            tabPageThemenbereiche.Padding = new Padding(3);
            tabPageThemenbereiche.Size = new Size(619, 438);
            tabPageThemenbereiche.TabIndex = 0;
            tabPageThemenbereiche.Text = "Themenbereiche";
            tabPageThemenbereiche.UseVisualStyleBackColor = true;
            // 
            // buttonThemenbereichNeu
            // 
            buttonThemenbereichNeu.Anchor = AnchorStyles.None;
            buttonThemenbereichNeu.Location = new Point(153, 223);
            buttonThemenbereichNeu.Name = "buttonThemenbereichNeu";
            buttonThemenbereichNeu.Size = new Size(75, 23);
            buttonThemenbereichNeu.TabIndex = 5;
            buttonThemenbereichNeu.Text = "Neu";
            buttonThemenbereichNeu.UseVisualStyleBackColor = true;
            buttonThemenbereichNeu.Click += buttonThemenbereichNeu_Click;
            // 
            // buttonLoeschen
            // 
            buttonLoeschen.Anchor = AnchorStyles.None;
            buttonLoeschen.Location = new Point(318, 224);
            buttonLoeschen.Name = "buttonLoeschen";
            buttonLoeschen.Size = new Size(75, 22);
            buttonLoeschen.TabIndex = 4;
            buttonLoeschen.Text = "Löschen";
            buttonLoeschen.UseVisualStyleBackColor = true;
            buttonLoeschen.Click += buttonLoeschen_Click;
            // 
            // buttonThemenbereichSpeichern
            // 
            buttonThemenbereichSpeichern.Anchor = AnchorStyles.None;
            buttonThemenbereichSpeichern.Location = new Point(237, 223);
            buttonThemenbereichSpeichern.Name = "buttonThemenbereichSpeichern";
            buttonThemenbereichSpeichern.Size = new Size(75, 23);
            buttonThemenbereichSpeichern.TabIndex = 3;
            buttonThemenbereichSpeichern.Text = "Speichern";
            buttonThemenbereichSpeichern.UseVisualStyleBackColor = true;
            buttonThemenbereichSpeichern.Click += buttonThemenbereichSpeichern_Click;
            // 
            // listBoxThemenbereiche
            // 
            listBoxThemenbereiche.Anchor = AnchorStyles.None;
            listBoxThemenbereiche.FormattingEnabled = true;
            listBoxThemenbereiche.ItemHeight = 15;
            listBoxThemenbereiche.Location = new Point(447, 17);
            listBoxThemenbereiche.Name = "listBoxThemenbereiche";
            listBoxThemenbereiche.Size = new Size(166, 229);
            listBoxThemenbereiche.TabIndex = 2;
            listBoxThemenbereiche.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // tbTheme
            // 
            tbTheme.Anchor = AnchorStyles.None;
            tbTheme.Location = new Point(153, 107);
            tbTheme.Name = "tbTheme";
            tbTheme.Size = new Size(240, 23);
            tbTheme.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(58, 110);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // tabPageGehege
            // 
            tabPageGehege.Controls.Add(buttonGehegeLoeschen);
            tabPageGehege.Controls.Add(buttonGehegeNeu);
            tabPageGehege.Controls.Add(dataGridGehege);
            tabPageGehege.Controls.Add(buttonGehegeSpeichern);
            tabPageGehege.Controls.Add(labelGehegeThemenBereich);
            tabPageGehege.Controls.Add(comboBoxThemenBereiche);
            tabPageGehege.Controls.Add(tbGehegeName);
            tabPageGehege.Controls.Add(lbGehegeName);
            tabPageGehege.Location = new Point(4, 24);
            tabPageGehege.Name = "tabPageGehege";
            tabPageGehege.Padding = new Padding(3);
            tabPageGehege.Size = new Size(619, 438);
            tabPageGehege.TabIndex = 1;
            tabPageGehege.Text = "Gehege";
            tabPageGehege.UseVisualStyleBackColor = true;
            // 
            // buttonGehegeLoeschen
            // 
            buttonGehegeLoeschen.Location = new Point(336, 197);
            buttonGehegeLoeschen.Name = "buttonGehegeLoeschen";
            buttonGehegeLoeschen.Size = new Size(75, 23);
            buttonGehegeLoeschen.TabIndex = 8;
            buttonGehegeLoeschen.Text = "Löschen";
            buttonGehegeLoeschen.UseVisualStyleBackColor = true;
            buttonGehegeLoeschen.Click += buttonGehegeLoeschen_Click;
            // 
            // buttonGehegeNeu
            // 
            buttonGehegeNeu.Location = new Point(118, 197);
            buttonGehegeNeu.Name = "buttonGehegeNeu";
            buttonGehegeNeu.Size = new Size(75, 23);
            buttonGehegeNeu.TabIndex = 7;
            buttonGehegeNeu.Text = "Neu";
            buttonGehegeNeu.UseVisualStyleBackColor = true;
            buttonGehegeNeu.Click += buttonGehegeNeu_Click;
            // 
            // dataGridGehege
            // 
            dataGridGehege.AllowUserToAddRows = false;
            dataGridGehege.AllowUserToDeleteRows = false;
            dataGridGehege.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridGehege.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridGehege.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridGehege.Columns.AddRange(new DataGridViewColumn[] { colGehegeName, colGehegeThemenbereich });
            dataGridGehege.Location = new Point(6, 253);
            dataGridGehege.MultiSelect = false;
            dataGridGehege.Name = "dataGridGehege";
            dataGridGehege.ReadOnly = true;
            dataGridGehege.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridGehege.Size = new Size(607, 179);
            dataGridGehege.TabIndex = 6;
            dataGridGehege.SelectionChanged += dataGridGehege_SelectionChanged;
            // 
            // colGehegeName
            // 
            colGehegeName.HeaderText = "Gehege";
            colGehegeName.Name = "colGehegeName";
            colGehegeName.ReadOnly = true;
            // 
            // colGehegeThemenbereich
            // 
            colGehegeThemenbereich.HeaderText = "Themenbereich";
            colGehegeThemenbereich.Name = "colGehegeThemenbereich";
            colGehegeThemenbereich.ReadOnly = true;
            // 
            // buttonGehegeSpeichern
            // 
            buttonGehegeSpeichern.Location = new Point(228, 197);
            buttonGehegeSpeichern.Name = "buttonGehegeSpeichern";
            buttonGehegeSpeichern.Size = new Size(75, 23);
            buttonGehegeSpeichern.TabIndex = 4;
            buttonGehegeSpeichern.Text = "Speichern";
            buttonGehegeSpeichern.UseVisualStyleBackColor = true;
            buttonGehegeSpeichern.Click += buttonGehegeUnk_Click;
            // 
            // labelGehegeThemenBereich
            // 
            labelGehegeThemenBereich.AutoSize = true;
            labelGehegeThemenBereich.Location = new Point(118, 138);
            labelGehegeThemenBereich.Name = "labelGehegeThemenBereich";
            labelGehegeThemenBereich.Size = new Size(89, 15);
            labelGehegeThemenBereich.TabIndex = 3;
            labelGehegeThemenBereich.Text = "Themenbereich";
            // 
            // comboBoxThemenBereiche
            // 
            comboBoxThemenBereiche.FormattingEnabled = true;
            comboBoxThemenBereiche.Location = new Point(243, 135);
            comboBoxThemenBereiche.Name = "comboBoxThemenBereiche";
            comboBoxThemenBereiche.Size = new Size(169, 23);
            comboBoxThemenBereiche.TabIndex = 2;
            // 
            // tbGehegeName
            // 
            tbGehegeName.Location = new Point(243, 92);
            tbGehegeName.Name = "tbGehegeName";
            tbGehegeName.Size = new Size(100, 23);
            tbGehegeName.TabIndex = 1;
            // 
            // lbGehegeName
            // 
            lbGehegeName.AutoSize = true;
            lbGehegeName.Location = new Point(118, 95);
            lbGehegeName.Name = "lbGehegeName";
            lbGehegeName.Size = new Size(84, 15);
            lbGehegeName.TabIndex = 0;
            lbGehegeName.Text = "Gegehe-Name";
            // 
            // tabPageTierarten
            // 
            tabPageTierarten.Controls.Add(buttonLöschenTierart);
            tabPageTierarten.Controls.Add(buttonNeuTierart);
            tabPageTierarten.Controls.Add(buttonSpeichernTierart);
            tabPageTierarten.Controls.Add(listBoxTierart);
            tabPageTierarten.Controls.Add(tbTierart);
            tabPageTierarten.Controls.Add(lbTierart);
            tabPageTierarten.Location = new Point(4, 24);
            tabPageTierarten.Name = "tabPageTierarten";
            tabPageTierarten.Size = new Size(619, 438);
            tabPageTierarten.TabIndex = 2;
            tabPageTierarten.Text = "Tierarten";
            tabPageTierarten.UseVisualStyleBackColor = true;
            // 
            // buttonLöschenTierart
            // 
            buttonLöschenTierart.Anchor = AnchorStyles.None;
            buttonLöschenTierart.Location = new Point(305, 228);
            buttonLöschenTierart.Name = "buttonLöschenTierart";
            buttonLöschenTierart.Size = new Size(82, 23);
            buttonLöschenTierart.TabIndex = 5;
            buttonLöschenTierart.Text = "Löschen";
            buttonLöschenTierart.UseVisualStyleBackColor = true;
            buttonLöschenTierart.Click += buttonLöschenTierart_Click;
            // 
            // buttonNeuTierart
            // 
            buttonNeuTierart.Anchor = AnchorStyles.None;
            buttonNeuTierart.Location = new Point(129, 228);
            buttonNeuTierart.Name = "buttonNeuTierart";
            buttonNeuTierart.Size = new Size(82, 23);
            buttonNeuTierart.TabIndex = 4;
            buttonNeuTierart.Text = "Neu";
            buttonNeuTierart.UseVisualStyleBackColor = true;
            buttonNeuTierart.Click += buttonNeuTierart_Click;
            // 
            // buttonSpeichernTierart
            // 
            buttonSpeichernTierart.Anchor = AnchorStyles.None;
            buttonSpeichernTierart.Location = new Point(217, 228);
            buttonSpeichernTierart.Name = "buttonSpeichernTierart";
            buttonSpeichernTierart.Size = new Size(82, 23);
            buttonSpeichernTierart.TabIndex = 3;
            buttonSpeichernTierart.Text = "Speichern";
            buttonSpeichernTierart.UseVisualStyleBackColor = true;
            buttonSpeichernTierart.Click += buttonSpeichernTierart_Click;
            // 
            // listBoxTierart
            // 
            listBoxTierart.Anchor = AnchorStyles.None;
            listBoxTierart.FormattingEnabled = true;
            listBoxTierart.ItemHeight = 15;
            listBoxTierart.Location = new Point(403, 20);
            listBoxTierart.Name = "listBoxTierart";
            listBoxTierart.Size = new Size(190, 319);
            listBoxTierart.TabIndex = 2;
            listBoxTierart.SelectedIndexChanged += listBoxTierart_SelectedIndexChanged;
            // 
            // tbTierart
            // 
            tbTierart.Anchor = AnchorStyles.None;
            tbTierart.Location = new Point(129, 95);
            tbTierart.Name = "tbTierart";
            tbTierart.Size = new Size(258, 23);
            tbTierart.TabIndex = 1;
            // 
            // lbTierart
            // 
            lbTierart.Anchor = AnchorStyles.None;
            lbTierart.AutoSize = true;
            lbTierart.Location = new Point(55, 98);
            lbTierart.Name = "lbTierart";
            lbTierart.Size = new Size(40, 15);
            lbTierart.TabIndex = 0;
            lbTierart.Text = "Tierart";
            // 
            // tabPageTiere
            // 
            tabPageTiere.Controls.Add(comboBoxTierThemenbereich);
            tabPageTiere.Controls.Add(lbTierThemenbereich);
            tabPageTiere.Controls.Add(buttonTierLoeschen);
            tabPageTiere.Controls.Add(buttonTierSpeichern);
            tabPageTiere.Controls.Add(buttonTierNeu);
            tabPageTiere.Controls.Add(comboBoxTierTierart);
            tabPageTiere.Controls.Add(comboBoxTierGehege);
            tabPageTiere.Controls.Add(tbTierName);
            tabPageTiere.Controls.Add(lbTierTierart);
            tabPageTiere.Controls.Add(lbTierGehege);
            tabPageTiere.Controls.Add(lbTiername);
            tabPageTiere.Controls.Add(lbTierIDWert);
            tabPageTiere.Controls.Add(lbTierIDText);
            tabPageTiere.Controls.Add(dataGridViewTiere);
            tabPageTiere.Location = new Point(4, 24);
            tabPageTiere.Name = "tabPageTiere";
            tabPageTiere.Size = new Size(619, 438);
            tabPageTiere.TabIndex = 3;
            tabPageTiere.Text = "Tiere";
            tabPageTiere.UseVisualStyleBackColor = true;
            // 
            // comboBoxTierThemenbereich
            // 
            comboBoxTierThemenbereich.FormattingEnabled = true;
            comboBoxTierThemenbereich.Location = new Point(243, 206);
            comboBoxTierThemenbereich.Name = "comboBoxTierThemenbereich";
            comboBoxTierThemenbereich.Size = new Size(289, 23);
            comboBoxTierThemenbereich.TabIndex = 14;
            // 
            // lbTierThemenbereich
            // 
            lbTierThemenbereich.AutoSize = true;
            lbTierThemenbereich.Location = new Point(87, 209);
            lbTierThemenbereich.Name = "lbTierThemenbereich";
            lbTierThemenbereich.Size = new Size(92, 15);
            lbTierThemenbereich.TabIndex = 13;
            lbTierThemenbereich.Text = "Themenbereich:";
            // 
            // buttonTierLoeschen
            // 
            buttonTierLoeschen.Location = new Point(373, 245);
            buttonTierLoeschen.Name = "buttonTierLoeschen";
            buttonTierLoeschen.Size = new Size(75, 23);
            buttonTierLoeschen.TabIndex = 12;
            buttonTierLoeschen.Text = "Löschen";
            buttonTierLoeschen.UseVisualStyleBackColor = true;
            buttonTierLoeschen.Click += buttonTierLoeschen_Click;
            // 
            // buttonTierSpeichern
            // 
            buttonTierSpeichern.Location = new Point(272, 245);
            buttonTierSpeichern.Name = "buttonTierSpeichern";
            buttonTierSpeichern.Size = new Size(75, 23);
            buttonTierSpeichern.TabIndex = 11;
            buttonTierSpeichern.Text = "Speichern";
            buttonTierSpeichern.UseVisualStyleBackColor = true;
            buttonTierSpeichern.Click += buttonTierSpeichern_Click;
            // 
            // buttonTierNeu
            // 
            buttonTierNeu.Location = new Point(171, 245);
            buttonTierNeu.Name = "buttonTierNeu";
            buttonTierNeu.Size = new Size(75, 23);
            buttonTierNeu.TabIndex = 10;
            buttonTierNeu.Text = "Neu";
            buttonTierNeu.UseVisualStyleBackColor = true;
            buttonTierNeu.Click += buttonTierNeu_Click;
            // 
            // comboBoxTierTierart
            // 
            comboBoxTierTierart.FormattingEnabled = true;
            comboBoxTierTierart.Location = new Point(243, 157);
            comboBoxTierTierart.Name = "comboBoxTierTierart";
            comboBoxTierTierart.Size = new Size(289, 23);
            comboBoxTierTierart.TabIndex = 8;
            // 
            // comboBoxTierGehege
            // 
            comboBoxTierGehege.FormattingEnabled = true;
            comboBoxTierGehege.Location = new Point(243, 108);
            comboBoxTierGehege.Name = "comboBoxTierGehege";
            comboBoxTierGehege.Size = new Size(289, 23);
            comboBoxTierGehege.TabIndex = 7;
            // 
            // tbTierName
            // 
            tbTierName.Location = new Point(243, 59);
            tbTierName.Name = "tbTierName";
            tbTierName.Size = new Size(268, 23);
            tbTierName.TabIndex = 6;
            // 
            // lbTierTierart
            // 
            lbTierTierart.AutoSize = true;
            lbTierTierart.Location = new Point(87, 157);
            lbTierTierart.Name = "lbTierTierart";
            lbTierTierart.Size = new Size(43, 15);
            lbTierTierart.TabIndex = 5;
            lbTierTierart.Text = "Tierart:";
            // 
            // lbTierGehege
            // 
            lbTierGehege.AutoSize = true;
            lbTierGehege.Location = new Point(87, 108);
            lbTierGehege.Name = "lbTierGehege";
            lbTierGehege.Size = new Size(50, 15);
            lbTierGehege.TabIndex = 4;
            lbTierGehege.Text = "Gehege:";
            // 
            // lbTiername
            // 
            lbTiername.AutoSize = true;
            lbTiername.Location = new Point(87, 62);
            lbTiername.Name = "lbTiername";
            lbTiername.Size = new Size(42, 15);
            lbTiername.TabIndex = 3;
            lbTiername.Text = "Name:";
            // 
            // lbTierIDWert
            // 
            lbTierIDWert.AutoSize = true;
            lbTierIDWert.Location = new Point(243, 18);
            lbTierIDWert.Name = "lbTierIDWert";
            lbTierIDWert.Size = new Size(0, 15);
            lbTierIDWert.TabIndex = 2;
            // 
            // lbTierIDText
            // 
            lbTierIDText.AutoSize = true;
            lbTierIDText.Location = new Point(87, 18);
            lbTierIDText.Name = "lbTierIDText";
            lbTierIDText.Size = new Size(40, 15);
            lbTierIDText.TabIndex = 1;
            lbTierIDText.Text = "TierID:";
            // 
            // dataGridViewTiere
            // 
            dataGridViewTiere.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTiere.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTiere.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTiere.Columns.AddRange(new DataGridViewColumn[] { colTiername, colTierTierart, colTierGehegeID, colTierThemenbereich });
            dataGridViewTiere.Location = new Point(3, 274);
            dataGridViewTiere.MultiSelect = false;
            dataGridViewTiere.Name = "dataGridViewTiere";
            dataGridViewTiere.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTiere.Size = new Size(613, 161);
            dataGridViewTiere.TabIndex = 0;
            dataGridViewTiere.SelectionChanged += dataGridViewTiere_SelectionChanged;
            // 
            // colTiername
            // 
            colTiername.HeaderText = "Tiername";
            colTiername.Name = "colTiername";
            // 
            // colTierTierart
            // 
            colTierTierart.HeaderText = "Tierart";
            colTierTierart.Name = "colTierTierart";
            // 
            // colTierGehegeID
            // 
            colTierGehegeID.HeaderText = "Gehege";
            colTierGehegeID.Name = "colTierGehegeID";
            // 
            // colTierThemenbereich
            // 
            colTierThemenbereich.HeaderText = "Themenbereich";
            colTierThemenbereich.Name = "colTierThemenbereich";
            // 
            // tabPageStatistik
            // 
            tabPageStatistik.Controls.Add(dataGridViewStatistik);
            tabPageStatistik.Controls.Add(radioButtonThemenbereichTierarten);
            tabPageStatistik.Controls.Add(radioButtonThemenbereicheOhneGehege);
            tabPageStatistik.Controls.Add(radioButtonAnzahlTierartenTiere);
            tabPageStatistik.Controls.Add(radioButtonAnzahlTierarten);
            tabPageStatistik.Controls.Add(radioButtonLeereGehege);
            tabPageStatistik.Controls.Add(radioButtonWelcheTiereGehege);
            tabPageStatistik.Controls.Add(radioButtonAnzahlTiereZoo);
            tabPageStatistik.Location = new Point(4, 24);
            tabPageStatistik.Name = "tabPageStatistik";
            tabPageStatistik.Padding = new Padding(3);
            tabPageStatistik.Size = new Size(619, 438);
            tabPageStatistik.TabIndex = 4;
            tabPageStatistik.Text = "Statistik";
            tabPageStatistik.UseVisualStyleBackColor = true;
            // 
            // dataGridViewStatistik
            // 
            dataGridViewStatistik.AllowUserToAddRows = false;
            dataGridViewStatistik.AllowUserToDeleteRows = false;
            dataGridViewStatistik.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewStatistik.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStatistik.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStatistik.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewStatistik.Location = new Point(6, 265);
            dataGridViewStatistik.Name = "dataGridViewStatistik";
            dataGridViewStatistik.Size = new Size(607, 150);
            dataGridViewStatistik.TabIndex = 8;
            // 
            // radioButtonThemenbereichTierarten
            // 
            radioButtonThemenbereichTierarten.AutoSize = true;
            radioButtonThemenbereichTierarten.Location = new Point(26, 221);
            radioButtonThemenbereichTierarten.Name = "radioButtonThemenbereichTierarten";
            radioButtonThemenbereichTierarten.Size = new Size(309, 19);
            radioButtonThemenbereichTierarten.TabIndex = 6;
            radioButtonThemenbereichTierarten.Tag = "7";
            radioButtonThemenbereichTierarten.Text = "7. In welchem Themenbereich leben welche Tierarten?";
            radioButtonThemenbereichTierarten.UseVisualStyleBackColor = true;
            radioButtonThemenbereichTierarten.CheckedChanged += radioButtonThemenbereichTierarten_CheckedChanged;
            // 
            // radioButtonThemenbereicheOhneGehege
            // 
            radioButtonThemenbereicheOhneGehege.AutoSize = true;
            radioButtonThemenbereicheOhneGehege.Location = new Point(26, 188);
            radioButtonThemenbereicheOhneGehege.Name = "radioButtonThemenbereicheOhneGehege";
            radioButtonThemenbereicheOhneGehege.Size = new Size(242, 19);
            radioButtonThemenbereicheOhneGehege.TabIndex = 5;
            radioButtonThemenbereicheOhneGehege.Tag = "6";
            radioButtonThemenbereicheOhneGehege.Text = "6. Gibt es Themenbereiche ohne Gehege?";
            radioButtonThemenbereicheOhneGehege.UseVisualStyleBackColor = true;
            radioButtonThemenbereicheOhneGehege.CheckedChanged += radioButtonThemenbereichTierarten_CheckedChanged;
            // 
            // radioButtonAnzahlTierartenTiere
            // 
            radioButtonAnzahlTierartenTiere.AutoSize = true;
            radioButtonAnzahlTierartenTiere.Location = new Point(26, 155);
            radioButtonAnzahlTierartenTiere.Name = "radioButtonAnzahlTierartenTiere";
            radioButtonAnzahlTierartenTiere.Size = new Size(253, 19);
            radioButtonAnzahlTierartenTiere.TabIndex = 4;
            radioButtonAnzahlTierartenTiere.Tag = "5";
            radioButtonAnzahlTierartenTiere.Text = "5. Von welcher Tierart gibt es wieviele Tiere?";
            radioButtonAnzahlTierartenTiere.UseVisualStyleBackColor = true;
            radioButtonAnzahlTierartenTiere.CheckedChanged += radioButtonThemenbereichTierarten_CheckedChanged;
            // 
            // radioButtonAnzahlTierarten
            // 
            radioButtonAnzahlTierarten.AutoSize = true;
            radioButtonAnzahlTierarten.Location = new Point(26, 122);
            radioButtonAnzahlTierarten.Name = "radioButtonAnzahlTierarten";
            radioButtonAnzahlTierarten.Size = new Size(280, 19);
            radioButtonAnzahlTierarten.TabIndex = 3;
            radioButtonAnzahlTierarten.Tag = "4";
            radioButtonAnzahlTierarten.Text = "4. Wieviele verschiedene Tierarten leben im Zoo?";
            radioButtonAnzahlTierarten.UseVisualStyleBackColor = true;
            radioButtonAnzahlTierarten.CheckedChanged += radioButtonThemenbereichTierarten_CheckedChanged;
            // 
            // radioButtonLeereGehege
            // 
            radioButtonLeereGehege.AutoSize = true;
            radioButtonLeereGehege.Location = new Point(26, 89);
            radioButtonLeereGehege.Name = "radioButtonLeereGehege";
            radioButtonLeereGehege.Size = new Size(171, 19);
            radioButtonLeereGehege.TabIndex = 2;
            radioButtonLeereGehege.Tag = "3";
            radioButtonLeereGehege.Text = "3. Welche Gehege sind leer?";
            radioButtonLeereGehege.UseVisualStyleBackColor = true;
            radioButtonLeereGehege.CheckedChanged += radioButtonThemenbereichTierarten_CheckedChanged;
            // 
            // radioButtonWelcheTiereGehege
            // 
            radioButtonWelcheTiereGehege.AutoSize = true;
            radioButtonWelcheTiereGehege.Location = new Point(26, 56);
            radioButtonWelcheTiereGehege.Name = "radioButtonWelcheTiereGehege";
            radioButtonWelcheTiereGehege.Size = new Size(242, 19);
            radioButtonWelcheTiereGehege.TabIndex = 1;
            radioButtonWelcheTiereGehege.Tag = "2";
            radioButtonWelcheTiereGehege.Text = "2. In welchen Gehegen sind welche Tiere?";
            radioButtonWelcheTiereGehege.UseVisualStyleBackColor = true;
            radioButtonWelcheTiereGehege.CheckedChanged += radioButtonThemenbereichTierarten_CheckedChanged;
            // 
            // radioButtonAnzahlTiereZoo
            // 
            radioButtonAnzahlTiereZoo.AutoSize = true;
            radioButtonAnzahlTiereZoo.Checked = true;
            radioButtonAnzahlTiereZoo.Location = new Point(26, 23);
            radioButtonAnzahlTiereZoo.Name = "radioButtonAnzahlTiereZoo";
            radioButtonAnzahlTiereZoo.Size = new Size(187, 19);
            radioButtonAnzahlTiereZoo.TabIndex = 0;
            radioButtonAnzahlTiereZoo.TabStop = true;
            radioButtonAnzahlTiereZoo.Tag = "1";
            radioButtonAnzahlTiereZoo.Text = "1. Wieviele Tiere leben im Zoo?";
            radioButtonAnzahlTiereZoo.UseVisualStyleBackColor = true;
            radioButtonAnzahlTiereZoo.CheckedChanged += radioButtonThemenbereichTierarten_CheckedChanged;
            // 
            // tabPagePersonalEinteilung
            // 
            tabPagePersonalEinteilung.Controls.Add(listBoxNormalPfleger);
            tabPagePersonalEinteilung.Controls.Add(listBoxHauptpfleger);
            tabPagePersonalEinteilung.Controls.Add(lbNormalPfleger);
            tabPagePersonalEinteilung.Controls.Add(lbHauptpfleger);
            tabPagePersonalEinteilung.Controls.Add(textBoxArbeitskraft);
            tabPagePersonalEinteilung.Controls.Add(lbPersonalName);
            tabPagePersonalEinteilung.Controls.Add(lbPersonalIDWert);
            tabPagePersonalEinteilung.Controls.Add(lbPersonalID);
            tabPagePersonalEinteilung.Controls.Add(dataGridViewPersonalEinteilung);
            tabPagePersonalEinteilung.Location = new Point(4, 24);
            tabPagePersonalEinteilung.Name = "tabPagePersonalEinteilung";
            tabPagePersonalEinteilung.Padding = new Padding(3);
            tabPagePersonalEinteilung.Size = new Size(619, 438);
            tabPagePersonalEinteilung.TabIndex = 5;
            tabPagePersonalEinteilung.Text = "Personaleinteilung";
            tabPagePersonalEinteilung.UseVisualStyleBackColor = true;
            // 
            // listBoxNormalPfleger
            // 
            listBoxNormalPfleger.FormattingEnabled = true;
            listBoxNormalPfleger.ItemHeight = 15;
            listBoxNormalPfleger.Location = new Point(421, 107);
            listBoxNormalPfleger.Name = "listBoxNormalPfleger";
            listBoxNormalPfleger.Size = new Size(120, 124);
            listBoxNormalPfleger.TabIndex = 8;
            listBoxNormalPfleger.DoubleClick += listBoxNormalPfleger_DoubleClick;
            // 
            // listBoxHauptpfleger
            // 
            listBoxHauptpfleger.FormattingEnabled = true;
            listBoxHauptpfleger.ItemHeight = 15;
            listBoxHauptpfleger.Location = new Point(118, 107);
            listBoxHauptpfleger.Name = "listBoxHauptpfleger";
            listBoxHauptpfleger.Size = new Size(120, 124);
            listBoxHauptpfleger.TabIndex = 7;
            listBoxHauptpfleger.DoubleClick += listBoxHauptpfleger_DoubleClick;
            // 
            // lbNormalPfleger
            // 
            lbNormalPfleger.AutoSize = true;
            lbNormalPfleger.Location = new Point(320, 107);
            lbNormalPfleger.Name = "lbNormalPfleger";
            lbNormalPfleger.Size = new Size(95, 15);
            lbNormalPfleger.TabIndex = 6;
            lbNormalPfleger.Text = "Pflegt zusätzlich:";
            // 
            // lbHauptpfleger
            // 
            lbHauptpfleger.AutoSize = true;
            lbHauptpfleger.Location = new Point(19, 107);
            lbHauptpfleger.Name = "lbHauptpfleger";
            lbHauptpfleger.Size = new Size(93, 15);
            lbHauptpfleger.TabIndex = 5;
            lbHauptpfleger.Text = "Hauptpfleger in:";
            // 
            // textBoxArbeitskraft
            // 
            textBoxArbeitskraft.Location = new Point(200, 51);
            textBoxArbeitskraft.Name = "textBoxArbeitskraft";
            textBoxArbeitskraft.ReadOnly = true;
            textBoxArbeitskraft.Size = new Size(100, 23);
            textBoxArbeitskraft.TabIndex = 4;
            // 
            // lbPersonalName
            // 
            lbPersonalName.AutoSize = true;
            lbPersonalName.Location = new Point(19, 54);
            lbPersonalName.Name = "lbPersonalName";
            lbPersonalName.Size = new Size(126, 15);
            lbPersonalName.TabIndex = 3;
            lbPersonalName.Text = "Name der Arbeitskraft:";
            // 
            // lbPersonalIDWert
            // 
            lbPersonalIDWert.AutoSize = true;
            lbPersonalIDWert.Location = new Point(200, 20);
            lbPersonalIDWert.Name = "lbPersonalIDWert";
            lbPersonalIDWert.Size = new Size(62, 15);
            lbPersonalIDWert.TabIndex = 2;
            lbPersonalIDWert.Text = "Platzhalter";
            // 
            // lbPersonalID
            // 
            lbPersonalID.AutoSize = true;
            lbPersonalID.Location = new Point(19, 20);
            lbPersonalID.Name = "lbPersonalID";
            lbPersonalID.Size = new Size(69, 15);
            lbPersonalID.TabIndex = 1;
            lbPersonalID.Text = "PersonalID: ";
            // 
            // dataGridViewPersonalEinteilung
            // 
            dataGridViewPersonalEinteilung.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPersonalEinteilung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPersonalEinteilung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPersonalEinteilung.Columns.AddRange(new DataGridViewColumn[] { Personalnummer, PersonalName, GehegeHauptpfleger, GehegeNormalPfleger });
            dataGridViewPersonalEinteilung.Location = new Point(6, 246);
            dataGridViewPersonalEinteilung.MultiSelect = false;
            dataGridViewPersonalEinteilung.Name = "dataGridViewPersonalEinteilung";
            dataGridViewPersonalEinteilung.ReadOnly = true;
            dataGridViewPersonalEinteilung.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPersonalEinteilung.Size = new Size(607, 186);
            dataGridViewPersonalEinteilung.TabIndex = 0;
            dataGridViewPersonalEinteilung.SelectionChanged += dataGridViewPersonalEinteilung_SelectionChanged;
            // 
            // Personalnummer
            // 
            Personalnummer.HeaderText = "Personalnummer";
            Personalnummer.Name = "Personalnummer";
            Personalnummer.ReadOnly = true;
            // 
            // PersonalName
            // 
            PersonalName.HeaderText = "Vollständiger Name";
            PersonalName.Name = "PersonalName";
            PersonalName.ReadOnly = true;
            // 
            // GehegeHauptpfleger
            // 
            GehegeHauptpfleger.HeaderText = "Hauptpfleger in diesen Gehegen";
            GehegeHauptpfleger.Name = "GehegeHauptpfleger";
            GehegeHauptpfleger.ReadOnly = true;
            // 
            // GehegeNormalPfleger
            // 
            GehegeNormalPfleger.HeaderText = "Betreut zurätzlich";
            GehegeNormalPfleger.Name = "GehegeNormalPfleger";
            GehegeNormalPfleger.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 490);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPageThemenbereiche.ResumeLayout(false);
            tabPageThemenbereiche.PerformLayout();
            tabPageGehege.ResumeLayout(false);
            tabPageGehege.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridGehege).EndInit();
            tabPageTierarten.ResumeLayout(false);
            tabPageTierarten.PerformLayout();
            tabPageTiere.ResumeLayout(false);
            tabPageTiere.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTiere).EndInit();
            tabPageStatistik.ResumeLayout(false);
            tabPageStatistik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStatistik).EndInit();
            tabPagePersonalEinteilung.ResumeLayout(false);
            tabPagePersonalEinteilung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersonalEinteilung).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageThemenbereiche;
        private Label label1;
        private TabPage tabPageGehege;
        private TabPage tabPageTierarten;
        private TabPage tabPageTiere;
        private ListBox listBoxThemenbereiche;
        private TextBox tbTheme;
        private Button buttonThemenbereichSpeichern;
        private Button buttonLoeschen;
        private Button buttonThemenbereichNeu;
        private TextBox tbTierart;
        private Label lbTierart;
        private ListBox listBoxTierart;
        private Button buttonLöschenTierart;
        private Button buttonNeuTierart;
        private Button buttonSpeichernTierart;
        private Label lbGehegeName;
        private Label labelGehegeThemenBereich;
        private ComboBox comboBoxThemenBereiche;
        private TextBox tbGehegeName;
        private Button buttonGehegeSpeichern;
        private DataGridView dataGridGehege;
        private DataGridViewTextBoxColumn colGehegeName;
        private DataGridViewTextBoxColumn colGehegeThemenbereich;
        private DataGridView dataGridViewTiere;
        private DataGridViewTextBoxColumn colTiername;
        private DataGridViewTextBoxColumn colTierTierart;
        private DataGridViewTextBoxColumn colTierGehegeID;
        private DataGridViewTextBoxColumn colTierThemenbereich;
        private Label lbTierIDText;
        private ComboBox comboBoxTierTierart;
        private ComboBox comboBoxTierGehege;
        private TextBox tbTierName;
        private Label lbTierTierart;
        private Label lbTierGehege;
        private Label lbTiername;
        private Label lbTierIDWert;
        private Button buttonTierLoeschen;
        private Button buttonTierSpeichern;
        private Button buttonTierNeu;
        private ComboBox comboBoxTierThemenbereich;
        private Label lbTierThemenbereich;
        private TabPage tabPageStatistik;
        private RadioButton radioButtonThemenbereichTierarten;
        private RadioButton radioButtonThemenbereicheOhneGehege;
        private RadioButton radioButtonAnzahlTierartenTiere;
        private RadioButton radioButtonAnzahlTierarten;
        private RadioButton radioButtonLeereGehege;
        private RadioButton radioButtonWelcheTiereGehege;
        private RadioButton radioButtonAnzahlTiereZoo;
        private DataGridView dataGridViewStatistik;
        private Button buttonGehegeLoeschen;
        private Button buttonGehegeNeu;
        private TabPage tabPagePersonalEinteilung;
        private DataGridView dataGridViewPersonalEinteilung;
        private Label lbNormalPfleger;
        private Label lbHauptpfleger;
        private TextBox textBoxArbeitskraft;
        private Label lbPersonalName;
        private Label lbPersonalIDWert;
        private Label lbPersonalID;
        private ListBox listBoxNormalPfleger;
        private ListBox listBoxHauptpfleger;
        private DataGridViewTextBoxColumn Personalnummer;
        private DataGridViewTextBoxColumn PersonalName;
        private DataGridViewTextBoxColumn GehegeHauptpfleger;
        private DataGridViewTextBoxColumn GehegeNormalPfleger;
    }
}
