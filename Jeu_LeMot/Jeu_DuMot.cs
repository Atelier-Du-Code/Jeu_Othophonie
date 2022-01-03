using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpeechLib;
using System.Xml;




namespace Definitif_Mathilde_App
{
    public partial class Jeu_DuMot : Form
    {
        int score = 0;
        int compteurDeTours = 1;
        int erreur = 0;


        string MotEnCours = "";
        bool bMotEnCoursValide = false;
        

        // Objets pour la synthèse vocale
        SpVoice voix = new SpVoice();
        SpeechVoiceSpeakFlags flags = SpeechVoiceSpeakFlags.SVSFlagsAsync;

        //Objets lecteur Xml
        XmlDocument monFichier = new XmlDocument();
        List<string> lstMots = new List<string>();

        //Objets ZoneVide
        string Texte_ZoneVide = "Attention, ta réponse est vide ! Réécoute le mot!";


        public List<string> lstTravail = new List<string>();
        public Random nbAleatoire = new Random();

        public Jeu_DuMot()
        {
            InitializeComponent();
            lectureXML();            

            for (int i = 0; i < lstMots.Count; i++)
            {
                lstTravail.Add(lstMots[i]);
            }
        }       
        private void Jeu_DuMot_Load(object sender, EventArgs e)
        {
            lblVerdict.Visible = false;
            lblScore.Visible = false;
            btnMenuPrincipal_FinDuJeu_LeMot.Visible = false;
            lblTestScore.Visible = false;

            txtbReponse.CharacterCasing = CharacterCasing.Lower;
        }

        private void btnSon_DuMot_Click(object sender, EventArgs e)
        {
            btnValider.Enabled = true;
            txtbReponse.Focus();

            if (MotEnCours == "")
            {
                MotEnCours = ChoixDuMot();                
                bMotEnCoursValide = false;
            }
            else
            {
                if (bMotEnCoursValide)
                {
                    MotEnCours = ChoixDuMot();                   
                    bMotEnCoursValide = false;
                }               
            }           
            
            voix.Speak(MotEnCours, flags);
        }

        public string ChoixDuMot()
        { 
            int indexMot = nbAleatoire.Next(0, lstTravail.Count);
            string leMot = lstTravail[indexMot];

            lstTravail.RemoveAt(indexMot);           

            return leMot;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {            
            MecaniqueDuJeu();
        }

        public void ZoneDeReponseVide()
        {
            lblScore.Visible = false;
            lblVerdict.Visible = false;
            btnValider.Enabled = false;           

            voix.Speak(Texte_ZoneVide, flags);
        }

        public void MecaniqueDuJeu()
        {
            lblVerdict.Visible = true;
            lblScore.Visible = true;
            btnValider.Enabled = false;

            SonSysteme sonDuSysteme = new SonSysteme();

            if (txtbReponse.Text == "")
            {
                ZoneDeReponseVide();
            }
            else
            {
                compteurDeTours++;

                if (txtbReponse.Text == MotEnCours)
                {
                    sonDuSysteme.ReponseVraie();

                    if (score <= 8)
                    {
                        score++;
                        lblScore.Text = score + "/10";
                        lblVerdict.Text = "Bravo! ";
                        btnSon_DuMot.Focus();                       

                    }
                    else
                    {
                        if (score == 9)
                        {
                            score++;
                            lblScore.Text = "10/10";
                            lblVerdict.Text = "Bravo tu as finis le jeu avec " + erreur + " erreur(s)!";

                            btnSon_DuMot.Enabled = false;
                            btnValider.Enabled = false;
                            txtbReponse.Enabled = false;
                            btnMenuPrincipal_FinDuJeu_LeMot.Visible = true;
                            btnMenuPrincipal_LeMot.Visible = false;
                        }
                    }

                    bMotEnCoursValide = true;
                }
                else
                {
                    sonDuSysteme.ReponseFausse();

                    erreur++;

                    lblVerdict.Text = "Recommence ! ";
                    score = 0;
                    lblScore.Text = score + "/10";
                    btnSon_DuMot.Focus();
                }

                FaitApparaitreLesEtoiles(score);
            }

            txtbReponse.Text = "";
            lblTestScore.Text = "score = " + score + "tour = " + compteurDeTours;
        }       

        public void lectureXML()
        {
            monFichier.Load("BiblioQuestions.xml");

            XmlNodeList lst = monFichier.GetElementsByTagName("Mot");

            foreach (XmlNode n in lst)
            {
                lstMots.Add(n.Attributes[0].Value);
            }            
        }

        private void btnMenuPrincipal_LeMot_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void btnMenuPrincipal_FinDuJeu_LeMot_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void FaitApparaitreLesEtoiles(int score)
        {
            List<PictureBox> lstPbEtoiles_LeMot = new List<PictureBox>();

            lstPbEtoiles_LeMot.Add(pbEtoile1);
            lstPbEtoiles_LeMot.Add(pbEtoile2);
            lstPbEtoiles_LeMot.Add(pbEtoile3);
            lstPbEtoiles_LeMot.Add(pbEtoile4);
            lstPbEtoiles_LeMot.Add(pbEtoile5);
            lstPbEtoiles_LeMot.Add(pbEtoile6);
            lstPbEtoiles_LeMot.Add(pbEtoile7);
            lstPbEtoiles_LeMot.Add(pbEtoile8);
            lstPbEtoiles_LeMot.Add(pbEtoile9);
            lstPbEtoiles_LeMot.Add(pbEtoile10);

            if (score > 0)
            {
                for (int i = 0; i < score; i++)
                {
                    lstPbEtoiles_LeMot[i].Image = Properties.Resources.Gif_etoile_jaune;
                }
            }
            else if (score == 0)
            {
                for (int i = 0; i < lstPbEtoiles_LeMot.Count; i++)
                {
                    lstPbEtoiles_LeMot[i].Image = Properties.Resources.GIF_etoile_noire;
                }
            }
        }
    }
}
