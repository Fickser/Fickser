using System;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**Welcome to the Directory Editor.** \n");
            MainMenu();
        }

        static void MainMenu()
        {
            string path = @"C:\Users\Fickser\Desktop\Tinkering";

            Console.WriteLine("We are currently working in the " + path + " directory. \n");
            Console.WriteLine("What would you like to do? \n \n");
            Console.WriteLine("1: Get SubFolders \n2: Get Files \n3: Create .txt file");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "1":
                    GetFolders(path);
                    break;
                case "2":
                    GetFiles(path);
                    break;
                case "3":
                    CreateTxtDoc(path);
                    break;
                default:
                    Console.WriteLine("Invalid response. Please Try again.");
                    MainMenu();
                    break;
            }


            /*CreateTxtDoc(path); //creates custom txt file and adds to directory
            GetFolders(path); //Grabs directories from target and displays
            GetFiles(path); // Grabs files from target and displays
            GetExtension(path); //Grabs Extension from target and displays*/



        }

        static void GetFolders(string path)
        {
            string[] directoryPath = Directory.GetDirectories(path);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Current Subdirectories within target folder: \n");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < directoryPath.Length; i++)
            {
                Console.WriteLine(directoryPath[i]);
            }
            Console.WriteLine();
            DoMore();
        }

        static void GetFiles(string path)
        {
            string[] filePath = Directory.GetFiles(path);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Current files within target folder: \n");
            Console.ForegroundColor = ConsoleColor.Blue;

            for (int i = 0; i < filePath.Length; i++)
            {
                Console.WriteLine(filePath[i]);
            }
            Console.WriteLine();
            DoMore();
        }

        static void GetExtension(string path)
        {
            string[] filePath = Directory.GetFiles(path);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("The extension for " + filePath[0] + " is " + "\"" + Path.GetExtension(filePath[0]) + "\"");
        }

        static void CreateTxtDoc(string path)
        {
            Console.Write("What would you like the file to be named?: ");
            string result = Console.ReadLine();
            if (File.Exists(path + "\\" + result + ".txt"))
            {
                Console.WriteLine("\n File Exists. Skipping File Creation. \n");
            }
            else
            {
                Console.WriteLine("\n File does not exist. Creating File. \n");
                File.Create(path + "\\" + result + ".txt");
            }
            Console.WriteLine();
            DoMore();
        }

        static void DoMore()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Would you like to do more?");
            Console.Write("1: Yes \n2: No \nInput: ");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "1":
                    Console.Clear();
                    MainMenu();
                    break;
                case "2":
                    Console.WriteLine("Thank you for using the Directory Editor. Have a nice day.");
                    break;
                default:
                    Console.WriteLine("Invalid response. Try again");
                    DoMore();
                    break;
            }
        }
    }
}
