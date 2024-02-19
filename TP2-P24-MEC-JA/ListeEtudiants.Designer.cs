namespace TP2_P24_MEC_JA
{
    partial class FrmListeEtudiants
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListeEtudiants));
            this.Lbl_ListeEtudiants = new System.Windows.Forms.Label();
            this.Lst_Etudiants = new System.Windows.Forms.ListView();
            this.txtRechercheNom = new System.Windows.Forms.TextBox();
            this.lblRechercheNom = new System.Windows.Forms.Label();
            this.lblRecherchePrenom = new System.Windows.Forms.Label();
            this.txtRecherchePrenom = new System.Windows.Forms.TextBox();
            this.lblRechercheAdresse = new System.Windows.Forms.Label();
            this.txtRechercheAdresse = new System.Windows.Forms.TextBox();
            this.lblNombreEtudiants = new System.Windows.Forms.Label();
            this.lblNombreEtudiantTitre = new System.Windows.Forms.Label();
            this.lblRechercheCodePermanent = new System.Windows.Forms.Label();
            this.txtRechercheCodePermanent = new System.Windows.Forms.TextBox();
            this.cmdQuitterListe = new System.Windows.Forms.Button();
            this.grpRechercheListe = new System.Windows.Forms.GroupBox();
            this.grpRechercheListe.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_ListeEtudiants
            // 
            this.Lbl_ListeEtudiants.AutoSize = true;
            this.Lbl_ListeEtudiants.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ListeEtudiants.Location = new System.Drawing.Point(46, 7);
            this.Lbl_ListeEtudiants.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_ListeEtudiants.Name = "Lbl_ListeEtudiants";
            this.Lbl_ListeEtudiants.Size = new System.Drawing.Size(204, 24);
            this.Lbl_ListeEtudiants.TabIndex = 0;
            this.Lbl_ListeEtudiants.Text = "Liste Des Étudiants";
            this.Lbl_ListeEtudiants.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lst_Etudiants
            // 
            this.Lst_Etudiants.BackColor = System.Drawing.Color.Silver;
            this.Lst_Etudiants.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lst_Etudiants.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Lst_Etudiants.GridLines = true;
            this.Lst_Etudiants.HideSelection = false;
            this.Lst_Etudiants.Location = new System.Drawing.Point(0, 182);
            this.Lst_Etudiants.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Lst_Etudiants.Name = "Lst_Etudiants";
            this.Lst_Etudiants.Size = new System.Drawing.Size(1228, 500);
            this.Lst_Etudiants.TabIndex = 1;
            this.Lst_Etudiants.UseCompatibleStateImageBehavior = false;
            this.Lst_Etudiants.View = System.Windows.Forms.View.Details;
            // 
            // txtRechercheNom
            // 
            this.txtRechercheNom.Location = new System.Drawing.Point(307, 28);
            this.txtRechercheNom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRechercheNom.Name = "txtRechercheNom";
            this.txtRechercheNom.Size = new System.Drawing.Size(327, 25);
            this.txtRechercheNom.TabIndex = 2;
            this.txtRechercheNom.TextChanged += new System.EventHandler(this.txtRechercheNom_TextChanged);
            // 
            // lblRechercheNom
            // 
            this.lblRechercheNom.AutoSize = true;
            this.lblRechercheNom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRechercheNom.Location = new System.Drawing.Point(128, 35);
            this.lblRechercheNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRechercheNom.Name = "lblRechercheNom";
            this.lblRechercheNom.Size = new System.Drawing.Size(171, 18);
            this.lblRechercheNom.TabIndex = 3;
            this.lblRechercheNom.Text = "Recherche par nom:";
            this.lblRechercheNom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRecherchePrenom
            // 
            this.lblRecherchePrenom.AutoSize = true;
            this.lblRecherchePrenom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecherchePrenom.Location = new System.Drawing.Point(101, 66);
            this.lblRecherchePrenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecherchePrenom.Name = "lblRecherchePrenom";
            this.lblRecherchePrenom.Size = new System.Drawing.Size(198, 18);
            this.lblRecherchePrenom.TabIndex = 5;
            this.lblRecherchePrenom.Text = "Recherche par prénom:";
            this.lblRecherchePrenom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRecherchePrenom
            // 
            this.txtRecherchePrenom.Location = new System.Drawing.Point(307, 59);
            this.txtRecherchePrenom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRecherchePrenom.Name = "txtRecherchePrenom";
            this.txtRecherchePrenom.Size = new System.Drawing.Size(327, 25);
            this.txtRecherchePrenom.TabIndex = 4;
            this.txtRecherchePrenom.TextChanged += new System.EventHandler(this.txtRecherchePrenom_TextChanged);
            // 
            // lblRechercheAdresse
            // 
            this.lblRechercheAdresse.AutoSize = true;
            this.lblRechercheAdresse.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRechercheAdresse.Location = new System.Drawing.Point(97, 97);
            this.lblRechercheAdresse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRechercheAdresse.Name = "lblRechercheAdresse";
            this.lblRechercheAdresse.Size = new System.Drawing.Size(202, 18);
            this.lblRechercheAdresse.TabIndex = 7;
            this.lblRechercheAdresse.Text = "Recherche par adresse:";
            this.lblRechercheAdresse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRechercheAdresse
            // 
            this.txtRechercheAdresse.Location = new System.Drawing.Point(307, 90);
            this.txtRechercheAdresse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRechercheAdresse.Name = "txtRechercheAdresse";
            this.txtRechercheAdresse.Size = new System.Drawing.Size(327, 25);
            this.txtRechercheAdresse.TabIndex = 6;
            this.txtRechercheAdresse.TextChanged += new System.EventHandler(this.txtRechercheAdresse_TextChanged);
            // 
            // lblNombreEtudiants
            // 
            this.lblNombreEtudiants.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombreEtudiants.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEtudiants.Location = new System.Drawing.Point(190, 137);
            this.lblNombreEtudiants.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreEtudiants.Name = "lblNombreEtudiants";
            this.lblNombreEtudiants.Size = new System.Drawing.Size(73, 33);
            this.lblNombreEtudiants.TabIndex = 9;
            this.lblNombreEtudiants.Text = "0";
            this.lblNombreEtudiants.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombreEtudiantTitre
            // 
            this.lblNombreEtudiantTitre.AutoSize = true;
            this.lblNombreEtudiantTitre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEtudiantTitre.Location = new System.Drawing.Point(13, 152);
            this.lblNombreEtudiantTitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreEtudiantTitre.Name = "lblNombreEtudiantTitre";
            this.lblNombreEtudiantTitre.Size = new System.Drawing.Size(169, 18);
            this.lblNombreEtudiantTitre.TabIndex = 8;
            this.lblNombreEtudiantTitre.Text = "Nombre d\'étudiants:";
            // 
            // lblRechercheCodePermanent
            // 
            this.lblRechercheCodePermanent.AutoSize = true;
            this.lblRechercheCodePermanent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRechercheCodePermanent.Location = new System.Drawing.Point(31, 128);
            this.lblRechercheCodePermanent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRechercheCodePermanent.Name = "lblRechercheCodePermanent";
            this.lblRechercheCodePermanent.Size = new System.Drawing.Size(268, 18);
            this.lblRechercheCodePermanent.TabIndex = 11;
            this.lblRechercheCodePermanent.Text = "Recherche par code permanent:";
            this.lblRechercheCodePermanent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRechercheCodePermanent
            // 
            this.txtRechercheCodePermanent.Location = new System.Drawing.Point(307, 121);
            this.txtRechercheCodePermanent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRechercheCodePermanent.Name = "txtRechercheCodePermanent";
            this.txtRechercheCodePermanent.Size = new System.Drawing.Size(327, 25);
            this.txtRechercheCodePermanent.TabIndex = 10;
            this.txtRechercheCodePermanent.TextChanged += new System.EventHandler(this.txtRechercheCodePermanent_TextChanged);
            // 
            // cmdQuitterListe
            // 
            this.cmdQuitterListe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmdQuitterListe.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdQuitterListe.Location = new System.Drawing.Point(49, 40);
            this.cmdQuitterListe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdQuitterListe.Name = "cmdQuitterListe";
            this.cmdQuitterListe.Size = new System.Drawing.Size(212, 75);
            this.cmdQuitterListe.TabIndex = 12;
            this.cmdQuitterListe.Text = "Quitter";
            this.cmdQuitterListe.UseVisualStyleBackColor = false;
            this.cmdQuitterListe.Click += new System.EventHandler(this.cmdQuitterListe_Click);
            // 
            // grpRechercheListe
            // 
            this.grpRechercheListe.Controls.Add(this.txtRechercheCodePermanent);
            this.grpRechercheListe.Controls.Add(this.txtRechercheAdresse);
            this.grpRechercheListe.Controls.Add(this.lblRechercheCodePermanent);
            this.grpRechercheListe.Controls.Add(this.txtRecherchePrenom);
            this.grpRechercheListe.Controls.Add(this.lblRechercheNom);
            this.grpRechercheListe.Controls.Add(this.lblRecherchePrenom);
            this.grpRechercheListe.Controls.Add(this.lblRechercheAdresse);
            this.grpRechercheListe.Controls.Add(this.txtRechercheNom);
            this.grpRechercheListe.Location = new System.Drawing.Point(379, 12);
            this.grpRechercheListe.Name = "grpRechercheListe";
            this.grpRechercheListe.Size = new System.Drawing.Size(662, 169);
            this.grpRechercheListe.TabIndex = 13;
            this.grpRechercheListe.TabStop = false;
            // 
            // FrmListeEtudiants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1228, 682);
            this.Controls.Add(this.grpRechercheListe);
            this.Controls.Add(this.cmdQuitterListe);
            this.Controls.Add(this.lblNombreEtudiants);
            this.Controls.Add(this.lblNombreEtudiantTitre);
            this.Controls.Add(this.Lst_Etudiants);
            this.Controls.Add(this.Lbl_ListeEtudiants);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmListeEtudiants";
            this.Text = "FrmListeEtudiants";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmListeEtudiants_FormClosing);
            this.Load += new System.EventHandler(this.FrmListeEtudiants_Load);
            this.grpRechercheListe.ResumeLayout(false);
            this.grpRechercheListe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_ListeEtudiants;
        private System.Windows.Forms.ListView Lst_Etudiants;
        private System.Windows.Forms.TextBox txtRechercheNom;
        private System.Windows.Forms.Label lblRechercheNom;
        private System.Windows.Forms.Label lblRecherchePrenom;
        private System.Windows.Forms.TextBox txtRecherchePrenom;
        private System.Windows.Forms.Label lblRechercheAdresse;
        private System.Windows.Forms.TextBox txtRechercheAdresse;
        private System.Windows.Forms.Label lblNombreEtudiants;
        private System.Windows.Forms.Label lblNombreEtudiantTitre;
        private System.Windows.Forms.Label lblRechercheCodePermanent;
        private System.Windows.Forms.TextBox txtRechercheCodePermanent;
        private System.Windows.Forms.Button cmdQuitterListe;
        private System.Windows.Forms.GroupBox grpRechercheListe;
    }
}