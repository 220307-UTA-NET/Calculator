using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Program
    {
        private static readonly string[] operations = { "+", "-", "*", "/", "^", "%" };
    static void Main(string[] args)
    {
        double result = 0;
        double firstNumber = SetNumber("Type you first number : ");
        double secondNumber = SetNumber("Type you second number: ");

        string stringOperation =
            SetOperation(
                "Enter the operation + (addition), - (soustraction), * (multiplication), / (division), ^ (exposant) or % (reste) :");

        switch (stringOperation)
        {
            case "+":
            case "addition":
                result = firstNumber + secondNumber;
                break;
            case "-":
            case "soustraction":
                result = firstNumber - secondNumber;
                break;
            case "*":
            case "multiplication":
                result = firstNumber*secondNumber;
                break;
            case "/":
            case "division":
                result = firstNumber/secondNumber;
                break;
            case "^":
            case "exposant":
                result = Math.Pow(firstNumber, secondNumber);
                break;
            case "%":
            case "reste":
                result = firstNumber%secondNumber;
                break;
        }
        Console.WriteLine("Result of {0} {1} {2} = {3}", firstNumber, stringOperation, secondNumber, result);
        Console.ReadKey();
    }

    private static double SetNumber(string outputText)
    {
        double parse;
        Console.Write(outputText);
        string tempInput = Console.ReadLine();
        while (!double.TryParse(tempInput, out parse))
        {
            Console.WriteLine("Incorrect input !");
            Console.Write(outputText);
            tempInput = Console.ReadLine();
        }
        return double.Parse(tempInput);
    }

    private static bool IsValidOperation(string input)
    {
        return operations.Contains(input);
    }

    private static string SetOperation(string outputText)
    {
        Console.Write(outputText);
        string tempInput = Console.ReadLine();
        while (!IsValidOperation(tempInput))
        {
            Console.WriteLine("Incorrect input !");
            Console.Write(outputText);
            tempInput = Console.ReadLine();
        }
 
        return tempInput;
    }
}}

