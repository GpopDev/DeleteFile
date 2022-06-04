using System;
using System.IO;

namespace DeleteFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ! Actually Works
            Console.WriteLine("Welcome");
            Console.Write("Insert full path of a file to delete: ");
            string FileToDelete = Convert.ToString(Console.ReadLine());
            File.Delete(FileToDelete);
        }
    }
}