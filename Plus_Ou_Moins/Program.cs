using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plus_Ou_Moins
{
	class Program
	{
		static void Main(string[] args)
		{
            //DECLARATION DES VARIABLES
			int numberRandomized=5, numberUser; // Initialisation.
			string userInput= Console.ReadLine(); // Input de l'utilisateur.
			bool Conversion = int.TryParse(userInput, out numberUser); // Conversion de l'input de l'utilisateur en int.

            //Si le nombre du joueur est supérieur au nombre aléatoire
			if (numberRandomized < numberUser)
			{
				Console.WriteLine("Trop grand !");
			}

            //Si le nombre du joueur est inférieur au nombre aléatoire
            else if (numberRandomized > numberUser)
			{
				Console.WriteLine("Trop petit !");
			}

            //Si le nombre du joueur est égal au nombre aléatoire
            else if (numberRandomized == numberUser)
			{
				Console.WriteLine("Félicitation, vous avez trouvé le nombre !");
			}

		}
	}
}
