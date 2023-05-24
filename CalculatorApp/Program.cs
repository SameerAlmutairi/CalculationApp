using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to the Calculator App!");
                Console.WriteLine("Please enter the first number:");
                double num1;
                while (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number:");
                }

                Console.WriteLine("Please enter the second number:");

                double num2;
                while (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number:");
                }


                Console.WriteLine("Please select an operation:");
                Console.WriteLine("1. Addition (+)");
                Console.WriteLine("2. Subtraction (-)");
                Console.WriteLine("3. Multiplication (*)");
                Console.WriteLine("4. Division (/)");
                Console.WriteLine("5. Exit");

                int choice = int.Parse(Console.ReadLine());

                double result = 0;
                bool isValid = true;

                switch (choice)
                {
                    case 1:
                        result = num1 + num2;
                        break;
                    case 2:
                        result = num1 - num2;
                        break;
                    case 3:
                        result = num1 * num2;
                        break;
                    case 4:
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                        {
                            Console.WriteLine("you Cannot divide any number by zero!");
                            isValid = false;
                        }
                        break;
                    case 5:
                        Environment.Exit(0); // exit
                        break;
                    default:
                        Console.WriteLine("Wrong choice!");
                        isValid = false;
                        break;
                }

                if (isValid)
                {
                    Console.WriteLine("Result: " + result);
                }
                    

                //Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}