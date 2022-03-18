using System;

namespace FunCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            int? optionVar;
            string optionVarAttempt;
            string mathPhrase;
            int calcMode;
            string incomingFilename;
            string baseFilename;
            IDictionary<string, int> wordsNumbers = new Dictionary<string,int>();
            wordsNumbers.Add("one",1);
            wordsNumbers.Add("two",2);
            wordsNumbers.Add("three",3);
            wordsNumbers.Add("four",4);
            wordsNumbers.Add("five",5);
            wordsNumbers.Add("six",6);
            wordsNumbers.Add("seven",7);
            wordsNumbers.Add("eight",8);
            wordsNumbers.Add("nine",9);
            wordsNumbers.Add("ten",10);
            wordsNumbers.Add("eleven",11);
            wordsNumbers.Add("twelve",12);
            wordsNumbers.Add("thirteen",13);
            wordsNumbers.Add("fourteen",14);
            wordsNumbers.Add("fifteen",15);
            wordsNumbers.Add("sixteen",16);
            wordsNumbers.Add("seventeen",17);
            wordsNumbers.Add("eighteen",18);
            wordsNumbers.Add("nineteen",19);
            wordsNumbers.Add("twenty",20);
            wordsNumbers.Add("thirty",30);
            wordsNumbers.Add("forty",40);
            wordsNumbers.Add("fifty",50);
            wordsNumbers.Add("sixty",60);
            wordsNumbers.Add("seventy",70);
            wordsNumbers.Add("eighty",80);
            wordsNumbers.Add("ninety",90);
            wordsNumbers.Add("one hundred",100);
            wordsNumbers.Add("two hundred",200);
            wordsNumbers.Add("three hundred",300);
            wordsNumbers.Add("four hundred",400);
            wordsNumbers.Add("five hundred",500);
            wordsNumbers.Add("six hundred",600);
            wordsNumbers.Add("seven hundred",700);
            wordsNumbers.Add("eight hundred",800);
            wordsNumbers.Add("nine hundred",900);
            wordsNumbers.Add("one thousand",1000);




            //int[] menuNums = { 1, 2, 3, 4};


            Console.WriteLine("Hello and welcome to this calculator program, I hope we can find your solutions (press the 'any' key to continue).");
            Console.ReadKey();
            //Console.Clear();
            Console.WriteLine("What kind of input would you like to use?");
            Console.WriteLine("Options are: ");
            Console.WriteLine("1.) Standard numbers and operations.");
            Console.WriteLine("2.) Standard numbers, operations, and parentheses.");
            Console.WriteLine("3.) Words.");
            Console.WriteLine("4.) Anything Goes!");
            Console.WriteLine("5.) Actually, I brought a .txt file, I hope that isn't a problem.");
            Console.WriteLine("0.) I came here by mistake, please close this program.");
            optionVarAttempt = Console.ReadLine();
            
            try
            {
                optionVar = int.Parse(optionVarAttempt);
            }
            catch (System.Exception)
            {
                Console.WriteLine($"There is no time for {optionVarAttempt}.");
                return;
            }
                {
                /* if ( optionVar == 5 )
                {
                    calcMode = 2;
                }
                else if ( menuNums.Contains( optionVar ))
                {
                    calcMode == 1;
                }
                else
                {
                    calcMode == 0;
                }
                break; */



                /*if ( optionVar = 5)
                {
                    caseNumber = 2;
                }
                else if ( optionVar = 0)
                {
                    caseNumber = 0;
                }
                else
                {
                    caseNumber = 1;
                }*/
                }
            
            
            switch ( optionVar )
            {
                case 0:
                return;

                case 1:
                //Console.Clear();
                Console.WriteLine("Alright then, what equation would you like the solution to?");
                mathPhrase = Console.ReadLine();
                /*inputShredder();
                abacus();*/
                break;

                case 2:
                //Console.Clear();
                Console.WriteLine("Alright then, what equation would you like the solution to?");
                mathPhrase = Console.ReadLine();
                /*inputShredder();
                abacus();*/
                break;

                case 3:
                //Console.Clear();
                Console.WriteLine("Alright then, what equation would you like the solution to?");
                mathPhrase = Console.ReadLine();
                /*inputShredder();
                abacus();*/
                break;

                case 4:
                //Console.Clear();
                Console.WriteLine("Alright then, what equation would you like the solution to?");
                mathPhrase = Console.ReadLine();
                /*inputShredder();
                abacus();*/
                break;
             
                case 5:
                Console.WriteLine("What .txt file would you like evaluated by the calculator?");
                incomingFilename = Console.ReadLine();
                /*fileFunnel();
                inputShredder();
                abacus();
                fileMaker();*/

                baseFilename = incomingFilename.Substring( 0 , incomingFilename.Length - 4 );
                Console.WriteLine("Your solutions can be found in the file named: " + baseFilename + "-solved.txt. Thank you for using the calculator.");
                break;

            }
        }
        static void inputShredder()
        {
            //mathPhrase
        }

        static void fileFunnel()
        {                
                

        }

        static void abacus()
        {                
                

        }

        static void fileMaker()
        {                
                

        }

                
    }
}