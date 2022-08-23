using System;

namespace Homework_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(20, 15.6);
            Employee employee2 = new Employee(25, 15.6);
            Employee employee3 = new Employee(47, 25.2);

            try
            {
                employee1.Change(19, 5);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

                var inner = ex.InnerException;

                while (inner != null)
                {
                    Console.WriteLine(inner.StackTrace);
                    inner = inner.InnerException;
                }
            }
            finally
            {
                Console.WriteLine($"Employee1 age - {employee1.Age}, salary - {employee1.Salary}");
            }


        
        }
    }
}
