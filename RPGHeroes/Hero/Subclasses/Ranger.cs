using RPGHeroes.Items;

namespace RPGHeroes.Hero.Subclasses
{
    public class Ranger : Hero
    {

        /// <summary>
        /// Constructor for the class. It sets the subclasses attributes as well as the weapons and armor they can equip.
        /// Their damaging attribute is also set.
        /// </summary>
        /// <param name="name"></param>
        public Ranger(string name) : base(name)
        {
            LevelAttributes = new(1, 7, 1);
            ValidWeaponTypes.AddRange(new[] { WeaponType.Bow });
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
            LevelAttributes.Dexterity += 5;
            LevelAttributes.Intelligence += 1;
        }
    }
}
