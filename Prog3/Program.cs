using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[][] jarray = new int[3][];
            jarray[0] = new int[] { 1, 2, 3 };
            jarray[1] = new int[] { 4, 5 };
            jarray[2] = new int[] { 5, 7, 8, 9 };

            foreach (int[] v in jarray)
            {
               
                int tmax, tmin;
                tmin = tmax = v[0];
                Array.ForEach(v, each => tmax = each > tmax ? each : tmax);
                Array.ForEach(v, each => tmin = each > tmin ? tmin : each);
                Console.WriteLine("The Maximum of row is :" + tmax);
                Console.WriteLine("The Minimum of row is :" + tmin);

            }

       

            //Onother Method is

            //foreach (int[] row in jarray)
            //{
            //    int min = row[0];
            //    int max = row[0];
            //    foreach (int element in row)
            //    {
            //        if (element < min)
            //        {
            //            min = element;
            //        }
            //        else
            //        {
            //            max = element;
            //        }
            //    }
            //    Console.WriteLine("Minimum value of row: " + min);
            //    Console.WriteLine("Maximum value of row: " + max);
            //}

            for (int i = 0; i < jarray[0].Length; i++)
            {
                int min = jarray[0][i];
                int max = jarray[0][i];
           
                foreach (int[] row in jarray)
                {
                    if (i < row.Length && row[i] < min)
                    {
           
                        min = row[i];
                    }
                    else if(i < row.Length && row[i] > max)
                    {
                        max = row[i];
                    }
                }
                Console.WriteLine("Minimum value of column " + i + ": " + min);
                Console.WriteLine("Maximum value of column " + i + ": " + max);
            }


            Console.Read();

        }
    }
}
