namespace Przychodnia_rejestracja
{
    partial class LekarzeSzczegoly
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpUrodzenia = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.pesel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.kod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ulica = new System.Windows.Forms.TextBox();
            this.miejsce_zam = new System.Windows.Forms.TextBox();
            this.miejsce_ur = new System.Windows.Forms.TextBox();
            this.nazwisko = new System.Windows.Forms.TextBox();
            this.imie = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvSpecjalnosci = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specjalnosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_nad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsSpecjalnosci = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.spec_dodaj = new System.Windows.Forms.ToolStripMenuItem();
            this.spec_usun = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvWizyty = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvPacjenci = new System.Windows.Forms.DataGridView();
            this.p_imie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_nazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppesel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_data_ur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_miejsce_ur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_ulica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            this.godzina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wimie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wnazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odbyta = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabcontrol.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecjalnosci)).BeginInit();
            this.cmsSpecjalnosci.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWizyty)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacjenci)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(674, 176);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpUrodzenia);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.pesel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.kod);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ulica);
            this.groupBox1.Controls.Add(this.miejsce_zam);
            this.groupBox1.Controls.Add(this.miejsce_ur);
            this.groupBox1.Controls.Add(this.nazwisko);
            this.groupBox1.Controls.Add(this.imie);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane Osobowe";
            // 
            // dtpUrodzenia
            // 
            this.dtpUrodzenia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUrodzenia.Location = new System.Drawing.Point(132, 109);
            this.dtpUrodzenia.Name = "dtpUrodzenia";
            this.dtpUrodzenia.Size = new System.Drawing.Size(147, 20);
            this.dtpUrodzenia.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "PESEL";
            // 
            // pesel
            // 
            this.pesel.Location = new System.Drawing.Point(132, 82);
            this.pesel.Name = "pesel";
            this.pesel.Size = new System.Drawing.Size(147, 20);
            this.pesel.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(319, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Kod pocztowy";
            // 
            // kod
            // 
            this.kod.Location = new System.Drawing.Point(408, 82);
            this.kod.Name = "kod";
            this.kod.Size = new System.Drawing.Size(147, 20);
            this.kod.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ulica";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Miejsce urodzenia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data urodzenia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nazwisko";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Imię";
            // 
            // ulica
            // 
            this.ulica.Location = new System.Drawing.Point(408, 56);
            this.ulica.Name = "ulica";
            this.ulica.Size = new System.Drawing.Size(147, 20);
            this.ulica.TabIndex = 5;
            // 
            // miejsce_zam
            // 
            this.miejsce_zam.Location = new System.Drawing.Point(408, 30);
            this.miejsce_zam.Name = "miejsce_zam";
            this.miejsce_zam.Size = new System.Drawing.Size(147, 20);
            this.miejsce_zam.TabIndex = 4;
            // 
            // miejsce_ur
            // 
            this.miejsce_ur.Location = new System.Drawing.Point(132, 134);
            this.miejsce_ur.Name = "miejsce_ur";
            this.miejsce_ur.Size = new System.Drawing.Size(147, 20);
            this.miejsce_ur.TabIndex = 3;
            // 
            // nazwisko
            // 
            this.nazwisko.Location = new System.Drawing.Point(132, 56);
            this.nazwisko.Name = "nazwisko";
            this.nazwisko.Size = new System.Drawing.Size(147, 20);
            this.nazwisko.TabIndex = 1;
            // 
            // imie
            // 
            this.imie.Location = new System.Drawing.Point(132, 30);
            this.imie.Name = "imie";
            this.imie.Size = new System.Drawing.Size(147, 20);
            this.imie.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabcontrol);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 246);
            this.panel1.TabIndex = 1;
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.tabPage1);
            this.tabcontrol.Controls.Add(this.tabPage2);
            this.tabcontrol.Controls.Add(this.tabPage3);
            this.tabcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrol.Location = new System.Drawing.Point(0, 0);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(674, 246);
            this.tabcontrol.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvSpecjalnosci);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(666, 220);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Specjalności";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvSpecjalnosci
            // 
            this.dgvSpecjalnosci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpecjalnosci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.specjalnosc,
            this.data_nad});
            this.dgvSpecjalnosci.ContextMenuStrip = this.cmsSpecjalnosci;
            this.dgvSpecjalnosci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSpecjalnosci.Location = new System.Drawing.Point(3, 3);
            this.dgvSpecjalnosci.MultiSelect = false;
            this.dgvSpecjalnosci.Name = "dgvSpecjalnosci";
            this.dgvSpecjalnosci.RowHeadersVisible = false;
            this.dgvSpecjalnosci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSpecjalnosci.Size = new System.Drawing.Size(660, 214);
            this.dgvSpecjalnosci.TabIndex = 0;
            this.dgvSpecjalnosci.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseDown);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Column1";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // specjalnosc
            // 
            this.specjalnosc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.specjalnosc.DataPropertyName = "specjalnosc";
            this.specjalnosc.HeaderText = "Specjalność";
            this.specjalnosc.Name = "specjalnosc";
            // 
            // data_nad
            // 
            this.data_nad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.data_nad.DataPropertyName = "data_nad";
            this.data_nad.HeaderText = "Data nadania";
            this.data_nad.Name = "data_nad";
            // 
            // cmsSpecjalnosci
            // 
            this.cmsSpecjalnosci.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spec_dodaj,
            this.spec_usun});
            this.cmsSpecjalnosci.Name = "cmsSpecjalnosci";
            this.cmsSpecjalnosci.Size = new System.Drawing.Size(106, 48);
            this.cmsSpecjalnosci.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsSpecjalnosci_ItemClicked);
            // 
            // spec_dodaj
            // 
            this.spec_dodaj.AccessibleName = "Dodaj";
            this.spec_dodaj.Name = "spec_dodaj";
            this.spec_dodaj.Size = new System.Drawing.Size(105, 22);
            this.spec_dodaj.Text = "Dodaj";
            // 
            // spec_usun
            // 
            this.spec_usun.Name = "spec_usun";
            this.spec_usun.Size = new System.Drawing.Size(105, 22);
            this.spec_usun.Text = "Usuń";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvWizyty);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(666, 220);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Wizyty";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvWizyty
            // 
            this.dgvWizyty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWizyty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.godzina,
            this.data,
            this.wimie,
            this.wnazwisko,
            this.odbyta});
            this.dgvWizyty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWizyty.Location = new System.Drawing.Point(3, 3);
            this.dgvWizyty.MultiSelect = false;
            this.dgvWizyty.Name = "dgvWizyty";
            this.dgvWizyty.RowHeadersVisible = false;
            this.dgvWizyty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWizyty.Size = new System.Drawing.Size(660, 214);
            this.dgvWizyty.TabIndex = 0;
            this.dgvWizyty.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseDown);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvPacjenci);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(666, 220);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pacjenci";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvPacjenci
            // 
            this.dgvPacjenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacjenci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.p_imie,
            this.p_nazwisko,
            this.ppesel,
            this.p_data_ur,
            this.p_miejsce_ur,
            this.p_ulica,
            this.p_adres,
            this.p_kod});
            this.dgvPacjenci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPacjenci.Location = new System.Drawing.Point(3, 3);
            this.dgvPacjenci.MultiSelect = false;
            this.dgvPacjenci.Name = "dgvPacjenci";
            this.dgvPacjenci.RowHeadersVisible = false;
            this.dgvPacjenci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacjenci.Size = new System.Drawing.Size(660, 214);
            this.dgvPacjenci.TabIndex = 0;
            this.dgvPacjenci.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseDown);
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
            // ppesel
            // 
            this.ppesel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ppesel.DataPropertyName = "ppesel";
            this.ppesel.HeaderText = "PESEL";
            this.ppesel.Name = "ppesel";
            // 
            // p_data_ur
            // 
            this.p_data_ur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.p_data_ur.DataPropertyName = "p_data_ur";
            this.p_data_ur.HeaderText = "Data urodzenia";
            this.p_data_ur.Name = "p_data_ur";
            // 
            // p_miejsce_ur
            // 
            this.p_miejsce_ur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.p_miejsce_ur.DataPropertyName = "p_miejsce_ur";
            this.p_miejsce_ur.HeaderText = "Miejsce urodzenia";
            this.p_miejsce_ur.Name = "p_miejsce_ur";
            // 
            // p_ulica
            // 
            this.p_ulica.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.p_ulica.DataPropertyName = "p_ulica";
            this.p_ulica.HeaderText = "Ulica";
            this.p_ulica.Name = "p_ulica";
            // 
            // p_adres
            // 
            this.p_adres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.p_adres.DataPropertyName = "p_adres";
            this.p_adres.HeaderText = "Adres";
            this.p_adres.Name = "p_adres";
            // 
            // p_kod
            // 
            this.p_kod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.p_kod.DataPropertyName = "p_kod";
            this.p_kod.HeaderText = "Kod pocztowy";
            this.p_kod.Name = "p_kod";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 422);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(674, 31);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(506, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 31);
            this.button1.TabIndex = 25;
            this.button1.Text = "Anuluj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button
            // 
            this.button.Dock = System.Windows.Forms.DockStyle.Right;
            this.button.Location = new System.Drawing.Point(590, 0);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(84, 31);
            this.button.TabIndex = 24;
            this.button.Text = "Zapisz";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // godzina
            // 
            this.godzina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.godzina.HeaderText = "Godzina";
            this.godzina.Name = "godzina";
            // 
            // data
            // 
            this.data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.data.DataPropertyName = "data";
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            // 
            // wimie
            // 
            this.wimie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.wimie.DataPropertyName = "wimie";
            this.wimie.HeaderText = "Imię";
            this.wimie.Name = "wimie";
            // 
            // wnazwisko
            // 
            this.wnazwisko.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.wnazwisko.DataPropertyName = "wnazwisko";
            this.wnazwisko.HeaderText = "Nazwisko";
            this.wnazwisko.Name = "wnazwisko";
            // 
            // odbyta
            // 
            this.odbyta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.odbyta.DataPropertyName = "odbyta";
            this.odbyta.HeaderText = "Odbyta";
            this.odbyta.Name = "odbyta";
            this.odbyta.ReadOnly = true;
            this.odbyta.Width = 47;
            // 
            // LekarzeSzczegoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 456);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LekarzeSzczegoly";
            this.Text = "Lekarze - Szczegóły";
            this.Load += new System.EventHandler(this.LekarzeSzczegoly_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabcontrol.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecjalnosci)).EndInit();
            this.cmsSpecjalnosci.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWizyty)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacjenci)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ulica;
        private System.Windows.Forms.TextBox miejsce_zam;
        private System.Windows.Forms.TextBox miejsce_ur;
        private System.Windows.Forms.TextBox nazwisko;
        private System.Windows.Forms.TextBox imie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox kod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox pesel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabcontrol;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvSpecjalnosci;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvWizyty;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvPacjenci;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.ContextMenuStrip cmsSpecjalnosci;
        private System.Windows.Forms.ToolStripMenuItem spec_dodaj;
        private System.Windows.Forms.ToolStripMenuItem spec_usun;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn specjalnosc;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_nad;
        private System.Windows.Forms.DateTimePicker dtpUrodzenia;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_imie;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_nazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn ppesel;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_data_ur;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_miejsce_ur;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_ulica;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_kod;
        private System.Windows.Forms.DataGridViewTextBoxColumn godzina;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn wimie;
        private System.Windows.Forms.DataGridViewTextBoxColumn wnazwisko;
        private System.Windows.Forms.DataGridViewCheckBoxColumn odbyta;
    }
}