using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student();
            Student stud1 = new Student("Yera", "17BD11232");

            Console.WriteLine(stud.getName());
            Console.WriteLine(stud1.getName());
        }
    }
}
