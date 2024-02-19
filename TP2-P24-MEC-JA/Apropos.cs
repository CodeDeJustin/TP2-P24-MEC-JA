/*****************************************************************************
 ********************* PROGRAMME - ÉCOLE DU PETIT MOULIN *********************
 ***************************** SECTION À PROPOS ******************************
 *****************************************************************************
 *
 * Description : Ce programme permet d'entrer les informations
 * personnelles de chaque étudiant, à l'aide de l'inscription, dans
 * une base de donnée. Ces informations peuvent être modifiables et il
 * est possible de supprimer un étudiant de la base de donnée.
 * 
 * ---------------------------------------------------------------------------
 *          CETTE SECTION EST LE PROGRAMME POUR LA FENÊTRE À PROPOS
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
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_P24_MEC_JA
{
    partial class Apropos : Form
    {
        public Apropos()
        {
            InitializeComponent();
            this.Text = String.Format("À propos de {0}", AssemblyTitle);
            this.lblProduit.Text = AssemblyProduct;
            this.lblVersion.Text = String.Format("Version {0}", AssemblyVersion);
            this.lblCopyright.Text = AssemblyCopyright;
            this.lblNomSociete.Text = AssemblyCompany;
            this.FrmAPropos.Text = AssemblyDescription;
        }

        #region Accesseurs d'attribut de l'assembly

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }


        #endregion

        private void okButton_Click(object sender, EventArgs e)
        {
                    this.Close();
        }
    }
}
