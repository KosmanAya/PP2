using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task2
{
    class Program
    {
        static bool prime(int n)
        {
            if (n == 1 || n == 0) return false;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C: \Users\User\Desktop\input.txt");// создаешь объект который будет читать с текста
            string s = sr.ReadToEnd();// читаешь конкретно с этого файла
            sr.Close();//закрываешь
            string[] arr = s.Split(' ');// разделяешь на пробелы и с той и с той стороны

            string result = "";// cоздаем пустое место
            StreamWriter sw = new StreamWriter(@"C: \Users\User\Desktop\output.txt");// cоздаем сами знанчение и создает сам
            for (int i = 0; i < arr.Length; i++)
            {
                int num = int.Parse(arr[i]);// parse это чтобы элемент строки был в инт 
                if (prime(num) == true)
                {
                    result = result + num + ' '; //v pred resultat sohranyaesh noviy tipa ""; "1" + " "; "1" + " " + "2" + " ";
                }
            }
            sw.Write(result);
            sw.Close();

        }
    }
}
