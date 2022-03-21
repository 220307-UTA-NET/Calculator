using System;
using System.IO;
using System.Collections.Generic;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string folder = @"C:\Users\Bung9\Desktop\Revature_N\Calculator\Calculator\ComputedValues.txt";
            bool run = true;
            Console.WriteLine("\n***** Welcome to the Calculator! *****\n");
            while (run == true)
            {
                Console.Write("\nPlease enter your expression to calculate: ");
                string userInput = Console.ReadLine();
                Calculator calc = new Calculator(userInput);
                bool checkCondition = calc.invalidChecks(userInput);
                if (checkCondition == true) //Fail condition handled in previous call
                {
                    calc.operation(userInput, folder);
                }
                bool switchCondition = calc.switcher();
                if(switchCondition == true)
                {
                    run = false;
                }
            }
        }
    }
}