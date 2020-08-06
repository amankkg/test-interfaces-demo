using System;

namespace PayCalculator
{
    class Program
    {
        // Сотрудник у которого есть ставка по часам может работать сверхурочно
        // В случае сверхурочных часов - расчет идет по увеличенной ставке
        static void Main(string[] args)
        {
            var regularSalary = new SalaryRate(7, 12);
            var chiefSalary = new SalaryRate(12, 15);

            var regularEmployee = new Employee(regularSalary);
            var ceo = new Employee(chiefSalary, 10);

            Console.WriteLine("Regular day, 12 hours worked");
            Console.WriteLine("Employee earned " + regularEmployee.Earned(12)); // сумма в $
            Console.WriteLine("CEO earned " + ceo.Earned(12)); // сумма в $

            Console.WriteLine("Holiday, 5 hours worked");
            Console.WriteLine("Employee earned " + regularEmployee.Earned(5, true));
            Console.WriteLine("CEO earned " + ceo.Earned(5, true));
        }
    }

    class Employee
    {
        readonly SalaryRate Rate;
        readonly int WorkdayLength;

        public Employee(SalaryRate rate, int workdayLength = 8)
        {
            Rate = rate;
            WorkdayLength = workdayLength;
        }

        public int Earned(int factualHours, bool isHoliday = false)
        {
            var workdayLength = isHoliday ? 0 : WorkdayLength;
            var baseSalary = Rate.Base * Math.Min(factualHours, workdayLength);
            var extraSalary = Rate.Extra * Math.Max(0, factualHours - workdayLength);

            return baseSalary + extraSalary;
        }
    }

    struct SalaryRate
    {
        public int Base { get; }
        public int Extra { get; }

        public SalaryRate(int @base, int extra)
        {
            Base = @base;
            Extra = extra;
        }
    }
}
