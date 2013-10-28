namespace Przychodnia_rejestracja
{
    partial class DodajPacjenta
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
            this.anuluj = new System.Windows.Forms.Button();
            this.dodaj = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dodaj);
            this.groupBox1.Controls.Add(this.anuluj);
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
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 220);
            this.groupBox1.TabIndex = 1;
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
            // anuluj
            // 
            this.anuluj.Location = new System.Drawing.Point(480, 185);
            this.anuluj.Name = "anuluj";
            this.anuluj.Size = new System.Drawing.Size(75, 23);
            this.anuluj.TabIndex = 17;
            this.anuluj.Text = "Anuluj";
            this.anuluj.UseVisualStyleBackColor = true;
            this.anuluj.Click += new System.EventHandler(this.anuluj_Click);
            // 
            // dodaj
            // 
            this.dodaj.Location = new System.Drawing.Point(399, 185);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(75, 23);
            this.dodaj.TabIndex = 18;
            this.dodaj.Text = "Dodaj";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // DodajPacjenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 220);
            this.Controls.Add(this.groupBox1);
            this.Name = "DodajPacjenta";
            this.Text = "DodajPacjenta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpUrodzenia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox pesel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox kod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ulica;
        private System.Windows.Forms.TextBox miejsce_zam;
        private System.Windows.Forms.TextBox miejsce_ur;
        private System.Windows.Forms.TextBox nazwisko;
        private System.Windows.Forms.TextBox imie;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.Button anuluj;
    }
}