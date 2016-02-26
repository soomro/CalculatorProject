using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation op = new Operation();
            // #37 Select which operation user perform
            Console.WriteLine("Please select your choice: \n" +
                "1 = to add two values \n" +
                "2 = to Multiply two values\n" +
                "3 = to minus two values\n" +
                "4 = to devide two values\n" +
                "Please Enter your choice:" );

            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the first number:");
            double firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            double secondNumber = int.Parse(Console.ReadLine());
            double result;
            switch (choice)
            {
                case 1:
                    // function will be called here
                    result = op.Add(firstNumber, secondNumber);
                    Console.WriteLine("The result is: "  + result);
                    break;
                case 2:
                    // function will be called here
                    result = op.Multiple(firstNumber, secondNumber);
                    Console.WriteLine("The result is: " + result);
                    break;
                case 3:
                    // function will be called here
                    result = op.Minus(firstNumber, secondNumber);
                    Console.WriteLine("The result is: " + result);
                    break;
                case 4:
                    // function will be called here
                    result = op.Devide(firstNumber, secondNumber);
                    Console.WriteLine("The result is: " + result);
                    break;                                        
                    
                default:
                    Console.WriteLine("");
                    break;
            }
            Console.ReadKey();
        }

    }
}
