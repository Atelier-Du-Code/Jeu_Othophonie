using System;
using System.Collections.Generic;
using System.Text;
using System.Media;


namespace Definitif_Mathilde_App
{    
    public class Son
    {
        static public string nomFichier = "";
        static public string url = "";    
    }

    class SonSysteme : Son
    {
        public void ReponseVraie()
        {
            url = "C:\\Jeu_Orthophonie\\Resources\\pluie.wav";
            SoundPlayer son = new SoundPlayer(url);
            son.Play();

        }
        public void ReponseFausse()
        {
            url = "C:\\Jeu_Orthophonie\\Resources\\rebond.wav";
            SoundPlayer son = new SoundPlayer(url);
            son.Play();
        }
    }


}
