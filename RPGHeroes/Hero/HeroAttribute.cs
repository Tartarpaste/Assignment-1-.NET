
namespace RPGHeroes.Hero
{
    public class HeroAttribute
    {
        public double Strength { get; set; }
        public double Dexterity { get; set; }
        public double Intelligence { get; set; }

        public HeroAttribute(double strength, double dexterity, double intelligence)
        {
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
        }
    }
}
