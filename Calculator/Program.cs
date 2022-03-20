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
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Welcome to Cosmic Calculator!");
            Console.WriteLine("-----------------------------");

            double num1 = 0;
            double num2 = 0;
            double result = num1 + num2;

            while ( true )
			{
				//user choosing their operator to do their equation 
                Console.WriteLine("Please enter a number for your operator.");
                Console.WriteLine("[1] : Add");
                Console.WriteLine("[2] : Substract");
                Console.WriteLine("[3] : Multiply");
                Console.WriteLine("[4] : Divide");

				int menu = int.Parse(Console.ReadLine());

				switch ( menu )
				{
					case 0:
						Console.WriteLine("Press Enter to continue.");
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

            Console.WriteLine("Enter first number :");
            num1 = Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("Enter second number :");
            num2 = Convert.ToDouble(Console.ReadLine());         
            result = num1 + num2;         
            Console.WriteLine("Total is : "+ result);
            Console.ReadKey();
            Console.Clear();

        }

        static void Substraction()
        {
            double num1 = 0;
            double num2 = 0;
            double result = num1 + num2;

            Console.WriteLine("Enter first number :");
            num1 = Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("Enter second number :");
            num2 = Convert.ToDouble(Console.ReadLine());         
            result = num1 - num2;         
            Console.WriteLine("Total is : "+ result);
            Console.ReadKey();
            Console.Clear();


        }

        static void Multiplication()
        {
            double num1 = 0;
            double num2 = 0;
            double result = num1 + num2;

            Console.WriteLine("Enter first number :");
            num1 = Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("Enter second number :");
            num2 = Convert.ToDouble(Console.ReadLine());         
            result = num1 * num2;         
            Console.WriteLine("Total is : "+ result);
            Console.ReadKey();
            Console.Clear();

        }

        static void Division()
        {
            double num1 = 0;
            double num2 = 0;
            double result = num1 + num2;

            Console.WriteLine("Enter first number :");
            num1 = Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("Enter second number :");
            num2 = Convert.ToDouble(Console.ReadLine());         
            result = num1 / num2;         
            Console.WriteLine("Total is : "+ result);
            Console.ReadKey();
            Console.Clear();


        }

    }

}
