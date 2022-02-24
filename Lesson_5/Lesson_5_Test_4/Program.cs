using System;
using System.IO;
using System.Linq;
namespace Lesson_5_Test_4
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Users\User\Desktop\Res\Lesson_5\Lesson_5_Test_4"; //Environment.CurrentDirectory;
            string nameFile = "List_1.txt";
            string nameFile_2 = "List_2.txt";

            SavePathRecursion(path, nameFile);
            Console.WriteLine("Файлы созданы");

            SavePath(path, nameFile_2);


        }

        static void SavePathRecursion(string pathToFindToDirectoria, string pathToWriteFile)
        {
            File.AppendAllLines(pathToWriteFile, new[] { pathToFindToDirectoria });
            string[] tree = Directory.EnumerateDirectories(pathToFindToDirectoria).ToArray();
            string[] fileTree = Directory.GetFiles(pathToFindToDirectoria);
            File.AppendAllLines(pathToWriteFile, fileTree );
            for (int i = 0; i < tree.Length; i++)
            {

                SavePathRecursion(tree[i], pathToWriteFile);
                

            }

            

        }
        static void SavePath(string pathToFindToDirectoriam, string pathToWriteFile)
        {
            string[] allfiles = Directory.GetFileSystemEntries(pathToFindToDirectoriam, "*.*", SearchOption.AllDirectories);
            File.AppendAllLines(pathToWriteFile, allfiles);

        }
    }
}
