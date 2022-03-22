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
            Console.WriteLine("----------------------------------------");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("**** Welcome to Cosmic Calculator! *****");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("----------------------------------------");
         

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

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[1] : Add");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[2] : Substract");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("[3] : Multiply");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[4] : Divide");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("[0] : Exit");

                //parsing the operator options to integer for the user to choose what they want to perform
				int operatorMenu = int.Parse(Console.ReadLine());

                Console.Clear();

                //branching the different operator options expressed in the while loop 
				switch ( operatorMenu )
				{
					case 0:			
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

        //addition function begin
        static void Addition()
        {

            double num1 = 0;
            double num2 = 0;
            double result = num1 + num2;

            //loops users input for performing addition problems
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;

                try
                { 
                    Console.WriteLine("Enter first number:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter second number :");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 + num2;         
                    Console.WriteLine("Total is : "+ result);
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Oops! Wrong Key. Please try again.");
                }
                    
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Do you want to continue? ");
                Console.WriteLine("[0] : No");
                Console.WriteLine("[1] : Yes");
                int operatorMenu = int.Parse(Console.ReadLine());

                Console.Clear(); 
                   
                switch ( operatorMenu )
				{
					case 0:			
						//Console.Clear();
						//return;
                        Environment.Exit(0);
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

        //substraction function begin
        static void Substraction()
        {
            double num1 = 0;
            double num2 = 0;
            double result = num1 + num2;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                try
                {

                    Console.WriteLine("Enter first number :");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter second number :");
                    num2 = Convert.ToDouble(Console.ReadLine());         
                    result = num1 - num2;         
                    Console.WriteLine("Total is : "+ result);
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Oops! Wrong Key. Please try again.");
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Do you want to continue? ");
                Console.WriteLine("[0] : No");
                Console.WriteLine("[1] : Yes");
                int exit = int.Parse(Console.ReadLine());
                Console.Clear();

                switch ( exit )
				{
					case 0:				
						//Console.Clear();
						//return;
                        Environment.Exit(0);
                        return;

                    case 1:
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

         //multiplication function begin
        static void Multiplication()
        {
            double num1 = 0;
            double num2 = 0;
            double result = num1 + num2;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;

                try
                {
                    Console.WriteLine("Enter first number :");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter second number :");
                    num2 = Convert.ToDouble(Console.ReadLine());         
                    result = num1 * num2;         
                    Console.WriteLine("Total is : "+ result);
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Oops! Wrong Key. Please try again.");
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Do you want to continue? ");
                Console.WriteLine("[0] : No");
                Console.WriteLine("[1] : Yes");
                int exit = int.Parse(Console.ReadLine());
                Console.Clear();

                switch ( exit )
				{
					case 0:			
						//Console.Clear();
						//return;
                        Environment.Exit(0);
                        return;

                    case 1:
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

        //division function begin
        static void Division()
        {
            double num1 = 0;
            double num2 = 0;
            double result = num1 + num2;

            while (true)
            { 
                Console.ForegroundColor = ConsoleColor.Yellow;

                try
                {
                    Console.WriteLine("Enter first number :");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter second number :");
                    num2 = Convert.ToDouble(Console.ReadLine());         
                    result = num1 / num2;         
                    Console.WriteLine("Total is : "+ result);
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Oops! Wrong Key. Please try again.");
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Do you want to continue? ");
                Console.WriteLine("[0] : No");
                Console.WriteLine("[1] : Yes");
                int exit = int.Parse(Console.ReadLine());
                Console.Clear();

                switch ( exit )
				{
					case 0:			
						//Console.Clear();
						//return;
                        Environment.Exit(0);
                        return;

                    case 1:
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


