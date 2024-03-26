namespace FrmLogin.UserControlls.UCNastup
{
    partial class UCSingleNastup
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNaslov = new System.Windows.Forms.Label();
            this.txtDatumOdrzavanja = new System.Windows.Forms.DateTimePicker();
            this.lblCena = new System.Windows.Forms.Label();
            this.txtCenaUlaznice = new System.Windows.Forms.TextBox();
            this.lblDatumOdrzavanja = new System.Windows.Forms.Label();
            this.lblGrupa = new System.Windows.Forms.Label();
            this.lblKoncert = new System.Windows.Forms.Label();
            this.cbKoncert = new System.Windows.Forms.ComboBox();
            this.cbGrupa = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.lblIdNastupa = new System.Windows.Forms.Label();
            this.lblValuta = new System.Windows.Forms.Label();
            this.lblAdresaGreska = new System.Windows.Forms.Label();
            this.lblNazivGreska = new System.Windows.Forms.Label();
            this.lblCenaGreska = new System.Windows.Forms.Label();
            this.lblRedniBrTacke = new System.Windows.Forms.Label();
            this.lblRBTacke = new System.Windows.Forms.Label();
            this.txtRBTacke = new System.Windows.Forms.TextBox();
            this.dgvNastupi = new System.Windows.Forms.DataGridView();
            this.btnDodajNastup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNastupi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNaslov
            // 
            this.txtNaslov.AutoSize = true;
            this.txtNaslov.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNaslov.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaslov.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtNaslov.Location = new System.Drawing.Point(8, 15);
            this.txtNaslov.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(166, 32);
            this.txtNaslov.TabIndex = 3;
            this.txtNaslov.Text = "Dodaj nastupa";
            // 
            // txtDatumOdrzavanja
            // 
            this.txtDatumOdrzavanja.AllowDrop = true;
            this.txtDatumOdrzavanja.Location = new System.Drawing.Point(221, 160);
            this.txtDatumOdrzavanja.Name = "txtDatumOdrzavanja";
            this.txtDatumOdrzavanja.Size = new System.Drawing.Size(313, 20);
            this.txtDatumOdrzavanja.TabIndex = 26;
            this.txtDatumOdrzavanja.Value = new System.DateTime(2022, 12, 20, 0, 0, 0, 0);
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCena.Location = new System.Drawing.Point(44, 206);
            this.lblCena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(116, 21);
            this.lblCena.TabIndex = 25;
            this.lblCena.Text = "Cena ulaznice:";
            // 
            // txtCenaUlaznice
            // 
            this.txtCenaUlaznice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCenaUlaznice.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCenaUlaznice.Location = new System.Drawing.Point(221, 204);
            this.txtCenaUlaznice.Margin = new System.Windows.Forms.Padding(2);
            this.txtCenaUlaznice.MaxLength = 30;
            this.txtCenaUlaznice.Name = "txtCenaUlaznice";
            this.txtCenaUlaznice.Size = new System.Drawing.Size(313, 29);
            this.txtCenaUlaznice.TabIndex = 24;
            // 
            // lblDatumOdrzavanja
            // 
            this.lblDatumOdrzavanja.AutoSize = true;
            this.lblDatumOdrzavanja.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumOdrzavanja.Location = new System.Drawing.Point(44, 159);
            this.lblDatumOdrzavanja.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatumOdrzavanja.Name = "lblDatumOdrzavanja";
            this.lblDatumOdrzavanja.Size = new System.Drawing.Size(148, 21);
            this.lblDatumOdrzavanja.TabIndex = 23;
            this.lblDatumOdrzavanja.Text = "Datum održavanja:";
            // 
            // lblGrupa
            // 
            this.lblGrupa.AutoSize = true;
            this.lblGrupa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupa.Location = new System.Drawing.Point(44, 116);
            this.lblGrupa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGrupa.Name = "lblGrupa";
            this.lblGrupa.Size = new System.Drawing.Size(108, 21);
            this.lblGrupa.TabIndex = 28;
            this.lblGrupa.Text = "Naziv Grupe:";
            // 
            // lblKoncert
            // 
            this.lblKoncert.AutoSize = true;
            this.lblKoncert.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKoncert.Location = new System.Drawing.Point(44, 67);
            this.lblKoncert.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKoncert.Name = "lblKoncert";
            this.lblKoncert.Size = new System.Drawing.Size(136, 21);
            this.lblKoncert.TabIndex = 27;
            this.lblKoncert.Text = "Adresa koncerta:";
            // 
            // cbKoncert
            // 
            this.cbKoncert.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbKoncert.FormattingEnabled = true;
            this.cbKoncert.Location = new System.Drawing.Point(221, 67);
            this.cbKoncert.Name = "cbKoncert";
            this.cbKoncert.Size = new System.Drawing.Size(313, 21);
            this.cbKoncert.TabIndex = 29;
            // 
            // cbGrupa
            // 
            this.cbGrupa.FormattingEnabled = true;
            this.cbGrupa.Location = new System.Drawing.Point(221, 116);
            this.cbGrupa.Name = "cbGrupa";
            this.cbGrupa.Size = new System.Drawing.Size(313, 21);
            this.cbGrupa.TabIndex = 30;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.MediumBlue;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnBack.Location = new System.Drawing.Point(38, 508);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(136, 41);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "Nazad";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.MediumBlue;
            this.btnSacuvaj.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnSacuvaj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
            this.btnSacuvaj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.btnSacuvaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacuvaj.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnSacuvaj.Location = new System.Drawing.Point(374, 508);
            this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(212, 41);
            this.btnSacuvaj.TabIndex = 32;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            // 
            // lblIdNastupa
            // 
            this.lblIdNastupa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIdNastupa.AutoSize = true;
            this.lblIdNastupa.Location = new System.Drawing.Point(335, 34);
            this.lblIdNastupa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdNastupa.Name = "lblIdNastupa";
            this.lblIdNastupa.Size = new System.Drawing.Size(0, 13);
            this.lblIdNastupa.TabIndex = 33;
            this.lblIdNastupa.Visible = false;
            // 
            // lblValuta
            // 
            this.lblValuta.AutoSize = true;
            this.lblValuta.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValuta.Location = new System.Drawing.Point(552, 208);
            this.lblValuta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValuta.Name = "lblValuta";
            this.lblValuta.Size = new System.Drawing.Size(47, 21);
            this.lblValuta.TabIndex = 34;
            this.lblValuta.Text = "RSD";
            // 
            // lblAdresaGreska
            // 
            this.lblAdresaGreska.AutoSize = true;
            this.lblAdresaGreska.ForeColor = System.Drawing.Color.Crimson;
            this.lblAdresaGreska.Location = new System.Drawing.Point(222, 94);
            this.lblAdresaGreska.Name = "lblAdresaGreska";
            this.lblAdresaGreska.Size = new System.Drawing.Size(0, 13);
            this.lblAdresaGreska.TabIndex = 35;
            // 
            // lblNazivGreska
            // 
            this.lblNazivGreska.AutoSize = true;
            this.lblNazivGreska.ForeColor = System.Drawing.Color.Crimson;
            this.lblNazivGreska.Location = new System.Drawing.Point(222, 142);
            this.lblNazivGreska.Name = "lblNazivGreska";
            this.lblNazivGreska.Size = new System.Drawing.Size(0, 13);
            this.lblNazivGreska.TabIndex = 36;
            // 
            // lblCenaGreska
            // 
            this.lblCenaGreska.AutoSize = true;
            this.lblCenaGreska.ForeColor = System.Drawing.Color.Crimson;
            this.lblCenaGreska.Location = new System.Drawing.Point(222, 245);
            this.lblCenaGreska.Name = "lblCenaGreska";
            this.lblCenaGreska.Size = new System.Drawing.Size(0, 13);
            this.lblCenaGreska.TabIndex = 37;
            // 
            // lblRedniBrTacke
            // 
            this.lblRedniBrTacke.AutoSize = true;
            this.lblRedniBrTacke.ForeColor = System.Drawing.Color.Crimson;
            this.lblRedniBrTacke.Location = new System.Drawing.Point(222, 303);
            this.lblRedniBrTacke.Name = "lblRedniBrTacke";
            this.lblRedniBrTacke.Size = new System.Drawing.Size(0, 13);
            this.lblRedniBrTacke.TabIndex = 40;
            // 
            // lblRBTacke
            // 
            this.lblRBTacke.AutoSize = true;
            this.lblRBTacke.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRBTacke.Location = new System.Drawing.Point(44, 268);
            this.lblRBTacke.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRBTacke.Name = "lblRBTacke";
            this.lblRBTacke.Size = new System.Drawing.Size(137, 21);
            this.lblRBTacke.TabIndex = 39;
            this.lblRBTacke.Text = "Redni broj tacke:";
            // 
            // txtRBTacke
            // 
            this.txtRBTacke.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRBTacke.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRBTacke.Location = new System.Drawing.Point(221, 266);
            this.txtRBTacke.Margin = new System.Windows.Forms.Padding(2);
            this.txtRBTacke.MaxLength = 30;
            this.txtRBTacke.Name = "txtRBTacke";
            this.txtRBTacke.Size = new System.Drawing.Size(313, 29);
            this.txtRBTacke.TabIndex = 38;
            // 
            // dgvNastupi
            // 
            this.dgvNastupi.AllowUserToAddRows = false;
            this.dgvNastupi.AllowUserToDeleteRows = false;
            this.dgvNastupi.BackgroundColor = System.Drawing.Color.MediumBlue;
            this.dgvNastupi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNastupi.Location = new System.Drawing.Point(38, 375);
            this.dgvNastupi.Name = "dgvNastupi";
            this.dgvNastupi.ReadOnly = true;
            this.dgvNastupi.Size = new System.Drawing.Size(548, 120);
            this.dgvNastupi.TabIndex = 41;
            // 
            // btnDodajNastup
            // 
            this.btnDodajNastup.BackColor = System.Drawing.Color.MediumBlue;
            this.btnDodajNastup.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnDodajNastup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
            this.btnDodajNastup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.btnDodajNastup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajNastup.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajNastup.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnDodajNastup.Location = new System.Drawing.Point(374, 320);
            this.btnDodajNastup.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajNastup.Name = "btnDodajNastup";
            this.btnDodajNastup.Size = new System.Drawing.Size(212, 41);
            this.btnDodajNastup.TabIndex = 42;
            this.btnDodajNastup.Text = "Dodaj nastup";
            this.btnDodajNastup.UseVisualStyleBackColor = false;
            // 
            // UCSingleNastup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnDodajNastup);
            this.Controls.Add(this.dgvNastupi);
            this.Controls.Add(this.lblRedniBrTacke);
            this.Controls.Add(this.lblRBTacke);
            this.Controls.Add(this.txtRBTacke);
            this.Controls.Add(this.lblCenaGreska);
            this.Controls.Add(this.lblNazivGreska);
            this.Controls.Add(this.lblAdresaGreska);
            this.Controls.Add(this.lblValuta);
            this.Controls.Add(this.lblIdNastupa);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbGrupa);
            this.Controls.Add(this.cbKoncert);
            this.Controls.Add(this.lblGrupa);
            this.Controls.Add(this.lblKoncert);
            this.Controls.Add(this.txtDatumOdrzavanja);
            this.Controls.Add(this.lblCena);
            this.Controls.Add(this.txtCenaUlaznice);
            this.Controls.Add(this.lblDatumOdrzavanja);
            this.Controls.Add(this.txtNaslov);
            this.Name = "UCSingleNastup";
            this.Size = new System.Drawing.Size(609, 560);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNastupi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label txtNaslov;
        internal System.Windows.Forms.DateTimePicker txtDatumOdrzavanja;
        private System.Windows.Forms.Label lblCena;
        internal System.Windows.Forms.TextBox txtCenaUlaznice;
        private System.Windows.Forms.Label lblDatumOdrzavanja;
        private System.Windows.Forms.Label lblGrupa;
        private System.Windows.Forms.Label lblKoncert;
        internal System.Windows.Forms.ComboBox cbKoncert;
        internal System.Windows.Forms.ComboBox cbGrupa;
        internal System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.Button btnSacuvaj;
        internal System.Windows.Forms.Label lblIdNastupa;
        private System.Windows.Forms.Label lblValuta;
        internal System.Windows.Forms.Label lblAdresaGreska;
        internal System.Windows.Forms.Label lblNazivGreska;
        internal System.Windows.Forms.Label lblCenaGreska;
        internal System.Windows.Forms.Label lblRedniBrTacke;
        private System.Windows.Forms.Label lblRBTacke;
        internal System.Windows.Forms.TextBox txtRBTacke;
        internal System.Windows.Forms.Button btnDodajNastup;
        internal System.Windows.Forms.DataGridView dgvNastupi;
    }
}
