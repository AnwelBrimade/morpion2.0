using System;
using System.Security.Policy;
using System.Text.RegularExpressions;

namespace Morpion
{
    class Program{
		public static int[,] grille = new int[3, 3]; // matrice pour stocker les coups joués

        // Fonction permettant l'affichage du Morpion
        // Déclaration d'un tableau en 2 dimensions
            // On définit la longueur de chaque dimensions
            int [,] grilleInt = new int[3, 3];
            string[,] grilleString = {{ "1", "2", "3" },{ "1", "2", "3" },{ "1", "2", "3" }};
        public static void AfficherMorpion(int j, int k){
        	 int[,] grilleInt2 = new int[3, 3];
            // Dessiner une grille
            for (j = 0; j < grilleInt2.GetLength(0); j++){
                Console.Write("\n|====|====|====|\n");
                Console.Write("|");
                for (k = 0; k < grilleInt2.GetLength(1); k++){
                    if (grille[j,k] == 0){
                	    	Console.Write(" O ");}
                	
                    if (grille[j,k] == 1){
                	    	Console.Write(" X ");}
                	
                    if (grille[j,k] == 10){
                	    	Console.Write(" -- ");}
                	
                    Console.Write("|");}}}

        // Fonction permettant de changer
        // dans le tableau qu'elle est le 
        // joueur qui à jouer
        // Bien vérifier que le joueur ne sort
        // pas du tableau et que la position
        // n'est pas déjà jouée
        	
        public static bool AJouer(int j, int k, int joueur){
return false;}

        // Fonction permettant de vérifier
        // si un joueur à gagner
        
        public static bool Gagner(int l, int c, int joueur){
            	if((grille[l,0] +grille[l,1] +grille[l,2]==0)||(grille[l,0] +grille[l,1] +grille[l,2]==0)){
            			return true;}
            	
            	if((grille[0,c] +grille[1,c] +grille[2,c]==0)||(grille[0,c] +grille[1,c] +grille[2,c]==0)){
            			return true;}
            
            	if((grille[0,0] +grille[1,1] +grille[2,2]==0)||(grille[1,2] +grille[2,2] +grille[1,2]==0)||(grille[0,0] +grille[1,1] +grille[2,2]==3)||(grille[1,2] +grille[2,2] +grille[1,2]==3)){
            			return true;}
            
            	else {return false;}}

        // Programme principal
        static void Main(string[] args){
            //--- Déclarations et initialisations --
            int LigneDébut = Console.CursorTop;     // par rapport au sommet de la fenêtre
            int ColonneDébut = Console.CursorLeft; // par rapport au sommet de la fenêtre

            int essais = 1;
	        int joueur=1;
	        int l = 10;
	        int c = 10;      // numéro de ligne et de colonne
            int j, k = 0;      // Parcourir le tableau en 2 dimensions
            bool bonnePosition = false; // Permet de vérifier si la position souhaité est disponible
			
	        //--- initialisation de la grille ---
            // On met chaque valeur du tableau à 10
            //comment gagner
            //toutes les lignes
                //
	        for (j=0; j < grille.GetLength(0); j++)
		        for (k=0; k < grille.GetLength(1); k++)
			         grille[j,k] = 10;
						while(essais != 9){	
						Console.Clear();
						AfficherMorpion(j, k);
							if (joueur == 1){
								Console.WriteLine("a vous de jouer joueur1");
								Console.WriteLine(grille[0,0]+grille[0,1]+grille[0,2]);}
							else{
								Console.WriteLine("a vous de jouer joueur2");
								Console.WriteLine(grille[0,0]+grille[0,1]+grille[0,2]);}
							
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
							
							while ((c>3)||(c<0)){	
								Console.SetCursorPosition(LigneDébut + 10, ColonneDébut + 8);
								c = int.Parse(Console.ReadLine())- 1;}
							for (j=0; j < grille.GetLength(0); j++){
		        					for (k=0; k < grille.GetLength(1); k++)
										if ((j==l)&&(k==c)){
		        							if  (joueur ==1){
		        								if (grille[j,k] !=0 && grille[j,k] !=1 ){
		        									grille[j,k] =0;
										            if (joueur==1)
										            	joueur=joueur+1;
										            else
										            	joueur=joueur-1;}
		        								else{
		        									joueur=1;
		        									l=10;
		        									c=10;}}
		        							
		        							if  (joueur ==2){
		        								if (grille[j,k] !=0 && grille[j,k] !=1 ){
		        									grille[j,k] =1;
		        									l=10;
										            c=10;
										            if (joueur==1)
										            	joueur=joueur+1;
										            else
										            	joueur=joueur-1;}
		        								
		        								else{
													joueur=2;
													l=10;
		        									c=10;}}}}
											// Parcourir un tableau verifier valeur
				            for (j = 0; j < grille.GetLength(0); j++)
				            {
				                for (var i = 0; i < grille.GetLength(1); i++){
									Console.WriteLine("Matrix : " + j.ToString() + " . " + i.ToString() + " valeur : " + grille[j, i]);}}
				            Console.WriteLine();
				            // Parcourir un tableau string avec des valeurs
				            for (j = 0; j < grille.GetLength(0); j++){
				                for (var i = 0; i < grille.GetLength(1); i++){
				                	Console.WriteLine("Matrix : " + j.ToString() + " . " + i.ToString() + " valeur : " + grille[j, i]);}}
				            Console.Write(joueur);}
						catch (Exception e)
						{Console.WriteLine(e.ToString());}
		        									if(Gagner(0,0,1))
		        										goto found;
		        									if(Gagner(0,0,2))
		        										goto found;
		        									essais=essais+1;
		        									
		        									Console.ReadKey();}
            // Fin de la partie
						found:
						{Console.Clear();
							if (joueur==2)
								Console.WriteLine(" vous avez gagné joueur 1!");
							else
								Console.WriteLine(" vous avez gagné joueur 2!");}
						Console.ReadKey();
						}}}