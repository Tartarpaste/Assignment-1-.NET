using RPGHeroes.Items;

namespace RPGHeroes.Hero.Subclasses
{
    public class Mage : Hero
    {

        /// <summary>
        /// Constructor for the class. It sets the subclasses attributes as well as the weapons and armor they can equip.
        /// Their damaging attribute is also set.
        /// </summary>
        /// <param name="name"></param>
        public Mage(string name) : base(name)
        {
            LevelAttributes = new(1, 1, 8);
            ValidWeaponTypes.AddRange(new[] { WeaponType.Wand, WeaponType.Staff });
            ValidArmorTypes.AddRange(new[] { ArmorType.Cloth });

            DamageAttribute = TotalAttributes().Intelligence;
        }

        /// <summary>
        /// Levels up the hero class with their correct stat increases
        /// </summary>
        public override void LevelUp()
        {
            Level += 1;
            LevelAttributes.Strength += 1;
            LevelAttributes.Dexterity += 1;
            LevelAttributes.Intelligence += 5;
        }
    }
}
