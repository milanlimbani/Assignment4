using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeOperations(out int sumOfOddNo, out int SumOfEvenNo, out string concatString, out int maxLength, out int blankParam,2, 4, 6, 1, 3, 5,"Milan", "", "Limbani", null, 1, "Good Morning", 2, "Milan", 4, "How Are You");
            Console.WriteLine("Sum of Odd Number is : " + sumOfOddNo);
            Console.WriteLine("Sum of Even Number is : " + SumOfEvenNo);
            Console.WriteLine("Concatenation of string is : " + concatString);
            Console.WriteLine("No of Blank parameters Count is : " + blankParam);
            Console.WriteLine("Max string length is : " + maxLength);
            Console.Read();
        }
        public static void SomeOperations(out int sumOfOddNo,out int SumOfEvenNo,out string concatString,out int maxLength,out int blankParam, params object[] pdata)
        {
            sumOfOddNo = 0;
            SumOfEvenNo = 0;
            concatString = "";
            maxLength = 0;
            blankParam=0;
            foreach (object p in pdata)
            {
                if (p is int)
                {
                    int num = (int)p;
                    if (num % 2 == 0)
                    {
                        SumOfEvenNo += num;
                    }
                    else
                    {
                        sumOfOddNo += num;
                    }
                }
                else if (p is string)
                {
                    string str = (string)p;
                    if (str.Length > maxLength)
                    {
                        maxLength = str.Length;
                    }
                    concatString += str;
                }
                else if (p == null || p.ToString().Trim() == "")
                {
                    blankParam++;
                }
            }

           
        }

    }
}
