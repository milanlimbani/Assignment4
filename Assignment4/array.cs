using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class array
    {
        private int[] numbers;

        public array(int[] numbers)
        {
            this.numbers = numbers;
        }

        public void DisplayNumbers()
        {
            Console.WriteLine("Numbers entered:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        public int Sum()
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public double Average()
        {
            return (double)Sum() / numbers.Length;
        }

        public int Maximum()
        {
            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            return max;
        }

        public int Minimum()
        {
            int min = numbers[0];
            foreach (int number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
            }
            return min;
        }
    }
}

