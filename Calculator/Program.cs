using System;
using System.Collections;
using System.Collections.Generic;
using CalculatorLibrary;

namespace CalculatorProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, This is a One-Line Arithmetic Calculator.\n\n");
            Console.WriteLine("The following arithmetic operators are supported:");
            Console.WriteLine("         +   Add");
            Console.WriteLine("         -   Subtract");
            Console.WriteLine("         *   Multiple");
            Console.WriteLine("         /   Divide");
            Console.WriteLine("         **  Exponent");
            Console.WriteLine("\n   Hint: Use parentheses () to explicitly show your priority.");
            Console.WriteLine("\n   Quit: Q/q");
            while (true)
            {
                Console.WriteLine("Please input your arithmetic expression:");
                string strUserInput = Console.ReadLine();
                if (strUserInput == "Q" || strUserInput == "q")
                {
                    Console.WriteLine("BYE.");
                    break;
                }
                try {
                    Console.WriteLine($"The result: {Calculator.Calculate(strUserInput)}");
                } catch ( Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("OOPs, Please try again.");
                    // error logging 
                    continue;
                }

                // logging here
            }
            
        }

    }
}