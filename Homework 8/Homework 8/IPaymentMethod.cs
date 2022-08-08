using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_8
{
    public interface IPaymentMethod
    {
        abstract public bool IsPaymentPossible(double ammountOfMoney);
        abstract public void MakePayment(double ammountOfMoney);
        abstract public void AddMoney(double ammountOfMoney);
        abstract public void Balance();

    }
}
