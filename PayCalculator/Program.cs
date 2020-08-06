using System;

namespace PayCalculator
{
    class Program
    {
        // Сотрудник у которого есть ставка по часам может работать сверхурочно
        // В случае сверхурочных часов - расчет идет по увеличенной ставке
        const int BASE_RATE = 5; // $ в час
        const int BASE_RATE_2 = 7; // $ в час
        
        const int EXTRA_RATE = 10; // $ в час
        const int EXTRA_RATE_2 = 12; // $ в час
        
        const int WORKING_DAY_HOURS = 8; // regular workday
        const int SHORT_DAY_HOURS = 4; // short workday

        static void Main(string[] args)
        {
            var workedHours = 12;

            Console.WriteLine(EmployeeWorked(workedHours)); // сумма в $
            Console.WriteLine(Employee2Worked(workedHours)); // сумма в $
        }

        static decimal EmployeeWorked(int hours)
        {
            var baseSalary = BASE_RATE * Math.Min(hours, WORKING_DAY_HOURS);
            var extraSalary = EXTRA_RATE * Math.Max(0, hours - WORKING_DAY_HOURS);

            return baseSalary + extraSalary;
        }

        static decimal Employee2Worked(int hours)
        {
            var baseSalary = BASE_RATE_2 * Math.Min(hours, WORKING_DAY_HOURS);
            var extraSalary = EXTRA_RATE_2 * Math.Max(0, hours - WORKING_DAY_HOURS);

            return baseSalary + extraSalary;
        }
    }
}
