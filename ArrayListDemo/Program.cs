using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ArrayListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList(6);
            list.Add("Milan");
            list.Add(1);
            list.AddRange(new int[] { 1, 2, 3, });
            list.Add("I am here");
            list.Add(new Student() { Marks = 345 , Name="milan",StudentId=1 }) ;
           
         
            foreach(object obj in list)
            {
                Console.WriteLine(obj.GetType().GetProperties().GetValue());
            }
            Console.WriteLine(list[0]);
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);
            Console.Read();
        }
    }
}
