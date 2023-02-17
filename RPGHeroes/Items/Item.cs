using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Items
{
    public enum Slot
    {
        Weapon,
        Head,
        Body,
        Legs
    }
    public class Item
    {


        public string Name { get; set; }
        public int RequiredLevel { get; set; }
        public Slot ItemSlot { get; set; }

        public Item(string name, int requiredLevel, Slot itemSlot) 
        {
            Name = name;
            RequiredLevel = requiredLevel;
            ItemSlot = itemSlot;
        }
    }
}
