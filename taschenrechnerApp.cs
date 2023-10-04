using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace taschenrechner_simple_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taschenrechner App");

            double num1, num2, result;
            char operation;

            Console.Write("Enter the first number: ");
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.Write("Enter the first number: ");
            }

            Console.Write("Enter the second number: ");
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.Write("Enter the second number: ");
            }

            Console.Write("Enter the operation (+, -, *, /): ");
            while (!char.TryParse(Console.ReadLine(), out operation))
            {
                Console.WriteLine("Invalid input. Please enter a valid operation.");
                Console.Write("Enter the operation (+, -, *, /): ");
            }

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine("The result {0} + {1} = {2}", num1, num2, result);
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine("The result {0} - {1} = {2}", num1, num2, result);
                    break;
                case '*':
                    result = num1 * num2;
                    Console.WriteLine("The result {0} * {1} = {2}", num1, num2, result);
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine("The result {0} / {1} = {2}", num1, num2, result);
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    break;
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

