using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Shop
{
    class Inventory : Items
    {
        int gold = 300;
        int minGold = 0;
        int inventorySpace = 0;
        int inventorySpaceMax = 25;
        int weight = 0;
        int weightMax = 100;

      

        //Everything weapons
       public Items this[int index]
        {
            get
            {
                return itemList[index];
            }
        }


       
        private Items[] itemList = new Items[100];
 

        /*public Load()
        {

        }*/

      

       




    }
}
