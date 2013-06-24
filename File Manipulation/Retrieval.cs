using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApplication1
{
    public class Retrieval
    {
        public static void GetFolders(string path)
        {
            Console.Clear();
            List<string> directoryCollection = new List<string>(Directory.EnumerateDirectories(path));
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("There are " + directoryCollection.Count + " current subdirectories within target folder: \n");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < directoryCollection.Count; i++)
            {
                Console.WriteLine(directoryCollection[i]);
            }
            Console.WriteLine();
        }

        public static void GetFiles(string path)
        {
            List<string> fileCollection = new List<string>(Directory.EnumerateFiles(path));
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("There are " + fileCollection.Count + " current files within target folder: \n");
            Console.ForegroundColor = ConsoleColor.Blue;

            for (int i = 0; i < fileCollection.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write((i + 1) + ": ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(fileCollection[i]);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.WriteLine();
        }

        public static string ReadFile(string path)
        {
            Console.WriteLine("Which .txt file would you like to access?");
            Retrieval.GetFiles(path);
            Console.Write("\n Input: ");
            string result = Console.ReadLine();
            Console.WriteLine("Current Contents of file: ");
            Console.WriteLine("****************START FILE DISPLAY******************");
            using (StreamReader StreamRead = new StreamReader(path + "\\" + result + ".txt", true))
            {
                string contents = StreamRead.ReadToEnd();
                Console.WriteLine(contents);
            }
            Console.WriteLine("*****************END FILE DISPLAY*******************\n");

            return result;
        }
    }
}
