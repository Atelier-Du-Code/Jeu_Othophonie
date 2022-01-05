using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Definitif_Mathilde_App
{
    public partial class Acceuil_Authentification : Form
    {
        //LecteurXML_Authentification
        public XmlDocument monFichier;
        public List<string> LstIdentifiant = new List<string>();
        public List<string> LstMotDePasse = new List<string>();

        //Mécanique Autentification        
        bool bIdentifiantValide = false;
        bool bMotDePasseValide = false;
        public Acceuil_Authentification()
        {
            InitializeComponent();
            LecteurXML_Autentification();            
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            bIdentifiantValide = false;
            bMotDePasseValide = false;

            VerifieIdentifiant();
            VerifieMotDePasse();
            Validation();

        }

        public void LecteurXML_Autentification()
        {
            monFichier = new XmlDocument();
            monFichier.Load("BDD_Authentification.xml");

            XmlNodeList lst = monFichier.GetElementsByTagName("profil");
            foreach (XmlNode n in lst)
            {
                LstIdentifiant.Add(n.Attributes[0].Value);
                LstMotDePasse.Add(n.Attributes[1].Value);               
            }
        }    
        
        public void VerifieIdentifiant()
        {
            for (int i = 0; i < LstIdentifiant.Count; i++)
            {
                if (txtbIdentifiant.Text == LstIdentifiant[i])
                {                    
                    bIdentifiantValide = true;
                }
            }
        }

        public void VerifieMotDePasse()
        {
            if (bIdentifiantValide == true)
            {
                for (int j = 0; j < LstMotDePasse.Count; j++)
                {
                    if (txtbMotDePasse.Text == LstMotDePasse[j])
                    {
                        bMotDePasseValide = true;
                    }   
                }

                if (bMotDePasseValide == false)
                {
                    lblVerif.Text = "Votre mot de passe est incorrecte";
                }
            }
            else
            {
                lblVerif.Text = "Votre identifiant est incorrecte";
            }           
        }

        public void Validation()
        {
            if (bIdentifiantValide == true && bMotDePasseValide == true)
            {
                Menu menu = new Menu();
                menu.Show();
            }
        }

        private void txtbIdentifiant_TextChanged(object sender, EventArgs e)
        {            
            lblVerif.Text = "";
        }

        private void txtbMotDePasse_TextChanged(object sender, EventArgs e)
        {
            lblVerif.Text = "";
        }
    }
}
