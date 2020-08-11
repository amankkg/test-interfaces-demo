using System;

namespace PrintMoney
{
    class Program
    {
        static void Main(string[] args)
        {
            var som = new Som(5, 80.54m);
            var rouble = new Rouble(3, 77);
            var dollar = new Dollar(12);

            var money = new Money[] { som, rouble, dollar };

            foreach (var m in money) Console.WriteLine(m.Print());

            // Код должен вывести следующие строки на экран:
            // 5 сом
            // 3Р
            // $12

            foreach (var m in new IRate[] { som, rouble }) Console.WriteLine(m.Convert(10));
        }
    }

    interface IRate
    {
        decimal Rate { get; }
        decimal Convert(int usdAmount) => usdAmount * Rate;
    }

    abstract class Money
    {
        readonly protected int Value;
        protected Money(int value) => Value = value;
        public abstract string Print();
    }

    class Som : Money, IRate
    {
        public decimal Rate { get; private set; }

        public Som(int value) : base(value) { }
        public Som(int value, decimal rate) : base(value) => Rate = rate;

        public override string Print() => $"{Value} сом";
    }

    class Rouble : Money, IRate
    {
        public decimal Rate { get; private set; }

        public Rouble(int value) : base(value) { }
        public Rouble(int value, decimal rate) : base(value) => Rate = rate;

        public override string Print() => $"{Value}Р";
    }

    class Dollar : Money
    {
        public Dollar(int value) : base(value) { }

        public override string Print() => $"${Value}";
    }
}
