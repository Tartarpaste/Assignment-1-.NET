using RPGHeroes.Items;

namespace RPGHeroes.Hero.Subclasses
{
    public class Ranger : Hero
    {

        public Ranger(string name) : base(name)
        {
            LevelAttributes = new(1, 7, 1);
            ValidWeaponTypes.AddRange(new[] { WeaponType.Bow });
            ValidArmorTypes.AddRange(new[] { ArmorType.Leather, ArmorType.Mail });

            DamageAttribute = TotalAttributes().Dexterity;


        }

        public override void LevelUp()
        {
            Level += 1;
            LevelAttributes.Strength += 1;
            LevelAttributes.Dexterity += 5;
            LevelAttributes.Intelligence += 1;
        }
    }
}
