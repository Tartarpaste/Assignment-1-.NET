using RPGHeroes.Exceptions;
using RPGHeroes.Hero.Subclasses;
using RPGHeroes.Items;

namespace RPGHeroesTests
{
    public class ErrorTest
    {
        [Fact]
        public void Hero_Equip_ShouldThrowInvalidArmorException()
        {
            Armor armor = new Armor("testArmor", 1, Slot.Head, new(2, 2, 2), ArmorType.Leather);
            Warrior warrior = new Warrior("testWarrior");


            Assert.Throws<InvalidArmorException>(() => warrior.Equip(armor));
        }

        [Fact]
        public void Hero_Equip_ShouldThrowInvalidLevelException()
        {
            Armor armor = new Armor("testArmor", 2, Slot.Head, new(2, 2, 2), ArmorType.Plate);
            Warrior warrior = new Warrior("testWarrior");

            Assert.Throws<InvalidLevelException>(() => warrior.Equip(armor));

        }

        [Fact]
        public void Hero_Equip_ShouldThrowInvalidWeaponException()
        {
            Weapon weapon = new Weapon("testWeapon", 1, Slot.Weapon, WeaponType.Bow, 2);
            Warrior warrior = new Warrior("testWarrior");

            Assert.Throws<InvalidWeaponException>(() => warrior.Equip(weapon));
        }
    }

}
