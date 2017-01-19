using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plus_Ou_Moins
{
	class Program
	{
		//Déclaration du Générateur du nombre aléatoire
		static readonly Random numberRandomizer = new Random();

		static void Main(string[] args)
		{
			//*******************************
			//   DECLARATION DES VARIABLES
			//*******************************

			int numberRandomized, miniRandom = 0, maxiRandom = 100, numberUser = miniRandom - 1;
			bool conversion = false, exit = false;
			string reponse = ""; // Variable qui permettra de savoir si le joueur compte rejouer ou non
			int numberTry = 1;

			//**********************
			//     LA PARTIE
			//**********************


			do//Condition pour rejouer une partie
			{
				numberRandomized = numberRandomizer.Next(miniRandom, maxiRandom); // Génération du nombre à trouver

				Console.WriteLine("Entrez un nombre entre {0} et {1}", miniRandom, maxiRandom);

				// BOUCLE DU JEU
				while (numberUser != numberRandomized)
				{

					// Cette boucle va nous permettre de tester si le joueur entre un nombre valide.
					do
					{
						string userInput = Console.ReadLine(); // Input de l'utilisateur.
															   /// La ligne ci-dessous assigne un nombre entier dans une variable booléen
						conversion = int.TryParse(userInput, out numberUser); // Conversion de l'input de l'utilisateur en int.
						if (!conversion)
						{
							Console.WriteLine("Entrez un nombre valide !");
						}

					} while (!conversion && (numberUser >= miniRandom && numberUser <= maxiRandom));



					// Si le nombre du joueur est supérieur au nombre aléatoire
					if (numberRandomized < numberUser)
					{
						Console.WriteLine("Trop grand !");
						numberTry = numberTry + 1;//Compte le nombre d'essai
					}

					// Si le nombre du joueur est inférieur au nombre aléatoire
					else if (numberRandomized > numberUser)
					{
						Console.WriteLine("Trop petit !");
						numberTry = numberTry + 1;//Compte le nombre d'essai
					}

					// Si le nombre du joueur est égal au nombre aléatoire
					else if (numberRandomized == numberUser)
					{
						Console.WriteLine("Félicitation, vous avez trouvé le nombre en " + numberTry + " essai!");

						//Permet de recommencer une partie ou non.
						while (reponse != "yes" && reponse != "no")
						{
							Console.WriteLine("Voulez-vous rejouer, \"yes\" ou \"no\"");

							reponse = Console.ReadLine();
						}

						if (reponse == "yes")
						{
							exit = false;
							reponse = "";
						}

						else if (reponse == "no")
						{
							exit = true;

						}

					}

				}//Fin de la boucle du jeu

			} while (!exit);//Condition pour rejouer une partie
		}
	}
}
