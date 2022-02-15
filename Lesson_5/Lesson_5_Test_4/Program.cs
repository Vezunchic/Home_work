using System;
using System.IO;
using System.Linq;
namespace Lesson_5_Test_4
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = Environment.CurrentDirectory;
            string nameFile = "List_1.txt";
            string recursNameFile = "List_2.txt";
            //RecursSavePath(path,recursNameFile);
            SavePath(path, nameFile);
            Console.WriteLine("Файлы созданы");




        }

        static void SavePath(string path, string file)
        {
            File.AppendAllLines(file, new[] { path });
            string[] tree = Directory.EnumerateDirectories(path).ToArray();
            
            for (int i = 0; i < tree.Length; i++)
            {
                SavePath(tree[i], file);


            }



        }
        /*static void RecursSavePath(string path, string file) // рекурсия
        {
            File.AppendAllLines(file, new[] { path });
            string[] treeItem = Directory.EnumerateFiles(path).ToArray();

            for (int i = 0; i < treeItem.Length; i++)
            {
                SavePath(treeItem[i], file);

            }
        



        }*/
    }
}
