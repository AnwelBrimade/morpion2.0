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
{
	public class Test{
		[DllImport("msvcrt")]
		static extern int _getche();
		public static bool caractValide(char caract)
		{
			string pattern = @"([BRNVJOG])";
			return Regex.IsMatch(caract.ToString(),pattern);
		}
    	
    public static void Main (){
        // Define a regular expression for repeated words.
        int LigneDébut = Console.CursorTop;     // par rapport au sommet de la fenêtre
            int ColonneDébut = Console.CursorLeft; // par rapport au sommet de la fenêtre
       
            
        	//string lettre =  Console.ReadLine();
        	/*char c = Convert.ToChar(lettre);
        	caractValide(c);
        	Console.Clear();*/
        	int nbrSecret=0;
        	string code_secret = "";
        	char[] combinaison = new char[5];
        	while (nbrSecret<5){
        		Console.Write("entrez votre Code secret");
            Console.SetCursorPosition(LigneDébut, ColonneDébut+ 1);
        		/*code_secret =  Console.ReadLine();*/
	        	/*char c = Convert.ToChar(lettre);*/
	        	char c = (char)_getche();
        		if (!caractValide(c)){
        			Console.ReadKey();
	        		//Console.SetCursorPosition(LigneDébut + 10, ColonneDébut + 8);
	        		/*code_secret =  Console.ReadLine();
	        		c = Convert.ToChar(lettre);
	        		caractValide(c);*/
	        		Console.Clear();
	        		
        		}
        		else{
        			Console.WriteLine(code_secret);
        			Console.ReadKey();
        			combinaison[nbrSecret] = c;
        			nbrSecret=nbrSecret+1;
        			code_secret= code_secret + c.ToString();
        			Console.Clear();
        			
        		}
        	}
        
        string text;
        text="";
        int gagné=0;
        
        char[] essaie = new char[5];
        char saisie;
        int essais=0;
        nbrSecret=0;
        while (text!=code_secret){
        	nbrSecret=0;
        	Console.Clear();
        	if (text==code_secret){
        		gagné=gagné+1;
        		goto bienJoué;
        	}
        	essais=essais+1;
        	while (nbrSecret<5){
        		
        		Console.Write("joueur 2 entrez votre essaie, vous en êtes a l'essaie :"+ essais);
        	Console.SetCursorPosition(LigneDébut, ColonneDébut+ 1);
        		/*code_secret =  Console.ReadLine();*/
	        	/*char c = Convert.ToChar(lettre);*/
	        	char c = (char)_getche();
        		if (!caractValide(c)){
	        		
        			Console.ReadKey();
	        		//Console.SetCursorPosition(LigneDébut + 10, ColonneDébut + 8);
	        		/*code_secret =  Console.ReadLine();
	        		c = Convert.ToChar(lettre);
	        		caractValide(c);*/
	        		Console.Clear();
	        		
        		}
        		else{
        			Console.WriteLine(text);
        			Console.ReadKey();
        			essaie[nbrSecret] = c;
        			nbrSecret=nbrSecret+1;
        			text= text + c.ToString();
        			Console.Clear();
        		}
        	}int tra=0;
        	for (tra=0;tra<essaie.Length;tra++){
	        			if (essaie[tra]!=combinaison[tra]){
	        				Console.WriteLine("X");
	        			}
	        			else{
	        				Console.WriteLine("y");
	        			}
        	
	        		}
        	Console.ReadKey();
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