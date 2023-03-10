using RPGHeroes.Hero;

namespace RPGHeroes.Items
{
    public enum WeaponType
    {
        Axe,
        Bow,
        Dagger,
        Hammer,
        Staff,
        Sword,
        Wand
    }
    public class Weapon : Item
    {
        public double WeaponDamage { get; set; }
        public WeaponType Type { get; set; }

        public Weapon(string name, int requiredLevel, Slot itemSlot, WeaponType type, double weaponDamage) : base(name, requiredLevel, itemSlot)
        {
            Type = type;
            WeaponDamage = weaponDamage;
            itemSlot = Slot.Weapon;
        }
    }
}
