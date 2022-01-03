using System;
using System.Collections.Generic;
using System.Text;
using SpeechLib;
using System.Xml;

namespace Definitif_Mathilde_App
{
    public class LecteurXml_LaSyllabe
    {
        //Objets lecteur Xml
        XmlDocument monFichier = new XmlDocument();
        public List<string> lstBonnesReps = new List<string>();
        public List<string> lstPiege1 = new List<string>();
        public List<string> lstPiege2 = new List<string>();
        public List<string> lstIndex = new List<string>();

        public List<string> lstQuestionsEnCours = new List<string>();
        
        string[] tableauBtn = new string[] { "btnRep1", "btnRep2", "btnRep3" };

        
        Random nbAléatoire = new Random();       
        int indexBtnAleatoire;

        public int positionRepSurBtn()
        {
            

            indexBtnAleatoire = nbAléatoire.Next(0, tableauBtn.Length);

            return indexBtnAleatoire;
        }
    }
}

    

