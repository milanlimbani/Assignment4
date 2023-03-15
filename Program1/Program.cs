using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            CountNoParam(out int icount, out int fcount, out int scount, out int ccount,24,30,"Milan","Hello",2.8F,3.0F,4,9.8,'c');
            Console.WriteLine($"The No of Integer Parameter is : {icount}");
            Console.WriteLine($"The No of Float Parameter is : {fcount}");
            Console.WriteLine($"The No of String Parameter is : {scount}");
            Console.WriteLine($"The No of Char Parameter is : {ccount}");
            Console.Read();
        }
        public static void CountNoParam(out int icount,out int fcount,out int scount,out int ccount,params object[] p)
        {
            icount = 0;
            fcount = 0;
            scount = 0;
            ccount = 0;
            foreach (object pdata in p)
            {
                if (pdata is int)
                {
                    icount++;
                }
                else if (pdata is float)
                {
                    fcount++;
                }
                else if (pdata is string)
                {
                    scount++;
                }
                else if (pdata is char)
                {
                    ccount++;
                }
            }
        }
    }
}
