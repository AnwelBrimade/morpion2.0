/*
 * Created by SharpDevelop.
 * User: a.trincart
 * Date: 13/11/2023
 * Time: 17:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.InteropServices;

public class Test
{
    public static void Main ()
    {
        public static void AfficherMorpion(int j, int k){
        	 int[,] grilleInt2 = new int[3, 0];
        	 
            // Dessiner une grille
            
            for (j = 0; j < grilleInt2.GetLength(0); j++){
                Console.Write("\n|====|====|====|\n");
                Console.Write("|");
                for (k = 0; k < grilleInt2.GetLength(1); k++){
                    if (grille[j,k] == B){
                	    	Console.Write(" B ");}
                	
                    if (grille[j,k] == R){
                	    	Console.Write(" R ");}
                	if (grille[j,k] == N){
                	    	Console.Write(" N ");}
                	
                    if (grille[j,k] == V){
                	    	Console.Write(" V ");}
                	if (grille[j,k] == j){
                	    	Console.Write(" j ");}
                	
                    if (grille[j,k] == o){
                	    	Console.Write(" o ");}
                	if (grille[j,k] == g){
                	    	Console.Write(" g ");}	
                    Console.Write("|");}}}
        
        
        
        
        
        
        
        
        
        essais=0
        
			essais
        // Report on each match.
        
        }
        Console.ReadKey();
    }