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
        static void WhiteSpace(int level) // peredaem level=количество пробелов 
        {
            for (int i = 0; i < level * 4; i++)
            {
                Console.Write(' ');
            }
        }
        static void print(string path, int level)// создаем функцию
        {
            DirectoryInfo dInfo = new DirectoryInfo(path); 
            FileInfo[] fileInfos = dInfo.GetFiles(); //с документов берем file
            DirectoryInfo[] directoryInfos = dInfo.GetDirectories();//papka

            foreach(FileInfo f in fileInfos) // dlya kazhdogo FileInfo kotoriy nahodistya v fileInfos vyvozhu ego imya
            {
                WhiteSpace(level);//вызываем функцию пробелов
                Console.WriteLine(f.Name); // вызываем его имя
            }
            foreach (DirectoryInfo d in directoryInfos) 
            {
                WhiteSpace(level);
                Console.WriteLine(d.Name);
                print(d.FullName, level + 1);// если найдет еще одну папку 
            }
        }
        static void Main(string[] args)
        {
            print(@"C:\Users\User\Desktop\pp2", 0); // вызываем нашу функцию
        }
    }
}
