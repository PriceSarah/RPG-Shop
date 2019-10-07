using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Shop
{
    class Shop 
    {

       //Name, Description, Cost, Weight, Space
        public Inventory ArmorStock = new Inventory();
        public Inventory WeaponStock = new Inventory();
        public Inventory MagicStock = new Inventory();
        public Inventory OtherStock = new Inventory();

        public void Save()
        {
            //save stuff into inventory
        }
        public void Load()
        {
            //load stuff into inventory
        }
       
        public void Buy()
        {

        }

        public void Sell()
        {

        }

    }
}