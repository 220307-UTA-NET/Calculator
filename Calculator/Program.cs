using System;


namespace practice
{
    class InputInt
    {
   
    
         static void Main(string[] args)
        
        {
            Console.WriteLine("Enter your number");
            Console.WriteLine("----------");
            int N = Int32.Parse(Console.ReadLine());
           
            Console.WriteLine("Enter your second number");
           int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("----------");
             int l = N + n;
             int h = N - n;

             Console.WriteLine(" Please choose your operations number");
             Console.WriteLine("   1 -> Addision\n   2 -> Substraction\n   3 -> multpilication \n   4 -> Division");
            int input = Int32.Parse(Console.ReadLine());

             if (input == 1)
            {
                 Console.WriteLine(N +" + " + n + " = " + l);
            }
                 else if (input == 2)
            {
                  Console.WriteLine(N + " - " + n + " = " + h);
                    
            }
              else if (input == 3)
            {
                 
                    Console.WriteLine( N + " / " + n + " = " + N * n);
            }
                
              else if  (input == 4)
            {
                    Console.WriteLine( N + " / " + n + " = " + N / n);
                    
            }
              else
            {
                 Console.WriteLine("Invallid input");
            }
             
    
        }
        
    }
}



