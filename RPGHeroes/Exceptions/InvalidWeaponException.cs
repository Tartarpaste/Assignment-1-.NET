
namespace RPGHeroes.Exceptions
{
    public class InvalidWeaponException : Exception
    {
        public InvalidWeaponException() { }

        public InvalidWeaponException(string message) : base(message) { }

        public override string Message => "You cannot equip this weapon";
    }
}
