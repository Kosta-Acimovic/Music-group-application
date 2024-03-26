namespace FrmLogin.UserControlls.UCIzvodjac
{
    partial class UCSingleIzvodjac
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
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblDatumRodjenja = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.lblNastup = new System.Windows.Forms.Label();
            this.txtNastup = new System.Windows.Forms.TextBox();
            this.lblIdIzvodjaca = new System.Windows.Forms.Label();
            this.txtDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.lblGrupa = new System.Windows.Forms.Label();
            this.cbGrupa = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblDatumGreska = new System.Windows.Forms.Label();
            this.lblNastupGreska = new System.Windows.Forms.Label();
            this.lblGrupaGreska = new System.Windows.Forms.Label();
            this.lblPrezimeGreska = new System.Windows.Forms.Label();
            this.lblImeGreska = new System.Windows.Forms.Label();
            this.btnDodajIzvodjaca = new System.Windows.Forms.Button();
            this.dgvIzvodjaci = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvodjaci)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNaslov
            // 
            this.txtNaslov.AutoSize = true;
            this.txtNaslov.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaslov.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtNaslov.Location = new System.Drawing.Point(38, 20);
            this.txtNaslov.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(190, 32);
            this.txtNaslov.TabIndex = 11;
            this.txtNaslov.Text = "Dodaj Izvodjaca";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezime.Location = new System.Drawing.Point(40, 129);
            this.lblPrezime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(73, 21);
            this.lblPrezime.TabIndex = 10;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.Location = new System.Drawing.Point(40, 74);
            this.lblIme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(42, 21);
            this.lblIme.TabIndex = 9;
            this.lblIme.Text = "Ime:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrezime.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrezime.Location = new System.Drawing.Point(217, 127);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrezime.MaxLength = 30;
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(340, 29);
            this.txtPrezime.TabIndex = 8;
            // 
            // txtIme
            // 
            this.txtIme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIme.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIme.Location = new System.Drawing.Point(216, 72);
            this.txtIme.Margin = new System.Windows.Forms.Padding(2);
            this.txtIme.MaxLength = 30;
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(341, 29);
            this.txtIme.TabIndex = 7;
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
            this.btnBack.Location = new System.Drawing.Point(29, 516);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 42);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Nazad";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // lblDatumRodjenja
            // 
            this.lblDatumRodjenja.AutoSize = true;
            this.lblDatumRodjenja.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumRodjenja.Location = new System.Drawing.Point(40, 182);
            this.lblDatumRodjenja.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatumRodjenja.Name = "lblDatumRodjenja";
            this.lblDatumRodjenja.Size = new System.Drawing.Size(123, 21);
            this.lblDatumRodjenja.TabIndex = 16;
            this.lblDatumRodjenja.Text = "Datum rođenja:";
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
            this.btnSacuvaj.Location = new System.Drawing.Point(216, 516);
            this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(189, 42);
            this.btnSacuvaj.TabIndex = 15;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            // 
            // lblNastup
            // 
            this.lblNastup.AutoSize = true;
            this.lblNastup.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNastup.Location = new System.Drawing.Point(40, 231);
            this.lblNastup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNastup.Name = "lblNastup";
            this.lblNastup.Size = new System.Drawing.Size(112, 21);
            this.lblNastup.TabIndex = 20;
            this.lblNastup.Text = "Broj Nastupa:";
            // 
            // txtNastup
            // 
            this.txtNastup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNastup.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNastup.Location = new System.Drawing.Point(216, 229);
            this.txtNastup.Margin = new System.Windows.Forms.Padding(2);
            this.txtNastup.MaxLength = 30;
            this.txtNastup.Name = "txtNastup";
            this.txtNastup.Size = new System.Drawing.Size(341, 29);
            this.txtNastup.TabIndex = 19;
            // 
            // lblIdIzvodjaca
            // 
            this.lblIdIzvodjaca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIdIzvodjaca.AutoSize = true;
            this.lblIdIzvodjaca.Location = new System.Drawing.Point(326, 39);
            this.lblIdIzvodjaca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdIzvodjaca.Name = "lblIdIzvodjaca";
            this.lblIdIzvodjaca.Size = new System.Drawing.Size(0, 13);
            this.lblIdIzvodjaca.TabIndex = 21;
            this.lblIdIzvodjaca.Visible = false;
            // 
            // txtDatumRodjenja
            // 
            this.txtDatumRodjenja.AllowDrop = true;
            this.txtDatumRodjenja.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.txtDatumRodjenja.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.txtDatumRodjenja.Location = new System.Drawing.Point(217, 183);
            this.txtDatumRodjenja.Name = "txtDatumRodjenja";
            this.txtDatumRodjenja.Size = new System.Drawing.Size(340, 20);
            this.txtDatumRodjenja.TabIndex = 22;
            this.txtDatumRodjenja.Value = new System.DateTime(2023, 1, 3, 0, 0, 0, 0);
            // 
            // lblGrupa
            // 
            this.lblGrupa.AutoSize = true;
            this.lblGrupa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupa.Location = new System.Drawing.Point(40, 284);
            this.lblGrupa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGrupa.Name = "lblGrupa";
            this.lblGrupa.Size = new System.Drawing.Size(61, 21);
            this.lblGrupa.TabIndex = 23;
            this.lblGrupa.Text = "Grupa:";
            // 
            // cbGrupa
            // 
            this.cbGrupa.FormattingEnabled = true;
            this.cbGrupa.Location = new System.Drawing.Point(216, 284);
            this.cbGrupa.Name = "cbGrupa";
            this.cbGrupa.Size = new System.Drawing.Size(341, 21);
            this.cbGrupa.TabIndex = 24;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MediumBlue;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnDelete.Location = new System.Drawing.Point(473, 516);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 42);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Izbriši";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            // 
            // lblDatumGreska
            // 
            this.lblDatumGreska.AutoSize = true;
            this.lblDatumGreska.ForeColor = System.Drawing.Color.Crimson;
            this.lblDatumGreska.Location = new System.Drawing.Point(217, 210);
            this.lblDatumGreska.Name = "lblDatumGreska";
            this.lblDatumGreska.Size = new System.Drawing.Size(0, 13);
            this.lblDatumGreska.TabIndex = 26;
            // 
            // lblNastupGreska
            // 
            this.lblNastupGreska.AutoSize = true;
            this.lblNastupGreska.ForeColor = System.Drawing.Color.Crimson;
            this.lblNastupGreska.Location = new System.Drawing.Point(217, 265);
            this.lblNastupGreska.Name = "lblNastupGreska";
            this.lblNastupGreska.Size = new System.Drawing.Size(0, 13);
            this.lblNastupGreska.TabIndex = 27;
            // 
            // lblGrupaGreska
            // 
            this.lblGrupaGreska.AutoSize = true;
            this.lblGrupaGreska.ForeColor = System.Drawing.Color.Crimson;
            this.lblGrupaGreska.Location = new System.Drawing.Point(217, 309);
            this.lblGrupaGreska.Name = "lblGrupaGreska";
            this.lblGrupaGreska.Size = new System.Drawing.Size(0, 13);
            this.lblGrupaGreska.TabIndex = 28;
            // 
            // lblPrezimeGreska
            // 
            this.lblPrezimeGreska.AutoSize = true;
            this.lblPrezimeGreska.ForeColor = System.Drawing.Color.Crimson;
            this.lblPrezimeGreska.Location = new System.Drawing.Point(217, 162);
            this.lblPrezimeGreska.Name = "lblPrezimeGreska";
            this.lblPrezimeGreska.Size = new System.Drawing.Size(0, 13);
            this.lblPrezimeGreska.TabIndex = 29;
            // 
            // lblImeGreska
            // 
            this.lblImeGreska.AutoSize = true;
            this.lblImeGreska.ForeColor = System.Drawing.Color.Crimson;
            this.lblImeGreska.Location = new System.Drawing.Point(217, 107);
            this.lblImeGreska.Name = "lblImeGreska";
            this.lblImeGreska.Size = new System.Drawing.Size(0, 13);
            this.lblImeGreska.TabIndex = 30;
            // 
            // btnDodajIzvodjaca
            // 
            this.btnDodajIzvodjaca.BackColor = System.Drawing.Color.MediumBlue;
            this.btnDodajIzvodjaca.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnDodajIzvodjaca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
            this.btnDodajIzvodjaca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.btnDodajIzvodjaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajIzvodjaca.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajIzvodjaca.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnDodajIzvodjaca.Location = new System.Drawing.Point(365, 330);
            this.btnDodajIzvodjaca.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajIzvodjaca.Name = "btnDodajIzvodjaca";
            this.btnDodajIzvodjaca.Size = new System.Drawing.Size(212, 41);
            this.btnDodajIzvodjaca.TabIndex = 44;
            this.btnDodajIzvodjaca.Text = "Dodaj izvođača";
            this.btnDodajIzvodjaca.UseVisualStyleBackColor = false;
            // 
            // dgvIzvodjaci
            // 
            this.dgvIzvodjaci.AllowUserToAddRows = false;
            this.dgvIzvodjaci.AllowUserToDeleteRows = false;
            this.dgvIzvodjaci.BackgroundColor = System.Drawing.Color.MediumBlue;
            this.dgvIzvodjaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzvodjaci.Location = new System.Drawing.Point(29, 385);
            this.dgvIzvodjaci.Name = "dgvIzvodjaci";
            this.dgvIzvodjaci.ReadOnly = true;
            this.dgvIzvodjaci.Size = new System.Drawing.Size(548, 120);
            this.dgvIzvodjaci.TabIndex = 43;
            // 
            // UCSingleIzvodjac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnDodajIzvodjaca);
            this.Controls.Add(this.dgvIzvodjaci);
            this.Controls.Add(this.lblImeGreska);
            this.Controls.Add(this.lblPrezimeGreska);
            this.Controls.Add(this.lblGrupaGreska);
            this.Controls.Add(this.lblNastupGreska);
            this.Controls.Add(this.lblDatumGreska);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbGrupa);
            this.Controls.Add(this.lblGrupa);
            this.Controls.Add(this.txtDatumRodjenja);
            this.Controls.Add(this.lblIdIzvodjaca);
            this.Controls.Add(this.lblNastup);
            this.Controls.Add(this.txtNastup);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblDatumRodjenja);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Name = "UCSingleIzvodjac";
            this.Size = new System.Drawing.Size(613, 578);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvodjaci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label txtNaslov;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblIme;
        internal System.Windows.Forms.TextBox txtPrezime;
        internal System.Windows.Forms.TextBox txtIme;
        internal System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblDatumRodjenja;
        internal System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label lblNastup;
        internal System.Windows.Forms.TextBox txtNastup;
        internal System.Windows.Forms.Label lblIdIzvodjaca;
        internal System.Windows.Forms.DateTimePicker txtDatumRodjenja;
        private System.Windows.Forms.Label lblGrupa;
        internal System.Windows.Forms.ComboBox cbGrupa;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Label lblDatumGreska;
        internal System.Windows.Forms.Label lblNastupGreska;
        internal System.Windows.Forms.Label lblGrupaGreska;
        internal System.Windows.Forms.Label lblPrezimeGreska;
        internal System.Windows.Forms.Label lblImeGreska;
        internal System.Windows.Forms.Button btnDodajIzvodjaca;
        internal System.Windows.Forms.DataGridView dgvIzvodjaci;
    }
}
