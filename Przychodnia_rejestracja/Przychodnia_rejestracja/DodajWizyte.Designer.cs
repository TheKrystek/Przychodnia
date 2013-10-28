namespace Przychodnia_rejestracja
{
    partial class DodajWizyte
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
            this.data = new System.Windows.Forms.DateTimePicker();
            this.czas = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pacjentNazwisko = new System.Windows.Forms.ComboBox();
            this.pacjentImie = new System.Windows.Forms.ComboBox();
            this.lekarzImie = new System.Windows.Forms.ComboBox();
            this.lekarzNazwisko = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dodaj = new System.Windows.Forms.Button();
            this.anuluj = new System.Windows.Forms.Button();
            this.pacjenciPESEL = new System.Windows.Forms.ComboBox();
            this.lekarzePESEL = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data.Location = new System.Drawing.Point(100, 19);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(121, 20);
            this.data.TabIndex = 0;
            // 
            // czas
            // 
            this.czas.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.czas.Location = new System.Drawing.Point(100, 45);
            this.czas.Name = "czas";
            this.czas.Size = new System.Drawing.Size(121, 20);
            this.czas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Godzina";
            // 
            // pacjentNazwisko
            // 
            this.pacjentNazwisko.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pacjentNazwisko.FormattingEnabled = true;
            this.pacjentNazwisko.Location = new System.Drawing.Point(100, 22);
            this.pacjentNazwisko.Name = "pacjentNazwisko";
            this.pacjentNazwisko.Size = new System.Drawing.Size(121, 21);
            this.pacjentNazwisko.TabIndex = 4;
            this.pacjentNazwisko.SelectedValueChanged += new System.EventHandler(this.pacjentNazwisko_SelectedValueChanged);
            // 
            // pacjentImie
            // 
            this.pacjentImie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pacjentImie.FormattingEnabled = true;
            this.pacjentImie.Location = new System.Drawing.Point(100, 49);
            this.pacjentImie.Name = "pacjentImie";
            this.pacjentImie.Size = new System.Drawing.Size(121, 21);
            this.pacjentImie.TabIndex = 5;
            this.pacjentImie.SelectedValueChanged += new System.EventHandler(this.pacjentImie_SelectedValueChanged);
            // 
            // lekarzImie
            // 
            this.lekarzImie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lekarzImie.FormattingEnabled = true;
            this.lekarzImie.Location = new System.Drawing.Point(100, 51);
            this.lekarzImie.Name = "lekarzImie";
            this.lekarzImie.Size = new System.Drawing.Size(121, 21);
            this.lekarzImie.TabIndex = 8;
            this.lekarzImie.SelectedValueChanged += new System.EventHandler(this.lekarzImie_SelectedValueChanged);
            // 
            // lekarzNazwisko
            // 
            this.lekarzNazwisko.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lekarzNazwisko.FormattingEnabled = true;
            this.lekarzNazwisko.Location = new System.Drawing.Point(100, 24);
            this.lekarzNazwisko.Name = "lekarzNazwisko";
            this.lekarzNazwisko.Size = new System.Drawing.Size(121, 21);
            this.lekarzNazwisko.TabIndex = 7;
            this.lekarzNazwisko.SelectedValueChanged += new System.EventHandler(this.lekarzNazwisko_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nazwisko";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Imię";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "PESEL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nazwisko";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Imię";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "PESEL";
            // 
            // dodaj
            // 
            this.dodaj.Enabled = false;
            this.dodaj.Location = new System.Drawing.Point(99, 365);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(75, 23);
            this.dodaj.TabIndex = 16;
            this.dodaj.Text = "Dodaj";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // anuluj
            // 
            this.anuluj.Location = new System.Drawing.Point(180, 365);
            this.anuluj.Name = "anuluj";
            this.anuluj.Size = new System.Drawing.Size(75, 23);
            this.anuluj.TabIndex = 17;
            this.anuluj.Text = "Anuluj";
            this.anuluj.UseVisualStyleBackColor = true;
            this.anuluj.Click += new System.EventHandler(this.anuluj_Click);
            // 
            // pacjenciPESEL
            // 
            this.pacjenciPESEL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pacjenciPESEL.FormattingEnabled = true;
            this.pacjenciPESEL.Location = new System.Drawing.Point(100, 83);
            this.pacjenciPESEL.Name = "pacjenciPESEL";
            this.pacjenciPESEL.Size = new System.Drawing.Size(121, 21);
            this.pacjenciPESEL.TabIndex = 18;
            this.pacjenciPESEL.SelectedIndexChanged += new System.EventHandler(this.pacjenciPESEL_SelectedIndexChanged);
            // 
            // lekarzePESEL
            // 
            this.lekarzePESEL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lekarzePESEL.FormattingEnabled = true;
            this.lekarzePESEL.Location = new System.Drawing.Point(100, 81);
            this.lekarzePESEL.Name = "lekarzePESEL";
            this.lekarzePESEL.Size = new System.Drawing.Size(121, 21);
            this.lekarzePESEL.TabIndex = 19;
            this.lekarzePESEL.SelectedIndexChanged += new System.EventHandler(this.lekarzePESEL_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.czas);
            this.groupBox1.Controls.Add(this.data);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 85);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data wizyty";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pacjentNazwisko);
            this.groupBox2.Controls.Add(this.pacjentImie);
            this.groupBox2.Controls.Add(this.pacjenciPESEL);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 124);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pacjent";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lekarzePESEL);
            this.groupBox3.Controls.Add(this.lekarzNazwisko);
            this.groupBox3.Controls.Add(this.lekarzImie);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(12, 233);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 124);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lekarz";
            // 
            // DodajWizyte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 399);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.anuluj);
            this.Controls.Add(this.dodaj);
            this.Name = "DodajWizyte";
            this.Text = "Dodaj Wizytę";
            this.Load += new System.EventHandler(this.DodajWizyte_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker data;
        private System.Windows.Forms.DateTimePicker czas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox pacjentNazwisko;
        private System.Windows.Forms.ComboBox pacjentImie;
        private System.Windows.Forms.ComboBox lekarzImie;
        private System.Windows.Forms.ComboBox lekarzNazwisko;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.Button anuluj;
        private System.Windows.Forms.ComboBox pacjenciPESEL;
        private System.Windows.Forms.ComboBox lekarzePESEL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}