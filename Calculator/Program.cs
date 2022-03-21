using System;
using System.Collections;
using System.Collections.Generic;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            // TEST FUNCTIONS
            // Console.WriteLine(Addition(12, 12));
            // Console.WriteLine(Subtraction(12, 1));
            // Console.WriteLine(Multiplication(3, 3));
            // Console.WriteLine(Division(9 , 3));

            Console.WriteLine("Enter your expression: ");

            string[] input = Console.ReadLine().Split(' ');

            // Check for empty input
            if(input == null || input.Length == 0)
            {
                Console.WriteLine("No input.");
                return;
            }
            else
            {
                Stack operatorStack = new Stack();
                Stack operandStack = new Stack();
                int operand1;
                int operand2;
                string operator1;

                for(int i = 0; i < input.Length; i++)
                {
                    if(int.TryParse(input[i], out operand1))
                    {
                        operandStack.Push(input[i]);
                    }
                    else
                    {
                        operatorStack.Push(input[i]);
                    }
                }
                // TEST STACKS
                // Console.WriteLine("operandStack.Count = " + operandStack.Count);
                // Console.WriteLine("operatorStack.Count = " + operatorStack.Count);

                // operand1 = int.Parse(operandStack.Pop().ToString());
                // Console.WriteLine("operand1 = " + operand1);

                // operand2 = int.Parse(operandStack.Pop().ToString());
                // Console.WriteLine("operand2 = " + operand2);

                // operator1 = operatorStack.Pop().ToString();
                // Console.WriteLine("operator1 = " + operator1);

                // Do calculations
                 while(operandStack.Count >= 2)
                {
                    operand1 = int.Parse(operandStack.Pop().ToString());
                    operand2 = int.Parse(operandStack.Pop().ToString());
                    operator1 = operatorStack.Pop().ToString();

                    // NO ORDER OF OPERATION
                    if(operator1 == "+")
                    {
                        operandStack.Push(Addition(operand2, operand1));
                    }
                    else if(operator1 == "-")
                    {
                        operandStack.Push(Subtraction(operand2, operand1));
                    }
                    else if(operator1 == "*")
                    {
                        operandStack.Push(Multiplication(operand2, operand1));
                    }
                    else if(operator1 == "/")
                    {
                        operandStack.Push(Division(operand2, operand1));
                    }
                }   // End while(operandStack >= 2)

                // Print result
                Console.WriteLine(operandStack.Pop());

            }   // End else
                
        }   // End Main

        // Functions
        static int Addition(int a, int b)
        {
            return (a + b);
        }

        static int Subtraction(int a, int b)
        {
            return (a - b);
        }

        static int Multiplication(int a, int b)
        {
            return (a * b);
        }

        static int Division(int a, int b)
        {
            return (a / b);
        }
    }
}