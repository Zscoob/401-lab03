using System;
using System.IO;

namespace Lab03
{
   public class NomsList
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu == true)
            {
               displayMenu = MainMenu();
            }
        }











      
      
        public static bool MainMenu()
        {
           // Console.Clear();
            Console.WriteLine("Choose an option");
            Console.WriteLine("1) View List");
            Console.WriteLine("2) Add an item");
            Console.WriteLine("3) Delete an item");
            Console.WriteLine("4) Exit");

            string filePath = @"Assets/list.txt";
            string result = Console.ReadLine();
            if (result == "1")
            {
               
                Console.WriteLine(ViewList(filePath));
                return true;
            }
            else if (result == "2")
            {
                Console.WriteLine("Enter you happy nomnom (>^.^)>");
                string[] content = new string[] { Console.ReadLine() };
                AddItem(filePath, content);
                return true;
            }
            else if (result == "3")
            {
                DelItem();
                return true;
            }
            else if (result == "4")
            {
                return false;
            }
            else
            {
                return false;
            }

        }
        
        public static string ViewList(string input)
        {
            

            string response = File.ReadAllText(input);
           
          
            return response;
        }
        public static void AddItem(string input, string[] content)
        {
            //Console.Clear();
            // Console.WriteLine("Enter an Item: ")
            File.AppendAllLines (input, content);
       

            Console.WriteLine("item added");

          


        }
        public static void DelItem()
        {
            Console.Clear();
        }
    }
}
