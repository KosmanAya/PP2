using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task3
{
    class Program
    {
        static void WhiteSpace(int level) // peredaem level
        {
            for (int i = 0; i < level * 4; i++)
            {
                Console.Write(' ');
            }
        }
        static void print(string path, int level)
        {
            DirectoryInfo dInfo = new DirectoryInfo(path); 
            FileInfo[] fileInfos = dInfo.GetFiles(); //file
            DirectoryInfo[] directoryInfos = dInfo.GetDirectories();//papka

            foreach(FileInfo f in fileInfos) // dlya kazhdogo FileInfo kotoriy nahodistya v fileInfos vyvozhu ego imya
            {
                WhiteSpace(level);
                Console.WriteLine(f.Name);
            }
            foreach (DirectoryInfo d in directoryInfos)
            {
                WhiteSpace(level);
                Console.WriteLine(d.Name);
                print(d.FullName, level + 1);
            }
        }
        static void Main(string[] args)
        {
            print(@"C:\Users\User\Desktop\pp2", 0);
        }
    }
}
