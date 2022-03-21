using System;
using System.Collections.Generic;  

namespace CalculatorProgram
{
	class CalculatorMenu // Named for the main menu for performing operations.
	{
		static void Main(string[] args) // The main function where we call the other functions to perform the operations.
		{
			Console.WriteLine("This is a Calculator Program!"); // Greets the user.

			while (true) // Will continue to perform operations until user decides to end it.
			{
                // These WriteLines get the user to choose an operation with a switch statement.
				Console.WriteLine("Choose an operation: ");
                Console.WriteLine("[5] - Clear Operations And Start Over");
				Console.WriteLine("[4] - Division");
                Console.WriteLine("[3] - Multiplication");
                Console.WriteLine("[2] - Subtraction");
                Console.WriteLine("[1] - Addition");
				Console.WriteLine("[0] - Exit");
				
				int menuItem = int.Parse(Console.ReadLine()); // Will try to Parse the menu item option into an integer data type.

                double num1;
                double num2;
                double equation;

				switch (menuItem) // Switch statement for selecting a case with the appropriate number location.
				{
					case 0: // Clears the screen and takes the user out of the program.
						Console.WriteLine("Press Enter to continue.");
						Console.ReadLine();				
						Console.Clear();
						return;
				
					case 1: // Calls the Addition function.

                        Addition();
						break;

                    case 2: // Calls the Subtraction function.
                        Subtraction();
                        break;

                    case 3: // Calls the Multiplication function.
                        Multiplication();
                        break;

                    case 4:	// Calls the Division function.
                        Division();
                        break;

                    case 5: // Calls the Clear function.
                        Clear();
                        break;

					default: // Will tell the user of an invalid menu item option and give them the menu options again.
						Console.WriteLine("Not a valid option.");
						Console.WriteLine("Press Enter to continue.");
						Console.ReadLine();
						Console.Clear();
						break;
				}
			}
		}

		static void Addition() // This is where we do the addition function.
		{   

                Console.WriteLine("Please enter first number: "); 
                double num1 = double.Parse(Console.ReadLine()); // Tries to parse the number in a double data type.

                Console.WriteLine(" ");

                Console.WriteLine("Please enter second number: ");
                double num2 = double.Parse(Console.ReadLine()); // Tries to parse the number in a double data type.

                Console.WriteLine(" ");

                double equation = num1 + num2; // Adds both numbers.
                Console.WriteLine("Both numbers are equal to " + equation);
		}
        static void Subtraction() // This is where we do the subtraction function.
		{
            
                Console.WriteLine("Please enter first number: ");
                double num1 = double.Parse(Console.ReadLine()); // Tries to parse the number in a double data type.

                Console.WriteLine(" ");

                Console.WriteLine("Please enter second number: ");
                double num2 = double.Parse(Console.ReadLine()); // Tries to parse the number in a double data type.
                
                Console.WriteLine(" ");

                double equation = num1 - num2; // Subtracts both numbers.
                Console.WriteLine("Both numbers are equal to " + equation);
            
        }
        static void Multiplication() // This is where we do the multiplication function.
        {
        

                Console.WriteLine("Please enter first number: ");
                double num1 = double.Parse(Console.ReadLine()); // Tries to parse the number in a double data type.

                Console.WriteLine(" ");

                Console.WriteLine("Please enter second number: ");
                double num2 = double.Parse(Console.ReadLine()); // Tries to parse the number in a double data type.

                Console.WriteLine(" ");

                double equation = num1 * num2; // Multiplies both numbers.
                Console.WriteLine("Both numbers are equal to " + equation);
            
        }

        static void Division() // This is where we do the division function.
        {
            
                Console.WriteLine("Please enter first number: ");
                double num1 = double.Parse(Console.ReadLine()); // Tries to parse the number in a double data type.

                Console.WriteLine(" ");

                Console.WriteLine("Please enter second number: ");
                double num2 = double.Parse(Console.ReadLine()); // Tries to parse the number in a double data type.

                Console.WriteLine(" ");

                double equation = num1 / num2; // Divides both numbers.
                Console.WriteLine("Both numbers are equal to " + equation);
        }

        static void Clear() // This is the equation clear function.
        {
            Console.WriteLine("Equation results cleared and starting over. ");
            Console.WriteLine(" ");
            Console.WriteLine("Press Enter to continue. ");
            Console.ReadLine();
            double equation = 0; // Sets the equation operation back to 0.
        }
	}
}