using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Shop
{
    class Weapons : Items
    {
        public Weapons(string newName, string newDescription, int newWeight, int newSpace, int newCost)
        {
            
          
        }

        //Everything weapons
        private Weapons shortsword = new Weapons("Short Sword", " A short sword is perfect weapon of choice for most any person of most any skill level.", 15, 2, 35);
        private Weapons rapier = new Weapons("Rapier", " A fancier sword. It's different from a short sword in use as you are meant to pierce rather than slash.", 10, 2, 30);
        private Weapons greatsword = new Weapons("Great Sword", " A great sword is a very heavy, but effective weapon. Not a weapon for the weak.", 35, 3, 50);
        private Weapons dagger = new Weapons("Dagger", " A dagger is a small weapon, but effective. A great choice of weapon for rogues or those who want to strike fast.", 5, 1, 10);
        private Weapons mace = new Weapons("Mace", " A mace is a havier one handed weapon. It's good for offense and defense.", 20, 2, 40);
        private Weapons warhammer = new Weapons("War Hammer", " A heavy duty bludgening weapon. This weapon is not easy to use and should only be used by the strongest of people.", 50, 4, 75);
        private Weapons shortbow = new Weapons("Short Bow", " A short bow is a good ranged weapon for most people. ", 10, 2, 35);
        private Weapons longbow = new Weapons("Long Bow", " A long bow is a bit more tricky than a short bow, but it has amazing range and power.", 30, 3, 45);
        private Weapons arrows = new Weapons("Arrows(10)", " A set of 10 arrows for your bow.", 5, 0, 10);
        private Weapons spear = new Weapons("Spear", " A spear is a versitile weapon that can be used in both melee and ranged combat.", 10, 3, 35);
        private Weapons battleaxe = new Weapons("Battle Axe", " A battle axe is a one handed weapon that is quite versitile.", 15, 2, 35);                    
        private Weapons greataxe = new Weapons("Great Axe", " A great axe is a heavy duty chopper that can easily hack through a group of foes.", 55, 4, 60);               
        private Weapons flail = new Weapons("Flail", " A flail is a hard to use, but effective weapon. Its like a morning star on a chain.", 25, 3, 40);
        private Weapons whip = new Weapons("Whip", " A whip is a weapon that takes practice. It won't slash or pierce your enemies but it will keep them back.", 5, 1, 20);
        
        private Weapons[] weaponList = new Weapons[15];
        public Inventory()
        {
            weaponList[0] = shortsword;
            weaponList[1] = rapier;
            weaponList[2] = greatsword;
            weaponList[3] = shortsword;
            weaponList[4] = shortsword;
            weaponList[5] = shortsword;
            weaponList[6] = shortsword;
            weaponList[7] = shortsword;
            weaponList[8] = shortsword;
            weaponList[9] = shortsword;
            weaponList[10] = shortsword;
            weaponList[11] = shortsword;
            weaponList[12] = shortsword;
        }

            public void Menu()
        {
            Console.WriteLine("What weapon would you be interested in?");
            string choice = "";
            string yesorno = "";

            


            while (choice != "0")
            {
                
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
                
                

                if (choice == "1")
                {

                    Console.WriteLine(weaponList[0].name + weaponList[0]);
                }
                else if (choice == "")
                {

                }
                else if (choice == "")
                {

                }
                else if (choice == "")
                {

                }

            }
        }

    }
}
