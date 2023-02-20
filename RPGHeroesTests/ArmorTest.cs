using RPGHeroes.Hero;
using RPGHeroes.Items;

namespace RPGHeroesTests
{
    
    public class ArmorTest
    {
        [Fact]
        public void Armor_CreateArmor_ShouldReturnCorrectName()
        {
            Armor armor = new Armor("TordArmor", 1, Slot.Head, new(2, 2, 2), ArmorType.Leather);
            
            string expected = "TordArmor";
            string actual = armor.Name;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Armor_CreateArmor_ShouldReturnCorrectRequiredLevel()
        {
            Armor armor = new Armor("TordArmor", 1, Slot.Head, new(2, 2, 2), ArmorType.Leather);

            int expected = 1;
            int actual = armor.RequiredLevel;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Armor_CreateArmor_ShouldReturnCorrectSlot()
        {
            Armor armor = new Armor("TordArmor", 1, Slot.Head, new(2, 2, 2), ArmorType.Leather);

            Slot expected = Slot.Head;
            Slot actual = armor.ItemSlot;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Armor_CreateArmor_ShouldReturnCorrectArmorAttriburtes()
        {
            Armor armor = new Armor("TordArmor", 1, Slot.Head, new(2, 2, 2), ArmorType.Leather);

            HeroAttribute expected = new HeroAttribute(2, 2, 2);
            HeroAttribute actual = armor.ArmorAttribute;

            Assert.Equivalent(expected, actual);
        }

        [Fact]
        public void Armor_CreateArmor_ShouldReturnCorrectArmorType()
        {
            Armor armor = new Armor("TordArmor", 1, Slot.Head, new(2, 2, 2), ArmorType.Leather);

            ArmorType expected = ArmorType.Leather;
            ArmorType actual = armor.Type;

            Assert.Equal(expected, actual);
        }
    }
}
