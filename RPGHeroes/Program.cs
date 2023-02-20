using RPGHeroes.Hero.Subclasses;
using RPGHeroes.Items;

namespace RPGHeroes
{
    class Program
    {
        static void Main(string[] args)
        {

            Weapon coolWeapon = new Weapon("The cool weapon", 1, Slot.Weapon, WeaponType.Staff, 2);
            Console.WriteLine("Hello, World!");
            Mage magus = new Mage("pavelius");
            magus.Equip(coolWeapon);
            magus.Display();
        }
    }
}