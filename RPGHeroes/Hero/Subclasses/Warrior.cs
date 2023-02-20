using RPGHeroes.Items;

namespace RPGHeroes.Hero.Subclasses
{
    public class Warrior : Hero
    {

        public Warrior(string name) : base(name)
        {
            LevelAttributes = new(5, 2, 1);
            ValidWeaponTypes.AddRange(new[] { WeaponType.Axe, WeaponType.Hammer, WeaponType.Sword });
            ValidArmorTypes.AddRange(new[] { ArmorType.Mail, ArmorType.Plate });

            DamageAttribute = TotalAttributes().Strength;

            
        }

        public override void LevelUp()
        {
            Level += 1;
            LevelAttributes.Strength += 3;
            LevelAttributes.Dexterity += 2;
            LevelAttributes.Intelligence += 1;
        }

    }
}
