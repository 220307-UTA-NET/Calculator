using System.Text.RegularExpressions;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator!");
            
            while (true)
            {
                Console.WriteLine("[1] - Input Equation Line");
                Console.WriteLine("[0] - Exit");

                int menu = int.Parse(Console.ReadLine());
                {
                    switch(menu)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Enter your equation. \nPlease only use 0-9 as values and + - / * as operands.");
                            string? input = Console.ReadLine();
                            InputFullEquation(input);
                            Console.WriteLine("Press enter to return to the menu");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 0:
                            Console.Clear();
                            Console.WriteLine("Goodbye!");
                            return;
                    }
                }
            }

            // while (true)
            // {
            //     Console.WriteLine("Select one of the listed funtions");
            //     Console.WriteLine("[1] - Add numbers");
            //     Console.WriteLine("[2] - Subtract numbers");
            //     Console.WriteLine("[3] - Divide numbers");
            //     Console.WriteLine("[4] - Multiply numbers");
            //     Console.WriteLine("[5] - Multiple Operations");
            //     Console.WriteLine("[6} - Input Equation Line");
            //     Console.WriteLine("[0] - Exit");

            //     int menu = int.Parse(Console.ReadLine());
                    
            //     switch(menu)
            //     {
            //         case 0:
            //             Console.Clear();
            //             Console.WriteLine("Goodbye!");
            //             return;
            //         case 1:
            //             AddInput();
            //             Console.WriteLine("Press enter to continue");
            //             Console.ReadLine();
            //             Console.Clear();
            //             break;
            //         case 2:
            //             SubtractInput();
            //             Console.WriteLine("Press enter to continue");
            //             Console.ReadLine();
            //             Console.Clear();
            //             break;
            //         case 3:
            //             DivideInput();
            //             Console.WriteLine("Press enter to continue");
            //             Console.ReadLine();
            //             Console.Clear();
            //             break;
            //         case 4:
            //             MultiplyInput();
            //             Console.WriteLine("Press enter to continue");
            //             Console.ReadLine();
            //             Console.Clear();
            //             break;
            //         case 5:
            //             Console.Clear();
            //             Console.WriteLine("Enter the first number to operate on");
            //             if (!Double.TryParse(Console.ReadLine(), out decimal first))
            //             {
            //                 Console.Write("Error not a valid input\n");
            //                 break;
            //             }
            //             first=(MultipleOperation(first));
            //             while (true)
                        
            //             {                           
            //                 Console.WriteLine("Type \"DONE\" to finish. \nPress Enter to perform another operation on your solution.");
                                            
            //                 if (Console.ReadLine().ToUpper() == "DONE" )
            //                 {
            //                     break; 
            //                 }
            //                 else
            //                 {
            //                     first=(MultipleOperation(first));
            //                 }   
            //             }
            //             Console.Clear();
            //             break;
            //         case 6:
            //             Console.WriteLine("Enter your equation. \nPlease only use 0-9 as values and + - / * as operands.");
            //             string? input = Console.ReadLine();
            //             InputFullEquation(input);
            //             //Console.WriteLine("Here's you answer. Remove your solution or operate further on it");
            //             Console.WriteLine("Press enter to return to the menu");
            //             Console.ReadLine();
            //             Console.Clear();
            //             break;
            //     }
            // }
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

            static decimal MultipleOperation(decimal first)
            {
                decimal[] numbers=new decimal[2];
                decimal solution=0;

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

            static void InputFullEquation(string input)
        {
            //remover any potential whitespaces
            string strippedInput = String.Concat(input.Where(c => !Char.IsWhiteSpace(c)));

             // List of entire string as chars
            List<char> inputList = input.ToList();
            
            //Check for invalid inputs
            for (int i =0; i<strippedInput.Length; i++)
            {
                Match m = Regex.Match(strippedInput.Substring(i,1), @"[0-9\.\+\-\*\/]");
                if (m.Success)
                {}
                else
                {
                    Console.WriteLine("Invalid input!");
                    return;
                }
            }
        
            //Check equation for division by Zero
            bool divideByZero = strippedInput.Contains("/0");
            if (divideByZero)
            {
            Console.WriteLine("Cannot divide by zero, result will be infinite");
            return;
            }
            
            //Parse out values separated by operands
            //Convert to a list of decimals
            List<string> listValues = new List<string>();
            listValues = strippedInput.Split('+','-','/','*').ToList(); 
            List<decimal> listValuesDec = listValues.ConvertAll<decimal>(Convert.ToDecimal);


            
            List<char> operandsList = new List<char>(); //new List to populate with operands

            for (int i=0; i<inputList.Count; i++)
            {
                if (inputList[i] == '+'||inputList[i] == '-'||inputList[i] == '/'||inputList[i] == '*')
                {
                    operandsList.Add(inputList[i]);
                }   
            }
            

            //Iterate through operands and evalute * and /
            int operandsLeft = operandsList.Count;
            for(int j=0; j<operandsLeft; j++)
            {
                while (true)
                {
                    for (int i=0, c=1; i<operandsList.Count; i++, c++)
                    {
                        if (operandsList[i] == '*')
                        {
                            listValuesDec[i]=Multiply(listValuesDec[i],listValuesDec[c]);
                            listValuesDec.RemoveAt(c);
                            operandsList.RemoveAt(i);
                            break; 
                        }
                        else if (operandsList[i] == '/')
                        {
                            listValuesDec[i]=Divide(listValuesDec[i],listValuesDec[c]);
                            listValuesDec.RemoveAt(c);
                            operandsList.RemoveAt(i); 
                            break;
                        }
                    }
                    break;
                }
            }
            
            //Output answer and return if length of listValuesList is 1
            if( listValuesDec.Count==1)
            {
                foreach(decimal i in listValuesDec)
                {
                    Console.WriteLine(strippedInput+"="+i);
                    WriteToFile(strippedInput+"="+i);
                    return;
                }
            }


            //Iterate though operands and evaluate + and -
            operandsLeft = operandsList.Count;
             for(int j=0; j<operandsLeft; j++)
            {
                while (true)
                {
                    for (int i=0, c=1; i<operandsList.Count; i++, c++)
                    {
                        if (operandsList[i] == '+')
                        {
                            listValuesDec[i]=Add(listValuesDec[i],listValuesDec[c]);
                            listValuesDec.RemoveAt(c);
                            operandsList.RemoveAt(i);
                        }
                        else if (operandsList[i] == '-')
                        {
                            listValuesDec[i]=Subtract(listValuesDec[i],listValuesDec[c]);
                            listValuesDec.RemoveAt(c);
                            operandsList.RemoveAt(i);
                        }
                    }
                    break;
                }
            }

            //Output answer and return if length of listValuesList is 1
             if( listValuesDec.Count==1)
            {
                foreach(decimal i in listValuesDec)
                {
                    Console.WriteLine(strippedInput+"="+i);
                    WriteToFile(strippedInput+"="+i);
                    return;
                }
            }

            
        }

            static decimal Add(decimal a, decimal b)
            {
                decimal c = a+b;
                return c;
            }

            static decimal Subtract(decimal a, decimal b)
            {
                decimal c = a-b;
                return c;
            }

            static decimal Multiply(decimal a, decimal b)
            {
                decimal c = a*b;
                return c;
            }

            static decimal Divide(decimal a, decimal b)
                {
                    decimal c = a/b;
                    return c;
                }

            static void WriteToFile(string equation)
            {
                string [] header ={"Equations evaluated in Dan's Calculator"};
                string path = @".\CalculatorHistory.txt";
                string[] equationToFile = new string []{equation};


                //testing if file exists yet
                if (! File.Exists(path))
                {
                    File.WriteAllLines(path, header);
                    File.AppendAllLines(path, equationToFile);
                }
                else
                { 
                    File.AppendAllLines(path, equationToFile);
                }
            }
    }
}
 