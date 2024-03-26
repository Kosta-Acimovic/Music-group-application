namespace FrmLogin
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kreirajMuzickuGrupuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretraziMuzickuGrupuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniMuzickuGruopuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.izvođačToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajIzvodjacaItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniIzvodjacaItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muzickaGrupaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajMuzickuGrupuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretraziMuzickuGrupuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajNastupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNastupItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretraziNastupItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblKorisnik = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajMuzickuGrupuToolStripMenuItem,
            this.pretraziMuzickuGrupuToolStripMenuItem,
            this.izmeniMuzickuGruopuToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(222, 76);
            // 
            // kreirajMuzickuGrupuToolStripMenuItem
            // 
            this.kreirajMuzickuGrupuToolStripMenuItem.Name = "kreirajMuzickuGrupuToolStripMenuItem";
            this.kreirajMuzickuGrupuToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.kreirajMuzickuGrupuToolStripMenuItem.Text = "Kreiraj muzicku grupu";
            // 
            // pretraziMuzickuGrupuToolStripMenuItem
            // 
            this.pretraziMuzickuGrupuToolStripMenuItem.Name = "pretraziMuzickuGrupuToolStripMenuItem";
            this.pretraziMuzickuGrupuToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.pretraziMuzickuGrupuToolStripMenuItem.Text = "Pretrazi muzicku grupu";
            // 
            // izmeniMuzickuGruopuToolStripMenuItem
            // 
            this.izmeniMuzickuGruopuToolStripMenuItem.Name = "izmeniMuzickuGruopuToolStripMenuItem";
            this.izmeniMuzickuGruopuToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.izmeniMuzickuGruopuToolStripMenuItem.Text = "Izmeni muzicku gruopu";
            // 
            // menuMain
            // 
            this.menuMain.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuMain.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izvođačToolStripMenuItem,
            this.muzickaGrupaToolStripMenuItem,
            this.kreirajNastupToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(621, 36);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "menuStrip1";
            // 
            // izvođačToolStripMenuItem
            // 
            this.izvođačToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajIzvodjacaItem,
            this.izmeniIzvodjacaItem});
            this.izvođačToolStripMenuItem.Name = "izvođačToolStripMenuItem";
            this.izvođačToolStripMenuItem.Size = new System.Drawing.Size(98, 32);
            this.izvođačToolStripMenuItem.Text = "Izvođač";
            // 
            // dodajIzvodjacaItem
            // 
            this.dodajIzvodjacaItem.Name = "dodajIzvodjacaItem";
            this.dodajIzvodjacaItem.Size = new System.Drawing.Size(237, 32);
            this.dodajIzvodjacaItem.Text = "Kreiraj izvđača";
            // 
            // izmeniIzvodjacaItem
            // 
            this.izmeniIzvodjacaItem.Name = "izmeniIzvodjacaItem";
            this.izmeniIzvodjacaItem.Size = new System.Drawing.Size(237, 32);
            this.izmeniIzvodjacaItem.Text = "Izmeni izvođača";
            // 
            // muzickaGrupaToolStripMenuItem
            // 
            this.muzickaGrupaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajMuzickuGrupuItem,
            this.pretraziMuzickuGrupuItem});
            this.muzickaGrupaToolStripMenuItem.Name = "muzickaGrupaToolStripMenuItem";
            this.muzickaGrupaToolStripMenuItem.Size = new System.Drawing.Size(165, 32);
            this.muzickaGrupaToolStripMenuItem.Text = "Muzička grupa";
            // 
            // dodajMuzickuGrupuItem
            // 
            this.dodajMuzickuGrupuItem.Name = "dodajMuzickuGrupuItem";
            this.dodajMuzickuGrupuItem.Size = new System.Drawing.Size(296, 32);
            this.dodajMuzickuGrupuItem.Text = "Kreiraj muzičku grupu";
            // 
            // pretraziMuzickuGrupuItem
            // 
            this.pretraziMuzickuGrupuItem.Name = "pretraziMuzickuGrupuItem";
            this.pretraziMuzickuGrupuItem.Size = new System.Drawing.Size(296, 32);
            this.pretraziMuzickuGrupuItem.Text = "Izmeni muzičku grupu";
            // 
            // kreirajNastupToolStripMenuItem
            // 
            this.kreirajNastupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajNastupItem,
            this.pretraziNastupItem});
            this.kreirajNastupToolStripMenuItem.Name = "kreirajNastupToolStripMenuItem";
            this.kreirajNastupToolStripMenuItem.Size = new System.Drawing.Size(93, 32);
            this.kreirajNastupToolStripMenuItem.Text = "Nastup";
            // 
            // dodajNastupItem
            // 
            this.dodajNastupItem.Name = "dodajNastupItem";
            this.dodajNastupItem.Size = new System.Drawing.Size(218, 32);
            this.dodajNastupItem.Text = "Kreiraj nastup";
            // 
            // pretraziNastupItem
            // 
            this.pretraziNastupItem.Name = "pretraziNastupItem";
            this.pretraziNastupItem.Size = new System.Drawing.Size(218, 32);
            this.pretraziNastupItem.Text = "Izmeni nastup";
            // 
            // pnlMain
            // 
            this.pnlMain.AutoSize = true;
            this.pnlMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 36);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(621, 337);
            this.pnlMain.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Aqua;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(524, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(98, 36);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblKorisnik
            // 
            this.lblKorisnik.AutoSize = true;
            this.lblKorisnik.BackColor = System.Drawing.Color.Transparent;
            this.lblKorisnik.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorisnik.Location = new System.Drawing.Point(366, 8);
            this.lblKorisnik.Name = "lblKorisnik";
            this.lblKorisnik.Size = new System.Drawing.Size(101, 22);
            this.lblKorisnik.TabIndex = 4;
            this.lblKorisnik.Text = "lblKorisnik";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(621, 373);
            this.Controls.Add(this.lblKorisnik);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuMain);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Muzički asambl";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kreirajMuzickuGrupuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretraziMuzickuGrupuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmeniMuzickuGruopuToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem muzickaGrupaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajMuzickuGrupuItem;
        private System.Windows.Forms.ToolStripMenuItem pretraziMuzickuGrupuItem;
        private System.Windows.Forms.ToolStripMenuItem izvođačToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajIzvodjacaItem;
        private System.Windows.Forms.ToolStripMenuItem izmeniIzvodjacaItem;
        private System.Windows.Forms.ToolStripMenuItem kreirajNastupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNastupItem;
        private System.Windows.Forms.ToolStripMenuItem pretraziNastupItem;
        internal System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblKorisnik;
        internal System.Windows.Forms.Button btnLogout;
    }
}