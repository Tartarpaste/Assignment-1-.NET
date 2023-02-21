using RPGHeroes.Hero;
using RPGHeroes.Hero.Subclasses;
using RPGHeroes.Items;

namespace RPGHeroesTests
{
    public class HeroTest
    {
        [Fact]
        public void Hero_CreateHero_ShouldReturnCorrectName()
        {
            Ranger ranger = new Ranger("testRanger");

            string expected = "testRanger";
            string actual = ranger.Name;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Hero_CreateHero_ShouldReturnCorrectlevel()
        {
            Ranger ranger = new Ranger("testRanger");

            int expected = 1;
            int actual = ranger.Level;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Hero_CreateHero_ShouldReturnCorrectHeroAttribute()
        {
            Ranger ranger = new Ranger("testRanger");

            HeroAttribute expected = new HeroAttribute(1, 7, 1);
            HeroAttribute actual = ranger.LevelAttributes;

            Assert.Equivalent(expected, actual);
        }

        [Fact]
        public void Hero_LevelUp_ShouldReturnCorrectLevel()
        {
            Ranger ranger = new Ranger("testRanger");

            ranger.LevelUp();

            int expected = 2;
            int actual = ranger.Level;

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Mage_LevelUp_ShouldReturnAttributes()
        {
            Mage mage = new Mage("testMage");

            mage.LevelUp();

            HeroAttribute expected = new HeroAttribute(2, 2, 13);
            HeroAttribute actual = mage.LevelAttributes;

            Assert.Equivalent(expected, actual);
        }

        [Fact]
        public void Ranger_LevelUp_ShouldReturnAttributes()
        {
            Ranger ranger = new Ranger("testRanger");

            ranger.LevelUp();

            HeroAttribute expected = new HeroAttribute(2, 12, 2);
            HeroAttribute actual = ranger.LevelAttributes;

            Assert.Equivalent(expected, actual);
        }

        [Fact]
        public void Rogue_LevelUp_ShouldReturnAttributes()
        {
            Rogue rogue = new Rogue("testRogue");

            rogue.LevelUp();

            HeroAttribute expected = new HeroAttribute(3, 10, 2);
            HeroAttribute actual = rogue.LevelAttributes;

            Assert.Equivalent(expected, actual);
        }

        [Fact]
        public void Warrior_LevelUp_ShouldReturnAttributes()
        {
            Warrior warrior = new Warrior("testWarrior");

            warrior.LevelUp();

            HeroAttribute expected = new HeroAttribute(8, 4, 2);
            HeroAttribute actual = warrior.LevelAttributes;

            Assert.Equivalent(expected, actual);
        }

        [Fact]
        public void Hero_TotalAttributesWithNoEquipment_ShouldReturnCorrectAttributes()
        {
            Rogue rogue = new Rogue("testRogue");

            HeroAttribute expected = new HeroAttribute(2, 6, 1);
            HeroAttribute actual = rogue.TotalAttributes();

            Assert.Equivalent(expected, actual);
        }

        [Fact]
        public void Hero_TotalAttributesWithOneItemEquiped_ShouldReturnCorrectAttributes()
        {
            Rogue rogue = new Rogue("testRogue");

            Armor armor = new Armor("testHat", 1, Slot.Head, new(1, 1, 1), ArmorType.Leather);

            rogue.Equip(armor);

            HeroAttribute expected = new HeroAttribute(3, 7, 2);
            HeroAttribute actual = rogue.TotalAttributes();

            Assert.Equivalent(expected, actual);
        }

        [Fact]
        public void Hero_TotalAttributesWithTwoItemsEquiped_ShouldReturnCorrectAttributes()
        {
            Rogue rogue = new Rogue("testRogue");

            Armor armor1 = new Armor("testHat", 1, Slot.Head, new(1, 1, 1), ArmorType.Leather);

            Armor armor2 = new Armor("testJacket", 1, Slot.Body, new(1, 1, 1), ArmorType.Leather);

            rogue.Equip(armor1);
            rogue.Equip(armor2);

            HeroAttribute expected = new HeroAttribute(4, 8, 3);
            HeroAttribute actual = rogue.TotalAttributes();

            Assert.Equivalent(expected, actual);
        }

        [Fact]
        public void Hero_TotalAttributesWithOneItemSwappedOut_ShouldReturnCorrectAttributes()
        {
            Rogue rogue = new Rogue("testRogue");

            Armor armor1 = new Armor("testHat", 1, Slot.Head, new(1, 1, 1), ArmorType.Leather);

            Armor armor2 = new Armor("replacementHat", 1, Slot.Head, new(2, 2, 2), ArmorType.Leather);

            rogue.Equip(armor1);
            rogue.Equip(armor2);

            HeroAttribute expected = new HeroAttribute(4, 8, 3);
            HeroAttribute actual = rogue.TotalAttributes();

            Assert.Equivalent(expected, actual);
        }

        [Fact]
        public void Hero_DamageWithoutWeapon_ShouldReturnCorrectDouble()
        {
            Warrior warrior = new Warrior("testWarrior");

            double expected = 1.05;
            double actual = warrior.Damage();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Hero_DamageWithWeapon_ShouldReturnCorrectDouble()
        {
            Warrior warrior = new Warrior("testWarrior");

            Weapon weapon = new Weapon("testSword", 1, Slot.Weapon, WeaponType.Sword, 2);

            warrior.Equip(weapon);

            double expected = 2.1;
            double actual = warrior.Damage();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Hero_DamageWithSwappedWeapon_ShouldReturnCorrectDouble()
        {
            Warrior warrior = new Warrior("testWarrior");

            Weapon weapon1 = new Weapon("testSword", 1, Slot.Weapon, WeaponType.Sword, 2);

            Weapon weapon2 = new Weapon("testAxe", 1, Slot.Weapon, WeaponType.Axe, 4);

            warrior.Equip(weapon1);
            warrior.Equip(weapon2);

            double expected = 4.2;
            double actual = warrior.Damage();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Hero_DamageWithWeaponAndArmor_ShouldReturnCorrectDouble()
        {
            Warrior warrior = new Warrior("testWarrior");

            Armor armor = new Armor("testHat", 1, Slot.Head, new(1, 1, 1), ArmorType.Plate);

            Weapon weapon = new Weapon("testSword", 1, Slot.Weapon, WeaponType.Sword, 2);

            warrior.Equip(armor);
            warrior.Equip(weapon);

            double expected = 2.12;
            double actual = warrior.Damage();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Hero_Display_ShouldReturnTheCorrectString()
        {
            Mage mage = new Mage("testMage");

            string expected = "This heroes name is: testMage\r\ntestMage's class is: Mage\r\ntestMage's level is: 1\r\ntestMage's total strength is:1\r\ntestMage's total dexterity is:1\r\ntestMage's total intelligence is:8\r\ntestMage's damage is: 1,08\r\n";
            string actual = mage.Display();

            Assert.Equal(expected, actual);
        }



    }
}
