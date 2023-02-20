﻿using RPGHeroes.Items;

namespace RPGHeroes.Hero.Subclasses
{
    public class Mage : Hero
    {

        public Mage(string name) : base(name)
        {
            LevelAttributes = new(1, 1, 8);
            ValidWeaponTypes.AddRange(new[] { WeaponType.Wand, WeaponType.Staff });
            ValidArmorTypes.AddRange(new[] { ArmorType.Cloth });

            DamageAttribute = TotalAttributes().Intelligence;
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
