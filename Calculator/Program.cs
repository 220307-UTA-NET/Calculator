﻿//Calculator Project 

namespace CalculatorProject
{
    class Program
    {
        static void Main(string[] args) 
        {
            while (true)
            {
                float fltOutput1 = input1();
                string strOutput2 = input2();                
                float fltOutput3 = input3();

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
        static float input1()  
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine ("~~~~~~~~  Calculator  ~~~~~~~~ \nPlease Enter Your First Number: ");
          
                string firstNumber = Console.ReadLine();  
                float floatNum1;
                bool success = float.TryParse(firstNumber, out floatNum1);

                    if (success == true )
                    {
                        float x = float.Parse(firstNumber);
                        Console.Clear();
                        return x;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine ("Invalid input. \nPlease press enter to try again.");
                        Console.ReadLine();
                        Console.Clear();
                    }
                Console.Clear();
            }            
        }
        static string input2()
        {
            while (true)
            {
                string [] validOperations = {"+", "-", "/", "*"};
                Console.WriteLine ("~~~~~~~~  Calculator  ~~~~~~~~  ");
                Console.WriteLine (" \nPlease select from the options below the operation you'd like to perform. \nOpperation:       Select: \nAddition:           +\nSubtaction:         -\nDivision:           /\nMultiplication:     * \n  \nOperation: " );
                string operationInput = Console.ReadLine();
                Console.Clear();

                if (validOperations.Contains ( operationInput ))
                {
                    string returnTwo = operationInput;
                    return returnTwo;
                    Console.Clear(); 
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(" '" + operationInput + "' is an invalid operation. \nPlease press enter to review the menu and try again.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
        static float input3()
        {
            while (true)
            {
                Console.WriteLine ("~~~~~~~~  Calculator  ~~~~~~~~ \nPlease Enter Your Second Number: ");
                string secondNumber = Console.ReadLine();  
                float floatNum2;
                bool secondSuccess = float.TryParse(secondNumber, out floatNum2); //Need to check if true
                    if (secondSuccess == true )
                    {
                        floatNum2 = float.Parse(secondNumber);
                        return floatNum2;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine ("Invalid input. \nPlease press enter to try again.");
                        Console.ReadLine();
                        Console.Clear();
                    }
            }                    
        }
        static void CalculationFunc(float Num_1, string mthOperation, float Num_2)
        {
            while (true)
            {
                if (mthOperation == "+")
                {
                    float answer =  Num_1 + Num_2;
                    Console.Clear();
                    Console.WriteLine ("~~~~~~~~  Calculator  ~~~~~~~~  ");
                    Console.WriteLine( Num_1 + " + " + Num_2 + " = " + answer); 
                }
                else if (mthOperation == "-")
                {
                    float answer = Num_1 - Num_2;
                    Console.Clear();
                    Console.WriteLine ("~~~~~~~~  Calculator  ~~~~~~~~  ");
                    Console.WriteLine( Num_1 + " - " + Num_2 + " = " + answer); 
                }
                else if (mthOperation == "/")
                {
                    float answer = Num_1 / Num_2;
                    Console.Clear();
                    Console.WriteLine ("~~~~~~~~  Calculator  ~~~~~~~~  ");
                    Console.WriteLine( Num_1 + " / " + Num_2 + " = " + answer); 
                }
                else// if (mthOperation == "*")
                {
                    float answer = Num_1 * Num_2;
                    Console.Clear();
                    Console.WriteLine ("~~~~~~~~  Calculator  ~~~~~~~~  ");
                    Console.WriteLine( Num_1 + " * " + Num_2 + " = " + answer); 
                }
            break;
            }             
        }
    } 
}
 

