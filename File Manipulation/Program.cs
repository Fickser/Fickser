using System;

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
            Console.WriteLine("1: Get SubFolders \n2: Get Files \n3: Create new .txt file \n4: Append existing file \n5: Delete existing file");
            Console.Write("\nInput: ");

            string answer = Console.ReadLine();
            Console.WriteLine();

            switch (answer)
            {
                case "1":
                    Retrieval.GetFolders(path);
                    break;
                case "2":
                    Retrieval.GetFiles(path);
                    break;
                case "3":
                    Manipulation.CreateTxtDoc(path);
                    break;
                case "4":
                    Manipulation.Append(path);
                    break;
                case "5":
                    Manipulation.deleteFile(path);
                    break;
                default:
                    invalid();
                    MainMenu();
                    break;
            }
            DoMore();
        }

        public static void DoMore()
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
                    invalid();
                    DoMore();
                    break;
            }
        }

        public static void invalid()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("**Invalid response. Try again.** \n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
