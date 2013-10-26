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
            this.cmsLekarze = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lekarze_szczegoly = new System.Windows.Forms.ToolStripMenuItem();
            this.lekarze_dodaj = new System.Windows.Forms.ToolStripMenuItem();
            this.tabSpecjalnosci = new System.Windows.Forms.TabPage();
            this.splitSpecjalnosci = new System.Windows.Forms.SplitContainer();
            this.dgvSpecjalnosci = new System.Windows.Forms.DataGridView();
            this.sp_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sp_nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbSpecjalnosci = new System.Windows.Forms.GroupBox();
            this.bSpAnuluj = new System.Windows.Forms.Button();
            this.bSpZapisz = new System.Windows.Forms.Button();
            this.bSpDodaj = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSpecjalnosc = new System.Windows.Forms.TextBox();
            this.tabChoroby = new System.Windows.Forms.TabPage();
            this.splitChoroby = new System.Windows.Forms.SplitContainer();
            this.dgvChoroby = new System.Windows.Forms.DataGridView();
            this.ch_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch_nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch_opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbChoroby = new System.Windows.Forms.GroupBox();
            this.bChAnuluj = new System.Windows.Forms.Button();
            this.bChZapisz = new System.Windows.Forms.Button();
            this.bChDodaj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbChOpis = new System.Windows.Forms.TextBox();
            this.tbChoroba = new System.Windows.Forms.TextBox();
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
            this.tabLekarstwa = new System.Windows.Forms.TabPage();
            this.splitLekarstwa = new System.Windows.Forms.SplitContainer();
            this.dgvLekarstwa = new System.Windows.Forms.DataGridView();
            this.lek_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lek_ulotka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lek_nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lek_cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsLekarstwa = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lekarstwa_ulotka = new System.Windows.Forms.ToolStripMenuItem();
            this.gbLekarstwa = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbLekNiepozadane = new System.Windows.Forms.TextBox();
            this.tbLekDawkowanie = new System.Windows.Forms.TextBox();
            this.tbLekPrzeciwwskazania = new System.Windows.Forms.TextBox();
            this.tbLekPodmiot = new System.Windows.Forms.TextBox();
            this.tbLekZalecenia = new System.Windows.Forms.TextBox();
            this.tbLekOpakowania = new System.Windows.Forms.TextBox();
            this.tbLekSklad = new System.Windows.Forms.TextBox();
            this.bLekAnuluj = new System.Windows.Forms.Button();
            this.bLekZapisz = new System.Windows.Forms.Button();
            this.bLekDodaj = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLekCena = new System.Windows.Forms.TextBox();
            this.tbLekarstwo = new System.Windows.Forms.TextBox();
            this.tabLekarze = new System.Windows.Forms.TabPage();
            this.splitLekarze = new System.Windows.Forms.SplitContainer();
            this.cbLekarzeSpecjalnosci = new System.Windows.Forms.CheckBox();
            this.bLekarzeWyczysc = new System.Windows.Forms.Button();
            this.bLekarzeSzukaj = new System.Windows.Forms.Button();
            this.cbLekarzeSpecjalnosc = new System.Windows.Forms.ComboBox();
            this.cbLekarzeNazwisko = new System.Windows.Forms.ComboBox();
            this.cbLekarzeImie = new System.Windows.Forms.ComboBox();
            this.cbLekarzeWiek = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.cbLekarzeMiasto = new System.Windows.Forms.ComboBox();
            this.dgvLekarze = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specjalnosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miejsce_ur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_ur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kod_pocztowy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miescje_zam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPacjenci = new System.Windows.Forms.TabPage();
            this.splitPacjenci = new System.Windows.Forms.SplitContainer();
            this.bPacjenciWyczysc = new System.Windows.Forms.Button();
            this.bPacjenciSzukaj = new System.Windows.Forms.Button();
            this.cbPacjenciLekarz = new System.Windows.Forms.ComboBox();
            this.cbPacjenciNazwisko = new System.Windows.Forms.ComboBox();
            this.cbPacjenciImie = new System.Windows.Forms.ComboBox();
            this.cbPacjenciWiek = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cbPacjenciMiasto = new System.Windows.Forms.ComboBox();
            this.dgvPacjenci = new System.Windows.Forms.DataGridView();
            this.p_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_imie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_nazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_miejsce_urodzenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_miasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_lekarz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabWizyty = new System.Windows.Forms.TabPage();
            this.splitWizyty = new System.Windows.Forms.SplitContainer();
            this.bWizytyWyczysc = new System.Windows.Forms.Button();
            this.bWizytySzukaj = new System.Windows.Forms.Button();
            this.bWizytyPrzeloz = new System.Windows.Forms.Button();
            this.bWizytyAnuluj = new System.Windows.Forms.Button();
            this.bWizytyDodaj = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.cbWizytyLekarz = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbWizytyWszystkie = new System.Windows.Forms.RadioButton();
            this.rbWizytyOdbyte = new System.Windows.Forms.RadioButton();
            this.rbWizytyNieodbyte = new System.Windows.Forms.RadioButton();
            this.cbWizytyData = new System.Windows.Forms.ComboBox();
            this.dgvWizyty = new System.Windows.Forms.DataGridView();
            this.w_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.w_godzina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.w_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.w_imie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.w_nazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.w_lekarz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.w_odbyta = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.menuStrip.SuspendLayout();
            this.cmsLekarze.SuspendLayout();
            this.tabSpecjalnosci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitSpecjalnosci)).BeginInit();
            this.splitSpecjalnosci.Panel1.SuspendLayout();
            this.splitSpecjalnosci.Panel2.SuspendLayout();
            this.splitSpecjalnosci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecjalnosci)).BeginInit();
            this.gbSpecjalnosci.SuspendLayout();
            this.tabChoroby.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitChoroby)).BeginInit();
            this.splitChoroby.Panel1.SuspendLayout();
            this.splitChoroby.Panel2.SuspendLayout();
            this.splitChoroby.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoroby)).BeginInit();
            this.gbChoroby.SuspendLayout();
            this.tabSwiadczenia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitSwiadczenia)).BeginInit();
            this.splitSwiadczenia.Panel1.SuspendLayout();
            this.splitSwiadczenia.Panel2.SuspendLayout();
            this.splitSwiadczenia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSwiadczenia)).BeginInit();
            this.gbSwiadczenia.SuspendLayout();
            this.tabLekarstwa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitLekarstwa)).BeginInit();
            this.splitLekarstwa.Panel1.SuspendLayout();
            this.splitLekarstwa.Panel2.SuspendLayout();
            this.splitLekarstwa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLekarstwa)).BeginInit();
            this.cmsLekarstwa.SuspendLayout();
            this.gbLekarstwa.SuspendLayout();
            this.tabLekarze.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitLekarze)).BeginInit();
            this.splitLekarze.Panel1.SuspendLayout();
            this.splitLekarze.Panel2.SuspendLayout();
            this.splitLekarze.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLekarze)).BeginInit();
            this.tabPacjenci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPacjenci)).BeginInit();
            this.splitPacjenci.Panel1.SuspendLayout();
            this.splitPacjenci.Panel2.SuspendLayout();
            this.splitPacjenci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacjenci)).BeginInit();
            this.tabWizyty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitWizyty)).BeginInit();
            this.splitWizyty.Panel1.SuspendLayout();
            this.splitWizyty.Panel2.SuspendLayout();
            this.splitWizyty.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWizyty)).BeginInit();
            this.tabControl.SuspendLayout();
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
            // 
            // splitSpecjalnosci.Panel1
            // 
            this.splitSpecjalnosci.Panel1.Controls.Add(this.dgvSpecjalnosci);
            // 
            // splitSpecjalnosci.Panel2
            // 
            this.splitSpecjalnosci.Panel2.Controls.Add(this.gbSpecjalnosci);
            this.splitSpecjalnosci.Size = new System.Drawing.Size(872, 465);
            this.splitSpecjalnosci.SplitterDistance = 594;
            this.splitSpecjalnosci.TabIndex = 0;
            // 
            // dgvSpecjalnosci
            // 
            this.dgvSpecjalnosci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpecjalnosci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sp_id,
            this.sp_nazwa});
            this.dgvSpecjalnosci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSpecjalnosci.Location = new System.Drawing.Point(0, 0);
            this.dgvSpecjalnosci.Name = "dgvSpecjalnosci";
            this.dgvSpecjalnosci.Size = new System.Drawing.Size(594, 465);
            this.dgvSpecjalnosci.TabIndex = 0;
            this.dgvSpecjalnosci.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRow_DoubleClicked);
            // 
            // sp_id
            // 
            this.sp_id.DataPropertyName = "sp_id";
            this.sp_id.HeaderText = "";
            this.sp_id.Name = "sp_id";
            this.sp_id.Visible = false;
            // 
            // sp_nazwa
            // 
            this.sp_nazwa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sp_nazwa.DataPropertyName = "sp_nazwa";
            this.sp_nazwa.HeaderText = "Nazwa specjalności";
            this.sp_nazwa.Name = "sp_nazwa";
            // 
            // gbSpecjalnosci
            // 
            this.gbSpecjalnosci.Controls.Add(this.bSpAnuluj);
            this.gbSpecjalnosci.Controls.Add(this.bSpZapisz);
            this.gbSpecjalnosci.Controls.Add(this.bSpDodaj);
            this.gbSpecjalnosci.Controls.Add(this.label4);
            this.gbSpecjalnosci.Controls.Add(this.tbSpecjalnosc);
            this.gbSpecjalnosci.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSpecjalnosci.Location = new System.Drawing.Point(0, 0);
            this.gbSpecjalnosci.Name = "gbSpecjalnosci";
            this.gbSpecjalnosci.Size = new System.Drawing.Size(274, 149);
            this.gbSpecjalnosci.TabIndex = 0;
            this.gbSpecjalnosci.TabStop = false;
            this.gbSpecjalnosci.Text = "Dodaj specjalność";
            // 
            // bSpAnuluj
            // 
            this.bSpAnuluj.Location = new System.Drawing.Point(160, 102);
            this.bSpAnuluj.Name = "bSpAnuluj";
            this.bSpAnuluj.Size = new System.Drawing.Size(89, 23);
            this.bSpAnuluj.TabIndex = 11;
            this.bSpAnuluj.Text = "Anuluj";
            this.bSpAnuluj.UseVisualStyleBackColor = true;
            this.bSpAnuluj.Visible = false;
            this.bSpAnuluj.Click += new System.EventHandler(this.bSpAnuluj_Click);
            // 
            // bSpZapisz
            // 
            this.bSpZapisz.Location = new System.Drawing.Point(65, 73);
            this.bSpZapisz.Name = "bSpZapisz";
            this.bSpZapisz.Size = new System.Drawing.Size(89, 23);
            this.bSpZapisz.TabIndex = 10;
            this.bSpZapisz.Text = "Zapisz";
            this.bSpZapisz.UseVisualStyleBackColor = true;
            this.bSpZapisz.Visible = false;
            this.bSpZapisz.VisibleChanged += new System.EventHandler(this.VisibleChanged);
            this.bSpZapisz.Click += new System.EventHandler(this.bSpZapisz_Click);
            // 
            // bSpDodaj
            // 
            this.bSpDodaj.Location = new System.Drawing.Point(160, 73);
            this.bSpDodaj.Name = "bSpDodaj";
            this.bSpDodaj.Size = new System.Drawing.Size(89, 23);
            this.bSpDodaj.TabIndex = 9;
            this.bSpDodaj.Text = "Dodaj";
            this.bSpDodaj.UseVisualStyleBackColor = true;
            this.bSpDodaj.Click += new System.EventHandler(this.bSpDodaj_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nazwa";
            // 
            // tbSpecjalnosc
            // 
            this.tbSpecjalnosc.Location = new System.Drawing.Point(96, 39);
            this.tbSpecjalnosc.Name = "tbSpecjalnosc";
            this.tbSpecjalnosc.Size = new System.Drawing.Size(153, 20);
            this.tbSpecjalnosc.TabIndex = 6;
            this.tbSpecjalnosc.TextChanged += new System.EventHandler(this.SprawdzFormat_Tekst);
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
            // dgvChoroby
            // 
            this.dgvChoroby.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChoroby.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ch_id,
            this.ch_nazwa,
            this.ch_opis});
            this.dgvChoroby.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChoroby.Location = new System.Drawing.Point(0, 0);
            this.dgvChoroby.MultiSelect = false;
            this.dgvChoroby.Name = "dgvChoroby";
            this.dgvChoroby.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            // bChAnuluj
            // 
            this.bChAnuluj.Location = new System.Drawing.Point(165, 207);
            this.bChAnuluj.Name = "bChAnuluj";
            this.bChAnuluj.Size = new System.Drawing.Size(89, 23);
            this.bChAnuluj.TabIndex = 5;
            this.bChAnuluj.Text = "Anuluj";
            this.bChAnuluj.UseVisualStyleBackColor = true;
            this.bChAnuluj.Visible = false;
            this.bChAnuluj.Click += new System.EventHandler(this.bChAnuluj_Click);
            // 
            // bChZapisz
            // 
            this.bChZapisz.Location = new System.Drawing.Point(70, 178);
            this.bChZapisz.Name = "bChZapisz";
            this.bChZapisz.Size = new System.Drawing.Size(89, 23);
            this.bChZapisz.TabIndex = 4;
            this.bChZapisz.Text = "Zapisz";
            this.bChZapisz.UseVisualStyleBackColor = true;
            this.bChZapisz.Visible = false;
            this.bChZapisz.VisibleChanged += new System.EventHandler(this.VisibleChanged);
            this.bChZapisz.Click += new System.EventHandler(this.bChZapisz_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nazwa";
            // 
            // tbChOpis
            // 
            this.tbChOpis.Location = new System.Drawing.Point(32, 75);
            this.tbChOpis.Multiline = true;
            this.tbChOpis.Name = "tbChOpis";
            this.tbChOpis.Size = new System.Drawing.Size(222, 97);
            this.tbChOpis.TabIndex = 1;
            // 
            // tbChoroba
            // 
            this.tbChoroba.Location = new System.Drawing.Point(101, 49);
            this.tbChoroba.Name = "tbChoroba";
            this.tbChoroba.Size = new System.Drawing.Size(153, 20);
            this.tbChoroba.TabIndex = 0;
            this.tbChoroba.TextChanged += new System.EventHandler(this.SprawdzFormat_Tekst);
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
            this.bEdytujSwiadczenie.VisibleChanged += new System.EventHandler(this.VisibleChanged);
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
            this.tbKoszt.TextChanged += new System.EventHandler(this.SprawdzFormat_Tekst);
            // 
            // tbSwiadczenia
            // 
            this.tbSwiadczenia.Location = new System.Drawing.Point(79, 53);
            this.tbSwiadczenia.Name = "tbSwiadczenia";
            this.tbSwiadczenia.Size = new System.Drawing.Size(159, 20);
            this.tbSwiadczenia.TabIndex = 0;
            this.tbSwiadczenia.TextChanged += new System.EventHandler(this.SprawdzFormat_Tekst);
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
            // 
            // splitLekarstwa.Panel1
            // 
            this.splitLekarstwa.Panel1.Controls.Add(this.dgvLekarstwa);
            // 
            // splitLekarstwa.Panel2
            // 
            this.splitLekarstwa.Panel2.Controls.Add(this.gbLekarstwa);
            this.splitLekarstwa.Size = new System.Drawing.Size(872, 465);
            this.splitLekarstwa.SplitterDistance = 499;
            this.splitLekarstwa.TabIndex = 0;
            // 
            // dgvLekarstwa
            // 
            this.dgvLekarstwa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLekarstwa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lek_id,
            this.lek_ulotka,
            this.lek_nazwa,
            this.lek_cena});
            this.dgvLekarstwa.ContextMenuStrip = this.cmsLekarstwa;
            this.dgvLekarstwa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLekarstwa.Location = new System.Drawing.Point(0, 0);
            this.dgvLekarstwa.MultiSelect = false;
            this.dgvLekarstwa.Name = "dgvLekarstwa";
            this.dgvLekarstwa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLekarstwa.Size = new System.Drawing.Size(499, 465);
            this.dgvLekarstwa.TabIndex = 0;
            this.dgvLekarstwa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRow_DoubleClicked);
            this.dgvLekarstwa.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseDown);
            // 
            // lek_id
            // 
            this.lek_id.DataPropertyName = "lek_id";
            this.lek_id.HeaderText = "id";
            this.lek_id.Name = "lek_id";
            this.lek_id.Visible = false;
            // 
            // lek_ulotka
            // 
            this.lek_ulotka.DataPropertyName = "lek_ulotka";
            this.lek_ulotka.HeaderText = "ulotka";
            this.lek_ulotka.Name = "lek_ulotka";
            this.lek_ulotka.Visible = false;
            // 
            // lek_nazwa
            // 
            this.lek_nazwa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lek_nazwa.DataPropertyName = "lek_nazwa";
            this.lek_nazwa.HeaderText = "Nazwa leku";
            this.lek_nazwa.Name = "lek_nazwa";
            // 
            // lek_cena
            // 
            this.lek_cena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lek_cena.DataPropertyName = "lek_cena";
            this.lek_cena.HeaderText = "Cena";
            this.lek_cena.Name = "lek_cena";
            // 
            // cmsLekarstwa
            // 
            this.cmsLekarstwa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lekarstwa_ulotka});
            this.cmsLekarstwa.Name = "cmsLekarstwa";
            this.cmsLekarstwa.Size = new System.Drawing.Size(158, 26);
            this.cmsLekarstwa.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsLekarstwa_ItemClicked);
            // 
            // lekarstwa_ulotka
            // 
            this.lekarstwa_ulotka.Name = "lekarstwa_ulotka";
            this.lekarstwa_ulotka.Size = new System.Drawing.Size(157, 22);
            this.lekarstwa_ulotka.Text = "Wyświetl ulotkę";
            // 
            // gbLekarstwa
            // 
            this.gbLekarstwa.Controls.Add(this.label13);
            this.gbLekarstwa.Controls.Add(this.label12);
            this.gbLekarstwa.Controls.Add(this.label11);
            this.gbLekarstwa.Controls.Add(this.label10);
            this.gbLekarstwa.Controls.Add(this.label9);
            this.gbLekarstwa.Controls.Add(this.label8);
            this.gbLekarstwa.Controls.Add(this.label7);
            this.gbLekarstwa.Controls.Add(this.tbLekNiepozadane);
            this.gbLekarstwa.Controls.Add(this.tbLekDawkowanie);
            this.gbLekarstwa.Controls.Add(this.tbLekPrzeciwwskazania);
            this.gbLekarstwa.Controls.Add(this.tbLekPodmiot);
            this.gbLekarstwa.Controls.Add(this.tbLekZalecenia);
            this.gbLekarstwa.Controls.Add(this.tbLekOpakowania);
            this.gbLekarstwa.Controls.Add(this.tbLekSklad);
            this.gbLekarstwa.Controls.Add(this.bLekAnuluj);
            this.gbLekarstwa.Controls.Add(this.bLekZapisz);
            this.gbLekarstwa.Controls.Add(this.bLekDodaj);
            this.gbLekarstwa.Controls.Add(this.label6);
            this.gbLekarstwa.Controls.Add(this.label5);
            this.gbLekarstwa.Controls.Add(this.tbLekCena);
            this.gbLekarstwa.Controls.Add(this.tbLekarstwo);
            this.gbLekarstwa.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbLekarstwa.Location = new System.Drawing.Point(0, 0);
            this.gbLekarstwa.Name = "gbLekarstwa";
            this.gbLekarstwa.Size = new System.Drawing.Size(369, 418);
            this.gbLekarstwa.TabIndex = 1;
            this.gbLekarstwa.TabStop = false;
            this.gbLekarstwa.Text = "Dodaj lekarstwo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 310);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Działania niepożądane";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(62, 272);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Dawkowanie";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Przeciwwskazania";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(79, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Zalecenia";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(95, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Skład";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Wielkość opakowań";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Podmiot odpowiedzialny";
            // 
            // tbLekNiepozadane
            // 
            this.tbLekNiepozadane.Location = new System.Drawing.Point(146, 307);
            this.tbLekNiepozadane.Multiline = true;
            this.tbLekNiepozadane.Name = "tbLekNiepozadane";
            this.tbLekNiepozadane.Size = new System.Drawing.Size(202, 32);
            this.tbLekNiepozadane.TabIndex = 14;
            // 
            // tbLekDawkowanie
            // 
            this.tbLekDawkowanie.Location = new System.Drawing.Point(146, 269);
            this.tbLekDawkowanie.Multiline = true;
            this.tbLekDawkowanie.Name = "tbLekDawkowanie";
            this.tbLekDawkowanie.Size = new System.Drawing.Size(202, 32);
            this.tbLekDawkowanie.TabIndex = 12;
            // 
            // tbLekPrzeciwwskazania
            // 
            this.tbLekPrzeciwwskazania.Location = new System.Drawing.Point(146, 231);
            this.tbLekPrzeciwwskazania.Multiline = true;
            this.tbLekPrzeciwwskazania.Name = "tbLekPrzeciwwskazania";
            this.tbLekPrzeciwwskazania.Size = new System.Drawing.Size(202, 32);
            this.tbLekPrzeciwwskazania.TabIndex = 11;
            // 
            // tbLekPodmiot
            // 
            this.tbLekPodmiot.Location = new System.Drawing.Point(146, 91);
            this.tbLekPodmiot.Name = "tbLekPodmiot";
            this.tbLekPodmiot.Size = new System.Drawing.Size(202, 20);
            this.tbLekPodmiot.TabIndex = 10;
            // 
            // tbLekZalecenia
            // 
            this.tbLekZalecenia.Location = new System.Drawing.Point(146, 193);
            this.tbLekZalecenia.Multiline = true;
            this.tbLekZalecenia.Name = "tbLekZalecenia";
            this.tbLekZalecenia.Size = new System.Drawing.Size(202, 32);
            this.tbLekZalecenia.TabIndex = 9;
            // 
            // tbLekOpakowania
            // 
            this.tbLekOpakowania.Location = new System.Drawing.Point(146, 155);
            this.tbLekOpakowania.Multiline = true;
            this.tbLekOpakowania.Name = "tbLekOpakowania";
            this.tbLekOpakowania.Size = new System.Drawing.Size(202, 32);
            this.tbLekOpakowania.TabIndex = 8;
            // 
            // tbLekSklad
            // 
            this.tbLekSklad.Location = new System.Drawing.Point(146, 117);
            this.tbLekSklad.Multiline = true;
            this.tbLekSklad.Name = "tbLekSklad";
            this.tbLekSklad.Size = new System.Drawing.Size(202, 32);
            this.tbLekSklad.TabIndex = 7;
            // 
            // bLekAnuluj
            // 
            this.bLekAnuluj.Location = new System.Drawing.Point(273, 378);
            this.bLekAnuluj.Name = "bLekAnuluj";
            this.bLekAnuluj.Size = new System.Drawing.Size(75, 23);
            this.bLekAnuluj.TabIndex = 6;
            this.bLekAnuluj.Text = "Anuluj";
            this.bLekAnuluj.UseVisualStyleBackColor = true;
            this.bLekAnuluj.Visible = false;
            this.bLekAnuluj.Click += new System.EventHandler(this.bLekAnuluj_Click);
            // 
            // bLekZapisz
            // 
            this.bLekZapisz.Location = new System.Drawing.Point(183, 350);
            this.bLekZapisz.Name = "bLekZapisz";
            this.bLekZapisz.Size = new System.Drawing.Size(75, 23);
            this.bLekZapisz.TabIndex = 5;
            this.bLekZapisz.Text = "Zapisz";
            this.bLekZapisz.UseVisualStyleBackColor = true;
            this.bLekZapisz.Visible = false;
            this.bLekZapisz.VisibleChanged += new System.EventHandler(this.VisibleChanged);
            this.bLekZapisz.Click += new System.EventHandler(this.bLekZapisz_Click);
            // 
            // bLekDodaj
            // 
            this.bLekDodaj.Location = new System.Drawing.Point(273, 350);
            this.bLekDodaj.Name = "bLekDodaj";
            this.bLekDodaj.Size = new System.Drawing.Size(75, 23);
            this.bLekDodaj.TabIndex = 4;
            this.bLekDodaj.Text = "Dodaj";
            this.bLekDodaj.UseVisualStyleBackColor = true;
            this.bLekDodaj.Click += new System.EventHandler(this.bLekDodaj_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Cena";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nazwa";
            // 
            // tbLekCena
            // 
            this.tbLekCena.Location = new System.Drawing.Point(146, 60);
            this.tbLekCena.Name = "tbLekCena";
            this.tbLekCena.Size = new System.Drawing.Size(202, 20);
            this.tbLekCena.TabIndex = 1;
            this.tbLekCena.TextChanged += new System.EventHandler(this.SprawdzFormat_Tekst);
            // 
            // tbLekarstwo
            // 
            this.tbLekarstwo.Location = new System.Drawing.Point(146, 34);
            this.tbLekarstwo.Name = "tbLekarstwo";
            this.tbLekarstwo.Size = new System.Drawing.Size(202, 20);
            this.tbLekarstwo.TabIndex = 0;
            this.tbLekarstwo.TextChanged += new System.EventHandler(this.SprawdzFormat_Tekst);
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
            this.splitLekarze.Panel1.Controls.Add(this.cbLekarzeSpecjalnosci);
            this.splitLekarze.Panel1.Controls.Add(this.bLekarzeWyczysc);
            this.splitLekarze.Panel1.Controls.Add(this.bLekarzeSzukaj);
            this.splitLekarze.Panel1.Controls.Add(this.cbLekarzeSpecjalnosc);
            this.splitLekarze.Panel1.Controls.Add(this.cbLekarzeNazwisko);
            this.splitLekarze.Panel1.Controls.Add(this.cbLekarzeImie);
            this.splitLekarze.Panel1.Controls.Add(this.cbLekarzeWiek);
            this.splitLekarze.Panel1.Controls.Add(this.label18);
            this.splitLekarze.Panel1.Controls.Add(this.label17);
            this.splitLekarze.Panel1.Controls.Add(this.label16);
            this.splitLekarze.Panel1.Controls.Add(this.label30);
            this.splitLekarze.Panel1.Controls.Add(this.label);
            this.splitLekarze.Panel1.Controls.Add(this.cbLekarzeMiasto);
            // 
            // splitLekarze.Panel2
            // 
            this.splitLekarze.Panel2.Controls.Add(this.dgvLekarze);
            this.splitLekarze.Size = new System.Drawing.Size(872, 465);
            this.splitLekarze.SplitterDistance = 82;
            this.splitLekarze.TabIndex = 0;
            // 
            // cbLekarzeSpecjalnosci
            // 
            this.cbLekarzeSpecjalnosci.AutoSize = true;
            this.cbLekarzeSpecjalnosci.Location = new System.Drawing.Point(532, 48);
            this.cbLekarzeSpecjalnosci.Name = "cbLekarzeSpecjalnosci";
            this.cbLekarzeSpecjalnosci.Size = new System.Drawing.Size(125, 17);
            this.cbLekarzeSpecjalnosci.TabIndex = 22;
            this.cbLekarzeSpecjalnosci.Text = "Pokazuj specjalności";
            this.cbLekarzeSpecjalnosci.UseVisualStyleBackColor = true;
            this.cbLekarzeSpecjalnosci.CheckedChanged += new System.EventHandler(this.cbLekarzeSpecjalnosci_CheckedChanged);
            // 
            // bLekarzeWyczysc
            // 
            this.bLekarzeWyczysc.Location = new System.Drawing.Point(782, 44);
            this.bLekarzeWyczysc.Name = "bLekarzeWyczysc";
            this.bLekarzeWyczysc.Size = new System.Drawing.Size(75, 29);
            this.bLekarzeWyczysc.TabIndex = 8;
            this.bLekarzeWyczysc.Text = "Wyczyść";
            this.bLekarzeWyczysc.UseVisualStyleBackColor = true;
            this.bLekarzeWyczysc.Click += new System.EventHandler(this.bLekarzeWyczysc_Click);
            // 
            // bLekarzeSzukaj
            // 
            this.bLekarzeSzukaj.Location = new System.Drawing.Point(782, 9);
            this.bLekarzeSzukaj.Name = "bLekarzeSzukaj";
            this.bLekarzeSzukaj.Size = new System.Drawing.Size(75, 29);
            this.bLekarzeSzukaj.TabIndex = 6;
            this.bLekarzeSzukaj.Text = "Szukaj";
            this.bLekarzeSzukaj.UseVisualStyleBackColor = true;
            this.bLekarzeSzukaj.Click += new System.EventHandler(this.bLekarzeSzukaj_Click);
            // 
            // cbLekarzeSpecjalnosc
            // 
            this.cbLekarzeSpecjalnosc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbLekarzeSpecjalnosc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbLekarzeSpecjalnosc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLekarzeSpecjalnosc.FormattingEnabled = true;
            this.cbLekarzeSpecjalnosc.Items.AddRange(new object[] {
            "Dowolna"});
            this.cbLekarzeSpecjalnosc.Location = new System.Drawing.Point(536, 15);
            this.cbLekarzeSpecjalnosc.Name = "cbLekarzeSpecjalnosc";
            this.cbLekarzeSpecjalnosc.Size = new System.Drawing.Size(121, 21);
            this.cbLekarzeSpecjalnosc.TabIndex = 5;
            // 
            // cbLekarzeNazwisko
            // 
            this.cbLekarzeNazwisko.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbLekarzeNazwisko.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbLekarzeNazwisko.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLekarzeNazwisko.FormattingEnabled = true;
            this.cbLekarzeNazwisko.Items.AddRange(new object[] {
            "Dowolne"});
            this.cbLekarzeNazwisko.Location = new System.Drawing.Point(97, 44);
            this.cbLekarzeNazwisko.Name = "cbLekarzeNazwisko";
            this.cbLekarzeNazwisko.Size = new System.Drawing.Size(121, 21);
            this.cbLekarzeNazwisko.TabIndex = 2;
            // 
            // cbLekarzeImie
            // 
            this.cbLekarzeImie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbLekarzeImie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbLekarzeImie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLekarzeImie.FormattingEnabled = true;
            this.cbLekarzeImie.Items.AddRange(new object[] {
            "Dowolne"});
            this.cbLekarzeImie.Location = new System.Drawing.Point(97, 15);
            this.cbLekarzeImie.Name = "cbLekarzeImie";
            this.cbLekarzeImie.Size = new System.Drawing.Size(121, 21);
            this.cbLekarzeImie.TabIndex = 1;
            // 
            // cbLekarzeWiek
            // 
            this.cbLekarzeWiek.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbLekarzeWiek.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbLekarzeWiek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLekarzeWiek.FormattingEnabled = true;
            this.cbLekarzeWiek.Items.AddRange(new object[] {
            "Dowolny"});
            this.cbLekarzeWiek.Location = new System.Drawing.Point(305, 44);
            this.cbLekarzeWiek.Name = "cbLekarzeWiek";
            this.cbLekarzeWiek.Size = new System.Drawing.Size(121, 21);
            this.cbLekarzeWiek.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(465, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "Specjalność";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(267, 47);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "Wiek";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(261, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Miasto";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.White;
            this.label30.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label30.Location = new System.Drawing.Point(38, 47);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(53, 13);
            this.label30.TabIndex = 4;
            this.label30.Text = "Nazwisko";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(65, 18);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(26, 13);
            this.label.TabIndex = 3;
            this.label.Text = "Imię";
            // 
            // cbLekarzeMiasto
            // 
            this.cbLekarzeMiasto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbLekarzeMiasto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbLekarzeMiasto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLekarzeMiasto.FormattingEnabled = true;
            this.cbLekarzeMiasto.Items.AddRange(new object[] {
            "Dowolne"});
            this.cbLekarzeMiasto.Location = new System.Drawing.Point(305, 15);
            this.cbLekarzeMiasto.Name = "cbLekarzeMiasto";
            this.cbLekarzeMiasto.Size = new System.Drawing.Size(121, 21);
            this.cbLekarzeMiasto.TabIndex = 3;
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
            this.specjalnosc,
            this.miejsce_ur,
            this.data_ur,
            this.adres,
            this.kod_pocztowy,
            this.miescje_zam});
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
            // specjalnosc
            // 
            this.specjalnosc.DataPropertyName = "specjalnosc";
            this.specjalnosc.HeaderText = "Specjalność";
            this.specjalnosc.Name = "specjalnosc";
            this.specjalnosc.ReadOnly = true;
            this.specjalnosc.Visible = false;
            // 
            // miejsce_ur
            // 
            this.miejsce_ur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.miejsce_ur.DataPropertyName = "miejsce_ur";
            this.miejsce_ur.HeaderText = "Miejsce urodzenia";
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
            // kod_pocztowy
            // 
            this.kod_pocztowy.DataPropertyName = "kod_pocztowy";
            this.kod_pocztowy.HeaderText = "Kod Pocztowy";
            this.kod_pocztowy.Name = "kod_pocztowy";
            this.kod_pocztowy.ReadOnly = true;
            // 
            // miescje_zam
            // 
            this.miescje_zam.DataPropertyName = "miescje_zam";
            this.miescje_zam.HeaderText = "Miasto";
            this.miescje_zam.Name = "miescje_zam";
            this.miescje_zam.ReadOnly = true;
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
            this.splitPacjenci.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitPacjenci.Panel1
            // 
            this.splitPacjenci.Panel1.Controls.Add(this.bPacjenciWyczysc);
            this.splitPacjenci.Panel1.Controls.Add(this.bPacjenciSzukaj);
            this.splitPacjenci.Panel1.Controls.Add(this.cbPacjenciLekarz);
            this.splitPacjenci.Panel1.Controls.Add(this.cbPacjenciNazwisko);
            this.splitPacjenci.Panel1.Controls.Add(this.cbPacjenciImie);
            this.splitPacjenci.Panel1.Controls.Add(this.cbPacjenciWiek);
            this.splitPacjenci.Panel1.Controls.Add(this.label14);
            this.splitPacjenci.Panel1.Controls.Add(this.label15);
            this.splitPacjenci.Panel1.Controls.Add(this.label19);
            this.splitPacjenci.Panel1.Controls.Add(this.label20);
            this.splitPacjenci.Panel1.Controls.Add(this.label21);
            this.splitPacjenci.Panel1.Controls.Add(this.cbPacjenciMiasto);
            // 
            // splitPacjenci.Panel2
            // 
            this.splitPacjenci.Panel2.Controls.Add(this.dgvPacjenci);
            this.splitPacjenci.Size = new System.Drawing.Size(872, 465);
            this.splitPacjenci.SplitterDistance = 102;
            this.splitPacjenci.TabIndex = 0;
            // 
            // bPacjenciWyczysc
            // 
            this.bPacjenciWyczysc.Location = new System.Drawing.Point(771, 54);
            this.bPacjenciWyczysc.Name = "bPacjenciWyczysc";
            this.bPacjenciWyczysc.Size = new System.Drawing.Size(75, 29);
            this.bPacjenciWyczysc.TabIndex = 20;
            this.bPacjenciWyczysc.Text = "Wyczyść";
            this.bPacjenciWyczysc.UseVisualStyleBackColor = true;
            this.bPacjenciWyczysc.Click += new System.EventHandler(this.bPacjenciWyczysc_Click);
            // 
            // bPacjenciSzukaj
            // 
            this.bPacjenciSzukaj.Location = new System.Drawing.Point(771, 19);
            this.bPacjenciSzukaj.Name = "bPacjenciSzukaj";
            this.bPacjenciSzukaj.Size = new System.Drawing.Size(75, 29);
            this.bPacjenciSzukaj.TabIndex = 17;
            this.bPacjenciSzukaj.Text = "Szukaj";
            this.bPacjenciSzukaj.UseVisualStyleBackColor = true;
            this.bPacjenciSzukaj.Click += new System.EventHandler(this.bPacjenciSzukaj_Click);
            // 
            // cbPacjenciLekarz
            // 
            this.cbPacjenciLekarz.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbPacjenciLekarz.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPacjenciLekarz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPacjenciLekarz.FormattingEnabled = true;
            this.cbPacjenciLekarz.Items.AddRange(new object[] {
            "Dowolny"});
            this.cbPacjenciLekarz.Location = new System.Drawing.Point(499, 24);
            this.cbPacjenciLekarz.Name = "cbPacjenciLekarz";
            this.cbPacjenciLekarz.Size = new System.Drawing.Size(180, 21);
            this.cbPacjenciLekarz.TabIndex = 15;
            // 
            // cbPacjenciNazwisko
            // 
            this.cbPacjenciNazwisko.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbPacjenciNazwisko.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPacjenciNazwisko.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPacjenciNazwisko.FormattingEnabled = true;
            this.cbPacjenciNazwisko.Items.AddRange(new object[] {
            "Dowolne"});
            this.cbPacjenciNazwisko.Location = new System.Drawing.Point(86, 54);
            this.cbPacjenciNazwisko.Name = "cbPacjenciNazwisko";
            this.cbPacjenciNazwisko.Size = new System.Drawing.Size(121, 21);
            this.cbPacjenciNazwisko.TabIndex = 10;
            // 
            // cbPacjenciImie
            // 
            this.cbPacjenciImie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbPacjenciImie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPacjenciImie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPacjenciImie.FormattingEnabled = true;
            this.cbPacjenciImie.Items.AddRange(new object[] {
            "Dowolne"});
            this.cbPacjenciImie.Location = new System.Drawing.Point(86, 25);
            this.cbPacjenciImie.Name = "cbPacjenciImie";
            this.cbPacjenciImie.Size = new System.Drawing.Size(121, 21);
            this.cbPacjenciImie.TabIndex = 9;
            // 
            // cbPacjenciWiek
            // 
            this.cbPacjenciWiek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPacjenciWiek.FormattingEnabled = true;
            this.cbPacjenciWiek.Items.AddRange(new object[] {
            "Dowolny"});
            this.cbPacjenciWiek.Location = new System.Drawing.Point(294, 54);
            this.cbPacjenciWiek.Name = "cbPacjenciWiek";
            this.cbPacjenciWiek.Size = new System.Drawing.Size(121, 21);
            this.cbPacjenciWiek.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(454, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Lekarz";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(256, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Wiek";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(250, 28);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 13);
            this.label19.TabIndex = 16;
            this.label19.Text = "Miasto";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label20.Location = new System.Drawing.Point(27, 57);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 13);
            this.label20.TabIndex = 14;
            this.label20.Text = "Nazwisko";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(54, 28);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(26, 13);
            this.label21.TabIndex = 11;
            this.label21.Text = "Imię";
            // 
            // cbPacjenciMiasto
            // 
            this.cbPacjenciMiasto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbPacjenciMiasto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPacjenciMiasto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPacjenciMiasto.FormattingEnabled = true;
            this.cbPacjenciMiasto.Items.AddRange(new object[] {
            "Dowolne"});
            this.cbPacjenciMiasto.Location = new System.Drawing.Point(294, 25);
            this.cbPacjenciMiasto.Name = "cbPacjenciMiasto";
            this.cbPacjenciMiasto.Size = new System.Drawing.Size(121, 21);
            this.cbPacjenciMiasto.TabIndex = 12;
            // 
            // dgvPacjenci
            // 
            this.dgvPacjenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacjenci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.p_id,
            this.p_imie,
            this.p_nazwisko,
            this.p_miejsce_urodzenia,
            this.p_data,
            this.p_adres,
            this.p_miasto,
            this.p_kod,
            this.p_lekarz});
            this.dgvPacjenci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPacjenci.Location = new System.Drawing.Point(0, 0);
            this.dgvPacjenci.Name = "dgvPacjenci";
            this.dgvPacjenci.Size = new System.Drawing.Size(872, 359);
            this.dgvPacjenci.TabIndex = 0;
            // 
            // p_id
            // 
            this.p_id.DataPropertyName = "p_id";
            this.p_id.HeaderText = "id";
            this.p_id.Name = "p_id";
            this.p_id.Visible = false;
            // 
            // p_imie
            // 
            this.p_imie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.p_imie.DataPropertyName = "p_imie";
            this.p_imie.HeaderText = "Imię";
            this.p_imie.Name = "p_imie";
            // 
            // p_nazwisko
            // 
            this.p_nazwisko.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.p_nazwisko.DataPropertyName = "p_nazwisko";
            this.p_nazwisko.HeaderText = "Nazwisko";
            this.p_nazwisko.Name = "p_nazwisko";
            // 
            // p_miejsce_urodzenia
            // 
            this.p_miejsce_urodzenia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.p_miejsce_urodzenia.DataPropertyName = "p_miejsce_urodzenia";
            this.p_miejsce_urodzenia.HeaderText = "Miejsce urodzenia";
            this.p_miejsce_urodzenia.Name = "p_miejsce_urodzenia";
            // 
            // p_data
            // 
            this.p_data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.p_data.DataPropertyName = "p_data";
            this.p_data.HeaderText = "Data urodzenia";
            this.p_data.Name = "p_data";
            // 
            // p_adres
            // 
            this.p_adres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.p_adres.DataPropertyName = "p_adres";
            this.p_adres.HeaderText = "Adres";
            this.p_adres.Name = "p_adres";
            // 
            // p_miasto
            // 
            this.p_miasto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.p_miasto.DataPropertyName = "p_miasto";
            this.p_miasto.HeaderText = "Miasto";
            this.p_miasto.Name = "p_miasto";
            // 
            // p_kod
            // 
            this.p_kod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.p_kod.DataPropertyName = "p_kod";
            this.p_kod.HeaderText = "Kod pocztowy";
            this.p_kod.Name = "p_kod";
            // 
            // p_lekarz
            // 
            this.p_lekarz.DataPropertyName = "p_lekarz";
            this.p_lekarz.HeaderText = "Lekarz";
            this.p_lekarz.Name = "p_lekarz";
            this.p_lekarz.Visible = false;
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
            this.splitWizyty.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitWizyty.Panel1
            // 
            this.splitWizyty.Panel1.Controls.Add(this.bWizytyWyczysc);
            this.splitWizyty.Panel1.Controls.Add(this.bWizytySzukaj);
            this.splitWizyty.Panel1.Controls.Add(this.bWizytyPrzeloz);
            this.splitWizyty.Panel1.Controls.Add(this.bWizytyAnuluj);
            this.splitWizyty.Panel1.Controls.Add(this.bWizytyDodaj);
            this.splitWizyty.Panel1.Controls.Add(this.label23);
            this.splitWizyty.Panel1.Controls.Add(this.cbWizytyLekarz);
            this.splitWizyty.Panel1.Controls.Add(this.label22);
            this.splitWizyty.Panel1.Controls.Add(this.groupBox1);
            this.splitWizyty.Panel1.Controls.Add(this.cbWizytyData);
            // 
            // splitWizyty.Panel2
            // 
            this.splitWizyty.Panel2.Controls.Add(this.dgvWizyty);
            this.splitWizyty.Size = new System.Drawing.Size(872, 465);
            this.splitWizyty.SplitterDistance = 147;
            this.splitWizyty.TabIndex = 0;
            // 
            // bWizytyWyczysc
            // 
            this.bWizytyWyczysc.Location = new System.Drawing.Point(466, 78);
            this.bWizytyWyczysc.Name = "bWizytyWyczysc";
            this.bWizytyWyczysc.Size = new System.Drawing.Size(75, 23);
            this.bWizytyWyczysc.TabIndex = 9;
            this.bWizytyWyczysc.Text = "Wyczyść";
            this.bWizytyWyczysc.UseVisualStyleBackColor = true;
            this.bWizytyWyczysc.Click += new System.EventHandler(this.bWizytyWyczysc_Click);
            // 
            // bWizytySzukaj
            // 
            this.bWizytySzukaj.Location = new System.Drawing.Point(466, 48);
            this.bWizytySzukaj.Name = "bWizytySzukaj";
            this.bWizytySzukaj.Size = new System.Drawing.Size(75, 23);
            this.bWizytySzukaj.TabIndex = 8;
            this.bWizytySzukaj.Text = "Szukaj";
            this.bWizytySzukaj.UseVisualStyleBackColor = true;
            this.bWizytySzukaj.Click += new System.EventHandler(this.bWizytySzukaj_Click);
            // 
            // bWizytyPrzeloz
            // 
            this.bWizytyPrzeloz.Location = new System.Drawing.Point(731, 48);
            this.bWizytyPrzeloz.Name = "bWizytyPrzeloz";
            this.bWizytyPrzeloz.Size = new System.Drawing.Size(75, 41);
            this.bWizytyPrzeloz.TabIndex = 7;
            this.bWizytyPrzeloz.Text = "Przełóż";
            this.bWizytyPrzeloz.UseVisualStyleBackColor = true;
            // 
            // bWizytyAnuluj
            // 
            this.bWizytyAnuluj.Location = new System.Drawing.Point(731, 94);
            this.bWizytyAnuluj.Name = "bWizytyAnuluj";
            this.bWizytyAnuluj.Size = new System.Drawing.Size(75, 41);
            this.bWizytyAnuluj.TabIndex = 6;
            this.bWizytyAnuluj.Text = "Anuluj";
            this.bWizytyAnuluj.UseVisualStyleBackColor = true;
            // 
            // bWizytyDodaj
            // 
            this.bWizytyDodaj.Location = new System.Drawing.Point(731, 0);
            this.bWizytyDodaj.Name = "bWizytyDodaj";
            this.bWizytyDodaj.Size = new System.Drawing.Size(75, 41);
            this.bWizytyDodaj.TabIndex = 5;
            this.bWizytyDodaj.Text = "Dodaj";
            this.bWizytyDodaj.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(28, 69);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(39, 13);
            this.label23.TabIndex = 4;
            this.label23.Text = "Lekarz";
            // 
            // cbWizytyLekarz
            // 
            this.cbWizytyLekarz.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbWizytyLekarz.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbWizytyLekarz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWizytyLekarz.FormattingEnabled = true;
            this.cbWizytyLekarz.Items.AddRange(new object[] {
            "Dowolny"});
            this.cbWizytyLekarz.Location = new System.Drawing.Point(73, 66);
            this.cbWizytyLekarz.Name = "cbWizytyLekarz";
            this.cbWizytyLekarz.Size = new System.Drawing.Size(121, 21);
            this.cbWizytyLekarz.TabIndex = 3;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(28, 23);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(30, 13);
            this.label22.TabIndex = 2;
            this.label22.Text = "Data";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbWizytyWszystkie);
            this.groupBox1.Controls.Add(this.rbWizytyOdbyte);
            this.groupBox1.Controls.Add(this.rbWizytyNieodbyte);
            this.groupBox1.Location = new System.Drawing.Point(233, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 115);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wizyty";
            // 
            // rbWizytyWszystkie
            // 
            this.rbWizytyWszystkie.AutoSize = true;
            this.rbWizytyWszystkie.Checked = true;
            this.rbWizytyWszystkie.Location = new System.Drawing.Point(31, 82);
            this.rbWizytyWszystkie.Name = "rbWizytyWszystkie";
            this.rbWizytyWszystkie.Size = new System.Drawing.Size(73, 17);
            this.rbWizytyWszystkie.TabIndex = 2;
            this.rbWizytyWszystkie.TabStop = true;
            this.rbWizytyWszystkie.Text = "Wszystkie";
            this.rbWizytyWszystkie.UseVisualStyleBackColor = true;
            // 
            // rbWizytyOdbyte
            // 
            this.rbWizytyOdbyte.AutoSize = true;
            this.rbWizytyOdbyte.Location = new System.Drawing.Point(31, 44);
            this.rbWizytyOdbyte.Name = "rbWizytyOdbyte";
            this.rbWizytyOdbyte.Size = new System.Drawing.Size(86, 17);
            this.rbWizytyOdbyte.TabIndex = 1;
            this.rbWizytyOdbyte.TabStop = true;
            this.rbWizytyOdbyte.Text = "Tylko odbyte";
            this.rbWizytyOdbyte.UseVisualStyleBackColor = true;
            // 
            // rbWizytyNieodbyte
            // 
            this.rbWizytyNieodbyte.AutoSize = true;
            this.rbWizytyNieodbyte.Location = new System.Drawing.Point(31, 20);
            this.rbWizytyNieodbyte.Name = "rbWizytyNieodbyte";
            this.rbWizytyNieodbyte.Size = new System.Drawing.Size(100, 17);
            this.rbWizytyNieodbyte.TabIndex = 0;
            this.rbWizytyNieodbyte.TabStop = true;
            this.rbWizytyNieodbyte.Text = "Tylko nieodbyte";
            this.rbWizytyNieodbyte.UseVisualStyleBackColor = true;
            // 
            // cbWizytyData
            // 
            this.cbWizytyData.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbWizytyData.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbWizytyData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWizytyData.FormattingEnabled = true;
            this.cbWizytyData.Items.AddRange(new object[] {
            "Dowolna",
            "Dzisiaj",
            "Wczoraj",
            "Ten tydzień",
            "Poprzedni tydzień",
            "Ten miesiąc",
            "Poprzedni miesiąc",
            "Pół roku",
            "Rok",
            "Więcej niż rok",
            "Zaplanowane"});
            this.cbWizytyData.Location = new System.Drawing.Point(64, 20);
            this.cbWizytyData.Name = "cbWizytyData";
            this.cbWizytyData.Size = new System.Drawing.Size(121, 21);
            this.cbWizytyData.TabIndex = 0;
            // 
            // dgvWizyty
            // 
            this.dgvWizyty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWizyty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.w_id,
            this.w_godzina,
            this.w_data,
            this.w_imie,
            this.w_nazwisko,
            this.w_lekarz,
            this.w_odbyta});
            this.dgvWizyty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWizyty.Location = new System.Drawing.Point(0, 0);
            this.dgvWizyty.Name = "dgvWizyty";
            this.dgvWizyty.Size = new System.Drawing.Size(872, 314);
            this.dgvWizyty.TabIndex = 0;
            // 
            // w_id
            // 
            this.w_id.DataPropertyName = "w_id";
            this.w_id.HeaderText = "id";
            this.w_id.Name = "w_id";
            this.w_id.Visible = false;
            // 
            // w_godzina
            // 
            this.w_godzina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.w_godzina.DataPropertyName = "w_godzina";
            this.w_godzina.HeaderText = "Godzina";
            this.w_godzina.Name = "w_godzina";
            this.w_godzina.Width = 71;
            // 
            // w_data
            // 
            this.w_data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.w_data.DataPropertyName = "w_data";
            this.w_data.HeaderText = "Dzień";
            this.w_data.Name = "w_data";
            this.w_data.Width = 59;
            // 
            // w_imie
            // 
            this.w_imie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.w_imie.DataPropertyName = "w_imie";
            this.w_imie.HeaderText = "Imię";
            this.w_imie.Name = "w_imie";
            // 
            // w_nazwisko
            // 
            this.w_nazwisko.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.w_nazwisko.DataPropertyName = "w_nazwisko";
            this.w_nazwisko.HeaderText = "Nazwisko";
            this.w_nazwisko.Name = "w_nazwisko";
            // 
            // w_lekarz
            // 
            this.w_lekarz.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.w_lekarz.DataPropertyName = "w_lekarz";
            this.w_lekarz.HeaderText = "Lekarz";
            this.w_lekarz.Name = "w_lekarz";
            // 
            // w_odbyta
            // 
            this.w_odbyta.DataPropertyName = "w_odbyta";
            this.w_odbyta.HeaderText = "Odbyta";
            this.w_odbyta.Name = "w_odbyta";
            this.w_odbyta.ReadOnly = true;
            this.w_odbyta.TrueValue = "w_odbyta";
            this.w_odbyta.Width = 60;
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl.Controls.Add(this.tabWizyty);
            this.tabControl.Controls.Add(this.tabPacjenci);
            this.tabControl.Controls.Add(this.tabLekarze);
            this.tabControl.Controls.Add(this.tabLekarstwa);
            this.tabControl.Controls.Add(this.tabSwiadczenia);
            this.tabControl.Controls.Add(this.tabChoroby);
            this.tabControl.Controls.Add(this.tabSpecjalnosci);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(886, 497);
            this.tabControl.TabIndex = 2;
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
            this.cmsLekarze.ResumeLayout(false);
            this.tabSpecjalnosci.ResumeLayout(false);
            this.splitSpecjalnosci.Panel1.ResumeLayout(false);
            this.splitSpecjalnosci.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitSpecjalnosci)).EndInit();
            this.splitSpecjalnosci.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecjalnosci)).EndInit();
            this.gbSpecjalnosci.ResumeLayout(false);
            this.gbSpecjalnosci.PerformLayout();
            this.tabChoroby.ResumeLayout(false);
            this.splitChoroby.Panel1.ResumeLayout(false);
            this.splitChoroby.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitChoroby)).EndInit();
            this.splitChoroby.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoroby)).EndInit();
            this.gbChoroby.ResumeLayout(false);
            this.gbChoroby.PerformLayout();
            this.tabSwiadczenia.ResumeLayout(false);
            this.splitSwiadczenia.Panel1.ResumeLayout(false);
            this.splitSwiadczenia.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitSwiadczenia)).EndInit();
            this.splitSwiadczenia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSwiadczenia)).EndInit();
            this.gbSwiadczenia.ResumeLayout(false);
            this.gbSwiadczenia.PerformLayout();
            this.tabLekarstwa.ResumeLayout(false);
            this.splitLekarstwa.Panel1.ResumeLayout(false);
            this.splitLekarstwa.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitLekarstwa)).EndInit();
            this.splitLekarstwa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLekarstwa)).EndInit();
            this.cmsLekarstwa.ResumeLayout(false);
            this.gbLekarstwa.ResumeLayout(false);
            this.gbLekarstwa.PerformLayout();
            this.tabLekarze.ResumeLayout(false);
            this.splitLekarze.Panel1.ResumeLayout(false);
            this.splitLekarze.Panel1.PerformLayout();
            this.splitLekarze.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitLekarze)).EndInit();
            this.splitLekarze.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLekarze)).EndInit();
            this.tabPacjenci.ResumeLayout(false);
            this.splitPacjenci.Panel1.ResumeLayout(false);
            this.splitPacjenci.Panel1.PerformLayout();
            this.splitPacjenci.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPacjenci)).EndInit();
            this.splitPacjenci.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacjenci)).EndInit();
            this.tabWizyty.ResumeLayout(false);
            this.splitWizyty.Panel1.ResumeLayout(false);
            this.splitWizyty.Panel1.PerformLayout();
            this.splitWizyty.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitWizyty)).EndInit();
            this.splitWizyty.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWizyty)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsLekarze;
        private System.Windows.Forms.ToolStripMenuItem lekarze_szczegoly;
        private System.Windows.Forms.ToolStripMenuItem lekarze_dodaj;
        private System.Windows.Forms.TabPage tabSpecjalnosci;
        private System.Windows.Forms.SplitContainer splitSpecjalnosci;
        private System.Windows.Forms.DataGridView dgvSpecjalnosci;
        private System.Windows.Forms.DataGridViewTextBoxColumn sp_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sp_nazwa;
        private System.Windows.Forms.GroupBox gbSpecjalnosci;
        private System.Windows.Forms.Button bSpAnuluj;
        private System.Windows.Forms.Button bSpZapisz;
        private System.Windows.Forms.Button bSpDodaj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSpecjalnosc;
        private System.Windows.Forms.TabPage tabChoroby;
        private System.Windows.Forms.SplitContainer splitChoroby;
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
        private System.Windows.Forms.TabPage tabSwiadczenia;
        private System.Windows.Forms.SplitContainer splitSwiadczenia;
        private System.Windows.Forms.DataGridView dgvSwiadczenia;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_koszt;
        private System.Windows.Forms.GroupBox gbSwiadczenia;
        private System.Windows.Forms.Button bAnulujSwiadczenie;
        private System.Windows.Forms.Button bEdytujSwiadczenie;
        private System.Windows.Forms.Button bDodajSwiadczenie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKoszt;
        private System.Windows.Forms.TextBox tbSwiadczenia;
        private System.Windows.Forms.TabPage tabLekarstwa;
        private System.Windows.Forms.SplitContainer splitLekarstwa;
        private System.Windows.Forms.DataGridView dgvLekarstwa;
        private System.Windows.Forms.TabPage tabLekarze;
        private System.Windows.Forms.SplitContainer splitLekarze;
        private System.Windows.Forms.ComboBox cbLekarzeMiasto;
        private System.Windows.Forms.DataGridView dgvLekarze;
        private System.Windows.Forms.TabPage tabPacjenci;
        private System.Windows.Forms.SplitContainer splitPacjenci;
        private System.Windows.Forms.DataGridView dgvPacjenci;
        private System.Windows.Forms.TabPage tabWizyty;
        private System.Windows.Forms.SplitContainer splitWizyty;
        private System.Windows.Forms.DataGridView dgvWizyty;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.GroupBox gbLekarstwa;
        private System.Windows.Forms.TextBox tbLekZalecenia;
        private System.Windows.Forms.TextBox tbLekOpakowania;
        private System.Windows.Forms.TextBox tbLekSklad;
        private System.Windows.Forms.Button bLekAnuluj;
        private System.Windows.Forms.Button bLekZapisz;
        private System.Windows.Forms.Button bLekDodaj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbLekCena;
        private System.Windows.Forms.TextBox tbLekarstwo;
        private System.Windows.Forms.TextBox tbLekPodmiot;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbLekNiepozadane;
        private System.Windows.Forms.TextBox tbLekDawkowanie;
        private System.Windows.Forms.TextBox tbLekPrzeciwwskazania;
        private System.Windows.Forms.DataGridViewTextBoxColumn lek_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn lek_ulotka;
        private System.Windows.Forms.DataGridViewTextBoxColumn lek_nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn lek_cena;
        private System.Windows.Forms.ContextMenuStrip cmsLekarstwa;
        private System.Windows.Forms.ToolStripMenuItem lekarstwa_ulotka;
        private System.Windows.Forms.Button bLekarzeSzukaj;
        private System.Windows.Forms.ComboBox cbLekarzeSpecjalnosc;
        private System.Windows.Forms.ComboBox cbLekarzeNazwisko;
        private System.Windows.Forms.ComboBox cbLekarzeImie;
        private System.Windows.Forms.ComboBox cbLekarzeWiek;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button bLekarzeWyczysc;
        private System.Windows.Forms.Button bPacjenciWyczysc;
        private System.Windows.Forms.Button bPacjenciSzukaj;
        private System.Windows.Forms.ComboBox cbPacjenciLekarz;
        private System.Windows.Forms.ComboBox cbPacjenciNazwisko;
        private System.Windows.Forms.ComboBox cbPacjenciImie;
        private System.Windows.Forms.ComboBox cbPacjenciWiek;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cbPacjenciMiasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_imie;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_nazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_miejsce_urodzenia;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_miasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_kod;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_lekarz;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cbWizytyLekarz;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbWizytyWszystkie;
        private System.Windows.Forms.RadioButton rbWizytyOdbyte;
        private System.Windows.Forms.RadioButton rbWizytyNieodbyte;
        private System.Windows.Forms.ComboBox cbWizytyData;
        private System.Windows.Forms.Button bWizytyPrzeloz;
        private System.Windows.Forms.Button bWizytyAnuluj;
        private System.Windows.Forms.Button bWizytyDodaj;
        private System.Windows.Forms.Button bWizytyWyczysc;
        private System.Windows.Forms.Button bWizytySzukaj;
        private System.Windows.Forms.CheckBox cbLekarzeSpecjalnosci;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn imie;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn specjalnosc;
        private System.Windows.Forms.DataGridViewTextBoxColumn miejsce_ur;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_ur;
        private System.Windows.Forms.DataGridViewTextBoxColumn adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn kod_pocztowy;
        private System.Windows.Forms.DataGridViewTextBoxColumn miescje_zam;
        private System.Windows.Forms.DataGridViewTextBoxColumn w_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn w_godzina;
        private System.Windows.Forms.DataGridViewTextBoxColumn w_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn w_imie;
        private System.Windows.Forms.DataGridViewTextBoxColumn w_nazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn w_lekarz;
        private System.Windows.Forms.DataGridViewCheckBoxColumn w_odbyta;
    }
}

