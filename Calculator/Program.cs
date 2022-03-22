namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {


            while ( true )
			{

				Console.WriteLine("What operation would you like to perform?");
				Console.WriteLine("[1] - (+)");
				Console.WriteLine("[2] - (-)");
                Console.WriteLine("[3] - (*)");
                Console.WriteLine("[4] - (/)");
				Console.WriteLine("[0] - Cancel");

                string userSelect = Console.ReadLine();

				switch ( userSelect )
				{
					case "0":
						Console.WriteLine("Press Enter to EXIT.");
						Console.ReadLine();				
						Console.Clear();
						return;
					case "1":
                        
                        Addition();
                        Console.WriteLine("Press Enter to continue.");
						Console.ReadLine();		
                        Console.Clear();
						break;
					case "2":
                        Subtraction();
                        Console.WriteLine("Press Enter to continue.");
						Console.ReadLine();		
                        Console.Clear();
						break;
                    case "3":
                        Multiplication();
                        Console.WriteLine("Press Enter to continue.");
						Console.ReadLine();		
                        Console.Clear();
                        break;
                    case "4":
                        Division();
                        Console.WriteLine("Press Enter to continue.");
						Console.ReadLine();		
                        Console.Clear();
                        break;
					default:
						Console.WriteLine("OOPS! That was not a valid answer. Please try again.");
						Console.WriteLine("Press Enter to continue.");
						Console.ReadLine();
						Console.Clear();
						break;
				}
			}
        }

         static void Addition()
        {
            Console.WriteLine("Choose a number to begin with: ");
            float userNum1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Add: ");
            float userNum2 = float.Parse(Console.ReadLine());
            float total = (userNum1 + userNum2);
            Console.WriteLine($"{userNum1} + {userNum2} = {total}");
        }
        static void Subtraction()
        {
            Console.WriteLine("Choose a number to begin with: ");
            float userNum1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Subtract: ");
            float userNum2 = float.Parse(Console.ReadLine());
            float total = (userNum1 - userNum2);
            Console.WriteLine($"{userNum1} - {userNum2} = {total}");
        }
        static void Multiplication()
        {
            Console.WriteLine("Choose a number to begin with: ");
            float userNum1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Multiply by: ");
            float userNum2 = float.Parse(Console.ReadLine());
            float total = (userNum1 * userNum2);
            Console.WriteLine($"{userNum1} * {userNum2} = {total}");
        }
        static void Division()
        {
            Console.WriteLine("Choose a number to begin with");
            float userNum1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Divide by: ");
            float userNum2 = float.Parse(Console.ReadLine());
            while (userNum2 == 0)
            {
                Console.WriteLine("Cannot divide by 0. Please pick another number");
                userNum2 = float.Parse(Console.ReadLine());
            }
            float total = (userNum1 / userNum2);
            Console.WriteLine($"{userNum1} / {userNum2} = {total}");
        }
    }
}