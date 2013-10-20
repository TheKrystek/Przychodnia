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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ulica = new System.Windows.Forms.TextBox();
            this.miejsce_zam = new System.Windows.Forms.TextBox();
            this.miejsce_ur = new System.Windows.Forms.TextBox();
            this.data_ur = new System.Windows.Forms.TextBox();
            this.nazwisko = new System.Windows.Forms.TextBox();
            this.imie = new System.Windows.Forms.TextBox();
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvSpecjalnosci = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvWizyty = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvPacjenci = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.kod = new System.Windows.Forms.TextBox();
            this.specjalnosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_nad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godzina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wimie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wnazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odbyta = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabcontrol.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecjalnosci)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWizyty)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacjenci)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.91262F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.08738F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabcontrol, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.0663F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.9337F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(681, 484);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
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
            this.groupBox1.Controls.Add(this.data_ur);
            this.groupBox1.Controls.Add(this.nazwisko);
            this.groupBox1.Controls.Add(this.imie);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane Osobowe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ulica";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data Urodzenia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data Urodzenia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nazwisko";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Imię";
            // 
            // ulica
            // 
            this.ulica.Location = new System.Drawing.Point(115, 162);
            this.ulica.Name = "ulica";
            this.ulica.Size = new System.Drawing.Size(122, 20);
            this.ulica.TabIndex = 5;
            // 
            // miejsce_zam
            // 
            this.miejsce_zam.Location = new System.Drawing.Point(115, 136);
            this.miejsce_zam.Name = "miejsce_zam";
            this.miejsce_zam.Size = new System.Drawing.Size(122, 20);
            this.miejsce_zam.TabIndex = 4;
            // 
            // miejsce_ur
            // 
            this.miejsce_ur.Location = new System.Drawing.Point(115, 111);
            this.miejsce_ur.Name = "miejsce_ur";
            this.miejsce_ur.Size = new System.Drawing.Size(122, 20);
            this.miejsce_ur.TabIndex = 3;
            // 
            // data_ur
            // 
            this.data_ur.Location = new System.Drawing.Point(115, 85);
            this.data_ur.Name = "data_ur";
            this.data_ur.Size = new System.Drawing.Size(122, 20);
            this.data_ur.TabIndex = 2;
            // 
            // nazwisko
            // 
            this.nazwisko.Location = new System.Drawing.Point(115, 57);
            this.nazwisko.Name = "nazwisko";
            this.nazwisko.Size = new System.Drawing.Size(122, 20);
            this.nazwisko.TabIndex = 1;
            // 
            // imie
            // 
            this.imie.Location = new System.Drawing.Point(115, 31);
            this.imie.Name = "imie";
            this.imie.Size = new System.Drawing.Size(122, 20);
            this.imie.TabIndex = 0;
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.tabPage1);
            this.tabcontrol.Controls.Add(this.tabPage2);
            this.tabcontrol.Controls.Add(this.tabPage3);
            this.tabcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrol.Location = new System.Drawing.Point(3, 226);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(558, 234);
            this.tabcontrol.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvSpecjalnosci);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(412, 211);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Specjalności";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvSpecjalnosci
            // 
            this.dgvSpecjalnosci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpecjalnosci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.specjalnosc,
            this.data_nad});
            this.dgvSpecjalnosci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSpecjalnosci.Location = new System.Drawing.Point(3, 3);
            this.dgvSpecjalnosci.MultiSelect = false;
            this.dgvSpecjalnosci.Name = "dgvSpecjalnosci";
            this.dgvSpecjalnosci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSpecjalnosci.Size = new System.Drawing.Size(406, 205);
            this.dgvSpecjalnosci.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvWizyty);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(550, 208);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Wizyty";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvWizyty
            // 
            this.dgvWizyty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWizyty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data,
            this.godzina,
            this.wimie,
            this.wnazwisko,
            this.odbyta});
            this.dgvWizyty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWizyty.Location = new System.Drawing.Point(3, 3);
            this.dgvWizyty.Name = "dgvWizyty";
            this.dgvWizyty.Size = new System.Drawing.Size(544, 202);
            this.dgvWizyty.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvPacjenci);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(412, 211);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pacjenci";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvPacjenci
            // 
            this.dgvPacjenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacjenci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPacjenci.Location = new System.Drawing.Point(3, 3);
            this.dgvPacjenci.Name = "dgvPacjenci";
            this.dgvPacjenci.Size = new System.Drawing.Size(406, 205);
            this.dgvPacjenci.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Kod pocztowy";
            // 
            // kod
            // 
            this.kod.Location = new System.Drawing.Point(115, 188);
            this.kod.Name = "kod";
            this.kod.Size = new System.Drawing.Size(122, 20);
            this.kod.TabIndex = 12;
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
            // data
            // 
            this.data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.data.DataPropertyName = "data";
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            // 
            // godzina
            // 
            this.godzina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.godzina.HeaderText = "Godzina";
            this.godzina.Name = "godzina";
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
            this.odbyta.Width = 47;
            // 
            // LekarzeSzczegoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 484);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LekarzeSzczegoly";
            this.Text = "Lekarze - Szczegóły";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabcontrol.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecjalnosci)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWizyty)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacjenci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabcontrol;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvSpecjalnosci;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox ulica;
        private System.Windows.Forms.TextBox miejsce_zam;
        private System.Windows.Forms.TextBox miejsce_ur;
        private System.Windows.Forms.TextBox data_ur;
        private System.Windows.Forms.TextBox nazwisko;
        private System.Windows.Forms.TextBox imie;
        private System.Windows.Forms.DataGridView dgvWizyty;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvPacjenci;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox kod;
        private System.Windows.Forms.DataGridViewTextBoxColumn specjalnosc;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_nad;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn godzina;
        private System.Windows.Forms.DataGridViewTextBoxColumn wimie;
        private System.Windows.Forms.DataGridViewTextBoxColumn wnazwisko;
        private System.Windows.Forms.DataGridViewCheckBoxColumn odbyta;
    }
}