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
            string buyorsell = "";
            Shop shop = new Shop();
            //Shop Intro
            Console.WriteLine("Hello there young adventurer. I see you are interested in my wares. Feel free to look around, I sell a plethera of items");
            Console.WriteLine("Would you like to Buy or Sell?");
            Console.WriteLine("(Buy/Sell/Inventory/Exit)");
            buyorsell = Console.ReadLine();

            if (buyorsell == "Buy")
            {
                Console.WriteLine("What are you looking for?");
                Console.WriteLine("\nWeapons");
                Console.WriteLine("Armor");
                Console.WriteLine("Food and Supplies");
                Console.WriteLine("Your Inventory");
                Console.WriteLine("(W/A/F/Exit)");
                //Console.WriteLine("Type 'Back' to go back");
                choice = Console.ReadLine();


                //Opens Shop Categories
                while (choice != "Exit")
                {

                    //Weapon Menu
                    if (choice == "W")
                    {

                        while (choice != "0")
                        {
                            Console.WriteLine("What weapon would you be interested in?");
                            string weaponChoice = "";
                            string yesorno = "";

                            //weapons list
                            Console.WriteLine("\n0: Exit");
                            Console.WriteLine("1: Short Sword");
                            Console.WriteLine("2: Rapier");
                            Console.WriteLine("3: Great Sword");
                            Console.WriteLine("4: Dagger");
                            Console.WriteLine("5: Mace");
                            Console.WriteLine("6: War Hammer");
                            Console.WriteLine("7: Short Bow");
                            Console.WriteLine("8: Long Bow");
                            Console.WriteLine("9: Arrows (10)");
                            Console.WriteLine("10: Spear");
                            Console.WriteLine("11: Battle Axe");
                            Console.WriteLine("12: Great Axe");
                            Console.WriteLine("13: Flail");
                            Console.WriteLine("14: Whip");
                            weaponChoice = Console.ReadLine();

                            if (weaponChoice == "1")
                            {

                                Console.WriteLine(shop.WeaponStock[0].name + shop.WeaponStock[0].description + " This costs " + shop.WeaponStock[0].cost + ", weighs " + shop.WeaponStock[0].weight + ", and will take up " + shop.WeaponStock[0].space + " space.");
                                Console.WriteLine("Would you like to buy it?");
                                Console.WriteLine("(yes/no)");
                                yesorno = Console.ReadLine();
                                if (yesorno == "yes")
                                {
                                    shop.Buy();
                                }
                                if (yesorno == "no")
                                {
                                    break;
                                }
                            }

                            else if (weaponChoice == "2")
                            {
                                Console.WriteLine(shop.WeaponStock[1].name + shop.WeaponStock[1].description + " This costs " + shop.WeaponStock[1].cost + ", weighs " + shop.WeaponStock[1].weight + ", and will take up " + shop.WeaponStock[1].space + " space.");
                                Console.WriteLine("Would you like to buy it?");
                                Console.WriteLine("(yes/no)");
                                yesorno = Console.ReadLine();
                                if (yesorno == "yes")
                                {

                                }
                                if (yesorno == "no")
                                {
                                    break;
                                }
                            }

                            else if (weaponChoice == "3")
                            {
                                Console.WriteLine(shop.WeaponStock[2].name + shop.WeaponStock[2].description + " This costs " + shop.WeaponStock[2].cost + ", weighs " + shop.WeaponStock[2].weight + ", and will take up " + shop.WeaponStock[2].space + " space.");
                                Console.WriteLine("Would you like to buy it?");
                                Console.WriteLine("(yes/no)");
                                yesorno = Console.ReadLine();
                                if (yesorno == "yes")
                                {

                                }
                                if (yesorno == "no")
                                {
                                    break;
                                }
                            }

                            else if (weaponChoice == "4")
                            {
                                Console.WriteLine(shop.WeaponStock[3].name + shop.WeaponStock[3].description + " This costs " + shop.WeaponStock[3].cost + ", weighs " + shop.WeaponStock[3].weight + ", and will take up " + shop.WeaponStock[3].space + " space.");
                                Console.WriteLine("Would you like to buy it?");
                                Console.WriteLine("(yes/no)");
                                yesorno = Console.ReadLine();
                                if (yesorno == "yes")
                                {

                                }
                                if (yesorno == "no")
                                {
                                    break;
                                }
                            }

                            else if (weaponChoice == "5")
                            {
                                Console.WriteLine(shop.WeaponStock[4].name + shop.WeaponStock[4].description + " This costs " + shop.WeaponStock[4].cost + ", weighs " + shop.WeaponStock[4].weight + ", and will take up " + shop.WeaponStock[4].space + " space.");
                                Console.WriteLine("Would you like to buy it?");
                                Console.WriteLine("(yes/no)");
                                yesorno = Console.ReadLine();
                                if (yesorno == "yes")
                                {

                                }
                                if (yesorno == "no")
                                {
                                    break;
                                }
                            }

                            else if (weaponChoice == "6")
                            {
                                Console.WriteLine(shop.WeaponStock[5].name + shop.WeaponStock[5].description + " This costs " + shop.WeaponStock[5].cost + ", weighs " + shop.WeaponStock[5].weight + ", and will take up " + shop.WeaponStock[5].space + " space.");
                                Console.WriteLine("Would you like to buy it?");
                                Console.WriteLine("(yes/no)");
                                yesorno = Console.ReadLine();
                                if (yesorno == "yes")
                                {

                                }
                                if (yesorno == "no")
                                {
                                    break;
                                }
                            }

                            else if (weaponChoice == "7")
                            {
                                Console.WriteLine(shop.WeaponStock[6].name + shop.WeaponStock[6].description + " This costs " + shop.WeaponStock[6].cost + ", weighs " + shop.WeaponStock[6].weight + ", and will take up " + shop.WeaponStock[6].space + " space.");
                                Console.WriteLine("Would you like to buy it?");
                                Console.WriteLine("(yes/no)");
                                yesorno = Console.ReadLine();
                                if (yesorno == "yes")
                                {

                                }
                                if (yesorno == "no")
                                {
                                    break;
                                }
                            }

                            else if (weaponChoice == "8")
                            {
                                Console.WriteLine(shop.WeaponStock[7].name + shop.WeaponStock[7].description + " This costs " + shop.WeaponStock[7].cost + ", weighs " + shop.WeaponStock[7].weight + ", and will take up " + shop.WeaponStock[7].space + " space.");
                                Console.WriteLine("Would you like to buy it?");
                                Console.WriteLine("(yes/no)");
                                yesorno = Console.ReadLine();
                                if (yesorno == "yes")
                                {

                                }
                                if (yesorno == "no")
                                {
                                    break;
                                }
                            }

                            else if (weaponChoice == "9")
                            {
                                Console.WriteLine(shop.WeaponStock[8].name + shop.WeaponStock[8].description + " This costs " + shop.WeaponStock[8].cost + ", weighs " + shop.WeaponStock[8].weight + ", and will take up " + shop.WeaponStock[8].space + " space.");
                                Console.WriteLine("Would you like to buy it?");
                                Console.WriteLine("(yes/no)");
                                yesorno = Console.ReadLine();
                                if (yesorno == "yes")
                                {

                                }
                                if (yesorno == "no")
                                {
                                    break;
                                }
                            }

                            else if (weaponChoice == "10")
                            {
                                Console.WriteLine(shop.WeaponStock[9].name + shop.WeaponStock[9].description + " This costs " + shop.WeaponStock[9].cost + ", weighs " + shop.WeaponStock[9].weight + ", and will take up " + shop.WeaponStock[9].space + " space.");
                                Console.WriteLine("Would you like to buy it?");
                                Console.WriteLine("(yes/no)");
                                yesorno = Console.ReadLine();
                                if (yesorno == "yes")
                                {

                                }
                                if (yesorno == "no")
                                {
                                    break;
                                }
                            }

                            else if (weaponChoice == "11")
                            {
                                Console.WriteLine(shop.WeaponStock[10].name + shop.WeaponStock[10].description + " This costs " + shop.WeaponStock[10].cost + ", weighs " + shop.WeaponStock[10].weight + ", and will take up " + shop.WeaponStock[10].space + " space.");
                                Console.WriteLine("Would you like to buy it?");
                                Console.WriteLine("(yes/no)");
                                yesorno = Console.ReadLine();
                                if (yesorno == "yes")
                                {

                                }
                                if (yesorno == "no")
                                {
                                    break;
                                }
                            }

                            else if (weaponChoice == "12")
                            {
                                Console.WriteLine(shop.WeaponStock[11].name + shop.WeaponStock[11].description + " This costs " + shop.WeaponStock[11].cost + ", weighs " + shop.WeaponStock[11].weight + ", and will take up " + shop.WeaponStock[11].space + " space.");
                                Console.WriteLine("Would you like to buy it?");
                                Console.WriteLine("(yes/no)");
                                yesorno = Console.ReadLine();
                                if (yesorno == "yes")
                                {

                                }
                                if (yesorno == "no")
                                {
                                    break;
                                }
                            }

                            else if (weaponChoice == "13")
                            {
                                Console.WriteLine(shop.WeaponStock[12].name + shop.WeaponStock[12].description + " This costs " + shop.WeaponStock[12].cost + ", weighs " + shop.WeaponStock[12].weight + ", and will take up " + shop.WeaponStock[12].space + " space.");
                                Console.WriteLine("Would you like to buy it?");
                                Console.WriteLine("(yes/no)");
                                yesorno = Console.ReadLine();
                                if (yesorno == "yes")
                                {

                                }
                                if (yesorno == "no")
                                {
                                    break;
                                }
                            }

                            else if (weaponChoice == "14")
                            {
                                Console.WriteLine(shop.WeaponStock[13].name + shop.WeaponStock[13].description + " This costs " + shop.WeaponStock[13].cost + ", weighs " + shop.WeaponStock[13].weight + ", and will take up " + shop.WeaponStock[13].space + " space.");
                                Console.WriteLine("Would you like to buy it?");
                                Console.WriteLine("(yes/no)");
                                yesorno = Console.ReadLine();
                                if (yesorno == "yes")
                                {

                                }
                                if (yesorno == "no")
                                {
                                    break;
                                }
                            }

                            if (weaponChoice == "0")
                            {
                                break;
                            }

                        }
                    }


                    //Armor Menu
                    else if (choice == "A")
                    {

                    }
                    //Food and Supplies Menu
                    else if (choice == "F")
                    {

                    }

                    else if (choice == "Exit")
                    {
                        break;
                    }
                }
            }

            //Selling
            else if (buyorsell == "Sell")
            {

            }

            //Inventory Open
            else if (buyorsell == "Inventory")
            {

            }
               

               
            
            if (buyorsell == "Exit")
            {
                Console.WriteLine("Have a nice day");
                Console.ReadKey();
            }
            //Console.ReadKey();
        }
    }
}
