using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Console.WriteLine("Enter 10 numbers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Number {0}: ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            array analyzer = new array(numbers);

            int choice;
            do
            {
                Console.WriteLine("\n1. Display numbers entered");
                Console.WriteLine("2. Sum of the numbers");
                Console.WriteLine("3. Average of numbers");
                Console.WriteLine("4. Maximum of numbers");
                Console.WriteLine("5. Minimum of numbers");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        analyzer.DisplayNumbers();
                        break;
                    case 2:
                        Console.WriteLine("Sum: {0}", analyzer.Sum());
                        break;
                    case 3:
                        Console.WriteLine("Average: {0}", analyzer.Average());
                        break;
                    case 4:
                        Console.WriteLine("Maximum: {0}", analyzer.Maximum());
                        break;
                    case 5:
                        Console.WriteLine("Minimum: {0}", analyzer.Minimum());
                        break;
                    case 6:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            } while (choice != 6);
        }
    }
}
