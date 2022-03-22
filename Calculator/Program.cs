class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome, thank you for choosing Kevin Lee's calculator");
        
        bool userOperate = true;       

        do 
        {
            Console.WriteLine("Select the operator [1]Addition [2]Subtraction [3]Multiplcation [4]Division [0]To Exit"); 

            int userMenuInput = int.Parse(Console.ReadLine());

            switch (userMenuInput)
            {
                case 1:
                Addition();
                break;

                case 2:
                Subtraction();
                break;

                case 3:
                Multiplcation();
                break;

                case 4:
                Division();
                break;

                case 0:
                userOperate = false;
                Environment.Exit(0);
                break;

                default:
                Console.WriteLine("Invalid Input! Please type the correct input!");
                break;
            }
        }while(userOperate == true);            
    }  

    static void Addition()
    {
        try
        {
            Console.WriteLine("Enter the first number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", num1, num2, (num1 + num2));
        }
        catch (Exception e)
        {
            Console.WriteLine("Invalid input! Please Type the valid input!", e);
        }
       
    }

    static void Subtraction()
    {

        try
        {
            Console.WriteLine("Enter the first number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} - {1} = {2}", num1, num2, (num1 - num2));

        }
        catch (Exception e)
        {
            Console.WriteLine("Invalid input! Please Type the valid input!",e);
        }
       
    }

    static void Multiplcation()
    {

        try
        {
            Console.WriteLine("Enter the first number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} * {1} = {2}", num1, num2, (num1 * num2));

        }
        catch (Exception e)
        {
            Console.WriteLine("Invalid input! Please Type the valid input!",e);
        }
       
    }

    static void Division()
    {
        try
        {
            Console.WriteLine("Enter the first number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            double num2 = Convert.ToDouble(Console.ReadLine());
          
            try
            {
                Console.WriteLine("{0} / {1} = {2}", num1, num2, (num1 / num2));
            }
            catch (Exception ze)
            {
                Console.WriteLine("Denominator cannot divide by zero (0)!");
            }         

        }
        catch (Exception e)
        {
            Console.WriteLine("Invalid input! Please Type the valid input!", e);
        }       
    }
}
