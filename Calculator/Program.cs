using System;


namespace Project_1_Calculator
{
    class calculator
    {
         static void Main(string[] args)

          {
          while(true)
          {

             try{
                    

               Console.WriteLine("Enter your number");
               Console.WriteLine("----------");
               double N = Int32.Parse(Console.ReadLine());
           
               Console.WriteLine("Enter your second number");
               double n = Int32.Parse(Console.ReadLine());
               Console.WriteLine("----------");
              
               double l = N + n;
               double h = N - n;

               Console.WriteLine("Please choose your operation number");

               Console.WriteLine("   0 -> exit\n   1 -> Addition\n   2 -> Subtraction\n   3 -> multiplication \n   4 -> Division");
           
               Console.WriteLine("----------");
               Console.WriteLine("You chose operation");

               int input = Int32.Parse(Console.ReadLine());
               Thread.Sleep(2000);
              
              Console.Clear();

            
            if (input == 0)
            {
                 break;
            }
              else if (input == 1)
            {
                 Console.WriteLine(N +" + " + n + " = " + l);
            }
                else if (input == 2)
            {
                  Console.WriteLine(N + " - " + n + " = " + h);
                    
            }
               else if (input == 3)
            {
                 
                    Console.WriteLine( N + " X " + n + " = " + N * n);
            }
                
              else if  (input == 4)
          
            {
                     
                    Console.WriteLine( N + " / " + n + " = " + (double)N / (double) n);
                    Console.WriteLine("Divided by zero is invalid");
                    
            }
             

            else if (input > 4)

           
            {
                 Console.WriteLine("Invalid opreation input ");
                
           }

            }
             catch(Exception e)
             {
               
                    Console.WriteLine(e.Message);
             }
           }
          }
     }
}




