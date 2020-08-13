namespace FizzBuzzClassLibrary
{
    public class EvenOdd
    {
        public static bool? Check(int number)
        {
            if (number == 0) return null;

            if (number % 2 == 0) return true;

            return false;
        }
    }
}
