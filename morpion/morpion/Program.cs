using System;
using System.Security.Policy;
using System.Text.RegularExpressions;

namespace Morpion
{
    class Program
	{
		public static int[,] grille = new int[3, 3]; // matrice pour stocker les coups joués

        // Fonction permettant l'affichage du Morpion
        public static void AfficherMorpion(int j, int k)
        {
                   {
        	for (k=0; k < grille.GetLength(1); k++)
        	{
        		for (j=0; j < grille.GetLength(0); j++)
        			Console.Write("[_]");
        	}
            
        }

        // Fonction permettant de changer
        // dans le tableau qu'elle est le 
        // joueur qui à jouer
        // Bien vérifier que le joueur ne sort
        // pas du tableau et que la position
        // n'est pas déjà jouée
        public static bool AJouer(int j, int k, int joueur)
        {
            // A compléter 
            return false;
        }

        // Fonction permettant de vérifier
        // si un joueur à gagner
        public static bool Gagner(int l, int c, int joueur)
        {
            // A compléter
            if joueur==1)
            	if
            return false;
        }

        // Programme principal
        static void Main(string[] args)
        {
            //--- Déclarations et initialisations --
            int LigneDébut = Console.CursorTop;     // par rapport au sommet de la fenêtre
            int ColonneDébut = Console.CursorLeft; // par rapport au sommet de la fenêtre

            int essais = 0;
	        int joueur = 1 ;
	        int l = 10;
	        int c = 10;      // numéro de ligne et de colonne
            int j, k = 0;      // Parcourir le tableau en 2 dimensions
            bool gagner = false;
            bool bonnePosition = false; // Permet de vérifier si la position souhaité est disponible

	        //--- initialisation de la grille ---
            // On met chaque valeur du tableau à 10
	        for (j=0; j < grille.GetLength(0); j++)
	        	
		        for (k=0; k < grille.GetLength(1); k++)
			         grille[j,k] = 10;
					while(!gagner && essais != 9)
					{
						AfficherMorpion(j, k)
						// A compléter 
						try
						{
							if (joueur == 1)
							{
								Console.WriteLine("a vous de jouer joueur1");
							}
							else
								Console.WriteLine("a vous de jouer joueur2");
							
							Console.WriteLine("Ligne   =    ");
							Console.WriteLine("Colonne =    ");
							
							// Peut changer en fonction de comment vous avez fait votre tableau.
							 // Permet de manipuler le curseur dans la fenêtre 
							while (l>3)
							{
								Console.SetCursorPosition(LigneDébut + 10, ColonneDébut + 9);
								l = int.Parse(Console.ReadLine())- 1;
								if (l>3)
								{
									Console.Clear();
									Console.Write("la valeur entrée n'est pas autorisée, veuillez recommencer :");
								}
							}
							
							
							// Peut changer en fonction de comment vous avez fait votre tableau.
							// Permet de manipuler le curseur dans la fenêtre 
							
							while (c>3)
							{
								
								Console.SetCursorPosition(LigneDébut + 10, ColonneDébut + 10);
								c = int.Parse(Console.ReadLine())- 1;
								if (c>3)
								{
									Console.Clear();
									Console.Write("la valeur entrée n'est pas autorisée, veuillez recommencer :");
								}
							}
							// A compléter 

						}
						catch (Exception e)
						{
							Console.WriteLine(e.ToString());
							Console.Clear();
						}

						if (joueur==1)
						{
							joueur = joueur+1;
							l =10;
							c = 10;
						}
						else
						{
							joueur = joueur-1;
							l =10;
							c = 10;
						}

					}; // Fin TQ

            // Fin de la partie
            // A compléter 

            Console.ReadKey();
		}
	}
}