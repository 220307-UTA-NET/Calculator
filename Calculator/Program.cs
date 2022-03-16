class Calculator
{

    public static long ConvertToNumbers(string numberString)
    {
        var numbers = Regex.Matches(numberString, @"\w+").Cast<Match>()
            .Select(m => m.value.ToLowerInvariant())
            .Where(v => numberTable.ContainsKey(v))
            .select(v => numberTable[v]);
        long acc = 0, total 0L;
        foreach(var n in numbers)
        {
            if(n >=1000)
            {
                total += acc*n;
                acc = 0;
            }
            else if(n >= 1000)
            {
                total +=acc*n;
                acc = 0;
            }
            else if (n >=100)
            {
                acc *= n;
            }
            else acc += n;
        }
        return (total + acc) * (numberString.startswith("minus",
        StringComparison.InvariantcultureIgnoreCase) ? -1 : 1);     
    }

    static void Main(string[] args)
    {
        char op;
        double num1,num2;

        Console.WriteLine("Enter the Operator(+, -, *, /)");
        Console.Readline()[0];

        Console.WriteLine("Enter the two numbers one by one");
        Console.WriteLine("Enter the first number");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the second number");
        num2 = Convert.ToDouble(Console.ReadLine());

        switch(op)
        {
            case '+':
            Console.WriteLine("{0} + {1} = {2}", num1, num2, (num1 + num2));
            break;

            case '-':
            Console.WriteLine("{0} - {1} = {2}", num1, num2, (num1 - num2));
            break;

            case '*':
            Console.WriteLine("{0} * {1} = {2}", num1, num2, (num1 * num2));
            break;

            case '/':
            if(num2 == 0.0)
            Console.WriteLine("Denominator cannot divide by zero (0)!");
            else
            Console.WriteLine("{0} / {1} = {2}", num1, num2, (num1 / num2));
            break;
            
            default:
            Console.WriteLine("{0} is an invalid operator", op);
            break;
        }

        Console.WriteLine("Press Any Key to Exit the Program");
        Console.ReadKey();
    }
}
