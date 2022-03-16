using System;
using System.Collections;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please input: ");
            string strToCalculate = Console.ReadLine();
            double result = Calculate(strToCalculate);
            Console.WriteLine(result);
        }

        static double Calculate(string s)
        {
            var calculateStack = new Stack<string>();
            int pos = 0;
            int endPos = s.Length - 1;
            while ( pos <= endPos ) {
                if ( s[pos] == ' ' ) {
                    pos++;
                    continue;
                }
            
                (int steps, string sub) = ParseNextItem(s.Substring(pos));
                Console.WriteLine($"the item i got is '{sub}'.");
                calculateStack.Push(sub);
                pos += steps;
            }
            return calculateStack.Count;
        }    

        static double Add(double operand1, double operand2)
        {
            return operand1 + operand2;
        }

        static double Multiple(double operand1, double operand2)
        {
            return operand1 * operand2;
        }
        static double Divide(double operand1, double operand2)
        {
            return operand1 / operand2;
        }
        static double Subtract(double operand1, double operand2)
        {
            return operand1 - operand2;
        }
        static (int steps, string item) ParseNextItem(string s)
        {
            int pos = 0;
            int endPos = s.Length - 1;
            int parenthesesCtr = 0;
            while ( pos <= endPos )
            {
                if ( s[pos] == '(' )
                {
                    parenthesesCtr++;
                    pos++;
                    continue;
                }
                else if ( s[pos] == ')' )
                {
                    parenthesesCtr--;
                    pos++;
                    if ( parenthesesCtr < 0 )
                    {
                        throw new FormatException($"Parentheses must be in pair. ErrorFormat in {s} at {pos}.");
                    } 
                    if ( parenthesesCtr == 0 ) break;
                }
                else 
                {
                    if ( parenthesesCtr > 0 )
                    {
                        pos++;
                        continue;
                    }
                    else
                    {
                        if ( s[pos] != ' ' )
                        {
                            pos++;
                            continue;
                        }
                        else
                        {
                            pos++;
                            break;
                        }
                    }
                }
            }
            return (pos, s.Substring(0, pos).Trim());
        }
    }
}
