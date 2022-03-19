class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome, thank you for choosing Kevin Lee's calculator");
        
        bool userOperate = true;       

        do 
        {
            Console.WriteLine("Select the operator [1]Addition [2]Subtraction [3]Multiplcation [4]Division [0]To Exit"); 

            char op;
            op = Console.ReadLine()[0];   
                    
            Console.WriteLine("Enter the two numbers one by one");
            Console.WriteLine("Enter the first number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            double num2 = Convert.ToDouble(Console.ReadLine());           

            switch(op)
            {
                case '1':
                    Console.WriteLine("{0} + {1} = {2}", num1, num2, (num1 + num2));
                    break;

                case '2':
                    Console.WriteLine("{0} - {1} = {2}", num1, num2, (num1 - num2));
                    break;

                case '3':
                    Console.WriteLine("{0} * {1} = {2}", num1, num2, (num1 * num2));
                    break;

                case '4':
                    if(num2 == 0.0)
                    Console.WriteLine("Denominator cannot divide by zero (0)!");
                    else
                    Console.WriteLine("{0} / {1} = {2}", num1, num2, (num1 / num2));
                    break;

                 case '0':
                    Environment.Exit(0);
                    break;
                            
                default:
                    Console.WriteLine("Invalid Input! Please type the correct input!", op);
                    break;
            }
               
           // Console.WriteLine("Do you wish you want to continue? Press [1] To continue or press any key to exit"); 

        }while(userOperate == true);            
    }  
}
