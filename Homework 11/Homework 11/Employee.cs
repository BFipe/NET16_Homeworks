using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_11
{
    internal class Employee
    {
        private int _age;
        private double _salary;

        public Employee(int age, double salary)
        {
            Age = age;
            Salary = salary;
        }

        public int Age
        {
            get 
            { 
                return _age;
            }

            set 
            {
                if (value < 18)
                {
                    throw new IncorrectImputData(value);
                } 
                _age = value;
            }
        }

  

        public double Salary
        {
            get 
            {
                return _salary; 
            }
            set
            {
                if (value < 0)
                {
                    throw new IncorrectImputData(value);
                }
                _salary = value;
            }
        }



        public void Change(int age, double salary)
        {
            Age = age;
            Salary = salary;
        }
    }
}
