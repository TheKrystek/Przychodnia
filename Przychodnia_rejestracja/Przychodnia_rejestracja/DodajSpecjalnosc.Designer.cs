﻿namespace Przychodnia_rejestracja
{
    partial class DodajSpecjalnosc
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
            this.panel_lakarz = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataPicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSpecjalnosci = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dodaj_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_lakarz
            // 
            this.panel_lakarz.Location = new System.Drawing.Point(12, 12);
            this.panel_lakarz.Name = "panel_lakarz";
            this.panel_lakarz.Size = new System.Drawing.Size(242, 80);
            this.panel_lakarz.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dodaj_button);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbSpecjalnosci);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataPicker);
            this.panel1.Location = new System.Drawing.Point(12, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 108);
            this.panel1.TabIndex = 1;
            // 
            // dataPicker
            // 
            this.dataPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataPicker.Location = new System.Drawing.Point(103, 40);
            this.dataPicker.Name = "dataPicker";
            this.dataPicker.Size = new System.Drawing.Size(121, 20);
            this.dataPicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data nadania";
            // 
            // cbSpecjalnosci
            // 
            this.cbSpecjalnosci.FormattingEnabled = true;
            this.cbSpecjalnosci.Location = new System.Drawing.Point(103, 13);
            this.cbSpecjalnosci.Name = "cbSpecjalnosci";
            this.cbSpecjalnosci.Size = new System.Drawing.Size(121, 21);
            this.cbSpecjalnosci.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Specjalność";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Anuluj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dodaj_button
            // 
            this.dodaj_button.Location = new System.Drawing.Point(164, 81);
            this.dodaj_button.Name = "dodaj_button";
            this.dodaj_button.Size = new System.Drawing.Size(75, 23);
            this.dodaj_button.TabIndex = 4;
            this.dodaj_button.Text = "Dodaj";
            this.dodaj_button.UseVisualStyleBackColor = true;
            this.dodaj_button.Click += new System.EventHandler(this.dodaj_button_Click);
            // 
            // DodajSpecjalnosc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 214);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_lakarz);
            this.Name = "DodajSpecjalnosc";
            this.Text = "Dodaj Specjalność - ";
            this.Load += new System.EventHandler(this.DodajSpecjalnosc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_lakarz;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button dodaj_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSpecjalnosci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dataPicker;
    }
}