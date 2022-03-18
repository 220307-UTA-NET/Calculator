using System;
using System.Collections;
using System.Collections.Generic;

namespace CalculatorLibrary
{
    public class Calculator
    {
        public static double Calculate(string s)
        {
            var operandQueue = new Queue<double>();
            var operatorQueue = new Queue<char>();

            // deal with the head space, tail space and tail '='
            s = s.Trim();
            if ( s[s.Length - 1] == '=' )
            {
                s = s.Substring(0, s.Length - 1);
                s = s.Trim();
            }

            // parse the string s to put operands and operators into queues
            int pos = 0;
            int endPos = s.Length - 1;

            while ( pos <= endPos )
            {
                if ( s[pos] == ' ' || s[pos] == '\t' ) 
                {
                    pos++;
                    continue;
                }
                if ( operandQueue.Count == operatorQueue.Count)
                {
                    (int n, double operand) = NextOperand(s.Substring(pos));
                    pos += n;
                    operandQueue.Enqueue(operand);
                } else if ( operandQueue.Count == operatorQueue.Count + 1 )
                {
                    (int n, char oper) = NextOperator(s.Substring(pos));
                    pos += n;
                    operatorQueue.Enqueue(oper);
                } else
                {
                    throw new FormatException("FormatError: the number of operators does NOT match the number of operands.");
                }
            }

            

            // do the calculation in three phases ^ **, * / and + -
            // phase 1, do expo 
            int i = 1;
            int counter = operatorQueue.Count;
            while ( i <= counter )
            {
                char oper = operatorQueue.Dequeue();
                if ( oper != '^' )
                {
                    operandQueue.Enqueue(operandQueue.Dequeue()); // get the first operand and put it in last
                    operatorQueue.Enqueue(oper);
                    if (i == counter) operandQueue.Enqueue(operandQueue.Dequeue()); // get the first operand and put it in last
                } else 
                {
                    double p1 = operandQueue.Dequeue();
                    double p2 = operandQueue.Dequeue();
                    operandQueue.Enqueue(compute(oper, p1, p2));
                }
                i++;
            }
            
            // phase 2, do * and / 
            i = 1;
            counter = operatorQueue.Count;
            while ( i <= counter )
            {
                char oper = operatorQueue.Dequeue();
                if ( oper != '*' || oper != '/' )
                {
                    operandQueue.Enqueue(operandQueue.Dequeue()); // get the first operand and put it in last
                    operatorQueue.Enqueue(oper);
                    if (i == counter) operandQueue.Enqueue(operandQueue.Dequeue()); // get the first operand and put it in last
                } else 
                {
                    double p1 = operandQueue.Dequeue();
                    double p2 = operandQueue.Dequeue();
                    operandQueue.Enqueue(compute(oper, p1, p2));
                }
                i++;
            }
            
            // phase 3, do + and - 
            
            while ( operatorQueue.Count > 0 )
            {
                    char oper = operatorQueue.Dequeue();
                    double p1 = operandQueue.Dequeue();
                    double p2 = operandQueue.Dequeue();
                    operandQueue.Enqueue(compute(oper, p1, p2));
            }

            return operandQueue.Dequeue();
        }

        private static double compute(char oper, double p1, double p2)
        {
            double tempResult = p1;
            switch ( oper )
            {
                case '+':
                    tempResult += p2;
                    break;
                case '-':
                    tempResult -= p2;
                    break;
                case '*':
                    tempResult *= p2;
                    break;
                case '/':
                    tempResult /= p2;
                    break;
                case '^':
                    tempResult = Math.Pow(p1, p2);
                    break;
            }
            return tempResult;
        }

        public static (int nSteps, double operand) NextOperand(string s)
        {
            int pos = 0;
            int endPos = s.Length - 1;
            int parenthesesCtr = 0;
     
            // dealing with '(' while needing an operand.
            if ( s[pos] == '(' )
            {
                parenthesesCtr++;
                pos++;
                while (parenthesesCtr > 0)
                {
                    if ( s[pos] == ')' ) parenthesesCtr--;
                    if ( s[pos] == '(' ) parenthesesCtr++;
                    pos++;
                    if ( pos > endPos )
                        throw new FormatException($"Parentheses must be in pair. ErrorFormat in {s} at {pos}.");
                }
                return (pos, Calculate(s.Substring(1, pos-2)));
            } 

            // dealing with '+' and '-' while needing an operand
            if ( s[pos] == '+' || s[pos] == '-')
            {
                pos++;
                int nPoints = 0;
                while ( pos <= endPos && (char.IsDigit(s[pos]) || s[pos] == '.' ) )
                {
                    if ( s[pos] == '.' ) {
                        nPoints++;
                        if ( nPoints > 1 )
                            throw new FormatException($"ONLY ONE point can have in a number. ErrorFormat in {s} at {pos}.");
                    } 
                    pos++;
                }
                return (pos, double.Parse(s.Substring(0, pos)));
            }
            
            // dealing with '0-9' while needing an operand
            if ( char.IsDigit(s[pos]) )
            {
                pos++;
                int nPoints = 0;
                while ( pos <= endPos && (char.IsDigit(s[pos]) || s[pos] == '.') )
                {
                    if ( s[pos] == '.' ) {
                        nPoints++;
                        if ( nPoints > 1 )
                            throw new FormatException($"ONLY ONE point can have in a number. ErrorFormat in {s} at {pos}.");
                    } 
                    pos++;
                }
                return (pos, double.Parse(s.Substring(0, pos)));
            }

            // dealing with '.' while needing an operand
            if ( s[pos] == '.' ) 
            {
                pos++;
                while ( pos <=endPos && char.IsDigit(s[pos]) )
                {
                    pos++;
                }
                if ( pos == 1 )
                    throw new FormatException($"Found NOTHING but a point while needing a number. ErrorFormat in {s} at {pos}.");
                return (pos, double.Parse(s.Substring(0, pos)));
            }

            // can't get an operand while you come here
            throw new FormatException($"ErrorFormat. Can NOT get an number from \"{s}\" at {pos}.");
        }

        public static (int nSteps, char oper) NextOperator(string s)
        {
            int pos = 0;
            int endPos = s.Length - 1;

            switch ( s[pos] )
            {
                case '+':
                    pos++;
                    return (pos, '+');
                case '-':
                    pos++;
                    return (pos, '-');
                case '/':
                    pos++;
                    return (pos, '/');
                case '^':
                    pos++;
                    return (pos, '^');
                case '*':
                    pos++;
                    if (pos <= endPos && s[pos] == '*') {
                        pos++;
                        return (pos, '^');
                    } 
                    return (pos, '*');
            }

            // can't have an operator when you reach here
            throw new FormatException($"ErrorFormat. Can NOT get an operator from \"{s}\" at {pos}.");
        }
    }
}
