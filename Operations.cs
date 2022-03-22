namespace CalculatorProgram
{   
    class Operations // Named for the main menu for performing operations.
	{
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
}   }
