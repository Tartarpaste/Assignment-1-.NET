using RPGHeroes.Item;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Hero
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; } = 1;
        public HeroAttribute LevelAttributes { get; set; }

        public Dictionary<Slot, Item.Item> Eqipment;
        public List<WeaponType> ValidWeaponTypes { get; set; }
        public List<ArmorType> ValidArmorTypes { get; set; }
        public int DamageAttribute { get; set; }  

        public Hero(string name)
        {
            Name = name;
            Level = 1;

            Eqipment.Add(Slot.Weapon, null);
            Eqipment.Add(Slot.Head, null);
            Eqipment.Add(Slot.Body, null);
            Eqipment.Add(Slot.Legs, null);


        }

        public abstract void LevelUp();

        public void Equip(Item.Item item)
        {
            if (item is Weapon)
            {
                Weapon weapon = (Weapon)item;
                if (!ValidWeaponTypes.Contains(weapon.Type))
                {
                    throw new Exceptions.InvalidWeaponException();
                }
                if (weapon.RequiredLevel >= Level)
                {
                    throw new Exceptions.InvalidLevelException();
                }
            }

            if (item is Armor)
            {
                Armor armor = (Armor)item;
                if (!ValidArmorTypes.Contains(armor.Type))
                {
                    throw new Exceptions.InvalidArmorException();
                }
                if (armor.RequiredLevel >= Level)
                {
                    throw new Exceptions.InvalidLevelException();
                }
            }

            Eqipment.Remove(item.ItemSlot);
            Eqipment.Add(item.ItemSlot, item);
        }

        public HeroAttribute TotalAttributes()
        {
            int strength = 0;
            int dexterity = 0;
            int Intelligence = 0;

            foreach(Item.Item item in Eqipment.Values)
            {
                if (item is Armor) 
                {
                    Armor armor = (Armor)item;
                    strength += armor.ArmorAttribute.Strength;
                    dexterity += armor.ArmorAttribute.Dexterity;
                    Intelligence += armor.ArmorAttribute.Intelligence;
                }
            }
            strength += LevelAttributes.Strength;
            dexterity += LevelAttributes.Dexterity;
            Intelligence += LevelAttributes.Intelligence;
            HeroAttribute TotalAttributes = new(strength, dexterity, Intelligence);

            return TotalAttributes;
        }

        public void Damage()
        {

        }

    }
}
