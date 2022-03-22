using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions; //Allows Regex
using System.Data; //Data Tables
using System.Linq.Expressions; //Expressions

//This code does not do ^ or check most specific order of operations
namespace Calculations
{
    class Calculator
    {
        private string expression;
        public Calculator(string expression)
        {
            this.expression = expression;
        }

        public bool invalidChecks(string input)
        {
            string inputTrimmed = input.Trim();
            inputTrimmed = inputTrimmed.Replace(" ", String.Empty);
            bool emptyS = string.IsNullOrEmpty(inputTrimmed);
            if(emptyS == false) //Loop 1: If expression is not empty or null
            {
                int value;
                string firstCharacter = inputTrimmed.Substring(0,1);
                bool integerCheck = int.TryParse(firstCharacter, out value);
                if(firstCharacter == "(" || integerCheck == true || firstCharacter == "-") //Loop 2: If the first character is '(' or an integer
                {
                    bool test = Regex.IsMatch(inputTrimmed, "[^0-99+-/%^*()]");
                    if(test == false) //Loop 3: If elements in Regex are matched
                    {
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid expression elements. Please try again....");
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid expression. Please try again....");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("No mathematical expression was entered. Please provide one and try again...."); 
                return false;
            }
        }

        public void operation(string checkedInput, string path)
        {
            checkedInput = checkedInput.Replace(" ", String.Empty);
            DataTable dt = new DataTable();
            var computed = dt.Compute(checkedInput, String.Empty); //Can't do exponents with this
            Console.WriteLine("The answer is: " + computed);      
            StreamWriter file_append = File.AppendText(path);
            file_append.WriteLine("The expression was: " + checkedInput + "\n\t The answer was: " + computed);
            file_append.Close();
        }

        public bool switcher()
        {
            Console.WriteLine("\nWould you like to continue using the calculator? [yes or no]");
            var response = Console.ReadLine();
            if(response == "yes" || response == "YES")
            {
                return false;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\nCalculator was closed...like a boss\nI'll take my paycheck now <3\n");
                return true;
            }
        }
    }
}