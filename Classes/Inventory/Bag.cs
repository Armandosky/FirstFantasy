using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Inventory
{
    public class Bag
    {
        private string name;
        private int damage;
        private int durability;

        public string Name { get => name; set => name = value; }
        public int Damage { get => damage; set => damage = value; }
        public int Durability { get => durability; set => durability = value; }
    }
}
