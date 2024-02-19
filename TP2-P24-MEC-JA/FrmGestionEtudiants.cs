/*****************************************************************************
 ********************* PROGRAMME - ÉCOLE DU PETIT MOULIN *********************
 ************************* SECTION GESTION ÉTUDIANTS *************************
 *****************************************************************************
 *
 * Description : Ce programme permet d'entrer les informations
 * personnelles de chaque étudiant, à l'aide de l'inscription, dans
 * une base de donnée. Ces informations peuvent être modifiables et il
 * est possible de supprimer un étudiant de la base de donnée.
 * 
 * ---------------------------------------------------------------------------
 *       CETTE SECTION EST LE PROGRAMME POUR LA GESTION DES ÉTUDIANTS
 * ---------------------------------------------------------------------------
 * 
 * Fait par:    Maryève Couture
 * Fait par:    Justin Allard
 * Le :         2023-02-20
 * Révisé par :
 * Révisé le :
******************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Pour les fichiers texte ou binaire
using static System.Net.WebRequestMethods;
using System.Net.Sockets;
using File = System.IO.File;

namespace TP2_P24_MEC_JA
{
    public partial class FrmGestionEtudiants : Form
    {
        public FrmGestionEtudiants()
        {
            InitializeComponent();
        }

        // VARIABLES GLOBALES
        int pos = -1;                                   // Indique la position de l'élève dans le fichier
        public const int longueurEnregistrement = 164;  // Correspond à la longueur d'un enregistrement
        public const string nomFichier = "Eleves.dta";  // Indique le nom du fichier"
        int nombreEtudiants = 0;                        // Indique le nombre de membres dans le fichier
        Action actionCourante = Action.Aucune;          // "Action" Indique l'action que nous allons faire sur le fichier

        // ÉNUMÉRATIONS
        public enum Action                              // Une énumération pour faciliter la gestion des actions (le powerpoint utilise string Action...)
        {
            Ajout,
            Modification,
            Aucune
        }

        private void FrmGestionEtudiants_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("Eleves.dta"))
                {
                    FileStream fs = new FileStream(nomFichier, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);
                    nombreEtudiants = (int)fs.Length / longueurEnregistrement;  // Chaque enregistrement est d'une longueur fixe.
                                                                                // En prenant la longueur totale du fichier en octets
                                                                                // divisés par la longueur d'un enregistrement nous obtenons
                                                                                // le nombre de membres

                    //-*-*-*-*-*-*-*- À EFFACER UNE FOIS LE PROGRAMME COMPLÉTÉ -*-*-*-*-*-*-*- POURRAIT ÊTRE UTILE POUR DÉBOGUER 
                    MessageBox.Show("La longueur du fichier est: " + fs.Length);
                    fs.Close();
                    if (nombreEtudiants > 0)
                    {
                        // DÉBARRAGE DES CONTRÔLES
                        Debarrer(grpNavigation, cmdModifier, cmdSupprimer);

                        // RÉCUPÉRER LE PREMIER MEMBRE DU FICHIER
                        pos = 0;
                        Recuperer_Etudiant(pos);
                    }
                    else
                    {
                        Barrer(cmdModifier, cmdSupprimer, grpNavigation, grpResultat);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        #region BOUTONS → → INSCRIRE / MODIFIER / SUPPRIMER / OK / ANNULER
        private void cmdInscrire_Click(object sender, EventArgs e)
        {
            try
            {
            // VIDER LE FORMULAIRE
            Vider_Formulaire();

            // BARRER CONTRÔLES
            Barrer(cmdInscrire, cmdModifier, cmdSupprimer, grpNavigation);

            // DÉBARRER CONTRÔLES
            Debarrer(cmdOK, cmdAnnuler, grpEtudiant, grpResultat);

            // CURSEUR SUR LE PRÉNOM
            txtPrenom.Focus();

            // Afficher l'action en cours
            // Action = "AJOUT"
            actionCourante = Action.Ajout;
            lblEtudiant.Text = "*** Ajout d'un étudiant en cours ***";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        private void cmdModifier_Click(object sender, EventArgs e)
        {
            try
            {
                // BARRER CONTRÔLES
                Barrer(grpNavigation, cmdInscrire, cmdModifier, cmdSupprimer, txtPrenom, txtNom, mskNoIdentifiant);

                // DÉBARRER CONTRÔLES
                Debarrer(grpEtudiant, cmdOK, cmdAnnuler, grpResultat);

                //IDENTIFIER L'ACTION EN COURS 
                actionCourante = Action.Modification;
                lblEtudiant.Text = " °°° MODE MODIFICATION °°° ";

                // DONNER LE FOCUS AU PRENOM 
                txtPrenom.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        private void cmdSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                // QUESTION DE CONFIRMATION À L'UTILISATEUR
                DialogResult rep;
                rep = MessageBox.Show("Désirez-vous enlevez cet étudiant?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    Supprimer_Etudiants();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            try
            {
            // VALIDATION FORMULAIRE
            if (Valider_Formulaire() == false)
            {
                return;
            }
            // EXÉCUTION DE L'ACTION EN COURS
            if (actionCourante == Action.Ajout)
            {
                Ajouter_ou_Modifier_Etudiant();

                MessageBox.Show("L'étudiant a été ajouté avec succès.");
                nombreEtudiants++;
                pos = nombreEtudiants - 1;
                lblEtudiant.Text = "Étudiant " + (pos + 1).ToString() + " de " + nombreEtudiants;
                }
            else
            {
                // MODIFICATION DE L'ÉTUDIANT
                Ajouter_ou_Modifier_Etudiant();
                MessageBox.Show("Étudiant modifié avec succès!");
            }
            cmdAnnuler.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdAnnuler_Click(object sender, EventArgs e)
        {
            try
            {
                // EFFACER LES MESSAGES D'ERREUR
                err1.Clear();
                actionCourante = Action.Aucune;
                lblEtudiant.Text = "";
                if (nombreEtudiants > 0)
                {
                    Barrer(cmdOK, cmdAnnuler, grpEtudiant, grpResultat);
                    Debarrer(cmdInscrire, cmdModifier, cmdSupprimer, grpNavigation);
                    Recuperer_Etudiant(pos);
                }
                else
                {
                    Vider_Formulaire();
                    Barrer(cmdOK, cmdAnnuler, cmdModifier, cmdSupprimer, grpEtudiant, grpNavigation, grpResultat);
                    Debarrer(cmdInscrire);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region MÉTHODES → → AJOUTER / MODIFIER / RÉCUPÉRER / SUPPRIMER ÉTUDIANT
        private void Ajouter_ou_Modifier_Etudiant()
        {
            try
            {
                // FILESTREAM
                FileStream fs;

                // POSITIONNEMENT
                if (actionCourante == Action.Ajout)
                {
                    fs = new FileStream(nomFichier, FileMode.Append, FileAccess.Write, FileShare.None);
                }
                else
                {
                    fs = new FileStream(nomFichier, FileMode.Open, FileAccess.Write, FileShare.None);
                    // ÉTABLIR LE POSITIONNEMENT
                    fs.Seek(pos * longueurEnregistrement, SeekOrigin.Begin);
                }
                BinaryWriter bw = new BinaryWriter(fs);

                // VARIABLES POUR INSCRIPTION DANS LE FICHIER
                string code_permanent;
                string prenom;
                string nom;
                string adresse;
                string ville;
                string code_postal;
                string tel;
                string identifiant;
                string date_de_naissance;
                char sexe;
                float TP1;
                float TP2;
                float intra;
                float final;

                code_permanent = mskCodePermanent.Text.PadRight(12);
                prenom = txtPrenom.Text.PadRight(20);
                nom = txtNom.Text.PadRight(20);
                adresse = txtAdresse.Text.PadRight(30);
                ville = txtVille.Text.PadRight(20);
                code_postal = mskCodePostal.Text.PadRight(7);
                tel = mskTelephone.Text;
                identifiant = mskNoIdentifiant.Text.PadRight(5);
                date_de_naissance = dtpDateNaissance.Value.ToShortDateString();
                TP1 = float.Parse(numTP1.Text);
                TP2 = float.Parse(numTP2.Text);
                intra = float.Parse(numIntra.Text);
                final = float.Parse(numIntra.Text);

                if (optFeminin.Checked == true)
                {
                    sexe = 'F';
                }
                else
                {
                    sexe = 'M';
                }

                // ÉCRITURE
                bw.Write(code_permanent);
                bw.Write(prenom);
                bw.Write(nom);
                bw.Write(adresse);
                bw.Write(ville);
                bw.Write(code_postal);
                bw.Write(tel);
                bw.Write(identifiant);
                bw.Write(date_de_naissance);
                bw.Write(TP1);
                bw.Write(TP2);
                bw.Write(intra);
                bw.Write(final);
                bw.Write(sexe);

                // FERMETURE DU FICHIER
                bw.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Recuperer_Etudiant(int position)
        {
            try
            {
                // Filestream et BinaryReader
                FileStream fs = new FileStream(nomFichier, FileMode.Open, FileAccess.Read, FileShare.None);
                BinaryReader br = new BinaryReader(fs);

                // Se positionner dans le fichier pour récupérer le bon membre
                fs.Seek(position * longueurEnregistrement, SeekOrigin.Begin); // Partons du début du fichier

                // Lire les informations du membre (TOUJOURS dans le même ordre que nous l'avons écrit)

                mskCodePermanent.Text = br.ReadString();
                txtPrenom.Text = br.ReadString().Trim();    // Trim() permet de supprimer les espaces avant et après le prénom (string)
                txtNom.Text = br.ReadString().Trim();
                txtAdresse.Text = br.ReadString().Trim();
                txtVille.Text = br.ReadString().Trim();
                mskCodePostal.Text = br.ReadString();
                mskTelephone.Text = br.ReadString();
                mskNoIdentifiant.Text = br.ReadString();
                dtpDateNaissance.Text = br.ReadString();
                numTP1.Value = (decimal)br.ReadSingle();
                numTP2.Value = (decimal)br.ReadSingle();
                numIntra.Value = (decimal)br.ReadSingle();
                numFinal.Value = (decimal)br.ReadSingle();
                char sexe;
                sexe = br.ReadChar();
                if (sexe == 'F')
                {
                    optFeminin.Checked = true;
                }
                else
                {
                    optMasculin.Checked = false;
                }

                // Fermer dans le bon ordre
                br.Close();
                fs.Close();

                // Afficher le membre sur lequel nous sommes positionné.
                lblEtudiant.Text = "Étudiant " + (position + 1).ToString() + " de " + nombreEtudiants;

                // N.B. : Nous pourrions utiliser la variable globale pos au lieu de la passer en paramètre.

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Supprimer_Etudiants()
        {
            try
            {
                string nomFichierTempo = "Eleves.tmp";
                // 1) on veut ouvrir 2 fichiers :
                // 1er : Le fichier source pour la lecture du fichier original
                // 2e  : le fichier de destination pour l'écriture dans un nouveau fichier temporaire SANS le membre à enlever

                FileStream fsSource = new FileStream(nomFichier, FileMode.Open, FileAccess.Read, FileShare.None);
                BinaryReader br = new BinaryReader(fsSource);

                FileStream fsDestination = new FileStream(nomFichierTempo, FileMode.Create, FileAccess.Write, FileShare.None);
                BinaryWriter bw = new BinaryWriter(fsDestination);

                // 2) Boucle de lecture sur le fichier source
                int cpt = 0;

                string codePermanent;
                string prenom;
                string nom;
                string adresse;
                string ville;
                string CodePostal;
                string telephone;
                string identifiant;
                string dateNaissance;
                float TP1;
                float TP2;
                float intra;
                float final;
                char sexe;

                for (int i = 0; i < nombreEtudiants; i++)
                {
                    codePermanent = br.ReadString();
                    prenom = br.ReadString();
                    nom = br.ReadString();
                    adresse = br.ReadString();
                    ville = br.ReadString();
                    CodePostal = br.ReadString();
                    telephone = br.ReadString();
                    identifiant = br.ReadString();
                    dateNaissance = br.ReadString();
                    TP1 = br.ReadSingle();
                    TP2 = br.ReadSingle();
                    intra = br.ReadSingle();
                    final = br.ReadSingle();
                    sexe = br.ReadChar();

                    if (prenom.Trim() != txtPrenom.Text.Trim() || nom.Trim() != txtNom.Text.Trim())
                    {
                        cpt++;
                        bw.Write(codePermanent);
                        bw.Write(prenom);
                        bw.Write(nom);
                        bw.Write(adresse);
                        bw.Write(ville);
                        bw.Write(CodePostal);
                        bw.Write(telephone);
                        bw.Write(identifiant);
                        bw.Write(dateNaissance);
                        bw.Write(TP1);
                        bw.Write(TP2);
                        bw.Write(intra);
                        bw.Write(final);
                        bw.Write(sexe);
                    }
                }

                // 5) FERMETURE DES FICHIERS
                br.Close();
                fsSource.Close();
                bw.Close();
                fsDestination.Close();

                // 6) ÉLIMINATION DU FICHIER SOURCE
                File.Delete(nomFichier);

                // 7) RENOMMER LE FICHIER DE DESTINATION EN FICHIER SOURCE
                File.Move(nomFichierTempo, nomFichier);

                // 8) CONFRMATION À L'UTILISATEUR
                MessageBox.Show("Étudiant enlevé avec succès!");
                nombreEtudiants--;

                if (nombreEtudiants > 0)
                {
                    pos = 0;
                    Recuperer_Etudiant(pos);
                }
                else
                {
                    pos = -1;
                    Vider_Formulaire();
                    Barrer(grpEtudiant, grpNavigation, cmdModifier, cmdSupprimer, cmdOK, cmdAnnuler);
                    lblEtudiant.Text = ""; // Ou .Clear
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region CRÉATION DU CODE PERMANENT ET DE L'IDENTIFIANT
        private string Nom_3_Lettres()
        {
            string nom = txtNom.Text;
            string nom_3_lettres = "";
            if (nom.Length >= 3)
            {
                nom_3_lettres = nom.Substring(0, 3);
            }
            else
            {
                nom_3_lettres = nom.PadRight(3, 'X').Substring(0, 3);
            }
            return nom_3_lettres;
        }

        private string Prenom_1_Lettre()
        {
            string prenom = txtPrenom.Text;
            string prenom_1_lettre = "";
            if (prenom.Length >= 1)
            {
                prenom_1_lettre = prenom.Substring(0, 1);
            }
            else
            {
                prenom_1_lettre = "X";
            }
            return prenom_1_lettre;
        }

        private string Date_Naissance_Code_Permanent()
        {
            DateTime naissance = dtpDateNaissance.Value;
            int jour = naissance.Day;
            int mois = naissance.Month;
            int annee = naissance.Year % 100;
            string naissanceCode;

            if (naissance.Year >= 1999)
                jour += 62;
            else if (naissance.Year < 1900)
                jour += 31;
            else
                jour += 0;

            if (optFeminin.Checked)
                mois += 50;
            else
                mois += 0;

            naissanceCode = jour.ToString() + mois.ToString("D2") + annee.ToString("D2");

            return naissanceCode;
        }

        private void CreerIdentifiant()
        {
            string prenom1lettre = Prenom_1_Lettre();
            string nom3lettres = Nom_3_Lettres();
            int numero_identifiant = (new Random()).Next(0, 9);
            List<string> ListeNumeroID = new List<string>();
            string identifiant = nom3lettres + prenom1lettre + numero_identifiant;

            while (ListeNumeroID.Contains(identifiant))
            {
                numero_identifiant = new Random().Next(0, 9);
                identifiant = nom3lettres + prenom1lettre + numero_identifiant;
            }
            ListeNumeroID.Add(identifiant);
            mskNoIdentifiant.Text = identifiant;
        }

        private void CreerCodePermanent()
        {
            string prenom1lettre = Prenom_1_Lettre();
            string nom3lettres = Nom_3_Lettres();
            string naissanceCode = Date_Naissance_Code_Permanent();
            string noMinistere = "20";

            mskCodePermanent.Text = nom3lettres + prenom1lettre + naissanceCode + noMinistere;
        }
        #endregion

        #region BOUTONS DE NAVIGATION
        private void cmdPremier_Click(object sender, EventArgs e)
        {
            pos = 0;
            Recuperer_Etudiant(pos);
        }

        private void cmdPrecedent_Click(object sender, EventArgs e)
        {
            if (pos > 0)
            {
                pos--;
                Recuperer_Etudiant(pos);
            }
        }

        private void cmdSuivant_Click(object sender, EventArgs e)
        {
            if (pos < nombreEtudiants - 1)
            {
                pos++;
                Recuperer_Etudiant(pos);
            }
        }

        private void cmdDernier_Click(object sender, EventArgs e)
        {
            pos = nombreEtudiants - 1;
            Recuperer_Etudiant(pos);
        }
        #endregion

        #region MÉTHODES → → BARRER / DÉBARRER
        private void Debarrer(params Control[] c)
        {
            for (int i = 0; i < c.Length; i++)
            {
                c[i].Enabled = true;
            }
        }

        private void Barrer(params Control[] c)
        {
            for (int i = 0; i < c.Length; i++)
            {
                c[i].Enabled = false;
            }
        }
        #endregion

        #region VALIDATION DES CHAINES DE CARACTÈRES
        private void Valider_Chaine(object sender, KeyPressEventArgs e)
        {
            try
            {
                string unaccentedChar = e.KeyChar.ToString().Normalize(NormalizationForm.FormD);
                if (e.KeyChar == '.' || e.KeyChar == ' ' || e.KeyChar == '-' || e.KeyChar == (char)8 || char.IsLetter(e.KeyChar) == true || e.KeyChar == '\'') //Char 8 correspond au backspace
                {
                    return;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Valider_Adresse(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '.' || e.KeyChar == ' ' || e.KeyChar == '-' || e.KeyChar == (char)8 || char.IsLetter(e.KeyChar) == true || char.IsDigit(e.KeyChar) || e.KeyChar == '\'') //Char 8 correspond au backspace
                {
                    return;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region VALIDER / VIDER FORMULAIRE
        private bool Valider_Formulaire()
        {
            bool valide = true;

            // EFFACER LES ANCIENNES ERREURS
            err1.Clear();

            // VALIDATION DES CHAMPS
            if (txtPrenom.Text.Trim() == "")
            {
                valide = false;
                err1.SetError(txtPrenom, "Entrée invalide, le prénom est obligatoire !");
            }

            if (txtNom.Text.Trim() == "")
            {
                valide = false;
                err1.SetError(txtNom, "Entrée invalide, le nom est obligatoire !");
            }

            if (txtAdresse.Text.Trim() == "")
            {
                valide = false;
                err1.SetError(txtAdresse, "Entrée invalide, une adresse valide doit être entrée !");
            }

            if (txtVille.Text.Trim() == "")
            {
                valide = false;
                err1.SetError(txtVille, "Entrée invalide, veuillez entrer le nom de la ville !");
            }

            if (mskCodePostal.MaskFull == false)
            {
                valide = false;
                err1.SetError(mskCodePostal, "Code postal invalide !");
            }

            if (mskTelephone.MaskFull == false)
            {
                valide = false;
                err1.SetError(mskTelephone, "Téléphone invalide !");
            }
            return valide;
        }

        private void Vider_Formulaire()
        {
            try
            {
                mskCodePermanent.Clear();
                txtPrenom.Clear();
                txtNom.Clear();
                txtAdresse.Clear();
                txtVille.Clear();
                mskCodePostal.Clear();
                mskTelephone.Clear();
                mskNoIdentifiant.Clear();
                // dtpDateNaissance.Value = DateTime.MinValue;
                numTP1.Value = 0;
                numTP2.Value = 0;
                numIntra.Value = 0;
                numFinal.Value = 0;
                // optFeminin.Checked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region CHANGEMENT DES VALEURS
        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {
            CreerIdentifiant();
            CreerCodePermanent();
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            CreerIdentifiant();
            CreerCodePermanent();
        }

        private void dtpDateNaissance_ValueChanged(object sender, EventArgs e)
        {
            CreerCodePermanent();
            dtpDateNaissance.MaxDate = DateTime.Today.AddYears(-4);
            dtpDateNaissance.MinDate = DateTime.Today.AddYears(-15);
        }
        #endregion

        #region QUITTER LE GESTIONNAIRE DES ÉTUDIANTS

        private bool QuitterGestionnaireParBouton;

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rep;
                rep = MessageBox.Show("Êtes vous certain de vouloir quitter le gestionnaire des étudiants?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (rep == DialogResult.Yes)
                {
                    QuitterGestionnaireParBouton = true;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fermeture formulaire");
            }
        }

        private void FrmGestionEtudiants_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (!QuitterGestionnaireParBouton)
                {
                DialogResult rep;
                rep = MessageBox.Show("Êtes vous certain de vouloir quitter le gestionnaire des étudiants?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (rep == DialogResult.No)
                {
                    e.Cancel = true;
                }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fermeture formulaire");
            }
        }
        #endregion
    }
}
