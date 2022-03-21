using System;


namespace Project_1_Calculator
{
    class calculator
    {
   
             static void Main(string[] args)
         
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

          Console.WriteLine("Please choose your operations number");
          Console.WriteLine("   1 -> Addision\n   2 -> Substraction\n   3 -> multpilication \n   4 -> Division");
           
              Console.WriteLine("You chose ");
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
                 
                    Console.WriteLine( N + " X " + n + " = " + N * n);
            }
                
              else if  (input == 4)
            {
                    Console.WriteLine( N + " / " + n + " = " + (double)N / (double) n);
                    
            }
              else
            {
                 Console.WriteLine("Invalid input ");
            }
             }
             catch(Exception e)
             {
               
                    Console.WriteLine(e.Message);
               }

             }
             //Console.WriteLine("Enter to continue");

            // Console.ReadLine();
           //  Console.Clear();
    
    
        }
        
    }




