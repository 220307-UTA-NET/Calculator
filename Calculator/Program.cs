using System;

namespace Calculator
{
    class Calculator 
    {

        static void Main(string[] args)
        {   
            //Console.WriteLine("Welcom to MyCalculator! \n Please select an operation: ");
                // while(true)
                // {
                    // int n = int.Parse(Console.ReadLine());
                    double [] InptNumber = new double[3];
                    int sum = 0;
                    for (int i = 0; i < InptNumber.Length; i++)
                    {
                        InptNumber[i] = int.Parse(Console.ReadLine());
                        sum += (int)InptNumber[i];
                    }
                    Console.WriteLine("The total sum is: " + sum);
                    Console.WriteLine("\n");

                      // The Subtraction Section
                    System.Console.WriteLine("---------Subtraction---------");
                    // int n = int.Parse(Console.ReadLine());
                    // float Subtraction = 0;
                    // for (int i = 0; i < InptNumber.Length; i++)
                    // {
                    //     InptNumber[i] = double.Parse(Console.ReadLine());
                    //     Subtraction = Subtraction - (float)InptNumber[i];
                    // }
                   
                    // Console.WriteLine("The The subtraction of: " + string.Join(", ", InptNumber) + " is: " + Subtraction);
                    // Console.WriteLine("----------------------------------");
                    // Console.WriteLine("\n");

                        
                    int AskSubtraction = 0;
                    Console.Write("\n" + "input number ( example : 1 - 2 - 3 - 4 ) : ");
                    var InputNumber = Console.ReadLine();
                    double Answer = 0;
                    double numResult;

                    foreach (var result in InputNumber.Split('-'))
                    {
                        if (double.TryParse(result, out numResult))
                        {
                            if(Math.Abs(Answer)>0){
                                Answer -= numResult;
                            }
                            else{
                                Answer=numResult;
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n" + "Wrong input !");
                            AskSubtraction++;
                        }
                    }

                    Console.WriteLine("\n" + "subtraction result : " + Answer);
                     
                     Console.WriteLine("\n");


                    System.Console.WriteLine("---------Division---------");
                    // int n = int.Parse(Console.ReadLine());
                    float Division = 1;
                    for (int i = 0; i < InptNumber.Length; i++)
                    {
                        InptNumber[i] = double.Parse(Console.ReadLine());
                        Division /= (float)InptNumber[i];
                    }
                   
                    Console.WriteLine("The division of: " + string.Join("/", InptNumber) + " is: " + Division);
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("\n");

                    System.Console.WriteLine("---------Multiplication---------");
                    // int n = int.Parse(Console.ReadLine());
                    float Multiplication = 1;
                    for (int i = 0; i < InptNumber.Length; i++)
                    {
                        InptNumber[i] = double.Parse(Console.ReadLine());
                        Multiplication *= (float)InptNumber[i];
                    }
                    Console.WriteLine("The Multiplication of: " + string.Join("x", InptNumber) + " is: " + Multiplication);
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("\n");

        }

        }
    }