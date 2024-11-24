/*
 Да се напише програма, която въвежда n числа и
 намира най-голямото измежду тях
 */
namespace loop_10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            for (int i = 0; i < number; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (maxNumber < currentNumber)
                {
                    maxNumber = currentNumber;
                }
            }

            Console.WriteLine(maxNumber);
        }
    }
}