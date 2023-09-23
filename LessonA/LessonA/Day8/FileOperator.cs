using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day8
{
    internal class FileOperator
    {
        public static void FileWriteAllLines()
        {
            String fName = @"c;\temp\myfileA.txt";
            string[] lines =
            {
                "chennai is the capital city.",
                "Madurai is the Temple city",
                "Salem is the steal city."
            };
            try
            {
                File.WriteAllLines(fName, lines);
                System.Console.WriteLine("File Created");
            }
            catch (Exception err)
            {
                Console.WriteLine($"ERROR!!!{err.Message}");
            }
        }
        public static void FileReadAllText()
        {
            string line = String.Empty;
            String fName = @"c:\temp\myfileA.txt";
            line = File.ReadAllText(fName);
            Console.WriteLine(line);
        }
        public static void FileRename()
        {
            String oldfName = @"c:\temp\myfileA.txt";
            String newfName = @"c:\temp\renamedfileA.txt";
            File.Copy(oldfName, newfName);
            File.Delete(oldfName);
            Console.WriteLine("File Renamed");
        }
        public static void FileDelete()
        {
            String fName = @"c:\temp\myfileA.txt";
            if (File.Exists(fName))
                File.Delete(fName);
            else
                Console.WriteLine("File DELETE FAILED");
        }
        public static void ListDirectoryContent()
        {
            String currentDir = @"c:\temp\";
            string[] fileNames = Directory.GetFiles(currentDir, "*.*");
            foreach (String name in fileNames)
            {
                Console.WriteLine(name);
            }



            string[] subdirNames = Directory.GetDirectories(currentDir, "*.*");
            foreach (String name in subdirNames)
            {
                Console.WriteLine(name);
            }
        }
        public static void ShowCurrentDirectory()
        {
            String currentworkingdirectory = Directory.GetCurrentDirectory();
            Console.WriteLine(currentworkingdirectory);
            currentworkingdirectory = Environment.CurrentDirectory;
            Console.WriteLine(currentworkingdirectory);
        }
        
        

    }

}
