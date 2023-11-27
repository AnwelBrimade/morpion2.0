/*
 * Created by SharpDevelop.
 * User: a.trincart
 * Date: 27/11/2023
 * Time: 16:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
namespace mastermind2._0
{public class Test{
    	
    public static void Main (){
    	//import getche()
    	
    	
        // Define a regular expression for repeated words.
        int LigneDébut = Console.CursorTop;     // par rapport au sommet de la fenêtre
            int ColonneDébut = Console.CursorLeft; // par rapport au sommet de la fenêtre
            Console.Write("entrez votre TypeCode secret");
            Console.SetCursorPosition(LigneDébut + 10, ColonneDébut + 8);
        string code_secret =  Console.ReadLine();
        Console.Clear();
        string text;
        text="a";
        int gagné=0;
        char[] combinaison = new char[5];
        
        combinaison= Convert.ToBase64CharArray ;
        char[] essaie = new char[5];
        char saisie;
        int essais=0;
        
        while (text!=code_secret){
        	Console.Clear();
        	if (text==code_secret){
        		gagné=gagné+1;
        		goto bienJoué;
        	}
        	Console.Write("joueur 2 entrez votre essaie, vous en êtes a l'essaie :"+ essais);
        	Console.SetCursorPosition(LigneDébut + 10, ColonneDébut + 8);
        	
        	text = Console.ReadLine();
        	essais=essais+1;
        	
        }
       bienJoué:
        {Console.Clear();
        	if (essais<6){
        		Console.SetCursorPosition(LigneDébut + 10, ColonneDébut + 8);
        			Console.WriteLine("bravo!");
        	}
        	if ((essais<11)&&(essais>5)){
        		Console.SetCursorPosition(LigneDébut + 10, ColonneDébut + 8);
        			Console.WriteLine("correct");
        		}
        		if (essais>10){
        		Console.SetCursorPosition(LigneDébut + 10, ColonneDébut + 8);
        			Console.WriteLine("décevant..");
        		}
        		
        	}Console.ReadKey();
        }
        }
        // Report on each match.
        
    }