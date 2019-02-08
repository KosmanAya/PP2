using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static int[] ArrMaker(string[] arr) // для любого массива строк 
        {
            int n = arr.Length;
            int[] array = new int[n * 2];
            int cnt = -1;
            for (int i = 0; i < n; i++)
            {
                cnt++; // 0
                array[cnt] = int.Parse(arr[i]); // array[0] = 1
                cnt++; // 1
                array[cnt] = int.Parse(arr[i]); // array[1] = 1
            }

            return array;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = int.Parse(s);
            string k = Console.ReadLine(); // 1 2 3 вторую 
            string[] arr = k.Split(' '); // po probel
            //arr[0] = 1 
            int[] q = ArrMaker(arr); // funcciya vozrashaet massiv
            for (int i = 0; i < q.Length; i++)
            {
                Console.Write(q[i]);
                Console.Write(' ');
            }



        }
    }
}
