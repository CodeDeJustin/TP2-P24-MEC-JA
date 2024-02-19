namespace TP2_P24_MEC_JA
{
    partial class Apropos
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Apropos));
            this.okButton = new System.Windows.Forms.Button();
            this.FrmAPropos = new System.Windows.Forms.TextBox();
            this.lblNomSociete = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblProduit = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.tblLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblIdentificationEcoleLogo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.tblLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(464, 294);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 21);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // FrmAPropos
            // 
            this.FrmAPropos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.FrmAPropos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FrmAPropos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrmAPropos.Location = new System.Drawing.Point(307, 119);
            this.FrmAPropos.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.FrmAPropos.Multiline = true;
            this.FrmAPropos.Name = "FrmAPropos";
            this.FrmAPropos.ReadOnly = true;
            this.FrmAPropos.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.FrmAPropos.Size = new System.Drawing.Size(232, 161);
            this.FrmAPropos.TabIndex = 23;
            this.FrmAPropos.TabStop = false;
            this.FrmAPropos.Text = "Programme permettant d\'inscrire les élèves fréquentant l\'école du Petit Moulin, a" +
    "vec les informations personnelles des étudiants et leurs notes";
            // 
            // lblNomSociete
            // 
            this.lblNomSociete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNomSociete.Location = new System.Drawing.Point(307, 87);
            this.lblNomSociete.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lblNomSociete.MaximumSize = new System.Drawing.Size(0, 17);
            this.lblNomSociete.Name = "lblNomSociete";
            this.lblNomSociete.Size = new System.Drawing.Size(232, 17);
            this.lblNomSociete.TabIndex = 22;
            this.lblNomSociete.Text = "Nom de l\'école";
            this.lblNomSociete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCopyright
            // 
            this.lblCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCopyright.Location = new System.Drawing.Point(307, 58);
            this.lblCopyright.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lblCopyright.MaximumSize = new System.Drawing.Size(0, 17);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(232, 17);
            this.lblCopyright.TabIndex = 21;
            this.lblCopyright.Text = "Copyright";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVersion
            // 
            this.lblVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVersion.Location = new System.Drawing.Point(307, 29);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lblVersion.MaximumSize = new System.Drawing.Size(0, 17);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(232, 17);
            this.lblVersion.TabIndex = 0;
            this.lblVersion.Text = "Version";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProduit
            // 
            this.lblProduit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProduit.Location = new System.Drawing.Point(307, 0);
            this.lblProduit.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lblProduit.MaximumSize = new System.Drawing.Size(0, 17);
            this.lblProduit.Name = "lblProduit";
            this.lblProduit.Size = new System.Drawing.Size(232, 17);
            this.lblProduit.TabIndex = 19;
            this.lblProduit.Text = "Nom du produit";
            this.lblProduit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.tblLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
            this.logoPictureBox.Size = new System.Drawing.Size(295, 285);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // 
            // tblLayoutPanel
            // 
            this.tblLayoutPanel.ColumnCount = 2;
            this.tblLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.53506F));
            this.tblLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.46494F));
            this.tblLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
            this.tblLayoutPanel.Controls.Add(this.lblProduit, 1, 0);
            this.tblLayoutPanel.Controls.Add(this.lblVersion, 1, 1);
            this.tblLayoutPanel.Controls.Add(this.lblCopyright, 1, 2);
            this.tblLayoutPanel.Controls.Add(this.lblNomSociete, 1, 3);
            this.tblLayoutPanel.Controls.Add(this.FrmAPropos, 1, 4);
            this.tblLayoutPanel.Controls.Add(this.lblIdentificationEcoleLogo, 0, 6);
            this.tblLayoutPanel.Controls.Add(this.okButton, 1, 6);
            this.tblLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanel.Location = new System.Drawing.Point(9, 9);
            this.tblLayoutPanel.Name = "tblLayoutPanel";
            this.tblLayoutPanel.RowCount = 7;
            this.tblLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.59717F));
            this.tblLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.826855F));
            this.tblLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tblLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayoutPanel.Size = new System.Drawing.Size(542, 318);
            this.tblLayoutPanel.TabIndex = 0;
            // 
            // lblIdentificationEcoleLogo
            // 
            this.lblIdentificationEcoleLogo.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificationEcoleLogo.ForeColor = System.Drawing.Color.Blue;
            this.lblIdentificationEcoleLogo.Location = new System.Drawing.Point(3, 291);
            this.lblIdentificationEcoleLogo.Name = "lblIdentificationEcoleLogo";
            this.lblIdentificationEcoleLogo.Size = new System.Drawing.Size(295, 27);
            this.lblIdentificationEcoleLogo.TabIndex = 25;
            this.lblIdentificationEcoleLogo.Text = "École du Petit Moulin  © 2023";
            this.lblIdentificationEcoleLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Apropos
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(560, 336);
            this.Controls.Add(this.tblLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Apropos";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "À propos - École du Petit Moulin";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.tblLayoutPanel.ResumeLayout(false);
            this.tblLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox FrmAPropos;
        private System.Windows.Forms.Label lblNomSociete;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblProduit;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanel;
        private System.Windows.Forms.Label lblIdentificationEcoleLogo;
    }
}
