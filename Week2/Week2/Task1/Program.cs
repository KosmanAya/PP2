using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace Task1
{
    class Program
    {
        static bool polin(string s) //ababa
        {
            for (int i = 0; i < s.Length/2; i++)
            {
                if (s[i] != s[s.Length - i - 1]) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\User\Desktop\text.txt");//создаешь объект который будет читать с текста
            string s = sr.ReadToEnd();// конкретно читаю и сохраняю в с

            if (polin(s) == true) Console.WriteLine("Yes");
            else Console.WriteLine("No");
            
        }
    }
}
