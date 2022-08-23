using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_11
{
    internal class Employee
    {
        private int _age;
        private double _salary;
        private string _name;


        public Employee(string name, int age, double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }


        public string Name
        {
            get
            {
                return _name;
            }

            set
            {

                value = value.Trim();

                if (String.IsNullOrWhiteSpace(value) || value.Length > 100)
                {
                    throw new IncorrectImputName();
                }

             
                _name = value;
            }
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

        public void Change(string name, int age, double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
    }
}
