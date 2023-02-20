
namespace RPGHeroes.Hero
{
    public class HeroAttribute
    {
        public double Strength { get; set; }
        public double Dexterity { get; set; }
        public double Intelligence { get; set; }

        /// <summary>
        /// Constructor for the heroattribute class 
        /// </summary>
        /// <param name="strength"></param>
        /// <param name="dexterity"></param>
        /// <param name="intelligence"></param>
        public HeroAttribute(double strength, double dexterity, double intelligence)
        {
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
        }
    }
}
