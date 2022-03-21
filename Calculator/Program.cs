using System;
using System.Collections;
using System.IO;

namespace Calculator
{

    class Program
    {

        static int whichoperator(int answer, List<string> operations, int nextnum)
        {
            if (operations[0] == "+")
            {
                answer = answer + nextnum;
            }else if (operations[0]== "-")
            {
                answer = answer - nextnum;
            }else if (operations[0]== "*")
            {
                answer = answer * nextnum;
            }else if (operations[0]== "/")
            {
                if (nextnum == 0)
                {
                    throw new InvalidOperationException("Cannot divide by zero");
                }else
                {
                answer = answer / nextnum;
                }
            }else if (operations[0] == null)
            {
                return answer;
            }

            operations.RemoveAt(0);
            return answer;
        }
        public static Dictionary<string, string> textconverTable = new Dictionary<string, string>{  
        {"zero","0"},{"one","1"},{"two","2"},{"three","3"},{"four","4"},{"five","5"},{"six","6"},  
        {"seven","7"},{"eight","8"},{"nine","9"},{"ten","10"},{"eleven","11"},{"twelve","12"},  
        {"thirteen","13"},{"fourteen","14"},{"fifteen","15"},{"sixteen","16"},{"seventeen","17"},  
        {"eighteen","18"},{"nineteen","19"},{"twenty","20"},{"thirty","30"},{"forty","40"},  
        {"fifty","50"},{"sixty","60"},{"seventy","70"},{"eighty","80"},{"ninety","90"},  
        {"hundred","100"},{"thousand","1000"},{"lakh","100000"},{"million","1000000"},  
        {"billion","1000000000"}, {"plus", "+"}, {"minus", "-"}, {"multiplied-by", "*"}, {"divided-by", "/"} 
        };  


        static void StringCalc()
        {
            while(true)
            {
                Console.WriteLine("This is the Calculator.");
                Console.WriteLine("enter the numbers you want to calculate ");
                Console.WriteLine("You can use Plus or + and have multiple numbers.");
                string theEquation = Console.ReadLine();//2 + 2
                Console.WriteLine(theEquation);
                string[] words = theEquation.Split(' ');

                var answer =0;
                List<string> operations= new List<string>();
                List<int> thedigits = new List<int>(); 

                foreach (var numbers in words)
                {
                    // each element in the array is numbers  
                    string key = numbers;
                    bool keyExists = textconverTable.ContainsKey(key);
                    if (keyExists){
                    string texttovalue = textconverTable[numbers];
        
                    words = words.Select(s => s.Replace(numbers, texttovalue)).ToArray();
                    
                    }
                    else 
                    {
                        continue;
                    }
                }

              



                foreach (var word in words)
                {
                
                    if ((word == "+") || (word == "-") || (word == "/") || (word == "*"))
                    {
                        Console.WriteLine(word);
                        operations.Add(word);
                    } 
                    try
                    {
                        int result = Int32.Parse(word);
                        Console.WriteLine(result);
                        thedigits.Add(result);
                    }
        
                    catch (FormatException)
                    {
                        // Console.WriteLine($"Unable to parse '{word}'");
                    }
                
                    
                }

                answer = thedigits[0];
                for( int i = 1; i<thedigits.Count; i++)
                {
                
                    try
                    {
                    answer = whichoperator(answer, operations, thedigits[i]);
                    }
                    catch (InvalidOperationException)
                    {
                        Console.WriteLine("can't divide by zero, unable to complete");
                        break;
                    }

                }

                string[] text = new String[] {};
                List<string> ls = words.ToList();
                ls.Add("= " + answer);
                text = ls.ToArray();


                //Write to a file
                 // hold the file path in memory as a string
                string path = @".\TestFile.txt";
            
                     // Test if the taget file exists yet
                if ( ! File.Exists(path) ) //if no
                    {
                        // Create and and write to the file
                    File.WriteAllLines(path, text);

                    }

                else //if yes
                {
                // Open and append to the file
                File.AppendAllLines(path, text);
                }
            
                //operations[0]  //give you the sign to use
            // thedigits[1]  //gives you the number to use
                Console.WriteLine("equals");
                Console.WriteLine(answer);
                Console.WriteLine("Good calculation");
                Console.WriteLine("Press Enter to continue.");
                Console.ReadLine();
                Console.Clear();
                break;
            }
                

        }

        static void FileCalc()
        {
            while(true)
            {
                Console.WriteLine("This is the Calculator to get input from the file.");
                Console.WriteLine("reading the contents of threetest.txt");
                Console.WriteLine("You can use Plus or + and have multiple numbers.");
                string[] words = File.ReadAllLines(@"./threetest.txt");//2 + 2
             

                var answer =0;
                List<string> operations= new List<string>();
                List<int> thedigits = new List<int>(); 

                foreach (var numbers in words)
                {
                    // each element in the array is numbers  
                    string key = numbers;
                    bool keyExists = textconverTable.ContainsKey(key);
                    if (keyExists){
                    string texttovalue = textconverTable[numbers];
        
                    words = words.Select(s => s.Replace(numbers, texttovalue)).ToArray();
                    
                    }
                    else 
                    {
                        continue;
                    }
                }

              



                foreach (var word in words)
                {
                
                    if ((word == "+") || (word == "-") || (word == "/") || (word == "*"))
                    {
                        Console.WriteLine(word);
                        operations.Add(word);
                    } 
                    try
                    {
                        int result = Int32.Parse(word);
                        Console.WriteLine(result);
                        thedigits.Add(result);
                    }
        
                    catch (FormatException)
                    {
                        // Console.WriteLine($"Unable to parse '{word}'");
                    }
                
                    
                }

                answer = thedigits[0];
                for( int i = 1; i<thedigits.Count; i++)
                {
                
                    try
                    {
                    answer = whichoperator(answer, operations, thedigits[i]);
                    }
                    catch (InvalidOperationException)
                    {
                        Console.WriteLine("can't divide by zero, unable to complete");
                        break;
                    }

                }

                string[] text = new String[] {};
                List<string> ls = words.ToList();
                ls.Add("= " + answer);
                text = ls.ToArray();


                //Write to a file
                 // hold the file path in memory as a string
                string path = @".\TestFile.txt";
            
                     // Test if the taget file exists yet
                if ( ! File.Exists(path) ) //if no
                    {
                        // Create and and write to the file
                    File.WriteAllLines(path, text);

                    }

                else //if yes
                {
                // Open and append to the file
                File.AppendAllLines(path, text);
                }
            
                //operations[0]  //give you the sign to use
            // thedigits[1]  //gives you the number to use
                Console.WriteLine("equals");
                Console.WriteLine(answer);
                Console.WriteLine("Good calculation");
                Console.WriteLine("Press Enter to continue.");
                Console.ReadLine();
                Console.Clear();
                break;
            }
                

        }
        static void Main(string[] args)
        {
            while ( true )
			{
			Console.WriteLine("Enter the number for the menu option of your choice: ");
			Console.WriteLine("[1] - Use Calculator");
			Console.WriteLine("[2] - Use Calculator to read and write to file");
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
                    StringCalc();    
                    break;

                    case 2:
                    FileCalc();    
                    break;

                }
            }
        }

            


    } 
} 