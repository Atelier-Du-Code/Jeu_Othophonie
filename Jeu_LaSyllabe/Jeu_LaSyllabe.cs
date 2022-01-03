using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SpeechLib;
using System.Xml;
using System.Linq;

namespace Definitif_Mathilde_App
{
    public partial class Jeu_LaSyllabe : Form
    {
        public Questions listeDesQuestions;
        public List<int> tirageDesQuestions;
        public UneQuestion laQuestionEnCours;
        public int IndexDeLaQuestionEnCours;
        public int boutonBonneReponse;

        int btn1 = 0;
        int btn2 = 0;
        int btn3 = 0;

        int score = 0;
        int erreur = 0;
        public int tour = 0;

        // Objets pour la synthèse vocale
        SpVoice voix = new SpVoice();
        SpeechVoiceSpeakFlags flags = SpeechVoiceSpeakFlags.SVSFlagsAsync;

        //Mécanique du jeu

        public LecteurXml_LaSyllabe LecteurXml_Syllabe = new LecteurXml_LaSyllabe();
        Random nbAleatoire = new Random();

        public List<string> lstQuestionsMelangees = new List<string>();
        List<int> indexMelanges = new List<int>();

        public GestionnaireRepSurBtn gestionnaireRepSurBtn = new GestionnaireRepSurBtn();
        public bool bReponseJuste = true;

        string bonneRep = "";

        public Jeu_LaSyllabe()
        {
            InitializeComponent();
            listeDesQuestions = new Questions();
            tirageDesQuestions = TirageAleatoire(0, listeDesQuestions.Qs.Count() - 1);
            IndexDeLaQuestionEnCours = 0;            
            laQuestionEnCours = listeDesQuestions.Qs[tirageDesQuestions[IndexDeLaQuestionEnCours]];
            boutonBonneReponse = -1;
        }

        public List<int> TirageAleatoire(int min, int max)
        {
            List<int> listeDeRetour = new List<int>();
            List<int> listeDeTravail = new List<int>();

            for (int i = min; i <= max; i++)
            {
                listeDeTravail.Add(i);
            }

            while (listeDeTravail.Count > 0)
            {
                int index = nbAleatoire.Next(0, listeDeTravail.Count);
                int indexDeLaListeAAjouter = listeDeTravail[index];

                listeDeRetour.Add(indexDeLaListeAAjouter);
                listeDeTravail.RemoveAt(index);
            }
            return listeDeRetour;
        }

        public int PlaceLeTexteSurLesBoutons(UneQuestion q)
        {            
            List<int> LesIndexAleatoireDesBoutons = new List<int>();

            List<string> LesSyllabes = new List<string>();
            
            LesSyllabes.Add(q.piege1);            
            LesSyllabes.Add(q.piege2);
            LesSyllabes.Add(q.bonneReponse);

            LesIndexAleatoireDesBoutons = TirageAleatoire(0, 2);
            int indexBoutonBonneReponse = -1;
            string s;

            for (int i = 0; i < LesIndexAleatoireDesBoutons.Count; i++)
            {
                if(LesIndexAleatoireDesBoutons[i] == 2)
                {
                    indexBoutonBonneReponse = i;
                }

                s = LesSyllabes[LesIndexAleatoireDesBoutons[i]];
                switch (i)
                {
                    case 0: btnRep1.Text = s;
                        break;
                    case 1:
                        btnRep2.Text = s;
                        break;
                    case 2:
                        btnRep3.Text = s;
                        break;
                }

            }           

            return indexBoutonBonneReponse;

        }        

        
       
        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            Close();
        }


        public void AnimationDeLaQuestionEnCours()
        {             
            btn1 = 0;
            btn2 = 0;
            btn3 = 0;

            int bonneReponse = boutonBonneReponse;
            while (bonneReponse == boutonBonneReponse)
            {
                bonneReponse = PlaceLeTexteSurLesBoutons(laQuestionEnCours);
            }

            boutonBonneReponse = bonneReponse;
            SyllabeCorrecte();
        }            
           

        private void btnSons_LaSyllabe_Click(object sender, EventArgs e)
        {
            AnimationDeLaQuestionEnCours();

            bonneRep = laQuestionEnCours.bonneReponse;
            voix.Speak(bonneRep, flags);

            BoutonsAccessibles();
            lblVerdict_LaSyllabe.Visible = true;
            lblScore_LaSyllabe.Visible = true;
        }

        private bool IncrementeQuestion()
        {
            bool bL = true;
            if(IndexDeLaQuestionEnCours < tirageDesQuestions.Count-1)
            {
                IndexDeLaQuestionEnCours++;
                laQuestionEnCours = listeDesQuestions.Qs[tirageDesQuestions[IndexDeLaQuestionEnCours]];
            }
            else
            {
                bL = false;
            }

            return bL;
        }

        public void SyllabeCorrecte()
        {
            if (btnRep1.Text == laQuestionEnCours.bonneReponse)
            {
                btn1 = btn1 + 1;
            }
            else if (btnRep2.Text == laQuestionEnCours.bonneReponse)
            {
                btn2 = btn2 + 1;
            }
            else
            {
                btn3 = btn3 + 1;
            }

        }

        private void btnRep1_Click(object sender, EventArgs e)
        {
            btn1 = btn1 + 1;
            
            Correction();            
        }

        private void btnRep2_Click(object sender, EventArgs e)
        {
            btn2 = btn2 + 1;

            
            Correction();
        }

        private void btnRep3_Click(object sender, EventArgs e)
        {
            btn3 = btn3 + 1;

            
            Correction();
        }

        public void Correction()
        {
            if (btn1 == 2 || btn2 == 2 || btn3 == 2)
            {
                IncrementeQuestion();

                if (score < 10)
                {
                    SonSysteme sonSysteme = new SonSysteme();
                    sonSysteme.ReponseVraie();

                    score = score + 1;
                    lblVerdict_LaSyllabe.Text = "Bravo !";
                    lblScore_LaSyllabe.Text = score + "/10";                                        
                }

                if(score == 10)
                {
                    lblScore_LaSyllabe.Text = "10/10";
                    lblVerdict_LaSyllabe.Text = "Bravo tu as finis le jeu avec " + erreur + " erreur(s)!";
                    btnSons_LaSyllabe.Enabled = false;
                    btnMenuFinDeJeu.Visible = true;
                    btnMenuPrincipal.Visible = false;
                }

                FaitApparaitreLesEtoiles(score);
                BoutonsInaccessibles();
            }
            else
            {
                SonSysteme sonSysteme = new SonSysteme();
                sonSysteme.ReponseFausse();
                bReponseJuste = false;
                erreur = erreur + 1;
                score = 0;
                lblScore_LaSyllabe.Text = score + "/10";
                lblVerdict_LaSyllabe.Text = "Recommence";

                FaitApparaitreLesEtoiles(score);
                BoutonsInaccessibles();

            }
        }
        public void BoutonsInaccessibles()
        {
            btnRep1.Enabled = false;
            btnRep2.Enabled = false;
            btnRep3.Enabled = false;
        }
        public void BoutonsAccessibles()
        {
            btnRep1.Enabled = true;
            btnRep2.Enabled = true;
            btnRep3.Enabled = true;
        }

        private void lblQuestion_LaSyllabe_Click(object sender, EventArgs e)
        {

        }

        public void FaitApparaitreLesEtoiles(int score)
        {
            List<PictureBox> lstPbEtoiles = new List<PictureBox>();

            lstPbEtoiles.Add(pbEtoile1);
            lstPbEtoiles.Add(pbEtoile2);
            lstPbEtoiles.Add(pbEtoile3);
            lstPbEtoiles.Add(pbEtoile4);
            lstPbEtoiles.Add(pbEtoile5);
            lstPbEtoiles.Add(pbEtoile6);
            lstPbEtoiles.Add(pbEtoile7);
            lstPbEtoiles.Add(pbEtoile8);
            lstPbEtoiles.Add(pbEtoile9);
            lstPbEtoiles.Add(pbEtoile10);

            if(score > 0)
            {
                for(int i = 0; i < score; i++)
                {
                    lstPbEtoiles[i].Image = Properties.Resources.Gif_etoile_jaune;
                }
            }
            else if (score == 0)
            {
                for (int i = 0; i < lstPbEtoiles.Count; i++)
                {
                    lstPbEtoiles[i].Image = Properties.Resources.GIF_etoile_noire;
                }
            }
        }

        private void Jeu_LaSyllabe_Load(object sender, EventArgs e)
        {
            lblVerdict_LaSyllabe.Visible = true;
            lblScore_LaSyllabe.Visible = false;
            btnMenuFinDeJeu.Visible = false;
        }

        private void btnMenuFinDeJeu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
    

