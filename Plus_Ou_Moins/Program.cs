using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plus_Ou_Moins
{

    class Program
    {
        // Déclaration du Générateur du nombre aléatoire.
        static readonly Random numberRandomizer = new Random();

        static void Main(string[] args)
        {
			//*******************************//
			//   DECLARATION DES VARIABLES   //
			//*******************************//
			int choixMenuPrincipal, nombreDePartiesJouees = 0, nombreDePartiesOuLOrdinateurADuDevinerLeNombreDuJoueur = 0;

            // debug display args passed in command line.
            foreach (string arg in args)
            {
                //Console.WriteLine(arg);
            }

			//*******************//
			//     LA PARTIE     //
			//*******************//

			if (args.Length == 0 || args[0] == "jeu" || args[0] == " ")
			{
				do
				{
					choixMenuPrincipal = MenuPrincipal();
					switch (choixMenuPrincipal)
					{

						case 1: // LE JOUEUR CHOISIT DE JOUER.
							theGame();
							nombreDePartiesJouees++;
							break;

						case 2: // Permet de choisir le niveau de difficulté pour le mode 1 joueur.

							break;

						case 3: // Affiche les statistiques du joueur.
							statistiquesDuJoueur(nombreDePartiesJouees, nombreDePartiesOuLOrdinateurADuDevinerLeNombreDuJoueur);
							break;

						case 4: // C'est l'ordinateur qui doit deviner le nombre mystère choisi par le joueur.
							ordinateurDevineLeNombre();
							nombreDePartiesOuLOrdinateurADuDevinerLeNombreDuJoueur++;
							break;

						case 5: // Permet de quitter le programme.
							Environment.Exit(0);
							break;
					}

				} while (true);
			}

			else if (args[0] == "wf" || args[0] == "windowsform" || (args[0] == "windows" && args[1] == "form"))
			{

				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				wfPlusOuMoins PlusOuMoins = new wfPlusOuMoins();
				Application.Run(PlusOuMoins);
				Environment.Exit(0);
			}

			else if(args[0] == "-version" || args[0] == "-v")
			{
				Console.WriteLine("Plus_Ou_Moins version 0.5");
			}

			else if(args[0] == "-help" || args[0] == "-h")
			{
				Console.WriteLine("Jouer au jeu : aucun argument, 'jeu', ' ' ");
				Console.WriteLine("Windows Form : 'wf', 'windowsform', 'windows form'");
				Console.WriteLine("Version du Programme : '-version', '-v'");
			}
			

        } // FIN DU MAIN.

        static int MenuPrincipal()
        {
            int i = 0, j = 0, longueurMaxMenus;
            int choixMenu = 0; // Stockera le choix du menu que le joueur va choisir.
            string[] menus = {"1. Jouer", "2. Choix de la difficulté", "3. Statistiques",
                              "4. Faire deviner un nombre à l'ordinateur", "5. Quitter" };
            do
            {
                // On cherche à stocker la longueur de la plus grande chaîne du tableau.
                longueurMaxMenus = menus[0].Length;
                for (i = 1; i < menus.Length; i++)
                {
                    if (menus[i].Length > longueurMaxMenus) longueurMaxMenus = menus[i].Length;
                }

                // On affiche les tirets en haut du tableau du menu.
                Console.Write("\t");
                for (i = 0; i < longueurMaxMenus + 10; i++)
                {
                    Console.Write("-");
                }

                // On affiche la ligne du titre.
                Console.Write("\n\t|\t   Plus ou Moins");
                for (j = 0; j < longueurMaxMenus - 2 - "Plus ou Moins".Length; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("|");

                // On affiche les tirets en-dessous du titre.
                Console.Write("\t");
                for (i = 0; i < longueurMaxMenus + 10; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();

                // On affiche les menus ainsi que les bords du tableau correspondant à leurs lignes.
                for (i = 0; i < menus.Length; i++)
                {
                    Console.Write("\t|\t" + menus[i]);
                    for (j = 0; j < longueurMaxMenus + 1 - menus[i].Length; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("|");
                }
                // Fin de l'affichage des menus.

                // On affiche les tirets en bas du tableau des menus.
                Console.Write("\t");
                for (i = 0; i < longueurMaxMenus + 10; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
                // FIN DE L'AFFICHAGE DU MENU ET DU TITRE DU JEU.

                // Le joueur sélectionne l'option du menu qu'il désire.
                Console.Write("\t|\tVotre choix : ");
                int.TryParse(Console.ReadLine(), out choixMenu);

                if (choixMenu < 0 || choixMenu > 5) // Si l'utilisateur n'a pas rentré un choix de menu correct.
                {
                    Console.WriteLine("Vous devez entrer un nombre compris entre 1 et 5. \nAppuyez sur une touche pour continuer !");
                    Console.ReadLine();
                    Console.Clear();
                }

            } while (choixMenu < 0 || choixMenu > 5); // L'utilisateur doit taper un nombre tant qu'il n'a pas rentré un choix de menu correct.

            Console.Clear();

            return choixMenu;
        }

        static void theGame()
        {
            int numberRandomized, miniRandom = 0, maxiRandom = 100, numberUser = miniRandom - 1;
            bool conversion = false;
            numberRandomized = numberRandomizer.Next(miniRandom, maxiRandom); // Génération du nombre à trouver.
            int numberTry = 0;

            Console.WriteLine("Entrez un nombre entre {0} et {1}", miniRandom, maxiRandom);


            //***************//
            // BOUCLE DU JEU //
            //***************//

            while (numberUser != numberRandomized)
            {

                // Cette boucle va nous permettre de tester si le joueur entre un nombre valide.
                do
                {
                    string userInput = Console.ReadLine(); // Input de l'utilisateur.
                                                           /// La ligne ci-dessous assigne un nombre entier dans une variable booléen.

                    conversion = int.TryParse(userInput, out numberUser); // Conversion de l'input de l'utilisateur en int.

                    if (!conversion) Console.WriteLine("Entrez un nombre valide !");

                } while (!conversion && (numberUser >= miniRandom && numberUser <= maxiRandom));


                // Si le nombre du joueur est supérieur au nombre aléatoire.
                if (numberRandomized < numberUser) Console.WriteLine("Trop grand !");

                // Si le nombre du joueur est inférieur au nombre aléatoire.
                else if (numberRandomized > numberUser) Console.WriteLine("Trop petit !");

                numberTry++; // Augmente le nombre d'essais.

            } // FIN DE LA BOUCLE DU JEU.

            Console.WriteLine("Félicitations!!! Vous avez trouvé le nombre en " + numberTry + " essai" + ((numberTry > 1) ? "s" : "") + "!");
            Console.ReadLine();
            Console.Clear();
        }

        static void statistiquesDuJoueur(int nbPartiesJouees, int nbPartiesJoueesOrdinateur)
        {
            string quitterLeMenuDesStatistiques = "";
            Console.WriteLine("\t\t--- Statistiques du joueur ---");
            Console.WriteLine("\t\tParties jouées : " + nbPartiesJouees);
            Console.WriteLine("\t\tParties jouées par l'ordinateur : " + nbPartiesJoueesOrdinateur);

            // Boucle qui permet de forcer l'utilisateur à taper 1 pour retourner au menu principal.
            do
            {
                Console.Write("Tapez 1 pour retourner au menu principal : ");
                quitterLeMenuDesStatistiques = Console.ReadLine();
                Console.WriteLine("\nTapez 1 pour quitter !!!\n");
            } while (quitterLeMenuDesStatistiques != "1");

            Console.Clear(); // Quand le joueur quitte ce menu, on efface ce qui est affiché à l'écran.
        }

        static void ordinateurDevineLeNombre()
        {
            int borneInferieure, borneSuperieure, nombreADeviner, nombreIntermediaire; // Variables déterminées par le joueur.
            int nombreJoueParLOrdinateur, numberTryComputer;
            Random nbAleatoire = new Random(); // Nombre aléatoire qui sera choisi par l'ordinateur.
            string reponse = "";

			do
			{
				numberTryComputer = 0;

				Console.WriteLine("Définissez les bornes entre lesquelles l'ordinateur devra deviner le nombre");
				Console.Write("Borne 1 : "); int.TryParse(Console.ReadLine(), out borneInferieure);
				Console.Write("Borne 2 : "); int.TryParse(Console.ReadLine(), out borneSuperieure);

                // Si la borne inférieure est supérieure à la borne supérieure, on inverse les valeurs des deux bornes.
                if (borneInferieure > borneSuperieure)
                {
                    nombreIntermediaire = borneInferieure;
                    borneInferieure = borneSuperieure;
                    borneSuperieure = nombreIntermediaire;
                }

				Console.WriteLine("Quel nombre voulez-vous que l'ordinateur devine ?");
				int.TryParse(Console.ReadLine(), out nombreADeviner);


                //******************************************************************************//
                // BOUCLE QUI CONTIENT LE JEU DE L'ORDINATEUR POUR DETERMINER LE NOMBRE MYSTERE //
                //******************************************************************************//
                do
                {
                    numberTryComputer++;

                    // Si l'écart entre les bornes est supérieur à 25, l'ordinateur choisit le nombre du milieu
                    if (borneSuperieure - borneInferieure > 25) nombreJoueParLOrdinateur = (borneInferieure + borneSuperieure) / 2;

                    // Dés que l'écart entre les bornes est inférieur à 25, l'ordinateur choisit des nombres
                    // aléatoirement entre ces bornes.
                    else nombreJoueParLOrdinateur = nbAleatoire.Next(borneInferieure, borneSuperieure);

                    // Si le nombre que l'ordinateur a joué est supérieur au nombre à deviner, alors
                    // la borne supérieure devient égale au nombre que vient de jouer l'ordinateur, car
                    // il vient d'obtenir l'information que le nombre qu'il cherche ne sera pas supérieur
                    // au nombre qu'il vient d'essayer.
                    if (nombreJoueParLOrdinateur > nombreADeviner) borneSuperieure = nombreJoueParLOrdinateur - 1;

					else if (nombreJoueParLOrdinateur < nombreADeviner) borneInferieure = nombreJoueParLOrdinateur + 1;

					else Console.WriteLine("L'ordinateur a trouvé le nombre en " + numberTryComputer + " essai" + ((numberTryComputer > 1) ? "s" : "") + "!");


				} while (nombreJoueParLOrdinateur != nombreADeviner); //Tant que l'ordinateur n'a pas trouvé le nombre mystère, on reste dans la boucle.

                // Tant que le joueur ne répond pas "yes" ou "no" quand on lui demande de rejouer, on lui repose la question.
                do
                {
                    Console.WriteLine("Voulez-vous faire rejouer l'ordinateur ? yes/no");
                    reponse = Console.ReadLine();
                } while (reponse != "yes" && reponse != "no");

			} while (reponse == "yes");

		}

	}
}
