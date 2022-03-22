// See https://aka.ms/new-console-template for more information
using System;
using System.Collections; 
using System.Linq;

namespace Calculator {

   class Program {

        //Global variable declarations: by defining a public static property inside
        //a public class
        public static string Opr;
        public static List<double> Numbers = new List<double>(); 
        public static double Result;
        public static string Opt;
        public static string[] Options = {"YES", "Y", "NO", "N"};
        public static string[] Operations = {"addition", "substraction", "multiplication", "division"};

        
        public static void Main(string[] args) {

            string input = "";
            bool isIn = false;

            do {       
                  //Result = 0.0;   
                  dowhileLoop();
                  switch(Opr) {
                    case "addition":
                      double tempAdd = 0.0;
                      foreach(double i in Numbers) {
                        tempAdd += i;
                      }
                      Result = tempAdd;
                      displayResult();
                      //Result = 0;
                      Console.WriteLine("Enter 0 to exit. Or enter any key for another operation");
                      input = Console.ReadLine();
                      if(!(input.Equals("0", StringComparison.OrdinalIgnoreCase))) {
                         isIn = true;
                         Numbers.Clear();
                      }
                      break;

                    case "substraction":
                      double tempSub = Numbers[0];
                      for(int i = 1; i < Numbers.Count; i++) {
                        tempSub -= Numbers[i];
                      }
                      Result = tempSub;
                      displayResult();
                      Console.WriteLine("Enter 0 to exit. Or enter any key for another operation");
                      input = Console.ReadLine();
                      if(!(input.Equals("0", StringComparison.OrdinalIgnoreCase))) {
                         isIn = true;
                         Numbers.Clear();
                      }
                      break;

                    case "multiplication":
                      double tempMul = Numbers[0];
                      for(int i = 1; i < Numbers.Count; i++) {
                        tempMul *= Numbers[i];
                      }
                      Result = tempMul;
                      displayResult();
                      Console.WriteLine("Enter 0 to exit. Or enter any key for another operation");
                      input = Console.ReadLine();
                      if(!(input.Equals("0", StringComparison.OrdinalIgnoreCase))) {
                         isIn = true;
                         Numbers.Clear();
                      }
                      break;

                    default: 
                      int size = Numbers.Count - 1;
                      double[] tempArray = new double[size];
                      //copy elements to another array
                      Numbers.CopyTo(1, tempArray, 0, size);
                      //returns true if 0 is dominator
                      isIn = Array.Exists(tempArray, x => x == 0); 
                      
                      if(isIn) {
                          Console.WriteLine("Wrong format, cannot divide by 0");
                          Console.WriteLine("Enter 0 to exit. Or enter any key for another operation");
                          input = Console.ReadLine();          
                      }
                      else {
                          double tempDiv = Numbers[0];
                          for(int i = 1; i < Numbers.Count; i++) {
                            tempDiv /= Numbers[i];
                          }
                          Result = tempDiv;
                          displayResult();
                          
                          Console.WriteLine("Enter 0 to exit. Or enter any key for another operation");
                          input = Console.ReadLine();
                          if(!(input.Equals("0", StringComparison.OrdinalIgnoreCase))) {
                             isIn = true;
                             Numbers.Clear();
                          }
                      }
                      break;  
                    }
            } while(!(input.Equals("0", StringComparison.OrdinalIgnoreCase)) && isIn == true);         
        }      

     


        public static void displayResult() {
          string sign;
            if(Opr.Equals("addition", StringComparison.OrdinalIgnoreCase))
              sign = "+";
            else if (Opr.Equals("substraction", StringComparison.OrdinalIgnoreCase))
              sign = "-";
            else if (Opr.Equals("multiplication", StringComparison.OrdinalIgnoreCase))
              sign = "*";
            else
              sign = "/";
            string numToString = "";
            for(int i = 0; i < Numbers.Count; i++ ) {
              if (i != (Numbers.Count - 1)) {
                numToString += Numbers[i].ToString() + " " + sign + " ";
              }
              else {
                 numToString += Numbers[i].ToString() + " = " + Result.ToString();
              } 
            }
            Console.WriteLine(numToString);
        }

        public static void dowhileLoop() {
            
            Console.WriteLine("Choose an operation - addition, substraction, multiplication, division");
            Opr = Console.ReadLine();
            //input validation
            //bool isIn = !(tempArray.Contains(operation));
            while(!(Operations.Contains(Opr))) {
              //choose an action to perform
				      Console.Write("Wrong input! Please carefully enter a valid operation name: " );
              Opr = Console.ReadLine();
            } 

            Console.WriteLine("We need at least two number");
            Console.WriteLine("Enter a number: ");
            Numbers.Add(int.Parse(Console.ReadLine()));

            do {
                Console.WriteLine("Enter a number: ");
                Numbers.Add(int.Parse(Console.ReadLine()));

                Console.WriteLine("Would you like to add number? yes or no");
                Opt = Console.ReadLine();
                //input validation
                while(!Array.Exists(Options, x => x == Opt.ToUpper())) {
                  //choose an action to perform
				          Console.WriteLine("Wrong input character! Please carefully enter Yes/No, or just Y/N : " );
                  Opt = Console.ReadLine();
                }      
            } while(Opt.Equals("YES", StringComparison.OrdinalIgnoreCase) || Opt.Equals("Y", StringComparison.OrdinalIgnoreCase));
        }
  }
}

