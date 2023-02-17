using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Exceptions
{
    internal class InvalidWeaponException : Exception
    {
        public InvalidWeaponException() { }

        public InvalidWeaponException(string message) : base(message) { }

        public override string Message => "You cannot equip this weapon";
    }
}
