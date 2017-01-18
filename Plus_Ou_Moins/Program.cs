using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plus_Ou_Moins
{
	class Program
	{
		static readonly Random numberRandomizer = new Random();
		static void Main(string[] args)
		{
			// DECLARATION DES VARIABLES
			int numberRandomized =5, numberUser, miniRandom=0, maxiRandom=100; bool Conversion = false; // Initialisation.
			Console.WriteLine("Entrez un nombre entre {0} et {1}", miniRandom, maxiRandom);
			do
			{
				string userInput = Console.ReadLine(); // Input de l'utilisateur.
				Conversion = int.TryParse(userInput, out numberUser); // Conversion de l'input de l'utilisateur en int.
				if (!Conversion)
				{
					Console.WriteLine("Entrez un nombre valide !");
				}
			} while (!Conversion);

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
