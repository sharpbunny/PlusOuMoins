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
            int choixMenuPrincipal, nombreDePartiesJouees = 0;
            

            //**********************
            //     LA PARTIE
            //**********************
            do
            {
                choixMenuPrincipal = MenuPrincipal();
                switch (choixMenuPrincipal)
                {

                    case 1: //LE JOUEUR CHOISIT DE JOUER
                        theGame();
                        nombreDePartiesJouees++; 
                        break;

                    case 2: //Permet de choisir le niveau de difficulté

                        break;

                    case 3: //affiche les statistiques du joueur
                        statistiquesDuJoueur(nombreDePartiesJouees);
                        break;

                    case 4: //Permet de quitter le programme
                        Environment.Exit(0);
                        break;
                }

            } while (true);


        } //FIN DU MAIN

        static int MenuPrincipal()
        {
            int choixMenu = 0; //Stockera le choix du menu que le joueur va choisir

            do
            {
                Console.WriteLine("\t\t Plus ou Moins");
                Console.WriteLine("\t\t 1. Jouer");
                Console.WriteLine("\t\t 2. Choix de la difficulté");
                Console.WriteLine("\t\t 3. Statistiques");
                Console.WriteLine("\t\t 4. Quitter");
                Console.Write("\t\t Votre choix : ");
                int.TryParse(Console.ReadLine(), out choixMenu);

                if (choixMenu < 0 || choixMenu > 4) //Si l'utilisateur n'a pas rentré un choix de menu correct
                {
                    Console.WriteLine("Vous devez entrer un nombre compris entre 1 et 3. \nAppuyez sur une touche pour continuer !");
                    Console.ReadLine();
                    Console.Clear();
                }

            } while (choixMenu < 0 || choixMenu > 4); //L'utilisateur doit taper un nombre tant qu'il n'a pas rentré un choix de menu correct

            Console.Clear();

            return choixMenu;
        }

        static void theGame()
        {
            int numberRandomized, miniRandom = 0, maxiRandom = 100, numberUser = miniRandom - 1;
            bool conversion = false;
            numberRandomized = numberRandomizer.Next(miniRandom, maxiRandom); // Génération du nombre à trouver
            int numberTry = 0;

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
                }

                // Si le nombre du joueur est inférieur au nombre aléatoire
                else if (numberRandomized > numberUser)
                {
                    Console.WriteLine("Trop petit !");
                }
                numberTry++; //Augmente le nombre d'essai

            } //FIN DE LA BOUCLE DU JEU

            Console.WriteLine("Félicitations!!! Vous avez trouvé le nombre en " + numberTry + " essai" + ((numberTry>1)?"s":"") + "!");
            Console.ReadLine();
            Console.Clear();
        }

        static void statistiquesDuJoueur(int nbPartiesJouees)
        {
            string quitterLeMenuDesStatistiques = "";
            Console.WriteLine("\t\t--- Statistiques du joueur ---");
            Console.WriteLine("\t\tParties jouees : " + nbPartiesJouees);

            //Boucle qui permet de forcer l'utilisateur à taper 1 pour retourner au menu principal
            do
            {
                Console.Write("Tapez 1 pour retourner au menu principal : ");
                quitterLeMenuDesStatistiques = Console.ReadLine();
                Console.WriteLine("\nTapez 1 pour quitter !!!\n");                   
            } while (quitterLeMenuDesStatistiques != "1");

            Console.Clear(); //Quand le joueur quitte ce menu, on efface ce qui est affiché à l'écran
        }

    }
}
