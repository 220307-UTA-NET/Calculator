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
                Console.WriteLine("[5] - Multiple Operations");
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
                        Console.WriteLine("Press enter to continue");
					    Console.ReadLine();
					    Console.Clear();
                        break;
                    case 2:
                        SubtractInput();
                        Console.WriteLine("Press enter to continue");
					    Console.ReadLine();
					    Console.Clear();
                        break;
                    case 3:
                        DivideInput();
                        Console.WriteLine("Press enter to continue");
					    Console.ReadLine();
					    Console.Clear();
                        break;
                    case 4:
                        MultiplyInput();
                        Console.WriteLine("Press enter to continue");
					    Console.ReadLine();
					    Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Enter the first number to operate on");
                        double first= double.Parse(Console.ReadLine());
                        first=(MultipleOperation(first));
                        while (true)
                        {                           
                            Console.WriteLine("Type \"DONE\" to finish. \nPress Enter to perform another operation on your solution.");
                                            
                            if (Console.ReadLine().ToUpper() == "DONE" )
                            {
                               break; 
                            }
                            else
                            {
                                first=(MultipleOperation(first));
                            }   
                        }
					    Console.Clear();
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
            string mathLine="equation";
            int solution=0;
            for(int c=0; c<numbers.Length; c++)
            {
                if(c==0)
                {
                    solution = numbers[c] + solution;
                    mathLine = numbers[c].ToString();
                }
                else
                {
                    solution = numbers[c] + solution;
                    mathLine = mathLine+ " + " +numbers[c].ToString();
                }
            }
            Console.Clear();
            Console.WriteLine(mathLine+ " = "+solution);
        }

        static void SubtractInput()
        {
            List<int> numbers = new List<int>(); 
            
            Console.WriteLine("Enter a number to subtract from: ");
            numbers.Add(int.Parse(Console.ReadLine()));
        
            Console.WriteLine("Enter a number(s) to subtract with: \nEnter \"Done\" when you have finished inputing numbers ");
            
            while (true)
            {
                string nextInput=Console.ReadLine();
                if (nextInput.ToUpper() =="DONE")
                {
                    break;
                }
                else
                {
                    numbers.Add(int.Parse(nextInput));
                }
            }
            
            
            string mathLine="equation";
            int solution=0;
            int [] array = numbers.ToArray();
            //Console.WriteLine(array.Length);

            for(int i=1; i<array.Length; i++)
            {
                if (i==1)
                {
                    solution = array[0]-array[1];
                    mathLine = array[0].ToString()+ " - " +array[1].ToString();
                    //Console.WriteLine(solution);
                }
                else
                {
                    solution = solution-array[i];
                    mathLine =mathLine +" - "+ array[i].ToString();
                    //Console.WriteLine(solution);
                }
            }
            Console.Clear();
            Console.WriteLine(mathLine+" = "+solution);

        }
        static void DivideInput()
        {
            Console.WriteLine("In Progess, come back later.");
        }

        static void MultiplyInput()
        {
            Console.WriteLine("In Progess, come back later.");
        }

        static double MultipleOperation(double first)
        {
            double[] numbers=new double[2];
            double solution=0;

            //Console.WriteLine("Enter the first number to operate on");
            numbers [0]= first;
            
            Console.WriteLine("Choose an operation and press Enter.");
            Console.WriteLine("[+] - Add");
            Console.WriteLine("[-] - Subtract");
            Console.WriteLine("[/] - Divide");
            Console.WriteLine("[*] - Multiply"); 

            while (true)
            {
                string menu = Console.ReadLine();
					
				switch(menu)
                {
                    case "+":
                        Console.WriteLine("Enter your next number");
                        numbers [1]= int.Parse(Console.ReadLine());
                        solution=numbers[0]+numbers[1];
                        Console.Clear();
                        Console.WriteLine(numbers[0]+" + "+numbers[1]+ " = "+solution);
                        numbers [0]=numbers[0]+numbers[1];
                        return numbers[0];
                    case "-":
                        Console.WriteLine("Enter your next number");
                        numbers [1]= int.Parse(Console.ReadLine());
                        solution=numbers[0]-numbers[1];
                        Console.Clear();
                        Console.WriteLine(numbers[0]+" - "+numbers[1]+ " = "+solution);
                        numbers [0]=numbers[0]-numbers[1];   
                        return numbers[0]; 
                    case "/":
                        Console.WriteLine("Enter your next number");
                        numbers [1]= int.Parse(Console.ReadLine());
                        solution=numbers[0]/numbers[1];
                        Console.Clear();
                        Console.WriteLine(numbers[0]+" / "+numbers[1]+ " = "+solution);
                        numbers [0]=numbers[0]/numbers[1];
                        return numbers[0];
                    case "*":
                        Console.WriteLine("Enter your next number");
                        numbers [1]= int.Parse(Console.ReadLine());
                        solution=numbers[0]*numbers[1];
                        Console.Clear();
                        Console.WriteLine(numbers[0]+" * "+numbers[1]+ " = "+solution);
                        numbers [0]=numbers[0]*numbers[1];
                        return numbers[0];
                }
        
            }




        }
    }
}
