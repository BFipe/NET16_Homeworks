using System;

namespace Homework_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Grisha", 20, 15.6);
            Employee employee2 = new Employee("Nikolai", 25, 15.6);
            Employee employee3 = new Employee("Petya", 47, 25.2);






            try
            {
                employee1.Change(19, 5);
                employee2.Change(" ", 35, 52);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

                var inner = ex.InnerException;

                while (inner != null)
                {
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine(inner.StackTrace);
                    inner = inner.InnerException;
                }
            }
            finally
            {
                Console.WriteLine($"Employee1 name - {employee1.Name}, age - {employee1.Age}, salary - {employee1.Salary}");
                Console.WriteLine($"Employee2 name - {employee2.Name}, age - {employee2.Age}, salary - {employee2.Salary}");
                Console.WriteLine($"Employee3 name - {employee3.Name}, age - {employee3.Age}, salary - {employee3.Salary}");
            }



        }
    }
}
