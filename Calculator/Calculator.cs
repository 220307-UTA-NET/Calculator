using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions; //Allows Regex
using System.Data; //Data Tables
using System.Linq.Expressions; //Expressions

//Currently not doing ^ or negative values
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
            string inputTrimmed = input.Trim(); //Remove outside spaces
            inputTrimmed = inputTrimmed.Replace(" ", String.Empty).Trim(); //Remove internal spaces
            bool emptyS = string.IsNullOrEmpty(inputTrimmed); //Check if empty
            if(emptyS == false)
            {
                int value;
                string firstCharacter = inputTrimmed.Substring(0,1); //Takes first character in string
                bool integerCheck = int.TryParse(firstCharacter, out value); //Tries to parse first character to integer. Returns boolean
                if(firstCharacter == "(" || integerCheck == true) //Checks to see if first char is '(' or a number. All else fails
                {
                    bool test = Regex.IsMatch(inputTrimmed, "[^0-99+-/%^*()]"); //If includes anything but 0-9 and some specific special characters, it fails out
                    if(test == false)
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
            checkedInput = checkedInput.Replace(" ", String.Empty); //Remove internal spaces
            DataTable dt = new DataTable();
            var computed = dt.Compute(checkedInput, string.Empty); //Can't do exponents with this
            Console.WriteLine("The answer is: " + computed);            
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
                Console.WriteLine("\nClosing...like a boss\nMade with love by Austin <3\n");
                return true;
            }
        }
    }
}