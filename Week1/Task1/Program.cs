using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line1 = Console.ReadLine();
            int n = int.Parse(line1);
            int[] nums_int = new int[n];
            string line2 = Console.ReadLine();
            string[] nums_string = line2.Split(); 
            for(int i=0; i<n; ++i)
            {
                nums_int[i] = int.Parse(nums_string[i]);
            }

            int[] ans = new int[n];


            int cnt = 0;
            for(int i = 0; i < n; ++i)
            {
                int nums_now = nums_int[i];
                if (nums_now == 0 || nums_now == 1) continue;
                bool isgood = true;
                for(int g = 2; g < nums_now; ++g)
                {
                    if (nums_now % g == 0) isgood = false;
                }
                if (isgood == false) continue;
                ans[cnt] = nums_now;
                ++cnt;
            }
            Console.WriteLine(cnt);
            for(int i = 0; i < cnt; ++i) 
            {
                Console.Write(ans[i] + " ");

            }
        }

    }
}
