
namespace Definitif_Mathilde_App
{
    partial class Acceuil_Authentification
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
            this.txtbIdentifiant = new System.Windows.Forms.TextBox();
            this.txtbMotDePasse = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.lblMotDePasseOublie = new System.Windows.Forms.Label();
            this.lblMotDePasse = new System.Windows.Forms.Label();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.lblNotif = new System.Windows.Forms.Label();
            this.lblTitre_Authntification = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbIdentifiant
            // 
            this.txtbIdentifiant.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbIdentifiant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbIdentifiant.Location = new System.Drawing.Point(292, 228);
            this.txtbIdentifiant.Name = "txtbIdentifiant";
            this.txtbIdentifiant.Size = new System.Drawing.Size(297, 37);
            this.txtbIdentifiant.TabIndex = 1;
            this.txtbIdentifiant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbIdentifiant.TextChanged += new System.EventHandler(this.txtbIdentifiant_TextChanged);
            // 
            // txtbMotDePasse
            // 
            this.txtbMotDePasse.BackColor = System.Drawing.Color.White;
            this.txtbMotDePasse.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbMotDePasse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbMotDePasse.Location = new System.Drawing.Point(292, 339);
            this.txtbMotDePasse.Name = "txtbMotDePasse";
            this.txtbMotDePasse.Size = new System.Drawing.Size(297, 37);
            this.txtbMotDePasse.TabIndex = 2;
            this.txtbMotDePasse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbMotDePasse.TextChanged += new System.EventHandler(this.txtbMotDePasse_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnConnexion);
            this.panel1.Controls.Add(this.lblMotDePasseOublie);
            this.panel1.Controls.Add(this.lblMotDePasse);
            this.panel1.Controls.Add(this.lblIdentifiant);
            this.panel1.Controls.Add(this.lblNotif);
            this.panel1.Controls.Add(this.txtbIdentifiant);
            this.panel1.Controls.Add(this.lblTitre_Authntification);
            this.panel1.Controls.Add(this.txtbMotDePasse);
            this.panel1.Controls.Add(this.btnQuitter);
            this.panel1.Location = new System.Drawing.Point(5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 598);
            this.panel1.TabIndex = 9;
            // 
            // btnConnexion
            // 
            this.btnConnexion.BackColor = System.Drawing.Color.Goldenrod;
            this.btnConnexion.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btnConnexion.FlatAppearance.BorderSize = 2;
            this.btnConnexion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnConnexion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnexion.Font = new System.Drawing.Font("Maiandra GD", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConnexion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConnexion.Location = new System.Drawing.Point(370, 431);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(146, 42);
            this.btnConnexion.TabIndex = 21;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = false;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // lblMotDePasseOublie
            // 
            this.lblMotDePasseOublie.BackColor = System.Drawing.Color.Transparent;
            this.lblMotDePasseOublie.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMotDePasseOublie.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblMotDePasseOublie.Location = new System.Drawing.Point(7, 477);
            this.lblMotDePasseOublie.Name = "lblMotDePasseOublie";
            this.lblMotDePasseOublie.Size = new System.Drawing.Size(876, 36);
            this.lblMotDePasseOublie.TabIndex = 20;
            this.lblMotDePasseOublie.Text = "Mot de passe oublié?";
            this.lblMotDePasseOublie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMotDePasse.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMotDePasse.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblMotDePasse.Location = new System.Drawing.Point(0, 299);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(886, 37);
            this.lblMotDePasse.TabIndex = 19;
            this.lblMotDePasse.Text = "Mot de passe";
            this.lblMotDePasse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIdentifiant.Font = new System.Drawing.Font("Maiandra GD", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdentifiant.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblIdentifiant.Location = new System.Drawing.Point(-3, 183);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(889, 42);
            this.lblIdentifiant.TabIndex = 18;
            this.lblIdentifiant.Text = "Identifiant";
            this.lblIdentifiant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNotif
            // 
            this.lblNotif.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNotif.Font = new System.Drawing.Font("Maiandra GD", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNotif.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblNotif.Location = new System.Drawing.Point(3, 387);
            this.lblNotif.Name = "lblNotif";
            this.lblNotif.Size = new System.Drawing.Size(876, 36);
            this.lblNotif.TabIndex = 17;
            this.lblNotif.Text = "Votre mot de passe est incorrecte";
            this.lblNotif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitre_Authntification
            // 
            this.lblTitre_Authntification.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitre_Authntification.Font = new System.Drawing.Font("Maiandra GD", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitre_Authntification.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitre_Authntification.Location = new System.Drawing.Point(0, 81);
            this.lblTitre_Authntification.Name = "lblTitre_Authntification";
            this.lblTitre_Authntification.Size = new System.Drawing.Size(889, 72);
            this.lblTitre_Authntification.TabIndex = 12;
            this.lblTitre_Authntification.Text = "Authentification";
            this.lblTitre_Authntification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.Goldenrod;
            this.btnQuitter.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btnQuitter.FlatAppearance.BorderSize = 2;
            this.btnQuitter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnQuitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Maiandra GD", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuitter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuitter.Location = new System.Drawing.Point(690, 516);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(146, 42);
            this.btnQuitter.TabIndex = 11;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // Acceuil_Authentification
            // 
            this.AcceptButton = this.btnConnexion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(900, 610);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Acceuil_Authentification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentification";
            this.Load += new System.EventHandler(this.Acceuil_Authentification_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtbIdentifiant;
        private System.Windows.Forms.TextBox txtbMotDePasse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblTitre_Authntification;
        private System.Windows.Forms.Label lblMotDePasseOublie;
        private System.Windows.Forms.Label lblMotDePasse;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.Label lblNotif;
        private System.Windows.Forms.Button btnConnexion;
    }
}