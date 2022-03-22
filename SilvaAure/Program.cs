namespace Calculator;

	class Program
	{

    static void Main(string[] args)
		{
	Console.WriteLine("Welcome to Aure's Calculator!");

			while ( true )
			{
				Console.WriteLine("Please choose a mathematical function: ");
				Console.WriteLine("[1] - Addition");
				Console.WriteLine("[2] - Subtraction");
				Console.WriteLine("[3] - Multiplication");
				Console.WriteLine("[4] - Division");
				Console.WriteLine("[5] - Power");
				Console.WriteLine("[6] - Square");
				Console.WriteLine("[7] - Round");
				Console.WriteLine("[0] - Exit");

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
						Subtraction();
						break;
					
					case 3:
                    	Multiplication();
						break;
					
					case 4:
                    Division();
						break;

					case 5:
					Power();
					break;

					case 6:
					Square();
					break;

					case 7:
					Rounding();
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

    private static void Addition()
		{
				int num1, num2, result;
        Console.WriteLine("Enter Number 1");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Number 2");
        num2 = Convert.ToInt32(Console.ReadLine());

        result = num1 + num2;

        Console.WriteLine("{0} + {1} = {2}",num1,num2,result);
		Console.WriteLine("Press any key to exit to menu");
		Console.ReadKey();
		
		}
			private static void Subtraction()
		
		{
			int num3, num4, result1;
        Console.WriteLine("Enter Number 1");
        num3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Number 2");
        num4 = Convert.ToInt32(Console.ReadLine());

        result1 = num3 - num4;

        Console.WriteLine("{0} - {1} = {2}",num3,num4,result1);

        Console.WriteLine("Press any key to exit to menu");
        Console.ReadKey();
		}
		
			private static void Multiplication()
		{
				int num5, num6, result2;
        Console.WriteLine("Enter Number 1");
        num5 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Number 2");
        num6 = Convert.ToInt32(Console.ReadLine());

        result2 = num5 * num6;

        Console.WriteLine("{0} * {1} = {2}",num5,num6,result2);
		Console.WriteLine("Press any key to exit to menu");
		Console.ReadKey();
		
		}
		private static void Division()
		{
				int num7, num8, result3;
        Console.WriteLine("Enter Number 1");
        num7 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Number 2");
        num8 = Convert.ToInt32(Console.ReadLine());

        result3 = num7 / num8;

        Console.WriteLine("{0} / {1} = {2}",num7,num8,result3);
		Console.WriteLine("Press any key to exit to menu");
		Console.ReadKey();
		
		}	
		private static void Power()
		{
			
		int x, y;
        Console.WriteLine("Enter Base Number ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Power number");
        y = Convert.ToInt32(Console.ReadLine());
		
        Console.WriteLine(Math.Pow (x, y));
		Console.WriteLine("Press any key to exit to menu");
		Console.ReadKey();
		}
		private static void Square()
		{
			
		int num9;
        Console.WriteLine("Enter Number To Square ");
        num9 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Math.Sqrt(num9));
		Console.WriteLine("Press any key to exit to menu");
		Console.ReadKey();
		}
		 private static void Rounding()
	{
		{
		double x = 0;
		double y = 0;
		while (x >= 0)
		{
			Console.WriteLine("Please enter the number to round");
			
			x = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("The number to Round is {0}", x);
			
			y = Math.Round(x, 1);
			Console.WriteLine("Rounded to the nearest Integer : {0:F0}", y);
			
			
			Console.WriteLine("Press any key to exit to menu");
			Console.ReadKey();
			return;
				}
			}
		}
	}
