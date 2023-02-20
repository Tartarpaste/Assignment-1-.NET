
namespace RPGHeroes.Exceptions
{
     public class InvalidArmorException : Exception
    {
        public InvalidArmorException() { }

        public InvalidArmorException(string message) : base(message) { }

        public override string Message => "You cannot equip this peice of armor";
    }
}
