/*
   Да се напише програма, която въвежда n числа и
   намира най-малкото измежду тях
 */

namespace loop_11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int minNumber = int.MaxValue;
            for (int i = 0; i < number; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber < minNumber)
                {
                    minNumber = currentNumber;
                }
            }
            
            Console.WriteLine(minNumber);
        }
    }
}