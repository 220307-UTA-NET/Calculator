using System;
using System.Collections.Generic;
using System.IO;

namespace CosmicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //The program starts here...
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-----------------------------");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Welcome to Cosmic Calculator!");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-----------------------------");
         

            //giving the doubles a starting point at 0
            double num1 = 0;
            double num2 = 0;
            double result = num1 + num2;

            //loop through the operators until user exits
            while ( true )
			{
				//user choosing their operator to do their equation 
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Please enter a number for your operator.");
                Console.WriteLine("[1] : Add");
                Console.WriteLine("[2] : Substract");
                Console.WriteLine("[3] : Multiply");
                Console.WriteLine("[4] : Divide");
                Console.WriteLine("[0] : Exit");

                //parsing the operator options to integer for the user to choose what they want to perform
				int menu = int.Parse(Console.ReadLine());

                //branching the different operator options expressed in the while loop 
				switch ( menu )
				{
					case 0:
						Console.WriteLine("Press Enter to exit.");
						Console.ReadLine();				
						Console.Clear();
						return;
				
					case 1:
						Addition();
						break;
				
					case 2:
						Substraction();
						break;

                    case 3:
						Multiplication();
						break;

                    case 4:
						Division();
						break;

					default:
						Console.WriteLine("Bad input: Input was not a valid option.");
						Console.WriteLine("Press Enter to continue.");
						Console.ReadLine();
						Console.Clear();
						break;
				}
            }
        }    

        static void Addition()
        {

            double num1 = 0;
            double num2 = 0;
            double result = num1 + num2;

            while (true)
            {
                //loops users input for performing addition problems
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter first number :");
                num1 = Convert.ToDouble( Console.ReadLine());
                Console.WriteLine("Enter second number :");
                num2 = Convert.ToDouble(Console.ReadLine());         
                result = num1 + num2;         
                Console.WriteLine("Total is : "+ result);
                Console.ReadKey();
                Console.Clear();


                Console.WriteLine("Do you want to continue? ");
                Console.WriteLine("[0] : No");
                Console.WriteLine("[1] : Yes");

                int menu = int.Parse(Console.ReadLine());

                switch ( menu )
				{
					case 0:
						Console.WriteLine("Press Enter to exit.");
						Console.ReadLine();				
						Console.Clear();
						return;

                    case 1:
						Addition();
						break;

                    default:
						Console.WriteLine("Bad input: Input was not a valid option.");
						Console.WriteLine("Press Enter to continue.");
						Console.ReadLine();
						Console.Clear();
						break;
                }
            
            }


        }

        static void Substraction()
        {
            double num1 = 0;
            double num2 = 0;
            double result = num1 + num2;

            while (true)
            {

                 Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter first number :");
                num1 = Convert.ToDouble( Console.ReadLine());
                Console.WriteLine("Enter second number :");
                num2 = Convert.ToDouble(Console.ReadLine());         
                result = num1 - num2;         
                Console.WriteLine("Total is : "+ result);
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Do you want to continue? ");
                Console.WriteLine("[0] : No");
                Console.WriteLine("[2] : Yes");

                int menu = int.Parse(Console.ReadLine());

                switch ( menu )
				{
					case 0:
						Console.WriteLine("Press Enter to exit.");
						Console.ReadLine();				
						Console.Clear();
						return;

                    case 2:
						Substraction();
						break;

                    default:
						Console.WriteLine("Bad input: Input was not a valid option.");
						Console.WriteLine("Press Enter to continue.");
						Console.ReadLine();
						Console.Clear();
						break;
                }

            }

        }

        static void Multiplication()
        {
            double num1 = 0;
            double num2 = 0;
            double result = num1 + num2;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Enter first number :");
                num1 = Convert.ToDouble( Console.ReadLine());
                Console.WriteLine("Enter second number :");
                num2 = Convert.ToDouble(Console.ReadLine());         
                result = num1 * num2;         
                Console.WriteLine("Total is : "+ result);
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Do you want to continue? ");
                Console.WriteLine("[0] : No");
                Console.WriteLine("[3] : Yes");

                int menu = int.Parse(Console.ReadLine());

                switch ( menu )
				{
					case 0:
						Console.WriteLine("Press Enter to exit.");
						Console.ReadLine();				
						Console.Clear();
						return;

                    case 3:
						Multiplication();
						break;

                    default:
						Console.WriteLine("Bad input: Input was not a valid option.");
						Console.WriteLine("Press Enter to continue.");
						Console.ReadLine();
						Console.Clear();
						break;
                }
            
            }
        }

        static void Division()
        {
            double num1 = 0;
            double num2 = 0;
            double result = num1 + num2;

            while (true)
            { 
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Enter first number :");
                num1 = Convert.ToDouble( Console.ReadLine());
                Console.WriteLine("Enter second number :");
                num2 = Convert.ToDouble(Console.ReadLine());         
                result = num1 / num2;         
                Console.WriteLine("Total is : "+ result);
                Console.ReadKey();
                Console.Clear();


                Console.WriteLine("Do you want to continue? ");
                Console.WriteLine("[0] : No");
                Console.WriteLine("[4] : Yes");

                int menu = int.Parse(Console.ReadLine());

                switch ( menu )
				{
					case 0:
						Console.WriteLine("Press Enter to exit.");
						Console.ReadLine();				
						Console.Clear();
						return;

                    case 4:
						Division();
						break;

                    default:
						Console.WriteLine("Bad input: Input was not a valid option.");
						Console.WriteLine("Press Enter to continue.");
						Console.ReadLine();
						Console.Clear();
						break;
                }

            }


        }

    }
}


