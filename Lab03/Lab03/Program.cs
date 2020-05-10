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

            //setting up error log
            string errorFilePath = @"Assets/errorLog.txt";
            string[] errorStart = new string[] { "Error log:" };
            File.WriteAllLines(errorFilePath, errorStart);
            Console.WriteLine("Welcome to your favorite nomnom list!");
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
                Console.WriteLine("Your Favorite NomNoms");
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
            else if (result == "error")
            {
                string errorFilePath = @"Assets/errorLog.txt";
                Console.WriteLine(ViewList(errorFilePath));
                return true;
            }
            else
            {
                return false;
            }

        }
        
        public static string ViewList(string input)
        {


            try
            {
                string[] listArray = File.ReadAllLines(input);

                //Converts Array into one string.
                string response = "";
                foreach (string foodItem in listArray)
                {
                    response += $"{foodItem}, ";
                }

                //takes off trailing whitespace
                response = response.Trim();

                return response;
            }
            catch (DirectoryNotFoundException error)
            {
                string errorFilePath = @"Assets/errorLog.txt";
                string errorString = $"{error}";
                AddItem(errorFilePath, errorString);
                return "Invalid Path";
            }
            catch (FileNotFoundException error)
            {
                string errorFilePath = @"Assets/errorLog.txt";
                string errorString = $"{error}";
                AddItem(errorFilePath, errorString);
                return "File not found";
            }
            catch (IOException error)
            {
                string errorFilePath = @"Assets/errorLog.txt";
                string errorString = $"{error}";
                AddItem(errorFilePath, errorString);
                return "System IO error";
            }
        }
        public static void AddItem(string path, string content)
        {

            try
            {
                string[] newItem = new string[] { content };
                File.AppendAllLines(path, newItem);
                Console.WriteLine("item added");
            }
            catch (DirectoryNotFoundException error)
            {
                string errorFilePath = @"Assets/errorLog.txt";
                string errorString = $"{error}";
                AddItem(errorFilePath, errorString);
            }
            catch (FileNotFoundException error)
            {
                string errorFilePath = @"Assets/errorLog.txt";
                string errorString = $"{error}";
                AddItem(errorFilePath, errorString);
            }
            catch (IOException error)
            {
                string errorFilePath = @"Assets/errorLog.txt";
                string errorString = $"{error}";
                AddItem(errorFilePath, errorString);
            }


        }
        public static void DelItem(string path, string itemToBeNotEaten)
        {
            try
            {
                string[] intialArray = File.ReadAllLines(path);
                string[] filteredArray = Array.FindAll(intialArray, nomnom => nomnom != itemToBeNotEaten);
                File.WriteAllLines(path, filteredArray);
            }
            catch (DirectoryNotFoundException error)
            {
                string errorFilePath = @"Assets/errorLog.txt";
                string errorString = $"{error}";
                AddItem(errorFilePath, errorString);
            }
            catch (FileNotFoundException error)
            {
                string errorFilePath = @"Assets/errorLog.txt";
                string errorString = $"{error}";
                AddItem(errorFilePath, errorString);
            }
            catch (IOException error)
            {
                string errorFilePath = @"Assets/errorLog.txt";
                string errorString = $"{error}";
                AddItem(errorFilePath, errorString);
            }

        }
    }
}
