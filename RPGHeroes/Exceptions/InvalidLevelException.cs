
namespace RPGHeroes.Exceptions
{
    public class InvalidLevelException : Exception
    {
        public InvalidLevelException() { }
        public InvalidLevelException(string message) : base(message) { }

        public override string Message => "Your level is not high enough to equip this item";

    }
}
