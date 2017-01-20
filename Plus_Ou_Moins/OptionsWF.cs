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
	public partial class OptionsWF : Form
	{
		public OptionsWF()
		{
			InitializeComponent();
		}

		private void buttonMenu_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox1.SelectedItem.Equals("Novice: 0 à 10"))
			{
				
			}
		}
	}
}
