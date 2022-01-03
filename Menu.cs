using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Definitif_Mathilde_App
{
    public partial class Menu : Form
    {
        public LecteurXml_LaSyllabe LecteurXml_Syllabe = new LecteurXml_LaSyllabe();


        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnJeu_DuMot_Click(object sender, EventArgs e)
        {
            Jeu_DuMot jeu_DuMot = new Jeu_DuMot();
            jeu_DuMot.Show();
        }

        private void btnJeu_LaSyllabe_Click(object sender, EventArgs e)
        {           
            Jeu_LaSyllabe jeu_LaSyllabe = new Jeu_LaSyllabe();
            jeu_LaSyllabe.ShowDialog();

            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
