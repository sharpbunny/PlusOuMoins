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
            int numberRandomized, miniRandom = 0, maxiRandom = 100, numberUser = miniRandom - 1; ; bool Conversion = false; // Initialisation.

		    numberRandomized = numberRandomizer.Next(miniRandom, maxiRandom); // Génération du nombre.

            Console.WriteLine("Entrez un nombre entre {0} et {1}", miniRandom, maxiRandom);

			while (numberUser != numberRandomized)
			{
			  // Cette boucle va nous permettre de tester si le joueur entre un nombre valide.
			  do
			  {
				string userInput = Console.ReadLine(); // Input de l'utilisateur.
				Conversion = int.TryParse(userInput, out numberUser); // Conversion de l'input de l'utilisateur en int.
				if (!Conversion)
				{
				  Console.WriteLine("Entrez un nombre valide !");
				}
			  } while (!Conversion && (numberUser >= miniRandom && numberUser <= maxiRandom));

			  // Si le nombre du joueur est supérieur au nombre aléatoire
			  if (numberRandomized < numberUser)
			  {
				Console.WriteLine("Trop grand !");
			  }

			  // Si le nombre du joueur est inférieur au nombre aléatoire
			  else if (numberRandomized > numberUser)
			  {
				Console.WriteLine("Trop petit !");
			  }

			  // Si le nombre du joueur est égal au nombre aléatoire
			  else if (numberRandomized == numberUser)
			  {
				Console.WriteLine("Félicitation, vous avez trouvé le nombre !");
			  }
			}
        }
    }
}
