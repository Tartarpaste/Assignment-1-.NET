using RPGHeroes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Hero.Subclasses
{
    public class Warrior : Hero
    {

        public Warrior(string name) : base(name)
        {
            ValidWeaponTypes.AddRange(new[] { WeaponType.Axe, WeaponType.Hammer, WeaponType.Sword });
            ValidArmorTypes.AddRange(new[] { ArmorType.Mail, ArmorType.Plate });

            DamageAttribute = TotalAttributes().Strength;

            LevelAttributes = new(5, 2, 1);
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
