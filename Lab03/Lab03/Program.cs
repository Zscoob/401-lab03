using System;
using System.IO;

namespace Lab03
{
   public class NomsList
    {
        static void Main(string[] args)
        {
            //setting up the list
            string filePath = @"Assets/list.txt";
            string[] starterItem = new string[] { "nutella" };
            File.WriteAllLines(filePath, starterItem);

            bool displayMenu = true;
            while (displayMenu == true)
            {
               displayMenu = MainMenu();
            }
        }


      
        public static bool MainMenu()
        {
           
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
                Console.WriteLine("Enter a new happy nomnom  (>^.^)> to add to the list");
                string content =  Console.ReadLine();
                AddItem(filePath, content);
                return true;
            }
            else if (result == "3")
            {
                Console.WriteLine("Which sad nomnom  (>^_^)> do you want to remove from the list");
                string delInput = Console.ReadLine(); 
                DelItem(filePath, delInput);
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
            

            string[] listArray = File.ReadAllLines(input);

            //Converts Array into one string.
            string response = "";
            foreach(string foodItem in listArray)
            {
                response += $"{foodItem}, ";
            }

            //takes off trailing whitespace
            response = response.Trim();
          
            return response;
        }
        public static void AddItem(string path, string content)
        {
             
            string[] newItem = new string[] { content };
           
            File.AppendAllLines (path, newItem);
       

            Console.WriteLine("item added");

          


        }
        public static void DelItem(string path, string itemToBeNotEaten)
        {
            string[] intialArray = File.ReadAllLines(path);
            string[] filteredArray = Array.FindAll(intialArray, nomnom => nomnom != itemToBeNotEaten);
            //Console.WriteLine(String.Join(", ", File.ReadAllLines(path)));
            File.WriteAllLines(path, filteredArray);
            
        }
    }
}
