namespace Przychodnia_rejestracja
{
    partial class Statystyki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statystyki));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pokaz = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.ComboBox();
            this.output = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.imie_lekarza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwisko_lekarza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imie_pacjenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwisko_pacjenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liczba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srednia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roznica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miesiac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cena_leku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwa_leku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwa_choroby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.output)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.89791F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.output, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.57692F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.42308F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(813, 520);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pokaz);
            this.panel1.Controls.Add(this.lista);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 46);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Statystyki";
            // 
            // pokaz
            // 
            this.pokaz.Location = new System.Drawing.Point(638, 7);
            this.pokaz.Name = "pokaz";
            this.pokaz.Size = new System.Drawing.Size(75, 23);
            this.pokaz.TabIndex = 1;
            this.pokaz.Text = "Pokaż";
            this.pokaz.UseVisualStyleBackColor = true;
            this.pokaz.Click += new System.EventHandler(this.pokaz_Click);
            // 
            // lista
            // 
            this.lista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lista.FormattingEnabled = true;
            this.lista.Items.AddRange(new object[] {
            "Lekarze z największą liczbą wypisanych recept",
            "Lekarze z największą sumą leków na receptach",
            "Lekarze z największą liczbą pacjentów",
            "Lekarze którzy wypisali recepty na więcej niż średnia",
            "Lekarze wypisujący najdroższe leki",
            "Choroby i liczba zdiagnozowanych przypadków",
            "Najpopularniejsze choroby według miesięcy diagnozy",
            "Pacjentki zbyt często odwiedzajace swoich lekarzy (częściej niż średnia)"});
            this.lista.Location = new System.Drawing.Point(78, 9);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(554, 21);
            this.lista.TabIndex = 0;
            // 
            // output
            // 
            this.output.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.output.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imie_lekarza,
            this.nazwisko_lekarza,
            this.imie_pacjenta,
            this.nazwisko_pacjenta,
            this.liczba,
            this.suma,
            this.srednia,
            this.roznica,
            this.miesiac,
            this.cena_leku,
            this.nazwa_leku,
            this.nazwa_choroby});
            this.output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.output.Location = new System.Drawing.Point(3, 55);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(807, 441);
            this.output.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 499);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(813, 21);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 16);
            // 
            // imie_lekarza
            // 
            this.imie_lekarza.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.imie_lekarza.DataPropertyName = "imie_lekarza";
            this.imie_lekarza.HeaderText = "Imię lekarza";
            this.imie_lekarza.Name = "imie_lekarza";
            // 
            // nazwisko_lekarza
            // 
            this.nazwisko_lekarza.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazwisko_lekarza.DataPropertyName = "nazwisko_lekarza";
            this.nazwisko_lekarza.HeaderText = "Nazwisko lekarza";
            this.nazwisko_lekarza.Name = "nazwisko_lekarza";
            // 
            // imie_pacjenta
            // 
            this.imie_pacjenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.imie_pacjenta.DataPropertyName = "imie_pacjenta";
            this.imie_pacjenta.HeaderText = "Imię pacjenta";
            this.imie_pacjenta.Name = "imie_pacjenta";
            // 
            // nazwisko_pacjenta
            // 
            this.nazwisko_pacjenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazwisko_pacjenta.DataPropertyName = "nazwisko_pacjenta";
            this.nazwisko_pacjenta.HeaderText = "Nazwisko pacjenta";
            this.nazwisko_pacjenta.Name = "nazwisko_pacjenta";
            // 
            // liczba
            // 
            this.liczba.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.liczba.DataPropertyName = "liczba";
            this.liczba.HeaderText = "Liczba";
            this.liczba.Name = "liczba";
            this.liczba.Width = 63;
            // 
            // suma
            // 
            this.suma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.suma.DataPropertyName = "suma";
            this.suma.HeaderText = "Suma";
            this.suma.Name = "suma";
            this.suma.Width = 59;
            // 
            // srednia
            // 
            this.srednia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.srednia.DataPropertyName = "srednia";
            this.srednia.HeaderText = "Średnia";
            this.srednia.Name = "srednia";
            this.srednia.Width = 68;
            // 
            // roznica
            // 
            this.roznica.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.roznica.DataPropertyName = "roznica";
            this.roznica.HeaderText = "Różnica";
            this.roznica.Name = "roznica";
            this.roznica.Width = 71;
            // 
            // miesiac
            // 
            this.miesiac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.miesiac.DataPropertyName = "miesiac";
            this.miesiac.HeaderText = "Miesiąc";
            this.miesiac.Name = "miesiac";
            this.miesiac.Width = 68;
            // 
            // cena_leku
            // 
            this.cena_leku.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cena_leku.DataPropertyName = "cena_leku";
            this.cena_leku.HeaderText = "Cena leku";
            this.cena_leku.Name = "cena_leku";
            this.cena_leku.Width = 74;
            // 
            // nazwa_leku
            // 
            this.nazwa_leku.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazwa_leku.DataPropertyName = "nazwa_leku";
            this.nazwa_leku.HeaderText = "Nazwa leku";
            this.nazwa_leku.Name = "nazwa_leku";
            // 
            // nazwa_choroby
            // 
            this.nazwa_choroby.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazwa_choroby.DataPropertyName = "nazwa_choroby";
            this.nazwa_choroby.HeaderText = "Nazwa choroby";
            this.nazwa_choroby.Name = "nazwa_choroby";
            // 
            // Statystyki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 520);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Statystyki";
            this.Text = "Statystyki";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.output)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pokaz;
        private System.Windows.Forms.ComboBox lista;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.DataGridViewTextBoxColumn imie_lekarza;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwisko_lekarza;
        private System.Windows.Forms.DataGridViewTextBoxColumn imie_pacjenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwisko_pacjenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn liczba;
        private System.Windows.Forms.DataGridViewTextBoxColumn suma;
        private System.Windows.Forms.DataGridViewTextBoxColumn srednia;
        private System.Windows.Forms.DataGridViewTextBoxColumn roznica;
        private System.Windows.Forms.DataGridViewTextBoxColumn miesiac;
        private System.Windows.Forms.DataGridViewTextBoxColumn cena_leku;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwa_leku;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwa_choroby;
    }
}