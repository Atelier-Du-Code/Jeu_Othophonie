using System;
using System.Collections.Generic;
using System.Text;

namespace Definitif_Mathilde_App
{
    public class GestionnaireRepSurBtn
    {        
        //public Jeu_LaSyllabe jeu_LaSyllabe = new Jeu_LaSyllabe();
        
        public LecteurXml_LaSyllabe LecteurXml_Syllabe = new LecteurXml_LaSyllabe();

        Random nbAleatoire = new Random();

        //Liste des boutons
        List<string> lstBtn = new List<string>() {"Btn1", "Btn2", "Btn3" };

        //Liste des réponses --> jeu_LaSyllabe.lstElementsReponsesQuestionEnCours

        // Liste des index de séléction 
        List<int> lstIndexPourSelection = new List<int>();
        int newIndex;

        //Liste reponses mélangées
        public List<String> RepsMelangees = new List<string>();

        public List<string> lstElementsReponsesQuestionEnCours = new List<string>();


        //générer une liste d'index aléatoires pour selectionner l'ordre des réponses
        public void CreationlstIndexSelection()
        {
            newIndex = nbAleatoire.Next(0, lstBtn.Count);

            for (int i = 0; i < lstBtn.Count; i++ )
            {
                lstIndexPourSelection.Add(newIndex);
            }
        }

        public void DeterminationPlacementRepSurBtn()
        {
            for (int i = 0; i < lstBtn.Count; i++)
            {
                if (lstIndexPourSelection[i] > lstElementsReponsesQuestionEnCours.ToString()[lstIndexPourSelection[i]])
                {
                    // vider toute la liste lstIndexPourSelection
                    lstIndexPourSelection.Clear();
                    CreationlstIndexSelection();
                    i--;
                }

                RepsMelangees.Add(lstElementsReponsesQuestionEnCours[lstIndexPourSelection[i]]);
                lstElementsReponsesQuestionEnCours.RemoveAt(lstIndexPourSelection[i]);
            }
        }
        /*
        public void NouvelleQuestion(int NoQuestion)
        {
            RepsMelangees.Add(LecteurXml_Syllabe.lstBonnesReps[boiteAQuestions.lstIndexToutesQuestions[NoQuestion]]);
            RepsMelangees.Add(LecteurXml_Syllabe.lstPiege1[boiteAQuestions.lstIndexToutesQuestions[NoQuestion]]);
            RepsMelangees.Add(LecteurXml_Syllabe.lstPiege2[boiteAQuestions.lstIndexToutesQuestions[NoQuestion]]);
            
        }*/
    }
}
