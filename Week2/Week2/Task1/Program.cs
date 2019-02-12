using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


// полиндром создаем в тексте если да то выводим да
namespace Task1
{
    class Program
    {
        static bool polin(string s) //ababa создали функцию полинs
        {
            for (int i = 0; i < s.Length/2; i++)//короче мы берем слово абба и проверям его на полиндром ,и проверям только начальные буквы точнее начинаем с буквы а и проверяем при помощи 18 строчки
            {
                if (s[i] != s[s.Length - i - 1]) return false; // v slove abba dlina=4 i=0 i tak delaem 
            }
            return true;
        }
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\User\Desktop\text.txt");//создаешь объект который будет читать с текста
            string s = sr.ReadToEnd();// конкретно читаю и сохраняю в с

            if (polin(s) == true) Console.WriteLine("Yes"); // polin s это функция ,котрую мы создали в 14 строке 
            else Console.WriteLine("No");
            
        }
    }
}
