using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApplication1
{
    public class Manipulation
    {
        public static void Append(string path)
        {
            string result = Retrieval.ReadFile(path);
            Console.WriteLine("What would you like to append it with? \n");
            Console.Write("Input: ");
            string append = Console.ReadLine();
            using (StreamWriter sw = new StreamWriter(path + "\\" + result + ".txt", true))
            {
                sw.WriteLine(append);
            }
        }

        public static void deleteFile(string path)
        {
            Console.WriteLine("Which file would you like to delete?");

            List<string> fileCollection = new List<string>(Directory.EnumerateFiles(path));
            Console.ForegroundColor = ConsoleColor.Blue;

            for (int i = 0; i < fileCollection.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write((i + 1) + ": ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(fileCollection[i]);
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("\nInput: ");
            string answer = Console.ReadLine();

            if (answer == "")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Answer must not be blank. Please try again. \n");
                Console.ForegroundColor = ConsoleColor.Gray;
                deleteFile(path);
            }

            bool isDigit = false;

            foreach (char c in answer)
            {
                if (!Char.IsDigit(c))
                {
                    isDigit = false;
                    Program.invalid();
                    deleteFile(path);
                }
                else
                {
                    isDigit = true;
                }
            }
            if (isDigit)
            {
                if (Convert.ToInt32(answer) >= 1 && Convert.ToInt32(answer) <= fileCollection.Count)
                {
                    Console.WriteLine("You have just deleted " + fileCollection[(Convert.ToInt32(answer) - 1)]);
                }
                else
                {
                    Program.invalid();
                    deleteFile(path);
                }
            }
        }

        public static void CreateTxtDoc(string path)
        {
            Console.WriteLine("Existing Files: \n");
            Retrieval.GetFiles(path);
            Console.Write("What would you like the file to be named?: ");
            string result = Console.ReadLine();
            if (File.Exists(path + "\\" + result + ".txt"))
            {
                Console.WriteLine("\nFile Exists. Skipping File Creation.");
            }
            else
            {
                Console.WriteLine("\nFile does not exist. Creating File. \n");
                using (FileStream create = File.Create(path + "\\" + result + ".txt"))
                {
                }
            }
            Console.WriteLine();
        }
    }
}
