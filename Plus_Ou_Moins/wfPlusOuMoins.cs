using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plus_Ou_Moins
{
	public partial class wfPlusOuMoins : Form
	{
		public wfPlusOuMoins()
		{
			InitializeComponent();
            
		}

		private void wfPlusOuMoins_Load(object sender, EventArgs e)
		{

		}

        //Evenement lorsque l'on clique sur le bouton "Quitter"
		private void buttonExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

        //Evenement lorsque l'on clique sur le bouton "Options"
		private void buttonOptions_Click(object sender, EventArgs e)
		{
            //On charge la fenêtre des options
			OptionsWF menuOption = new OptionsWF();
			menuOption.ShowDialog();
		}

        //Evenement lorsque l'on clique sur le bouton "Jouer"
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            Jeu partie = new Jeu();
            partie.ShowDialog();
        }
    }
}
