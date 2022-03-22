//Diego's Caculator Project
namespace Caculator
{
    class Program
    {
        static void Main()
        {
           while(true)
			{
				Console.WriteLine("Enter a number");
				Console.WriteLine("[0] - Exit Game");
				Console.WriteLine("[1] - SimpleCalcultor");
				Console.WriteLine("[2] - ComplexCalcultor");
				int menu = int.Parse(Console.ReadLine());
				switch (menu)
				{
					case 0:
						Console.WriteLine("Closing Program");
						//Console.Clear();
						return;
					case 1:
						SimpleCalc();
						break;
					case 2:
						ComplexCalc();
						break;
					default:
						Console.WriteLine("Unregistered input! Please enter either 1 or 0");
						break;
				}


			}
		}
		static void SimpleCalc()
        {
            double num1 = 0, num2 = 0, answer = 0;
			string[] operatorArray = {"+","-","*","/"};
			string operand = " ";
            Console.WriteLine("---------Using Simple Calculator---------");
            while(true)
            {
				Console.WriteLine("Enter Equation: ");
				string input = Console.ReadLine();
				if(input == "STOP")
				{
					return;
				}
				else
				{
					string[] inputs = input.Split(' ');
					num1 = double.Parse(inputs[0]);
					operand = inputs[1];
					num2 = double.Parse(inputs[2]);
					
				}
				
				switch(operand)
				{
					case "+":
						answer = num1 + num2;
						Console.WriteLine(num1+" "+operand+" "+num2+" = "+answer);
						break;
					case "-":
						answer = num1 - num2;
						Console.WriteLine(num1+" "+operand+" "+num2+" = "+answer);
						break;
					case "*":
						answer = num1 * num2;
						Console.WriteLine(num1+" "+operand+" "+num2+" = "+answer);
						break;
					case "/":
						answer = num1 / num2;
						Console.WriteLine(num1+" "+operand+" "+num2+" = "+answer);
						break;
					default:
						Console.WriteLine("Unregistered input! Please enter either a space betwen each character!");
						break;
					
				}

				
            }
            
        }
        static void ComplexCalc()
        {
            double num1 = 0, num2 = 0, answer = 0;
			string[] operatorArray = {"+","-","*","/"};
			string operand = " ";
            Console.WriteLine("---------Using Complex Calculator---------");
			Console.WriteLine("---------In Beta-------------");
            while(true)
            {
				Console.WriteLine("Enter Equation: ");
				string input = Console.ReadLine();
				if(input == "STOP")
				{
					return;
				}
				else
				{
					string[] inputs = input.Split(' ');
					
					switch(inputs[1])
					{
						case "+":
							for (int i = 0; i < inputs.Length; i++)
								{
									//Distinguishes between oeprator and number in array
									bool isNum = double.TryParse(inputs[i], out double numbers);
									if(isNum)
									{
										num1 = double.Parse(inputs[i]);
										answer += num1;
									}
									else
									{operand = inputs[i];}
								}
								Console.WriteLine(answer);
								answer = 0;
								break;
						case "-":
							for (int i = 0; i < inputs.Length; i++)
								{
									//Distinguishes between oeprator and number in array
									bool isNum = double.TryParse(inputs[i], out double numbers);
									if(isNum)
									{
										if(i == 0)
										{
											num1 = double.Parse(inputs[0]);
											num2 = double.Parse(inputs[i]);
											answer = num1 - num2;
										}
										else if(i > 0)
										{
											num2 = double.Parse(inputs[i]);
											answer = num1 - num2;

										}
										else if(i >= 5)
										{
											answer = num1 - num2 ;
										}
										
									}
									else
									{operand = inputs[i];}
								}
								Console.WriteLine(answer);
								answer = 0;
								break;
						case "*":
							for (int i = 0; i < inputs.Length; i++)
								{
									//Distinguishes between oeprator and number in array
									bool isNum = double.TryParse(inputs[i], out double numbers);
									if(isNum)
									{
										num1 = double.Parse(inputs[0]);
										num2 = double.Parse(inputs[i]);
										answer *= num2;
									}
									else
									{operand = inputs[i];}
								}
								Console.WriteLine(answer);
								answer = 0;
								break;
						
						case "/":
							for (int i = 0; i < inputs.Length; i++)
								{
									//Distinguishes between oeprator and number in array
									bool isNum = double.TryParse(inputs[i], out double numbers);
									if(isNum)
									{
										num1 = double.Parse(inputs[0]);
										num2 = double.Parse(inputs[i]);
										answer /= num2;
									}
									else
									{operand = inputs[i];}
								}
								Console.WriteLine(answer);
								answer = 0;
								break;
					}
					
				}
				
            }
            
        }
    }

}


