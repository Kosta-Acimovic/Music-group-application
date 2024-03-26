namespace FrmLogin.UserControlls
{
    partial class UCDefaultMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDefaultMain));
            this.btnZakazi = new System.Windows.Forms.Button();
            this.lblVreme = new System.Windows.Forms.Label();
            this.lblVremeDoKraja = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnZakazi
            // 
            this.btnZakazi.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnZakazi.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnZakazi.FlatAppearance.BorderSize = 2;
            this.btnZakazi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
            this.btnZakazi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.btnZakazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZakazi.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZakazi.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnZakazi.Location = new System.Drawing.Point(172, 312);
            this.btnZakazi.Margin = new System.Windows.Forms.Padding(2);
            this.btnZakazi.Name = "btnZakazi";
            this.btnZakazi.Size = new System.Drawing.Size(285, 98);
            this.btnZakazi.TabIndex = 1;
            this.btnZakazi.Text = "Dodaj nastup";
            this.btnZakazi.UseVisualStyleBackColor = false;
            // 
            // lblVreme
            // 
            this.lblVreme.AutoSize = true;
            this.lblVreme.BackColor = System.Drawing.Color.Transparent;
            this.lblVreme.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVreme.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblVreme.Location = new System.Drawing.Point(510, 10);
            this.lblVreme.Name = "lblVreme";
            this.lblVreme.Size = new System.Drawing.Size(0, 31);
            this.lblVreme.TabIndex = 39;
            // 
            // lblVremeDoKraja
            // 
            this.lblVremeDoKraja.AutoSize = true;
            this.lblVremeDoKraja.BackColor = System.Drawing.Color.Transparent;
            this.lblVremeDoKraja.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVremeDoKraja.ForeColor = System.Drawing.Color.Red;
            this.lblVremeDoKraja.Location = new System.Drawing.Point(480, 312);
            this.lblVremeDoKraja.Name = "lblVremeDoKraja";
            this.lblVremeDoKraja.Size = new System.Drawing.Size(0, 32);
            this.lblVremeDoKraja.TabIndex = 40;
            // 
            // UCDefaultMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.lblVremeDoKraja);
            this.Controls.Add(this.lblVreme);
            this.Controls.Add(this.btnZakazi);
            this.Name = "UCDefaultMain";
            this.Size = new System.Drawing.Size(620, 461);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnZakazi;
        internal System.Windows.Forms.Label lblVreme;
        internal System.Windows.Forms.Label lblVremeDoKraja;
    }
}
