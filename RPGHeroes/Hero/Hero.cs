using System;
using RPGHeroes.Items;
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
        public HeroAttribute LevelAttributes { get; set; } = new HeroAttribute(1, 1, 1);

        public Dictionary<Slot, Item?> Equipment = new Dictionary<Slot, Item?>();
        public List<WeaponType> ValidWeaponTypes { get; set; } = new List<WeaponType>();
        public List<ArmorType> ValidArmorTypes { get; set; } = new List<ArmorType>();
        public double DamageAttribute { get; set; } = 0;

        public Hero(string name)
        {
            Name = name;
            Level = 1;


            Equipment.Add(Slot.Weapon, null);
            Equipment.Add(Slot.Head, null);
            Equipment.Add(Slot.Body, null);
            Equipment.Add(Slot.Legs, null);


        }

        public abstract void LevelUp();

        public void Equip(Item item)
        {
            if (item is Weapon)
            {
                Weapon weapon = (Weapon)item;
                if (!ValidWeaponTypes.Contains(weapon.Type))
                {
                    throw new Exceptions.InvalidWeaponException();
                }
                if (weapon.RequiredLevel > Level)
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
                if (armor.RequiredLevel > Level)
                {
                    throw new Exceptions.InvalidLevelException();
                }
            }

            Equipment.Remove(item.ItemSlot);
            Equipment.Add(item.ItemSlot, item);
        }

        public HeroAttribute TotalAttributes()
        {
            double strength = 0;
            double dexterity = 0;
            double Intelligence = 0;

            foreach(Item item in Equipment.Values)
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

        public double Damage()
        {

            double HeroDamage = 1;
            if (Equipment[Slot.Weapon] != null)
            {
                Weapon weapon = (Weapon)Equipment[Slot.Weapon];
                HeroDamage = weapon.WeaponDamage * (1 + DamageAttribute / 100);
                return HeroDamage;
            } else
            {
                HeroDamage = 1 * (1 + DamageAttribute / 100);
                return HeroDamage;
            }
        }

        public void Display() 
        {
            StringBuilder heroDisplay = new StringBuilder();

            heroDisplay.AppendLine("This heroes name is: " + Name);
            heroDisplay.AppendLine(Name + "'s class is: " + GetType().Name);
            heroDisplay.AppendLine(Name + "'s level is: " + Level);
            heroDisplay.AppendLine(Name + "'s total strength is:" + TotalAttributes().Strength);
            heroDisplay.AppendLine(Name + "'s total dexterity is:" + TotalAttributes().Dexterity);
            heroDisplay.AppendLine(Name + "'s total intelligence is:" + TotalAttributes().Intelligence);
            heroDisplay.AppendLine(Name + "'s damage is: " + Damage());

            Console.WriteLine(heroDisplay);
        }
    }
}
