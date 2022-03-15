namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator!");

            while (true)
            {
                Console.WriteLine("Select one of the listed funtions");
                Console.WriteLine("[1] - Add numbers");
                Console.WriteLine("[2] - Subtract numbers");
                Console.WriteLine("[3] - Divide numbers");
                Console.WriteLine("[4] - Multiply numbers");
                Console.WriteLine("[0] - Exit");

                int menu = int.Parse(Console.ReadLine());
					
				switch(menu)
				{
					case 0:
						Console.Clear();
						Console.WriteLine("Goodbye!");
						return;
                    case 1:
                        AddInput();
                        break;
                    case 2:
                        SubtractInput();
                        break;
                    case 3:
                        DivideInput();
                        break;
                    case 4:
                        MultiplyInput();
                        break;
                }
            }
        }

        static void AddInput()
        {
            //create array with length equal to quantity of numbers   
            Console.WriteLine("How many numbers do you want to add?");
            int totalAmountOfNumbers=int.Parse(Console.ReadLine());
            int [] numbers = new int[totalAmountOfNumbers];

            //populate array with user input
            for (int i=0; i<numbers.Length; i++)
            {
                if(i==0)
                {
                    Console.WriteLine("Enter your first number:");
                    numbers[i]=int.Parse(Console.ReadLine()); 
                }
                else if (i>0)
                {    
                    Console.WriteLine("Enter the next number to add:");
                    numbers[i]=int.Parse(Console.ReadLine());
                }

            }

            //iterate over array and add the values together
            int solution=0;
            for(int c=0; c<numbers.Length; c++)
            {
                solution = numbers[c] + solution;
            }

            Console.WriteLine("The sum of your numbers is: "+solution);
        }

        static void SubtractInput()
        {

        }
        static void DivideInput()
        {

        }

        static void MultiplyInput()
        {

        }
    }
}
