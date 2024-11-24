/*
 Да се напише програма, която въвежда n числа
   • Проверява дали сумата на числата на четни
   позиции е равна на сумата на числата на нечетни
   позиции
   • При равенство печата "Yes" + сумата; иначе печата
   "No" + разликата (положително число).
 */

namespace loop_13
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOdd = 0;
            int sumEven = 0;
            for (int i = 1; i <= n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumEven += currentNumber;
                }
                else
                {
                    sumOdd += currentNumber;
                }
            }

            if (sumEven == sumOdd)
            {
                Console.WriteLine($"Yes\nsum = {sumEven}");
            }
            else
            {
                Console.WriteLine($"No\ndiff = {Math.Abs(sumEven - sumOdd)}");
            }
        }
    }
}