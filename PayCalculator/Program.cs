using System;
using System.Collections.Generic;

namespace PayCalculator
{
    class Program
    {
        static List<Employee> employees = new List<Employee>();
        static List<Clerk> clerks = new List<Clerk>();

        static void Main(string[] args)
        {
            Initialize();

            WorkDay(clerks, -20);
            Report();
            WorkDay(employees, 5, true);
            Report();
        }

        static void Initialize()
        {
            var clerk1 = new Clerk();
            var clerk2 = new Clerk();

            employees.AddRange(new Employee[] {
                clerk1,
                clerk2,
                new Ceo()
            });

            clerks.Add(clerk1);
            clerks.Add(clerk2);
        }

        static void WorkDay(IEnumerable<Employee> workingEmployees, int hours, bool isHoliday = false)
        {
            Console.WriteLine($"\nWorked {hours} hour(s). Is holiday ? {isHoliday}");

            foreach (var employee in workingEmployees)
            {
                employee.Worked(hours, isHoliday);
            }
        }

        static void Report()
        {
            Console.WriteLine("\nSalary Report\n");

            foreach (var employee in employees)
            {
                Console.WriteLine($"\t{employee.Position}\tearned ${employee.Earned}");
            }
        }
    }
}
