/*****************************************************************************
 ********************* PROGRAMME - ÉCOLE DU PETIT MOULIN *********************
 ******************************** SECTION MDI ********************************
 *****************************************************************************
 *
 * Description : Ce programme permet d'entrer les informations
 * personnelles de chaque étudiant, à l'aide de l'inscription, dans
 * une base de donnée. Ces informations peuvent être modifiables et il
 * est possible de supprimer un étudiant de la base de donnée.
 * 
 * ---------------------------------------------------------------------------
 *      CETTE SECTION EST LE PROGRAMME POUR LA FENÊTRE PRINCIPALE MDI
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

namespace TP2_P24_MEC_JA
{
    public partial class FrmMDIcontainer : Form
    {
        public FrmMDIcontainer()
        {
            InitializeComponent();
        }

        #region MENU FICHIER
        private void MnuGestionEtudiants_Click(object sender, EventArgs e)
        {
            try
            {
            for(int i=0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Name == "FrmGestionEtudiants")
                {
                    this.MdiChildren[i].Activate();
                    return;
                }
            }
            FrmGestionEtudiants frm = new FrmGestionEtudiants();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fermeture de session!");
            }
        }

        private void MnuListeStatistiques_Click(object sender, EventArgs e)
        {
            try
            {
                for(int i=0; i<this.MdiChildren.Length; i++)
                {
                    if (this.MdiChildren[i].Name == "FrmMDIcontainer")
                    {
                        this.MdiChildren[i].Activate();
                        return;
                    }

                }
                FrmListeEtudiants frm = new FrmListeEtudiants();
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fermeture de session!");
            }
        }
        #endregion

        #region MENU À PROPOS
        private void mnuApropos_Click(object sender, EventArgs e)
        {
            Apropos apropos = new Apropos();
            apropos.Show();
        }
        #endregion

        #region QUITTER

        private bool QuitterMDIParBouton;

        private void MnuQuitter_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rep;
                rep = MessageBox.Show("Êtes vous certain de vouloir quitter?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (rep == DialogResult.Yes)
                {
                    QuitterMDIParBouton = true;
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fermeture de session!");
            }
        }

        private void FrmMDIcontainer_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (!QuitterMDIParBouton)
                {
                    DialogResult rep;
                    rep = MessageBox.Show("Êtes vous certain de vouloir quitter?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (rep == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fermeture de session!");
            }
        }
        #endregion
    }
}
