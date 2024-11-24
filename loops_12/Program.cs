/*
   Да се напише програма, която въвежда 2*n числа
   • Проверява дали сумите на левите n и десните n числа
   са равни
   • При равенство печата Yes + сумата; иначе печата No +
   разликата (изчислена като положително число)
 */

namespace loop_12
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Strat");
            int sumLeft = 0;
            for (int i = 0; i < number; i++)
            {
                int currentNumberLeft = int.Parse(Console.ReadLine());
                sumLeft += currentNumberLeft;
            }
            Console.WriteLine("mid");
            int sumRight = 0;
            for (int i = 0; i < number; i++)
            {
                int currentNumberRight = int.Parse(Console.ReadLine());
                sumRight += currentNumberRight;
            }
            Console.WriteLine("End");

            Console.WriteLine(sumLeft);
            Console.WriteLine(sumRight);
            if (sumLeft == sumRight)
            {
                Console.WriteLine($"Yes, sum = {sumLeft}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sumLeft - sumRight)}");
            }
        }
    }
}