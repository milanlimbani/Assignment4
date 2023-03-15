using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data;
            int size;
            Console.WriteLine("Enter the size of Array : ");
            bool result = int.TryParse(Console.ReadLine(), out size);
            if (result)
            {
                data = new Data(size);
            }
            else
            {
                data = new Data(2);
            }
            Student student = new Student() { Name = "milan", Marks = 450, StudentId = 1 };
            data.SetData(student, 1);
            Student student1 = new Student() { Name = "smit", Marks = 460, StudentId = 2 };

            //data.setDatat(student,2);
            data[1] = student1; // set indexer
            Student temp;
            if(data.GetData(1,out temp))
            {
                Console.WriteLine($"{temp.StudentId}\t {temp.Name}\t {temp.Marks}");
               
            }
            temp = data[1];
            Console.WriteLine(temp);

            GenericIndexer<String> genericIndexer = new GenericIndexer<string>();
            genericIndexer[0] = "Milan Limbani";
            genericIndexer[1] = "Akshay";
            Console.WriteLine($"value from generic(String) indexer " + $"{genericIndexer[0]}");

            GenericIndexer<Student> studentIndexer = new GenericIndexer<Student>();
            studentIndexer[0] = student;
            studentIndexer[1] = student1;
            Console.WriteLine($"value from generic(student) indexer " + $"{studentIndexer[0]}");

            Console.ReadLine();

        }
    }
}
