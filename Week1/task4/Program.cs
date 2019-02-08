using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = int.Parse(s);

            for (int i = 0; i < n; i++) // 1 
            {
                for(int j = 0; j <= i ; j++) // 0 <= 1 1 <= 1
                {
                    Console.Write("[*]");
                }
                Console.WriteLine();
            }
        }
    }
}
