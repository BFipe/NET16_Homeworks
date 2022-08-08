using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_8
{
    internal interface ITaxi
    {
        abstract public void MakeRide(User user);
        abstract public double GetPriceOfRide();

    }
}
