using RPGHeroes.Items;

namespace RPGHeroesTests
{
    public class WeaponTest
    {

        [Fact]
        public void Weapon_CreateWeapon_ShouldReturnCorrectName() 
        {
            Weapon weapon = new Weapon("testWeapon", 1, Slot.Weapon, WeaponType.Dagger, 1);

            string expected = "testWeapon";
            string actual = weapon.Name;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Weapon_CreateWeapon_ShouldReturnCorrectLevelRequirement()
        {
            Weapon weapon = new Weapon("testWeapon", 1, Slot.Weapon, WeaponType.Dagger, 1);

            int expected = 1;
            int actual = weapon.RequiredLevel;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Weapon_CreateWeapon_ShouldReturnCorrectSlot()
        {
            Weapon weapon = new Weapon("testWeapon", 1, Slot.Weapon, WeaponType.Dagger, 1);

            Slot expected = Slot.Weapon;
            Slot actual = weapon.ItemSlot;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Weapon_CreateWeapon_ShouldReturnCorrectWeaponType()
        {
            Weapon weapon = new Weapon("testWeapon", 1, Slot.Weapon, WeaponType.Dagger, 1);

            WeaponType expected = WeaponType.Dagger;
            WeaponType actual = weapon.Type;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Weapon_CreateWeapon_ShouldReturnCorrectDamage()
        {
            Weapon weapon = new Weapon("testWeapon", 1, Slot.Weapon, WeaponType.Dagger, 1);

            double expected = 1;
            double actual = weapon.WeaponDamage;

            Assert.Equal(expected, actual);
        }
    }
}
