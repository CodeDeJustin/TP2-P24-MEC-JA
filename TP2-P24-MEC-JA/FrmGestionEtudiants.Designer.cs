namespace TP2_P24_MEC_JA
{
    partial class FrmGestionEtudiants
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionEtudiants));
            this.grpEtudiant = new System.Windows.Forms.GroupBox();
            this.grpSexe = new System.Windows.Forms.GroupBox();
            this.optMasculin = new System.Windows.Forms.RadioButton();
            this.optFeminin = new System.Windows.Forms.RadioButton();
            this.dtpDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.lblDateNaissance = new System.Windows.Forms.Label();
            this.mskNoIdentifiant = new System.Windows.Forms.MaskedTextBox();
            this.lblNoIdentifiant = new System.Windows.Forms.Label();
            this.mskTelephone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.mskCodePostal = new System.Windows.Forms.MaskedTextBox();
            this.lblCodePostal = new System.Windows.Forms.Label();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.mskCodePermanent = new System.Windows.Forms.MaskedTextBox();
            this.lblCodePermanent = new System.Windows.Forms.Label();
            this.grpResultat = new System.Windows.Forms.GroupBox();
            this.numFinal = new System.Windows.Forms.NumericUpDown();
            this.lblFinal = new System.Windows.Forms.Label();
            this.numIntra = new System.Windows.Forms.NumericUpDown();
            this.lblIntra = new System.Windows.Forms.Label();
            this.numTP2 = new System.Windows.Forms.NumericUpDown();
            this.lblTP2 = new System.Windows.Forms.Label();
            this.numTP1 = new System.Windows.Forms.NumericUpDown();
            this.lblTP1 = new System.Windows.Forms.Label();
            this.grpNavigation = new System.Windows.Forms.GroupBox();
            this.cmdSuivant = new System.Windows.Forms.Button();
            this.cmdDernier = new System.Windows.Forms.Button();
            this.cmdPrecedent = new System.Windows.Forms.Button();
            this.cmdPremier = new System.Windows.Forms.Button();
            this.lblEtudiant = new System.Windows.Forms.Label();
            this.cmdInscrire = new System.Windows.Forms.Button();
            this.cmdModifier = new System.Windows.Forms.Button();
            this.cmdSupprimer = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmdAnnuler = new System.Windows.Forms.Button();
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.err1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpEtudiant.SuspendLayout();
            this.grpSexe.SuspendLayout();
            this.grpResultat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIntra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTP1)).BeginInit();
            this.grpNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEtudiant
            // 
            this.grpEtudiant.Controls.Add(this.grpSexe);
            this.grpEtudiant.Controls.Add(this.dtpDateNaissance);
            this.grpEtudiant.Controls.Add(this.lblDateNaissance);
            this.grpEtudiant.Controls.Add(this.mskNoIdentifiant);
            this.grpEtudiant.Controls.Add(this.lblNoIdentifiant);
            this.grpEtudiant.Controls.Add(this.mskTelephone);
            this.grpEtudiant.Controls.Add(this.lblTelephone);
            this.grpEtudiant.Controls.Add(this.mskCodePostal);
            this.grpEtudiant.Controls.Add(this.lblCodePostal);
            this.grpEtudiant.Controls.Add(this.txtVille);
            this.grpEtudiant.Controls.Add(this.lblVille);
            this.grpEtudiant.Controls.Add(this.txtAdresse);
            this.grpEtudiant.Controls.Add(this.lblAdresse);
            this.grpEtudiant.Controls.Add(this.txtNom);
            this.grpEtudiant.Controls.Add(this.lblNom);
            this.grpEtudiant.Controls.Add(this.txtPrenom);
            this.grpEtudiant.Controls.Add(this.lblPrenom);
            this.grpEtudiant.Controls.Add(this.mskCodePermanent);
            this.grpEtudiant.Controls.Add(this.lblCodePermanent);
            this.grpEtudiant.Enabled = false;
            this.grpEtudiant.Location = new System.Drawing.Point(12, 12);
            this.grpEtudiant.Name = "grpEtudiant";
            this.grpEtudiant.Size = new System.Drawing.Size(695, 358);
            this.grpEtudiant.TabIndex = 0;
            this.grpEtudiant.TabStop = false;
            this.grpEtudiant.Text = "Étudiant";
            // 
            // grpSexe
            // 
            this.grpSexe.Controls.Add(this.optMasculin);
            this.grpSexe.Controls.Add(this.optFeminin);
            this.grpSexe.Location = new System.Drawing.Point(489, 247);
            this.grpSexe.Name = "grpSexe";
            this.grpSexe.Size = new System.Drawing.Size(200, 102);
            this.grpSexe.TabIndex = 11;
            this.grpSexe.TabStop = false;
            this.grpSexe.Text = "Sexe";
            // 
            // optMasculin
            // 
            this.optMasculin.AutoSize = true;
            this.optMasculin.Location = new System.Drawing.Point(18, 60);
            this.optMasculin.Name = "optMasculin";
            this.optMasculin.Size = new System.Drawing.Size(112, 26);
            this.optMasculin.TabIndex = 1;
            this.optMasculin.TabStop = true;
            this.optMasculin.Tag = "M";
            this.optMasculin.Text = "Masculin";
            this.optMasculin.UseVisualStyleBackColor = true;
            // 
            // optFeminin
            // 
            this.optFeminin.AutoSize = true;
            this.optFeminin.Location = new System.Drawing.Point(18, 28);
            this.optFeminin.Name = "optFeminin";
            this.optFeminin.Size = new System.Drawing.Size(102, 26);
            this.optFeminin.TabIndex = 0;
            this.optFeminin.TabStop = true;
            this.optFeminin.Tag = "F";
            this.optFeminin.Text = "Féminin";
            this.optFeminin.UseVisualStyleBackColor = true;
            // 
            // dtpDateNaissance
            // 
            this.dtpDateNaissance.Location = new System.Drawing.Point(219, 309);
            this.dtpDateNaissance.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtpDateNaissance.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDateNaissance.Name = "dtpDateNaissance";
            this.dtpDateNaissance.Size = new System.Drawing.Size(236, 29);
            this.dtpDateNaissance.TabIndex = 8;
            this.dtpDateNaissance.ValueChanged += new System.EventHandler(this.dtpDateNaissance_ValueChanged);
            // 
            // lblDateNaissance
            // 
            this.lblDateNaissance.Location = new System.Drawing.Point(20, 312);
            this.lblDateNaissance.Name = "lblDateNaissance";
            this.lblDateNaissance.Size = new System.Drawing.Size(193, 27);
            this.lblDateNaissance.TabIndex = 16;
            this.lblDateNaissance.Text = "Date de naissance:";
            this.lblDateNaissance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDateNaissance.UseCompatibleTextRendering = true;
            // 
            // mskNoIdentifiant
            // 
            this.mskNoIdentifiant.Location = new System.Drawing.Point(219, 273);
            this.mskNoIdentifiant.Mask = ">LLLL0";
            this.mskNoIdentifiant.Name = "mskNoIdentifiant";
            this.mskNoIdentifiant.Size = new System.Drawing.Size(160, 29);
            this.mskNoIdentifiant.TabIndex = 7;
            // 
            // lblNoIdentifiant
            // 
            this.lblNoIdentifiant.Location = new System.Drawing.Point(34, 281);
            this.lblNoIdentifiant.Name = "lblNoIdentifiant";
            this.lblNoIdentifiant.Size = new System.Drawing.Size(179, 24);
            this.lblNoIdentifiant.TabIndex = 14;
            this.lblNoIdentifiant.Text = "No identifiant:";
            this.lblNoIdentifiant.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNoIdentifiant.UseCompatibleTextRendering = true;
            // 
            // mskTelephone
            // 
            this.mskTelephone.Location = new System.Drawing.Point(219, 239);
            this.mskTelephone.Mask = ">(000) 000-0000";
            this.mskTelephone.Name = "mskTelephone";
            this.mskTelephone.Size = new System.Drawing.Size(160, 29);
            this.mskTelephone.TabIndex = 6;
            // 
            // lblTelephone
            // 
            this.lblTelephone.Location = new System.Drawing.Point(34, 247);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(179, 24);
            this.lblTelephone.TabIndex = 12;
            this.lblTelephone.Text = "Téléphone:";
            this.lblTelephone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTelephone.UseCompatibleTextRendering = true;
            // 
            // mskCodePostal
            // 
            this.mskCodePostal.Location = new System.Drawing.Point(219, 203);
            this.mskCodePostal.Mask = ">L0L-0L0";
            this.mskCodePostal.Name = "mskCodePostal";
            this.mskCodePostal.Size = new System.Drawing.Size(160, 29);
            this.mskCodePostal.TabIndex = 5;
            // 
            // lblCodePostal
            // 
            this.lblCodePostal.Location = new System.Drawing.Point(34, 211);
            this.lblCodePostal.Name = "lblCodePostal";
            this.lblCodePostal.Size = new System.Drawing.Size(179, 24);
            this.lblCodePostal.TabIndex = 10;
            this.lblCodePostal.Text = "Code postal:";
            this.lblCodePostal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCodePostal.UseCompatibleTextRendering = true;
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(219, 168);
            this.txtVille.MaxLength = 20;
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(448, 29);
            this.txtVille.TabIndex = 4;
            this.txtVille.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Valider_Chaine);
            // 
            // lblVille
            // 
            this.lblVille.Location = new System.Drawing.Point(34, 176);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(179, 24);
            this.lblVille.TabIndex = 8;
            this.lblVille.Text = "Ville:";
            this.lblVille.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(219, 133);
            this.txtAdresse.MaxLength = 30;
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(449, 29);
            this.txtAdresse.TabIndex = 3;
            this.txtAdresse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Valider_Adresse);
            // 
            // lblAdresse
            // 
            this.lblAdresse.Location = new System.Drawing.Point(34, 141);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(179, 24);
            this.lblAdresse.TabIndex = 6;
            this.lblAdresse.Text = "Adresse:";
            this.lblAdresse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(219, 96);
            this.txtNom.MaxLength = 20;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(448, 29);
            this.txtNom.TabIndex = 2;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Valider_Chaine);
            // 
            // lblNom
            // 
            this.lblNom.Location = new System.Drawing.Point(34, 103);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(179, 24);
            this.lblNom.TabIndex = 4;
            this.lblNom.Text = "Nom:";
            this.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(220, 61);
            this.txtPrenom.MaxLength = 20;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(448, 29);
            this.txtPrenom.TabIndex = 1;
            this.txtPrenom.TextChanged += new System.EventHandler(this.txtPrenom_TextChanged);
            this.txtPrenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Valider_Chaine);
            // 
            // lblPrenom
            // 
            this.lblPrenom.Location = new System.Drawing.Point(34, 66);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(179, 24);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prénom:";
            this.lblPrenom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mskCodePermanent
            // 
            this.mskCodePermanent.Location = new System.Drawing.Point(219, 25);
            this.mskCodePermanent.Mask = ">AAAA00000000";
            this.mskCodePermanent.Name = "mskCodePermanent";
            this.mskCodePermanent.Size = new System.Drawing.Size(160, 29);
            this.mskCodePermanent.TabIndex = 0;
            // 
            // lblCodePermanent
            // 
            this.lblCodePermanent.Location = new System.Drawing.Point(34, 30);
            this.lblCodePermanent.Name = "lblCodePermanent";
            this.lblCodePermanent.Size = new System.Drawing.Size(179, 24);
            this.lblCodePermanent.TabIndex = 0;
            this.lblCodePermanent.Text = "Code permanent:";
            this.lblCodePermanent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpResultat
            // 
            this.grpResultat.Controls.Add(this.numFinal);
            this.grpResultat.Controls.Add(this.lblFinal);
            this.grpResultat.Controls.Add(this.numIntra);
            this.grpResultat.Controls.Add(this.lblIntra);
            this.grpResultat.Controls.Add(this.numTP2);
            this.grpResultat.Controls.Add(this.lblTP2);
            this.grpResultat.Controls.Add(this.numTP1);
            this.grpResultat.Controls.Add(this.lblTP1);
            this.grpResultat.Enabled = false;
            this.grpResultat.Location = new System.Drawing.Point(728, 12);
            this.grpResultat.Name = "grpResultat";
            this.grpResultat.Size = new System.Drawing.Size(165, 178);
            this.grpResultat.TabIndex = 1;
            this.grpResultat.TabStop = false;
            this.grpResultat.Text = "Résultats";
            // 
            // numFinal
            // 
            this.numFinal.DecimalPlaces = 2;
            this.numFinal.Location = new System.Drawing.Point(76, 139);
            this.numFinal.Name = "numFinal";
            this.numFinal.Size = new System.Drawing.Size(71, 29);
            this.numFinal.TabIndex = 7;
            // 
            // lblFinal
            // 
            this.lblFinal.Location = new System.Drawing.Point(7, 139);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(62, 24);
            this.lblFinal.TabIndex = 7;
            this.lblFinal.Text = "Final:";
            this.lblFinal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numIntra
            // 
            this.numIntra.DecimalPlaces = 2;
            this.numIntra.Location = new System.Drawing.Point(76, 101);
            this.numIntra.Name = "numIntra";
            this.numIntra.Size = new System.Drawing.Size(71, 29);
            this.numIntra.TabIndex = 6;
            // 
            // lblIntra
            // 
            this.lblIntra.Location = new System.Drawing.Point(7, 101);
            this.lblIntra.Name = "lblIntra";
            this.lblIntra.Size = new System.Drawing.Size(62, 24);
            this.lblIntra.TabIndex = 5;
            this.lblIntra.Text = "Intra:";
            this.lblIntra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numTP2
            // 
            this.numTP2.DecimalPlaces = 2;
            this.numTP2.Location = new System.Drawing.Point(76, 64);
            this.numTP2.Name = "numTP2";
            this.numTP2.Size = new System.Drawing.Size(71, 29);
            this.numTP2.TabIndex = 5;
            // 
            // lblTP2
            // 
            this.lblTP2.Location = new System.Drawing.Point(7, 64);
            this.lblTP2.Name = "lblTP2";
            this.lblTP2.Size = new System.Drawing.Size(62, 24);
            this.lblTP2.TabIndex = 3;
            this.lblTP2.Text = "TP 2:";
            this.lblTP2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numTP1
            // 
            this.numTP1.DecimalPlaces = 2;
            this.numTP1.Location = new System.Drawing.Point(76, 28);
            this.numTP1.Name = "numTP1";
            this.numTP1.Size = new System.Drawing.Size(71, 29);
            this.numTP1.TabIndex = 4;
            // 
            // lblTP1
            // 
            this.lblTP1.Location = new System.Drawing.Point(7, 29);
            this.lblTP1.Name = "lblTP1";
            this.lblTP1.Size = new System.Drawing.Size(62, 24);
            this.lblTP1.TabIndex = 1;
            this.lblTP1.Text = "TP 1:";
            this.lblTP1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpNavigation
            // 
            this.grpNavigation.Controls.Add(this.cmdSuivant);
            this.grpNavigation.Controls.Add(this.cmdDernier);
            this.grpNavigation.Controls.Add(this.cmdPrecedent);
            this.grpNavigation.Controls.Add(this.cmdPremier);
            this.grpNavigation.Controls.Add(this.lblEtudiant);
            this.grpNavigation.Enabled = false;
            this.grpNavigation.Location = new System.Drawing.Point(12, 376);
            this.grpNavigation.Name = "grpNavigation";
            this.grpNavigation.Size = new System.Drawing.Size(548, 59);
            this.grpNavigation.TabIndex = 2;
            this.grpNavigation.TabStop = false;
            // 
            // cmdSuivant
            // 
            this.cmdSuivant.Location = new System.Drawing.Point(469, 17);
            this.cmdSuivant.Name = "cmdSuivant";
            this.cmdSuivant.Size = new System.Drawing.Size(34, 34);
            this.cmdSuivant.TabIndex = 3;
            this.cmdSuivant.Text = ">";
            this.cmdSuivant.UseVisualStyleBackColor = true;
            this.cmdSuivant.Click += new System.EventHandler(this.cmdSuivant_Click);
            // 
            // cmdDernier
            // 
            this.cmdDernier.Location = new System.Drawing.Point(509, 17);
            this.cmdDernier.Name = "cmdDernier";
            this.cmdDernier.Size = new System.Drawing.Size(34, 34);
            this.cmdDernier.TabIndex = 4;
            this.cmdDernier.Text = ">|";
            this.cmdDernier.UseVisualStyleBackColor = true;
            this.cmdDernier.Click += new System.EventHandler(this.cmdDernier_Click);
            // 
            // cmdPrecedent
            // 
            this.cmdPrecedent.Location = new System.Drawing.Point(46, 17);
            this.cmdPrecedent.Name = "cmdPrecedent";
            this.cmdPrecedent.Size = new System.Drawing.Size(34, 34);
            this.cmdPrecedent.TabIndex = 1;
            this.cmdPrecedent.Text = "<";
            this.cmdPrecedent.UseVisualStyleBackColor = true;
            this.cmdPrecedent.Click += new System.EventHandler(this.cmdPrecedent_Click);
            // 
            // cmdPremier
            // 
            this.cmdPremier.Location = new System.Drawing.Point(6, 17);
            this.cmdPremier.Name = "cmdPremier";
            this.cmdPremier.Size = new System.Drawing.Size(34, 34);
            this.cmdPremier.TabIndex = 0;
            this.cmdPremier.Text = "|<";
            this.cmdPremier.UseVisualStyleBackColor = true;
            this.cmdPremier.Click += new System.EventHandler(this.cmdPremier_Click);
            // 
            // lblEtudiant
            // 
            this.lblEtudiant.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblEtudiant.Location = new System.Drawing.Point(86, 21);
            this.lblEtudiant.Name = "lblEtudiant";
            this.lblEtudiant.Size = new System.Drawing.Size(377, 27);
            this.lblEtudiant.TabIndex = 2;
            this.lblEtudiant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdInscrire
            // 
            this.cmdInscrire.Location = new System.Drawing.Point(728, 197);
            this.cmdInscrire.Name = "cmdInscrire";
            this.cmdInscrire.Size = new System.Drawing.Size(165, 30);
            this.cmdInscrire.TabIndex = 1;
            this.cmdInscrire.Text = "Inscrire";
            this.cmdInscrire.UseVisualStyleBackColor = true;
            this.cmdInscrire.Click += new System.EventHandler(this.cmdInscrire_Click);
            // 
            // cmdModifier
            // 
            this.cmdModifier.Enabled = false;
            this.cmdModifier.Location = new System.Drawing.Point(728, 233);
            this.cmdModifier.Name = "cmdModifier";
            this.cmdModifier.Size = new System.Drawing.Size(165, 30);
            this.cmdModifier.TabIndex = 2;
            this.cmdModifier.Text = "Modifier";
            this.cmdModifier.UseVisualStyleBackColor = true;
            this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
            // 
            // cmdSupprimer
            // 
            this.cmdSupprimer.Enabled = false;
            this.cmdSupprimer.Location = new System.Drawing.Point(728, 269);
            this.cmdSupprimer.Name = "cmdSupprimer";
            this.cmdSupprimer.Size = new System.Drawing.Size(165, 30);
            this.cmdSupprimer.TabIndex = 3;
            this.cmdSupprimer.Text = "Supprimer";
            this.cmdSupprimer.UseVisualStyleBackColor = true;
            this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
            // 
            // cmdOK
            // 
            this.cmdOK.Enabled = false;
            this.cmdOK.Location = new System.Drawing.Point(728, 305);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(165, 30);
            this.cmdOK.TabIndex = 4;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdAnnuler
            // 
            this.cmdAnnuler.Enabled = false;
            this.cmdAnnuler.Location = new System.Drawing.Point(728, 341);
            this.cmdAnnuler.Name = "cmdAnnuler";
            this.cmdAnnuler.Size = new System.Drawing.Size(165, 30);
            this.cmdAnnuler.TabIndex = 5;
            this.cmdAnnuler.Text = "Annuler";
            this.cmdAnnuler.UseVisualStyleBackColor = true;
            this.cmdAnnuler.Click += new System.EventHandler(this.cmdAnnuler_Click);
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.BackColor = System.Drawing.Color.Cyan;
            this.cmdQuitter.Location = new System.Drawing.Point(583, 377);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(310, 60);
            this.cmdQuitter.TabIndex = 6;
            this.cmdQuitter.Text = "Quitter";
            this.cmdQuitter.UseVisualStyleBackColor = false;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // err1
            // 
            this.err1.ContainerControl = this;
            // 
            // FrmGestionEtudiants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(908, 444);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.cmdAnnuler);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.cmdSupprimer);
            this.Controls.Add(this.cmdModifier);
            this.Controls.Add(this.cmdInscrire);
            this.Controls.Add(this.grpNavigation);
            this.Controls.Add(this.grpResultat);
            this.Controls.Add(this.grpEtudiant);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmGestionEtudiants";
            this.Text = "Gestion des étudiants";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGestionEtudiants_FormClosing);
            this.Load += new System.EventHandler(this.FrmGestionEtudiants_Load);
            this.grpEtudiant.ResumeLayout(false);
            this.grpEtudiant.PerformLayout();
            this.grpSexe.ResumeLayout(false);
            this.grpSexe.PerformLayout();
            this.grpResultat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIntra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTP1)).EndInit();
            this.grpNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.err1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEtudiant;
        private System.Windows.Forms.MaskedTextBox mskCodePermanent;
        private System.Windows.Forms.Label lblCodePermanent;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.MaskedTextBox mskCodePostal;
        private System.Windows.Forms.Label lblCodePostal;
        private System.Windows.Forms.MaskedTextBox mskTelephone;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.GroupBox grpSexe;
        private System.Windows.Forms.RadioButton optMasculin;
        private System.Windows.Forms.RadioButton optFeminin;
        private System.Windows.Forms.DateTimePicker dtpDateNaissance;
        private System.Windows.Forms.Label lblDateNaissance;
        private System.Windows.Forms.MaskedTextBox mskNoIdentifiant;
        private System.Windows.Forms.Label lblNoIdentifiant;
        private System.Windows.Forms.GroupBox grpResultat;
        private System.Windows.Forms.NumericUpDown numTP2;
        private System.Windows.Forms.Label lblTP2;
        private System.Windows.Forms.NumericUpDown numTP1;
        private System.Windows.Forms.Label lblTP1;
        private System.Windows.Forms.NumericUpDown numFinal;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.NumericUpDown numIntra;
        private System.Windows.Forms.Label lblIntra;
        private System.Windows.Forms.GroupBox grpNavigation;
        private System.Windows.Forms.Button cmdSuivant;
        private System.Windows.Forms.Button cmdDernier;
        private System.Windows.Forms.Button cmdPrecedent;
        private System.Windows.Forms.Button cmdPremier;
        private System.Windows.Forms.Label lblEtudiant;
        private System.Windows.Forms.Button cmdInscrire;
        private System.Windows.Forms.Button cmdModifier;
        private System.Windows.Forms.Button cmdSupprimer;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdAnnuler;
        private System.Windows.Forms.Button cmdQuitter;
        private System.Windows.Forms.ErrorProvider err1;
    }
}