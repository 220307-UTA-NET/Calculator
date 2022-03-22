// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more in
//Be written in C# for .NET 6
//Be able to accept multiple numbers
//Perform a selected operation on those numbers
//Display the result of the operation
//Repeat until the user chooses to exit
using System;
namespace  Calculator
{
public class Program {

static void myCalc()
    {
     double number;
     double result = 0;
     string input = "0";
     string operation = "";
     while(!input.Equals ("=") )
      {
       input = Console.ReadLine();
       if(double.TryParse(input,out number))  //main if
       {
               if(operation =="")
               { 
                    result = number;
                    
               }
               else if(operation =="+")
               {
                     result += number;
                  
               }
               else if(operation =="-")
               {
                    result -= number;
                
               }
               else if(operation =="*")
               {
                     result *= number;
                    
               }
               else if(operation =="/")
               {
                     result /= number;
                 
               }
               
       }
      else if (input.Equals("+") || input.Equals("-") || input.Equals("*") || input.Equals("/"))  //main if
               {
               operation = input ;
               } 
     }
         Console.WriteLine("Total = " +result);
     }               

  public static void Main(string[] args)
    {
     Console.WriteLine("Calculator Project \n\nTo Add(+),Subtract(-),Multiply(*),Divide(/)");
     Console.WriteLine("\nEnter the number followed by operator, =(equal) sign will print the result");
     ConsoleKeyInfo keyInfo;
     myCalc();
     while(true)
     {
         Console.WriteLine("Do you want to continue:(Y/N)");
         keyInfo = Console.ReadKey();
        if(keyInfo.Key == ConsoleKey.Y)
        {
               Console.WriteLine("\nEnter the number followed by operator, =(equal) sign will print the result");
               myCalc();
        }
        else if(keyInfo.Key == ConsoleKey.N)
        {
            return;
        }
        else
        Console.WriteLine("\nError - Give Y or N to continue");
     }
    }
}

}

