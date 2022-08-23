using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_11
{
    internal class IncorrectImputName : Exception
    {
        public IncorrectImputName() : base($"Your name is empty data or have more than 100 characters in it") {}
    }
}
