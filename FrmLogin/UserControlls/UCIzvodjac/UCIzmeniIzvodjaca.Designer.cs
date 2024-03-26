namespace FrmLogin.UserControlls.UCIzvodjac
{
    partial class UCIzmeniIzvodjaca
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.dgvIzvodjac = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblZaUnos = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvodjac)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.MediumBlue;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnBack.Location = new System.Drawing.Point(28, 385);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 49);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Nazad";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.MediumBlue;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnEdit.Location = new System.Drawing.Point(385, 385);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(181, 49);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Izmeni izvođača";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblNaslov.Location = new System.Drawing.Point(11, 5);
            this.lblNaslov.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(205, 32);
            this.lblNaslov.TabIndex = 11;
            this.lblNaslov.Text = "Pretraga izvođača";
            // 
            // dgvIzvodjac
            // 
            this.dgvIzvodjac.AllowUserToAddRows = false;
            this.dgvIzvodjac.AllowUserToDeleteRows = false;
            this.dgvIzvodjac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIzvodjac.BackgroundColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIzvodjac.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvIzvodjac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIzvodjac.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvIzvodjac.GridColor = System.Drawing.Color.BlanchedAlmond;
            this.dgvIzvodjac.Location = new System.Drawing.Point(28, 105);
            this.dgvIzvodjac.Margin = new System.Windows.Forms.Padding(2);
            this.dgvIzvodjac.MultiSelect = false;
            this.dgvIzvodjac.Name = "dgvIzvodjac";
            this.dgvIzvodjac.ReadOnly = true;
            this.dgvIzvodjac.RowHeadersWidth = 51;
            this.dgvIzvodjac.RowTemplate.Height = 24;
            this.dgvIzvodjac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIzvodjac.Size = new System.Drawing.Size(537, 259);
            this.dgvIzvodjac.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MediumBlue;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnSearch.Location = new System.Drawing.Point(455, 52);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 39);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(284, 57);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(165, 29);
            this.txtSearch.TabIndex = 8;
            // 
            // lblZaUnos
            // 
            this.lblZaUnos.AutoSize = true;
            this.lblZaUnos.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZaUnos.Location = new System.Drawing.Point(21, 60);
            this.lblZaUnos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZaUnos.Name = "lblZaUnos";
            this.lblZaUnos.Size = new System.Drawing.Size(258, 21);
            this.lblZaUnos.TabIndex = 7;
            this.lblZaUnos.Text = "Unesite ime izvođača za pretragu:";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.MediumBlue;
            this.btnShow.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnShow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
            this.btnShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnShow.Location = new System.Drawing.Point(161, 385);
            this.btnShow.Margin = new System.Windows.Forms.Padding(2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(220, 49);
            this.btnShow.TabIndex = 14;
            this.btnShow.Text = "Prikaži detalje";
            this.btnShow.UseVisualStyleBackColor = false;
            // 
            // UCIzmeniIzvodjaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.dgvIzvodjac);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblZaUnos);
            this.Name = "UCIzmeniIzvodjaca";
            this.Size = new System.Drawing.Size(593, 451);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvodjac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblNaslov;
        internal System.Windows.Forms.DataGridView dgvIzvodjac;
        internal System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblZaUnos;
        internal System.Windows.Forms.Button btnShow;
    }
}
