/*
   Да се напише програма, която въвежда n числа
   • Проверява дали сумата на числата на четни
   позиции е равна на сумата на числата на нечетни
   позиции
   • При равенство печата "Yes" + сумата; иначе печата
   "No" + разликата (положително число).
 */

namespace loop_15
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int stars = int.Parse(Console.ReadLine()); // 3
            for (int row = 1; row <= stars; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }
        }
    }
}