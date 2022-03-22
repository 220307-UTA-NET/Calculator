// See https://aka.ms/new-console-template for more information
//Your application should:
//Be written in C# for .NET 6
//Be able to accept multiple numbers
//Perform a selected operation on those numbers
//Display the result of the operation
//Repeat until the user chooses to exit
//Your application could also (but it doesn't have to):
//Accept number values and operations in a written input format (ie. "one plus one")
//Accept mixed format input (ie. "one plus 3")
//Accept multiple values (ie. "2 + 3 + 4")
//Perform multiple operations (ie. "2 - 1 + 3")
//Store a calculation history to a file.
//Accept inputs from a file, perform the required operations, then ouput those results to a file.

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace FunctionTesting
{
    public static class Globals
    {
        public static bool endProgram = false;
    }
    public class Class1
    {
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to Cameron Merkh's super awesome calculator program! \n To exit the program type EXIT. To start over, type RESTART. For a deeper explaination of how the program works, type HELP. \n I currently accept + - * / ^ operators only. I cannot handle negative numbers being inputted.");
                while (true){
                    Beginning:
                    string? testInput = Console.ReadLine();
                    if (string.IsNullOrEmpty(testInput))
                    {
                        Console.WriteLine("Error: You must input something.");
                        goto Beginning;
                    }
                    else
                    {
                    testInput = textAltering(testInput);
                    }
                    
                    if (testInput.ToUpper() == "EXIT"){ //reminder to self: fix these to be contiains so spaces and things won't fuck it up
                        break;
                    }
                    else if (testInput.ToUpper() == "HELP")
                    {
                        menuOptions();
                    }

                    

                    breakdown(testInput);
                    if (Globals.endProgram)
                    {
                        break;
                    }
                }
                Console.WriteLine("Calculator is done.");
                
            }
            
            static void breakdown(string test)
            {
                
                char digit;
                //char digit2;
                bool result;
                bool result3;
                int lastPosition = 0;
                string temp;
                bool result2;
                //bool result4;
                int holding = test.Length;
                //float numWord;

                string answer;

                List<string> inputList = new List<string>();
                LoopStart:
                string originalProblem = (test + " = ");
                for (int i = 0; i < test.Length;i++) //reading and dividing up the input
                {
                    digit = test[i];
                    result = Char.IsLetter(digit);//this is where I can add in the letter word function



                    result = Char.IsDigit(digit);
                    result3 = digit.Equals('.');
                    if(result3 == true)
                    {
                        result = true;
                    }
                    if (result == false)
                    {
                        int j = i+1;
                        temp = test[lastPosition..i];
                        inputList.Add(temp);
                        temp = Char.ToString(test[i]);
                        result2 = Char.IsDigit(test[j]);
                        // if (result2 == false)
                        // {
                        //     digit2 = Char.ToString(test[j]);
                        //     if (digit2 == "-")
                        //     {
                        //         result2 = true;
                        //     }
                        // }
                        if (result2 == false)
                        {
		                	Console.WriteLine("Error: You entered a word I don't understand or two operators in a row. Please start over.");
                            answer = "0";
                            goto LoopEnd;
                        }              
                        inputList.Add(temp);
                        lastPosition = i+1;
                    }
                }
                temp = test[lastPosition..];
                inputList.Add(temp);



               // foreach(string a in inputList)
                //Console.WriteLine(a);

                for(int k = 0; k < inputList.Count;k++) //Order of operations exponents
                {
                    if (inputList[k] == "^")
                    {
                        float first;
                        int second;

                        first = float.Parse(inputList[(k-1)]);
                        float hold = first;
                        second= int.Parse(inputList[(k+1)]);
                        for (int l = second; l > 0;l--)
                        {
                            first = hold * first;
                        }
                        inputList[(k-1)] = first.ToString();
                        inputList.RemoveAt((k+1));
                        inputList.RemoveAt(k);  
                        continue;
                    }
                }
                for(int k = 0; k < inputList.Count;k++) //Order of operations multiplcation and division
                {
                    if (inputList[k] == "*")
                    {
                        float first;
                        float second;

                        first = float.Parse(inputList[(k-1)]);
                        second = float.Parse(inputList[(k+1)]);
                        first = first * second;
                        inputList[(k-1)] = first.ToString();
                        inputList.RemoveAt((k+1));
                        inputList.RemoveAt(k);  
                        continue;
                    }
                    if (inputList[k] == "/")
                    {
                        float first;
                        float second;

                        first = float.Parse(inputList[(k-1)]);
                        second = float.Parse(inputList[(k+1)]);
                        if (second == 0f)
                        {
                            Console.WriteLine("Error: You tried to divide by zero!\nEnding Program");
                            Environment.Exit(0);

                        }
                        first = first / second;
                        inputList[(k-1)] = first.ToString();
                        inputList.RemoveAt((k+1));
                        inputList.RemoveAt(k);  
                        continue;
                    }
                }
                for(int k = 0; k < inputList.Count;k++) //Order of operations addition and subtraction
                {
                    if (inputList[k] == "+")
                    {
                        float first;
                        float second;

                        first = float.Parse(inputList[(k-1)]);
                        second = float.Parse(inputList[(k+1)]);
                        first = first + second;
                        inputList[(k-1)] = first.ToString();
                        inputList.RemoveAt((k+1));
                        inputList.RemoveAt(k); 
                        continue;
                    }
                    if (inputList[k] == "-")
                    {
                        float first;
                        float second;

                        first = float.Parse(inputList[(k-1)]);
                        second = float.Parse(inputList[(k+1)]);
                        first = first - second;
                        inputList[(k-1)] = first.ToString();
                        inputList.RemoveAt((k+1));
                        inputList.RemoveAt(k);  
                        continue;
                    }
                }
                Console.WriteLine(originalProblem);
                foreach(string a in inputList)
                Console.WriteLine(a);
                answer = inputList[0];
                

                Console.WriteLine("\nYou can continue working this number, starting with an operator. Or you can type RESTART to clear it. You can also type SAVE to save it to a text file.");
                    

                    while (true){
                        string? test2 = Console.ReadLine();
                        if(!string.IsNullOrEmpty(test2))
                        {
                            test = test2;
                        }
                        else
                        {
                            test = "";
                        }
                        if (string.IsNullOrEmpty(test))
                        {
                            Console.WriteLine("Error: You must input something.");
                        }
                        else if (test.ToUpper() == "HELP")
                        {
                            menuOptions();
                        }
                        else if (test.ToUpper() == "EXIT")
                        {
                            Globals.endProgram = true;
                            break;
                        }
                        else if (test.ToUpper() == "SAVE")
                        {
                            saveMath(originalProblem);
                        }
                        else if (test.ToUpper() == "RESTART")
                        {
                            Console.Clear();
                            Console.WriteLine("Welcome to Cameron Merkh's super awesome calculator program! \n To exit the program type EXIT. To start over, type RESTART. For a deeper explaination of how the program works, type HELP. \n I currently accept + - * / ^ operators only.");
                            break;
                        }
                        else
                        {
                            test = textAltering(test);
                            digit = test[0];
                            result = Char.IsDigit(digit);
                            if (result == true){
                            Console.WriteLine("You need to start with an operator.");
                            break;
                            }
                            test = (answer + test2);
                            test = textAltering(test);
                            inputList.Clear();
                            lastPosition = 0;
                            goto LoopStart;
                        }
                    }
                    LoopEnd:
                    Console.WriteLine("");
            }
            static string textAltering(string text)
            {
                text = text.ToLower();
                text = text.Replace(" ", "");
                text = text.Replace("zero", "0");
                text = text.Replace("one", "1");
                text = text.Replace("two", "2");
                text = text.Replace("three", "3");
                text = text.Replace("four", "4");
                text = text.Replace("five", "5");
                text = text.Replace("six", "6");
                text = text.Replace("seven", "7");
                text = text.Replace("eight", "8");
                text = text.Replace("nine", "9");
                text = text.Replace("plus","+");
                text = text.Replace("minus","-");
                text = text.Replace("times","*");
                text = text.Replace("multipliedby","*");
                text = text.Replace("dividedby","/");

                return text;
            }
  
            static void menuOptions()
            {
                Console.WriteLine("To exit the program type EXIT \n To start over type RESTART \n To see this message again, type MENU \n To save a calculation type SAVE \n To try and load a calculation from a file type LOAD \n The program can understand words as numbers but only single digit words, though the program can understand larger numbers if they're broken down like that (e.g. 10 would be one zero, 256 would be two five six). I also understand plus, minus, times, multiplied by, and divided by.");
            }
            static void saveMath(string work)
            {
                if(File.Exists("Past Math.txt"))
                {
                    File.AppendAllText("Past Math.txt", work);
                }
                else
                {
                    File.Create("Past Math.txt").Close();
                    File.WriteAllText("Past Math.txt", work);
                }
                Console.WriteLine("Saved!");
            }

    }
}

                    //if (result == true){
                    //    lastPosition = i;
                    //    for (int k = i; k < test.Length;k++){
                    //    digit2 = test[k];
                    //    result3 = Char.IsLetter(digit2);
                    //    if (result3 == false){
                    //       result4 = Char.IsDigit(digit2);
                    //        if (result4 == false){
                    //            result4 = digit2.Equals("."); // some of this needs to be removed, work it out later after fixing letters
                    //            holding = k;
                    //            k = test.Length;
                    //        }
                    //    }
                    //    }
                    //    numWord = numToText(Convort.ToString(test[lastPosition..holding]));
                    //    Console.WriteLine(numWord);
                    //    inputList.Add(numWord.ToString());
                    //    lastPosition = 1 + holding;
                        //Console.WriteLine("Sorry I can't handle letters other than the provided commands. Please start over.");
                        //goto LoopEnd;
                    //}
                                        // else if (testInput.ToUpper() == "LOAD")
                    // {
                    //     testInput = loadMath();
                    // }
                   
                        //digit = testInput[1];
                       // result = Char.IsDigit(digit);  this needs new variables
                       // if (result == false)//check to see if you used letters
                       // {
                       // Console.WriteLine("You need to start with a number.");
                        //}
                       // //idea to make letters work. treat it like the numbers, going char by char until I extract the whole thing, then check to see if the extraction is a number word. if yes, convert to number, if not, kick back error. When doing this I have to remember to fix this part and the similiar part at the end so it doesn't kick back with letters when it wants letters.