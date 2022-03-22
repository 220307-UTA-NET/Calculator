using System;
using System.Collections;
using System.Collections.Generic;


using System;
//using System.Collections;
using System.Collections.Generic;


namespace CalculatorApp
{
    class Calculator
   {
       
        //creating a Stack named 'result' to push the results of
        //the perfomed operations in the stack
        public Stack<double> result = new Stack<double>();
        double ans;
      
        //adding to numbers
        public void add(double a, double b)
        {
            ans = a + b;
            Console.WriteLine("Sum:{0}", ans);
            result.Push(ans);
        }
        //subtracting two numbers
        public void subtract(double a, double b)
        {
            ans = a - b;
            Console.WriteLine("Difference:{0}", ans);
            result.Push(ans);
        }

        //multiplying two numbers
        public void multiply(double a, double b)
        {
            ans = a * b;
            Console.WriteLine("Product:{0} ", ans);
            result.Push(ans);
        }

        //dividing two numbers
        public void divide(double a, double b)
        {
            if (b != 0)
            {
                ans = a / b;
                Console.WriteLine("Quotient:{0}", ans);
                result.Push(ans);
            }
            else
            {
                Console.WriteLine("Error: Cannot divide by 0");
            }
        }
        
        //printing the previous results, if there is any
        void undo()
        {
            result.Pop();
            ans = result.Pop();
            Console.WriteLine("Running answer:{0}", ans);
        }
         
         //deleting all the current and previous results and making the answer to all 
         //operations zero
        void clear()
        {
            while (result.Count != 0)
                  result.Pop();
            
            ans = 0;
            Console.WriteLine("Running answer:{0}", ans);
        }

        public static void Main(string[] args)
        {
            
            Calculator cal = new Calculator();
            string userSelection= "";
            
            Console.WriteLine("\n");
            Console.WriteLine("Hi! This is a simple Calculator Application \n");
            Console.WriteLine("This calculator can perform addition, subtraction, multiplication and division. \n\n");
            Console.WriteLine("Instructions: \n");
            Console.WriteLine("enter 'any' key to start calculation\n");
            Console.WriteLine("if you want to see previous results, enter 'Undo'\n ");
            Console.WriteLine("if you want to clear previous results, enter 'Clear'\n");
            Console.WriteLine("if you want to quit, enter 'Exit'\n\n");
        
            while (true)
            {
                Console.WriteLine(" \n Enter (Clear or Undo or Exit or any Expression to start ):");
                
                userSelection = Console.ReadLine();
                if (userSelection.ToLower() == "exit")
                    break;
                else if (userSelection.ToLower() == "undo")
                   try{
                       cal.undo();
                   }
                   catch (Exception e)
                   {
                       Console.WriteLine(e.Message );
                       
                   }

                else if (userSelection.ToLower() == "clear")
                    cal.clear();
                else
                {
                    double a, b;
                    char c;

                    Console.WriteLine("Write the first number");
                    double.TryParse(Console.ReadLine(), out a);

                    Console.WriteLine("Write the second number");
                    double.TryParse(Console.ReadLine(), out b);

                    Console.WriteLine("Write the operand (+,-,/,*)");
                    char.TryParse(Console.ReadLine(), out c);


                    if (c == '+')
                        cal.add(a, b);
                    if (c == '-')
                        cal.subtract(a, b);
                    if (c == '*')
                        cal.multiply(a, b);
                    if (c == '/')
                        cal.divide(a, b);
                    
                }
            }    
        
       }       

        
    }
}