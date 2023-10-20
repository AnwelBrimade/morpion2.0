using System;
using System.Security.Policy;
using System.Text.RegularExpressions;

namespace Morpion
{
    class Program
	{
		public static int[,] grille = new int[3, 3]; // matrice pour stocker les coups joués

        // Fonction permettant l'affichage du Morpion
        // Déclaration d'un tableau en 2 dimensions
            // On définit la longueur de chaque dimensions
            int [,] grilleInt = new int[3, 3];
            string[,] grilleString = { { "1", "2", "3" }, { "1", "2", "3" }, { "1", "2", "3" } };
        public static void AfficherMorpion(int j, int k)
        {
        	 int[,] grilleInt2 = new int[3, 3];
            // Dessiner une grille
            for (j = 0; j < grilleInt2.GetLength(0); j++)
            {
                Console.Write("\n|====|====|====|\n");
                Console.Write("|");
                for (k = 0; k < grilleInt2.GetLength(1); k++)
                {
                    if (grille[j,k] == 2)
                	    {
                	    	Console.Write(" O ");
                	    }
                    if (grille[j,k] == 1)
                	    {
                	    	Console.Write(" X ");
                	    }
                    if (grille[j,k] == 10)
                	    {
                	    	Console.Write(" -- ");
                	    }
                    Console.Write("|");
                }
                
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
             int[,] grilleInt = new int[3, 3];
            return false;
        }

        // Fonction permettant de vérifier
        // si un joueur à gagner
        
        public static bool Gagner(int l, int c, int joueur)
        {
            // A compléter
            bool gagner=false;
            if (!gagner)
            {
            	if (joueur==1)
            		Console.WriteLine("joueur 1 a gagné");
            	else
            		Console.WriteLine("joueur 2 a gagné");
            }
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
            bool bonnePosition = false; // Permet de vérifier si la position souhaité est disponible
			bool gagner=false;
	        //--- initialisation de la grille ---
            // On met chaque valeur du tableau à 10
	        for (j=0; j < grille.GetLength(0); j++)
	        	
		        for (k=0; k < grille.GetLength(1); k++)
			         grille[j,k] = 10;
					while(!gagner && essais != 9)
					{
						Console.Clear();
						AfficherMorpion(j, k);
						// A compléter 
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
							 //	for (j=0; j < grille.GetLength(0); j++)
						try
						{

							 while ((l>3)||(l<0))
							{
							 	
								Console.SetCursorPosition(LigneDébut + 10, ColonneDébut + 7);
								l = int.Parse(Console.ReadLine())- 1;
							}
							
							
							// Peut changer en fonction de comment vous avez fait votre tableau.
							// Permet de manipuler le curseur dans la fenêtre 
							
							while ((c>3)||(c<0))
							{
								
								Console.SetCursorPosition(LigneDébut + 10, ColonneDébut + 8);
								c = int.Parse(Console.ReadLine())- 1;
								
							}
						
							
								for (j=0; j < grille.GetLength(0); j++)
								{
		        					for (k=0; k < grille.GetLength(1); k++)
										if ((j==l)&&(k==c))
										{
		        							if  (joueur ==1)
											{
		        								grille[j,k] =1;
											}
		        							else
		        								grille[j,k] =2;
		        					}}
						
											// Parcourir un tableau int sans valeurs
				            for (j = 0; j < grille.GetLength(0); j++)
				            {
				                for (var i = 0; i < grille.GetLength(1); i++)
				                {
				                    Console.WriteLine("Matrix : " + j.ToString() + " . " + i.ToString() + " valeur : " + grille[j, i]);
				
				                }
				            }
				
				            Console.WriteLine();
				
				            // Parcourir un tableau string avec des valeurs
				            for (j = 0; j < grille.GetLength(0); j++)
				            {
				                for (var i = 0; i < grille.GetLength(1); i++)
				                {
				                    Console.WriteLine("Matrix : " + j.ToString() + " . " + i.ToString() + " valeur : " + grille[j, i]);
				
				                }
				            }
				            Console.ReadKey();

						}
						catch (Exception e)
						{
							
							
							Console.WriteLine(e.ToString());
							Console.Clear();
						}

						if (joueur==1)
						{
							if (gagner==false)
							{
								joueur = joueur+1;
								l =10;
								c = 10;
							}
						}
						else
						{
							if (gagner==false)
							{
								joueur = joueur-1;
								l =10;
								c = 10;
							}
						}

					}; // Fin TQ

            // Fin de la partie
            // A compléter 

            Console.ReadKey();
		}
	}
}