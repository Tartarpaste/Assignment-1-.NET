using RPGHeroes.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Hero.Subclasses
{
    public class Mage : Hero
    {

        public Mage(string name) : base(name)
        {
            ValidWeaponTypes.AddRange(new[] { WeaponType.Wand, WeaponType.Staff });
            ValidArmorTypes.AddRange(new[] { ArmorType.Cloth });

            DamageAttribute = TotalAttributes().Intelligence;

            LevelAttributes = new(1, 1, 8);

        }

        public override void LevelUp()
        {
            Level += 1;
            LevelAttributes.Strength += 1;
            LevelAttributes.Dexterity += 1;
            LevelAttributes.Intelligence += 5;
        }
    }
}
