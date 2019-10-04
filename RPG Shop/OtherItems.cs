using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Shop
{
    class OtherItems : Items
    {
        public OtherItems(string newName, string newDescription, int newWeight, int newSpace, int newCost)
        {
            name = newName;
            description = newDescription;
            weight = newWeight;
            space = newSpace;
            cost = newCost;
        }
    }
}
