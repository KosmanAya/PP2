using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(@"C: \Users\User\Desktop\test.txt"); // даем сами знанчение и создает сам
            sw.Write(34564);
            sw.Close();

            File.Copy(@"C: \Users\User\Desktop\test.txt", @"C: \Users\User\Documents\test.txt");
            File.Delete(@"C: \Users\User\Desktop\test.txt");
        }
    }
}
