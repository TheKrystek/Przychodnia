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
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data.Location = new System.Drawing.Point(114, 22);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(104, 20);
            this.data.TabIndex = 0;
            // 
            // czas
            // 
            this.czas.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.czas.Location = new System.Drawing.Point(114, 62);
            this.czas.Name = "czas";
            this.czas.Size = new System.Drawing.Size(104, 20);
            this.czas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Godzina";
            // 
            // pacjentNazwisko
            // 
            this.pacjentNazwisko.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pacjentNazwisko.FormattingEnabled = true;
            this.pacjentNazwisko.Location = new System.Drawing.Point(97, 107);
            this.pacjentNazwisko.Name = "pacjentNazwisko";
            this.pacjentNazwisko.Size = new System.Drawing.Size(121, 21);
            this.pacjentNazwisko.TabIndex = 4;
            this.pacjentNazwisko.SelectedValueChanged += new System.EventHandler(this.pacjentNazwisko_SelectedValueChanged);
            // 
            // pacjentImie
            // 
            this.pacjentImie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pacjentImie.FormattingEnabled = true;
            this.pacjentImie.Location = new System.Drawing.Point(97, 134);
            this.pacjentImie.Name = "pacjentImie";
            this.pacjentImie.Size = new System.Drawing.Size(121, 21);
            this.pacjentImie.TabIndex = 5;
            this.pacjentImie.SelectedValueChanged += new System.EventHandler(this.pacjentImie_SelectedValueChanged);
            // 
            // lekarzImie
            // 
            this.lekarzImie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lekarzImie.FormattingEnabled = true;
            this.lekarzImie.Location = new System.Drawing.Point(97, 250);
            this.lekarzImie.Name = "lekarzImie";
            this.lekarzImie.Size = new System.Drawing.Size(121, 21);
            this.lekarzImie.TabIndex = 8;
            this.lekarzImie.SelectedValueChanged += new System.EventHandler(this.lekarzImie_SelectedValueChanged);
            // 
            // lekarzNazwisko
            // 
            this.lekarzNazwisko.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lekarzNazwisko.FormattingEnabled = true;
            this.lekarzNazwisko.Location = new System.Drawing.Point(97, 223);
            this.lekarzNazwisko.Name = "lekarzNazwisko";
            this.lekarzNazwisko.Size = new System.Drawing.Size(121, 21);
            this.lekarzNazwisko.TabIndex = 7;
            this.lekarzNazwisko.SelectedValueChanged += new System.EventHandler(this.lekarzNazwisko_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nazwisko";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Imię";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "PESEL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nazwisko";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Imię";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "PESEL";
            // 
            // dodaj
            // 
            this.dodaj.Location = new System.Drawing.Point(62, 340);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(75, 23);
            this.dodaj.TabIndex = 16;
            this.dodaj.Text = "Dodaj";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // anuluj
            // 
            this.anuluj.Location = new System.Drawing.Point(143, 340);
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
            this.pacjenciPESEL.Location = new System.Drawing.Point(97, 168);
            this.pacjenciPESEL.Name = "pacjenciPESEL";
            this.pacjenciPESEL.Size = new System.Drawing.Size(121, 21);
            this.pacjenciPESEL.TabIndex = 18;
            this.pacjenciPESEL.SelectedIndexChanged += new System.EventHandler(this.pacjenciPESEL_SelectedIndexChanged);
            // 
            // lekarzePESEL
            // 
            this.lekarzePESEL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lekarzePESEL.FormattingEnabled = true;
            this.lekarzePESEL.Location = new System.Drawing.Point(97, 280);
            this.lekarzePESEL.Name = "lekarzePESEL";
            this.lekarzePESEL.Size = new System.Drawing.Size(121, 21);
            this.lekarzePESEL.TabIndex = 19;
            this.lekarzePESEL.SelectedIndexChanged += new System.EventHandler(this.lekarzePESEL_SelectedIndexChanged);
            // 
            // DodajWizyte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 396);
            this.Controls.Add(this.lekarzePESEL);
            this.Controls.Add(this.pacjenciPESEL);
            this.Controls.Add(this.anuluj);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lekarzImie);
            this.Controls.Add(this.lekarzNazwisko);
            this.Controls.Add(this.pacjentImie);
            this.Controls.Add(this.pacjentNazwisko);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.czas);
            this.Controls.Add(this.data);
            this.Name = "DodajWizyte";
            this.Text = "Dodaj Wizytę";
            this.Load += new System.EventHandler(this.DodajWizyte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}