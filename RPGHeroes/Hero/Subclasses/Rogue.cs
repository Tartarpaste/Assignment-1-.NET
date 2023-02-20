using RPGHeroes.Items;

namespace RPGHeroes.Hero.Subclasses
{
    public class Rogue : Hero
    {

        /// <summary>
        /// Constructor for the class. It sets the subclasses attributes as well as the weapons and armor they can equip.
        /// Their damaging attribute is also set.
        /// </summary>
        /// <param name="name"></param>
        public Rogue(string name) : base(name)
        {
            LevelAttributes = new(2, 6, 1);
            ValidWeaponTypes.AddRange(new[] { WeaponType.Dagger, WeaponType.Sword });
            ValidArmorTypes.AddRange(new[] { ArmorType.Leather, ArmorType.Mail });

            DamageAttribute = TotalAttributes().Dexterity;

        
        }

        /// <summary>
        /// Levels up the hero class with their correct stat increases
        /// </summary>
        public override void LevelUp()
        {
            Level += 1;
            LevelAttributes.Strength += 1;
            LevelAttributes.Dexterity += 4;
            LevelAttributes.Intelligence += 1;
        }
    }
}
