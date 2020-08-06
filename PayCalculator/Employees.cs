using System;

namespace PayCalculator
{
    abstract class Employee
    {
        private readonly SalaryRate Rate;
        private readonly int WorkdayLength;
        public abstract string Position { get; }
        public int Earned { get; private set; } = 0;
        public int TotalHours { get; private set; } = 0;

        protected Employee(SalaryRate rate, int workdayLength = 8)
        {
            Rate = rate;
            WorkdayLength = workdayLength;
        }

        public virtual void Worked(int factualHours, bool isHoliday = false)
        {
            var workdayLength = isHoliday ? 0 : WorkdayLength;
            var baseSalary = Rate.Base * Math.Min(factualHours, workdayLength);
            var extraSalary = Rate.Extra * Math.Max(0, factualHours - workdayLength);

            TotalHours += factualHours;
            Earned += baseSalary + extraSalary;
        }
    }

    class Clerk : Employee
    {
        public override string Position => "Clerk";

        public Clerk() : base(new SalaryRate(7, 12))
        {
        }

        public string Department { get; } = "Finance";
    }

    class Ceo : Employee
    {
        public override string Position => "CEO";

        public Ceo() : base(new SalaryRate(12, 15), 6)
        {
        }

        public string Department { get; } = "Finance";
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
