using System.Data;
using System;
using System.Collections.Generic;

namespace Calculon
{
    public class Program
    {
        static void Main(string[] args)
        {
            int optionVar;
            string optionVarAttempt;
            string mathPhrase;
            int useCase;
            string filepath = @".\History.txt";

            Console.WriteLine("Hello and welcome to this calculator program, I hope we can find your solutions (press the 'any' key to continue).");
            Console.ReadKey();
            Console.Clear();
            while (true)
            {
                Console.WriteLine("What kind of input would you like to use?");
                Console.WriteLine("Options are: ");
                Console.WriteLine("1.) Standard numbers and operations.");
                Console.WriteLine("2.) Standard numbers, operations, and parentheses.");
                Console.WriteLine("3.) Words.");
                Console.WriteLine("4.) Anything Goes!");
                Console.WriteLine("5.) Actually, I brought a .txt file, I hope that isn't a problem. UNDER CONSTRUCTION.");
                Console.WriteLine("0.) I came here by mistake, please close this program.");
                optionVarAttempt = Console.ReadLine();
                
                bool success =  int.TryParse(optionVarAttempt, out optionVar);
                if (success)
                {
                    optionVar = int.Parse(optionVarAttempt);
                }          
                else
                {
                    throw new Exception("You've tried to enter something other than numbers.");
                    //Console.WriteLine ("You've tried to enter something other than 0-5, try again.");
                    //return;
                }                        
            
                if ((optionVar > 0) && (optionVar < 5))
                {
                    useCase = 1;
                }
                else if (optionVar == 5)
                {
                    useCase = 2;
                }
                else if (optionVar ==0)
                {
                    useCase = 0;
                }
                else
                {
                    throw new IndexOutOfRangeException(); 
                }

                switch ( useCase )
                {
                    case 0:
                    return;

                    case 1:
                    Console.Clear();
                    Console.WriteLine("Alright then, what equation would you like the solution to?");
                    mathPhrase = Console.ReadLine();
                    
                    string[] mathPhraseWrite = {mathPhrase};
                    DataTable mathtrix = new DataTable();
                    var tempOutput = mathtrix.Compute(mathPhrase,"");
                    if (!File.Exists(filepath))
                    {
                        File.WriteAllLines(filepath, mathPhraseWrite);
                    }
                    else
                    {
                        File.AppendAllLines(filepath, mathPhraseWrite);
                    }

                    Console.WriteLine("The solution: " + mathPhrase + " = " + tempOutput + $".\nPress enter to continue.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
            }
        }
    }
}