using RPGHeroes.Hero.Subclasses;
using RPGHeroes.Items;

namespace RPGHeroes
{
    class Program
    {
        static void Main(string[] args)
        {

            //Weapon coolWeapon = new Weapon("The cool weapon", 1, Slot.Weapon, WeaponType.Axe, 2);
            //Armor armor1 = new Armor("testHat", 1, Slot.Head, new(1, 1, 1), ArmorType.Plate);
            Mage warrior = new Mage("testMage");
            //warrior.Equip(armor1);
            //warrior.Equip(coolWeapon);
            warrior.Display();
        }
    }


}