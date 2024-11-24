/*
 * Да се напише програма, която въвежда n числа и ги сумира
 */

namespace loop_09
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double sum = 0;
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                double currentNumber = double.Parse(Console.ReadLine());
                sum += currentNumber;
            }
            Console.WriteLine(sum);
        }
    }
}