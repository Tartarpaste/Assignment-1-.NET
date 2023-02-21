using RPGHeroes.Hero.Subclasses;
using RPGHeroes.Items;
using System.Text;

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

        /// <summary>
        /// Construcor for the Hero class.
        /// </summary>
        /// <param name="name"></param>
        public Hero(string name)
        {
            Name = name;
            Level = 1;


            Equipment.Add(Slot.Weapon, null);
            Equipment.Add(Slot.Head, null);
            Equipment.Add(Slot.Body, null);
            Equipment.Add(Slot.Legs, null);


        }

        /// <summary>
        /// The base levelup method that is overridden by the child classes.
        /// </summary>
        public abstract void LevelUp();


        /// <summary>
        /// Lets a hero equip items. The item passed into the function is checked for exceptions and then added
        /// to the slot it is designated for. If there is already an item in the slot, it is deleted.
        /// </summary>
        /// <param name="item"></param>
        /// <exception cref="Exceptions.InvalidWeaponException"></exception>
        /// <exception cref="Exceptions.InvalidLevelException"></exception>
        /// <exception cref="Exceptions.InvalidArmorException"></exception>
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

        /// <summary>
        /// Calculates the combined stats of a heroes attributes. 
        /// If the hero has any items equiped, their stats will be added as well
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Calculates the damage a hero deals based on their damageing attribute.
        /// A weapons damage modifier is also added if the hero has one equiped.
        /// </summary>
        /// <returns></returns>
        public double Damage()
        {

            double HeroDamage = 1;

            switch (this)
            {
                case Mage:
                    DamageAttribute = TotalAttributes().Intelligence;
                    break;

                case Ranger:
                    DamageAttribute = TotalAttributes().Dexterity;
                    break;

                case Rogue:
                    DamageAttribute = TotalAttributes().Dexterity;
                    break;

                case Warrior:
                    DamageAttribute = TotalAttributes().Strength;
                    break;
            }

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

        /// <summary>
        /// Uses a string builder to print all of the heroes information
        /// </summary>
        public string Display() 
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
            return heroDisplay.ToString();
        }
    }
}
