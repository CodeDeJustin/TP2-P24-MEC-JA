/*****************************************************************************
 ********************* PROGRAMME - ÉCOLE DU PETIT MOULIN *********************
 ************************** SECTION LISTE ÉTUDIANTS **************************
 *****************************************************************************
 *
 * Description : Ce programme permet d'entrer les informations
 * personnelles de chaque étudiant, à l'aide de l'inscription, dans
 * une base de donnée. Ces informations peuvent être modifiables et il
 * est possible de supprimer un étudiant de la base de donnée.
 * 
 * ---------------------------------------------------------------------------
 *       CETTE SECTION EST LE PROGRAMME POUR LA LISTE DES ÉTUDIANTS
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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_P24_MEC_JA
{
    public partial class FrmListeEtudiants : Form
    {
        public FrmListeEtudiants()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void FrmListeEtudiants_Load(object sender, EventArgs e)
        {
            try
            {
                Afficher_Etudiants();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #region AFFICHER ÉTUDIANTS
        private void Afficher_Etudiants()
        {
            try
            {
                Lst_Etudiants.Clear();

                Lst_Etudiants.Columns.Add("Code Permanent", 150, HorizontalAlignment.Left);
                Lst_Etudiants.Columns.Add("Prénom", 180, HorizontalAlignment.Left);
                Lst_Etudiants.Columns.Add("Nom", 180, HorizontalAlignment.Left);
                Lst_Etudiants.Columns.Add("Adresse", 260, HorizontalAlignment.Left);
                Lst_Etudiants.Columns.Add("Ville", 160, HorizontalAlignment.Left);
                Lst_Etudiants.Columns.Add("Code Postal", 110, HorizontalAlignment.Center);
                Lst_Etudiants.Columns.Add("Téléphone", 130, HorizontalAlignment.Center);
                Lst_Etudiants.Columns.Add("Identifiant", 100, HorizontalAlignment.Center);
                Lst_Etudiants.Columns.Add("Date de Naissance", 180, HorizontalAlignment.Center);
                Lst_Etudiants.Columns.Add("TP1", 65, HorizontalAlignment.Center);
                Lst_Etudiants.Columns.Add("TP2", 65, HorizontalAlignment.Center);
                Lst_Etudiants.Columns.Add("Intra", 65, HorizontalAlignment.Center);
                Lst_Etudiants.Columns.Add("Final", 65, HorizontalAlignment.Center);
                Lst_Etudiants.Columns.Add("Sexe", 65, HorizontalAlignment.Center);
                Lst_Etudiants.Columns.Add("Moyenne", 65, HorizontalAlignment.Center);
                Lst_Etudiants.Width = 1500;

                FileStream fs = new FileStream(FrmGestionEtudiants.nomFichier, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);
                BinaryReader br = new BinaryReader(fs);

                // Lecture des étudiants
                string[] Etudiants = new string[15];

                // ajouter les items au listview
                ListViewItem items;
                for (; ; )
                {
                    if (br.PeekChar() == -1)
                    {
                        break;
                    }
                    Etudiants[0] = br.ReadString().Trim();              // code permanent
                    Etudiants[1] = br.ReadString().Trim();              // prenom
                    Etudiants[2] = br.ReadString().Trim();              // nom
                    Etudiants[3] = br.ReadString().Trim();              // adresse
                    Etudiants[4] = br.ReadString().Trim();              // ville ;
                    Etudiants[5] = br.ReadString().Trim();              // code postal
                    Etudiants[6] = br.ReadString().Trim();              // téléphone
                    Etudiants[7] = br.ReadString().Trim();              // identifiant
                    Etudiants[8] = br.ReadString().Trim();              // date de naissance 
                    Etudiants[9] = br.ReadSingle().ToString();          // TP1
                    Etudiants[10] = br.ReadSingle().ToString();         // TP2
                    Etudiants[11] = br.ReadSingle().ToString();         // Intra
                    Etudiants[12] = br.ReadSingle().ToString();         // Final 
                    Etudiants[13] = br.ReadChar().ToString().Trim();    // sexe
                    float TP1 = float.Parse(Etudiants[9]);
                    float TP2 = float.Parse(Etudiants[10]);
                    float Intra = float.Parse(Etudiants[11]);
                    float Final = float.Parse(Etudiants[12]);
                    double moyenne = TP1 * 0.10 + TP2 * 0.10 + Intra * 0.40 + Final * 0.40;
                    Etudiants[14] = moyenne.ToString();

                    //ajout de listviewitems
                    items = new ListViewItem(Etudiants);
                    Lst_Etudiants.Items.Add(items);

                    int nombreEtudiants = 0;
                    foreach (ListViewItem note_Etudiant in Lst_Etudiants.Items)
                    {
                        nombreEtudiants++;
                        lblNombreEtudiants.Text = nombreEtudiants.ToString();
                    }
                }
                br.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        #region MOTEURS DE RECHERCHE
        private void txtRechercheNom_TextChanged(object sender, EventArgs e)
        {
            try
            {
            if (string.IsNullOrWhiteSpace(txtRechercheNom.Text))
            {
                Afficher_Etudiants();
            }
            else
            {
                ListViewItem[] items = new ListViewItem[Lst_Etudiants.Items.Count];
                Lst_Etudiants.Items.CopyTo(items, 0);
                Lst_Etudiants.Items.Clear();
                foreach (ListViewItem nom in items)
                {
                    if (nom.SubItems[2].Text.ToUpper().StartsWith(txtRechercheNom.Text.ToUpper()))
                    {
                        Lst_Etudiants.Items.Add(nom);
                    }
                }
            }
            }
            catch(Exception ex)
            { 
            MessageBox.Show(ex.Message);
            }
        }

        private void txtRecherchePrenom_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtRecherchePrenom.Text))
                {
                    Afficher_Etudiants();
                }
                else
                {
                    ListViewItem[] items = new ListViewItem[Lst_Etudiants.Items.Count];
                    Lst_Etudiants.Items.CopyTo(items, 0);
                    Lst_Etudiants.Items.Clear();
                    foreach (ListViewItem prenom in items)
                    {
                        if (prenom.SubItems[1].Text.ToUpper().StartsWith(txtRecherchePrenom.Text.ToUpper()))
                        {
                            Lst_Etudiants.Items.Add(prenom);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtRechercheAdresse_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtRechercheAdresse.Text))
                {
                    Afficher_Etudiants();
                }
                else
                {
                    ListViewItem[] items = new ListViewItem[Lst_Etudiants.Items.Count];
                    Lst_Etudiants.Items.CopyTo(items, 0);
                    Lst_Etudiants.Items.Clear();
                    foreach (ListViewItem adresse in items)
                    {
                        if (adresse.SubItems[3].Text.ToUpper().Contains(txtRechercheAdresse.Text.ToUpper()))
                        {
                            Lst_Etudiants.Items.Add(adresse);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtRechercheCodePermanent_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtRechercheCodePermanent.Text))
                {
                    Afficher_Etudiants();
                }
                else
                {
                    ListViewItem[] items = new ListViewItem[Lst_Etudiants.Items.Count];
                    Lst_Etudiants.Items.CopyTo(items, 0);
                    Lst_Etudiants.Items.Clear();
                    foreach (ListViewItem codePermanent in items)
                    {
                        if (codePermanent.SubItems[0].Text.ToUpper().Contains(txtRechercheCodePermanent.Text.ToUpper()))
                        {
                            Lst_Etudiants.Items.Add(codePermanent);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region QUITTER

        private bool QuitterListeParBouton;

        private void cmdQuitterListe_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rep;
                rep = MessageBox.Show("Êtes vous certain de vouloir quitter la liste des étudiants?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (rep == DialogResult.Yes)
                {
                    QuitterListeParBouton = true;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fermeture formulaire");
            }
        }

        private void FrmListeEtudiants_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (!QuitterListeParBouton)
                {
                    DialogResult rep;
                    rep = MessageBox.Show("Êtes vous certain de vouloir quitter la liste des étudiants?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
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