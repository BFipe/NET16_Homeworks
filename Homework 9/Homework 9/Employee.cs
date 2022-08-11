using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_9
{





    public class Employee
    {

        private int _age;
        private int _experience;

        public Employee(string name, int age, int experience, bool isHaveHigherEducation)
        {
            Age = age;
            Experience = experience;
            Name = name;
            IsHaveHigherEducation = isHaveHigherEducation;
        }
        public string Name { get; set; }
        public bool IsHaveHigherEducation { get; set; }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0)
                {
                    _age = 0;
                }
                else
                {
                    _age = value;
                }
            }
        }

        public int Experience
        {
            get
            {
                return _experience;
            }
            set
            {
                if (value < 0)
                {
                    _experience = 0;
                }
                else
                {
                    _experience = value;
                }
            }
        }


        #region Реализация через метод
        //public static void Salary(List<Employee> Employers)    
        //{
        //    int salary = 0;
        //    foreach (var employer in Employers)
        //    {
        //        if (employer.IsHaveHigherEducation)
        //        {

        //            salary = (employer.Experience + 1) * 1250;

        //        }
        //        else
        //        {
        //            salary = (employer.Experience + 1) * 1000;
        //        }

        //        Console.WriteLine($"{employer.Name} have salary {salary}");
        //    }
        //}
        #endregion

        public static int Salary(Employee employer)
        {
            if (employer.IsHaveHigherEducation)
            {
                return (employer.Experience + 1) * 1250;
            }
            else
            {
                return (employer.Experience + 1) * 1000;
            }
        }

        public static void ShowSalary(List<Employee> Employers, EmployerDelegate salaryDelegate)
        {
            int salary = 0;
            foreach (var employer in Employers)
            {
                salary = salaryDelegate(employer);
                Console.WriteLine($"{employer.Name} have salary {salary}");
            }
        }



    }
}
