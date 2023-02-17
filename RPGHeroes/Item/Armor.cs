using RPGHeroes.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Item
{
    public enum ArmorType
    {
        Cloth,
        Leather,
        Mail,
        Plate
    }
    public class Armor : Item
    {
        public HeroAttribute ArmorAttribute { get; set; }
        public ArmorType Type { get; set; }

        public Armor(string name, int requiredLevel, Slot itemSlot, HeroAttribute armorAttribute, ArmorType type) : base(name, requiredLevel, itemSlot)
        {
            ArmorAttribute = armorAttribute;
            Type = type;
        }
    }
}
