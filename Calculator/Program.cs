using System;
using System.IO;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is your Calculator!");

            while ( true )
            {
                Console.WriteLine("Enter the operation that you want to use!");
                Console.WriteLine("[4] - Division");
                Console.WriteLine("[3] - Multiplication");
                Console.WriteLine("[2] - Subtraction");
                Console.WriteLine("[1] - Addition");
                Console.WriteLine("[0] - Exit");

                int choices = int.Parse(Console.ReadLine());
                switch( choices )
                {
                    case 0:
                        Console.WriteLine("Press Enter to Continue");
                        Console.ReadLine();
                        Console.Clear();
                        return;
                    
                    case 1:
                        Addition();
                        break;

                    case 2:
                        Subtraction();
                        break;

                    case 3:
                        Multiplication();
                        break;

                    case 4:
                        Division();
                        break;

                    default:
                        Console.WriteLine("Bad input: Not a valid option.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
        }

        static async void Addition()
        {
            double number1, number2;
            double Result;

            while ( true )
            {
                Console.WriteLine("Enter the numbers you want to calculate.");
                Console.WriteLine("Input the first number: ");
                number1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Input the second number: ");
                number2 = Convert.ToDouble(Console.ReadLine());
                Result = number1 + number2; 
                Console.WriteLine("The result of the sum is: " + Result);
                Console.WriteLine("Press Enter to continue.");
                Console.ReadLine();
                Console.Clear();
                break;
            
            }

        }

        static void Subtraction()
        {
            double number1, number2;
            double Result;

            while( true )
            {
                Console.WriteLine("Enter the numbers you want to calculate.");
                Console.WriteLine("Input the first number: ");
                number1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Input the second number: ");
                number2 = Convert.ToDouble(Console.ReadLine());

                Result = number1 - number2;
                

                Console.WriteLine("The result of the difference is: " + Math.Round(Result, 3));

                Console.WriteLine("Press Enter to continue.");
                Console.ReadLine();
                Console.Clear();
                break;
            }

        }

        static void Multiplication()
        {
            double number1, number2;
            double Result;

            while( true )
            {
                Console.WriteLine("Enter the numbers you want to calculate.");
                Console.WriteLine("Input the first number: ");
                number1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Input the second number: ");
                number2 = Convert.ToDouble(Console.ReadLine());

                Result = number1 * number2;

                Console.WriteLine("The result of the product is: " + Math.Round(Result, 3));

                Console.WriteLine("Press Enter to continue.");
                Console.ReadLine();
                Console.Clear();
                break;
            }
        }

        static void Division()
        {
            double number1, number2;
            double Result;

            while( true )
            {
                Console.WriteLine("Enter the numbers you want to calculate.");
                Console.WriteLine("Input the first number: ");
                number1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Input the second number: ");
                number2 = Convert.ToDouble(Console.ReadLine());

                Result = number1 / number2;

                Console.WriteLine("The result of the quotient is: " + Math.Round(Result, 3));

                Console.WriteLine("Press Enter to continue.");
                Console.ReadLine();
                Console.Clear();
                break;
            }
        }
    }
}