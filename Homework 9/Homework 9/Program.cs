using System;
using System.Collections.Generic;

namespace Homework_9
{
    public delegate int EmployerDelegate(Employee employer);

    internal class Program
    {



        static void Main(string[] args)
        {
            EmployerDelegate salaryDelegate = new EmployerDelegate(Employee.Salary);
            Employee emp = new Employee("d", 2, 2, true);
            List<Employee> employers = new List<Employee>
            {
                new Employee("Ilya", 19, 1, false),
                new Employee("Egor", 29, 10, true),
                new Employee("Andrey", 22, 5, true),
                new Employee("Alisa", 24, 2, false),
                new Employee("Nastya", 19, 0, false),
                new Employee("German", 23, 4, true),
            };

            Employee.ShowSalary(employers, salaryDelegate);


            Console.WriteLine("---------------");
/////////////////////////////////////////////////////////////////////////////////////
            EmployerDelegate salaryAnotherCompany = SalaryForAnotherCompany;


            static int SalaryForAnotherCompany(Employee employer)
            {
                if (employer.IsHaveHigherEducation)
                {
                    return (employer.Experience + 1) * 1000;
                }
                else
                {
                    return (employer.Experience + 1) * 800;
                }
            }


            Employee.ShowSalary(employers, salaryAnotherCompany);
/////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("---------------");
/////////////////////////////////////////////////////////////////////////////////////
            EmployerDelegate anotherSalaryAnotherCompany = (Employee employer) =>
            {
                if (employer.IsHaveHigherEducation)
                {
                    return (employer.Experience + 1) * 12135;
                }
                else
                {
                    return (employer.Experience + 1) * 833;
                }
            };

            Employee.ShowSalary(employers, anotherSalaryAnotherCompany);
/////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
