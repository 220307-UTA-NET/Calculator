//Calculator Project 

namespace CalculatorProject
{
    class Program
    {
        static void Main(string[] args) 
        {
        
            while (true)
            {

                // Console.WriteLine ("~~~~~~~~  Calculator  ~~~~~~~~  ");

                float fltOutput1;
                fltOutput1 = input1();

                string strOutput2;
                strOutput2 = input2();
                
                float fltOutput3;
                fltOutput3 = input3();

                CalculationFunc(fltOutput1, strOutput2,fltOutput3);
            
                Console.WriteLine(" \nThanks for calculating! \nPress Enter to exit or enter 1 to use calculator again.");
                string exit = Console.ReadLine();
                Console.Clear();
                
                if (exit == "")
                {
                    return;
                }

            }

        }

        static float input1()  // change response to bad input
        {
            Console.Clear();
            while (true)
            {
                // Console.Clear();
                Console.WriteLine ("~~~~~~~~  Calculator  ~~~~~~~~ \nPlease Enter Your First Number: ");
                // Console.WriteLine (" \nPlease Enter Your First Number: ");
          
                string firstNumber = Console.ReadLine();  
                float floatNum1;
                bool success = float.TryParse(firstNumber, out floatNum1);
                // Console.Clear();

                    if (success == true )
                    {
                        float x = float.Parse(firstNumber);
                        // Console.Clear();
                        return x;
                        // break;
                    }
                    else
                    {
                        // Console.WriteLine ("Invalid input. Please try again.");                        
                        Console.WriteLine (" \nInvalid input. \nPress enter to try again.");
                        Console.ReadLine();
                        Console.Clear();
                        // Console.WriteLine ("~~~~~~~~  Calculator  ~~~~~~~~  ");
                    }
                Console.Clear();
                // float x = floatNum1;
                // return x;
            }            
        }

        static string input2()
        {
            while (true)
            {
                string [] validOperations = {"+", "-", "/", "*"};
                Console.WriteLine (" \nPlease select from the options below the operation you'd like to perform. \nOpperation:       Select: \nAddition:           +\nSubtaction:         -\nDivision:           /\nMultiplication:     * \n  \nOperation: " );
                string operationInput = Console.ReadLine();

                if (validOperations.Contains ( operationInput ))
                {
                    string returnTwo = operationInput;
                    return returnTwo;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid operation selected. Please press enter to review the menu and try again.");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine ("~~~~~~~~  Calculator  ~~~~~~~~  ");
                }

            }
        }

        static float input3() //use code from this funtion for error message
        {
            while (true)
            {
                Console.WriteLine (" \nPlease Enter Your Second Number: ");
                string secondNumber = Console.ReadLine();  
                float floatNum2;
                bool secondSuccess = float.TryParse(secondNumber, out floatNum2); //Need to check if true
                    if (secondSuccess == true )
                    {
                        floatNum2 = float.Parse(secondNumber);
                        return floatNum2;
                        // break;
                    }
                    else
                    {
                        Console.WriteLine ("Invalid input. Please try again. ");
                    }
            }                    
        }
        static void CalculationFunc(float fltOutput1, string strOutput2, float fltOutput3)
        {
            while (true)
            {
                if (strOutput2 == "+")
                {
                    float answer =  fltOutput1 + fltOutput3;
                    Console.Clear();
                    Console.WriteLine ("~~~~~~~~  Calculator  ~~~~~~~~  ");
                    Console.WriteLine( fltOutput1 + " + " + fltOutput3 + " = " + answer); 
                }

                else if (strOutput2 == "-")
                {
                    float answer = fltOutput1 - fltOutput3;
                    Console.Clear();
                    Console.WriteLine ("~~~~~~~~  Calculator  ~~~~~~~~  ");
                    Console.WriteLine( fltOutput1 + " - " + fltOutput3 + " = " + answer); 
                }

                else if (strOutput2 == "/")
                {
                    float answer = fltOutput1 / fltOutput3;
                    Console.Clear();
                    Console.WriteLine ("~~~~~~~~  Calculator  ~~~~~~~~  ");
                    Console.WriteLine( fltOutput1 + " / " + fltOutput3 + " = " + answer); 
                }

                else if (strOutput2 == "*")
                {
                    float answer = fltOutput1 * fltOutput3;
                    Console.Clear();
                    Console.WriteLine ("~~~~~~~~  Calculator  ~~~~~~~~  ");
                    Console.WriteLine( fltOutput1 + " * " + fltOutput3 + " = " + answer); 
                }

                else
                {
                    Console.WriteLine( "SOMETHING WENT WRONG!!!!!!!!!"); //Don't need
                    break;
                }
            break;
            }             
        }
    } 
}
 







// Create code to use null input to mean "If you'd like to use the calculator, please run program again."
// Takes in operation and decides if valid or tells user to try again 
//Console.WriteLine(firstNumber); 
//Console.Clear();
//Console.WriteLine();
//Console.ReadLine(); 
//Console.WriteLine ("\nPlease Enter the operation you'd like to perform.");
// if - else statement for invalid operation









