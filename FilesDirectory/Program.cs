using System;
using System.IO;
using AssignmentLibrary;
namespace ConsoleApp8
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter directory path");
            string root = @"" + Console.ReadLine();
           
            FilesDirectory.DirectorySearch(root);
            Console.ReadKey();
        }
        }

   
}