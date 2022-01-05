using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Definitif_Mathilde_App
{
    public class Questions
    {
        public List<UneQuestion> Qs = new List<UneQuestion>();
        public XmlDocument monFichier;
        public Questions()
        {
            monFichier = new XmlDocument();            
            monFichier.Load("BiblioQuestions.xml");

            

            XmlNodeList lst = monFichier.GetElementsByTagName("Syllabe");
            foreach (XmlNode n in lst)
            {
                UneQuestion laQuestion = new UneQuestion();
                laQuestion.bonneReponse = n.Attributes[0].Value;
                laQuestion.piege1 = n.Attributes[1].Value;
                laQuestion.piege2 = n.Attributes[2].Value;

                Qs.Add(laQuestion);
            }
        }
    }
    public class UneQuestion
    {
        public string bonneReponse;
        public string piege1;
        public string piege2;      

    }
}
