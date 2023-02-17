using RPGHeroes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Hero.Subclasses
{
    public class Rogue : Hero
    {

        public Rogue(string name) : base(name)
        {
            LevelAttributes = new(2, 6, 1);
            ValidWeaponTypes.AddRange(new[] { WeaponType.Dagger, WeaponType.Sword });
            ValidArmorTypes.AddRange(new[] { ArmorType.Leather, ArmorType.Mail });

            DamageAttribute = TotalAttributes().Dexterity;

        
        }

        public override void LevelUp()
        {
            Level += 1;
            LevelAttributes.Strength += 1;
            LevelAttributes.Dexterity += 4;
            LevelAttributes.Intelligence += 1;
        }
    }
}
