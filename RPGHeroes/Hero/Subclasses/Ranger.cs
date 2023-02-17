using RPGHeroes.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Hero.Subclasses
{
    public class Ranger : Hero
    {

        public Ranger(string name) : base(name)
        {
            ValidWeaponTypes.AddRange(new[] { WeaponType.Bow });
            ValidArmorTypes.AddRange(new[] { ArmorType.Leather, ArmorType.Mail });


            LevelAttributes = new(1, 7, 1);


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
