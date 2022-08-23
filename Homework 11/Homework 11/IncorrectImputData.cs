using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_11
{

    internal class IncorrectImputData : Exception
    {
        public IncorrectImputData() {}
        public IncorrectImputData(int value) : base($"Incorrect imput! You entered {value}, but your age must be >= 18.")
        {
            
        }
        public IncorrectImputData(double value) : base($"Incorrect imput!  You entered {value}, but your salary must be >= 0.")
        {

        }
    }
}
