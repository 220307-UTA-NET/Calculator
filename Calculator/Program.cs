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
            Console.WriteLine("please input: ");
            string strToCalculate = Console.ReadLine();
            double result = Calculator.Calculate(strToCalculate);
            Console.WriteLine(result);
        }

    }
}