namespace Calculator 
{
            static class calculator
            {

                    static void Main(string[] args)
                    { 
                        while (true)
                                    {
                                    Console.WriteLine("Hello, what operation you need to do?");
                                    string  OPTIONS= 

                                                        @"
                                                            [0] MULTIPLY 
                                                            [1] DIVIDE
                                                            [2] ADD
                                                            [3] SUBSTRACT 
                                                            [4] MULTIPLE OPERATIONS 
                                                        " ;
                                    Console.WriteLine(OPTIONS);
                                    float MENU = float.Parse(Console.ReadLine());
                                    switch (MENU)            
                                                { 
                                                    case 0:
                                                        while (true)
                                                                    {   Console.WriteLine("From 2 to 5, how many number you need to multiply ?");
                                                                        float input = float.Parse(Console.ReadLine());
                                                                        float a,b,c,d,e;
                                                                        switch (input)
                                                                        {
                                                                                case 2:
                                                                                 try
                                                                                {
                                                                            
                                                                                Console.WriteLine("type number 1");
                                                                                a= float.Parse(Console.ReadLine());
                                                                                Console.WriteLine("type number 2");
                                                                                b= float.Parse(Console.ReadLine());
                                                                                }
                                                                                catch (Exception e1 ) 
                                                                                {
                                                                                Console.WriteLine("Bad input, I accept only numbers. Please type a again");
                                                                                continue;
                                                                                
                                                                                }
                                                                                
                                                                                float mutiplication1 = a*b;
                                                                                Console.WriteLine(a + " * " + b + "  =  " + mutiplication1);

                                                                                break;
                                                                                case 3:
                                                                                 try
                                                                                {
                                                                                
                                                                                Console.WriteLine("type number 1");
                                                                                a= float.Parse(Console.ReadLine());
                                                                                Console.WriteLine("type number 2");
                                                                                b= float.Parse(Console.ReadLine());
                                                                                Console.WriteLine("type number 3");
                                                                                c= float.Parse(Console.ReadLine());
                                                                                }
                                                                                catch (Exception e2 ) 
                                                                                {
                                                                                Console.WriteLine("Bad input, I accept only numbers. Please type a again");
                                                                                continue;
                                                                                
                                                                                }
                                                                                
                                                                                float mutiplication2 = a*b*c;
                                                                                Console.WriteLine(a + "  *  " + b + "  *  " + c + "  =  " + mutiplication2);
                                                                                break;
                                                                                case 4:
                                                                                 try
                                                                                {
                                                                                
                                                                                Console.WriteLine("type number 1");
                                                                                a= float.Parse(Console.ReadLine());
                                                                                Console.WriteLine("type number 2");
                                                                                b= float.Parse(Console.ReadLine());
                                                                                Console.WriteLine("type number 3");
                                                                                c= float.Parse(Console.ReadLine());
                                                                                Console.WriteLine("type number 4");
                                                                                d= float.Parse(Console.ReadLine());
                                                                                }
                                                                                catch (Exception e3 ) 
                                                                                {
                                                                                Console.WriteLine("Bad input, I accept only numbers. Please type a again");
                                                                                continue;
                                                                                
                                                                                }
                                                                                
                                                                                float mutiplication4 = a*b*c*d;
                                                                                Console.WriteLine(a + "  *  " + b + "  *  " + c + "  *  " + d + "  =  " + mutiplication4);
                                                                                break;
                                                                                case 5:
                                                                                 try
                                                                                {
                                                                                
                                                                                Console.WriteLine("type number 1");
                                                                                a= float.Parse(Console.ReadLine());
                                                                                Console.WriteLine("type number 2");
                                                                                b= float.Parse(Console.ReadLine());
                                                                                Console.WriteLine("type number 3");
                                                                                c= float.Parse(Console.ReadLine());
                                                                                Console.WriteLine("type number 4");
                                                                                d= float.Parse(Console.ReadLine());
                                                                                Console.WriteLine("type number 5");
                                                                                e= float.Parse(Console.ReadLine());
                                                                                }
                                                                                catch (Exception e4 ) 
                                                                                {
                                                                                Console.WriteLine("Bad input, I accept only numbers. Please type a again");
                                                                                continue;
                                                                                
                                                                                }
                                                                                
                                                                                float mutiplication5 = a*b*c*d*e;
                                                                                Console.WriteLine(a + "  *  " + b + "  *  " + c + "   *  " + d + "  *  " + e +"  =  " + mutiplication5);
                                                                                break;
                                                                                default:
                                                                                Console.WriteLine("you didn't select a proper option, please try again.");
                                                                                break;

                                                                                

                                                                                
                                                                        } 
                                                                        Console.WriteLine("Do you still need to do another multiplication [y/n]?"); 
                                                                        char ans1= char.Parse(Console.ReadLine()); 
                                                                        if (ans1.Equals ('n') ){break;}
                                                                        else if ( ans1.Equals ('y') ){continue;}
                                                                        else {Console.WriteLine("write a correct character");}
                                                                    }
                                                    break;         
                                                    
                                                    case 1:
                                                        while (true)
                                                                    {   float a,b;
                                                                        Console.WriteLine("Please type the numbers that you need to divide");
                                                                        string  divisionFormat = 
                                    
                                                                                            @"
                                                                                                        number 1
                                                                                                Result = -----------
                                                                                                        number 2

                                                                                            ";
                                                                        
                                                                        Console.WriteLine(divisionFormat);
                                                                        Console.WriteLine("type number 1 ");
                                                                        try
                                                                        {
                                                                          a = float.Parse(Console.ReadLine());
                                                                        }
                                                                        catch (Exception e ) 
                                                                        {
                                                                          Console.WriteLine("Bad input, I accept only numbers. Please type a again");
                                                                          continue;
                                                                        
                                                                        }
                                                                        
                                                                        
                                                                        Console.WriteLine("type number 2");
                                                                        
                                                                        try
                                                                        {
                                                                          b = float.Parse(Console.ReadLine());
                                                                        }
                                                                        catch (Exception e ) 
                                                                        {
                                                                          Console.WriteLine("Bad input, I accept only numbers. Please type a again");
                                                                          continue;
                                                                        
                                                                        }
                                                                        float division = a/b;   
                                                                        Console.WriteLine(a + " / " + b + "  =  " + division);

                                                                        Console.WriteLine("Do you still need to do another division [y/n]?"); 
                                                                        char ans1= char.Parse(Console.ReadLine()); 
                                                                        if (ans1.Equals ('n') ){break;}
                                                                        else if ( ans1.Equals ('y') ){continue;}
                                                                        else {Console.WriteLine("write a correct character");}
                                                                    }
                                                    break;

                                                    case 2:
                                                     
                                                        while (true)
                                                                    {   Console.WriteLine("From 2 to 5, how many numbers do you need to add ?");
                                                                        float input = float.Parse(Console.ReadLine());
                                                                        float a,b,c,d,e;
                                                                        switch (input)
                                                                        {
                                                                                case 2:
                                                                                try
                                                                                {
                                                                                Console.WriteLine("type number 1");
                                                                                a = float.Parse(Console.ReadLine());
                                                                                Console.WriteLine("type number 2");
                                                                                b = float.Parse(Console.ReadLine());
                                                                                }
                                                                                catch (Exception z ) 
                                                                                {
                                                                                Console.WriteLine("Bad input, I accept only numbers. Please type a again");
                                                                                continue;
                                                                                
                                                                                }
                                                                                float subtract = a + b;
                                                                                Console.WriteLine(a + " + " + b + "  =  " + subtract);

                                                                                break;
                                                                                case 3:
                                                                                try
                                                                                {
                                                                                Console.WriteLine("type number 1");
                                                                                a = float.Parse(Console.ReadLine());
                                                                                Console.WriteLine("type number 2");
                                                                                b = float.Parse(Console.ReadLine());
                                                                                Console.WriteLine("type number 3");
                                                                                c= float.Parse(Console.ReadLine());
                                                                                }
                                                                                catch (Exception e1 ) 
                                                                                {
                                                                                Console.WriteLine("Bad input, I accept only numbers. Please type a again");
                                                                                continue;
                                                                                
                                                                                }
                                                                                subtract = a + b + c ;
                                                                                Console.WriteLine(a + "  +  " + b + "  +  " + c + "  =  " + subtract);
                                                                                break;
                                                                                case 4:
                                                                                try
                                                                                {
                                                                                Console.WriteLine("type number 1");
                                                                                a= float.Parse(Console.ReadLine());
                                                                                Console.WriteLine("type number 2");
                                                                                b= float.Parse(Console.ReadLine());
                                                                                Console.WriteLine("type number 3");
                                                                                c= float.Parse(Console.ReadLine());
                                                                                Console.WriteLine("type number 4");
                                                                                d= float.Parse(Console.ReadLine());
                                                                                }
                                                                                catch (Exception e2 ) 
                                                                                {
                                                                                Console.WriteLine("Bad input, I accept only numbers. Please type a again");
                                                                                continue;
                                                                                
                                                                                }
                                                                                
                                                                             subtract = a+b+c+d;
                                                                                Console.WriteLine(a + "  +  " + b + "  +  " + c + "  +  " + d + "  =  " + subtract);
                                                                                break;
                                                                                case 5:
                                                                                
                                                                                try
                                                                                {

                                                                                Console.WriteLine("type number 1");
                                                                                a= float.Parse(Console.ReadLine());
                                                                                Console.WriteLine("type number 2");
                                                                                b= float.Parse(Console.ReadLine());
                                                                                Console.WriteLine("type number 3");
                                                                                c= float.Parse(Console.ReadLine());
                                                                                Console.WriteLine("type number 4");
                                                                                d= float.Parse(Console.ReadLine());
                                                                                Console.WriteLine("type number 5");
                                                                                e= float.Parse(Console.ReadLine());
                                                                                }
                                                                                catch (Exception e2 ) 
                                                                                {
                                                                                Console.WriteLine("Bad input, I accept only numbers. Please type a again");
                                                                                continue;
                                                                                
                                                                                }
                                                                                
                                                                             subtract = a+b+c+d+e;
                                                                                Console.WriteLine(a + "  +  " + b + "  +  " + c + "   +  " + d + "  +  " + e +"  =  " + subtract);
                                                                                break;
                                                                                default:
                                                                                Console.WriteLine("you didn't select a proper option, please try again.");
                                                                                break;

                                                                                

                                                                                
                                                                        } 
                                                                        Console.WriteLine("Do you still need to do another multiplication [y/n]?"); 
                                                                        char ans1= char.Parse(Console.ReadLine()); 
                                                                        if (ans1.Equals ('n') ){break;}
                                                                        else if ( ans1.Equals ('y') ){continue;}
                                                                        else {Console.WriteLine("write a correct character");}
                                                                    }
                                                    break; 

                                                    case 3:
                                                        while (true)
                                                                    {   
                                                                        float a,b,c,d,e;
                                                                        try
                                                                        {
                                                                         
                                                                        Console.WriteLine(" number1 - number2 = result ");
                                                                        Console.WriteLine("type number 1");
                                                                        a= float.Parse(Console.ReadLine());
                                                                        Console.WriteLine("type number 2");
                                                                        b= float.Parse(Console.ReadLine());
                                                                        }
                                                                        catch (Exception e2 ) 
                                                                        {
                                                                        Console.WriteLine("Bad input, I accept only numbers. Please type a again");
                                                                        continue;
                                                                        
                                                                        }                                                                
                                                                        float subtract  = a - b;
                                                                        Console.WriteLine(a + " - " + b + "  =  " + subtract);
                                                                        Console.WriteLine("Do you still need to do another multiplication [y/n]?"); 
                                                                        char ans1= char.Parse(Console.ReadLine()); 
                                                                        if (ans1.Equals ('n') ){break;}
                                                                        else if ( ans1.Equals ('y') ){continue;}
                                                                        else {Console.WriteLine("write a correct character");}
                                                                    }

                                                    
                                                    
                                                    break;        
                                                }
                                    Console.WriteLine("Do you still need to do another operation [y/n]?"); 
                                    char ans2= char.Parse(Console.ReadLine()); 
                                    if (ans2.Equals ('n') ){break;}
                                    else if ( ans2.Equals ('y') ){continue;}
                                    else {Console.WriteLine("write a correct character");}
                                    }
                                    






                    }


            
            
            
            
            
            
            
            
            
            
            }         
}