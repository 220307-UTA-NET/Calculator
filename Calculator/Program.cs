
namespace Calculator
{
  class Prorgam{
    static void Main( string [] args){
      char choice;
      double num1;
      double num2;


  Console.WriteLine("Operation List"); //Displays title
  Console.WriteLine();// Used for line spacing
  Console.WriteLine("1.Addition\n2.Subtraction\n3.Multiplication\n4.Division"); // Displays for user list of operations that can be performed on the calculator
  Console.WriteLine(); // Used for line spacing
  Console.WriteLine("Choose the operation you wish to perform (+, -, *, /)"); // Displays operations to be performed and prompts user to select and enter the desired operator
  choice = Console.ReadLine()[0]; // reads the selected operator
  Console.WriteLine(" Enter two numbers one by one"); //Prompts user to enter two numbers
  num1 = Convert.ToDouble(Console.ReadLine()); // Reads and displays first number entered on terminal
  num2 = Convert.ToDouble(Console.ReadLine()); // Reads and displays second number entered on terminal

  

  switch (choice){
    case '+':
    Console.WriteLine("{0} + {1} = {2}",num1,num2,(num1 + num2));
    break;
    case '-':
    Console.WriteLine("{0} - {1} = {2}",num1,num2,(num1 - num2));
    break;
    case '*':
    Console.WriteLine("{0} * {1} = {2}",num1,num2,(num1 * num2));
    break;
    case '/':
    Console.WriteLine("{0} / {1} = {2}",num1,num2,(num1 / num2));
    break;
    
    default:
    break;
   


    }
  
  }
  
  }
    }









 
    
  
  
  




    

      
    