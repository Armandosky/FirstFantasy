using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Inventory
{
    public class Armor : Bag
    {
        public Armor()
        {
            Name = "Armor";
            Durability = 1000;
            Damage = 5;
        }
    }
}
