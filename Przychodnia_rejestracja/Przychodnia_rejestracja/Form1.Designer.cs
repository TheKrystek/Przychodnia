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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabLekarze = new System.Windows.Forms.TabPage();
            this.splitLekarze = new System.Windows.Forms.SplitContainer();
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
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabLekarze.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitLekarze)).BeginInit();
            this.splitLekarze.SuspendLayout();
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
            this.splitChoroby.SuspendLayout();
            this.tabLekarstwa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitLekarstwa)).BeginInit();
            this.splitLekarstwa.SuspendLayout();
            this.tabSwiadczenia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitSwiadczenia)).BeginInit();
            this.splitSwiadczenia.SuspendLayout();
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
            this.tabLekarze.Size = new System.Drawing.Size(878, 232);
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
            this.splitLekarze.Size = new System.Drawing.Size(872, 226);
            this.splitLekarze.SplitterDistance = 135;
            this.splitLekarze.TabIndex = 0;
            // 
            // tabWizyty
            // 
            this.tabWizyty.Controls.Add(this.splitWizyty);
            this.tabWizyty.Location = new System.Drawing.Point(4, 4);
            this.tabWizyty.Name = "tabWizyty";
            this.tabWizyty.Padding = new System.Windows.Forms.Padding(3);
            this.tabWizyty.Size = new System.Drawing.Size(878, 232);
            this.tabWizyty.TabIndex = 1;
            this.tabWizyty.Text = "Wizyty";
            this.tabWizyty.UseVisualStyleBackColor = true;
            // 
            // splitWizyty
            // 
            this.splitWizyty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitWizyty.Location = new System.Drawing.Point(3, 3);
            this.splitWizyty.Name = "splitWizyty";
            this.splitWizyty.Size = new System.Drawing.Size(872, 226);
            this.splitWizyty.SplitterDistance = 290;
            this.splitWizyty.TabIndex = 0;
            // 
            // tabPacjenci
            // 
            this.tabPacjenci.Controls.Add(this.splitPacjenci);
            this.tabPacjenci.Location = new System.Drawing.Point(4, 4);
            this.tabPacjenci.Name = "tabPacjenci";
            this.tabPacjenci.Padding = new System.Windows.Forms.Padding(3);
            this.tabPacjenci.Size = new System.Drawing.Size(878, 232);
            this.tabPacjenci.TabIndex = 2;
            this.tabPacjenci.Text = "Pacjenci";
            this.tabPacjenci.UseVisualStyleBackColor = true;
            // 
            // splitPacjenci
            // 
            this.splitPacjenci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPacjenci.Location = new System.Drawing.Point(3, 3);
            this.splitPacjenci.Name = "splitPacjenci";
            this.splitPacjenci.Size = new System.Drawing.Size(872, 226);
            this.splitPacjenci.SplitterDistance = 290;
            this.splitPacjenci.TabIndex = 0;
            // 
            // tabSpecjalnosci
            // 
            this.tabSpecjalnosci.Controls.Add(this.splitSpecjalnosci);
            this.tabSpecjalnosci.Location = new System.Drawing.Point(4, 4);
            this.tabSpecjalnosci.Name = "tabSpecjalnosci";
            this.tabSpecjalnosci.Padding = new System.Windows.Forms.Padding(3);
            this.tabSpecjalnosci.Size = new System.Drawing.Size(878, 232);
            this.tabSpecjalnosci.TabIndex = 3;
            this.tabSpecjalnosci.Text = "Specjalnosci";
            this.tabSpecjalnosci.UseVisualStyleBackColor = true;
            // 
            // splitSpecjalnosci
            // 
            this.splitSpecjalnosci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitSpecjalnosci.Location = new System.Drawing.Point(3, 3);
            this.splitSpecjalnosci.Name = "splitSpecjalnosci";
            this.splitSpecjalnosci.Size = new System.Drawing.Size(872, 226);
            this.splitSpecjalnosci.SplitterDistance = 290;
            this.splitSpecjalnosci.TabIndex = 0;
            // 
            // tabChoroby
            // 
            this.tabChoroby.Controls.Add(this.splitChoroby);
            this.tabChoroby.Location = new System.Drawing.Point(4, 4);
            this.tabChoroby.Name = "tabChoroby";
            this.tabChoroby.Padding = new System.Windows.Forms.Padding(3);
            this.tabChoroby.Size = new System.Drawing.Size(878, 232);
            this.tabChoroby.TabIndex = 4;
            this.tabChoroby.Text = "Choroby";
            this.tabChoroby.UseVisualStyleBackColor = true;
            // 
            // splitChoroby
            // 
            this.splitChoroby.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitChoroby.Location = new System.Drawing.Point(3, 3);
            this.splitChoroby.Name = "splitChoroby";
            this.splitChoroby.Size = new System.Drawing.Size(872, 226);
            this.splitChoroby.SplitterDistance = 290;
            this.splitChoroby.TabIndex = 0;
            // 
            // tabLekarstwa
            // 
            this.tabLekarstwa.Controls.Add(this.splitLekarstwa);
            this.tabLekarstwa.Location = new System.Drawing.Point(4, 4);
            this.tabLekarstwa.Name = "tabLekarstwa";
            this.tabLekarstwa.Padding = new System.Windows.Forms.Padding(3);
            this.tabLekarstwa.Size = new System.Drawing.Size(878, 232);
            this.tabLekarstwa.TabIndex = 5;
            this.tabLekarstwa.Text = "Lekarstwa";
            this.tabLekarstwa.UseVisualStyleBackColor = true;
            // 
            // splitLekarstwa
            // 
            this.splitLekarstwa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitLekarstwa.Location = new System.Drawing.Point(3, 3);
            this.splitLekarstwa.Name = "splitLekarstwa";
            this.splitLekarstwa.Size = new System.Drawing.Size(872, 226);
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
            this.splitSwiadczenia.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitSwiadczenia.Size = new System.Drawing.Size(872, 465);
            this.splitSwiadczenia.SplitterDistance = 269;
            this.splitSwiadczenia.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.splitLekarze)).EndInit();
            this.splitLekarze.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.splitChoroby)).EndInit();
            this.splitChoroby.ResumeLayout(false);
            this.tabLekarstwa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitLekarstwa)).EndInit();
            this.splitLekarstwa.ResumeLayout(false);
            this.tabSwiadczenia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitSwiadczenia)).EndInit();
            this.splitSwiadczenia.ResumeLayout(false);
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
    }
}

