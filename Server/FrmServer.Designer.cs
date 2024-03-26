namespace Server
{
    partial class FrmServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServer));
            this.lblPokrenut = new System.Windows.Forms.Label();
            this.btnPokreni = new System.Windows.Forms.Button();
            this.btnStopiraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPokrenut
            // 
            this.lblPokrenut.AutoSize = true;
            this.lblPokrenut.BackColor = System.Drawing.SystemColors.Control;
            this.lblPokrenut.Font = new System.Drawing.Font("Lucida Fax", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPokrenut.ForeColor = System.Drawing.Color.Crimson;
            this.lblPokrenut.Location = new System.Drawing.Point(77, 65);
            this.lblPokrenut.Name = "lblPokrenut";
            this.lblPokrenut.Size = new System.Drawing.Size(255, 25);
            this.lblPokrenut.TabIndex = 8;
            this.lblPokrenut.Text = "Server nije pokrenut...";
            // 
            // btnPokreni
            // 
            this.btnPokreni.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPokreni.ForeColor = System.Drawing.Color.Cyan;
            this.btnPokreni.Location = new System.Drawing.Point(14, 8);
            this.btnPokreni.Name = "btnPokreni";
            this.btnPokreni.Size = new System.Drawing.Size(382, 49);
            this.btnPokreni.TabIndex = 7;
            this.btnPokreni.Text = "Pokreni server";
            this.btnPokreni.UseVisualStyleBackColor = true;
            this.btnPokreni.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStopiraj
            // 
            this.btnStopiraj.Enabled = false;
            this.btnStopiraj.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopiraj.ForeColor = System.Drawing.Color.Cyan;
            this.btnStopiraj.Location = new System.Drawing.Point(12, 98);
            this.btnStopiraj.Name = "btnStopiraj";
            this.btnStopiraj.Size = new System.Drawing.Size(384, 48);
            this.btnStopiraj.TabIndex = 9;
            this.btnStopiraj.Text = "Stopiraj server";
            this.btnStopiraj.UseVisualStyleBackColor = true;
            this.btnStopiraj.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 158);
            this.Controls.Add(this.btnStopiraj);
            this.Controls.Add(this.lblPokrenut);
            this.Controls.Add(this.btnPokreni);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmServer";
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmServer_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPokrenut;
        private System.Windows.Forms.Button btnPokreni;
        private System.Windows.Forms.Button btnStopiraj;
    }
}

