namespace Przychodnia_rejestracja
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabLekarze = new System.Windows.Forms.TabPage();
            this.splitLekarze = new System.Windows.Forms.SplitContainer();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbNazwisko = new System.Windows.Forms.ComboBox();
            this.cbImie = new System.Windows.Forms.ComboBox();
            this.dgvLekarze = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miejsce_ur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_ur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miescje_zam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kod_pocztowy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsLekarze = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lekarze_szczegoly = new System.Windows.Forms.ToolStripMenuItem();
            this.lekarze_dodaj = new System.Windows.Forms.ToolStripMenuItem();
            this.tabWizyty = new System.Windows.Forms.TabPage();
            this.splitWizyty = new System.Windows.Forms.SplitContainer();
            this.tabPacjenci = new System.Windows.Forms.TabPage();
            this.splitPacjenci = new System.Windows.Forms.SplitContainer();
            this.tabSpecjalnosci = new System.Windows.Forms.TabPage();
            this.splitSpecjalnosci = new System.Windows.Forms.SplitContainer();
            this.tabChoroby = new System.Windows.Forms.TabPage();
            this.splitChoroby = new System.Windows.Forms.SplitContainer();
            this.tabLekarstwa = new System.Windows.Forms.TabPage();
            this.splitLekarstwa = new System.Windows.Forms.SplitContainer();
            this.tabSwiadczenia = new System.Windows.Forms.TabPage();
            this.splitSwiadczenia = new System.Windows.Forms.SplitContainer();
            this.dgvSwiadczenia = new System.Windows.Forms.DataGridView();
            this.s_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_koszt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbSwiadczenia = new System.Windows.Forms.GroupBox();
            this.bAnulujSwiadczenie = new System.Windows.Forms.Button();
            this.bEdytujSwiadczenie = new System.Windows.Forms.Button();
            this.bDodajSwiadczenie = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKoszt = new System.Windows.Forms.TextBox();
            this.tbSwiadczenia = new System.Windows.Forms.TextBox();
            this.dgvChoroby = new System.Windows.Forms.DataGridView();
            this.ch_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch_nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch_opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbChoroby = new System.Windows.Forms.GroupBox();
            this.tbChoroba = new System.Windows.Forms.TextBox();
            this.tbChOpis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bChDodaj = new System.Windows.Forms.Button();
            this.bChZapisz = new System.Windows.Forms.Button();
            this.bChAnuluj = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabLekarze.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitLekarze)).BeginInit();
            this.splitLekarze.Panel1.SuspendLayout();
            this.splitLekarze.Panel2.SuspendLayout();
            this.splitLekarze.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLekarze)).BeginInit();
            this.cmsLekarze.SuspendLayout();
            this.tabWizyty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitWizyty)).BeginInit();
            this.splitWizyty.SuspendLayout();
            this.tabPacjenci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPacjenci)).BeginInit();
            this.splitPacjenci.SuspendLayout();
            this.tabSpecjalnosci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitSpecjalnosci)).BeginInit();
            this.splitSpecjalnosci.SuspendLayout();
            this.tabChoroby.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitChoroby)).BeginInit();
            this.splitChoroby.Panel1.SuspendLayout();
            this.splitChoroby.Panel2.SuspendLayout();
            this.splitChoroby.SuspendLayout();
            this.tabLekarstwa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitLekarstwa)).BeginInit();
            this.splitLekarstwa.SuspendLayout();
            this.tabSwiadczenia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitSwiadczenia)).BeginInit();
            this.splitSwiadczenia.Panel1.SuspendLayout();
            this.splitSwiadczenia.Panel2.SuspendLayout();
            this.splitSwiadczenia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSwiadczenia)).BeginInit();
            this.gbSwiadczenia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoroby)).BeginInit();
            this.gbChoroby.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 521);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(886, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.opcjeToolStripMenuItem,
            this.oProgramieToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(886, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // opcjeToolStripMenuItem
            // 
            this.opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
            this.opcjeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.opcjeToolStripMenuItem.Text = "Opcje";
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl.Controls.Add(this.tabLekarze);
            this.tabControl.Controls.Add(this.tabWizyty);
            this.tabControl.Controls.Add(this.tabPacjenci);
            this.tabControl.Controls.Add(this.tabSpecjalnosci);
            this.tabControl.Controls.Add(this.tabChoroby);
            this.tabControl.Controls.Add(this.tabLekarstwa);
            this.tabControl.Controls.Add(this.tabSwiadczenia);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(886, 497);
            this.tabControl.TabIndex = 2;
            // 
            // tabLekarze
            // 
            this.tabLekarze.Controls.Add(this.splitLekarze);
            this.tabLekarze.Location = new System.Drawing.Point(4, 4);
            this.tabLekarze.Name = "tabLekarze";
            this.tabLekarze.Padding = new System.Windows.Forms.Padding(3);
            this.tabLekarze.Size = new System.Drawing.Size(878, 471);
            this.tabLekarze.TabIndex = 0;
            this.tabLekarze.Text = "Lekarze";
            this.tabLekarze.UseVisualStyleBackColor = true;
            // 
            // splitLekarze
            // 
            this.splitLekarze.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitLekarze.Location = new System.Drawing.Point(3, 3);
            this.splitLekarze.Name = "splitLekarze";
            this.splitLekarze.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitLekarze.Panel1
            // 
            this.splitLekarze.Panel1.Controls.Add(this.comboBox1);
            this.splitLekarze.Panel1.Controls.Add(this.cbNazwisko);
            this.splitLekarze.Panel1.Controls.Add(this.cbImie);
            // 
            // splitLekarze.Panel2
            // 
            this.splitLekarze.Panel2.Controls.Add(this.dgvLekarze);
            this.splitLekarze.Size = new System.Drawing.Size(872, 465);
            this.splitLekarze.SplitterDistance = 82;
            this.splitLekarze.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(278, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // cbNazwisko
            // 
            this.cbNazwisko.FormattingEnabled = true;
            this.cbNazwisko.Location = new System.Drawing.Point(78, 39);
            this.cbNazwisko.Name = "cbNazwisko";
            this.cbNazwisko.Size = new System.Drawing.Size(121, 21);
            this.cbNazwisko.TabIndex = 1;
            // 
            // cbImie
            // 
            this.cbImie.FormattingEnabled = true;
            this.cbImie.Location = new System.Drawing.Point(78, 12);
            this.cbImie.Name = "cbImie";
            this.cbImie.Size = new System.Drawing.Size(121, 21);
            this.cbImie.TabIndex = 0;
            // 
            // dgvLekarze
            // 
            this.dgvLekarze.AllowUserToOrderColumns = true;
            this.dgvLekarze.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLekarze.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLekarze.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.imie,
            this.nazwisko,
            this.miejsce_ur,
            this.data_ur,
            this.adres,
            this.miescje_zam,
            this.kod_pocztowy});
            this.dgvLekarze.ContextMenuStrip = this.cmsLekarze;
            this.dgvLekarze.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLekarze.Location = new System.Drawing.Point(0, 0);
            this.dgvLekarze.MultiSelect = false;
            this.dgvLekarze.Name = "dgvLekarze";
            this.dgvLekarze.ReadOnly = true;
            this.dgvLekarze.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvLekarze.RowHeadersVisible = false;
            this.dgvLekarze.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLekarze.ShowCellToolTips = false;
            this.dgvLekarze.Size = new System.Drawing.Size(872, 379);
            this.dgvLekarze.TabIndex = 0;
            this.dgvLekarze.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseDown);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Lp.";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 47;
            // 
            // imie
            // 
            this.imie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.imie.DataPropertyName = "imie";
            this.imie.HeaderText = "Imię";
            this.imie.Name = "imie";
            this.imie.ReadOnly = true;
            // 
            // nazwisko
            // 
            this.nazwisko.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazwisko.DataPropertyName = "nazwisko";
            this.nazwisko.HeaderText = "Nazwisko";
            this.nazwisko.Name = "nazwisko";
            this.nazwisko.ReadOnly = true;
            // 
            // miejsce_ur
            // 
            this.miejsce_ur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.miejsce_ur.DataPropertyName = "miejsce_ur";
            this.miejsce_ur.HeaderText = "Miejsce Urodzenia";
            this.miejsce_ur.Name = "miejsce_ur";
            this.miejsce_ur.ReadOnly = true;
            // 
            // data_ur
            // 
            this.data_ur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.data_ur.DataPropertyName = "data_ur";
            this.data_ur.HeaderText = "Data urodzenia";
            this.data_ur.Name = "data_ur";
            this.data_ur.ReadOnly = true;
            // 
            // adres
            // 
            this.adres.DataPropertyName = "adres";
            this.adres.HeaderText = "Adres";
            this.adres.Name = "adres";
            this.adres.ReadOnly = true;
            // 
            // miescje_zam
            // 
            this.miescje_zam.DataPropertyName = "miescje_zam";
            this.miescje_zam.HeaderText = "Miasto";
            this.miescje_zam.Name = "miescje_zam";
            this.miescje_zam.ReadOnly = true;
            // 
            // kod_pocztowy
            // 
            this.kod_pocztowy.DataPropertyName = "kod_pocztowy";
            this.kod_pocztowy.HeaderText = "Kod Pocztowy";
            this.kod_pocztowy.Name = "kod_pocztowy";
            this.kod_pocztowy.ReadOnly = true;
            // 
            // cmsLekarze
            // 
            this.cmsLekarze.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lekarze_szczegoly,
            this.lekarze_dodaj});
            this.cmsLekarze.Name = "cmsLekarze";
            this.cmsLekarze.Size = new System.Drawing.Size(126, 48);
            this.cmsLekarze.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsLekarze_ItemClicked);
            // 
            // lekarze_szczegoly
            // 
            this.lekarze_szczegoly.Name = "lekarze_szczegoly";
            this.lekarze_szczegoly.Size = new System.Drawing.Size(125, 22);
            this.lekarze_szczegoly.Text = "Szczegóły";
            // 
            // lekarze_dodaj
            // 
            this.lekarze_dodaj.Name = "lekarze_dodaj";
            this.lekarze_dodaj.Size = new System.Drawing.Size(125, 22);
            this.lekarze_dodaj.Text = "Dodaj";
            // 
            // tabWizyty
            // 
            this.tabWizyty.Controls.Add(this.splitWizyty);
            this.tabWizyty.Location = new System.Drawing.Point(4, 4);
            this.tabWizyty.Name = "tabWizyty";
            this.tabWizyty.Padding = new System.Windows.Forms.Padding(3);
            this.tabWizyty.Size = new System.Drawing.Size(878, 471);
            this.tabWizyty.TabIndex = 1;
            this.tabWizyty.Text = "Wizyty";
            this.tabWizyty.UseVisualStyleBackColor = true;
            // 
            // splitWizyty
            // 
            this.splitWizyty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitWizyty.Location = new System.Drawing.Point(3, 3);
            this.splitWizyty.Name = "splitWizyty";
            this.splitWizyty.Size = new System.Drawing.Size(872, 465);
            this.splitWizyty.SplitterDistance = 290;
            this.splitWizyty.TabIndex = 0;
            // 
            // tabPacjenci
            // 
            this.tabPacjenci.Controls.Add(this.splitPacjenci);
            this.tabPacjenci.Location = new System.Drawing.Point(4, 4);
            this.tabPacjenci.Name = "tabPacjenci";
            this.tabPacjenci.Padding = new System.Windows.Forms.Padding(3);
            this.tabPacjenci.Size = new System.Drawing.Size(878, 471);
            this.tabPacjenci.TabIndex = 2;
            this.tabPacjenci.Text = "Pacjenci";
            this.tabPacjenci.UseVisualStyleBackColor = true;
            // 
            // splitPacjenci
            // 
            this.splitPacjenci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPacjenci.Location = new System.Drawing.Point(3, 3);
            this.splitPacjenci.Name = "splitPacjenci";
            this.splitPacjenci.Size = new System.Drawing.Size(872, 465);
            this.splitPacjenci.SplitterDistance = 290;
            this.splitPacjenci.TabIndex = 0;
            // 
            // tabSpecjalnosci
            // 
            this.tabSpecjalnosci.Controls.Add(this.splitSpecjalnosci);
            this.tabSpecjalnosci.Location = new System.Drawing.Point(4, 4);
            this.tabSpecjalnosci.Name = "tabSpecjalnosci";
            this.tabSpecjalnosci.Padding = new System.Windows.Forms.Padding(3);
            this.tabSpecjalnosci.Size = new System.Drawing.Size(878, 471);
            this.tabSpecjalnosci.TabIndex = 3;
            this.tabSpecjalnosci.Text = "Specjalnosci";
            this.tabSpecjalnosci.UseVisualStyleBackColor = true;
            // 
            // splitSpecjalnosci
            // 
            this.splitSpecjalnosci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitSpecjalnosci.Location = new System.Drawing.Point(3, 3);
            this.splitSpecjalnosci.Name = "splitSpecjalnosci";
            this.splitSpecjalnosci.Size = new System.Drawing.Size(872, 465);
            this.splitSpecjalnosci.SplitterDistance = 290;
            this.splitSpecjalnosci.TabIndex = 0;
            // 
            // tabChoroby
            // 
            this.tabChoroby.Controls.Add(this.splitChoroby);
            this.tabChoroby.Location = new System.Drawing.Point(4, 4);
            this.tabChoroby.Name = "tabChoroby";
            this.tabChoroby.Padding = new System.Windows.Forms.Padding(3);
            this.tabChoroby.Size = new System.Drawing.Size(878, 471);
            this.tabChoroby.TabIndex = 4;
            this.tabChoroby.Text = "Choroby";
            this.tabChoroby.UseVisualStyleBackColor = true;
            // 
            // splitChoroby
            // 
            this.splitChoroby.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitChoroby.Location = new System.Drawing.Point(3, 3);
            this.splitChoroby.Name = "splitChoroby";
            // 
            // splitChoroby.Panel1
            // 
            this.splitChoroby.Panel1.Controls.Add(this.dgvChoroby);
            // 
            // splitChoroby.Panel2
            // 
            this.splitChoroby.Panel2.Controls.Add(this.gbChoroby);
            this.splitChoroby.Size = new System.Drawing.Size(872, 465);
            this.splitChoroby.SplitterDistance = 562;
            this.splitChoroby.TabIndex = 0;
            // 
            // tabLekarstwa
            // 
            this.tabLekarstwa.Controls.Add(this.splitLekarstwa);
            this.tabLekarstwa.Location = new System.Drawing.Point(4, 4);
            this.tabLekarstwa.Name = "tabLekarstwa";
            this.tabLekarstwa.Padding = new System.Windows.Forms.Padding(3);
            this.tabLekarstwa.Size = new System.Drawing.Size(878, 471);
            this.tabLekarstwa.TabIndex = 5;
            this.tabLekarstwa.Text = "Lekarstwa";
            this.tabLekarstwa.UseVisualStyleBackColor = true;
            // 
            // splitLekarstwa
            // 
            this.splitLekarstwa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitLekarstwa.Location = new System.Drawing.Point(3, 3);
            this.splitLekarstwa.Name = "splitLekarstwa";
            this.splitLekarstwa.Size = new System.Drawing.Size(872, 465);
            this.splitLekarstwa.SplitterDistance = 290;
            this.splitLekarstwa.TabIndex = 0;
            // 
            // tabSwiadczenia
            // 
            this.tabSwiadczenia.Controls.Add(this.splitSwiadczenia);
            this.tabSwiadczenia.Location = new System.Drawing.Point(4, 4);
            this.tabSwiadczenia.Name = "tabSwiadczenia";
            this.tabSwiadczenia.Padding = new System.Windows.Forms.Padding(3);
            this.tabSwiadczenia.Size = new System.Drawing.Size(878, 471);
            this.tabSwiadczenia.TabIndex = 6;
            this.tabSwiadczenia.Text = "Świadczenia";
            this.tabSwiadczenia.UseVisualStyleBackColor = true;
            // 
            // splitSwiadczenia
            // 
            this.splitSwiadczenia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitSwiadczenia.Location = new System.Drawing.Point(3, 3);
            this.splitSwiadczenia.Name = "splitSwiadczenia";
            // 
            // splitSwiadczenia.Panel1
            // 
            this.splitSwiadczenia.Panel1.Controls.Add(this.dgvSwiadczenia);
            // 
            // splitSwiadczenia.Panel2
            // 
            this.splitSwiadczenia.Panel2.Controls.Add(this.gbSwiadczenia);
            this.splitSwiadczenia.Size = new System.Drawing.Size(872, 465);
            this.splitSwiadczenia.SplitterDistance = 574;
            this.splitSwiadczenia.TabIndex = 0;
            // 
            // dgvSwiadczenia
            // 
            this.dgvSwiadczenia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSwiadczenia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.s_id,
            this.s_nazwa,
            this.s_koszt});
            this.dgvSwiadczenia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSwiadczenia.Location = new System.Drawing.Point(0, 0);
            this.dgvSwiadczenia.MultiSelect = false;
            this.dgvSwiadczenia.Name = "dgvSwiadczenia";
            this.dgvSwiadczenia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSwiadczenia.Size = new System.Drawing.Size(574, 465);
            this.dgvSwiadczenia.TabIndex = 0;
            this.dgvSwiadczenia.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRow_DoubleClicked);
            // 
            // s_id
            // 
            this.s_id.DataPropertyName = "s_id";
            this.s_id.HeaderText = "id";
            this.s_id.Name = "s_id";
            this.s_id.Visible = false;
            // 
            // s_nazwa
            // 
            this.s_nazwa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.s_nazwa.DataPropertyName = "s_nazwa";
            this.s_nazwa.HeaderText = "Nazwa świadczenia";
            this.s_nazwa.Name = "s_nazwa";
            // 
            // s_koszt
            // 
            this.s_koszt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.s_koszt.DataPropertyName = "s_koszt";
            this.s_koszt.HeaderText = "Koszt świadczenia";
            this.s_koszt.Name = "s_koszt";
            // 
            // gbSwiadczenia
            // 
            this.gbSwiadczenia.Controls.Add(this.bAnulujSwiadczenie);
            this.gbSwiadczenia.Controls.Add(this.bEdytujSwiadczenie);
            this.gbSwiadczenia.Controls.Add(this.bDodajSwiadczenie);
            this.gbSwiadczenia.Controls.Add(this.label2);
            this.gbSwiadczenia.Controls.Add(this.label1);
            this.gbSwiadczenia.Controls.Add(this.tbKoszt);
            this.gbSwiadczenia.Controls.Add(this.tbSwiadczenia);
            this.gbSwiadczenia.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSwiadczenia.Location = new System.Drawing.Point(0, 0);
            this.gbSwiadczenia.Name = "gbSwiadczenia";
            this.gbSwiadczenia.Size = new System.Drawing.Size(294, 191);
            this.gbSwiadczenia.TabIndex = 0;
            this.gbSwiadczenia.TabStop = false;
            this.gbSwiadczenia.Text = "Dodaj świadczenie";
            // 
            // bAnulujSwiadczenie
            // 
            this.bAnulujSwiadczenie.Location = new System.Drawing.Point(147, 152);
            this.bAnulujSwiadczenie.Name = "bAnulujSwiadczenie";
            this.bAnulujSwiadczenie.Size = new System.Drawing.Size(91, 23);
            this.bAnulujSwiadczenie.TabIndex = 6;
            this.bAnulujSwiadczenie.Text = "Anuluj";
            this.bAnulujSwiadczenie.UseVisualStyleBackColor = true;
            this.bAnulujSwiadczenie.Visible = false;
            this.bAnulujSwiadczenie.Click += new System.EventHandler(this.bAnulujSwiadczenie_Click);
            // 
            // bEdytujSwiadczenie
            // 
            this.bEdytujSwiadczenie.Location = new System.Drawing.Point(50, 123);
            this.bEdytujSwiadczenie.Name = "bEdytujSwiadczenie";
            this.bEdytujSwiadczenie.Size = new System.Drawing.Size(91, 23);
            this.bEdytujSwiadczenie.TabIndex = 5;
            this.bEdytujSwiadczenie.Text = "Zapisz";
            this.bEdytujSwiadczenie.UseVisualStyleBackColor = true;
            this.bEdytujSwiadczenie.Visible = false;
            this.bEdytujSwiadczenie.VisibleChanged += new System.EventHandler(this.bEdytujSwiadczenie_VisibleChanged);
            this.bEdytujSwiadczenie.Click += new System.EventHandler(this.bEdytujSwiadczenie_Click);
            // 
            // bDodajSwiadczenie
            // 
            this.bDodajSwiadczenie.Location = new System.Drawing.Point(147, 123);
            this.bDodajSwiadczenie.Name = "bDodajSwiadczenie";
            this.bDodajSwiadczenie.Size = new System.Drawing.Size(91, 23);
            this.bDodajSwiadczenie.TabIndex = 4;
            this.bDodajSwiadczenie.Text = "Dodaj";
            this.bDodajSwiadczenie.UseVisualStyleBackColor = true;
            this.bDodajSwiadczenie.Click += new System.EventHandler(this.dodaj_swiadczenia_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Koszt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nazwa ";
            // 
            // tbKoszt
            // 
            this.tbKoszt.Location = new System.Drawing.Point(79, 79);
            this.tbKoszt.Name = "tbKoszt";
            this.tbKoszt.Size = new System.Drawing.Size(121, 20);
            this.tbKoszt.TabIndex = 1;
            this.tbKoszt.TextChanged += new System.EventHandler(this.SprawdzFormat_Pieniadze);
            // 
            // tbSwiadczenia
            // 
            this.tbSwiadczenia.Location = new System.Drawing.Point(79, 53);
            this.tbSwiadczenia.Name = "tbSwiadczenia";
            this.tbSwiadczenia.Size = new System.Drawing.Size(159, 20);
            this.tbSwiadczenia.TabIndex = 0;
            this.tbSwiadczenia.TextChanged += new System.EventHandler(this.SprawdzFormat_Tekst);
            // 
            // dgvChoroby
            // 
            this.dgvChoroby.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChoroby.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ch_id,
            this.ch_nazwa,
            this.ch_opis});
            this.dgvChoroby.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChoroby.Location = new System.Drawing.Point(0, 0);
            this.dgvChoroby.Name = "dgvChoroby";
            this.dgvChoroby.Size = new System.Drawing.Size(562, 465);
            this.dgvChoroby.TabIndex = 0;
            this.dgvChoroby.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRow_DoubleClicked);
            // 
            // ch_id
            // 
            this.ch_id.DataPropertyName = "ch_id";
            this.ch_id.HeaderText = "Column1";
            this.ch_id.Name = "ch_id";
            this.ch_id.Visible = false;
            // 
            // ch_nazwa
            // 
            this.ch_nazwa.DataPropertyName = "ch_nazwa";
            this.ch_nazwa.HeaderText = "Nazwa";
            this.ch_nazwa.Name = "ch_nazwa";
            this.ch_nazwa.Width = 200;
            // 
            // ch_opis
            // 
            this.ch_opis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ch_opis.DataPropertyName = "ch_opis";
            this.ch_opis.HeaderText = "Opis jednostki chorobowej";
            this.ch_opis.Name = "ch_opis";
            // 
            // gbChoroby
            // 
            this.gbChoroby.Controls.Add(this.bChAnuluj);
            this.gbChoroby.Controls.Add(this.bChZapisz);
            this.gbChoroby.Controls.Add(this.bChDodaj);
            this.gbChoroby.Controls.Add(this.label3);
            this.gbChoroby.Controls.Add(this.tbChOpis);
            this.gbChoroby.Controls.Add(this.tbChoroba);
            this.gbChoroby.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbChoroby.Location = new System.Drawing.Point(0, 0);
            this.gbChoroby.Name = "gbChoroby";
            this.gbChoroby.Size = new System.Drawing.Size(306, 245);
            this.gbChoroby.TabIndex = 0;
            this.gbChoroby.TabStop = false;
            this.gbChoroby.Text = "Dodaj chorobę";
            // 
            // tbChoroba
            // 
            this.tbChoroba.Location = new System.Drawing.Point(101, 49);
            this.tbChoroba.Name = "tbChoroba";
            this.tbChoroba.Size = new System.Drawing.Size(153, 20);
            this.tbChoroba.TabIndex = 0;
            this.tbChoroba.TextChanged += new System.EventHandler(this.SprawdzFormat_Tekst);
            // 
            // tbChOpis
            // 
            this.tbChOpis.Location = new System.Drawing.Point(32, 75);
            this.tbChOpis.Multiline = true;
            this.tbChOpis.Name = "tbChOpis";
            this.tbChOpis.Size = new System.Drawing.Size(222, 97);
            this.tbChOpis.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nazwa";
            // 
            // bChDodaj
            // 
            this.bChDodaj.Location = new System.Drawing.Point(165, 178);
            this.bChDodaj.Name = "bChDodaj";
            this.bChDodaj.Size = new System.Drawing.Size(89, 23);
            this.bChDodaj.TabIndex = 3;
            this.bChDodaj.Text = "Dodaj";
            this.bChDodaj.UseVisualStyleBackColor = true;
            this.bChDodaj.Click += new System.EventHandler(this.bChDodaj_Click);
            // 
            // bChZapisz
            // 
            this.bChZapisz.Location = new System.Drawing.Point(70, 178);
            this.bChZapisz.Name = "bChZapisz";
            this.bChZapisz.Size = new System.Drawing.Size(89, 23);
            this.bChZapisz.TabIndex = 4;
            this.bChZapisz.Text = "Zapisz";
            this.bChZapisz.UseVisualStyleBackColor = true;
            this.bChZapisz.Click += new System.EventHandler(this.bChZapisz_Click);
            // 
            // bChAnuluj
            // 
            this.bChAnuluj.Location = new System.Drawing.Point(165, 207);
            this.bChAnuluj.Name = "bChAnuluj";
            this.bChAnuluj.Size = new System.Drawing.Size(89, 23);
            this.bChAnuluj.TabIndex = 5;
            this.bChAnuluj.Text = "Anuluj";
            this.bChAnuluj.UseVisualStyleBackColor = true;
            this.bChAnuluj.Click += new System.EventHandler(this.bChAnuluj_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 543);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainWindow";
            this.Text = "Przychodnia Lekarska - Rejestracja";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabLekarze.ResumeLayout(false);
            this.splitLekarze.Panel1.ResumeLayout(false);
            this.splitLekarze.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitLekarze)).EndInit();
            this.splitLekarze.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLekarze)).EndInit();
            this.cmsLekarze.ResumeLayout(false);
            this.tabWizyty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitWizyty)).EndInit();
            this.splitWizyty.ResumeLayout(false);
            this.tabPacjenci.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPacjenci)).EndInit();
            this.splitPacjenci.ResumeLayout(false);
            this.tabSpecjalnosci.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitSpecjalnosci)).EndInit();
            this.splitSpecjalnosci.ResumeLayout(false);
            this.tabChoroby.ResumeLayout(false);
            this.splitChoroby.Panel1.ResumeLayout(false);
            this.splitChoroby.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitChoroby)).EndInit();
            this.splitChoroby.ResumeLayout(false);
            this.tabLekarstwa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitLekarstwa)).EndInit();
            this.splitLekarstwa.ResumeLayout(false);
            this.tabSwiadczenia.ResumeLayout(false);
            this.splitSwiadczenia.Panel1.ResumeLayout(false);
            this.splitSwiadczenia.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitSwiadczenia)).EndInit();
            this.splitSwiadczenia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSwiadczenia)).EndInit();
            this.gbSwiadczenia.ResumeLayout(false);
            this.gbSwiadczenia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoroby)).EndInit();
            this.gbChoroby.ResumeLayout(false);
            this.gbChoroby.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabLekarze;
        private System.Windows.Forms.TabPage tabWizyty;
        private System.Windows.Forms.TabPage tabPacjenci;
        private System.Windows.Forms.TabPage tabSpecjalnosci;
        private System.Windows.Forms.TabPage tabChoroby;
        private System.Windows.Forms.TabPage tabLekarstwa;
        private System.Windows.Forms.TabPage tabSwiadczenia;
        private System.Windows.Forms.SplitContainer splitLekarze;
        private System.Windows.Forms.SplitContainer splitWizyty;
        private System.Windows.Forms.SplitContainer splitPacjenci;
        private System.Windows.Forms.SplitContainer splitSpecjalnosci;
        private System.Windows.Forms.SplitContainer splitChoroby;
        private System.Windows.Forms.SplitContainer splitLekarstwa;
        private System.Windows.Forms.SplitContainer splitSwiadczenia;
        private System.Windows.Forms.DataGridView dgvLekarze;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn imie;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn miejsce_ur;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_ur;
        private System.Windows.Forms.DataGridViewTextBoxColumn adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn miescje_zam;
        private System.Windows.Forms.DataGridViewTextBoxColumn kod_pocztowy;
        private System.Windows.Forms.ContextMenuStrip cmsLekarze;
        private System.Windows.Forms.ToolStripMenuItem lekarze_szczegoly;
        private System.Windows.Forms.ToolStripMenuItem lekarze_dodaj;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cbNazwisko;
        private System.Windows.Forms.ComboBox cbImie;
        private System.Windows.Forms.DataGridView dgvSwiadczenia;
        private System.Windows.Forms.GroupBox gbSwiadczenia;
        private System.Windows.Forms.TextBox tbSwiadczenia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKoszt;
        private System.Windows.Forms.Button bDodajSwiadczenie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_koszt;
        private System.Windows.Forms.Button bEdytujSwiadczenie;
        private System.Windows.Forms.Button bAnulujSwiadczenie;
        private System.Windows.Forms.DataGridView dgvChoroby;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch_nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch_opis;
        private System.Windows.Forms.GroupBox gbChoroby;
        private System.Windows.Forms.Button bChAnuluj;
        private System.Windows.Forms.Button bChZapisz;
        private System.Windows.Forms.Button bChDodaj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbChOpis;
        private System.Windows.Forms.TextBox tbChoroba;
    }
}

