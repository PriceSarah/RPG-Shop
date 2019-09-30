using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Shop
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Variables
            string choice = "";

            //Shop Intro
            Console.WriteLine("Hello there young adventurer. I see you are interested in my wares. Feel free to look around, I sell a plethera of items");
            Console.WriteLine("What are you looking for?");
            Console.WriteLine("\nWeapons");
            Console.WriteLine("Armor");
            Console.WriteLine("Magic Items");
            Console.WriteLine("Other Items");
            Console.WriteLine("Your Inventory");
            Console.WriteLine("(W/A/M/O/I)");
            //Console.WriteLine("Type 'Back' to go back");
            choice = Console.ReadLine();
            

            //Opens Shop Categories
            while (choice != "W" && choice != "A" && choice != "M" && choice != "O" && choice != "I")
            if (choice == "W")
            {
               //    categories.OpenWeapons();

                  
            }
            else if (choice == "A")
            {

            }
            else if (choice == "M")
            {

            }
            else if (choice == "O")
            {

            }
            else if (choice == "I")
            {

            }

            Console.ReadKey();
        }
    }
}
