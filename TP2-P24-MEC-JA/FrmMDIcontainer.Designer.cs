namespace TP2_P24_MEC_JA
{
    partial class FrmMDIcontainer
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMDIcontainer));
            this.MnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuGestionEtudiants = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuListeStatistiques = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSeparateur = new System.Windows.Forms.ToolStripSeparator();
            this.MnuQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuApropos = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuPrincipal
            // 
            this.MnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFichier,
            this.mnuApropos});
            this.MnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MnuPrincipal.MdiWindowListItem = this.MnuFichier;
            this.MnuPrincipal.Name = "MnuPrincipal";
            this.MnuPrincipal.Size = new System.Drawing.Size(1031, 24);
            this.MnuPrincipal.TabIndex = 1;
            this.MnuPrincipal.Text = "menuStrip1";
            // 
            // MnuFichier
            // 
            this.MnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuGestionEtudiants,
            this.MnuListeStatistiques,
            this.MnuSeparateur,
            this.MnuQuitter});
            this.MnuFichier.Name = "MnuFichier";
            this.MnuFichier.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.MnuFichier.Size = new System.Drawing.Size(54, 20);
            this.MnuFichier.Text = "&Fichier";
            // 
            // MnuGestionEtudiants
            // 
            this.MnuGestionEtudiants.Name = "MnuGestionEtudiants";
            this.MnuGestionEtudiants.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.G)));
            this.MnuGestionEtudiants.Size = new System.Drawing.Size(225, 22);
            this.MnuGestionEtudiants.Text = "&Gestion des étudiants";
            this.MnuGestionEtudiants.Click += new System.EventHandler(this.MnuGestionEtudiants_Click);
            // 
            // MnuListeStatistiques
            // 
            this.MnuListeStatistiques.Name = "MnuListeStatistiques";
            this.MnuListeStatistiques.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.MnuListeStatistiques.Size = new System.Drawing.Size(225, 22);
            this.MnuListeStatistiques.Text = "&Liste et statistiques";
            this.MnuListeStatistiques.Click += new System.EventHandler(this.MnuListeStatistiques_Click);
            // 
            // MnuSeparateur
            // 
            this.MnuSeparateur.Name = "MnuSeparateur";
            this.MnuSeparateur.Size = new System.Drawing.Size(222, 6);
            // 
            // MnuQuitter
            // 
            this.MnuQuitter.Name = "MnuQuitter";
            this.MnuQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MnuQuitter.Size = new System.Drawing.Size(225, 22);
            this.MnuQuitter.Text = "&Quitter";
            this.MnuQuitter.Click += new System.EventHandler(this.MnuQuitter_Click);
            // 
            // mnuApropos
            // 
            this.mnuApropos.Name = "mnuApropos";
            this.mnuApropos.Size = new System.Drawing.Size(67, 20);
            this.mnuApropos.Text = "À Propos";
            this.mnuApropos.Click += new System.EventHandler(this.mnuApropos_Click);
            // 
            // FrmMDIcontainer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1031, 588);
            this.Controls.Add(this.MnuPrincipal);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MnuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmMDIcontainer";
            this.Text = "TP2-P24 Gestion école";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMDIcontainer_FormClosing);
            this.MnuPrincipal.ResumeLayout(false);
            this.MnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MnuFichier;
        private System.Windows.Forms.ToolStripMenuItem MnuGestionEtudiants;
        private System.Windows.Forms.ToolStripMenuItem MnuListeStatistiques;
        private System.Windows.Forms.ToolStripSeparator MnuSeparateur;
        private System.Windows.Forms.ToolStripMenuItem MnuQuitter;
        private System.Windows.Forms.ToolStripMenuItem mnuApropos;
    }
}

