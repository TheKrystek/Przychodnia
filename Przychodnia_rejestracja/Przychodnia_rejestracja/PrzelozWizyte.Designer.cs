namespace Przychodnia_rejestracja
{
    partial class PrzelozWizyte
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
            this.godzina = new System.Windows.Forms.DateTimePicker();
            this.data = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nowaGodzina = new System.Windows.Forms.DateTimePicker();
            this.nowaData = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.anuluj = new System.Windows.Forms.Button();
            this.dodaj = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.godzina);
            this.groupBox1.Controls.Add(this.data);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 85);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data wizyty";
            // 
            // godzina
            // 
            this.godzina.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.godzina.Location = new System.Drawing.Point(100, 45);
            this.godzina.Name = "godzina";
            this.godzina.Size = new System.Drawing.Size(121, 20);
            this.godzina.TabIndex = 1;
            this.godzina.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // data
            // 
            this.data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data.Location = new System.Drawing.Point(100, 19);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(121, 20);
            this.data.TabIndex = 0;
            this.data.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nowaGodzina);
            this.groupBox2.Controls.Add(this.nowaData);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 85);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nowa data wizyty";
            // 
            // nowaGodzina
            // 
            this.nowaGodzina.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.nowaGodzina.Location = new System.Drawing.Point(100, 45);
            this.nowaGodzina.Name = "nowaGodzina";
            this.nowaGodzina.Size = new System.Drawing.Size(121, 20);
            this.nowaGodzina.TabIndex = 1;
            this.nowaGodzina.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // nowaData
            // 
            this.nowaData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.nowaData.Location = new System.Drawing.Point(100, 19);
            this.nowaData.Name = "nowaData";
            this.nowaData.Size = new System.Drawing.Size(121, 20);
            this.nowaData.TabIndex = 0;
            this.nowaData.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Godzina";
            // 
            // anuluj
            // 
            this.anuluj.Location = new System.Drawing.Point(180, 194);
            this.anuluj.Name = "anuluj";
            this.anuluj.Size = new System.Drawing.Size(75, 23);
            this.anuluj.TabIndex = 24;
            this.anuluj.Text = "Anuluj";
            this.anuluj.UseVisualStyleBackColor = true;
            this.anuluj.Click += new System.EventHandler(this.anuluj_Click);
            // 
            // dodaj
            // 
            this.dodaj.Enabled = false;
            this.dodaj.Location = new System.Drawing.Point(99, 194);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(75, 23);
            this.dodaj.TabIndex = 23;
            this.dodaj.Text = "Dodaj";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // PrzelozWizyte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 225);
            this.Controls.Add(this.anuluj);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PrzelozWizyte";
            this.Text = "PrzelozWizyte";
            this.Load += new System.EventHandler(this.PrzelozWizyte_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker godzina;
        private System.Windows.Forms.DateTimePicker data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker nowaGodzina;
        private System.Windows.Forms.DateTimePicker nowaData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button anuluj;
        private System.Windows.Forms.Button dodaj;
    }
}