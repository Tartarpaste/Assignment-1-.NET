using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHeroes.Exceptions
{
    internal class InvalidLevelException : Exception
    {
        public InvalidLevelException() { }
        public InvalidLevelException(string message) : base(message) { }

        public override string Message => "Your level is not high enough to equip this item";

    }
}
