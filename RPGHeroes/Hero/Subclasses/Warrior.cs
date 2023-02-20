using RPGHeroes.Items;

namespace RPGHeroes.Hero.Subclasses
{
    public class Warrior : Hero
    {

        /// <summary>
        /// Constructor for the class. It sets the subclasses attributes as well as the weapons and armor they can equip.
        /// Their damaging attribute is also set.
        /// </summary>
        /// <param name="name"></param>
        public Warrior(string name) : base(name)
        {
            LevelAttributes = new(5, 2, 1);
            ValidWeaponTypes.AddRange(new[] { WeaponType.Axe, WeaponType.Hammer, WeaponType.Sword });
            ValidArmorTypes.AddRange(new[] { ArmorType.Mail, ArmorType.Plate });

            DamageAttribute = TotalAttributes().Strength;

            
        }

        /// <summary>
        /// Levels up the hero class with their correct stat increases
        /// </summary>
        public override void LevelUp()
        {
            Level += 1;
            LevelAttributes.Strength += 3;
            LevelAttributes.Dexterity += 2;
            LevelAttributes.Intelligence += 1;
        }

    }
}
